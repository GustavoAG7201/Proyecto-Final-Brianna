<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductosAgregar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosAgregar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaHora = New System.Windows.Forms.DateTimePicker()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCTOS "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PRODUCTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CANTIDAD "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DESCRIPCION "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "FECHA_VENTA"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(352, 121)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(210, 24)
        Me.txtDescripcion.TabIndex = 9
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(78, 55)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(120, 20)
        Me.txtProducto.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "PRECIO "
        '
        'btnAgregar
        '
        Me.btnAgregar.AutoSize = True
        Me.btnAgregar.Location = New System.Drawing.Point(24, 263)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 13)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "AGREGAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(474, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "CANCELAR"
        '
        'dtpFechaHora
        '
        Me.dtpFechaHora.Location = New System.Drawing.Point(338, 45)
        Me.dtpFechaHora.Name = "dtpFechaHora"
        Me.dtpFechaHora.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaHora.TabIndex = 17
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(78, 130)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(120, 20)
        Me.nudCantidad.TabIndex = 18
        '
        'nudPrecio
        '
        Me.nudPrecio.Location = New System.Drawing.Point(78, 188)
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.Size = New System.Drawing.Size(120, 20)
        Me.nudPrecio.TabIndex = 19
        '
        'frmProductosAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(553, 291)
        Me.Controls.Add(Me.nudPrecio)
        Me.Controls.Add(Me.nudCantidad)
        Me.Controls.Add(Me.dtpFechaHora)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductosAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos Agregar"
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAgregar As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFechaHora As DateTimePicker
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents nudPrecio As NumericUpDown
End Class
