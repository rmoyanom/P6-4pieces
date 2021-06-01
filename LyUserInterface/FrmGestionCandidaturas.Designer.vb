<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionCandidaturas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblFechaInscripcion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblHorasRequeridas = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTags = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PnAccion = New System.Windows.Forms.Panel()
        Me.NudHoras = New System.Windows.Forms.NumericUpDown()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.RtxtMotivoCancelacion = New System.Windows.Forms.RichTextBox()
        Me.BtnAccion = New System.Windows.Forms.Button()
        Me.LblAccion = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PnAccion.SuspendLayout()
        CType(Me.NudHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DETALLES DE CANDIDATURA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(127, 3)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(3)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(334, 26)
        Me.LblUsuario.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(127, 35)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(3)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(334, 29)
        Me.lblNombre.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Apellidos:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidos.Location = New System.Drawing.Point(127, 70)
        Me.LblApellidos.Margin = New System.Windows.Forms.Padding(3)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(334, 29)
        Me.LblApellidos.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 105)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 31)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Telefono:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(127, 105)
        Me.LblTelefono.Margin = New System.Windows.Forms.Padding(3)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(334, 31)
        Me.LblTelefono.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 142)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Correo:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.Location = New System.Drawing.Point(127, 142)
        Me.LblCorreo.Margin = New System.Windows.Forms.Padding(3)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(334, 25)
        Me.LblCorreo.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(477, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 39)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Estado:"
        '
        'LblEstado
        '
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(593, 48)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(195, 58)
        Me.LblEstado.TabIndex = 1
        Me.LblEstado.Text = "Estado"
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(553, 189)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(195, 51)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar Solicitud"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(553, 246)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(195, 51)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "Cancelar Solicitud"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizar.Location = New System.Drawing.Point(553, 303)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(195, 51)
        Me.BtnFinalizar.TabIndex = 2
        Me.BtnFinalizar.Text = "Finalizar Solicitud"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.72414!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.27586!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblUsuario, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNombre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCorreo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTelefono, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblApellidos, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblFechaInscripcion, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LblHorasRequeridas, 1, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 62)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(464, 266)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 173)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fecha"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblFechaInscripcion
        '
        Me.LblFechaInscripcion.AutoSize = True
        Me.LblFechaInscripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFechaInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaInscripcion.Location = New System.Drawing.Point(127, 173)
        Me.LblFechaInscripcion.Margin = New System.Windows.Forms.Padding(3)
        Me.LblFechaInscripcion.Name = "LblFechaInscripcion"
        Me.LblFechaInscripcion.Size = New System.Drawing.Size(334, 31)
        Me.LblFechaInscripcion.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 210)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 77)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Horas requeridas:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblHorasRequeridas
        '
        Me.LblHorasRequeridas.AutoSize = True
        Me.LblHorasRequeridas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblHorasRequeridas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHorasRequeridas.Location = New System.Drawing.Point(127, 210)
        Me.LblHorasRequeridas.Margin = New System.Windows.Forms.Padding(3)
        Me.LblHorasRequeridas.Name = "LblHorasRequeridas"
        Me.LblHorasRequeridas.Size = New System.Drawing.Size(334, 77)
        Me.LblHorasRequeridas.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(589, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Acciones"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblTags
        '
        Me.LblTags.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTags.Location = New System.Drawing.Point(7, 375)
        Me.LblTags.Margin = New System.Windows.Forms.Padding(3)
        Me.LblTags.Name = "LblTags"
        Me.LblTags.Size = New System.Drawing.Size(464, 68)
        Me.LblTags.TabIndex = 6
        Me.LblTags.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(172, 355)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Tags de usuario"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PnAccion
        '
        Me.PnAccion.Controls.Add(Me.NudHoras)
        Me.PnAccion.Controls.Add(Me.lblInfo)
        Me.PnAccion.Controls.Add(Me.RtxtMotivoCancelacion)
        Me.PnAccion.Controls.Add(Me.BtnAccion)
        Me.PnAccion.Controls.Add(Me.LblAccion)
        Me.PnAccion.Location = New System.Drawing.Point(7, 49)
        Me.PnAccion.Name = "PnAccion"
        Me.PnAccion.Size = New System.Drawing.Size(781, 416)
        Me.PnAccion.TabIndex = 8
        Me.PnAccion.Visible = False
        '
        'NudHoras
        '
        Me.NudHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudHoras.Location = New System.Drawing.Point(282, 153)
        Me.NudHoras.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudHoras.Name = "NudHoras"
        Me.NudHoras.Size = New System.Drawing.Size(199, 38)
        Me.NudHoras.TabIndex = 4
        Me.NudHoras.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudHoras.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(136, 57)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(501, 80)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Inidque el motivo de la cancelación"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RtxtMotivoCancelacion
        '
        Me.RtxtMotivoCancelacion.Location = New System.Drawing.Point(216, 140)
        Me.RtxtMotivoCancelacion.Name = "RtxtMotivoCancelacion"
        Me.RtxtMotivoCancelacion.Size = New System.Drawing.Size(336, 106)
        Me.RtxtMotivoCancelacion.TabIndex = 2
        Me.RtxtMotivoCancelacion.Text = ""
        Me.RtxtMotivoCancelacion.Visible = False
        '
        'BtnAccion
        '
        Me.BtnAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccion.Location = New System.Drawing.Point(242, 306)
        Me.BtnAccion.Name = "BtnAccion"
        Me.BtnAccion.Size = New System.Drawing.Size(273, 67)
        Me.BtnAccion.TabIndex = 1
        Me.BtnAccion.Text = "Realizar"
        Me.BtnAccion.UseVisualStyleBackColor = True
        '
        'LblAccion
        '
        Me.LblAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccion.Location = New System.Drawing.Point(19, 9)
        Me.LblAccion.Name = "LblAccion"
        Me.LblAccion.Size = New System.Drawing.Size(738, 46)
        Me.LblAccion.TabIndex = 0
        Me.LblAccion.Text = "Aceptar Solicitud"
        Me.LblAccion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmGestionCandidaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.PnAccion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblTags)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BtnFinalizar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmGestionCandidaturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles Candidatura"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PnAccion.ResumeLayout(False)
        CType(Me.NudHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblApellidos As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblFechaInscripcion As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblHorasRequeridas As Label
    Friend WithEvents LblTags As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PnAccion As Panel
    Friend WithEvents BtnAccion As Button
    Friend WithEvents LblAccion As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents RtxtMotivoCancelacion As RichTextBox
    Friend WithEvents NudHoras As NumericUpDown
End Class
