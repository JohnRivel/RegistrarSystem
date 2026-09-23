Public Class UsersForm

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorizeColumns(grid, "Status")
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim keep = SelectedValue(grid, "User ID")
            Dim dt = Db.GetTable(
                "SELECT UserID AS `User ID`, Username, FullName AS `Full Name`, Role, Status " &
                "  FROM tblusers ORDER BY Role, FullName")
            BindGrid(grid, dt)
            SelectRow(grid, "User ID", keep)
            lblCount.Text = $"{dt.Rows.Count} user(s)"
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Function SelectedId() As Integer
        Return Db.ToInt(SelectedValue(grid, "User ID"))
    End Function

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        Dim st = Db.ToStr(SelectedValue(grid, "Status"))
        btnToggle.Text = If(st = "Inactive", " Activate", " Deactivate")
        btnToggle.BackColor = If(st = "Inactive", ColGreen, ColOrange)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenEditor(0)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If SelectedId() = 0 Then
            Warn("Please select a user first.")
        Else
            OpenEditor(SelectedId())
        End If
    End Sub

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.RowIndex >= 0 Then OpenEditor(SelectedId())
    End Sub

    Private Sub OpenEditor(userId As Integer)
        Using dlg As New UserEditorDialog(userId)
            If dlg.ShowDialog(MainForm.Current) = DialogResult.OK Then
                LoadData()
                SelectRow(grid, "User ID", dlg.UserId)
            End If
        End Using
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        Dim id = SelectedId()
        If id = 0 Then
            Warn("Please select a user first.")
            Return
        End If
        If id = Session.UserID Then
            Warn("You cannot deactivate your own account.")
            Return
        End If
        Dim newStatus = If(Db.ToStr(SelectedValue(grid, "Status")) = "Active", "Inactive", "Active")
        If Not Confirm($"Set user '{SelectedValue(grid, "Username")}' to {newStatus}?") Then Return
        Try
            Db.Execute("UPDATE tblusers SET Status = @s WHERE UserID = @id", Db.P("@s", newStatus), Db.P("@id", id))
            LoadData()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

End Class
