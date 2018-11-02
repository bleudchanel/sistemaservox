Imports pryUtil

Public Class clsVentaRapidaBN
    Inherits clsUtil
    Property Id As Int32
    Property Descripcion As String
    Property IdProducto As Int32
    Property FechaVenta As DateTime
    Property IdCliente As Int32
    Property PrecioIndividual As Decimal
    Property Cantidad As Int32
    Property PrecioTotal As Decimal
    Property Estado As Byte
    Property FechaRegistra As DateTime
    Property FechaModifica As DateTime
    Property UsuarioRegistra As Int32
    Property UsuarioModifica As Int32
End Class
