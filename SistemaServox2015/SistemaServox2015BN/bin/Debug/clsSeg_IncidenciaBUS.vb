
Public Class clsSeg_IncidenciaBUS
	Inherits clsSeg_IncidenciaBD

#Region "Mantenimiento Basico"

    Function fncRegistrarBUS() As Integer
        Dim rs As Integer = -1
        Try
            Return fncRegistrarBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


#End Region
    Public Function fncConsultarFechaHoraServidorBUS( _
   ) As DateTime
        Dim rs As DateTime = DateTime.Now
        Try
            rs = fncConsultarFechaHoraServidorBD()
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Public Function fncusp_Co2_S_Co2_mmObtenerNewIdfuenteBUS( _
 Anio As Integer _
 ) As Object
        Dim rs As Object = Nothing
        Try
            rs = fncusp_Co2_S_Co2_mmObtenerNewIdfuenteBD(Anio)
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


End Class
