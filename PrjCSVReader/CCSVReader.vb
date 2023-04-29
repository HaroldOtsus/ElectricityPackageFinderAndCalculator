Imports System.Data.OleDb
Public Class CCSVReader

    Public Shared Function ReadCSV(ByVal filePath As String) As DataTable
        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & IO.Path.GetDirectoryName(filePath) & ";Extended Properties='text;HDR=Yes;FMT=Delimited'"
        Dim query As String = "SELECT * FROM [" & IO.Path.GetFileName(filePath) & "]"
        Dim dt As New DataTable()

        Using conn As New OleDbConnection(connString)
            Using adapter As New OleDbDataAdapter(query, conn)
                adapter.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

End Class
