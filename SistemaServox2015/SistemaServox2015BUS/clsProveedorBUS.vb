Imports SistemaServox2015BD
Imports pryUtil.clsUtil


Public Class clsProveedorBUS
    Inherits clsProveedorBD

#Region "Mantenimiento Básico"
    Function fncRegistrarBUS() As Integer
        Dim rs As Integer = -1
        Try
            Return fncRegistrarBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncModificarBUS() As Integer
        Dim rs As Integer = -1
        Try
            Return fncModificarBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Function fncEliminarBUS() As Integer
        Dim rs As Integer = -1
        Try
            Return fncEliminarBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConsultarBUS( _
    Optional ByVal IdProveedor As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdProveedor _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            PRVruc = ObtenerValorCelda(Registro, "PRVruc")
            PRVnombre = ObtenerValorCelda(Registro, "PRVnombre")
            PRVdireccion = ObtenerValorCelda(Registro, "PRVdireccion")
            PRVtelefonofijo = ObtenerValorCelda(Registro, "PRVtelefonofijo")
            PRVtelefonomovil = ObtenerValorCelda(Registro, "PRVtelefonomovil")
            PRVemail = ObtenerValorCelda(Registro, "PRVemail")
            PRVfecharegistro = ObtenerValorCelda(Registro, "PRVfecharegistro")
            PRVobservacion = ObtenerValorCelda(Registro, "PRVobservacion")
            PRVimagen = ConvertirBytes2Imagen(ObtenerValorCelda(Registro, "PRVimagen"))
            IdProveedor = ObtenerValorCelda(Registro, "IdProveedor")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
            IdTipoDocumentoIdentidad = ObtenerValorCelda(Registro, "IdTipoDocumentoIdentidad")
            DocumentoIdentidad = ObtenerValorCelda(Registro, "DocumentoIdentidad")
            Tipo = ObtenerValorCelda(Registro, "Tipo")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub
#End Region

#Region "Constructores"
    Public Sub New()

    End Sub

    Public Sub New(strPRVruc As String,
        strPRVnombre As String,
        strPRVdireccion As String,
        strPRVtelefonofijo As String,
        strPRVtelefonomovil As String,
        strPRVemail As String,
        datePRVfecharegistro As Date,
        strPRVobservacion As String,
        intIdProveedor As Integer,
        intEstado As Integer,
        dateFechaModifica As Date,
        intUsuarioRegistra As Integer,
        intIdTipoDocumentoIdentidad As Integer,
        strDocumentoIdentidad As String,
        strTipo As String)

        PRVruc = strPRVruc
        PRVnombre = strPRVnombre
        PRVdireccion = strPRVdireccion
        PRVtelefonofijo = strPRVtelefonofijo
        PRVtelefonomovil = strPRVtelefonomovil
        PRVemail = strPRVemail
        PRVfecharegistro = datePRVfecharegistro
        PRVobservacion = strPRVobservacion
        PRVimagen = DBNull.Value
        IdProveedor = intIdProveedor
        Estado = intEstado
        FechaModifica = dateFechaModifica
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioRegistra
        IdTipoDocumentoIdentidad = intIdTipoDocumentoIdentidad
        DocumentoIdentidad = strDocumentoIdentidad
        Tipo = strTipo

    End Sub



#End Region

    Public Function fncListarProveedoresPorCamposBUS( _
 Optional ByVal DocumentoIdentidad As String = "" _
 , Optional ByVal IdProveedor As Integer = -1 _
 , Optional ByVal Estado As Integer = -1 _
 , Optional ByVal Nombre As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Srv_ListarProveedoresPorCamposBD( _
            DocumentoIdentidad _
            , IdProveedor _
            , Estado _
            , Nombre _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncHistorialDeComprasBUS( _
 Optional CodigoProducto As String = "" _
 , Optional IdProveedor As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Srv_HistorialDeComprasBD( _
            CodigoProducto _
            , IdProveedor _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncValidaDocumentoExistenteProveedorBUS( _
 Optional IdTipoDocumentoIdentidad As Integer = -1 _
 , Optional NumeroDocumento As String = "" _
 , Optional IdProveedor As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaDocumentoExistenteProveedorBD( _
            IdTipoDocumentoIdentidad _
            , NumeroDocumento _
            , IdProveedor _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncValidaDocumento(ByVal intIdTipoDocumento As Integer, ByVal strNumeroDocumento As String, Optional ByVal intIdProveedor As Integer = -1) As Boolean
        Return fncValidaDataTable(fncValidaDocumentoExistenteProveedorBUS(intIdTipoDocumento, strNumeroDocumento, intIdProveedor))
    End Function



    Public Function fncHistorialDeCompras(Optional ByVal IdProveedor As Integer = -1) As DataTable
        Dim dtHistorial As New DataTable
        dtHistorial = fncHistorialDeComprasBUS("", IdProveedor)
        If fncValidaDataTable(dtHistorial) Then

        End If

        Return dtHistorial
    End Function

    Public Function fncReporteHistorialProveedorBUS( _
  Optional IdProveedor As Integer = -1 _
  , Optional Mes As Integer = -1 _
  , Optional Anio As Integer = -1 _
  ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ReporteHistorialProveedorBD( _
            IdProveedor _
            , Mes _
            , Anio _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncReporteHistorialProveedorDosFechasBUS( _
 Optional IdProveedor As Integer = -1 _
 , Optional FechaDesde As String = "1900-01-01" _
 , Optional FechaHasta As String = "1900-01-01" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ReporteHistorialProveedorDosFechasBD( _
            IdProveedor _
            , FechaDesde _
            , FechaHasta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





End Class
