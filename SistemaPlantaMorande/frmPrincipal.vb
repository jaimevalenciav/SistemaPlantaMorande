Imports System.Data
Imports System.Data.SqlClient
Public Class frmPrincipal
    Public cnn As SqlConnection
    Public dtr As SqlDataReader
    Public cmd As SqlCommand
    Private Sub ArtículosBodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículosBodegaToolStripMenuItem.Click
        Try
            cnn = New SqlConnection("Data Source = SQLSERVER02\BCI_ERP_C; Initial Catalog= sisplanta; Persist Security Info = True; user Id = planta; Password= morande2017")
            cmd = New SqlCommand("sp_VerificarAccesoetiquetadoarticulos", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@NomUsuario", lbluser.Text)
            cnn.Open()
            dtr = cmd.ExecuteReader
            If dtr.HasRows Then
                ''Se comenta mensaje de bienvenida, no es necesario'
                ''MsgBox("Pasa validacion", MsgBoxStyle.Information)
                etibodplanta.ShowDialog()
            Else
                MsgBox("Ud. no posee permisos de acceso a este módulo", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ArtículosHouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículosHouseToolStripMenuItem.Click
        Try
            cnn = New SqlConnection("Data Source = SQLSERVER02\BCI_ERP_C; Initial Catalog= sisplanta; Persist Security Info = True; user Id = planta; Password= morande2017")
            cmd = New SqlCommand("sp_VerificarAccesoetiquetadoarticuloshouse", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@NomUsuario", lbluser.Text)
            cnn.Open()
            dtr = cmd.ExecuteReader
            If dtr.HasRows Then
                ''Se comenta mensaje de bienvenida, no es necesario'
                ''MsgBox("Pasa validacion", MsgBoxStyle.Information)
                etihouse.ShowDialog()
            Else
                MsgBox("Ud. no posee permisos de acceso a este módulo", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try


    End Sub

    Private Sub IngresoAnálisisCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoAnálisisCamposToolStripMenuItem.Click

    End Sub

    Private Sub AnálisisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnálisisToolStripMenuItem.Click
        frmAnalisis.ShowDialog()
    End Sub

    Private Sub CorrelativoMuestraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorrelativoMuestraToolStripMenuItem.Click

    End Sub

    Private Sub GrupoDeAnálisisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoDeAnálisisToolStripMenuItem.Click
        frmGrupoAnalisis.ShowDialog()
    End Sub
End Class