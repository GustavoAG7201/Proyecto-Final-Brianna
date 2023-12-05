<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AGREGARToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AGREGARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AGREGARToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACERCADEEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USUARIOToolStripMenuItem, Me.PRODUCTOSToolStripMenuItem, Me.VENTASToolStripMenuItem, Me.ACERCADEEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(775, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USUARIOToolStripMenuItem
        '
        Me.USUARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LISTADOToolStripMenuItem, Me.AGREGARToolStripMenuItem3})
        Me.USUARIOToolStripMenuItem.Name = "USUARIOToolStripMenuItem"
        Me.USUARIOToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.USUARIOToolStripMenuItem.Text = "USUARIOS"
        '
        'LISTADOToolStripMenuItem
        '
        Me.LISTADOToolStripMenuItem.Name = "LISTADOToolStripMenuItem"
        Me.LISTADOToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LISTADOToolStripMenuItem.Text = "LISTADO "
        '
        'AGREGARToolStripMenuItem3
        '
        Me.AGREGARToolStripMenuItem3.Name = "AGREGARToolStripMenuItem3"
        Me.AGREGARToolStripMenuItem3.Size = New System.Drawing.Size(129, 22)
        Me.AGREGARToolStripMenuItem3.Text = "AGREGAR "
        '
        'PRODUCTOSToolStripMenuItem
        '
        Me.PRODUCTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGREGARToolStripMenuItem, Me.LISTADOToolStripMenuItem1})
        Me.PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem"
        Me.PRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.PRODUCTOSToolStripMenuItem.Text = "PRODUCTOS"
        '
        'AGREGARToolStripMenuItem
        '
        Me.AGREGARToolStripMenuItem.Name = "AGREGARToolStripMenuItem"
        Me.AGREGARToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.AGREGARToolStripMenuItem.Text = "AGREGAR "
        '
        'LISTADOToolStripMenuItem1
        '
        Me.LISTADOToolStripMenuItem1.Name = "LISTADOToolStripMenuItem1"
        Me.LISTADOToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.LISTADOToolStripMenuItem1.Text = "LISTADO"
        '
        'VENTASToolStripMenuItem
        '
        Me.VENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGREGARToolStripMenuItem2, Me.LISTADOToolStripMenuItem3})
        Me.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        Me.VENTASToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.VENTASToolStripMenuItem.Text = "VENTAS "
        '
        'AGREGARToolStripMenuItem2
        '
        Me.AGREGARToolStripMenuItem2.Name = "AGREGARToolStripMenuItem2"
        Me.AGREGARToolStripMenuItem2.Size = New System.Drawing.Size(129, 22)
        Me.AGREGARToolStripMenuItem2.Text = "AGREGAR "
        '
        'LISTADOToolStripMenuItem3
        '
        Me.LISTADOToolStripMenuItem3.Name = "LISTADOToolStripMenuItem3"
        Me.LISTADOToolStripMenuItem3.Size = New System.Drawing.Size(129, 22)
        Me.LISTADOToolStripMenuItem3.Text = "LISTADO "
        '
        'ACERCADEEToolStripMenuItem
        '
        Me.ACERCADEEToolStripMenuItem.Name = "ACERCADEEToolStripMenuItem"
        Me.ACERCADEEToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ACERCADEEToolStripMenuItem.Text = "ACERCA DEE "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 463)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "PANDORA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents USUARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACERCADEEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AGREGARToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents AGREGARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTADOToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AGREGARToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LISTADOToolStripMenuItem3 As ToolStripMenuItem
End Class
