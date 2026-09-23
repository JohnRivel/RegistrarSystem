Imports MySql.Data.MySqlClient

Public Module RequestService

    Public Const StPending As String = "Pending"
    Public Const StProcessing As String = "Processing"
    Public Const StReady As String = "Ready for Release"
    Public Const StReleased As String = "Released"
    Public Const StCancelled As String = "Cancelled"

    Public Const PayUnpaid As String = "Unpaid"
    Public Const PayPaid As String = "Paid"

    Public ReadOnly AllStatuses As String() = {StPending, StProcessing, StReady, StReleased, StCancelled}

    Public Const MaxQuantity As Integer = 20

    Public Const RequestListSql As String =
        "SELECT r.RequestID, r.RequestNo AS `Request No.`, r.RequestDate AS `Date`, " &
        "       r.StudentID AS `Student ID`, CONCAT(s.FirstName, ' ', s.LastName) AS `Student Name`, " &
        "       (SELECT GROUP_CONCAT(CONCAT(d.DocumentName, IF(rd.Quantity > 1, CONCAT(' x', rd.Quantity), '')) " &
        "               ORDER BY rd.RequestDetailID SEPARATOR ', ') " &
        "          FROM tblrequestdetails rd JOIN tbldocuments d ON d.DocumentID = rd.DocumentID " &
        "         WHERE rd.RequestID = r.RequestID) AS `Document`, " &
        "       r.TotalAmount AS `Amount`, r.PaymentStatus AS `Payment`, r.Status AS `Status` " &
        "  FROM tblrequest r JOIN tblstudents s ON s.StudentID = r.StudentID "

    Public Function NextStatuses(current As String) As String()
        Select Case current
            Case StPending : Return {StProcessing, StCancelled}
            Case StProcessing : Return {StReady, StCancelled}
            Case StReady : Return {StReleased, StCancelled}
            Case Else : Return Array.Empty(Of String)()
        End Select
    End Function

    Public Function RequiresPayment(status As String) As Boolean
        Return status = StProcessing OrElse status = StReady OrElse status = StReleased
    End Function

    Public Function NextRequestNo(cn As MySqlConnection, tx As MySqlTransaction, year As Integer) As String
        Dim prefix = $"REQ-{year}-"
        Using cmd As New MySqlCommand("SELECT MAX(RequestNo) FROM tblrequest WHERE RequestNo LIKE @p FOR UPDATE", cn, tx)
            cmd.Parameters.AddWithValue("@p", prefix & "%")
            Return prefix & NextSequence(cmd.ExecuteScalar(), prefix).ToString("D5")
        End Using
    End Function

    Public Function PreviewRequestNo(year As Integer) As String
        Dim prefix = $"REQ-{year}-"
        Dim last = Db.Scalar("SELECT MAX(RequestNo) FROM tblrequest WHERE RequestNo LIKE @p", Db.P("@p", prefix & "%"))
        Return prefix & NextSequence(last, prefix).ToString("D5")
    End Function

    Private Function NextSequence(lastNo As Object, prefix As String) As Integer
        If lastNo Is Nothing OrElse lastNo Is DBNull.Value Then Return 1
        Dim n As Integer
        If Integer.TryParse(CStr(lastNo).Substring(prefix.Length), n) Then Return n + 1
        Return 1
    End Function

End Module
