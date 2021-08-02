Imports System.Data.Entity.Core
Imports System.Data.SqlClient

Public Class Conexion


    Public Shared Function sgnConexion() As String
        Dim conexion As New SqlClient.SqlConnectionStringBuilder
        conexion.DataSource = "JAPON"
        conexion.UserID = ""
        conexion.Password = ""
        conexion.PersistSecurityInfo = True

        Dim entityCSB As New EntityClient.EntityConnectionStringBuilder
        entityCSB.ProviderConnectionString = conexion.ToString

        Return entityCSB.ToString

    End Function


End Class

