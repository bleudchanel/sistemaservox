Imports pryUtil

Public Class clsProductoBN
    Inherits clsUtil
    Property PROnombre As String
    Property PROunidad As String
    Property PROdescripcion As String
    Property PROstock As Int32
    Property PROstockmin As Int32
    Property PROprecioigv As Double
    Property PRVruc As String
    Property IdProducto As Int32
    Property FechaRegistro As DateTime
    Property FechaModifica As DateTime
    Property IdMedida As Int32
    Property IdProveedor As Object
    Property PrecioCoste As Decimal
    Property PorcentajeIGVCoste As Decimal
    Property PrecioCosteConIGV As Decimal
    Property PrecioNetoSinIGV As Decimal
    Property Estado As Byte
    Property UsuarioRegistra As Int32
    Property UsuarioModifica As Int32
    Property IdTipoDeExistencia As Int32
    Property PorcentajeIGVVenta As Decimal
    Property PrecioNetoConIGV As Decimal
    Property IdEmpleadoComision As Object
    Property MontoComision As Decimal
    Property CodigoMonedaCompra As String
    Property CodigoMonedaVenta As String
End Class
