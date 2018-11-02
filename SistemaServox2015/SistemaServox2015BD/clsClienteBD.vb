Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN

Public Class clsClienteBD
    Inherits clsClienteBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srvCLIpCliente")
            db.AddInParameter(Comando, "@CLIruc", DbType.String, CLIruc)
            db.AddInParameter(Comando, "@CLInombre", DbType.String, CLInombre)
            db.AddInParameter(Comando, "@CLIdireccion", DbType.String, CLIdireccion)
            db.AddInParameter(Comando, "@CLItelefonofijo", DbType.String, CLItelefonofijo)
            db.AddInParameter(Comando, "@CLItelefonomovil", DbType.String, CLItelefonomovil)
            db.AddInParameter(Comando, "@CLIemail", DbType.String, CLIemail)
            db.AddInParameter(Comando, "@CLIfecharegistro", DbType.DateTime, CLIfecharegistro)
            db.AddInParameter(Comando, "@CLIobservacion", DbType.String, CLIobservacion)
            db.AddOutParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@Imagen", DbType.Binary, ConvertirImagen2Bytes(Imagen))
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@DocumentoIdentidad", DbType.String, DocumentoIdentidad)
            rs = db.ExecuteNonQuery(Comando)
            IdCliente = db.GetParameterValue(Comando, "@IdCliente")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srvCLIpCliente")
            db.AddInParameter(Comando, "@CLIruc", DbType.String, CLIruc)
            db.AddInParameter(Comando, "@CLInombre", DbType.String, CLInombre)
            db.AddInParameter(Comando, "@CLIdireccion", DbType.String, CLIdireccion)
            db.AddInParameter(Comando, "@CLItelefonofijo", DbType.String, CLItelefonofijo)
            db.AddInParameter(Comando, "@CLItelefonomovil", DbType.String, CLItelefonomovil)
            db.AddInParameter(Comando, "@CLIemail", DbType.String, CLIemail)
            db.AddInParameter(Comando, "@CLIfecharegistro", DbType.DateTime, CLIfecharegistro)
            db.AddInParameter(Comando, "@CLIobservacion", DbType.String, CLIobservacion)
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@Imagen", DbType.Binary, ConvertirImagen2Bytes(Imagen))
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@DocumentoIdentidad", DbType.String, DocumentoIdentidad)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srvCLIpCliente")
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional ByVal IdCliente As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srvCLIpCliente")
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srvCLIpCliente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




#End Region

    Public Function fncusp_Srv_ListarClientesPorCamposBD( _
 Optional ByVal DocumentoIdentidad As String = "" _
 , Optional ByVal IdCliente As Integer = -1 _
 , Optional ByVal Estado As Integer = -1 _
 , Optional ByVal Nombre As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_ListarClientesPorCampos")
            db.AddInParameter(Comando, "@DocumentoIdentidad", DbType.String, DocumentoIdentidad)
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@Nombre", DbType.String, Nombre)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_ListarClientesPorCampos"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_ValidaDocumentoExistenteClienteBD( _
Optional IdTipoDocumentoIdentidad As Integer = -1 _
, Optional NumeroDocumento As String = "" _
, Optional IdCliente As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaDocumentoExistenteCliente")
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@NumeroDocumento", DbType.String, NumeroDocumento)
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaDocumentoExistenteCliente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_srv_ReporteHistorialClienteBD( _
    Optional IdCliente As Integer = -1 _
    , Optional FechaDesde As String = "1900-01-01" _
    , Optional FechaHasta As String = "1900-01-01" _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ReporteHistorialCliente")
            db.AddInParameter(Comando, "@IdCliente", DbType.Int64, IdCliente)
            db.AddInParameter(Comando, "@FechaDesde", DbType.DateTime, FechaDesde)
            db.AddInParameter(Comando, "@FechaHasta", DbType.DateTime, FechaHasta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ReporteHistorialCliente"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





End Class
