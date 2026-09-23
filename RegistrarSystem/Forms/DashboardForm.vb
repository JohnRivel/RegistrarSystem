Public Class DashboardForm

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = $"Welcome, {Session.FullName}!"
        lblInfo.Text = $"Logged in as {Session.Role}" & vbCrLf & Today.ToString("dddd, MMMM d, yyyy")
        ColorizeColumns(grid, "Status", "Payment")

        For Each tile In {tileStudents, tilePending, tileProcessing, tileReady, tileReleased, tileCancelled, tileUnpaid, tileDocuments}
            AddHandler tile.Click, AddressOf Tile_Click
            For Each child As Control In tile.Controls
                AddHandler child.Click, AddressOf Tile_Click
            Next
        Next

        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim s = Db.GetTable(
                "SELECT (SELECT COUNT(*) FROM tblstudents WHERE Status = 'Active') AS Students, " &
                "       (SELECT COUNT(*) FROM tbldocuments WHERE Status = 'Active') AS Docs, " &
                "       IFNULL(SUM(Status = 'Pending'), 0) AS Pending, " &
                "       IFNULL(SUM(Status = 'Processing'), 0) AS Processing, " &
                "       IFNULL(SUM(Status = 'Ready for Release'), 0) AS Ready, " &
                "       IFNULL(SUM(Status = 'Released'), 0) AS Released, " &
                "       IFNULL(SUM(Status = 'Cancelled'), 0) AS Cancelled, " &
                "       IFNULL(SUM(PaymentStatus = 'Unpaid' AND Status <> 'Cancelled'), 0) AS Unpaid, " &
                "       IFNULL(SUM(RequestDate = CURDATE()), 0) AS Today, " &
                "       IFNULL(SUM(CASE WHEN PaymentStatus = 'Paid' AND ORDate = CURDATE() THEN TotalAmount END), 0) AS PaidToday, " &
                "       IFNULL(SUM(CASE WHEN PaymentStatus = 'Paid' AND YEAR(ORDate) = YEAR(CURDATE()) " &
                "                        AND MONTH(ORDate) = MONTH(CURDATE()) THEN TotalAmount END), 0) AS PaidMonth " &
                "  FROM tblrequest").Rows(0)

            lblChipToday.Text = $"Requests Today: {Db.ToInt(s("Today"))}"
            lblChipPaidToday.Text = $"Collected Today: {Money(Db.ToDec(s("PaidToday")))}"
            lblChipMonth.Text = $"Collected This Month: {Money(Db.ToDec(s("PaidMonth")))}"

            tileStudentsNum.Text = Db.ToInt(s("Students")).ToString()
            tilePendingNum.Text = Db.ToInt(s("Pending")).ToString()
            tileProcessingNum.Text = Db.ToInt(s("Processing")).ToString()
            tileReadyNum.Text = Db.ToInt(s("Ready")).ToString()
            tileReleasedNum.Text = Db.ToInt(s("Released")).ToString()
            tileCancelledNum.Text = Db.ToInt(s("Cancelled")).ToString()
            tileUnpaidNum.Text = Db.ToInt(s("Unpaid")).ToString()
            tileDocumentsNum.Text = Db.ToInt(s("Docs")).ToString()

            Dim dt = Db.GetTable(RequestListSql & " ORDER BY r.RequestID DESC LIMIT 10")
            BindGrid(grid, dt, "RequestID")
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub Tile_Click(sender As Object, e As EventArgs)
        Dim ctrl = CType(sender, Control)
        Dim tile = If(TypeOf ctrl Is Panel, ctrl, ctrl.Parent)
        Dim target = CStr(tile.Tag)
        Select Case target
            Case "students"
                MainForm.Current?.OpenModule("students")
            Case "documents"
                MainForm.Current?.OpenModule(If(Session.IsAdmin, "documents", "newrequest"))
            Case Else
                MainForm.Current?.OpenModule("requests", target)
        End Select
    End Sub

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.RowIndex < 0 Then Return
        Dim id = Db.ToInt(grid.Rows(e.RowIndex).Cells("RequestID").Value)
        Using dlg As New RequestDetailsDialog(id)
            dlg.ShowDialog(MainForm.Current)
            If dlg.Changed Then LoadData()
        End Using
    End Sub

End Class
