Imports MySql.Data.MySqlClient

Public Class StudentsForm

    Private isLoaded As Boolean

    Private Sub StudentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.SelectedIndex = 0
        ColorizeColumns(grid, "Status")

        If Not Session.IsAdmin Then
            btnAdd.Visible = False
            btnEdit.Visible = False
            btnToggle.Visible = False
            btnDelete.Visible = False
            lblSubtitle.Text = "Search and view student records"
        End If

        isLoaded = True
        LoadData()
        txtSearch.Select()
    End Sub

    Private Sub LoadData()
        Try
            Dim keep = SelectedId()
            Dim dt = Db.GetTable(
                "SELECT StudentID AS `Student ID`, LRN, FirstName AS `First Name`, MiddleName AS `Middle Name`, LastName AS `Last Name`, " &
                "       Course, YearLevel AS `Year Level`, Section, " &
                "       ContactNo AS `Contact No.`, Status " &
                "  FROM tblstudents " &
                " WHERE (StudentID LIKE @q OR LRN LIKE @q OR LastName LIKE @q OR FirstName LIKE @q " &
                "        OR CONCAT(FirstName, ' ', LastName) LIKE @q OR CONCAT(LastName, ', ', FirstName) LIKE @q " &
                "        OR Course LIKE @q) " &
                "   AND (@st = 'All' OR Status = @st) " &
                " ORDER BY StudentID",
                Db.P("@q", "%" & txtSearch.Text.Trim() & "%"),
                Db.P("@st", cboStatus.Text))
            BindGrid(grid, dt)
            SelectRow(grid, "Student ID", keep)
            lblCount.Text = $"{dt.Rows.Count} student(s) found"
            UpdateToggleText()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchTimer.Stop()
        searchTimer.Start()
    End Sub

    Private Sub searchTimer_Tick(sender As Object, e As EventArgs) Handles searchTimer.Tick
        searchTimer.Stop()
        LoadData()
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        If isLoaded Then LoadData()
    End Sub

    Private Function SelectedId() As String
        Dim v = SelectedValue(grid, "Student ID")
        Return If(v Is Nothing, Nothing, Db.ToStr(v))
    End Function

    Private Function RequireSelection() As String
        Dim id = SelectedId()
        If id Is Nothing Then Warn("Please select a student from the list first.")
        Return id
    End Function

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        UpdateToggleText()
    End Sub

    Private Sub UpdateToggleText()
        Dim st = Db.ToStr(SelectedValue(grid, "Status"))
        btnToggle.Text = If(st = "Inactive", " Activate", " Deactivate")
        btnToggle.BackColor = If(st = "Inactive", ColGreen, ColOrange)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenEditor(Nothing)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id = RequireSelection()
        If id IsNot Nothing Then OpenEditor(id)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim id = RequireSelection()
        If id IsNot Nothing Then OpenEditor(id, viewOnly:=True)
    End Sub

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.RowIndex >= 0 Then OpenEditor(SelectedId(), viewOnly:=Not Session.IsAdmin)
    End Sub

    Private Sub OpenEditor(studentId As String, Optional viewOnly As Boolean = False)
        Using dlg As New StudentEditorDialog(studentId, viewOnly)
            If dlg.ShowDialog(MainForm.Current) = DialogResult.OK Then
                LoadData()
                SelectRow(grid, "Student ID", dlg.StudentId)
            End If
        End Using
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        ToggleStatus()
    End Sub

    Private Sub ToggleStatus()
        Dim id = RequireSelection()
        If id Is Nothing Then Return
        Dim newStatus = If(Db.ToStr(SelectedValue(grid, "Status")) = "Active", "Inactive", "Active")
        Dim name = $"{SelectedValue(grid, "First Name")} {SelectedValue(grid, "Last Name")}"
        If Not Confirm($"Set student {id} ({name}) to {newStatus}?") Then Return
        Try
            Db.Execute("UPDATE tblstudents SET Status = @s WHERE StudentID = @id", Db.P("@s", newStatus), Db.P("@id", id))
            LoadData()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteStudent()
    End Sub

    Private Sub DeleteStudent()
        Dim id = RequireSelection()
        If id Is Nothing Then Return
        If Not Confirm($"Permanently delete student {id}?{vbCrLf}{vbCrLf}This cannot be undone.", "Delete Student") Then Return
        Try
            Db.Execute("DELETE FROM tblstudents WHERE StudentID = @id", Db.P("@id", id))
            LoadData()
        Catch ex As MySqlException When ex.Number = Db.ErrRowReferenced
            Warn("This student already has document requests, so the record cannot be deleted." & vbCrLf &
                 "Use Deactivate instead.")
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

End Class
