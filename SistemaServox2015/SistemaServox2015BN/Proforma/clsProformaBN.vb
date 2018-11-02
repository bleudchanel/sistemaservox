Imports pryUtil


Public Class clsProformaBN
    Inherits clsUtil
    Property IdProforma As Int32
    Property IdModalidadPago As Int32
    Property IdTipoComprobante As Int32
    Property Serie As String
    Property Numero As String
    Property Descripcion As String
    Property Observacion As String
    Property IdCliente As Int32
    Property Estado As Byte
    Property FechaVenta As DateTime
    Property FechaPago As DateTime
    Property IGV As Decimal
    Property Correlativo As Int64
    Property FechaRegistra As DateTime
    Property FechaModifica As DateTime
    Property UsuarioRegistra As Int32
    Property UsuarioModifica As Int32
    Property IdTipoOperacion As Int32
    Property EstadoProceso As Byte
End Class
