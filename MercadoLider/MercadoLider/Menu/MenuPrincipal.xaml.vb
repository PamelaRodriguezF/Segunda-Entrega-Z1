Public Class MenuPrincipal

    Private persona As Usuario
    Public Sub New(persona As Usuario)
        InitializeComponent()
        Me.persona = persona

        CargaMenuInicio()
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

    'Navegacion de ventanas
    Public Sub CargaMenuInicio()
        Dim CargaMenuInicial As New MenuInicio(Me)
        CargaElementos.Navigate(CargaMenuInicial)
    End Sub
    Public Sub CargaMenuProductos(busqueda As String)
        Dim CargaMenuProductos As New MenuProductos(Me, busqueda)
        CargaElementos.Navigate(CargaMenuProductos)
    End Sub
    Public Sub CargaMenuProducto(producto As Producto)
        Dim CargaMenuProducto As New MenuProducto(Me, persona, producto)
        Me.Show()
        CargaElementos.Navigate(CargaMenuProducto)
    End Sub

    Private Sub ConfigBoton_Click(sender As Object, e As RoutedEventArgs) Handles BotonMiPerfil.Click
        Dim MiPerfil As New ConfigPrincipal(Me, persona)
        MiPerfil.Show()

        Me.Hide()
    End Sub

    Private Sub ConfigBoton_Click_1(sender As Object, e As RoutedEventArgs) Handles ConfigBoton.Click
        Dim AjusteVentana As New Ajustes(persona)
        AjusteVentana.Show()

        Me.Hide()
    End Sub

    Private Sub BotonDesconectar_Click(sender As Object, e As RoutedEventArgs) Handles BotonDesconectar.Click
        Dim IrInicio As New Inicio
        IrInicio.Show()

        Me.Hide()
        Me.Close()
    End Sub

    Private Sub CanvasLoginCerrar_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles CanvasLoginCerrar.MouseLeftButtonDown
        Me.Close()

    End Sub
End Class
