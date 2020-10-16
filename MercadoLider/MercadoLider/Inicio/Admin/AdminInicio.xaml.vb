Imports System.Text.RegularExpressions

Class AdminInicio
    Dim clasePrincipal As Inicio

    Dim ValidacionCorreo = False
    Dim ValidacionClave = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(clasePrincipal As Inicio)
        InitializeComponent()
        Me.clasePrincipal = clasePrincipal
    End Sub

    Private Sub cambioAMenu(clasePrincipal As Inicio)
        Dim CargaMenuPrincipal As New MenuPrincipal(Nothing)
        CargaMenuPrincipal.Show()

        clasePrincipal.Close()
    End Sub

    Private Sub BotonIngresarAdmin_Click(sender As Object, e As RoutedEventArgs) Handles BotonIngresarAdmin.Click
        If ValidacionCorreo And ValidacionClave Then
            cambioAMenu(clasePrincipal)
        Else
            CamposIncorrectosLabel.Content = "Campos Incorrectos"
        End If

    End Sub

    Private Sub TextoLoginUsuario_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextoLoginUsuario.LostFocus
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

End Class
