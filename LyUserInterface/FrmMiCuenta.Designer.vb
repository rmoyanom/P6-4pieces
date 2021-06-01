<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMiCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMiCuenta))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnMiCuenta = New System.Windows.Forms.Button()
        Me.BtnMiCartera = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PtcLogo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelContenidos = New System.Windows.Forms.Panel()
        Me.PanelErrores = New System.Windows.Forms.Panel()
        Me.LblError = New System.Windows.Forms.Label()
        Me.LblTitleMiPerfil = New System.Windows.Forms.Label()
        Me.PnlMiCartera = New System.Windows.Forms.Panel()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.LblTitleSaldo = New System.Windows.Forms.Label()
        Me.LblTitleCartera = New System.Windows.Forms.Label()
        Me.PnlCategorias = New System.Windows.Forms.Panel()
        Me.BtnSaveCategorias = New System.Windows.Forms.Button()
        Me.LblTitleCategoriasList = New System.Windows.Forms.Label()
        Me.CblCategorias = New System.Windows.Forms.CheckedListBox()
        Me.PnlMisDatos = New System.Windows.Forms.Panel()
        Me.BtnCancelEdit = New System.Windows.Forms.Button()
        Me.BtnCategorias = New System.Windows.Forms.Button()
        Me.LBoxCategorias = New System.Windows.Forms.ListBox()
        Me.LblTitleCategorias = New System.Windows.Forms.Label()
        Me.BtnSaveChanges = New System.Windows.Forms.Button()
        Me.BtnEditarUser = New System.Windows.Forms.Button()
        Me.TxtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.LblPasswordConfirm = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblTitleUser = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenidos.SuspendLayout()
        Me.PanelErrores.SuspendLayout()
        Me.PnlMiCartera.SuspendLayout()
        Me.PnlCategorias.SuspendLayout()
        Me.PnlMisDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnVolver, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnMiCuenta, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnMiCartera, 0, 2)
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
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnVolver
        '
        Me.BtnVolver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Image = Global.LyUserInterface.My.Resources.Resources.back
        Me.BtnVolver.Location = New System.Drawing.Point(3, 354)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(214, 116)
        Me.BtnVolver.TabIndex = 8
        Me.BtnVolver.Text = "VOLVER"
        Me.BtnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnVolver.UseVisualStyleBackColor = True
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
        Me.BtnMiCuenta.Text = "Mis Datos"
        Me.BtnMiCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnMiCuenta.UseVisualStyleBackColor = True
        '
        'BtnMiCartera
        '
        Me.BtnMiCartera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMiCartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMiCartera.Image = Global.LyUserInterface.My.Resources.Resources.servicios
        Me.BtnMiCartera.Location = New System.Drawing.Point(3, 224)
        Me.BtnMiCartera.Name = "BtnMiCartera"
        Me.BtnMiCartera.Size = New System.Drawing.Size(214, 124)
        Me.BtnMiCartera.TabIndex = 1
        Me.BtnMiCartera.Text = "Mi Cartera"
        Me.BtnMiCartera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnMiCartera.UseVisualStyleBackColor = True
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
        Me.Panel3.Location = New System.Drawing.Point(0, 474)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(220, 21)
        Me.Panel3.TabIndex = 6
        '
        'PanelContenidos
        '
        Me.PanelContenidos.BackColor = System.Drawing.Color.Azure
        Me.PanelContenidos.Controls.Add(Me.PanelErrores)
        Me.PanelContenidos.Controls.Add(Me.LblTitleMiPerfil)
        Me.PanelContenidos.Controls.Add(Me.PnlMiCartera)
        Me.PanelContenidos.Controls.Add(Me.PnlCategorias)
        Me.PanelContenidos.Controls.Add(Me.PnlMisDatos)
        Me.PanelContenidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenidos.Location = New System.Drawing.Point(220, 0)
        Me.PanelContenidos.Name = "PanelContenidos"
        Me.PanelContenidos.Size = New System.Drawing.Size(597, 495)
        Me.PanelContenidos.TabIndex = 1
        '
        'PanelErrores
        '
        Me.PanelErrores.BackColor = System.Drawing.Color.Azure
        Me.PanelErrores.Controls.Add(Me.LblError)
        Me.PanelErrores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelErrores.Location = New System.Drawing.Point(0, 474)
        Me.PanelErrores.Name = "PanelErrores"
        Me.PanelErrores.Size = New System.Drawing.Size(597, 21)
        Me.PanelErrores.TabIndex = 2
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.BackColor = System.Drawing.Color.Transparent
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(19, 1)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(0, 17)
        Me.LblError.TabIndex = 24
        '
        'LblTitleMiPerfil
        '
        Me.LblTitleMiPerfil.AutoSize = True
        Me.LblTitleMiPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleMiPerfil.Location = New System.Drawing.Point(6, 9)
        Me.LblTitleMiPerfil.Name = "LblTitleMiPerfil"
        Me.LblTitleMiPerfil.Size = New System.Drawing.Size(199, 55)
        Me.LblTitleMiPerfil.TabIndex = 0
        Me.LblTitleMiPerfil.Text = "Mi perfil"
        '
        'PnlMiCartera
        '
        Me.PnlMiCartera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMiCartera.Controls.Add(Me.LblSaldo)
        Me.PnlMiCartera.Controls.Add(Me.LblTitleSaldo)
        Me.PnlMiCartera.Controls.Add(Me.LblTitleCartera)
        Me.PnlMiCartera.Location = New System.Drawing.Point(0, 94)
        Me.PnlMiCartera.Name = "PnlMiCartera"
        Me.PnlMiCartera.Size = New System.Drawing.Size(597, 378)
        Me.PnlMiCartera.TabIndex = 30
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.BackColor = System.Drawing.Color.White
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaldo.Location = New System.Drawing.Point(144, 64)
        Me.LblSaldo.MinimumSize = New System.Drawing.Size(150, 26)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(150, 31)
        Me.LblSaldo.TabIndex = 2
        Me.LblSaldo.Text = "0 h"
        Me.LblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTitleSaldo
        '
        Me.LblTitleSaldo.AutoSize = True
        Me.LblTitleSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleSaldo.Location = New System.Drawing.Point(16, 68)
        Me.LblTitleSaldo.Name = "LblTitleSaldo"
        Me.LblTitleSaldo.Size = New System.Drawing.Size(122, 24)
        Me.LblTitleSaldo.TabIndex = 1
        Me.LblTitleSaldo.Text = "Saldo actual: "
        '
        'LblTitleCartera
        '
        Me.LblTitleCartera.AutoSize = True
        Me.LblTitleCartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleCartera.Location = New System.Drawing.Point(11, 12)
        Me.LblTitleCartera.Name = "LblTitleCartera"
        Me.LblTitleCartera.Size = New System.Drawing.Size(123, 26)
        Me.LblTitleCartera.TabIndex = 0
        Me.LblTitleCartera.Text = "Mi Cartera"
        '
        'PnlCategorias
        '
        Me.PnlCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCategorias.Controls.Add(Me.BtnSaveCategorias)
        Me.PnlCategorias.Controls.Add(Me.LblTitleCategoriasList)
        Me.PnlCategorias.Controls.Add(Me.CblCategorias)
        Me.PnlCategorias.Location = New System.Drawing.Point(0, 96)
        Me.PnlCategorias.Name = "PnlCategorias"
        Me.PnlCategorias.Size = New System.Drawing.Size(597, 378)
        Me.PnlCategorias.TabIndex = 26
        Me.PnlCategorias.Visible = False
        '
        'BtnSaveCategorias
        '
        Me.BtnSaveCategorias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveCategorias.Location = New System.Drawing.Point(252, 10)
        Me.BtnSaveCategorias.Name = "BtnSaveCategorias"
        Me.BtnSaveCategorias.Size = New System.Drawing.Size(333, 34)
        Me.BtnSaveCategorias.TabIndex = 29
        Me.BtnSaveCategorias.Text = "ACTUALIZAR CATEGORIAS"
        Me.BtnSaveCategorias.UseVisualStyleBackColor = True
        '
        'LblTitleCategoriasList
        '
        Me.LblTitleCategoriasList.AutoSize = True
        Me.LblTitleCategoriasList.BackColor = System.Drawing.Color.Azure
        Me.LblTitleCategoriasList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleCategoriasList.Location = New System.Drawing.Point(13, 13)
        Me.LblTitleCategoriasList.Name = "LblTitleCategoriasList"
        Me.LblTitleCategoriasList.Size = New System.Drawing.Size(211, 24)
        Me.LblTitleCategoriasList.TabIndex = 28
        Me.LblTitleCategoriasList.Text = "Listado de Categorías"
        '
        'CblCategorias
        '
        Me.CblCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CblCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CblCategorias.FormattingEnabled = True
        Me.CblCategorias.Location = New System.Drawing.Point(16, 55)
        Me.CblCategorias.Margin = New System.Windows.Forms.Padding(5)
        Me.CblCategorias.MultiColumn = True
        Me.CblCategorias.Name = "CblCategorias"
        Me.CblCategorias.Size = New System.Drawing.Size(569, 308)
        Me.CblCategorias.Sorted = True
        Me.CblCategorias.TabIndex = 27
        '
        'PnlMisDatos
        '
        Me.PnlMisDatos.Controls.Add(Me.BtnCancelEdit)
        Me.PnlMisDatos.Controls.Add(Me.BtnCategorias)
        Me.PnlMisDatos.Controls.Add(Me.LBoxCategorias)
        Me.PnlMisDatos.Controls.Add(Me.LblTitleCategorias)
        Me.PnlMisDatos.Controls.Add(Me.BtnSaveChanges)
        Me.PnlMisDatos.Controls.Add(Me.BtnEditarUser)
        Me.PnlMisDatos.Controls.Add(Me.TxtPasswordConfirm)
        Me.PnlMisDatos.Controls.Add(Me.LblPasswordConfirm)
        Me.PnlMisDatos.Controls.Add(Me.TxtPassword)
        Me.PnlMisDatos.Controls.Add(Me.LblPassword)
        Me.PnlMisDatos.Controls.Add(Me.TxtUsuario)
        Me.PnlMisDatos.Controls.Add(Me.LblUsuario)
        Me.PnlMisDatos.Controls.Add(Me.LblTitleUser)
        Me.PnlMisDatos.Controls.Add(Me.TxtEmail)
        Me.PnlMisDatos.Controls.Add(Me.LblEmail)
        Me.PnlMisDatos.Controls.Add(Me.TxtTelefono)
        Me.PnlMisDatos.Controls.Add(Me.LblTelefono)
        Me.PnlMisDatos.Controls.Add(Me.TxtApellidos)
        Me.PnlMisDatos.Controls.Add(Me.LblApellidos)
        Me.PnlMisDatos.Controls.Add(Me.TxtNombre)
        Me.PnlMisDatos.Controls.Add(Me.LblNombre)
        Me.PnlMisDatos.Location = New System.Drawing.Point(0, 96)
        Me.PnlMisDatos.Name = "PnlMisDatos"
        Me.PnlMisDatos.Size = New System.Drawing.Size(595, 378)
        Me.PnlMisDatos.TabIndex = 30
        '
        'BtnCancelEdit
        '
        Me.BtnCancelEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancelEdit.FlatAppearance.BorderSize = 0
        Me.BtnCancelEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelEdit.Location = New System.Drawing.Point(386, 229)
        Me.BtnCancelEdit.Name = "BtnCancelEdit"
        Me.BtnCancelEdit.Size = New System.Drawing.Size(165, 38)
        Me.BtnCancelEdit.TabIndex = 25
        Me.BtnCancelEdit.Text = "CANCELAR"
        Me.BtnCancelEdit.UseVisualStyleBackColor = False
        Me.BtnCancelEdit.Visible = False
        '
        'BtnCategorias
        '
        Me.BtnCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCategorias.Location = New System.Drawing.Point(26, 326)
        Me.BtnCategorias.Name = "BtnCategorias"
        Me.BtnCategorias.Size = New System.Drawing.Size(165, 38)
        Me.BtnCategorias.TabIndex = 23
        Me.BtnCategorias.Text = "EDITAR LISTA"
        Me.BtnCategorias.UseVisualStyleBackColor = True
        '
        'LBoxCategorias
        '
        Me.LBoxCategorias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBoxCategorias.Enabled = False
        Me.LBoxCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBoxCategorias.FormattingEnabled = True
        Me.LBoxCategorias.ItemHeight = 18
        Me.LBoxCategorias.Location = New System.Drawing.Point(207, 289)
        Me.LBoxCategorias.Name = "LBoxCategorias"
        Me.LBoxCategorias.Size = New System.Drawing.Size(233, 76)
        Me.LBoxCategorias.TabIndex = 22
        '
        'LblTitleCategorias
        '
        Me.LblTitleCategorias.AutoSize = True
        Me.LblTitleCategorias.BackColor = System.Drawing.Color.Azure
        Me.LblTitleCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleCategorias.Location = New System.Drawing.Point(25, 289)
        Me.LblTitleCategorias.Name = "LblTitleCategorias"
        Me.LblTitleCategorias.Size = New System.Drawing.Size(134, 26)
        Me.LblTitleCategorias.TabIndex = 21
        Me.LblTitleCategorias.Text = "Categorias:"
        '
        'BtnSaveChanges
        '
        Me.BtnSaveChanges.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnSaveChanges.FlatAppearance.BorderSize = 0
        Me.BtnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveChanges.Location = New System.Drawing.Point(207, 229)
        Me.BtnSaveChanges.Name = "BtnSaveChanges"
        Me.BtnSaveChanges.Size = New System.Drawing.Size(165, 38)
        Me.BtnSaveChanges.TabIndex = 20
        Me.BtnSaveChanges.Text = "GUARDAR DATOS"
        Me.BtnSaveChanges.UseVisualStyleBackColor = False
        Me.BtnSaveChanges.Visible = False
        '
        'BtnEditarUser
        '
        Me.BtnEditarUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarUser.Location = New System.Drawing.Point(26, 229)
        Me.BtnEditarUser.Name = "BtnEditarUser"
        Me.BtnEditarUser.Size = New System.Drawing.Size(165, 38)
        Me.BtnEditarUser.TabIndex = 19
        Me.BtnEditarUser.Text = "EDITAR USUARIO"
        Me.BtnEditarUser.UseVisualStyleBackColor = True
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(386, 183)
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordConfirm.ReadOnly = True
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(169, 27)
        Me.TxtPasswordConfirm.TabIndex = 18
        '
        'LblPasswordConfirm
        '
        Me.LblPasswordConfirm.AutoSize = True
        Me.LblPasswordConfirm.BackColor = System.Drawing.Color.Azure
        Me.LblPasswordConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LblPasswordConfirm.Location = New System.Drawing.Point(189, 186)
        Me.LblPasswordConfirm.Name = "LblPasswordConfirm"
        Me.LblPasswordConfirm.Size = New System.Drawing.Size(191, 22)
        Me.LblPasswordConfirm.TabIndex = 17
        Me.LblPasswordConfirm.Text = "Confirmar Contraseña:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(386, 145)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.ReadOnly = True
        Me.TxtPassword.Size = New System.Drawing.Size(169, 27)
        Me.TxtPassword.TabIndex = 16
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Azure
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LblPassword.Location = New System.Drawing.Point(272, 146)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(108, 22)
        Me.LblPassword.TabIndex = 15
        Me.LblPassword.Text = "Contraseña:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(102, 143)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.ReadOnly = True
        Me.TxtUsuario.Size = New System.Drawing.Size(160, 27)
        Me.TxtUsuario.TabIndex = 14
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Azure
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LblUsuario.Location = New System.Drawing.Point(18, 145)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(77, 22)
        Me.LblUsuario.TabIndex = 13
        Me.LblUsuario.Text = "Usuario:"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTitleUser
        '
        Me.LblTitleUser.AutoSize = True
        Me.LblTitleUser.BackColor = System.Drawing.Color.Azure
        Me.LblTitleUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleUser.Location = New System.Drawing.Point(25, 103)
        Me.LblTitleUser.Name = "LblTitleUser"
        Me.LblTitleUser.Size = New System.Drawing.Size(199, 26)
        Me.LblTitleUser.TabIndex = 12
        Me.LblTitleUser.Text = "Datos de usuario:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(366, 54)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(200, 27)
        Me.TxtEmail.TabIndex = 11
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Azure
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LblEmail.Location = New System.Drawing.Point(295, 54)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(65, 22)
        Me.LblEmail.TabIndex = 10
        Me.LblEmail.Text = "E-Mail:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(102, 52)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.ReadOnly = True
        Me.TxtTelefono.Size = New System.Drawing.Size(160, 27)
        Me.TxtTelefono.TabIndex = 9
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Azure
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LblTelefono.Location = New System.Drawing.Point(10, 55)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(86, 22)
        Me.LblTelefono.TabIndex = 8
        Me.LblTelefono.Text = "Teléfono:"
        Me.LblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidos.Location = New System.Drawing.Point(366, 14)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.ReadOnly = True
        Me.TxtApellidos.Size = New System.Drawing.Size(200, 27)
        Me.TxtApellidos.TabIndex = 7
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.BackColor = System.Drawing.Color.Azure
        Me.LblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LblApellidos.Location = New System.Drawing.Point(272, 15)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(88, 22)
        Me.LblApellidos.TabIndex = 6
        Me.LblApellidos.Text = "Apellidos:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(102, 12)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(160, 27)
        Me.TxtNombre.TabIndex = 5
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Azure
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.LblNombre.Location = New System.Drawing.Point(18, 14)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(78, 22)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Nombre:"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmMiCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(817, 495)
        Me.Controls.Add(Me.PanelContenidos)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 534)
        Me.Name = "FrmMiCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Perfil"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PtcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenidos.ResumeLayout(False)
        Me.PanelContenidos.PerformLayout()
        Me.PanelErrores.ResumeLayout(False)
        Me.PanelErrores.PerformLayout()
        Me.PnlMiCartera.ResumeLayout(False)
        Me.PnlMiCartera.PerformLayout()
        Me.PnlCategorias.ResumeLayout(False)
        Me.PnlCategorias.PerformLayout()
        Me.PnlMisDatos.ResumeLayout(False)
        Me.PnlMisDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelContenidos As Panel
    Friend WithEvents BtnMiCuenta As Button
    Friend WithEvents BtnMiCartera As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblTitleMiPerfil As Label
    Friend WithEvents PtcLogo As PictureBox
    Friend WithEvents PanelErrores As Panel
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents LblApellidos As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblTitleUser As Label
    Friend WithEvents TxtPasswordConfirm As TextBox
    Friend WithEvents LblPasswordConfirm As Label
    Friend WithEvents BtnCategorias As Button
    Friend WithEvents LBoxCategorias As ListBox
    Friend WithEvents LblTitleCategorias As Label
    Friend WithEvents BtnSaveChanges As Button
    Friend WithEvents BtnEditarUser As Button
    Friend WithEvents LblError As Label
    Friend WithEvents BtnCancelEdit As Button
    Friend WithEvents LblTitleCategoriasList As Label
    Friend WithEvents CblCategorias As CheckedListBox
    Friend WithEvents BtnSaveCategorias As Button
    Friend WithEvents PnlMisDatos As Panel
    Friend WithEvents PnlCategorias As Panel
    Friend WithEvents PnlMiCartera As Panel
    Friend WithEvents LblTitleCartera As Label
    Friend WithEvents LblSaldo As Label
    Friend WithEvents LblTitleSaldo As Label
    Friend WithEvents BtnVolver As Button
End Class
