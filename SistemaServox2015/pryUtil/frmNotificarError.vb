Imports System.Windows.Forms
Imports System.Drawing

Public Class frmNotificarError
    Sub New(xMensaje As String, xTitulo As String, Optional xDetalle As String = "")

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = xTitulo
        lblMensaje.Text = xMensaje
        txtDetalles.Text = xDetalle
    End Sub

    Private Sub frmNotificarError_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        picImagen.Image = Bitmap.FromHicon(SystemIcons.Hand.Handle)
        If lblMensaje.Height > 70 Then
            Me.txtDetalles.Top += lblMensaje.Height - 70
            Me.Height += lblMensaje.Height - 70
            Me.btnVerDetalles.Top += lblMensaje.Height - 70
            Me.txtDetalles.Height = 0
        End If
    End Sub

    Private Sub btnVerDetalles_Click(sender As System.Object, e As System.EventArgs) Handles btnVerDetalles.Click
        If txtDetalles.Height = 0 Then
            Me.Height += 50
            'btnVerDetalles.Image = My.Resources.navigation_090_white
        Else
            Me.Height -= 50
            'btnVerDetalles.Image = My.Resources.navigation_270_white
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.Hide()
    End Sub

    Private Sub frmNotificarError_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Beep()
    End Sub

End Class