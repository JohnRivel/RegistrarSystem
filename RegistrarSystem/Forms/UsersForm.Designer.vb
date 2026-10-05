<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.lblIcon.AutoSize = True
        Me.lblIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 22.0!)
        Me.lblIcon.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblIcon.Location = New System.Drawing.Point(26, 22)
        Me.lblIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.TabIndex = 0
        Me.lblIcon.Text = ""
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 17.0!)
        Me.lblTitle.Location = New System.Drawing.Point(70, 18)
        Me.lblTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "User Management"
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblSubtitle.Location = New System.Drawing.Point(72, 56)
        Me.lblSubtitle.Size = New System.Drawing.Size(40, 19)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "System accounts and their roles"
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(62, 150, 116)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(86, 168, 136)
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.RegistrarSystem.My.Resources.Resources.btn_add
        Me.btnAdd.Location = New System.Drawing.Point(28, 94)
        Me.btnAdd.Size = New System.Drawing.Size(120, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = " Add User"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(62, 104, 186)
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(82, 124, 204)
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.RegistrarSystem.My.Resources.Resources.btn_edit
        Me.btnEdit.Location = New System.Drawing.Point(156, 94)
        Me.btnEdit.Size = New System.Drawing.Size(200, 36)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = " Edit / Reset Password"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnToggle.BackColor = System.Drawing.Color.FromArgb(204, 132, 72)
        Me.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToggle.FlatAppearance.BorderSize = 0
        Me.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 150, 98)
        Me.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnToggle.ForeColor = System.Drawing.Color.White
        Me.btnToggle.Image = Global.RegistrarSystem.My.Resources.Resources.btn_block
        Me.btnToggle.Location = New System.Drawing.Point(364, 94)
        Me.btnToggle.Size = New System.Drawing.Size(125, 36)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.TabIndex = 5
        Me.btnToggle.Text = " Deactivate"
        Me.btnToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnToggle.UseVisualStyleBackColor = False
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(78, 92, 128)
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(96, 110, 146)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Global.RegistrarSystem.My.Resources.Resources.btn_refresh
        Me.btnRefresh.Location = New System.Drawing.Point(497, 94)
        Me.btnRefresh.Size = New System.Drawing.Size(105, 36)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = " Refresh"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(196, 96, 112)
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(208, 120, 134)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.RegistrarSystem.My.Resources.Resources.btn_delete
        Me.btnDelete.Location = New System.Drawing.Point(610, 94)
        Me.btnDelete.Size = New System.Drawing.Size(130, 36)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = " Delete User"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(51, 64, 98)
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.BackgroundColor = System.Drawing.Color.FromArgb(46, 58, 90)
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(30, 39, 64)
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(30, 39, 64)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeight = 40
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(46, 58, 90)
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(62, 104, 186)
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid.EnableHeadersVisualStyles = False
        Me.grid.GridColor = System.Drawing.Color.FromArgb(68, 82, 118)
        Me.grid.Location = New System.Drawing.Point(28, 142)
        Me.grid.MultiSelect = False
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.RowTemplate.Height = 34
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(986, 458)
        Me.grid.Name = "grid"
        Me.grid.TabIndex = 7
        Me.lblCount.AutoSize = True
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblCount.Location = New System.Drawing.Point(26, 610)
        Me.lblCount.Size = New System.Drawing.Size(40, 19)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "0 user(s)"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(37, 47, 75)
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.lblIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lblCount)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UsersForm"
        Me.Text = "User Management"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnToggle As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblCount As System.Windows.Forms.Label
End Class
