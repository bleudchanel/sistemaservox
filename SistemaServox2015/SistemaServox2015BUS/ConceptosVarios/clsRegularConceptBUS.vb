Imports SistemaServox2015BD
Imports pryUtil.clsUtil

Public Class clsRegularConceptBUS
    Inherits clsRegularConceptBD

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
    Optional IdRegularConcept As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdRegularConcept _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdRegularConcept = ObtenerValorCelda(Registro, "IdRegularConcept")
            ConceptCode = ObtenerValorCelda(Registro, "ConceptCode")
            ConceptDescription = ObtenerValorCelda(Registro, "ConceptDescription")
            ConceptStatus = ObtenerValorCelda(Registro, "ConceptStatus")
            FechaRegistra = ObtenerValorCelda(Registro, "FechaRegistra")
            FechaModifica = ObtenerValorCelda(Registro, "FechaModifica")
            UsuarioRegistra = ObtenerValorCelda(Registro, "UsuarioRegistra")
            UsuarioModifica = ObtenerValorCelda(Registro, "UsuarioModifica")
        Catch ex As Exception
            NotificarError(ex)
        End Try
    End Sub


#End Region


#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(intIdRegularConcept As Integer,
                strConceptCode As String,
                strConceptDescription As String,
                intConceptStatus As Integer,
                dateFechaRegistra As Date,
                intUsuarioRegistra As Integer
                )

        IdRegularConcept = intIdRegularConcept
        ConceptCode = strConceptCode
        ConceptDescription = strConceptDescription
        ConceptStatus = enmEstado.Activo
        FechaRegistra = dateFechaRegistra
        FechaModifica = dateFechaRegistra
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioRegistra

    End Sub
#End Region

End Class
