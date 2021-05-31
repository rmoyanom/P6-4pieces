Public Class FrmMisServicios

    Private Sub Volver_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Main.VolverAlMenu(Me)
    End Sub

    Private Sub FrmMisServicios_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Main.AbribVentana(Me)
    End Sub
End Class