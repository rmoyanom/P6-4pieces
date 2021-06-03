Imports LyBussinesModel.Usuario

Module Main
    Private _MensajeError As String

    ''' <summary>
    ''' Variable auxiliar utilizada para controlar el id de servicio entre formularios.
    ''' </summary>
    Private _AuxiliarIdServicioInteraccion As Integer

    ''' <summary>
    ''' Provee acceso a los errores que se generen dentro del modulo
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MensajeError As String
        Get
            Dim aux As String = _MensajeError
            _MensajeError = Nothing
            Return aux
        End Get
    End Property

    ''' <summary>
    ''' Metodo que determina si un usuario fue logueado con exito
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property EstaLogueado As Boolean
        Get
            Return Not Usuario Is Nothing
        End Get
    End Property


    ''' <summary>
    ''' Provee acceso al objeto usuario autenticado en la app
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property UsuarioAutenticado As LyBussinesModel.Usuario
        Get
            Return Usuario
        End Get
    End Property

    ''' <summary>
    ''' Provee acceso al id servicio auxiliar
    ''' </summary>
    ''' <returns></returns>
    Public Property AuxiliarIdServicioInteraccion As Integer
        Get
            Return _AuxiliarIdServicioInteraccion
        End Get
        Set(value As Integer)
            _AuxiliarIdServicioInteraccion = value
        End Set
    End Property


#Region "Control de apariencia de ventanas"
    Private EstadoVentana As FormWindowState
    Private TamañoVentana As Size
    Private MinimumSize As Size = FrmMain.MinimumSize
    Private PosicionVentana As Point

    ''' <summary>
    ''' llamada que hacen los formularios para obtener la posición y tamaño del formulario que inicio su llamada
    ''' </summary>
    ''' <param name="formulario"></param>
    Sub AbribVentana(formulario As Form)
        If formulario.WindowState <> EstadoVentana Then
            formulario.WindowState = EstadoVentana
        End If

        formulario.Size = TamañoVentana
        formulario.Location = PosicionVentana
    End Sub

    ''' <summary>
    ''' Metodo rapido para abrir un subapartado
    ''' </summary>
    ''' <param name="formularioOrigen"></param>
    ''' <param name="formularioDestino"></param>
    Sub AbrirApartado(formularioOrigen As Form, formularioDestino As Form)
        ObtenerEstadoFormulario(formularioOrigen)
        formularioOrigen.Hide()
        formularioDestino.Visible = True
    End Sub

    ''' <summary>
    ''' Metodo rapido para volver al frmenu
    ''' </summary>
    ''' <param name="formulario"></param>
    Sub VolverAlMenu(formulario As Form)
        ObtenerEstadoFormulario(formulario)
        FrmMain.LoadServicios()
        FrmMain.Show()
    End Sub

    ''' <summary>
    ''' Obtiene el estado actual del tamaño y posición de un formulario para aplicarlo a un subformulario
    ''' </summary>
    ''' <param name="formulario"></param>
    Public Sub ObtenerEstadoFormulario(formulario As Form)
        EstadoVentana = formulario.WindowState
        TamañoVentana = formulario.Size
        PosicionVentana = formulario.Location
    End Sub

    ''' <summary>
    ''' Aplica el tamaño y posicion a un formulario con los datos internos del modulo main( Cargados con anterioridad)
    ''' </summary>
    ''' <param name="formulario"></param>
    Private Sub AplicarEstadoFormulario(formulario As Form)
        formulario.WindowState = EstadoVentana
        formulario.Size = TamañoVentana
        formulario.Location = PosicionVentana
        formulario.MinimumSize = MinimumSize
    End Sub
#End Region

#Region "Funciones de Acceso"
    ''' <summary>
    ''' Objeto de usuario logueado
    ''' </summary>
    Private Usuario As LyBussinesModel.Usuario

    ''' <summary>
    ''' Metodo para editar al usuario logueado
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub UpdateUserOnEdit(id As Integer)
        Dim Dao As New LyDataAcces.DAO.DaoUsuario
        Main.Usuario = Dao.GetPerfilUsuario(id)
    End Sub

    ''' <summary>
    ''' Realizar login de usuario
    ''' </summary>
    ''' <param name="usuario">nombre de usuario</param>
    ''' <param name="contraseña">Contraseña</param>
    ''' <returns></returns>
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

    ''' <summary>
    ''' En el caso de existir un error en un dao utilizado en el modulo prepara el error para su posterior salida
    ''' </summary>
    ''' <param name="mensaje"></param>
    ''' <param name="dao"></param>
    Private Sub PrepararMesajeError(mensaje As String, dao As LyDataAcces.DAO.IDao)
        _MensajeError = mensaje

        Dim readError As Exception = dao.Errores
        If readError IsNot Nothing Then
            _MensajeError = readError.Message.ToString
        End If

    End Sub


    ''' <summary>
    ''' Verifica si la base de datos existe, si no es así, la crea.
    ''' </summary>
    Public Sub VerificarSiExisteBD()
        Dim daoUser As New LyDataAcces.DAO.DaoUsuario
        Dim daoCategoria As New LyDataAcces.DAO.DaoCategoria

        If daoUser.CreateBDSiNoExiste Then

            'Creación de Categorias
            daoCategoria.CrearCategoria("Hogar")
            daoCategoria.CrearCategoria("Informática")
            daoCategoria.CrearCategoria("CuidadoMayores")
            daoCategoria.CrearCategoria("Mecanica")
            daoCategoria.CrearCategoria("LaborSocial")
            daoCategoria.CrearCategoria("Alimentos")
            daoCategoria.CrearCategoria("Cocina")
            daoCategoria.CrearCategoria("Construcción")
            daoCategoria.CrearCategoria("Educación")
            daoCategoria.CrearCategoria("PaseoAnimales")
            daoCategoria.CrearCategoria("Niñer@")

        End If


    End Sub

#End Region
End Module
