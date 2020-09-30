Imports System.Text.RegularExpressions

Class MenuProductos
    Dim MenuPrincipal As MenuPrincipal
    Dim busqueda As String

    Dim ArrayGrids As List(Of Grid)
    Dim ArrayProductos As List(Of Producto)

    Dim ValidacionBusqueda = False
    Public Sub New()
        InitializeComponent()

    End Sub

    Public Sub New(CargaMenuPrincipal As MenuPrincipal, busqueda As String)
        InitializeComponent()
        Me.busqueda = busqueda
        Me.MenuPrincipal = CargaMenuPrincipal


        NavegacionPagina(1)
    End Sub

    Private Sub NavegacionPagina(pagina As Integer)

        ArrayProductos = DAOProductos.encontrarPorNombre(busqueda)

        For index As Integer = 0 To 4
            Dim posPagActual = index + (((pagina - 1) * 5))

            Dim cartaHija As MaterialDesignThemes.Wpf.Card = GridPadre.Children.Item((index))
            cartaHija.Visibility = Visibility.Visible
            Dim gridHija As Grid = cartaHija.Content

            If ArrayProductos.Count > posPagActual Then

                Dim imagenHija As Image = gridHija.Children.Item(0)
                Try
                    imagenHija.Source = New BitmapImage(New Uri("pack://application:,,,/MercadoLider;component/Recursos/ImagenesProductos/" + ArrayProductos(posPagActual).Foto))
                Catch ex As Exception
                    imagenHija.Source = New BitmapImage(New Uri("pack://application:,,,/MercadoLider;component/Recursos/ImagenesProductos/Default.jpg"))
                End Try

                Dim precioHijo As Button = gridHija.Children.Item(1)
                precioHijo.Content = "$" + ArrayProductos(posPagActual).Precio.ToString

                Dim primerStackhijo As StackPanel = gridHija.Children.Item(2)
                Dim tituloHijo As TextBlock = primerStackhijo.Children.Item(0)
                tituloHijo.Text = ArrayProductos(posPagActual).Nombre

                Dim descHija As TextBlock = primerStackhijo.Children.Item(1)
                descHija.Text = ArrayProductos(posPagActual).Descripcion

                Dim segundoStackhijo As StackPanel = gridHija.Children.Item(3)
                Dim verMas As Button = segundoStackhijo.Children.Item(0)
            Else
                cartaHija.Visibility = Visibility.Hidden
            End If
        Next

    End Sub

    Private Sub BotonBuscador_Click(sender As Object, e As RoutedEventArgs) Handles BotonBuscador.Click
        busqueda = TextBoxBuscador.Text

        NavegacionPagina(1)
    End Sub

    Private Sub BotonAtras_Click(sender As Object, e As RoutedEventArgs) Handles BotonAtras.Click
        MenuPrincipal.CargaMenuInicio()
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

    Private Sub CargarAArrays()
        ArrayGrids.Add(PrimerProductoGrid)
        ArrayGrids.Add(SegundoProductoGrid)
        ArrayGrids.Add(TercerProductoGrid)
        ArrayGrids.Add(CuartoProductoGrid)
        ArrayGrids.Add(QuintoProductoGrid)
    End Sub

    Private Sub BotonVerMasPrimerProducto_Click(sender As Object, e As RoutedEventArgs) Handles BotonVerMasPrimerProducto.Click, BotonVerMasSegundoProducto1.Click, BotonVerMasTercerProducto.Click, BotonVerMasCuartoProducto.Click, BotonVerMasQuintoProducto.Click
        Dim padre As StackPanel = sender.Parent

        Dim abuelo As Grid = padre.Parent

        Dim bisabuelo As MaterialDesignThemes.Wpf.Card = abuelo.Parent

        Dim tatarabuelo As Grid = bisabuelo.Parent

        Dim posicionProducto = tatarabuelo.Children.IndexOf(bisabuelo)

        MenuPrincipal.CargaMenuProducto(ArrayProductos(posicionProducto))
    End Sub
End Class
