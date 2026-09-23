Imports MySql.Data.MySqlClient

Public Class RequestListForm

    Private ReadOnly initialFilter As String
    Private isLoaded As Boolean

    Public Sub New(Optional filter As String = Nothing)
        InitializeComponent()
        initialFilter = filter
    End Sub

    Private Sub RequestListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.SelectedIndex = 0
        cboPay.SelectedIndex = 0
        dtpFrom.Value = New Date(Today.Year, Today.Month, 1)
        dtpTo.Value = Today
        dtpFrom.Enabled = False
        dtpTo.Enabled = False
        ColorizeColumns(grid, "Status", "Payment")

        If initialFilter IsNot Nothing Then
            If initialFilter.StartsWith("pay:") Then
                cboPay.SelectedItem = initialFilter.Substring(4)
            ElseIf AllStatuses.Contains(initialFilter) Then
                cboStatus.SelectedItem = initialFilter
            End If
        End If

        isLoaded = True
        LoadData()
        txtSearch.Select()
    End Sub

    Private Sub LoadData()
        If chkDate.Checked AndAlso dtpFrom.Value.Date > dtpTo.Value.Date Then
            Warn("The 'from' date must not be later than the 'to' date.")
            Return
        End If
        Try
            Dim where As New List(Of String)
            Dim ps As New List(Of MySqlParameter)
            Dim q = txtSearch.Text.Trim()
            If q <> "" Then
                where.Add("(r.RequestNo LIKE @q OR r.StudentID LIKE @q OR r.ORNo LIKE @q " &
                          " OR CONCAT(s.FirstName, ' ', s.LastName) LIKE @q OR CONCAT(s.LastName, ', ', s.FirstName) LIKE @q)")
                ps.Add(Db.P("@q", "%" & q & "%"))
            End If
            If cboStatus.SelectedIndex > 0 Then
                where.Add("r.Status = @st")
                ps.Add(Db.P("@st", cboStatus.Text))
            End If
            If cboPay.SelectedIndex > 0 Then
                where.Add("r.PaymentStatus = @pay")
                ps.Add(Db.P("@pay", cboPay.Text))
            End If
            If chkDate.Checked Then
                where.Add("r.RequestDate BETWEEN @from AND @to")
                ps.Add(Db.P("@from", dtpFrom.Value.Date))
                ps.Add(Db.P("@to", dtpTo.Value.Date))
            End If

            Dim sql = RequestListSql &
                      If(where.Count > 0, " WHERE " & String.Join(" AND ", where), "") &
                      " ORDER BY r.RequestDate DESC, r.RequestNo DESC"

            Dim keep = SelectedValue(grid, "RequestID")
            Dim dt = Db.GetTable(sql, ps.ToArray())
            BindGrid(grid, dt, "RequestID")
            SelectRow(grid, "RequestID", keep)

            Dim total = dt.AsEnumerable().Sum(Function(r) Db.ToDec(r("Amount")))
            lblSummary.Text = $"{dt.Rows.Count} request(s)   |   Total amount: {Money(total)}"
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, btnRefresh.Click
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchTimer.Stop()
        searchTimer.Start()
    End Sub

    Private Sub searchTimer_Tick(sender As Object, e As EventArgs) Handles searchTimer.Tick
        searchTimer.Stop()
        LoadData()
    End Sub

    Private Sub Filters_Changed(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged, cboPay.SelectedIndexChanged
        If isLoaded Then LoadData()
    End Sub

    Private Sub chkDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkDate.CheckedChanged
        dtpFrom.Enabled = chkDate.Checked
        dtpTo.Enabled = chkDate.Checked
        If isLoaded Then LoadData()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenSelected()
    End Sub

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.RowIndex >= 0 Then OpenSelected()
    End Sub

    Private Sub grid_KeyDown(sender As Object, e As KeyEventArgs) Handles grid.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            OpenSelected()
        End If
    End Sub

    Private Sub OpenSelected()
        Dim id = Db.ToInt(SelectedValue(grid, "RequestID"))
        If id = 0 Then
            Warn("Please select a request first.")
            Return
        End If
        Using dlg As New RequestDetailsDialog(id)
            dlg.ShowDialog(MainForm.Current)
            If dlg.Changed Then LoadData()
        End Using
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        MainForm.Current?.OpenModule("newrequest")
    End Sub

End Class
