Class ProductosUsuario
    Private persona As Usuario
    Dim MenuPrincipal As ConfigPrincipal

    Public Sub New(CargaMenuPrincipal As ConfigPrincipal, persona As Usuario)
        InitializeComponent()
        Me.persona = persona
        Me.MenuPrincipal = CargaMenuPrincipal
    End Sub
    Private Sub BotonAceptar_Click(sender As Object, e As RoutedEventArgs) Handles BotonAceptar.Click
        crearProducto()
    End Sub

    Private Sub crearProducto()
        Dim productoNuevo As New Producto(-1, persona, NombreText.Text, DescripcionText.Text, "Default.jpg", Date.Now, PrecioText.Text, Nothing)
        productoNuevo.Cant = Convert.ToInt32(StockText.Text)

        DAOProductos.insertarProducto(productoNuevo)
        MenuPrincipal.CargaElemento(New ProductosUsuario(MenuPrincipal, persona))
        MsgBox("Producto insertado")
    End Sub
End Class
