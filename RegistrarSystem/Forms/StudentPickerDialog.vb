Imports System.ComponentModel

Public Class StudentPickerDialog

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property SelectedStudentId As String

    Private Sub StudentPickerDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        txtSearch.Select()
    End Sub

    Private Sub LoadData()
        Try
            Dim dt = Db.GetTable(
                "SELECT StudentID AS `Student ID`, CONCAT_WS(' ', FirstName, NULLIF(MiddleName, ''), LastName) AS `Name`, " &
                "       Course, YearLevel AS `Year Level`, Section " &
                "  FROM tblstudents " &
                " WHERE Status = 'Active' " &
                "   AND (StudentID LIKE @q OR LRN LIKE @q OR LastName LIKE @q OR FirstName LIKE @q " &
                "        OR CONCAT(FirstName, ' ', LastName) LIKE @q OR CONCAT(LastName, ', ', FirstName) LIKE @q) " &
                " ORDER BY StudentID",
                Db.P("@q", "%" & txtSearch.Text.Trim() & "%"))
            BindGrid(grid, dt)
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

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        PickSelected()
    End Sub

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.RowIndex >= 0 Then PickSelected()
    End Sub

    Private Sub PickSelected()
        Dim v = SelectedValue(grid, "Student ID")
        If v Is Nothing Then
            Warn("Please select a student.")
            Return
        End If
        SelectedStudentId = Db.ToStr(v)
        DialogResult = DialogResult.OK
    End Sub

End Class
