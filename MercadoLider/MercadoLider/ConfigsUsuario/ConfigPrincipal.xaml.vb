Public Class ConfigPrincipal
    Dim MenuPrincipal As MenuPrincipal

    Private persona As Usuario
    Public Sub New(CargaMenuPrincipal As MenuPrincipal, persona As Usuario)
        InitializeComponent()
        Me.persona = persona
        Me.MenuPrincipal = CargaMenuPrincipal

        CargaElemento(New MisDatos(Me, persona))
        cargaDatosUsuario()
    End Sub

    'Carga datos de usuario
    Private Sub cargaDatosUsuario()
        LabelNombreUsuario.Content = persona.Nombre

        Try
            ImagenUsuario.Source = New BitmapImage(New Uri("pack://application:,,,/MercadoLider;component/Recursos/AvatarUsuario/" + persona.Imagen))
        Catch ex As Exception
            ImagenUsuario.Source = New BitmapImage(New Uri("pack://application:,,,/MercadoLider;component/Recursos/AvatarUsuario/Default.png"))
        End Try
    End Sub

    'Navegacion
    Private Sub DatosBoton_Click(sender As Object, e As RoutedEventArgs) Handles DatosBoton.Click
        CargaElemento(New MisDatos(Me, persona))
    End Sub

    Private Sub ComprasBoton_Click(sender As Object, e As RoutedEventArgs) Handles ComprasBoton.Click
        CargaElemento(New ComprasUsuario(Me, MenuPrincipal, persona))
    End Sub

    Private Sub VentasBoton_Click(sender As Object, e As RoutedEventArgs) Handles VentasBoton.Click
        CargaElemento(New VentasUsuario(Me, MenuPrincipal, persona))
    End Sub

    Private Sub CrearProductoBoton_Click(sender As Object, e As RoutedEventArgs) Handles CrearProductoBoton.Click
        CargaElemento(New ProductosUsuario(Me, persona))
    End Sub

    Private Sub StockBoton_Click(sender As Object, e As RoutedEventArgs) Handles StockBoton.Click
        CargaElemento(New StockUsuario(Me, MenuPrincipal, persona))
    End Sub

    Private Sub FacturasBoton_Click(sender As Object, e As RoutedEventArgs) Handles FacturasBoton.Click
        CargaElemento(New VerFacturaUsuario(Me, persona))
    End Sub

    Public Sub CargaElemento(pagina As Page)
        CargaElementos.Navigate(pagina)
    End Sub


    Private Sub VolverMenuPrincial_Click(sender As Object, e As RoutedEventArgs) Handles VolverMenuPrincial.Click
        Dim MenuCarga As New MenuPrincipal(persona)

        MenuCarga.Show()

        Me.Hide()
        Me.Close()
    End Sub

    Private Sub CanvasLoginCerrar_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles CanvasLoginCerrar.MouseLeftButtonUp
        Me.Close()
    End Sub
End Class
