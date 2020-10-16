Public Class Producto
    'Datos
    Private IdProducto As Integer
    Private VendedorProducto As Usuario
    Private NombreProducto As String
    Private DescripcionProducto As String
    Private FotoProducto As String
    Private FechaPublicacionProducto As Date
    Private PrecioProducto As Integer
    Private CantProducto As Integer
    'Multimedia
    Private galeriaProducto As List(Of String)

    Public Sub New(id As Integer, vendedor As Usuario, nombre As String, descripcion As String, foto As String, fechaPublicacion As Date, precio As Integer, galeria As List(Of String))
        Me.Id = id
        Me.Vendedor = vendedor
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Foto = foto
        Me.FechaPublicacion = fechaPublicacion
        Me.Precio = precio
        Me.Galeria = galeria
    End Sub

    'Encapsulamiento
    Public Property Id As Integer
        Get
            Return IdProducto
        End Get
        Set(value As Integer)
            IdProducto = value
        End Set
    End Property

    Public Property Vendedor As Usuario
        Get
            Return VendedorProducto
        End Get
        Set(value As Usuario)
            VendedorProducto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return NombreProducto
        End Get
        Set(value As String)
            NombreProducto = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return DescripcionProducto
        End Get
        Set(value As String)
            DescripcionProducto = value
        End Set
    End Property

    Public Property Foto As String
        Get
            Return FotoProducto
        End Get
        Set(value As String)
            FotoProducto = value
        End Set
    End Property

    Public Property FechaPublicacion As Date
        Get
            Return FechaPublicacionProducto
        End Get
        Set(value As Date)
            FechaPublicacionProducto = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return PrecioProducto
        End Get
        Set(value As Integer)
            PrecioProducto = value
        End Set
    End Property

    Public Property Galeria As List(Of String)
        Get
            Return galeriaProducto
        End Get
        Set(value As List(Of String))
            galeriaProducto = value
        End Set
    End Property

    Public Property Cant As Integer
        Get
            Return CantProducto
        End Get
        Set(value As Integer)
            CantProducto = value
        End Set
    End Property
End Class
