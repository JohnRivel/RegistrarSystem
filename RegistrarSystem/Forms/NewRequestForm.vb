Imports MySql.Data.MySqlClient

Public Class NewRequestForm

    Private Class DocItem
        Public Property ID As Integer
        Public Property Name As String
        Public Property Fee As Decimal
        Public Overrides Function ToString() As String
            Return $"{Name}  -  {Money(Fee)}"
        End Function
    End Class

    Private studentId As String

    Private Sub NewRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.MaxDate = Today
        dtpDate.Value = Today
        txtBy.Text = Session.FullName
        colId.ValueType = GetType(Integer)
        colFee.ValueType = GetType(Decimal)
        colQty.ValueType = GetType(Integer)
        colSub.ValueType = GetType(Decimal)
        LoadDocuments()
        ShowPreviewNumber()
        txtStudentId.Select()
    End Sub

    Private Sub LoadDocuments()
        Try
            cboDoc.Items.Clear()
            Dim dt = Db.GetTable("SELECT DocumentID, DocumentName, Fee FROM tbldocuments WHERE Status = 'Active' ORDER BY DocumentName")
            For Each r As DataRow In dt.Rows
                cboDoc.Items.Add(New DocItem With {.ID = Db.ToInt(r("DocumentID")), .Name = Db.ToStr(r("DocumentName")), .Fee = Db.ToDec(r("Fee"))})
            Next
            If cboDoc.Items.Count > 0 Then cboDoc.SelectedIndex = 0
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
        UpdateAmount()
    End Sub

    Private Sub DocOrQty_Changed(sender As Object, e As EventArgs) Handles cboDoc.SelectedIndexChanged, numQty.ValueChanged
        UpdateAmount()
    End Sub

    Private Sub UpdateAmount()
        Dim doc = TryCast(cboDoc.SelectedItem, DocItem)
        If doc Is Nothing Then
            lblAmount.Text = "Select a document to see its amount."
            Return
        End If
        Dim qty = CInt(numQty.Value)
        lblAmount.Text = $"Fee: {Money(doc.Fee)}   x   {qty}   =   Amount: {Money(doc.Fee * qty)}"
    End Sub

    Private Sub ShowPreviewNumber()
        Try
            txtReqNo.Text = PreviewRequestNo(dtpDate.Value.Year) & "  (auto)"
        Catch ex As Exception
            txtReqNo.Text = "(generated on save)"
        End Try
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        ShowPreviewNumber()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        FindStudent()
    End Sub

    Private Sub txtStudentId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentId.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            FindStudent()
        End If
    End Sub

    Private Sub txtStudentId_TextChanged(sender As Object, e As EventArgs) Handles txtStudentId.TextChanged
        If studentId IsNot Nothing AndAlso txtStudentId.Text.Trim() <> studentId Then ClearStudent(False)
    End Sub

    Private Sub FindStudent()
        Dim id = txtStudentId.Text.Trim()
        If id = "" Then
            Warn("Enter a Student ID, or click Browse to search by name.")
            txtStudentId.Focus()
            Return
        End If
        Try
            Dim dt = Db.GetTable(
                "SELECT StudentID, CONCAT_WS(' ', FirstName, NULLIF(MiddleName, ''), LastName) AS FullName, " &
                "       Course, YearLevel, Section, Status FROM tblstudents WHERE StudentID = @id",
                Db.P("@id", id))
            If dt.Rows.Count = 0 Then
                ClearStudent(False)
                Warn($"No student found with Student ID {id}.")
                txtStudentId.SelectAll()
                txtStudentId.Focus()
                Return
            End If
            Dim r = dt.Rows(0)
            If Db.ToStr(r("Status")) <> "Active" Then
                ClearStudent(False)
                Warn($"Student {id} is INACTIVE. A request cannot be created for an inactive student.")
                Return
            End If
            studentId = Db.ToStr(r("StudentID"))
            txtName.Text = Db.ToStr(r("FullName"))
            txtCourse.Text = Db.ToStr(r("Course"))
            txtYear.Text = $"{r("YearLevel")} - {r("Section")}"
            cboDoc.Focus()
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using dlg As New StudentPickerDialog()
            If dlg.ShowDialog(MainForm.Current) = DialogResult.OK Then
                txtStudentId.Text = dlg.SelectedStudentId
                FindStudent()
            End If
        End Using
    End Sub

    Private Sub ClearStudent(clearIdText As Boolean)
        studentId = Nothing
        If clearIdText Then txtStudentId.Clear()
        txtName.Clear()
        txtCourse.Clear()
        txtYear.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddItem()
    End Sub

    Private Sub AddItem()
        Dim doc = TryCast(cboDoc.SelectedItem, DocItem)
        If doc Is Nothing Then
            Warn("Please select a document.")
            Return
        End If
        Dim qty = CInt(numQty.Value)

        For Each row As DataGridViewRow In gridItems.Rows
            If CInt(row.Cells("colId").Value) = doc.ID Then
                Dim newQty = CInt(row.Cells("colQty").Value) + qty
                If newQty > MaxQuantity Then
                    Warn($"The quantity for {doc.Name} cannot exceed {MaxQuantity}.")
                    Return
                End If
                row.Cells("colQty").Value = newQty
                Recalculate()
                Return
            End If
        Next

        gridItems.Rows.Add(doc.ID, doc.Name, doc.Fee, qty, doc.Fee * qty)
        numQty.Value = 1
        Recalculate()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RemoveItem()
    End Sub

    Private Sub gridItems_KeyDown(sender As Object, e As KeyEventArgs) Handles gridItems.KeyDown
        If e.KeyCode = Keys.Delete AndAlso Not gridItems.IsCurrentCellInEditMode Then RemoveItem()
    End Sub

    Private Sub RemoveItem()
        If gridItems.CurrentRow Is Nothing Then
            Warn("Select a document line to remove.")
            Return
        End If
        gridItems.Rows.Remove(gridItems.CurrentRow)
        Recalculate()
    End Sub

    Private Sub gridItems_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles gridItems.CellValidating
        If gridItems.Columns(e.ColumnIndex).Name <> "colQty" Then Return
        Dim q As Integer
        If Not Integer.TryParse(Convert.ToString(e.FormattedValue), q) OrElse q < 1 OrElse q > MaxQuantity Then
            lblItems.Text = $"Quantity must be a whole number from 1 to {MaxQuantity} (press Esc to undo)."
            lblItems.ForeColor = ColRed
            e.Cancel = True
        End If
    End Sub

    Private Sub gridItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gridItems.CellEndEdit
        Recalculate()
    End Sub

    Private Sub gridItems_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles gridItems.DataError
        e.Cancel = True
    End Sub

    Private Function Recalculate() As Decimal
        Dim total As Decimal = 0D
        Dim copies = 0
        For Each row As DataGridViewRow In gridItems.Rows
            Dim fee = CDec(row.Cells("colFee").Value)
            Dim qty = CInt(row.Cells("colQty").Value)
            Dim subTotal = fee * qty
            row.Cells("colSub").Value = subTotal
            total += subTotal
            copies += qty
        Next
        lblTotal.Text = Money(total)
        lblItems.ForeColor = ColMuted
        lblItems.Text = If(gridItems.Rows.Count = 0, "No documents added yet.",
                           $"{gridItems.Rows.Count} document type(s), {copies} copy/copies")
        Return total
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveRequest()
    End Sub

    Private Sub SaveRequest()
        If gridItems.IsCurrentCellInEditMode AndAlso Not gridItems.EndEdit() Then Return

        If studentId Is Nothing Then
            Warn("Search and select a valid student first.")
            txtStudentId.Focus()
            Return
        End If
        If gridItems.Rows.Count = 0 Then
            Warn("Add at least one document to the request.")
            cboDoc.Focus()
            Return
        End If
        If dtpDate.Value.Date > Today Then
            Warn("The request date cannot be in the future.")
            Return
        End If

        Dim total = Recalculate()
        If Not Confirm($"Save this request?{vbCrLf}{vbCrLf}Student: {txtName.Text}{vbCrLf}" &
                       $"Documents: {gridItems.Rows.Count}{vbCrLf}Total Amount: {Money(total)}", "Save Request") Then Return

        Dim requestNo As String = Nothing
        Dim requestId As Integer
        Try
            Using cn = Db.OpenConnection()
                Using tx = cn.BeginTransaction()
                    requestNo = NextRequestNo(cn, tx, dtpDate.Value.Year)

                    Using cmd As New MySqlCommand(
                        "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, TotalAmount, PaymentStatus, Status, CreatedBy) " &
                        "VALUES (@no, @sid, @dt, @total, @pay, @st, @by)", cn, tx)
                        cmd.Parameters.AddWithValue("@no", requestNo)
                        cmd.Parameters.AddWithValue("@sid", studentId)
                        cmd.Parameters.AddWithValue("@dt", dtpDate.Value.Date)
                        cmd.Parameters.AddWithValue("@total", total)
                        cmd.Parameters.AddWithValue("@pay", PayUnpaid)
                        cmd.Parameters.AddWithValue("@st", StPending)
                        cmd.Parameters.AddWithValue("@by", Session.UserID)
                        cmd.ExecuteNonQuery()
                        requestId = CInt(cmd.LastInsertedId)
                    End Using

                    For Each row As DataGridViewRow In gridItems.Rows
                        Using cmd As New MySqlCommand(
                            "INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) " &
                            "VALUES (@rid, @did, @qty, @amt, @sub)", cn, tx)
                            cmd.Parameters.AddWithValue("@rid", requestId)
                            cmd.Parameters.AddWithValue("@did", CInt(row.Cells("colId").Value))
                            cmd.Parameters.AddWithValue("@qty", CInt(row.Cells("colQty").Value))
                            cmd.Parameters.AddWithValue("@amt", CDec(row.Cells("colFee").Value))
                            cmd.Parameters.AddWithValue("@sub", CDec(row.Cells("colSub").Value))
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    tx.Commit()
                End Using
            End Using
        Catch ex As Exception
            Ui.ShowError(ex)
            Return
        End Try

        txtReqNo.Text = requestNo
        Dim openNow = Confirm($"Request saved successfully!{vbCrLf}{vbCrLf}" &
                              $"Request Number:  {requestNo}{vbCrLf}Total Amount:  {Money(total)}{vbCrLf}{vbCrLf}" &
                              "Open the request now to record the payment?", "Request Saved")
        ClearForm()
        If openNow Then
            Using dlg As New RequestDetailsDialog(requestId)
                dlg.ShowDialog(MainForm.Current)
            End Using
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If gridItems.Rows.Count = 0 OrElse Confirm("Clear this request form?") Then ClearForm()
    End Sub

    Private Sub ClearForm()
        ClearStudent(True)
        gridItems.Rows.Clear()
        numQty.Value = 1
        dtpDate.Value = Today
        If cboDoc.Items.Count > 0 Then cboDoc.SelectedIndex = 0
        Recalculate()
        ShowPreviewNumber()
        txtStudentId.Focus()
    End Sub

End Class
