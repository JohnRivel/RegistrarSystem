Public Class LoginForm

    Private Const MaxAttempts As Integer = 3
    Private Const LockSeconds As Integer = 30

    Private failedAttempts As Integer
    Private lockRemaining As Integer

    Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtUser.Focus()
    End Sub

    Private Sub LoginForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Using p As New Pen(Color.FromArgb(76, 81, 104))
            e.Graphics.DrawRectangle(p, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1)
        End Using
    End Sub

    Private Sub Panels_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBrand.MouseDown, pnlRight.MouseDown
        If e.Button = MouseButtons.Left Then DragWindow(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        txtPass.UseSystemPasswordChar = Not chkShow.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DoLogin()
    End Sub

    Private Sub DoLogin()
        lblMsg.Text = ""
        Dim username = txtUser.Text.Trim()

        If username = "" Then
            ShowMessage("Please enter your username.", txtUser)
            Return
        End If
        If txtPass.Text = "" Then
            ShowMessage("Please enter your password.", txtPass)
            Return
        End If

        Cursor = Cursors.WaitCursor
        Try
            Dim dt = Db.GetTable(
                "SELECT UserID, Username, FullName, Role, Status FROM tblusers " &
                "WHERE Username = @u AND Password = @p LIMIT 1",
                Db.P("@u", username), Db.P("@p", HashPassword(txtPass.Text)))

            If dt.Rows.Count = 0 Then
                failedAttempts += 1
                txtPass.Clear()
                If failedAttempts >= MaxAttempts Then
                    StartLockout()
                Else
                    ShowMessage($"Invalid username or password. ({MaxAttempts - failedAttempts} attempt(s) left)", txtPass)
                End If
                Return
            End If

            Dim row = dt.Rows(0)
            If Db.ToStr(row("Status")) <> "Active" Then
                ShowMessage("This account is deactivated. Contact the administrator.", txtUser)
                Return
            End If

            Session.UserID = Db.ToInt(row("UserID"))
            Session.Username = Db.ToStr(row("Username"))
            Session.FullName = Db.ToStr(row("FullName"))
            Session.Role = Db.ToStr(row("Role"))
            DialogResult = DialogResult.OK
        Catch ex As Exception
            Ui.ShowError(ex)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ShowMessage(message As String, focusOn As Control)
        lblMsg.Text = message
        focusOn.Focus()
    End Sub

    Private Sub StartLockout()
        lockRemaining = LockSeconds
        btnLogin.Enabled = False
        txtUser.Enabled = False
        txtPass.Enabled = False
        lblMsg.Text = $"Too many failed attempts. Try again in {lockRemaining}s."
        lockTimer.Start()
    End Sub

    Private Sub lockTimer_Tick(sender As Object, e As EventArgs) Handles lockTimer.Tick
        lockRemaining -= 1
        If lockRemaining > 0 Then
            lblMsg.Text = $"Too many failed attempts. Try again in {lockRemaining}s."
            Return
        End If
        lockTimer.Stop()
        failedAttempts = 0
        btnLogin.Enabled = True
        txtUser.Enabled = True
        txtPass.Enabled = True
        lblMsg.Text = ""
        txtPass.Focus()
    End Sub

End Class
