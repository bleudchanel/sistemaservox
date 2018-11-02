<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotificarError
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.btnVerDetalles = New System.Windows.Forms.Button()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        ''        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAceptar.Location = New System.Drawing.Point(565, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 48)
        Me.Panel1.TabIndex = 0
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.Location = New System.Drawing.Point(62, 26)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(550, 134)
        Me.lblMensaje.TabIndex = 4
        Me.lblMensaje.Text = "Label1"
        '
        'txtDetalles
        '
        Me.txtDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetalles.Location = New System.Drawing.Point(12, 99)
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalles.Size = New System.Drawing.Size(628, 61)
        Me.txtDetalles.TabIndex = 5
        '
        'btnVerDetalles
        '
        Me.btnVerDetalles.FlatAppearance.BorderSize = 0
        '   Me.btnVerDetalles.Image = Global.pryUtil.My.Resources.Resources.navigation_270_white
        Me.btnVerDetalles.Location = New System.Drawing.Point(618, 77)
        Me.btnVerDetalles.Name = "btnVerDetalles"
        Me.btnVerDetalles.Size = New System.Drawing.Size(22, 23)
        Me.btnVerDetalles.TabIndex = 1
        Me.btnVerDetalles.UseVisualStyleBackColor = True
        '
        'picImagen
        '
        Me.picImagen.Location = New System.Drawing.Point(25, 26)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(39, 74)
        Me.picImagen.TabIndex = 3
        Me.picImagen.TabStop = False
        '
        'frmNotificarError
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnAceptar
        Me.ClientSize = New System.Drawing.Size(652, 214)
        Me.Controls.Add(Me.txtDetalles)
        Me.Controls.Add(Me.btnVerDetalles)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.picImagen)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotificarError"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnVerDetalles As System.Windows.Forms.Button
    Friend WithEvents picImagen As System.Windows.Forms.PictureBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents txtDetalles As System.Windows.Forms.TextBox
End Class
