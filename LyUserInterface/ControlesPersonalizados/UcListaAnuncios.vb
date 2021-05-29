Imports System.ComponentModel
Public Class UcListaAnuncios
    Private Const MARGEN = 5
    Private _ListaPaneles As New List(Of Panel)
    Public Delegate Sub enviarId(id As Integer)
    Public Event OnClickButton As enviarId
    Public Sub ConstruirDatos(items As List(Of LyBussinesModel.Servicio))
        Dim count As Integer = 0
        PnPrincipal.Controls.Clear()



        If Not items Is Nothing Then
            For Each elemento As LyBussinesModel.Servicio In items
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
                Dim bntVisualizar As New Button

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

                With bntVisualizar
                    .Name = "btn" + count.ToString
                    .Location = btnDefaultVisualizar.Location
                    .Size = btnDefaultVisualizar.Size
                    .Anchor = btnDefaultVisualizar.Anchor
                    .Tag = elemento.Id
                    .Font = btnDefaultVisualizar.Font
                    .Text = btnDefaultVisualizar.Text
                    .BackColor = btnDefaultVisualizar.BackColor
                    .FlatStyle = btnDefaultVisualizar.FlatStyle
                End With

                ClonarLabel("LblTitle" + count.ToString,
                            titulo,
                            LbldefaultTitle, elemento.Titulo)

                ClonarLabel("lblDescripcion" + count.ToString,
                            descripcion,
                            LblDdefaultDescripcion, elemento.Descripcion)

                ClonarLabel("lblTituloCreado" + count.ToString,
                            tituloCreador,
                            lblDefaultTitleCreador, "CREADOR:")

                ClonarLabel("lblCreado" + count.ToString,
                            creador,
                            lblDefaultNombre, elemento.Creador.Nombre)

                ClonarLabel("lblTituloFecha" + count.ToString,
                            tituloFecha,
                            lblDefaultTituloPublico, "FECHA:")

                ClonarLabel("lblFecha" + count.ToString,
                            fecha, lblDefaultFecha,
                            elemento.FechaDeInicio.ToString)


                pnLateral.Controls.Add(tituloCreador)
                pnLateral.Controls.Add(creador)

                pnLateral.Controls.Add(tituloFecha)
                pnLateral.Controls.Add(fecha)
                pnLateral.Controls.Add(bntVisualizar)

                nuevoPanel.Controls.Add(pnLateral)

                nuevoPanel.Controls.Add(titulo)
                nuevoPanel.Controls.Add(descripcion)


                PnPrincipal.Controls.Add(nuevoPanel)

                AddHandler bntVisualizar.Click, AddressOf BtnDefaultVisualizar_Click
                count += 1
            Next

            For Each elemento As Control In PnPrincipal.Controls
                If elemento.Name.Substring(0, 2) = "Pn" Then
                    DirectCast(elemento, Panel).Anchor = PnDefault.Anchor
                End If

            Next
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


    Private Sub BtnDefaultVisualizar_Click(sender As Object, e As EventArgs)
        RaiseEvent OnClickButton(DirectCast(sender, Button).Tag)
    End Sub


End Class
