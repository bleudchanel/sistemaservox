Imports System.Windows.Forms
Imports System.Net
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Globalization
Imports System.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data.Configuration
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography

Public Class clsUtil

#Region "Estructuras"

    Public Shared Function fncEstructuraKardex() As DataTable
        Dim dtResultado As New DataTable

        dtResultado.Columns.Add("IdOperacion", GetType(Integer))
        dtResultado.Columns.Add("Fecha", GetType(String))
        dtResultado.Columns.Add("CodigoTipoDocumento", GetType(String))
        dtResultado.Columns.Add("TipoDocumento", GetType(String))
        dtResultado.Columns.Add("Serie", GetType(String))
        dtResultado.Columns.Add("Numero", GetType(String))

        dtResultado.Columns.Add("IdProducto", GetType(Integer))
        dtResultado.Columns.Add("Producto", GetType(String))
        dtResultado.Columns.Add("DescripcionProducto", GetType(String))

        dtResultado.Columns.Add("CodigoTipoOperacion", GetType(String))
        dtResultado.Columns.Add("TipoOperacion", GetType(String))

        dtResultado.Columns.Add("EnCantidad", GetType(Integer))
        dtResultado.Columns.Add("EnCostoUnitario", GetType(Decimal))
        dtResultado.Columns.Add("EnCostoTotal", GetType(Decimal))

        dtResultado.Columns.Add("SalCantidad", GetType(Integer))
        dtResultado.Columns.Add("SalCostoUnitario", GetType(Decimal))
        dtResultado.Columns.Add("SalCostoTotal", GetType(Decimal))

        dtResultado.Columns.Add("FinCantidad", GetType(Integer))
        dtResultado.Columns.Add("FinCostoUnitario", GetType(Decimal))
        dtResultado.Columns.Add("FinCostoTotal", GetType(Decimal))

        Return dtResultado
    End Function

    Public Shared Sub fncIngresarEnEstructuraKardex(ByVal dtResultado As DataTable _
                                                           , ByVal intIdOperacion As Integer _
                                                           , ByVal dateFecha As Date _
                                                           , ByVal CodigoTipoDocumento As String _
                                                           , ByVal TipoDocumento As String _
                                                           , ByVal strSerie As String _
                                                           , ByVal strNumero As String _
                                                           , ByVal intIdProducto As Integer _
                                                           , ByVal strProducto As String _
                                                           , ByVal strDescripcionProducto As String _
                                                           , ByVal CodigoTipoOperacion As String _
                                                           , ByVal TipoOperacion As String _
                                                           , ByVal intEnCantidad As Integer _
                                                           , ByVal decEnCostoUnitario As Decimal _
                                                           , ByVal decEnCostoTotal As Decimal _
                                                           , ByVal intSalCantidad As Integer _
                                                           , ByVal decSalCostoUnitario As Decimal _
                                                           , ByVal decSalCostoTotal As Decimal _
                                                           , ByVal intFinCantidad As Integer _
                                                           , ByVal decFinCostoUnitario As Decimal _
                                                           , ByVal decFinCostoTotal As Decimal)
        dtResultado.Rows.Add()
        With dtResultado.Rows(dtResultado.Rows.Count - 1)
            .Item("IdOperacion") = intIdOperacion
            .Item("Fecha") = dateFecha.ToString("dd/MM/yyyy")
            .Item("CodigoTipoDocumento") = CodigoTipoDocumento
            .Item("TipoDocumento") = TipoDocumento
            .Item("Serie") = strSerie
            .Item("Numero") = strNumero

            .Item("IdProducto") = intIdProducto
            .Item("Producto") = strProducto
            .Item("DescripcionProducto") = strDescripcionProducto

            .Item("CodigoTipoOperacion") = CodigoTipoOperacion
            .Item("TipoOperacion") = TipoOperacion

            .Item("EnCantidad") = intEnCantidad
            .Item("EnCostoUnitario") = decEnCostoUnitario
            .Item("EnCostoTotal") = decEnCostoTotal

            .Item("SalCantidad") = intSalCantidad
            .Item("SalCostoUnitario") = decSalCostoUnitario
            .Item("SalCostoTotal") = decSalCostoTotal

            .Item("FinCantidad") = intFinCantidad
            .Item("FinCostoUnitario") = decFinCostoUnitario
            .Item("FinCostoTotal") = decFinCostoTotal

        End With

    End Sub

#End Region

#Region "Utiles Sistema"

    'public static string CerosIzquierda(string Inicial,int LongFinal)
    '  {
    '      string rs = string.Empty;
    '      int CantidadCeros = LongFinal - Inicial.Length;
    '      for (int i = 0; i < CantidadCeros; i++)
    '      {
    '          rs += "0";
    '      }
    '      rs += Inicial;
    '      return rs;
    '  }


    Public Shared Function CerosIzquierda(ByVal strInicial As String, ByVal intLenFinal As Integer) As String
        Dim strResultado As String = String.Empty

        Dim intCantidadCeros As Integer = intLenFinal - strInicial.Length
        For i As Integer = 0 To intCantidadCeros - 1
            strResultado &= "0"
        Next
        strResultado &= strInicial
        Return strResultado
    End Function
    Public Shared Sub PosicionUltimo(ByVal txtMasked As MaskedTextBox, ByVal strChar As String)
        Dim strText As String = txtMasked.Text
        Dim intLastPositionChar As New Integer
        If strText.Length > 0 Then
            For i As Integer = 0 To strText.Length - 1
                If Mid$(strText, i + 1, 1).Equals(strChar) Then
                    intLastPositionChar = i
                Else
                    Exit For
                End If
            Next
        End If

        txtMasked.Select(intLastPositionChar, 0)
    End Sub

    Public Shared Sub FilaInvisibleIndex(ByVal dgvObjetivo As DataGridView, ByVal intIndex As Integer)
        If intIndex - 1 >= 0 Then
            If dgvObjetivo.Rows(intIndex - 1).Visible = True Then
                dgvObjetivo.Rows(intIndex - 1).Cells("CodigoProducto").Selected = True
            Else
                FilaInvisibleIndex(dgvObjetivo, intIndex - 1)
            End If
            ''   Else

        End If
    End Sub

    Public Shared Sub fncSetDataTableInDGV(ByVal dtBase As DataTable, ByVal dgvObjetivo As DataGridView)    
        dgvObjetivo.Rows.Clear()
        If fncValidaDataTable(dtBase) Then
            '' For Each row As DataGridViewRow In dgvObjetivo.Rows
            For Each rowD As DataRow In dtBase.Rows

                dgvObjetivo.Rows.Add()

                For Each column As DataGridViewColumn In dgvObjetivo.Columns
                    For Each columnD As DataColumn In dtBase.Columns
                        If column.Name = columnD.ColumnName Then
                            dgvObjetivo.Rows(dgvObjetivo.Rows.Count - 1).Cells(column.Name).Value = ObtenerValorCelda(rowD, column.Name)
                        End If
                    Next
                    ''If column.Name = 
                Next
            Next
            ''  Next
            ''
        End If

    End Sub

    Public Shared Sub BuscarEnDataGrid(ByVal dgvObjetivo As DataGridView, ByVal strTexto As String, ByVal strCampos() As String, ByVal strCampoFinal As String)
        If strCampos.Length > 0 And strTexto.Length > 0 Then
            For Each item In strCampos
                For i As Integer = 0 To dgvObjetivo.Rows.Count - 1

                    If dgvObjetivo.Rows(i).Cells(item.ToString).Value.ToString.ToUpper.Contains(strTexto.ToUpper) Then
                        dgvObjetivo.Rows(i).Selected = True
                        dgvObjetivo.CurrentCell = dgvObjetivo.Rows(i).Cells(strCampoFinal)
                        dgvObjetivo.FirstDisplayedScrollingRowIndex = i
                        Exit For
                    End If
                Next
            Next

        End If

    End Sub

    Public Shared Function EstadoPorEntero(ByVal intEstado As Integer) As String
        Select Case intEstado
            Case 1
                Return "Activo"
            Case 0
                Return "Inactivo"
            Case Else
                Return "Otro"
        End Select
    End Function

    Public Shared Sub ClearControls(ByVal Container As Control, Optional ByVal Recursive As Boolean = False)
        For Each ChildControl As Control In Container.Controls
            If TypeOf ChildControl Is TextBox Then
                DirectCast(ChildControl, TextBox).Text = String.Empty
            ElseIf TypeOf ChildControl Is ComboBox Then
                DirectCast(ChildControl, ComboBox).SelectedIndex = -1
                If DirectCast(ChildControl, ComboBox).DropDownStyle = ComboBoxStyle.DropDown Then
                    DirectCast(ChildControl, ComboBox).Text = String.Empty
                End If
            ElseIf TypeOf ChildControl Is CheckBox Then
                DirectCast(ChildControl, CheckBox).Checked = False
            ElseIf TypeOf ChildControl Is Label Then
                If DirectCast(ChildControl, Label).BorderStyle <> BorderStyle.None Then
                    DirectCast(ChildControl, Label).Text = String.Empty
                End If
                'ElseIf TypeOf ChildControl Is DateTimePickerNull Then
                '    DirectCast(ChildControl, DateTimePickerNull).Value = Nothing
            ElseIf TypeOf ChildControl Is DateTimePicker Then
                DirectCast(ChildControl, DateTimePicker).Value = FechaHoraServidor()
            ElseIf TypeOf ChildControl Is CheckBox Then
                DirectCast(ChildControl, CheckBox).Checked = False
            ElseIf TypeOf ChildControl Is RadioButton Then
                DirectCast(ChildControl, RadioButton).Checked = False
            ElseIf TypeOf ChildControl Is ListBox Then
                If DirectCast(ChildControl, ListBox).DataSource Is Nothing Then
                    DirectCast(ChildControl, ListBox).Items.Clear()
                Else
                    DirectCast(ChildControl, ListBox).DataSource = Nothing
                End If
            ElseIf TypeOf ChildControl Is Label Then
                If DirectCast(ChildControl, Label).Tag IsNot Nothing AndAlso CStr(DirectCast(ChildControl, Label).Tag) = "L" Then
                    DirectCast(ChildControl, Label).Text = String.Empty
                End If
            ElseIf Recursive AndAlso ChildControl.HasChildren Then
                ClearControls(ChildControl, True)
            End If
        Next
    End Sub


    Public Shared Function fncDetalleVisible(ByVal dgvBase As DataGridView) As Integer
        Dim intResultado As New Integer
        For i As Integer = 0 To dgvBase.Rows.Count - 1
            If dgvBase.Rows(i).Visible = True Then
                intResultado += 1
            End If
        Next
        Return intResultado
    End Function

    Public Shared Sub ProcComboBoxEstado(ByVal cmbBase As ComboBox)

        cmbBase.DataSource = Nothing
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("IdEstado", GetType(Integer))
        dtEstado.Columns.Add("Estado", GetType(String))


        Dim items As Array
        items = System.Enum.GetValues(GetType(enmEstado))
        For Each intItem As Integer In items
            dtEstado.Rows.Add(intItem, EstadoPorEntero(intItem))
        Next

        cmbBase.DataSource = dtEstado
        cmbBase.ValueMember = "IdEstado"
        cmbBase.DisplayMember = "Estado"
        cmbBase.SelectedValue = enmEstado.Activo

    End Sub

    Public Enum enmModalidadPago
        Contado = 1
        Credito = 2
        Deposito = 3
    End Enum

    Public Enum enmTipoOperacion
        Venta = 1
        Compra = 2
    End Enum

    Public Enum enmTipoInterno
        CompraConIGV = 1
        CompraSinIGV = 2
        Venta = 10
        Proforma = 20
        Garantía = 30
        Transporte = 40
    End Enum

    Public Enum enmRegularConcept
        Transporte = 1
    End Enum

