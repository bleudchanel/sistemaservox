Imports SistemaServox2015BD
Imports pryUtil.clsUtil


Public Class clsOtrosGastosBUS

    Inherits clsOtrosGastosBD

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
            ConceptoId = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "ConceptoId"))
            Descripcion = ObtenerValorCelda(Registro, "Descripcion")
            Mes = ObtenerValorCelda(Registro, "Mes")
            Anio = ObtenerValorCelda(Registro, "Anio")
            Estado = ObtenerValorCelda(Registro, "Estado")
            ProveedorId = fncSiMenorIgualACeroEsDbNull(ObtenerValorCelda(Registro, "ProveedorId"))
            Proveedor = ObtenerValorCelda(Registro, "Proveedor")
            Monto = ObtenerValorCelda(Registro, "Monto")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub
#End Region

    Public Sub New()

    End Sub

    Public Sub New(ByVal strDescripcion As String _
                   , ByVal intMes As Integer _
                   , ByVal intAnio As Integer _
                   , ByVal decMonto As Decimal)
        ConceptoId = DBNull.Value
        Descripcion = strDescripcion
        Mes = intMes
        Anio = intAnio
        Estado = enmEstado.Activo
        ProveedorId = DBNull.Value
        Proveedor = "Proveedor Default"
        Monto = decMonto
    End Sub

    Public Function fncListarOtrosGastosPorPeriodoBUS( _
 Optional Mes As Integer = -1 _
 , Optional Anio As Integer = -1 _
 , Optional Id As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListarOtrosGastosPorPeriodoBD( _
            Mes _
            , Anio _
            , Id _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncConceptosBusquedaListaBUS( _
 Optional Texto As String = "" _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ConceptosBusquedaListaBD( _
            Texto _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
