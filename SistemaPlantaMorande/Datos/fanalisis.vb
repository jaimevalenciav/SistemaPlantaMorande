Imports System.Data.SqlClient
Public Class fanalisis
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("lista_analisis")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function


    Public Function insertar(ByVal dts As vanalisis) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_analisis")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nomanalisis", dts.gnomanalisis)
            cmd.Parameters.AddWithValue("@nomcorto", dts.gcodcorto)
            cmd.Parameters.AddWithValue("@valormin", dts.gvalormin)
            cmd.Parameters.AddWithValue("@valormax", dts.gvalormax)
            cmd.Parameters.AddWithValue("@activo", dts.gestado)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function editar(ByVal dts As vanalisis) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_analisis")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idanalisis", dts.gidanalisis)
            cmd.Parameters.AddWithValue("@nomanalisis", dts.gnomanalisis)
            cmd.Parameters.AddWithValue("@codcorto", dts.gcodcorto)
            cmd.Parameters.AddWithValue("@valormin", dts.gvalormin)
            cmd.Parameters.AddWithValue("@valormax", dts.gvalormax)
            cmd.Parameters.AddWithValue("@activo", dts.gestado)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
End Class
