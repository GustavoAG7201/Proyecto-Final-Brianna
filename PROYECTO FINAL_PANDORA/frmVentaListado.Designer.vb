<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentaListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentaListado))
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(573, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "ELIMINAR "
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(12, 12)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(519, 370)
        Me.dgvVentas.TabIndex = 1
        '
        'frmVentaListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 394)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnEliminar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentaListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTA LISTADO "
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvVentas As DataGridView
End Class
