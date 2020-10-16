Public Class Inicio
    Public Sub New()
        InitializeComponent()

        CargarLogin()
    End Sub

    Public Sub New(coso As Boolean)
        InitializeComponent()

        CargbarAdmin()
    End Sub

    Public Sub CargarLogin()
        Dim LogUsuario As New Login(Me)
        CargaPagina.Navigate(LogUsuario)
    End Sub
    Public Sub CargarRegistro()
        Dim RegUsuario As New Registro1(Me)
        CargaPagina.Navigate(RegUsuario)
    End Sub

    Public Sub CargbarAdmin()
        Dim InicioAdmin As New AdminInicio(Me)
        CargaPagina.Navigate(InicioAdmin)
    End Sub

    Private Sub LabelAbrirRegistro_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles LabelAbrirRegistro.MouseLeftButtonUp
        If LabelAbrirRegistro.Content.Equals("Únete Aquí!") Then
            CargarRegistro()

            LabelDescAbrirRegistro.Content = "Ya tienes una cuenta?"
            LabelAbrirRegistro.Content = "Ve Aquí"
        Else
            CargarLogin()
            LabelDescAbrirRegistro.Content = "Aún no te has registrado?"
            LabelAbrirRegistro.Content = "Únete Aquí!"
        End If
    End Sub

    Private Sub CanvasLoginCerrar_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles CanvasLoginCerrar.MouseLeftButtonUp
        Me.Close()
    End Sub
End Class
