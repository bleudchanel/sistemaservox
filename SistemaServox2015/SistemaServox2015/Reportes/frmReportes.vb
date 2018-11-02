Imports SistemaServox2015BUS
Imports pryUtil.clsUtil
Imports System.Net
Imports System.IO


Public Class frmReportes

    Private Sub btnReporteVentas_Click(sender As System.Object, e As System.EventArgs) Handles btnReporteVentasFechas.Click
        ReportesVenta(dtpVentasDesde.Value, dtpVentasHasta.Value)
    End Sub

    Sub ReportesVenta(ByVal dateDesde As Date, ByVal dateHasta As Date)
        Dim Venta As New clsVentaBUS
        Dim dtVenta As DataTable = Venta.fncVentasEntreDosFechasBUS(dateDesde, dateHasta)
        If fncValidaDataTable(dtVenta) Then
            FncDataTable2Excel(dtVenta, "Ventas entre dos fechas")
        Else
            Notificar("No hay datos para mostrar.")
        End If
    End Sub

    Private Sub frmReportes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProcComboBoxAAnio(cmbAnio)
        ProcComboBoxAMes(cmbMes)
        ProcComboBoxAAnio(cmbAnioGanancia)
        ProcComboBoxAMes(cmbMesGanancia)
    End Sub

    Private Sub btnReporteCompras_Click(sender As System.Object, e As System.EventArgs) Handles btnReporteCompras.Click
        Dim Compra As New clsCompraBUS
        Dim dtCompra As DataTable = Compra.fncComprasEntreDosFechasBUS(Me.dtpComprasDesde.Value, Me.dtpComprasHasta.Value)
        If fncValidaDataTable(dtCompra) Then
            FncDataTable2Excel(dtCompra, "Compras entre dos fechas")
        End If
    End Sub

    Private Sub btnReporteInventario_Click(sender As System.Object, e As System.EventArgs) Handles btnReporteInventario.Click
        Dim Producto As New clsProductoBUS
        Dim dtInventario As DataTable = Producto.fncListaInventarioHastaFechaBUS(Me.dtpFechaInventario.Value, If(chkMostrarInventario0.Checked = True, 1, -1), My.Settings.IGV)
        If fncValidaDataTable(dtInventario) Then
            FncDataTable2Excel(dtInventario, "Inventario hasta " & Me.dtpFechaInventario.Value.ToString("dd/MM/yyyy"))
        End If
    End Sub

    Private Sub btnBackUp_Click(sender As System.Object, e As System.EventArgs) Handles btnBackUp.Click
        Dim Usuario As New clsUsuarioBUS
        Dim strNombre As String = FechaHoraServidor.ToString("yyyyMMddHHmmss") + ".bak"
        Dim strBase As String = Usuario.fncBackUpDataBaseBUS(strNombre)



        Dim sourcepath As String = "C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\Backup\" + strNombre
        Dim DestPath As String = "C:\DataSistema\" + strNombre
        My.Computer.FileSystem.CopyFile(
    sourcepath,
    DestPath,
    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        '' CopyDirectory(sourcepath, DestPath)
        Process.Start("C:\DataSistema\")
        ''Notificar("Ejecutado")
    End Sub

    Private Shared Sub CopyDirectory(ByVal sourcePath As String, ByVal destPath As String)
        If Not Directory.Exists(destPath) Then
            Directory.CreateDirectory(destPath)
        End If

        For Each file__1 As String In Directory.GetFiles(Path.GetDirectoryName(sourcePath))
            Dim dest As String = Path.Combine(destPath, Path.GetFileName(file__1))
            File.Copy(file__1, dest)
        Next

        For Each folder As String In Directory.GetDirectories(Path.GetDirectoryName(sourcePath))
            Dim dest As String = Path.Combine(destPath, Path.GetFileName(folder))
            CopyDirectory(folder, dest)
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnReporteGanancias_Click(sender As System.Object, e As System.EventArgs) Handles btnReporteGananciasFechas.Click
        ReporteGanancias(Me.dtpGananciasDesde.Value, Me.dtpGananciasHasta.Value)
    End Sub

    Sub ReporteGanancias(ByVal dateDesde As Date, ByVal dateHasta As Date)
        Dim Venta As New clsVentaBUS
        Dim dtVenta As DataTable = Venta.fncGananciasEntreDosFechasBUS(dateDesde, dateHasta, My.Settings.ValorDolar)
        If fncValidaDataTable(dtVenta) Then
            FncDataTable2ExcelResaltado(dtVenta, "Ganancias entre dos fechas")
        Else
            Notificar("No hay datos para mostrar.")
        End If
    End Sub

    Private Sub dtpComprasDesde_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpComprasDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = dtpComprasHasta
        End If
    End Sub

    Private Sub dtpVentasDesde_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpVentasDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.dtpVentasHasta
        End If
    End Sub

    Private Sub dtpGananciasDesde_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpGananciasDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = dtpGananciasHasta
        End If
    End Sub

    Private Sub dtpFechaInventario_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaInventario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnReporteInventario
        End If
    End Sub

    Private Sub dtpVentasHasta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpVentasHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnReporteVentasFechas

        End If
    End Sub

    Private Sub dtpGananciasHasta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpGananciasHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnReporteGananciasFechas
        End If
    End Sub

    Private Sub dtpComprasHasta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpComprasHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Me.btnReporteCompras

        End If
    End Sub

    Private Sub btnReporteVentasMesAnio_Click(sender As System.Object, e As System.EventArgs) Handles btnReporteVentasMesAnio.Click
        Dim dateBuscar As New Date(Me.cmbAnio.SelectedValue, Me.cmbMes.SelectedValue, 1)
        Dim dateInicial As Date = dateBuscar
        Dim dateFinal As Date = dateBuscar.AddMonths(1).AddDays(-1)
        ReportesVenta(dateInicial, dateFinal)
    End Sub

    Private Sub btnReporteGananciasMesAnio_Click(sender As System.Object, e As System.EventArgs) Handles btnReporteGananciasMesAnio.Click
        Dim dateBuscar As New Date(Me.cmbAnioGanancia.SelectedValue, Me.cmbMesGanancia.SelectedValue, 1)
        Dim dateInicial As Date = dateBuscar
        Dim dateFinal As Date = dateBuscar.AddMonths(1).AddDays(-1)
        ReporteGanancias(dateInicial, dateFinal)
    End Sub
End Class