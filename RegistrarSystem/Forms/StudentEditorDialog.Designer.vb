<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentEditorDialog
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblIdCap = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblLastCap = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.lblFirstCap = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblMiddleCap = New System.Windows.Forms.Label()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.lblContactCap = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblCourseCap = New System.Windows.Forms.Label()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.lblYearCap = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.lblSectionCap = New System.Windows.Forms.Label()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.lblStatusCap = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblHeading.Location = New System.Drawing.Point(22, 18)
        Me.lblHeading.Size = New System.Drawing.Size(40, 19)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Add Student"
        Me.lblIdCap.AutoSize = True
        Me.lblIdCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblIdCap.Location = New System.Drawing.Point(22, 62)
        Me.lblIdCap.Size = New System.Drawing.Size(40, 19)
        Me.lblIdCap.Name = "lblIdCap"
        Me.lblIdCap.TabIndex = 1
        Me.lblIdCap.Text = "Student ID *"
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtId.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtId.Location = New System.Drawing.Point(22, 84)
        Me.txtId.MaxLength = 8
        Me.txtId.PlaceholderText = "e.g. 20260001"
        Me.txtId.Size = New System.Drawing.Size(288, 26)
        Me.txtId.Name = "txtId"
        Me.txtId.TabIndex = 2
        Me.lblLastCap.AutoSize = True
        Me.lblLastCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLastCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblLastCap.Location = New System.Drawing.Point(22, 122)
        Me.lblLastCap.Size = New System.Drawing.Size(40, 19)
        Me.lblLastCap.Name = "lblLastCap"
        Me.lblLastCap.TabIndex = 5
        Me.lblLastCap.Text = "Last Name *"
        Me.txtLast.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLast.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtLast.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtLast.Location = New System.Drawing.Point(22, 144)
        Me.txtLast.MaxLength = 50
        Me.txtLast.Size = New System.Drawing.Size(288, 26)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.TabIndex = 6
        Me.lblFirstCap.AutoSize = True
        Me.lblFirstCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFirstCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblFirstCap.Location = New System.Drawing.Point(330, 122)
        Me.lblFirstCap.Size = New System.Drawing.Size(40, 19)
        Me.lblFirstCap.Name = "lblFirstCap"
        Me.lblFirstCap.TabIndex = 7
        Me.lblFirstCap.Text = "First Name *"
        Me.txtFirst.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirst.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtFirst.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtFirst.Location = New System.Drawing.Point(330, 144)
        Me.txtFirst.MaxLength = 50
        Me.txtFirst.Size = New System.Drawing.Size(288, 26)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.TabIndex = 8
        Me.lblMiddleCap.AutoSize = True
        Me.lblMiddleCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMiddleCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblMiddleCap.Location = New System.Drawing.Point(22, 182)
        Me.lblMiddleCap.Size = New System.Drawing.Size(40, 19)
        Me.lblMiddleCap.Name = "lblMiddleCap"
        Me.lblMiddleCap.TabIndex = 9
        Me.lblMiddleCap.Text = "Middle Name"
        Me.txtMiddle.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.txtMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtMiddle.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtMiddle.Location = New System.Drawing.Point(22, 204)
        Me.txtMiddle.MaxLength = 50
        Me.txtMiddle.PlaceholderText = "optional"
        Me.txtMiddle.Size = New System.Drawing.Size(288, 26)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.TabIndex = 10
        Me.lblContactCap.AutoSize = True
        Me.lblContactCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblContactCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblContactCap.Location = New System.Drawing.Point(330, 182)
        Me.lblContactCap.Size = New System.Drawing.Size(40, 19)
        Me.lblContactCap.Name = "lblContactCap"
        Me.lblContactCap.TabIndex = 11
        Me.lblContactCap.Text = "Contact Number *"
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtContact.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.txtContact.Location = New System.Drawing.Point(330, 204)
        Me.txtContact.MaxLength = 11
        Me.txtContact.PlaceholderText = "09XXXXXXXXX"
        Me.txtContact.Size = New System.Drawing.Size(288, 26)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.TabIndex = 12
        Me.lblCourseCap.AutoSize = True
        Me.lblCourseCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCourseCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblCourseCap.Location = New System.Drawing.Point(22, 242)
        Me.lblCourseCap.Size = New System.Drawing.Size(40, 19)
        Me.lblCourseCap.Name = "lblCourseCap"
        Me.lblCourseCap.TabIndex = 13
        Me.lblCourseCap.Text = "Course *"
        Me.cboCourse.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCourse.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboCourse.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Items.AddRange(New Object() {"BSIT", "BSCS", "BSCPE", "BSIE", "BSA", "BSBA", "BSCA", "BSREM", "BSCRIM", "BSPSY", "BEED", "BSED", "BTVTED", "BSTM", "BSHM", "JD"})
        Me.cboCourse.Location = New System.Drawing.Point(22, 264)
        Me.cboCourse.MaxLength = 50
        Me.cboCourse.Size = New System.Drawing.Size(288, 27)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.TabIndex = 14
        Me.lblYearCap.AutoSize = True
        Me.lblYearCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblYearCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblYearCap.Location = New System.Drawing.Point(330, 242)
        Me.lblYearCap.Size = New System.Drawing.Size(40, 19)
        Me.lblYearCap.Name = "lblYearCap"
        Me.lblYearCap.TabIndex = 15
        Me.lblYearCap.Text = "Year Level *"
        Me.cboYear.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboYear.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboYear.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year"})
        Me.cboYear.Location = New System.Drawing.Point(330, 264)
        Me.cboYear.Size = New System.Drawing.Size(288, 27)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.TabIndex = 16
        Me.lblSectionCap.AutoSize = True
        Me.lblSectionCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSectionCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblSectionCap.Location = New System.Drawing.Point(22, 302)
        Me.lblSectionCap.Size = New System.Drawing.Size(40, 19)
        Me.lblSectionCap.Name = "lblSectionCap"
        Me.lblSectionCap.TabIndex = 17
        Me.lblSectionCap.Text = "Section *"
        Me.cboSection.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSection.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboSection.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(22, 324)
        Me.cboSection.Size = New System.Drawing.Size(288, 27)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.TabIndex = 18
        Me.lblStatusCap.AutoSize = True
        Me.lblStatusCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusCap.ForeColor = System.Drawing.Color.FromArgb(156, 168, 196)
        Me.lblStatusCap.Location = New System.Drawing.Point(330, 62)
        Me.lblStatusCap.Size = New System.Drawing.Size(40, 19)
        Me.lblStatusCap.Name = "lblStatusCap"
        Me.lblStatusCap.TabIndex = 3
        Me.lblStatusCap.Text = "Status"
        Me.cboStatus.BackColor = System.Drawing.Color.FromArgb(58, 72, 108)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboStatus.Location = New System.Drawing.Point(330, 84)
        Me.cboStatus.Size = New System.Drawing.Size(288, 27)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 4
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(78, 92, 128)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(96, 110, 146)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(390, 384)
        Me.btnCancel.Size = New System.Drawing.Size(110, 36)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(62, 150, 116)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(86, 168, 136)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.RegistrarSystem.My.Resources.Resources.btn_save
        Me.btnSave.Location = New System.Drawing.Point(508, 384)
        Me.btnSave.Size = New System.Drawing.Size(110, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = " Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(37, 47, 75)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(640, 440)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblIdCap)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblLastCap)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.lblFirstCap)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblMiddleCap)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.lblContactCap)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblCourseCap)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.lblYearCap)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.lblSectionCap)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.lblStatusCap)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(220, 225, 236)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentEditorDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblIdCap As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblLastCap As System.Windows.Forms.Label
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstCap As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleCap As System.Windows.Forms.Label
    Friend WithEvents txtMiddle As System.Windows.Forms.TextBox
    Friend WithEvents lblContactCap As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblCourseCap As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearCap As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblSectionCap As System.Windows.Forms.Label
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatusCap As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
