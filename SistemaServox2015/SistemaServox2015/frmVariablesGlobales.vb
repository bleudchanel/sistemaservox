Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net

Public Class frmVariablesGlobales

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub frmVariablesGlobales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.txtIGV.Text = My.Settings.IGV
        Me.txtValorDolar.Text = My.Settings.ValorDolar
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        My.Settings.IGV = Me.txtIGV.Text
        My.Settings.ValorDolar = Me.txtValorDolar.Text
        Notificar("Datos Guardados")
        Me.Close()

    End Sub

    Private Sub frmVariablesGlobales_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()

        End If
    End Sub
End Class
