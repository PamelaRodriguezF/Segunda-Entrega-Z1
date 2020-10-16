Imports System.Text.RegularExpressions

Class MisDatos

    Dim ValidacionNombre = False
    Dim ValidacionApellido = False
    Dim ValidacionCorreo = False
    Dim ValidacionClave = False
    Dim ValidacionTelefono = False

    Private persona As Usuario
    Private padre As ConfigPrincipal
    Public Sub New(padre As ConfigPrincipal, persona As Usuario)
        InitializeComponent()
        Me.persona = persona
        Me.padre = padre

        cargaDatos()
    End Sub

    'Modificar Usuario
    Private Sub ModificarBoton_Click(sender As Object, e As RoutedEventArgs) Handles ModificarBoton.Click
        Dim modifPersona As Usuario = persona

        modifPersona.Nombre = NombreTexto.Text
        modifPersona.Apellido = ApellidoTexto.Text
        modifPersona.Mail = CorreoTexto.Text
        modifPersona.Clave = ClaveTexto.Password
        modifPersona.Telefono = TelefonoTexto.Text

        If modifPersona.Direcciones.Count > 0 Then
            DAOUsuario.editarDireccion(modifPersona.Id.ToString, DireccionUnoTexto.Text, modifPersona.Direcciones(0))

            modifPersona.Direcciones(0) = DireccionUnoTexto.Text
        Else
            modifPersona.Direcciones.Add(DireccionUnoTexto.Text)

            DAOUsuario.insertarDireccion(modifPersona.Id.ToString, DireccionUnoTexto.Text)
        End If

        If modifPersona.Direcciones.Count > 1 Then
            DAOUsuario.editarDireccion(modifPersona.Id.ToString, DireccionDosTexto.Text, modifPersona.Direcciones(1))

            modifPersona.Direcciones(1) = DireccionDosTexto.Text
        Else
            modifPersona.Direcciones.Add(DireccionDosTexto.Text)

            DAOUsuario.insertarDireccion(modifPersona.Id.ToString, DireccionDosTexto.Text)
        End If

        DAOUsuario.editarUsuario(modifPersona)

        MsgBox("Actualizado correctamente")
    End Sub

    'Eliminar usuario
    Private Sub EliminarBoton_Click(sender As Object, e As RoutedEventArgs) Handles EliminarBoton.Click
        PreguntarBorradoPanel.Visibility = Visibility.Visible
    End Sub

    Private Sub NegarConfir_Click(sender As Object, e As RoutedEventArgs) Handles NegarConfir.Click
        PreguntarBorradoPanel.Visibility = Visibility.Hidden
    End Sub

    Private Sub AceptarConfir_Click(sender As Object, e As RoutedEventArgs) Handles AceptarConfir.Click
        DAOUsuario.borrarUsuario(persona.Id)

        Dim nuevoInicio As New Inicio()
        nuevoInicio.Show()

        padre.Hide()
        padre.Close()
    End Sub
    'Carga de datos
    Private Sub cargaDatos()
        NombreTexto.Text = persona.Nombre
        ApellidoTexto.Text = persona.Apellido
        CorreoTexto.Text = persona.Mail
        ClaveTexto.Password = persona.Clave
        TelefonoTexto.Text = persona.Telefono
        If persona.Direcciones.Count > 0 Then
            DireccionUnoTexto.Text = persona.Direcciones(0)
            If persona.Direcciones.Count > 1 Then
                DireccionDosTexto.Text = persona.Nombre(1)
            End If
        End If
    End Sub

    'Validaciones
    Private Sub NombreText_LostFocus(sender As Object, e As RoutedEventArgs) Handles NombreTexto.LostFocus
        Static NombreExpRegular As New Regex("^[ a-zA-Z]+$")

        If NombreExpRegular.IsMatch(sender.Text) Then
            ErrorNombre.Content = ""
            ValidacionNombre = True
        Else
            ErrorNombre.Content = "Formato de nombre incorrecto"
            ValidacionNombre = False
        End If
    End Sub

    Private Sub ApellidoText_LostFocus(sender As Object, e As RoutedEventArgs) Handles ApellidoTexto.LostFocus
        Static ApellidoExpRegular As New Regex("^[ a-zA-Z]+$")

        If ApellidoExpRegular.IsMatch(sender.Text) Then
            ErrorApellido.Content = ""
            ValidacionApellido = True
        Else
            ErrorApellido.Content = "Formato de apellido incorrecto"
            ValidacionApellido = False
        End If
    End Sub

    Private Sub CorreoText_LostFocus(sender As Object, e As RoutedEventArgs) Handles CorreoTexto.LostFocus
        Static EmailExpRegular As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        If EmailExpRegular.IsMatch(sender.Text) Then
            ErrorCorreo.Content = ""
            ValidacionCorreo = True
        Else
            ErrorCorreo.Content = "Formato de correo incorrecto"
            ValidacionCorreo = False
        End If
    End Sub

    Private Sub TextoLoginClave_LostFocus(sender As Object, e As RoutedEventArgs) Handles ClaveTexto.LostFocus
        Static ClaveExpRegular As New Regex("^[a-zA-Z0-9]+$")

        If ClaveExpRegular.IsMatch(sender.Password.ToString()) Then
            ErrorClave.Content = ""
            ValidacionClave = True
        Else
            ErrorClave.Content = "Formato de clave incorrecto"
            ValidacionClave = False
        End If
    End Sub

    Private Sub TelefonoText_LostFocus(sender As Object, e As RoutedEventArgs) Handles TelefonoTexto.LostFocus
        Static TelefonoExpRegular As New Regex("^[ 0-9]+$")

        If TelefonoExpRegular.IsMatch(sender.Text) Then
            ErrorTelefono.Content = ""
            ValidacionTelefono = True
        Else
            ErrorTelefono.Content = "Formato de Telefono incorrecto"
            ValidacionTelefono = False
        End If
    End Sub

End Class
