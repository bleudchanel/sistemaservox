<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReporteCompras = New System.Windows.Forms.Button()
        Me.dtpComprasHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpComprasDesde = New System.Windows.Forms.DateTimePicker()
        Me.grpVentasEntreDosFechas = New System.Windows.Forms.GroupBox()
        Me.btnReporteVentasFechas = New System.Windows.Forms.Button()
        Me.dtpVentasHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpVentasDesde = New System.Windows.Forms.DateTimePicker()
        Me.grpInventario = New System.Windows.Forms.GroupBox()
        Me.chkMostrarInventario0 = New System.Windows.Forms.CheckBox()
        Me.btnReporteInventario = New System.Windows.Forms.Button()
        Me.dtpFechaInventario = New System.Windows.Forms.DateTimePicker()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReporteGananciasFechas = New System.Windows.Forms.Button()
        Me.dtpGananciasHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpGananciasDesde = New System.Windows.Forms.DateTimePicker()
        Me.tbcReportes = New System.Windows.Forms.TabControl()
        Me.tbpCompras = New System.Windows.Forms.TabPage()
        Me.tbpVentas = New System.Windows.Forms.TabPage()
        Me.tbpGanancias = New System.Windows.Forms.TabPage()
        Me.tbpInventario = New System.Windows.Forms.TabPage()
        Me.tbpSistema = New System.Windows.Forms.TabPage()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.btnReporteVentasMesAnio = New System.Windows.Forms.Button()
        Me.btnReporteGananciasMesAnio = New System.Windows.Forms.Button()
        Me.cmbMesGanancia = New System.Windows.Forms.ComboBox()
        Me.cmbAnioGanancia = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.grpVentasEntreDosFechas.SuspendLayout()
        Me.grpInventario.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbcReportes.SuspendLayout()
        Me.tbpCompras.SuspendLayout()
        Me.tbpVentas.SuspendLayout()
        Me.tbpGanancias.SuspendLayout()
        Me.tbpInventario.SuspendLayout()
        Me.tbpSistema.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReporteCompras)
        Me.GroupBox1.Controls.Add(Me.dtpComprasHasta)
        Me.GroupBox1.Controls.Add(Me.dtpComprasDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compras entre dos fechas"
        '
        'btnReporteCompras
        '
        Me.btnReporteCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporteCompras.BackColor = System.Drawing.Color.White
        Me.btnReporteCompras.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteCompras.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnReporteCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteCompras.Location = New System.Drawing.Point(265, 46)
        Me.btnReporteCompras.Name = "btnReporteCompras"
        Me.btnReporteCompras.Size = New System.Drawing.Size(140, 28)
        Me.btnReporteCompras.TabIndex = 15
        Me.btnReporteCompras.Text = "&Compras"
        Me.btnReporteCompras.UseVisualStyleBackColor = False
        '
        'dtpComprasHasta
        '
        Me.dtpComprasHasta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpComprasHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpComprasHasta.Location = New System.Drawing.Point(143, 46)
        Me.dtpComprasHasta.Name = "dtpComprasHasta"
        Me.dtpComprasHasta.Size = New System.Drawing.Size(116, 27)
        Me.dtpComprasHasta.TabIndex = 14
        '
        'dtpComprasDesde
        '
        Me.dtpComprasDesde.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpComprasDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpComprasDesde.Location = New System.Drawing.Point(21, 46)
        Me.dtpComprasDesde.Name = "dtpComprasDesde"
        Me.dtpComprasDesde.Size = New System.Drawing.Size(116, 27)
        Me.dtpComprasDesde.TabIndex = 13
        '
        'grpVentasEntreDosFechas
        '
        Me.grpVentasEntreDosFechas.Controls.Add(Me.btnReporteVentasMesAnio)
        Me.grpVentasEntreDosFechas.Controls.Add(Me.cmbAnio)
        Me.grpVentasEntreDosFechas.Controls.Add(Me.cmbMes)
        Me.grpVentasEntreDosFechas.Controls.Add(Me.btnReporteVentasFechas)
        Me.grpVentasEntreDosFechas.Controls.Add(Me.dtpVentasHasta)
        Me.grpVentasEntreDosFechas.Controls.Add(Me.dtpVentasDesde)
        Me.grpVentasEntreDosFechas.Location = New System.Drawing.Point(11, 18)
        Me.grpVentasEntreDosFechas.Name = "grpVentasEntreDosFechas"
        Me.grpVentasEntreDosFechas.Size = New System.Drawing.Size(476, 109)
        Me.grpVentasEntreDosFechas.TabIndex = 1
        Me.grpVentasEntreDosFechas.TabStop = False
        Me.grpVentasEntreDosFechas.Text = "Ventas entre dos fechas"
        '
        'btnReporteVentasFechas
        '
        Me.btnReporteVentasFechas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporteVentasFechas.BackColor = System.Drawing.Color.White
        Me.btnReporteVentasFechas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteVentasFechas.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnReporteVentasFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteVentasFechas.Location = New System.Drawing.Point(295, 30)
        Me.btnReporteVentasFechas.Name = "btnReporteVentasFechas"
        Me.btnReporteVentasFechas.Size = New System.Drawing.Size(161, 28)
        Me.btnReporteVentasFechas.TabIndex = 16
        Me.btnReporteVentasFechas.Text = "&Ventas Fechas"
        Me.btnReporteVentasFechas.UseVisualStyleBackColor = False
        '
        'dtpVentasHasta
        '
        Me.dtpVentasHasta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVentasHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVentasHasta.Location = New System.Drawing.Point(161, 31)
        Me.dtpVentasHasta.Name = "dtpVentasHasta"
        Me.dtpVentasHasta.Size = New System.Drawing.Size(128, 27)
        Me.dtpVentasHasta.TabIndex = 14
        '
        'dtpVentasDesde
        '
        Me.dtpVentasDesde.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVentasDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVentasDesde.Location = New System.Drawing.Point(21, 31)
        Me.dtpVentasDesde.Name = "dtpVentasDesde"
        Me.dtpVentasDesde.Size = New System.Drawing.Size(134, 27)
        Me.dtpVentasDesde.TabIndex = 13
        '
        'grpInventario
        '
        Me.grpInventario.Controls.Add(Me.chkMostrarInventario0)
        Me.grpInventario.Controls.Add(Me.btnReporteInventario)
        Me.grpInventario.Controls.Add(Me.dtpFechaInventario)
        Me.grpInventario.Location = New System.Drawing.Point(12, 17)
        Me.grpInventario.Name = "grpInventario"
        Me.grpInventario.Size = New System.Drawing.Size(485, 101)
        Me.grpInventario.TabIndex = 2
        Me.grpInventario.TabStop = False
        Me.grpInventario.Text = "Inventario hasta una fecha"
        '
        'chkMostrarInventario0
        '
        Me.chkMostrarInventario0.AutoSize = True
        Me.chkMostrarInventario0.Location = New System.Drawing.Point(21, 64)
        Me.chkMostrarInventario0.Name = "chkMostrarInventario0"
        Me.chkMostrarInventario0.Size = New System.Drawing.Size(306, 22)
        Me.chkMostrarInventario0.TabIndex = 17
        Me.chkMostrarInventario0.Text = "NO mostrar productos con inventario 0 o menor"
        Me.chkMostrarInventario0.UseVisualStyleBackColor = True
        '
        'btnReporteInventario
        '
        Me.btnReporteInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporteInventario.BackColor = System.Drawing.Color.White
        Me.btnReporteInventario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteInventario.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnReporteInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteInventario.Location = New System.Drawing.Point(146, 30)
        Me.btnReporteInventario.Name = "btnReporteInventario"
        Me.btnReporteInventario.Size = New System.Drawing.Size(140, 28)
        Me.btnReporteInventario.TabIndex = 16
        Me.btnReporteInventario.Text = "&Inventario"
        Me.btnReporteInventario.UseVisualStyleBackColor = False
        '
        'dtpFechaInventario
        '
        Me.dtpFechaInventario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInventario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInventario.Location = New System.Drawing.Point(21, 31)
        Me.dtpFechaInventario.Name = "dtpFechaInventario"
        Me.dtpFechaInventario.Size = New System.Drawing.Size(119, 27)
        Me.dtpFechaInventario.TabIndex = 13
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(390, 204)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 85
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnBackUp
        '
        Me.btnBackUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBackUp.BackColor = System.Drawing.Color.White
        Me.btnBackUp.Enabled = False
        Me.btnBackUp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUp.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackUp.Location = New System.Drawing.Point(13, -31)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(227, 28)
        Me.btnBackUp.TabIndex = 17
        Me.btnBackUp.Text = "&BackUp del Sistema"
        Me.btnBackUp.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReporteGananciasMesAnio)
        Me.GroupBox2.Controls.Add(Me.cmbMesGanancia)
        Me.GroupBox2.Controls.Add(Me.cmbAnioGanancia)
        Me.GroupBox2.Controls.Add(Me.btnReporteGananciasFechas)
        Me.GroupBox2.Controls.Add(Me.dtpGananciasHasta)
        Me.GroupBox2.Controls.Add(Me.dtpGananciasDesde)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 100)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ganancias entre dos fechas"
        '
        'btnReporteGananciasFechas
        '
        Me.btnReporteGananciasFechas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporteGananciasFechas.BackColor = System.Drawing.Color.White
        Me.btnReporteGananciasFechas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteGananciasFechas.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnReporteGananciasFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteGananciasFechas.Location = New System.Drawing.Point(278, 33)
        Me.btnReporteGananciasFechas.Name = "btnReporteGananciasFechas"
        Me.btnReporteGananciasFechas.Size = New System.Drawing.Size(192, 28)
        Me.btnReporteGananciasFechas.TabIndex = 16
        Me.btnReporteGananciasFechas.Text = "&Ganancias Fechas"
        Me.btnReporteGananciasFechas.UseVisualStyleBackColor = False
        '
        'dtpGananciasHasta
        '
        Me.dtpGananciasHasta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpGananciasHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGananciasHasta.Location = New System.Drawing.Point(146, 34)
        Me.dtpGananciasHasta.Name = "dtpGananciasHasta"
        Me.dtpGananciasHasta.Size = New System.Drawing.Size(126, 27)
        Me.dtpGananciasHasta.TabIndex = 14
        '
        'dtpGananciasDesde
        '
        Me.dtpGananciasDesde.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpGananciasDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGananciasDesde.Location = New System.Drawing.Point(4, 34)
        Me.dtpGananciasDesde.Name = "dtpGananciasDesde"
        Me.dtpGananciasDesde.Size = New System.Drawing.Size(136, 27)
        Me.dtpGananciasDesde.TabIndex = 13
        '
        'tbcReportes
        '
        Me.tbcReportes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcReportes.Controls.Add(Me.tbpCompras)
        Me.tbcReportes.Controls.Add(Me.tbpVentas)
        Me.tbcReportes.Controls.Add(Me.tbpGanancias)
        Me.tbcReportes.Controls.Add(Me.tbpInventario)
        Me.tbcReportes.Controls.Add(Me.tbpSistema)
        Me.tbcReportes.Location = New System.Drawing.Point(12, 31)
        Me.tbcReportes.Name = "tbcReportes"
        Me.tbcReportes.SelectedIndex = 0
        Me.tbcReportes.Size = New System.Drawing.Size(518, 164)
        Me.tbcReportes.TabIndex = 87
        '
        'tbpCompras
        '
        Me.tbpCompras.Controls.Add(Me.GroupBox1)
        Me.tbpCompras.Location = New System.Drawing.Point(4, 27)
        Me.tbpCompras.Name = "tbpCompras"
        Me.tbpCompras.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCompras.Size = New System.Drawing.Size(510, 133)
        Me.tbpCompras.TabIndex = 0
        Me.tbpCompras.Text = "Compras"
        Me.tbpCompras.UseVisualStyleBackColor = True
        '
        'tbpVentas
        '
        Me.tbpVentas.Controls.Add(Me.grpVentasEntreDosFechas)
        Me.tbpVentas.Location = New System.Drawing.Point(4, 27)
        Me.tbpVentas.Name = "tbpVentas"
        Me.tbpVentas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpVentas.Size = New System.Drawing.Size(510, 133)
        Me.tbpVentas.TabIndex = 1
        Me.tbpVentas.Text = "Ventas"
        Me.tbpVentas.UseVisualStyleBackColor = True
        '
        'tbpGanancias
        '
        Me.tbpGanancias.Controls.Add(Me.GroupBox2)
        Me.tbpGanancias.Location = New System.Drawing.Point(4, 27)
        Me.tbpGanancias.Name = "tbpGanancias"
        Me.tbpGanancias.Size = New System.Drawing.Size(510, 133)
        Me.tbpGanancias.TabIndex = 2
        Me.tbpGanancias.Text = "Ganancias"
        Me.tbpGanancias.UseVisualStyleBackColor = True
        '
        'tbpInventario
        '
        Me.tbpInventario.Controls.Add(Me.grpInventario)
        Me.tbpInventario.Location = New System.Drawing.Point(4, 27)
        Me.tbpInventario.Name = "tbpInventario"
        Me.tbpInventario.Size = New System.Drawing.Size(510, 133)
        Me.tbpInventario.TabIndex = 3
        Me.tbpInventario.Text = "Inventario"
        Me.tbpInventario.UseVisualStyleBackColor = True
        '
        'tbpSistema
        '
        Me.tbpSistema.Controls.Add(Me.btnBackUp)
        Me.tbpSistema.Location = New System.Drawing.Point(4, 27)
        Me.tbpSistema.Name = "tbpSistema"
        Me.tbpSistema.Size = New System.Drawing.Size(510, 133)
        Me.tbpSistema.TabIndex = 4
        Me.tbpSistema.Text = "Sistema"
        Me.tbpSistema.UseVisualStyleBackColor = True
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
        Me.txtTitulo.Size = New System.Drawing.Size(542, 25)
        Me.txtTitulo.TabIndex = 88
        Me.txtTitulo.Text = "Reportes"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbAnio
        '
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(21, 64)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(98, 27)
        Me.cmbAnio.TabIndex = 102
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(125, 64)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(164, 27)
        Me.cmbMes.TabIndex = 101
        '
        'btnReporteVentasMesAnio
        '
        Me.btnReporteVentasMesAnio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporteVentasMesAnio.BackColor = System.Drawing.Color.White
        Me.btnReporteVentasMesAnio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteVentasMesAnio.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnReporteVentasMesAnio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteVentasMesAnio.Location = New System.Drawing.Point(295, 64)
        Me.btnReporteVentasMesAnio.Name = "btnReporteVentasMesAnio"
        Me.btnReporteVentasMesAnio.Size = New System.Drawing.Size(161, 28)
        Me.btnReporteVentasMesAnio.TabIndex = 103
        Me.btnReporteVentasMesAnio.Text = "Ventas &Mes y Año"
        Me.btnReporteVentasMesAnio.UseVisualStyleBackColor = False
        '
        'btnReporteGananciasMesAnio
        '
        Me.btnReporteGananciasMesAnio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporteGananciasMesAnio.BackColor = System.Drawing.Color.White
        Me.btnReporteGananciasMesAnio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteGananciasMesAnio.Image = Global.SistemaServox2015.My.Resources.Resources.page_edit
        Me.btnReporteGananciasMesAnio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteGananciasMesAnio.Location = New System.Drawing.Point(278, 67)
        Me.btnReporteGananciasMesAnio.Name = "btnReporteGananciasMesAnio"
        Me.btnReporteGananciasMesAnio.Size = New System.Drawing.Size(192, 28)
        Me.btnReporteGananciasMesAnio.TabIndex = 106
        Me.btnReporteGananciasMesAnio.Text = "Ganancias &Mes y Año"
        Me.btnReporteGananciasMesAnio.UseVisualStyleBackColor = False
        '
        'cmbMesGanancia
        '
        Me.cmbMesGanancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMesGanancia.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMesGanancia.FormattingEnabled = True
        Me.cmbMesGanancia.Location = New System.Drawing.Point(4, 67)
        Me.cmbMesGanancia.Name = "cmbMesGanancia"
        Me.cmbMesGanancia.Size = New System.Drawing.Size(98, 27)
        Me.cmbMesGanancia.TabIndex = 105
        '
        'cmbAnioGanancia
        '
        Me.cmbAnioGanancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnioGanancia.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnioGanancia.FormattingEnabled = True
        Me.cmbAnioGanancia.Location = New System.Drawing.Point(108, 67)
        Me.cmbAnioGanancia.Name = "cmbAnioGanancia"
        Me.cmbAnioGanancia.Size = New System.Drawing.Size(164, 27)
        Me.cmbAnioGanancia.TabIndex = 104
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(542, 244)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.tbcReportes)
        Me.Controls.Add(Me.btnCerrar)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmReportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpVentasEntreDosFechas.ResumeLayout(False)
        Me.grpInventario.ResumeLayout(False)
        Me.grpInventario.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.tbcReportes.ResumeLayout(False)
        Me.tbpCompras.ResumeLayout(False)
        Me.tbpVentas.ResumeLayout(False)
        Me.tbpGanancias.ResumeLayout(False)
        Me.tbpInventario.ResumeLayout(False)
        Me.tbpSistema.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpComprasHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpComprasDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpVentasEntreDosFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtpVentasHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpVentasDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnReporteCompras As System.Windows.Forms.Button
    Friend WithEvents btnReporteVentasFechas As System.Windows.Forms.Button
    Friend WithEvents grpInventario As System.Windows.Forms.GroupBox
    Friend WithEvents btnReporteInventario As System.Windows.Forms.Button
    Friend WithEvents dtpFechaInventario As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkMostrarInventario0 As System.Windows.Forms.CheckBox
    Friend WithEvents btnBackUp As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReporteGananciasFechas As System.Windows.Forms.Button
    Friend WithEvents dtpGananciasHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpGananciasDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbcReportes As System.Windows.Forms.TabControl
    Friend WithEvents tbpCompras As System.Windows.Forms.TabPage
    Friend WithEvents tbpVentas As System.Windows.Forms.TabPage
    Friend WithEvents tbpGanancias As System.Windows.Forms.TabPage
    Friend WithEvents tbpInventario As System.Windows.Forms.TabPage
    Friend WithEvents tbpSistema As System.Windows.Forms.TabPage
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents btnReporteVentasMesAnio As System.Windows.Forms.Button
    Friend WithEvents btnReporteGananciasMesAnio As System.Windows.Forms.Button
    Friend WithEvents cmbMesGanancia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnioGanancia As System.Windows.Forms.ComboBox
End Class
