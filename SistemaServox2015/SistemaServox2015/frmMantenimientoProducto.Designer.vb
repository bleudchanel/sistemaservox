<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoProducto
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbcProducto = New System.Windows.Forms.TabControl()
        Me.tbpListar = New System.Windows.Forms.TabPage()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.chkMostrarControlesAvanzados = New System.Windows.Forms.CheckBox()
        Me.btnKardex = New System.Windows.Forms.Button()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosteSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGVcoste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosteConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioNetoSinIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGVActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioConIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewImageColumn()
        Me.EstadoBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpNuevo = New System.Windows.Forms.TabPage()
        Me.grpAccion = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.grpMonedaVenta = New System.Windows.Forms.GroupBox()
        Me.rbDolaresVenta = New System.Windows.Forms.RadioButton()
        Me.rbSolesVenta = New System.Windows.Forms.RadioButton()
        Me.grpMonedaCompra = New System.Windows.Forms.GroupBox()
        Me.rbDolaresCompra = New System.Windows.Forms.RadioButton()
        Me.rbSolesCompra = New System.Windows.Forms.RadioButton()
        Me.btnVerOperacion = New System.Windows.Forms.Button()
        Me.lblUltimaModificacion = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrecioCosteSinIGV = New SistemaServox2015.MoneyTextBox8(Me.components)
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIGVActual = New System.Windows.Forms.Label()
        Me.txtPrecioVentaConIGV = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtPrecioVenta = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtPrecioCosteConIGV = New SistemaServox2015.MoneyTextBox8(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcionProveedor = New System.Windows.Forms.TextBox()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.txtRucProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudStockMinimo = New System.Windows.Forms.NumericUpDown()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.Operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.tbpDatosExtra = New System.Windows.Forms.TabPage()
        Me.grpComision = New System.Windows.Forms.GroupBox()
        Me.btnEliminarComision = New System.Windows.Forms.Button()
        Me.btnGuardarComision = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMontoComision = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.btnEliminarPS = New System.Windows.Forms.Button()
        Me.btnNuevoPS = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorSecundario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.chkUnlock = New System.Windows.Forms.CheckBox()
        Me.tbcProducto.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpNuevo.SuspendLayout()
        Me.grpAccion.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.grpMonedaVenta.SuspendLayout()
        Me.grpMonedaCompra.SuspendLayout()
        CType(Me.nudStockMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDatosExtra.SuspendLayout()
        Me.grpComision.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcProducto
        '
        Me.tbcProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcProducto.Controls.Add(Me.tbpListar)
        Me.tbcProducto.Controls.Add(Me.tbpNuevo)
        Me.tbcProducto.Controls.Add(Me.tbpDatosExtra)
        Me.tbcProducto.Location = New System.Drawing.Point(2, 20)
        Me.tbcProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbcProducto.Name = "tbcProducto"
        Me.tbcProducto.SelectedIndex = 0
        Me.tbcProducto.Size = New System.Drawing.Size(1055, 484)
        Me.tbcProducto.TabIndex = 30
        '
        'tbpListar
        '
        Me.tbpListar.Controls.Add(Me.btnEliminar)
        Me.tbpListar.Controls.Add(Me.chkMostrarControlesAvanzados)
        Me.tbpListar.Controls.Add(Me.btnKardex)
        Me.tbpListar.Controls.Add(Me.btnDesactivar)
        Me.tbpListar.Controls.Add(Me.txtBusqueda)
        Me.tbpListar.Controls.Add(Me.chkEstado)
        Me.tbpListar.Controls.Add(Me.btnModificar)
        Me.tbpListar.Controls.Add(Me.btnNuevo)
        Me.tbpListar.Controls.Add(Me.dgvProducto)
        Me.tbpListar.Location = New System.Drawing.Point(4, 28)
        Me.tbpListar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpListar.Size = New System.Drawing.Size(1047, 452)
        Me.tbpListar.TabIndex = 0
        Me.tbpListar.Text = "Listar"
        Me.tbpListar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Global.SistemaServox2015.My.Resources.Resources.delete
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(897, 397)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 28)
        Me.btnEliminar.TabIndex = 36
        Me.btnEliminar.Text = "&Eliminar Permanentemente"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'chkMostrarControlesAvanzados
        '
        Me.chkMostrarControlesAvanzados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMostrarControlesAvanzados.AutoSize = True
        Me.chkMostrarControlesAvanzados.Location = New System.Drawing.Point(382, 398)
        Me.chkMostrarControlesAvanzados.Name = "chkMostrarControlesAvanzados"
        Me.chkMostrarControlesAvanzados.Size = New System.Drawing.Size(218, 23)
        Me.chkMostrarControlesAvanzados.TabIndex = 35
        Me.chkMostrarControlesAvanzados.Text = "Mostrar Controles Avanzados"
        Me.chkMostrarControlesAvanzados.UseVisualStyleBackColor = True
        '
        'btnKardex
        '
        Me.btnKardex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnKardex.BackColor = System.Drawing.Color.White
        Me.btnKardex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKardex.Location = New System.Drawing.Point(13, 398)
        Me.btnKardex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnKardex.Name = "btnKardex"
        Me.btnKardex.Size = New System.Drawing.Size(173, 28)
        Me.btnKardex.TabIndex = 6
        Me.btnKardex.Text = "&KardexValorizado"
        Me.btnKardex.UseVisualStyleBackColor = False
        '
        'btnDesactivar
        '
        Me.btnDesactivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesactivar.BackColor = System.Drawing.Color.White
        Me.btnDesactivar.Image = Global.SistemaServox2015.My.Resources.Resources.delete
        Me.btnDesactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDesactivar.Location = New System.Drawing.Point(752, 397)
        Me.btnDesactivar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(140, 28)
        Me.btnDesactivar.TabIndex = 5
        Me.btnDesactivar.Text = "&Descontinuar"
        Me.btnDesactivar.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(780, 8)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBusqueda.MaxLength = 350
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(257, 25)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(8, 11)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(157, 23)
        Me.chkEstado.TabIndex = 2
        Me.chkEstado.Text = "Ver Descontinuados"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(192, 398)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 28)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.SistemaServox2015.My.Resources.Resources.add
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(606, 397)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.dgvProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.NombreProducto, Me.DescripcionProducto, Me.UnidadMedida, Me.StockMinimo, Me.StockActual, Me.DocumentoProveedor, Me.DescripcionProveedor, Me.CosteSinIGV, Me.IGVcoste, Me.CosteConIGV, Me.PrecioNetoSinIGV, Me.IGVActual, Me.PrecioConIGV, Me.Estado, Me.EstadoBase})
        Me.dgvProducto.EnableHeadersVisualStyles = False
        Me.dgvProducto.Location = New System.Drawing.Point(8, 42)
        Me.dgvProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvProducto.MultiSelect = False
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducto.Size = New System.Drawing.Size(1030, 348)
        Me.dgvProducto.TabIndex = 34
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Visible = False
        '
        'NombreProducto
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProducto.DefaultCellStyle = DataGridViewCellStyle15
        Me.NombreProducto.HeaderText = "Producto"
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        Me.NombreProducto.Width = 140
        '
        'DescripcionProducto
        '
        Me.DescripcionProducto.HeaderText = "Descripción"
        Me.DescripcionProducto.Name = "DescripcionProducto"
        Me.DescripcionProducto.ReadOnly = True
        Me.DescripcionProducto.Width = 260
        '
        'UnidadMedida
        '
        Me.UnidadMedida.HeaderText = "Medida"
        Me.UnidadMedida.Name = "UnidadMedida"
        Me.UnidadMedida.ReadOnly = True
        Me.UnidadMedida.Width = 70
        '
        'StockMinimo
        '
        Me.StockMinimo.HeaderText = "Min."
        Me.StockMinimo.Name = "StockMinimo"
        Me.StockMinimo.ReadOnly = True
        Me.StockMinimo.Width = 60
        '
        'StockActual
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N0"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.StockActual.DefaultCellStyle = DataGridViewCellStyle16
        Me.StockActual.HeaderText = "Stock"
        Me.StockActual.Name = "StockActual"
        Me.StockActual.ReadOnly = True
        Me.StockActual.Width = 80
        '
        'DocumentoProveedor
        '
        Me.DocumentoProveedor.HeaderText = "N. Doc"
        Me.DocumentoProveedor.Name = "DocumentoProveedor"
        Me.DocumentoProveedor.ReadOnly = True
        Me.DocumentoProveedor.Visible = False
        '
        'DescripcionProveedor
        '
        Me.DescripcionProveedor.HeaderText = "Proveedor"
        Me.DescripcionProveedor.Name = "DescripcionProveedor"
        Me.DescripcionProveedor.ReadOnly = True
        Me.DescripcionProveedor.Visible = False
        Me.DescripcionProveedor.Width = 160
        '
        'CosteSinIGV
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosteSinIGV.DefaultCellStyle = DataGridViewCellStyle17
        Me.CosteSinIGV.HeaderText = "Coste"
        Me.CosteSinIGV.Name = "CosteSinIGV"
        Me.CosteSinIGV.ReadOnly = True
        '
        'IGVcoste
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IGVcoste.DefaultCellStyle = DataGridViewCellStyle18
        Me.IGVcoste.HeaderText = "%IGV(coste)"
        Me.IGVcoste.Name = "IGVcoste"
        Me.IGVcoste.ReadOnly = True
        Me.IGVcoste.Visible = False
        Me.IGVcoste.Width = 80
        '
        'CosteConIGV
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosteConIGV.DefaultCellStyle = DataGridViewCellStyle19
        Me.CosteConIGV.HeaderText = "Coste (+IGV)"
        Me.CosteConIGV.Name = "CosteConIGV"
        Me.CosteConIGV.ReadOnly = True
        '
        'PrecioNetoSinIGV
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioNetoSinIGV.DefaultCellStyle = DataGridViewCellStyle20
        Me.PrecioNetoSinIGV.HeaderText = "Precio"
        Me.PrecioNetoSinIGV.Name = "PrecioNetoSinIGV"
        Me.PrecioNetoSinIGV.ReadOnly = True
        Me.PrecioNetoSinIGV.Visible = False
        '
        'IGVActual
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IGVActual.DefaultCellStyle = DataGridViewCellStyle21
        Me.IGVActual.HeaderText = "%IGV"
        Me.IGVActual.Name = "IGVActual"
        Me.IGVActual.ReadOnly = True
        Me.IGVActual.Visible = False
        Me.IGVActual.Width = 60
        '
        'PrecioConIGV
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioConIGV.DefaultCellStyle = DataGridViewCellStyle22
        Me.PrecioConIGV.HeaderText = "Precio Venta"
        Me.PrecioConIGV.Name = "PrecioConIGV"
        Me.PrecioConIGV.ReadOnly = True
        Me.PrecioConIGV.Width = 105
        '
        'Estado
        '
        Me.Estado.HeaderText = "Est"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Estado.Width = 40
        '
        'EstadoBase
        '
        Me.EstadoBase.HeaderText = "EstadoBase"
        Me.EstadoBase.Name = "EstadoBase"
        Me.EstadoBase.ReadOnly = True
        Me.EstadoBase.Visible = False
        '
        'tbpNuevo
        '
        Me.tbpNuevo.Controls.Add(Me.grpAccion)
        Me.tbpNuevo.Controls.Add(Me.grpDatos)
        Me.tbpNuevo.Location = New System.Drawing.Point(4, 28)
        Me.tbpNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpNuevo.Name = "tbpNuevo"
        Me.tbpNuevo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpNuevo.Size = New System.Drawing.Size(1047, 452)
        Me.tbpNuevo.TabIndex = 1
        Me.tbpNuevo.Text = "Nuevo"
        Me.tbpNuevo.UseVisualStyleBackColor = True
        '
        'grpAccion
        '
        Me.grpAccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAccion.Controls.Add(Me.chkUnlock)
        Me.grpAccion.Controls.Add(Me.btnCancelar)
        Me.grpAccion.Controls.Add(Me.btnGuardar)
        Me.grpAccion.Location = New System.Drawing.Point(9, 392)
        Me.grpAccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAccion.Name = "grpAccion"
        Me.grpAccion.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAccion.Size = New System.Drawing.Size(1030, 56)
        Me.grpAccion.TabIndex = 3
        Me.grpAccion.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(526, 20)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 28)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "C&ancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.SistemaServox2015.My.Resources.Resources.disk
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(380, 20)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 28)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'grpDatos
        '
        Me.grpDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDatos.Controls.Add(Me.grpMonedaVenta)
        Me.grpDatos.Controls.Add(Me.grpMonedaCompra)
        Me.grpDatos.Controls.Add(Me.btnVerOperacion)
        Me.grpDatos.Controls.Add(Me.lblUltimaModificacion)
        Me.grpDatos.Controls.Add(Me.Label10)
        Me.grpDatos.Controls.Add(Me.txtPrecioCosteSinIGV)
        Me.grpDatos.Controls.Add(Me.btnExcel)
        Me.grpDatos.Controls.Add(Me.btnBuscarProveedor)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.Label3)
        Me.grpDatos.Controls.Add(Me.lblIGVActual)
        Me.grpDatos.Controls.Add(Me.txtPrecioVentaConIGV)
        Me.grpDatos.Controls.Add(Me.txtPrecioVenta)
        Me.grpDatos.Controls.Add(Me.txtPrecioCosteConIGV)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.txtDescripcionProveedor)
        Me.grpDatos.Controls.Add(Me.txtIdProveedor)
        Me.grpDatos.Controls.Add(Me.txtRucProveedor)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.nudStockMinimo)
        Me.grpDatos.Controls.Add(Me.dgvHistorial)
        Me.grpDatos.Controls.Add(Me.cmbUnidadMedida)
        Me.grpDatos.Controls.Add(Me.txtDescripcionProducto)
        Me.grpDatos.Controls.Add(Me.Label18)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.txtIdProducto)
        Me.grpDatos.Controls.Add(Me.txtCodigoProducto)
        Me.grpDatos.Location = New System.Drawing.Point(9, 4)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDatos.Size = New System.Drawing.Size(1030, 388)
        Me.grpDatos.TabIndex = 2
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'grpMonedaVenta
        '
        Me.grpMonedaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpMonedaVenta.Controls.Add(Me.rbDolaresVenta)
        Me.grpMonedaVenta.Controls.Add(Me.rbSolesVenta)
        Me.grpMonedaVenta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMonedaVenta.Location = New System.Drawing.Point(241, 260)
        Me.grpMonedaVenta.Name = "grpMonedaVenta"
        Me.grpMonedaVenta.Size = New System.Drawing.Size(193, 43)
        Me.grpMonedaVenta.TabIndex = 124
        Me.grpMonedaVenta.TabStop = False
        Me.grpMonedaVenta.Text = "Moneda de Venta"
        '
        'rbDolaresVenta
        '
        Me.rbDolaresVenta.AutoSize = True
        Me.rbDolaresVenta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDolaresVenta.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbDolaresVenta.Location = New System.Drawing.Point(93, 17)
        Me.rbDolaresVenta.Name = "rbDolaresVenta"
        Me.rbDolaresVenta.Size = New System.Drawing.Size(71, 22)
        Me.rbDolaresVenta.TabIndex = 1
        Me.rbDolaresVenta.TabStop = True
        Me.rbDolaresVenta.Text = "Dólares"
        Me.rbDolaresVenta.UseVisualStyleBackColor = True
        '
        'rbSolesVenta
        '
        Me.rbSolesVenta.AutoSize = True
        Me.rbSolesVenta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSolesVenta.ForeColor = System.Drawing.Color.Black
        Me.rbSolesVenta.Location = New System.Drawing.Point(32, 16)
        Me.rbSolesVenta.Name = "rbSolesVenta"
        Me.rbSolesVenta.Size = New System.Drawing.Size(57, 22)
        Me.rbSolesVenta.TabIndex = 0
        Me.rbSolesVenta.TabStop = True
        Me.rbSolesVenta.Text = "Soles"
        Me.rbSolesVenta.UseVisualStyleBackColor = True
        '
        'grpMonedaCompra
        '
        Me.grpMonedaCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpMonedaCompra.Controls.Add(Me.rbDolaresCompra)
        Me.grpMonedaCompra.Controls.Add(Me.rbSolesCompra)
        Me.grpMonedaCompra.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMonedaCompra.Location = New System.Drawing.Point(6, 260)
        Me.grpMonedaCompra.Name = "grpMonedaCompra"
        Me.grpMonedaCompra.Size = New System.Drawing.Size(193, 43)
        Me.grpMonedaCompra.TabIndex = 123
        Me.grpMonedaCompra.TabStop = False
        Me.grpMonedaCompra.Text = "Moneda de Compra"
        '
        'rbDolaresCompra
        '
        Me.rbDolaresCompra.AutoSize = True
        Me.rbDolaresCompra.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDolaresCompra.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbDolaresCompra.Location = New System.Drawing.Point(93, 17)
        Me.rbDolaresCompra.Name = "rbDolaresCompra"
        Me.rbDolaresCompra.Size = New System.Drawing.Size(71, 22)
        Me.rbDolaresCompra.TabIndex = 1
        Me.rbDolaresCompra.TabStop = True
        Me.rbDolaresCompra.Text = "Dólares"
        Me.rbDolaresCompra.UseVisualStyleBackColor = True
        '
        'rbSolesCompra
        '
        Me.rbSolesCompra.AutoSize = True
        Me.rbSolesCompra.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSolesCompra.ForeColor = System.Drawing.Color.Black
        Me.rbSolesCompra.Location = New System.Drawing.Point(32, 16)
        Me.rbSolesCompra.Name = "rbSolesCompra"
        Me.rbSolesCompra.Size = New System.Drawing.Size(57, 22)
        Me.rbSolesCompra.TabIndex = 0
        Me.rbSolesCompra.TabStop = True
        Me.rbSolesCompra.Text = "Soles"
        Me.rbSolesCompra.UseVisualStyleBackColor = True
        '
        'btnVerOperacion
        '
        Me.btnVerOperacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVerOperacion.BackColor = System.Drawing.Color.White
        Me.btnVerOperacion.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnVerOperacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerOperacion.Location = New System.Drawing.Point(440, 355)
        Me.btnVerOperacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVerOperacion.Name = "btnVerOperacion"
        Me.btnVerOperacion.Size = New System.Drawing.Size(140, 28)
        Me.btnVerOperacion.TabIndex = 122
        Me.btnVerOperacion.Text = "&Operación"
        Me.btnVerOperacion.UseVisualStyleBackColor = False
        '
        'lblUltimaModificacion
        '
        Me.lblUltimaModificacion.AutoSize = True
        Me.lblUltimaModificacion.Location = New System.Drawing.Point(198, 49)
        Me.lblUltimaModificacion.Name = "lblUltimaModificacion"
        Me.lblUltimaModificacion.Size = New System.Drawing.Size(0, 19)
        Me.lblUltimaModificacion.TabIndex = 121
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Coste :"
        '
        'txtPrecioCosteSinIGV
        '
        Me.txtPrecioCosteSinIGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioCosteSinIGV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPrecioCosteSinIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioCosteSinIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPrecioCosteSinIGV.Location = New System.Drawing.Point(61, 312)
        Me.txtPrecioCosteSinIGV.Name = "txtPrecioCosteSinIGV"
        Me.txtPrecioCosteSinIGV.Size = New System.Drawing.Size(125, 27)
        Me.txtPrecioCosteSinIGV.TabIndex = 10
        Me.txtPrecioCosteSinIGV.Text = "0.00"
        Me.txtPrecioCosteSinIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.White
        Me.btnExcel.Image = Global.SistemaServox2015.My.Resources.Resources.page_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(884, 354)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(140, 28)
        Me.btnExcel.TabIndex = 118
        Me.btnExcel.Text = "E&xcel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.BackColor = System.Drawing.Color.White
        Me.btnBuscarProveedor.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnBuscarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(220, 200)
        Me.btnBuscarProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(172, 28)
        Me.btnBuscarProveedor.TabIndex = 6
        Me.btnBuscarProveedor.Text = "&Buscar Proveedor"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(199, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 18)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Precio Venta :"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Precio :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Coste+igv :"
        '
        'lblIGVActual
        '
        Me.lblIGVActual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIGVActual.AutoSize = True
        Me.lblIGVActual.Location = New System.Drawing.Point(434, 360)
        Me.lblIGVActual.Name = "lblIGVActual"
        Me.lblIGVActual.Size = New System.Drawing.Size(0, 19)
        Me.lblIGVActual.TabIndex = 114
        '
        'txtPrecioVentaConIGV
        '
        Me.txtPrecioVentaConIGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioVentaConIGV.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrecioVentaConIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVentaConIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPrecioVentaConIGV.Location = New System.Drawing.Point(294, 348)
        Me.txtPrecioVentaConIGV.Name = "txtPrecioVentaConIGV"
        Me.txtPrecioVentaConIGV.Size = New System.Drawing.Size(125, 27)
        Me.txtPrecioVentaConIGV.TabIndex = 13
        Me.txtPrecioVentaConIGV.Text = "0.00"
        Me.txtPrecioVentaConIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPrecioVenta.Location = New System.Drawing.Point(61, 348)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(125, 27)
        Me.txtPrecioVenta.TabIndex = 12
        Me.txtPrecioVenta.Text = "0.00"
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecioCosteConIGV
        '
        Me.txtPrecioCosteConIGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioCosteConIGV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPrecioCosteConIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioCosteConIGV.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPrecioCosteConIGV.Location = New System.Drawing.Point(294, 312)
        Me.txtPrecioCosteConIGV.Name = "txtPrecioCosteConIGV"
        Me.txtPrecioCosteConIGV.Size = New System.Drawing.Size(125, 27)
        Me.txtPrecioCosteConIGV.TabIndex = 11
        Me.txtPrecioCosteConIGV.Text = "0.00"
        Me.txtPrecioCosteConIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Código"
        '
        'txtDescripcionProveedor
        '
        Me.txtDescripcionProveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcionProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionProveedor.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProveedor.Location = New System.Drawing.Point(6, 234)
        Me.txtDescripcionProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcionProveedor.MaxLength = 350
        Me.txtDescripcionProveedor.Name = "txtDescripcionProveedor"
        Me.txtDescripcionProveedor.Size = New System.Drawing.Size(386, 23)
        Me.txtDescripcionProveedor.TabIndex = 7
        Me.txtDescripcionProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdProveedor.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProveedor.Location = New System.Drawing.Point(8, 203)
        Me.txtIdProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdProveedor.MaxLength = 350
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.ReadOnly = True
        Me.txtIdProveedor.Size = New System.Drawing.Size(66, 23)
        Me.txtIdProveedor.TabIndex = 106
        Me.txtIdProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRucProveedor
        '
        Me.txtRucProveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtRucProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRucProveedor.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRucProveedor.Location = New System.Drawing.Point(80, 204)
        Me.txtRucProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRucProveedor.MaxLength = 350
        Me.txtRucProveedor.Name = "txtRucProveedor"
        Me.txtRucProveedor.Size = New System.Drawing.Size(134, 23)
        Me.txtRucProveedor.TabIndex = 5
        Me.txtRucProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Stock Mínimo"
        '
        'nudStockMinimo
        '
        Me.nudStockMinimo.Location = New System.Drawing.Point(217, 141)
        Me.nudStockMinimo.Name = "nudStockMinimo"
        Me.nudStockMinimo.Size = New System.Drawing.Size(84, 27)
        Me.nudStockMinimo.TabIndex = 4
        '
        'dgvHistorial
        '
        Me.dgvHistorial.AllowUserToAddRows = False
        Me.dgvHistorial.AllowUserToDeleteRows = False
        Me.dgvHistorial.AllowUserToOrderColumns = True
        Me.dgvHistorial.AllowUserToResizeRows = False
        Me.dgvHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistorial.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Operacion, Me.Fecha, Me.PrecioUnidad, Me.Compra, Me.Venta, Me.Saldo, Me.IdOperacion, Me.IdTipoComprobante, Me.TipoOperacion})
        Me.dgvHistorial.EnableHeadersVisualStyles = False
        Me.dgvHistorial.Location = New System.Drawing.Point(439, 16)
        Me.dgvHistorial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvHistorial.MultiSelect = False
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.ReadOnly = True
        Me.dgvHistorial.RowHeadersVisible = False
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Size = New System.Drawing.Size(585, 336)
        Me.dgvHistorial.TabIndex = 102
        '
        'Operacion
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operacion.DefaultCellStyle = DataGridViewCellStyle23
        Me.Operacion.HeaderText = "Operación"
        Me.Operacion.Name = "Operacion"
        Me.Operacion.ReadOnly = True
        Me.Operacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Operacion.Width = 140
        '
        'Fecha
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle24
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PrecioUnidad
        '
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioUnidad.DefaultCellStyle = DataGridViewCellStyle25
        Me.PrecioUnidad.HeaderText = "PUni"
        Me.PrecioUnidad.Name = "PrecioUnidad"
        Me.PrecioUnidad.ReadOnly = True
        Me.PrecioUnidad.Width = 70
        '
        'Compra
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compra.DefaultCellStyle = DataGridViewCellStyle26
        Me.Compra.HeaderText = "Compra"
        Me.Compra.Name = "Compra"
        Me.Compra.ReadOnly = True
        Me.Compra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Compra.Width = 70
        '
        'Venta
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Venta.DefaultCellStyle = DataGridViewCellStyle27
        Me.Venta.HeaderText = "Venta"
        Me.Venta.Name = "Venta"
        Me.Venta.ReadOnly = True
        Me.Venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Venta.Width = 70
        '
        'Saldo
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle28
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'IdOperacion
        '
        Me.IdOperacion.HeaderText = "IdOperacion"
        Me.IdOperacion.Name = "IdOperacion"
        Me.IdOperacion.ReadOnly = True
        Me.IdOperacion.Visible = False
        '
        'IdTipoComprobante
        '
        Me.IdTipoComprobante.HeaderText = "IdTipoComprobante"
        Me.IdTipoComprobante.Name = "IdTipoComprobante"
        Me.IdTipoComprobante.ReadOnly = True
        Me.IdTipoComprobante.Visible = False
        '
        'TipoOperacion
        '
        Me.TipoOperacion.HeaderText = "TipoOperacion"
        Me.TipoOperacion.Name = "TipoOperacion"
        Me.TipoOperacion.ReadOnly = True
        Me.TipoOperacion.Visible = False
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidadMedida.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnidadMedida.FormattingEnabled = True
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(8, 142)
        Me.cmbUnidadMedida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(193, 26)
        Me.cmbUnidadMedida.TabIndex = 3
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionProducto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(8, 79)
        Me.txtDescripcionProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcionProducto.MaxLength = 350
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(384, 23)
        Me.txtDescripcionProducto.TabIndex = 2
        Me.txtDescripcionProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 18)
        Me.Label18.TabIndex = 92
        Me.Label18.Text = "Medida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 18)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 18)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Id"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdProducto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProducto.Location = New System.Drawing.Point(8, 48)
        Me.txtIdProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdProducto.MaxLength = 350
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.ReadOnly = True
        Me.txtIdProducto.Size = New System.Drawing.Size(39, 23)
        Me.txtIdProducto.TabIndex = 43
        Me.txtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(53, 48)
        Me.txtCodigoProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoProducto.MaxLength = 350
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(125, 23)
        Me.txtCodigoProducto.TabIndex = 1
        Me.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbpDatosExtra
        '
        Me.tbpDatosExtra.Controls.Add(Me.grpComision)
        Me.tbpDatosExtra.Controls.Add(Me.btnEliminarPS)
        Me.tbpDatosExtra.Controls.Add(Me.btnNuevoPS)
        Me.tbpDatosExtra.Controls.Add(Me.Label5)
        Me.tbpDatosExtra.Controls.Add(Me.dgvProveedores)
        Me.tbpDatosExtra.Location = New System.Drawing.Point(4, 28)
        Me.tbpDatosExtra.Name = "tbpDatosExtra"
        Me.tbpDatosExtra.Size = New System.Drawing.Size(1047, 452)
        Me.tbpDatosExtra.TabIndex = 2
        Me.tbpDatosExtra.Text = "Extra"
        Me.tbpDatosExtra.UseVisualStyleBackColor = True
        '
        'grpComision
        '
        Me.grpComision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpComision.Controls.Add(Me.btnEliminarComision)
        Me.grpComision.Controls.Add(Me.btnGuardarComision)
        Me.grpComision.Controls.Add(Me.Label11)
        Me.grpComision.Controls.Add(Me.txtMontoComision)
        Me.grpComision.Controls.Add(Me.txtIdEmpleado)
        Me.grpComision.Controls.Add(Me.txtNombreEmpleado)
        Me.grpComision.Controls.Add(Me.btnBuscarEmpleado)
        Me.grpComision.Location = New System.Drawing.Point(568, 233)
        Me.grpComision.Name = "grpComision"
        Me.grpComision.Size = New System.Drawing.Size(473, 160)
        Me.grpComision.TabIndex = 107
        Me.grpComision.TabStop = False
        Me.grpComision.Text = "Comisión"
        '
        'btnEliminarComision
        '
        Me.btnEliminarComision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarComision.BackColor = System.Drawing.Color.White
        Me.btnEliminarComision.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarComision.Image = Global.SistemaServox2015.My.Resources.Resources.delete
        Me.btnEliminarComision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarComision.Location = New System.Drawing.Point(164, 110)
        Me.btnEliminarComision.Name = "btnEliminarComision"
        Me.btnEliminarComision.Size = New System.Drawing.Size(167, 28)
        Me.btnEliminarComision.TabIndex = 50
        Me.btnEliminarComision.Text = "&Eliminar Comisión"
        Me.btnEliminarComision.UseVisualStyleBackColor = False
        '
        'btnGuardarComision
        '
        Me.btnGuardarComision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarComision.BackColor = System.Drawing.Color.White
        Me.btnGuardarComision.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarComision.Image = Global.SistemaServox2015.My.Resources.Resources.disk
        Me.btnGuardarComision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarComision.Location = New System.Drawing.Point(18, 110)
        Me.btnGuardarComision.Name = "btnGuardarComision"
        Me.btnGuardarComision.Size = New System.Drawing.Size(140, 28)
        Me.btnGuardarComision.TabIndex = 49
        Me.btnGuardarComision.Text = "&Guardar"
        Me.btnGuardarComision.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 19)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Monto :"
        '
        'txtMontoComision
        '
        Me.txtMontoComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoComision.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtMontoComision.Location = New System.Drawing.Point(164, 61)
        Me.txtMontoComision.Name = "txtMontoComision"
        Me.txtMontoComision.Size = New System.Drawing.Size(100, 27)
        Me.txtMontoComision.TabIndex = 46
        Me.txtMontoComision.Text = "0.00"
        Me.txtMontoComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEmpleado.Location = New System.Drawing.Point(18, 31)
        Me.txtIdEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdEmpleado.MaxLength = 350
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.ReadOnly = True
        Me.txtIdEmpleado.Size = New System.Drawing.Size(39, 23)
        Me.txtIdEmpleado.TabIndex = 45
        Me.txtIdEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEmpleado.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(63, 31)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreEmpleado.MaxLength = 350
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(391, 23)
        Me.txtNombreEmpleado.TabIndex = 44
        Me.txtNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.BackColor = System.Drawing.Color.White
        Me.btnBuscarEmpleado.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnBuscarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(282, 62)
        Me.btnBuscarEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(172, 28)
        Me.btnBuscarEmpleado.TabIndex = 7
        Me.btnBuscarEmpleado.Text = "Buscar &Empleado"
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = False
        '
        'btnEliminarPS
        '
        Me.btnEliminarPS.BackColor = System.Drawing.Color.White
        Me.btnEliminarPS.Image = Global.SistemaServox2015.My.Resources.Resources.delete
        Me.btnEliminarPS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarPS.Location = New System.Drawing.Point(543, 69)
        Me.btnEliminarPS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminarPS.Name = "btnEliminarPS"
        Me.btnEliminarPS.Size = New System.Drawing.Size(140, 28)
        Me.btnEliminarPS.TabIndex = 106
        Me.btnEliminarPS.Text = "&Eliminar"
        Me.btnEliminarPS.UseVisualStyleBackColor = False
        '
        'btnNuevoPS
        '
        Me.btnNuevoPS.BackColor = System.Drawing.Color.White
        Me.btnNuevoPS.Image = Global.SistemaServox2015.My.Resources.Resources.add
        Me.btnNuevoPS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoPS.Location = New System.Drawing.Point(543, 33)
        Me.btnNuevoPS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevoPS.Name = "btnNuevoPS"
        Me.btnNuevoPS.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevoPS.TabIndex = 105
        Me.btnNuevoPS.Text = "&Nuevo"
        Me.btnNuevoPS.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 19)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Proveedores Secundarios"
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.AllowUserToOrderColumns = True
        Me.dgvProveedores.AllowUserToResizeRows = False
        Me.dgvProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedor, Me.IdProveedorSecundario, Me.TipoDocumento, Me.Documento, Me.Proveedor})
        Me.dgvProveedores.EnableHeadersVisualStyles = False
        Me.dgvProveedores.Location = New System.Drawing.Point(6, 35)
        Me.dgvProveedores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvProveedores.MultiSelect = False
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.RowHeadersVisible = False
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(531, 358)
        Me.dgvProveedores.TabIndex = 103
        '
        'IdProveedor
        '
        Me.IdProveedor.HeaderText = "IdProveedor"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.ReadOnly = True
        Me.IdProveedor.Visible = False
        '
        'IdProveedorSecundario
        '
        Me.IdProveedorSecundario.HeaderText = "IdProveedorSecundario"
        Me.IdProveedorSecundario.Name = "IdProveedorSecundario"
        Me.IdProveedorSecundario.ReadOnly = True
        Me.IdProveedorSecundario.Visible = False
        '
        'TipoDocumento
        '
        Me.TipoDocumento.HeaderText = "Tipo"
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.ReadOnly = True
        Me.TipoDocumento.Width = 60
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 240
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(1057, 22)
        Me.txtTitulo.TabIndex = 29
        Me.txtTitulo.Text = "Mantenimiento Producto"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(907, 512)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'chkUnlock
        '
        Me.chkUnlock.AutoSize = True
        Me.chkUnlock.Location = New System.Drawing.Point(10, 22)
        Me.chkUnlock.Name = "chkUnlock"
        Me.chkUnlock.Size = New System.Drawing.Size(174, 23)
        Me.chkUnlock.TabIndex = 16
        Me.chkUnlock.Text = "Habilitar edición coste"
        Me.chkUnlock.UseVisualStyleBackColor = True
        '
        'frmMantenimientoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(1057, 543)
        Me.Controls.Add(Me.tbcProducto)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMantenimientoProducto"
        Me.tbcProducto.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.tbpListar.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpNuevo.ResumeLayout(False)
        Me.grpAccion.ResumeLayout(False)
        Me.grpAccion.PerformLayout()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.grpMonedaVenta.ResumeLayout(False)
        Me.grpMonedaVenta.PerformLayout()
        Me.grpMonedaCompra.ResumeLayout(False)
        Me.grpMonedaCompra.PerformLayout()
        CType(Me.nudStockMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDatosExtra.ResumeLayout(False)
        Me.tbpDatosExtra.PerformLayout()
        Me.grpComision.ResumeLayout(False)
        Me.grpComision.PerformLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcProducto As System.Windows.Forms.TabControl
    Friend WithEvents tbpListar As System.Windows.Forms.TabPage
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents tbpNuevo As System.Windows.Forms.TabPage
    Friend WithEvents grpAccion As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents btnDesactivar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtRucProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudStockMinimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgvHistorial As System.Windows.Forms.DataGridView
    Friend WithEvents cmbUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioVenta As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtPrecioCosteConIGV As SistemaServox2015.MoneyTextBox8
    Friend WithEvents btnKardex As System.Windows.Forms.Button
    Friend WithEvents lblIGVActual As System.Windows.Forms.Label
    Friend WithEvents txtPrecioVentaConIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarProveedor As System.Windows.Forms.Button
    Friend WithEvents chkMostrarControlesAvanzados As System.Windows.Forms.CheckBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents tbpDatosExtra As System.Windows.Forms.TabPage
    Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents IdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorSecundario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminarPS As System.Windows.Forms.Button
    Friend WithEvents btnNuevoPS As System.Windows.Forms.Button
    Friend WithEvents grpComision As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminarComision As System.Windows.Forms.Button
    Friend WithEvents btnGuardarComision As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMontoComision As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtIdEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarEmpleado As System.Windows.Forms.Button
    Friend WithEvents lblUltimaModificacion As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioCosteSinIGV As SistemaServox2015.MoneyTextBox8
    Friend WithEvents btnVerOperacion As System.Windows.Forms.Button
    Friend WithEvents Operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents grpMonedaVenta As System.Windows.Forms.GroupBox
    Friend WithEvents rbDolaresVenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbSolesVenta As System.Windows.Forms.RadioButton
    Friend WithEvents grpMonedaCompra As System.Windows.Forms.GroupBox
    Friend WithEvents rbDolaresCompra As System.Windows.Forms.RadioButton
    Friend WithEvents rbSolesCompra As System.Windows.Forms.RadioButton
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockMinimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CosteSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGVcoste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CosteConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNetoSinIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGVActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioConIGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents EstadoBase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkUnlock As System.Windows.Forms.CheckBox
End Class
