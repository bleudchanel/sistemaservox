<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.EmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSeriesDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasConIGVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasSinIGVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaBoletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProformasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GarantíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁpidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComisionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasEntreDosFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasEntreDosFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioHastaUnaFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeGananciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteAvanzadoDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarPasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VariablesGlobalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem1, Me.ClienteToolStripMenuItem2, Me.ProveedorToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.MatenimientoToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1244, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoEmpleadoToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(72, 20)
        Me.EmpleadoToolStripMenuItem1.Text = "&Empleado"
        '
        'MantenimientoEmpleadoToolStripMenuItem
        '
        Me.MantenimientoEmpleadoToolStripMenuItem.Name = "MantenimientoEmpleadoToolStripMenuItem"
        Me.MantenimientoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.MantenimientoEmpleadoToolStripMenuItem.Text = "Mantenimiento Empleado"
        '
        'ClienteToolStripMenuItem2
        '
        Me.ClienteToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoClienteToolStripMenuItem})
        Me.ClienteToolStripMenuItem2.Name = "ClienteToolStripMenuItem2"
        Me.ClienteToolStripMenuItem2.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem2.Text = "C&liente"
        '
        'MantenimientoClienteToolStripMenuItem
        '
        Me.MantenimientoClienteToolStripMenuItem.Name = "MantenimientoClienteToolStripMenuItem"
        Me.MantenimientoClienteToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.MantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoProveedorToolStripMenuItem})
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProveedorToolStripMenuItem.Text = "P&roveedor"
        '
        'MantenimientoProveedorToolStripMenuItem
        '
        Me.MantenimientoProveedorToolStripMenuItem.Name = "MantenimientoProveedorToolStripMenuItem"
        Me.MantenimientoProveedorToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MantenimientoProveedorToolStripMenuItem.Text = "Mantenimiento Proveedor"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoProductoToolStripMenuItem, Me.BuscarSeriesDeProductoToolStripMenuItem})
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ProductoToolStripMenuItem.Text = "Pro&ducto"
        '
        'MantenimientoProductoToolStripMenuItem
        '
        Me.MantenimientoProductoToolStripMenuItem.Name = "MantenimientoProductoToolStripMenuItem"
        Me.MantenimientoProductoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.MantenimientoProductoToolStripMenuItem.Text = "Mantenimiento Producto"
        '
        'BuscarSeriesDeProductoToolStripMenuItem
        '
        Me.BuscarSeriesDeProductoToolStripMenuItem.Name = "BuscarSeriesDeProductoToolStripMenuItem"
        Me.BuscarSeriesDeProductoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.BuscarSeriesDeProductoToolStripMenuItem.Text = "Buscar &Series de Producto"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasConIGVToolStripMenuItem, Me.ComprasSinIGVToolStripMenuItem, Me.TransporteToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "&Compras"
        '
        'ComprasConIGVToolStripMenuItem
        '
        Me.ComprasConIGVToolStripMenuItem.Name = "ComprasConIGVToolStripMenuItem"
        Me.ComprasConIGVToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ComprasConIGVToolStripMenuItem.Text = "Compras Con IGV"
        '
        'ComprasSinIGVToolStripMenuItem
        '
        Me.ComprasSinIGVToolStripMenuItem.Name = "ComprasSinIGVToolStripMenuItem"
        Me.ComprasSinIGVToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ComprasSinIGVToolStripMenuItem.Text = "Compras Sin IGV"
        '
        'TransporteToolStripMenuItem
        '
        Me.TransporteToolStripMenuItem.Name = "TransporteToolStripMenuItem"
        Me.TransporteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TransporteToolStripMenuItem.Text = "Transporte"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoVentasToolStripMenuItem, Me.VentaBoletaToolStripMenuItem, Me.ProformasToolStripMenuItem, Me.GarantíaToolStripMenuItem, Me.ÁpidaToolStripMenuItem, Me.ComisionesToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "&Ventas"
        '
        'MantenimientoVentasToolStripMenuItem
        '
        Me.MantenimientoVentasToolStripMenuItem.Name = "MantenimientoVentasToolStripMenuItem"
        Me.MantenimientoVentasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MantenimientoVentasToolStripMenuItem.Text = "Venta - &Factura"
        '
        'VentaBoletaToolStripMenuItem
        '
        Me.VentaBoletaToolStripMenuItem.Name = "VentaBoletaToolStripMenuItem"
        Me.VentaBoletaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.VentaBoletaToolStripMenuItem.Text = "Venta - &Boleta"
        '
        'ProformasToolStripMenuItem
        '
        Me.ProformasToolStripMenuItem.Name = "ProformasToolStripMenuItem"
        Me.ProformasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ProformasToolStripMenuItem.Text = "&Proforma"
        '
        'GarantíaToolStripMenuItem
        '
        Me.GarantíaToolStripMenuItem.Name = "GarantíaToolStripMenuItem"
        Me.GarantíaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GarantíaToolStripMenuItem.Text = "&Garantía"
        '
        'ÁpidaToolStripMenuItem
        '
        Me.ÁpidaToolStripMenuItem.Name = "ÁpidaToolStripMenuItem"
        Me.ÁpidaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ÁpidaToolStripMenuItem.Text = "&Venta Rápida"
        '
        'ComisionesToolStripMenuItem
        '
        Me.ComisionesToolStripMenuItem.Name = "ComisionesToolStripMenuItem"
        Me.ComisionesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ComisionesToolStripMenuItem.Text = "&Comisiones"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem1, Me.VentasEntreDosFechasToolStripMenuItem, Me.ComprasEntreDosFechasToolStripMenuItem, Me.InventarioHastaUnaFechaToolStripMenuItem, Me.ReporteDeGananciasToolStripMenuItem, Me.ReporteAvanzadoDeProductoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Repor&tes"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(238, 22)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'VentasEntreDosFechasToolStripMenuItem
        '
        Me.VentasEntreDosFechasToolStripMenuItem.Name = "VentasEntreDosFechasToolStripMenuItem"
        Me.VentasEntreDosFechasToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.VentasEntreDosFechasToolStripMenuItem.Text = "Ventas entre dos fechas"
        '
        'ComprasEntreDosFechasToolStripMenuItem
        '
        Me.ComprasEntreDosFechasToolStripMenuItem.Name = "ComprasEntreDosFechasToolStripMenuItem"
        Me.ComprasEntreDosFechasToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ComprasEntreDosFechasToolStripMenuItem.Text = "Compras entre dos fechas"
        '
        'InventarioHastaUnaFechaToolStripMenuItem
        '
        Me.InventarioHastaUnaFechaToolStripMenuItem.Name = "InventarioHastaUnaFechaToolStripMenuItem"
        Me.InventarioHastaUnaFechaToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.InventarioHastaUnaFechaToolStripMenuItem.Text = "Inventario hasta una fecha"
        '
        'ReporteDeGananciasToolStripMenuItem
        '
        Me.ReporteDeGananciasToolStripMenuItem.Name = "ReporteDeGananciasToolStripMenuItem"
        Me.ReporteDeGananciasToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ReporteDeGananciasToolStripMenuItem.Text = "Reporte de ganancias"
        '
        'ReporteAvanzadoDeProductoToolStripMenuItem
        '
        Me.ReporteAvanzadoDeProductoToolStripMenuItem.Name = "ReporteAvanzadoDeProductoToolStripMenuItem"
        Me.ReporteAvanzadoDeProductoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ReporteAvanzadoDeProductoToolStripMenuItem.Text = "Reporte Avanzado de Producto"
        '
        'MatenimientoToolStripMenuItem
        '
        Me.MatenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarPasswordToolStripMenuItem1, Me.VariablesGlobalesToolStripMenuItem, Me.OtrosGastosToolStripMenuItem})
        Me.MatenimientoToolStripMenuItem.Name = "MatenimientoToolStripMenuItem"
        Me.MatenimientoToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.MatenimientoToolStripMenuItem.Text = "&Matenimiento"
        '
        'CambiarPasswordToolStripMenuItem1
        '
        Me.CambiarPasswordToolStripMenuItem1.Name = "CambiarPasswordToolStripMenuItem1"
        Me.CambiarPasswordToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.CambiarPasswordToolStripMenuItem1.Text = "Cambiar Password"
        '
        'VariablesGlobalesToolStripMenuItem
        '
        Me.VariablesGlobalesToolStripMenuItem.Name = "VariablesGlobalesToolStripMenuItem"
        Me.VariablesGlobalesToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.VariablesGlobalesToolStripMenuItem.Text = "Variables Globales"
        '
        'OtrosGastosToolStripMenuItem
        '
        Me.OtrosGastosToolStripMenuItem.Name = "OtrosGastosToolStripMenuItem"
        Me.OtrosGastosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.OtrosGastosToolStripMenuItem.Text = "Otros Gastos"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 590)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1244, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(685, 0)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(107, 23)
        Me.btnUpload.TabIndex = 9
        Me.btnUpload.Text = "Abrir Factura Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 612)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmPrincipal"
        Me.Text = "SISTEMA DE INVENTARIO :: COARITA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaBoletaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProformasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasConIGVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasSinIGVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GarantíaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasEntreDosFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasEntreDosFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioHastaUnaFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeGananciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarPasswordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariablesGlobalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSeriesDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteAvanzadoDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosGastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÁpidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComisionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpload As Button
End Class
