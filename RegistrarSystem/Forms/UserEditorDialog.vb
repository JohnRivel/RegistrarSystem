Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class UserEditorDialog

    Private Const MinPasswordLength As Integer = 6

    Private ReadOnly isNew As Boolean
    Private ReadOnly isSelf As Boolean

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property UserId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        Me.UserId = userId
        isNew = userId = 0
        isSelf = userId = Session.UserID
    End Sub

    Private Sub UserEditorDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = If(isNew, "Add User", "Edit User")
        lblHeading.Text = Text
        cboRole.SelectedIndex = 0
        cboStatus.SelectedIndex = 0

        If Not isNew Then
            lblPassCap.Text = "New Password"
            txtPass.PlaceholderText = "leave blank to keep current"
            LoadUser()
        End If
        If isSelf Then
            cboRole.Enabled = False
            cboStatus.Enabled = False
            lblSelfNote.Visible = True
        End If
    End Sub

    Private Sub LoadUser()
        Try
            Dim dt = Db.GetTable("SELECT Username, FullName, Role, Status FROM tblusers WHERE UserID = @id", Db.P("@id", UserId))
            If dt.Rows.Count = 0 Then Return
            Dim r = dt.Rows(0)
            txtUsername.Text = Db.ToStr(r("Username"))
            txtFullName.Text = Db.ToStr(r("FullName"))
            cboRole.SelectedItem = Db.ToStr(r("Role"))
            cboStatus.SelectedItem = Db.ToStr(r("Status"))
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveUser()
    End Sub

    Private Sub SaveUser()
        Dim username = txtUsername.Text.Trim()
        Dim fullName = txtFullName.Text.Trim()

        If Not Regex.IsMatch(username, "^[A-Za-z0-9_]{3,30}$") Then
            Warn("Username must be 3-30 characters (letters, numbers, underscore only).")
            txtUsername.Focus()
            Return
        End If
        If fullName.Length < 3 Then
            Warn("Please enter the user's full name.")
            txtFullName.Focus()
            Return
        End If
        Dim changePassword = isNew OrElse txtPass.Text <> ""
        If changePassword Then
            If txtPass.Text.Length < MinPasswordLength Then
                Warn($"Password must be at least {MinPasswordLength} characters.")
                txtPass.Focus()
                Return
            End If
            If txtPass.Text <> txtConfirm.Text Then
                Warn("Password and Confirm Password do not match.")
                txtConfirm.Focus()
                Return
            End If
        End If

        Try
            If Db.Exists("SELECT COUNT(*) FROM tblusers WHERE Username = @u AND UserID <> @id",
                         Db.P("@u", username), Db.P("@id", UserId)) Then
                Warn("This username is already taken.")
                txtUsername.Focus()
                Return
            End If

            If Not isNew AndAlso (cboRole.Text <> RoleAdmin OrElse cboStatus.Text <> "Active") Then
                Dim otherAdmins = Db.ToInt(Db.Scalar(
                    "SELECT COUNT(*) FROM tblusers WHERE Role = @r AND Status = 'Active' AND UserID <> @id",
                    Db.P("@r", RoleAdmin), Db.P("@id", UserId)))
                Dim wasAdmin = Db.Exists("SELECT COUNT(*) FROM tblusers WHERE UserID = @id AND Role = @r AND Status = 'Active'",
                                         Db.P("@id", UserId), Db.P("@r", RoleAdmin))
                If wasAdmin AndAlso otherAdmins = 0 Then
                    Warn("This is the only active Administrator. Create another Administrator first.")
                    Return
                End If
            End If

            If isNew Then
                Using cn = Db.OpenConnection()
                    Using cmd As New MySqlCommand(
                        "INSERT INTO tblusers (Username, Password, FullName, Role, Status) VALUES (@u, @p, @n, @r, @s)", cn)
                        cmd.Parameters.AddRange({Db.P("@u", username), Db.P("@p", HashPassword(txtPass.Text)),
                                                 Db.P("@n", fullName), Db.P("@r", cboRole.Text), Db.P("@s", cboStatus.Text)})
                        cmd.ExecuteNonQuery()
                        UserId = CInt(cmd.LastInsertedId)
                    End Using
                End Using
            Else
                Db.Execute("UPDATE tblusers SET Username = @u, FullName = @n, Role = @r, Status = @s WHERE UserID = @id",
                           Db.P("@u", username), Db.P("@n", fullName), Db.P("@r", cboRole.Text),
                           Db.P("@s", cboStatus.Text), Db.P("@id", UserId))
                If changePassword Then
                    Db.Execute("UPDATE tblusers SET Password = @p WHERE UserID = @id",
                               Db.P("@p", HashPassword(txtPass.Text)), Db.P("@id", UserId))
                End If
            End If

            If isSelf Then
                Session.Username = username
                Session.FullName = fullName
            End If
            Info(If(isNew, "User account created.", "User account updated."))
            DialogResult = DialogResult.OK
        Catch ex As MySqlException When ex.Number = Db.ErrDuplicateKey
            Warn("This username is already taken.")
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

End Class
