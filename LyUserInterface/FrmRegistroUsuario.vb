Public Class FrmRegistroUsuario
    Private Sub FrmRegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmRegistroUsuario_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        FrmInicioSesion.Show()
    End Sub
End Class