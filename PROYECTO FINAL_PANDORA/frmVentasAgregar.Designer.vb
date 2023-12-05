<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentasAgregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentasAgregar))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dtpFechaHora = New System.Windows.Forms.DateTimePicker()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.cbIdProducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FECHA Y HORA  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CANTIDAD"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(231, 214)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "CANCELAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(6, 214)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "GUADAR "
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dtpFechaHora
        '
        Me.dtpFechaHora.Location = New System.Drawing.Point(101, 29)
        Me.dtpFechaHora.Name = "dtpFechaHora"
        Me.dtpFechaHora.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaHora.TabIndex = 15
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(101, 88)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(200, 20)
        Me.nudCantidad.TabIndex = 16
        '
        'cbIdProducto
        '
        Me.cbIdProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIdProducto.FormattingEnabled = True
        Me.cbIdProducto.Location = New System.Drawing.Point(101, 128)
        Me.cbIdProducto.Name = "cbIdProducto"
        Me.cbIdProducto.Size = New System.Drawing.Size(200, 21)
        Me.cbIdProducto.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "PRODUCTO"
        '
        'frmVentasAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(318, 247)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbIdProducto)
        Me.Controls.Add(Me.nudCantidad)
        Me.Controls.Add(Me.dtpFechaHora)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentasAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTAS AGREGAR"
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dtpFechaHora As DateTimePicker
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents cbIdProducto As ComboBox
    Friend WithEvents Label1 As Label
End Class
