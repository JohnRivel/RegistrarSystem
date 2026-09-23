Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class DocumentEditorDialog

    Private ReadOnly isNew As Boolean

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property DocumentId As Integer

    Public Sub New(documentId As Integer)
        InitializeComponent()
        Me.DocumentId = documentId
        isNew = documentId = 0
    End Sub

    Private Sub DocumentEditorDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = If(isNew, "Add Document", "Edit Document")
        lblHeading.Text = Text
        cboStatus.SelectedIndex = 0
        If Not isNew Then
            txtId.Text = DocumentId.ToString()
            LoadDocument()
        End If
    End Sub

    Private Sub LoadDocument()
        Try
            Dim dt = Db.GetTable("SELECT * FROM tbldocuments WHERE DocumentID = @id", Db.P("@id", DocumentId))
            If dt.Rows.Count = 0 Then Return
            Dim r = dt.Rows(0)
            txtName.Text = Db.ToStr(r("DocumentName"))
            txtDesc.Text = Db.ToStr(r("Description"))
            numFee.Value = Db.ToDec(r("Fee"))
            cboStatus.SelectedItem = Db.ToStr(r("Status"))
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveDocument()
    End Sub

    Private Sub SaveDocument()
        Dim name = txtName.Text.Trim()
        If name.Length < 3 Then
            Warn("Document Name must have at least 3 characters.")
            txtName.Focus()
            Return
        End If
        If numFee.Value <= 0 AndAlso Not Confirm("The fee is " & Money(0) & ". Save this as a free document?") Then
            numFee.Focus()
            Return
        End If

        Try
            If Db.Exists("SELECT COUNT(*) FROM tbldocuments WHERE DocumentName = @n AND DocumentID <> @id",
                         Db.P("@n", name), Db.P("@id", DocumentId)) Then
                Warn("A document with this name already exists.")
                txtName.Focus()
                Return
            End If

            Dim desc = txtDesc.Text.Trim()
            Dim ps = {Db.P("@id", DocumentId), Db.P("@n", name), Db.P("@d", If(desc = "", Nothing, desc)),
                      Db.P("@fee", numFee.Value), Db.P("@st", cboStatus.Text)}
            If isNew Then
                Using cn = Db.OpenConnection()
                    Using cmd As New MySqlCommand("INSERT INTO tbldocuments (DocumentName, Description, Fee, Status) VALUES (@n, @d, @fee, @st)", cn)
                        cmd.Parameters.AddRange(ps)
                        cmd.ExecuteNonQuery()
                        DocumentId = CInt(cmd.LastInsertedId)
                    End Using
                End Using
            Else
                Db.Execute("UPDATE tbldocuments SET DocumentName = @n, Description = @d, Fee = @fee, Status = @st WHERE DocumentID = @id", ps)
            End If
            Info(If(isNew, "Document added successfully.", "Document updated successfully." & vbCrLf &
                    "Note: existing requests keep the fee that was charged at the time."))
            DialogResult = DialogResult.OK
        Catch ex As MySqlException When ex.Number = Db.ErrDuplicateKey
            Warn("A document with this name already exists.")
        Catch ex As Exception
            Ui.ShowError(ex)
        End Try
    End Sub

End Class
