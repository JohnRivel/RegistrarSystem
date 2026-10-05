<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewRequestForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblInfoIcon = New System.Windows.Forms.Label()
        Me.lblInfoTitle = New System.Windows.Forms.Label()
        Me.lblReqNoCap = New System.Windows.Forms.Label()
        Me.txtReqNo = New System.Windows.Forms.TextBox()
        Me.lblDateCap = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStatusCap = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblPayCap = New System.Windows.Forms.Label()
        Me.txtPayStatus = New System.Windows.Forms.TextBox()
        Me.lblByCap = New System.Windows.Forms.Label()
        Me.txtBy = New System.Windows.Forms.TextBox()
        Me.pnlStudent = New System.Windows.Forms.Panel()
        Me.lblStudIcon = New System.Windows.Forms.Label()
        Me.lblStudTitle = New System.Windows.Forms.Label()
        Me.lblIdCap = New System.Windows.Forms.Label()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblNameCap = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCourseCap = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblYearCap = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.pnlDocs = New System.Windows.Forms.Panel()
        Me.lblDocIcon = New System.Windows.Forms.Label()
        Me.lblDocTitle = New System.Windows.Forms.Label()
        Me.lblDocCap = New System.Windows.Forms.Label()
        Me.cboDoc = New System.Windows.Forms.ComboBox()
        Me.lblQtyCap = New System.Windows.Forms.Label()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridItems = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblTotalCaption = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.lblIcon.AutoSize = True
        Me.lblIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 22.0!)
        Me.lblIcon.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblIcon.Location = New System.Drawing.Point(26, 22)
        Me.lblIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.TabIndex = 0
        Me.lblIcon.Text = ""
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 17.0!)
        Me.lblTitle.Location = New System.Drawing.Point(70, 18)
        Me.lblTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "New Document Request"
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblSubtitle.Location = New System.Drawing.Point(72, 56)
        Me.lblSubtitle.Size = New System.Drawing.Size(40, 19)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Search the student, add the documents, then save the request"
        Me.pnlInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInfo.BackColor = System.Drawing.Color.FromArgb(46, 58, 90)
        Me.pnlInfo.Controls.Add(Me.lblInfoIcon)
        Me.pnlInfo.Controls.Add(Me.lblInfoTitle)
        Me.pnlInfo.Controls.Add(Me.lblReqNoCap)
        Me.pnlInfo.Controls.Add(Me.txtReqNo)
        Me.pnlInfo.Controls.Add(Me.lblDateCap)
        Me.pnlInfo.Controls.Add(Me.dtpDate)
        Me.pnlInfo.Controls.Add(Me.lblStatusCap)
        Me.pnlInfo.Controls.Add(Me.txtStatus)
        Me.pnlInfo.Controls.Add(Me.lblPayCap)
        Me.pnlInfo.Controls.Add(Me.txtPayStatus)
        Me.pnlInfo.Controls.Add(Me.lblByCap)
        Me.pnlInfo.Controls.Add(Me.txtBy)
        Me.pnlInfo.Location = New System.Drawing.Point(26, 90)
        Me.pnlInfo.Size = New System.Drawing.Size(988, 100)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.TabIndex = 3
        Me.lblInfoIcon.AutoSize = True
        Me.lblInfoIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
        Me.lblInfoIcon.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblInfoIcon.Location = New System.Drawing.Point(16, 14)
        Me.lblInfoIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblInfoIcon.Name = "lblInfoIcon"
        Me.lblInfoIcon.TabIndex = 4
        Me.lblInfoIcon.Text = ""
        Me.lblInfoTitle.AutoSize = True
        Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblInfoTitle.Location = New System.Drawing.Point(40, 12)
        Me.lblInfoTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.TabIndex = 5
        Me.lblInfoTitle.Text = "Request Information"
        Me.lblReqNoCap.AutoSize = True
        Me.lblReqNoCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblReqNoCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblReqNoCap.Location = New System.Drawing.Point(18, 44)
        Me.lblReqNoCap.Size = New System.Drawing.Size(40, 19)
        Me.lblReqNoCap.Name = "lblReqNoCap"
        Me.lblReqNoCap.TabIndex = 6
        Me.lblReqNoCap.Text = "Request Number"
        Me.txtReqNo.BackColor = System.Drawing.Color.FromArgb(42, 53, 83)
        Me.txtReqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReqNo.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtReqNo.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtReqNo.Location = New System.Drawing.Point(18, 64)
        Me.txtReqNo.ReadOnly = True
        Me.txtReqNo.Size = New System.Drawing.Size(180, 26)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.TabIndex = 7
        Me.txtReqNo.TabStop = False
        Me.lblDateCap.AutoSize = True
        Me.lblDateCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDateCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblDateCap.Location = New System.Drawing.Point(212, 44)
        Me.lblDateCap.Size = New System.Drawing.Size(40, 19)
        Me.lblDateCap.Name = "lblDateCap"
        Me.lblDateCap.TabIndex = 8
        Me.lblDateCap.Text = "Request Date"
        Me.dtpDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(212, 64)
        Me.dtpDate.Size = New System.Drawing.Size(150, 26)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.TabIndex = 9
        Me.lblStatusCap.AutoSize = True
        Me.lblStatusCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblStatusCap.Location = New System.Drawing.Point(376, 44)
        Me.lblStatusCap.Size = New System.Drawing.Size(40, 19)
        Me.lblStatusCap.Name = "lblStatusCap"
        Me.lblStatusCap.TabIndex = 10
        Me.lblStatusCap.Text = "Request Status"
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(42, 53, 83)
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtStatus.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtStatus.Location = New System.Drawing.Point(376, 64)
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(150, 26)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.TabIndex = 11
        Me.txtStatus.TabStop = False
        Me.txtStatus.Text = "Pending"
        Me.lblPayCap.AutoSize = True
        Me.lblPayCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPayCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblPayCap.Location = New System.Drawing.Point(540, 44)
        Me.lblPayCap.Size = New System.Drawing.Size(40, 19)
        Me.lblPayCap.Name = "lblPayCap"
        Me.lblPayCap.TabIndex = 12
        Me.lblPayCap.Text = "Payment Status"
        Me.txtPayStatus.BackColor = System.Drawing.Color.FromArgb(42, 53, 83)
        Me.txtPayStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPayStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtPayStatus.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtPayStatus.Location = New System.Drawing.Point(540, 64)
        Me.txtPayStatus.ReadOnly = True
        Me.txtPayStatus.Size = New System.Drawing.Size(150, 26)
        Me.txtPayStatus.Name = "txtPayStatus"
        Me.txtPayStatus.TabIndex = 13
        Me.txtPayStatus.TabStop = False
        Me.txtPayStatus.Text = "Unpaid"
        Me.lblByCap.AutoSize = True
        Me.lblByCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblByCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblByCap.Location = New System.Drawing.Point(704, 44)
        Me.lblByCap.Size = New System.Drawing.Size(40, 19)
        Me.lblByCap.Name = "lblByCap"
        Me.lblByCap.TabIndex = 14
        Me.lblByCap.Text = "Processed By"
        Me.txtBy.BackColor = System.Drawing.Color.FromArgb(42, 53, 83)
        Me.txtBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBy.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtBy.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtBy.Location = New System.Drawing.Point(704, 64)
        Me.txtBy.ReadOnly = True
        Me.txtBy.Size = New System.Drawing.Size(220, 26)
        Me.txtBy.Name = "txtBy"
        Me.txtBy.TabIndex = 15
        Me.txtBy.TabStop = False
        Me.pnlStudent.BackColor = System.Drawing.Color.FromArgb(46, 58, 90)
        Me.pnlStudent.Controls.Add(Me.lblStudIcon)
        Me.pnlStudent.Controls.Add(Me.lblStudTitle)
        Me.pnlStudent.Controls.Add(Me.lblIdCap)
        Me.pnlStudent.Controls.Add(Me.txtStudentId)
        Me.pnlStudent.Controls.Add(Me.btnFind)
        Me.pnlStudent.Controls.Add(Me.btnBrowse)
        Me.pnlStudent.Controls.Add(Me.lblNameCap)
        Me.pnlStudent.Controls.Add(Me.txtName)
        Me.pnlStudent.Controls.Add(Me.lblCourseCap)
        Me.pnlStudent.Controls.Add(Me.txtCourse)
        Me.pnlStudent.Controls.Add(Me.lblYearCap)
        Me.pnlStudent.Controls.Add(Me.txtYear)
        Me.pnlStudent.Location = New System.Drawing.Point(26, 204)
        Me.pnlStudent.Size = New System.Drawing.Size(390, 240)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.TabIndex = 16
        Me.lblStudIcon.AutoSize = True
        Me.lblStudIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
        Me.lblStudIcon.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblStudIcon.Location = New System.Drawing.Point(16, 14)
        Me.lblStudIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblStudIcon.Name = "lblStudIcon"
        Me.lblStudIcon.TabIndex = 17
        Me.lblStudIcon.Text = ""
        Me.lblStudTitle.AutoSize = True
        Me.lblStudTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblStudTitle.Location = New System.Drawing.Point(40, 12)
        Me.lblStudTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblStudTitle.Name = "lblStudTitle"
        Me.lblStudTitle.TabIndex = 18
        Me.lblStudTitle.Text = "Student"
        Me.lblIdCap.AutoSize = True
        Me.lblIdCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblIdCap.Location = New System.Drawing.Point(18, 44)
        Me.lblIdCap.Size = New System.Drawing.Size(40, 19)
        Me.lblIdCap.Name = "lblIdCap"
        Me.lblIdCap.TabIndex = 19
        Me.lblIdCap.Text = "Student ID *"
        Me.txtStudentId.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentId.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtStudentId.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtStudentId.Location = New System.Drawing.Point(18, 66)
        Me.txtStudentId.MaxLength = 8
        Me.txtStudentId.PlaceholderText = "Enter Student ID"
        Me.txtStudentId.Size = New System.Drawing.Size(150, 26)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.TabIndex = 20
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(62, 104, 186)
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(82, 124, 204)
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnFind.ForeColor = System.Drawing.Color.White
        Me.btnFind.Image = Global.RegistrarSystem.My.Resources.Resources.btn_search
        Me.btnFind.Location = New System.Drawing.Point(176, 61)
        Me.btnFind.Size = New System.Drawing.Size(95, 36)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.TabIndex = 21
        Me.btnFind.Text = " Search"
        Me.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFind.UseVisualStyleBackColor = False
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(78, 92, 128)
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(96, 110, 146)
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Image = Global.RegistrarSystem.My.Resources.Resources.btn_people
        Me.btnBrowse.Location = New System.Drawing.Point(279, 61)
        Me.btnBrowse.Size = New System.Drawing.Size(95, 36)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.TabIndex = 22
        Me.btnBrowse.Text = " Browse"
        Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrowse.UseVisualStyleBackColor = False
        Me.lblNameCap.AutoSize = True
        Me.lblNameCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNameCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblNameCap.Location = New System.Drawing.Point(18, 108)
        Me.lblNameCap.Size = New System.Drawing.Size(40, 19)
        Me.lblNameCap.Name = "lblNameCap"
        Me.lblNameCap.TabIndex = 23
        Me.lblNameCap.Text = "Student Name"
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(42, 53, 83)
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtName.Location = New System.Drawing.Point(18, 130)
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(356, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.TabIndex = 24
        Me.txtName.TabStop = False
        Me.lblCourseCap.AutoSize = True
        Me.lblCourseCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCourseCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblCourseCap.Location = New System.Drawing.Point(18, 168)
        Me.lblCourseCap.Size = New System.Drawing.Size(40, 19)
        Me.lblCourseCap.Name = "lblCourseCap"
        Me.lblCourseCap.TabIndex = 25
        Me.lblCourseCap.Text = "Course"
        Me.txtCourse.BackColor = System.Drawing.Color.FromArgb(42, 53, 83)
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtCourse.Location = New System.Drawing.Point(18, 190)
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(170, 26)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.TabIndex = 26
        Me.txtCourse.TabStop = False
        Me.lblYearCap.AutoSize = True
        Me.lblYearCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblYearCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblYearCap.Location = New System.Drawing.Point(204, 168)
        Me.lblYearCap.Size = New System.Drawing.Size(40, 19)
        Me.lblYearCap.Name = "lblYearCap"
        Me.lblYearCap.TabIndex = 27
        Me.lblYearCap.Text = "Year Level / Section"
        Me.txtYear.BackColor = System.Drawing.Color.FromArgb(42, 53, 83)
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtYear.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtYear.Location = New System.Drawing.Point(204, 190)
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(170, 26)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.TabIndex = 28
        Me.txtYear.TabStop = False
        Me.pnlDocs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDocs.BackColor = System.Drawing.Color.FromArgb(46, 58, 90)
        Me.pnlDocs.Controls.Add(Me.lblDocIcon)
        Me.pnlDocs.Controls.Add(Me.lblDocTitle)
        Me.pnlDocs.Controls.Add(Me.lblDocCap)
        Me.pnlDocs.Controls.Add(Me.cboDoc)
        Me.pnlDocs.Controls.Add(Me.lblQtyCap)
        Me.pnlDocs.Controls.Add(Me.numQty)
        Me.pnlDocs.Controls.Add(Me.btnAdd)
        Me.pnlDocs.Controls.Add(Me.lblAmount)
        Me.pnlDocs.Controls.Add(Me.gridItems)
        Me.pnlDocs.Controls.Add(Me.btnRemove)
        Me.pnlDocs.Controls.Add(Me.lblItems)
        Me.pnlDocs.Location = New System.Drawing.Point(430, 204)
        Me.pnlDocs.Size = New System.Drawing.Size(584, 320)
        Me.pnlDocs.Name = "pnlDocs"
        Me.pnlDocs.TabIndex = 29
        Me.lblDocIcon.AutoSize = True
        Me.lblDocIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
        Me.lblDocIcon.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblDocIcon.Location = New System.Drawing.Point(16, 14)
        Me.lblDocIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblDocIcon.Name = "lblDocIcon"
        Me.lblDocIcon.TabIndex = 30
        Me.lblDocIcon.Text = ""
        Me.lblDocTitle.AutoSize = True
        Me.lblDocTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblDocTitle.Location = New System.Drawing.Point(40, 12)
        Me.lblDocTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblDocTitle.Name = "lblDocTitle"
        Me.lblDocTitle.TabIndex = 31
        Me.lblDocTitle.Text = "Requested Documents"
        Me.lblDocCap.AutoSize = True
        Me.lblDocCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDocCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblDocCap.Location = New System.Drawing.Point(18, 44)
        Me.lblDocCap.Size = New System.Drawing.Size(40, 19)
        Me.lblDocCap.Name = "lblDocCap"
        Me.lblDocCap.TabIndex = 32
        Me.lblDocCap.Text = "Document"
        Me.cboDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDoc.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDoc.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboDoc.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboDoc.FormattingEnabled = True
        Me.cboDoc.Location = New System.Drawing.Point(18, 66)
        Me.cboDoc.Size = New System.Drawing.Size(362, 27)
        Me.cboDoc.Name = "cboDoc"
        Me.cboDoc.TabIndex = 33
        Me.lblQtyCap.AutoSize = True
        Me.lblQtyCap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQtyCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblQtyCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblQtyCap.Location = New System.Drawing.Point(390, 44)
        Me.lblQtyCap.Size = New System.Drawing.Size(40, 19)
        Me.lblQtyCap.Name = "lblQtyCap"
        Me.lblQtyCap.TabIndex = 34
        Me.lblQtyCap.Text = "Quantity"
        Me.numQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numQty.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.numQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numQty.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.numQty.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.numQty.Location = New System.Drawing.Point(390, 66)
        Me.numQty.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQty.Size = New System.Drawing.Size(70, 26)
        Me.numQty.Name = "numQty"
        Me.numQty.TabIndex = 35
        Me.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numQty.ThousandsSeparator = True
        Me.numQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(62, 150, 116)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(86, 168, 136)
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.RegistrarSystem.My.Resources.Resources.btn_add
        Me.btnAdd.Location = New System.Drawing.Point(468, 61)
        Me.btnAdd.Size = New System.Drawing.Size(98, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = " Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.lblAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmount.BackColor = System.Drawing.Color.FromArgb(30, 39, 64)
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblAmount.Location = New System.Drawing.Point(18, 104)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblAmount.Size = New System.Drawing.Size(548, 30)
        Me.lblAmount.TabIndex = 45
        Me.lblAmount.Text = "Amount: ₱0.00"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.colId.HeaderText = "ID"
        Me.colId.Name = "colId"
        Me.colId.Visible = False
        Me.colDoc.FillWeight = 220!
        Me.colDoc.HeaderText = "Document"
        Me.colDoc.Name = "colDoc"
        Me.colDoc.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "#,##0.00"
        Me.colFee.DefaultCellStyle = DataGridViewCellStyle1
        Me.colFee.HeaderText = "Fee (₱)"
        Me.colFee.Name = "colFee"
        Me.colFee.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.colQty.DefaultCellStyle = DataGridViewCellStyle2
        Me.colQty.FillWeight = 80!
        Me.colQty.HeaderText = "Qty (editable)"
        Me.colQty.Name = "colQty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "#,##0.00"
        Me.colSub.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSub.HeaderText = "Amount (₱)"
        Me.colSub.Name = "colSub"
        Me.colSub.ReadOnly = True
        Me.gridItems.AllowUserToAddRows = False
        Me.gridItems.AllowUserToDeleteRows = False
        Me.gridItems.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(51, 64, 98)
        Me.gridItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gridItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridItems.BackgroundColor = System.Drawing.Color.FromArgb(46, 58, 90)
        Me.gridItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(30, 39, 64)
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(30, 39, 64)
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gridItems.ColumnHeadersHeight = 40
        Me.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gridItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colDoc, Me.colFee, Me.colQty, Me.colSub})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(46, 58, 90)
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(62, 104, 186)
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridItems.DefaultCellStyle = DataGridViewCellStyle6
        Me.gridItems.EnableHeadersVisualStyles = False
        Me.gridItems.GridColor = System.Drawing.Color.FromArgb(68, 82, 118)
        Me.gridItems.Location = New System.Drawing.Point(18, 142)
        Me.gridItems.MultiSelect = False
        Me.gridItems.RowHeadersVisible = False
        Me.gridItems.RowTemplate.Height = 34
        Me.gridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridItems.Size = New System.Drawing.Size(548, 122)
        Me.gridItems.Name = "gridItems"
        Me.gridItems.TabIndex = 37
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(196, 96, 112)
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(208, 120, 134)
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Image = Global.RegistrarSystem.My.Resources.Resources.btn_delete
        Me.btnRemove.Location = New System.Drawing.Point(18, 274)
        Me.btnRemove.Size = New System.Drawing.Size(160, 36)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.TabIndex = 38
        Me.btnRemove.Text = " Remove Selected"
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseVisualStyleBackColor = False
        Me.lblItems.AutoSize = False
        Me.lblItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItems.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblItems.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblItems.Location = New System.Drawing.Point(286, 282)
        Me.lblItems.Size = New System.Drawing.Size(280, 22)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.TabIndex = 39
        Me.lblItems.Text = "No documents added yet."
        Me.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.pnlFooter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(30, 39, 64)
        Me.pnlFooter.Controls.Add(Me.lblTotalCaption)
        Me.pnlFooter.Controls.Add(Me.lblTotal)
        Me.pnlFooter.Controls.Add(Me.btnClear)
        Me.pnlFooter.Controls.Add(Me.btnSave)
        Me.pnlFooter.Location = New System.Drawing.Point(26, 538)
        Me.pnlFooter.Size = New System.Drawing.Size(988, 80)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.TabIndex = 40
        Me.lblTotalCaption.AutoSize = True
        Me.lblTotalCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblTotalCaption.Location = New System.Drawing.Point(18, 10)
        Me.lblTotalCaption.Size = New System.Drawing.Size(40, 19)
        Me.lblTotalCaption.Name = "lblTotalCaption"
        Me.lblTotalCaption.TabIndex = 41
        Me.lblTotalCaption.Text = "TOTAL AMOUNT"
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblTotal.Location = New System.Drawing.Point(16, 30)
        Me.lblTotal.Size = New System.Drawing.Size(40, 19)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.TabIndex = 42
        Me.lblTotal.Text = "₱0.00"
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(78, 92, 128)
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(96, 110, 146)
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Global.RegistrarSystem.My.Resources.Resources.btn_clear
        Me.btnClear.Location = New System.Drawing.Point(700, 18)
        Me.btnClear.Size = New System.Drawing.Size(110, 44)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.TabIndex = 43
        Me.btnClear.Text = " Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(62, 104, 186)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(82, 124, 204)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.RegistrarSystem.My.Resources.Resources.btn_save
        Me.btnSave.Location = New System.Drawing.Point(818, 18)
        Me.btnSave.Size = New System.Drawing.Size(150, 44)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = " Save Request"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(37, 47, 75)
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.lblIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlStudent)
        Me.Controls.Add(Me.pnlDocs)
        Me.Controls.Add(Me.pnlFooter)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewRequestForm"
        Me.Text = "New Document Request"
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblInfoIcon As System.Windows.Forms.Label
    Friend WithEvents lblInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblReqNoCap As System.Windows.Forms.Label
    Friend WithEvents txtReqNo As System.Windows.Forms.TextBox
    Friend WithEvents lblDateCap As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStatusCap As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblPayCap As System.Windows.Forms.Label
    Friend WithEvents txtPayStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblByCap As System.Windows.Forms.Label
    Friend WithEvents txtBy As System.Windows.Forms.TextBox
    Friend WithEvents pnlStudent As System.Windows.Forms.Panel
    Friend WithEvents lblStudIcon As System.Windows.Forms.Label
    Friend WithEvents lblStudTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdCap As System.Windows.Forms.Label
    Friend WithEvents txtStudentId As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblNameCap As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblCourseCap As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents lblYearCap As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents pnlDocs As System.Windows.Forms.Panel
    Friend WithEvents lblDocIcon As System.Windows.Forms.Label
    Friend WithEvents lblDocTitle As System.Windows.Forms.Label
    Friend WithEvents lblDocCap As System.Windows.Forms.Label
    Friend WithEvents cboDoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblQtyCap As System.Windows.Forms.Label
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents colId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridItems As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblTotalCaption As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
