<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteProductoAvanzado
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
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.grpReporteProducto = New System.Windows.Forms.GroupBox()
        Me.grpControles = New System.Windows.Forms.GroupBox()
        Me.btnReporteGrafico = New System.Windows.Forms.Button()
        Me.btnGenerarReporteIndividual = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.btnGenerarDataAnual = New System.Windows.Forms.Button()
        Me.btnGenerarData = New System.Windows.Forms.Button()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReporteProducto.SuspendLayout()
        Me.grpControles.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.Producto, Me.Descripcion, Me.Cantidad, Me.PrecioVenta, Me.Total})
        Me.dgvCliente.EnableHeadersVisualStyles = False
        Me.dgvCliente.Location = New System.Drawing.Point(6, 44)
        Me.dgvCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvCliente.MultiSelect = False
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.RowHeadersVisible = False
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(794, 338)
        Me.dgvCliente.TabIndex = 35
        '
        'grpReporteProducto
        '
        Me.grpReporteProducto.Controls.Add(Me.lblAviso)
        Me.grpReporteProducto.Controls.Add(Me.dgvCliente)
        Me.grpReporteProducto.Location = New System.Drawing.Point(6, 101)
        Me.grpReporteProducto.Name = "grpReporteProducto"
        Me.grpReporteProducto.Size = New System.Drawing.Size(806, 400)
        Me.grpReporteProducto.TabIndex = 36
        Me.grpReporteProducto.TabStop = False
        Me.grpReporteProducto.Text = "Productos"
        '
        'grpControles
        '
        Me.grpControles.Controls.Add(Me.btnReporteGrafico)
        Me.grpControles.Controls.Add(Me.btnGenerarReporteIndividual)
        Me.grpControles.Controls.Add(Me.btnCerrar)
        Me.grpControles.Location = New System.Drawing.Point(6, 507)
        Me.grpControles.Name = "grpControles"
        Me.grpControles.Size = New System.Drawing.Size(806, 57)
        Me.grpControles.TabIndex = 37
        Me.grpControles.TabStop = False
        Me.grpControles.Text = "Controles"
        '
        'btnReporteGrafico
        '
        Me.btnReporteGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporteGrafico.BackColor = System.Drawing.Color.White
        Me.btnReporteGrafico.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteGrafico.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnReporteGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteGrafico.Location = New System.Drawing.Point(197, 22)
        Me.btnReporteGrafico.Name = "btnReporteGrafico"
        Me.btnReporteGrafico.Size = New System.Drawing.Size(176, 28)
        Me.btnReporteGrafico.TabIndex = 88
        Me.btnReporteGrafico.Text = "&Gráfico"
        Me.btnReporteGrafico.UseVisualStyleBackColor = False
        '
        'btnGenerarReporteIndividual
        '
        Me.btnGenerarReporteIndividual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarReporteIndividual.BackColor = System.Drawing.Color.White
        Me.btnGenerarReporteIndividual.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarReporteIndividual.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnGenerarReporteIndividual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarReporteIndividual.Location = New System.Drawing.Point(15, 22)
        Me.btnGenerarReporteIndividual.Name = "btnGenerarReporteIndividual"
        Me.btnGenerarReporteIndividual.Size = New System.Drawing.Size(176, 28)
        Me.btnGenerarReporteIndividual.TabIndex = 86
        Me.btnGenerarReporteIndividual.Text = "&Reporte Individual"
        Me.btnGenerarReporteIndividual.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(660, 23)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 87
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.btnGenerarDataAnual)
        Me.grpDatos.Controls.Add(Me.btnGenerarData)
        Me.grpDatos.Controls.Add(Me.cmbAnio)
        Me.grpDatos.Controls.Add(Me.cmbMes)
        Me.grpDatos.Location = New System.Drawing.Point(6, 31)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(806, 64)
        Me.grpDatos.TabIndex = 38
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Filtro"
        '
        'btnGenerarDataAnual
        '
        Me.btnGenerarDataAnual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarDataAnual.BackColor = System.Drawing.Color.White
        Me.btnGenerarDataAnual.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarDataAnual.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnGenerarDataAnual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarDataAnual.Location = New System.Drawing.Point(512, 21)
        Me.btnGenerarDataAnual.Name = "btnGenerarDataAnual"
        Me.btnGenerarDataAnual.Size = New System.Drawing.Size(170, 28)
        Me.btnGenerarDataAnual.TabIndex = 88
        Me.btnGenerarDataAnual.Text = "&Ventas Anual"
        Me.btnGenerarDataAnual.UseVisualStyleBackColor = False
        '
        'btnGenerarData
        '
        Me.btnGenerarData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarData.BackColor = System.Drawing.Color.White
        Me.btnGenerarData.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarData.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnGenerarData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarData.Location = New System.Drawing.Point(336, 22)
        Me.btnGenerarData.Name = "btnGenerarData"
        Me.btnGenerarData.Size = New System.Drawing.Size(170, 28)
        Me.btnGenerarData.TabIndex = 87
        Me.btnGenerarData.Text = "&Ventas Mensual"
        Me.btnGenerarData.UseVisualStyleBackColor = False
        '
        'cmbAnio
        '
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(219, 22)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(111, 27)
        Me.cmbAnio.TabIndex = 3
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(12, 22)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(201, 27)
        Me.cmbMes.TabIndex = 2
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.DarkCyan
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(821, 25)
        Me.txtTitulo.TabIndex = 89
        Me.txtTitulo.Text = "Reporte de Producto"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAviso
        '
        Me.lblAviso.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.Location = New System.Drawing.Point(560, 18)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAviso.Size = New System.Drawing.Size(240, 22)
        Me.lblAviso.TabIndex = 36
        Me.lblAviso.Text = "IMPORTANTE"
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Visible = False
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 140
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 250
        '
        'Cantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'PrecioVenta
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PrecioVenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioVenta.HeaderText = "Precio"
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.ReadOnly = True
        '
        'Total
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total.DefaultCellStyle = DataGridViewCellStyle3
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'frmReporteProductoAvanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 575)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpControles)
        Me.Controls.Add(Me.grpReporteProducto)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmReporteProductoAvanzado"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReporteProducto.ResumeLayout(False)
        Me.grpControles.ResumeLayout(False)
        Me.grpDatos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents grpReporteProducto As System.Windows.Forms.GroupBox
    Friend WithEvents grpControles As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerarReporteIndividual As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerarData As System.Windows.Forms.Button
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents btnReporteGrafico As System.Windows.Forms.Button
    Friend WithEvents btnGenerarDataAnual As System.Windows.Forms.Button
    Friend WithEvents lblAviso As System.Windows.Forms.Label
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
