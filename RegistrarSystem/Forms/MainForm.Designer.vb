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
        Me.components = New System.ComponentModel.Container()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.lblUserIcon = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblBrandIcon = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnRequests = New System.Windows.Forms.Button()
        Me.btnNewRequest = New System.Windows.Forms.Button()
        Me.btnDocuments = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.clockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTop.SuspendLayout()
        Me.pnlSide.SuspendLayout()
        Me.SuspendLayout()
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(31, 33, 45)
        Me.pnlTop.Controls.Add(Me.lblClock)
        Me.pnlTop.Controls.Add(Me.lblUserIcon)
        Me.pnlTop.Controls.Add(Me.lblUser)
        Me.pnlTop.Controls.Add(Me.lblBrand)
        Me.pnlTop.Controls.Add(Me.lblBrandIcon)
        Me.pnlTop.Controls.Add(Me.btnMenu)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1304, 56)
        Me.pnlTop.TabIndex = 2
        Me.lblClock.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblClock.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblClock.Location = New System.Drawing.Point(534, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(420, 56)
        Me.lblClock.TabIndex = 0
        Me.lblClock.Text = "Current Time and Date:"
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUserIcon.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUserIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.0!)
        Me.lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.lblUserIcon.Location = New System.Drawing.Point(954, 0)
        Me.lblUserIcon.Name = "lblUserIcon"
        Me.lblUserIcon.Size = New System.Drawing.Size(50, 56)
        Me.lblUserIcon.TabIndex = 1
        Me.lblUserIcon.Text = ""
        Me.lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.lblUser.Location = New System.Drawing.Point(1004, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(300, 56)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "User Name  (Role)"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBrand.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblBrand.Location = New System.Drawing.Point(100, 0)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(300, 56)
        Me.lblBrand.TabIndex = 3
        Me.lblBrand.Text = "REGISTRAR  DOCUMENT  REQUEST"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBrandIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblBrandIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.0!)
        Me.lblBrandIcon.Location = New System.Drawing.Point(56, 0)
        Me.lblBrandIcon.Name = "lblBrandIcon"
        Me.lblBrandIcon.Size = New System.Drawing.Size(44, 56)
        Me.lblBrandIcon.TabIndex = 4
        Me.lblBrandIcon.Text = ""
        Me.lblBrandIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(74, 125, 255)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.0!)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(56, 56)
        Me.btnMenu.TabIndex = 5
        Me.btnMenu.TabStop = False
        Me.btnMenu.Text = ""
        Me.toolTip.SetToolTip(Me.btnMenu, "Show / hide menu")
        Me.btnMenu.UseVisualStyleBackColor = False
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(31, 33, 45)
        Me.pnlSide.Controls.Add(Me.btnUsers)
        Me.pnlSide.Controls.Add(Me.btnReports)
        Me.pnlSide.Controls.Add(Me.btnRequests)
        Me.pnlSide.Controls.Add(Me.btnNewRequest)
        Me.pnlSide.Controls.Add(Me.btnDocuments)
        Me.pnlSide.Controls.Add(Me.btnStudents)
        Me.pnlSide.Controls.Add(Me.btnDashboard)
        Me.pnlSide.Controls.Add(Me.lblMenuTitle)
        Me.pnlSide.Controls.Add(Me.btnLogout)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 56)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(236, 725)
        Me.pnlSide.TabIndex = 1
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.btnUsers.Image = Global.RegistrarSystem.My.Resources.Resources.nav_users
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 344)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnUsers.Size = New System.Drawing.Size(236, 50)
        Me.btnUsers.TabIndex = 7
        Me.btnUsers.TabStop = False
        Me.btnUsers.Tag = "users"
        Me.btnUsers.Text = "   User Management"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnUsers, "User Management")
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.btnReports.Image = Global.RegistrarSystem.My.Resources.Resources.nav_reports
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 294)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnReports.Size = New System.Drawing.Size(236, 50)
        Me.btnReports.TabIndex = 6
        Me.btnReports.TabStop = False
        Me.btnReports.Tag = "reports"
        Me.btnReports.Text = "   Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnReports, "Reports")
        Me.btnRequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRequests.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRequests.FlatAppearance.BorderSize = 0
        Me.btnRequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequests.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.btnRequests.Image = Global.RegistrarSystem.My.Resources.Resources.nav_requests
        Me.btnRequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequests.Location = New System.Drawing.Point(0, 244)
        Me.btnRequests.Name = "btnRequests"
        Me.btnRequests.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnRequests.Size = New System.Drawing.Size(236, 50)
        Me.btnRequests.TabIndex = 5
        Me.btnRequests.TabStop = False
        Me.btnRequests.Tag = "requests"
        Me.btnRequests.Text = "   Document Requests"
        Me.btnRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnRequests, "Document Requests")
        Me.btnNewRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewRequest.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewRequest.FlatAppearance.BorderSize = 0
        Me.btnNewRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewRequest.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.btnNewRequest.Image = Global.RegistrarSystem.My.Resources.Resources.nav_newrequest
        Me.btnNewRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewRequest.Location = New System.Drawing.Point(0, 194)
        Me.btnNewRequest.Name = "btnNewRequest"
        Me.btnNewRequest.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnNewRequest.Size = New System.Drawing.Size(236, 50)
        Me.btnNewRequest.TabIndex = 4
        Me.btnNewRequest.TabStop = False
        Me.btnNewRequest.Tag = "newrequest"
        Me.btnNewRequest.Text = "   New Request"
        Me.btnNewRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnNewRequest, "New Request")
        Me.btnDocuments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDocuments.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDocuments.FlatAppearance.BorderSize = 0
        Me.btnDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.btnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocuments.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.btnDocuments.Image = Global.RegistrarSystem.My.Resources.Resources.nav_documents
        Me.btnDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocuments.Location = New System.Drawing.Point(0, 144)
        Me.btnDocuments.Name = "btnDocuments"
        Me.btnDocuments.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnDocuments.Size = New System.Drawing.Size(236, 50)
        Me.btnDocuments.TabIndex = 3
        Me.btnDocuments.TabStop = False
        Me.btnDocuments.Tag = "documents"
        Me.btnDocuments.Text = "   Document Management"
        Me.btnDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocuments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnDocuments, "Document Management")
        Me.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudents.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudents.FlatAppearance.BorderSize = 0
        Me.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudents.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.btnStudents.Image = Global.RegistrarSystem.My.Resources.Resources.nav_students
        Me.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudents.Location = New System.Drawing.Point(0, 94)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnStudents.Size = New System.Drawing.Size(236, 50)
        Me.btnStudents.TabIndex = 2
        Me.btnStudents.TabStop = False
        Me.btnStudents.Tag = "students"
        Me.btnStudents.Text = "   Student Management"
        Me.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnStudents, "Student Management")
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.btnDashboard.Image = Global.RegistrarSystem.My.Resources.Resources.nav_home
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 44)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(236, 50)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.TabStop = False
        Me.btnDashboard.Tag = "home"
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnDashboard, "Dashboard")
        Me.lblMenuTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMenuTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.lblMenuTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Padding = New System.Windows.Forms.Padding(20, 0, 0, 8)
        Me.lblMenuTitle.Size = New System.Drawing.Size(236, 44)
        Me.lblMenuTitle.TabIndex = 0
        Me.lblMenuTitle.Text = "MAIN MENU"
        Me.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 55, 72)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(158, 164, 184)
        Me.btnLogout.Image = Global.RegistrarSystem.My.Resources.Resources.nav_logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 675)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(236, 50)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "   Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btnLogout, "Logout")
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(236, 56)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1068, 725)
        Me.pnlContent.TabIndex = 0
        Me.clockTimer.Interval = 1000
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(41, 44, 58)
        Me.ClientSize = New System.Drawing.Size(1304, 781)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(236, 238, 244)
        Me.MinimumSize = New System.Drawing.Size(1300, 720)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Document Request System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlSide.ResumeLayout(False)
        Me.ResumeLayout(False)

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
