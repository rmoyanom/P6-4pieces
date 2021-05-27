Public Class FrmMain
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
        FrmInicioSesion.Close()
    End Sub
End Class