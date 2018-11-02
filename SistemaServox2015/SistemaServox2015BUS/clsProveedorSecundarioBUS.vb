Imports SistemaServox2015BD
Imports pryUtil.clsUtil


Public Class clsProveedorSecundarioBUS
    Inherits clsProveedorSecundarioBD

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
    Optional IdProveedorSecundario As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdProveedorSecundario _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdProveedorSecundario = ObtenerValorCelda(Registro, "IdProveedorSecundario")
            IdProveedor = ObtenerValorCelda(Registro, "IdProveedor")
            IdProducto = ObtenerValorCelda(Registro, "IdProducto")
            Estado = ObtenerValorCelda(Registro, "Estado")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub


#End Region


#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(intIdProveedorSecundario As Integer,
        intIdProveedor As Integer,
        intIdProducto As Integer)

        IdProveedorSecundario = intIdProveedorSecundario
        IdProveedor = intIdProveedor
        IdProducto = intIdProducto
        Estado = enmEstado.Activo

    End Sub
#End Region


    Public Function fncListarProveedoresSecundariosBUS( _
 Optional IdProducto As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListarProveedoresSecundariosBD( _
            IdProducto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




End Class
