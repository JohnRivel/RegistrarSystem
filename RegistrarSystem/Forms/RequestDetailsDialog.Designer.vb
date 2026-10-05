<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestDetailsDialog
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        flpHeader = New FlowLayoutPanel()
        lblReqNo = New Label()
        lblStatusBadge = New Label()
        lblPayBadge = New Label()
        pnlInfo = New Panel()
        lblInfoIcon = New Label()
        lblInfoTitle = New Label()
        lblDateCap = New Label()
        txtDate = New TextBox()
        lblStudentIdCap = New Label()
        txtStudentId = New TextBox()
        lblStudentCap = New Label()
        txtStudent = New TextBox()
        lblCourseCap = New Label()
        txtCourse = New TextBox()
        lblContactCap = New Label()
        txtContact = New TextBox()
        lblByCap = New Label()
        txtBy = New TextBox()
        lblReleasedCap = New Label()
        txtReleased = New TextBox()
        pnlDocs = New Panel()
        lblDocsIcon = New Label()
        lblDocsTitle = New Label()
        gridDocs = New DataGridView()
        lblTotal = New Label()
        pnlPay = New Panel()
        lblPayIcon = New Label()
        lblPayTitle = New Label()
        lblPayStatusCap = New Label()
        cboPay = New ComboBox()
        lblOrCap = New Label()
        txtOr = New TextBox()
        lblOrDateCap = New Label()
        dtpOr = New DateTimePicker()
        lblPaidCap = New Label()
        numPaid = New NumericUpDown()
        lblChange = New Label()
        btnSavePay = New Button()
        pnlStatus = New Panel()
        lblStatusIcon = New Label()
        lblStatusTitle = New Label()
        lblCurrentCap = New Label()
        txtCurrent = New TextBox()
        lblNextCap = New Label()
        cboNext = New ComboBox()
        lblStatusHint = New Label()
        btnStatus = New Button()
        btnClose = New Button()
        flpHeader.SuspendLayout()
        pnlInfo.SuspendLayout()
        pnlDocs.SuspendLayout()
        CType(gridDocs, ComponentModel.ISupportInitialize).BeginInit()
        pnlPay.SuspendLayout()
        CType(numPaid, ComponentModel.ISupportInitialize).BeginInit()
        pnlStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpHeader
        ' 
        flpHeader.Controls.Add(lblReqNo)
        flpHeader.Controls.Add(lblStatusBadge)
        flpHeader.Controls.Add(lblPayBadge)
        flpHeader.Location = New Point(26, 16)
        flpHeader.Name = "flpHeader"
        flpHeader.Size = New Size(900, 46)
        flpHeader.TabIndex = 0
        flpHeader.WrapContents = False
        ' 
        ' lblReqNo
        ' 
        lblReqNo.AutoSize = True
        lblReqNo.Font = New Font("Segoe UI Semibold", 18F)
        lblReqNo.Location = New Point(0, 0)
        lblReqNo.Margin = New Padding(0, 0, 12, 0)
        lblReqNo.Name = "lblReqNo"
        lblReqNo.Size = New Size(196, 32)
        lblReqNo.TabIndex = 1
        lblReqNo.Text = "REQ-2026-00000"
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.AutoSize = True
        lblStatusBadge.BackColor = Color.FromArgb(CByte(206), CByte(166), CByte(82))
        lblStatusBadge.Font = New Font("Segoe UI Semibold", 9.5F)
        lblStatusBadge.ForeColor = Color.White
        lblStatusBadge.Location = New Point(208, 8)
        lblStatusBadge.Margin = New Padding(0, 8, 8, 0)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Padding = New Padding(10, 4, 10, 4)
        lblStatusBadge.Size = New Size(78, 25)
        lblStatusBadge.TabIndex = 2
        lblStatusBadge.Text = "Pending"
        ' 
        ' lblPayBadge
        ' 
        lblPayBadge.AutoSize = True
        lblPayBadge.BackColor = Color.FromArgb(CByte(204), CByte(132), CByte(72))
        lblPayBadge.Font = New Font("Segoe UI Semibold", 9.5F)
        lblPayBadge.ForeColor = Color.White
        lblPayBadge.Location = New Point(294, 8)
        lblPayBadge.Margin = New Padding(0, 8, 8, 0)
        lblPayBadge.Name = "lblPayBadge"
        lblPayBadge.Padding = New Padding(10, 4, 10, 4)
        lblPayBadge.Size = New Size(71, 25)
        lblPayBadge.TabIndex = 3
        lblPayBadge.Text = "Unpaid"
        ' 
        ' pnlInfo
        ' 
        pnlInfo.BackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        pnlInfo.Controls.Add(lblInfoIcon)
        pnlInfo.Controls.Add(lblInfoTitle)
        pnlInfo.Controls.Add(lblDateCap)
        pnlInfo.Controls.Add(txtDate)
        pnlInfo.Controls.Add(lblStudentIdCap)
        pnlInfo.Controls.Add(txtStudentId)
        pnlInfo.Controls.Add(lblStudentCap)
        pnlInfo.Controls.Add(txtStudent)
        pnlInfo.Controls.Add(lblCourseCap)
        pnlInfo.Controls.Add(txtCourse)
        pnlInfo.Controls.Add(lblContactCap)
        pnlInfo.Controls.Add(txtContact)
        pnlInfo.Controls.Add(lblByCap)
        pnlInfo.Controls.Add(txtBy)
        pnlInfo.Controls.Add(lblReleasedCap)
        pnlInfo.Controls.Add(txtReleased)
        pnlInfo.Location = New Point(26, 72)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Size = New Size(1008, 178)
        pnlInfo.TabIndex = 4
        ' 
        ' lblInfoIcon
        ' 
        lblInfoIcon.AutoSize = True
        lblInfoIcon.Font = New Font("Segoe MDL2 Assets", 12F)
        lblInfoIcon.ForeColor = Color.FromArgb(CByte(226), CByte(186), CByte(92))
        lblInfoIcon.Location = New Point(16, 14)
        lblInfoIcon.Name = "lblInfoIcon"
        lblInfoIcon.Size = New Size(23, 16)
        lblInfoIcon.TabIndex = 5
        lblInfoIcon.Text = ""
        ' 
        ' lblInfoTitle
        ' 
        lblInfoTitle.AutoSize = True
        lblInfoTitle.Font = New Font("Segoe UI Semibold", 11F)
        lblInfoTitle.Location = New Point(40, 12)
        lblInfoTitle.Name = "lblInfoTitle"
        lblInfoTitle.Size = New Size(148, 20)
        lblInfoTitle.TabIndex = 6
        lblInfoTitle.Text = "Request Information"
        ' 
        ' lblDateCap
        ' 
        lblDateCap.AutoSize = True
        lblDateCap.Font = New Font("Segoe UI", 9F)
        lblDateCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblDateCap.Location = New Point(18, 44)
        lblDateCap.Name = "lblDateCap"
        lblDateCap.Size = New Size(76, 15)
        lblDateCap.TabIndex = 7
        lblDateCap.Text = "Request Date"
        ' 
        ' txtDate
        ' 
        txtDate.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtDate.BorderStyle = BorderStyle.FixedSingle
        txtDate.Font = New Font("Segoe UI", 10.5F)
        txtDate.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtDate.Location = New Point(18, 66)
        txtDate.Name = "txtDate"
        txtDate.ReadOnly = True
        txtDate.Size = New Size(230, 26)
        txtDate.TabIndex = 8
        txtDate.TabStop = False
        ' 
        ' lblStudentIdCap
        ' 
        lblStudentIdCap.AutoSize = True
        lblStudentIdCap.Font = New Font("Segoe UI", 9F)
        lblStudentIdCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblStudentIdCap.Location = New Point(266, 44)
        lblStudentIdCap.Name = "lblStudentIdCap"
        lblStudentIdCap.Size = New Size(62, 15)
        lblStudentIdCap.TabIndex = 9
        lblStudentIdCap.Text = "Student ID"
        ' 
        ' txtStudentId
        ' 
        txtStudentId.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtStudentId.BorderStyle = BorderStyle.FixedSingle
        txtStudentId.Font = New Font("Segoe UI", 10.5F)
        txtStudentId.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtStudentId.Location = New Point(266, 66)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.ReadOnly = True
        txtStudentId.Size = New Size(230, 26)
        txtStudentId.TabIndex = 10
        txtStudentId.TabStop = False
        ' 
        ' lblStudentCap
        ' 
        lblStudentCap.AutoSize = True
        lblStudentCap.Font = New Font("Segoe UI", 9F)
        lblStudentCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblStudentCap.Location = New Point(514, 44)
        lblStudentCap.Name = "lblStudentCap"
        lblStudentCap.Size = New Size(83, 15)
        lblStudentCap.TabIndex = 11
        lblStudentCap.Text = "Student Name"
        ' 
        ' txtStudent
        ' 
        txtStudent.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtStudent.BorderStyle = BorderStyle.FixedSingle
        txtStudent.Font = New Font("Segoe UI", 10.5F)
        txtStudent.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtStudent.Location = New Point(514, 66)
        txtStudent.Name = "txtStudent"
        txtStudent.ReadOnly = True
        txtStudent.Size = New Size(476, 26)
        txtStudent.TabIndex = 12
        txtStudent.TabStop = False
        ' 
        ' lblCourseCap
        ' 
        lblCourseCap.AutoSize = True
        lblCourseCap.Font = New Font("Segoe UI", 9F)
        lblCourseCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblCourseCap.Location = New Point(18, 104)
        lblCourseCap.Name = "lblCourseCap"
        lblCourseCap.Size = New Size(127, 15)
        lblCourseCap.TabIndex = 13
        lblCourseCap.Text = "Course / Year / Section"
        ' 
        ' txtCourse
        ' 
        txtCourse.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtCourse.BorderStyle = BorderStyle.FixedSingle
        txtCourse.Font = New Font("Segoe UI", 10.5F)
        txtCourse.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtCourse.Location = New Point(18, 126)
        txtCourse.Name = "txtCourse"
        txtCourse.ReadOnly = True
        txtCourse.Size = New Size(230, 26)
        txtCourse.TabIndex = 14
        txtCourse.TabStop = False
        ' 
        ' lblContactCap
        ' 
        lblContactCap.AutoSize = True
        lblContactCap.Font = New Font("Segoe UI", 9F)
        lblContactCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblContactCap.Location = New Point(266, 104)
        lblContactCap.Name = "lblContactCap"
        lblContactCap.Size = New Size(71, 15)
        lblContactCap.TabIndex = 15
        lblContactCap.Text = "Contact No."
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtContact.BorderStyle = BorderStyle.FixedSingle
        txtContact.Font = New Font("Segoe UI", 10.5F)
        txtContact.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtContact.Location = New Point(266, 126)
        txtContact.Name = "txtContact"
        txtContact.ReadOnly = True
        txtContact.Size = New Size(230, 26)
        txtContact.TabIndex = 16
        txtContact.TabStop = False
        ' 
        ' lblByCap
        ' 
        lblByCap.AutoSize = True
        lblByCap.Font = New Font("Segoe UI", 9F)
        lblByCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblByCap.Location = New Point(514, 104)
        lblByCap.Name = "lblByCap"
        lblByCap.Size = New Size(76, 15)
        lblByCap.TabIndex = 17
        lblByCap.Text = "Processed By"
        ' 
        ' txtBy
        ' 
        txtBy.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtBy.BorderStyle = BorderStyle.FixedSingle
        txtBy.Font = New Font("Segoe UI", 10.5F)
        txtBy.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtBy.Location = New Point(514, 126)
        txtBy.Name = "txtBy"
        txtBy.ReadOnly = True
        txtBy.Size = New Size(230, 26)
        txtBy.TabIndex = 18
        txtBy.TabStop = False
        ' 
        ' lblReleasedCap
        ' 
        lblReleasedCap.AutoSize = True
        lblReleasedCap.Font = New Font("Segoe UI", 9F)
        lblReleasedCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblReleasedCap.Location = New Point(762, 104)
        lblReleasedCap.Name = "lblReleasedCap"
        lblReleasedCap.Size = New Size(72, 15)
        lblReleasedCap.TabIndex = 19
        lblReleasedCap.Text = "Released On"
        ' 
        ' txtReleased
        ' 
        txtReleased.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtReleased.BorderStyle = BorderStyle.FixedSingle
        txtReleased.Font = New Font("Segoe UI", 10.5F)
        txtReleased.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtReleased.Location = New Point(762, 126)
        txtReleased.Name = "txtReleased"
        txtReleased.ReadOnly = True
        txtReleased.Size = New Size(228, 26)
        txtReleased.TabIndex = 20
        txtReleased.TabStop = False
        ' 
        ' pnlDocs
        ' 
        pnlDocs.BackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        pnlDocs.Controls.Add(lblDocsIcon)
        pnlDocs.Controls.Add(lblDocsTitle)
        pnlDocs.Controls.Add(gridDocs)
        pnlDocs.Controls.Add(lblTotal)
        pnlDocs.Location = New Point(26, 264)
        pnlDocs.Name = "pnlDocs"
        pnlDocs.Size = New Size(500, 380)
        pnlDocs.TabIndex = 21
        ' 
        ' lblDocsIcon
        ' 
        lblDocsIcon.AutoSize = True
        lblDocsIcon.Font = New Font("Segoe MDL2 Assets", 12F)
        lblDocsIcon.ForeColor = Color.FromArgb(CByte(226), CByte(186), CByte(92))
        lblDocsIcon.Location = New Point(16, 14)
        lblDocsIcon.Name = "lblDocsIcon"
        lblDocsIcon.Size = New Size(23, 16)
        lblDocsIcon.TabIndex = 22
        lblDocsIcon.Text = ""
        ' 
        ' lblDocsTitle
        ' 
        lblDocsTitle.AutoSize = True
        lblDocsTitle.Font = New Font("Segoe UI Semibold", 11F)
        lblDocsTitle.Location = New Point(40, 12)
        lblDocsTitle.Name = "lblDocsTitle"
        lblDocsTitle.Size = New Size(161, 20)
        lblDocsTitle.TabIndex = 23
        lblDocsTitle.Text = "Requested Documents"
        ' 
        ' gridDocs
        ' 
        gridDocs.AllowUserToAddRows = False
        gridDocs.AllowUserToDeleteRows = False
        gridDocs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(51), CByte(64), CByte(98))
        gridDocs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        gridDocs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gridDocs.BackgroundColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        gridDocs.BorderStyle = BorderStyle.None
        gridDocs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        gridDocs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(64))
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9.5F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        DataGridViewCellStyle2.Padding = New Padding(6, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(30), CByte(39), CByte(64))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        gridDocs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        gridDocs.ColumnHeadersHeight = 40
        gridDocs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        DataGridViewCellStyle3.Padding = New Padding(6, 0, 4, 0)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(62), CByte(104), CByte(186))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        gridDocs.DefaultCellStyle = DataGridViewCellStyle3
        gridDocs.EnableHeadersVisualStyles = False
        gridDocs.GridColor = Color.FromArgb(CByte(68), CByte(82), CByte(118))
        gridDocs.Location = New Point(18, 44)
        gridDocs.MultiSelect = False
        gridDocs.Name = "gridDocs"
        gridDocs.ReadOnly = True
        gridDocs.RowHeadersVisible = False
        gridDocs.RowTemplate.Height = 34
        gridDocs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridDocs.Size = New Size(464, 280)
        gridDocs.TabIndex = 24
        ' 
        ' lblTotal
        ' 
        lblTotal.Font = New Font("Segoe UI Semibold", 13F)
        lblTotal.ForeColor = Color.FromArgb(CByte(62), CByte(150), CByte(116))
        lblTotal.Location = New Point(18, 336)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(464, 30)
        lblTotal.TabIndex = 25
        lblTotal.Text = "Total Amount:  ₱0.00"
        lblTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlPay
        ' 
        pnlPay.BackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        pnlPay.Controls.Add(lblPayIcon)
        pnlPay.Controls.Add(lblPayTitle)
        pnlPay.Controls.Add(lblPayStatusCap)
        pnlPay.Controls.Add(cboPay)
        pnlPay.Controls.Add(lblOrCap)
        pnlPay.Controls.Add(txtOr)
        pnlPay.Controls.Add(lblOrDateCap)
        pnlPay.Controls.Add(dtpOr)
        pnlPay.Controls.Add(lblPaidCap)
        pnlPay.Controls.Add(numPaid)
        pnlPay.Controls.Add(lblChange)
        pnlPay.Controls.Add(btnSavePay)
        pnlPay.Location = New Point(540, 264)
        pnlPay.Name = "pnlPay"
        pnlPay.Size = New Size(494, 200)
        pnlPay.TabIndex = 26
        ' 
        ' lblPayIcon
        ' 
        lblPayIcon.AutoSize = True
        lblPayIcon.Font = New Font("Segoe MDL2 Assets", 12F)
        lblPayIcon.ForeColor = Color.FromArgb(CByte(226), CByte(186), CByte(92))
        lblPayIcon.Location = New Point(16, 14)
        lblPayIcon.Name = "lblPayIcon"
        lblPayIcon.Size = New Size(23, 16)
        lblPayIcon.TabIndex = 27
        lblPayIcon.Text = ""
        ' 
        ' lblPayTitle
        ' 
        lblPayTitle.AutoSize = True
        lblPayTitle.Font = New Font("Segoe UI Semibold", 11F)
        lblPayTitle.Location = New Point(40, 12)
        lblPayTitle.Name = "lblPayTitle"
        lblPayTitle.Size = New Size(154, 20)
        lblPayTitle.TabIndex = 28
        lblPayTitle.Text = "Payment Information"
        ' 
        ' lblPayStatusCap
        ' 
        lblPayStatusCap.AutoSize = True
        lblPayStatusCap.Font = New Font("Segoe UI", 9F)
        lblPayStatusCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblPayStatusCap.Location = New Point(18, 44)
        lblPayStatusCap.Name = "lblPayStatusCap"
        lblPayStatusCap.Size = New Size(89, 15)
        lblPayStatusCap.TabIndex = 29
        lblPayStatusCap.Text = "Payment Status"
        ' 
        ' cboPay
        ' 
        cboPay.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        cboPay.DropDownStyle = ComboBoxStyle.DropDownList
        cboPay.FlatStyle = FlatStyle.Flat
        cboPay.Font = New Font("Segoe UI", 10.5F)
        cboPay.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        cboPay.FormattingEnabled = True
        cboPay.Items.AddRange(New Object() {"Unpaid", "Paid"})
        cboPay.Location = New Point(18, 66)
        cboPay.Name = "cboPay"
        cboPay.Size = New Size(220, 27)
        cboPay.TabIndex = 30
        ' 
        ' lblOrCap
        ' 
        lblOrCap.AutoSize = True
        lblOrCap.Font = New Font("Segoe UI", 9F)
        lblOrCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblOrCap.Location = New Point(256, 44)
        lblOrCap.Name = "lblOrCap"
        lblOrCap.Size = New Size(70, 15)
        lblOrCap.TabIndex = 31
        lblOrCap.Text = "OR Number"
        ' 
        ' txtOr
        ' 
        txtOr.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        txtOr.BorderStyle = BorderStyle.FixedSingle
        txtOr.Font = New Font("Segoe UI", 10.5F)
        txtOr.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtOr.Location = New Point(256, 66)
        txtOr.MaxLength = 30
        txtOr.Name = "txtOr"
        txtOr.PlaceholderText = "e.g. OR-100010"
        txtOr.Size = New Size(220, 26)
        txtOr.TabIndex = 32
        ' 
        ' lblOrDateCap
        ' 
        lblOrDateCap.AutoSize = True
        lblOrDateCap.Font = New Font("Segoe UI", 9F)
        lblOrDateCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblOrDateCap.Location = New Point(18, 104)
        lblOrDateCap.Name = "lblOrDateCap"
        lblOrDateCap.Size = New Size(50, 15)
        lblOrDateCap.TabIndex = 33
        lblOrDateCap.Text = "OR Date"
        ' 
        ' dtpOr
        ' 
        dtpOr.CustomFormat = "MM/dd/yyyy"
        dtpOr.Font = New Font("Segoe UI", 10.5F)
        dtpOr.Format = DateTimePickerFormat.Custom
        dtpOr.Location = New Point(18, 126)
        dtpOr.Name = "dtpOr"
        dtpOr.Size = New Size(220, 26)
        dtpOr.TabIndex = 34
        ' 
        ' lblPaidCap
        ' 
        lblPaidCap.AutoSize = True
        lblPaidCap.Font = New Font("Segoe UI", 9F)
        lblPaidCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblPaidCap.Location = New Point(256, 104)
        lblPaidCap.Name = "lblPaidCap"
        lblPaidCap.Size = New Size(95, 15)
        lblPaidCap.TabIndex = 35
        lblPaidCap.Text = "Amount Paid (₱)"
        ' 
        ' numPaid
        ' 
        numPaid.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        numPaid.BorderStyle = BorderStyle.FixedSingle
        numPaid.DecimalPlaces = 2
        numPaid.Font = New Font("Segoe UI", 10.5F)
        numPaid.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        numPaid.Location = New Point(256, 126)
        numPaid.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numPaid.Name = "numPaid"
        numPaid.Size = New Size(220, 26)
        numPaid.TabIndex = 36
        numPaid.TextAlign = HorizontalAlignment.Right
        numPaid.ThousandsSeparator = True
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Font = New Font("Segoe UI", 9.5F)
        lblChange.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblChange.Location = New Point(18, 166)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(79, 17)
        lblChange.TabIndex = 37
        lblChange.Text = "Amount due"
        ' 
        ' btnSavePay
        ' 
        btnSavePay.BackColor = Color.FromArgb(CByte(62), CByte(150), CByte(116))
        btnSavePay.Cursor = Cursors.Hand
        btnSavePay.FlatAppearance.BorderSize = 0
        btnSavePay.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(86), CByte(168), CByte(136))
        btnSavePay.FlatStyle = FlatStyle.Flat
        btnSavePay.Font = New Font("Segoe UI Semibold", 9.5F)
        btnSavePay.ForeColor = Color.White
        btnSavePay.Image = My.Resources.Resources.btn_money
        btnSavePay.Location = New Point(326, 158)
        btnSavePay.Name = "btnSavePay"
        btnSavePay.Size = New Size(150, 34)
        btnSavePay.TabIndex = 38
        btnSavePay.Text = " Save Payment"
        btnSavePay.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSavePay.UseVisualStyleBackColor = False
        ' 
        ' pnlStatus
        ' 
        pnlStatus.BackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        pnlStatus.Controls.Add(lblStatusIcon)
        pnlStatus.Controls.Add(lblStatusTitle)
        pnlStatus.Controls.Add(lblCurrentCap)
        pnlStatus.Controls.Add(txtCurrent)
        pnlStatus.Controls.Add(lblNextCap)
        pnlStatus.Controls.Add(cboNext)
        pnlStatus.Controls.Add(lblStatusHint)
        pnlStatus.Controls.Add(btnStatus)
        pnlStatus.Location = New Point(540, 478)
        pnlStatus.Name = "pnlStatus"
        pnlStatus.Size = New Size(494, 166)
        pnlStatus.TabIndex = 39
        ' 
        ' lblStatusIcon
        ' 
        lblStatusIcon.AutoSize = True
        lblStatusIcon.Font = New Font("Segoe MDL2 Assets", 12F)
        lblStatusIcon.ForeColor = Color.FromArgb(CByte(226), CByte(186), CByte(92))
        lblStatusIcon.Location = New Point(16, 14)
        lblStatusIcon.Name = "lblStatusIcon"
        lblStatusIcon.Size = New Size(23, 16)
        lblStatusIcon.TabIndex = 40
        lblStatusIcon.Text = ""
        ' 
        ' lblStatusTitle
        ' 
        lblStatusTitle.AutoSize = True
        lblStatusTitle.Font = New Font("Segoe UI Semibold", 11F)
        lblStatusTitle.Location = New Point(40, 12)
        lblStatusTitle.Name = "lblStatusTitle"
        lblStatusTitle.Size = New Size(108, 20)
        lblStatusTitle.TabIndex = 41
        lblStatusTitle.Text = "Request Status"
        ' 
        ' lblCurrentCap
        ' 
        lblCurrentCap.AutoSize = True
        lblCurrentCap.Font = New Font("Segoe UI", 9F)
        lblCurrentCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblCurrentCap.Location = New Point(18, 44)
        lblCurrentCap.Name = "lblCurrentCap"
        lblCurrentCap.Size = New Size(82, 15)
        lblCurrentCap.TabIndex = 42
        lblCurrentCap.Text = "Current Status"
        ' 
        ' txtCurrent
        ' 
        txtCurrent.BackColor = Color.FromArgb(CByte(42), CByte(53), CByte(83))
        txtCurrent.BorderStyle = BorderStyle.FixedSingle
        txtCurrent.Font = New Font("Segoe UI", 10.5F)
        txtCurrent.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        txtCurrent.Location = New Point(18, 66)
        txtCurrent.Name = "txtCurrent"
        txtCurrent.ReadOnly = True
        txtCurrent.Size = New Size(220, 26)
        txtCurrent.TabIndex = 43
        txtCurrent.TabStop = False
        ' 
        ' lblNextCap
        ' 
        lblNextCap.AutoSize = True
        lblNextCap.Font = New Font("Segoe UI", 9F)
        lblNextCap.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblNextCap.Location = New Point(256, 44)
        lblNextCap.Name = "lblNextCap"
        lblNextCap.Size = New Size(99, 15)
        lblNextCap.TabIndex = 44
        lblNextCap.Text = "Change Status To"
        ' 
        ' cboNext
        ' 
        cboNext.BackColor = Color.FromArgb(CByte(58), CByte(72), CByte(108))
        cboNext.DropDownStyle = ComboBoxStyle.DropDownList
        cboNext.FlatStyle = FlatStyle.Flat
        cboNext.Font = New Font("Segoe UI", 10.5F)
        cboNext.ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        cboNext.FormattingEnabled = True
        cboNext.Location = New Point(256, 66)
        cboNext.Name = "cboNext"
        cboNext.Size = New Size(220, 27)
        cboNext.TabIndex = 45
        ' 
        ' lblStatusHint
        ' 
        lblStatusHint.Font = New Font("Segoe UI", 9F)
        lblStatusHint.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblStatusHint.Location = New Point(18, 104)
        lblStatusHint.Name = "lblStatusHint"
        lblStatusHint.Size = New Size(290, 48)
        lblStatusHint.TabIndex = 46
        lblStatusHint.Text = "Flow: Pending > Processing > Ready for Release > Released"
        ' 
        ' btnStatus
        ' 
        btnStatus.BackColor = Color.FromArgb(CByte(62), CByte(104), CByte(186))
        btnStatus.Cursor = Cursors.Hand
        btnStatus.FlatAppearance.BorderSize = 0
        btnStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(82), CByte(124), CByte(204))
        btnStatus.FlatStyle = FlatStyle.Flat
        btnStatus.Font = New Font("Segoe UI Semibold", 9.5F)
        btnStatus.ForeColor = Color.White
        btnStatus.Image = My.Resources.Resources.btn_sync
        btnStatus.Location = New Point(326, 110)
        btnStatus.Name = "btnStatus"
        btnStatus.Size = New Size(150, 34)
        btnStatus.TabIndex = 47
        btnStatus.Text = " Update Status"
        btnStatus.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStatus.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(78), CByte(92), CByte(128))
        btnClose.Cursor = Cursors.Hand
        btnClose.DialogResult = DialogResult.Cancel
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(96), CByte(110), CByte(146))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Semibold", 9.5F)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(924, 660)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(110, 36)
        btnClose.TabIndex = 48
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' RequestDetailsDialog
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(37), CByte(47), CByte(75))
        CancelButton = btnClose
        ClientSize = New Size(1060, 712)
        Controls.Add(flpHeader)
        Controls.Add(pnlInfo)
        Controls.Add(pnlDocs)
        Controls.Add(pnlPay)
        Controls.Add(pnlStatus)
        Controls.Add(btnClose)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "RequestDetailsDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Request Details"
        flpHeader.ResumeLayout(False)
        flpHeader.PerformLayout()
        pnlInfo.ResumeLayout(False)
        pnlInfo.PerformLayout()
        pnlDocs.ResumeLayout(False)
        pnlDocs.PerformLayout()
        CType(gridDocs, ComponentModel.ISupportInitialize).EndInit()
        pnlPay.ResumeLayout(False)
        pnlPay.PerformLayout()
        CType(numPaid, ComponentModel.ISupportInitialize).EndInit()
        pnlStatus.ResumeLayout(False)
        pnlStatus.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents flpHeader As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblReqNo As System.Windows.Forms.Label
    Friend WithEvents lblStatusBadge As System.Windows.Forms.Label
    Friend WithEvents lblPayBadge As System.Windows.Forms.Label
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblInfoIcon As System.Windows.Forms.Label
    Friend WithEvents lblInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblDateCap As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentIdCap As System.Windows.Forms.Label
    Friend WithEvents txtStudentId As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentCap As System.Windows.Forms.Label
    Friend WithEvents txtStudent As System.Windows.Forms.TextBox
    Friend WithEvents lblCourseCap As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents lblContactCap As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblByCap As System.Windows.Forms.Label
    Friend WithEvents txtBy As System.Windows.Forms.TextBox
    Friend WithEvents lblReleasedCap As System.Windows.Forms.Label
    Friend WithEvents txtReleased As System.Windows.Forms.TextBox
    Friend WithEvents pnlDocs As System.Windows.Forms.Panel
    Friend WithEvents lblDocsIcon As System.Windows.Forms.Label
    Friend WithEvents lblDocsTitle As System.Windows.Forms.Label
    Friend WithEvents gridDocs As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents pnlPay As System.Windows.Forms.Panel
    Friend WithEvents lblPayIcon As System.Windows.Forms.Label
    Friend WithEvents lblPayTitle As System.Windows.Forms.Label
    Friend WithEvents lblPayStatusCap As System.Windows.Forms.Label
    Friend WithEvents cboPay As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrCap As System.Windows.Forms.Label
    Friend WithEvents txtOr As System.Windows.Forms.TextBox
    Friend WithEvents lblOrDateCap As System.Windows.Forms.Label
    Friend WithEvents dtpOr As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPaidCap As System.Windows.Forms.Label
    Friend WithEvents numPaid As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents btnSavePay As System.Windows.Forms.Button
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lblStatusIcon As System.Windows.Forms.Label
    Friend WithEvents lblStatusTitle As System.Windows.Forms.Label
    Friend WithEvents lblCurrentCap As System.Windows.Forms.Label
    Friend WithEvents txtCurrent As System.Windows.Forms.TextBox
    Friend WithEvents lblNextCap As System.Windows.Forms.Label
    Friend WithEvents cboNext As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatusHint As System.Windows.Forms.Label
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
