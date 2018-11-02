<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoEmpleado
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
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tbpNuevo = New System.Windows.Forms.TabPage()
        Me.grpAccion = New System.Windows.Forms.GroupBox()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNroDocumentoIdentidad = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbpDatosExtra = New System.Windows.Forms.TabPage()
        Me.dtpVentasHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpVentasDesde = New System.Windows.Forms.DateTimePicker()
        Me.dgvHistorialComisiones = New System.Windows.Forms.DataGridView()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROdescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoComision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnGenerarHistorial = New System.Windows.Forms.Button()
        Me.tbcCliente.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpNuevo.SuspendLayout()
        Me.grpAccion.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.tbpDatosExtra.SuspendLayout()
        CType(Me.dgvHistorialComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtTitulo.Size = New System.Drawing.Size(998, 22)
        Me.txtTitulo.TabIndex = 25
        Me.txtTitulo.Text = "Mantenimiento Empleado"
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
        Me.tbcCliente.Location = New System.Drawing.Point(0, 30)
        Me.tbcCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbcCliente.Name = "tbcCliente"
        Me.tbcCliente.SelectedIndex = 0
        Me.tbcCliente.Size = New System.Drawing.Size(986, 442)
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
        Me.tbpListar.Controls.Add(Me.dgvEmpleado)
        Me.tbpListar.Location = New System.Drawing.Point(4, 27)
        Me.tbpListar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbpListar.Size = New System.Drawing.Size(978, 411)
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
        Me.txtBusqueda.Location = New System.Drawing.Point(744, 11)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBusqueda.MaxLength = 350
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(228, 27)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'dgvEmpleado
        '
        Me.dgvEmpleado.AllowUserToAddRows = False
        Me.dgvEmpleado.AllowUserToDeleteRows = False
        Me.dgvEmpleado.AllowUserToOrderColumns = True
        Me.dgvEmpleado.AllowUserToResizeRows = False
        Me.dgvEmpleado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmpleado.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.IdEmpleado, Me.Apellidos, Me.Nombres, Me.Estado})
        Me.dgvEmpleado.EnableHeadersVisualStyles = False
        Me.dgvEmpleado.Location = New System.Drawing.Point(8, 47)
        Me.dgvEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvEmpleado.MultiSelect = False
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.ReadOnly = True
        Me.dgvEmpleado.RowHeadersVisible = False
        Me.dgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleado.Size = New System.Drawing.Size(964, 305)
        Me.dgvEmpleado.TabIndex = 34
        '
        'DNI
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNI.DefaultCellStyle = DataGridViewCellStyle1
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Width = 120
        '
        'IdEmpleado
        '
        Me.IdEmpleado.HeaderText = "IdCliente"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'Apellidos
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apellidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        Me.Apellidos.Width = 250
        '
        'Nombres
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombres.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        Me.Nombres.Width = 200
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
        Me.tbpNuevo.Size = New System.Drawing.Size(978, 411)
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
        Me.grpAccion.Size = New System.Drawing.Size(887, 73)
        Me.grpAccion.TabIndex = 3
        Me.grpAccion.TabStop = False
        '
        'grpDatos
        '
        Me.grpDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDatos.Controls.Add(Me.txtNombres)
        Me.grpDatos.Controls.Add(Me.Label11)
        Me.grpDatos.Controls.Add(Me.Label10)
        Me.grpDatos.Controls.Add(Me.txtObservacion)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.txtEmail)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.txtNroDocumentoIdentidad)
        Me.grpDatos.Controls.Add(Me.cmbEstado)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.txtIdCliente)
        Me.grpDatos.Controls.Add(Me.txtApellidos)
        Me.grpDatos.Controls.Add(Me.Label5)
        Me.grpDatos.Location = New System.Drawing.Point(8, 6)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDatos.Size = New System.Drawing.Size(887, 315)
        Me.grpDatos.TabIndex = 2
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(88, 121)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombres.MaxLength = 350
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(320, 27)
        Me.txtNombres.TabIndex = 3
        Me.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 19)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Nombres"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 19)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "DNI"
        '
        'txtNroDocumentoIdentidad
        '
        Me.txtNroDocumentoIdentidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtNroDocumentoIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocumentoIdentidad.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumentoIdentidad.Location = New System.Drawing.Point(88, 156)
        Me.txtNroDocumentoIdentidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNroDocumentoIdentidad.MaxLength = 350
        Me.txtNroDocumentoIdentidad.Name = "txtNroDocumentoIdentidad"
        Me.txtNroDocumentoIdentidad.Size = New System.Drawing.Size(260, 27)
        Me.txtNroDocumentoIdentidad.TabIndex = 4
        Me.txtNroDocumentoIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label6.Location = New System.Drawing.Point(57, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Id"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.Location = New System.Drawing.Point(88, 51)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdCliente.MaxLength = 350
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(71, 27)
        Me.txtIdCliente.TabIndex = 1
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.SystemColors.Window
        Me.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellidos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(88, 86)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellidos.MaxLength = 350
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(320, 27)
        Me.txtApellidos.TabIndex = 2
        Me.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Apellidos"
        '
        'tbpDatosExtra
        '
        Me.tbpDatosExtra.Controls.Add(Me.dtpVentasHasta)
        Me.tbpDatosExtra.Controls.Add(Me.dtpVentasDesde)
        Me.tbpDatosExtra.Controls.Add(Me.btnExcel)
        Me.tbpDatosExtra.Controls.Add(Me.btnGenerarHistorial)
        Me.tbpDatosExtra.Controls.Add(Me.dgvHistorialComisiones)
        Me.tbpDatosExtra.Location = New System.Drawing.Point(4, 27)
        Me.tbpDatosExtra.Name = "tbpDatosExtra"
        Me.tbpDatosExtra.Size = New System.Drawing.Size(978, 411)
        Me.tbpDatosExtra.TabIndex = 2
        Me.tbpDatosExtra.Text = "Comisiones"
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
        'dgvHistorialComisiones
        '
        Me.dgvHistorialComisiones.AllowUserToAddRows = False
        Me.dgvHistorialComisiones.AllowUserToDeleteRows = False
        Me.dgvHistorialComisiones.AllowUserToOrderColumns = True
        Me.dgvHistorialComisiones.AllowUserToResizeRows = False
        Me.dgvHistorialComisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistorialComisiones.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistorialComisiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Serie, Me.Numero, Me.Fecha, Me.Precio, Me.Cantidad, Me.PROnombre, Me.PROdescripcion, Me.Operacion, Me.Empleado, Me.MontoComision})
        Me.dgvHistorialComisiones.EnableHeadersVisualStyles = False
        Me.dgvHistorialComisiones.Location = New System.Drawing.Point(7, 38)
        Me.dgvHistorialComisiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvHistorialComisiones.MultiSelect = False
        Me.dgvHistorialComisiones.Name = "dgvHistorialComisiones"
        Me.dgvHistorialComisiones.ReadOnly = True
        Me.dgvHistorialComisiones.RowHeadersVisible = False
        Me.dgvHistorialComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorialComisiones.Size = New System.Drawing.Size(964, 360)
        Me.dgvHistorialComisiones.TabIndex = 35
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        Me.Serie.Width = 60
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
        Me.Fecha.Width = 80
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 70
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cant"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 50
        '
        'PROnombre
        '
        Me.PROnombre.HeaderText = "Producto"
        Me.PROnombre.Name = "PROnombre"
        Me.PROnombre.ReadOnly = True
        '
        'PROdescripcion
        '
        Me.PROdescripcion.HeaderText = "Descripción Producto"
        Me.PROdescripcion.Name = "PROdescripcion"
        Me.PROdescripcion.ReadOnly = True
        Me.PROdescripcion.Width = 160
        '
        'Operacion
        '
        Me.Operacion.HeaderText = "Op"
        Me.Operacion.Name = "Operacion"
        Me.Operacion.ReadOnly = True
        Me.Operacion.Width = 60
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        Me.Empleado.Width = 140
        '
        'MontoComision
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.MontoComision.DefaultCellStyle = DataGridViewCellStyle4
        Me.MontoComision.HeaderText = "Monto"
        Me.MontoComision.Name = "MontoComision"
        Me.MontoComision.ReadOnly = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(832, 375)
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
        Me.btnSeleccionar.Location = New System.Drawing.Point(8, 360)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(140, 28)
        Me.btnSeleccionar.TabIndex = 2
        Me.btnSeleccionar.Text = "&Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(300, 360)
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
        Me.btnNuevo.Location = New System.Drawing.Point(154, 360)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.White
        Me.btnExcel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Image = Global.SistemaServox2015.My.Resources.Resources.page_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(831, 6)
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
        'frmMantenimientoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(998, 480)
        Me.Controls.Add(Me.tbcCliente)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMantenimientoEmpleado"
        Me.tbcCliente.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.tbpListar.PerformLayout()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpNuevo.ResumeLayout(False)
        Me.grpAccion.ResumeLayout(False)
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.tbpDatosExtra.ResumeLayout(False)
        CType(Me.dgvHistorialComisiones, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvEmpleado As System.Windows.Forms.DataGridView
    Friend WithEvents tbpNuevo As System.Windows.Forms.TabPage
    Friend WithEvents grpAccion As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNroDocumentoIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents tbpDatosExtra As System.Windows.Forms.TabPage
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnGenerarHistorial As System.Windows.Forms.Button
    Friend WithEvents dgvHistorialComisiones As System.Windows.Forms.DataGridView
    Friend WithEvents dtpVentasHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpVentasDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROnombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROdescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoComision As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
