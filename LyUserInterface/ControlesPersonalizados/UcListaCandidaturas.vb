Imports System.ComponentModel
Imports LyBussinesModel
Imports LyDataAcces.DAO

Public Class UcListaCandidaturas
    Private Const MARGEN = 5
    Private _TextoBotones As String

    Private _ListaPaneles As New List(Of Panel)

    <Browsable(True)>
    Public Property TextoBotones As String
        Get
            Return _TextoBotones
        End Get
        Set(value As String)
            _TextoBotones = value
        End Set
    End Property

    Public Delegate Sub enviarId(id As Integer)
    Public Event OnClickButton As enviarId
    Public Sub ConstruirDatos(items As List(Of Candidatura))
        Dim count As Integer = 0
        PnPrincipal.Controls.Clear()

        If items IsNot Nothing AndAlso items.Count > 0 Then
            PnPrincipal.Visible = True
            For Each elemento As Candidatura In items
                Dim nuevoPanel As New Panel
                Dim posicion As Point = PnDefault.Location
                Dim size As Point = PnDefault.Size
                Dim anchor As AnchorStyles = PnDefault.Anchor
                Dim titulo As New Label
                Dim descripcion As New Label
                Dim tituloCreador As New Label
                Dim tituloFecha As New Label
                Dim creador As New Label
                Dim fecha As New Label
                Dim pnLateral As New Panel
                Dim bntCancelar As New Button
                Dim tags As New Label


                posicion.Y += count * PnDefault.Size.Height
                posicion.Y += MARGEN * count

                With nuevoPanel
                    .Name = "Pn" + count.ToString
                    .Location = posicion
                    .Size = size
                    .BackColor = PnDefault.BackColor
                End With

                With pnLateral
                    .Name = "PnL" + count.ToString
                    .Location = pnDefaultLateral.Location
                    .Size = pnDefaultLateral.Size
                    .Anchor = pnDefaultLateral.Anchor
                    .BackColor = pnDefaultLateral.BackColor
                End With
                Dim visibleBtn = True
                If (elemento.Estado = EstadoCandidatura.FINALIZADA Or elemento.Estado = EstadoCandidatura.CANCELADA) Then
                    visibleBtn = False
                End If

                With bntCancelar
                    .Name = "btn" + count.ToString
                    .Location = btnDefaultCancelar.Location
                    .Size = btnDefaultCancelar.Size
                    .Anchor = btnDefaultCancelar.Anchor
                    .Tag = elemento.Id
                    .Font = btnDefaultCancelar.Font
                    .Text = "CANCELAR"
                    .BackColor = btnDefaultCancelar.BackColor
                    .FlatStyle = btnDefaultCancelar.FlatStyle
                    .Visible = visibleBtn
                End With




                ClonarLabel("LblTitle" + count.ToString,
                            titulo,
                            LbldefaultTitle, elemento.Servicio.Titulo)

                ClonarLabel("lblDescripcion" + count.ToString,
                            descripcion,
                            LblDdefaultDescripcion, elemento.Servicio.Descripcion)

                ClonarLabel("lblDefaultTitleStatus" + count.ToString,
                            tituloCreador,
                            lblDefaultTitleStatus, "ESTADO:")

                ClonarLabel("lblDefaultStatus" + count.ToString,
                            creador,
                            lblDefaultStatus, elemento.Estado.ToString)

                ClonarLabel("lblDefaultTituloUpdate" + count.ToString,
                            tituloFecha,
                            lblDefaultTituloUpdate, "ÚLTIMA ACTUALIZACIÓN:")
                Dim fechatexto As String = elemento.FechaInscripcion.ToString
                If (elemento.Estado = EstadoCandidatura.ACEPTADA) Then
                    fechatexto = elemento.FechaAceptacion.ToString
                ElseIf (elemento.Estado = EstadoCandidatura.CANCELADA) Then
                    fechatexto = elemento.FechaDeCancelacion.ToString
                ElseIf (elemento.Estado = EstadoCandidatura.FINALIZADA) Then
                    fechatexto = elemento.FechaAcordadaServicio.ToString
                End If
                ClonarLabel("lblDefaultFecha" + count.ToString,
                            fecha, lblDefaultFecha,
                            fechatexto)


                pnLateral.Controls.Add(tituloCreador)
                pnLateral.Controls.Add(creador)

                pnLateral.Controls.Add(tituloFecha)
                pnLateral.Controls.Add(fecha)
                pnLateral.Controls.Add(bntCancelar)

                nuevoPanel.Controls.Add(pnLateral)

                nuevoPanel.Controls.Add(titulo)
                nuevoPanel.Controls.Add(descripcion)

                PnPrincipal.Controls.Add(nuevoPanel)

                AddHandler bntCancelar.Click, AddressOf btnDefaultCancelar_Click
                count += 1
            Next

            For Each elemento As Control In PnPrincipal.Controls
                If elemento.Name.Substring(0, 2) = "Pn" Then
                    DirectCast(elemento, Panel).Anchor = PnDefault.Anchor
                End If

            Next
        Else
            PnPrincipal.Visible = False
        End If
    End Sub



    Private Sub ClonarLabel(titulo As String,
                            labelDestino As Label,
                            labelOrigen As Label,
                            texto As String)
        With labelDestino
            .Name = titulo
            .Location = labelOrigen.Location
            .Size = labelOrigen.Size
            .Anchor = labelOrigen.Anchor
            .BackColor = labelOrigen.BackColor
            .BorderStyle = labelOrigen.BorderStyle
            .Font = labelOrigen.Font
            .Text = texto
            .TextAlign = labelOrigen.TextAlign
        End With
    End Sub


    Private Sub btnDefaultCancelar_Click(sender As Object, e As EventArgs)
        Dim dao As New DaoCandidatura
        dao.CancelarCandidatura(DirectCast(sender, Button).Tag, CanceladoPor.CANDIDATO, "cambio de idea")
        lblDefaultTitleStatus.Text = EstadoCandidatura.CANCELADA
        DirectCast(sender, Button).Enabled = False
        DirectCast(sender, Button).Visible = False
        RaiseEvent OnClickButton(DirectCast(sender, Button).Tag)
    End Sub

End Class
