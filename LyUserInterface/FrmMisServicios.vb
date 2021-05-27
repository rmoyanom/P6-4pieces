Public Class FrmMisServicios
    Private Sub IniciarVentana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.AbribVentana(Me)
    End Sub


    Private Sub Volver_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Main.VolverAlMenu(Me)
    End Sub
End Class