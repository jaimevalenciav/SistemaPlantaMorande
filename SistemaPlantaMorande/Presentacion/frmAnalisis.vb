Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Public Class frmAnalisis
    Private dt As New DataTable
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Private Sub frmAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        swactivo.Value = False
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fanalisis
            dt = func.mostrar
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                datalistado.DefaultCellStyle.SelectionBackColor = Color.DarkRed
                datalistado.DefaultCellStyle.SelectionForeColor = Color.White
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        datalistado.Columns(0).Width = 85
        datalistado.Columns(1).Width = 200
        datalistado.Columns(2).Width = 70
        datalistado.Columns(3).Width = 140
        datalistado.Columns(4).Width = 140
        datalistado.Columns(5).Width = 70
        btnguardar.Visible = True
        btneditar.Visible = False
    End Sub
    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        txtid.Text = datalistado.SelectedCells.Item(0).Value
        txtcodigo.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre.Text = datalistado.SelectedCells.Item(1).Value
        txtvalormin.Text = datalistado.SelectedCells.Item(3).Value
        txtvalormax.Text = datalistado.SelectedCells.Item(4).Value
        swactivo.Value = datalistado.SelectedCells.Item(5).Value
        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub btnlimpia_Click(sender As Object, e As EventArgs) Handles btnlimpia.Click
        txtid.Text = ""
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtvalormin.Text = "0"
        txtvalormax.Text = "0"
        swactivo.Value = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtcodigo.Text <> "" And txtnombre.Text <> "" And txtvalormin.Text <> "" And txtvalormax.Text <> "" Then
            Try
                Dim dts As New vanalisis
                Dim func As New fanalisis
                'dts.gidanalisis = txtid.Text
                dts.gcodcorto = txtcodigo.Text
                dts.gnomanalisis = txtnombre.Text
                dts.gvalormin = txtvalormin.Text
                dts.gvalormax = txtvalormax.Text
                dts.gestado = swactivo.Value
                If func.insertar(dts) Then
                    MessageBox.Show("Tipo Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Tipo no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtid.Text = ""
        txtnombre.Text = ""
        txtcodigo.Text = ""
        txtvalormin.Text = ""
        txtvalormax.Text = ""
        swactivo.Value = False
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar el registro?", "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If txtcodigo.Text <> "" And txtnombre.Text <> "" And txtvalormin.Text <> "" And txtvalormax.Text <> "" Then
                Try
                    Dim dts As New vanalisis
                    Dim func As New fanalisis

                    dts.gidanalisis = txtid.Text
                    dts.gcodcorto = txtcodigo.Text
                    dts.gnomanalisis = txtnombre.Text
                    dts.gvalormin = txtvalormin.Text
                    dts.gvalormax = txtvalormax.Text
                    dts.gestado = swactivo.Value

                    If func.editar(dts) Then
                        MessageBox.Show("Tipo Editado Correctamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Tipo no fue Editado, intente nuevamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        limpiar()
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
End Class