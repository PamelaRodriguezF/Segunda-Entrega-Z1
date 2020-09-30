Imports System.Text.RegularExpressions

Class Registro1
    Dim clasePrincipal As Inicio
    Dim ValidacionNombre = False
    Dim ValidacionApellido = False
    Dim ValidacionCorreo = False
    Dim ValidacionClave = False
    Dim ValidacionTelefono = False
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(clasePrincipal As Inicio)
        InitializeComponent()
        Me.clasePrincipal = clasePrincipal
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If ValidacionNombre And ValidacionApellido And ValidacionCorreo And ValidacionClave And ValidacionTelefono Then
            Dim direcciones As New List(Of String)
            direcciones.Add(TextoDireccUnousuario.Text)
            Dim nuevoUsuario As New Usuario(-1, TextoCorreoUsuario.Text, TextoLoginClave.Password, TextoNombreUsuario.Text, TextoApellidoUsuario.Text, "Coso", direcciones, TextoTelUsuario.Text, False, False, False)

            Dim ContRegUsuario As New Registro2(clasePrincipal, nuevoUsuario)
            CargaPagina.Navigate(ContRegUsuario)
        End If
        CamposIncorrectosLabel.Content = "Campos Incorrectos"

    End Sub

    Private Sub TextoNombreUsuario_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextoNombreUsuario.LostFocus
        Static NombreExpRegular As New Regex("^[ a-zA-Z]+$")

        If NombreExpRegular.IsMatch(sender.Text) Then
            ErrorNombre.Content = ""
            ValidacionNombre = True
        Else
            ErrorNombre.Content = "Formato de nombre incorrecto"
            ValidacionNombre = False
        End If
    End Sub

    Private Sub ErrorApellido_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextoApellidoUsuario.LostFocus
        Static ApellidoExpRegular As New Regex("^[ a-zA-Z]+$")

        If ApellidoExpRegular.IsMatch(sender.Text) Then
            ErrorApellido.Content = ""
            ValidacionApellido = True
        Else
            ErrorApellido.Content = "Formato de apellido incorrecto"
            ValidacionApellido = False
        End If
    End Sub

    Private Sub TextoCorreoUsuario_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextoCorreoUsuario.LostFocus
        Static EmailExpRegular As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        If EmailExpRegular.IsMatch(sender.Text) Then
            ErrorCorreo.Content = ""
            ValidacionCorreo = True
        Else
            ErrorCorreo.Content = "Formato de correo incorrecto"
            ValidacionCorreo = False
        End If
    End Sub

    Private Sub TextoLoginClave_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextoLoginClave.LostFocus
        Static ClaveExpRegular As New Regex("^[a-zA-Z0-9]+$")

        If ClaveExpRegular.IsMatch(sender.Password.ToString()) Then
            ErrorClave.Content = ""
            ValidacionClave = True
        Else
            ErrorClave.Content = "Formato de clave incorrecto"
            ValidacionClave = False
        End If
    End Sub

    Private Sub TextoTelUsuario_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextoTelUsuario.LostFocus
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
