Imports LyBussinesModel
Imports LyDataAcces

Public Class FrmMisServicios

    Private Sub Volver_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Main.VolverAlMenu(Me)
    End Sub

    Private Sub FrmMisServicios_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Main.AbribVentana(Me)
    End Sub


    Private Sub UcListaCandidaturas_Load(sender As Object, e As EventArgs) Handles UcListaCandidaturas.Load
        Dim listaCandidaturasUser As List(Of Candidatura)
        LblCurrentMenu.Text = "Activas"
        UcListaCandidaturas.ConstruirDatos(UploadListaCandidaturas(True))
    End Sub

    Private Function UploadListaCandidaturas(estado As Boolean) As List(Of Candidatura)
        Dim dao As DAO.DaoCandidatura = New DAO.DaoCandidatura()
        Return dao.GetListaCandidaturas(UsuarioAutenticado, estado)
    End Function
    Private Sub BtnActivos_Click(sender As Object, e As EventArgs) Handles BtnActivos.Click
        Dim listaCandidaturasUser As List(Of Candidatura)
        LblCurrentMenu.Text = "Activas"
        UcListaCandidaturas.ConstruirDatos(UploadListaCandidaturas(True))
    End Sub
    Private Sub BtnFinalizados_Click(sender As Object, e As EventArgs) Handles BtnFinalizados.Click
        Dim listaCandidaturasUser As List(Of Candidatura)
        LblCurrentMenu.Text = "Finalizadas"
        UcListaCandidaturas.ConstruirDatos(UploadListaCandidaturas(False))
    End Sub
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dispose()
    End Sub

    Private Sub Cancelacion_EventHandler() Handles UcListaCandidaturas.OnClickButton
        Dim estado As Boolean = True
        Dim listaCandidaturasUser As List(Of Candidatura)
        If (LblCurrentMenu.Text = "Finalizadas") Then
            estado = False
        End If
        LblCurrentMenu.Text = "Activas"
        UcListaCandidaturas.ConstruirDatos(UploadListaCandidaturas(estado))
    End Sub
    Private Sub FrmMisServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class