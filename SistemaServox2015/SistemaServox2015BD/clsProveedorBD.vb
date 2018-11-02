Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports pryUtil.clsUtil
Imports SistemaServox2015BN


Public Class clsProveedorBD
    Inherits clsProveedorBN
    Private db As Database = EnterpriseLibraryContainer.Current.GetInstance(Of Database)()

#Region "Mantenimiento Básico"
    Function fncRegistrarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_I_srvPRVpProveedor")
            db.AddInParameter(Comando, "@PRVruc", DbType.String, PRVruc)
            db.AddInParameter(Comando, "@PRVnombre", DbType.String, PRVnombre)
            db.AddInParameter(Comando, "@PRVdireccion", DbType.String, PRVdireccion)
            db.AddInParameter(Comando, "@PRVtelefonofijo", DbType.String, PRVtelefonofijo)
            db.AddInParameter(Comando, "@PRVtelefonomovil", DbType.String, PRVtelefonomovil)
            db.AddInParameter(Comando, "@PRVemail", DbType.String, PRVemail)
            db.AddInParameter(Comando, "@PRVfecharegistro", DbType.DateTime, PRVfecharegistro)
            db.AddInParameter(Comando, "@PRVobservacion", DbType.String, PRVobservacion)
            db.AddInParameter(Comando, "@PRVimagen", DbType.Binary, ConvertirImagen2Bytes(PRVimagen))
            db.AddOutParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@DocumentoIdentidad", DbType.String, DocumentoIdentidad)
            db.AddInParameter(Comando, "@Tipo", DbType.String, Tipo)
            rs = db.ExecuteNonQuery(Comando)
            IdProveedor = db.GetParameterValue(Comando, "@IdProveedor")
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_U_srvPRVpProveedor")
            db.AddInParameter(Comando, "@PRVruc", DbType.String, PRVruc)
            db.AddInParameter(Comando, "@PRVnombre", DbType.String, PRVnombre)
            db.AddInParameter(Comando, "@PRVdireccion", DbType.String, PRVdireccion)
            db.AddInParameter(Comando, "@PRVtelefonofijo", DbType.String, PRVtelefonofijo)
            db.AddInParameter(Comando, "@PRVtelefonomovil", DbType.String, PRVtelefonomovil)
            db.AddInParameter(Comando, "@PRVemail", DbType.String, PRVemail)
            db.AddInParameter(Comando, "@PRVfecharegistro", DbType.DateTime, PRVfecharegistro)
            db.AddInParameter(Comando, "@PRVobservacion", DbType.String, PRVobservacion)
            db.AddInParameter(Comando, "@PRVimagen", DbType.Binary, ConvertirImagen2Bytes(PRVimagen))
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@FechaModifica", DbType.DateTime, FechaModifica)
            db.AddInParameter(Comando, "@UsuarioRegistra", DbType.Int64, UsuarioRegistra)
            db.AddInParameter(Comando, "@UsuarioModifica", DbType.Int64, UsuarioModifica)
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@DocumentoIdentidad", DbType.String, DocumentoIdentidad)
            db.AddInParameter(Comando, "@Tipo", DbType.String, Tipo)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBD() As Integer
        Dim rs As Integer = -1
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_D_srvPRVpProveedor")
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            rs = db.ExecuteNonQuery(Comando)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBD( _
    Optional IdProveedor As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Pln_S_srvPRVpProveedor")
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Pln_S_srvPRVpProveedor"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



#End Region


    Public Function fncusp_Srv_ListarProveedoresPorCamposBD( _
Optional ByVal DocumentoIdentidad As String = "" _
, Optional ByVal IdProveedor As Integer = -1 _
, Optional ByVal Estado As Integer = -1 _
, Optional ByVal Nombre As String = "" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_ListarProveedoresPorCampos")
            db.AddInParameter(Comando, "@DocumentoIdentidad", DbType.String, DocumentoIdentidad)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Estado", DbType.Int64, Estado)
            db.AddInParameter(Comando, "@Nombre", DbType.String, Nombre)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_ListarProveedoresPorCampos"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_ValidaDocumentoExistenteProveedorBD( _
Optional IdTipoDocumentoIdentidad As Integer = -1 _
, Optional NumeroDocumento As String = "" _
, Optional IdProveedor As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_ValidaDocumentoExistenteProveedor")
            db.AddInParameter(Comando, "@IdTipoDocumentoIdentidad", DbType.Int64, IdTipoDocumentoIdentidad)
            db.AddInParameter(Comando, "@NumeroDocumento", DbType.String, NumeroDocumento)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_ValidaDocumentoExistenteProveedor"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



    Public Function fncusp_Srv_HistorialDeComprasBD( _
Optional CodigoProducto As String = "" _
, Optional IdProveedor As Integer = -1 _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_Srv_HistorialDeCompras")
            db.AddInParameter(Comando, "@CodigoProducto", DbType.String, CodigoProducto)
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_Srv_HistorialDeCompras"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_srv_ReporteHistorialProveedorBD( _
    Optional IdProveedor As Integer = -1 _
    , Optional Mes As Integer = -1 _
    , Optional Anio As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ReporteHistorialProveedor")
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@Mes", DbType.Int64, Mes)
            db.AddInParameter(Comando, "@Anio", DbType.Int64, Anio)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ReporteHistorialProveedor"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncusp_srv_ReporteHistorialProveedorDosFechasBD( _
Optional IdProveedor As Integer = -1 _
, Optional FechaDesde As String = "1900-01-01" _
, Optional FechaHasta As String = "1900-01-01" _
) As DataTable
        Dim rs As New DataTable
        Try
            Dim Comando As Common.DbCommand = db.GetStoredProcCommand("usp_srv_ReporteHistorialProveedorDosFechas")
            db.AddInParameter(Comando, "@IdProveedor", DbType.Int64, IdProveedor)
            db.AddInParameter(Comando, "@FechaDesde", DbType.DateTime, FechaDesde)
            db.AddInParameter(Comando, "@FechaHasta", DbType.DateTime, FechaHasta)
            Dim Consulta As New DataSet
            db.LoadDataSet(Comando, Consulta, New String() {"usp_srv_ReporteHistorialProveedorDosFechas"})
            rs = Consulta.Tables(0)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




End Class
