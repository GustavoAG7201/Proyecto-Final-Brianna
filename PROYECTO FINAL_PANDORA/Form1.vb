Public Class Form1
    Private Sub ACERCADEEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACERCADEEToolStripMenuItem.Click


        Dim frmAboutBox As New AboutBox1

        AboutBox1.MdiParent = Me
        AboutBox1.Show()

    End Sub

    Private Sub USUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOToolStripMenuItem.Click



    End Sub

    Private Sub LISTADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADOToolStripMenuItem.Click

        Dim frmUsuariosListado As New frmUsuariosListado
        frmUsuariosListado.MdiParent = Me
        frmUsuariosListado.Show()

    End Sub

    Private Sub AGREGARToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem3.Click
        Dim frmUsuariosAgregar As New frmUsuarioAgregar
        frmUsuariosAgregar.MdiParent = Me
        frmUsuariosAgregar.Show()
    End Sub

    Private Sub PRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTOSToolStripMenuItem.Click

    End Sub

    Private Sub AGREGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem.Click
        Dim frmproductosAgregar As New frmProductosAgregar
        frmproductosAgregar.MdiParent = Me
        frmproductosAgregar.Show()
    End Sub

    Private Sub AGREGARToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem2.Click
        Dim frmVentasAgregar As New frmVentasAgregar
        frmVentasAgregar.MdiParent = Me
        frmVentasAgregar.Show()
    End Sub

    Private Sub LISTADOToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles LISTADOToolStripMenuItem3.Click
        Dim frmVentasListado As New frmVentaListado
        frmVentasListado.MdiParent = Me
        frmVentasListado.Show()
    End Sub

    Private Sub LISTADOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LISTADOToolStripMenuItem1.Click
        Dim frmProductosListado As New frmProductoListado
        frmProductosListado.MdiParent = Me
        frmProductosListado.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
