
Imports System.Data.OleDb
    Imports System.IO
    Public Class CCSVReader

        Public Shared Function ReadCSV(ByVal filePath As String) As DataTable
            Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & IO.Path.GetDirectoryName(filePath) & ";Extended Properties='text;HDR=Yes;FMT=Delimited'"
            Dim query As String = "SELECT * FROM [" & IO.Path.GetFileName(filePath) & "]"
            Dim dt As New DataTable()

            Using parser As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                parser.SetDelimiters(";") 'demlimiter is the end of the row

                'ignores the first 9 lines because that is user information and not consumption history
                Dim headerLinesToSkip As Integer = 9
                For i As Integer = 1 To headerLinesToSkip
                    parser.ReadLine()
                Next

                'Filling ze table
                ' Read the header row and add the columns to the table
                Dim column As Integer = 0
                Dim headerRow As String() = parser.ReadFields()
                For Each header As String In headerRow
                    dt.Columns.Add(header)
                    column += 1
                Next
                If column > 2 Then
                    ' Read the data rows and add them to the table
                    While Not parser.EndOfData
                        Dim fields As String() = parser.ReadFields()
                        dt.Rows.Add(fields)
                        'p.dateAndTime = fields(0)
                        'p.wattage = fields(2)

                    End While

                End If
            End Using

            Return dt
        End Function

    End Class

