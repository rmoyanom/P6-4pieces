<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicioSesion))
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnIniciarSesion = New System.Windows.Forms.Button()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.PtcLogo = New System.Windows.Forms.PictureBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.LkLblRegistraUsuario = New System.Windows.Forms.LinkLabel()
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(48, 99)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(110, 29)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario:"
        '
        'BtnIniciarSesion
        '
        Me.BtnIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciarSesion.Location = New System.Drawing.Point(12, 214)
        Me.BtnIniciarSesion.Name = "BtnIniciarSesion"
        Me.BtnIniciarSesion.Size = New System.Drawing.Size(366, 59)
        Me.BtnIniciarSesion.TabIndex = 1
        Me.BtnIniciarSesion.Text = "Iniciar Sesión"
        Me.BtnIniciarSesion.UseVisualStyleBackColor = True
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(6, 141)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(153, 29)
        Me.LblContraseña.TabIndex = 0
        Me.LblContraseña.Text = "Contraseña:"
        '
        'PtcLogo
        '
        Me.PtcLogo.Image = Global.LyUserInterface.My.Resources.Resources.image
        Me.PtcLogo.Location = New System.Drawing.Point(-1, -16)
        Me.PtcLogo.Name = "PtcLogo"
        Me.PtcLogo.Size = New System.Drawing.Size(386, 105)
        Me.PtcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtcLogo.TabIndex = 2
        Me.PtcLogo.TabStop = False
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(156, 99)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(221, 35)
        Me.TxtUsuario.TabIndex = 3
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(156, 140)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(221, 35)
        Me.TxtContraseña.TabIndex = 3
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'LkLblRegistraUsuario
        '
        Me.LkLblRegistraUsuario.AutoSize = True
        Me.LkLblRegistraUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LkLblRegistraUsuario.Location = New System.Drawing.Point(190, 178)
        Me.LkLblRegistraUsuario.Name = "LkLblRegistraUsuario"
        Me.LkLblRegistraUsuario.Size = New System.Drawing.Size(173, 20)
        Me.LkLblRegistraUsuario.TabIndex = 4
        Me.LkLblRegistraUsuario.TabStop = True
        Me.LkLblRegistraUsuario.Text = "Crear un nuevo usuario"
        '
        'FrmInicioSesion
        '
        Me.AcceptButton = Me.BtnIniciarSesion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 285)
        Me.Controls.Add(Me.LkLblRegistraUsuario)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.PtcLogo)
        Me.Controls.Add(Me.BtnIniciarSesion)
        Me.Controls.Add(Me.LblContraseña)
        Me.Controls.Add(Me.LblUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInicioSesion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banco del Tiempo"
        Me.TopMost = True
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsuario As Label
    Friend WithEvents BtnIniciarSesion As Button
    Friend WithEvents LblContraseña As Label
    Friend WithEvents PtcLogo As PictureBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents LkLblRegistraUsuario As LinkLabel
End Class
