<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestListForm
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
        Me.cboPay = New System.Windows.Forms.ComboBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.searchTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.lblIcon.AutoSize = True
        Me.lblIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 22.0!)
        Me.lblIcon.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblIcon.Location = New System.Drawing.Point(26, 22)
        Me.lblIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.TabIndex = 0
        Me.lblIcon.Text = ""
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 17.0!)
        Me.lblTitle.Location = New System.Drawing.Point(70, 18)
        Me.lblTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Document Requests"
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblSubtitle.Location = New System.Drawing.Point(72, 56)
        Me.lblSubtitle.Size = New System.Drawing.Size(40, 19)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Double-click a request to view details, record payment or update its status"
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtSearch.Location = New System.Drawing.Point(28, 100)
        Me.txtSearch.PlaceholderText = "Search Request No., Student ID, name or OR No..."
        Me.txtSearch.Size = New System.Drawing.Size(300, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.TabIndex = 3
        Me.cboStatus.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"All Status", "Pending", "Processing", "Ready for Release", "Released", "Cancelled"})
        Me.cboStatus.Location = New System.Drawing.Point(336, 99)
        Me.cboStatus.Size = New System.Drawing.Size(160, 27)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 4
        Me.cboPay.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPay.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboPay.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboPay.FormattingEnabled = True
        Me.cboPay.Items.AddRange(New Object() {"All Payments", "Unpaid", "Paid"})
        Me.cboPay.Location = New System.Drawing.Point(504, 99)
        Me.cboPay.Size = New System.Drawing.Size(130, 27)
        Me.cboPay.Name = "cboPay"
        Me.cboPay.TabIndex = 5
        Me.chkDate.AutoSize = True
        Me.chkDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDate.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.chkDate.Location = New System.Drawing.Point(644, 101)
        Me.chkDate.Size = New System.Drawing.Size(60, 23)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.TabIndex = 6
        Me.chkDate.Text = "Date:"
        Me.chkDate.UseVisualStyleBackColor = True
        Me.dtpFrom.CustomFormat = "MM/dd/yyyy"
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(708, 100)
        Me.dtpFrom.Size = New System.Drawing.Size(125, 26)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.TabIndex = 7
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblTo.Location = New System.Drawing.Point(840, 103)
        Me.lblTo.Size = New System.Drawing.Size(40, 19)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.TabIndex = 8
        Me.lblTo.Text = "to"
        Me.dtpTo.CustomFormat = "MM/dd/yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(864, 100)
        Me.dtpTo.Size = New System.Drawing.Size(125, 26)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.TabIndex = 9
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(62, 104, 186)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(82, 124, 204)
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.RegistrarSystem.My.Resources.Resources.btn_search
        Me.btnSearch.Location = New System.Drawing.Point(28, 138)
        Me.btnSearch.Size = New System.Drawing.Size(100, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = " Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(62, 150, 116)
        Me.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(86, 168, 136)
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnOpen.ForeColor = System.Drawing.Color.White
        Me.btnOpen.Image = Global.RegistrarSystem.My.Resources.Resources.btn_edit
        Me.btnOpen.Location = New System.Drawing.Point(136, 138)
        Me.btnOpen.Size = New System.Drawing.Size(140, 36)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.TabIndex = 11
        Me.btnOpen.Text = " View / Update"
        Me.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpen.UseVisualStyleBackColor = False
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(78, 92, 128)
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(96, 110, 146)
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.RegistrarSystem.My.Resources.Resources.btn_add
        Me.btnNew.Location = New System.Drawing.Point(284, 138)
        Me.btnNew.Size = New System.Drawing.Size(140, 36)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = " New Request"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = False
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(78, 92, 128)
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(96, 110, 146)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Global.RegistrarSystem.My.Resources.Resources.btn_refresh
        Me.btnRefresh.Location = New System.Drawing.Point(432, 138)
        Me.btnRefresh.Size = New System.Drawing.Size(105, 36)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.Text = " Refresh"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = False
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
        Me.grid.Location = New System.Drawing.Point(28, 186)
        Me.grid.MultiSelect = False
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.RowTemplate.Height = 34
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(986, 414)
        Me.grid.Name = "grid"
        Me.grid.TabIndex = 14
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSummary.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSummary.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblSummary.Location = New System.Drawing.Point(26, 610)
        Me.lblSummary.Size = New System.Drawing.Size(40, 19)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.TabIndex = 15
        Me.lblSummary.Text = "0 request(s)"
        Me.searchTimer.Interval = 350
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(37, 47, 75)
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.lblIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboPay)
        Me.Controls.Add(Me.chkDate)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lblSummary)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RequestListForm"
        Me.Text = "Document Requests"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboPay As System.Windows.Forms.ComboBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents searchTimer As System.Windows.Forms.Timer
End Class
