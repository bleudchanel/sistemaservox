Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsDetalleCompraBUS
    Inherits clsDetalleCompraBD

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
    Optional ByVal IdDetalleCompra As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdDetalleCompra _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(ByVal Registro As DataRow)
        Try
            IdDetalleCompra = ObtenerValorCelda(Registro, "IdDetalleCompra")
            IdCompra = ObtenerValorCelda(Registro, "IdCompra")
            Estado = ObtenerValorCelda(Registro, "Estado")
            IdProducto = ObtenerValorCelda(Registro, "IdProducto")
            Cantidad = ObtenerValorCelda(Registro, "Cantidad")
            CostoUnidadSinIGV = ObtenerValorCelda(Registro, "CostoUnidadSinIGV")
            UnidadIGV = ObtenerValorCelda(Registro, "UnidadIGV")
            CostoUnidadConIGV = ObtenerValorCelda(Registro, "CostoUnidadConIGV")
            CostoTotalSinIGV = ObtenerValorCelda(Registro, "CostoTotalSinIGV")
            CostoIGV = ObtenerValorCelda(Registro, "CostoIGV")
            CostoTotalConIGV = ObtenerValorCelda(Registro, "CostoTotalConIGV")
            FechaCompraDetalle = ObtenerValorCelda(Registro, "FechaCompraDetalle")
            FechaRegistro = ObtenerValorCelda(Registro, "FechaRegistro")
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

    Public Sub New(ByVal intIdDetalleCompra As Integer,
                    ByVal intIdCompra As Integer,
                    ByVal intIdProducto As Integer,
                    ByVal intCantidad As Integer,
                    ByVal decCostoUnidadSinIGV As Decimal,
                    ByVal decUnidadIGV As Decimal,
                    ByVal decCostoUnidadConIGV As Decimal,
                    ByVal decCostoTotalSinIGV As Decimal,
                    ByVal decCostoIGV As Decimal,
                    ByVal decCostoTotalConIGV As Decimal,
                    ByVal dateFechaCompraDetalle As Date,
                    ByVal intUsuario As Integer,
                    ByVal strPROnombre As String,
                    ByVal strPROdescripcion As String,
                    ByVal intIdUnidadMedida As Integer)

        IdDetalleCompra = intIdDetalleCompra
        IdCompra = intIdCompra
        Estado = enmEstado.Activo
        IdProducto = intIdProducto
        Cantidad = intCantidad
        CostoUnidadSinIGV = decCostoUnidadSinIGV
        UnidadIGV = decUnidadIGV
        CostoUnidadConIGV = decCostoUnidadConIGV
        CostoTotalSinIGV = decCostoTotalSinIGV
        CostoIGV = decCostoIGV
        CostoTotalConIGV = decCostoTotalConIGV
        FechaCompraDetalle = dateFechaCompraDetalle
        FechaRegistro = dateFechaCompraDetalle
        FechaModifica = dateFechaCompraDetalle
        UsuarioRegistra = intUsuario
        UsuarioModifica = intUsuario
        PROnombre = strPROnombre
        PROdescripcion = strPROdescripcion
        IdUnidadMedida = intIdUnidadMedida
    End Sub
#End Region

    Public Function fncListarDetallePorCompraBUS( _
 Optional ByVal IdCompra As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_Srv_ListarDetallePorCompraBD( _
            IdCompra _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




End Class
