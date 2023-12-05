
Imports System.Data.OleDb

Public Class PANDORA


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text


        Try
            conexion_.Open()

            Dim consulta As String = "SELECT COUNT(*) FROM usuarios WHERE usuario = '" & usuario & "' AND contrasena = '" & contrasena & "'"
            Dim comando As New OleDbCommand(consulta, conexion_)


            Dim validacionDeCredenciales As Integer = CInt(comando.ExecuteScalar())

            If validacionDeCredenciales > 0 Then

                MsgBox("Credenciales válidas", MsgBoxStyle.Information, "Inicio")
                Form1.Show()
                Me.Close()
            Else
                MsgBox("Credenciales incorrectas", MsgBoxStyle.Critical, "Error")
            End If

        Catch ex As Exception
            MsgBox("Credenciales incorrectas")
        Finally
            conexion_.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
