Imports System.Text.RegularExpressions

Class MenuInicio
    Dim MenuPrincipal As MenuPrincipal

    Dim ValidacionBusqueda = False
    Public Sub New()
        InitializeComponent()


    End Sub

    Public Sub New(CargaMenuPrincipal As MenuPrincipal)
        InitializeComponent()

        Me.MenuPrincipal = CargaMenuPrincipal
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If ValidacionBusqueda Then
            MenuPrincipal.CargaMenuProductos(TextBoxBuscador.Text)
        End If
    End Sub

    Private Sub BotonAdmin_Click(sender As Object, e As RoutedEventArgs) Handles BotonAdmin.Click
        Dim Admin As New Inicio(True)
        Admin.Show()

        MenuPrincipal.Hide()
        MenuPrincipal.Close()
    End Sub

    Private Sub TextBoxBuscador_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextBoxBuscador.LostFocus
        Static BuscadorExpRegular As New Regex("^[ a-zA-Z0-9]+$")

        If BuscadorExpRegular.IsMatch(sender.Text) Then
            FormatoBusquedaLabel.Content = ""
            ValidacionBusqueda = True
        Else
            FormatoBusquedaLabel.Content = "Formato de busqueda incorrecto"
            ValidacionBusqueda = False
        End If
    End Sub
End Class
