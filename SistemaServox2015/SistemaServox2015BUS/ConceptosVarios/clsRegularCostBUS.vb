Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsRegularCostBUS
    Inherits clsRegularCostBD

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
    Optional IdRegularCost As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdRegularCost _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdRegularCost = ObtenerValorCelda(Registro, "IdRegularCost")
            IdCompra = ObtenerValorCelda(Registro, "IdCompra")
            Serie = ObtenerValorCelda(Registro, "Serie")
            Number = ObtenerValorCelda(Registro, "Number")
            IdRegularConcept = ObtenerValorCelda(Registro, "IdRegularConcept")
            IdProveedor = ObtenerValorCelda(Registro, "IdProveedor")
            Amount = ObtenerValorCelda(Registro, "Amount")
            CostDate = ObtenerValorCelda(Registro, "CostDate")
            CostStatus = ObtenerValorCelda(Registro, "CostStatus")
            CostDescription = ObtenerValorCelda(Registro, "CostDescription")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub


#End Region


#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(
        intIdRegularCost As Integer,
        intIdCompra As Integer,
        strSerie As String,
        strNumber As String,
        intIdRegularConcept As Integer,
        intIdProveedor As Integer,
        decAmount As Decimal,
        dateCostDate As Date,
        strCostDescription As String
        )

        IdRegularCost = intIdRegularCost
        IdCompra = intIdCompra
        Serie = strSerie
        Number = strNumber
        IdRegularConcept = intIdRegularConcept
        IdProveedor = intIdProveedor
        Amount = decAmount
        CostDate = dateCostDate
        CostStatus = enmEstado.Activo
        CostDescription = strCostDescription

    End Sub
#End Region


    Public Function fncRegularCostPorIdCompraBUS( _
 Optional IdRegularConcept As Integer = -1 _
 , Optional IdCompra As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_RegularCostPorIdCompraBD( _
            IdRegularConcept _
            , IdCompra _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function



End Class
