<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnMiCuenta = New System.Windows.Forms.Button()
        Me.BtnMiServicios = New System.Windows.Forms.Button()
        Me.BtnMisAnuncios = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PtcLogo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAddAnuncio = New System.Windows.Forms.Button()
        Me.UcListaAnuncios = New LyUserInterface.UcListaAnuncios()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnMiCuenta, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnMiServicios, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnMisAnuncios, 0, 3)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(220, 498)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnMiCuenta
        '
        Me.BtnMiCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMiCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMiCuenta.Image = Global.LyUserInterface.My.Resources.Resources.ajustes
        Me.BtnMiCuenta.Location = New System.Drawing.Point(3, 96)
        Me.BtnMiCuenta.Name = "BtnMiCuenta"
        Me.BtnMiCuenta.Size = New System.Drawing.Size(214, 122)
        Me.BtnMiCuenta.TabIndex = 0
        Me.BtnMiCuenta.Text = "Mi Cuenta"
        Me.BtnMiCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnMiCuenta.UseVisualStyleBackColor = True
        '
        'BtnMiServicios
        '
        Me.BtnMiServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMiServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMiServicios.Image = Global.LyUserInterface.My.Resources.Resources.servicios
        Me.BtnMiServicios.Location = New System.Drawing.Point(3, 224)
        Me.BtnMiServicios.Name = "BtnMiServicios"
        Me.BtnMiServicios.Size = New System.Drawing.Size(214, 124)
        Me.BtnMiServicios.TabIndex = 1
        Me.BtnMiServicios.Text = "Mis Servicios"
        Me.BtnMiServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnMiServicios.UseVisualStyleBackColor = True
        '
        'BtnMisAnuncios
        '
        Me.BtnMisAnuncios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMisAnuncios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMisAnuncios.Image = Global.LyUserInterface.My.Resources.Resources.publicaciones
        Me.BtnMisAnuncios.Location = New System.Drawing.Point(3, 354)
        Me.BtnMisAnuncios.Name = "BtnMisAnuncios"
        Me.BtnMisAnuncios.Size = New System.Drawing.Size(214, 116)
        Me.BtnMisAnuncios.TabIndex = 2
        Me.BtnMisAnuncios.Text = "Mis Anuncios"
        Me.BtnMisAnuncios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnMisAnuncios.UseVisualStyleBackColor = True
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
        Me.Panel3.Location = New System.Drawing.Point(0, 477)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(220, 21)
        Me.Panel3.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.BtnAddAnuncio)
        Me.Panel1.Controls.Add(Me.UcListaAnuncios)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 498)
        Me.Panel1.TabIndex = 1
        '
        'BtnAddAnuncio
        '
        Me.BtnAddAnuncio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddAnuncio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddAnuncio.Image = Global.LyUserInterface.My.Resources.Resources.add1
        Me.BtnAddAnuncio.Location = New System.Drawing.Point(383, 49)
        Me.BtnAddAnuncio.Name = "BtnAddAnuncio"
        Me.BtnAddAnuncio.Size = New System.Drawing.Size(179, 42)
        Me.BtnAddAnuncio.TabIndex = 7
        Me.BtnAddAnuncio.Text = "Publicar anuncio"
        Me.BtnAddAnuncio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddAnuncio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddAnuncio.UseVisualStyleBackColor = True
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
        Me.UcListaAnuncios.Size = New System.Drawing.Size(558, 379)
        Me.UcListaAnuncios.TabIndex = 3
        Me.UcListaAnuncios.TextoBotones = "MÁS DETALLES..."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Azure
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 477)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(564, 21)
        Me.Panel4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tablón de anuncios"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(784, 498)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 534)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banco del tiempo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMiCuenta As Button
    Friend WithEvents BtnMiServicios As Button
    Friend WithEvents BtnMisAnuncios As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PtcLogo As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UcListaAnuncios As UcListaAnuncios
    Friend WithEvents BtnAddAnuncio As Button
End Class
