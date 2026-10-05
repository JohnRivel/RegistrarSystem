Imports MySql.Data.MySqlClient

Public Class UsersForm

    Private headAdminId As Integer

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorizeColumns(grid, "Status")
        LoadData()
        btnDelete.Visible = Session.UserID = headAdminId
    End Sub

    Private Sub LoadData()
        Try
            Dim keep = SelectedValue(grid, "User ID")
            ' The head administrator is the first administrator account that was created.
            headAdminId = Db.ToInt(Db.Scalar("SELECT MIN(UserID) FROM tblusers WHERE Role = @r", Db.P("@r", RoleAdmin)))
            Dim dt = Db.GetTable(
                "SELECT UserID AS `User ID`, Username, FullName AS `Full Name`, " &
                "       IF(UserID = @head, 'Head Administrator', Role) AS Role, Status " &
                "  FROM tblusers ORDER BY UserID <> @head, Role, FullName",
                Db.P("@head", headAdminId))
            BindGrid(grid, dt)
            SelectRow(grid, "User ID", keep)
            lblCount.Text = $"{dt.Rows.Count} user(s)"
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
        UpdateToggleButton()
    End Sub

    Private Function SelectedId() As Integer
        Return Db.ToInt(SelectedValue(grid, "User ID"))
    End Function

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        UpdateToggleButton()
    End Sub

    Private Sub UpdateToggleButton()
        Dim inactive = Db.ToStr(SelectedValue(grid, "Status")) = "Inactive"
        btnToggle.Text = If(inactive, " Activate", " Deactivate")
        btnToggle.BackColor = If(inactive, ColGreen, ColOrange)
        btnToggle.FlatAppearance.MouseOverBackColor = Blend(btnToggle.BackColor, Color.White, 0.15)
        btnToggle.Image = If(inactive, My.Resources.btn_check, My.Resources.btn_block)
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
        If id = headAdminId AndAlso newStatus = "Inactive" Then
            Warn("The head administrator account cannot be deactivated.")
            Return
        End If
        Dim action = If(newStatus = "Active", "Activate", "Deactivate")
        Dim extra = If(newStatus = "Active", "They will be able to log in again.", "They will no longer be able to log in.")
        If Not Confirm($"{action} user '{SelectedValue(grid, "Username")}'?{vbCrLf}{vbCrLf}{extra}", $"{action} Account") Then Return
        Try
            Db.Execute("UPDATE tblusers SET Status = @s WHERE UserID = @id", Db.P("@s", newStatus), Db.P("@id", id))
            LoadData()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id = SelectedId()
        If id = 0 Then
            Warn("Please select a user first.")
            Return
        End If
        If Session.UserID <> headAdminId Then
            Warn("Only the head administrator can delete accounts.")
            Return
        End If
        If id = headAdminId Then
            Warn("The head administrator account cannot be deleted.")
            Return
        End If
        Dim username = SelectedValue(grid, "Username")
        Dim role = Db.ToStr(SelectedValue(grid, "Role"))
        If Not Confirm($"Permanently delete the {role} account '{username}'?{vbCrLf}{vbCrLf}This cannot be undone.", "Delete Account") Then Return
        Try
            Db.Execute("DELETE FROM tblusers WHERE UserID = @id AND UserID <> @head", Db.P("@id", id), Db.P("@head", headAdminId))
            LoadData()
        Catch ex As MySqlException When ex.Number = Db.ErrRowReferenced
            Warn("This account has already processed document requests, so it cannot be deleted." & vbCrLf &
                 "Use Deactivate instead.")
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

End Class
