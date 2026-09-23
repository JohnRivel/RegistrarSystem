<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblChipToday = New System.Windows.Forms.Label()
        Me.lblChipPaidToday = New System.Windows.Forms.Label()
        Me.lblChipMonth = New System.Windows.Forms.Label()
        Me.tileStudents = New System.Windows.Forms.Panel()
        Me.tileStudentsNum = New System.Windows.Forms.Label()
        Me.tileStudentsCaption = New System.Windows.Forms.Label()
        Me.tileStudentsIcon = New System.Windows.Forms.Label()
        Me.tilePending = New System.Windows.Forms.Panel()
        Me.tilePendingNum = New System.Windows.Forms.Label()
        Me.tilePendingCaption = New System.Windows.Forms.Label()
        Me.tilePendingIcon = New System.Windows.Forms.Label()
        Me.tileProcessing = New System.Windows.Forms.Panel()
        Me.tileProcessingNum = New System.Windows.Forms.Label()
        Me.tileProcessingCaption = New System.Windows.Forms.Label()
        Me.tileProcessingIcon = New System.Windows.Forms.Label()
        Me.tileReady = New System.Windows.Forms.Panel()
        Me.tileReadyNum = New System.Windows.Forms.Label()
        Me.tileReadyCaption = New System.Windows.Forms.Label()
        Me.tileReadyIcon = New System.Windows.Forms.Label()
        Me.tileReleased = New System.Windows.Forms.Panel()
        Me.tileReleasedNum = New System.Windows.Forms.Label()
        Me.tileReleasedCaption = New System.Windows.Forms.Label()
        Me.tileReleasedIcon = New System.Windows.Forms.Label()
        Me.tileCancelled = New System.Windows.Forms.Panel()
        Me.tileCancelledNum = New System.Windows.Forms.Label()
        Me.tileCancelledCaption = New System.Windows.Forms.Label()
        Me.tileCancelledIcon = New System.Windows.Forms.Label()
        Me.tileUnpaid = New System.Windows.Forms.Panel()
        Me.tileUnpaidNum = New System.Windows.Forms.Label()
        Me.tileUnpaidCaption = New System.Windows.Forms.Label()
        Me.tileUnpaidIcon = New System.Windows.Forms.Label()
        Me.tileDocuments = New System.Windows.Forms.Panel()
        Me.tileDocumentsNum = New System.Windows.Forms.Label()
        Me.tileDocumentsCaption = New System.Windows.Forms.Label()
        Me.tileDocumentsIcon = New System.Windows.Forms.Label()
        Me.tlpTiles = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(26, 18)
        Me.lblWelcome.Size = New System.Drawing.Size(40, 19)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome!"
        Me.lblInfo.AutoSize = False
        Me.lblInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblInfo.Location = New System.Drawing.Point(814, 22)
        Me.lblInfo.Size = New System.Drawing.Size(200, 40)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Logged in as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Today"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblChipToday.AutoSize = False
        Me.lblChipToday.BackColor = System.Drawing.Color.FromArgb(232, 172, 48)
        Me.lblChipToday.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.lblChipToday.ForeColor = System.Drawing.Color.White
        Me.lblChipToday.Location = New System.Drawing.Point(28, 70)
        Me.lblChipToday.Size = New System.Drawing.Size(250, 34)
        Me.lblChipToday.Name = "lblChipToday"
        Me.lblChipToday.TabIndex = 2
        Me.lblChipToday.Text = "Requests Today: 0"
        Me.lblChipToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblChipPaidToday.AutoSize = False
        Me.lblChipPaidToday.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblChipPaidToday.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.lblChipPaidToday.ForeColor = System.Drawing.Color.White
        Me.lblChipPaidToday.Location = New System.Drawing.Point(290, 70)
        Me.lblChipPaidToday.Size = New System.Drawing.Size(250, 34)
        Me.lblChipPaidToday.Name = "lblChipPaidToday"
        Me.lblChipPaidToday.TabIndex = 3
        Me.lblChipPaidToday.Text = "Collected Today: ₱0.00"
        Me.lblChipPaidToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblChipMonth.AutoSize = False
        Me.lblChipMonth.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblChipMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.lblChipMonth.ForeColor = System.Drawing.Color.White
        Me.lblChipMonth.Location = New System.Drawing.Point(552, 70)
        Me.lblChipMonth.Size = New System.Drawing.Size(250, 34)
        Me.lblChipMonth.Name = "lblChipMonth"
        Me.lblChipMonth.TabIndex = 4
        Me.lblChipMonth.Text = "Collected This Month: ₱0.00"
        Me.lblChipMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileStudents.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.tileStudents.Controls.Add(Me.tileStudentsIcon)
        Me.tileStudents.Controls.Add(Me.tileStudentsNum)
        Me.tileStudents.Controls.Add(Me.tileStudentsCaption)
        Me.tileStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tileStudents.Margin = New System.Windows.Forms.Padding(0, 0, 14, 14)
        Me.tileStudents.Size = New System.Drawing.Size(247, 111)
        Me.tileStudents.Tag = "students"
        Me.tileStudents.Name = "tileStudents"
        Me.tileStudents.TabIndex = 5
        Me.tileStudentsNum.AutoSize = True
        Me.tileStudentsNum.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!)
        Me.tileStudentsNum.ForeColor = System.Drawing.Color.White
        Me.tileStudentsNum.Location = New System.Drawing.Point(20, 14)
        Me.tileStudentsNum.Text = "0"
        Me.tileStudentsNum.Name = "tileStudentsNum"
        Me.tileStudentsNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileStudentsCaption.AutoSize = True
        Me.tileStudentsCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.tileStudentsCaption.ForeColor = System.Drawing.Color.White
        Me.tileStudentsCaption.Location = New System.Drawing.Point(22, 66)
        Me.tileStudentsCaption.Text = "Active Students"
        Me.tileStudentsCaption.Name = "tileStudentsCaption"
        Me.tileStudentsCaption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileStudentsIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tileStudentsIcon.AutoSize = True
        Me.tileStudentsIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 36.0!)
        Me.tileStudentsIcon.ForeColor = System.Drawing.Color.FromArgb(146, 177, 255)
        Me.tileStudentsIcon.Location = New System.Drawing.Point(170, 22)
        Me.tileStudentsIcon.Text = ""
        Me.tileStudentsIcon.Name = "tileStudentsIcon"
        Me.tileStudentsIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tilePending.BackColor = System.Drawing.Color.FromArgb(230, 126, 34)
        Me.tilePending.Controls.Add(Me.tilePendingIcon)
        Me.tilePending.Controls.Add(Me.tilePendingNum)
        Me.tilePending.Controls.Add(Me.tilePendingCaption)
        Me.tilePending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tilePending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tilePending.Margin = New System.Windows.Forms.Padding(0, 0, 14, 14)
        Me.tilePending.Size = New System.Drawing.Size(247, 111)
        Me.tilePending.Tag = "Pending"
        Me.tilePending.Name = "tilePending"
        Me.tilePending.TabIndex = 6
        Me.tilePendingNum.AutoSize = True
        Me.tilePendingNum.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!)
        Me.tilePendingNum.ForeColor = System.Drawing.Color.White
        Me.tilePendingNum.Location = New System.Drawing.Point(20, 14)
        Me.tilePendingNum.Text = "0"
        Me.tilePendingNum.Name = "tilePendingNum"
        Me.tilePendingNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tilePendingCaption.AutoSize = True
        Me.tilePendingCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.tilePendingCaption.ForeColor = System.Drawing.Color.White
        Me.tilePendingCaption.Location = New System.Drawing.Point(22, 66)
        Me.tilePendingCaption.Text = "Pending"
        Me.tilePendingCaption.Name = "tilePendingCaption"
        Me.tilePendingCaption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tilePendingIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tilePendingIcon.AutoSize = True
        Me.tilePendingIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 36.0!)
        Me.tilePendingIcon.ForeColor = System.Drawing.Color.FromArgb(240, 178, 122)
        Me.tilePendingIcon.Location = New System.Drawing.Point(170, 22)
        Me.tilePendingIcon.Text = ""
        Me.tilePendingIcon.Name = "tilePendingIcon"
        Me.tilePendingIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileProcessing.BackColor = System.Drawing.Color.FromArgb(160, 106, 222)
        Me.tileProcessing.Controls.Add(Me.tileProcessingIcon)
        Me.tileProcessing.Controls.Add(Me.tileProcessingNum)
        Me.tileProcessing.Controls.Add(Me.tileProcessingCaption)
        Me.tileProcessing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileProcessing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tileProcessing.Margin = New System.Windows.Forms.Padding(0, 0, 14, 14)
        Me.tileProcessing.Size = New System.Drawing.Size(247, 111)
        Me.tileProcessing.Tag = "Processing"
        Me.tileProcessing.Name = "tileProcessing"
        Me.tileProcessing.TabIndex = 7
        Me.tileProcessingNum.AutoSize = True
        Me.tileProcessingNum.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!)
        Me.tileProcessingNum.ForeColor = System.Drawing.Color.White
        Me.tileProcessingNum.Location = New System.Drawing.Point(20, 14)
        Me.tileProcessingNum.Text = "0"
        Me.tileProcessingNum.Name = "tileProcessingNum"
        Me.tileProcessingNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileProcessingCaption.AutoSize = True
        Me.tileProcessingCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.tileProcessingCaption.ForeColor = System.Drawing.Color.White
        Me.tileProcessingCaption.Location = New System.Drawing.Point(22, 66)
        Me.tileProcessingCaption.Text = "Processing"
        Me.tileProcessingCaption.Name = "tileProcessingCaption"
        Me.tileProcessingCaption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileProcessingIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tileProcessingIcon.AutoSize = True
        Me.tileProcessingIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 36.0!)
        Me.tileProcessingIcon.ForeColor = System.Drawing.Color.FromArgb(198, 166, 235)
        Me.tileProcessingIcon.Location = New System.Drawing.Point(170, 22)
        Me.tileProcessingIcon.Text = ""
        Me.tileProcessingIcon.Name = "tileProcessingIcon"
        Me.tileProcessingIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileReady.BackColor = System.Drawing.Color.FromArgb(232, 172, 48)
        Me.tileReady.Controls.Add(Me.tileReadyIcon)
        Me.tileReady.Controls.Add(Me.tileReadyNum)
        Me.tileReady.Controls.Add(Me.tileReadyCaption)
        Me.tileReady.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileReady.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tileReady.Margin = New System.Windows.Forms.Padding(0, 0, 14, 14)
        Me.tileReady.Size = New System.Drawing.Size(247, 111)
        Me.tileReady.Tag = "Ready for Release"
        Me.tileReady.Name = "tileReady"
        Me.tileReady.TabIndex = 8
        Me.tileReadyNum.AutoSize = True
        Me.tileReadyNum.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!)
        Me.tileReadyNum.ForeColor = System.Drawing.Color.White
        Me.tileReadyNum.Location = New System.Drawing.Point(20, 14)
        Me.tileReadyNum.Text = "0"
        Me.tileReadyNum.Name = "tileReadyNum"
        Me.tileReadyNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileReadyCaption.AutoSize = True
        Me.tileReadyCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.tileReadyCaption.ForeColor = System.Drawing.Color.White
        Me.tileReadyCaption.Location = New System.Drawing.Point(22, 66)
        Me.tileReadyCaption.Text = "Ready for Release"
        Me.tileReadyCaption.Name = "tileReadyCaption"
        Me.tileReadyCaption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileReadyIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tileReadyIcon.AutoSize = True
        Me.tileReadyIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 36.0!)
        Me.tileReadyIcon.ForeColor = System.Drawing.Color.FromArgb(241, 205, 131)
        Me.tileReadyIcon.Location = New System.Drawing.Point(170, 22)
        Me.tileReadyIcon.Text = ""
        Me.tileReadyIcon.Name = "tileReadyIcon"
        Me.tileReadyIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileReleased.BackColor = System.Drawing.Color.FromArgb(38, 170, 118)
        Me.tileReleased.Controls.Add(Me.tileReleasedIcon)
        Me.tileReleased.Controls.Add(Me.tileReleasedNum)
        Me.tileReleased.Controls.Add(Me.tileReleasedCaption)
        Me.tileReleased.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileReleased.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tileReleased.Margin = New System.Windows.Forms.Padding(0, 0, 14, 14)
        Me.tileReleased.Size = New System.Drawing.Size(247, 111)
        Me.tileReleased.Tag = "Released"
        Me.tileReleased.Name = "tileReleased"
        Me.tileReleased.TabIndex = 9
        Me.tileReleasedNum.AutoSize = True
        Me.tileReleasedNum.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!)
        Me.tileReleasedNum.ForeColor = System.Drawing.Color.White
        Me.tileReleasedNum.Location = New System.Drawing.Point(20, 14)
        Me.tileReleasedNum.Text = "0"
        Me.tileReleasedNum.Name = "tileReleasedNum"
        Me.tileReleasedNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileReleasedCaption.AutoSize = True
        Me.tileReleasedCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.tileReleasedCaption.ForeColor = System.Drawing.Color.White
        Me.tileReleasedCaption.Location = New System.Drawing.Point(22, 66)
        Me.tileReleasedCaption.Text = "Released"
        Me.tileReleasedCaption.Name = "tileReleasedCaption"
        Me.tileReleasedCaption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileReleasedIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tileReleasedIcon.AutoSize = True
        Me.tileReleasedIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 36.0!)
        Me.tileReleasedIcon.ForeColor = System.Drawing.Color.FromArgb(125, 204, 173)
        Me.tileReleasedIcon.Location = New System.Drawing.Point(170, 22)
        Me.tileReleasedIcon.Text = ""
        Me.tileReleasedIcon.Name = "tileReleasedIcon"
        Me.tileReleasedIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileCancelled.BackColor = System.Drawing.Color.FromArgb(228, 84, 108)
        Me.tileCancelled.Controls.Add(Me.tileCancelledIcon)
        Me.tileCancelled.Controls.Add(Me.tileCancelledNum)
        Me.tileCancelled.Controls.Add(Me.tileCancelledCaption)
        Me.tileCancelled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileCancelled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tileCancelled.Margin = New System.Windows.Forms.Padding(0, 0, 14, 14)
        Me.tileCancelled.Size = New System.Drawing.Size(247, 111)
        Me.tileCancelled.Tag = "Cancelled"
        Me.tileCancelled.Name = "tileCancelled"
        Me.tileCancelled.TabIndex = 10
        Me.tileCancelledNum.AutoSize = True
        Me.tileCancelledNum.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!)
        Me.tileCancelledNum.ForeColor = System.Drawing.Color.White
        Me.tileCancelledNum.Location = New System.Drawing.Point(20, 14)
        Me.tileCancelledNum.Text = "0"
        Me.tileCancelledNum.Name = "tileCancelledNum"
        Me.tileCancelledNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileCancelledCaption.AutoSize = True
        Me.tileCancelledCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.tileCancelledCaption.ForeColor = System.Drawing.Color.White
        Me.tileCancelledCaption.Location = New System.Drawing.Point(22, 66)
        Me.tileCancelledCaption.Text = "Cancelled"
        Me.tileCancelledCaption.Name = "tileCancelledCaption"
        Me.tileCancelledCaption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileCancelledIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tileCancelledIcon.AutoSize = True
        Me.tileCancelledIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 36.0!)
        Me.tileCancelledIcon.ForeColor = System.Drawing.Color.FromArgb(239, 152, 167)
        Me.tileCancelledIcon.Location = New System.Drawing.Point(170, 22)
        Me.tileCancelledIcon.Text = ""
        Me.tileCancelledIcon.Name = "tileCancelledIcon"
        Me.tileCancelledIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileUnpaid.BackColor = System.Drawing.Color.FromArgb(22, 170, 168)
        Me.tileUnpaid.Controls.Add(Me.tileUnpaidIcon)
        Me.tileUnpaid.Controls.Add(Me.tileUnpaidNum)
        Me.tileUnpaid.Controls.Add(Me.tileUnpaidCaption)
        Me.tileUnpaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileUnpaid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tileUnpaid.Margin = New System.Windows.Forms.Padding(0, 0, 14, 14)
        Me.tileUnpaid.Size = New System.Drawing.Size(247, 111)
        Me.tileUnpaid.Tag = "pay:Unpaid"
        Me.tileUnpaid.Name = "tileUnpaid"
        Me.tileUnpaid.TabIndex = 11
        Me.tileUnpaidNum.AutoSize = True
        Me.tileUnpaidNum.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!)
        Me.tileUnpaidNum.ForeColor = System.Drawing.Color.White
        Me.tileUnpaidNum.Location = New System.Drawing.Point(20, 14)
        Me.tileUnpaidNum.Text = "0"
        Me.tileUnpaidNum.Name = "tileUnpaidNum"
        Me.tileUnpaidNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileUnpaidCaption.AutoSize = True
        Me.tileUnpaidCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.tileUnpaidCaption.ForeColor = System.Drawing.Color.White
        Me.tileUnpaidCaption.Location = New System.Drawing.Point(22, 66)
        Me.tileUnpaidCaption.Text = "Unpaid Requests"
        Me.tileUnpaidCaption.Name = "tileUnpaidCaption"
        Me.tileUnpaidCaption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileUnpaidIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tileUnpaidIcon.AutoSize = True
        Me.tileUnpaidIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 36.0!)
        Me.tileUnpaidIcon.ForeColor = System.Drawing.Color.FromArgb(115, 204, 203)
        Me.tileUnpaidIcon.Location = New System.Drawing.Point(170, 22)
        Me.tileUnpaidIcon.Text = ""
        Me.tileUnpaidIcon.Name = "tileUnpaidIcon"
        Me.tileUnpaidIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileDocuments.BackColor = System.Drawing.Color.FromArgb(84, 150, 226)
        Me.tileDocuments.Controls.Add(Me.tileDocumentsIcon)
        Me.tileDocuments.Controls.Add(Me.tileDocumentsNum)
        Me.tileDocuments.Controls.Add(Me.tileDocumentsCaption)
        Me.tileDocuments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tileDocuments.Margin = New System.Windows.Forms.Padding(0, 0, 14, 14)
        Me.tileDocuments.Size = New System.Drawing.Size(247, 111)
        Me.tileDocuments.Tag = "documents"
        Me.tileDocuments.Name = "tileDocuments"
        Me.tileDocuments.TabIndex = 12
        Me.tileDocumentsNum.AutoSize = True
        Me.tileDocumentsNum.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!)
        Me.tileDocumentsNum.ForeColor = System.Drawing.Color.White
        Me.tileDocumentsNum.Location = New System.Drawing.Point(20, 14)
        Me.tileDocumentsNum.Text = "0"
        Me.tileDocumentsNum.Name = "tileDocumentsNum"
        Me.tileDocumentsNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileDocumentsCaption.AutoSize = True
        Me.tileDocumentsCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.tileDocumentsCaption.ForeColor = System.Drawing.Color.White
        Me.tileDocumentsCaption.Location = New System.Drawing.Point(22, 66)
        Me.tileDocumentsCaption.Text = "Document Types"
        Me.tileDocumentsCaption.Name = "tileDocumentsCaption"
        Me.tileDocumentsCaption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileDocumentsIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tileDocumentsIcon.AutoSize = True
        Me.tileDocumentsIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 36.0!)
        Me.tileDocumentsIcon.ForeColor = System.Drawing.Color.FromArgb(152, 192, 238)
        Me.tileDocumentsIcon.Location = New System.Drawing.Point(170, 22)
        Me.tileDocumentsIcon.Text = ""
        Me.tileDocumentsIcon.Name = "tileDocumentsIcon"
        Me.tileDocumentsIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tlpTiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpTiles.ColumnCount = 4
        Me.tlpTiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTiles.Controls.Add(Me.tileStudents, 0, 0)
        Me.tlpTiles.Controls.Add(Me.tilePending, 1, 0)
        Me.tlpTiles.Controls.Add(Me.tileProcessing, 2, 0)
        Me.tlpTiles.Controls.Add(Me.tileReady, 3, 0)
        Me.tlpTiles.Controls.Add(Me.tileReleased, 0, 1)
        Me.tlpTiles.Controls.Add(Me.tileCancelled, 1, 1)
        Me.tlpTiles.Controls.Add(Me.tileUnpaid, 2, 1)
        Me.tlpTiles.Controls.Add(Me.tileDocuments, 3, 1)
        Me.tlpTiles.Location = New System.Drawing.Point(26, 118)
        Me.tlpTiles.RowCount = 2
        Me.tlpTiles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTiles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTiles.Size = New System.Drawing.Size(1002, 250)
        Me.tlpTiles.Name = "tlpTiles"
        Me.tlpTiles.TabIndex = 13
        Me.lblRecent.AutoSize = True
        Me.lblRecent.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblRecent.Location = New System.Drawing.Point(26, 380)
        Me.lblRecent.Size = New System.Drawing.Size(40, 19)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.TabIndex = 14
        Me.lblRecent.Text = "Latest Requests"
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
        Me.grid.Location = New System.Drawing.Point(28, 412)
        Me.grid.MultiSelect = False
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.RowTemplate.Height = 34
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(986, 204)
        Me.grid.Name = "grid"
        Me.grid.TabIndex = 15
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(41, 44, 58)
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblChipToday)
        Me.Controls.Add(Me.lblChipPaidToday)
        Me.Controls.Add(Me.lblChipMonth)
        Me.Controls.Add(Me.tlpTiles)
        Me.Controls.Add(Me.lblRecent)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.Text = "Dashboard"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblChipToday As System.Windows.Forms.Label
    Friend WithEvents lblChipPaidToday As System.Windows.Forms.Label
    Friend WithEvents lblChipMonth As System.Windows.Forms.Label
    Friend WithEvents tileStudents As System.Windows.Forms.Panel
    Friend WithEvents tileStudentsNum As System.Windows.Forms.Label
    Friend WithEvents tileStudentsCaption As System.Windows.Forms.Label
    Friend WithEvents tileStudentsIcon As System.Windows.Forms.Label
    Friend WithEvents tilePending As System.Windows.Forms.Panel
    Friend WithEvents tilePendingNum As System.Windows.Forms.Label
    Friend WithEvents tilePendingCaption As System.Windows.Forms.Label
    Friend WithEvents tilePendingIcon As System.Windows.Forms.Label
    Friend WithEvents tileProcessing As System.Windows.Forms.Panel
    Friend WithEvents tileProcessingNum As System.Windows.Forms.Label
    Friend WithEvents tileProcessingCaption As System.Windows.Forms.Label
    Friend WithEvents tileProcessingIcon As System.Windows.Forms.Label
    Friend WithEvents tileReady As System.Windows.Forms.Panel
    Friend WithEvents tileReadyNum As System.Windows.Forms.Label
    Friend WithEvents tileReadyCaption As System.Windows.Forms.Label
    Friend WithEvents tileReadyIcon As System.Windows.Forms.Label
    Friend WithEvents tileReleased As System.Windows.Forms.Panel
    Friend WithEvents tileReleasedNum As System.Windows.Forms.Label
    Friend WithEvents tileReleasedCaption As System.Windows.Forms.Label
    Friend WithEvents tileReleasedIcon As System.Windows.Forms.Label
    Friend WithEvents tileCancelled As System.Windows.Forms.Panel
    Friend WithEvents tileCancelledNum As System.Windows.Forms.Label
    Friend WithEvents tileCancelledCaption As System.Windows.Forms.Label
    Friend WithEvents tileCancelledIcon As System.Windows.Forms.Label
    Friend WithEvents tileUnpaid As System.Windows.Forms.Panel
    Friend WithEvents tileUnpaidNum As System.Windows.Forms.Label
    Friend WithEvents tileUnpaidCaption As System.Windows.Forms.Label
    Friend WithEvents tileUnpaidIcon As System.Windows.Forms.Label
    Friend WithEvents tileDocuments As System.Windows.Forms.Panel
    Friend WithEvents tileDocumentsNum As System.Windows.Forms.Label
    Friend WithEvents tileDocumentsCaption As System.Windows.Forms.Label
    Friend WithEvents tileDocumentsIcon As System.Windows.Forms.Label
    Friend WithEvents tlpTiles As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRecent As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
End Class
