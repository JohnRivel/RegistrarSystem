<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DocumentEditorDialog
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
        Me.lblIdCap = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblStatusCap = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblNameCap = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDescCap = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblFeeCap = New System.Windows.Forms.Label()
        Me.numFee = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.numFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblHeading.Location = New System.Drawing.Point(22, 18)
        Me.lblHeading.Size = New System.Drawing.Size(40, 19)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Add Document"
        Me.lblIdCap.AutoSize = True
        Me.lblIdCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblIdCap.Location = New System.Drawing.Point(22, 62)
        Me.lblIdCap.Size = New System.Drawing.Size(40, 19)
        Me.lblIdCap.Name = "lblIdCap"
        Me.lblIdCap.TabIndex = 1
        Me.lblIdCap.Text = "Document ID"
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtId.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtId.Location = New System.Drawing.Point(22, 84)
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(248, 26)
        Me.txtId.Name = "txtId"
        Me.txtId.TabIndex = 2
        Me.txtId.TabStop = False
        Me.txtId.Text = "(auto)"
        Me.lblStatusCap.AutoSize = True
        Me.lblStatusCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblStatusCap.Location = New System.Drawing.Point(290, 62)
        Me.lblStatusCap.Size = New System.Drawing.Size(40, 19)
        Me.lblStatusCap.Name = "lblStatusCap"
        Me.lblStatusCap.TabIndex = 3
        Me.lblStatusCap.Text = "Status"
        Me.cboStatus.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboStatus.Location = New System.Drawing.Point(290, 84)
        Me.cboStatus.Size = New System.Drawing.Size(248, 27)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 4
        Me.lblNameCap.AutoSize = True
        Me.lblNameCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNameCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblNameCap.Location = New System.Drawing.Point(22, 122)
        Me.lblNameCap.Size = New System.Drawing.Size(40, 19)
        Me.lblNameCap.Name = "lblNameCap"
        Me.lblNameCap.TabIndex = 5
        Me.lblNameCap.Text = "Document Name *"
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtName.Location = New System.Drawing.Point(22, 144)
        Me.txtName.MaxLength = 100
        Me.txtName.PlaceholderText = "e.g. Transcript of Records"
        Me.txtName.Size = New System.Drawing.Size(516, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.TabIndex = 6
        Me.lblDescCap.AutoSize = True
        Me.lblDescCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDescCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblDescCap.Location = New System.Drawing.Point(22, 182)
        Me.lblDescCap.Size = New System.Drawing.Size(40, 19)
        Me.lblDescCap.Name = "lblDescCap"
        Me.lblDescCap.TabIndex = 7
        Me.lblDescCap.Text = "Description"
        Me.txtDesc.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtDesc.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtDesc.Location = New System.Drawing.Point(22, 204)
        Me.txtDesc.MaxLength = 255
        Me.txtDesc.Multiline = True
        Me.txtDesc.PlaceholderText = "Short description"
        Me.txtDesc.Size = New System.Drawing.Size(516, 60)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.TabIndex = 8
        Me.lblFeeCap.AutoSize = True
        Me.lblFeeCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFeeCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblFeeCap.Location = New System.Drawing.Point(22, 276)
        Me.lblFeeCap.Size = New System.Drawing.Size(40, 19)
        Me.lblFeeCap.Name = "lblFeeCap"
        Me.lblFeeCap.TabIndex = 9
        Me.lblFeeCap.Text = "Fee (₱) *"
        Me.numFee.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.numFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numFee.DecimalPlaces = 2
        Me.numFee.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.numFee.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.numFee.Location = New System.Drawing.Point(22, 298)
        Me.numFee.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numFee.Size = New System.Drawing.Size(248, 26)
        Me.numFee.Name = "numFee"
        Me.numFee.TabIndex = 10
        Me.numFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numFee.ThousandsSeparator = True
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(92, 98, 120)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(125, 129, 147)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(310, 358)
        Me.btnCancel.Size = New System.Drawing.Size(110, 36)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 11
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
        Me.btnSave.Location = New System.Drawing.Point(428, 358)
        Me.btnSave.Size = New System.Drawing.Size(110, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = " Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(41, 44, 58)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(560, 412)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblIdCap)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblStatusCap)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.lblNameCap)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDescCap)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblFeeCap)
        Me.Controls.Add(Me.numFee)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DocumentEditorDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Document"
        CType(Me.numFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblIdCap As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusCap As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblNameCap As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblDescCap As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblFeeCap As System.Windows.Forms.Label
    Friend WithEvents numFee As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
