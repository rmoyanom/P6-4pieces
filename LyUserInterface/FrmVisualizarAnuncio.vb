﻿Imports System.ComponentModel
Imports LyBussinesModel.DTO

''' <summary>
''' formulario para visualizar un anuncios y sus detalles
''' </summary>
Public Class FrmVisualizarAnuncio
    Public LanzarEdicionAnuncio As Boolean = False

    Private _Servicio As LyBussinesModel.DTO.DTOServiciosDetalles


    Public Sub CargarAnuncio(idServicio As Integer)
        Dim Dao As New LyDataAcces.DAO.DaoServicios
        LanzarEdicionAnuncio = False
        _Servicio = Dao.GetServiciosDetalles(idServicio, Main.UsuarioAutenticado.Id)
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

                LblTags.Text = String.Join("   ", _Servicio.Categorias.Select(Function(x) "#" + x.nombre))
            End If

            'Si este anuncio lo ha creado el usuario
            If _Servicio.Creador.id = UsuarioAutenticado.Id Then
                BtnCrearSolicitud.Text = "Gestionar mi anuncio"
                BtnCrearSolicitud.Enabled = True
            Else
                ActualizarEstadoPuedeSolicitar(_Servicio.SePuedeSolicitar)
            End If

        Else
            Me.DialogResult = DialogResult.None
            Me.Close()
        End If
    End Sub


    Private Sub BtnCrearSolicitud_Click(sender As Object, e As EventArgs) Handles BtnCrearSolicitud.Click
        If _Servicio.Creador.id = UsuarioAutenticado.Id Then
            'LANZAR ACCION PARA IR A GESTION DE ANUNCIOS+
            Main.AuxiliarIdServicioInteraccion = _Servicio.id
            Me.DialogResult = DialogResult.Yes
        Else
            PnEnvioSolicitud.Visible = True
            PnEnvioSolicitud.BringToFront()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        PnEnvioSolicitud.Visible = False
    End Sub

    Private Sub BtnGenerarSolicitud_Click(sender As Object, e As EventArgs) Handles BtnGenerarSolicitud.Click
        Dim dao As New LyDataAcces.DAO.DaoCandidatura
        Dim creaConCandicatura As New DTOCandidatura With {
            .Estado = LyBussinesModel.EstadoCandidatura.PENDIENTE,
            .HorasRequeridas = NudHorasRequeridas.Value,
            .IdServicio = _Servicio.id,
            .IdUsuario = Main.UsuarioAutenticado.Id,
            .FechaInscripcion = DateTime.Now
        }

        If dao.Crearcandidatura(creaConCandicatura) Then
            _Servicio.SePuedeSolicitar = ResultadoDetalleServicioPuedeSolicitarse.YA_SOLICITADA
            ActualizarEstadoPuedeSolicitar(_Servicio.SePuedeSolicitar)
            PnEnvioSolicitud.Visible = False
        Else
            Dim errores As Exception = DirectCast(dao, LyDataAcces.DAO.IDao).Errores
            MsgBox("Ha ocurrido un error:" + errores.Message)
        End If
    End Sub


    Private Sub ActualizarEstadoPuedeSolicitar(valor As ResultadoDetalleServicioPuedeSolicitarse)
        Select Case valor
            Case ResultadoDetalleServicioPuedeSolicitarse.PUEDE
                BtnCrearSolicitud.Enabled = True
                BtnCrearSolicitud.Text = "ENVÍAR SOLICITUD"
            Case ResultadoDetalleServicioPuedeSolicitarse.HORAS_INSUFICIENTES
                BtnCrearSolicitud.Enabled = False
                BtnCrearSolicitud.Text = "NO LE QUEDÁN HORAS AL CREADOR"
            Case ResultadoDetalleServicioPuedeSolicitarse.YA_SOLICITADA
                BtnCrearSolicitud.Enabled = False
                BtnCrearSolicitud.Text = "YA SOLICITADA"

        End Select
    End Sub

    Private Sub FrmVisualizarAnuncio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LblUsuario.Text = ""
        LblTitulo.Text = ""
        LblDescripcion.Text = ""
        LblCantidadSolicitudes.Text = ""
        LblFechaCreacion.Text = ""
        LblHorasUser.Text = ""
        LblPuntuacion.Text = ""
        LblTags.Text = ""
        BtnCrearSolicitud.Text = ""
        BtnCrearSolicitud.Enabled = False
        PnEnvioSolicitud.Visible = False
    End Sub


End Class