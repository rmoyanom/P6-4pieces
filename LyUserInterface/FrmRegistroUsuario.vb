Imports LyBussinesModel
Imports LyDataAcces
Public Class FrmRegistroUsuario
    Private Sub FrmRegistroUsuario_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        FrmInicioSesion.Show()
    End Sub
    Private Sub BtnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        Dim nuevoUsuario = New DTO.DTOUsuario(
            TxtNombreUsuario.Text,
            TxtNombre.Text,
            TxtApellidos.Text,
            TxtTelefono.Text,
            TxtEmail.Text,
            Usuario.CreateHash(TxtNombreUsuario.Text, TxtPassword.Text)
        )

        Dim daoUsuario = New DAO.DaoUsuario()

        If (daoUsuario.RegistrarUsuario(nuevoUsuario)) Then

            Login(TxtNombreUsuario.Text, TxtPassword.Text)
            FrmMain.Show()
            Me.Hide()

        Else
            LblError.Text = DirectCast(daoUsuario, LyDataAcces.DAO.IDao).Errores.Message
            MsgBox("Error producido: " + LblError.Text, MsgBoxStyle.Critical, "Error registrando usuario")

        End If
    End Sub
    Private Sub BtnCancelarRegistro_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FrmInicioSesion.Show()
        Me.Hide()
    End Sub

    Private Sub FrmRegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class