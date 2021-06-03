﻿Imports System.Text.RegularExpressions
Imports LyDataAcces

''' <summary>
''' Formulario principal para realizar el loguin del usuario
''' </summary>
Public Class FrmInicioSesion
    '#If DEBUG Then
    '    Private Sub FrmInicioSesion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '        If Login("a", "a") Then
    '            Me.Hide()
    '            FrmMain.Show()
    '        End If
    '    End Sub
    '#End If


    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        If Login(TxtUsuario.Text.ToLower(), TxtContraseña.Text) Then
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
        Main.VerificarSiExisteBD()
    End Sub
End Class
