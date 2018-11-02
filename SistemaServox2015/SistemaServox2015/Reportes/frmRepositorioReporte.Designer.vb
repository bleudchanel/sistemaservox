<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepositorioReporte
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
        Me.crpViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crpViewer
        '
        Me.crpViewer.ActiveViewIndex = -1
        Me.crpViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpViewer.CachedPageNumberPerDoc = 10
        Me.crpViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpViewer.Location = New System.Drawing.Point(0, 0)
        Me.crpViewer.Name = "crpViewer"
        Me.crpViewer.Size = New System.Drawing.Size(1059, 648)
        Me.crpViewer.TabIndex = 0
        '
        'frmRepositorioReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 648)
        Me.Controls.Add(Me.crpViewer)
        Me.Name = "frmRepositorioReporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crpViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
