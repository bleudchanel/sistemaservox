<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoOtrosGastos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.IdOtroGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCabecera = New System.Windows.Forms.GroupBox()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.btnBuscarGastos = New System.Windows.Forms.Button()
        Me.pnlControlProducto = New System.Windows.Forms.Panel()
        Me.dgvConcepto = New System.Windows.Forms.DataGridView()
        Me.subIdConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmarGasto = New System.Windows.Forms.Button()
        Me.lblProductoConIGV = New System.Windows.Forms.Label()
        Me.txtMonto = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblTituloPanel = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.ErrorVentas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.tbcVentas.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        Me.grpDetalleCompra.SuspendLayout()
        CType(Me.dgvOtro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCabecera.SuspendLayout()
        Me.pnlControlProducto.SuspendLayout()
        CType(Me.dgvConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbcVentas.Size = New System.Drawing.Size(698, 531)
        Me.tbcVentas.TabIndex = 83
        '
        'tbpListar
        '
        Me.tbpListar.Controls.Add(Me.grpDetalleCompra)
        Me.tbpListar.Controls.Add(Me.grpCabecera)
        Me.tbpListar.Location = New System.Drawing.Point(4, 24)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpListar.Size = New System.Drawing.Size(690, 503)
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
        Me.grpDetalleCompra.Size = New System.Drawing.Size(675, 382)
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
        Me.btnExcel.Location = New System.Drawing.Point(6, 339)
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
        Me.btnModificarDetalle.Location = New System.Drawing.Point(383, 14)
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
        Me.btnQuitarDetalle.Location = New System.Drawing.Point(529, 14)
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
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(237, 14)
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
        Me.Label18.Location = New System.Drawing.Point(539, 333)
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
        Me.txtTotal.Location = New System.Drawing.Point(542, 351)
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
        Me.dgvOtro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdOtroGasto, Me.Descripcion, Me.Monto})
        Me.dgvOtro.EnableHeadersVisualStyles = False
        Me.dgvOtro.Location = New System.Drawing.Point(6, 45)
        Me.dgvOtro.MultiSelect = False
        Me.dgvOtro.Name = "dgvOtro"
        Me.dgvOtro.ReadOnly = True
        Me.dgvOtro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOtro.Size = New System.Drawing.Size(663, 287)
        Me.dgvOtro.TabIndex = 34
        '
        'IdOtroGasto
        '
        Me.IdOtroGasto.HeaderText = "IdOtroGasto"
        Me.IdOtroGasto.Name = "IdOtroGasto"
        Me.IdOtroGasto.ReadOnly = True
        Me.IdOtroGasto.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Concepto"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 400
        '
        'Monto
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle3
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'grpCabecera
        '
        Me.grpCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCabecera.Controls.Add(Me.cmbAnio)
        Me.grpCabecera.Controls.Add(Me.Label2)
        Me.grpCabecera.Controls.Add(Me.cmbMes)
        Me.grpCabecera.Controls.Add(Me.btnBuscarGastos)
        Me.grpCabecera.Location = New System.Drawing.Point(7, 6)
        Me.grpCabecera.Name = "grpCabecera"
        Me.grpCabecera.Size = New System.Drawing.Size(677, 81)
        Me.grpCabecera.TabIndex = 75
        Me.grpCabecera.TabStop = False
        Me.grpCabecera.Text = "Cabecera"
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
        Me.pnlControlProducto.Controls.Add(Me.dgvConcepto)
        Me.pnlControlProducto.Controls.Add(Me.btnCancelar)
        Me.pnlControlProducto.Controls.Add(Me.btnConfirmarGasto)
        Me.pnlControlProducto.Controls.Add(Me.lblProductoConIGV)
        Me.pnlControlProducto.Controls.Add(Me.txtMonto)
        Me.pnlControlProducto.Controls.Add(Me.txtCodigoProducto)
        Me.pnlControlProducto.Controls.Add(Me.lblTituloPanel)
        Me.pnlControlProducto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlControlProducto.Location = New System.Drawing.Point(12, 568)
        Me.pnlControlProducto.Name = "pnlControlProducto"
        Me.pnlControlProducto.Size = New System.Drawing.Size(629, 170)
        Me.pnlControlProducto.TabIndex = 87
        Me.pnlControlProducto.Visible = False
        '
        'dgvConcepto
        '
        Me.dgvConcepto.AllowUserToAddRows = False
        Me.dgvConcepto.AllowUserToDeleteRows = False
        Me.dgvConcepto.AllowUserToOrderColumns = True
        Me.dgvConcepto.AllowUserToResizeRows = False
        Me.dgvConcepto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConcepto.BackgroundColor = System.Drawing.Color.White
        Me.dgvConcepto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subIdConcepto, Me.subConcepto})
        Me.dgvConcepto.EnableHeadersVisualStyles = False
        Me.dgvConcepto.Location = New System.Drawing.Point(6, 57)
        Me.dgvConcepto.MultiSelect = False
        Me.dgvConcepto.Name = "dgvConcepto"
        Me.dgvConcepto.ReadOnly = True
        Me.dgvConcepto.RowHeadersVisible = False
        Me.dgvConcepto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConcepto.Size = New System.Drawing.Size(439, 108)
        Me.dgvConcepto.TabIndex = 103
        '
        'subIdConcepto
        '
        Me.subIdConcepto.HeaderText = "IdConcepto"
        Me.subIdConcepto.Name = "subIdConcepto"
        Me.subIdConcepto.ReadOnly = True
        Me.subIdConcepto.Visible = False
        '
        'subConcepto
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subConcepto.DefaultCellStyle = DataGridViewCellStyle4
        Me.subConcepto.HeaderText = "Concepto"
        Me.subConcepto.Name = "subConcepto"
        Me.subConcepto.ReadOnly = True
        Me.subConcepto.Width = 400
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelar.Location = New System.Drawing.Point(558, 118)
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
        Me.btnConfirmarGasto.Location = New System.Drawing.Point(500, 118)
        Me.btnConfirmarGasto.Name = "btnConfirmarGasto"
        Me.btnConfirmarGasto.Size = New System.Drawing.Size(56, 28)
        Me.btnConfirmarGasto.TabIndex = 107
        Me.btnConfirmarGasto.UseVisualStyleBackColor = False
        '
        'lblProductoConIGV
        '
        Me.lblProductoConIGV.AutoSize = True
        Me.lblProductoConIGV.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductoConIGV.Location = New System.Drawing.Point(455, 24)
        Me.lblProductoConIGV.Name = "lblProductoConIGV"
        Me.lblProductoConIGV.Size = New System.Drawing.Size(44, 18)
        Me.lblProductoConIGV.TabIndex = 109
        Me.lblProductoConIGV.Text = "Monto"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtMonto.Location = New System.Drawing.Point(505, 22)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(109, 27)
        Me.txtMonto.TabIndex = 122
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BackColor = System.Drawing.Color.White
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(6, 23)
        Me.txtCodigoProducto.MaxLength = 200
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(439, 26)
        Me.txtCodigoProducto.TabIndex = 101
        Me.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTituloPanel
        '
        Me.lblTituloPanel.AutoSize = True
        Me.lblTituloPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPanel.Location = New System.Drawing.Point(3, 5)
        Me.lblTituloPanel.Name = "lblTituloPanel"
        Me.lblTituloPanel.Size = New System.Drawing.Size(65, 18)
        Me.lblTituloPanel.TabIndex = 21
        Me.lblTituloPanel.Text = "Concepto"
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.IndianRed
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(708, 25)
        Me.txtTitulo.TabIndex = 82
        Me.txtTitulo.Text = "Mantenimiento Otros Gastos"
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
        Me.btnCerrar.Location = New System.Drawing.Point(556, 568)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 84
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmMantenimientoOtrosGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 600)
        Me.Controls.Add(Me.pnlControlProducto)
        Me.Controls.Add(Me.tbcVentas)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMantenimientoOtrosGastos"
        Me.tbcVentas.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.grpDetalleCompra.ResumeLayout(False)
        Me.grpDetalleCompra.PerformLayout()
        CType(Me.dgvOtro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCabecera.ResumeLayout(False)
        Me.grpCabecera.PerformLayout()
        Me.pnlControlProducto.ResumeLayout(False)
        Me.pnlControlProducto.PerformLayout()
        CType(Me.dgvConcepto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvConcepto As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarGasto As System.Windows.Forms.Button
    Friend WithEvents lblProductoConIGV As System.Windows.Forms.Label
    Friend WithEvents txtMonto As SistemaServox2015.MoneyTextBox
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblTituloPanel As System.Windows.Forms.Label
    Friend WithEvents ErrorVentas As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents subIdConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdOtroGasto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExcel As System.Windows.Forms.Button
End Class
