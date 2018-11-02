<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoProveedor
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbcProveedor = New System.Windows.Forms.TabControl()
        Me.tbpListar = New System.Windows.Forms.TabPage()
        Me.btnHistorialProveedor = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tbpNuevo = New System.Windows.Forms.TabPage()
        Me.grpAccion = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelfMovil = New System.Windows.Forms.TextBox()
        Me.txtTelfFijo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbpHistorial = New System.Windows.Forms.TabPage()
        Me.chkSoloAnio = New System.Windows.Forms.CheckBox()
        Me.btnVerOperacion = New System.Windows.Forms.Button()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.dgvHistorialVentas = New System.Windows.Forms.DataGridView()
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGVStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnGenerarHistorialMA = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpVentasHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpVentasDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerarDosFechas = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbcProveedor.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpNuevo.SuspendLayout()
        Me.grpAccion.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.tbpHistorial.SuspendLayout()
        CType(Me.dgvHistorialVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcProveedor
        '
        Me.tbcProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcProveedor.Controls.Add(Me.tbpListar)
        Me.tbcProveedor.Controls.Add(Me.tbpNuevo)
        Me.tbcProveedor.Controls.Add(Me.tbpHistorial)
        Me.tbcProveedor.Location = New System.Drawing.Point(7, 32)
        Me.tbcProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbcProveedor.Name = "tbcProveedor"
        Me.tbcProveedor.SelectedIndex = 0
        Me.tbcProveedor.Size = New System.Drawing.Size(922, 483)
        Me.tbcProveedor.TabIndex = 28
        '
        'tbpListar
        '
        Me.tbpListar.Controls.Add(Me.btnHistorialProveedor)
        Me.tbpListar.Controls.Add(Me.txtBusqueda)
        Me.tbpListar.Controls.Add(Me.btnCerrar)
        Me.tbpListar.Controls.Add(Me.btnSeleccionar)
        Me.tbpListar.Controls.Add(Me.chkEstado)
        Me.tbpListar.Controls.Add(Me.btnModificar)
        Me.tbpListar.Controls.Add(Me.btnNuevo)
        Me.tbpListar.Controls.Add(Me.dgvProveedor)
        Me.tbpListar.Location = New System.Drawing.Point(4, 27)
        Me.tbpListar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpListar.Size = New System.Drawing.Size(914, 452)
        Me.tbpListar.TabIndex = 0
        Me.tbpListar.Text = "Listar"
        Me.tbpListar.UseVisualStyleBackColor = True
        '
        'btnHistorialProveedor
        '
        Me.btnHistorialProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHistorialProveedor.BackColor = System.Drawing.Color.White
        Me.btnHistorialProveedor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialProveedor.Image = Global.SistemaServox2015.My.Resources.Resources.zoom_in
        Me.btnHistorialProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorialProveedor.Location = New System.Drawing.Point(445, 398)
        Me.btnHistorialProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHistorialProveedor.Name = "btnHistorialProveedor"
        Me.btnHistorialProveedor.Size = New System.Drawing.Size(140, 28)
        Me.btnHistorialProveedor.TabIndex = 5
        Me.btnHistorialProveedor.Text = "&Historial"
        Me.btnHistorialProveedor.UseVisualStyleBackColor = False
        Me.btnHistorialProveedor.Visible = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(681, 7)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBusqueda.MaxLength = 350
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(225, 25)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(766, 398)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.BackColor = System.Drawing.Color.White
        Me.btnSeleccionar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Image = Global.SistemaServox2015.My.Resources.Resources.accept
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(7, 398)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(140, 28)
        Me.btnSeleccionar.TabIndex = 2
        Me.btnSeleccionar.Text = "&Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(7, 6)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(102, 22)
        Me.chkEstado.TabIndex = 2
        Me.chkEstado.Text = "Ver Inactivos"
        Me.chkEstado.UseVisualStyleBackColor = True
        Me.chkEstado.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(299, 398)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 28)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SistemaServox2015.My.Resources.Resources.add
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(153, 398)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AllowUserToAddRows = False
        Me.dgvProveedor.AllowUserToDeleteRows = False
        Me.dgvProveedor.AllowUserToOrderColumns = True
        Me.dgvProveedor.AllowUserToResizeRows = False
        Me.dgvProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProveedor.BackgroundColor = System.Drawing.Color.White
        Me.dgvProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.DocumentoIdentidad, Me.Nombre, Me.Direccion, Me.TelefonoFijo, Me.TelefonoMovil, Me.Email, Me.FechaRegistro, Me.Observacion, Me.IdProveedor, Me.Estado})
        Me.dgvProveedor.EnableHeadersVisualStyles = False
        Me.dgvProveedor.Location = New System.Drawing.Point(7, 40)
        Me.dgvProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvProveedor.MultiSelect = False
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        Me.dgvProveedor.RowHeadersVisible = False
        Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedor.Size = New System.Drawing.Size(900, 350)
        Me.dgvProveedor.TabIndex = 34
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 50
        '
        'DocumentoIdentidad
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentoIdentidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.DocumentoIdentidad.HeaderText = "Nro. Documento"
        Me.DocumentoIdentidad.Name = "DocumentoIdentidad"
        Me.DocumentoIdentidad.ReadOnly = True
        '
        'Nombre
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle6
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 220
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 150
        '
        'TelefonoFijo
        '
        Me.TelefonoFijo.HeaderText = "Telf. Fijo"
        Me.TelefonoFijo.Name = "TelefonoFijo"
        Me.TelefonoFijo.ReadOnly = True
        Me.TelefonoFijo.Width = 70
        '
        'TelefonoMovil
        '
        Me.TelefonoMovil.HeaderText = "Telf. Movil"
        Me.TelefonoMovil.Name = "TelefonoMovil"
        Me.TelefonoMovil.ReadOnly = True
        Me.TelefonoMovil.Width = 70
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'FechaRegistro
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaRegistro.DefaultCellStyle = DataGridViewCellStyle7
        Me.FechaRegistro.HeaderText = "Registro"
        Me.FechaRegistro.Name = "FechaRegistro"
        Me.FechaRegistro.ReadOnly = True
        Me.FechaRegistro.Width = 80
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 120
        '
        'IdProveedor
        '
        Me.IdProveedor.HeaderText = "IdProveedor"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.ReadOnly = True
        Me.IdProveedor.Visible = False
        '
        'Estado
        '
        Me.Estado.HeaderText = "Est."
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Estado.Width = 40
        '
        'tbpNuevo
        '
        Me.tbpNuevo.Controls.Add(Me.grpAccion)
        Me.tbpNuevo.Controls.Add(Me.grpDatos)
        Me.tbpNuevo.Location = New System.Drawing.Point(4, 27)
        Me.tbpNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpNuevo.Name = "tbpNuevo"
        Me.tbpNuevo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpNuevo.Size = New System.Drawing.Size(914, 452)
        Me.tbpNuevo.TabIndex = 1
        Me.tbpNuevo.Text = "Nuevo"
        Me.tbpNuevo.UseVisualStyleBackColor = True
        '
        'grpAccion
        '
        Me.grpAccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAccion.Controls.Add(Me.btnCancelar)
        Me.grpAccion.Controls.Add(Me.btnGuardar)
        Me.grpAccion.Location = New System.Drawing.Point(8, 370)
        Me.grpAccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAccion.Name = "grpAccion"
        Me.grpAccion.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAccion.Size = New System.Drawing.Size(896, 62)
        Me.grpAccion.TabIndex = 3
        Me.grpAccion.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(387, 18)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 28)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "C&ancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.SistemaServox2015.My.Resources.Resources.disk
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(241, 18)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 28)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'grpDatos
        '
        Me.grpDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDatos.Controls.Add(Me.Label10)
        Me.grpDatos.Controls.Add(Me.cmbTipo)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.txtNroDocumento)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.Label3)
        Me.grpDatos.Controls.Add(Me.txtObservacion)
        Me.grpDatos.Controls.Add(Me.txtEmail)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.txtTelfMovil)
        Me.grpDatos.Controls.Add(Me.txtTelfFijo)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.cmbTipoDocumento)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.txtIdProveedor)
        Me.grpDatos.Controls.Add(Me.txtNombreProveedor)
        Me.grpDatos.Controls.Add(Me.Label5)
        Me.grpDatos.Location = New System.Drawing.Point(8, 6)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDatos.Size = New System.Drawing.Size(683, 335)
        Me.grpDatos.TabIndex = 2
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 15)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Tipo:"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(88, 283)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(171, 26)
        Me.cmbTipo.TabIndex = 111
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(345, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 15)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Nro. Documento"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.BackColor = System.Drawing.SystemColors.Window
        Me.txtNroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocumento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.Location = New System.Drawing.Point(345, 102)
        Me.txtNroDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNroDocumento.MaxLength = 350
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(232, 25)
        Me.txtNroDocumento.TabIndex = 3
        Me.txtNroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Tipo Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Observación:"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(88, 250)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtObservacion.MaxLength = 350
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(489, 25)
        Me.txtObservacion.TabIndex = 8
        Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(88, 217)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.MaxLength = 350
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(320, 25)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Teléfono Móvil: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Teléfono Fijo: "
        '
        'txtTelfMovil
        '
        Me.txtTelfMovil.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelfMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelfMovil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelfMovil.Location = New System.Drawing.Point(406, 184)
        Me.txtTelfMovil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelfMovil.MaxLength = 350
        Me.txtTelfMovil.Name = "txtTelfMovil"
        Me.txtTelfMovil.Size = New System.Drawing.Size(171, 25)
        Me.txtTelfMovil.TabIndex = 6
        Me.txtTelfMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelfFijo
        '
        Me.txtTelfFijo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelfFijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelfFijo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelfFijo.Location = New System.Drawing.Point(88, 184)
        Me.txtTelfFijo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelfFijo.MaxLength = 350
        Me.txtTelfFijo.Name = "txtTelfFijo"
        Me.txtTelfFijo.Size = New System.Drawing.Size(171, 25)
        Me.txtTelfFijo.TabIndex = 5
        Me.txtTelfFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(6, 151)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDireccion.MaxLength = 350
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(571, 25)
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(6, 102)
        Me.cmbTipoDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(324, 26)
        Me.cmbTipoDocumento.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 15)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Id"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdProveedor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProveedor.Location = New System.Drawing.Point(6, 48)
        Me.txtIdProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdProveedor.MaxLength = 350
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.ReadOnly = True
        Me.txtIdProveedor.Size = New System.Drawing.Size(71, 25)
        Me.txtIdProveedor.TabIndex = 43
        Me.txtIdProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreProveedor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProveedor.Location = New System.Drawing.Point(82, 48)
        Me.txtNombreProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreProveedor.MaxLength = 350
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(495, 25)
        Me.txtNombreProveedor.TabIndex = 1
        Me.txtNombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Nombre/Razón Social"
        '
        'tbpHistorial
        '
        Me.tbpHistorial.Controls.Add(Me.GroupBox2)
        Me.tbpHistorial.Controls.Add(Me.GroupBox1)
        Me.tbpHistorial.Controls.Add(Me.btnVerOperacion)
        Me.tbpHistorial.Controls.Add(Me.dgvHistorialVentas)
        Me.tbpHistorial.Controls.Add(Me.btnExcel)
        Me.tbpHistorial.Location = New System.Drawing.Point(4, 27)
        Me.tbpHistorial.Name = "tbpHistorial"
        Me.tbpHistorial.Size = New System.Drawing.Size(914, 452)
        Me.tbpHistorial.TabIndex = 2
        Me.tbpHistorial.Text = "Historial"
        Me.tbpHistorial.UseVisualStyleBackColor = True
        '
        'chkSoloAnio
        '
        Me.chkSoloAnio.AutoSize = True
        Me.chkSoloAnio.Location = New System.Drawing.Point(285, 24)
        Me.chkSoloAnio.Name = "chkSoloAnio"
        Me.chkSoloAnio.Size = New System.Drawing.Size(76, 22)
        Me.chkSoloAnio.TabIndex = 3
        Me.chkSoloAnio.Text = "Solo Año"
        Me.chkSoloAnio.UseVisualStyleBackColor = True
        '
        'btnVerOperacion
        '
        Me.btnVerOperacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVerOperacion.BackColor = System.Drawing.Color.White
        Me.btnVerOperacion.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnVerOperacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerOperacion.Location = New System.Drawing.Point(6, 418)
        Me.btnVerOperacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVerOperacion.Name = "btnVerOperacion"
        Me.btnVerOperacion.Size = New System.Drawing.Size(140, 28)
        Me.btnVerOperacion.TabIndex = 9
        Me.btnVerOperacion.Text = "&Operación"
        Me.btnVerOperacion.UseVisualStyleBackColor = False
        '
        'cmbAnio
        '
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(11, 21)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(98, 27)
        Me.cmbAnio.TabIndex = 1
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(115, 21)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(164, 27)
        Me.cmbMes.TabIndex = 2
        '
        'dgvHistorialVentas
        '
        Me.dgvHistorialVentas.AllowUserToAddRows = False
        Me.dgvHistorialVentas.AllowUserToDeleteRows = False
        Me.dgvHistorialVentas.AllowUserToOrderColumns = True
        Me.dgvHistorialVentas.AllowUserToResizeRows = False
        Me.dgvHistorialVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistorialVentas.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistorialVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoDocumento, Me.Documento, Me.Proveedor, Me.TipoComprobante, Me.IGVStatus, Me.IdCompra, Me.TipoOperacion, Me.Serie, Me.Numero, Me.Fecha, Me.Total})
        Me.dgvHistorialVentas.EnableHeadersVisualStyles = False
        Me.dgvHistorialVentas.Location = New System.Drawing.Point(6, 124)
        Me.dgvHistorialVentas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvHistorialVentas.MultiSelect = False
        Me.dgvHistorialVentas.Name = "dgvHistorialVentas"
        Me.dgvHistorialVentas.ReadOnly = True
        Me.dgvHistorialVentas.RowHeadersVisible = False
        Me.dgvHistorialVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorialVentas.Size = New System.Drawing.Size(890, 289)
        Me.dgvHistorialVentas.TabIndex = 40
        '
        'TipoDocumento
        '
        Me.TipoDocumento.HeaderText = "Tipo"
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.ReadOnly = True
        Me.TipoDocumento.Width = 50
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Nombre"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 200
        '
        'TipoComprobante
        '
        Me.TipoComprobante.HeaderText = "Comp."
        Me.TipoComprobante.Name = "TipoComprobante"
        Me.TipoComprobante.ReadOnly = True
        Me.TipoComprobante.Width = 50
        '
        'IGVStatus
        '
        Me.IGVStatus.HeaderText = "Tipo II"
        Me.IGVStatus.Name = "IGVStatus"
        Me.IGVStatus.ReadOnly = True
        Me.IGVStatus.Width = 80
        '
        'IdCompra
        '
        Me.IdCompra.HeaderText = "IdCompra"
        Me.IdCompra.Name = "IdCompra"
        Me.IdCompra.ReadOnly = True
        Me.IdCompra.Visible = False
        '
        'TipoOperacion
        '
        Me.TipoOperacion.HeaderText = "TipoOperacion"
        Me.TipoOperacion.Name = "TipoOperacion"
        Me.TipoOperacion.ReadOnly = True
        Me.TipoOperacion.Visible = False
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        Me.Serie.Width = 70
        '
        'Numero
        '
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Total
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total.DefaultCellStyle = DataGridViewCellStyle8
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.White
        Me.btnExcel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Image = Global.SistemaServox2015.My.Resources.Resources.page_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(756, 12)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(140, 28)
        Me.btnExcel.TabIndex = 8
        Me.btnExcel.Text = "E&xcel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnGenerarHistorialMA
        '
        Me.btnGenerarHistorialMA.BackColor = System.Drawing.Color.White
        Me.btnGenerarHistorialMA.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarHistorialMA.Image = Global.SistemaServox2015.My.Resources.Resources.accept
        Me.btnGenerarHistorialMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarHistorialMA.Location = New System.Drawing.Point(367, 21)
        Me.btnGenerarHistorialMA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerarHistorialMA.Name = "btnGenerarHistorialMA"
        Me.btnGenerarHistorialMA.Size = New System.Drawing.Size(140, 28)
        Me.btnGenerarHistorialMA.TabIndex = 4
        Me.btnGenerarHistorialMA.Text = "&Generar"
        Me.btnGenerarHistorialMA.UseVisualStyleBackColor = False
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(934, 22)
        Me.txtTitulo.TabIndex = 27
        Me.txtTitulo.Text = "Mantenimiento Proveedor"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.chkSoloAnio)
        Me.GroupBox1.Controls.Add(Me.cmbAnio)
        Me.GroupBox1.Controls.Add(Me.btnGenerarHistorialMA)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 53)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mes - Año"
        '
        'dtpVentasHasta
        '
        Me.dtpVentasHasta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVentasHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVentasHasta.Location = New System.Drawing.Point(134, 18)
        Me.dtpVentasHasta.Name = "dtpVentasHasta"
        Me.dtpVentasHasta.Size = New System.Drawing.Size(116, 27)
        Me.dtpVentasHasta.TabIndex = 6
        '
        'dtpVentasDesde
        '
        Me.dtpVentasDesde.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVentasDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVentasDesde.Location = New System.Drawing.Point(12, 18)
        Me.dtpVentasDesde.Name = "dtpVentasDesde"
        Me.dtpVentasDesde.Size = New System.Drawing.Size(116, 27)
        Me.dtpVentasDesde.TabIndex = 5
        '
        'btnGenerarDosFechas
        '
        Me.btnGenerarDosFechas.BackColor = System.Drawing.Color.White
        Me.btnGenerarDosFechas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarDosFechas.Image = Global.SistemaServox2015.My.Resources.Resources.accept
        Me.btnGenerarDosFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarDosFechas.Location = New System.Drawing.Point(285, 17)
        Me.btnGenerarDosFechas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerarDosFechas.Name = "btnGenerarDosFechas"
        Me.btnGenerarDosFechas.Size = New System.Drawing.Size(222, 28)
        Me.btnGenerarDosFechas.TabIndex = 7
        Me.btnGenerarDosFechas.Text = "&Generar (Entre fechas)"
        Me.btnGenerarDosFechas.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGenerarDosFechas)
        Me.GroupBox2.Controls.Add(Me.dtpVentasHasta)
        Me.GroupBox2.Controls.Add(Me.dtpVentasDesde)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 49)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entre fechas"
        '
        'frmMantenimientoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(934, 521)
        Me.Controls.Add(Me.tbcProveedor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMantenimientoProveedor"
        Me.tbcProveedor.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.tbpListar.PerformLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpNuevo.ResumeLayout(False)
        Me.grpAccion.ResumeLayout(False)
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.tbpHistorial.ResumeLayout(False)
        CType(Me.dgvHistorialVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcProveedor As System.Windows.Forms.TabControl
    Friend WithEvents tbpListar As System.Windows.Forms.TabPage
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents tbpNuevo As System.Windows.Forms.TabPage
    Friend WithEvents grpAccion As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoIdentidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoFijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnHistorialProveedor As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelfMovil As System.Windows.Forms.TextBox
    Friend WithEvents txtTelfFijo As System.Windows.Forms.TextBox
    Friend WithEvents tbpHistorial As System.Windows.Forms.TabPage
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnGenerarHistorialMA As System.Windows.Forms.Button
    Friend WithEvents dgvHistorialVentas As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents btnVerOperacion As System.Windows.Forms.Button
    Friend WithEvents TipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGVStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkSoloAnio As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerarDosFechas As System.Windows.Forms.Button
    Friend WithEvents dtpVentasHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpVentasDesde As System.Windows.Forms.DateTimePicker
End Class
