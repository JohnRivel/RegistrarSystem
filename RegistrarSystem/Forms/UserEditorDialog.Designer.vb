<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserEditorDialog
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
        lblHeading = New Label()
        lblUsernameCap = New Label()
        txtUsername = New TextBox()
        lblFullNameCap = New Label()
        txtFullName = New TextBox()
        lblRoleCap = New Label()
        cboRole = New ComboBox()
        lblStatusCap = New Label()
        cboStatus = New ComboBox()
        lblPassCap = New Label()
        txtPass = New TextBox()
        lblConfirmCap = New Label()
        txtConfirm = New TextBox()
        lblSelfNote = New Label()
        btnCancel = New Button()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI Semibold", 15F)
        lblHeading.Location = New Point(22, 18)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(96, 28)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Add User"
        ' 
        ' lblUsernameCap
        ' 
        lblUsernameCap.AutoSize = True
        lblUsernameCap.Font = New Font("Segoe UI", 9F)
        lblUsernameCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblUsernameCap.Location = New Point(22, 62)
        lblUsernameCap.Name = "lblUsernameCap"
        lblUsernameCap.Size = New Size(68, 15)
        lblUsernameCap.TabIndex = 1
        lblUsernameCap.Text = "Username *"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.5F)
        txtUsername.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtUsername.Location = New Point(22, 84)
        txtUsername.MaxLength = 30
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "letters, numbers, underscore"
        txtUsername.Size = New Size(268, 26)
        txtUsername.TabIndex = 2
        ' 
        ' lblFullNameCap
        ' 
        lblFullNameCap.AutoSize = True
        lblFullNameCap.Font = New Font("Segoe UI", 9F)
        lblFullNameCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblFullNameCap.Location = New Point(310, 62)
        lblFullNameCap.Name = "lblFullNameCap"
        lblFullNameCap.Size = New Size(69, 15)
        lblFullNameCap.TabIndex = 3
        lblFullNameCap.Text = "Full Name *"
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Font = New Font("Segoe UI", 10.5F)
        txtFullName.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtFullName.Location = New Point(310, 84)
        txtFullName.MaxLength = 100
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(268, 26)
        txtFullName.TabIndex = 4
        ' 
        ' lblRoleCap
        ' 
        lblRoleCap.AutoSize = True
        lblRoleCap.Font = New Font("Segoe UI", 9F)
        lblRoleCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblRoleCap.Location = New Point(22, 122)
        lblRoleCap.Name = "lblRoleCap"
        lblRoleCap.Size = New Size(38, 15)
        lblRoleCap.TabIndex = 5
        lblRoleCap.Text = "Role *"
        ' 
        ' cboRole
        ' 
        cboRole.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.FlatStyle = FlatStyle.Flat
        cboRole.Font = New Font("Segoe UI", 10.5F)
        cboRole.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Registrar Staff", "Administrator"})
        cboRole.Location = New Point(22, 144)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(268, 27)
        cboRole.TabIndex = 6
        ' 
        ' lblStatusCap
        ' 
        lblStatusCap.AutoSize = True
        lblStatusCap.Font = New Font("Segoe UI", 9F)
        lblStatusCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblStatusCap.Location = New Point(310, 122)
        lblStatusCap.Name = "lblStatusCap"
        lblStatusCap.Size = New Size(39, 15)
        lblStatusCap.TabIndex = 7
        lblStatusCap.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.FlatStyle = FlatStyle.Flat
        cboStatus.Font = New Font("Segoe UI", 10.5F)
        cboStatus.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(310, 144)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(268, 27)
        cboStatus.TabIndex = 8
        ' 
        ' lblPassCap
        ' 
        lblPassCap.AutoSize = True
        lblPassCap.Font = New Font("Segoe UI", 9F)
        lblPassCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblPassCap.Location = New Point(22, 182)
        lblPassCap.Name = "lblPassCap"
        lblPassCap.Size = New Size(65, 15)
        lblPassCap.TabIndex = 9
        lblPassCap.Text = "Password *"
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Font = New Font("Segoe UI", 10.5F)
        txtPass.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtPass.Location = New Point(22, 204)
        txtPass.MaxLength = 50
        txtPass.Name = "txtPass"
        txtPass.PlaceholderText = "at least 6 characters"
        txtPass.Size = New Size(268, 26)
        txtPass.TabIndex = 10
        txtPass.UseSystemPasswordChar = True
        ' 
        ' lblConfirmCap
        ' 
        lblConfirmCap.AutoSize = True
        lblConfirmCap.Font = New Font("Segoe UI", 9F)
        lblConfirmCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblConfirmCap.Location = New Point(310, 182)
        lblConfirmCap.Name = "lblConfirmCap"
        lblConfirmCap.Size = New Size(104, 15)
        lblConfirmCap.TabIndex = 11
        lblConfirmCap.Text = "Confirm Password"
        ' 
        ' txtConfirm
        ' 
        txtConfirm.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        txtConfirm.BorderStyle = BorderStyle.FixedSingle
        txtConfirm.Font = New Font("Segoe UI", 10.5F)
        txtConfirm.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtConfirm.Location = New Point(310, 204)
        txtConfirm.MaxLength = 50
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(268, 26)
        txtConfirm.TabIndex = 12
        txtConfirm.UseSystemPasswordChar = True
        ' 
        ' lblSelfNote
        ' 
        lblSelfNote.AutoSize = True
        lblSelfNote.Font = New Font("Segoe UI", 9F)
        lblSelfNote.ForeColor = Color.FromArgb(CByte(206), CByte(166), CByte(82))
        lblSelfNote.Location = New Point(22, 246)
        lblSelfNote.Name = "lblSelfNote"
        lblSelfNote.Size = New Size(376, 15)
        lblSelfNote.TabIndex = 13
        lblSelfNote.Text = "You are editing your own account: role and status cannot be changed."
        lblSelfNote.Visible = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(78), CByte(92), CByte(128))
        btnCancel.Cursor = Cursors.Hand
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(96), CByte(110), CByte(146))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 9.5F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(360, 368)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 36)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(62), CByte(150), CByte(116))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(86), CByte(168), CByte(136))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9.5F)
        btnSave.ForeColor = Color.White
        btnSave.Image = My.Resources.Resources.btn_save
        btnSave.Location = New Point(478, 368)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 36)
        btnSave.TabIndex = 15
        btnSave.Text = " Save"
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' UserEditorDialog
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(37), CByte(47), CByte(75))
        CancelButton = btnCancel
        ClientSize = New Size(600, 424)
        Controls.Add(lblHeading)
        Controls.Add(lblUsernameCap)
        Controls.Add(txtUsername)
        Controls.Add(lblFullNameCap)
        Controls.Add(txtFullName)
        Controls.Add(lblRoleCap)
        Controls.Add(cboRole)
        Controls.Add(lblStatusCap)
        Controls.Add(cboStatus)
        Controls.Add(lblPassCap)
        Controls.Add(txtPass)
        Controls.Add(lblConfirmCap)
        Controls.Add(txtConfirm)
        Controls.Add(lblSelfNote)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserEditorDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Add User"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblUsernameCap As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblFullNameCap As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblRoleCap As System.Windows.Forms.Label
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatusCap As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblPassCap As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmCap As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblSelfNote As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
