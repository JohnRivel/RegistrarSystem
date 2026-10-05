<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        components = New ComponentModel.Container()
        pnlTop = New Panel()
        lblClock = New Label()
        lblUserIcon = New Label()
        lblUser = New Label()
        lblBrand = New Label()
        lblBrandIcon = New Label()
        btnMenu = New Button()
        pnlSide = New Panel()
        btnUsers = New Button()
        btnReports = New Button()
        btnRequests = New Button()
        btnNewRequest = New Button()
        btnDocuments = New Button()
        btnStudents = New Button()
        btnDashboard = New Button()
        lblMenuTitle = New Label()
        btnLogout = New Button()
        pnlContent = New Panel()
        clockTimer = New Timer(components)
        toolTip = New ToolTip(components)
        pnlTop.SuspendLayout()
        pnlSide.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(64))
        pnlTop.Controls.Add(lblClock)
        pnlTop.Controls.Add(lblUserIcon)
        pnlTop.Controls.Add(lblUser)
        pnlTop.Controls.Add(lblBrand)
        pnlTop.Controls.Add(lblBrandIcon)
        pnlTop.Controls.Add(btnMenu)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(1304, 56)
        pnlTop.TabIndex = 2
        ' 
        ' lblClock
        ' 
        lblClock.Dock = DockStyle.Right
        lblClock.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblClock.Location = New Point(534, 0)
        lblClock.Name = "lblClock"
        lblClock.Size = New Size(420, 56)
        lblClock.TabIndex = 0
        lblClock.Text = "Current Time and Date:"
        lblClock.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblUserIcon
        ' 
        lblUserIcon.Dock = DockStyle.Right
        lblUserIcon.Font = New Font("Segoe MDL2 Assets", 14F)
        lblUserIcon.ForeColor = Color.FromArgb(CByte(226), CByte(186), CByte(92))
        lblUserIcon.Location = New Point(954, 0)
        lblUserIcon.Name = "lblUserIcon"
        lblUserIcon.Size = New Size(50, 56)
        lblUserIcon.TabIndex = 1
        lblUserIcon.Text = ""
        lblUserIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUser
        ' 
        lblUser.Dock = DockStyle.Right
        lblUser.Font = New Font("Segoe UI Semibold", 9.5F)
        lblUser.Location = New Point(1004, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(300, 56)
        lblUser.TabIndex = 2
        lblUser.Text = "User Name  (Role)"
        lblUser.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBrand
        ' 
        lblBrand.Dock = DockStyle.Left
        lblBrand.Font = New Font("Segoe UI Semibold", 11F)
        lblBrand.Location = New Point(108, 0)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(340, 56)
        lblBrand.TabIndex = 3
        lblBrand.Text = "LYCEUM OF ALABANG  |  REGISTRAR"
        lblBrand.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBrandIcon
        ' 
        lblBrandIcon.Dock = DockStyle.Left
        lblBrandIcon.Font = New Font("Segoe MDL2 Assets", 15F)
        lblBrandIcon.ForeColor = Color.FromArgb(CByte(226), CByte(186), CByte(92))
        lblBrandIcon.Location = New Point(56, 0)
        lblBrandIcon.Name = "lblBrandIcon"
        lblBrandIcon.Size = New Size(52, 56)
        lblBrandIcon.TabIndex = 4
        lblBrandIcon.Text = ""
        lblBrandIcon.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.FromArgb(CByte(62), CByte(104), CByte(186))
        btnMenu.Cursor = Cursors.Hand
        btnMenu.Dock = DockStyle.Left
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Font = New Font("Segoe MDL2 Assets", 14F)
        btnMenu.ForeColor = Color.White
        btnMenu.Location = New Point(0, 0)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(56, 56)
        btnMenu.TabIndex = 5
        btnMenu.TabStop = False
        btnMenu.Text = ""
        toolTip.SetToolTip(btnMenu, "Show / hide menu")
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' pnlSide
        ' 
        pnlSide.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(64))
        pnlSide.Controls.Add(btnUsers)
        pnlSide.Controls.Add(btnReports)
        pnlSide.Controls.Add(btnRequests)
        pnlSide.Controls.Add(btnNewRequest)
        pnlSide.Controls.Add(btnDocuments)
        pnlSide.Controls.Add(btnStudents)
        pnlSide.Controls.Add(btnDashboard)
        pnlSide.Controls.Add(lblMenuTitle)
        pnlSide.Controls.Add(btnLogout)
        pnlSide.Dock = DockStyle.Left
        pnlSide.Location = New Point(0, 56)
        pnlSide.Name = "pnlSide"
        pnlSide.Size = New Size(236, 725)
        pnlSide.TabIndex = 1
        ' 
        ' btnUsers
        ' 
        btnUsers.Cursor = Cursors.Hand
        btnUsers.Dock = DockStyle.Top
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        btnUsers.Image = My.Resources.Resources.nav_users
        btnUsers.ImageAlign = ContentAlignment.MiddleLeft
        btnUsers.Location = New Point(0, 344)
        btnUsers.Name = "btnUsers"
        btnUsers.Padding = New Padding(16, 0, 0, 0)
        btnUsers.Size = New Size(236, 50)
        btnUsers.TabIndex = 7
        btnUsers.TabStop = False
        btnUsers.Tag = "users"
        btnUsers.Text = "   User Management"
        btnUsers.TextAlign = ContentAlignment.MiddleLeft
        btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip.SetToolTip(btnUsers, "User Management")
        ' 
        ' btnReports
        ' 
        btnReports.Cursor = Cursors.Hand
        btnReports.Dock = DockStyle.Top
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        btnReports.Image = My.Resources.Resources.nav_reports
        btnReports.ImageAlign = ContentAlignment.MiddleLeft
        btnReports.Location = New Point(0, 294)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(16, 0, 0, 0)
        btnReports.Size = New Size(236, 50)
        btnReports.TabIndex = 6
        btnReports.TabStop = False
        btnReports.Tag = "reports"
        btnReports.Text = "   Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip.SetToolTip(btnReports, "Reports")
        ' 
        ' btnRequests
        ' 
        btnRequests.Cursor = Cursors.Hand
        btnRequests.Dock = DockStyle.Top
        btnRequests.FlatAppearance.BorderSize = 0
        btnRequests.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        btnRequests.FlatStyle = FlatStyle.Flat
        btnRequests.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        btnRequests.Image = My.Resources.Resources.nav_requests
        btnRequests.ImageAlign = ContentAlignment.MiddleLeft
        btnRequests.Location = New Point(0, 244)
        btnRequests.Name = "btnRequests"
        btnRequests.Padding = New Padding(16, 0, 0, 0)
        btnRequests.Size = New Size(236, 50)
        btnRequests.TabIndex = 5
        btnRequests.TabStop = False
        btnRequests.Tag = "requests"
        btnRequests.Text = "   Document Requests"
        btnRequests.TextAlign = ContentAlignment.MiddleLeft
        btnRequests.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip.SetToolTip(btnRequests, "Document Requests")
        ' 
        ' btnNewRequest
        ' 
        btnNewRequest.Cursor = Cursors.Hand
        btnNewRequest.Dock = DockStyle.Top
        btnNewRequest.FlatAppearance.BorderSize = 0
        btnNewRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        btnNewRequest.FlatStyle = FlatStyle.Flat
        btnNewRequest.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        btnNewRequest.Image = My.Resources.Resources.nav_newrequest
        btnNewRequest.ImageAlign = ContentAlignment.MiddleLeft
        btnNewRequest.Location = New Point(0, 194)
        btnNewRequest.Name = "btnNewRequest"
        btnNewRequest.Padding = New Padding(16, 0, 0, 0)
        btnNewRequest.Size = New Size(236, 50)
        btnNewRequest.TabIndex = 4
        btnNewRequest.TabStop = False
        btnNewRequest.Tag = "newrequest"
        btnNewRequest.Text = "   New Request"
        btnNewRequest.TextAlign = ContentAlignment.MiddleLeft
        btnNewRequest.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip.SetToolTip(btnNewRequest, "New Request")
        ' 
        ' btnDocuments
        ' 
        btnDocuments.Cursor = Cursors.Hand
        btnDocuments.Dock = DockStyle.Top
        btnDocuments.FlatAppearance.BorderSize = 0
        btnDocuments.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        btnDocuments.FlatStyle = FlatStyle.Flat
        btnDocuments.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        btnDocuments.Image = My.Resources.Resources.nav_documents
        btnDocuments.ImageAlign = ContentAlignment.MiddleLeft
        btnDocuments.Location = New Point(0, 144)
        btnDocuments.Name = "btnDocuments"
        btnDocuments.Padding = New Padding(16, 0, 0, 0)
        btnDocuments.Size = New Size(236, 50)
        btnDocuments.TabIndex = 3
        btnDocuments.TabStop = False
        btnDocuments.Tag = "documents"
        btnDocuments.Text = "   Document Management"
        btnDocuments.TextAlign = ContentAlignment.MiddleLeft
        btnDocuments.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip.SetToolTip(btnDocuments, "Document Management")
        ' 
        ' btnStudents
        ' 
        btnStudents.Cursor = Cursors.Hand
        btnStudents.Dock = DockStyle.Top
        btnStudents.FlatAppearance.BorderSize = 0
        btnStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        btnStudents.FlatStyle = FlatStyle.Flat
        btnStudents.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        btnStudents.Image = My.Resources.Resources.nav_students
        btnStudents.ImageAlign = ContentAlignment.MiddleLeft
        btnStudents.Location = New Point(0, 94)
        btnStudents.Name = "btnStudents"
        btnStudents.Padding = New Padding(16, 0, 0, 0)
        btnStudents.Size = New Size(236, 50)
        btnStudents.TabIndex = 2
        btnStudents.TabStop = False
        btnStudents.Tag = "students"
        btnStudents.Text = "   Student Management"
        btnStudents.TextAlign = ContentAlignment.MiddleLeft
        btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip.SetToolTip(btnStudents, "Student Management")
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        btnDashboard.Image = My.Resources.Resources.nav_home
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 44)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(16, 0, 0, 0)
        btnDashboard.Size = New Size(236, 50)
        btnDashboard.TabIndex = 1
        btnDashboard.TabStop = False
        btnDashboard.Tag = "home"
        btnDashboard.Text = "   Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip.SetToolTip(btnDashboard, "Dashboard")
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.Dock = DockStyle.Top
        lblMenuTitle.Font = New Font("Segoe UI Semibold", 8.5F)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        lblMenuTitle.Location = New Point(0, 0)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Padding = New Padding(20, 0, 0, 8)
        lblMenuTitle.Size = New Size(236, 44)
        lblMenuTitle.TabIndex = 0
        lblMenuTitle.Text = "MAIN MENU"
        lblMenuTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' btnLogout
        ' 
        btnLogout.Cursor = Cursors.Hand
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(58), CByte(90))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.FromArgb(CByte(156), CByte(168), CByte(196))
        btnLogout.Image = My.Resources.Resources.nav_logout
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 675)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(16, 0, 0, 0)
        btnLogout.Size = New Size(236, 50)
        btnLogout.TabIndex = 8
        btnLogout.TabStop = False
        btnLogout.Text = "   Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        toolTip.SetToolTip(btnLogout, "Logout")
        ' 
        ' pnlContent
        ' 
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(236, 56)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1068, 725)
        pnlContent.TabIndex = 0
        ' 
        ' clockTimer
        ' 
        clockTimer.Interval = 1000
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(37), CByte(47), CByte(75))
        ClientSize = New Size(1304, 781)
        Controls.Add(pnlContent)
        Controls.Add(pnlSide)
        Controls.Add(pnlTop)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.FromArgb(CByte(220), CByte(225), CByte(236))
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(1300, 720)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lyceum of Alabang - Registrar Document Request System"
        WindowState = FormWindowState.Maximized
        pnlTop.ResumeLayout(False)
        pnlSide.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents lblUserIcon As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblBrandIcon As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents pnlSide As System.Windows.Forms.Panel
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnRequests As System.Windows.Forms.Button
    Friend WithEvents btnNewRequest As System.Windows.Forms.Button
    Friend WithEvents btnDocuments As System.Windows.Forms.Button
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents lblMenuTitle As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents clockTimer As System.Windows.Forms.Timer
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
End Class
