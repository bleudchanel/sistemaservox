Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsUsuarioBUS
    Inherits clsUsuarioBD

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

    Function fncModificarBUS() As String
        Dim rs As Integer = -1
        Try
            Return fncModificarBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Function fncBackUpDataBaseBUS(ByVal strNombreArchivo As String) As Integer
        Dim rs As Integer = -1
        Try
            Return fncBackUpDataBaseBD(strNombreArchivo)
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
    Optional IdUsuario As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdUsuario _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdUsuario = ObtenerValorCelda(Registro, "IdUsuario")
            Nombre = ObtenerValorCelda(Registro, "Nombre")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaRegistro = ObtenerValorCelda(Registro, "FechaRegistro")
            Clave = ObtenerValorCelda(Registro, "Clave")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub

    Public Function fncListarUsuariosBUS( _
 Optional IdUsuario As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_ListarUsuariosBD( _
            IdUsuario _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




#End Region


End Class
