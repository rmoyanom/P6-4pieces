<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVisualizarAnuncio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisualizarAnuncio))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblHorasUser = New System.Windows.Forms.Label()
        Me.LblCantidadSolicitudes = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblFechaCreacion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTags = New System.Windows.Forms.Label()
        Me.LblPuntuacion = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCrearSolicitud = New System.Windows.Forms.Button()
        Me.PnEnvioSolicitud = New System.Windows.Forms.Panel()
        Me.NudHorasRequeridas = New System.Windows.Forms.NumericUpDown()
        Me.LblTituloNhoras = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnGenerarSolicitud = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PnEnvioSolicitud.SuspendLayout()
        CType(Me.NudHorasRequeridas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTitulo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDescripcion, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTags, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPuntuacion, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 495)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(778, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Detalles del anuncio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 383)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(563, 42)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Otras personas que ya han realizado este servicio han valorado la realización de " &
    "esté con la siguiente puntuación"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblTitulo
        '
        Me.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(11, 48)
        Me.LblTitulo.Margin = New System.Windows.Forms.Padding(3)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(563, 34)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "TITULO"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.BackColor = System.Drawing.Color.White
        Me.LblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(11, 88)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(3)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.TableLayoutPanel1.SetRowSpan(Me.LblDescripcion, 2)
        Me.LblDescripcion.Size = New System.Drawing.Size(563, 189)
        Me.LblDescripcion.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 3)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblHorasUser)
        Me.Panel2.Controls.Add(Me.LblCantidadSolicitudes)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.LblFechaCreacion)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.LblUsuario)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(580, 48)
        Me.Panel2.Name = "Panel2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel2, 4)
        Me.Panel2.Size = New System.Drawing.Size(201, 255)
        Me.Panel2.TabIndex = 3
        '
        'LblHorasUser
        '
        Me.LblHorasUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHorasUser.BackColor = System.Drawing.SystemColors.Control
        Me.LblHorasUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHorasUser.Location = New System.Drawing.Point(3, 137)
        Me.LblHorasUser.Name = "LblHorasUser"
        Me.LblHorasUser.Size = New System.Drawing.Size(195, 19)
        Me.LblHorasUser.TabIndex = 1
        Me.LblHorasUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCantidadSolicitudes
        '
        Me.LblCantidadSolicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCantidadSolicitudes.BackColor = System.Drawing.SystemColors.Control
        Me.LblCantidadSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidadSolicitudes.Location = New System.Drawing.Point(3, 229)
        Me.LblCantidadSolicitudes.Name = "LblCantidadSolicitudes"
        Me.LblCantidadSolicitudes.Size = New System.Drawing.Size(195, 19)
        Me.LblCantidadSolicitudes.TabIndex = 1
        Me.LblCantidadSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nº de Horas actuales"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblFechaCreacion
        '
        Me.LblFechaCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechaCreacion.BackColor = System.Drawing.SystemColors.Control
        Me.LblFechaCreacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaCreacion.Location = New System.Drawing.Point(3, 180)
        Me.LblFechaCreacion.Name = "LblFechaCreacion"
        Me.LblFechaCreacion.Size = New System.Drawing.Size(195, 19)
        Me.LblFechaCreacion.TabIndex = 1
        Me.LblFechaCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cantidad de solicitudes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblUsuario
        '
        Me.LblUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(3, 98)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(195, 19)
        Me.LblUsuario.TabIndex = 1
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha de Creación"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Creado por:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblTags
        '
        Me.LblTags.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTags.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTags.Location = New System.Drawing.Point(11, 309)
        Me.LblTags.Margin = New System.Windows.Forms.Padding(3)
        Me.LblTags.Name = "LblTags"
        Me.LblTags.Size = New System.Drawing.Size(563, 68)
        Me.LblTags.TabIndex = 5
        Me.LblTags.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblPuntuacion
        '
        Me.LblPuntuacion.AutoSize = True
        Me.LblPuntuacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPuntuacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntuacion.Location = New System.Drawing.Point(11, 431)
        Me.LblPuntuacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LblPuntuacion.Name = "LblPuntuacion"
        Me.LblPuntuacion.Size = New System.Drawing.Size(563, 61)
        Me.LblPuntuacion.TabIndex = 8
        Me.LblPuntuacion.Text = "5"
        Me.LblPuntuacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCrearSolicitud)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(580, 309)
        Me.Panel3.Name = "Panel3"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel3, 3)
        Me.Panel3.Size = New System.Drawing.Size(201, 183)
        Me.Panel3.TabIndex = 11
        '
        'BtnCrearSolicitud
        '
        Me.BtnCrearSolicitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCrearSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearSolicitud.Location = New System.Drawing.Point(0, 0)
        Me.BtnCrearSolicitud.Name = "BtnCrearSolicitud"
        Me.BtnCrearSolicitud.Size = New System.Drawing.Size(201, 183)
        Me.BtnCrearSolicitud.TabIndex = 10
        Me.BtnCrearSolicitud.Text = "ENVÍAR SOLICITUD"
        Me.BtnCrearSolicitud.UseVisualStyleBackColor = True
        '
        'PnEnvioSolicitud
        '
        Me.PnEnvioSolicitud.Controls.Add(Me.NudHorasRequeridas)
        Me.PnEnvioSolicitud.Controls.Add(Me.LblTituloNhoras)
        Me.PnEnvioSolicitud.Controls.Add(Me.BtnCancel)
        Me.PnEnvioSolicitud.Controls.Add(Me.BtnGenerarSolicitud)
        Me.PnEnvioSolicitud.Controls.Add(Me.Label10)
        Me.PnEnvioSolicitud.Controls.Add(Me.Label6)
        Me.PnEnvioSolicitud.Controls.Add(Me.Label8)
        Me.PnEnvioSolicitud.Controls.Add(Me.Label4)
        Me.PnEnvioSolicitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnEnvioSolicitud.Location = New System.Drawing.Point(0, 0)
        Me.PnEnvioSolicitud.Name = "PnEnvioSolicitud"
        Me.PnEnvioSolicitud.Size = New System.Drawing.Size(784, 495)
        Me.PnEnvioSolicitud.TabIndex = 1
        '
        'NudHorasRequeridas
        '
        Me.NudHorasRequeridas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudHorasRequeridas.Location = New System.Drawing.Point(310, 288)
        Me.NudHorasRequeridas.Name = "NudHorasRequeridas"
        Me.NudHorasRequeridas.Size = New System.Drawing.Size(211, 40)
        Me.NudHorasRequeridas.TabIndex = 4
        '
        'LblTituloNhoras
        '
        Me.LblTituloNhoras.AutoSize = True
        Me.LblTituloNhoras.Location = New System.Drawing.Point(49, 260)
        Me.LblTituloNhoras.Name = "LblTituloNhoras"
        Me.LblTituloNhoras.Size = New System.Drawing.Size(0, 13)
        Me.LblTituloNhoras.TabIndex = 3
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(30, 380)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(215, 80)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "CANCELAR"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnGenerarSolicitud
        '
        Me.BtnGenerarSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarSolicitud.Location = New System.Drawing.Point(372, 380)
        Me.BtnGenerarSolicitud.Name = "BtnGenerarSolicitud"
        Me.BtnGenerarSolicitud.Size = New System.Drawing.Size(381, 80)
        Me.BtnGenerarSolicitud.TabIndex = 2
        Me.BtnGenerarSolicitud.Text = "ACEPTO QUE SE COMPARTA MI INFORMACIÓN"
        Me.BtnGenerarSolicitud.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(89, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(630, 75)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Puede requerirle al anunciante un minimo de horas por el desarrollo de este traba" &
    "jo que posteriormente si se pone acepta su solicitud podrá negociar"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(630, 102)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(260, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(317, 37)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "REQUERIR HORAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(435, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CREACIÓN DE SULICITUD"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.LyUserInterface.My.Resources.Resources.usuario
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmVisualizarAnuncio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 495)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PnEnvioSolicitud)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 534)
        Me.MinimumSize = New System.Drawing.Size(800, 534)
        Me.Name = "FrmVisualizarAnuncio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles del anuncio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PnEnvioSolicitud.ResumeLayout(False)
        Me.PnEnvioSolicitud.PerformLayout()
        CType(Me.NudHorasRequeridas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblHorasUser As Label
    Friend WithEvents LblCantidadSolicitudes As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblFechaCreacion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblTags As Label
    Friend WithEvents LblPuntuacion As Label
    Friend WithEvents PnEnvioSolicitud As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnGenerarSolicitud As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCrearSolicitud As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents NudHorasRequeridas As NumericUpDown
    Friend WithEvents LblTituloNhoras As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
End Class
