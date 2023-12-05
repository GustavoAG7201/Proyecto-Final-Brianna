Imports System.Data.OleDb
Imports System.Timers
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmUsuarioAgregar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim usuario As String = txtUsuario.Text
        Dim correo As String = txtCorreo.Text
        Dim password As String = txtPasword.Text
        Dim validarContrasena As String = txtValidarContrasena.Text
        Dim nombre As String = txtNombre.Text
        Dim apellidoPaterno As String = txtApellidoPaterno.Text
        Dim apellidomaterno As String = txtApellidoMaterno.Text

        Dim query As String

        If usuario = "" Or correo = "" Or password = "" Then
            MsgBox("favor de llenar el formulario ", MsgBoxStyle.Critical, "aviso")

        Else

            If password <> validarContrasena Then
                MsgBox("las contraseñas no coinciden", MsgBoxStyle.Critical, "aviso ")

            Else

                Try
                    conexion_.Open()
                    query = "INSERT INTO usuarios (usuario, correro, contrasena, nombre, paterno, materno) 
VALUES   ('" & usuario & "','" & correo & "','" & password & "','" & nombre & "','" & apellidoPaterno & "','" & apellidomaterno & "')"

                    Dim COM As New OleDbCommand(query, conexion_)

                    COM.ExecuteNonQuery()
                    conexion_.Close()


                    MsgBox("Registro almacenado", MsgBoxStyle.Information, "aviso")

                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conexion_.Close()
                End Try



            End If




        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmUsuarioAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class