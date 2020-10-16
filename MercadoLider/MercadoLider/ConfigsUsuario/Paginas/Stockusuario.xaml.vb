Class StockUsuario

    Private persona As Usuario
    Dim MenuPrincipal As MenuPrincipal
    Dim menu As ConfigPrincipal

    Private listaCartas As List(Of MaterialDesignThemes.Wpf.Card)
    Private listaBotones As List(Of Button)

    Private listaProductos As List(Of Producto)

    Private paginaProductos As Integer = 0
    Public Sub New(menu As ConfigPrincipal, CargaMenuPrincipal As MenuPrincipal, persona As Usuario)
        InitializeComponent()
        Me.persona = persona
        Me.MenuPrincipal = CargaMenuPrincipal
        Me.menu = menu

        cargaStockUsuario(paginaProductos)
    End Sub

    Private Sub cargaStockUsuario(paginaProductos As Integer)
        listaCartas = New List(Of MaterialDesignThemes.Wpf.Card)
        listaBotones = New List(Of Button)

        cargarALista()
        listaProductos = DAOProductos.encontrarStockPorVendedor(persona)

        Dim recorrido As Integer
        If ((listaProductos.Count - 1) - (paginaProductos * 4)) <= 3 Then
            recorrido = ((listaProductos.Count - 1) - (paginaProductos * 4))
        Else
            recorrido = 3
        End If

        For index As Integer = 0 To 3
            Dim numeroProd As Integer = index + (paginaProductos * 4)
            Dim gridcartas As Grid = listaCartas(index).Content

            If index <= recorrido Then
                listaCartas(index).Visibility = Visibility.Visible

                Dim imagenProducto As Image = gridcartas.Children(0)
                Try
                    imagenProducto.Source = New BitmapImage(New Uri("pack://application:,,,/MercadoLider;component/Recursos/ImagenesProductos/" + listaProductos(numeroProd).Foto))
                Catch ex As Exception
                    imagenProducto.Source = New BitmapImage(New Uri("pack://application:,,,/MercadoLider;component/Recursos/ImagenesProductos/Default.jpg"))
                End Try

                Dim nombreProducto As TextBox = gridcartas.Children(1)
                nombreProducto.Text = "Nombre: " + listaProductos(numeroProd).Nombre

                Dim precioProducto As TextBox = gridcartas.Children(2)
                precioProducto.Text = "Precio: $" + listaProductos(numeroProd).Precio.ToString()

                Dim stockProducto As TextBox = gridcartas.Children(3)
                stockProducto.Text = "Stock: " + listaProductos(numeroProd).Cant.ToString()

                listaBotones.Add(gridcartas.Children(4))

                Actual.Content = paginaProductos + 1

                If paginaProductos = 0 Then
                    Anterior.Visibility = Visibility.Hidden
                    Primero.Visibility = Visibility.Hidden
                Else
                    Anterior.Visibility = Visibility.Visible
                    Primero.Visibility = Visibility.Visible
                End If
            Else
                listaCartas(index).Visibility = Visibility.Hidden
            End If

            If numeroProd >= listaProductos.Count - 1 Then
                Siguiente.Visibility = Visibility.Hidden
                Ultimo.Visibility = Visibility.Hidden
            Else
                Siguiente.Visibility = Visibility.Visible
                Ultimo.Visibility = Visibility.Visible
            End If

            If listaProductos.Count <= 3 Then
                Anterior.Visibility = Visibility.Hidden
                Primero.Visibility = Visibility.Hidden
                Actual.Content = 1
                Siguiente.Visibility = Visibility.Hidden
                Ultimo.Visibility = Visibility.Hidden
            End If
        Next
    End Sub

    Private Sub cargarALista()
        listaCartas = New List(Of MaterialDesignThemes.Wpf.Card)

        listaCartas.Add(GridProductosStock.Children(0))
        listaCartas.Add(GridProductosStock.Children(1))
        listaCartas.Add(GridProductosStock.Children(2))
        listaCartas.Add(GridProductosStock.Children(3))
    End Sub

    Private Sub CargarProducto(sender As Object, e As RoutedEventArgs)
        Dim index As Integer = listaBotones.IndexOf(sender)

        MenuPrincipal.CargaMenuProducto(listaProductos(index + (paginaProductos * 4)))

        menu.Hide()

    End Sub

    Private Sub SiguientePag(sender As Object, e As RoutedEventArgs) Handles Siguiente.Click
        paginaProductos += 1

        cargaStockUsuario(paginaProductos)
    End Sub

    Private Sub AnteriorPag(sender As Object, e As RoutedEventArgs) Handles Anterior.Click
        paginaProductos -= 1

        cargaStockUsuario(paginaProductos)
    End Sub

    Private Sub PrimerPag(sender As Object, e As RoutedEventArgs) Handles Primero.Click
        paginaProductos = 0
        cargaStockUsuario(paginaProductos)
    End Sub
    Private Sub UltimaPag(sender As Object, e As RoutedEventArgs) Handles Ultimo.Click
        paginaProductos = listaProductos.Count / 4

        cargaStockUsuario(paginaProductos)
    End Sub
End Class
