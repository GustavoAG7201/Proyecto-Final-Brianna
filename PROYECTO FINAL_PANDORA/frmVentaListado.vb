Imports System.Data.OleDb

Public Class frmVentaListado
    Private Sub frmVentaListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListVentas()
    End Sub



    Private Sub ListVentas()

        Try
            conexion_.Open()

            Dim query As String = "SELECT id_venta, cantidad, id_producto, fecha_venta FROM  ventas"
            Dim COM As New OleDbCommand(query, conexion_)
            Dim LEC As OleDbDataReader = COM.ExecuteReader()
            Dim TABLA As New DataTable
            TABLA.Load(LEC)
            dgvVentas.DataSource = TABLA
            conexion_.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion_.Close()

        End Try

    End Sub





    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim selected_row As Integer = dgvVentas.CurrentRow.Cells(0).Value
        Dim response As Byte
        response = MsgBox("¿esta seguro de que desea eliminar este  registro ?", MsgBoxStyle.YesNo, "Eliminar")
        If response = 6 Then
            Try
                conexion_.Open()
                Dim query As String = "DELETE FROM usuarios WHERE id_ventas = " & selected_row & ""

                Dim COM As New OleDbCommand(query, conexion_)
                COM.ExecuteNonQuery()
                conexion_.Close()

                MsgBox("registro eliminado ", MsgBoxStyle.Information, "eliminado ")

                ListVentas()
                Me.dgvVentas.CurrentRow.Selected = False

            Catch ex As Exception
                conexion_.Close()
                MsgBox("error al eliminar  el registro", MsgBoxStyle.Critical, "aviso")

            End Try
        End If

    End Sub


End Class