''' <summary>
''' Formulario principal de la aplicación donde permite el acceso a los demas formularios de la aplicacion
''' </summary>
Public Class FrmMain


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Para abrir un apartado ha de estar el usuario logueado menos que formulario de origen sea Registro 
        'De usuario, esta condición añade seguridad a la aplicación frente a ingeniería inversa.
#If Not DEBUG Then
        If EstaLogueado = False Then
            MsgBox("Error de autenticación, el usuario no está autenticado",, "Error")
            Me.Dispose()
            Return
        End If
#End If
        Main.ObtenerEstadoFormulario(Me)
        LoadServicios()
    End Sub

    Private Sub BtnMiCuenta_VisibleChanged(sender As Object, e As EventArgs) Handles BtnMiCuenta.VisibleChanged
        If Me.Visible = True Then
            Main.AbribVentana(Me)
        End If
    End Sub


    Private Sub BtnMiCuenta_Click(sender As Object, e As EventArgs) Handles BtnMiCuenta.Click
        Main.AbrirApartado(Me, FrmMiCuenta)
    End Sub

    Private Sub BtnMiServicios_Click(sender As Object, e As EventArgs) Handles BtnMiServicios.Click
        Main.AbrirApartado(Me, FrmMisServicios)
    End Sub

    Private Sub BtnMisAnuncios_Click(sender As Object, e As EventArgs) Handles BtnMisAnuncios.Click
        Main.AbrirApartado(Me, FrmMisAnuncios)
    End Sub

    Private Sub FrmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Close()
        FrmInicioSesion.Show()
    End Sub

    Public Sub LoadServicios()
        Dim dao As New LyDataAcces.DAO.DaoServicios
        Dim listaServicios As List(Of LyBussinesModel.DTO.DTOServicios)
        listaServicios = dao.GetListServicios()
        If listaServicios IsNot Nothing Then

            If listaServicios.Count > 0 Then
                UcListaAnuncios.ConstruirDatos(listaServicios)
            End If
        End If
    End Sub

    Private Sub VisualizarServicio(id As Integer) Handles UcListaAnuncios.OnClickButton
        FrmVisualizarAnuncio.CargarAnuncio(id)
        If FrmVisualizarAnuncio.ShowDialog() = DialogResult.Yes Then
            FrmMisAnuncios.LoadServicioParaGestion(Main.AuxiliarIdServicioInteraccion)
            Main.AbrirApartado(Me, FrmMisAnuncios)
        End If
    End Sub

    Private Sub BtnAddAnuncio_Click(sender As Object, e As EventArgs) Handles BtnAddAnuncio.Click
        FrmCrearAnuncio.ClearText()
        FrmCrearAnuncio.ShowDialog()
        LoadServicios()
    End Sub

End Class