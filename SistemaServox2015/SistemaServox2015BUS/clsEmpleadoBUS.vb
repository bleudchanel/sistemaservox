Imports SistemaServox2015BD
Imports pryUtil.clsUtil


Public Class clsEmpleadoBUS
    Inherits clsEmpleadoBD

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
    Optional IdEmpleado As Integer = -1 _
    ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncConsultarBD( _
            IdEmpleado _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function

    Sub fncSetearBUS(Registro As DataRow)
        Try
            IdEmpleado = ObtenerValorCelda(Registro, "IdEmpleado")
            Estado = ObtenerValorCelda(Registro, "Estado")
            Apellidos = ObtenerValorCelda(Registro, "Apellidos")
            Nombres = ObtenerValorCelda(Registro, "Nombres")
            IdTipoDocumentoIdentidad = ObtenerValorCelda(Registro, "IdTipoDocumentoIdentidad")
            NumeroDocumento = ObtenerValorCelda(Registro, "NumeroDocumento")
            FechaRegistro = ObtenerValorCelda(Registro, "FechaRegistro")
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

    Public Sub New(intIdEmpleado As Integer,
        strApellidos As String,
        strNombres As String,
        strNumeroDocumento As String,
        dateFechaRegistro As Date,
        intUsuarioRegistra As Integer)

        IdEmpleado = intIdEmpleado
        Estado = enmEstado.Activo
        Apellidos = strApellidos
        Nombres = strNombres
        IdTipoDocumentoIdentidad = enmTipoDocumento.DNI
        NumeroDocumento = strNumeroDocumento
        FechaRegistro = dateFechaRegistro
        FechaModifica = dateFechaRegistro
        UsuarioRegistra = intUsuarioRegistra
        UsuarioModifica = intUsuarioRegistra


    End Sub
#End Region


    Public Function fncListarEmpleadosPorCampoBUS( _
 Optional IdEmpleado As Integer = -1 _
 , Optional Nombre As String = "" _
 , Optional DNI As String = "" _
 , Optional Estado As Integer = -1 _
 ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_ListarEmpleadosPorCampoBD( _
            IdEmpleado _
            , Nombre _
            , DNI _
            , Estado _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function


    Public Function fncHistorialEmpleadoBUS( _
     Optional IdEmpleado As Integer = -1 _
     , Optional Mes As Integer = -1 _
     , Optional Anio As Integer = -1 _
     ) As DataTable
        Dim rs As New DataTable
        Try
            rs = fncusp_srv_HistorialEmpleadoBD( _
            IdEmpleado _
            , Mes _
            , Anio _
            )
        Catch ex As Exception
            NotificarError(ex)
        End Try
        Return rs
    End Function





End Class
