Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class clsSeg_IncidenciaBD
    Inherits clsSeg_IncidenciaBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Basico"

    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Seg_I_Incidencia")
            db.AddInParameter(Comando, "@CodigoError", DbType.String, CodigoError)
            db.AddInParameter(Comando, "@Mensaje", DbType.String, Mensaje)
            db.AddInParameter(Comando, "@IP", DbType.String, IP)
            db.AddInParameter(Comando, "@MAC", DbType.String, MAC)
            db.AddInParameter(Comando, "@Usuario", DbType.String, Usuario)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region
    Public Function fncConsultarFechaHoraServidorBD( _
   ) As DateTime
        Dim rs As DateTime = DateTime.Now

        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("USP_PEN_S_MOSTRARFECHAHORASERVIDOR")
            db.AddOutParameter(Comando, "@FechaHoraServidor", DbType.DateTime, 0)
            db.ExecuteNonQuery(Comando)
            rs = db.GetParameterValue(Comando, "@FechaHoraServidor")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_Co2_S_Co2_mmObtenerNewIdfuenteBD( _
 ByVal Anio As Integer _
 ) As Object
        Dim rs As Object = Nothing
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Co2_S_Co2_mmObtenerNewIdfuente")
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            rs = db.ExecuteScalar(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class

