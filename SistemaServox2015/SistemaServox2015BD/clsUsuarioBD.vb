Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsUsuarioBD
    Inherits clsUsuarioBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_Usuario")
            db.AddOutParameter(Comando, "@IdUsuario", DbType.Int64, IdUsuario)
            db.AddInParameter(Comando, "@Nombre", DbType.String, Nombre)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaRegistro", DbType.DateTime, FechaRegistro)
            db.AddInParameter(Comando, "@Clave", DbType.String, Clave)
            rs = db.ExecuteNonQuery(Comando)
            IdUsuario = db.GetParameterValue(Comando, "@IdUsuario")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_Usuario")
            db.AddInParameter(Comando, "@IdUsuario", DbType.Int64, IdUsuario)
            db.AddInParameter(Comando, "@Nombre", DbType.String, Nombre)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaRegistro", DbType.DateTime, FechaRegistro)
            db.AddInParameter(Comando, "@Clave", DbType.String, Clave)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncBackUpDataBaseBD(ByVal strNombreArchivo As String) As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_BackUpDataBase")
            db.AddInParameter(Comando, "@NombreArchivo", DbType.String, strNombreArchivo)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function








    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_Usuario")
            db.AddInParameter(Comando, "@IdUsuario", DbType.Int64, IdUsuario)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdUsuario As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_Usuario")
            db.AddInParameter(Comando, "@IdUsuario", DbType.Int64, IdUsuario)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_Usuario"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_ListarUsuariosBD( _
Optional IdUsuario As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ListarUsuarios")
            db.AddInParameter(Comando, "@IdUsuario", DbType.Int64, IdUsuario)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ListarUsuarios"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




#End Region
End Class
