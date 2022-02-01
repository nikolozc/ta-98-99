Public Class Form1

    Private formNumber As Integer = 1
    Private formName As String = "Default"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Form Number: " & formNumber & " Name: " & formName
    End Sub

    Private Sub btnNewForm_Click(sender As Object, e As EventArgs) Handles btnNewForm.Click
        'dim newform as new form1
        Dim newName As String = txtNewFormName.Text
        'newform.formname = newname
        'newform.formnumber = 2
        'newform.showdialog()

        Dim myNewForm As New Form2
        myNewForm.Text = newName
        myNewForm.Show()
    End Sub
End Class
