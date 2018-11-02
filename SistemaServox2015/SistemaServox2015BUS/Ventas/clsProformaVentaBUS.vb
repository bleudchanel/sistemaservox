Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsProformaVentaBUS
    Inherits clsProformaVentaBD

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
    Optional IdProformaVenta As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdProformaVenta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdProformaVenta = ObtenerValorCelda(Registro, "IdProformaVenta")
            IdVenta = ObtenerValorCelda(Registro, "IdVenta")
            IdProforma = ObtenerValorCelda(Registro, "IdProforma")
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

    Public Sub New(intIdProformaVenta As Integer,
                    intIdVenta As Integer,
                    intIdProforma As Integer,
                    dateFechaRegistra As Date,
                    intUsuarioRegistra As Integer
                    )

        IdProformaVenta = intIdProformaVenta
        IdVenta = intIdVenta
        IdProforma = intIdProforma
        Estado = enmEstado.Activo
        FechaRegistra = dateFechaRegistra
        FechaModifica = dateFechaRegistra
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioRegistra

    End Sub
#End Region

    Public Function fncusp_srv_ListarProformasPorVentaBUS( _
 Optional IdVenta As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListarProformasPorVentaBD( _
            IdVenta _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function




End Class
