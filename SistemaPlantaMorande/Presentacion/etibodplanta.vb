Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Public Class etibodplanta
    Private dt As New DataTable
    Private Sub etibodplanta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()
        txtcodigo.ReadOnly = True
        txtnombre.ReadOnly = True
        txtfamilia.ReadOnly = True
        txtdestino.ReadOnly = True
        txtcodigo.ReadOnly = True
        txtcodigo.BackColor = Color.White
        txtnombre.BackColor = Color.White
        txtfamilia.BackColor = Color.White
        txtdestino.BackColor = Color.White
        txtcodigo.ForeColor = Color.DarkOrange

    End Sub

    Private Sub mostrar()

        Try
            Dim func As New farticulosbodega
            dt = func.mostrar
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
            Else
                datalistado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        datalistado.Columns(0).Width = 90
        datalistado.Columns(1).Width = 400
        datalistado.Columns(2).Width = 145
        datalistado.Columns(3).Width = 80

    End Sub

    Private Sub txtcodarticulo_TextChanged(sender As Object, e As EventArgs) Handles txtcodarticulo.TextChanged
        buscaarticulocod()
    End Sub

    Private Sub buscaarticulocod()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = "CodigoArticulo like '" & txtcodarticulo.Text & "%'"

            datalistado.DataSource = dv
            datalistado.Update()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtnomarticulo_TextChanged(sender As Object, e As EventArgs) Handles txtnomarticulo.TextChanged
        buscaarticulonom()
    End Sub
    Private Sub buscaarticulonom()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = "NombreArticulo like '%" & txtnomarticulo.Text & "%'"
            datalistado.DataSource = dv
            datalistado.Update()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtcodarticulo.Text = ""
        txtnomarticulo.Text = ""
        'mostrar()
    End Sub

    Private Sub limpiar()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtfamilia.Text = ""
        txtdestino.Text = ""
        chk55x32.Checked = False
        chk100x70.Checked = False
        txtcantidadetiq.Text = 0
    End Sub


    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        txtcodigo.Text = datalistado.SelectedCells.Item(0).Value
        txtnombre.Text = datalistado.SelectedCells.Item(1).Value
        txtfamilia.Text = datalistado.SelectedCells.Item(2).Value
        txtdestino.Text = datalistado.SelectedCells.Item(3).Value
        chk30x20.Checked = True
        chk55x32.Checked = False
        chk100x70.Checked = False
        txtcantidadetiq.Text = 1
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnlimpia_Click(sender As Object, e As EventArgs) Handles btnlimpia.Click
        limpiar()

    End Sub

    Private Sub btnprinteti_Click(sender As Object, e As EventArgs) Handles btnprinteti.Click
        Dim s As String
        Dim pd As New PrintDialog()
        s = ""

        If chk55x32.Checked = True Then


            '-------------Codigo EPL--------------------
            s = "I8,A,1" & vbCrLf & vbCrLf & vbCrLf
            s = s + "Q256,024" & vbCrLf
            s = s + "q831" & vbCrLf
            s = s + "rN" & vbCrLf
            s = s + "S0" & vbCrLf
            s = s + "D11" & vbCrLf  'Oscuridad de la impresion
            s = s + "ZT" & vbCrLf
            s = s + "JF" & vbCrLf
            s = s + "OD" & vbCrLf
            s = s + "R204,0" & vbCrLf 'posición horizontal de la etiqueta
            s = s + "f100" & vbCrLf
            s = s + "N" & vbCrLf
            s = s + "A3,91,0,4,1,1,N," & """" & Mid(txtnombre.Text, 51, 25) & """" & vbCrLf
            s = s + "A3,69,0,4,1,1,N," & """" & Mid(txtnombre.Text, 26, 25) & """" & vbCrLf
            s = s + "A3,45,0,4,1,1,N," & """" & Mid(txtnombre.Text, 1, 25) & """" & vbCrLf
            s = s + "LO7,166,425,3" & vbCrLf
            s = s + "A210,113,0,4,1,1,N," & """" & "Marca Destino:" & """" & vbCrLf
            s = s + "B7,170,0,1,2,6,44,B," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "A210,138,0,4,1,1,N," & """" & txtdestino.Text & """" & vbCrLf
            s = s + "A8,8,0,2,2,2,N," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "A7,113,0,4,1,1,N," & """" & "Familia:" & """" & vbCrLf
            s = s + "A7,138,0,4,1,1,N," & """" & Mid(txtfamilia.Text, 1, 12) & """" & vbCrLf
            s = s + "LO206,112,1,51" & vbCrLf
            s = s + "LE3,215,431,25" & vbCrLf
            s = s + "LE3,112,431,22" & vbCrLf
            s = s + "LE3,4,429,39" & vbCrLf
            s = s + "P" & txtcantidadetiq.Text & vbCrLf



            RawPrinterHelper.SendStringToPrinter("etiquetas", s)

            'TextBox1.Text = s
            limpiar()

        ElseIf chk100x70.Checked = True Then

            '-------------Codigo ZPL--------------------
            's = "^XA" & vbCrLf
            's = s + "^MMT" & vbCrLf
            's = s + "^PW799" & vbCrLf
            's = s + "^LL0559" & vbCrLf
            's = s + "^LS0" & vbCrLf
            's = s + "^FT18,114^A0N,102,100^FH\^FD" & txtcodigo.Text & "^FS" & vbCrLf
            's = s + "^FT18,161^A0N,17,16^FH\^FD" & txtnombre.Text & "^FS" & vbCrLf
            's = s + "^FT18,226^A0N,28,28^FH\^FDFamilia:^FS" & vbCrLf
            's = s + "^FT145,223^A0N,28,26^FH\^FD" & txtfamilia.Text & "^FS" & vbCrLf
            's = s + "^FT18,263^A0N,28,28^FH\^FDMarca Destino:^FS" & vbCrLf
            's = s + "^FT207,263^A0N,28,26^FH\^FD" & txtdestino.Text & "^FS" & vbCrLf
            's = s + "^FO14,278^GB767,0,8^FS" & vbCrLf
            's = s + "^BY3,3,214^FT43,495^B3N,N,,Y,N" & vbCrLf
            's = s + "^FD" & txtcodigo.Text & "^FS" & vbCrLf
            's = s + "^PQ" & txtcantidadetiq.Text & ",0,1,Y^XZ" & vbCrLf

            '-------------Codigo EPL--------------------
            s = "I8, A, 1" & vbCrLf & vbCrLf & vbCrLf
            s = s + "Q559,24" & vbCrLf
            s = s + "q831" & vbCrLf
            s = s + "rN" & vbCrLf
            s = s + "S6" & vbCrLf
            s = s + "D13" & vbCrLf
            s = s + "ZT" & vbCrLf
            s = s + "JF" & vbCrLf
            s = s + "OD" & vbCrLf
            s = s + "R32,0" & vbCrLf
            s = s + "f100" & vbCrLf
            s = s + "N" & vbCrLf
            s = s + "A7,38,0,4,3,3,N," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "A385,206,0,1,2,2,N," & """" & txtdestino.Text & """" & vbCrLf
            s = s + "A12,206,0,1,2,2,N," & """" & txtfamilia.Text & """" & vbCrLf
            s = s + "A385,170,0,1,1,1,N," & """" & "Marca Destino:" & """" & vbCrLf
            s = s + "A12,109,0,1,1,1,N," & """" & "Descripción Artículo SAP:" & """" & vbCrLf
            s = s + "A11,21,0,1,1,1,N," & """" & "Código SAP:" & """" & vbCrLf
            s = s + "A11,170,0,1,1,1,N," & """" & "Familia:" & """" & vbCrLf
            s = s + "A12,143,0,1,1,1,N," & """" & Mid(txtnombre.Text, 77, 76) & """" & vbCrLf
            s = s + "A12,127,0,1,1,1,N," & """" & Mid(txtnombre.Text, 1, 76) & """" & vbCrLf
            s = s + "LO13,273,768,8" & vbCrLf
            s = s + "B14,282,0,1,3,9,160,B," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "LO5,249,773,1" & vbCrLf
            s = s + "LO363,164,2,87" & vbCrLf
            s = s + "LE8,17,772,20" & vbCrLf
            s = s + "LE8,163,772,20" & vbCrLf
            s = s + "LE8,105,777,20" & vbCrLf
            s = s + "LE9,443,769,26" & vbCrLf
            s = s + "P" & txtcantidadetiq.Text & vbCrLf
            RawPrinterHelper.SendStringToPrinter("etiquetas", s)
            'TextBox1.Text = s
            limpiar()

        ElseIf chk30x20.Checked = True Then



            '-------------Codigo EPL--------------------
            s = "I8,A,1" & vbCrLf & vbCrLf & vbCrLf
            s = s + "Q176,24" & vbCrLf
            s = s + "q831" & vbCrLf
            s = s + "rN" & vbCrLf
            s = s + "S4" & vbCrLf
            s = s + "D11" & vbCrLf
            s = s + "ZT" & vbCrLf
            s = s + "JF" & vbCrLf
            s = s + "OD" & vbCrLf
            s = s + "R0,0" & vbCrLf
            s = s + "f100" & vbCrLf
            s = s + "N" & vbCrLf
            s = s + "B810,79,2,1,1,3,55,B," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "A810,125,2,2,1,1,N," & """" & Mid(txtnombre.Text, 1, 19) & """" & vbCrLf
            s = s + "A810,103,2,2,1,1,N," & """" & Mid(txtnombre.Text, 20, 19) & """" & vbCrLf
            s = s + "A804,160,2,2,2,2,N," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "B524,79,2,1,1,3,55,B," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "A525,125,2,2,1,1,N," & """" & Mid(txtnombre.Text, 1, 19) & """" & vbCrLf
            s = s + "A525,103,2,2,1,1,N," & """" & Mid(txtnombre.Text, 20, 19) & """" & vbCrLf
            s = s + "A525,160,2,2,2,2,N," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "B250,79,2,1,1,3,55,B," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "A247,125,2,2,1,1,N," & """" & Mid(txtnombre.Text, 1, 19) & """" & vbCrLf
            s = s + "A247,103,2,2,1,1,N," & """" & Mid(txtnombre.Text, 20, 19) & """" & vbCrLf
            s = s + "A247,160,2,2,2,2,N," & """" & txtcodigo.Text & """" & vbCrLf
            s = s + "P" & txtcantidadetiq.Text & vbCrLf
            RawPrinterHelper.SendStringToPrinter("etiquetas", s)
            'TextBox1.Text = s
            limpiar()

        End If
    End Sub


    Private Sub txtcantidadetiq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidadetiq.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class