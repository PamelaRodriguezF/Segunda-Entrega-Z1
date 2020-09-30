Class MenuProducto
    Dim MenuPrincipal As MenuPrincipal
    Dim ProductoACargar As Producto
    Dim UsuarioPrograma As Usuario
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(CargaMenuPrincipal As MenuPrincipal, usuario As Usuario, producto As Producto)
        InitializeComponent()
        Me.MenuPrincipal = CargaMenuPrincipal
        Me.ProductoACargar = producto
        Me.UsuarioPrograma = usuario

        NombreProductoTexto.Text = ProductoACargar.Nombre
        PrecioProductoTexto.Text = "$" + ProductoACargar.Precio.ToString
        Try
            FotoProductoBorder.Source = New BitmapImage(New Uri("pack://application:,,,/MercadoLider;component/Recursos/ImagenesProductos/" + ProductoACargar.Foto))
        Catch ex As Exception
            FotoProductoBorder.Source = New BitmapImage(New Uri("pack://application:,,,/MercadoLider;component/Recursos/ImagenesProductos/Default.jpg"))
        End Try
        DescripcionProductoTexto.Text = ProductoACargar.Descripcion

        comprobarusuario()
    End Sub

    Private Sub comprobarusuario()

        If UsuarioPrograma.Id = ProductoACargar.Vendedor.Id Or UsuarioPrograma.Administrador Then
            BotonEliminarProducto.Visibility = Visibility.Visible
            BotonEliminarStock.Visibility = Visibility.Visible
            BotonModificar.Visibility = Visibility.Visible
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        PanelCompraCanvas.Visibility = Visibility.Visible
        ConfirmacionCompraCanvas.Visibility = Visibility.Visible
        FinalizacionCompraCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        PanelCompraCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        ConfirmacionCompraCanvas.Visibility = Visibility.Hidden
        FinalizacionCompraCanvas.Visibility = Visibility.Visible
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        PanelCompraCanvas.Visibility = Visibility.Hidden
        ConfirmacionCompraCanvas.Visibility = Visibility.Hidden
        FinalizacionCompraCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        MenuPrincipal.CargaMenuProductos("nada")
    End Sub
End Class
