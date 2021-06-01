<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMisServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMisServicios))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnActivos = New System.Windows.Forms.Button()
        Me.BtnFinalizados = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PtcLogo = New System.Windows.Forms.PictureBox()
        Me.PnlContenido = New System.Windows.Forms.Panel()
        Me.UcListaServicios = New LyUserInterface.UcListaAnuncios()
        Me.PnlError = New System.Windows.Forms.Panel()
        Me.LblTitleServicios = New System.Windows.Forms.Label()
        Me.LblCurrentMenu = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlContenido.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Azure
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 474)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(220, 21)
        Me.Panel3.TabIndex = 6
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(220, 495)
        Me.TableLayoutPanel1.TabIndex = 4
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
        'PnlContenido
        '
        Me.PnlContenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlContenido.BackColor = System.Drawing.Color.LightGray
        Me.PnlContenido.Controls.Add(Me.LblCurrentMenu)
        Me.PnlContenido.Controls.Add(Me.UcListaServicios)
        Me.PnlContenido.Controls.Add(Me.PnlError)
        Me.PnlContenido.Controls.Add(Me.LblTitleServicios)
        Me.PnlContenido.Location = New System.Drawing.Point(220, 0)
        Me.PnlContenido.Name = "PnlContenido"
        Me.PnlContenido.Size = New System.Drawing.Size(528, 495)
        Me.PnlContenido.TabIndex = 5
        '
        'UcListaServicios
        '
        Me.UcListaServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcListaServicios.AutoScroll = True
        Me.UcListaServicios.BackColor = System.Drawing.Color.Azure
        Me.UcListaServicios.Location = New System.Drawing.Point(1, 92)
        Me.UcListaServicios.Name = "UcListaServicios"
        Me.UcListaServicios.Size = New System.Drawing.Size(527, 382)
        Me.UcListaServicios.TabIndex = 4
        Me.UcListaServicios.TextoBotones = "Gestionar"
        '
        'PnlError
        '
        Me.PnlError.BackColor = System.Drawing.Color.Azure
        Me.PnlError.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlError.Location = New System.Drawing.Point(0, 474)
        Me.PnlError.Name = "PnlError"
        Me.PnlError.Size = New System.Drawing.Size(528, 21)
        Me.PnlError.TabIndex = 2
        '
        'LblTitleServicios
        '
        Me.LblTitleServicios.AutoSize = True
        Me.LblTitleServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleServicios.Location = New System.Drawing.Point(4, 3)
        Me.LblTitleServicios.Name = "LblTitleServicios"
        Me.LblTitleServicios.Size = New System.Drawing.Size(237, 39)
        Me.LblTitleServicios.TabIndex = 0
        Me.LblTitleServicios.Text = "Mis Servicios"
        '
        'LblCurrentMenu
        '
        Me.LblCurrentMenu.AutoSize = True
        Me.LblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentMenu.Location = New System.Drawing.Point(426, 60)
        Me.LblCurrentMenu.Name = "LblCurrentMenu"
        Me.LblCurrentMenu.Size = New System.Drawing.Size(89, 29)
        Me.LblCurrentMenu.TabIndex = 5
        Me.LblCurrentMenu.Text = "Activos"
        Me.LblCurrentMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmMisServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 495)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PnlContenido)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMisServicios"
        Me.Text = "FormMisServicios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlContenido.ResumeLayout(False)
        Me.PnlContenido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnActivos As Button
    Friend WithEvents BtnFinalizados As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PtcLogo As PictureBox
    Friend WithEvents PnlContenido As Panel
    Friend WithEvents UcListaServicios As UcListaAnuncios
    Friend WithEvents PnlError As Panel
    Friend WithEvents LblTitleServicios As Label
    Friend WithEvents LblCurrentMenu As Label
End Class
