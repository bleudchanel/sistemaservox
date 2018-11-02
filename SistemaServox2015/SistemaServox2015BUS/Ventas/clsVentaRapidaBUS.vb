Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsVentaRapidaBUS
    Inherits clsVentaRapidaBD

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
    Optional Id As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            Id _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            Id = ObtenerValorCelda(Registro, "Id")
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            IdProducto = ObtenerValorCelda(Registro, "IdProducto")
            FechaVenta = ObtenerValorCelda(Registro, "FechaVenta")
            IdCliente = ObtenerValorCelda(Registro, "IdCliente")
            PrecioIndividual = ObtenerValorCelda(Registro, "PrecioIndividual")
            Cantidad = ObtenerValorCelda(Registro, "Cantidad")
            PrecioTotal = ObtenerValorCelda(Registro, "PrecioTotal")
            Estado = ObtenerValorCelda(Registro, "Estado")
            FechaRegistra = ObtenerValorCelda(Registro, "FechaRegistra")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub


#End Region

#Region "Constructores"
    Public Sub New()

    End Sub

    Public Sub New(strDescripcion As String _
                   , intIdProducto As Integer _
                   , dateFechaVenta As Date _
                   , intIdCliente As Integer _
                   , decPrecioIndividual As Decimal _
                   , intCantidad As Integer _
                   , decPrecioTotal As Decimal _
                   , intUsuario As Integer
                   )
        Descripcion = strDescripcion
        IdProducto = intIdProducto
        FechaVenta = dateFechaVenta
        IdCliente = intIdCliente
        PrecioIndividual = decPrecioIndividual
        Cantidad = intCantidad
        PrecioTotal = decPrecioTotal
        Estado = enmEstado.Activo
        FechaRegistra = FechaHoraServidor()
        FechaModifica = FechaHoraServidor()
        UsuarioRegistra = intUsuario
        UsuarioModifica = intUsuario
    End Sub
#End Region


    Public Function fncListarVentasRapidasPorPeriodoBUS( _
 Optional Mes As Integer = -1 _
 , Optional Anio As Integer = -1 _
 , Optional Id As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncListarVentasRapidasPorPeriodoBD( _
            Mes _
            , Anio _
            , Id _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


End Class
