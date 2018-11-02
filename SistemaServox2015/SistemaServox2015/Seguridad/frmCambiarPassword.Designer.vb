<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarPassword
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
        Me.grpPasswordActual = New System.Windows.Forms.GroupBox()
        Me.txtPasswordActual = New System.Windows.Forms.TextBox()
        Me.grpNuevoPassword = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRepitaNuevoPassword = New System.Windows.Forms.TextBox()
        Me.txtNuevoPassword = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.grpPasswordActual.SuspendLayout()
        Me.grpNuevoPassword.SuspendLayout()
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
        Me.txtTitulo.Size = New System.Drawing.Size(411, 25)
        Me.txtTitulo.TabIndex = 83
        Me.txtTitulo.Text = "Cambiar Password"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpPasswordActual
        '
        Me.grpPasswordActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPasswordActual.Controls.Add(Me.txtPasswordActual)
        Me.grpPasswordActual.Location = New System.Drawing.Point(12, 31)
        Me.grpPasswordActual.Name = "grpPasswordActual"
        Me.grpPasswordActual.Size = New System.Drawing.Size(387, 71)
        Me.grpPasswordActual.TabIndex = 84
        Me.grpPasswordActual.TabStop = False
        Me.grpPasswordActual.Text = "Ingrese Password Actual"
        '
        'txtPasswordActual
        '
        Me.txtPasswordActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswordActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordActual.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordActual.Location = New System.Drawing.Point(28, 30)
        Me.txtPasswordActual.Name = "txtPasswordActual"
        Me.txtPasswordActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordActual.Size = New System.Drawing.Size(324, 26)
        Me.txtPasswordActual.TabIndex = 1
        Me.txtPasswordActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpNuevoPassword
        '
        Me.grpNuevoPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpNuevoPassword.Controls.Add(Me.Label1)
        Me.grpNuevoPassword.Controls.Add(Me.txtRepitaNuevoPassword)
        Me.grpNuevoPassword.Controls.Add(Me.txtNuevoPassword)
        Me.grpNuevoPassword.Location = New System.Drawing.Point(12, 108)
        Me.grpNuevoPassword.Name = "grpNuevoPassword"
        Me.grpNuevoPassword.Size = New System.Drawing.Size(387, 135)
        Me.grpNuevoPassword.TabIndex = 85
        Me.grpNuevoPassword.TabStop = False
        Me.grpNuevoPassword.Text = "Ingrese Nuevo Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Repita Nuevo Password"
        '
        'txtRepitaNuevoPassword
        '
        Me.txtRepitaNuevoPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRepitaNuevoPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRepitaNuevoPassword.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepitaNuevoPassword.Location = New System.Drawing.Point(28, 87)
        Me.txtRepitaNuevoPassword.Name = "txtRepitaNuevoPassword"
        Me.txtRepitaNuevoPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepitaNuevoPassword.Size = New System.Drawing.Size(324, 26)
        Me.txtRepitaNuevoPassword.TabIndex = 3
        Me.txtRepitaNuevoPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNuevoPassword
        '
        Me.txtNuevoPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNuevoPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNuevoPassword.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoPassword.Location = New System.Drawing.Point(28, 34)
        Me.txtNuevoPassword.Name = "txtNuevoPassword"
        Me.txtNuevoPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevoPassword.Size = New System.Drawing.Size(324, 26)
        Me.txtNuevoPassword.TabIndex = 2
        Me.txtNuevoPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.SistemaServox2015.My.Resources.Resources.disk
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 260)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 28)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Guardar"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.SistemaServox2015.My.Resources.Resources.door_out
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(259, 259)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(140, 28)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmCambiarPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(411, 301)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grpNuevoPassword)
        Me.Controls.Add(Me.grpPasswordActual)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCambiarPassword"
        Me.grpPasswordActual.ResumeLayout(False)
        Me.grpPasswordActual.PerformLayout()
        Me.grpNuevoPassword.ResumeLayout(False)
        Me.grpNuevoPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents grpPasswordActual As System.Windows.Forms.GroupBox
    Friend WithEvents grpNuevoPassword As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtPasswordActual As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRepitaNuevoPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevoPassword As System.Windows.Forms.TextBox
End Class
