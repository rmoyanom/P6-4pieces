Imports LyBussinesModel.DTO

Public Class FrmVisualizarAnuncio
    Private _Servicio As LyBussinesModel.DTO.DTOServiciosDetalles


    Public Sub CargarAnuncio(idServicio As Integer)
        Dim Dao As New LyDataAcces.DAO.DaoServicios

        _Servicio = Dao.GetServiciosDetalles(idServicio)
        If _Servicio IsNot Nothing Then
            LblUsuario.Text = _Servicio.Creador.NombreUsuario
            LblTitulo.Text = _Servicio.Titulo
            LblDescripcion.Text = _Servicio.Descripcion
            LblCantidadSolicitudes.Text = _Servicio.CantidadSolicitudes.ToString
            LblFechaCreacion.Text = _Servicio.FechaDeInicio.ToString
            LblHorasUser.Text = _Servicio.Creador.HorasAcumuladas
            If _Servicio.Puntuacion > 0 Then
                LblPuntuacion.Text = _Servicio.Puntuacion.ToString
            Else
                LblPuntuacion.Text = "N/a"
            End If

            LblTags.Text = ""
            If _Servicio.Categorias.Count > 0 Then
                For Each categoria As DTOCategoria In _Servicio.Categorias
                    LblTags.Text += "    #" + categoria.nombre
                Next
            End If
        Else
            Me.Close()
        End If
    End Sub

End Class