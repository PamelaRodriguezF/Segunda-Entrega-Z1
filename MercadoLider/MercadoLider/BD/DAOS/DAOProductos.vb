Imports MySql.Data.MySqlClient

Public Class DAOProductos

    Private Shared ReadOnly INSERTAR_PRODUCTO As String = "INSERT INTO PRODUCTOS (ID_VENDEDOR, NOMBRE, DESCRIPCION, FOTO, FEC_PUBLICACION, PRECIO, STOCK, ACTIVO) VALUES (@vendedor, @nombre, @descr, @foto, @fecha, @precio, @stock, 1)"
    Private Shared ReadOnly BUSCAR_PRODUCTO As String = "SELECT P.ID, P.NOMBRE, P.DESCRIPCION, P.FOTO, P.FEC_PUBLICACION, P.PRECIO , P.STOCK FROM PRODUCTOS P INNER JOIN VENDEDORES V ON V.ID = P.ID_VENDEDOR WHERE V.ID_USUARIO = @vendedor AND P.ACTIVO = 1"

    Private Shared ReadOnly BUSCAR_VENTAS_POR_VENDEDOR As String = "SELECT P.ID, P.NOMBRE, P.DESCRIPCION, P.FOTO, P.FEC_PUBLICACION, V.PRECIO, V.CANTIDAD FROM VENTAS V INNER JOIN PRODUCTOS P ON P.ID = V.ID_PRODUCTO INNER JOIN VENDEDORES VD ON P.ID_VENDEDOR = VD.ID WHERE VD.ID_USUARIO = @vendedor;"
    Private Shared ReadOnly BUSCAR_VENTAS_POR_COMPRADOR As String = "SELECT P.ID, P.NOMBRE, P.DESCRIPCION, P.FOTO, P.FEC_PUBLICACION, V.PRECIO, V.CANTIDAD FROM VENTAS V INNER JOIN PRODUCTOS P ON P.ID = V.ID_PRODUCTO INNER JOIN COMPRADORES CP ON V.ID_COMPRADOR = CP.ID WHERE CP.ID_USUARIO = @comprador;"



    Public Shared Function encontrarPorNombre(nombre As String)
        Dim listaProductos As New List(Of Producto)

        Dim datosQuery(,) = New String(,) {
            {"@busqueda", nombre}
        }

        'Se hace esto debido a un problema de compatibilidad entre la asignacion de parametros y el operador LIKE de MySql, hasta que se enceuntre una solucion factible
        Dim Query As String = "SELECT P.ID, V.ID, V.NOMBRE, V.IMAGEN, V.TELEFONO, P.NOMBRE, P.DESCRIPCION, P.FOTO, P.FEC_PUBLICACION, P.PRECIO FROM PRODUCTOS P INNER JOIN USUARIOS V ON V.ID = P.ID_VENDEDOR WHERE P.NOMBRE LIKE '%" + nombre + "%'"


        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(Query, datosQuery)

        While reader.Read()
            Dim vendedorProducto As New Usuario(reader.GetInt32(1), reader.GetString(2), reader.GetString(3), Nothing, reader.GetString(4))

            Dim nuevoProducto As New Producto(reader.GetInt32(0), vendedorProducto, reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetDateTime(8), reader.GetInt32(9), Nothing)

            listaProductos.Add(nuevoProducto)
        End While

        reader.Close()

        Return listaProductos
    End Function

    Public Shared Function encontrarStockPorVendedor(persona As Usuario)
        Dim listaProductos As New List(Of Producto)

        Dim datosQuery(,) = New String(,) {
            {"@vendedor", persona.Id.ToString}
        }

        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(BUSCAR_PRODUCTO, datosQuery)

        While reader.Read()

            Dim nuevoProducto As New Producto(reader.GetInt32(0), persona, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetInt32(5), Nothing) With {
                .Cant = reader.GetInt32(6)
            }

            listaProductos.Add(nuevoProducto)
        End While

        reader.Close()

        Return listaProductos
    End Function

    Public Shared Function encontrarVentasVendedor(persona As Usuario)
        Dim listaProductos As New List(Of Producto)

        Dim datosQuery(,) = New String(,) {
            {"@vendedor", persona.Id.ToString}
        }

        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(BUSCAR_VENTAS_POR_VENDEDOR, datosQuery)

        While reader.Read()

            Dim nuevoProducto As New Producto(reader.GetInt32(0), persona, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetInt32(5), Nothing) With {
                .Cant = reader.GetInt32(6)
            }

            listaProductos.Add(nuevoProducto)
        End While

        reader.Close()

        Return listaProductos
    End Function
    Public Shared Function encontrarVentasComprador(persona As Usuario)
        Dim listaProductos As New List(Of Producto)

        Dim datosQuery(,) = New String(,) {
            {"@comprador", persona.Id.ToString}
        }

        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(BUSCAR_VENTAS_POR_COMPRADOR, datosQuery)

        While reader.Read()

            Dim nuevoProducto As New Producto(reader.GetInt32(0), persona, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetInt32(5), Nothing) With {
                .Cant = reader.GetInt32(6)
            }

            listaProductos.Add(nuevoProducto)
        End While

        reader.Close()

        Return listaProductos
    End Function

    Friend Shared Sub insertarProducto(nuevoProducto As Producto)
        Dim datosQuery(,) = New String(,) {
            {"@vendedor", nuevoProducto.Vendedor.Id.ToString},
            {"@nombre", nuevoProducto.Nombre.ToString},
            {"@descr", nuevoProducto.Descripcion.ToString},
            {"@foto", nuevoProducto.Foto.ToString},
            {"@fecha", nuevoProducto.FechaPublicacion.Year.ToString + "-" + nuevoProducto.FechaPublicacion.Month.ToString + "-" + nuevoProducto.FechaPublicacion.Day.ToString},
            {"@precio", nuevoProducto.Precio.ToString},
            {"@stock", nuevoProducto.Cant.ToString}
        }

        DAOUtilidades.insertarConParametros(INSERTAR_PRODUCTO, datosQuery)
    End Sub
End Class
