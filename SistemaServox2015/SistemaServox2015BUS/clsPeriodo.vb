Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsPeriodo

    ''' <summary>
    ''' 1 Compra, 2 Venta
    ''' </summary>
    ''' <param name="Operacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fncListaPeriodoPorOperacionBUS( _
 ByVal Operacion As Integer _
 ) As DataTable
        Dim Venta As New clsVentaBD
        Dim rs As New DataTable
        Try
            rs = Venta.fncusp_Srv_ListaPeriodoPorOperacionBD(Operacion)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


End Class
