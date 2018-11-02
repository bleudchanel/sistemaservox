
Imports pryUtil

Public Class clsDetalleProformaBN
    Inherits clsUtil
    Property IdDetalleProforma As Int32
    Property IdProforma As Int32
    Property Estado As Byte
    Property IdProducto As Int32
    Property Cantidad As Decimal
    Property PrecioUnidadSinIGV As Decimal
    Property UnidadIGV As Decimal
    Property PrecioUnidadConIGV As Decimal
    Property PrecioTotalSinIGV As Decimal
    Property TotalIGV As Decimal
    Property PrecioTotalConIGV As Decimal
    Property FechaVentaDetalle As DateTime
    Property FechaRegistra As DateTime
    Property FechaModifica As DateTime
    Property UsuarioRegistra As Int32
    Property UsuarioModifica As Int32
    Property PROnombre As String
    Property PROdescripcion As String
    Property IdUnidadMedida As Int32
End Class
