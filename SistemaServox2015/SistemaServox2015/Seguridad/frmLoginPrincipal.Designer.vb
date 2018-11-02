<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginPrincipal))
        Me.grpAccion = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.grpPersonal = New System.Windows.Forms.GroupBox()
        Me.cmbPerfil = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblEnvironment = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grpAccion.SuspendLayout()
        Me.grpPersonal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAccion
        '
        Me.grpAccion.Controls.Add(Me.btnSalir)
        Me.grpAccion.Controls.Add(Me.btnIngresar)
        Me.grpAccion.Location = New System.Drawing.Point(106, 157)
        Me.grpAccion.Name = "grpAccion"
        Me.grpAccion.Size = New System.Drawing.Size(314, 63)
        Me.grpAccion.TabIndex = 153
        Me.grpAccion.TabStop = False
        Me.grpAccion.Text = "ACCIONES"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(150, 24)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 25)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.White
        Me.btnIngresar.Image = CType(resources.GetObject("btnIngresar.Image"), System.Drawing.Image)
        Me.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresar.Location = New System.Drawing.Point(26, 24)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(118, 25)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "&Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'grpPersonal
        '
        Me.grpPersonal.BackColor = System.Drawing.Color.Transparent
        Me.grpPersonal.Controls.Add(Me.cmbPerfil)
        Me.grpPersonal.Controls.Add(Me.txtPassword)
        Me.grpPersonal.Controls.Add(Me.lblPass)
        Me.grpPersonal.Controls.Add(Me.lblUsuario)
        Me.grpPersonal.Location = New System.Drawing.Point(106, 42)
        Me.grpPersonal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPersonal.Size = New System.Drawing.Size(314, 104)
        Me.grpPersonal.TabIndex = 152
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "DATOS PERSONALES"
        '
        'cmbPerfil
        '
        Me.cmbPerfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPerfil.FormattingEnabled = True
        Me.cmbPerfil.Location = New System.Drawing.Point(132, 28)
        Me.cmbPerfil.Name = "cmbPerfil"
        Me.cmbPerfil.Size = New System.Drawing.Size(151, 26)
        Me.cmbPerfil.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(132, 63)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(151, 23)
        Me.txtPassword.TabIndex = 2
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(39, 63)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(74, 18)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(61, 28)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(52, 18)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'lblEnvironment
        '
        Me.lblEnvironment.AutoSize = True
        Me.lblEnvironment.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnvironment.Location = New System.Drawing.Point(10, 243)
        Me.lblEnvironment.Name = "lblEnvironment"
        Me.lblEnvironment.Size = New System.Drawing.Size(71, 16)
        Me.lblEnvironment.TabIndex = 157
        Me.lblEnvironment.Text = "Environment"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(447, 253)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(50, 18)
        Me.lblVersion.TabIndex = 159
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 30)
        Me.Panel1.TabIndex = 161
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(156, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(198, 25)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Sistema de Inventario"
        '
        'frmLoginPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(521, 280)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblEnvironment)
        Me.Controls.Add(Me.grpAccion)
        Me.Controls.Add(Me.grpPersonal)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLoginPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grpAccion.ResumeLayout(False)
        Me.grpPersonal.ResumeLayout(False)
        Me.grpPersonal.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAccion As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents grpPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblEnvironment As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
