Public Class DocumentsForm

    Private isLoaded As Boolean

    Private Sub DocumentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.SelectedIndex = 0
        ColorizeColumns(grid, "Status")
        isLoaded = True
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim keep = SelectedValue(grid, "Document ID")
            Dim dt = Db.GetTable(
                "SELECT DocumentID AS `Document ID`, DocumentName AS `Document Name`, Description, Fee, Status " &
                "  FROM tbldocuments " &
                " WHERE (DocumentName LIKE @q OR Description LIKE @q) AND (@st = 'All' OR Status = @st) " &
                " ORDER BY DocumentName",
                Db.P("@q", "%" & txtSearch.Text.Trim() & "%"), Db.P("@st", cboStatus.Text))
            BindGrid(grid, dt)
            SelectRow(grid, "Document ID", keep)
            lblCount.Text = $"{dt.Rows.Count} document(s)"
            UpdateToggleText()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadData()
        End If
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        If isLoaded Then LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadData()
    End Sub

    Private Function SelectedId() As Integer
        Return Db.ToInt(SelectedValue(grid, "Document ID"))
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
        OpenEditor(0)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If SelectedId() = 0 Then
            Warn("Please select a document first.")
        Else
            OpenEditor(SelectedId())
        End If
    End Sub

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.RowIndex >= 0 Then OpenEditor(SelectedId())
    End Sub

    Private Sub OpenEditor(documentId As Integer)
        Using dlg As New DocumentEditorDialog(documentId)
            If dlg.ShowDialog(MainForm.Current) = DialogResult.OK Then
                LoadData()
                SelectRow(grid, "Document ID", dlg.DocumentId)
            End If
        End Using
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        Dim id = SelectedId()
        If id = 0 Then
            Warn("Please select a document first.")
            Return
        End If
        Dim newStatus = If(Db.ToStr(SelectedValue(grid, "Status")) = "Active", "Inactive", "Active")
        Dim extra = If(newStatus = "Inactive", vbCrLf & "Inactive documents can no longer be selected in new requests.", "")
        If Not Confirm($"Set '{SelectedValue(grid, "Document Name")}' to {newStatus}?{extra}") Then Return
        Try
            Db.Execute("UPDATE tbldocuments SET Status = @s WHERE DocumentID = @id", Db.P("@s", newStatus), Db.P("@id", id))
            LoadData()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

End Class
