Class VerFacturaUsuario
    Dim ConfigsPrincipal As ConfigPrincipal
    Private persona As Usuario

    Public Sub New(ConfigsPrincipal As ConfigPrincipal, persona As Usuario)
        InitializeComponent()
        Me.persona = persona
        Me.ConfigsPrincipal = ConfigsPrincipal
    End Sub


    Private Sub VerBoton_Click(sender As Object, e As RoutedEventArgs) Handles VerBoton.Click
        Dim Factura As New FacturasUsuario
        ConfigsPrincipal.CargaElementos.Navigate(Factura)
    End Sub
End Class
