Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsTipoComprobanteBUS

    Inherits clsTipoComprobanteBD

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
    Optional ByVal IdTipoComprobante As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdTipoComprobante _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            IdTipoComprobante = ObtenerValorCelda(Registro, "IdTipoComprobante")
            CodigoSunat = ObtenerValorCelda(Registro, "CodigoSunat")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Abreviacion = ObtenerValorCelda(Registro, "Abreviacion")
            Estado = ObtenerValorCelda(Registro, "Estado")
            EnUso = ObtenerValorCelda(Registro, "EnUso")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub



#End Region

    Public Function fncTipoComprobanteBUS( _
 Optional ByVal EnUso As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Srv_TipoComprobanteBD( _
            EnUso _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
