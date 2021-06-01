Imports LyBussinesModel
Imports LyDataAcces

Public Class FrmMisServicios

    Private Sub Volver_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Main.VolverAlMenu(Me)
    End Sub

    Private Sub FrmMisServicios_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Main.AbribVentana(Me)
    End Sub


    Private Sub UcListaServicios_Load(sender As Object, e As EventArgs) Handles UcListaServicios.Load
        Dim listaServiciosUser As List(Of DTO.DTOServicios)
        LblCurrentMenu.Text = "Activos"
        UploadListaServicios(listaServiciosUser, True)
    End Sub

    Private Sub UploadListaServicios(listaServiciosUser As List(Of DTO.DTOServicios), estado As Boolean)
        Dim dao As DAO.DaoServicios = New DAO.DaoServicios()
        Dim dto As DTO.DTOServicios = New DTO.DTOServicios()
        listaServiciosUser = dao.GetListServicios(UsuarioAutenticado.Id, estado)
    End Sub
    Private Sub BtnActivos_Click(sender As Object, e As EventArgs) Handles BtnActivos.Click
        Dim listaServiciosUser As List(Of DTO.DTOServicios)
        LblCurrentMenu.Text = "Activos"
        UploadListaServicios(listaServiciosUser, True)
    End Sub
    Private Sub BtnFinalizados_Click(sender As Object, e As EventArgs) Handles BtnFinalizados.Click
        Dim listaServiciosUser As List(Of DTO.DTOServicios)
        LblCurrentMenu.Text = "Finalizados"
        UploadListaServicios(listaServiciosUser, False)
    End Sub
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dispose()
    End Sub

End Class