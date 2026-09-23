<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.searchTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.lblIcon.AutoSize = True
        Me.lblIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 22.0!)
        Me.lblIcon.ForeColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblIcon.Location = New System.Drawing.Point(26, 22)
        Me.lblIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.TabIndex = 0
        Me.lblIcon.Text = ""
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 17.0!)
        Me.lblTitle.Location = New System.Drawing.Point(70, 18)
        Me.lblTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Student Management"
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblSubtitle.Location = New System.Drawing.Point(72, 56)
        Me.lblSubtitle.Size = New System.Drawing.Size(40, 19)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Add, edit, search and deactivate student records"
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtSearch.Location = New System.Drawing.Point(28, 100)
        Me.txtSearch.PlaceholderText = "Search ID, LRN, name or course..."
        Me.txtSearch.Size = New System.Drawing.Size(240, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.TabIndex = 3
        Me.cboStatus.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"All", "Active", "Inactive"})
        Me.cboStatus.Location = New System.Drawing.Point(276, 99)
        Me.cboStatus.Size = New System.Drawing.Size(105, 27)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 4
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(110, 151, 255)
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.RegistrarSystem.My.Resources.Resources.btn_search
        Me.btnSearch.Location = New System.Drawing.Point(389, 94)
        Me.btnSearch.Size = New System.Drawing.Size(95, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = " Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(92, 98, 120)
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(125, 129, 147)
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Image = Global.RegistrarSystem.My.Resources.Resources.btn_view
        Me.btnView.Location = New System.Drawing.Point(492, 94)
        Me.btnView.Size = New System.Drawing.Size(80, 36)
        Me.btnView.Name = "btnView"
        Me.btnView.TabIndex = 6
        Me.btnView.Text = " View"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = False
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(92, 98, 120)
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(125, 129, 147)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Global.RegistrarSystem.My.Resources.Resources.btn_refresh
        Me.btnRefresh.Location = New System.Drawing.Point(580, 94)
        Me.btnRefresh.Size = New System.Drawing.Size(40, 36)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = ""
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(38, 170, 118)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(81, 187, 145)
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.RegistrarSystem.My.Resources.Resources.btn_add
        Me.btnAdd.Location = New System.Drawing.Point(628, 94)
        Me.btnAdd.Size = New System.Drawing.Size(80, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = " Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(110, 151, 255)
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.RegistrarSystem.My.Resources.Resources.btn_edit
        Me.btnEdit.Location = New System.Drawing.Point(716, 94)
        Me.btnEdit.Size = New System.Drawing.Size(80, 36)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = " Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnToggle.BackColor = System.Drawing.Color.FromArgb(230, 126, 34)
        Me.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToggle.FlatAppearance.BorderSize = 0
        Me.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 152, 78)
        Me.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnToggle.ForeColor = System.Drawing.Color.White
        Me.btnToggle.Image = Global.RegistrarSystem.My.Resources.Resources.btn_block
        Me.btnToggle.Location = New System.Drawing.Point(804, 94)
        Me.btnToggle.Size = New System.Drawing.Size(115, 36)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.TabIndex = 10
        Me.btnToggle.Text = " Deactivate"
        Me.btnToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnToggle.UseVisualStyleBackColor = False
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(228, 84, 108)
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(233, 118, 137)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.RegistrarSystem.My.Resources.Resources.btn_delete
        Me.btnDelete.Location = New System.Drawing.Point(927, 94)
        Me.btnDelete.Size = New System.Drawing.Size(87, 36)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = " Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(57, 61, 80)
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.BackgroundColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(31, 33, 45)
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(31, 33, 45)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeight = 40
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid.EnableHeadersVisualStyles = False
        Me.grid.GridColor = System.Drawing.Color.FromArgb(76, 81, 104)
        Me.grid.Location = New System.Drawing.Point(28, 142)
        Me.grid.MultiSelect = False
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.RowTemplate.Height = 34
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(986, 458)
        Me.grid.Name = "grid"
        Me.grid.TabIndex = 12
        Me.lblCount.AutoSize = True
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblCount.Location = New System.Drawing.Point(26, 610)
        Me.lblCount.Size = New System.Drawing.Size(40, 19)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.TabIndex = 13
        Me.lblCount.Text = "0 student(s) found"
        Me.searchTimer.Interval = 350
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(41, 44, 58)
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.lblIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lblCount)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentsForm"
        Me.Text = "Student Management"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnToggle As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents searchTimer As System.Windows.Forms.Timer
End Class
