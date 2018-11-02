Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsClienteBUS
    Inherits clsClienteBD

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
    Optional ByVal IdCliente As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdCliente _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            CLIruc = ObtenerValorCelda(Registro, "CLIruc")
            CLInombre = ObtenerValorCelda(Registro, "CLInombre")
            CLIdireccion = ObtenerValorCelda(Registro, "CLIdireccion")
            CLItelefonofijo = ObtenerValorCelda(Registro, "CLItelefonofijo")
            CLItelefonomovil = ObtenerValorCelda(Registro, "CLItelefonomovil")
            CLIemail = ObtenerValorCelda(Registro, "CLIemail")
            CLIfecharegistro = ObtenerValorCelda(Registro, "CLIfecharegistro")
            CLIobservacion = ObtenerValorCelda(Registro, "CLIobservacion")
            IdCliente = ObtenerValorCelda(Registro, "IdCliente")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
            Imagen = ConvertirBytes2Imagen(ObtenerValorCelda(Registro, "Imagen"))
            IdTipoDocumentoIdentidad = ObtenerValorCelda(Registro, "IdTipoDocumentoIdentidad")
            DocumentoIdentidad = ObtenerValorCelda(Registro, "DocumentoIdentidad")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub
#End Region

#Region "Constructores"
    Public Sub New()

    End Sub

    Public Sub New(strCLIruc As String,
                    strCLInombre As String,
                    strCLIdireccion As String,
                    strCLItelefonofijo As String,
                    strCLItelefonomovil As String,
                    strCLIemail As String,
                    dateCLIfecharegistro As Date,
                    strCLIobservacion As String,
                    intIdCliente As Integer,
                    intEstado As Integer,
                    intUsuarioRegistra As Integer,
                    intUsuarioModifica As Integer,
                    intIdTipoDocumentoIdentidad As Integer,
                    strDocumentoIdentidad As String)
        CLIruc = strCLIruc
        CLInombre = strCLInombre
        CLIdireccion = strCLIdireccion
        CLItelefonofijo = strCLItelefonofijo
        CLItelefonomovil = strCLItelefonomovil
        CLIemail = strCLIemail
        CLIfecharegistro = dateCLIfecharegistro
        CLIobservacion = strCLIobservacion
        IdCliente = intIdCliente
        Estado = intEstado
        FechaModifica = dateCLIfecharegistro
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioModifica
        Imagen = DBNull.Value
        IdTipoDocumentoIdentidad = intIdTipoDocumentoIdentidad
        DocumentoIdentidad = strDocumentoIdentidad


    End Sub

#End Region

    Public Function fncListarClientesPorCamposBUS( _
 Optional ByVal DocumentoIdentidad As String = "" _
 , Optional ByVal IdCliente As Integer = -1 _
 , Optional ByVal Estado As Integer = -1 _
 , Optional ByVal Nombre As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Srv_ListarClientesPorCamposBD( _
            DocumentoIdentidad _
            , IdCliente _
            , Estado _
            , Nombre _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncReporteHistorialClienteBUS( _
 Optional IdCliente As Integer = -1 _
 , Optional FechaDesde As String = "1900-01-01" _
 , Optional FechaHasta As String = "1900-01-01" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ReporteHistorialClienteBD( _
            IdCliente _
            , FechaDesde _
            , FechaHasta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function






    Public Function fncValidaDocumentoExistenteClienteBUS( _
 Optional IdTipoDocumentoIdentidad As Integer = -1 _
 , Optional NumeroDocumento As String = "" _
 , Optional IdCliente As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ValidaDocumentoExistenteClienteBD( _
            IdTipoDocumentoIdentidad _
            , NumeroDocumento _
            , IdCliente _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncValidaDocumento(ByVal intIdTipoDocumento As Integer, ByVal strNumeroDocumento As String, Optional ByVal intIdCliente As Integer = -1) As Boolean
        Return fncValidaDataTable(fncValidaDocumentoExistenteClienteBUS(intIdTipoDocumento, strNumeroDocumento, intIdCliente))
    End Function

End Class
