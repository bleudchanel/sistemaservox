Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net
Imports System.Environment
Imports pryUtil.clsUtil
Imports SistemaServox2015BUS
Imports System.Xml
Imports System.Configuration
Imports System.Reflection

Public Class frmLoginPrincipal


    Private Sub txtPassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        Me.txtPassword.Text = ""
    End Sub

   
    Private Sub frmLoginPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim ObjPerfil As New clsSeguridadBUS
        'Dim dtPerfil As New DataTable

        '' Set Id de Administrador del Sistema
        'modPlanilla.intSISadminID = 102


        'dtPerfil = ObjPerfil.fncusp_Seg_S_PerfilPorSISidBUS(9, 1)
        'If fncValidaDataTable(dtPerfil) = True Then
        '    cmbPerfil.DataSource = dtPerfil
        '    cmbPerfil.DisplayMember = "PRFnombre"
        '    cmbPerfil.ValueMember = "PRFid"
        '    Me.cmbPerfil.SelectedItem = 0
        'Else
        '    Notificar("El sistema no tiene conexión o no existen usuarios registrados")
        '    Me.Close()

        'End If
        Dim Usuario As New clsUsuarioBUS

        SetComboBox(cmbPerfil, Usuario.fncListarUsuariosBUS(), "Nombre", "IdUsuario")
        cmbPerfil.SelectedIndex = 0
        If My.Settings.IdUltimoUsuario <> 0 Then
            cmbPerfil.SelectedValue = My.Settings.IdUltimoUsuario
        End If
        cmbPerfil.AutoCompleteMode = AutoCompleteMode.Append
        'cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPerfil.AutoCompleteSource = AutoCompleteSource.ListItems

        'Dim ObjAyuda As New clsAyudaBUS
        'Dim lstBase As List(Of String) = ObjAyuda.fncConstruirAvisos()
        'Me.rtbAvisos.Rtf = lstBase(1).ToString


        Me.lblEnvironment.Text = Environment.MachineName & vbNewLine & ".NET " & Environment.Version.ToString
        Me.ActiveControl = Me.txtPassword


        Me.lblVersion.Text = Application.ProductVersion

    End Sub

    'Sub SeleccionarUsuarioPorDefecto()
    '    Me.cmbPerfil.item()
    'End Sub


    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click



        Dim Usuario As New clsUsuarioBUS
        Dim intIdUsuarioActual As Integer = Me.cmbPerfil.SelectedValue
        Dim dtUsuario As DataTable = Usuario.fncListarUsuariosBUS(intIdUsuarioActual)
        If fncValidaDataTable(dtUsuario) Then
            Dim strPassword As String = ObtenerValorCelda(dtUsuario.Rows(0), "Clave")
            If Me.txtPassword.Text.ToUpper.Equals(strPassword.ToUpper) Then
                My.Settings.IdUltimoUsuario = intIdUsuarioActual
                My.Settings.Usuario = intIdUsuarioActual
                My.Settings.NombreUsuario = cmbPerfil.Text
                Me.Hide()
                Dim frm As New frmPrincipal
                frm.ShowDialog()
                Me.Close()
            Else
                Notificar("Password Incorrecto.", "ERROR")
            End If
        End If

        'If txtPassword.Text = "2015" Then
        '    Me.Hide()
        '    Dim frm As New frmPrincipal
        '    frm.ShowDialog()
        '    Me.Close()
        '    ''            Me.Close()
        'End If

        'Dim sEncryptKey As String = "H0nkyH0nk"
        'Dim strActual As String
        'Dim intPRFid As New Integer
        'Dim strPRFnombre As String = String.Empty
        'Dim ObjPerfil As New clsSeguridadBUS
        'Dim dtValidar As New DataTable
        'Try
        '    strActual = EncryptPasswordMD5(txtPassword.Text, sEncryptKey)

        '    If (cmbPerfil.Text.Trim.Length >= 3) AndAlso (cmbPerfil.Text.Trim.Substring(2, cmbPerfil.Text.Trim.Length - 2).Equals("SuperAdmin")) Then
        '        dtValidar = ObjPerfil.fncConsultarValidarPassBUS(CInt(cmbPerfil.Text.Trim.Substring(0, 2)), strActual)
        '        intPRFid = CInt(cmbPerfil.Text.Trim.Substring(0, 2))
        '        strPRFnombre = "SuperAdmin"
        '    Else
        '        dtValidar = ObjPerfil.fncConsultarValidarPassBUS(cmbPerfil.SelectedValue, strActual)
        '        intPRFid = cmbPerfil.SelectedValue
        '        strPRFnombre = cmbPerfil.Text
        '    End If


        '    'modPlanilla.intIdFacultad = Me.cmbFacultad.SelectedValue
        '    'modPlanilla.strFacultad = Me.cmbFacultad.Text


        '    If (dtValidar IsNot Nothing AndAlso dtValidar.Rows.Count > 0) Then
        '        '  Notificar("Password Correcto : " & cmbPerfil.Text & " : " & cmbPerfil.SelectedValue)
        '        modPlanilla.intSISid = 9 ' Planilla
        '        modPlanilla.intPRFid = intPRFid
        '        modPlanilla.strPRFnombre = cmbPerfil.Text

        '        'Dim dtDependencia As DataTable = ObjPerfil.fncusp_Cho_DependenciaUsuarioBUS(intPRFid)
        '        'If fncValidaDataTable(dtDependencia) = True Then
        '        '    modPlanilla.intIdFacultad = ObtenerValorCelda(dtDependencia.Rows(0), "IdFacultad")
        '        '    modPlanilla.strFacultad = ObtenerValorCelda(dtDependencia.Rows(0), "Facultad")
        '        '    modPlanilla.intIdPtaDependencia = ObtenerValorCelda(dtDependencia.Rows(0), "IdPtaDependencia")
        '        'Else
        '        '    Exit Sub
        '        'End If
        '        My.Settings.sUserApp = Me.cmbPerfil.Text
        '        '    Dim ObjChoSemestre As New clsChoSemestreBUS
        '        ' ObjChoSemestre.ActualizarBaseDeSemestres()


        '        Me.Hide()
        '        Dim frm As New frmPrincipal
        '        frm.Owner = Me
        '        frm.Show()
        '        ' Me.Close()
        '    Else
        '        Notificar("Password incorrecto")
        '    End If
        'Catch ex As Exception
        '    NotificarError(ex)
        'End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnIngresar_Click(Me, e)
        End If
    End Sub

    'Private Sub cmbPerfil_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPerfil.Enter
    '    Dim ObjPerfil As New clsSeguridadBUS
    '    Dim dtPerfil As New DataTable

    '    dtPerfil = ObjPerfil.fncusp_Seg_S_PerfilPorSISidBUS(9, 1)
    '    'dtPerfil.DefaultView.RowFilter = "SISid = 3"
    '    cmbPerfil.DataSource = dtPerfil
    '    cmbPerfil.DisplayMember = "PRFnombre"
    '    cmbPerfil.ValueMember = "PRFid"
    '    Me.cmbPerfil.SelectedItem = 0
    'End Sub

    Private Sub cmbPerfil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPerfil.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPassword.Focus()
        End If
    End Sub

    Private Sub cmbPerfil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPerfil.SelectedIndexChanged

    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnIngresar.Focus()
        End If
    End Sub

End Class