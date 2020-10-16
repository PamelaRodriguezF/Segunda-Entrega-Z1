Imports MySql.Data.MySqlClient

Public NotInheritable Class DataBaseManager

    Private Shared ReadOnly DBManager As New Lazy(Of DataBaseManager)(Function() New DataBaseManager(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)
    Private Shared conexionBD As MySqlConnection

    Private Sub New()
    End Sub

    Shared Sub New()
        Dim StringConexion As String = "server=localhost;database=MercadoLider;uid=root;pwd=root;"

        Conexion = New MySqlConnection(StringConexion)

        Conexion.Open()

        Dim cmd As New MySqlCommand("USE MERCADOLIDER", Conexion)

        cmd.ExecuteNonQuery()
    End Sub


    Public Shared Property Conexion As MySqlConnection
        Get
            Return conexionBD
        End Get
        Set(value As MySqlConnection)
            conexionBD = value
        End Set
    End Property

    Public Shared ReadOnly Property BDManager As Lazy(Of DataBaseManager)
        Get
            Return DBManager
        End Get
    End Property
End Class
