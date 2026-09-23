Imports MySql.Data.MySqlClient

Public Class ReportsForm

    Private Const RptAll As String = "All Document Requests"
    Private Const RptPending As String = "Pending Requests"
    Private Const RptReleased As String = "Released Requests"
    Private Const RptByDate As String = "Requests by Date"
    Private Const RptByDoc As String = "Requests by Document Type"
    Private Const RptPayment As String = "Payment Report"

    Private isLoaded As Boolean

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = New Date(Today.Year, Today.Month, 1)
        dtpTo.Value = Today
        cboPayFilter.SelectedIndex = 0
        ColorizeColumns(grid, "Status", "Payment")

        Try
            Dim dt = Db.GetTable("SELECT DocumentID, DocumentName FROM tbldocuments ORDER BY DocumentName")
            For Each r As DataRow In dt.Rows
                cboDoc.Items.Add(New KeyValuePair(Of Integer, String)(Db.ToInt(r("DocumentID")), Db.ToStr(r("DocumentName"))))
            Next
            cboDoc.DisplayMember = "Value"
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
        cboDoc.SelectedIndex = 0

        isLoaded = True
        cboReport.SelectedIndex = 0
    End Sub

    Private Sub cboReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReport.SelectedIndexChanged
        If Not isLoaded Then Return
        UpdateFilters()
        Generate()
    End Sub

    Private Sub UpdateFilters()
        Dim rpt = cboReport.Text
        cboDoc.Visible = rpt = RptByDoc
        cboPayFilter.Visible = rpt = RptPayment
        If rpt = RptByDate Then
            chkDate.Checked = True
            chkDate.Enabled = False
        Else
            chkDate.Enabled = True
        End If
        dtpFrom.Enabled = chkDate.Checked
        dtpTo.Enabled = chkDate.Checked
    End Sub

    Private Sub chkDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkDate.CheckedChanged
        dtpFrom.Enabled = chkDate.Checked
        dtpTo.Enabled = chkDate.Checked
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Generate()
    End Sub

    Private Sub Generate()
        If chkDate.Checked AndAlso dtpFrom.Value.Date > dtpTo.Value.Date Then
            Warn("The 'from' date must not be later than the 'to' date.")
            Return
        End If

        Dim rpt = cboReport.Text
        Dim where As New List(Of String)
        Dim ps As New List(Of MySqlParameter)
        If chkDate.Checked Then
            where.Add("r.RequestDate BETWEEN @from AND @to")
            ps.Add(Db.P("@from", dtpFrom.Value.Date))
            ps.Add(Db.P("@to", dtpTo.Value.Date))
        End If

        Dim sql As String
        Dim amountColumn = "Amount"
        Dim note = ""

        Select Case rpt
            Case RptPending
                where.Add("r.Status = 'Pending'")
                sql = RequestListSql & WhereClause(where) & " ORDER BY r.RequestDate, r.RequestNo"

            Case RptReleased
                where.Add("r.Status = 'Released'")
                sql = "SELECT r.RequestNo AS `Request No.`, r.RequestDate AS `Request Date`, r.StudentID AS `Student ID`, " &
                      "       CONCAT(s.FirstName, ' ', s.LastName) AS `Student Name`, r.ORNo AS `OR No.`, " &
                      "       r.TotalAmount AS `Amount`, DATE_FORMAT(r.ReleasedDate, '%m/%d/%Y %h:%i %p') AS `Released On`, " &
                      "       u.FullName AS `Processed By` " &
                      "  FROM tblrequest r JOIN tblstudents s ON s.StudentID = r.StudentID JOIN tblusers u ON u.UserID = r.CreatedBy " &
                      WhereClause(where) & " ORDER BY r.ReleasedDate DESC"

            Case RptByDoc
                If cboDoc.SelectedIndex <= 0 Then
                    where.Add("r.Status <> 'Cancelled'")
                    sql = "SELECT d.DocumentName AS `Document`, COUNT(DISTINCT r.RequestID) AS `No. of Requests`, " &
                          "       SUM(rd.Quantity) AS `Total Copies`, SUM(rd.SubTotal) AS `Total Amount` " &
                          "  FROM tblrequestdetails rd " &
                          "  JOIN tblrequest r ON r.RequestID = rd.RequestID " &
                          "  JOIN tbldocuments d ON d.DocumentID = rd.DocumentID " &
                          WhereClause(where) & " GROUP BY d.DocumentID, d.DocumentName ORDER BY `Total Amount` DESC"
                    amountColumn = "Total Amount"
                    note = " (cancelled requests excluded)"
                Else
                    Dim doc = CType(cboDoc.SelectedItem, KeyValuePair(Of Integer, String))
                    where.Add("rd.DocumentID = @doc")
                    ps.Add(Db.P("@doc", doc.Key))
                    sql = "SELECT r.RequestNo AS `Request No.`, r.RequestDate AS `Date`, r.StudentID AS `Student ID`, " &
                          "       CONCAT(s.FirstName, ' ', s.LastName) AS `Student Name`, rd.Quantity AS `Qty`, " &
                          "       rd.SubTotal AS `Amount`, r.PaymentStatus AS `Payment`, r.Status AS `Status` " &
                          "  FROM tblrequestdetails rd " &
                          "  JOIN tblrequest r ON r.RequestID = rd.RequestID " &
                          "  JOIN tblstudents s ON s.StudentID = r.StudentID " &
                          WhereClause(where) & " ORDER BY r.RequestDate DESC"
                    note = " - " & doc.Value
                End If

            Case RptPayment
                where.Add("r.Status <> 'Cancelled'")
                If cboPayFilter.SelectedIndex > 0 Then
                    where.Add("r.PaymentStatus = @pay")
                    ps.Add(Db.P("@pay", cboPayFilter.Text))
                End If
                sql = "SELECT r.RequestNo AS `Request No.`, r.RequestDate AS `Request Date`, " &
                      "       CONCAT(s.FirstName, ' ', s.LastName) AS `Student Name`, r.TotalAmount AS `Amount`, " &
                      "       r.PaymentStatus AS `Payment`, r.ORNo AS `OR No.`, r.ORDate AS `OR Date`, " &
                      "       r.AmountPaid AS `Amount Paid`, " &
                      "       IF(r.PaymentStatus = 'Paid', r.AmountPaid - r.TotalAmount, 0) AS `Change`, r.Status AS `Status` " &
                      "  FROM tblrequest r JOIN tblstudents s ON s.StudentID = r.StudentID " &
                      WhereClause(where) & " ORDER BY r.RequestDate DESC, r.RequestNo DESC"
                note = " (cancelled requests excluded)"

            Case Else
                sql = RequestListSql & WhereClause(where) & " ORDER BY r.RequestDate DESC, r.RequestNo DESC"
        End Select

        Try
            Dim dt = Db.GetTable(sql, ps.ToArray())
            BindGrid(grid, dt, "RequestID")

            lblReportTitle.Text = rpt & note
            lblReportSubtitle.Text = If(chkDate.Checked,
                                        $"Request date: {dtpFrom.Value:MM/dd/yyyy} to {dtpTo.Value:MM/dd/yyyy}",
                                        "All dates") &
                                     $"   |   Generated {Now:MM/dd/yyyy hh:mm tt} by {Session.FullName}"
            lblSummary.Text = BuildSummary(dt, rpt, amountColumn)
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Shared Function WhereClause(where As List(Of String)) As String
        Return If(where.Count > 0, " WHERE " & String.Join(" AND ", where), "")
    End Function

    Private Shared Function BuildSummary(dt As DataTable, rpt As String, amountColumn As String) As String
        Dim rows = dt.AsEnumerable()
        Dim total = rows.Sum(Function(r) Db.ToDec(r(amountColumn)))
        If rpt = RptPayment Then
            Dim collected = rows.Where(Function(r) Db.ToStr(r("Payment")) = PayPaid).Sum(Function(r) Db.ToDec(r("Amount")))
            Dim unpaid = rows.Where(Function(r) Db.ToStr(r("Payment")) = PayUnpaid).Sum(Function(r) Db.ToDec(r("Amount")))
            Return $"Records: {dt.Rows.Count}     Total Collected: {Money(collected)}     Unpaid Balance: {Money(unpaid)}"
        End If
        Return $"Records: {dt.Rows.Count}     Total Amount: {Money(total)}"
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printer As New GridPrinter(grid, lblReportTitle.Text, lblReportSubtitle.Text, lblSummary.Text)
        printer.ShowPreview(MainForm.Current)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportCsv(grid, lblReportTitle.Text.Replace(" ", "_") & "_" & Today.ToString("yyyyMMdd"))
    End Sub

End Class
