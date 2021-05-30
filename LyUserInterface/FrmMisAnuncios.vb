Imports LyBussinesModel.DTO

Public Class FrmMisAnuncios

    Private _Servicio As LyBussinesModel.DTO.DTOServiciosDetalles

    Private Sub FrmMisAnuncios_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Main.AbribVentana(Me)
    End Sub

    Private Sub IniciarVentana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnActivos_Click(sender, e)
    End Sub

    Private Sub BtnActivos_Click(sender As Object, e As EventArgs) Handles BtnActivos.Click
        LblSubtitulo.Text = "Activos"
        UcListaAnuncios.TextoBotones = "Gestionar"
        Dim dao As New LyDataAcces.DAO.DaoServicios
        Dim listaServicios As List(Of LyBussinesModel.DTO.DTOServicios)
        listaServicios = dao.GetListServicios(Main.UsuarioAutenticado.Id, False)
        If listaServicios IsNot Nothing Then

            If listaServicios.Count > 0 Then
                UcListaAnuncios.ConstruirDatos(listaServicios)
            End If
        End If
    End Sub

    Private Sub BtnFinalizados_Click(sender As Object, e As EventArgs) Handles BtnFinalizados.Click
        LblSubtitulo.Text = "Finalizados"
        UcListaAnuncios.TextoBotones = "Ver registros"
        Dim dao As New LyDataAcces.DAO.DaoServicios
        Dim listaServicios As List(Of LyBussinesModel.DTO.DTOServicios)
        listaServicios = dao.GetListServicios(Main.UsuarioAutenticado.Id, True)
        UcListaAnuncios.ConstruirDatos(listaServicios)
    End Sub

    Private Sub BtnAddAnuncio_Click(sender As Object, e As EventArgs) Handles BtnAddAnuncio.Click
        FrmCrearAnuncio.ClearText()
        FrmCrearAnuncio.Show()
    End Sub

    Private Sub UcListaAnuncios_OnClickButton(id As Integer) Handles UcListaAnuncios.OnClickButton
        LoadServicioParaGestion(id)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click, Button3.Click
        PnVerGestionarAnuncio.Hide()
    End Sub

    Private Sub LoadServicioParaGestion(idServicio As Integer)
        Dim Dao As New LyDataAcces.DAO.DaoServicios

        _Servicio = Dao.GetServiciosDetalles(idServicio, Main.UsuarioAutenticado.Id)
        If _Servicio IsNot Nothing Then
            TxtTitulo.Text = _Servicio.Titulo
            RtxtDescripcion.Text = _Servicio.Descripcion


            LoadCategorias()

            If _Servicio.Categorias.Count > 0 Then
                For Each categoria As DTOCategoria In _Servicio.Categorias

                    For i As Integer = 0 To ChkList.Items.Count - 1
                        Dim item = ChkList.Items(i)
                        Dim element = DirectCast(item, LyBussinesModel.Categoria)
                        If element.Id = categoria.idCategoria Then
                            ChkList.SetItemChecked(ChkList.Items.IndexOf(item), True)
                        End If
                    Next

                Next
            End If
            PnVerGestionarAnuncio.Show()
            PnVerGestionarAnuncio.BringToFront()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub LoadCategorias()
        ChkList.DataSource = Nothing
        Dim dao As New LyDataAcces.DAO.DaoCategoria
        Dim list As List(Of LyBussinesModel.Categoria) = dao.GetAllCategorias
        If list.Count > 0 Then
            ChkList.DataSource = list
            ChkList.ValueMember = "Id"
            ChkList.DisplayMember = "Nombre"
        End If
    End Sub



    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dispose()
    End Sub
    Private Sub Volver_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Main.VolverAlMenu(Me)
    End Sub

End Class