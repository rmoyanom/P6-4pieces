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
        resources.ApplyResources(Me.LblTitulo, "LblTitulo")
        Me.LblTitulo.Name = "LblTitulo"
        '
        'LblNombreUsuario
        '
        resources.ApplyResources(Me.LblNombreUsuario, "LblNombreUsuario")
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        '
        'TxtNombreUsuario
        '
        resources.ApplyResources(Me.TxtNombreUsuario, "TxtNombreUsuario")
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        '
        'LblPassword
        '
        resources.ApplyResources(Me.LblPassword, "LblPassword")
        Me.LblPassword.Name = "LblPassword"
        '
        'TxtPassword
        '
        resources.ApplyResources(Me.TxtPassword, "TxtPassword")
        Me.TxtPassword.Name = "TxtPassword"
        '
        'LblTitleDatosPersonales
        '
        resources.ApplyResources(Me.LblTitleDatosPersonales, "LblTitleDatosPersonales")
        Me.LblTitleDatosPersonales.Name = "LblTitleDatosPersonales"
        '
        'LblNombre
        '
        resources.ApplyResources(Me.LblNombre, "LblNombre")
        Me.LblNombre.Name = "LblNombre"
        '
        'TxtNombre
        '
        resources.ApplyResources(Me.TxtNombre, "TxtNombre")
        Me.TxtNombre.Name = "TxtNombre"
        '
        'LblApellidos
        '
        resources.ApplyResources(Me.LblApellidos, "LblApellidos")
        Me.LblApellidos.Name = "LblApellidos"
        '
        'TxtApellidos
        '
        resources.ApplyResources(Me.TxtApellidos, "TxtApellidos")
        Me.TxtApellidos.Name = "TxtApellidos"
        '
        'LblTelefono
        '
        resources.ApplyResources(Me.LblTelefono, "LblTelefono")
        Me.LblTelefono.Name = "LblTelefono"
        '
        'TxtTelefono
        '
        resources.ApplyResources(Me.TxtTelefono, "TxtTelefono")
        Me.TxtTelefono.Name = "TxtTelefono"
        '
        'LblEmail
        '
        resources.ApplyResources(Me.LblEmail, "LblEmail")
        Me.LblEmail.Name = "LblEmail"
        '
        'TxtEmail
        '
        resources.ApplyResources(Me.TxtEmail, "TxtEmail")
        Me.TxtEmail.Name = "TxtEmail"
        '
        'LblError
        '
        resources.ApplyResources(Me.LblError, "LblError")
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Name = "LblError"
        '
        'BtnCancelar
        '
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        resources.ApplyResources(Me.BtnRegistrar, "BtnRegistrar")
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'FrmRegistroUsuario
        '
        Me.AcceptButton = Me.BtnRegistrar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
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
        Me.MaximizeBox = False
        Me.Name = "FrmRegistroUsuario"
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