#End Region

    Public Shared Function fncNumeroDeDiasEntre2Fechas(ByVal dateFechaInicio As Date, ByVal dateFechaFin As Date, ByVal intMes As Integer, ByVal intAnio As Integer) As Integer
        Dim intDiasDiferencia As Integer = DateDiff(DateInterval.Day, dateFechaInicio.Date, dateFechaFin.Date)
        Dim intDiasCalculado As New Integer
        Dim intDiasEnMes As Integer = Date.DaysInMonth(intAnio, intMes)
        Select Case intMes
            Case 2
                intDiasCalculado = If(intDiasDiferencia = 27 Or intDiasDiferencia = 28, 30, 30 - (intDiasEnMes - intDiasDiferencia))
            Case Else
                Select Case intDiasEnMes
                    Case 30
                        intDiasCalculado = If(intDiasDiferencia = 29, 30, 30 - (intDiasEnMes - (intDiasDiferencia + 1)))
                    Case 31
                        intDiasCalculado = If(intDiasDiferencia = 30, 30, 30 - (intDiasEnMes - intDiasDiferencia))
                End Select
        End Select
        'intDiasCalculados = If(intMes = 2, If(intDiasCalculados = 28 Or intDiasCalculados = 29, 30, intDiasCalculados), If(intDiasCalculados >= 30, 30, intDiasCalculados)) 'If(intDiasEnMes < 30,   intDiasCalculados)

        Return intDiasCalculado
    End Function

    Public Enum enmTipoDocumento
        DNI = 2
        RUC = 4
    End Enum

    Public Enum enmIGV As Long
        IGVActual = 0.18
    End Enum

    Public Enum enmTipoComprobante
        Boleta = 4
        Factura = 2
    End Enum
   

    Public Enum enmOrden
        Primero = 1
        Atras = 2
        Siguiente = 3
        Ultimo = 4
        Unico = 5
    End Enum

    Public Enum enmTipoExistencia
        Mercadería = 1
    End Enum

    Public Shared Function ValorCorrecto(ByVal strValor As String) As Integer
        Dim intResultado As New Integer
        If IsNumeric(strValor) Then
            If CInt(strValor) > 0 Then
                intResultado = CInt(strValor)
            Else
                intResultado = -1
            End If
        Else
            intResultado = -1
        End If

        Return intResultado

    End Function

    Public Shared Function ToProperCase( _
    ByVal str As String _
) As String
        If str IsNot Nothing Then
            Dim myTI As System.Globalization.TextInfo

            myTI = New System.Globalization.CultureInfo("en-US", False).TextInfo
            str = str.ToLower
            str = myTI.ToTitleCase(str)
            Return str
        Else
            Return String.Empty
        End If

    End Function




    '    End Enum

    ''' <summary>
    ''' 0 Inicio Mes || 1 Fin Mes
    ''' </summary>
    ''' <param name="intMes"></param>
    ''' <param name="intAnio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function fncInicioFinMes(ByVal intMes As Integer, ByVal intAnio As Integer) As List(Of Date)
        Dim lstDate As New List(Of Date)
        Dim dateRemDesde As New Date
        Dim dateRemHasta As New Date

        Dim dateMesActual As New DateTime(intAnio, intMes, 1)

        dateRemDesde = dateMesActual
        dateRemHasta = dateMesActual.AddMonths(1).AddDays(-1)


        lstDate.Add(dateRemDesde)
        lstDate.Add(dateRemHasta)

        Return lstDate
    End Function



    Public Shared Function FormatoPorColumnaTipo(ByVal strTipo As String)
        ' Dim strFormato As String = String.Empty
        Select Case strTipo
            Case "System.Int64", "System.Int32"
                Return "##"
            Case "System.String"
                Return "@"
            Case Else
                Return "0.0###"
        End Select
    End Function

    Public Shared Sub FncDataTable2Excel2Hojas(ByVal dtContenido As DataTable, ByVal dtContenido2 As DataTable, ByVal strRepTitulo As String)
        If fncValidaDataTable(dtContenido) = False Then
            Exit Sub
        End If
        Dim arr As Object(,) = New Object(dtContenido.Rows.Count - 1, dtContenido.Columns.Count - 1) {}
        Dim arrTipos As Object() = New Object(dtContenido.Columns.Count - 1) {}
        Dim arrTitulos As Object() = New Object(dtContenido.Columns.Count - 1) {}

        'For i As Integer = 0 To dtContenido.Columns.Count - 1
        '    arrTipos(i) = dtContenido.Columns(i).DataType
        '    '      arrTitulos(i) = dtContenido.Columns(i).ColumnName
        'Next

        For r As Integer = 0 To dtContenido.Rows.Count - 1
            Dim dr As DataRow = dtContenido.Rows(r)
            For c As Integer = 0 To dtContenido.Columns.Count - 1
                If r = 0 Then
                    arrTipos(c) = dtContenido.Columns(c).DataType
                    arrTitulos(c) = dtContenido.Columns(c).ColumnName
                End If
                arr(r, c) = dr(c).ToString
            Next
        Next

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        'Añadimos el Libro al programa, y la hoja al libro
        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()
        ' Imprimiendo Cabecera
        ' 1 = topRow

        For j As Integer = 0 To arrTipos.Length - 1
            Dim ColumnRange1 As Excel.Range = DirectCast(exHoja.Cells(1, j + 1), Excel.Range)
            Dim ColumnRange2 As Excel.Range = DirectCast(exHoja.Cells(dtContenido.Rows.Count + 1, j + 1), Excel.Range)
            Dim rangeColumna As Excel.Range = exHoja.Range(ColumnRange1, ColumnRange2)
            rangeColumna.NumberFormat = FormatoPorColumnaTipo(arrTipos(j).ToString)
        Next

        Dim t1 As Excel.Range = DirectCast(exHoja.Cells(1, 1), Excel.Range)
        Dim t2 As Excel.Range = DirectCast(exHoja.Cells(1, dtContenido.Columns.Count), Excel.Range)
        Dim rangeTitulo As Excel.Range = exHoja.Range(t1, t2)

        rangeTitulo.Value = arrTitulos

        Dim c1 As Excel.Range = DirectCast(exHoja.Cells(2, 1), Excel.Range)
        Dim c2 As Excel.Range = DirectCast(exHoja.Cells(1 + dtContenido.Rows.Count, dtContenido.Columns.Count), Excel.Range)
        Dim range As Excel.Range = exHoja.Range(c1, c2)

        range.Value = arr

        If fncValidaDataTable(dtContenido2) Then
            Dim arr2 As Object(,) = New Object(dtContenido.Rows.Count - 1, dtContenido.Columns.Count - 1) {}
            Dim arrTipos2 As Object() = New Object(dtContenido.Columns.Count - 1) {}
            Dim arrTitulos2 As Object() = New Object(dtContenido.Columns.Count - 1) {}

            'For i As Integer = 0 To dtContenido.Columns.Count - 1
            '    arrTipos(i) = dtContenido.Columns(i).DataType
            '    '      arrTitulos(i) = dtContenido.Columns(i).ColumnName
            'Next

            For r As Integer = 0 To dtContenido.Rows.Count - 1
                Dim dr As DataRow = dtContenido.Rows(r)
                For c As Integer = 0 To dtContenido.Columns.Count - 1
                    If r = 0 Then
                        arrTipos2(c) = dtContenido.Columns(c).DataType
                        arrTitulos2(c) = dtContenido.Columns(c).ColumnName
                    End If
                    arr2(r, c) = dr(c).ToString
                Next
            Next

            Dim exHoja2 As Microsoft.Office.Interop.Excel.Worksheet

            'Añadimos el Libro al programa, y la hoja al libro
            exHoja2 = exLibro.Worksheets.Add()
            ' Imprimiendo Cabecera
            ' 1 = topRow

            For j As Integer = 0 To arrTipos2.Length - 1
                Dim ColumnRange1 As Excel.Range = DirectCast(exHoja2.Cells(1, j + 1), Excel.Range)
                Dim ColumnRange2 As Excel.Range = DirectCast(exHoja2.Cells(dtContenido.Rows.Count + 1, j + 1), Excel.Range)
                Dim rangeColumna As Excel.Range = exHoja2.Range(ColumnRange1, ColumnRange2)
                rangeColumna.NumberFormat = FormatoPorColumnaTipo(arrTipos2(j).ToString)
            Next

            Dim t12 As Excel.Range = DirectCast(exHoja2.Cells(1, 1), Excel.Range)
            Dim t22 As Excel.Range = DirectCast(exHoja2.Cells(1, dtContenido.Columns.Count), Excel.Range)
            Dim rangeTitulo2 As Excel.Range = exHoja2.Range(t12, t22)

            rangeTitulo2.Value = arrTitulos

            Dim c12 As Excel.Range = DirectCast(exHoja2.Cells(2, 1), Excel.Range)
            Dim c22 As Excel.Range = DirectCast(exHoja2.Cells(1 + dtContenido.Rows.Count, dtContenido.Columns.Count), Excel.Range)
            Dim range2 As Excel.Range = exHoja2.Range(c12, c22)

            range2.Value = arr2
        End If

        'Aplicación visible
        exApp.Application.Visible = True
    End Sub

    'Public Shared Function FncDataTableExcelMasivos(ByVal 
    Public Shared Sub FncDataTable2Excel(ByVal dtContenido As DataTable, ByVal strRepTitulo As String)
        If fncValidaDataTable(dtContenido) = False Then
            Exit Sub
        End If
        Dim arr As Object(,) = New Object(dtContenido.Rows.Count - 1, dtContenido.Columns.Count - 1) {}
        Dim arrTipos As Object() = New Object(dtContenido.Columns.Count - 1) {}
        Dim arrTitulos As Object() = New Object(dtContenido.Columns.Count - 1) {}

        'For i As Integer = 0 To dtContenido.Columns.Count - 1
        '    arrTipos(i) = dtContenido.Columns(i).DataType
        '    '      arrTitulos(i) = dtContenido.Columns(i).ColumnName
        'Next

        For r As Integer = 0 To dtContenido.Rows.Count - 1
            Dim dr As DataRow = dtContenido.Rows(r)
            For c As Integer = 0 To dtContenido.Columns.Count - 1
                If r = 0 Then
                    arrTipos(c) = dtContenido.Columns(c).DataType
                    arrTitulos(c) = dtContenido.Columns(c).ColumnName
                End If
                arr(r, c) = dr(c).ToString
            Next
        Next

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        'Añadimos el Libro al programa, y la hoja al libro
        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()
        ' Imprimiendo Cabecera
        ' 1 = topRow

        For j As Integer = 0 To arrTipos.Length - 1
            Dim ColumnRange1 As Excel.Range = DirectCast(exHoja.Cells(1, j + 1), Excel.Range)
            Dim ColumnRange2 As Excel.Range = DirectCast(exHoja.Cells(dtContenido.Rows.Count + 1, j + 1), Excel.Range)
            Dim rangeColumna As Excel.Range = exHoja.Range(ColumnRange1, ColumnRange2)
            rangeColumna.NumberFormat = FormatoPorColumnaTipo(arrTipos(j).ToString)
        Next

        Dim t1 As Excel.Range = DirectCast(exHoja.Cells(1, 1), Excel.Range)
        Dim t2 As Excel.Range = DirectCast(exHoja.Cells(1, dtContenido.Columns.Count), Excel.Range)
        Dim rangeTitulo As Excel.Range = exHoja.Range(t1, t2)

        rangeTitulo.Value = arrTitulos

        Dim c1 As Excel.Range = DirectCast(exHoja.Cells(2, 1), Excel.Range)
        Dim c2 As Excel.Range = DirectCast(exHoja.Cells(1 + dtContenido.Rows.Count, dtContenido.Columns.Count), Excel.Range)
        Dim range As Excel.Range = exHoja.Range(c1, c2)

        range.Value = arr

        'Aplicación visible
        exApp.Application.Visible = True

        'Dim Resp As String = ""
        'Dim intCount As Integer = dtContenido.Rows.Count
        'If MsgBox("El reporte se generará en Excel: ¿Desea continuar?" & vbNewLine & "Este proceso puede demorar hasta 1 minuto.", vbYesNo) = MsgBoxResult.Yes Then
        '    'Creamos las variables

        '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
        '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet



        '    Try
        '        'Añadimos el Libro al programa, y la hoja al libro
        '        exLibro = exApp.Workbooks.Add
        '        exHoja = exLibro.Worksheets.Add()
        '        ' Imprimiendo Cabecera

        '        exHoja.Cells.Item(1, 1) = "UNIVERSIDAD PRIVADA DE TACNA"
        '        exHoja.Range("A1:D1").Merge()
        '        exHoja.Rows.Item(1).Font.Bold = 1
        '        exHoja.Range("A1:D1").Font.Size = 16
        '        exHoja.Rows.Item(1).HorizontalAlignment = 3

        '        exHoja.Cells.Item(1, 7) = strRepTitulo
        '        exHoja.Range("F1:H1").Merge()
        '        exHoja.Rows.Item(1).Font.Bold = 1
        '        exHoja.Range("F1:H1").Font.Size = 20
        '        exHoja.Rows.Item(1).HorizontalAlignment = 3

        '        exHoja.Cells.Item(2, 7) = ""
        '        exHoja.Range("F2:H2").Merge()
        '        exHoja.Rows.Item(2).Font.Bold = 1

        '        exHoja.Rows.Item(2).Font.Size = 16
        '        exHoja.Rows.Item(2).HorizontalAlignment = 3

        '        exHoja.Cells.Item(3, 1) = " "
        '        exHoja.Cells.Item(3, 1).Font.Bold = 1
        '        exHoja.Rows.Item(3).Font.Size = 14
        '        exHoja.Cells.Item(3, 2) = strCodigo
        '        exHoja.Rows.Item(3).HorizontalAlignment = 3

        '        exHoja.Cells.Item(4, 1) = " "
        '        exHoja.Cells.Item(4, 1).Font.Bold = 1
        '        exHoja.Rows.Item(4).Font.Size = 14
        '        exHoja.Cells.Item(4, 2) = strAlumno
        '        exHoja.Rows.Item(4).HorizontalAlignment = 3

        '        Dim NCol As Integer = dtContenido.Columns.Count
        '        Dim NRow As Integer = dtContenido.Rows.Count()
        '        '  Dim iMaxYCoordinate As Integer
        '        exHoja.Rows.Item(6).Font.Bold = 1
        '        exHoja.Rows.Item(6).Font.Size = 12
        '        exHoja.Rows.Item(6).HorizontalAlignment = 3
        '        'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
        '        For i As Integer = 1 To NCol
        '            exHoja.Cells.Item(6, i) = dtContenido.Columns(i - 1).ColumnName.ToString
        '            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
        '        Next
        '        ' 1, 3,4,6,8,



        '        For Fila As Integer = 0 To NRow - 1
        '            For Col As Integer = 0 To NCol - 1

        '                exHoja.Cells.Item(Fila + 7, Col + 1) = dtContenido.Rows(Fila)(Col)

        '            Next
        '        Next


        '        exHoja.Rows.Item(5).Font.Bold = 1


        '        ' exHoja.Range("B5:D5").Merge()
        '        exHoja.Range("E5:H5").Merge()
        '        exHoja.Range("B2:D2").Merge()
        '        exHoja.Range("B3:D3").Merge()
        '        exHoja.Range("B4:D4").Merge()
        '        exHoja.Columns.AutoFit()


        '        'Aplicación visible
        '        exApp.Application.Visible = True

        '        exHoja = Nothing
        '        exLibro = Nothing
        '        exApp = Nothing

        '    Catch ex As Exception
        '        NotificarError(ex)

        '    End Try


        'End If

    End Sub


    'Public Shared Function FncDataTableExcelMasivos(ByVal 
    Public Shared Sub FncDataTable2ExcelResaltado(ByVal dtContenido As DataTable, ByVal strRepTitulo As String)
        If fncValidaDataTable(dtContenido) = False Then
            Exit Sub
        End If
        Dim arr As Object(,) = New Object(dtContenido.Rows.Count - 1, dtContenido.Columns.Count - 1) {}
        Dim arrTipos As Object() = New Object(dtContenido.Columns.Count - 1) {}
        Dim arrTitulos As Object() = New Object(dtContenido.Columns.Count - 1) {}

        'For i As Integer = 0 To dtContenido.Columns.Count - 1
        '    arrTipos(i) = dtContenido.Columns(i).DataType
        '    '      arrTitulos(i) = dtContenido.Columns(i).ColumnName
        'Next

        For r As Integer = 0 To dtContenido.Rows.Count - 1
            Dim dr As DataRow = dtContenido.Rows(r)
            For c As Integer = 0 To dtContenido.Columns.Count - 1
                If r = 0 Then
                    arrTipos(c) = dtContenido.Columns(c).DataType
                    arrTitulos(c) = dtContenido.Columns(c).ColumnName
                End If
                arr(r, c) = dr(c).ToString
            Next
        Next

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        'Añadimos el Libro al programa, y la hoja al libro
        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()
        ' Imprimiendo Cabecera
        ' 1 = topRow

        For j As Integer = 0 To arrTipos.Length - 1
            Dim ColumnRange1 As Excel.Range = DirectCast(exHoja.Cells(1, j + 1), Excel.Range)
            Dim ColumnRange2 As Excel.Range = DirectCast(exHoja.Cells(dtContenido.Rows.Count + 1, j + 1), Excel.Range)
            Dim rangeColumna As Excel.Range = exHoja.Range(ColumnRange1, ColumnRange2)
            rangeColumna.NumberFormat = FormatoPorColumnaTipo(arrTipos(j).ToString)
        Next

        Dim t1 As Excel.Range = DirectCast(exHoja.Cells(1, 1), Excel.Range)
        Dim t2 As Excel.Range = DirectCast(exHoja.Cells(1, dtContenido.Columns.Count), Excel.Range)
        Dim rangeTitulo As Excel.Range = exHoja.Range(t1, t2)

        rangeTitulo.Value = arrTitulos

        Dim c1 As Excel.Range = DirectCast(exHoja.Cells(2, 1), Excel.Range)
        Dim c2 As Excel.Range = DirectCast(exHoja.Cells(1 + dtContenido.Rows.Count, dtContenido.Columns.Count), Excel.Range)
        Dim range As Excel.Range = exHoja.Range(c1, c2)

        range.Value = arr

        For i As Integer = 0 To dtContenido.Rows.Count - 1
            If ObtenerValorCelda(dtContenido.Rows(i), "Diferencia") = "*" Then
                exHoja.Rows.Item(i + 2).Font.Bold = 1
            End If
        Next

        'Aplicación visible
        exApp.Application.Visible = True

        'Dim Resp As String = ""
        'Dim intCount As Integer = dtContenido.Rows.Count
        'If MsgBox("El reporte se generará en Excel: ¿Desea continuar?" & vbNewLine & "Este proceso puede demorar hasta 1 minuto.", vbYesNo) = MsgBoxResult.Yes Then
        '    'Creamos las variables

        '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
        '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet



        '    Try
        '        'Añadimos el Libro al programa, y la hoja al libro
        '        exLibro = exApp.Workbooks.Add
        '        exHoja = exLibro.Worksheets.Add()
        '        ' Imprimiendo Cabecera

        '        exHoja.Cells.Item(1, 1) = "UNIVERSIDAD PRIVADA DE TACNA"
        '        exHoja.Range("A1:D1").Merge()
        '        exHoja.Rows.Item(1).Font.Bold = 1
        '        exHoja.Range("A1:D1").Font.Size = 16
        '        exHoja.Rows.Item(1).HorizontalAlignment = 3

        '        exHoja.Cells.Item(1, 7) = strRepTitulo
        '        exHoja.Range("F1:H1").Merge()
        '        exHoja.Rows.Item(1).Font.Bold = 1
        '        exHoja.Range("F1:H1").Font.Size = 20
        '        exHoja.Rows.Item(1).HorizontalAlignment = 3

        '        exHoja.Cells.Item(2, 7) = ""
        '        exHoja.Range("F2:H2").Merge()
        '        exHoja.Rows.Item(2).Font.Bold = 1

        '        exHoja.Rows.Item(2).Font.Size = 16
        '        exHoja.Rows.Item(2).HorizontalAlignment = 3

        '        exHoja.Cells.Item(3, 1) = " "
        '        exHoja.Cells.Item(3, 1).Font.Bold = 1
        '        exHoja.Rows.Item(3).Font.Size = 14
        '        exHoja.Cells.Item(3, 2) = strCodigo
        '        exHoja.Rows.Item(3).HorizontalAlignment = 3

        '        exHoja.Cells.Item(4, 1) = " "
        '        exHoja.Cells.Item(4, 1).Font.Bold = 1
        '        exHoja.Rows.Item(4).Font.Size = 14
        '        exHoja.Cells.Item(4, 2) = strAlumno
        '        exHoja.Rows.Item(4).HorizontalAlignment = 3

        '        Dim NCol As Integer = dtContenido.Columns.Count
        '        Dim NRow As Integer = dtContenido.Rows.Count()
        '        '  Dim iMaxYCoordinate As Integer
        '        exHoja.Rows.Item(6).Font.Bold = 1
        '        exHoja.Rows.Item(6).Font.Size = 12
        '        exHoja.Rows.Item(6).HorizontalAlignment = 3
        '        'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
        '        For i As Integer = 1 To NCol
        '            exHoja.Cells.Item(6, i) = dtContenido.Columns(i - 1).ColumnName.ToString
        '            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
        '        Next
        '        ' 1, 3,4,6,8,



        '        For Fila As Integer = 0 To NRow - 1
        '            For Col As Integer = 0 To NCol - 1

        '                exHoja.Cells.Item(Fila + 7, Col + 1) = dtContenido.Rows(Fila)(Col)

        '            Next
        '        Next


        '        exHoja.Rows.Item(5).Font.Bold = 1


        '        ' exHoja.Range("B5:D5").Merge()
        '        exHoja.Range("E5:H5").Merge()
        '        exHoja.Range("B2:D2").Merge()
        '        exHoja.Range("B3:D3").Merge()
        '        exHoja.Range("B4:D4").Merge()
        '        exHoja.Columns.AutoFit()


        '        'Aplicación visible
        '        exApp.Application.Visible = True

        '        exHoja = Nothing
        '        exLibro = Nothing
        '        exApp = Nothing

        '    Catch ex As Exception
        '        NotificarError(ex)

        '    End Try


        'End If

    End Sub


    Public Shared Function RedondeoBCR(ByVal Valor As Decimal) As Decimal
        Dim Redondeado As Decimal = 0
        If (Valor - Math.Round(Valor, 1)) * 100 > 5 Then
            Redondeado = Math.Round(Valor, 1) + 0.05
        ElseIf (Valor - Math.Round(Valor, 1)) * 100 < 5 Then
            Redondeado = Math.Round(Valor, 1)
        Else
            Redondeado = Valor
        End If
        Return Redondeado
    End Function




    Public Shared Function fncForzarDecimal(ByVal strValor As String) As Decimal
        Dim decResultado As New Decimal
        If IsNumeric(strValor) Then
            'If CInt(strValor) > 0 Then
            decResultado = Decimal.Parse(strValor)
            'End If
        Else
            decResultado = 0
        End If

        Return decResultado

    End Function

    Public Shared Function fncForzarInteger(ByVal strValor As String) As Integer
        Dim intResultado As New Integer
        If IsNumeric(strValor) Then
            'If CInt(strValor) > 0 Then
            intResultado = Integer.Parse(strValor)
            'End If
        Else
            intResultado = 0
        End If

        Return intResultado

    End Function



    Public Shared Function fncRound2(ByVal decBase As Decimal) As Decimal
        Return Math.Round(decBase, 2, MidpointRounding.AwayFromZero)
    End Function


    Public Shared Function fncRound4(ByVal decBase As Decimal) As Decimal
        Return Math.Round(decBase, 4, MidpointRounding.AwayFromZero)
    End Function
    'Public Shared Function fncDataTable

    ' ''' <summary>
    ' ''' Define los Id de Tipo Operacion
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Public Enum enumTipoOperacion As Integer






    ''' <summary>
    ''' Define estado de variables del sistema
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enmEstado
        Activo = 1
        Inactivo = 0
    End Enum


    Public Enum enmEstadoProforma
        NoCanjeada = 0
        Canjeada = 1
    End Enum

    Public Enum enmEstadoGarantia
        Pendiente = 0
        PasoGarantia = 1
        NoPasoGarantia = 2
    End Enum


    ''' <summary>
    ''' Obtener la Fecha y Hora del Servidor
    ''' </summary>
    ''' <returns>DateTime</returns>
    ''' <remarks></remarks>
    Public Shared Function FechaHoraServidor() As DateTime
        Dim obj As New clsSeg_IncidenciaBUS
        Return obj.fncConsultarFechaHoraServidorBUS
    End Function


    Public Shared Function fncIdFuente(ByVal intAnio As Integer) As Long
        Dim longIdFuente As New Long
        Dim obj As New clsSeg_IncidenciaBUS
        longIdFuente = obj.fncusp_Co2_S_Co2_mmObtenerNewIdfuenteBUS(intAnio)
        Return longIdFuente
    End Function
    ''' <summary>
    ''' Valida si un dataTable tiene datos
    ''' </summary>
    ''' <param name="dtBase">DataTable a tratar</param>
    ''' <returns>True or False</returns>
    ''' <remarks></remarks>
    ''' <author>Wilmer</author>
    Public Shared Function fncValidaDataTable(ByVal dtBase As DataTable) As Boolean
        If dtBase IsNot Nothing AndAlso dtBase.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function fncSiMenorIgualACeroEsDbNull(ByVal longValor As Long) As Object
        If longValor > 0 Then
            Return longValor
        Else
            Return DBNull.Value
        End If
    End Function


    ''' <summary>
    ''' Setea un ComboBox con un datatable
    ''' </summary>
    ''' <param name="cmbTarget">ComboBox a Setear</param>
    ''' <param name="dtBase">DataTable base</param>
    ''' <param name="strDisplayMember">DisplayMember para el combobox</param>
    ''' <param name="strValueMember">ValueMember para el combobox</param>
    ''' <remarks></remarks>
    Public Shared Sub SetComboBox(ByVal cmbTarget As ComboBox, ByVal dtBase As DataTable, ByVal strDisplayMember As String, ByVal strValueMember As String)
        cmbTarget.DataSource = Nothing
        If dtBase IsNot Nothing AndAlso dtBase.Rows.Count > 0 Then
            cmbTarget.DataSource = dtBase
            cmbTarget.DisplayMember = strDisplayMember
            cmbTarget.ValueMember = strValueMember
            cmbTarget.SelectedIndex = If(cmbTarget.Items.Count > 0, 0, -1)
        Else
            MsgBox("No existe data para llenar el ComboBox: " & cmbTarget.Name & " -  Verifique el contenido de acuerdo a los siguientes parámetros: " & vbNewLine & _
                strDisplayMember & " - " & strValueMember, MsgBoxStyle.Information)
        End If

    End Sub

    Public Shared Sub SetComboBox(ByVal cmbTarget As ComboBox, ByVal dtBase As DataTable, ByVal strDisplayMember As String, ByVal strValueMember As String, ByVal strDefaultMember As String)
        cmbTarget.DataSource = Nothing
        If dtBase IsNot Nothing AndAlso dtBase.Rows.Count > 0 Then

            Dim dtTratado As New DataTable
            dtTratado.Columns.Add(strValueMember, GetType(Object))
            dtTratado.Columns.Add(strDisplayMember, GetType(Object))

            For Each row As DataRow In dtBase.Rows
                dtTratado.Rows.Add(ObtenerValorCelda(row, strValueMember), ObtenerValorCelda(row, strDisplayMember))
            Next

            dtTratado.Rows.Add(-1, strDefaultMember)
            cmbTarget.DataSource = dtTratado
            cmbTarget.DisplayMember = strDisplayMember
            cmbTarget.ValueMember = strValueMember
            cmbTarget.SelectedValue = -1
        Else
            MsgBox("No existe data para llenar el ComboBox: " & cmbTarget.Name & " -  Verifique el contenido de acuerdo a los siguientes parámetros: " & vbNewLine & _
                strDisplayMember & " - " & strValueMember, MsgBoxStyle.Information)
        End If
    End Sub

    Public Shared Sub NotificarError(ByVal xExcepcion As Exception, Optional ByVal xCodigo As String = "", Optional ByVal xUsuario As Integer = 0)
        Dim Mensaje As String = xExcepcion.Message

        Dim Ubicacion As String = ""
        Dim Contador As Integer = 0
        For i As Integer = 0 To xExcepcion.StackTrace.Length - 4
            If xExcepcion.StackTrace.Substring(i, 4) = " en " Then
                Contador += 1
            End If
            If Contador = 3 Then
                Ubicacion = xExcepcion.StackTrace.Substring(i + 4)
                Exit For
            End If
        Next

        Dim Detalle As String = xCodigo.PadLeft(6, "0"c) & " : " & xExcepcion.Message & vbCrLf & "[" & Ubicacion & "]"
        Dim frm As New frmNotificarError(Mensaje, "Error", Detalle)
        frm.ShowDialog()

        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        Dim ip = host.AddressList.FirstOrDefault(Function(x As IPAddress) _
            x.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork)
        Dim networkInterface = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Dim firstNetwork = networkInterface.FirstOrDefault(Function(x As System.Net.NetworkInformation.NetworkInterface) _
            x.OperationalStatus = System.Net.NetworkInformation.OperationalStatus.Up)
        Dim firstMacAddressOfWorkingNetworkAdapter = firstNetwork.GetPhysicalAddress()

        'Registro de incidencia
        'Dim objIncidencia As New clsSeg_IncidenciaBUS
        'objIncidencia.CodigoError = xCodigo
        'objIncidencia.IP = ip.ToString
        'objIncidencia.MAC = firstMacAddressOfWorkingNetworkAdapter.ToString
        'objIncidencia.Mensaje = Mensaje & xExcepcion.StackTrace
        'objIncidencia.Usuario = xUsuario

        'objIncidencia.fncRegistrarBUS()
    End Sub

    ''' <summary>
    ''' Notifica un mensaje de exito
    ''' </summary>
    ''' <param name="xMensaje"></param>
    ''' Descripcion del mensaje
    ''' <param name="xTitulo"></param>
    ''' Titulo del mensaje
    ''' <remarks></remarks>
    Public Shared Sub Notificar(ByVal xMensaje As String, Optional ByVal xTitulo As String = "")
        If xTitulo.Trim = "" Then
            xTitulo = "Operacion Exitosa"
        End If

        MessageBox.Show(xMensaje, xTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ''' <summary>
    ''' Visualiza un mensaje de autorizacion que confirma o no la accion. Devuelve True o False
    ''' </summary>
    ''' <param name="xMensaje"></param>
    ''' Descripcion del mensaje
    ''' <param name="xTitulo"></param>
    ''' Titulo del mensaje
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Autorizar(ByVal xMensaje As String, Optional ByVal xTitulo As String = "") As Boolean
        Dim booRespuesta As Boolean = False

        If xTitulo.Trim = "" Then
            xTitulo = "¿Esta Seguro?"
        End If

        If MessageBox.Show(xMensaje, xTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            booRespuesta = True
        End If

        Return booRespuesta
    End Function

    ''' <summary>
    ''' Obtiene el valor de una celda en un datarow por el nombre del campo. Devuelve un objeto
    ''' </summary>
    ''' <param name="xdrRegistro"></param>
    ''' Objeto DataRow que contiene los datos
    ''' <param name="xstrCampo"></param>
    ''' Nombre de la columna
    ''' <param name="xbooAnulable"></param>
    ''' Confirma si el campo acepta valores nulos
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerValorCelda(ByVal xdrRegistro As DataRow, ByVal xstrCampo As String, Optional ByVal xbooAnulable As Boolean = False) As Object
        If xdrRegistro.Table.Columns.Contains(xstrCampo) Then
            If xbooAnulable Then
                Return xdrRegistro(xstrCampo)
            Else
                If IsDBNull(xdrRegistro(xstrCampo)) Then
                    Return ObtenerValorCampoDefecto(xdrRegistro.Table.Columns(xstrCampo).DataType)
                Else
                    Return xdrRegistro(xstrCampo)
                End If
            End If
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Obtiene el valor por defecto de un tipo de datos. Devuelve un objeto
    ''' </summary>
    ''' <param name="xobjTipo"></param>
    ''' Tipo de dato
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerValorCampoDefecto(ByVal xobjTipo As Object) As Object
        Select Case xobjTipo.Name
            Case "String"
                Return ""
            Case "Integer", "Double", "Int16", "Int32", "Int64"
                Return 0
            Case "Date"
                Return Now
            Case "Boolean"
                Return False
            Case Else
                Return Nothing
        End Select
    End Function

    ''' <summary>
    ''' Obtiene un array de objetos con los valores diferentes de un campo de tabla. Devuelve un List(Of Object)
    ''' </summary>
    ''' <param name="xtbvTabla"></param>
    ''' Objeto DataTable que contiene los datos
    ''' <param name="xstrCampo"></param>
    ''' Nombre de la columna
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerValoresUnicosCampo(ByVal xtbvTabla As DataView, ByVal xstrCampo As String) As List(Of Object)
        Dim objRespuesta As List(Of Object) = New List(Of Object)

        If xtbvTabla IsNot Nothing AndAlso xtbvTabla.Count > 0 Then
            If xtbvTabla.Table.Columns.Contains(xstrCampo) Then
                Dim objValorActual As Object = Nothing

                For i As Integer = 0 To xtbvTabla.Count - 1
                    If Not objValorActual = xtbvTabla.Item(i).Item(xstrCampo) Then
                        objValorActual = xtbvTabla.Item(i).Item(xstrCampo)

                        objRespuesta.Add(objValorActual)
                    End If
                Next
            End If
        End If

        Return objRespuesta
    End Function

    ''' <summary>
    ''' Devuelve un objeto imagen como array de bytes
    ''' </summary>
    ''' <param name="xImagen"></param>
    ''' Objeto de imagen
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertirImagen2Bytes(ByVal xImagen As Object) As Object
        Dim Respuesta As Object = DBNull.Value

        Try
            If xImagen IsNot Nothing Then
                If xImagen.GetType.FullName.Contains("System.Drawing") Then
                    Dim dibujo As System.Drawing.Image = New Drawing.Bitmap(CType(xImagen, Drawing.Image))
                    Dim mesFormatoImagen As System.IO.MemoryStream = New System.IO.MemoryStream

                    mesFormatoImagen.SetLength(7999)
                    dibujo.Save(mesFormatoImagen, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Respuesta = mesFormatoImagen.GetBuffer()
                ElseIf xImagen.GetType.FullName = "System.Byte[]" Then
                    Respuesta = xImagen
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return Respuesta
    End Function

    ''' <summary>
    ''' Devuelve un array de bytes como objeto imagen
    ''' </summary>
    ''' <param name="xBytes"></param>
    ''' Objeto Array de Bytes
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertirBytes2Imagen(ByVal xBytes As Object) As Object
        Dim Respuesta As Object = DBNull.Value

        Try
            If xBytes IsNot Nothing AndAlso xBytes.GetType.FullName = "System.Byte[]" Then
                If xBytes.Length > 0 Then
                    Dim Memoria As System.IO.MemoryStream = New System.IO.MemoryStream(CType(xBytes, Byte()))
                    Respuesta = New System.Drawing.Bitmap(Memoria)
                Else
                    Respuesta = Nothing
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return Respuesta
    End Function

    ''' <summary>
    ''' Formatear un Numero indicando el numero de decimales Ej. 126,152.00 (con 2 decimales)
    ''' </summary>
    ''' <param name="Numero"></param>
    ''' <param name="Decimales"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function FormatearNumero(ByVal Numero As Double, Optional ByVal Decimales As Integer = 2) As String
        Dim rs As String = ""

        rs = Format(Numero, "###,##0" & ".".PadRight(Decimales + 1, "0"c))

        Return rs
    End Function

    ''' <summary>
    ''' Devuelve un objeto como Double
    ''' </summary>
    ''' <param name="xValor"></param>
    ''' Valor a convertir
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function [Double](ByVal xValor As Object) As Double
        If IsDBNull(xValor) Then
            Return 0.0
        Else
            Return xValor
        End If
    End Function

    ''' <summary>
    ''' Obtiene un texto alineado indicando la longitud del texto
    ''' </summary>
    ''' <param name="xTexto"></param>
    ''' Texto a alinear
    ''' <param name="xLongitud"></param>
    ''' Longitud del texto a devolver
    ''' <param name="xAlineacion"></param>
    ''' Alineacion: Izquierda (I), Derecha (D) o Centrada (C)
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function AlinearTexto(ByVal xTexto As Object, ByVal xLongitud As Integer, Optional ByVal xAlineacion As String = "I") As String
        If IsDBNull(xTexto) Then
            xTexto = ""
        Else
            xTexto = CStr(xTexto)
        End If

        Dim Respuesta As String = xTexto.ToString

        If xTexto.Length > xLongitud Then
            Respuesta = xTexto.Substring(0, xLongitud)
        ElseIf xTexto.Length < xLongitud Then
            If xAlineacion = "I" Then
                Respuesta = xTexto.PadRight(xLongitud, " "c)
            ElseIf xAlineacion = "D" Then
                Respuesta = xTexto.PadLeft(xLongitud, " "c)
            ElseIf xAlineacion = "C" Then
                Dim Diferencia As Integer = xLongitud - xTexto.Length
                If Diferencia > 0 Then
                    Dim EspacioIzquierda As Integer = CInt(Diferencia / 2)
                    If Diferencia Mod 2 = 1 Then
                        EspacioIzquierda += 1
                    End If

                    Respuesta = xTexto.PadLeft(xTexto.ToString.Length + EspacioIzquierda, " "c).PadRight(xLongitud, " "c)
                Else
                    Respuesta = xTexto
                End If
            End If
        End If

        Return Respuesta
    End Function

    Shared Function Formatear(ByVal xObjeto As Object, ByVal xFormato As String, Optional ByVal xDefecto As String = "") As String
        Dim Respuesta As String = xDefecto

        If Not IsDBNull(xObjeto) AndAlso xObjeto IsNot Nothing Then
            Respuesta = Format(xObjeto, xFormato)
        End If

        Return Respuesta
    End Function
    Public Shared Function IfNullObj(ByVal o As Object, Optional ByVal DefaultValue As String = "") As String
        Dim ret As String = ""
        Try
            If o Is DBNull.Value Then
                ret = DefaultValue
            Else
                ret = o.ToString
            End If
            Return ret
        Catch ex As Exception
            Return ret
        End Try
    End Function

    Public Shared Function DataGridViewToDataTable(ByVal dtg As DataGridView,
    Optional ByVal DataTableName As String = "myDataTable") As DataTable
        Try
            Dim dt As New DataTable(DataTableName)
            Dim row As DataRow
            Dim TotalDatagridviewColumns As Integer = dtg.ColumnCount - 1
            'Add Datacolumn
            For Each c As DataGridViewColumn In dtg.Columns
                Dim idColumn As DataColumn = New DataColumn()
                idColumn.ColumnName = c.Name
                dt.Columns.Add(idColumn)
            Next
            'Now Iterate thru Datagrid and create the data row
            For Each dr As DataGridViewRow In dtg.Rows
                'Iterate thru datagrid
                row = dt.NewRow 'Create new row
                'Iterate thru Column 1 up to the total number of columns
                For cn As Integer = 0 To TotalDatagridviewColumns
                    row.Item(cn) = IfNullObj(dr.Cells(cn).Value) ' This Will handle error datagridviewcell on NULL Values
                Next
                'Now add the row to Datarow Collection
                dt.Rows.Add(row)
            Next
            'Now return the data table
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub Validar_NumericoV4(ByVal txt As TextBox, ByVal CharCode As Char, ByRef Var As Boolean)
        ' Dim Pos As Integer = 0
        If txt.Text.Length > txt.MaxLength Then
            txt.Text = "0.0000"
            Var = True
            Exit Sub
        End If
        'Exit Sub
        Dim PosA As Integer = txt.SelectionStart

        If Chr(8) <> CharCode Then
            Dim Tecla As String = Asc(CharCode)

            If txt.Text.Trim.Length = 0 Then
                txt.Text = Format(0, "0.0000")
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
                        txt.Text = Mid(txt.Text, 1, IIf(Extension.Length = 5, txt.Text.Length, txt.Text.Length - 1))
                        If Extension.Length = 5 Then
                            txt.SelectionStart = Pos + 1
                        Else
                            txt.SelectionStart = Pos
                        End If


                    End If
                End If
            End If
        Else
            txt.Text = "0.0000"
            txt.SelectionStart = 0
            txt.SelectionLength = 0
            Var = True
            Exit Sub
            'PosA = 1
        End If
        txt.Text = Format(CDec(txt.Text), "0.0000")
        txt.SelectionStart = PosA + 1
    End Sub


    Public Shared Sub Validar_NumericoV(ByVal txt As TextBox, ByVal CharCode As Char, ByRef Var As Boolean)
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


    'Public Shared Sub Validar_NumericoV(ByVal txt As TextBox, ByVal CharCode As Char, ByRef Var As Boolean)
    '    ' Dim Pos As Integer = 0
    '    If txt.Text.Length > txt.MaxLength Then
    '        txt.Text = "0.00"
    '        Var = True
    '        Exit Sub
    '    End If
    '    'Exit Sub
    '    Dim PosA As Integer = txt.SelectionStart

    '    If Chr(8) <> CharCode Then
    '        Dim Tecla As String = Asc(CharCode)

    '        If txt.Text.Trim.Length = 0 Then
    '            txt.Text = Format(0, "0.00")
    '            txt.SelectionStart = 0
    '        Else
    '            If txt.SelectionStart = 0 Then
    '                Var = True
    '                Dim TextoIzq As String = ""
    '                Dim TextoDer As String = txt.Text.Substring(1)
    '                'Me.txtCantidad.Text = ""
    '                If Chr(Tecla) <> "." Then txt.Text = Chr(Tecla) & TextoDer
    '            Else
    '                If CharCode = "." Then
    '                    If txt.Text.IndexOf(".") = txt.SelectionStart Then
    '                        Var = True
    '                        txt.SelectionStart = txt.Text.IndexOf(".") + 1
    '                    Else
    '                        Var = True
    '                        'e.Handled = True
    '                        'Me.txtCantidad.SelectionStart = Me.txtCantidad.Text.IndexOf(".") + 1
    '                    End If

    '                Else
    '                    Var = True
    '                    Dim Pos As Integer = txt.SelectionStart
    '                    Dim Extension As String = ""
    '                    'Me.txtCantidad.Text = Me.txtCantidad.Text.Insert(Me.txtCantidad.SelectionStart, e.KeyChar)
    '                    'Extension = Mid(Me.txtCantidad.Text, Me.txtCantidad.Text.IndexOf(".") + 1, 4)
    '                    'Me.txtCantidad.Text = Mid(Me.txtCantidad.Text, 1, IIf(Extension.Length = 4, Me.txtCantidad.Text.Length + 1, Me.txtCantidad.Text.Length - 1))
    '                    txt.Text = txt.Text.Insert(txt.SelectionStart, CharCode)
    '                    Extension = Mid(txt.Text, txt.Text.IndexOf(".") + 1)
    '                    txt.Text = Mid(txt.Text, 1, IIf(Extension.Length = 3, txt.Text.Length, txt.Text.Length - 1))
    '                    If Extension.Length = 3 Then
    '                        txt.SelectionStart = Pos + 1
    '                    Else
    '                        txt.SelectionStart = Pos
    '                    End If


    '                End If
    '            End If
    '        End If
    '    Else
    '        txt.Text = "0.00"
    '        txt.SelectionStart = 0
    '        txt.SelectionLength = 0
    '        Var = True
    '        Exit Sub
    '        'PosA = 1
    '    End If
    '    txt.Text = Format(CDec(txt.Text), "0.00")
    '    txt.SelectionStart = PosA + 1
    'End Sub


    ''' <summary>
    ''' Formatea la Columna de un DataGridView 0: DateTime - 1: Decimal - 2: Ocultar
    ''' </summary>
    ''' <param name="dgvTarget">DataGridView objetivo</param>
    ''' <param name="strColumn">Array de columnas</param>
    ''' <param name="intTipo">0: Date - 1: Decimal - 2: Ocultar</param>
    ''' <remarks></remarks>
    Public Shared Sub FormateaColumna(ByVal dgvTarget As DataGridView, _
                                      ByVal strColumn() As String, _
                                      ByVal intTipo As Integer)
        For Each strCol As String In strColumn
            If dgvTarget.Columns(strCol) IsNot Nothing Then
                Select Case intTipo
                    Case 0
                        dgvTarget.Columns(strCol).DefaultCellStyle.Format = "dd/MM/yyyy"
                        dgvTarget.Columns(strCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Case 1
                        dgvTarget.Columns(strCol).DefaultCellStyle.Format = "n2"
                        dgvTarget.Columns(strCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Case 2
                        dgvTarget.Columns(strCol).Visible = False
                End Select
            End If
        Next
    End Sub

    Public Shared Function fncDiaSemanaPorIntSemana(ByVal intDia As Integer)
        Select Case intDia
            Case 1
                Return "Lunes"
            Case 2
                Return "Martes"
            Case 3
                Return "Miércoles"
            Case 4
                Return "Jueves"
            Case 5
                Return "Viernes"
            Case 6
                Return "Sábado"
            Case 7
                Return "Domingo"
            Case Else
                Return "NO VALIDO"
        End Select
    End Function

    ''' <summary>
    ''' Ordena las Columnas en el Grid empezando en DisplayIndex: 0
    ''' </summary>
    ''' <param name="dgvTarget">DataGridView Objetivo</param>
    ''' <param name="strColumn">Array de Columnas en orden</param>
    ''' <remarks></remarks>
    Public Shared Sub FormateaGridOrden(ByVal dgvTarget As DataGridView, _
                                        ByVal strColumn() As String)
        Dim intOrden As Integer = 0
        For Each strCol As String In strColumn
            If dgvTarget.Columns(strCol) IsNot Nothing Then
                dgvTarget.Columns(strCol).DisplayIndex = intOrden
                intOrden += 1
            End If
        Next
    End Sub

    ''' <summary>
    ''' Agrega Filas desde un datatable existente [dtFuente] a otro datatable [dtTarget]
    ''' </summary>
    ''' <param name="dtTarget">dt Objetivo</param>
    ''' <param name="dtFuente">dt Origen</param>
    ''' <remarks></remarks>
    Public Shared Sub AddRowsToDatatable(ByVal dtTarget As DataTable, ByVal dtFuente As DataTable)


        Dim strTargetCols As New List(Of String)
        ' Captura nombres de columnas
        If Not (dtTarget IsNot Nothing AndAlso dtTarget.Rows.Count > 0) Then
            Exit Sub
        End If
        For Each column As DataColumn In dtTarget.Columns
            'column.DataType = GetType(Object)
            strTargetCols.Add(column.ColumnName)
        Next
        ' Agrega Nuevas filas a existente

        If Not (dtFuente IsNot Nothing AndAlso dtFuente.Rows.Count > 0) Then
            Exit Sub
        End If

        For Each row As DataRow In dtFuente.Rows
            Dim drTarget As DataRow = dtTarget.NewRow
            For Each item As String In strTargetCols
                Dim strItem As String = ObtenerValorCelda(row, item)
                drTarget.Item(item) = strItem
            Next
            dtTarget.Rows.Add(drTarget)
        Next
    End Sub

    ''' <summary>
    ''' Limpia todos los textbox en determinado formulario
    ''' </summary>
    ''' <param name="root">form o group, conjunto que agrupa los textbox</param>
    ''' <remarks></remarks>
    Public Shared Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    'preoband

    Public Shared Function DatosRedIp() As String
        'Datos Privados
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        Dim ip = host.AddressList.FirstOrDefault(Function(x As IPAddress) _
            x.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork)

        Return ip.ToString
    End Function

    Public Shared Function DatosRedMac() As String
        Dim networkinterface = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Dim firstnetwork = networkinterface.FirstOrDefault(Function(x As System.Net.NetworkInformation.NetworkInterface) _
            x.OperationalStatus = System.Net.NetworkInformation.OperationalStatus.Up)
        Dim firstmacaddressofworkingnetworkadapter = firstnetwork.GetPhysicalAddress()
        Return firstmacaddressofworkingnetworkadapter.ToString
    End Function

    Public Shared Function fncValidarCaracteresAlfabeticos(ByVal strBase As String)
        For i = 0 To strBase.Length - 1
            If Char.IsLetter(strBase.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Shared Sub ShowMessageBox(ByVal message As Object)
        MessageBox.Show(message.ToString())
    End Sub

    'Public Shared Sub ExportToExcel(ByVal dgv As DataGridView)
    '    Dim t As New Threading.Thread(AddressOf ShowMessageBox)

    '    t.Start("Espere mientras se genera el reporte")

    '    If ((dgv.Columns.Count = 0) Or (dgv.Rows.Count = 0)) Then Exit Sub
    '    Dim XlApp = New Excel.Application With {.Visible = True}
    '    XlApp.Visible = False
    '    XlApp.Workbooks.Add(Excel.XlSheetType.xlWorksheet)
    '    Dim xlWS = XlApp.ActiveSheet
    '    xlWS.Name = "Exported Data"

    '    ' Lenguaje y variables a Español Perú

    '    Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-PE")




    '    'Copy visible data from DGV to Excel
    '    Dim columnCollection As DataGridViewColumnCollection = dgv.Columns
    '    Dim currentVisibleColumn As DataGridViewColumn = columnCollection.GetFirstColumn(DataGridViewElementStates.Visible)
    '    Dim lastColumnExported As DataGridViewColumn = currentVisibleColumn
    '    Dim visibleColumntCount As Integer = columnCollection.GetColumnCount(DataGridViewElementStates.Visible)

    '    'Finally export the data
    '    For c = 1 To visibleColumntCount
    '        xlWS.Cells(1, c) = currentVisibleColumn.HeaderText
    '        currentVisibleColumn = columnCollection.GetNextColumn(lastColumnExported, DataGridViewElementStates.Visible, DataGridViewElementStates.None)
    '        lastColumnExported = currentVisibleColumn
    '    Next

    '    'Only export visible cells
    '    For r = 0 To dgv.Rows.Count - 1
    '        'Reset values
    '        currentVisibleColumn = columnCollection.GetFirstColumn(DataGridViewElementStates.Visible)
    '        lastColumnExported = currentVisibleColumn
    '        For c = 1 To visibleColumntCount
    '            Dim value = dgv.Rows(r).Cells(currentVisibleColumn.Index).Value
    '            'Dim DateH As Date
    '            If value IsNot vbNullString And value IsNot DBNull.Value Then
    '                Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE")
    '                If currentVisibleColumn.GetType() = System.Type.GetType("System.Date") Then
    '                    xlWS.Cells(r + 2, c) = Date.Parse(value.ToString).Date
    '                Else
    '                    xlWS.Cells(r + 2, c) = value.ToString()
    '                End If

    '                'If Date.TryParse(value, DateH) = True Then
    '                '    'If DateH >= Date.Now.AddYears(-100) And DateH <= Date.Now.AddYears(100) Then
    '                '    '    xlWS.Cells(r + 2, c) = DateH
    '                '    'Else
    '                '    '    xlWS.Cells(r + 2, c) = value.ToString()
    '                '    'End If
    '                'Else
    '                '    xlWS.Cells(r + 2, c) = value.ToString()
    '                'End If

    '                'xlWS.Cells.NumberFormat = "@"
    '            End If
    '            currentVisibleColumn = columnCollection.GetNextColumn(lastColumnExported, DataGridViewElementStates.Visible, DataGridViewElementStates.None)
    '            lastColumnExported = currentVisibleColumn
    '        Next
    '    Next

    '    'Autosize columns in excel
    '    Dim columns = xlWS.UsedRange.Columns
    '    columns.AutoFit()
    '    XlApp.Visible = True

    'End Sub


    ' Encryption 

    Private Shared m_strPassPhrase As String = "MyPriv@Password!$$"    '---- any text string is good here
    Private Shared m_strHashAlgorithm As String = "MD5"                '--- we are doing MD5 encryption - can be "SHA1"
    Private Shared m_strPasswordIterations As Integer = 2              '--- can be any number
    Private Shared m_strInitVector As String = "@1B2c3D4e5F6g7H8"      '--- must be 16 bytes
    Private Shared m_intKeySize As Integer = 256                       '--- can be 192 or 128


    Public Shared Function EncryptPasswordMD5(ByVal plainText As String, ByVal p_strSaltValue As String) As String

        Dim strReturn As String = String.Empty

        ' Convert strings into byte arrays.
        ' Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8 
        ' encoding.

        Try
            Dim initVectorBytes As Byte()
            initVectorBytes = System.Text.Encoding.ASCII.GetBytes(m_strInitVector)

            Dim saltValueBytes As Byte()
            saltValueBytes = System.Text.Encoding.ASCII.GetBytes(p_strSaltValue)

            ' Convert our plaintext into a byte array.
            ' Let us assume that plaintext contains UTF8-encoded characters.
            Dim plainTextBytes As Byte()
            plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)

            ' First, we must create a password, from which the key will be derived.
            ' This password will be generated from the specified passphrase and 
            ' salt value. The password will be created using the specified hash 
            ' algorithm. Password creation can be done in several iterations.

            Dim password As Rfc2898DeriveBytes

            password = New Rfc2898DeriveBytes(m_strPassPhrase, _
                                          saltValueBytes, _
                                          m_strPasswordIterations)

            ' Use the password to generate pseudo-random bytes for the encryption
            ' key. Specify the size of the key in bytes (instead of bits).
            Dim keyBytes As Byte()
            Dim intKeySize As Integer = 0

            intKeySize = CType((m_intKeySize / 8), Integer)

            keyBytes = password.GetBytes(intKeySize)

            ' Create uninitialized Rijndael encryption object.
            Dim symmetricKey As System.Security.Cryptography.RijndaelManaged
            symmetricKey = New System.Security.Cryptography.RijndaelManaged

            ' It is reasonable to set encryption mode to Cipher Block Chaining
            ' (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC

            'symmetricKey.Padding = PaddingMode.Zeros


            ' Generate encryptor from the existing key bytes and initialization 
            ' vector. Key size will be defined based on the number of the key 
            ' bytes.
            Dim encryptor As System.Security.Cryptography.ICryptoTransform
            encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim memoryStream As System.IO.MemoryStream
            memoryStream = New System.IO.MemoryStream

            ' Define cryptographic stream (always use Write mode for encryption).
            Dim cryptoStream As System.Security.Cryptography.CryptoStream
            cryptoStream = New System.Security.Cryptography.CryptoStream(memoryStream, _
                                            encryptor, _
                                            System.Security.Cryptography.CryptoStreamMode.Write)
            ' Start encrypting.
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)

            ' Finish encrypting.
            cryptoStream.FlushFinalBlock()

            ' Convert our encrypted data from a memory stream into a byte array.
            Dim cipherTextBytes As Byte()
            cipherTextBytes = memoryStream.ToArray()

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert encrypted data into a base64-encoded string.
            Dim cipherText As String
            cipherText = Convert.ToBase64String(cipherTextBytes)

            ' Return encrypted string.
            strReturn = cipherText

        Catch ex As Exception
            strReturn = Nothing
        End Try

        Return strReturn

    End Function

    'Decrypt Function: 

    Public Shared Function DecryptPasswordMD5(ByVal cipherText As String, ByVal p_strSaltValue As String) As String

        Dim strReturn As String = String.Empty

        ' Convert strings defining encryption key characteristics into byte
        ' arrays. Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
        ' encoding.

        Try

            Dim initVectorBytes As Byte()
            initVectorBytes = System.Text.Encoding.ASCII.GetBytes(m_strInitVector)

            Dim saltValueBytes As Byte()
            saltValueBytes = System.Text.Encoding.ASCII.GetBytes(p_strSaltValue)

            ' Convert our ciphertext into a byte array.
            Dim cipherTextBytes As Byte()
            cipherTextBytes = Convert.FromBase64String(cipherText)

            ' First, we must create a password, from which the key will be 
            ' derived. This password will be generated from the specified 
            ' passphrase and salt value. The password will be created using
            ' the specified hash algorithm. Password creation can be done in
            ' several iterations.

            Dim password As Rfc2898DeriveBytes

            password = New Rfc2898DeriveBytes(m_strPassPhrase, _
                                            saltValueBytes, _
                                            m_strPasswordIterations)

            ' Use the password to generate pseudo-random bytes for the encryption
            ' key. Specify the size of the key in bytes (instead of bits).
            Dim keyBytes As Byte()
            Dim intKeySize As Integer

            intKeySize = CType((m_intKeySize / 8), Integer)

            keyBytes = password.GetBytes(intKeySize)

            ' Create uninitialized Rijndael encryption object.
            Dim symmetricKey As System.Security.Cryptography.RijndaelManaged
            symmetricKey = New System.Security.Cryptography.RijndaelManaged

            ' It is reasonable to set encryption mode to Cipher Block Chaining
            ' (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC

            'symmetricKey.Padding = PaddingMode.Zeros

            ' Generate decryptor from the existing key bytes and initialization 
            ' vector. Key size will be defined based on the number of the key 
            ' bytes.
            Dim decryptor As System.Security.Cryptography.ICryptoTransform
            decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim memoryStream As System.IO.MemoryStream
            memoryStream = New System.IO.MemoryStream(cipherTextBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim cryptoStream As System.Security.Cryptography.CryptoStream
            cryptoStream = New System.Security.Cryptography.CryptoStream(memoryStream, _
                                            decryptor, _
                                            System.Security.Cryptography.CryptoStreamMode.Read)

            ' Since at this point we don't know what the size of decrypted data
            ' will be, allocate the buffer long enough to hold ciphertext;
            ' plaintext is never longer than ciphertext.
            Dim plainTextBytes As Byte()
            ReDim plainTextBytes(cipherTextBytes.Length)

            ' Start decrypting.
            Dim decryptedByteCount As Integer
            decryptedByteCount = cryptoStream.Read(plainTextBytes, _
                                                0, _
                                                plainTextBytes.Length)

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert decrypted data into a string. 
            ' Let us assume that the original plaintext string was UTF8-encoded.
            Dim plainText As String
            plainText = System.Text.Encoding.UTF8.GetString(plainTextBytes, _
                                                0, _
                                                decryptedByteCount)

            ' Return decrypted string.
            strReturn = plainText

        Catch ex As Exception
            strReturn = Nothing
        End Try

        Return strReturn


    End Function



#Region "Exportar a Excel"

    Structure TipoDato
        Public tpdDato As System.Type
        Public Formato As String
    End Structure

    Public Shared Function mtd_CargarTipoDato() As TipoDato()

        Dim objTipoDato(7) As TipoDato
        objTipoDato(0).tpdDato = System.Type.GetType("System.Int16")
        objTipoDato(0).Formato = "0"
        objTipoDato(1).tpdDato = System.Type.GetType("System.Int32")
        objTipoDato(1).Formato = "0"
        objTipoDato(2).tpdDato = System.Type.GetType("System.Int64")
        objTipoDato(2).Formato = "0"
        objTipoDato(3).tpdDato = System.Type.GetType("System.Boolean")
        objTipoDato(3).Formato = "0"
        objTipoDato(4).tpdDato = System.Type.GetType("System.Double")
        objTipoDato(4).Formato = "#,###,##0.00"
        objTipoDato(5).tpdDato = System.Type.GetType("System.Decimal")
        objTipoDato(5).Formato = "#,###,##0.00"
        objTipoDato(6).tpdDato = System.Type.GetType("System.DateTime")
        objTipoDato(6).Formato = "dd/mm/yyyy"
        objTipoDato(7).tpdDato = System.Type.GetType("System.String")
        objTipoDato(7).Formato = ""
        Return objTipoDato

    End Function

    Public Shared Function fnc_ConvertirALetra(ByVal iCol As Integer) As String
        Dim i, j As Integer
        i = Int((iCol - 1) / 26)
        j = iCol - (i * 26)
        If i > 0 Then
            Return Chr(64 + i) + Chr(64 + j)
        Else
            Return Chr(64 + j)
        End If
    End Function

    Public Shared Sub ProcComboBoxAMes(ByVal pComboBox As ComboBox)
        ' Dim ObjAuxiliar As New clsco2_auxiliarBUS
        ' Dim dmFechaHoy As Date = ObjAuxiliar.fncConsultarFechaHoraServidorBUS
        pComboBox.DataSource = Nothing

        Dim intMes As Integer = FechaHoraServidor.Month

        Dim ObjDataTable As New DataTable
        ObjDataTable.Columns.Add("IdMes", GetType(Integer))
        ObjDataTable.Columns.Add("Nombre", GetType(String))
        ObjDataTable.Rows.Add(1, "ENERO")
        ObjDataTable.Rows.Add(2, "FEBRERO")
        ObjDataTable.Rows.Add(3, "MARZO")
        ObjDataTable.Rows.Add(4, "ABRIL")
        ObjDataTable.Rows.Add(5, "MAYO")
        ObjDataTable.Rows.Add(6, "JUNIO")
        ObjDataTable.Rows.Add(7, "JULIO")
        ObjDataTable.Rows.Add(8, "AGOSTO")
        ObjDataTable.Rows.Add(9, "SETIEMBRE")
        ObjDataTable.Rows.Add(10, "OCTUBRE")
        ObjDataTable.Rows.Add(11, "NOVIEMBRE")
        ObjDataTable.Rows.Add(12, "DICIEMBRE")


        pComboBox.DataSource = ObjDataTable
        pComboBox.ValueMember = "IdMes"
        pComboBox.DisplayMember = "Nombre"
        pComboBox.SelectedValue = intMes
    End Sub

    Public Shared Sub ProcComboBoxAAnio(ByVal cmbBase As ComboBox)
        cmbBase.DataSource = Nothing
        Dim intAnio As Integer = FechaHoraServidor.Year
        Dim dtAnio As New DataTable
        dtAnio.Columns.Add("IdAnio", GetType(Integer))
        dtAnio.Columns.Add("Anio", GetType(Integer))

        For i As Integer = 1 To 12
            dtAnio.Rows.Add(intAnio - (6 - i), (intAnio - (6 - i)).ToString)
        Next

        cmbBase.DataSource = dtAnio
        cmbBase.ValueMember = "IdAnio"
        cmbBase.DisplayMember = "Anio"
        cmbBase.SelectedValue = intAnio

    End Sub

    Public Shared Sub mtd_ExportarDataTableAExcel(ByVal dtMiTabla As DataTable)
        Dim oXL As Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        Dim oRng As Excel.Range

        Dim intFilas As Integer = dtMiTabla.Rows.Count - 1
        Dim intColumnas As Integer = dtMiTabla.Columns.Count - 1

        Dim intIndexCol As Integer = 0
        Dim intIndexFil As Integer = 0

        Dim strLetra As String = ""
        Dim strFormato As String = ""

        Dim objTipoDato(7) As TipoDato
        objTipoDato = mtd_CargarTipoDato()


        ' Start Excel and get Application object.
        oXL = CreateObject("Excel.Application")
        oXL.Visible = True

        ' Get a new workbook.
        oWB = oXL.Workbooks.Add
        oSheet = oWB.ActiveSheet

        intIndexCol = 0
        For Each columna As DataColumn In dtMiTabla.Columns
            intIndexCol = intIndexCol + 1
            strLetra = fnc_ConvertirALetra(intIndexCol)
            oSheet.Range(strLetra & "1", strLetra & "1").Value = columna.ColumnName
        Next

        With oSheet.Range("A1", strLetra & "1")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        Dim mtxMiTabla(intFilas, intColumnas) As Object

        intIndexCol = 0
        intIndexFil = 0
        For Each fila As DataRow In dtMiTabla.Rows
            intIndexCol = 0
            For Each columna As DataColumn In dtMiTabla.Columns
                'If Not IsDBNull(dtMiTabla.Rows(intIndexFil).Item(intIndexCol)) Then
                mtxMiTabla(intIndexFil, intIndexCol) = dtMiTabla.Rows(intIndexFil).Item(intIndexCol)
                'Else
                '   mtxMiTabla(intIndexFil, intIndexCol) = ObtenerValorCampoDefecto(dtMiTabla.Columns(intIndexCol).DataType)
                'End If
                intIndexCol = intIndexCol + 1
            Next
            intIndexFil = intIndexFil + 1
        Next

        strLetra = ""
        strFormato = ""
        intIndexCol = 0
        For Each columna As DataColumn In dtMiTabla.Columns
            intIndexCol = intIndexCol + 1
            strLetra = fnc_ConvertirALetra(intIndexCol)
            For Each objTipo As TipoDato In objTipoDato
                If objTipo.tpdDato.Name = columna.DataType.Name Then
                    strFormato = objTipo.Formato
                    Exit For
                End If
            Next
            oSheet.Range(strLetra & "2", strLetra & CStr(2 + intFilas)).NumberFormat = strFormato
        Next
        oSheet.Range("A" & "2", strLetra & CStr(2 + intFilas)).Value = mtxMiTabla

        Dim columns = oSheet.UsedRange.Columns
        columns.AutoFit()

        oXL.Visible = True
        oXL.UserControl = True

        oRng = Nothing
        oSheet = Nothing
        oWB = Nothing
        'oXL.Quit()
        oXL = Nothing

        Exit Sub
Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
    End Sub

#End Region


#Region "Exportar a Excel"

    Public Shared Function mtd_CargarTipoDatoAFP() As TipoDato()

        Dim objTipoDato(7) As TipoDato
        objTipoDato(0).tpdDato = System.Type.GetType("System.Int16")
        objTipoDato(0).Formato = "0"
        objTipoDato(1).tpdDato = System.Type.GetType("System.Int32")
        objTipoDato(1).Formato = "0"
        objTipoDato(2).tpdDato = System.Type.GetType("System.Int64")
        objTipoDato(2).Formato = "0"
        objTipoDato(3).tpdDato = System.Type.GetType("System.Boolean")
        objTipoDato(3).Formato = "0"
        objTipoDato(4).tpdDato = System.Type.GetType("System.Double")
        objTipoDato(4).Formato = "0.00"
        objTipoDato(5).tpdDato = System.Type.GetType("System.Decimal")
        objTipoDato(5).Formato = "0.00"
        objTipoDato(6).tpdDato = System.Type.GetType("System.DateTime")
        objTipoDato(6).Formato = "dd/mm/yyyy"
        objTipoDato(7).tpdDato = System.Type.GetType("System.String")
        objTipoDato(7).Formato = ""
        Return objTipoDato

    End Function

    Public Shared Sub mtd_ExportarDataTableAExcelSinCabecera(ByVal dtMiTabla As DataTable)
        Dim oXL As Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        Dim oRng As Excel.Range

        Dim intFilas As Integer = dtMiTabla.Rows.Count - 1
        Dim intColumnas As Integer = dtMiTabla.Columns.Count - 1

        Dim intIndexCol As Integer = 0
        Dim intIndexFil As Integer = 0

        Dim strLetra As String = ""
        Dim strFormato As String = ""

        Dim objTipoDato(7) As TipoDato
        objTipoDato = mtd_CargarTipoDatoAFP()


        ' Start Excel and get Application object.
        oXL = CreateObject("Excel.Application")
        oXL.Visible = True

        ' Get a new workbook.
        oWB = oXL.Workbooks.Add
        oSheet = oWB.ActiveSheet

        Dim mtxMiTabla(intFilas, intColumnas) As Object

        intIndexCol = 0
        intIndexFil = 0
        For Each fila As DataRow In dtMiTabla.Rows
            intIndexCol = 0
            For Each columna As DataColumn In dtMiTabla.Columns
                'If Not IsDBNull(dtMiTabla.Rows(intIndexFil).Item(intIndexCol)) Then
                If columna.ColumnName = "dniper" Then
                    mtxMiTabla(intIndexFil, intIndexCol) = "'" & dtMiTabla.Rows(intIndexFil).Item(intIndexCol)
                Else
                    mtxMiTabla(intIndexFil, intIndexCol) = dtMiTabla.Rows(intIndexFil).Item(intIndexCol)
                End If
                'Else
                '   mtxMiTabla(intIndexFil, intIndexCol) = ObtenerValorCampoDefecto(dtMiTabla.Columns(intIndexCol).DataType)
                'End If
                intIndexCol = intIndexCol + 1
            Next
            intIndexFil = intIndexFil + 1
        Next

        strLetra = ""
        strFormato = ""
        intIndexCol = 0
        For Each columna As DataColumn In dtMiTabla.Columns
            intIndexCol = intIndexCol + 1
            strLetra = fnc_ConvertirALetra(intIndexCol)
            For Each objTipo As TipoDato In objTipoDato
                If objTipo.tpdDato.Name = columna.DataType.Name Then
                    strFormato = objTipo.Formato
                    Exit For
                End If
            Next
            oSheet.Range(strLetra & "1", strLetra & CStr(1 + intFilas)).NumberFormat = strFormato
        Next
        oSheet.Range("A" & "1", strLetra & CStr(1 + intFilas)).Value = mtxMiTabla

        Dim columns = oSheet.UsedRange.Columns
        columns.AutoFit()

        oXL.Visible = True
        oXL.UserControl = True

        oRng = Nothing
        oSheet = Nothing
        oWB = Nothing
        'oXL.Quit()
        oXL = Nothing

        Exit Sub
Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
    End Sub

#End Region

End Class
