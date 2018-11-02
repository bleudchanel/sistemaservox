<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoComprasConIGV
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
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.tbcCompras = New System.Windows.Forms.TabControl()
        Me.tbpListar = New System.Windows.Forms.TabPage()
        Me.grpDetalleCompra = New System.Windows.Forms.GroupBox()
        Me.grpMoneda = New System.Windows.Forms.GroupBox()
        Me.rbDolares = New System.Windows.Forms.RadioButton()
        Me.rbSoles = New System.Windows.Forms.RadioButton()
        Me.btnCodigosProducto = New System.Windows.Forms.Button()
        Me.txtBusquedaDetalle = New System.Windows.Forms.TextBox()
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
        Me.dgvDetalleCompra = New System.Windows.Forms.DataGridView()
        Me.IdDetalleCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoUnidadSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoUnidadIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoUnidadConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotalSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotalIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTotalConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCabecera = New System.Windows.Forms.GroupBox()
        Me.chkActivarBloqueado = New System.Windows.Forms.CheckBox()
        Me.lblCodigoProveedor = New System.Windows.Forms.Label()
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
        Me.dtpFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.txtProveedorRUC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBuscarFactura = New System.Windows.Forms.Button()
        Me.tbpDatosExtra = New System.Windows.Forms.TabPage()
        Me.grpTransporte = New System.Windows.Forms.GroupBox()
        Me.btnQuitarTransporte = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtObservacionTransporte = New System.Windows.Forms.TextBox()
        Me.txtRegularConcept = New System.Windows.Forms.TextBox()
        Me.txtNumeroTransporte = New System.Windows.Forms.MaskedTextBox()
        Me.txtSerieTransporte = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdTransporte = New System.Windows.Forms.TextBox()
        Me.btnBuscarProveedorTransporte = New System.Windows.Forms.Button()
        Me.txtMontoTransporte = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtTransporteNombre = New System.Windows.Forms.TextBox()
        Me.txtTransporteRUC = New System.Windows.Forms.TextBox()
        Me.pnlControlProducto = New System.Windows.Forms.Panel()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.chkActualizaPrecioCompra = New System.Windows.Forms.CheckBox()
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
        Me.subIdMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCosteSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCosteConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCosteIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subPrecioSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subCodigoMonedaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnConfirmarProducto = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblProductoConIGV = New System.Windows.Forms.Label()
        Me.lblProductoIGV = New System.Windows.Forms.Label()
        Me.lblProductoSinIGV = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMedida = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalConIGV = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtCostoConIGV = New SistemaServox2015.MoneyTextBox8(Me.components)
        Me.txtIGVCosto = New SistemaServox2015.MoneyTextBox8(Me.components)
        Me.txtCosto = New SistemaServox2015.MoneyTextBox8(Me.components)
        Me.cmbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblTituloPanel = New System.Windows.Forms.Label()
        Me.ErrorCompras = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.tbcCompras.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        Me.grpDetalleCompra.SuspendLayout()
        Me.grpMoneda.SuspendLayout()
        CType(Me.dgvDetalleCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCabecera.SuspendLayout()
        Me.grpNavegar.SuspendLayout()
        Me.tbpDatosExtra.SuspendLayout()
        Me.grpTransporte.SuspendLayout()
        Me.pnlControlProducto.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(991, 22)
        Me.txtTitulo.TabIndex = 26
        Me.txtTitulo.Text = "MANTENIMIENTO DE COMPRAS CON IGV"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbcCompras
        '
        Me.tbcCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcCompras.Controls.Add(Me.tbpListar)
        Me.tbcCompras.Controls.Add(Me.tbpDatosExtra)
        Me.tbcCompras.Location = New System.Drawing.Point(3, 26)
        Me.tbcCompras.Name = "tbcCompras"
        Me.tbcCompras.SelectedIndex = 0
        Me.tbcCompras.Size = New System.Drawing.Size(977, 534)
        Me.tbcCompras.TabIndex = 27
        '
        'tbpListar
        '
        Me.tbpListar.Controls.Add(Me.grpDetalleCompra)
        Me.tbpListar.Controls.Add(Me.grpCabecera)
        Me.tbpListar.Location = New System.Drawing.Point(4, 24)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpListar.Size = New System.Drawing.Size(969, 506)
        Me.tbpListar.TabIndex = 0
        Me.tbpListar.Text = "Listar"
        Me.tbpListar.UseVisualStyleBackColor = True
        '
        'grpDetalleCompra
        '
        Me.grpDetalleCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetalleCompra.Controls.Add(Me.grpMoneda)
        Me.grpDetalleCompra.Controls.Add(Me.btnCodigosProducto)
        Me.grpDetalleCompra.Controls.Add(Me.txtBusquedaDetalle)
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
        Me.grpDetalleCompra.Controls.Add(Me.dgvDetalleCompra)
        Me.grpDetalleCompra.Location = New System.Drawing.Point(7, 139)
        Me.grpDetalleCompra.Name = "grpDetalleCompra"
        Me.grpDetalleCompra.Size = New System.Drawing.Size(956, 351)
        Me.grpDetalleCompra.TabIndex = 76
        Me.grpDetalleCompra.TabStop = False
        Me.grpDetalleCompra.Text = "Detalle"
        '
        'grpMoneda
        '
        Me.grpMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpMoneda.Controls.Add(Me.rbDolares)
        Me.grpMoneda.Controls.Add(Me.rbSoles)
        Me.grpMoneda.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMoneda.Location = New System.Drawing.Point(421, 304)
        Me.grpMoneda.Name = "grpMoneda"
        Me.grpMoneda.Size = New System.Drawing.Size(193, 43)
        Me.grpMoneda.TabIndex = 86
        Me.grpMoneda.TabStop = False
        Me.grpMoneda.Text = "Moneda"
        '
        'rbDolares
        '
        Me.rbDolares.AutoSize = True
        Me.rbDolares.Checked = True
        Me.rbDolares.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDolares.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbDolares.Location = New System.Drawing.Point(93, 17)
        Me.rbDolares.Name = "rbDolares"
        Me.rbDolares.Size = New System.Drawing.Size(71, 22)
        Me.rbDolares.TabIndex = 1
        Me.rbDolares.TabStop = True
        Me.rbDolares.Text = "Dólares"
        Me.rbDolares.UseVisualStyleBackColor = True
        '
        'rbSoles
        '
        Me.rbSoles.AutoSize = True
        Me.rbSoles.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSoles.ForeColor = System.Drawing.Color.Black
        Me.rbSoles.Location = New System.Drawing.Point(32, 16)
        Me.rbSoles.Name = "rbSoles"
        Me.rbSoles.Size = New System.Drawing.Size(57, 22)
        Me.rbSoles.TabIndex = 0
        Me.rbSoles.TabStop = True
        Me.rbSoles.Text = "Soles"
        Me.rbSoles.UseVisualStyleBackColor = True
        '
        'btnCodigosProducto
        '
        Me.btnCodigosProducto.BackColor = System.Drawing.Color.White
        Me.btnCodigosProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCodigosProducto.Image = Global.SistemaServox2015.My.Resources.Resources.add
        Me.btnCodigosProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCodigosProducto.Location = New System.Drawing.Point(228, 14)
        Me.btnCodigosProducto.Name = "btnCodigosProducto"
        Me.btnCodigosProducto.Size = New System.Drawing.Size(105, 28)
        Me.btnCodigosProducto.TabIndex = 84
        Me.btnCodigosProducto.Text = "&Series"
        Me.btnCodigosProducto.UseVisualStyleBackColor = False
        '
        'txtBusquedaDetalle
        '
        Me.txtBusquedaDetalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtBusquedaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusquedaDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusquedaDetalle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaDetalle.Location = New System.Drawing.Point(6, 19)
        Me.txtBusquedaDetalle.MaxLength = 350
        Me.txtBusquedaDetalle.Name = "txtBusquedaDetalle"
        Me.txtBusquedaDetalle.Size = New System.Drawing.Size(216, 23)
        Me.txtBusquedaDetalle.TabIndex = 83
        Me.txtBusquedaDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnModificarDetalle
        '
        Me.btnModificarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarDetalle.BackColor = System.Drawing.Color.White
        Me.btnModificarDetalle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDetalle.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnModificarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarDetalle.Location = New System.Drawing.Point(664, 14)
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
        Me.btnQuitarDetalle.Location = New System.Drawing.Point(810, 14)
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
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(518, 14)
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
        Me.Label19.Location = New System.Drawing.Point(3, 301)
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
        Me.txtObservacion.Location = New System.Drawing.Point(6, 318)
        Me.txtObservacion.MaxLength = 350
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(410, 27)
        Me.txtObservacion.TabIndex = 81
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(845, 302)
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
        Me.Label17.Location = New System.Drawing.Point(740, 302)
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
        Me.Label16.Location = New System.Drawing.Point(629, 302)
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
        Me.txtTotal.Location = New System.Drawing.Point(848, 320)
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
        Me.txtTotalIGV.Location = New System.Drawing.Point(740, 320)
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
        Me.txtSubTotal.Location = New System.Drawing.Point(632, 320)
        Me.txtSubTotal.MaxLength = 350
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(102, 27)
        Me.txtSubTotal.TabIndex = 75
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalleCompra
        '
        Me.dgvDetalleCompra.AllowUserToAddRows = False
        Me.dgvDetalleCompra.AllowUserToDeleteRows = False
        Me.dgvDetalleCompra.AllowUserToOrderColumns = True
        Me.dgvDetalleCompra.AllowUserToResizeRows = False
        Me.dgvDetalleCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleCompra.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalleCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalleCompra, Me.IdProducto, Me.CodigoProducto, Me.DescripcionProducto, Me.Cantidad, Me.IdUnidadMedida, Me.UnidadMedida, Me.CostoUnidadSinIGV, Me.CostoUnidadIGV, Me.CostoUnidadConIGV, Me.CostoTotalSinIGV, Me.CostoTotalIGV, Me.CostoTotalConIGV, Me.Estado})
        Me.dgvDetalleCompra.EnableHeadersVisualStyles = False
        Me.dgvDetalleCompra.Location = New System.Drawing.Point(6, 45)
        Me.dgvDetalleCompra.MultiSelect = False
        Me.dgvDetalleCompra.Name = "dgvDetalleCompra"
        Me.dgvDetalleCompra.ReadOnly = True
        Me.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCompra.Size = New System.Drawing.Size(944, 256)
        Me.dgvDetalleCompra.TabIndex = 34
        '
        'IdDetalleCompra
        '
        Me.IdDetalleCompra.HeaderText = "IdDetalleCompra"
        Me.IdDetalleCompra.Name = "IdDetalleCompra"
        Me.IdDetalleCompra.ReadOnly = True
        Me.IdDetalleCompra.Visible = False
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
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoProducto.DefaultCellStyle = DataGridViewCellStyle23
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
        Me.DescripcionProducto.Width = 350
        '
        'Cantidad
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle24
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
        'CostoUnidadSinIGV
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoUnidadSinIGV.DefaultCellStyle = DataGridViewCellStyle25
        Me.CostoUnidadSinIGV.HeaderText = "Costo"
        Me.CostoUnidadSinIGV.Name = "CostoUnidadSinIGV"
        Me.CostoUnidadSinIGV.ReadOnly = True
        Me.CostoUnidadSinIGV.Visible = False
        Me.CostoUnidadSinIGV.Width = 80
        '
        'CostoUnidadIGV
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoUnidadIGV.DefaultCellStyle = DataGridViewCellStyle26
        Me.CostoUnidadIGV.HeaderText = "IGV"
        Me.CostoUnidadIGV.Name = "CostoUnidadIGV"
        Me.CostoUnidadIGV.ReadOnly = True
        Me.CostoUnidadIGV.Visible = False
        Me.CostoUnidadIGV.Width = 70
        '
        'CostoUnidadConIGV
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoUnidadConIGV.DefaultCellStyle = DataGridViewCellStyle27
        Me.CostoUnidadConIGV.HeaderText = "Unidad + IGV"
        Me.CostoUnidadConIGV.Name = "CostoUnidadConIGV"
        Me.CostoUnidadConIGV.ReadOnly = True
        Me.CostoUnidadConIGV.Width = 120
        '
        'CostoTotalSinIGV
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoTotalSinIGV.DefaultCellStyle = DataGridViewCellStyle28
        Me.CostoTotalSinIGV.HeaderText = "Total"
        Me.CostoTotalSinIGV.Name = "CostoTotalSinIGV"
        Me.CostoTotalSinIGV.ReadOnly = True
        Me.CostoTotalSinIGV.Visible = False
        '
        'CostoTotalIGV
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoTotalIGV.DefaultCellStyle = DataGridViewCellStyle29
        Me.CostoTotalIGV.HeaderText = "IGV Total"
        Me.CostoTotalIGV.Name = "CostoTotalIGV"
        Me.CostoTotalIGV.ReadOnly = True
        Me.CostoTotalIGV.Visible = False
        '
        'CostoTotalConIGV
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoTotalConIGV.DefaultCellStyle = DataGridViewCellStyle30
        Me.CostoTotalConIGV.HeaderText = "Total + IGV"
        Me.CostoTotalConIGV.Name = "CostoTotalConIGV"
        Me.CostoTotalConIGV.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'grpCabecera
        '
        Me.grpCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCabecera.Controls.Add(Me.chkActivarBloqueado)
        Me.grpCabecera.Controls.Add(Me.lblCodigoProveedor)
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
        Me.grpCabecera.Controls.Add(Me.dtpFechaCompra)
        Me.grpCabecera.Controls.Add(Me.txtProveedorRUC)
        Me.grpCabecera.Controls.Add(Me.Label11)
        Me.grpCabecera.Controls.Add(Me.btnBuscarProveedor)
        Me.grpCabecera.Controls.Add(Me.Label12)
        Me.grpCabecera.Controls.Add(Me.Label13)
        Me.grpCabecera.Controls.Add(Me.btnBuscarFactura)
        Me.grpCabecera.Location = New System.Drawing.Point(7, 6)
        Me.grpCabecera.Name = "grpCabecera"
        Me.grpCabecera.Size = New System.Drawing.Size(956, 127)
        Me.grpCabecera.TabIndex = 75
        Me.grpCabecera.TabStop = False
        Me.grpCabecera.Text = "Cabecera"
        '
        'chkActivarBloqueado
        '
        Me.chkActivarBloqueado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkActivarBloqueado.AutoSize = True
        Me.chkActivarBloqueado.Location = New System.Drawing.Point(882, 14)
        Me.chkActivarBloqueado.Name = "chkActivarBloqueado"
        Me.chkActivarBloqueado.Size = New System.Drawing.Size(64, 19)
        Me.chkActivarBloqueado.TabIndex = 204
        Me.chkActivarBloqueado.Text = "Activar"
        Me.chkActivarBloqueado.UseVisualStyleBackColor = True
        '
        'lblCodigoProveedor
        '
        Me.lblCodigoProveedor.AutoSize = True
        Me.lblCodigoProveedor.Location = New System.Drawing.Point(381, 43)
        Me.lblCodigoProveedor.Name = "lblCodigoProveedor"
        Me.lblCodigoProveedor.Size = New System.Drawing.Size(35, 15)
        Me.lblCodigoProveedor.TabIndex = 102
        Me.lblCodigoProveedor.Text = "0912"
        Me.lblCodigoProveedor.Visible = False
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
        Me.txtSerie.Mask = "000"
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(67, 30)
        Me.txtSerie.TabIndex = 2
        Me.txtSerie.Text = "000"
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIGV
        '
        Me.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtIGV.Location = New System.Drawing.Point(883, 87)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(63, 27)
        Me.txtIGV.TabIndex = 203
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
        Me.grpNavegar.Size = New System.Drawing.Size(363, 54)
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
        Me.btnUltimo.TabIndex = 69
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
        Me.btnAtras.TabIndex = 67
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
        Me.btnSiguiente.TabIndex = 68
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
        Me.btnPrimero.TabIndex = 65
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
        Me.cmbAnioPeriodo.TabIndex = 70
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
        Me.Label1.Location = New System.Drawing.Point(744, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Fecha Compra"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(891, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 15)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "IGV"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(390, 70)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(393, 88)
        Me.txtDescripcion.MaxLength = 350
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(343, 27)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProveedorNombre
        '
        Me.txtProveedorNombre.BackColor = System.Drawing.SystemColors.Info
        Me.txtProveedorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedorNombre.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorNombre.Location = New System.Drawing.Point(632, 35)
        Me.txtProveedorNombre.MaxLength = 350
        Me.txtProveedorNombre.Name = "txtProveedorNombre"
        Me.txtProveedorNombre.Size = New System.Drawing.Size(314, 27)
        Me.txtProveedorNombre.TabIndex = 202
        Me.txtProveedorNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFechaCompra
        '
        Me.dtpFechaCompra.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCompra.Location = New System.Drawing.Point(742, 88)
        Me.dtpFechaCompra.Name = "dtpFechaCompra"
        Me.dtpFechaCompra.Size = New System.Drawing.Size(116, 27)
        Me.dtpFechaCompra.TabIndex = 6
        '
        'txtProveedorRUC
        '
        Me.txtProveedorRUC.BackColor = System.Drawing.SystemColors.Info
        Me.txtProveedorRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedorRUC.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorRUC.Location = New System.Drawing.Point(422, 36)
        Me.txtProveedorRUC.MaxLength = 11
        Me.txtProveedorRUC.Name = "txtProveedorRUC"
        Me.txtProveedorRUC.Size = New System.Drawing.Size(145, 27)
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
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(573, 36)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(53, 28)
        Me.btnBuscarProveedor.TabIndex = 201
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
        Me.Label13.Location = New System.Drawing.Point(419, 16)
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
        Me.btnBuscarFactura.TabIndex = 71
        Me.btnBuscarFactura.Text = "&F"
        Me.btnBuscarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarFactura.UseVisualStyleBackColor = False
        '
        'tbpDatosExtra
        '
        Me.tbpDatosExtra.Controls.Add(Me.grpTransporte)
        Me.tbpDatosExtra.Location = New System.Drawing.Point(4, 24)
        Me.tbpDatosExtra.Name = "tbpDatosExtra"
        Me.tbpDatosExtra.Size = New System.Drawing.Size(969, 506)
        Me.tbpDatosExtra.TabIndex = 1
        Me.tbpDatosExtra.Text = "Datos Extra"
        Me.tbpDatosExtra.UseVisualStyleBackColor = True
        '
        'grpTransporte
        '
        Me.grpTransporte.Controls.Add(Me.btnQuitarTransporte)
        Me.grpTransporte.Controls.Add(Me.Label21)
        Me.grpTransporte.Controls.Add(Me.txtObservacionTransporte)
        Me.grpTransporte.Controls.Add(Me.txtRegularConcept)
        Me.grpTransporte.Controls.Add(Me.txtNumeroTransporte)
        Me.grpTransporte.Controls.Add(Me.txtSerieTransporte)
        Me.grpTransporte.Controls.Add(Me.Label20)
        Me.grpTransporte.Controls.Add(Me.Label7)
        Me.grpTransporte.Controls.Add(Me.Label6)
        Me.grpTransporte.Controls.Add(Me.txtIdTransporte)
        Me.grpTransporte.Controls.Add(Me.btnBuscarProveedorTransporte)
        Me.grpTransporte.Controls.Add(Me.txtMontoTransporte)
        Me.grpTransporte.Controls.Add(Me.txtTransporteNombre)
        Me.grpTransporte.Controls.Add(Me.txtTransporteRUC)
        Me.grpTransporte.Location = New System.Drawing.Point(7, 12)
        Me.grpTransporte.Name = "grpTransporte"
        Me.grpTransporte.Size = New System.Drawing.Size(418, 273)
        Me.grpTransporte.TabIndex = 3
        Me.grpTransporte.TabStop = False
        Me.grpTransporte.Text = "Transporte"
        '
        'btnQuitarTransporte
        '
        Me.btnQuitarTransporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarTransporte.BackColor = System.Drawing.Color.White
        Me.btnQuitarTransporte.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarTransporte.Image = Global.SistemaServox2015.My.Resources.Resources.delete
        Me.btnQuitarTransporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitarTransporte.Location = New System.Drawing.Point(8, 239)
        Me.btnQuitarTransporte.Name = "btnQuitarTransporte"
        Me.btnQuitarTransporte.Size = New System.Drawing.Size(140, 28)
        Me.btnQuitarTransporte.TabIndex = 108
        Me.btnQuitarTransporte.Text = "&Quitar"
        Me.btnQuitarTransporte.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 179)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 15)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Nota"
        '
        'txtObservacionTransporte
        '
        Me.txtObservacionTransporte.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtObservacionTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacionTransporte.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionTransporte.Location = New System.Drawing.Point(6, 197)
        Me.txtObservacionTransporte.MaxLength = 350
        Me.txtObservacionTransporte.Name = "txtObservacionTransporte"
        Me.txtObservacionTransporte.ReadOnly = True
        Me.txtObservacionTransporte.Size = New System.Drawing.Size(406, 27)
        Me.txtObservacionTransporte.TabIndex = 103
        Me.txtObservacionTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRegularConcept
        '
        Me.txtRegularConcept.BackColor = System.Drawing.SystemColors.Control
        Me.txtRegularConcept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegularConcept.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegularConcept.Location = New System.Drawing.Point(6, 76)
        Me.txtRegularConcept.MaxLength = 350
        Me.txtRegularConcept.Name = "txtRegularConcept"
        Me.txtRegularConcept.ReadOnly = True
        Me.txtRegularConcept.Size = New System.Drawing.Size(406, 27)
        Me.txtRegularConcept.TabIndex = 90
        Me.txtRegularConcept.Text = "COSTO POR TRANSPORTE"
        Me.txtRegularConcept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroTransporte
        '
        Me.txtNumeroTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroTransporte.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroTransporte.Location = New System.Drawing.Point(81, 40)
        Me.txtNumeroTransporte.Mask = "00000000"
        Me.txtNumeroTransporte.Name = "txtNumeroTransporte"
        Me.txtNumeroTransporte.ReadOnly = True
        Me.txtNumeroTransporte.Size = New System.Drawing.Size(112, 30)
        Me.txtNumeroTransporte.TabIndex = 101
        Me.txtNumeroTransporte.Text = "00000000"
        Me.txtNumeroTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerieTransporte
        '
        Me.txtSerieTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerieTransporte.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieTransporte.Location = New System.Drawing.Point(8, 40)
        Me.txtSerieTransporte.Mask = "000"
        Me.txtSerieTransporte.Name = "txtSerieTransporte"
        Me.txtSerieTransporte.ReadOnly = True
        Me.txtSerieTransporte.Size = New System.Drawing.Size(67, 30)
        Me.txtSerieTransporte.TabIndex = 100
        Me.txtSerieTransporte.Text = "000"
        Me.txtSerieTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(78, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 15)
        Me.Label20.TabIndex = 87
        Me.Label20.Text = "Número"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Serie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 15)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Monto Transporte"
        '
        'txtIdTransporte
        '
        Me.txtIdTransporte.BackColor = System.Drawing.SystemColors.Control
        Me.txtIdTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdTransporte.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTransporte.Location = New System.Drawing.Point(280, 116)
        Me.txtIdTransporte.MaxLength = 350
        Me.txtIdTransporte.Name = "txtIdTransporte"
        Me.txtIdTransporte.ReadOnly = True
        Me.txtIdTransporte.Size = New System.Drawing.Size(37, 27)
        Me.txtIdTransporte.TabIndex = 82
        Me.txtIdTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarProveedorTransporte
        '
        Me.btnBuscarProveedorTransporte.BackColor = System.Drawing.Color.White
        Me.btnBuscarProveedorTransporte.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProveedorTransporte.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarProveedorTransporte.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnBuscarProveedorTransporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarProveedorTransporte.Location = New System.Drawing.Point(146, 116)
        Me.btnBuscarProveedorTransporte.Name = "btnBuscarProveedorTransporte"
        Me.btnBuscarProveedorTransporte.Size = New System.Drawing.Size(128, 28)
        Me.btnBuscarProveedorTransporte.TabIndex = 102
        Me.btnBuscarProveedorTransporte.Text = "&Transporte"
        Me.btnBuscarProveedorTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarProveedorTransporte.UseVisualStyleBackColor = False
        '
        'txtMontoTransporte
        '
        Me.txtMontoTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoTransporte.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtMontoTransporte.Location = New System.Drawing.Point(312, 230)
        Me.txtMontoTransporte.Name = "txtMontoTransporte"
        Me.txtMontoTransporte.ReadOnly = True
        Me.txtMontoTransporte.Size = New System.Drawing.Size(100, 27)
        Me.txtMontoTransporte.TabIndex = 104
        Me.txtMontoTransporte.Text = "0.00"
        Me.txtMontoTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTransporteNombre
        '
        Me.txtTransporteNombre.BackColor = System.Drawing.SystemColors.Control
        Me.txtTransporteNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransporteNombre.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransporteNombre.Location = New System.Drawing.Point(6, 149)
        Me.txtTransporteNombre.MaxLength = 350
        Me.txtTransporteNombre.Name = "txtTransporteNombre"
        Me.txtTransporteNombre.ReadOnly = True
        Me.txtTransporteNombre.Size = New System.Drawing.Size(406, 27)
        Me.txtTransporteNombre.TabIndex = 8
        Me.txtTransporteNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTransporteRUC
        '
        Me.txtTransporteRUC.BackColor = System.Drawing.SystemColors.Control
        Me.txtTransporteRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransporteRUC.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransporteRUC.Location = New System.Drawing.Point(6, 116)
        Me.txtTransporteRUC.MaxLength = 350
        Me.txtTransporteRUC.Name = "txtTransporteRUC"
        Me.txtTransporteRUC.ReadOnly = True
        Me.txtTransporteRUC.Size = New System.Drawing.Size(134, 27)
        Me.txtTransporteRUC.TabIndex = 7
        Me.txtTransporteRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlControlProducto
        '
        Me.pnlControlProducto.BackColor = System.Drawing.Color.White
        Me.pnlControlProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControlProducto.Controls.Add(Me.lblMoneda)
        Me.pnlControlProducto.Controls.Add(Me.chkActualizaPrecioCompra)
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
        Me.pnlControlProducto.Controls.Add(Me.lblMedida)
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
        Me.pnlControlProducto.Location = New System.Drawing.Point(772, 581)
        Me.pnlControlProducto.Name = "pnlControlProducto"
        Me.pnlControlProducto.Size = New System.Drawing.Size(742, 170)
        Me.pnlControlProducto.TabIndex = 57
        Me.pnlControlProducto.Visible = False
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneda.Location = New System.Drawing.Point(570, 108)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(78, 24)
        Me.lblMoneda.TabIndex = 118
        Me.lblMoneda.Text = "Moneda"
        '
        'chkActualizaPrecioCompra
        '
        Me.chkActualizaPrecioCompra.AutoSize = True
        Me.chkActualizaPrecioCompra.Location = New System.Drawing.Point(719, 59)
        Me.chkActualizaPrecioCompra.Name = "chkActualizaPrecioCompra"
        Me.chkActualizaPrecioCompra.Size = New System.Drawing.Size(15, 14)
        Me.chkActualizaPrecioCompra.TabIndex = 117
        Me.chkActualizaPrecioCompra.UseVisualStyleBackColor = True
        Me.chkActualizaPrecioCompra.Visible = False
        '
        'nudCantidad
        '
        Me.nudCantidad.BackColor = System.Drawing.Color.Aquamarine
        Me.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudCantidad.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.nudCantidad.Location = New System.Drawing.Point(504, 22)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(78, 27)
        Me.nudCantidad.TabIndex = 104
        Me.nudCantidad.Text = "0"
        Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(567, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 18)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Total sin IGV"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(581, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 18)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "IGV"
        Me.Label9.Visible = False
        '
        'txtIGVTotal
        '
        Me.txtIGVTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtIGVTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGVTotal.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtIGVTotal.Location = New System.Drawing.Point(646, 132)
        Me.txtIGVTotal.Name = "txtIGVTotal"
        Me.txtIGVTotal.Size = New System.Drawing.Size(95, 27)
        Me.txtIGVTotal.TabIndex = 108
        Me.txtIGVTotal.Text = "0.00"
        Me.txtIGVTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIGVTotal.Visible = False
        '
        'txtTotalSinIGV
        '
        Me.txtTotalSinIGV.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalSinIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalSinIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtTotalSinIGV.Location = New System.Drawing.Point(574, 132)
        Me.txtTotalSinIGV.Name = "txtTotalSinIGV"
        Me.txtTotalSinIGV.ReadOnly = True
        Me.txtTotalSinIGV.Size = New System.Drawing.Size(95, 27)
        Me.txtTotalSinIGV.TabIndex = 104
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
        Me.dgvProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subIdProducto, Me.subCodigoProducto, Me.subDescripcionProducto, Me.subStockActual, Me.subIdMedida, Me.subCosteSinIGV, Me.subCosteConIGV, Me.subCosteIGV, Me.subPrecioSinIGV, Me.subCodigoMonedaCompra})
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
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subCodigoProducto.DefaultCellStyle = DataGridViewCellStyle31
        Me.subCodigoProducto.HeaderText = "Producto"
        Me.subCodigoProducto.Name = "subCodigoProducto"
        Me.subCodigoProducto.ReadOnly = True
        Me.subCodigoProducto.Width = 120
        '
        'subDescripcionProducto
        '
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subDescripcionProducto.DefaultCellStyle = DataGridViewCellStyle32
        Me.subDescripcionProducto.HeaderText = "Descripción"
        Me.subDescripcionProducto.Name = "subDescripcionProducto"
        Me.subDescripcionProducto.ReadOnly = True
        Me.subDescripcionProducto.Width = 200
        '
        'subStockActual
        '
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.NullValue = Nothing
        Me.subStockActual.DefaultCellStyle = DataGridViewCellStyle33
        Me.subStockActual.HeaderText = "Stock"
        Me.subStockActual.Name = "subStockActual"
        Me.subStockActual.ReadOnly = True
        Me.subStockActual.Width = 75
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
        'subCodigoMonedaCompra
        '
        Me.subCodigoMonedaCompra.HeaderText = "CodigoMonedaCompra"
        Me.subCodigoMonedaCompra.Name = "subCodigoMonedaCompra"
        Me.subCodigoMonedaCompra.ReadOnly = True
        Me.subCodigoMonedaCompra.Visible = False
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.BackColor = System.Drawing.Color.White
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelarProducto.Location = New System.Drawing.Point(646, 22)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(56, 28)
        Me.btnCancelarProducto.TabIndex = 107
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
        Me.btnConfirmarProducto.TabIndex = 106
        Me.btnConfirmarProducto.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(440, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 18)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Total + IGV"
        '
        'lblProductoConIGV
        '
        Me.lblProductoConIGV.AutoSize = True
        Me.lblProductoConIGV.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoConIGV.Location = New System.Drawing.Point(440, 61)
        Me.lblProductoConIGV.Name = "lblProductoConIGV"
        Me.lblProductoConIGV.Size = New System.Drawing.Size(74, 18)
        Me.lblProductoConIGV.TabIndex = 109
        Me.lblProductoConIGV.Text = "Unidad +IGV"
        '
        'lblProductoIGV
        '
        Me.lblProductoIGV.AutoSize = True
        Me.lblProductoIGV.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoIGV.Location = New System.Drawing.Point(643, 61)
        Me.lblProductoIGV.Name = "lblProductoIGV"
        Me.lblProductoIGV.Size = New System.Drawing.Size(68, 18)
        Me.lblProductoIGV.TabIndex = 108
        Me.lblProductoIGV.Text = "Unidad IGV"
        Me.lblProductoIGV.Visible = False
        '
        'lblProductoSinIGV
        '
        Me.lblProductoSinIGV.AutoSize = True
        Me.lblProductoSinIGV.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoSinIGV.Location = New System.Drawing.Point(574, 61)
        Me.lblProductoSinIGV.Name = "lblProductoSinIGV"
        Me.lblProductoSinIGV.Size = New System.Drawing.Size(46, 18)
        Me.lblProductoSinIGV.TabIndex = 107
        Me.lblProductoSinIGV.Text = "Unidad"
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
        'lblMedida
        '
        Me.lblMedida.AutoSize = True
        Me.lblMedida.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedida.Location = New System.Drawing.Point(407, 5)
        Me.lblMedida.Name = "lblMedida"
        Me.lblMedida.Size = New System.Drawing.Size(48, 18)
        Me.lblMedida.TabIndex = 105
        Me.lblMedida.Text = "Medida"
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
        Me.txtTotalConIGV.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalConIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalConIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtTotalConIGV.Location = New System.Drawing.Point(440, 132)
        Me.txtTotalConIGV.Name = "txtTotalConIGV"
        Me.txtTotalConIGV.Size = New System.Drawing.Size(126, 27)
        Me.txtTotalConIGV.TabIndex = 105
        Me.txtTotalConIGV.Text = "0.00"
        Me.txtTotalConIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostoConIGV
        '
        Me.txtCostoConIGV.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCostoConIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoConIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtCostoConIGV.Location = New System.Drawing.Point(440, 81)
        Me.txtCostoConIGV.Name = "txtCostoConIGV"
        Me.txtCostoConIGV.Size = New System.Drawing.Size(126, 27)
        Me.txtCostoConIGV.TabIndex = 112
        Me.txtCostoConIGV.Text = "0.00"
        Me.txtCostoConIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIGVCosto
        '
        Me.txtIGVCosto.BackColor = System.Drawing.Color.White
        Me.txtIGVCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGVCosto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtIGVCosto.Location = New System.Drawing.Point(646, 81)
        Me.txtIGVCosto.Name = "txtIGVCosto"
        Me.txtIGVCosto.ReadOnly = True
        Me.txtIGVCosto.Size = New System.Drawing.Size(95, 27)
        Me.txtIGVCosto.TabIndex = 111
        Me.txtIGVCosto.Text = "0.00"
        Me.txtIGVCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIGVCosto.Visible = False
        '
        'txtCosto
        '
        Me.txtCosto.BackColor = System.Drawing.Color.Azure
        Me.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCosto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtCosto.Location = New System.Drawing.Point(574, 81)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(95, 27)
        Me.txtCosto.TabIndex = 110
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
        Me.txtDescripcionProducto.TabIndex = 101
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
        Me.txtCodigoProducto.TabIndex = 100
        Me.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTituloPanel
        '
        Me.lblTituloPanel.AutoSize = True
        Me.lblTituloPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPanel.Location = New System.Drawing.Point(3, 3)
        Me.lblTituloPanel.Name = "lblTituloPanel"
        Me.lblTituloPanel.Size = New System.Drawing.Size(64, 18)
        Me.lblTituloPanel.TabIndex = 21
        Me.lblTituloPanel.Text = "Producto"
        '
        'ErrorCompras
        '
        Me.ErrorCompras.ContainerControl = Me
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(460, 570)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 28)
        Me.btnCancelar.TabIndex = 78
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
        Me.btnGuardar.Location = New System.Drawing.Point(160, 570)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 28)
        Me.btnGuardar.TabIndex = 77
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
        Me.btnCerrar.Location = New System.Drawing.Point(835, 570)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 59
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
        Me.btnNuevo.Location = New System.Drawing.Point(14, 570)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevo.TabIndex = 3
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
        Me.btnModificar.Location = New System.Drawing.Point(306, 570)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 28)
        Me.btnModificar.TabIndex = 4
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
        Me.btnAnular.Location = New System.Drawing.Point(606, 570)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(140, 28)
        Me.btnAnular.TabIndex = 5
        Me.btnAnular.Text = "&Anular"
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'frmMantenimientoComprasConIGV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 607)
        Me.Controls.Add(Me.pnlControlProducto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.tbcCompras)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAnular)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMantenimientoComprasConIGV"
        Me.tbcCompras.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.grpDetalleCompra.ResumeLayout(False)
        Me.grpDetalleCompra.PerformLayout()
        Me.grpMoneda.ResumeLayout(False)
        Me.grpMoneda.PerformLayout()
        CType(Me.dgvDetalleCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCabecera.ResumeLayout(False)
        Me.grpCabecera.PerformLayout()
        Me.grpNavegar.ResumeLayout(False)
        Me.tbpDatosExtra.ResumeLayout(False)
        Me.grpTransporte.ResumeLayout(False)
        Me.grpTransporte.PerformLayout()
        Me.pnlControlProducto.ResumeLayout(False)
        Me.pnlControlProducto.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents tbcCompras As System.Windows.Forms.TabControl
    Friend WithEvents tbpListar As System.Windows.Forms.TabPage
    Friend WithEvents btnBuscarFactura As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtProveedorNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgvDetalleCompra As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents txtProveedorRUC As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarProveedor As System.Windows.Forms.Button
    Friend WithEvents grpDetalleCompra As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIGV As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents grpCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbAnioPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents CostoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnModificarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnQuitarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents grpNavegar As System.Windows.Forms.GroupBox
    Friend WithEvents pnlControlProducto As System.Windows.Forms.Panel
    Friend WithEvents cmbUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblTituloPanel As System.Windows.Forms.Label
    Friend WithEvents txtIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblProductoConIGV As System.Windows.Forms.Label
    Friend WithEvents lblProductoIGV As System.Windows.Forms.Label
    Friend WithEvents lblProductoSinIGV As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMedida As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalConIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtCostoConIGV As SistemaServox2015.MoneyTextBox8
    Friend WithEvents txtIGVCosto As SistemaServox2015.MoneyTextBox8
    Friend WithEvents txtCosto As SistemaServox2015.MoneyTextBox8
    Friend WithEvents btnCancelarProducto As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarProducto As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIGVTotal As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtTotalSinIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSerie As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ErrorCompras As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblCodigoProveedor As System.Windows.Forms.Label
    Friend WithEvents nudCantidad As SistemaServox2015.MoneyTextBox0
    Friend WithEvents chkActualizaPrecioCompra As System.Windows.Forms.CheckBox
    Friend WithEvents txtBusquedaDetalle As System.Windows.Forms.TextBox
    Friend WithEvents btnCodigosProducto As System.Windows.Forms.Button
    Friend WithEvents tbpDatosExtra As System.Windows.Forms.TabPage
    Friend WithEvents chkActivarBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents grpTransporte As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitarTransporte As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtObservacionTransporte As System.Windows.Forms.TextBox
    Friend WithEvents txtRegularConcept As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroTransporte As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSerieTransporte As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdTransporte As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarProveedorTransporte As System.Windows.Forms.Button
    Friend WithEvents txtMontoTransporte As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtTransporteNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtTransporteRUC As System.Windows.Forms.TextBox
    Friend WithEvents IdDetalleCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoUnidadSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoUnidadIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoUnidadConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents rbDolares As System.Windows.Forms.RadioButton
    Friend WithEvents rbSoles As System.Windows.Forms.RadioButton
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents subIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subDescripcionProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subStockActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subIdMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCosteSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCosteConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCosteIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subPrecioSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subCodigoMonedaCompra As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
