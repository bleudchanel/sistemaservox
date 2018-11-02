Imports pryUtil

Public Class clsDetalleCompraBN
    Inherits clsUtil
    Property IdDetalleCompra As Int32
    Property IdCompra As Int32
    Property Estado As Byte
    Property IdProducto As Int32
    Property Cantidad As Decimal
    Property CostoUnidadSinIGV As Decimal
    Property UnidadIGV As Decimal
    Property CostoUnidadConIGV As Decimal
    Property CostoTotalSinIGV As Decimal
    Property CostoIGV As Decimal
    Property CostoTotalConIGV As Decimal
    Property FechaCompraDetalle As DateTime
    Property FechaRegistro As DateTime
    Property FechaModifica As DateTime
    Property UsuarioRegistra As Int32
    Property UsuarioModifica As Int32
    Property PROnombre As String
    Property PROdescripcion As String
    Property IdUnidadMedida As Int32
End Class
