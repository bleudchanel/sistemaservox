Imports System.Windows.Forms
Imports System.Threading
Imports System.Globalization
Imports OpenInvoicePeru.WinApp

Public Class frmPrincipal



    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub



    'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    'End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE")

        My.Settings.IGV = If(My.Settings.IGV = 0, 0.18, My.Settings.IGV)
        Me.Text = "SISTEMA DE INVENTARIO :: SERVOX :: USUARIO " & My.Settings.NombreUsuario
        ''  mo()
    End Sub


    Private Function SingletonForm(ByVal FormUnico As Form) As Boolean
        Dim Rpta As Boolean = True
        Dim ctl As Form
        For Each ctl In MdiChildren
            If ctl.Name = FormUnico.Name Then
                Rpta = False
                Exit For
            Else
                Rpta = True
            End If
        Next
        Return Rpta
    End Function


    Private Sub DevolverEnfoque(ByRef Formu As Form)
        For Each OpenForm As Form In Me.MdiChildren
            If OpenForm.Name = Formu.Name Then
                OpenForm.Activate()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub DevolverEnfoqueTexto(ByVal txtBusca As String)
        For Each OpenForm As Form In Me.MdiChildren
            If OpenForm.Text = txtBusca Then
                OpenForm.Activate()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If SingletonForm(frmMantenimientoCliente) = True Then
        '    Dim ChildForm As New frmMantenimientoCliente

        '    ChildForm.StartPosition = FormStartPosition.Manual
        '    ChildForm.Left = 0
        '    ChildForm.Top = 0
        '    ChildForm.MdiParent = Me
        '    ChildForm.Show()
        'Else
        '    DevolverEnfoque(frmMantenimientoCliente)
        'End If
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SingletonForm(frmMantenimientoProveedor) = True Then
            Dim ChildForm As New frmMantenimientoProveedor

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoProveedor)
        End If
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SingletonForm(frmMantenimientoComisiones) = True Then
            Dim ChildForm As New frmMantenimientoComisiones

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoComisiones)
        End If
    End Sub

    Private Sub MantenimientoDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If SingletonForm(frmMantenimientoCompras) = True Then
        '    Dim ChildForm As New frmMantenimientoCompras

        '    ChildForm.StartPosition = FormStartPosition.Manual
        '    ChildForm.Left = 0
        '    ChildForm.Top = 0
        '    ChildForm.MdiParent = Me
        '    ChildForm.Show()
        'Else
        '    DevolverEnfoque(frmMantenimientoCompras)
        'End If
    End Sub

    Private Sub MantenimientoVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoVentasToolStripMenuItem.Click

        If modInventario.bolVentasFacturaAbierto = False Then
            'If SingletonForm(frmMantenimientoVentas) = True Then
            Dim ChildForm As New frmMantenimientoVentas

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.txtTitulo.Text = "MANTENIMIENTO DE FACTURA"
            ChildForm.Text = "FACTURA"
            ChildForm.bolEsFactura = True
            modInventario.bolVentasFacturaAbierto = True
            ChildForm.Show()
            'Else
            '    DevolverEnfoque(frmMantenimientoVentas)
            'End If
        Else
            DevolverEnfoqueTexto("FACTURA")
        End If

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub VentaBoletaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentaBoletaToolStripMenuItem.Click
        If modInventario.bolVentasBoletaAbierto = False Then
            Dim ChildForm As New frmMantenimientoVentas

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.txtTitulo.Text = "MANTENIMIENTO DE BOLETA"
            ChildForm.Text = "BOLETA"
            ChildForm.bolEsFactura = False
            modInventario.bolVentasBoletaAbierto = True
            ChildForm.txtTitulo.BackColor = Color.DarkCyan
            ChildForm.Show()
        Else
            DevolverEnfoqueTexto("BOLETA")
        End If

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub CAMBIARPASSWORDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasToolStripMenuItem.Click

    End Sub

    Private Sub BuscarCódigosDeProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If SingletonForm(frmBusquedaPorCodigo) = True Then
            Dim ChildForm As New frmBusquedaPorCodigo

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmBusquedaPorCodigo)
        End If
    End Sub

    Private Sub ProformasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProformasToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoProforma) = True Then
            Dim ChildForm As New frmMantenimientoProforma

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoProforma)
        End If
    End Sub

    Private Sub ComprasConIGVToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasConIGVToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoComprasConIGV) = True Then
            Dim ChildForm As New frmMantenimientoComprasConIGV

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoComprasConIGV)
        End If
    End Sub

    Private Sub ComprasSinIGVToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasSinIGVToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoComprasSinIGV) = True Then
            Dim ChildForm As New frmMantenimientoComprasSinIGV

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoComprasSinIGV)
        End If
    End Sub

    Private Sub GarantíaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GarantíaToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoGarantia) = True Then
            Dim ChildForm As New frmMantenimientoGarantia

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoGarantia)
        End If
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        'If SingletonForm(frmMantenimientoCliente) = True Then
        '    Dim ChildForm As New frmMantenimientoCliente

        '    ChildForm.StartPosition = FormStartPosition.Manual
        '    ChildForm.Left = 0
        '    ChildForm.Top = 0
        '    ChildForm.MdiParent = Me
        '    ChildForm.Show()
        'Else
        '    DevolverEnfoque(frmMantenimientoCliente)
        'End If
    End Sub

    Private Sub ProveedorToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        'If SingletonForm(frmMantenimientoProveedor) = True Then
        '    Dim ChildForm As New frmMantenimientoProveedor

        '    ChildForm.StartPosition = FormStartPosition.Manual
        '    ChildForm.Left = 0
        '    ChildForm.Top = 0
        '    ChildForm.MdiParent = Me
        '    ChildForm.Show()
        'Else
        '    DevolverEnfoque(frmMantenimientoProveedor)
        'End If
    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        'If SingletonForm(frmMantenimientoProducto) = True Then
        '    Dim ChildForm As New frmMantenimientoProducto

        '    ChildForm.StartPosition = FormStartPosition.Manual
        '    ChildForm.Left = 0
        '    ChildForm.Top = 0
        '    ChildForm.MdiParent = Me
        '    ChildForm.Show()
        'Else
        '    DevolverEnfoque(frmMantenimientoProducto)
        'End If
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If SingletonForm(frmMantenimientoEmpleado) = True Then
            Dim ChildForm As New frmMantenimientoEmpleado

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoEmpleado)
        End If
    End Sub

    Private Sub TransporteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TransporteToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoTransporte) = True Then
            Dim ChildForm As New frmMantenimientoTransporte

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoTransporte)
        End If
    End Sub

    Private Sub MantenimientoClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MantenimientoClienteToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoCliente) = True Then
            Dim ChildForm As New frmMantenimientoCliente

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoCliente)
        End If
    End Sub

    Private Sub MantenimientoProveedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MantenimientoProveedorToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoProveedor) = True Then
            Dim ChildForm As New frmMantenimientoProveedor

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoProveedor)
        End If
    End Sub

    Private Sub MantenimientoProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MantenimientoProductoToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoProducto) = True Then
            Dim ChildForm As New frmMantenimientoProducto

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoProducto)
        End If
    End Sub

    Private Sub MantenimientoEmpleadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MantenimientoEmpleadoToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoEmpleado) = True Then
            Dim ChildForm As New frmMantenimientoEmpleado

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoEmpleado)
        End If
    End Sub

    Private Sub ReportesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ReportesToolStripMenuItem1.Click
        If SingletonForm(frmReportes) = True Then
            Dim ChildForm As New frmReportes

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmReportes)
        End If
    End Sub

    Private Sub VentasEntreDosFechasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasEntreDosFechasToolStripMenuItem.Click
        Dim ChildForm As New frmReportes

        ChildForm.StartPosition = FormStartPosition.Manual
        ChildForm.Left = 0
        ChildForm.Top = 0
        ChildForm.MdiParent = Me
        ChildForm.tbcReportes.SelectedTab = ChildForm.tbpVentas
        ChildForm.ActiveControl = ChildForm.dtpVentasDesde
        ChildForm.Show()


        'If SingletonForm(frmReportes) = True Then
        '    Dim ChildForm As New frmReportes

        '    ChildForm.StartPosition = FormStartPosition.Manual
        '    ChildForm.Left = 0
        '    ChildForm.Top = 0
        '    ChildForm.MdiParent = Me
        '    ChildForm.Show()
        'Else
        '    DevolverEnfoque(frmReportes)
        'End If
    End Sub

    Private Sub ComprasEntreDosFechasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasEntreDosFechasToolStripMenuItem.Click
        Dim ChildForm As New frmReportes

        ChildForm.StartPosition = FormStartPosition.Manual
        ChildForm.Left = 0
        ChildForm.Top = 0
        ChildForm.MdiParent = Me
        ChildForm.tbcReportes.SelectedTab = ChildForm.tbpCompras

        ChildForm.ActiveControl = ChildForm.dtpComprasDesde
        ChildForm.Show()
    End Sub

    Private Sub InventarioHastaUnaFechaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioHastaUnaFechaToolStripMenuItem.Click
        Dim ChildForm As New frmReportes

        ChildForm.StartPosition = FormStartPosition.Manual
        ChildForm.Left = 0
        ChildForm.Top = 0
        ChildForm.MdiParent = Me
        ChildForm.tbcReportes.SelectedTab = ChildForm.tbpInventario

        ChildForm.ActiveControl = ChildForm.dtpFechaInventario
        ChildForm.Show()
    End Sub

    Private Sub ReporteDeGananciasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteDeGananciasToolStripMenuItem.Click
        Dim ChildForm As New frmReportes

        ChildForm.StartPosition = FormStartPosition.Manual
        ChildForm.Left = 0
        ChildForm.Top = 0
        ChildForm.MdiParent = Me
        ChildForm.tbcReportes.SelectedTab = ChildForm.tbpGanancias

        ChildForm.ActiveControl = ChildForm.dtpGananciasDesde
        ChildForm.Show()
    End Sub

    Private Sub CambiarPasswordToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CambiarPasswordToolStripMenuItem1.Click
        If SingletonForm(frmCambiarPassword) = True Then
            Dim ChildForm As New frmCambiarPassword

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmCambiarPassword)
        End If
    End Sub

    Private Sub VariablesGlobalesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VariablesGlobalesToolStripMenuItem.Click
        If SingletonForm(frmVariablesGlobales) = True Then
            Dim ChildForm As New frmVariablesGlobales

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmVariablesGlobales)
        End If
    End Sub

    Private Sub BuscarSeriesDeProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuscarSeriesDeProductoToolStripMenuItem.Click
        If SingletonForm(frmBusquedaPorCodigo) = True Then
            Dim ChildForm As New frmBusquedaPorCodigo

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmBusquedaPorCodigo)
        End If
    End Sub

    Private Sub ReporteAvanzadoDeProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteAvanzadoDeProductoToolStripMenuItem.Click
        If SingletonForm(frmReporteProductoAvanzado) = True Then
            Dim ChildForm As New frmReporteProductoAvanzado

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmReporteProductoAvanzado)
        End If
    End Sub

    Private Sub OtrosGastosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OtrosGastosToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoOtrosGastos) = True Then
            Dim ChildForm As New frmMantenimientoOtrosGastos

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoOtrosGastos)
        End If
    End Sub

    Private Sub ÁpidaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÁpidaToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoVentasRapidas) = True Then
            Dim ChildForm As New frmMantenimientoVentasRapidas

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoVentasRapidas)
        End If
    End Sub

    Private Sub ComisionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComisionesToolStripMenuItem.Click
        If SingletonForm(frmMantenimientoComisiones) = True Then
            Dim ChildForm As New frmMantenimientoComisiones

            ChildForm.StartPosition = FormStartPosition.Manual
            ChildForm.Left = 0
            ChildForm.Top = 0
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            DevolverEnfoque(frmMantenimientoComisiones)
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim frm As New FrmEnviarSunat
        frm.Show()
    End Sub
End Class
