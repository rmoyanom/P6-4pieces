<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroUsuario
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroUsuario))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblNombreUsuario = New System.Windows.Forms.Label()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblTitleDatosPersonales = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblError = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(50, 20)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(374, 29)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Registrate como nuevo usuario"
        '
        'LblNombreUsuario
        '
        Me.LblNombreUsuario.AutoSize = True
        Me.LblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreUsuario.Location = New System.Drawing.Point(20, 70)
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        Me.LblNombreUsuario.Size = New System.Drawing.Size(140, 24)
        Me.LblNombreUsuario.TabIndex = 0
        Me.LblNombreUsuario.Text = "Nuevo Usuario:"
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(200, 65)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(160, 29)
        Me.TxtNombreUsuario.TabIndex = 1
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(400, 70)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(136, 24)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Tu contraseña:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(600, 70)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(160, 29)
        Me.TxtPassword.TabIndex = 3
        '
        'LblTitleDatosPersonales
        '
        Me.LblTitleDatosPersonales.AutoSize = True
        Me.LblTitleDatosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleDatosPersonales.Location = New System.Drawing.Point(50, 150)
        Me.LblTitleDatosPersonales.Name = "LblTitleDatosPersonales"
        Me.LblTitleDatosPersonales.Size = New System.Drawing.Size(204, 26)
        Me.LblTitleDatosPersonales.TabIndex = 4
        Me.LblTitleDatosPersonales.Text = "Datos personales:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(20, 200)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(84, 24)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(119, 195)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(160, 29)
        Me.TxtNombre.TabIndex = 5
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidos.Location = New System.Drawing.Point(299, 200)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(93, 24)
        Me.LblApellidos.TabIndex = 6
        Me.LblApellidos.Text = "Apellidos:"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidos.Location = New System.Drawing.Point(400, 195)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(360, 29)
        Me.TxtApellidos.TabIndex = 7
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(20, 250)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(90, 24)
        Me.LblTelefono.TabIndex = 8
        Me.LblTelefono.Text = "Teléfono:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(119, 245)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(160, 29)
        Me.TxtTelefono.TabIndex = 9
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(299, 250)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(68, 24)
        Me.LblEmail.TabIndex = 10
        Me.LblEmail.Text = "E-mail:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(400, 245)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(360, 29)
        Me.TxtEmail.TabIndex = 11
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(20, 300)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(232, 20)
        Me.LblError.TabIndex = 14
        Me.LblError.Text = ""
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(20, 350)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(300, 60)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(460, 350)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(300, 60)
        Me.BtnRegistrar.TabIndex = 13
        Me.BtnRegistrar.Text = "Guardar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'FrmRegistroUsuario
        '
        Me.AcceptButton = Me.BtnRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(780, 450)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LblNombreUsuario)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblTitleDatosPersonales)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblApellidos)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Name = "FrmRegistroUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Icon = CType(Resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Text = "FrmRegistroUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblTitleDatosPersonales As Label
    Friend WithEvents LblNombreUsuario As Label
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblApellidos As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblError As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnRegistrar As Button

End Class
