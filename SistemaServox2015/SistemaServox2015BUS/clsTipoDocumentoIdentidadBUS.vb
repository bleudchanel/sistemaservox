Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsTipoDocumentoIdentidadBUS
    Inherits clsTipoDocumentoIdentidadBD

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
    Optional ByVal IdTipoDocumentoIdentidad As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdTipoDocumentoIdentidad _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            IdTipoDocumentoIdentidad = ObtenerValorCelda(Registro, "IdTipoDocumentoIdentidad")
            CodigoSUNAT = ObtenerValorCelda(Registro, "CodigoSUNAT")
            Estado = ObtenerValorCelda(Registro, "Estado")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Abrev = ObtenerValorCelda(Registro, "Abrev")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub


#End Region


    Public Function fncListarDocumentoIdentidadCamposBUS( _
 Optional ByVal Estado As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListarDocumentoIdentidadCamposBD( _
            Estado _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


End Class
