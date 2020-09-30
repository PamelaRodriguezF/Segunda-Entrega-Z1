Class ProductosUsuario
    Private persona As Usuario
    Public Sub New(persona As Usuario)
        InitializeComponent()
        Me.persona = persona
    End Sub
    Private Sub BotonAceptar_Click(sender As Object, e As RoutedEventArgs) Handles BotonAceptar.Click
        crearProducto()
    End Sub

    Private Sub crearProducto()
        Dim productoNuevo As New Producto(-1, persona, NombreText.Text, DescripcionText.Text, "Default.jpg", Date.Now, PrecioText.Text, Nothing)

        DAOProductos.insertarProducto(productoNuevo)

        MsgBox("Producto insertado")
    End Sub
End Class
