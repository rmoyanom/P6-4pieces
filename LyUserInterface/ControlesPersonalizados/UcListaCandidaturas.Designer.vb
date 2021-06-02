<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcListaCandidaturas
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.PnDefault = New System.Windows.Forms.Panel()
        Me.LblDefaultTags = New System.Windows.Forms.Label()
        Me.pnDefaultLateral = New System.Windows.Forms.Panel()
        Me.btnDefaultCancelar = New System.Windows.Forms.Button()
        Me.lblDefaultTituloUpdate = New System.Windows.Forms.Label()
        Me.lblDefaultTitleStatus = New System.Windows.Forms.Label()
        Me.lblDefaultFecha = New System.Windows.Forms.Label()
        Me.lblDefaultStatus = New System.Windows.Forms.Label()
        Me.LblDdefaultDescripcion = New System.Windows.Forms.Label()
        Me.LbldefaultTitle = New System.Windows.Forms.Label()
        Me.PnPrincipal = New System.Windows.Forms.Panel()
        Me.LblNoData = New System.Windows.Forms.Label()
        Me.PnDefault.SuspendLayout()
        Me.pnDefaultLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnDefault
        '
        Me.PnDefault.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnDefault.BackColor = System.Drawing.Color.SteelBlue
        Me.PnDefault.Controls.Add(Me.LblDefaultTags)
        Me.PnDefault.Controls.Add(Me.pnDefaultLateral)
        Me.PnDefault.Controls.Add(Me.LblDdefaultDescripcion)
        Me.PnDefault.Controls.Add(Me.LbldefaultTitle)
        Me.PnDefault.Location = New System.Drawing.Point(5, 3)
        Me.PnDefault.Margin = New System.Windows.Forms.Padding(10)
        Me.PnDefault.Name = "PnDefault"
        Me.PnDefault.Size = New System.Drawing.Size(481, 164)
        Me.PnDefault.TabIndex = 0
        Me.PnDefault.Visible = False
        '
        'LblDefaultTags
        '
        Me.LblDefaultTags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDefaultTags.BackColor = System.Drawing.Color.Azure
        Me.LblDefaultTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDefaultTags.Location = New System.Drawing.Point(5, 143)
        Me.LblDefaultTags.Name = "LblDefaultTags"
        Me.LblDefaultTags.Size = New System.Drawing.Size(294, 16)
        Me.LblDefaultTags.TabIndex = 5
        Me.LblDefaultTags.Text = "Label1"
        '
        'pnDefaultLateral
        '
        Me.pnDefaultLateral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnDefaultLateral.BackColor = System.Drawing.Color.Azure
        Me.pnDefaultLateral.Controls.Add(Me.btnDefaultCancelar)
        Me.pnDefaultLateral.Controls.Add(Me.lblDefaultTituloUpdate)
        Me.pnDefaultLateral.Controls.Add(Me.lblDefaultTitleStatus)
        Me.pnDefaultLateral.Controls.Add(Me.lblDefaultFecha)
        Me.pnDefaultLateral.Controls.Add(Me.lblDefaultStatus)
        Me.pnDefaultLateral.Location = New System.Drawing.Point(302, 37)
        Me.pnDefaultLateral.Name = "pnDefaultLateral"
        Me.pnDefaultLateral.Size = New System.Drawing.Size(177, 122)
        Me.pnDefaultLateral.TabIndex = 4
        '
        'btnDefaultCancelar
        '
        Me.btnDefaultCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDefaultCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaultCancelar.Location = New System.Drawing.Point(1, 89)
        Me.btnDefaultCancelar.Name = "btnDefaultCancelar"
        Me.btnDefaultCancelar.Size = New System.Drawing.Size(174, 31)
        Me.btnDefaultCancelar.TabIndex = 3
        Me.btnDefaultCancelar.Text = "CANCELAR"
        Me.btnDefaultCancelar.UseVisualStyleBackColor = True
        '
        'lblDefaultTituloUpdate
        '
        Me.lblDefaultTituloUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDefaultTituloUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblDefaultTituloUpdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultTituloUpdate.Location = New System.Drawing.Point(2, 45)
        Me.lblDefaultTituloUpdate.Name = "lblDefaultTituloUpdate"
        Me.lblDefaultTituloUpdate.Size = New System.Drawing.Size(172, 15)
        Me.lblDefaultTituloUpdate.TabIndex = 2
        Me.lblDefaultTituloUpdate.Text = "ÚLTIMA ACTUALIZACIÓN:"
        '
        'lblDefaultTitleStatus
        '
        Me.lblDefaultTitleStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDefaultTitleStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblDefaultTitleStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultTitleStatus.Location = New System.Drawing.Point(3, 2)
        Me.lblDefaultTitleStatus.Name = "lblDefaultTitleStatus"
        Me.lblDefaultTitleStatus.Size = New System.Drawing.Size(172, 15)
        Me.lblDefaultTitleStatus.TabIndex = 2
        Me.lblDefaultTitleStatus.Text = "ESTADO:"
        '
        'lblDefaultFecha
        '
        Me.lblDefaultFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDefaultFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblDefaultFecha.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultFecha.Location = New System.Drawing.Point(2, 61)
        Me.lblDefaultFecha.Name = "lblDefaultFecha"
        Me.lblDefaultFecha.Size = New System.Drawing.Size(172, 15)
        Me.lblDefaultFecha.TabIndex = 2
        Me.lblDefaultFecha.Text = "10/08/2021"
        Me.lblDefaultFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDefaultStatus
        '
        Me.lblDefaultStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDefaultStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblDefaultStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultStatus.Location = New System.Drawing.Point(3, 18)
        Me.lblDefaultStatus.Name = "lblDefaultStatus"
        Me.lblDefaultStatus.Size = New System.Drawing.Size(172, 15)
        Me.lblDefaultStatus.TabIndex = 2
        Me.lblDefaultStatus.Text = "Pendiente"
        Me.lblDefaultStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDdefaultDescripcion
        '
        Me.LblDdefaultDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDdefaultDescripcion.BackColor = System.Drawing.Color.Azure
        Me.LblDdefaultDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDdefaultDescripcion.Location = New System.Drawing.Point(5, 37)
        Me.LblDdefaultDescripcion.Name = "LblDdefaultDescripcion"
        Me.LblDdefaultDescripcion.Size = New System.Drawing.Size(294, 104)
        Me.LblDdefaultDescripcion.TabIndex = 1
        Me.LblDdefaultDescripcion.Text = "Label1"
        '
        'LbldefaultTitle
        '
        Me.LbldefaultTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbldefaultTitle.Location = New System.Drawing.Point(3, 5)
        Me.LbldefaultTitle.Name = "LbldefaultTitle"
        Me.LbldefaultTitle.Size = New System.Drawing.Size(461, 32)
        Me.LbldefaultTitle.TabIndex = 0
        Me.LbldefaultTitle.Text = "TITULO DEL ANUNCIO"
        '
        'PnPrincipal
        '
        Me.PnPrincipal.AutoScroll = True
        Me.PnPrincipal.BackColor = System.Drawing.Color.FloralWhite
        Me.PnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PnPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.PnPrincipal.Name = "PnPrincipal"
        Me.PnPrincipal.Size = New System.Drawing.Size(496, 376)
        Me.PnPrincipal.TabIndex = 1
        Me.PnPrincipal.Visible = False
        '
        'LblNoData
        '
        Me.LblNoData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNoData.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoData.Location = New System.Drawing.Point(3, 9)
        Me.LblNoData.Name = "LblNoData"
        Me.LblNoData.Size = New System.Drawing.Size(493, 31)
        Me.LblNoData.TabIndex = 2
        Me.LblNoData.Text = "No hay candidaturas que mostrar"
        Me.LblNoData.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UcListaCandidaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.Controls.Add(Me.PnDefault)
        Me.Controls.Add(Me.PnPrincipal)
        Me.Controls.Add(Me.LblNoData)
        Me.Name = "UcListaCandidaturas"
        Me.Size = New System.Drawing.Size(496, 376)
        Me.PnDefault.ResumeLayout(False)
        Me.pnDefaultLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnDefault As Panel
    Friend WithEvents LblDdefaultDescripcion As Label
    Friend WithEvents LbldefaultTitle As Label
    Friend WithEvents lblDefaultStatus As Label
    Friend WithEvents lblDefaultTituloUpdate As Label
    Friend WithEvents lblDefaultTitleStatus As Label
    Friend WithEvents lblDefaultFecha As Label
    Friend WithEvents btnDefaultCancelar As Button
    Friend WithEvents PnPrincipal As Panel
    Friend WithEvents pnDefaultLateral As Panel
    Friend WithEvents LblDefaultTags As Label
    Friend WithEvents LblNoData As Label
End Class
