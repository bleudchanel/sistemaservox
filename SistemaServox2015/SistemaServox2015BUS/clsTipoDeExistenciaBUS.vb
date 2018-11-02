Imports SistemaServox2015BD
Imports pryUtil.clsUtil


Public Class clsTipoDeExistenciaBUS

    Inherits clsTipoDeExistenciaBD

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
    Optional ByVal IdTipoDeExistencia As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdTipoDeExistencia _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            IdTipoDeExistencia = ObtenerValorCelda(Registro, "IdTipoDeExistencia")
            CodigoSunat = ObtenerValorCelda(Registro, "CodigoSunat")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Estado = ObtenerValorCelda(Registro, "Estado")
            Abreviatura = ObtenerValorCelda(Registro, "Abreviatura")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub

#End Region
End Class
