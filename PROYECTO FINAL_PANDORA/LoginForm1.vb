
Imports System.Data.OleDb

Public Class LoginForm1

    Private conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & Application.StartupPath & "\pandora accdb.accdb")

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text

        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
