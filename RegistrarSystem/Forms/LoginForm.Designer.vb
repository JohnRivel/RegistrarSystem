<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlBrand = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblBrandTitle = New System.Windows.Forms.Label()
        Me.lblBrandSubtitle = New System.Windows.Forms.Label()
        Me.lblBrandText = New System.Windows.Forms.Label()
        Me.pnlStripe = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBrand.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()
        Me.pnlBrand.BackColor = System.Drawing.Color.FromArgb(31, 33, 45)
        Me.pnlBrand.Controls.Add(Me.lblLogo)
        Me.pnlBrand.Controls.Add(Me.lblBrandTitle)
        Me.pnlBrand.Controls.Add(Me.lblBrandSubtitle)
        Me.pnlBrand.Controls.Add(Me.lblBrandText)
        Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(390, 500)
        Me.pnlBrand.TabIndex = 0
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Segoe MDL2 Assets", 54.0!)
        Me.lblLogo.ForeColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblLogo.Location = New System.Drawing.Point(40, 70)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(96, 72)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = ""
        Me.lblBrandTitle.AutoSize = True
        Me.lblBrandTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 28.0!)
        Me.lblBrandTitle.Location = New System.Drawing.Point(40, 170)
        Me.lblBrandTitle.Name = "lblBrandTitle"
        Me.lblBrandTitle.Size = New System.Drawing.Size(163, 51)
        Me.lblBrandTitle.TabIndex = 1
        Me.lblBrandTitle.Text = "Registrar"
        Me.lblBrandSubtitle.AutoSize = True
        Me.lblBrandSubtitle.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblBrandSubtitle.Location = New System.Drawing.Point(44, 222)
        Me.lblBrandSubtitle.Name = "lblBrandSubtitle"
        Me.lblBrandSubtitle.Size = New System.Drawing.Size(253, 30)
        Me.lblBrandSubtitle.TabIndex = 2
        Me.lblBrandSubtitle.Text = "Document Request System"
        Me.lblBrandText.AutoSize = True
        Me.lblBrandText.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblBrandText.Location = New System.Drawing.Point(46, 272)
        Me.lblBrandText.Name = "lblBrandText"
        Me.lblBrandText.Size = New System.Drawing.Size(253, 38)
        Me.lblBrandText.TabIndex = 3
        Me.lblBrandText.Text = "Record, track, pay and release official" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "school documents in one place."
        Me.pnlStripe.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.pnlStripe.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlStripe.Location = New System.Drawing.Point(390, 0)
        Me.pnlStripe.Name = "pnlStripe"
        Me.pnlStripe.Size = New System.Drawing.Size(5, 500)
        Me.pnlStripe.TabIndex = 1
        Me.pnlRight.Controls.Add(Me.btnClose)
        Me.pnlRight.Controls.Add(Me.lblWelcome)
        Me.pnlRight.Controls.Add(Me.lblSignIn)
        Me.pnlRight.Controls.Add(Me.lblUsername)
        Me.pnlRight.Controls.Add(Me.txtUser)
        Me.pnlRight.Controls.Add(Me.lblPassword)
        Me.pnlRight.Controls.Add(Me.txtPass)
        Me.pnlRight.Controls.Add(Me.chkShow)
        Me.pnlRight.Controls.Add(Me.lblMsg)
        Me.pnlRight.Controls.Add(Me.btnLogin)
        Me.pnlRight.Controls.Add(Me.lblHint)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(395, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(485, 500)
        Me.pnlRight.TabIndex = 2
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 84, 108)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.btnClose.Location = New System.Drawing.Point(395, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 36)
        Me.btnClose.TabIndex = 10
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "✕  Exit"
        Me.btnClose.UseVisualStyleBackColor = False
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(62, 70)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(177, 37)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome back"
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblSignIn.Location = New System.Drawing.Point(65, 114)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(229, 19)
        Me.lblSignIn.TabIndex = 1
        Me.lblSignIn.Text = "Sign in with your registrar account"
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblUsername.Location = New System.Drawing.Point(64, 168)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 17)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtUser.Location = New System.Drawing.Point(66, 192)
        Me.txtUser.MaxLength = 30
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PlaceholderText = "Enter username"
        Me.txtUser.Size = New System.Drawing.Size(350, 29)
        Me.txtUser.TabIndex = 3
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblPassword.Location = New System.Drawing.Point(64, 240)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 17)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtPass.Location = New System.Drawing.Point(66, 264)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PlaceholderText = "Enter password"
        Me.txtPass.Size = New System.Drawing.Size(350, 29)
        Me.txtPass.TabIndex = 5
        Me.txtPass.UseSystemPasswordChar = True
        Me.chkShow.AutoSize = True
        Me.chkShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkShow.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.chkShow.Location = New System.Drawing.Point(66, 306)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(122, 23)
        Me.chkShow.TabIndex = 6
        Me.chkShow.Text = "Show password"
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblMsg.ForeColor = System.Drawing.Color.FromArgb(228, 84, 108)
        Me.lblMsg.Location = New System.Drawing.Point(64, 336)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(360, 22)
        Me.lblMsg.TabIndex = 7
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(110, 151, 255)
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Global.RegistrarSystem.My.Resources.Resources.btn_lock
        Me.btnLogin.Location = New System.Drawing.Point(66, 364)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(350, 44)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = " LOGIN"
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblHint.Location = New System.Drawing.Point(66, 420)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(270, 15)
        Me.lblHint.TabIndex = 9
        Me.lblHint.Text = "Forgot your password? Ask the system administrator."
        Me.lockTimer.Interval = 1000
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(41, 44, 58)
        Me.ClientSize = New System.Drawing.Size(880, 500)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlStripe)
        Me.Controls.Add(Me.pnlBrand)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Registrar Document Request System"
        Me.pnlBrand.ResumeLayout(False)
        Me.pnlBrand.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents lblBrandTitle As System.Windows.Forms.Label
    Friend WithEvents lblBrandSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblBrandText As System.Windows.Forms.Label
    Friend WithEvents pnlStripe As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblSignIn As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents lockTimer As System.Windows.Forms.Timer
End Class
