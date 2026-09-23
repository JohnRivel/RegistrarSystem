Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Module Ui

    Public ReadOnly ColBg As Color = Color.FromArgb(41, 44, 58)
    Public ReadOnly ColInput As Color = Color.FromArgb(66, 70, 91)
    Public ReadOnly ColReadOnly As Color = Color.FromArgb(46, 49, 64)
    Public ReadOnly ColCard As Color = Color.FromArgb(51, 55, 72)
    Public ReadOnly ColBar As Color = Color.FromArgb(31, 33, 45)
    Public ReadOnly ColText As Color = Color.FromArgb(236, 238, 244)
    Public ReadOnly ColMuted As Color = Color.FromArgb(158, 164, 184)
    Public ReadOnly ColAccent As Color = Color.FromArgb(74, 125, 255)
    Public ReadOnly ColGreen As Color = Color.FromArgb(38, 170, 118)
    Public ReadOnly ColRed As Color = Color.FromArgb(228, 84, 108)
    Public ReadOnly ColOrange As Color = Color.FromArgb(230, 126, 34)
    Public ReadOnly ColYellow As Color = Color.FromArgb(232, 172, 48)
    Public ReadOnly ColTeal As Color = Color.FromArgb(22, 170, 168)

    Public Function Blend(a As Color, b As Color, amount As Double) As Color
        Return Color.FromArgb(
            CInt(CInt(a.R) + (CInt(b.R) - CInt(a.R)) * amount),
            CInt(CInt(a.G) + (CInt(b.G) - CInt(a.G)) * amount),
            CInt(CInt(a.B) + (CInt(b.B) - CInt(a.B)) * amount))
    End Function

    Public Function StatusColor(status As String) As Color
        Select Case status
            Case RequestService.StPending : Return ColYellow
            Case RequestService.StProcessing : Return ColAccent
            Case RequestService.StReady : Return ColTeal
            Case RequestService.StReleased, RequestService.PayPaid, "Active" : Return ColGreen
            Case RequestService.StCancelled, "Inactive" : Return ColRed
            Case RequestService.PayUnpaid : Return ColOrange
            Case Else : Return Color.Empty
        End Select
    End Function

    Public Sub DimWhenDisabled(ParamArray buttons As Button())
        For Each b In buttons
            Dim normal = b.BackColor
            AddHandler b.EnabledChanged, Sub() b.BackColor = If(b.Enabled, normal, Blend(normal, ColBg, 0.65))
        Next
    End Sub

    Private ReadOnly FillColumns As String() =
        {"Document", "Document Name", "Description", "Student Name", "Name", "Full Name"}

    Public Sub BindGrid(g As DataGridView, dt As DataTable, ParamArray hiddenColumns As String())
        g.DataSource = dt
        Dim anyFill = g.Columns.Cast(Of DataGridViewColumn)().Any(Function(c) FillColumns.Contains(c.Name))
        For Each c As DataGridViewColumn In g.Columns
            c.SortMode = DataGridViewColumnSortMode.Automatic
            If anyFill Then
                c.AutoSizeMode = If(FillColumns.Contains(c.Name),
                                    DataGridViewAutoSizeColumnMode.Fill,
                                    DataGridViewAutoSizeColumnMode.AllCells)
                c.MinimumWidth = 60
            End If
            If hiddenColumns.Contains(c.Name) Then c.Visible = False
            If c.ValueType Is GetType(Decimal) Then
                c.DefaultCellStyle.Format = "#,##0.00"
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            ElseIf c.ValueType Is GetType(Date) Then
                c.DefaultCellStyle.Format = "MM/dd/yyyy"
            End If
        Next
    End Sub

    Public Sub ColorizeColumns(g As DataGridView, ParamArray columnNames As String())
        Dim bold As New Font("Segoe UI Semibold", 9.5F)
        AddHandler g.CellFormatting,
            Sub(sender, e)
                If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
                If Not columnNames.Contains(g.Columns(e.ColumnIndex).Name) Then Return
                Dim c = StatusColor(Db.ToStr(e.Value))
                If c.IsEmpty Then Return
                e.CellStyle.ForeColor = Blend(c, Color.White, 0.25)
                e.CellStyle.Font = bold
            End Sub
    End Sub

    Public Function SelectedValue(g As DataGridView, column As String) As Object
        If g.CurrentRow Is Nothing OrElse Not g.Columns.Contains(column) Then Return Nothing
        Return g.CurrentRow.Cells(column).Value
    End Function

    Public Sub SelectRow(g As DataGridView, column As String, value As Object)
        If value Is Nothing OrElse Not g.Columns.Contains(column) Then Return
        For Each r As DataGridViewRow In g.Rows
            If Equals(r.Cells(column).Value, value) Then
                g.CurrentCell = r.Cells(g.Columns.Cast(Of DataGridViewColumn)().First(Function(c) c.Visible).Index)
                Exit For
            End If
        Next
    End Sub

    Public ReadOnly Peso As String = ChrW(&H20B1)

    Public Function Money(value As Decimal) As String
        Return Peso & value.ToString("#,##0.00")
    End Function

    Public Sub Info(message As String, Optional title As String = "Registrar System")
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub Warn(message As String, Optional title As String = "Please check")
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Function Confirm(message As String, Optional title As String = "Confirm") As Boolean
        Return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Sub ShowError(ex As Exception)
        Dim my = TryCast(ex, MySqlException)
        If my Is Nothing AndAlso ex.InnerException IsNot Nothing Then my = TryCast(ex.InnerException, MySqlException)

        Dim msg As String
        If my IsNot Nothing AndAlso (my.Number = 1042 OrElse my.Number = 0 AndAlso my.Message.Contains("connect")) Then
            msg = "Cannot connect to the MySQL server." & vbCrLf & vbCrLf &
                  "Make sure MySQL is running (XAMPP Control Panel > MySQL > Start) " &
                  "and that registrar_db was imported from Database\registrar_db.sql."
        ElseIf my IsNot Nothing AndAlso my.Number = 1049 Then
            msg = "The database 'registrar_db' does not exist." & vbCrLf & vbCrLf &
                  "Import Database\registrar_db.sql using phpMyAdmin first."
        ElseIf my IsNot Nothing Then
            msg = $"Database error ({my.Number}):{vbCrLf}{my.Message}"
        Else
            msg = "An unexpected error occurred:" & vbCrLf & ex.Message
        End If
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub ExportCsv(g As DataGridView, fileName As String)
        If g.Rows.Count = 0 Then
            Warn("There is nothing to export.")
            Return
        End If
        Using dlg As New SaveFileDialog With {
                .Filter = "CSV file (*.csv)|*.csv",
                .FileName = fileName & ".csv"}
            If dlg.ShowDialog() <> DialogResult.OK Then Return
            Dim cols = g.Columns.Cast(Of DataGridViewColumn)() _
                        .Where(Function(c) c.Visible) _
                        .OrderBy(Function(c) c.DisplayIndex).ToList()
            Dim sb As New StringBuilder()
            sb.AppendLine(String.Join(",", cols.Select(Function(c) CsvCell(c.HeaderText))))
            For Each r As DataGridViewRow In g.Rows
                sb.AppendLine(String.Join(",", cols.Select(Function(c) CsvCell(Convert.ToString(r.Cells(c.Index).FormattedValue)))))
            Next
            File.WriteAllText(dlg.FileName, sb.ToString(), New UTF8Encoding(True))
            Info("Exported to:" & vbCrLf & dlg.FileName)
        End Using
    End Sub

    Private Function CsvCell(s As String) As String
        If String.IsNullOrEmpty(s) Then Return ""
        If s.IndexOfAny({","c, """"c, ControlChars.Cr, ControlChars.Lf}) >= 0 Then
            Return """" & s.Replace("""", """""") & """"
        End If
        Return s
    End Function

    <DllImport("user32.dll")>
    Private Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer) As IntPtr
    End Function

    Public Sub DragWindow(form As Form)
        ReleaseCapture()
        SendMessage(form.Handle, &HA1, 2, 0)
    End Sub

End Module
