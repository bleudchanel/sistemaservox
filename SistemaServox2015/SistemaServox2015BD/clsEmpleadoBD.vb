Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsEmpleadoBD
    Inherits clsEmpleadoBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srv_Empleado")
            db.AddOutParameter(Comando, "@IdEmpleado", DbType.Int64, IdEmpleado)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@Apellidos", DbType.String, Apellidos)
            db.AddInParameter(Comando, "@Nombres", DbType.String, Nombres)
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@NumeroDocumento", DbType.String, NumeroDocumento)
            db.AddInParameter(Comando, "@FechaRegistro", DbType.DateTime, FechaRegistro)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            rs = db.ExecuteNonQuery(Comando)
            IdEmpleado = db.GetParameterValue(Comando, "@IdEmpleado")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srv_Empleado")
            db.AddInParameter(Comando, "@IdEmpleado", DbType.Int64, IdEmpleado)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@Apellidos", DbType.String, Apellidos)
            db.AddInParameter(Comando, "@Nombres", DbType.String, Nombres)
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@NumeroDocumento", DbType.String, NumeroDocumento)
            db.AddInParameter(Comando, "@FechaRegistro", DbType.DateTime, FechaRegistro)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srv_Empleado")
            db.AddInParameter(Comando, "@IdEmpleado", DbType.Int64, IdEmpleado)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdEmpleado As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srv_Empleado")
            db.AddInParameter(Comando, "@IdEmpleado", DbType.Int64, IdEmpleado)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srv_Empleado"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region


    Public Function fncusp_srv_ListarEmpleadosPorCampoBD( _
Optional IdEmpleado As Integer = -1 _
, Optional Nombre As String = "" _
, Optional DNI As String = "" _
, Optional Estado As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ListarEmpleadosPorCampo")
            db.AddInParameter(Comando, "@IdEmpleado", DbType.Int64, IdEmpleado)
            db.AddInParameter(Comando, "@Nombre", DbType.String, Nombre)
            db.AddInParameter(Comando, "@DNI", DbType.String, DNI)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ListarEmpleadosPorCampo"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_HistorialEmpleadoBD( _
    Optional IdEmpleado As Integer = -1 _
    , Optional Mes As Integer = -1 _
    , Optional Anio As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_HistorialEmpleado")
            db.AddInParameter(Comando, "@IdEmpleado", DbType.Int64, IdEmpleado)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_HistorialEmpleado"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





End Class
