<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMisAnuncios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMisAnuncios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAddAnuncio = New System.Windows.Forms.Button()
        Me.LblSubtitulo = New System.Windows.Forms.Label()
        Me.UcListaAnuncios = New LyUserInterface.UcListaAnuncios()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnActivos = New System.Windows.Forms.Button()
        Me.BtnFinalizados = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PtcLogo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnVerGestionarAnuncio = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTGCandidaturas = New System.Windows.Forms.DataGridView()
        Me.LblTituloVentana = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.RtxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkList = New System.Windows.Forms.CheckedListBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.lblAccionesTitulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnVerGestionarAnuncio.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DTGCandidaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.BtnAddAnuncio)
        Me.Panel1.Controls.Add(Me.LblSubtitulo)
        Me.Panel1.Controls.Add(Me.UcListaAnuncios)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 575)
        Me.Panel1.TabIndex = 3
        '
        'BtnAddAnuncio
        '
        Me.BtnAddAnuncio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddAnuncio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddAnuncio.Image = Global.LyUserInterface.My.Resources.Resources.add1
        Me.BtnAddAnuncio.Location = New System.Drawing.Point(507, 47)
        Me.BtnAddAnuncio.Name = "BtnAddAnuncio"
        Me.BtnAddAnuncio.Size = New System.Drawing.Size(179, 42)
        Me.BtnAddAnuncio.TabIndex = 6
        Me.BtnAddAnuncio.Text = "Publicar anuncio"
        Me.BtnAddAnuncio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddAnuncio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddAnuncio.UseVisualStyleBackColor = True
        '
        'LblSubtitulo
        '
        Me.LblSubtitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubtitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtitulo.Location = New System.Drawing.Point(6, 54)
        Me.LblSubtitulo.Name = "LblSubtitulo"
        Me.LblSubtitulo.Size = New System.Drawing.Size(495, 33)
        Me.LblSubtitulo.TabIndex = 5
        Me.LblSubtitulo.Text = "Activos"
        Me.LblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UcListaAnuncios
        '
        Me.UcListaAnuncios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcListaAnuncios.AutoScroll = True
        Me.UcListaAnuncios.BackColor = System.Drawing.Color.Azure
        Me.UcListaAnuncios.Location = New System.Drawing.Point(3, 92)
        Me.UcListaAnuncios.Name = "UcListaAnuncios"
        Me.UcListaAnuncios.Size = New System.Drawing.Size(683, 456)
        Me.UcListaAnuncios.TabIndex = 4
        Me.UcListaAnuncios.TextoBotones = "Gestionar"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Azure
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 554)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(689, 21)
        Me.Panel4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mis anuncios"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnVolver, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnActivos, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnFinalizados, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(220, 575)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'BtnVolver
        '
        Me.BtnVolver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Image = Global.LyUserInterface.My.Resources.Resources.back
        Me.BtnVolver.Location = New System.Drawing.Point(3, 354)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(214, 116)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "VOLVER"
        Me.BtnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnActivos
        '
        Me.BtnActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivos.Image = Global.LyUserInterface.My.Resources.Resources.publicOn
        Me.BtnActivos.Location = New System.Drawing.Point(3, 96)
        Me.BtnActivos.Name = "BtnActivos"
        Me.BtnActivos.Size = New System.Drawing.Size(214, 122)
        Me.BtnActivos.TabIndex = 0
        Me.BtnActivos.Text = "Activos"
        Me.BtnActivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnActivos.UseVisualStyleBackColor = True
        '
        'BtnFinalizados
        '
        Me.BtnFinalizados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnFinalizados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizados.Image = Global.LyUserInterface.My.Resources.Resources.publicOf
        Me.BtnFinalizados.Location = New System.Drawing.Point(3, 224)
        Me.BtnFinalizados.Name = "BtnFinalizados"
        Me.BtnFinalizados.Size = New System.Drawing.Size(214, 124)
        Me.BtnFinalizados.TabIndex = 1
        Me.BtnFinalizados.Text = "Finalizados"
        Me.BtnFinalizados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnFinalizados.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.PtcLogo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 93)
        Me.Panel2.TabIndex = 5
        '
        'PtcLogo
        '
        Me.PtcLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PtcLogo.Image = Global.LyUserInterface.My.Resources.Resources.image
        Me.PtcLogo.Location = New System.Drawing.Point(0, 0)
        Me.PtcLogo.Name = "PtcLogo"
        Me.PtcLogo.Size = New System.Drawing.Size(220, 93)
        Me.PtcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtcLogo.TabIndex = 3
        Me.PtcLogo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Azure
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 554)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(220, 21)
        Me.Panel3.TabIndex = 6
        '
        'PnVerGestionarAnuncio
        '
        Me.PnVerGestionarAnuncio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnVerGestionarAnuncio.Controls.Add(Me.TableLayoutPanel4)
        Me.PnVerGestionarAnuncio.Location = New System.Drawing.Point(1, 0)
        Me.PnVerGestionarAnuncio.Name = "PnVerGestionarAnuncio"
        Me.PnVerGestionarAnuncio.Size = New System.Drawing.Size(908, 572)
        Me.PnVerGestionarAnuncio.TabIndex = 4
        Me.PnVerGestionarAnuncio.Visible = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel3, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.LblTituloVentana, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel8, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 5)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(904, 572)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DTGCandidaturas, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(414, 37)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(487, 532)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(481, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "LISTA CANDIDATURAS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DTGCandidaturas
        '
        Me.DTGCandidaturas.AllowUserToAddRows = False
        Me.DTGCandidaturas.AllowUserToDeleteRows = False
        Me.DTGCandidaturas.AllowUserToResizeColumns = False
        Me.DTGCandidaturas.AllowUserToResizeRows = False
        Me.DTGCandidaturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGCandidaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGCandidaturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTGCandidaturas.Location = New System.Drawing.Point(3, 25)
        Me.DTGCandidaturas.Name = "DTGCandidaturas"
        Me.DTGCandidaturas.ReadOnly = True
        Me.DTGCandidaturas.RowHeadersVisible = False
        Me.DTGCandidaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGCandidaturas.ShowCellErrors = False
        Me.DTGCandidaturas.ShowCellToolTips = False
        Me.DTGCandidaturas.ShowEditingIcon = False
        Me.DTGCandidaturas.ShowRowErrors = False
        Me.DTGCandidaturas.Size = New System.Drawing.Size(481, 504)
        Me.DTGCandidaturas.TabIndex = 1
        '
        'LblTituloVentana
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.LblTituloVentana, 3)
        Me.LblTituloVentana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTituloVentana.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTituloVentana.Location = New System.Drawing.Point(3, 3)
        Me.LblTituloVentana.Margin = New System.Windows.Forms.Padding(3)
        Me.LblTituloVentana.Name = "LblTituloVentana"
        Me.LblTituloVentana.Size = New System.Drawing.Size(898, 28)
        Me.LblTituloVentana.TabIndex = 0
        Me.LblTituloVentana.Text = "GESTIONAR ANUNCIO"
        Me.LblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnGuardar, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.RtxtDescripcion, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtTitulo, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkList, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(153, 37)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(258, 532)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(3, 476)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(252, 53)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        Me.BtnGuardar.Visible = False
        '
        'RtxtDescripcion
        '
        Me.RtxtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtxtDescripcion.Location = New System.Drawing.Point(3, 53)
        Me.RtxtDescripcion.Name = "RtxtDescripcion"
        Me.RtxtDescripcion.ReadOnly = True
        Me.RtxtDescripcion.Size = New System.Drawing.Size(252, 318)
        Me.RtxtDescripcion.TabIndex = 13
        Me.RtxtDescripcion.Text = ""
        '
        'TxtTitulo
        '
        Me.TxtTitulo.BackColor = System.Drawing.Color.White
        Me.TxtTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitulo.Location = New System.Drawing.Point(3, 25)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.ReadOnly = True
        Me.TxtTitulo.Size = New System.Drawing.Size(252, 22)
        Me.TxtTitulo.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DATOS ANUNCIO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChkList
        '
        Me.ChkList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkList.Enabled = False
        Me.ChkList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList.FormattingEnabled = True
        Me.ChkList.Location = New System.Drawing.Point(3, 377)
        Me.ChkList.Name = "ChkList"
        Me.ChkList.Size = New System.Drawing.Size(252, 93)
        Me.ChkList.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.BtnSalir)
        Me.Panel8.Controls.Add(Me.BtnFinalizar)
        Me.Panel8.Controls.Add(Me.BtnEditar)
        Me.Panel8.Controls.Add(Me.lblAccionesTitulo)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 37)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(147, 532)
        Me.Panel8.TabIndex = 16
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.LyUserInterface.My.Resources.Resources.back
        Me.BtnSalir.Location = New System.Drawing.Point(3, 406)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(142, 122)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "VOLVER"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFinalizar.Location = New System.Drawing.Point(3, 73)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(141, 43)
        Me.BtnFinalizar.TabIndex = 1
        Me.BtnFinalizar.Text = "FINALIZAR"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Location = New System.Drawing.Point(3, 24)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(141, 43)
        Me.BtnEditar.TabIndex = 1
        Me.BtnEditar.Text = "EDITAR ANUNCIO"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'lblAccionesTitulo
        '
        Me.lblAccionesTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccionesTitulo.Location = New System.Drawing.Point(3, 5)
        Me.lblAccionesTitulo.Name = "lblAccionesTitulo"
        Me.lblAccionesTitulo.Size = New System.Drawing.Size(142, 24)
        Me.lblAccionesTitulo.TabIndex = 0
        Me.lblAccionesTitulo.Text = "ACCIONES"
        Me.lblAccionesTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmMisAnuncios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 575)
        Me.Controls.Add(Me.PnVerGestionarAnuncio)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMisAnuncios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banco del tiempo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnVerGestionarAnuncio.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DTGCandidaturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnActivos As Button
    Friend WithEvents BtnFinalizados As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PtcLogo As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UcListaAnuncios As UcListaAnuncios
    Friend WithEvents LblSubtitulo As Label
    Friend WithEvents BtnAddAnuncio As Button
    Friend WithEvents PnVerGestionarAnuncio As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents lblAccionesTitulo As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents DTGCandidaturas As DataGridView
    Friend WithEvents RtxtDescripcion As RichTextBox
    Friend WithEvents TxtTitulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkList As CheckedListBox
    Friend WithEvents LblTituloVentana As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnVolver As Button
End Class
