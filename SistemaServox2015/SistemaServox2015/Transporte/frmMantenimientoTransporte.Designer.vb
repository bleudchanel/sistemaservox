<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoTransporte
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
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.tbcCompras = New System.Windows.Forms.TabControl()
        Me.tbpListar = New System.Windows.Forms.TabPage()
        Me.grpCabecera = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMontoTransporte = New SistemaServox2015.MoneyTextBox(Me.components)
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
        Me.dgvComprobantesTransporte = New System.Windows.Forms.DataGridView()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorCompras = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.tbcCompras.SuspendLayout()
        Me.tbpListar.SuspendLayout()
        Me.grpCabecera.SuspendLayout()
        Me.grpNavegar.SuspendLayout()
        Me.tbpDatosExtra.SuspendLayout()
        CType(Me.dgvComprobantesTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.DarkBlue
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
        Me.txtTitulo.Text = "MANTENIMIENTO DE TRANSPORTE"
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
        Me.tbcCompras.Size = New System.Drawing.Size(977, 287)
        Me.tbcCompras.TabIndex = 27
        '
        'tbpListar
        '
        Me.tbpListar.Controls.Add(Me.grpCabecera)
        Me.tbpListar.Location = New System.Drawing.Point(4, 24)
        Me.tbpListar.Name = "tbpListar"
        Me.tbpListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpListar.Size = New System.Drawing.Size(969, 259)
        Me.tbpListar.TabIndex = 0
        Me.tbpListar.Text = "Listar"
        Me.tbpListar.UseVisualStyleBackColor = True
        '
        'grpCabecera
        '
        Me.grpCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCabecera.Controls.Add(Me.Label4)
        Me.grpCabecera.Controls.Add(Me.txtMontoTransporte)
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
        Me.grpCabecera.Size = New System.Drawing.Size(956, 226)
        Me.grpCabecera.TabIndex = 75
        Me.grpCabecera.TabStop = False
        Me.grpCabecera.Text = "Cabecera"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(806, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "Monto :"
        '
        'txtMontoTransporte
        '
        Me.txtMontoTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoTransporte.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtMontoTransporte.Location = New System.Drawing.Point(809, 154)
        Me.txtMontoTransporte.Name = "txtMontoTransporte"
        Me.txtMontoTransporte.Size = New System.Drawing.Size(137, 27)
        Me.txtMontoTransporte.TabIndex = 205
        Me.txtMontoTransporte.Text = "0.00"
        Me.txtMontoTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtIGV.Visible = False
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
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 136)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 154)
        Me.txtDescripcion.MaxLength = 350
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(791, 27)
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
        Me.tbpDatosExtra.Controls.Add(Me.dgvComprobantesTransporte)
        Me.tbpDatosExtra.Location = New System.Drawing.Point(4, 24)
        Me.tbpDatosExtra.Name = "tbpDatosExtra"
        Me.tbpDatosExtra.Size = New System.Drawing.Size(969, 259)
        Me.tbpDatosExtra.TabIndex = 1
        Me.tbpDatosExtra.Text = "Datos Extra"
        Me.tbpDatosExtra.UseVisualStyleBackColor = True
        '
        'dgvComprobantesTransporte
        '
        Me.dgvComprobantesTransporte.AllowUserToAddRows = False
        Me.dgvComprobantesTransporte.AllowUserToDeleteRows = False
        Me.dgvComprobantesTransporte.AllowUserToOrderColumns = True
        Me.dgvComprobantesTransporte.AllowUserToResizeRows = False
        Me.dgvComprobantesTransporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComprobantesTransporte.BackgroundColor = System.Drawing.Color.White
        Me.dgvComprobantesTransporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Serie, Me.Numero, Me.Fecha, Me.Observacion, Me.Tipo})
        Me.dgvComprobantesTransporte.EnableHeadersVisualStyles = False
        Me.dgvComprobantesTransporte.Location = New System.Drawing.Point(19, 15)
        Me.dgvComprobantesTransporte.MultiSelect = False
        Me.dgvComprobantesTransporte.Name = "dgvComprobantesTransporte"
        Me.dgvComprobantesTransporte.ReadOnly = True
        Me.dgvComprobantesTransporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComprobantesTransporte.Size = New System.Drawing.Size(938, 225)
        Me.dgvComprobantesTransporte.TabIndex = 35
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        Me.Serie.Width = 40
        '
        'Numero
        '
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        Me.Numero.Width = 80
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 80
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 500
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 150
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
        Me.btnCancelar.Location = New System.Drawing.Point(452, 323)
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
        Me.btnGuardar.Location = New System.Drawing.Point(160, 323)
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
        Me.btnCerrar.Location = New System.Drawing.Point(835, 323)
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
        Me.btnNuevo.Location = New System.Drawing.Point(14, 323)
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
        Me.btnModificar.Location = New System.Drawing.Point(306, 323)
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
        Me.btnAnular.Location = New System.Drawing.Point(606, 323)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(140, 28)
        Me.btnAnular.TabIndex = 5
        Me.btnAnular.Text = "&Anular"
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'frmMantenimientoTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 360)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.tbcCompras)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAnular)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMantenimientoTransporte"
        Me.tbcCompras.ResumeLayout(False)
        Me.tbpListar.ResumeLayout(False)
        Me.grpCabecera.ResumeLayout(False)
        Me.grpCabecera.PerformLayout()
        Me.grpNavegar.ResumeLayout(False)
        Me.tbpDatosExtra.ResumeLayout(False)
        CType(Me.dgvComprobantesTransporte, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents txtProveedorRUC As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarProveedor As System.Windows.Forms.Button
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
    Friend WithEvents grpNavegar As System.Windows.Forms.GroupBox
    Friend WithEvents txtIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSerie As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ErrorCompras As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblCodigoProveedor As System.Windows.Forms.Label
    Friend WithEvents tbpDatosExtra As System.Windows.Forms.TabPage
    Friend WithEvents chkActivarBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMontoTransporte As SistemaServox2015.MoneyTextBox
    Friend WithEvents dgvComprobantesTransporte As System.Windows.Forms.DataGridView
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
