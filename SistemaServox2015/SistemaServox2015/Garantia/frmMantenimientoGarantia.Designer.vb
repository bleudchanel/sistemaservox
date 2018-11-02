<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoGarantia
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbcVentas = New System.Windows.Forms.TabControl()
        Me.tbpListar = New System.Windows.Forms.TabPage()
        Me.grpDetalleCompra = New System.Windows.Forms.GroupBox()
        Me.pnlControlProducto = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtbObservacionDetalle = New System.Windows.Forms.RichTextBox()
        Me.chkActualizarPrecioVenta = New System.Windows.Forms.CheckBox()
        Me.nudCantidad = New SistemaServox2015.MoneyTextBox0(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIGVTotal = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtTotalSinIGV = New SistemaServox2015.MoneyTextBox(Me.components)
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
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnConfirmarProducto = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblProductoConIGV = New System.Windows.Forms.Label()
        Me.lblProductoIGV = New System.Windows.Forms.Label()
        Me.lblProductoSinIGV = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalConIGV = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtCostoConIGV = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtIGVCosto = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtCosto = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.cmbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblTituloPanel = New System.Windows.Forms.Label()
        Me.btnCodigosProducto = New System.Windows.Forms.Button()
        Me.btnModificarDetalle = New System.Windows.Forms.Button()
        Me.btnQuitarDetalle = New System.Windows.Forms.Button()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalIGV = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.dgvDetalleGarantia = New System.Windows.Forms.DataGridView()
        Me.IdDetalleVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidadSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidadIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidadConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCabecera = New System.Windows.Forms.GroupBox()
        Me.grpEstadoProceso = New System.Windows.Forms.GroupBox()
        Me.rbNoAceptada = New System.Windows.Forms.RadioButton()
        Me.rbAceptada = New System.Windows.Forms.RadioButton()
        Me.rbPendiente = New System.Windows.Forms.RadioButton()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.MaskedTextBox()
        Me.txtSerie = New System.Windows.Forms.MaskedTextBox()
        Me.txtIGV = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.grpNavegar = New System.Windows.Forms.GroupBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.cmbAnioPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtProveedorNombre = New System.Windows.Forms.TextBox()
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.txtProveedorRUC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBuscarFactura = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.ErrorVentas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.tbcVentas.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        Me.grpDetalleCompra.SuspendLayout()
        Me.pnlControlProducto.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCabecera.SuspendLayout()
        Me.grpEstadoProceso.SuspendLayout()
        Me.grpNavegar.SuspendLayout()
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
        Me.tbcVentas.Size = New System.Drawing.Size(967, 527)
        Me.tbcVentas.TabIndex = 83
        '
        'tbpListar
        '
        Me.tbpListar.Controls.Add(Me.grpDetalleCompra)
        Me.tbpListar.Controls.Add(Me.grpCabecera)
        Me.tbpListar.Location = New System.Drawing.Point(4, 24)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpListar.Size = New System.Drawing.Size(959, 499)
        Me.tbpListar.TabIndex = 0
        Me.tbpListar.Text = "Listar"
        Me.tbpListar.UseVisualStyleBackColor = True
        '
        'grpDetalleCompra
        '
        Me.grpDetalleCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetalleCompra.Controls.Add(Me.btnCodigosProducto)
        Me.grpDetalleCompra.Controls.Add(Me.btnModificarDetalle)
        Me.grpDetalleCompra.Controls.Add(Me.btnQuitarDetalle)
        Me.grpDetalleCompra.Controls.Add(Me.btnAgregarDetalle)
        Me.grpDetalleCompra.Controls.Add(Me.Label19)
        Me.grpDetalleCompra.Controls.Add(Me.txtObservacion)
        Me.grpDetalleCompra.Controls.Add(Me.Label18)
        Me.grpDetalleCompra.Controls.Add(Me.Label17)
        Me.grpDetalleCompra.Controls.Add(Me.Label16)
        Me.grpDetalleCompra.Controls.Add(Me.txtTotal)
        Me.grpDetalleCompra.Controls.Add(Me.txtTotalIGV)
        Me.grpDetalleCompra.Controls.Add(Me.txtSubTotal)
        Me.grpDetalleCompra.Controls.Add(Me.dgvDetalleGarantia)
        Me.grpDetalleCompra.Location = New System.Drawing.Point(7, 167)
        Me.grpDetalleCompra.Name = "grpDetalleCompra"
        Me.grpDetalleCompra.Size = New System.Drawing.Size(944, 302)
        Me.grpDetalleCompra.TabIndex = 76
        Me.grpDetalleCompra.TabStop = False
        Me.grpDetalleCompra.Text = "Detalle"
        '
        'pnlControlProducto
        '
        Me.pnlControlProducto.BackColor = System.Drawing.Color.White
        Me.pnlControlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControlProducto.Controls.Add(Me.Label6)
        Me.pnlControlProducto.Controls.Add(Me.rtbObservacionDetalle)
        Me.pnlControlProducto.Controls.Add(Me.chkActualizarPrecioVenta)
        Me.pnlControlProducto.Controls.Add(Me.nudCantidad)
        Me.pnlControlProducto.Controls.Add(Me.Label10)
        Me.pnlControlProducto.Controls.Add(Me.Label9)
        Me.pnlControlProducto.Controls.Add(Me.txtIGVTotal)
        Me.pnlControlProducto.Controls.Add(Me.txtTotalSinIGV)
        Me.pnlControlProducto.Controls.Add(Me.dgvProducto)
        Me.pnlControlProducto.Controls.Add(Me.btnCancelarProducto)
        Me.pnlControlProducto.Controls.Add(Me.btnConfirmarProducto)
        Me.pnlControlProducto.Controls.Add(Me.Label8)
        Me.pnlControlProducto.Controls.Add(Me.lblProductoConIGV)
        Me.pnlControlProducto.Controls.Add(Me.lblProductoIGV)
        Me.pnlControlProducto.Controls.Add(Me.lblProductoSinIGV)
        Me.pnlControlProducto.Controls.Add(Me.Label5)
        Me.pnlControlProducto.Controls.Add(Me.Label4)
        Me.pnlControlProducto.Controls.Add(Me.Label3)
        Me.pnlControlProducto.Controls.Add(Me.txtTotalConIGV)
        Me.pnlControlProducto.Controls.Add(Me.txtCostoConIGV)
        Me.pnlControlProducto.Controls.Add(Me.txtIGVCosto)
        Me.pnlControlProducto.Controls.Add(Me.txtCosto)
        Me.pnlControlProducto.Controls.Add(Me.cmbUnidadMedida)
        Me.pnlControlProducto.Controls.Add(Me.txtDescripcionProducto)
        Me.pnlControlProducto.Controls.Add(Me.txtCodigoProducto)
        Me.pnlControlProducto.Controls.Add(Me.lblTituloPanel)
        Me.pnlControlProducto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlControlProducto.Location = New System.Drawing.Point(771, 578)
        Me.pnlControlProducto.Name = "pnlControlProducto"
        Me.pnlControlProducto.Size = New System.Drawing.Size(715, 170)
        Me.pnlControlProducto.TabIndex = 87
        Me.pnlControlProducto.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(440, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Descripción"
        '
        'rtbObservacionDetalle
        '
        Me.rtbObservacionDetalle.Location = New System.Drawing.Point(438, 77)
        Me.rtbObservacionDetalle.MaxLength = 250
        Me.rtbObservacionDetalle.Name = "rtbObservacionDetalle"
        Me.rtbObservacionDetalle.Size = New System.Drawing.Size(264, 82)
        Me.rtbObservacionDetalle.TabIndex = 125
        Me.rtbObservacionDetalle.Text = ""
        '
        'chkActualizarPrecioVenta
        '
        Me.chkActualizarPrecioVenta.AutoSize = True
        Me.chkActualizarPrecioVenta.Location = New System.Drawing.Point(494, 138)
        Me.chkActualizarPrecioVenta.Name = "chkActualizarPrecioVenta"
        Me.chkActualizarPrecioVenta.Size = New System.Drawing.Size(15, 14)
        Me.chkActualizarPrecioVenta.TabIndex = 117
        Me.chkActualizarPrecioVenta.UseVisualStyleBackColor = True
        Me.chkActualizarPrecioVenta.Visible = False
        '
        'nudCantidad
        '
        Me.nudCantidad.BackColor = System.Drawing.Color.PaleTurquoise
        Me.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudCantidad.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.nudCantidad.Location = New System.Drawing.Point(501, 23)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(81, 27)
        Me.nudCantidad.TabIndex = 118
        Me.nudCantidad.Text = "0"
        Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(440, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 18)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Sub Total"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(440, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 18)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "IGV"
        Me.Label9.Visible = False
        '
        'txtIGVTotal
        '
        Me.txtIGVTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGVTotal.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtIGVTotal.Location = New System.Drawing.Point(442, 132)
        Me.txtIGVTotal.Name = "txtIGVTotal"
        Me.txtIGVTotal.Size = New System.Drawing.Size(86, 27)
        Me.txtIGVTotal.TabIndex = 119
        Me.txtIGVTotal.Text = "0.00"
        Me.txtIGVTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIGVTotal.Visible = False
        '
        'txtTotalSinIGV
        '
        Me.txtTotalSinIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalSinIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtTotalSinIGV.Location = New System.Drawing.Point(440, 132)
        Me.txtTotalSinIGV.Name = "txtTotalSinIGV"
        Me.txtTotalSinIGV.Size = New System.Drawing.Size(85, 27)
        Me.txtTotalSinIGV.TabIndex = 120
        Me.txtTotalSinIGV.Text = "0.00"
        Me.txtTotalSinIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalSinIGV.Visible = False
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
        Me.dgvProducto.Location = New System.Drawing.Point(6, 57)
        Me.dgvProducto.MultiSelect = False
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.RowHeadersVisible = False
        Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducto.Size = New System.Drawing.Size(428, 108)
        Me.dgvProducto.TabIndex = 103
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
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subCodigoProducto.DefaultCellStyle = DataGridViewCellStyle9
        Me.subCodigoProducto.HeaderText = "Producto"
        Me.subCodigoProducto.Name = "subCodigoProducto"
        Me.subCodigoProducto.ReadOnly = True
        Me.subCodigoProducto.Width = 120
        '
        'subDescripcionProducto
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subDescripcionProducto.DefaultCellStyle = DataGridViewCellStyle10
        Me.subDescripcionProducto.HeaderText = "Descripción"
        Me.subDescripcionProducto.Name = "subDescripcionProducto"
        Me.subDescripcionProducto.ReadOnly = True
        Me.subDescripcionProducto.Width = 200
        '
        'subStockActual
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.subStockActual.DefaultCellStyle = DataGridViewCellStyle11
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
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.BackColor = System.Drawing.Color.White
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelarProducto.Location = New System.Drawing.Point(646, 22)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(56, 28)
        Me.btnCancelarProducto.TabIndex = 108
        Me.btnCancelarProducto.UseVisualStyleBackColor = False
        '
        'btnConfirmarProducto
        '
        Me.btnConfirmarProducto.BackColor = System.Drawing.Color.White
        Me.btnConfirmarProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarProducto.Image = Global.SistemaServox2015.My.Resources.Resources.accept
        Me.btnConfirmarProducto.Location = New System.Drawing.Point(588, 22)
        Me.btnConfirmarProducto.Name = "btnConfirmarProducto"
        Me.btnConfirmarProducto.Size = New System.Drawing.Size(56, 28)
        Me.btnConfirmarProducto.TabIndex = 107
        Me.btnConfirmarProducto.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(435, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 18)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Total + IGV"
        Me.Label8.Visible = False
        '
        'lblProductoConIGV
        '
        Me.lblProductoConIGV.AutoSize = True
        Me.lblProductoConIGV.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoConIGV.Location = New System.Drawing.Point(435, 111)
        Me.lblProductoConIGV.Name = "lblProductoConIGV"
        Me.lblProductoConIGV.Size = New System.Drawing.Size(70, 18)
        Me.lblProductoConIGV.TabIndex = 109
        Me.lblProductoConIGV.Text = "Unidad+IGV"
        Me.lblProductoConIGV.Visible = False
        '
        'lblProductoIGV
        '
        Me.lblProductoIGV.AutoSize = True
        Me.lblProductoIGV.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoIGV.Location = New System.Drawing.Point(441, 111)
        Me.lblProductoIGV.Name = "lblProductoIGV"
        Me.lblProductoIGV.Size = New System.Drawing.Size(68, 18)
        Me.lblProductoIGV.TabIndex = 108
        Me.lblProductoIGV.Text = "IGV Unidad"
        Me.lblProductoIGV.Visible = False
        '
        'lblProductoSinIGV
        '
        Me.lblProductoSinIGV.AutoSize = True
        Me.lblProductoSinIGV.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoSinIGV.Location = New System.Drawing.Point(440, 111)
        Me.lblProductoSinIGV.Name = "lblProductoSinIGV"
        Me.lblProductoSinIGV.Size = New System.Drawing.Size(85, 18)
        Me.lblProductoSinIGV.TabIndex = 107
        Me.lblProductoSinIGV.Text = "Precio Unidad"
        Me.lblProductoSinIGV.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(498, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(410, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Medida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Descripción"
        '
        'txtTotalConIGV
        '
        Me.txtTotalConIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalConIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtTotalConIGV.Location = New System.Drawing.Point(444, 132)
        Me.txtTotalConIGV.Name = "txtTotalConIGV"
        Me.txtTotalConIGV.Size = New System.Drawing.Size(79, 27)
        Me.txtTotalConIGV.TabIndex = 121
        Me.txtTotalConIGV.Text = "0.00"
        Me.txtTotalConIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalConIGV.Visible = False
        '
        'txtCostoConIGV
        '
        Me.txtCostoConIGV.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtCostoConIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoConIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtCostoConIGV.Location = New System.Drawing.Point(444, 132)
        Me.txtCostoConIGV.Name = "txtCostoConIGV"
        Me.txtCostoConIGV.Size = New System.Drawing.Size(79, 27)
        Me.txtCostoConIGV.TabIndex = 122
        Me.txtCostoConIGV.Text = "0.00"
        Me.txtCostoConIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCostoConIGV.Visible = False
        '
        'txtIGVCosto
        '
        Me.txtIGVCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGVCosto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtIGVCosto.Location = New System.Drawing.Point(442, 132)
        Me.txtIGVCosto.Name = "txtIGVCosto"
        Me.txtIGVCosto.Size = New System.Drawing.Size(86, 27)
        Me.txtIGVCosto.TabIndex = 123
        Me.txtIGVCosto.Text = "0.00"
        Me.txtIGVCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIGVCosto.Visible = False
        '
        'txtCosto
        '
        Me.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCosto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtCosto.Location = New System.Drawing.Point(443, 132)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(85, 27)
        Me.txtCosto.TabIndex = 124
        Me.txtCosto.Text = "0.00"
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCosto.Visible = False
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidadMedida.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnidadMedida.FormattingEnabled = True
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(410, 23)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(88, 27)
        Me.cmbUnidadMedida.TabIndex = 97
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.BackColor = System.Drawing.Color.White
        Me.txtDescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionProducto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(147, 23)
        Me.txtDescripcionProducto.MaxLength = 200
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(257, 26)
        Me.txtDescripcionProducto.TabIndex = 102
        Me.txtDescripcionProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BackColor = System.Drawing.Color.White
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(6, 23)
        Me.txtCodigoProducto.MaxLength = 200
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(135, 26)
        Me.txtCodigoProducto.TabIndex = 101
        Me.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTituloPanel
        '
        Me.lblTituloPanel.AutoSize = True
        Me.lblTituloPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPanel.Location = New System.Drawing.Point(3, 5)
        Me.lblTituloPanel.Name = "lblTituloPanel"
        Me.lblTituloPanel.Size = New System.Drawing.Size(64, 18)
        Me.lblTituloPanel.TabIndex = 21
        Me.lblTituloPanel.Text = "Producto"
        '
        'btnCodigosProducto
        '
        Me.btnCodigosProducto.BackColor = System.Drawing.Color.White
        Me.btnCodigosProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCodigosProducto.Image = Global.SistemaServox2015.My.Resources.Resources.add
        Me.btnCodigosProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCodigosProducto.Location = New System.Drawing.Point(5, 15)
        Me.btnCodigosProducto.Name = "btnCodigosProducto"
        Me.btnCodigosProducto.Size = New System.Drawing.Size(105, 28)
        Me.btnCodigosProducto.TabIndex = 83
        Me.btnCodigosProducto.Text = "Có&digos"
        Me.btnCodigosProducto.UseVisualStyleBackColor = False
        Me.btnCodigosProducto.Visible = False
        '
        'btnModificarDetalle
        '
        Me.btnModificarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarDetalle.BackColor = System.Drawing.Color.White
        Me.btnModificarDetalle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDetalle.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnModificarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarDetalle.Location = New System.Drawing.Point(652, 14)
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
        Me.btnQuitarDetalle.Location = New System.Drawing.Point(798, 14)
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
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(506, 14)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(140, 28)
        Me.btnAgregarDetalle.TabIndex = 7
        Me.btnAgregarDetalle.Text = "&Producto"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 252)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 15)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(6, 269)
        Me.txtObservacion.MaxLength = 350
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(521, 27)
        Me.txtObservacion.TabIndex = 81
        Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(833, 253)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 15)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Total Final"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(728, 253)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 15)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Total IGV"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(617, 253)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 15)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Sub Total"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(836, 271)
        Me.txtTotal.MaxLength = 350
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(102, 27)
        Me.txtTotal.TabIndex = 77
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalIGV
        '
        Me.txtTotalIGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalIGV.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalIGV.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalIGV.Location = New System.Drawing.Point(728, 271)
        Me.txtTotalIGV.MaxLength = 350
        Me.txtTotalIGV.Name = "txtTotalIGV"
        Me.txtTotalIGV.ReadOnly = True
        Me.txtTotalIGV.Size = New System.Drawing.Size(102, 27)
        Me.txtTotalIGV.TabIndex = 76
        Me.txtTotalIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(620, 271)
        Me.txtSubTotal.MaxLength = 350
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(102, 27)
        Me.txtSubTotal.TabIndex = 75
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalleGarantia
        '
        Me.dgvDetalleGarantia.AllowUserToAddRows = False
        Me.dgvDetalleGarantia.AllowUserToDeleteRows = False
        Me.dgvDetalleGarantia.AllowUserToOrderColumns = True
        Me.dgvDetalleGarantia.AllowUserToResizeRows = False
        Me.dgvDetalleGarantia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleGarantia.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalleGarantia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalleVenta, Me.IdProducto, Me.CodigoProducto, Me.DescripcionProducto, Me.Cantidad, Me.IdUnidadMedida, Me.UnidadMedida, Me.PrecioUnidadSinIGV, Me.PrecioUnidadIGV, Me.PrecioUnidadConIGV, Me.PrecioTotalSinIGV, Me.PrecioTotalIGV, Me.PrecioTotalConIGV, Me.Estado, Me.ObservacionDetalle})
        Me.dgvDetalleGarantia.EnableHeadersVisualStyles = False
        Me.dgvDetalleGarantia.Location = New System.Drawing.Point(6, 45)
        Me.dgvDetalleGarantia.MultiSelect = False
        Me.dgvDetalleGarantia.Name = "dgvDetalleGarantia"
        Me.dgvDetalleGarantia.ReadOnly = True
        Me.dgvDetalleGarantia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleGarantia.Size = New System.Drawing.Size(932, 207)
        Me.dgvDetalleGarantia.TabIndex = 34
        '
        'IdDetalleVenta
        '
        Me.IdDetalleVenta.HeaderText = "IdDetalleVenta"
        Me.IdDetalleVenta.Name = "IdDetalleVenta"
        Me.IdDetalleVenta.ReadOnly = True
        Me.IdDetalleVenta.Visible = False
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Visible = False
        '
        'CodigoProducto
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoProducto.DefaultCellStyle = DataGridViewCellStyle1
        Me.CodigoProducto.HeaderText = "Producto"
        Me.CodigoProducto.Name = "CodigoProducto"
        Me.CodigoProducto.ReadOnly = True
        Me.CodigoProducto.Width = 130
        '
        'DescripcionProducto
        '
        Me.DescripcionProducto.HeaderText = "Descripción"
        Me.DescripcionProducto.Name = "DescripcionProducto"
        Me.DescripcionProducto.ReadOnly = True
        Me.DescripcionProducto.Width = 260
        '
        'Cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 90
        '
        'IdUnidadMedida
        '
        Me.IdUnidadMedida.HeaderText = "IdUnidadMedida"
        Me.IdUnidadMedida.Name = "IdUnidadMedida"
        Me.IdUnidadMedida.ReadOnly = True
        Me.IdUnidadMedida.Visible = False
        '
        'UnidadMedida
        '
        Me.UnidadMedida.HeaderText = "Medida"
        Me.UnidadMedida.Name = "UnidadMedida"
        Me.UnidadMedida.ReadOnly = True
        Me.UnidadMedida.Width = 60
        '
        'PrecioUnidadSinIGV
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioUnidadSinIGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioUnidadSinIGV.HeaderText = "Costo"
        Me.PrecioUnidadSinIGV.Name = "PrecioUnidadSinIGV"
        Me.PrecioUnidadSinIGV.ReadOnly = True
        Me.PrecioUnidadSinIGV.Visible = False
        Me.PrecioUnidadSinIGV.Width = 80
        '
        'PrecioUnidadIGV
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioUnidadIGV.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioUnidadIGV.HeaderText = "IGV"
        Me.PrecioUnidadIGV.Name = "PrecioUnidadIGV"
        Me.PrecioUnidadIGV.ReadOnly = True
        Me.PrecioUnidadIGV.Visible = False
        Me.PrecioUnidadIGV.Width = 70
        '
        'PrecioUnidadConIGV
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioUnidadConIGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.PrecioUnidadConIGV.HeaderText = "Costo+IGV"
        Me.PrecioUnidadConIGV.Name = "PrecioUnidadConIGV"
        Me.PrecioUnidadConIGV.ReadOnly = True
        Me.PrecioUnidadConIGV.Visible = False
        '
        'PrecioTotalSinIGV
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTotalSinIGV.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioTotalSinIGV.HeaderText = "Total"
        Me.PrecioTotalSinIGV.Name = "PrecioTotalSinIGV"
        Me.PrecioTotalSinIGV.ReadOnly = True
        Me.PrecioTotalSinIGV.Visible = False
        '
        'PrecioTotalIGV
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTotalIGV.DefaultCellStyle = DataGridViewCellStyle7
        Me.PrecioTotalIGV.HeaderText = "IGV Total"
        Me.PrecioTotalIGV.Name = "PrecioTotalIGV"
        Me.PrecioTotalIGV.ReadOnly = True
        Me.PrecioTotalIGV.Visible = False
        '
        'PrecioTotalConIGV
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTotalConIGV.DefaultCellStyle = DataGridViewCellStyle8
        Me.PrecioTotalConIGV.HeaderText = "Total + IGV"
        Me.PrecioTotalConIGV.Name = "PrecioTotalConIGV"
        Me.PrecioTotalConIGV.ReadOnly = True
        Me.PrecioTotalConIGV.Visible = False
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'ObservacionDetalle
        '
        Me.ObservacionDetalle.HeaderText = "Observación"
        Me.ObservacionDetalle.Name = "ObservacionDetalle"
        Me.ObservacionDetalle.ReadOnly = True
        Me.ObservacionDetalle.Width = 250
        '
        'grpCabecera
        '
        Me.grpCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCabecera.Controls.Add(Me.grpEstadoProceso)
        Me.grpCabecera.Controls.Add(Me.lblCodigoCliente)
        Me.grpCabecera.Controls.Add(Me.txtNumero)
        Me.grpCabecera.Controls.Add(Me.txtSerie)
        Me.grpCabecera.Controls.Add(Me.txtIGV)
        Me.grpCabecera.Controls.Add(Me.grpNavegar)
        Me.grpCabecera.Controls.Add(Me.Label2)
        Me.grpCabecera.Controls.Add(Me.cmbTipoComprobante)
        Me.grpCabecera.Controls.Add(Me.Label1)
        Me.grpCabecera.Controls.Add(Me.Label15)
        Me.grpCabecera.Controls.Add(Me.Label14)
        Me.grpCabecera.Controls.Add(Me.txtDescripcion)
        Me.grpCabecera.Controls.Add(Me.txtProveedorNombre)
        Me.grpCabecera.Controls.Add(Me.dtpFechaVenta)
        Me.grpCabecera.Controls.Add(Me.txtProveedorRUC)
        Me.grpCabecera.Controls.Add(Me.Label11)
        Me.grpCabecera.Controls.Add(Me.btnBuscarProveedor)
        Me.grpCabecera.Controls.Add(Me.Label12)
        Me.grpCabecera.Controls.Add(Me.Label13)
        Me.grpCabecera.Controls.Add(Me.btnBuscarFactura)
        Me.grpCabecera.Location = New System.Drawing.Point(7, 6)
        Me.grpCabecera.Name = "grpCabecera"
        Me.grpCabecera.Size = New System.Drawing.Size(946, 155)
        Me.grpCabecera.TabIndex = 75
        Me.grpCabecera.TabStop = False
        Me.grpCabecera.Text = "Cabecera"
        '
        'grpEstadoProceso
        '
        Me.grpEstadoProceso.Controls.Add(Me.rbNoAceptada)
        Me.grpEstadoProceso.Controls.Add(Me.rbAceptada)
        Me.grpEstadoProceso.Controls.Add(Me.rbPendiente)
        Me.grpEstadoProceso.Location = New System.Drawing.Point(405, 109)
        Me.grpEstadoProceso.Name = "grpEstadoProceso"
        Me.grpEstadoProceso.Size = New System.Drawing.Size(317, 40)
        Me.grpEstadoProceso.TabIndex = 103
        Me.grpEstadoProceso.TabStop = False
        Me.grpEstadoProceso.Text = "Estado Proceso"
        '
        'rbNoAceptada
        '
        Me.rbNoAceptada.AutoSize = True
        Me.rbNoAceptada.Location = New System.Drawing.Point(211, 15)
        Me.rbNoAceptada.Name = "rbNoAceptada"
        Me.rbNoAceptada.Size = New System.Drawing.Size(94, 19)
        Me.rbNoAceptada.TabIndex = 2
        Me.rbNoAceptada.Text = "No Aceptada"
        Me.rbNoAceptada.UseVisualStyleBackColor = True
        '
        'rbAceptada
        '
        Me.rbAceptada.AutoSize = True
        Me.rbAceptada.Location = New System.Drawing.Point(112, 15)
        Me.rbAceptada.Name = "rbAceptada"
        Me.rbAceptada.Size = New System.Drawing.Size(76, 19)
        Me.rbAceptada.TabIndex = 1
        Me.rbAceptada.Text = "Aceptada"
        Me.rbAceptada.UseVisualStyleBackColor = True
        '
        'rbPendiente
        '
        Me.rbPendiente.AutoSize = True
        Me.rbPendiente.Checked = True
        Me.rbPendiente.Location = New System.Drawing.Point(6, 15)
        Me.rbPendiente.Name = "rbPendiente"
        Me.rbPendiente.Size = New System.Drawing.Size(79, 19)
        Me.rbPendiente.TabIndex = 0
        Me.rbPendiente.TabStop = True
        Me.rbPendiente.Text = "Pendiente"
        Me.rbPendiente.UseVisualStyleBackColor = True
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Location = New System.Drawing.Point(366, 41)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(35, 15)
        Me.lblCodigoCliente.TabIndex = 101
        Me.lblCodigoCliente.Text = "0912"
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtNumero.Location = New System.Drawing.Point(189, 34)
        Me.txtNumero.Mask = "00000000"
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(112, 30)
        Me.txtNumero.TabIndex = 3
        Me.txtNumero.Text = "00000000"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerie
        '
        Me.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerie.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(116, 34)
        Me.txtSerie.Mask = "L000"
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(67, 30)
        Me.txtSerie.TabIndex = 2
        Me.txtSerie.Text = "G000"
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIGV
        '
        Me.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtIGV.Location = New System.Drawing.Point(864, 83)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(52, 27)
        Me.txtIGV.TabIndex = 102
        Me.txtIGV.Text = "0.00"
        Me.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpNavegar
        '
        Me.grpNavegar.Controls.Add(Me.btnUltimo)
        Me.grpNavegar.Controls.Add(Me.btnAtras)
        Me.grpNavegar.Controls.Add(Me.btnSiguiente)
        Me.grpNavegar.Controls.Add(Me.btnPrimero)
        Me.grpNavegar.Controls.Add(Me.cmbAnioPeriodo)
        Me.grpNavegar.Location = New System.Drawing.Point(12, 67)
        Me.grpNavegar.Name = "grpNavegar"
        Me.grpNavegar.Size = New System.Drawing.Size(387, 54)
        Me.grpNavegar.TabIndex = 100
        Me.grpNavegar.TabStop = False
        Me.grpNavegar.Text = "Navegar"
        '
        'btnUltimo
        '
        Me.btnUltimo.BackColor = System.Drawing.Color.White
        Me.btnUltimo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Image = Global.SistemaServox2015.My.Resources.Resources.resultset_last
        Me.btnUltimo.Location = New System.Drawing.Point(197, 20)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(56, 28)
        Me.btnUltimo.TabIndex = 74
        Me.btnUltimo.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.White
        Me.btnAtras.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.SistemaServox2015.My.Resources.Resources.resultset_previous
        Me.btnAtras.Location = New System.Drawing.Point(73, 20)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(56, 28)
        Me.btnAtras.TabIndex = 72
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.White
        Me.btnSiguiente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Image = Global.SistemaServox2015.My.Resources.Resources.resultset_next
        Me.btnSiguiente.Location = New System.Drawing.Point(135, 20)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(56, 28)
        Me.btnSiguiente.TabIndex = 73
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnPrimero
        '
        Me.btnPrimero.BackColor = System.Drawing.Color.White
        Me.btnPrimero.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Image = Global.SistemaServox2015.My.Resources.Resources.resultset_first
        Me.btnPrimero.Location = New System.Drawing.Point(11, 20)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(56, 28)
        Me.btnPrimero.TabIndex = 71
        Me.btnPrimero.UseVisualStyleBackColor = False
        '
        'cmbAnioPeriodo
        '
        Me.cmbAnioPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnioPeriodo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnioPeriodo.FormattingEnabled = True
        Me.cmbAnioPeriodo.Location = New System.Drawing.Point(259, 20)
        Me.cmbAnioPeriodo.Name = "cmbAnioPeriodo"
        Me.cmbAnioPeriodo.Size = New System.Drawing.Size(88, 27)
        Me.cmbAnioPeriodo.TabIndex = 75
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
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoComprobante.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoComprobante.FormattingEnabled = True
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(12, 36)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(98, 27)
        Me.cmbTipoComprobante.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(741, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Fecha Venta"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(890, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 15)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "IGV"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(405, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 15)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Nota :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(405, 82)
        Me.txtDescripcion.MaxLength = 350
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(317, 27)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProveedorNombre
        '
        Me.txtProveedorNombre.BackColor = System.Drawing.SystemColors.Info
        Me.txtProveedorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedorNombre.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorNombre.Location = New System.Drawing.Point(625, 37)
        Me.txtProveedorNombre.MaxLength = 350
        Me.txtProveedorNombre.Name = "txtProveedorNombre"
        Me.txtProveedorNombre.Size = New System.Drawing.Size(313, 27)
        Me.txtProveedorNombre.TabIndex = 82
        Me.txtProveedorNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenta.Location = New System.Drawing.Point(731, 84)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(116, 27)
        Me.dtpFechaVenta.TabIndex = 6
        '
        'txtProveedorRUC
        '
        Me.txtProveedorRUC.BackColor = System.Drawing.SystemColors.Info
        Me.txtProveedorRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedorRUC.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorRUC.Location = New System.Drawing.Point(405, 36)
        Me.txtProveedorRUC.MaxLength = 11
        Me.txtProveedorRUC.Name = "txtProveedorRUC"
        Me.txtProveedorRUC.Size = New System.Drawing.Size(155, 27)
        Me.txtProveedorRUC.TabIndex = 4
        Me.txtProveedorRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(121, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Serie"
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.BackColor = System.Drawing.Color.White
        Me.btnBuscarProveedor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProveedor.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(566, 35)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(53, 28)
        Me.btnBuscarProveedor.TabIndex = 81
        Me.btnBuscarProveedor.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(195, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 15)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Número"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(402, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 15)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Proveedor"
        '
        'btnBuscarFactura
        '
        Me.btnBuscarFactura.BackColor = System.Drawing.Color.White
        Me.btnBuscarFactura.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarFactura.ForeColor = System.Drawing.Color.White
        Me.btnBuscarFactura.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnBuscarFactura.Location = New System.Drawing.Point(307, 35)
        Me.btnBuscarFactura.Name = "btnBuscarFactura"
        Me.btnBuscarFactura.Size = New System.Drawing.Size(53, 28)
        Me.btnBuscarFactura.TabIndex = 80
        Me.btnBuscarFactura.Text = "&F"
        Me.btnBuscarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarFactura.UseVisualStyleBackColor = False
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.OliveDrab
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(977, 25)
        Me.txtTitulo.TabIndex = 82
        Me.txtTitulo.Text = "Mantenimiento Garantia"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ErrorVentas
        '
        Me.ErrorVentas.ContainerControl = Me
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(450, 568)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 28)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "C&ancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaServox2015.My.Resources.Resources.disk
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(160, 568)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 28)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(825, 568)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 84
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SistemaServox2015.My.Resources.Resources.add
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(14, 568)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevo.TabIndex = 17
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(306, 568)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 28)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.BackColor = System.Drawing.Color.White
        Me.btnAnular.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.Image = Global.SistemaServox2015.My.Resources.Resources.delete
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnular.Location = New System.Drawing.Point(596, 568)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(140, 28)
        Me.btnAnular.TabIndex = 21
        Me.btnAnular.Text = "&Anular"
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'frmMantenimientoGarantia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 600)
        Me.Controls.Add(Me.pnlControlProducto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.tbcVentas)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAnular)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMantenimientoGarantia"
        Me.tbcVentas.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.grpDetalleCompra.ResumeLayout(False)
        Me.grpDetalleCompra.PerformLayout()
        Me.pnlControlProducto.ResumeLayout(False)
        Me.pnlControlProducto.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCabecera.ResumeLayout(False)
        Me.grpCabecera.PerformLayout()
        Me.grpEstadoProceso.ResumeLayout(False)
        Me.grpEstadoProceso.PerformLayout()
        Me.grpNavegar.ResumeLayout(False)
        CType(Me.ErrorVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents tbcVentas As System.Windows.Forms.TabControl
    Friend WithEvents tbpListar As System.Windows.Forms.TabPage
    Friend WithEvents grpDetalleCompra As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnQuitarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIGV As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleGarantia As System.Windows.Forms.DataGridView
    Friend WithEvents grpCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSerie As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents grpNavegar As System.Windows.Forms.GroupBox
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents cmbAnioPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedorNombre As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaVenta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtProveedorRUC As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarProveedor As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarFactura As System.Windows.Forms.Button
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents pnlControlProducto As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIGVTotal As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtTotalSinIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelarProducto As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarProducto As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblProductoConIGV As System.Windows.Forms.Label
    Friend WithEvents lblProductoIGV As System.Windows.Forms.Label
    Friend WithEvents lblProductoSinIGV As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalConIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtCostoConIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtIGVCosto As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtCosto As SistemaServox2015.MoneyTextBox
    Friend WithEvents cmbUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblTituloPanel As System.Windows.Forms.Label
    Friend WithEvents ErrorVentas As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblCodigoCliente As System.Windows.Forms.Label
    Friend WithEvents nudCantidad As SistemaServox2015.MoneyTextBox0
    Friend WithEvents chkActualizarPrecioVenta As System.Windows.Forms.CheckBox
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
    Friend WithEvents btnCodigosProducto As System.Windows.Forms.Button
    Friend WithEvents IdDetalleVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidadSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidadIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidadConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rtbObservacionDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents grpEstadoProceso As System.Windows.Forms.GroupBox
    Friend WithEvents rbNoAceptada As System.Windows.Forms.RadioButton
    Friend WithEvents rbAceptada As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendiente As System.Windows.Forms.RadioButton
End Class
