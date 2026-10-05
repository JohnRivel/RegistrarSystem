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
        lblHeading = New Label()
        lblIdCap = New Label()
        txtId = New TextBox()
        lblStatusCap = New Label()
        cboStatus = New ComboBox()
        lblNameCap = New Label()
        txtName = New TextBox()
        lblDescCap = New Label()
        txtDesc = New TextBox()
        lblFeeCap = New Label()
        numFee = New NumericUpDown()
        btnCancel = New Button()
        btnSave = New Button()
        CType(numFee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI Semibold", 15F)
        lblHeading.Location = New Point(22, 18)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(150, 28)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Add Document"
        ' 
        ' lblIdCap
        ' 
        lblIdCap.AutoSize = True
        lblIdCap.Font = New Font("Segoe UI", 9F)
        lblIdCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblIdCap.Location = New Point(22, 62)
        lblIdCap.Name = "lblIdCap"
        lblIdCap.Size = New Size(77, 15)
        lblIdCap.TabIndex = 1
        lblIdCap.Text = "Document ID"
        ' 
        ' txtId
        ' 
        txtId.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtId.BorderStyle = BorderStyle.FixedSingle
        txtId.Font = New Font("Segoe UI", 10.5F)
        txtId.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtId.Location = New Point(22, 84)
        txtId.Name = "txtId"
        txtId.ReadOnly = True
        txtId.Size = New Size(248, 26)
        txtId.TabIndex = 2
        txtId.TabStop = False
        txtId.Text = "(auto)"
        ' 
        ' lblStatusCap
        ' 
        lblStatusCap.AutoSize = True
        lblStatusCap.Font = New Font("Segoe UI", 9F)
        lblStatusCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblStatusCap.Location = New Point(290, 62)
        lblStatusCap.Name = "lblStatusCap"
        lblStatusCap.Size = New Size(39, 15)
        lblStatusCap.TabIndex = 3
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
        cboStatus.Location = New Point(290, 84)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(248, 27)
        cboStatus.TabIndex = 4
        ' 
        ' lblNameCap
        ' 
        lblNameCap.AutoSize = True
        lblNameCap.Font = New Font("Segoe UI", 9F)
        lblNameCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblNameCap.Location = New Point(22, 122)
        lblNameCap.Name = "lblNameCap"
        lblNameCap.Size = New Size(106, 15)
        lblNameCap.TabIndex = 5
        lblNameCap.Text = "Document Name *"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 10.5F)
        txtName.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtName.Location = New Point(22, 144)
        txtName.MaxLength = 100
        txtName.Name = "txtName"
        txtName.PlaceholderText = "e.g. Transcript of Records"
        txtName.Size = New Size(516, 26)
        txtName.TabIndex = 6
        ' 
        ' lblDescCap
        ' 
        lblDescCap.AutoSize = True
        lblDescCap.Font = New Font("Segoe UI", 9F)
        lblDescCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblDescCap.Location = New Point(22, 182)
        lblDescCap.Name = "lblDescCap"
        lblDescCap.Size = New Size(67, 15)
        lblDescCap.TabIndex = 7
        lblDescCap.Text = "Description"
        ' 
        ' txtDesc
        ' 
        txtDesc.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        txtDesc.BorderStyle = BorderStyle.FixedSingle
        txtDesc.Font = New Font("Segoe UI", 10.5F)
        txtDesc.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtDesc.Location = New Point(22, 204)
        txtDesc.MaxLength = 255
        txtDesc.Multiline = True
        txtDesc.Name = "txtDesc"
        txtDesc.PlaceholderText = "Short description"
        txtDesc.Size = New Size(516, 60)
        txtDesc.TabIndex = 8
        ' 
        ' lblFeeCap
        ' 
        lblFeeCap.AutoSize = True
        lblFeeCap.Font = New Font("Segoe UI", 9F)
        lblFeeCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblFeeCap.Location = New Point(22, 276)
        lblFeeCap.Name = "lblFeeCap"
        lblFeeCap.Size = New Size(51, 15)
        lblFeeCap.TabIndex = 9
        lblFeeCap.Text = "Fee (₱) *"
        ' 
        ' numFee
        ' 
        numFee.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        numFee.BorderStyle = BorderStyle.FixedSingle
        numFee.DecimalPlaces = 2
        numFee.Font = New Font("Segoe UI", 10.5F)
        numFee.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        numFee.Location = New Point(22, 298)
        numFee.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        numFee.Name = "numFee"
        numFee.Size = New Size(248, 26)
        numFee.TabIndex = 10
        numFee.TextAlign = HorizontalAlignment.Right
        numFee.ThousandsSeparator = True
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
        btnCancel.Location = New Point(310, 358)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 36)
        btnCancel.TabIndex = 11
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
        btnSave.Location = New Point(428, 358)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 36)
        btnSave.TabIndex = 12
        btnSave.Text = " Save"
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' DocumentEditorDialog
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(37), CByte(47), CByte(75))
        CancelButton = btnCancel
        ClientSize = New Size(560, 412)
        Controls.Add(lblHeading)
        Controls.Add(lblIdCap)
        Controls.Add(txtId)
        Controls.Add(lblStatusCap)
        Controls.Add(cboStatus)
        Controls.Add(lblNameCap)
        Controls.Add(txtName)
        Controls.Add(lblDescCap)
        Controls.Add(txtDesc)
        Controls.Add(lblFeeCap)
        Controls.Add(numFee)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "DocumentEditorDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Document"
        CType(numFee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

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
