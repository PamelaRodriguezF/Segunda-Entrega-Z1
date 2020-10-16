Imports System.Text.RegularExpressions

Class Registro2
    Dim clasePrincipal As Inicio
    Dim ValidacionRut = False

    Dim terminado As Boolean = False

    Dim creacionPersona As Usuario
    Public Sub New()
    End Sub

    Public Sub New(clasePrincipal As Inicio, persona As Usuario)
        InitializeComponent()

        terminado = True

        Me.clasePrincipal = clasePrincipal
        Me.creacionPersona = persona
    End Sub

    Private Sub BotonInicio_Click(sender As Object, e As RoutedEventArgs) Handles BotonRegistro.Click
        If ValidacionRut Then
            DAOUsuario.insertarUsuario(creacionPersona)
            Dim direccion As String = creacionPersona.Direcciones(0)


            creacionPersona = DAOUsuario.encontrarPersona(creacionPersona.Mail, creacionPersona.Clave)
            DAOUsuario.insertarDireccion(creacionPersona.Id.ToString, direccion)

            If ComboOpcion.SelectedIndex = 0 Then
                DAOUsuario.insertarComprador(creacionPersona.Id.ToString)

            ElseIf ComboOpcion.SelectedIndex = 1 Then
                DAOUsuario.insertarVendedor(creacionPersona.Id.ToString, TextoRutEmpresa.Text)

            ElseIf ComboOpcion.SelectedIndex = 2 Then
                DAOUsuario.insertarComprador(creacionPersona.Id.ToString)
                DAOUsuario.insertarVendedor(creacionPersona.Id.ToString, TextoRutEmpresa.Text)
            End If

            MsgBox("Registro existoso")
            cambioAMenu(clasePrincipal)
        End If
    End Sub


    Private Sub ComboOpcion_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles ComboOpcion.SelectionChanged
        If ComboOpcion.SelectedIndex > 0 And terminado Then
            DescripcionEmpresa.Visibility = Visibility.Visible
            ErrorRut.Visibility = Visibility.Visible
            TextoRutEmpresa.Visibility = Visibility.Visible
        ElseIf ComboOpcion.SelectedIndex = 0 And terminado Then
            DescripcionEmpresa.Visibility = Visibility.Hidden
            ErrorRut.Visibility = Visibility.Hidden
            TextoRutEmpresa.Visibility = Visibility.Hidden
        End If
    End Sub

    Private Sub cambioAMenu(clasePrincipal As Inicio)
        Dim CargaMenuPrincipal As New Inicio
        CargaMenuPrincipal.Show()

        clasePrincipal.Close()
    End Sub

    Private Sub TextoRutEmpresa_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextoRutEmpresa.LostFocus
        Static RutExpRegular As New Regex("^[0-9]+$")

        If RutExpRegular.IsMatch(sender.Text) And sender.Text.ToString().Length = 12 Then
            ErrorRut.Content = ""
            ValidacionRut = True
        Else
            ErrorRut.Content = "Formato de RUT incorrecto"
            ValidacionRut = False
        End If
    End Sub

End Class
