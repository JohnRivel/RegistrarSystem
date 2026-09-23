Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class RequestDetailsDialog

    Private ReadOnly requestId As Integer

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Changed As Boolean

    Private status As String = ""
    Private paymentStatus As String = ""
    Private totalAmount As Decimal
    Private requestDate As Date

    Public Sub New(requestId As Integer)
        InitializeComponent()
        Me.requestId = requestId
    End Sub

    Private Sub RequestDetailsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpOr.MaxDate = Today
        DimWhenDisabled(btnSavePay, btnStatus)
        LoadRequest()
    End Sub

    Private Sub LoadRequest()
        Try
            Dim dt = Db.GetTable(
                "SELECT r.*, CONCAT_WS(' ', s.FirstName, NULLIF(s.MiddleName, ''), s.LastName) AS StudentName, " &
                "       CONCAT(s.Course, ' / ', s.YearLevel, ' / ', s.Section) AS CourseInfo, s.ContactNo, u.FullName AS ProcessedBy " &
                "  FROM tblrequest r " &
                "  JOIN tblstudents s ON s.StudentID = r.StudentID " &
                "  JOIN tblusers u ON u.UserID = r.CreatedBy " &
                " WHERE r.RequestID = @id", Db.P("@id", requestId))
            If dt.Rows.Count = 0 Then
                Warn("This request no longer exists.")
                Close()
                Return
            End If
            Dim r = dt.Rows(0)
            status = Db.ToStr(r("Status"))
            paymentStatus = Db.ToStr(r("PaymentStatus"))
            totalAmount = Db.ToDec(r("TotalAmount"))
            requestDate = CDate(r("RequestDate"))

            lblReqNo.Text = Db.ToStr(r("RequestNo"))
            Text = "Request Details - " & lblReqNo.Text
            lblStatusBadge.Text = status
            lblStatusBadge.BackColor = StatusColor(status)
            lblPayBadge.Text = paymentStatus
            lblPayBadge.BackColor = StatusColor(paymentStatus)

            txtDate.Text = requestDate.ToString("MM/dd/yyyy")
            txtStudentId.Text = Db.ToStr(r("StudentID"))
            txtStudent.Text = Db.ToStr(r("StudentName"))
            txtCourse.Text = Db.ToStr(r("CourseInfo"))
            txtContact.Text = Db.ToStr(r("ContactNo"))
            txtBy.Text = Db.ToStr(r("ProcessedBy"))
            Dim released = Db.ToDate(r("ReleasedDate"))
            txtReleased.Text = If(released.HasValue, released.Value.ToString("MM/dd/yyyy hh:mm tt"), "-")

            Dim docs = Db.GetTable(
                "SELECT d.DocumentName AS `Document`, rd.Amount AS `Fee`, rd.Quantity AS `Qty`, rd.SubTotal AS `Subtotal` " &
                "  FROM tblrequestdetails rd JOIN tbldocuments d ON d.DocumentID = rd.DocumentID " &
                " WHERE rd.RequestID = @id ORDER BY rd.RequestDetailID", Db.P("@id", requestId))
            BindGrid(gridDocs, docs)
            gridDocs.Columns("Qty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            lblTotal.Text = "Total Amount:  " & Money(totalAmount)

            cboPay.SelectedItem = paymentStatus
            txtOr.Text = Db.ToStr(r("ORNo"))
            Dim orDate = Db.ToDate(r("ORDate"))
            dtpOr.Value = If(orDate.HasValue AndAlso orDate.Value <= Today, orDate.Value, Today)
            numPaid.Value = If(paymentStatus = PayPaid, Db.ToDec(r("AmountPaid")), totalAmount)

            txtCurrent.Text = status
            cboNext.Items.Clear()
            cboNext.Items.AddRange(NextStatuses(status).Cast(Of Object)().ToArray())
            If cboNext.Items.Count > 0 Then cboNext.SelectedIndex = 0

            ApplyLocks()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub ApplyLocks()
        Dim isFinal = status = StReleased OrElse status = StCancelled
        cboPay.Enabled = Not isFinal
        btnSavePay.Enabled = Not isFinal
        cboNext.Enabled = Not isFinal
        btnStatus.Enabled = Not isFinal
        UpdatePaymentInputs()

        If isFinal Then
            lblStatusHint.Text = $"This request is {status}. No further changes are allowed."
            lblStatusHint.ForeColor = ColMuted
        ElseIf paymentStatus <> PayPaid Then
            lblStatusHint.Text = "Record the payment first before the request can be processed."
            lblStatusHint.ForeColor = ColYellow
        Else
            lblStatusHint.Text = "Flow: Pending > Processing > Ready for Release > Released"
            lblStatusHint.ForeColor = ColMuted
        End If
    End Sub

    Private Sub cboPay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPay.SelectedIndexChanged
        UpdatePaymentInputs()
    End Sub

    Private Sub numPaid_ValueChanged(sender As Object, e As EventArgs) Handles numPaid.ValueChanged
        UpdateChange()
    End Sub

    Private Sub UpdatePaymentInputs()
        Dim editable = cboPay.Enabled AndAlso cboPay.Text = PayPaid
        txtOr.ReadOnly = Not editable
        txtOr.BackColor = If(editable, ColInput, ColReadOnly)
        dtpOr.Enabled = editable
        numPaid.ReadOnly = Not editable
        numPaid.Increment = If(editable, 1D, 0D)
        numPaid.BackColor = If(editable, ColInput, ColReadOnly)
        UpdateChange()
    End Sub

    Private Sub UpdateChange()
        If cboPay.Text <> PayPaid Then
            lblChange.Text = $"Amount due: {Money(totalAmount)}"
            lblChange.ForeColor = ColYellow
        ElseIf numPaid.Value < totalAmount Then
            lblChange.Text = $"Short by {Money(totalAmount - numPaid.Value)}"
            lblChange.ForeColor = ColRed
        Else
            lblChange.Text = $"Change: {Money(numPaid.Value - totalAmount)}"
            lblChange.ForeColor = ColGreen
        End If
    End Sub

    Private Sub btnSavePay_Click(sender As Object, e As EventArgs) Handles btnSavePay.Click
        SavePayment()
    End Sub

    Private Sub SavePayment()
        Try
            If cboPay.Text = PayPaid Then
                Dim orNo = txtOr.Text.Trim().ToUpperInvariant()
                If Not Regex.IsMatch(orNo, "^[A-Z0-9\-]{3,30}$") Then
                    Warn("Enter a valid OR Number (letters, numbers and dashes, at least 3 characters).")
                    txtOr.Focus()
                    Return
                End If
                If dtpOr.Value.Date < requestDate Then
                    Warn("The OR Date cannot be earlier than the request date (" & requestDate.ToString("MM/dd/yyyy") & ").")
                    Return
                End If
                If numPaid.Value < totalAmount Then
                    Warn($"Amount Paid must be at least the total amount of {Money(totalAmount)}.")
                    numPaid.Focus()
                    Return
                End If
                If Db.Exists("SELECT COUNT(*) FROM tblrequest WHERE ORNo = @or AND RequestID <> @id",
                             Db.P("@or", orNo), Db.P("@id", requestId)) Then
                    Warn($"OR Number {orNo} is already used by another request.")
                    txtOr.Focus()
                    Return
                End If

                Db.Execute("UPDATE tblrequest SET PaymentStatus = 'Paid', ORNo = @or, ORDate = @d, AmountPaid = @a WHERE RequestID = @id",
                           Db.P("@or", orNo), Db.P("@d", dtpOr.Value.Date), Db.P("@a", numPaid.Value), Db.P("@id", requestId))
                Info($"Payment recorded.{vbCrLf}OR Number: {orNo}{vbCrLf}Change: {Money(numPaid.Value - totalAmount)}")
            Else
                If paymentStatus = PayUnpaid Then
                    Info("The request is already marked as Unpaid.")
                    Return
                End If
                If RequiresPayment(status) Then
                    Warn($"This request is already {status}. It cannot be set back to Unpaid.")
                    Return
                End If
                If Not Confirm("Remove the payment record (OR Number, OR Date, Amount Paid) from this request?") Then Return
                Db.Execute("UPDATE tblrequest SET PaymentStatus = 'Unpaid', ORNo = NULL, ORDate = NULL, AmountPaid = 0 WHERE RequestID = @id",
                           Db.P("@id", requestId))
            End If
            Changed = True
            LoadRequest()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        UpdateStatus()
    End Sub

    Private Sub UpdateStatus()
        Dim target = cboNext.Text
        If target = "" Then
            Warn("Select the new status.")
            Return
        End If
        If RequiresPayment(target) AndAlso paymentStatus <> PayPaid Then
            Warn($"Please record the payment (Payment Status = Paid, OR Number and OR Date) before setting the status to {target}.")
            cboPay.Focus()
            Return
        End If
        Dim prompt = $"Change status from {status} to {target}?"
        If target = StCancelled Then prompt &= vbCrLf & vbCrLf & "A cancelled request can no longer be processed."
        If target = StReleased Then prompt &= vbCrLf & vbCrLf & "Confirm that the documents were handed to the student."
        If Not Confirm(prompt, "Update Status") Then Return

        Try
            Dim rows = Db.Execute(
                "UPDATE tblrequest SET Status = @new, ReleasedDate = IF(@new = 'Released', NOW(), ReleasedDate) " &
                " WHERE RequestID = @id AND Status = @old",
                Db.P("@new", target), Db.P("@id", requestId), Db.P("@old", status))
            If rows = 0 Then
                Warn("This request was updated by another user. The latest data will be reloaded.")
            Else
                Changed = True
            End If
            LoadRequest()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

End Class
