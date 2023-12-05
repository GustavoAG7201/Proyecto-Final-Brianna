<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductoListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductoListado))
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListado
        '
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(12, 12)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(574, 375)
        Me.dgvListado.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(663, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ELIMINAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmProductoListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(763, 428)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvListado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductoListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTO LISTADO"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents Button1 As Button
End Class
