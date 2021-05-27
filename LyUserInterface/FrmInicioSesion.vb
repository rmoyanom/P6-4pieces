Public Class FrmInicioSesion
    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        FrmMain.Show()
        Me.Hide()
    End Sub

    Private Sub LkLblRegistraUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LkLblRegistraUsuario.LinkClicked
        FrmRegistroUsuario.Show()
        Me.Hide()
    End Sub
End Class
