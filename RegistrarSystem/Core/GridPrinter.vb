Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class GridPrinter

    Private ReadOnly grid As DataGridView
    Private ReadOnly title As String
    Private ReadOnly subtitle As String
    Private ReadOnly summary As String
    Private rowIndex As Integer
    Private pageNo As Integer

    Public Sub New(grid As DataGridView, title As String, subtitle As String, summary As String)
        Me.grid = grid
        Me.title = title
        Me.subtitle = subtitle
        Me.summary = summary
    End Sub

    Public Sub ShowPreview(owner As IWin32Window)
        If grid.Rows.Count = 0 Then
            Warn("There is nothing to print. Generate a report first.")
            Return
        End If
        Using doc As New PrintDocument()
            doc.DocumentName = title
            doc.DefaultPageSettings.Landscape = True
            doc.DefaultPageSettings.Margins = New Margins(50, 50, 50, 50)
            AddHandler doc.BeginPrint, Sub(s, e)
                                           rowIndex = 0
                                           pageNo = 0
                                       End Sub
            AddHandler doc.PrintPage, AddressOf PrintPage
            Using dlg As New PrintPreviewDialog With {
                    .Document = doc, .Width = 1150, .Height = 780,
                    .StartPosition = FormStartPosition.CenterScreen}
                dlg.ShowDialog(owner)
            End Using
        End Using
    End Sub

    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g = e.Graphics
        Dim m = e.MarginBounds
        pageNo += 1

        Using fTitle As New Font("Segoe UI", 15, FontStyle.Bold),
              fSmall As New Font("Segoe UI", 9),
              fHead As New Font("Segoe UI", 9, FontStyle.Bold),
              fCell As New Font("Segoe UI", 8.5F),
              sf As New StringFormat With {
                  .Trimming = StringTrimming.EllipsisCharacter,
                  .FormatFlags = StringFormatFlags.NoWrap,
                  .LineAlignment = StringAlignment.Center}

            Dim y As Single = m.Top
            g.DrawString("OFFICE OF THE REGISTRAR", fSmall, Brushes.DimGray, m.Left, y)
            y += 18
            g.DrawString(title, fTitle, Brushes.Black, m.Left, y)
            y += 30
            g.DrawString(subtitle, fSmall, Brushes.DimGray, m.Left, y)
            y += 26

            Dim cols = grid.Columns.Cast(Of DataGridViewColumn)() _
                        .Where(Function(c) c.Visible) _
                        .OrderBy(Function(c) c.DisplayIndex).ToList()
            Dim totalWidth = cols.Sum(Function(c) c.Width)
            Dim widths = cols.Select(Function(c) CSng(c.Width / totalWidth * m.Width)).ToArray()
            Dim rowH = fCell.GetHeight(g) + 9

            g.FillRectangle(Brushes.Gainsboro, m.Left, y, m.Width, rowH)
            Dim x As Single = m.Left
            For i = 0 To cols.Count - 1
                g.DrawString(cols(i).HeaderText, fHead, Brushes.Black, New RectangleF(x + 3, y, widths(i) - 6, rowH), sf)
                x += widths(i)
            Next
            y += rowH

            e.HasMorePages = False
            While rowIndex < grid.Rows.Count
                If y + rowH > m.Bottom - 30 Then
                    e.HasMorePages = True
                    Exit While
                End If
                Dim row = grid.Rows(rowIndex)
                x = m.Left
                For i = 0 To cols.Count - 1
                    Dim cell = row.Cells(cols(i).Index)
                    Dim text = Convert.ToString(cell.FormattedValue)
                    Using cellFormat = CType(sf.Clone(), StringFormat)
                        If cols(i).ValueType Is GetType(Decimal) Then cellFormat.Alignment = StringAlignment.Far
                        g.DrawString(text, fCell, Brushes.Black, New RectangleF(x + 3, y, widths(i) - 6, rowH), cellFormat)
                    End Using
                    x += widths(i)
                Next
                g.DrawLine(Pens.LightGray, m.Left, y + rowH, m.Right, y + rowH)
                y += rowH
                rowIndex += 1
            End While

            If Not e.HasMorePages AndAlso summary <> "" Then
                g.DrawString(summary, fHead, Brushes.Black, m.Left, y + 10)
            End If

            g.DrawString($"Page {pageNo}   |   Printed {Now:MM/dd/yyyy hh:mm tt} by {Session.FullName}",
                         fSmall, Brushes.Gray, m.Left, m.Bottom - 16)
        End Using
    End Sub

End Class
