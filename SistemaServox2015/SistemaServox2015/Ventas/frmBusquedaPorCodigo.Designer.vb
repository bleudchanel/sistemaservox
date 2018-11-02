<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaPorCodigo
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
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.grpResultado = New System.Windows.Forms.GroupBox()
        Me.dgvComprobante = New System.Windows.Forms.DataGridView()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnVerOperacion = New System.Windows.Forms.Button()
        Me.Operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperacionDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpResultado.SuspendLayout()
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.SlateGray
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(915, 25)
        Me.txtTitulo.TabIndex = 84
        Me.txtTitulo.Text = "Búsqueda por Serie de Item"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpResultado
        '
        Me.grpResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResultado.Controls.Add(Me.dgvComprobante)
        Me.grpResultado.Location = New System.Drawing.Point(12, 93)
        Me.grpResultado.Name = "grpResultado"
        Me.grpResultado.Size = New System.Drawing.Size(891, 292)
        Me.grpResultado.TabIndex = 85
        Me.grpResultado.TabStop = False
        Me.grpResultado.Text = "Comprobante"
        '
        'dgvComprobante
        '
        Me.dgvComprobante.AllowUserToAddRows = False
        Me.dgvComprobante.AllowUserToDeleteRows = False
        Me.dgvComprobante.AllowUserToOrderColumns = True
        Me.dgvComprobante.AllowUserToResizeRows = False
        Me.dgvComprobante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComprobante.BackgroundColor = System.Drawing.Color.White
        Me.dgvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Operacion, Me.Codigo, Me.Descripcion, Me.Comprobante, Me.Fecha, Me.PrecioUnidad, Me.Cantidad, Me.Producto, Me.OperacionDescripcion, Me.IdTipoComprobante, Me.IdOperacion})
        Me.dgvComprobante.EnableHeadersVisualStyles = False
        Me.dgvComprobante.Location = New System.Drawing.Point(6, 22)
        Me.dgvComprobante.MultiSelect = False
        Me.dgvComprobante.Name = "dgvComprobante"
        Me.dgvComprobante.ReadOnly = True
        Me.dgvComprobante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComprobante.Size = New System.Drawing.Size(879, 264)
        Me.dgvComprobante.TabIndex = 7
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.txtDescripcion)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.txtCodigo)
        Me.grpDatos.Location = New System.Drawing.Point(12, 31)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(566, 56)
        Me.grpDatos.TabIndex = 86
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(354, 20)
        Me.txtDescripcion.MaxLength = 350
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(206, 27)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(63, 20)
        Me.txtCodigo.MaxLength = 350
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(206, 27)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(763, 391)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnVerOperacion
        '
        Me.btnVerOperacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVerOperacion.BackColor = System.Drawing.Color.White
        Me.btnVerOperacion.Image = Global.SistemaServox2015.My.Resources.Resources.zoom
        Me.btnVerOperacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerOperacion.Location = New System.Drawing.Point(12, 391)
        Me.btnVerOperacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVerOperacion.Name = "btnVerOperacion"
        Me.btnVerOperacion.Size = New System.Drawing.Size(140, 28)
        Me.btnVerOperacion.TabIndex = 123
        Me.btnVerOperacion.Text = "&Operación"
        Me.btnVerOperacion.UseVisualStyleBackColor = False
        '
        'Operacion
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operacion.DefaultCellStyle = DataGridViewCellStyle1
        Me.Operacion.HeaderText = "Operación"
        Me.Operacion.Name = "Operacion"
        Me.Operacion.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Serie Item"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 120
        '
        'Comprobante
        '
        Me.Comprobante.HeaderText = "Comprobante"
        Me.Comprobante.Name = "Comprobante"
        Me.Comprobante.ReadOnly = True
        Me.Comprobante.Width = 120
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 90
        '
        'PrecioUnidad
        '
        Me.PrecioUnidad.HeaderText = "PUnidad"
        Me.PrecioUnidad.Name = "PrecioUnidad"
        Me.PrecioUnidad.ReadOnly = True
        Me.PrecioUnidad.Width = 60
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 50
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 150
        '
        'OperacionDescripcion
        '
        Me.OperacionDescripcion.HeaderText = "OperacionDescripcion"
        Me.OperacionDescripcion.Name = "OperacionDescripcion"
        Me.OperacionDescripcion.ReadOnly = True
        Me.OperacionDescripcion.Visible = False
        '
        'IdTipoComprobante
        '
        Me.IdTipoComprobante.HeaderText = "IdTipoComprobante"
        Me.IdTipoComprobante.Name = "IdTipoComprobante"
        Me.IdTipoComprobante.ReadOnly = True
        Me.IdTipoComprobante.Visible = False
        '
        'IdOperacion
        '
        Me.IdOperacion.HeaderText = "IdOperacion"
        Me.IdOperacion.Name = "IdOperacion"
        Me.IdOperacion.ReadOnly = True
        Me.IdOperacion.Visible = False
        '
        'frmBusquedaPorCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(915, 421)
        Me.Controls.Add(Me.btnVerOperacion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpResultado)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBusquedaPorCodigo"
        Me.grpResultado.ResumeLayout(False)
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents grpResultado As System.Windows.Forms.GroupBox
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents dgvComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnVerOperacion As System.Windows.Forms.Button
    Friend WithEvents Operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperacionDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
