Imports LyBussinesModel.Usuario

Module Main
    Private _MensajeError As String



    Public ReadOnly Property MensajeError As String
        Get
            Dim aux As String = _MensajeError
            _MensajeError = Nothing
            Return aux
        End Get
    End Property
    Public ReadOnly Property EstaLogueado As Boolean
        Get
            Return Not Usuario Is Nothing
        End Get
    End Property
    Public ReadOnly Property UsuarioAutenticado As LyBussinesModel.Usuario
        Get
            Return Usuario
        End Get
    End Property


#Region "Control de apariencia de ventanas"
    Private EstadoVentana As FormWindowState
    Private TamañoVentana As Size
    Private MinimumSize As Size = FrmMain.MinimumSize
    Private PosicionVentana As Point

    Sub AbribVentana(formulario As Form)
        'Acciones para Estandarizar la ventana
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.WindowState = EstadoVentana
        formulario.Size = TamañoVentana
    End Sub
    Sub AbrirApartado(formularioOrigen As Form, formularioDestino As Form)
        ObtenerEstadoFormulario(formularioOrigen)
        formularioOrigen.Hide()
        formularioDestino.Show()
        AplicarEstadoFormulario(formularioDestino)
    End Sub
    Sub VolverAlMenu(formulario As Form)
        ObtenerEstadoFormulario(formulario)
        FrmMain.Show()
        AplicarEstadoFormulario(FrmMain)
    End Sub
    Private Sub ObtenerEstadoFormulario(formulario As Form)
        EstadoVentana = formulario.WindowState
        TamañoVentana = formulario.Size
        PosicionVentana = formulario.Location

    End Sub
    Private Sub AplicarEstadoFormulario(formulario As Form)
        formulario.WindowState = EstadoVentana
        formulario.Size = TamañoVentana
        formulario.Location = PosicionVentana
        formulario.MinimumSize = MinimumSize
    End Sub
#End Region

#Region "Funciones de Acceso"
    Private Usuario As LyBussinesModel.Usuario

    Public Function Login(usuario As String, contraseña As String) As Boolean
        Dim Dao As New LyDataAcces.DAO.DaoUsuario
        Dim idUsuario As Integer = -1

        'TODO: Prevenimos que nombre de usuario solo contenga texto

        idUsuario = Dao.IniciarSesion(usuario, contraseña)
        If idUsuario > 0 Then
            Main.Usuario = Dao.GetPerfilUsuario(idUsuario)

            If Main.Usuario Is Nothing Then
                PrepararMesajeError("No hemos podido recuperar al usuario", Dao)
                Return False
            Else
                Return True
            End If
        Else
            PrepararMesajeError("Usuario o contraseña incorrecta", Dao)
            Return False
        End If

    End Function
    Private Sub PrepararMesajeError(mensaje As String, dao As LyDataAcces.DAO.IDao)
        _MensajeError = mensaje

        Dim readError As Exception = dao.Errores
        If Not readError Is Nothing Then
            _MensajeError = readError.Message.ToString
        End If

    End Sub



#End Region
End Module
