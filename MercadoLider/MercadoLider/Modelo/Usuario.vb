Public Class Usuario
    'Datos
    Private idUsuario As Integer
    Private mailUsuario As String
    Private claveUsuario As String
    Private nombreUsuario As String
    Private apellidoUsuario As String
    Private imagenUsuario As String
    Private direccionesUsuario As List(Of String)
    Private telefonoUsuario As String

    'Permisos
    Private compradorUsuario As Boolean
    Private vendedorUsuario As Boolean
    Private administradorUsuario As Boolean

    Public Sub New(id As Integer, mail As String, clave As String, nombre As String, apellido As String, imagen As String, direcciones As List(Of String), telefono As String, comprador As Boolean, vendedor As Boolean, administrador As Boolean)
        Me.Id = id
        Me.Mail = mail
        Me.Clave = clave
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Imagen = imagen
        Me.Direcciones = direcciones
        Me.Telefono = telefono
        Me.Comprador = comprador
        Me.Vendedor = vendedor
        Me.Administrador = administrador
    End Sub

    Public Sub New(id As Integer, nombre As String, imagen As String, direcciones As List(Of String), telefono As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Imagen = imagen
        Me.Direcciones = direcciones
        Me.Telefono = telefono
        Me.Comprador = False
        Me.Vendedor = True
        Me.Administrador = False
    End Sub


    'Encapsulamiento
    Public Property Id As Integer
        Get
            Return idUsuario
        End Get
        Set(value As Integer)
            idUsuario = value
        End Set
    End Property

    Public Property Mail As String
        Get
            Return mailUsuario
        End Get
        Set(value As String)
            mailUsuario = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return claveUsuario
        End Get
        Set(value As String)
            claveUsuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return apellidoUsuario
        End Get
        Set(value As String)
            apellidoUsuario = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return imagenUsuario
        End Get
        Set(value As String)
            imagenUsuario = value
        End Set
    End Property

    Public Property Direcciones As List(Of String)
        Get
            Return direccionesUsuario
        End Get
        Set(value As List(Of String))
            direccionesUsuario = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return telefonoUsuario
        End Get
        Set(value As String)
            telefonoUsuario = value
        End Set
    End Property

    Public Property Comprador As Boolean
        Get
            Return compradorUsuario
        End Get
        Set(value As Boolean)
            compradorUsuario = value
        End Set
    End Property

    Public Property Vendedor As Boolean
        Get
            Return vendedorUsuario
        End Get
        Set(value As Boolean)
            vendedorUsuario = value
        End Set
    End Property

    Public Property Administrador As Boolean
        Get
            Return administradorUsuario
        End Get
        Set(value As Boolean)
            administradorUsuario = value
        End Set
    End Property
End Class
