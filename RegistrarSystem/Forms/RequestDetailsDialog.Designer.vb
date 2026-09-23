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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.flpHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblReqNo = New System.Windows.Forms.Label()
        Me.lblStatusBadge = New System.Windows.Forms.Label()
        Me.lblPayBadge = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblInfoIcon = New System.Windows.Forms.Label()
        Me.lblInfoTitle = New System.Windows.Forms.Label()
        Me.lblDateCap = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblStudentIdCap = New System.Windows.Forms.Label()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.lblStudentCap = New System.Windows.Forms.Label()
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.lblCourseCap = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblContactCap = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblByCap = New System.Windows.Forms.Label()
        Me.txtBy = New System.Windows.Forms.TextBox()
        Me.lblReleasedCap = New System.Windows.Forms.Label()
        Me.txtReleased = New System.Windows.Forms.TextBox()
        Me.pnlDocs = New System.Windows.Forms.Panel()
        Me.lblDocsIcon = New System.Windows.Forms.Label()
        Me.lblDocsTitle = New System.Windows.Forms.Label()
        Me.gridDocs = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pnlPay = New System.Windows.Forms.Panel()
        Me.lblPayIcon = New System.Windows.Forms.Label()
        Me.lblPayTitle = New System.Windows.Forms.Label()
        Me.lblPayStatusCap = New System.Windows.Forms.Label()
        Me.cboPay = New System.Windows.Forms.ComboBox()
        Me.lblOrCap = New System.Windows.Forms.Label()
        Me.txtOr = New System.Windows.Forms.TextBox()
        Me.lblOrDateCap = New System.Windows.Forms.Label()
        Me.dtpOr = New System.Windows.Forms.DateTimePicker()
        Me.lblPaidCap = New System.Windows.Forms.Label()
        Me.numPaid = New System.Windows.Forms.NumericUpDown()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnSavePay = New System.Windows.Forms.Button()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblStatusIcon = New System.Windows.Forms.Label()
        Me.lblStatusTitle = New System.Windows.Forms.Label()
        Me.lblCurrentCap = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.lblNextCap = New System.Windows.Forms.Label()
        Me.cboNext = New System.Windows.Forms.ComboBox()
        Me.lblStatusHint = New System.Windows.Forms.Label()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.gridDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.flpHeader.Controls.Add(Me.lblReqNo)
        Me.flpHeader.Controls.Add(Me.lblStatusBadge)
        Me.flpHeader.Controls.Add(Me.lblPayBadge)
        Me.flpHeader.Location = New System.Drawing.Point(26, 16)
        Me.flpHeader.Size = New System.Drawing.Size(900, 46)
        Me.flpHeader.Name = "flpHeader"
        Me.flpHeader.TabIndex = 0
        Me.flpHeader.WrapContents = False
        Me.lblReqNo.AutoSize = True
        Me.lblReqNo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblReqNo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!)
        Me.lblReqNo.Location = New System.Drawing.Point(0, 0)
        Me.lblReqNo.Size = New System.Drawing.Size(40, 19)
        Me.lblReqNo.Name = "lblReqNo"
        Me.lblReqNo.TabIndex = 1
        Me.lblReqNo.Text = "REQ-2026-00000"
        Me.lblStatusBadge.AutoSize = True
        Me.lblStatusBadge.Margin = New System.Windows.Forms.Padding(0, 8, 8, 0)
        Me.lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(232, 172, 48)
        Me.lblStatusBadge.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.lblStatusBadge.ForeColor = System.Drawing.Color.White
        Me.lblStatusBadge.Location = New System.Drawing.Point(0, 0)
        Me.lblStatusBadge.Padding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.lblStatusBadge.Size = New System.Drawing.Size(40, 19)
        Me.lblStatusBadge.Name = "lblStatusBadge"
        Me.lblStatusBadge.TabIndex = 2
        Me.lblStatusBadge.Text = "Pending"
        Me.lblPayBadge.AutoSize = True
        Me.lblPayBadge.Margin = New System.Windows.Forms.Padding(0, 8, 8, 0)
        Me.lblPayBadge.BackColor = System.Drawing.Color.FromArgb(230, 126, 34)
        Me.lblPayBadge.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.lblPayBadge.ForeColor = System.Drawing.Color.White
        Me.lblPayBadge.Location = New System.Drawing.Point(0, 0)
        Me.lblPayBadge.Padding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.lblPayBadge.Size = New System.Drawing.Size(40, 19)
        Me.lblPayBadge.Name = "lblPayBadge"
        Me.lblPayBadge.TabIndex = 3
        Me.lblPayBadge.Text = "Unpaid"
        Me.pnlInfo.BackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.pnlInfo.Controls.Add(Me.lblInfoIcon)
        Me.pnlInfo.Controls.Add(Me.lblInfoTitle)
        Me.pnlInfo.Controls.Add(Me.lblDateCap)
        Me.pnlInfo.Controls.Add(Me.txtDate)
        Me.pnlInfo.Controls.Add(Me.lblStudentIdCap)
        Me.pnlInfo.Controls.Add(Me.txtStudentId)
        Me.pnlInfo.Controls.Add(Me.lblStudentCap)
        Me.pnlInfo.Controls.Add(Me.txtStudent)
        Me.pnlInfo.Controls.Add(Me.lblCourseCap)
        Me.pnlInfo.Controls.Add(Me.txtCourse)
        Me.pnlInfo.Controls.Add(Me.lblContactCap)
        Me.pnlInfo.Controls.Add(Me.txtContact)
        Me.pnlInfo.Controls.Add(Me.lblByCap)
        Me.pnlInfo.Controls.Add(Me.txtBy)
        Me.pnlInfo.Controls.Add(Me.lblReleasedCap)
        Me.pnlInfo.Controls.Add(Me.txtReleased)
        Me.pnlInfo.Location = New System.Drawing.Point(26, 72)
        Me.pnlInfo.Size = New System.Drawing.Size(1008, 178)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.TabIndex = 4
        Me.lblInfoIcon.AutoSize = True
        Me.lblInfoIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
        Me.lblInfoIcon.ForeColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblInfoIcon.Location = New System.Drawing.Point(16, 14)
        Me.lblInfoIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblInfoIcon.Name = "lblInfoIcon"
        Me.lblInfoIcon.TabIndex = 5
        Me.lblInfoIcon.Text = ""
        Me.lblInfoTitle.AutoSize = True
        Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblInfoTitle.Location = New System.Drawing.Point(40, 12)
        Me.lblInfoTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.TabIndex = 6
        Me.lblInfoTitle.Text = "Request Information"
        Me.lblDateCap.AutoSize = True
        Me.lblDateCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDateCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblDateCap.Location = New System.Drawing.Point(18, 44)
        Me.lblDateCap.Size = New System.Drawing.Size(40, 19)
        Me.lblDateCap.Name = "lblDateCap"
        Me.lblDateCap.TabIndex = 7
        Me.lblDateCap.Text = "Request Date"
        Me.txtDate.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtDate.Location = New System.Drawing.Point(18, 66)
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(230, 26)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.TabIndex = 8
        Me.txtDate.TabStop = False
        Me.lblStudentIdCap.AutoSize = True
        Me.lblStudentIdCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStudentIdCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblStudentIdCap.Location = New System.Drawing.Point(266, 44)
        Me.lblStudentIdCap.Size = New System.Drawing.Size(40, 19)
        Me.lblStudentIdCap.Name = "lblStudentIdCap"
        Me.lblStudentIdCap.TabIndex = 9
        Me.lblStudentIdCap.Text = "Student ID"
        Me.txtStudentId.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentId.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtStudentId.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtStudentId.Location = New System.Drawing.Point(266, 66)
        Me.txtStudentId.ReadOnly = True
        Me.txtStudentId.Size = New System.Drawing.Size(230, 26)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.TabIndex = 10
        Me.txtStudentId.TabStop = False
        Me.lblStudentCap.AutoSize = True
        Me.lblStudentCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStudentCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblStudentCap.Location = New System.Drawing.Point(514, 44)
        Me.lblStudentCap.Size = New System.Drawing.Size(40, 19)
        Me.lblStudentCap.Name = "lblStudentCap"
        Me.lblStudentCap.TabIndex = 11
        Me.lblStudentCap.Text = "Student Name"
        Me.txtStudent.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudent.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtStudent.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtStudent.Location = New System.Drawing.Point(514, 66)
        Me.txtStudent.ReadOnly = True
        Me.txtStudent.Size = New System.Drawing.Size(476, 26)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.TabIndex = 12
        Me.txtStudent.TabStop = False
        Me.lblCourseCap.AutoSize = True
        Me.lblCourseCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCourseCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblCourseCap.Location = New System.Drawing.Point(18, 104)
        Me.lblCourseCap.Size = New System.Drawing.Size(40, 19)
        Me.lblCourseCap.Name = "lblCourseCap"
        Me.lblCourseCap.TabIndex = 13
        Me.lblCourseCap.Text = "Course / Year / Section"
        Me.txtCourse.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtCourse.Location = New System.Drawing.Point(18, 126)
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(230, 26)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.TabIndex = 14
        Me.txtCourse.TabStop = False
        Me.lblContactCap.AutoSize = True
        Me.lblContactCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblContactCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblContactCap.Location = New System.Drawing.Point(266, 104)
        Me.lblContactCap.Size = New System.Drawing.Size(40, 19)
        Me.lblContactCap.Name = "lblContactCap"
        Me.lblContactCap.TabIndex = 15
        Me.lblContactCap.Text = "Contact No."
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtContact.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtContact.Location = New System.Drawing.Point(266, 126)
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(230, 26)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.TabIndex = 16
        Me.txtContact.TabStop = False
        Me.lblByCap.AutoSize = True
        Me.lblByCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblByCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblByCap.Location = New System.Drawing.Point(514, 104)
        Me.lblByCap.Size = New System.Drawing.Size(40, 19)
        Me.lblByCap.Name = "lblByCap"
        Me.lblByCap.TabIndex = 17
        Me.lblByCap.Text = "Processed By"
        Me.txtBy.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBy.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtBy.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtBy.Location = New System.Drawing.Point(514, 126)
        Me.txtBy.ReadOnly = True
        Me.txtBy.Size = New System.Drawing.Size(230, 26)
        Me.txtBy.Name = "txtBy"
        Me.txtBy.TabIndex = 18
        Me.txtBy.TabStop = False
        Me.lblReleasedCap.AutoSize = True
        Me.lblReleasedCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblReleasedCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblReleasedCap.Location = New System.Drawing.Point(762, 104)
        Me.lblReleasedCap.Size = New System.Drawing.Size(40, 19)
        Me.lblReleasedCap.Name = "lblReleasedCap"
        Me.lblReleasedCap.TabIndex = 19
        Me.lblReleasedCap.Text = "Released On"
        Me.txtReleased.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtReleased.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReleased.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtReleased.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtReleased.Location = New System.Drawing.Point(762, 126)
        Me.txtReleased.ReadOnly = True
        Me.txtReleased.Size = New System.Drawing.Size(228, 26)
        Me.txtReleased.Name = "txtReleased"
        Me.txtReleased.TabIndex = 20
        Me.txtReleased.TabStop = False
        Me.pnlDocs.BackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.pnlDocs.Controls.Add(Me.lblDocsIcon)
        Me.pnlDocs.Controls.Add(Me.lblDocsTitle)
        Me.pnlDocs.Controls.Add(Me.gridDocs)
        Me.pnlDocs.Controls.Add(Me.lblTotal)
        Me.pnlDocs.Location = New System.Drawing.Point(26, 264)
        Me.pnlDocs.Size = New System.Drawing.Size(500, 380)
        Me.pnlDocs.Name = "pnlDocs"
        Me.pnlDocs.TabIndex = 21
        Me.lblDocsIcon.AutoSize = True
        Me.lblDocsIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
        Me.lblDocsIcon.ForeColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblDocsIcon.Location = New System.Drawing.Point(16, 14)
        Me.lblDocsIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblDocsIcon.Name = "lblDocsIcon"
        Me.lblDocsIcon.TabIndex = 22
        Me.lblDocsIcon.Text = ""
        Me.lblDocsTitle.AutoSize = True
        Me.lblDocsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblDocsTitle.Location = New System.Drawing.Point(40, 12)
        Me.lblDocsTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblDocsTitle.Name = "lblDocsTitle"
        Me.lblDocsTitle.TabIndex = 23
        Me.lblDocsTitle.Text = "Requested Documents"
        Me.gridDocs.AllowUserToAddRows = False
        Me.gridDocs.AllowUserToDeleteRows = False
        Me.gridDocs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(57, 61, 80)
        Me.gridDocs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridDocs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridDocs.BackgroundColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.gridDocs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridDocs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridDocs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(31, 33, 45)
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(31, 33, 45)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDocs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridDocs.ColumnHeadersHeight = 40
        Me.gridDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridDocs.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridDocs.EnableHeadersVisualStyles = False
        Me.gridDocs.GridColor = System.Drawing.Color.FromArgb(76, 81, 104)
        Me.gridDocs.Location = New System.Drawing.Point(18, 44)
        Me.gridDocs.MultiSelect = False
        Me.gridDocs.ReadOnly = True
        Me.gridDocs.RowHeadersVisible = False
        Me.gridDocs.RowTemplate.Height = 34
        Me.gridDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDocs.Size = New System.Drawing.Size(464, 280)
        Me.gridDocs.Name = "gridDocs"
        Me.gridDocs.TabIndex = 24
        Me.lblTotal.AutoSize = False
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(38, 170, 118)
        Me.lblTotal.Location = New System.Drawing.Point(18, 336)
        Me.lblTotal.Size = New System.Drawing.Size(464, 30)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "Total Amount:  ₱0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.pnlPay.BackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.pnlPay.Controls.Add(Me.lblPayIcon)
        Me.pnlPay.Controls.Add(Me.lblPayTitle)
        Me.pnlPay.Controls.Add(Me.lblPayStatusCap)
        Me.pnlPay.Controls.Add(Me.cboPay)
        Me.pnlPay.Controls.Add(Me.lblOrCap)
        Me.pnlPay.Controls.Add(Me.txtOr)
        Me.pnlPay.Controls.Add(Me.lblOrDateCap)
        Me.pnlPay.Controls.Add(Me.dtpOr)
        Me.pnlPay.Controls.Add(Me.lblPaidCap)
        Me.pnlPay.Controls.Add(Me.numPaid)
        Me.pnlPay.Controls.Add(Me.lblChange)
        Me.pnlPay.Controls.Add(Me.btnSavePay)
        Me.pnlPay.Location = New System.Drawing.Point(540, 264)
        Me.pnlPay.Size = New System.Drawing.Size(494, 200)
        Me.pnlPay.Name = "pnlPay"
        Me.pnlPay.TabIndex = 26
        Me.lblPayIcon.AutoSize = True
        Me.lblPayIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
        Me.lblPayIcon.ForeColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblPayIcon.Location = New System.Drawing.Point(16, 14)
        Me.lblPayIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblPayIcon.Name = "lblPayIcon"
        Me.lblPayIcon.TabIndex = 27
        Me.lblPayIcon.Text = ""
        Me.lblPayTitle.AutoSize = True
        Me.lblPayTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblPayTitle.Location = New System.Drawing.Point(40, 12)
        Me.lblPayTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblPayTitle.Name = "lblPayTitle"
        Me.lblPayTitle.TabIndex = 28
        Me.lblPayTitle.Text = "Payment Information"
        Me.lblPayStatusCap.AutoSize = True
        Me.lblPayStatusCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPayStatusCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblPayStatusCap.Location = New System.Drawing.Point(18, 44)
        Me.lblPayStatusCap.Size = New System.Drawing.Size(40, 19)
        Me.lblPayStatusCap.Name = "lblPayStatusCap"
        Me.lblPayStatusCap.TabIndex = 29
        Me.lblPayStatusCap.Text = "Payment Status"
        Me.cboPay.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.cboPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPay.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboPay.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.cboPay.FormattingEnabled = True
        Me.cboPay.Items.AddRange(New Object() {"Unpaid", "Paid"})
        Me.cboPay.Location = New System.Drawing.Point(18, 66)
        Me.cboPay.Size = New System.Drawing.Size(220, 27)
        Me.cboPay.Name = "cboPay"
        Me.cboPay.TabIndex = 30
        Me.lblOrCap.AutoSize = True
        Me.lblOrCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOrCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblOrCap.Location = New System.Drawing.Point(256, 44)
        Me.lblOrCap.Size = New System.Drawing.Size(40, 19)
        Me.lblOrCap.Name = "lblOrCap"
        Me.lblOrCap.TabIndex = 31
        Me.lblOrCap.Text = "OR Number"
        Me.txtOr.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.txtOr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOr.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtOr.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtOr.Location = New System.Drawing.Point(256, 66)
        Me.txtOr.MaxLength = 30
        Me.txtOr.PlaceholderText = "e.g. OR-100010"
        Me.txtOr.Size = New System.Drawing.Size(220, 26)
        Me.txtOr.Name = "txtOr"
        Me.txtOr.TabIndex = 32
        Me.lblOrDateCap.AutoSize = True
        Me.lblOrDateCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOrDateCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblOrDateCap.Location = New System.Drawing.Point(18, 104)
        Me.lblOrDateCap.Size = New System.Drawing.Size(40, 19)
        Me.lblOrDateCap.Name = "lblOrDateCap"
        Me.lblOrDateCap.TabIndex = 33
        Me.lblOrDateCap.Text = "OR Date"
        Me.dtpOr.CustomFormat = "MM/dd/yyyy"
        Me.dtpOr.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtpOr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOr.Location = New System.Drawing.Point(18, 126)
        Me.dtpOr.Size = New System.Drawing.Size(220, 26)
        Me.dtpOr.Name = "dtpOr"
        Me.dtpOr.TabIndex = 34
        Me.lblPaidCap.AutoSize = True
        Me.lblPaidCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPaidCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblPaidCap.Location = New System.Drawing.Point(256, 104)
        Me.lblPaidCap.Size = New System.Drawing.Size(40, 19)
        Me.lblPaidCap.Name = "lblPaidCap"
        Me.lblPaidCap.TabIndex = 35
        Me.lblPaidCap.Text = "Amount Paid (₱)"
        Me.numPaid.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.numPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numPaid.DecimalPlaces = 2
        Me.numPaid.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.numPaid.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.numPaid.Location = New System.Drawing.Point(256, 126)
        Me.numPaid.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numPaid.Size = New System.Drawing.Size(220, 26)
        Me.numPaid.Name = "numPaid"
        Me.numPaid.TabIndex = 36
        Me.numPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPaid.ThousandsSeparator = True
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblChange.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblChange.Location = New System.Drawing.Point(18, 166)
        Me.lblChange.Size = New System.Drawing.Size(40, 19)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.TabIndex = 37
        Me.lblChange.Text = "Amount due"
        Me.btnSavePay.BackColor = System.Drawing.Color.FromArgb(38, 170, 118)
        Me.btnSavePay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavePay.FlatAppearance.BorderSize = 0
        Me.btnSavePay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(81, 187, 145)
        Me.btnSavePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnSavePay.ForeColor = System.Drawing.Color.White
        Me.btnSavePay.Image = Global.RegistrarSystem.My.Resources.Resources.btn_money
        Me.btnSavePay.Location = New System.Drawing.Point(326, 158)
        Me.btnSavePay.Size = New System.Drawing.Size(150, 34)
        Me.btnSavePay.Name = "btnSavePay"
        Me.btnSavePay.TabIndex = 38
        Me.btnSavePay.Text = " Save Payment"
        Me.btnSavePay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSavePay.UseVisualStyleBackColor = False
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.pnlStatus.Controls.Add(Me.lblStatusIcon)
        Me.pnlStatus.Controls.Add(Me.lblStatusTitle)
        Me.pnlStatus.Controls.Add(Me.lblCurrentCap)
        Me.pnlStatus.Controls.Add(Me.txtCurrent)
        Me.pnlStatus.Controls.Add(Me.lblNextCap)
        Me.pnlStatus.Controls.Add(Me.cboNext)
        Me.pnlStatus.Controls.Add(Me.lblStatusHint)
        Me.pnlStatus.Controls.Add(Me.btnStatus)
        Me.pnlStatus.Location = New System.Drawing.Point(540, 478)
        Me.pnlStatus.Size = New System.Drawing.Size(494, 166)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.TabIndex = 39
        Me.lblStatusIcon.AutoSize = True
        Me.lblStatusIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
        Me.lblStatusIcon.ForeColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblStatusIcon.Location = New System.Drawing.Point(16, 14)
        Me.lblStatusIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblStatusIcon.Name = "lblStatusIcon"
        Me.lblStatusIcon.TabIndex = 40
        Me.lblStatusIcon.Text = ""
        Me.lblStatusTitle.AutoSize = True
        Me.lblStatusTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblStatusTitle.Location = New System.Drawing.Point(40, 12)
        Me.lblStatusTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblStatusTitle.Name = "lblStatusTitle"
        Me.lblStatusTitle.TabIndex = 41
        Me.lblStatusTitle.Text = "Request Status"
        Me.lblCurrentCap.AutoSize = True
        Me.lblCurrentCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCurrentCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblCurrentCap.Location = New System.Drawing.Point(18, 44)
        Me.lblCurrentCap.Size = New System.Drawing.Size(40, 19)
        Me.lblCurrentCap.Name = "lblCurrentCap"
        Me.lblCurrentCap.TabIndex = 42
        Me.lblCurrentCap.Text = "Current Status"
        Me.txtCurrent.BackColor = System.Drawing.Color.FromArgb(46, 49, 64)
        Me.txtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtCurrent.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.txtCurrent.Location = New System.Drawing.Point(18, 66)
        Me.txtCurrent.ReadOnly = True
        Me.txtCurrent.Size = New System.Drawing.Size(220, 26)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.TabIndex = 43
        Me.txtCurrent.TabStop = False
        Me.lblNextCap.AutoSize = True
        Me.lblNextCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNextCap.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblNextCap.Location = New System.Drawing.Point(256, 44)
        Me.lblNextCap.Size = New System.Drawing.Size(40, 19)
        Me.lblNextCap.Name = "lblNextCap"
        Me.lblNextCap.TabIndex = 44
        Me.lblNextCap.Text = "Change Status To"
        Me.cboNext.BackColor = System.Drawing.Color.FromArgb(66, 70, 91)
        Me.cboNext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNext.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboNext.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.cboNext.FormattingEnabled = True
        Me.cboNext.Location = New System.Drawing.Point(256, 66)
        Me.cboNext.Size = New System.Drawing.Size(220, 27)
        Me.cboNext.Name = "cboNext"
        Me.cboNext.TabIndex = 45
        Me.lblStatusHint.AutoSize = False
        Me.lblStatusHint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusHint.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblStatusHint.Location = New System.Drawing.Point(18, 104)
        Me.lblStatusHint.Size = New System.Drawing.Size(290, 48)
        Me.lblStatusHint.Name = "lblStatusHint"
        Me.lblStatusHint.TabIndex = 46
        Me.lblStatusHint.Text = "Flow: Pending > Processing > Ready for Release > Released"
        Me.btnStatus.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatus.FlatAppearance.BorderSize = 0
        Me.btnStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(110, 151, 255)
        Me.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnStatus.ForeColor = System.Drawing.Color.White
        Me.btnStatus.Image = Global.RegistrarSystem.My.Resources.Resources.btn_sync
        Me.btnStatus.Location = New System.Drawing.Point(326, 110)
        Me.btnStatus.Size = New System.Drawing.Size(150, 34)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.TabIndex = 47
        Me.btnStatus.Text = " Update Status"
        Me.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatus.UseVisualStyleBackColor = False
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(92, 98, 120)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(125, 129, 147)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(924, 660)
        Me.btnClose.Size = New System.Drawing.Size(110, 36)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 48
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(41, 44, 58)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1060, 712)
        Me.Controls.Add(Me.flpHeader)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlDocs)
        Me.Controls.Add(Me.pnlPay)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RequestDetailsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Request Details"
        CType(Me.gridDocs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
