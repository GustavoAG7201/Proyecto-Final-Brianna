Imports System.Data.OleDb
Public Class frmVentasAgregar

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim cantidad As Integer = nudCantidad.Value
        Dim fecha_hora As Date = dtpFechaHora.Value
        Dim id_producto As Integer = CInt(cbIdProducto.SelectedValue)



        Dim query As String

        If cantidad = 0 Then

            MsgBox("favor de llenar el formulario ", MsgBoxStyle.Critical, "aviso ")

        Else

            Try

                conexion_.Open()

                query = "INSERT INTO ventas ( cantidad, id_producto, fecha_venta ) VALUES (' " & cantidad & "'," & id_producto & ", '" & fecha_hora & " ' )"

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

    Private Sub frmVentasAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion_.Open()

            Dim query As String = "Select id_producto, producto from productos"
            Dim tabla As New DataTable
            Dim adp As New OleDbDataAdapter(query, conexion_)
            adp.Fill(tabla)

            cbIdProducto.DataSource = tabla
            cbIdProducto.DisplayMember = "producto"
            cbIdProducto.ValueMember = "id_producto"
            conexion_.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub
End Class