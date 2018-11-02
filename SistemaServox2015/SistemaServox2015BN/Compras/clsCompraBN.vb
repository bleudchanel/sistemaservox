Imports pryUtil

Public Class clsCompraBN
    Inherits clsUtil
    Property IdCompra As Int32
    Property Serie As String
    Property Numero As String
    Property Descripcion As String
    Property Observacion As String
    Property IdProveedor As Int32
    Property Estado As Byte
    Property FechaCompra As DateTime
    Property FechaPago As DateTime
    Property IdModalidadPago As Int32
    Property IdTipoComprobante As Int32
    Property FechaRegistra As DateTime
    Property FechaModifica As DateTime
    Property UsuarioRegistra As Int32
    Property UsuarioModifica As Int32
    Property Correlativo As Int64
    Property IGV As Decimal
    Property IdTipoOperacion As Object
    Property IdTipoInterno As Object
    Property IdTransporte As Object
    Property CodigoMoneda As String
End Class
