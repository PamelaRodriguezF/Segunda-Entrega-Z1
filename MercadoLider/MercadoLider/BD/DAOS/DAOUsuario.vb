Imports MySql.Data.MySqlClient

Public Class DAOUsuario

    Private Shared ReadOnly ENCONTRAR_USUARIO As String = "SELECT U.ID, U.MAIL, U.CLAVE, U.NOMBRE, U.APELLIDO, U.IMAGEN, U.TELEFONO FROM USUARIOS U WHERE (U.MAIL = @mail AND U.CLAVE = @clave) AND U.ACTIVO = 1"
    Private Shared ReadOnly ENCONTRAR_DIRECCIONES As String = "SELECT DU.DIRECCION FROM DIRECCION_USUARIO DU INNER JOIN USUARIOS P ON P.ID = DU.ID_USUARIO WHERE P.ID = @usuario"
    Private Shared ReadOnly ELIMINAR_USUARIO As String = "UPDATE USUARIOS SET ACTIVO = '0' WHERE (ID = @usuario)"
    Private Shared ReadOnly EDITAR_USUARIO As String = "UPDATE USUARIOS SET MAIL = @mail, CLAVE = @clave, NOMBRE = @nombre, APELLIDO = @apellido, IMAGEN = @imagen, TELEFONO = @telefono WHERE (ID = @usuario)"
    Private Shared ReadOnly EDITAR_DIRECCIONES As String = "UPDATE USUARIOS SET MAIL = @mail, CLAVE = @clave, NOMBRE = @nombre, APELLIDO = @apellido, IMAGEN = @imagen, TELEFONO = @telefono WHERE (ID = @usuario)"
    Private Shared ReadOnly INSERTAR_USUARIO As String = "INSERT INTO USUARIOS (MAIL, CLAVE, NOMBRE, APELLIDO, IMAGEN, TELEFONO) VALUES (@mail, @clave, @nombre, @apellido, @imagen, @telefono)"
    Private Shared ReadOnly INSERTAR_DIRECCION As String = "INSERT INTO DIRECCION_USUARIO (ID_USUARIO, DIRECCION) VALUES (@usuario, @direccion)"
    Private Shared ReadOnly MODIFICAR_DIRECCION As String = "UPDATE DIRECCION_USUARIO SET DIRECCION = @direccion WHERE (ID_USUARIO = @usuario AND DIRECCION = @viejadir)"
    'Chequear permisos
    Private Shared ReadOnly ES_COMPRADOR As String = "SELECT * FROM COMPRADORES WHERE ID_USUARIO = @usuario"
    Private Shared ReadOnly ES_VENDEDOR As String = "SELECT * FROM VENDEDORES WHERE ID_USUARIO = @usuario"
    Private Shared ReadOnly ES_ADIM As String = "SELECT * FROM ADMINISTRADORES WHERE ID_USUARIO = @usuario"

    'Asignar permisos
    Private Shared ReadOnly INSERTAR_COMPRADOR As String = "INSERT INTO COMPRADORES (ID_USUARIO) VALUES (@usuario)"
    Private Shared ReadOnly INSERTAR_VENDEDOR As String = "INSERT INTO VENDEDORES (ID_USUARIO, RUT) VALUES (@usuario, @rut)"
    Private Shared ReadOnly INSERTAR_ADIM As String = "INSERT INTO ADMINISTRADORES (ID_USUARIO) VALUES (@usuario)"

    Public Shared Function encontrarPersona(mail As String, clave As String)
        Dim persona As Usuario = Nothing
        Dim datosQuery(,) = New String(,) {
            {"@mail", mail},
            {"@clave", clave}
        }

        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(ENCONTRAR_USUARIO, datosQuery)

        While reader.Read()

            persona = New Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), Nothing, reader.GetString(6), False, False, False)

        End While

        reader.Close()

        Return persona
    End Function

    Public Shared Function encontrarDireccion(idPersona As String)
        Dim direcciones As New List(Of String)

        Dim datosQuery(,) = New String(,) {
            {"@usuario", idPersona}
        }

        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(ENCONTRAR_DIRECCIONES, datosQuery)

        While reader.Read()

            direcciones.Add(reader.GetString(0))

        End While

        reader.Close()

        Return direcciones
    End Function

    Public Shared Function esAdmin(idPersona As String)
        Dim admin As Boolean = False

        Dim datosQuery(,) = New String(,) {
            {"@usuario", idPersona}
        }

        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(ES_ADIM, datosQuery)

        If reader.HasRows Then
            admin = True
        End If

        reader.Close()

        Return admin
    End Function

    Public Shared Function esComprador(idPersona As String)
        Dim comprador As Boolean = False

        Dim datosQuery(,) = New String(,) {
            {"@usuario", idPersona}
        }

        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(ES_COMPRADOR, datosQuery)

        If reader.HasRows Then
            comprador = True
        End If

        reader.Close()

        Return comprador
    End Function

    Public Shared Function esVendedor(idPersona As String)
        Dim vendedor As Boolean = False

        Dim datosQuery(,) = New String(,) {
            {"@usuario", idPersona}
        }

        Dim reader As MySqlDataReader = DAOUtilidades.listarConParametros(ES_VENDEDOR, datosQuery)

        If reader.HasRows Then
            vendedor = True
        End If

        reader.Close()

        Return vendedor
    End Function

    Public Shared Sub borrarUsuario(id As String)

        Dim datosQuery(,) = New String(,) {
            {"@usuario", id}
        }

        DAOUtilidades.insertarConParametros(ELIMINAR_USUARIO, datosQuery)
    End Sub

    Public Shared Sub editarUsuario(persona As Usuario)

        Dim datosQuery(,) = New String(,) {
            {"@usuario", persona.Id},
            {"@mail", persona.Mail},
            {"@clave", persona.Clave},
            {"@nombre", persona.Nombre},
            {"@apellido", persona.Apellido},
            {"@imagen", persona.Imagen},
            {"@telefono", persona.Telefono}
        }

        DAOUtilidades.insertarConParametros(EDITAR_USUARIO, datosQuery)
    End Sub

    Public Shared Sub insertarUsuario(persona As Usuario)

        Dim datosQuery(,) = New String(,) {
            {"@mail", persona.Mail},
            {"@clave", persona.Clave},
            {"@nombre", persona.Nombre},
            {"@apellido", persona.Apellido},
            {"@imagen", persona.Imagen},
            {"@telefono", persona.Telefono}
        }

        DAOUtilidades.insertarConParametros(INSERTAR_USUARIO, datosQuery)
    End Sub

    Public Shared Sub insertarVendedor(id As String, rut As String)

        Dim datosQuery(,) = New String(,) {
            {"@usuario", id},
            {"@rut", rut}
        }

        DAOUtilidades.insertarConParametros(INSERTAR_VENDEDOR, datosQuery)
    End Sub

    Public Shared Sub insertarComprador(id As String)

        Dim datosQuery(,) = New String(,) {
            {"@usuario", id}
        }

        DAOUtilidades.insertarConParametros(INSERTAR_COMPRADOR, datosQuery)
    End Sub

    Public Shared Sub insertarAdmin(id As String)

        Dim datosQuery(,) = New String(,) {
            {"@usuario", id}
        }

        DAOUtilidades.insertarConParametros(INSERTAR_ADIM, datosQuery)
    End Sub

    Public Shared Sub insertarDireccion(id As String, direccion As String)

        Dim datosQuery(,) = New String(,) {
            {"@usuario", id},
            {"@direccion", direccion}
        }

        DAOUtilidades.insertarConParametros(INSERTAR_DIRECCION, datosQuery)
    End Sub

    Public Shared Sub editarDireccion(id As String, direccion As String, viejadir As String)

        Dim datosQuery(,) = New String(,) {
            {"@usuario", id},
            {"@viejadir", viejadir},
            {"@direccion", direccion}
        }

        DAOUtilidades.insertarConParametros(MODIFICAR_DIRECCION, datosQuery)
    End Sub
End Class
