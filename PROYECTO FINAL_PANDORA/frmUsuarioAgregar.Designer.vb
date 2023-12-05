<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarioAgregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarioAgregar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPasword = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtValidarContrasena = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATOS DE INICIO DE SESION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CONTRASEÑA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(595, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "VALIDAR CONTRASEÑA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CORRERO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(420, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DATOS GENERALES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "NOMBRE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(620, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "APELLIDO MATERNO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "APELLIDO PATERNO"
        '
        'txtPasword
        '
        Me.txtPasword.Location = New System.Drawing.Point(411, 55)
        Me.txtPasword.Name = "txtPasword"
        Me.txtPasword.Size = New System.Drawing.Size(164, 20)
        Me.txtPasword.TabIndex = 2
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(101, 105)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(189, 20)
        Me.txtCorreo.TabIndex = 3
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(431, 222)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(144, 20)
        Me.txtApellidoPaterno.TabIndex = 6
        '
        'txtValidarContrasena
        '
        Me.txtValidarContrasena.Location = New System.Drawing.Point(742, 59)
        Me.txtValidarContrasena.Name = "txtValidarContrasena"
        Me.txtValidarContrasena.Size = New System.Drawing.Size(155, 20)
        Me.txtValidarContrasena.TabIndex = 4
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(742, 222)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(159, 20)
        Me.txtApellidoMaterno.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 218)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(189, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(101, 55)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(189, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(753, 294)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(114, 294)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmUsuarioAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 319)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.txtValidarContrasena)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtPasword)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsuarioAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPasword As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents txtValidarContrasena As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
