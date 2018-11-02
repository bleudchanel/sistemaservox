Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net


Public Class frmCambiarPassword

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmCambiarPassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ControlesEnLoad()
    End Sub

    Sub ControlesEnLoad()
        Me.Text = "CAMBIO DE PASSWORD :: " & My.Settings.NombreUsuario

        Me.txtPasswordActual.Text = String.Empty
        Me.txtNuevoPassword.Text = String.Empty
        Me.txtRepitaNuevoPassword.Text = String.Empty

        Me.ActiveControl = Me.txtPasswordActual

    End Sub


    Private Sub txtPasswordActual_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPasswordActual.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.txtNuevoPassword
            Me.txtNuevoPassword.Select(0, Me.txtNuevoPassword.Text.Length)
        End If
    End Sub

    Private Sub txtNuevoPassword_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNuevoPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.txtRepitaNuevoPassword
            Me.txtRepitaNuevoPassword.Select(0, Me.txtRepitaNuevoPassword.Text.Length)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim Usuario As New clsUsuarioBUS
        Dim intIdUsuarioActual As Integer = My.Settings.Usuario
        Dim dtUsuario As DataTable = Usuario.fncListarUsuariosBUS(intIdUsuarioActual)
        If fncValidaDataTable(dtUsuario) Then
            Dim strPassword As String = ObtenerValorCelda(dtUsuario.Rows(0), "Clave")
            If Me.txtPasswordActual.Text.ToUpper.Equals(strPassword.ToUpper) Then
                If Me.txtNuevoPassword.Text.Trim.Length >= 4 AndAlso Me.txtNuevoPassword.Text.ToUpper.Equals(Me.txtRepitaNuevoPassword.Text.ToUpper) Then
                    Dim dtUsuarioActual As DataTable = Usuario.fncConsultarBUS(intIdUsuarioActual)
                    If fncValidaDataTable(dtUsuarioActual) Then
                        Usuario.fncSetearBUS(dtUsuarioActual.Rows(0))
                        Usuario.Clave = Me.txtNuevoPassword.Text
                        Usuario.FechaRegistro = FechaHoraServidor()
                        If Usuario.fncModificarBUS() > 0 Then
                            Notificar("Se modificó correctamente.")
                        End If
                    Else
                        Notificar("Ocurrió un error", "ERROR")
                    End If
                Else
                    Notificar("El nuevo password ingresado no coincide, vuelva a ingresar el nuevo password. Recuerde que debe ser igual en ambos casilleros." & vbCrLf &
                              "La longitud del password no debe ser menor a 4 letras o números.", "ERROR")
                End If

                'My.Settings.IdUltimoUsuario = intIdUsuarioActual
                'My.Settings.Usuario = intIdUsuarioActual
                'Me.Hide()
                'Dim frm As New frmPrincipal
                'frm.ShowDialog()
                'Me.Close()
            Else
                Notificar("Password Actual Incorrecto.", "ERROR")
            End If
        End If
    End Sub
End Class