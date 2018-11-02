Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsCodUnidadVentaBUS

    Inherits clsCodUnidadVentaBD

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
    Optional IdCodigo As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdCodigo _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdCodigo = ObtenerValorCelda(Registro, "IdCodigo")
            IdDetalleVenta = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "IdDetalleVenta"))
            IdDetalleCompra = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "IdDetalleCompra"))
            Codigo = ObtenerValorCelda(Registro, "Codigo")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaRegistra = ObtenerValorCelda(Registro, "FechaRegistra")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            IdEmpleado = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "IdEmpleado"))
            MontoComision = ObtenerValorCelda(Registro, "MontoComision")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub



#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(intIdCodigo As Integer,
        intIdDetalleVenta As Integer,
        intIdDetalleCompra As Integer,
        strCodigo As String,
        strDescripcion As String,
        dateFechaRegistra As Date,
        intUsuarioRegistra As Integer,
        intIdEmpleado As Integer,
        decMontoComision As Decimal)

        IdCodigo = intIdCodigo
        IdDetalleVenta = fncSiMenorIgualACeroEsDbNull(intIdDetalleVenta)
        IdDetalleCompra = fncSiMenorIgualACeroEsDbNull(intIdDetalleCompra)
        Codigo = strCodigo
        Descripcion = strDescripcion
        Estado = enmEstado.Activo
        FechaRegistra = dateFechaRegistra
        UsuarioRegistra = intUsuarioRegistra
        IdEmpleado = fncSiMenorIgualACeroEsDbNull(intIdEmpleado)
        MontoComision = decMontoComision

    End Sub
#End Region


    Public Function fncListarCodigosPorDetalleBUS( _
 Optional IdVenta As Integer = -1 _
 , Optional IdCompra As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListarCodigosPorDetalleBD( _
            IdVenta _
            , IdCompra _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





    Public Function fncBusquedaCodigoComprobanteBUS( _
 Optional Codigo As String = "" _
 , Optional Descripcion As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_BusquedaCodigoComprobanteBD( _
            Codigo _
            , Descripcion _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
