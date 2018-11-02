Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsDetalleVentaBUS
    Inherits clsDetalleVentaBD

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
    Optional ByVal IdDetalleVenta As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdDetalleVenta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            IdDetalleVenta = ObtenerValorCelda(Registro, "IdDetalleVenta")
            IdVenta = ObtenerValorCelda(Registro, "IdVenta")
            Estado = ObtenerValorCelda(Registro, "Estado")
            IdProducto = ObtenerValorCelda(Registro, "IdProducto")
            Cantidad = ObtenerValorCelda(Registro, "Cantidad")
            PrecioUnidadSinIGV = ObtenerValorCelda(Registro, "PrecioUnidadSinIGV")
            UnidadIGV = ObtenerValorCelda(Registro, "UnidadIGV")
            PrecioUnidadConIGV = ObtenerValorCelda(Registro, "PrecioUnidadConIGV")
            PrecioTotalSinIGV = ObtenerValorCelda(Registro, "PrecioTotalSinIGV")
            TotalIGV = ObtenerValorCelda(Registro, "TotalIGV")
            PrecioTotalConIGV = ObtenerValorCelda(Registro, "PrecioTotalConIGV")
            FechaVentaDetalle = ObtenerValorCelda(Registro, "FechaVentaDetalle")
            FechaRegistra = ObtenerValorCelda(Registro, "FechaRegistra")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
            PROnombre = ObtenerValorCelda(Registro, "PROnombre")
            PROdescripcion = ObtenerValorCelda(Registro, "PROdescripcion")
            IdUnidadMedida = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "IdUnidadMedida"))
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(ByVal intIdDetalleVenta As Integer,
                    ByVal intIdVenta As Integer,
                    ByVal intIdProducto As Integer,
                    ByVal intCantidad As Integer,
                    ByVal decPrecioUnidadSinIGV As Decimal,
                    ByVal decUnidadIGV As Decimal,
                    ByVal decPrecioUnidadConIGV As Decimal,
                    ByVal decPrecioTotalSinIGV As Decimal,
                    ByVal decPrecioIGV As Decimal,
                    ByVal decPrecioTotalConIGV As Decimal,
                    ByVal dateFechaVentaDetalle As Date,
                    ByVal intUsuario As Integer,
                    ByVal strPROnombre As String,
                    ByVal strPROdescripcion As String,
                    ByVal intIdUnidadMedida As Integer)

        IdDetalleVenta = intIdDetalleVenta
        IdVenta = intIdVenta
        Estado = enmEstado.Activo
        IdProducto = intIdProducto
        Cantidad = intCantidad
        PrecioUnidadSinIGV = decPrecioUnidadSinIGV
        UnidadIGV = decUnidadIGV
        PrecioUnidadConIGV = decPrecioUnidadConIGV
        PrecioTotalSinIGV = decPrecioTotalSinIGV
        TotalIGV = decPrecioIGV
        PrecioTotalConIGV = decPrecioTotalConIGV
        FechaVentaDetalle = dateFechaVentaDetalle
        FechaRegistra = dateFechaVentaDetalle
        FechaModifica = dateFechaVentaDetalle
        UsuarioRegistra = intUsuario
        UsuarioModifica = intUsuario
        PROnombre = strPROnombre
        PROdescripcion = strPROdescripcion
        IdUnidadMedida = intIdUnidadMedida
    End Sub
#End Region


    Public Function fncListarDetallePorVentaBUS( _
 Optional ByVal IdVenta As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Srv_ListarDetallePorVentaBD( _
            IdVenta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
