<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariablesGlobales
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
        Me.txtIGV = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.grpVariables = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorDolar = New SistemaServox2015.MoneyTextBox(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.grpVariables.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.DarkCyan
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitulo.MaxLength = 200
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(353, 25)
        Me.txtTitulo.TabIndex = 89
        Me.txtTitulo.Text = "Variables Globales"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIGV
        '
        Me.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGV.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.Location = New System.Drawing.Point(137, 54)
        Me.txtIGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(93, 30)
        Me.txtIGV.TabIndex = 90
        Me.txtIGV.Text = "0.00"
        Me.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpVariables
        '
        Me.grpVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpVariables.Controls.Add(Me.btnGuardar)
        Me.grpVariables.Controls.Add(Me.Label2)
        Me.grpVariables.Controls.Add(Me.txtValorDolar)
        Me.grpVariables.Controls.Add(Me.Label1)
        Me.grpVariables.Controls.Add(Me.txtIGV)
        Me.grpVariables.Location = New System.Drawing.Point(14, 43)
        Me.grpVariables.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpVariables.Name = "grpVariables"
        Me.grpVariables.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpVariables.Size = New System.Drawing.Size(327, 197)
        Me.grpVariables.TabIndex = 91
        Me.grpVariables.TabStop = False
        Me.grpVariables.Text = "Variables"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 24)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "IGV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 24)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "DÓLAR"
        '
        'txtValorDolar
        '
        Me.txtValorDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorDolar.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorDolar.Location = New System.Drawing.Point(137, 98)
        Me.txtValorDolar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtValorDolar.Name = "txtValorDolar"
        Me.txtValorDolar.Size = New System.Drawing.Size(93, 30)
        Me.txtValorDolar.TabIndex = 92
        Me.txtValorDolar.Text = "0.00"
        Me.txtValorDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.SistemaServox2015.My.Resources.Resources.disk
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(6, 161)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 28)
        Me.btnGuardar.TabIndex = 94
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(201, 249)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 92
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmVariablesGlobales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 290)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grpVariables)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmVariablesGlobales"
        Me.grpVariables.ResumeLayout(False)
        Me.grpVariables.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtIGV As SistemaServox2015.MoneyTextBox
    Friend WithEvents grpVariables As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtValorDolar As SistemaServox2015.MoneyTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button

End Class
