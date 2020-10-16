Public Class Ajustes

    Sub New(persona As Usuario)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BotonInicio_Click(sender As Object, e As RoutedEventArgs) Handles BotonInicio.Click
        Dim MenuCarga As New MenuPrincipal(Nothing)
        MenuCarga.Show()

        Me.Hide()
        Me.Close()
    End Sub

    Private Sub BotonInicio_Copy_Click(sender As Object, e As RoutedEventArgs) Handles BotonInicio_Copy.Click
        Dim MenuCarga As New MenuPrincipal(Nothing)
        MenuCarga.Show()

        Me.Hide()
        Me.Close()
    End Sub

    Private Sub CanvasLoginCerrar_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles CanvasLoginCerrar.MouseLeftButtonUp
        Me.Close()
    End Sub
End Class
