Public Class FrmVisualizarAnuncio
    Private Servicio As LyBussinesModel.DTO.DTOServiciosDetalles

    Public Sub CargarAnuncio(idServicio As Integer)
        Dim Dao As New LyDataAcces.DAO.DaoServicios

        Dao.GetServiciosDetalles(idServicio)
    End Sub

    Private Sub FrmVisualizarAnuncio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class