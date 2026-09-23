Imports System.Windows.Forms

Module Program

    <STAThread>
    Sub Main()
        Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
        AddHandler Application.ThreadException, Sub(s, e) Ui.ShowError(e.Exception)

        Do
            Using login As New LoginForm()
                If login.ShowDialog() <> DialogResult.OK Then Exit Do
            End Using

            Dim loggedOut As Boolean
            Using main As New MainForm()
                main.ShowDialog()
                loggedOut = main.LoggedOut
            End Using

            Session.Clear()
            If Not loggedOut Then Exit Do
        Loop
    End Sub

End Module
