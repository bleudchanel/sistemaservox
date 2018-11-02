<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoCodigosUnidad
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
        Me.grpDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvCodigoItem = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtComprobante = New System.Windows.Forms.TextBox()
        Me.txtIdCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.IdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetalleVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoComision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpDetalle.SuspendLayout()
        CType(Me.dgvCodigoItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtTitulo.Size = New System.Drawing.Size(573, 25)
        Me.txtTitulo.TabIndex = 83
        Me.txtTitulo.Text = "Mantenimiento Series por Item"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpDetalle
        '
        Me.grpDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetalle.Controls.Add(Me.dgvCodigoItem)
        Me.grpDetalle.Location = New System.Drawing.Point(6, 157)
        Me.grpDetalle.Name = "grpDetalle"
        Me.grpDetalle.Size = New System.Drawing.Size(558, 323)
        Me.grpDetalle.TabIndex = 84
        Me.grpDetalle.TabStop = False
        Me.grpDetalle.Text = "Detalle"
        '
        'dgvCodigoItem
        '
        Me.dgvCodigoItem.AllowUserToAddRows = False
        Me.dgvCodigoItem.AllowUserToDeleteRows = False
        Me.dgvCodigoItem.AllowUserToOrderColumns = True
        Me.dgvCodigoItem.AllowUserToResizeRows = False
        Me.dgvCodigoItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCodigoItem.BackgroundColor = System.Drawing.Color.White
        Me.dgvCodigoItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCodigo, Me.Indice, Me.IdDetalleVenta, Me.Codigo, Me.Descripcion, Me.Empleado, Me.IdEmpleado, Me.MontoComision})
        Me.dgvCodigoItem.EnableHeadersVisualStyles = False
        Me.dgvCodigoItem.Location = New System.Drawing.Point(9, 19)
        Me.dgvCodigoItem.MultiSelect = False
        Me.dgvCodigoItem.Name = "dgvCodigoItem"
        Me.dgvCodigoItem.ReadOnly = True
        Me.dgvCodigoItem.RowHeadersVisible = False
        Me.dgvCodigoItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCodigoItem.Size = New System.Drawing.Size(540, 298)
        Me.dgvCodigoItem.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(93, 21)
        Me.txtCodigo.MaxLength = 350
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(206, 27)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpDatos
        '
        Me.grpDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDatos.Controls.Add(Me.txtDescripcion)
        Me.grpDatos.Controls.Add(Me.btnEliminar)
        Me.grpDatos.Controls.Add(Me.btnGuardar)
        Me.grpDatos.Controls.Add(Me.btnNuevo)
        Me.grpDatos.Controls.Add(Me.txtComprobante)
        Me.grpDatos.Controls.Add(Me.txtIdCodigo)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.txtCodigo)
        Me.grpDatos.Location = New System.Drawing.Point(3, 26)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(561, 125)
        Me.grpDatos.TabIndex = 86
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDescripcion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.FormattingEnabled = True
        Me.txtDescripcion.Location = New System.Drawing.Point(93, 54)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(206, 27)
        Me.txtDescripcion.TabIndex = 98
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.SistemaServox2015.My.Resources.Resources.delete
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(305, 87)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 28)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaServox2015.My.Resources.Resources.disk
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(159, 87)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 28)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SistemaServox2015.My.Resources.Resources.add
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(13, 87)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtComprobante
        '
        Me.txtComprobante.BackColor = System.Drawing.SystemColors.Control
        Me.txtComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComprobante.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComprobante.Location = New System.Drawing.Point(305, 54)
        Me.txtComprobante.MaxLength = 350
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.ReadOnly = True
        Me.txtComprobante.Size = New System.Drawing.Size(205, 27)
        Me.txtComprobante.TabIndex = 90
        Me.txtComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIdCodigo
        '
        Me.txtIdCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.txtIdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCodigo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCodigo.Location = New System.Drawing.Point(304, 21)
        Me.txtIdCodigo.MaxLength = 350
        Me.txtIdCodigo.Name = "txtIdCodigo"
        Me.txtIdCodigo.ReadOnly = True
        Me.txtIdCodigo.Size = New System.Drawing.Size(46, 27)
        Me.txtIdCodigo.TabIndex = 89
        Me.txtIdCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Serie"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(424, 486)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 87
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'IdCodigo
        '
        Me.IdCodigo.HeaderText = "Id"
        Me.IdCodigo.Name = "IdCodigo"
        Me.IdCodigo.ReadOnly = True
        Me.IdCodigo.Visible = False
        Me.IdCodigo.Width = 40
        '
        'Indice
        '
        Me.Indice.HeaderText = "Index"
        Me.Indice.Name = "Indice"
        Me.Indice.ReadOnly = True
        Me.Indice.Width = 45
        '
        'IdDetalleVenta
        '
        Me.IdDetalleVenta.HeaderText = "IdDetalleVenta"
        Me.IdDetalleVenta.Name = "IdDetalleVenta"
        Me.IdDetalleVenta.ReadOnly = True
        Me.IdDetalleVenta.Visible = False
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Serie"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción/Producto"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 250
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "Comisionado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        Me.Empleado.Visible = False
        Me.Empleado.Width = 240
        '
        'IdEmpleado
        '
        Me.IdEmpleado.HeaderText = "IdEmpleado"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'MontoComision
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoComision.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoComision.HeaderText = "Monto"
        Me.MontoComision.Name = "MontoComision"
        Me.MontoComision.ReadOnly = True
        Me.MontoComision.Visible = False
        '
        'frmMantenimientoCodigosUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(573, 524)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpDetalle)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMantenimientoCodigosUnidad"
        Me.grpDetalle.ResumeLayout(False)
        CType(Me.dgvCodigoItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents grpDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCodigoItem As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtComprobante As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.ComboBox
    Friend WithEvents IdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Indice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDetalleVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoComision As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
