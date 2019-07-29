Imports System.Data.SqlClient
Module Module1
    Dim sql As String
    Dim con As New SqlConnection("Data Source=(local);Initial Catalog=simplecrytal;Persist Security Info=True;User ID=sa;password=123456789;")
    Dim da As SqlDataAdapter
    Friend dt As DataTable
    Sub checkcon()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Friend Function read(ByVal sql As String)
        Try
            dt = New DataTable
            dt.Clear()
            da = New SqlDataAdapter(sql, con)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Return MsgBox(sql)
        End Try

    End Function
End Module
