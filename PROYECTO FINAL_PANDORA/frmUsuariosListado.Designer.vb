<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuariosListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuariosListado))
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(21, 12)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(721, 340)
        Me.dgvUsuarios.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(764, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 35)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmUsuariosListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 356)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsuariosListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS LISTADO"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnEliminar As Button
End Class
