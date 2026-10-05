<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.cboReport = New System.Windows.Forms.ComboBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.cboDoc = New System.Windows.Forms.ComboBox()
        Me.cboPayFilter = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.lblReportSubtitle = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.lblSummary = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.lblIcon.AutoSize = True
        Me.lblIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 22.0!)
        Me.lblIcon.ForeColor = System.Drawing.Color.FromArgb(226, 186, 92)
        Me.lblIcon.Location = New System.Drawing.Point(26, 22)
        Me.lblIcon.Size = New System.Drawing.Size(40, 19)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.TabIndex = 0
        Me.lblIcon.Text = ""
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 17.0!)
        Me.lblTitle.Location = New System.Drawing.Point(70, 18)
        Me.lblTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Reports"
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblSubtitle.Location = New System.Drawing.Point(72, 56)
        Me.lblSubtitle.Size = New System.Drawing.Size(40, 19)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Choose a report, set the filters, then click Generate"
        Me.cboReport.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReport.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboReport.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboReport.FormattingEnabled = True
        Me.cboReport.Items.AddRange(New Object() {"All Document Requests", "Pending Requests", "Released Requests", "Requests by Date", "Requests by Document Type", "Payment Report"})
        Me.cboReport.Location = New System.Drawing.Point(28, 99)
        Me.cboReport.Size = New System.Drawing.Size(230, 27)
        Me.cboReport.Name = "cboReport"
        Me.cboReport.TabIndex = 3
        Me.chkDate.AutoSize = True
        Me.chkDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDate.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.chkDate.Location = New System.Drawing.Point(268, 101)
        Me.chkDate.Size = New System.Drawing.Size(60, 23)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.TabIndex = 4
        Me.chkDate.Text = "Date range:"
        Me.chkDate.UseVisualStyleBackColor = True
        Me.dtpFrom.CustomFormat = "MM/dd/yyyy"
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(370, 100)
        Me.dtpFrom.Size = New System.Drawing.Size(125, 26)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.TabIndex = 5
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblTo.Location = New System.Drawing.Point(502, 103)
        Me.lblTo.Size = New System.Drawing.Size(40, 19)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.TabIndex = 6
        Me.lblTo.Text = "to"
        Me.dtpTo.CustomFormat = "MM/dd/yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(526, 100)
        Me.dtpTo.Size = New System.Drawing.Size(125, 26)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.TabIndex = 7
        Me.cboDoc.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDoc.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboDoc.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboDoc.FormattingEnabled = True
        Me.cboDoc.Items.AddRange(New Object() {"All Documents (summary)"})
        Me.cboDoc.Location = New System.Drawing.Point(661, 99)
        Me.cboDoc.Size = New System.Drawing.Size(230, 27)
        Me.cboDoc.Name = "cboDoc"
        Me.cboDoc.TabIndex = 8
        Me.cboPayFilter.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboPayFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPayFilter.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboPayFilter.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboPayFilter.FormattingEnabled = True
        Me.cboPayFilter.Items.AddRange(New Object() {"All Payments", "Paid", "Unpaid"})
        Me.cboPayFilter.Location = New System.Drawing.Point(661, 99)
        Me.cboPayFilter.Size = New System.Drawing.Size(140, 27)
        Me.cboPayFilter.Name = "cboPayFilter"
        Me.cboPayFilter.TabIndex = 9
        Me.cboPayFilter.Visible = False
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(62, 104, 186)
        Me.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerate.FlatAppearance.BorderSize = 0
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(82, 124, 204)
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Image = Global.RegistrarSystem.My.Resources.Resources.btn_chart
        Me.btnGenerate.Location = New System.Drawing.Point(28, 138)
        Me.btnGenerate.Size = New System.Drawing.Size(115, 36)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.TabIndex = 10
        Me.btnGenerate.Text = " Generate"
        Me.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGenerate.UseVisualStyleBackColor = False
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(78, 92, 128)
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(96, 110, 146)
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = Global.RegistrarSystem.My.Resources.Resources.btn_print
        Me.btnPrint.Location = New System.Drawing.Point(151, 138)
        Me.btnPrint.Size = New System.Drawing.Size(95, 36)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = " Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(78, 92, 128)
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(96, 110, 146)
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Image = Global.RegistrarSystem.My.Resources.Resources.btn_export
        Me.btnExport.Location = New System.Drawing.Point(254, 138)
        Me.btnExport.Size = New System.Drawing.Size(125, 36)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.TabIndex = 12
        Me.btnExport.Text = " Export CSV"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = False
        Me.lblReportTitle.AutoSize = True
        Me.lblReportTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblReportTitle.Location = New System.Drawing.Point(26, 188)
        Me.lblReportTitle.Size = New System.Drawing.Size(40, 19)
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.TabIndex = 13
        Me.lblReportTitle.Text = "Report title"
        Me.lblReportSubtitle.AutoSize = True
        Me.lblReportSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblReportSubtitle.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblReportSubtitle.Location = New System.Drawing.Point(28, 214)
        Me.lblReportSubtitle.Size = New System.Drawing.Size(40, 19)
        Me.lblReportSubtitle.Name = "lblReportSubtitle"
        Me.lblReportSubtitle.TabIndex = 14
        Me.lblReportSubtitle.Text = "Filters"
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(51, 64, 98)
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.BackgroundColor = System.Drawing.Color.FromArgb(46, 58, 90)
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(30, 39, 64)
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(30, 39, 64)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeight = 40
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(46, 58, 90)
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(62, 104, 186)
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid.EnableHeadersVisualStyles = False
        Me.grid.GridColor = System.Drawing.Color.FromArgb(68, 82, 118)
        Me.grid.Location = New System.Drawing.Point(28, 240)
        Me.grid.MultiSelect = False
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.RowTemplate.Height = 34
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(986, 360)
        Me.grid.Name = "grid"
        Me.grid.TabIndex = 15
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSummary.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblSummary.Location = New System.Drawing.Point(26, 610)
        Me.lblSummary.Size = New System.Drawing.Size(40, 19)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.TabIndex = 16
        Me.lblSummary.Text = "Records: 0"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(37, 47, 75)
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.lblIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.cboReport)
        Me.Controls.Add(Me.chkDate)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.cboDoc)
        Me.Controls.Add(Me.cboPayFilter)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblReportTitle)
        Me.Controls.Add(Me.lblReportSubtitle)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lblSummary)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportsForm"
        Me.Text = "Reports"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents cboReport As System.Windows.Forms.ComboBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboDoc As System.Windows.Forms.ComboBox
    Friend WithEvents cboPayFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents lblReportTitle As System.Windows.Forms.Label
    Friend WithEvents lblReportSubtitle As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblSummary As System.Windows.Forms.Label
End Class
