Imports LyDataAcces

Public Class FrmInicioSesion
    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        If Login(TxtUsuario.Text, TxtContraseña.Text) Then
            FrmMain.Show()
            Me.Hide()
        Else
            MsgBox("Error producido: " + Main.MensajeError)
        End If
    End Sub

    Private Sub LkLblRegistraUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LkLblRegistraUsuario.LinkClicked
        FrmRegistroUsuario.Show()
        Me.Hide()
    End Sub

End Class
