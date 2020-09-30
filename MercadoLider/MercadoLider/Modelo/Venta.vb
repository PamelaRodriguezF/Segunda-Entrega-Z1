Public Class Venta
    Private IdVenta As String
    Private CompradorVenta As Usuario
    Private ProductoVenta As Producto
    Private PrecioVenta As Integer
    Private CantidadVenta As Integer
    Private FechaVenta As Date

    Public Sub New(id As String, comprador As Usuario, producto As Producto, precio As Integer, cantidad As Integer, fecha As Date)
        Me.Id = id
        Me.Comprador = comprador
        Me.Producto = producto
        Me.Precio = precio
        Me.Cantidad = cantidad
        Me.Fecha = fecha
    End Sub

    Public Property Id As String
        Get
            Return IdVenta
        End Get
        Set(value As String)
            IdVenta = value
        End Set
    End Property

    Public Property Comprador As Usuario
        Get
            Return CompradorVenta
        End Get
        Set(value As Usuario)
            CompradorVenta = value
        End Set
    End Property

    Public Property Producto As Producto
        Get
            Return ProductoVenta
        End Get
        Set(value As Producto)
            ProductoVenta = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return PrecioVenta
        End Get
        Set(value As Integer)
            PrecioVenta = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return CantidadVenta
        End Get
        Set(value As Integer)
            CantidadVenta = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return FechaVenta
        End Get
        Set(value As Date)
            FechaVenta = value
        End Set
    End Property
End Class
