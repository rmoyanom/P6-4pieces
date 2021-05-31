Imports System.Text.RegularExpressions
Imports LyDataAcces

Public Class FrmInicioSesion

    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        If Login(TxtUsuario.Text, TxtContraseña.Text) Then
            Me.Hide()
            FrmMain.Show()
        Else
            MsgBox("Error producido: " + Main.MensajeError, MsgBoxStyle.Critical, "Error inicio de sesión")
        End If
        TxtContraseña.Clear()
        TxtUsuario.Clear()
        BtnIniciarSesion.Enabled = False
    End Sub

    Private Sub LkLblRegistraUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LkLblRegistraUsuario.LinkClicked
        FrmRegistroUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        'Expresión regular, solo se permite texto.
        If Regex.IsMatch(TxtUsuario.Text, "^[a-zA-Z ]*$") Then
            BtnIniciarSesion.Enabled = True
        Else
            BtnIniciarSesion.Enabled = False
        End If
    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
