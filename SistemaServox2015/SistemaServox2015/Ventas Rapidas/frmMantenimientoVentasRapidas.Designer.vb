<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoVentasRapidas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbcVentas = New System.Windows.Forms.TabControl()
        Me.tbpListar = New System.Windows.Forms.TabPage()
        Me.grpDetalleCompra = New System.Windows.Forms.GroupBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnModificarDetalle = New System.Windows.Forms.Button()
        Me.btnQuitarDetalle = New System.Windows.Forms.Button()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dgvOtro = New System.Windows.Forms.DataGridView()
        Me.IdVentaRapida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCabecera = New System.Windows.Forms.GroupBox()
        Me.lblIGV = New System.Windows.Forms.Label()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.btnBuscarGastos = New System.Windows.Forms.Button()
        Me.pnlControlProducto = New System.Windows.Forms.Panel()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.subIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subDescripcionProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subStockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subStockMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subIdMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCosteSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCosteConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCosteIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subPrecioSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subPrecioConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblTituloPanel = New System.Windows.Forms.Label()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.txtPrecioTotal = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.nudCantidad = New SistemaServox2015.MoneyTextBox0(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMedida = New System.Windows.Forms.Label()
        Me.cmbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmarGasto = New System.Windows.Forms.Button()
        Me.lblProductoConIGV = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.ErrorVentas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.tbcVentas.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        Me.grpDetalleCompra.SuspendLayout()
        CType(Me.dgvOtro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCabecera.SuspendLayout()
        Me.pnlControlProducto.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcVentas
        '
        Me.tbcVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcVentas.Controls.Add(Me.tbpListar)
        Me.tbcVentas.Location = New System.Drawing.Point(3, 31)
        Me.tbcVentas.Name = "tbcVentas"
        Me.tbcVentas.SelectedIndex = 0
        Me.tbcVentas.Size = New System.Drawing.Size(936, 531)
        Me.tbcVentas.TabIndex = 83
        '
        'tbpListar
        '
        Me.tbpListar.Controls.Add(Me.grpDetalleCompra)
        Me.tbpListar.Controls.Add(Me.grpCabecera)
        Me.tbpListar.Location = New System.Drawing.Point(4, 24)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpListar.Size = New System.Drawing.Size(928, 503)
        Me.tbpListar.TabIndex = 0
        Me.tbpListar.Text = "Listar"
        Me.tbpListar.UseVisualStyleBackColor = True
        '
        'grpDetalleCompra
        '
        Me.grpDetalleCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetalleCompra.Controls.Add(Me.btnExcel)
        Me.grpDetalleCompra.Controls.Add(Me.btnModificarDetalle)
        Me.grpDetalleCompra.Controls.Add(Me.btnQuitarDetalle)
        Me.grpDetalleCompra.Controls.Add(Me.btnAgregarDetalle)
        Me.grpDetalleCompra.Controls.Add(Me.Label18)
        Me.grpDetalleCompra.Controls.Add(Me.txtTotal)
        Me.grpDetalleCompra.Controls.Add(Me.dgvOtro)
        Me.grpDetalleCompra.Location = New System.Drawing.Point(7, 93)
        Me.grpDetalleCompra.Name = "grpDetalleCompra"
        Me.grpDetalleCompra.Size = New System.Drawing.Size(913, 392)
        Me.grpDetalleCompra.TabIndex = 76
        Me.grpDetalleCompra.TabStop = False
        Me.grpDetalleCompra.Text = "Detalle"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.White
        Me.btnExcel.Image = Global.SistemaServox2015.My.Resources.Resources.page_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(6, 349)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(140, 28)
        Me.btnExcel.TabIndex = 119
        Me.btnExcel.Text = "E&xcel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnModificarDetalle
        '
        Me.btnModificarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarDetalle.BackColor = System.Drawing.Color.White
        Me.btnModificarDetalle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDetalle.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnModificarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarDetalle.Location = New System.Drawing.Point(621, 14)
        Me.btnModificarDetalle.Name = "btnModificarDetalle"
        Me.btnModificarDetalle.Size = New System.Drawing.Size(140, 28)
        Me.btnModificarDetalle.TabIndex = 8
        Me.btnModificarDetalle.Text = "&Modificar"
        Me.btnModificarDetalle.UseVisualStyleBackColor = False
        '
        'btnQuitarDetalle
        '
        Me.btnQuitarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDetalle.BackColor = System.Drawing.Color.White
        Me.btnQuitarDetalle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarDetalle.Image = Global.SistemaServox2015.My.Resources.Resources.delete
        Me.btnQuitarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitarDetalle.Location = New System.Drawing.Point(767, 14)
        Me.btnQuitarDetalle.Name = "btnQuitarDetalle"
        Me.btnQuitarDetalle.Size = New System.Drawing.Size(140, 28)
        Me.btnQuitarDetalle.TabIndex = 9
        Me.btnQuitarDetalle.Text = "&Quitar"
        Me.btnQuitarDetalle.UseVisualStyleBackColor = False
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDetalle.BackColor = System.Drawing.Color.White
        Me.btnAgregarDetalle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDetalle.Image = Global.SistemaServox2015.My.Resources.Resources.add
        Me.btnAgregarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(475, 14)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(140, 28)
        Me.btnAgregarDetalle.TabIndex = 7
        Me.btnAgregarDetalle.Text = "&Agregar"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(777, 343)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 15)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Total Periodo"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(780, 361)
        Me.txtTotal.MaxLength = 350
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(127, 27)
        Me.txtTotal.TabIndex = 77
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvOtro
        '
        Me.dgvOtro.AllowUserToAddRows = False
        Me.dgvOtro.AllowUserToDeleteRows = False
        Me.dgvOtro.AllowUserToOrderColumns = True
        Me.dgvOtro.AllowUserToResizeRows = False
        Me.dgvOtro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOtro.BackgroundColor = System.Drawing.Color.White
        Me.dgvOtro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVentaRapida, Me.FechaVenta, Me.Descripcion, Me.Producto, Me.Cliente, Me.Cantidad, Me.PrecioTotal})
        Me.dgvOtro.EnableHeadersVisualStyles = False
        Me.dgvOtro.Location = New System.Drawing.Point(6, 45)
        Me.dgvOtro.MultiSelect = False
        Me.dgvOtro.Name = "dgvOtro"
        Me.dgvOtro.ReadOnly = True
        Me.dgvOtro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOtro.Size = New System.Drawing.Size(901, 297)
        Me.dgvOtro.TabIndex = 34
        '
        'IdVentaRapida
        '
        Me.IdVentaRapida.HeaderText = "IdVentaRapida"
        Me.IdVentaRapida.Name = "IdVentaRapida"
        Me.IdVentaRapida.ReadOnly = True
        Me.IdVentaRapida.Visible = False
        '
        'FechaVenta
        '
        Me.FechaVenta.HeaderText = "Fecha"
        Me.FechaVenta.Name = "FechaVenta"
        Me.FechaVenta.ReadOnly = True
        Me.FechaVenta.Width = 70
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Visible = False
        Me.Descripcion.Width = 250
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 200
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 200
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'PrecioTotal
        '
        Me.PrecioTotal.HeaderText = "Total"
        Me.PrecioTotal.Name = "PrecioTotal"
        Me.PrecioTotal.ReadOnly = True
        Me.PrecioTotal.Width = 80
        '
        'grpCabecera
        '
        Me.grpCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCabecera.Controls.Add(Me.lblIGV)
        Me.grpCabecera.Controls.Add(Me.cmbAnio)
        Me.grpCabecera.Controls.Add(Me.Label2)
        Me.grpCabecera.Controls.Add(Me.cmbMes)
        Me.grpCabecera.Controls.Add(Me.btnBuscarGastos)
        Me.grpCabecera.Location = New System.Drawing.Point(7, 6)
        Me.grpCabecera.Name = "grpCabecera"
        Me.grpCabecera.Size = New System.Drawing.Size(915, 81)
        Me.grpCabecera.TabIndex = 75
        Me.grpCabecera.TabStop = False
        Me.grpCabecera.Text = "Cabecera"
        '
        'lblIGV
        '
        Me.lblIGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIGV.AutoSize = True
        Me.lblIGV.Location = New System.Drawing.Point(816, 50)
        Me.lblIGV.Name = "lblIGV"
        Me.lblIGV.Size = New System.Drawing.Size(26, 15)
        Me.lblIGV.TabIndex = 101
        Me.lblIGV.Text = "IGV"
        '
        'cmbAnio
        '
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(18, 37)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(98, 27)
        Me.cmbAnio.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Tipo"
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(122, 37)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(164, 27)
        Me.cmbMes.TabIndex = 1
        '
        'btnBuscarGastos
        '
        Me.btnBuscarGastos.BackColor = System.Drawing.Color.White
        Me.btnBuscarGastos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarGastos.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarGastos.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnBuscarGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarGastos.Location = New System.Drawing.Point(292, 37)
        Me.btnBuscarGastos.Name = "btnBuscarGastos"
        Me.btnBuscarGastos.Size = New System.Drawing.Size(98, 28)
        Me.btnBuscarGastos.TabIndex = 80
        Me.btnBuscarGastos.Text = "&Buscar"
        Me.btnBuscarGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarGastos.UseVisualStyleBackColor = False
        '
        'pnlControlProducto
        '
        Me.pnlControlProducto.BackColor = System.Drawing.Color.White
        Me.pnlControlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControlProducto.Controls.Add(Me.dgvProducto)
        Me.pnlControlProducto.Controls.Add(Me.Label3)
        Me.pnlControlProducto.Controls.Add(Me.txtDescripcionProducto)
        Me.pnlControlProducto.Controls.Add(Me.txtCodigoProducto)
        Me.pnlControlProducto.Controls.Add(Me.lblTituloPanel)
        Me.pnlControlProducto.Controls.Add(Me.lblCodigoCliente)
        Me.pnlControlProducto.Controls.Add(Me.txtNombreCliente)
        Me.pnlControlProducto.Controls.Add(Me.txtCodigoCliente)
        Me.pnlControlProducto.Controls.Add(Me.Label13)
        Me.pnlControlProducto.Controls.Add(Me.Label1)
        Me.pnlControlProducto.Controls.Add(Me.dtpFechaVenta)
        Me.pnlControlProducto.Controls.Add(Me.txtPrecioTotal)
        Me.pnlControlProducto.Controls.Add(Me.nudCantidad)
        Me.pnlControlProducto.Controls.Add(Me.Label5)
        Me.pnlControlProducto.Controls.Add(Me.lblMedida)
        Me.pnlControlProducto.Controls.Add(Me.cmbUnidadMedida)
        Me.pnlControlProducto.Controls.Add(Me.btnCancelar)
        Me.pnlControlProducto.Controls.Add(Me.btnConfirmarGasto)
        Me.pnlControlProducto.Controls.Add(Me.lblProductoConIGV)
        Me.pnlControlProducto.Controls.Add(Me.txtPrecioUnitario)
        Me.pnlControlProducto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlControlProducto.Location = New System.Drawing.Point(20, 568)
        Me.pnlControlProducto.Name = "pnlControlProducto"
        Me.pnlControlProducto.Size = New System.Drawing.Size(743, 221)
        Me.pnlControlProducto.TabIndex = 87
        Me.pnlControlProducto.Visible = False
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToAddRows = False
        Me.dgvProducto.AllowUserToDeleteRows = False
        Me.dgvProducto.AllowUserToOrderColumns = True
        Me.dgvProducto.AllowUserToResizeRows = False
        Me.dgvProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducto.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subIdProducto, Me.subCodigoProducto, Me.subDescripcionProducto, Me.subStockActual, Me.subStockMinimo, Me.subIdMedida, Me.subCosteSinIGV, Me.subCosteConIGV, Me.subCosteIGV, Me.subPrecioSinIGV, Me.subPrecioConIGV})
        Me.dgvProducto.EnableHeadersVisualStyles = False
        Me.dgvProducto.Location = New System.Drawing.Point(6, 60)
        Me.dgvProducto.MultiSelect = False
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.RowHeadersVisible = False
        Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducto.Size = New System.Drawing.Size(439, 156)
        Me.dgvProducto.TabIndex = 143
        '
        'subIdProducto
        '
        Me.subIdProducto.HeaderText = "IdProducto"
        Me.subIdProducto.Name = "subIdProducto"
        Me.subIdProducto.ReadOnly = True
        Me.subIdProducto.Visible = False
        '
        'subCodigoProducto
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subCodigoProducto.DefaultCellStyle = DataGridViewCellStyle4
        Me.subCodigoProducto.HeaderText = "Producto"
        Me.subCodigoProducto.Name = "subCodigoProducto"
        Me.subCodigoProducto.ReadOnly = True
        Me.subCodigoProducto.Width = 120
        '
        'subDescripcionProducto
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subDescripcionProducto.DefaultCellStyle = DataGridViewCellStyle5
        Me.subDescripcionProducto.HeaderText = "Descripción"
        Me.subDescripcionProducto.Name = "subDescripcionProducto"
        Me.subDescripcionProducto.ReadOnly = True
        Me.subDescripcionProducto.Width = 200
        '
        'subStockActual
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.subStockActual.DefaultCellStyle = DataGridViewCellStyle6
        Me.subStockActual.HeaderText = "Stock"
        Me.subStockActual.Name = "subStockActual"
        Me.subStockActual.ReadOnly = True
        Me.subStockActual.Width = 75
        '
        'subStockMinimo
        '
        Me.subStockMinimo.HeaderText = "StockMin"
        Me.subStockMinimo.Name = "subStockMinimo"
        Me.subStockMinimo.ReadOnly = True
        Me.subStockMinimo.Visible = False
        '
        'subIdMedida
        '
        Me.subIdMedida.HeaderText = "IdMedida"
        Me.subIdMedida.Name = "subIdMedida"
        Me.subIdMedida.ReadOnly = True
        Me.subIdMedida.Visible = False
        '
        'subCosteSinIGV
        '
        Me.subCosteSinIGV.HeaderText = "CosteSinIGV"
        Me.subCosteSinIGV.Name = "subCosteSinIGV"
        Me.subCosteSinIGV.ReadOnly = True
        Me.subCosteSinIGV.Visible = False
        '
        'subCosteConIGV
        '
        Me.subCosteConIGV.HeaderText = "CosteConIGV"
        Me.subCosteConIGV.Name = "subCosteConIGV"
        Me.subCosteConIGV.ReadOnly = True
        Me.subCosteConIGV.Visible = False
        '
        'subCosteIGV
        '
        Me.subCosteIGV.HeaderText = "CosteIGV"
        Me.subCosteIGV.Name = "subCosteIGV"
        Me.subCosteIGV.ReadOnly = True
        Me.subCosteIGV.Visible = False
        '
        'subPrecioSinIGV
        '
        Me.subPrecioSinIGV.HeaderText = "PrecioSinIGV"
        Me.subPrecioSinIGV.Name = "subPrecioSinIGV"
        Me.subPrecioSinIGV.ReadOnly = True
        Me.subPrecioSinIGV.Visible = False
        '
        'subPrecioConIGV
        '
        Me.subPrecioConIGV.HeaderText = "PrecioConIGV"
        Me.subPrecioConIGV.Name = "subPrecioConIGV"
        Me.subPrecioConIGV.ReadOnly = True
        Me.subPrecioConIGV.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Descripción"
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.BackColor = System.Drawing.Color.White
        Me.txtDescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionProducto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(147, 25)
        Me.txtDescripcionProducto.MaxLength = 200
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(298, 26)
        Me.txtDescripcionProducto.TabIndex = 141
        Me.txtDescripcionProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BackColor = System.Drawing.Color.White
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(6, 25)
        Me.txtCodigoProducto.MaxLength = 200
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(135, 26)
        Me.txtCodigoProducto.TabIndex = 140
        Me.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTituloPanel
        '
        Me.lblTituloPanel.AutoSize = True
        Me.lblTituloPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPanel.Location = New System.Drawing.Point(4, 6)
        Me.lblTituloPanel.Name = "lblTituloPanel"
        Me.lblTituloPanel.Size = New System.Drawing.Size(64, 18)
        Me.lblTituloPanel.TabIndex = 139
        Me.lblTituloPanel.Text = "Producto"
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Location = New System.Drawing.Point(449, 98)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(36, 18)
        Me.lblCodigoCliente.TabIndex = 138
        Me.lblCodigoCliente.Text = "0912"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(451, 119)
        Me.txtNombreCliente.MaxLength = 350
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(275, 27)
        Me.txtNombreCliente.TabIndex = 137
        Me.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Location = New System.Drawing.Point(571, 86)
        Me.txtCodigoCliente.MaxLength = 11
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(155, 27)
        Me.txtCodigoCliente.TabIndex = 135
        Me.txtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(520, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 15)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(530, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Fecha Venta"
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenta.Location = New System.Drawing.Point(612, 152)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(116, 27)
        Me.dtpFechaVenta.TabIndex = 133
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.BackColor = System.Drawing.Color.MintCream
        Me.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioTotal.Enabled = False
        Me.txtPrecioTotal.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPrecioTotal.Location = New System.Drawing.Point(630, 53)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.Size = New System.Drawing.Size(98, 27)
        Me.txtPrecioTotal.TabIndex = 131
        Me.txtPrecioTotal.Text = "0.00"
        Me.txtPrecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudCantidad
        '
        Me.nudCantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudCantidad.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.nudCantidad.Location = New System.Drawing.Point(546, 22)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(78, 27)
        Me.nudCantidad.TabIndex = 127
        Me.nudCantidad.Text = "0"
        Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(540, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Cantidad"
        '
        'lblMedida
        '
        Me.lblMedida.AutoSize = True
        Me.lblMedida.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedida.Location = New System.Drawing.Point(449, 5)
        Me.lblMedida.Name = "lblMedida"
        Me.lblMedida.Size = New System.Drawing.Size(48, 18)
        Me.lblMedida.TabIndex = 129
        Me.lblMedida.Text = "Medida"
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidadMedida.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnidadMedida.FormattingEnabled = True
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(452, 23)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(88, 27)
        Me.cmbUnidadMedida.TabIndex = 124
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelar.Location = New System.Drawing.Point(670, 188)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(56, 28)
        Me.btnCancelar.TabIndex = 108
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnConfirmarGasto
        '
        Me.btnConfirmarGasto.BackColor = System.Drawing.Color.White
        Me.btnConfirmarGasto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarGasto.Image = Global.SistemaServox2015.My.Resources.Resources.accept
        Me.btnConfirmarGasto.Location = New System.Drawing.Point(612, 188)
        Me.btnConfirmarGasto.Name = "btnConfirmarGasto"
        Me.btnConfirmarGasto.Size = New System.Drawing.Size(56, 28)
        Me.btnConfirmarGasto.TabIndex = 107
        Me.btnConfirmarGasto.UseVisualStyleBackColor = False
        '
        'lblProductoConIGV
        '
        Me.lblProductoConIGV.AutoSize = True
        Me.lblProductoConIGV.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoConIGV.Location = New System.Drawing.Point(627, 4)
        Me.lblProductoConIGV.Name = "lblProductoConIGV"
        Me.lblProductoConIGV.Size = New System.Drawing.Size(57, 18)
        Me.lblProductoConIGV.TabIndex = 109
        Me.lblProductoConIGV.Text = "Precio/U"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioUnitario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(630, 22)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(96, 27)
        Me.txtPrecioUnitario.TabIndex = 122
        Me.txtPrecioUnitario.Text = "0.00"
        Me.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.DarkKhaki
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(946, 25)
        Me.txtTitulo.TabIndex = 82
        Me.txtTitulo.Text = "Mantenimiento Ventas Rápidas"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ErrorVentas
        '
        Me.ErrorVentas.ContainerControl = Me
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(794, 568)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 84
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmMantenimientoVentasRapidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 600)
        Me.Controls.Add(Me.pnlControlProducto)
        Me.Controls.Add(Me.tbcVentas)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMantenimientoVentasRapidas"
        Me.tbcVentas.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.grpDetalleCompra.ResumeLayout(False)
        Me.grpDetalleCompra.PerformLayout()
        CType(Me.dgvOtro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCabecera.ResumeLayout(False)
        Me.grpCabecera.PerformLayout()
        Me.pnlControlProducto.ResumeLayout(False)
        Me.pnlControlProducto.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcVentas As System.Windows.Forms.TabControl
    Friend WithEvents tbpListar As System.Windows.Forms.TabPage
    Friend WithEvents grpDetalleCompra As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnQuitarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents dgvOtro As System.Windows.Forms.DataGridView
    Friend WithEvents grpCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarGastos As System.Windows.Forms.Button
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents pnlControlProducto As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarGasto As System.Windows.Forms.Button
    Friend WithEvents lblProductoConIGV As System.Windows.Forms.Label
    Friend WithEvents txtPrecioUnitario As SistemaServox2015.MoneyTextBox
    Friend WithEvents ErrorVentas As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrecioTotal As SistemaServox2015.MoneyTextBox
    Friend WithEvents nudCantidad As SistemaServox2015.MoneyTextBox0
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMedida As System.Windows.Forms.Label
    Friend WithEvents cmbUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVenta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCodigoCliente As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblTituloPanel As System.Windows.Forms.Label
    Friend WithEvents IdVentaRapida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents subIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subDescripcionProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subStockActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subStockMinimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subIdMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCosteSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCosteConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCosteIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subPrecioSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subPrecioConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblIGV As System.Windows.Forms.Label
    Friend WithEvents btnExcel As System.Windows.Forms.Button
End Class
