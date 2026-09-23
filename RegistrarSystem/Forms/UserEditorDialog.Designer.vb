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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblUsernameCap = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblFullNameCap = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblRoleCap = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.lblStatusCap = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblPassCap = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmCap = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.lblSelfNote = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblHeading.Location = New System.Drawing.Point(22, 18)
        Me.lblHeading.Size = New System.Drawing.Size(40, 19)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Add User"
        Me.lblUsernameCap.AutoSize = True
        Me.lblUsernameCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUsernameCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblUsernameCap.Location = New System.Drawing.Point(22, 62)
        Me.lblUsernameCap.Size = New System.Drawing.Size(40, 19)
        Me.lblUsernameCap.Name = "lblUsernameCap"
        Me.lblUsernameCap.TabIndex = 1
        Me.lblUsernameCap.Text = "Username *"
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtUsername.Location = New System.Drawing.Point(22, 84)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.PlaceholderText = "letters, numbers, underscore"
        Me.txtUsername.Size = New System.Drawing.Size(268, 26)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.TabIndex = 2
        Me.lblFullNameCap.AutoSize = True
        Me.lblFullNameCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFullNameCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblFullNameCap.Location = New System.Drawing.Point(310, 62)
        Me.lblFullNameCap.Size = New System.Drawing.Size(40, 19)
        Me.lblFullNameCap.Name = "lblFullNameCap"
        Me.lblFullNameCap.TabIndex = 3
        Me.lblFullNameCap.Text = "Full Name *"
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtFullName.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtFullName.Location = New System.Drawing.Point(310, 84)
        Me.txtFullName.MaxLength = 100
        Me.txtFullName.Size = New System.Drawing.Size(268, 26)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.TabIndex = 4
        Me.lblRoleCap.AutoSize = True
        Me.lblRoleCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRoleCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblRoleCap.Location = New System.Drawing.Point(22, 122)
        Me.lblRoleCap.Size = New System.Drawing.Size(40, 19)
        Me.lblRoleCap.Name = "lblRoleCap"
        Me.lblRoleCap.TabIndex = 5
        Me.lblRoleCap.Text = "Role *"
        Me.cboRole.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRole.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboRole.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"Registrar Staff", "Administrator"})
        Me.cboRole.Location = New System.Drawing.Point(22, 144)
        Me.cboRole.Size = New System.Drawing.Size(268, 27)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.TabIndex = 6
        Me.lblStatusCap.AutoSize = True
        Me.lblStatusCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblStatusCap.Location = New System.Drawing.Point(310, 122)
        Me.lblStatusCap.Size = New System.Drawing.Size(40, 19)
        Me.lblStatusCap.Name = "lblStatusCap"
        Me.lblStatusCap.TabIndex = 7
        Me.lblStatusCap.Text = "Status"
        Me.cboStatus.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboStatus.Location = New System.Drawing.Point(310, 144)
        Me.cboStatus.Size = New System.Drawing.Size(268, 27)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 8
        Me.lblPassCap.AutoSize = True
        Me.lblPassCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblPassCap.Location = New System.Drawing.Point(22, 182)
        Me.lblPassCap.Size = New System.Drawing.Size(40, 19)
        Me.lblPassCap.Name = "lblPassCap"
        Me.lblPassCap.TabIndex = 9
        Me.lblPassCap.Text = "Password *"
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtPass.Location = New System.Drawing.Point(22, 204)
        Me.txtPass.MaxLength = 50
        Me.txtPass.PlaceholderText = "at least 6 characters"
        Me.txtPass.Size = New System.Drawing.Size(268, 26)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.TabIndex = 10
        Me.txtPass.UseSystemPasswordChar = True
        Me.lblConfirmCap.AutoSize = True
        Me.lblConfirmCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblConfirmCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblConfirmCap.Location = New System.Drawing.Point(310, 182)
        Me.lblConfirmCap.Size = New System.Drawing.Size(40, 19)
        Me.lblConfirmCap.Name = "lblConfirmCap"
        Me.lblConfirmCap.TabIndex = 11
        Me.lblConfirmCap.Text = "Confirm Password"
        Me.txtConfirm.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirm.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtConfirm.Location = New System.Drawing.Point(310, 204)
        Me.txtConfirm.MaxLength = 50
        Me.txtConfirm.Size = New System.Drawing.Size(268, 26)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.TabIndex = 12
        Me.txtConfirm.UseSystemPasswordChar = True
        Me.lblSelfNote.AutoSize = True
        Me.lblSelfNote.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSelfNote.ForeColor = System.Drawing.Color.FromArgb(232, 172, 48)
        Me.lblSelfNote.Location = New System.Drawing.Point(22, 246)
        Me.lblSelfNote.Size = New System.Drawing.Size(40, 19)
        Me.lblSelfNote.Name = "lblSelfNote"
        Me.lblSelfNote.TabIndex = 13
        Me.lblSelfNote.Visible = False
        Me.lblSelfNote.Text = "You are editing your own account: role and status cannot be changed."
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(92, 98, 120)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(125, 129, 147)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(360, 368)
        Me.btnCancel.Size = New System.Drawing.Size(110, 36)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(38, 170, 118)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(81, 187, 145)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.RegistrarSystem.My.Resources.Resources.btn_save
        Me.btnSave.Location = New System.Drawing.Point(478, 368)
        Me.btnSave.Size = New System.Drawing.Size(110, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = " Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(41, 44, 58)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(600, 424)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblUsernameCap)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblFullNameCap)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblRoleCap)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.lblStatusCap)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.lblPassCap)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblConfirmCap)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.lblSelfNote)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserEditorDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
