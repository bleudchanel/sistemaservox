<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.tbcCliente = New System.Windows.Forms.TabControl()
        Me.tbpListar = New System.Windows.Forms.TabPage()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoDocumentoIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelefonofijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLitelefonomovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfecharegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tbpNuevo = New System.Windows.Forms.TabPage()
        Me.grpAccion = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.PbImagen = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefonoMovil = New System.Windows.Forms.TextBox()
        Me.txtTelefonoFijo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNroDocumentoIdentidad = New System.Windows.Forms.TextBox()
        Me.cmbTipoDocumentoIdentidad = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbpDatosExtra = New System.Windows.Forms.TabPage()
        Me.dtpVentasHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpVentasDesde = New System.Windows.Forms.DateTimePicker()
        Me.dgvHistorialCompras = New System.Windows.Forms.DataGridView()
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnGenerarHistorial = New System.Windows.Forms.Button()
        Me.tbcCliente.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpNuevo.SuspendLayout()
        Me.grpAccion.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        CType(Me.PbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDatosExtra.SuspendLayout()
        CType(Me.dgvHistorialCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.SlateGray
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(948, 22)
        Me.txtTitulo.TabIndex = 25
        Me.txtTitulo.Text = "Mantenimiento Cliente"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbcCliente
        '
        Me.tbcCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcCliente.Controls.Add(Me.tbpListar)
        Me.tbcCliente.Controls.Add(Me.tbpNuevo)
        Me.tbcCliente.Controls.Add(Me.tbpDatosExtra)
        Me.tbcCliente.Location = New System.Drawing.Point(7, 34)
        Me.tbcCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbcCliente.Name = "tbcCliente"
        Me.tbcCliente.SelectedIndex = 0
        Me.tbcCliente.Size = New System.Drawing.Size(936, 442)
        Me.tbcCliente.TabIndex = 26
        '
        'tbpListar
        '
        Me.tbpListar.Controls.Add(Me.txtBusqueda)
        Me.tbpListar.Controls.Add(Me.btnCerrar)
        Me.tbpListar.Controls.Add(Me.btnSeleccionar)
        Me.tbpListar.Controls.Add(Me.chkEstado)
        Me.tbpListar.Controls.Add(Me.btnModificar)
        Me.tbpListar.Controls.Add(Me.btnNuevo)
        Me.tbpListar.Controls.Add(Me.dgvCliente)
        Me.tbpListar.Location = New System.Drawing.Point(4, 27)
        Me.tbpListar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpListar.Size = New System.Drawing.Size(928, 411)
        Me.tbpListar.TabIndex = 0
        Me.tbpListar.Text = "Listar"
        Me.tbpListar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(692, 8)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBusqueda.MaxLength = 350
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(228, 27)
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
        Me.btnCerrar.Location = New System.Drawing.Point(780, 365)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 5
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
        Me.btnSeleccionar.Location = New System.Drawing.Point(8, 365)
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
        Me.chkEstado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.Location = New System.Drawing.Point(7, 12)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(111, 23)
        Me.chkEstado.TabIndex = 2
        Me.chkEstado.Text = "Ver Inactivos"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(300, 365)
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
        Me.btnNuevo.Location = New System.Drawing.Point(154, 365)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.AllowUserToOrderColumns = True
        Me.dgvCliente.AllowUserToResizeRows = False
        Me.dgvCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.IdTipoDocumentoIdentidad, Me.DocumentoIdentidad, Me.CLInombre, Me.CLIdireccion, Me.CLItelefonofijo, Me.CLitelefonomovil, Me.CLIemail, Me.CLIfecharegistro, Me.CLIobservacion, Me.IdCliente, Me.Estado})
        Me.dgvCliente.EnableHeadersVisualStyles = False
        Me.dgvCliente.Location = New System.Drawing.Point(7, 47)
        Me.dgvCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvCliente.MultiSelect = False
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.RowHeadersVisible = False
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(914, 310)
        Me.dgvCliente.TabIndex = 34
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 50
        '
        'IdTipoDocumentoIdentidad
        '
        Me.IdTipoDocumentoIdentidad.HeaderText = "IdTipoDocumentoIdentidad"
        Me.IdTipoDocumentoIdentidad.Name = "IdTipoDocumentoIdentidad"
        Me.IdTipoDocumentoIdentidad.ReadOnly = True
        Me.IdTipoDocumentoIdentidad.Visible = False
        '
        'DocumentoIdentidad
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentoIdentidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.DocumentoIdentidad.HeaderText = "Nro. Documento"
        Me.DocumentoIdentidad.Name = "DocumentoIdentidad"
        Me.DocumentoIdentidad.ReadOnly = True
        '
        'CLInombre
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLInombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.CLInombre.HeaderText = "Nombre"
        Me.CLInombre.Name = "CLInombre"
        Me.CLInombre.ReadOnly = True
        Me.CLInombre.Width = 220
        '
        'CLIdireccion
        '
        Me.CLIdireccion.HeaderText = "Dirección"
        Me.CLIdireccion.Name = "CLIdireccion"
        Me.CLIdireccion.ReadOnly = True
        Me.CLIdireccion.Width = 150
        '
        'CLItelefonofijo
        '
        Me.CLItelefonofijo.HeaderText = "Telf. Fijo"
        Me.CLItelefonofijo.Name = "CLItelefonofijo"
        Me.CLItelefonofijo.ReadOnly = True
        Me.CLItelefonofijo.Width = 70
        '
        'CLitelefonomovil
        '
        Me.CLitelefonomovil.HeaderText = "Telf. Movil"
        Me.CLitelefonomovil.Name = "CLitelefonomovil"
        Me.CLitelefonomovil.ReadOnly = True
        Me.CLitelefonomovil.Width = 70
        '
        'CLIemail
        '
        Me.CLIemail.HeaderText = "Email"
        Me.CLIemail.Name = "CLIemail"
        Me.CLIemail.ReadOnly = True
        '
        'CLIfecharegistro
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIfecharegistro.DefaultCellStyle = DataGridViewCellStyle3
        Me.CLIfecharegistro.HeaderText = "Registro"
        Me.CLIfecharegistro.Name = "CLIfecharegistro"
        Me.CLIfecharegistro.ReadOnly = True
        Me.CLIfecharegistro.Width = 80
        '
        'CLIobservacion
        '
        Me.CLIobservacion.HeaderText = "Observación"
        Me.CLIobservacion.Name = "CLIobservacion"
        Me.CLIobservacion.ReadOnly = True
        Me.CLIobservacion.Visible = False
        Me.CLIobservacion.Width = 120
        '
        'IdCliente
        '
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        Me.IdCliente.Visible = False
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
        Me.tbpNuevo.Size = New System.Drawing.Size(928, 411)
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
        Me.grpAccion.Location = New System.Drawing.Point(8, 318)
        Me.grpAccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAccion.Name = "grpAccion"
        Me.grpAccion.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAccion.Size = New System.Drawing.Size(881, 73)
        Me.grpAccion.TabIndex = 3
        Me.grpAccion.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaServox2015.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(466, 22)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 28)
        Me.btnCancelar.TabIndex = 8
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
        Me.btnGuardar.Location = New System.Drawing.Point(319, 22)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 28)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'grpDatos
        '
        Me.grpDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDatos.Controls.Add(Me.btnExaminar)
        Me.grpDatos.Controls.Add(Me.PbImagen)
        Me.grpDatos.Controls.Add(Me.Label10)
        Me.grpDatos.Controls.Add(Me.txtObservacion)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.txtEmail)
        Me.grpDatos.Controls.Add(Me.Label3)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.txtTelefonoMovil)
        Me.grpDatos.Controls.Add(Me.txtTelefonoFijo)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.txtNroDocumentoIdentidad)
        Me.grpDatos.Controls.Add(Me.cmbTipoDocumentoIdentidad)
        Me.grpDatos.Controls.Add(Me.cmbEstado)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.txtIdEmpleado)
        Me.grpDatos.Controls.Add(Me.txtNombreCompleto)
        Me.grpDatos.Controls.Add(Me.Label5)
        Me.grpDatos.Location = New System.Drawing.Point(8, 6)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDatos.Size = New System.Drawing.Size(881, 315)
        Me.grpDatos.TabIndex = 2
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'btnExaminar
        '
        Me.btnExaminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExaminar.BackColor = System.Drawing.Color.White
        Me.btnExaminar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExaminar.Location = New System.Drawing.Point(715, 275)
        Me.btnExaminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(125, 31)
        Me.btnExaminar.TabIndex = 115
        Me.btnExaminar.Text = "&Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = False
        Me.btnExaminar.Visible = False
        '
        'PbImagen
        '
        Me.PbImagen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbImagen.Location = New System.Drawing.Point(715, 29)
        Me.PbImagen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PbImagen.Name = "PbImagen"
        Me.PbImagen.Size = New System.Drawing.Size(125, 237)
        Me.PbImagen.TabIndex = 114
        Me.PbImagen.TabStop = False
        Me.PbImagen.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 19)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(11, 400)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtObservacion.MaxLength = 350
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(564, 27)
        Me.txtObservacion.TabIndex = 112
        Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 19)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(11, 337)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.MaxLength = 350
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(279, 27)
        Me.txtEmail.TabIndex = 110
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Telf. Móvil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Telf. Fijo"
        '
        'txtTelefonoMovil
        '
        Me.txtTelefonoMovil.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefonoMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonoMovil.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoMovil.Location = New System.Drawing.Point(259, 242)
        Me.txtTelefonoMovil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefonoMovil.MaxLength = 350
        Me.txtTelefonoMovil.Name = "txtTelefonoMovil"
        Me.txtTelefonoMovil.Size = New System.Drawing.Size(241, 27)
        Me.txtTelefonoMovil.TabIndex = 6
        Me.txtTelefonoMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelefonoFijo
        '
        Me.txtTelefonoFijo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefonoFijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonoFijo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoFijo.Location = New System.Drawing.Point(12, 242)
        Me.txtTelefonoFijo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefonoFijo.MaxLength = 350
        Me.txtTelefonoFijo.Name = "txtTelefonoFijo"
        Me.txtTelefonoFijo.Size = New System.Drawing.Size(241, 27)
        Me.txtTelefonoFijo.TabIndex = 5
        Me.txtTelefonoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(11, 184)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDireccion.MaxLength = 350
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(564, 27)
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(324, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 19)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Nro. Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Tipo Documento"
        '
        'txtNroDocumentoIdentidad
        '
        Me.txtNroDocumentoIdentidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtNroDocumentoIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocumentoIdentidad.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumentoIdentidad.Location = New System.Drawing.Point(328, 122)
        Me.txtNroDocumentoIdentidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNroDocumentoIdentidad.MaxLength = 350
        Me.txtNroDocumentoIdentidad.Name = "txtNroDocumentoIdentidad"
        Me.txtNroDocumentoIdentidad.Size = New System.Drawing.Size(248, 27)
        Me.txtNroDocumentoIdentidad.TabIndex = 3
        Me.txtNroDocumentoIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbTipoDocumentoIdentidad
        '
        Me.cmbTipoDocumentoIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumentoIdentidad.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocumentoIdentidad.FormattingEnabled = True
        Me.cmbTipoDocumentoIdentidad.Location = New System.Drawing.Point(11, 121)
        Me.cmbTipoDocumentoIdentidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTipoDocumentoIdentidad.Name = "cmbTipoDocumentoIdentidad"
        Me.cmbTipoDocumentoIdentidad.Size = New System.Drawing.Size(311, 26)
        Me.cmbTipoDocumentoIdentidad.TabIndex = 2
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(11, 462)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(243, 27)
        Me.cmbEstado.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 436)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Estado :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Id"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdEmpleado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEmpleado.Location = New System.Drawing.Point(11, 54)
        Me.txtIdEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdEmpleado.MaxLength = 350
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.ReadOnly = True
        Me.txtIdEmpleado.Size = New System.Drawing.Size(71, 27)
        Me.txtIdEmpleado.TabIndex = 43
        Me.txtIdEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(88, 54)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreCompleto.MaxLength = 350
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(488, 27)
        Me.txtNombreCompleto.TabIndex = 1
        Me.txtNombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 19)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Nombre Completo"
        '
        'tbpDatosExtra
        '
        Me.tbpDatosExtra.Controls.Add(Me.dtpVentasHasta)
        Me.tbpDatosExtra.Controls.Add(Me.dtpVentasDesde)
        Me.tbpDatosExtra.Controls.Add(Me.dgvHistorialCompras)
        Me.tbpDatosExtra.Controls.Add(Me.btnExcel)
        Me.tbpDatosExtra.Controls.Add(Me.btnGenerarHistorial)
        Me.tbpDatosExtra.Location = New System.Drawing.Point(4, 27)
        Me.tbpDatosExtra.Name = "tbpDatosExtra"
        Me.tbpDatosExtra.Size = New System.Drawing.Size(928, 411)
        Me.tbpDatosExtra.TabIndex = 2
        Me.tbpDatosExtra.Text = "Historial"
        Me.tbpDatosExtra.UseVisualStyleBackColor = True
        '
        'dtpVentasHasta
        '
        Me.dtpVentasHasta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVentasHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVentasHasta.Location = New System.Drawing.Point(129, 7)
        Me.dtpVentasHasta.Name = "dtpVentasHasta"
        Me.dtpVentasHasta.Size = New System.Drawing.Size(116, 27)
        Me.dtpVentasHasta.TabIndex = 39
        '
        'dtpVentasDesde
        '
        Me.dtpVentasDesde.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVentasDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVentasDesde.Location = New System.Drawing.Point(7, 7)
        Me.dtpVentasDesde.Name = "dtpVentasDesde"
        Me.dtpVentasDesde.Size = New System.Drawing.Size(116, 27)
        Me.dtpVentasDesde.TabIndex = 38
        '
        'dgvHistorialCompras
        '
        Me.dgvHistorialCompras.AllowUserToAddRows = False
        Me.dgvHistorialCompras.AllowUserToDeleteRows = False
        Me.dgvHistorialCompras.AllowUserToOrderColumns = True
        Me.dgvHistorialCompras.AllowUserToResizeRows = False
        Me.dgvHistorialCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistorialCompras.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistorialCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoDocumento, Me.Documento, Me.Nombre, Me.TipoComprobante, Me.Serie, Me.Numero, Me.Fecha, Me.Total})
        Me.dgvHistorialCompras.EnableHeadersVisualStyles = False
        Me.dgvHistorialCompras.Location = New System.Drawing.Point(7, 38)
        Me.dgvHistorialCompras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvHistorialCompras.MultiSelect = False
        Me.dgvHistorialCompras.Name = "dgvHistorialCompras"
        Me.dgvHistorialCompras.ReadOnly = True
        Me.dgvHistorialCompras.RowHeadersVisible = False
        Me.dgvHistorialCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorialCompras.Size = New System.Drawing.Size(914, 360)
        Me.dgvHistorialCompras.TabIndex = 35
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
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'TipoComprobante
        '
        Me.TipoComprobante.HeaderText = "Comprobante"
        Me.TipoComprobante.Name = "TipoComprobante"
        Me.TipoComprobante.ReadOnly = True
        Me.TipoComprobante.Width = 70
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 140
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.White
        Me.btnExcel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Image = Global.SistemaServox2015.My.Resources.Resources.page_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(781, 6)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(140, 28)
        Me.btnExcel.TabIndex = 37
        Me.btnExcel.Text = "E&xcel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnGenerarHistorial
        '
        Me.btnGenerarHistorial.BackColor = System.Drawing.Color.White
        Me.btnGenerarHistorial.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarHistorial.Image = Global.SistemaServox2015.My.Resources.Resources.accept
        Me.btnGenerarHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarHistorial.Location = New System.Drawing.Point(251, 7)
        Me.btnGenerarHistorial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerarHistorial.Name = "btnGenerarHistorial"
        Me.btnGenerarHistorial.Size = New System.Drawing.Size(140, 28)
        Me.btnGenerarHistorial.TabIndex = 36
        Me.btnGenerarHistorial.Text = "&Generar"
        Me.btnGenerarHistorial.UseVisualStyleBackColor = False
        '
        'frmMantenimientoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(948, 480)
        Me.Controls.Add(Me.tbcCliente)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMantenimientoCliente"
        Me.tbcCliente.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.tbpListar.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpNuevo.ResumeLayout(False)
        Me.grpAccion.ResumeLayout(False)
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.PbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDatosExtra.ResumeLayout(False)
        CType(Me.dgvHistorialCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents tbcCliente As System.Windows.Forms.TabControl
    Friend WithEvents tbpListar As System.Windows.Forms.TabPage
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents tbpNuevo As System.Windows.Forms.TabPage
    Friend WithEvents grpAccion As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoDocumentoIdentidad As System.Windows.Forms.ComboBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Private WithEvents PbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoMovil As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoFijo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNroDocumentoIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoDocumentoIdentidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoIdentidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelefonofijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLitelefonomovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIemail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfecharegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents tbpDatosExtra As System.Windows.Forms.TabPage
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnGenerarHistorial As System.Windows.Forms.Button
    Friend WithEvents dgvHistorialCompras As System.Windows.Forms.DataGridView
    Friend WithEvents TipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpVentasHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpVentasDesde As System.Windows.Forms.DateTimePicker
End Class
