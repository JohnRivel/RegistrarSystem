Imports System.ComponentModel

Public Class MainForm

    Public Shared Property Current As MainForm

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property LoggedOut As Boolean

    Private currentPage As Form
    Private navTexts As Dictionary(Of Button, String)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Current = Me
        Icon = SchoolIcon
        lblBrandIcon.Text = ""
        lblBrandIcon.Image = New Bitmap(My.Resources.school_logo, 36, 36)
        lblBrandIcon.ImageAlign = ContentAlignment.MiddleCenter
        lblUser.Text = $"{Session.FullName}  ({Session.Role})"

        btnDocuments.Visible = Session.IsAdmin
        btnUsers.Visible = Session.IsAdmin

        navTexts = NavButtons().ToDictionary(Function(b) b, Function(b) b.Text)
        navTexts(btnLogout) = btnLogout.Text
        UpdateClock()
        clockTimer.Start()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Navigate("home")
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not LoggedOut AndAlso e.CloseReason = CloseReason.UserClosing Then
            If Not Confirm("Exit the Registrar Document Request System?", "Exit") Then
                e.Cancel = True
                Return
            End If
        End If
        clockTimer.Stop()
        If Current Is Me Then Current = Nothing
    End Sub

    Private Function NavButtons() As Button()
        Return {btnDashboard, btnStudents, btnDocuments, btnNewRequest, btnRequests, btnReports, btnUsers}
    End Function

    Private Sub clockTimer_Tick(sender As Object, e As EventArgs) Handles clockTimer.Tick
        UpdateClock()
    End Sub

    Private Sub UpdateClock()
        lblClock.Text = "Current Time and Date:  " & Now.ToString("hh:mm tt  -  dddd  MM-dd-yyyy")
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim collapse = pnlSide.Width > 56
        pnlSide.Width = If(collapse, 56, 236)
        For Each kv In navTexts
            kv.Key.Text = If(collapse, "", kv.Value)
        Next
    End Sub

    Private Sub NavButton_Click(sender As Object, e As EventArgs) Handles _
            btnDashboard.Click, btnStudents.Click, btnDocuments.Click, btnNewRequest.Click,
            btnRequests.Click, btnReports.Click, btnUsers.Click
        Navigate(CStr(CType(sender, Button).Tag))
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If Not Confirm("Do you want to log out?", "Logout") Then Return
        LoggedOut = True
        Close()
    End Sub

    Public Sub OpenModule(key As String, Optional arg As String = Nothing)
        BeginInvoke(Sub() Navigate(key, arg))
    End Sub

    Public Sub Navigate(key As String, Optional arg As String = Nothing)
        Dim page As Form
        Select Case key
            Case "home" : page = New DashboardForm()
            Case "students" : page = New StudentsForm()
            Case "documents"
                If Not Session.IsAdmin Then Return
                page = New DocumentsForm()
            Case "newrequest" : page = New NewRequestForm()
            Case "requests" : page = New RequestListForm(arg)
            Case "reports" : page = New ReportsForm()
            Case "users"
                If Not Session.IsAdmin Then Return
                page = New UsersForm()
            Case Else : Return
        End Select

        page.TopLevel = False
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill

        pnlContent.SuspendLayout()
        If currentPage IsNot Nothing Then
            pnlContent.Controls.Remove(currentPage)
            currentPage.Dispose()
        End If
        currentPage = page
        pnlContent.Controls.Add(page)
        page.Show()
        pnlContent.ResumeLayout()

        For Each b In NavButtons()
            Dim active = CStr(b.Tag) = key
            b.BackColor = If(active, ColCard, ColBar)
            b.ForeColor = If(active, ColGold, ColMuted)
        Next
    End Sub

End Class
