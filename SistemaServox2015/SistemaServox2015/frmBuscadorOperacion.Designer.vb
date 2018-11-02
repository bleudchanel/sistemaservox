<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscadorOperacion
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
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.dgvOperacion = New System.Windows.Forms.DataGridView()
        Me.IdOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificadorPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Persona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.txtDescripcionOperacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarSerieNumero = New System.Windows.Forms.Button()
        Me.btnBuscarPersona = New System.Windows.Forms.Button()
        Me.txtIdOperacion = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgvOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtTitulo.Size = New System.Drawing.Size(904, 22)
        Me.txtTitulo.TabIndex = 26
        Me.txtTitulo.Text = "Buscar Operación"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvOperacion
        '
        Me.dgvOperacion.AllowUserToAddRows = False
        Me.dgvOperacion.AllowUserToDeleteRows = False
        Me.dgvOperacion.AllowUserToOrderColumns = True
        Me.dgvOperacion.AllowUserToResizeRows = False
        Me.dgvOperacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOperacion.BackgroundColor = System.Drawing.Color.White
        Me.dgvOperacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdOperacion, Me.Serie, Me.Numero, Me.Fecha, Me.FechaRegistra, Me.IdentificadorPersona, Me.Persona, Me.Estado, Me.Descripcion})
        Me.dgvOperacion.EnableHeadersVisualStyles = False
        Me.dgvOperacion.Location = New System.Drawing.Point(5, 114)
        Me.dgvOperacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvOperacion.MultiSelect = False
        Me.dgvOperacion.Name = "dgvOperacion"
        Me.dgvOperacion.ReadOnly = True
        Me.dgvOperacion.RowHeadersVisible = False
        Me.dgvOperacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOperacion.Size = New System.Drawing.Size(895, 319)
        Me.dgvOperacion.TabIndex = 35
        '
        'IdOperacion
        '
        Me.IdOperacion.HeaderText = "IdOperacion"
        Me.IdOperacion.Name = "IdOperacion"
        Me.IdOperacion.ReadOnly = True
        Me.IdOperacion.Visible = False
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
        'FechaRegistra
        '
        Me.FechaRegistra.HeaderText = "FechaRegistra"
        Me.FechaRegistra.Name = "FechaRegistra"
        Me.FechaRegistra.ReadOnly = True
        Me.FechaRegistra.Visible = False
        '
        'IdentificadorPersona
        '
        Me.IdentificadorPersona.HeaderText = "Identificación"
        Me.IdentificadorPersona.Name = "IdentificadorPersona"
        Me.IdentificadorPersona.ReadOnly = True
        '
        'Persona
        '
        Me.Persona.HeaderText = "Nombre / Razón Social"
        Me.Persona.Name = "Persona"
        Me.Persona.ReadOnly = True
        Me.Persona.Width = 250
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.BackColor = System.Drawing.Color.White
        Me.btnSeleccionar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(534, 440)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(140, 28)
        Me.btnSeleccionar.TabIndex = 5
        Me.btnSeleccionar.Text = "&Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'txtDescripcionOperacion
        '
        Me.txtDescripcionOperacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionOperacion.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescripcionOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionOperacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionOperacion.Location = New System.Drawing.Point(176, 440)
        Me.txtDescripcionOperacion.MaxLength = 350
        Me.txtDescripcionOperacion.Name = "txtDescripcionOperacion"
        Me.txtDescripcionOperacion.ReadOnly = True
        Me.txtDescripcionOperacion.Size = New System.Drawing.Size(352, 27)
        Me.txtDescripcionOperacion.TabIndex = 65
        Me.txtDescripcionOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Selección :"
        '
        'txtNumeroIdentificacion
        '
        Me.txtNumeroIdentificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroIdentificacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumeroIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroIdentificacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroIdentificacion.Location = New System.Drawing.Point(123, 67)
        Me.txtNumeroIdentificacion.MaxLength = 350
        Me.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion"
        Me.txtNumeroIdentificacion.Size = New System.Drawing.Size(177, 27)
        Me.txtNumeroIdentificacion.TabIndex = 3
        Me.txtNumeroIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "RUC / DNI"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(76, 32)
        Me.txtNumero.MaxLength = 350
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(224, 27)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Número"
        '
        'btnBuscarSerieNumero
        '
        Me.btnBuscarSerieNumero.BackColor = System.Drawing.Color.White
        Me.btnBuscarSerieNumero.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarSerieNumero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarSerieNumero.Location = New System.Drawing.Point(306, 32)
        Me.btnBuscarSerieNumero.Name = "btnBuscarSerieNumero"
        Me.btnBuscarSerieNumero.Size = New System.Drawing.Size(140, 28)
        Me.btnBuscarSerieNumero.TabIndex = 2
        Me.btnBuscarSerieNumero.Text = "&Buscar"
        Me.btnBuscarSerieNumero.UseVisualStyleBackColor = False
        '
        'btnBuscarPersona
        '
        Me.btnBuscarPersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarPersona.BackColor = System.Drawing.Color.White
        Me.btnBuscarPersona.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPersona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarPersona.Location = New System.Drawing.Point(306, 66)
        Me.btnBuscarPersona.Name = "btnBuscarPersona"
        Me.btnBuscarPersona.Size = New System.Drawing.Size(140, 28)
        Me.btnBuscarPersona.TabIndex = 4
        Me.btnBuscarPersona.Text = "Busca&r"
        Me.btnBuscarPersona.UseVisualStyleBackColor = False
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIdOperacion.BackColor = System.Drawing.SystemColors.Control
        Me.txtIdOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdOperacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacion.Location = New System.Drawing.Point(96, 440)
        Me.txtIdOperacion.MaxLength = 350
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.ReadOnly = True
        Me.txtIdOperacion.Size = New System.Drawing.Size(74, 27)
        Me.txtIdOperacion.TabIndex = 75
        Me.txtIdOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(760, 442)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmBuscadorOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(904, 474)
        Me.Controls.Add(Me.txtIdOperacion)
        Me.Controls.Add(Me.btnBuscarPersona)
        Me.Controls.Add(Me.btnBuscarSerieNumero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumeroIdentificacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcionOperacion)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dgvOperacion)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBuscadorOperacion"
        CType(Me.dgvOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents dgvOperacion As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcionOperacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarSerieNumero As System.Windows.Forms.Button
    Friend WithEvents btnBuscarPersona As System.Windows.Forms.Button
    Friend WithEvents IdOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorPersona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Persona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtIdOperacion As System.Windows.Forms.TextBox
End Class
