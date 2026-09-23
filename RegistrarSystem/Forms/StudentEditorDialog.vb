Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class StudentEditorDialog

    Private Const NamePattern As String = "^[A-Za-zÑñ][A-Za-zÑñ .'\-]{0,49}$"

    Private ReadOnly isNew As Boolean
    Private ReadOnly viewOnly As Boolean

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property StudentId As String

    Public Sub New(studentId As String, Optional viewOnly As Boolean = False)
        InitializeComponent()
        Me.StudentId = studentId
        Me.viewOnly = viewOnly
        isNew = studentId Is Nothing
    End Sub

    Private Sub StudentEditorDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = If(isNew, "Add Student", If(viewOnly, "View Student", "Edit Student"))
        lblHeading.Text = Text
        cboCourse.SelectedIndex = 0
        cboYear.SelectedIndex = 0
        cboStatus.SelectedIndex = 0

        If Not isNew Then
            txtId.ReadOnly = True
            txtId.BackColor = ColReadOnly
            LoadStudent()
        End If

        If viewOnly Then
            For Each t In {txtLrn, txtLast, txtFirst, txtMiddle, txtContact, txtSection}
                t.ReadOnly = True
                t.BackColor = ColReadOnly
            Next
            cboCourse.Enabled = False
            cboYear.Enabled = False
            cboStatus.Enabled = False
            btnSave.Visible = False
            btnCancel.Text = "Close"
            AcceptButton = Nothing
        End If
    End Sub

    Private Sub LoadStudent()
        Try
            Dim dt = Db.GetTable("SELECT * FROM tblstudents WHERE StudentID = @id", Db.P("@id", StudentId))
            If dt.Rows.Count = 0 Then
                Warn("Student record not found.")
                Return
            End If
            Dim r = dt.Rows(0)
            txtId.Text = Db.ToStr(r("StudentID"))
            txtLrn.Text = Db.ToStr(r("LRN"))
            txtLast.Text = Db.ToStr(r("LastName"))
            txtFirst.Text = Db.ToStr(r("FirstName"))
            txtMiddle.Text = Db.ToStr(r("MiddleName"))
            cboCourse.Text = Db.ToStr(r("Course"))
            cboYear.SelectedItem = Db.ToStr(r("YearLevel"))
            txtSection.Text = Db.ToStr(r("Section"))
            txtContact.Text = Db.ToStr(r("ContactNo"))
            cboStatus.SelectedItem = Db.ToStr(r("Status"))
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Function ValidateInputs() As (Message As String, Target As Control)
        Dim id = txtId.Text.Trim()
        If Not Regex.IsMatch(id, "^\d{8}$") Then Return ("Student ID must be exactly 8 digits (e.g. 20260001).", txtId)
        If Not Regex.IsMatch(txtLrn.Text.Trim(), "^\d{12}$") Then Return ("LRN must be exactly 12 digits.", txtLrn)
        If Not Regex.IsMatch(txtLast.Text.Trim(), NamePattern) Then Return ("Enter a valid Last Name (letters, spaces, . ' - only).", txtLast)
        If Not Regex.IsMatch(txtFirst.Text.Trim(), NamePattern) Then Return ("Enter a valid First Name (letters, spaces, . ' - only).", txtFirst)
        If txtMiddle.Text.Trim() <> "" AndAlso Not Regex.IsMatch(txtMiddle.Text.Trim(), NamePattern) Then
            Return ("Middle Name may only contain letters, spaces, . ' -", txtMiddle)
        End If
        If Not Regex.IsMatch(txtContact.Text.Trim(), "^09\d{9}$") Then Return ("Contact Number must be 11 digits starting with 09 (e.g. 09171234567).", txtContact)
        If cboCourse.Text.Trim() = "" Then Return ("Please enter the Course.", cboCourse)
        If cboYear.SelectedIndex < 0 Then Return ("Please select the Year Level.", cboYear)
        If Not Regex.IsMatch(txtSection.Text.Trim(), "^[A-Za-z0-9\- ]{1,20}$") Then Return ("Please enter a valid Section (letters/numbers).", txtSection)

        If isNew AndAlso Db.Exists("SELECT COUNT(*) FROM tblstudents WHERE StudentID = @id", Db.P("@id", id)) Then
            Return ($"Student ID {id} already exists.", txtId)
        End If
        If Db.Exists("SELECT COUNT(*) FROM tblstudents WHERE LRN = @lrn AND StudentID <> @id",
                     Db.P("@lrn", txtLrn.Text.Trim()), Db.P("@id", id)) Then
            Return ("This LRN is already used by another student.", txtLrn)
        End If
        Return (Nothing, Nothing)
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveStudent()
    End Sub

    Private Sub SaveStudent()
        Try
            Dim check = ValidateInputs()
            If check.Message IsNot Nothing Then
                Warn(check.Message)
                check.Target.Focus()
                Return
            End If

            Dim middle = txtMiddle.Text.Trim()
            Dim ps = {
                Db.P("@id", txtId.Text.Trim()),
                Db.P("@lrn", txtLrn.Text.Trim()),
                Db.P("@ln", txtLast.Text.Trim()),
                Db.P("@fn", txtFirst.Text.Trim()),
                Db.P("@mn", If(middle = "", Nothing, middle)),
                Db.P("@course", cboCourse.Text.Trim().ToUpperInvariant()),
                Db.P("@yr", cboYear.Text),
                Db.P("@sec", txtSection.Text.Trim().ToUpperInvariant()),
                Db.P("@contact", txtContact.Text.Trim()),
                Db.P("@st", cboStatus.Text)}

            If isNew Then
                Db.Execute("INSERT INTO tblstudents (StudentID, LRN, LastName, FirstName, MiddleName, Course, YearLevel, Section, ContactNo, Status) " &
                           "VALUES (@id, @lrn, @ln, @fn, @mn, @course, @yr, @sec, @contact, @st)", ps)
            Else
                Db.Execute("UPDATE tblstudents SET LRN = @lrn, LastName = @ln, FirstName = @fn, MiddleName = @mn, Course = @course, " &
                           "YearLevel = @yr, Section = @sec, ContactNo = @contact, Status = @st WHERE StudentID = @id", ps)
            End If

            StudentId = txtId.Text.Trim()
            Info(If(isNew, "Student added successfully.", "Student updated successfully."))
            DialogResult = DialogResult.OK
        Catch ex As MySqlException When ex.Number = Db.ErrDuplicateKey
            Warn("The Student ID or LRN already exists.")
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

End Class
