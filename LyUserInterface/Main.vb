Module Main
    Dim UsuarioAutenticado As Boolean = False
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

End Module
