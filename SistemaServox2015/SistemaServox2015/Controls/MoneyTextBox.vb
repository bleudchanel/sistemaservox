Imports System
Imports System.Collections
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports pryUtil.clsUtil

Public Class MoneyTextBox
    Inherits TextBox


#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Text = "0.00"
        Me.TextAlign = HorizontalAlignment.Right
        Me.Font = New Font("Calibri", 12)
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region



    'Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
    '    If Not File.Exists(Me.Text) Then
    '        Me.ForeColor = Color.Red
    '    Else
    '        Me.ForeColor = Color.Black
    '    End If

    '    MyBase.OnTextChanged(e)
    'End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
        End If

        MyBase.OnKeyDown(e)
    End Sub

    Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
        If Me.Text.Trim.Length = 0 Then
            Me.Text = "0.00"
        End If
        MyBase.OnLeave(e)
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        Else
            Try
                Dim vCapturar As Boolean = False
                Dim vCharCode As Char = ""
                Validar_NumericoV2(Me, e.KeyChar, vCapturar)
                e.Handled = vCapturar
            Catch ex As Exception

                e.Handled = True
                Me.Text = "0.00"
            End Try

        End If
        MyBase.OnKeyPress(e)
    End Sub


    Public Shared Sub Validar_NumericoV2(ByVal txt As TextBox, ByVal CharCode As Char, ByRef Var As Boolean)
        ' Dim Pos As Integer = 0
        If txt.Text.Length > txt.MaxLength Then
            txt.Text = "0.00"
            Var = True
            Exit Sub
        End If
        If txt.SelectionLength = txt.Text.Length Then
            txt.Text = "0.00"
            txt.SelectionStart = 0
        End If
        'Exit Sub
        Dim PosA As Integer = txt.SelectionStart
        Dim Tecla As String
        If Chr(8) <> CharCode Then
            Tecla = Asc(CharCode)
            If txt.Text.Trim.Length = 0 Then
                txt.Text = Format(0, "0.00")
                txt.SelectionStart = 0
            Else
                If txt.SelectionStart = 0 Then
                    Var = True
                    Dim TextoIzq As String = ""
                    Dim TextoDer As String = txt.Text.Substring(1)
                    'Me.txtCantidad.Text = ""
                    If Chr(Tecla) <> "." Then txt.Text = Chr(Tecla) & TextoDer
                Else
                    If CharCode = "." Then
                        If txt.Text.IndexOf(".") = txt.SelectionStart Then
                            Var = True
                            txt.SelectionStart = txt.Text.IndexOf(".") + 1
                        Else
                            Var = True
                            'e.Handled = True
                            'Me.txtCantidad.SelectionStart = Me.txtCantidad.Text.IndexOf(".") + 1
                        End If
                    Else
                        Var = True
                        Dim Pos As Integer = txt.SelectionStart
                        Dim Extension As String = ""
                        'Me.txtCantidad.Text = Me.txtCantidad.Text.Insert(Me.txtCantidad.SelectionStart, e.KeyChar)
                        'Extension = Mid(Me.txtCantidad.Text, Me.txtCantidad.Text.IndexOf(".") + 1, 4)
                        'Me.txtCantidad.Text = Mid(Me.txtCantidad.Text, 1, IIf(Extension.Length = 4, Me.txtCantidad.Text.Length + 1, Me.txtCantidad.Text.Length - 1))
                        txt.Text = txt.Text.Insert(txt.SelectionStart, CharCode)
                        Extension = Mid(txt.Text, txt.Text.IndexOf(".") + 1)
                        txt.Text = Mid(txt.Text, 1, IIf(Extension.Length = 3, txt.Text.Length, txt.Text.Length - 1))
                        If Extension.Length = 3 Then
                            txt.SelectionStart = Pos + 1
                        Else
                            txt.SelectionStart = Pos
                        End If
                    End If
                End If
            End If
        Else
            Dim Pos As Integer = txt.SelectionStart
            If Pos > 1 Then
                Tecla = Asc(CharCode)
                Dim TextoAnterior As String = Mid(txt.Text, Pos, 1)
                If TextoAnterior = "." Then
                    Pos = txt.SelectionStart - 1
                    txt.Text = Mid(txt.Text, 1, Pos - 1) & Mid(txt.Text, Pos + 1)
                    txt.SelectionStart = Pos - 1
                    If Pos = 1 Then
                        txt.Text = "0" & txt.Text
                    End If
                Else
                    txt.Text = Mid(txt.Text, 1, Pos - 1) & Mid(txt.Text, Pos + 1)
                    txt.SelectionStart = Pos - 1
                End If

            Else
                txt.Text = "0.00"
                txt.SelectionStart = 0
                txt.SelectionLength = 0
            End If
            Var = True
            Exit Sub
            'PosA = 1
        End If
        Dim decNumero As Decimal = fncForzarDecimal(txt.Text)
        txt.Text = Format(decNumero, "0.00")
        txt.SelectionStart = PosA + 1
    End Sub
End Class
