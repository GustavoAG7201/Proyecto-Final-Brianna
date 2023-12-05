Imports System.Data.OleDb
Public Class frmProductosAgregar


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim producto As String = txtProducto.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim cantidad As String = nudCantidad.Value
        Dim precio As String = nudPrecio.Value
        Dim fecha_hora As Date = dtpFechaHora.Value


        Dim query As String

        If producto = " " Or cantidad = " " Or descripcion = " " Then

            MsgBox("favor de llenar el formulario ", MsgBoxStyle.Critical, "aviso ")

        Else

            Try

                conexion_.Open()

                query = "INSERT INTO productos ( producto, cantidad, fecha_venta, descripcion, precio )
 VALUES (' " & producto & "','" & cantidad & "','" & fecha_hora & "','" & descripcion & "','" & precio & " ' )"

                Dim COM As New OleDbCommand(query, conexion_)

                COM.ExecuteNonQuery()
                conexion_.Close()
                MsgBox("registro almacenado", MsgBoxStyle.Information, "aviso")

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion_.Close()

            End Try

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub
End Class