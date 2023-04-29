Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Public Class CCSVFileImport
    Implements ICSVFileImport
    Inherits 
    Public Function ImportCSVFile(openFileDialog)


        'opens a window for user to select their CSV file
        Dim openFileDialog As New OpenFileDialog()
        'Filter to only show CSV files and all files
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        'If the user selects a file and presses OK
        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim selectedFileName As String = openFileDialog.FileName

            'If btnConfirmSimuCSV.Focused = True Then
            'creates table for incoming info
            ' Dim table As New DataTable()
            'parses the csv file
            Using parser As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedFileName)
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
                    tableOfCSV.Columns.Add(header)
                    column += 1
                Next
                If column > 2 Then



                    ' Read the data rows and add them to the table
                    While Not parser.EndOfData
                        Dim fields As String() = parser.ReadFields()
                        tableOfCSV.Rows.Add(fields)
                        'p.dateAndTime = fields(0)
                        'p.wattage = fields(2)

                    End While

                    'date time pickers are enabled
                    'dtpBeginning.Enabled = True
                    'dtpEnd.Enabled = True

                    'length of table
                    'Dim rowCount As Integer = tableOfCSV.Rows.Count
                    Dim rowCountInForEach As Integer = 0

                    'if the table fits the template(is correct)
                    If tableOfCSV.Columns(0).ColumnName = "Algus" And tableOfCSV.Columns(2).ColumnName = "Kogus (kWh)" _
                        And tableOfCSV.Columns(1).ColumnName = "Lõpp" And tableOfCSV.Columns(3).ColumnName = "Börsihind (EUR / MWh)" Then

                        'For i As Integer = 0 To 9
                        For Each row As DataRow In tableOfCSV.Rows
                            'if there are too many rows of data take only the first 3 days
                            If rowCountInForEach = (24 * 3) + 1 Then
                                Exit For
                            End If
                            'Dim row As DataRow = table.Rows(i)

                            'if current row is the first row then set minDate for  dtpBeginning
                            If rowCountInForEach = 0 Then
                                'dtpBeginning.MinDate = DateTime.Parse(row("Algus"))
                                'dtpBeginning.Value = DateTime.Parse(row("Algus"))
                                'MsgBox("minDate for  dtpBeginning" & row("Algus"))
                            End If
                            'if current row is the second row in the table then set minDate for  dtpEnd
                            If rowCountInForEach = 1 Then
                                'dtpEnd.MinDate = DateTime.Parse(row("Lõpp"))
                                'dtpEnd.Value = DateTime.Parse(row("Lõpp"))
                                'MsgBox("minDate for  dtpEnd" & row("Lõpp"))
                            End If
                            'if current row count is the row BEFORE the last row then set maxDate for dtpBeginning

                            If rowCountInForEach = rowCount - 2 Then 'has to be -2 because rowCountInForEach starts off as 0
                                'dtpBeginning.MaxDate = DateTime.Parse(row("Algus"))
                                'MsgBox("maxDate for dtpBeginning" & row("Algus"))
                            End If
                            'if current row is the last row in the table then set maxDate for dtpEnd
                            If row Is tableOfCSV.Rows(rowCount - 1) Then
                                'dtpEnd.MaxDate = DateTime.Parse(row("Lõpp"))
                                'MsgBox("maxDate for dtpEnd" & row("Lõpp"))
                            End If


                            '
                            rowCountInForEach += 1
                        Next
                        'sets the minimum and max dates that can be selected
                        'dtpBeginning.Value = dtpBeginning.MinDate
                        'dtpEnd.Value = dtpEnd.MaxDate

                        'MOCK CALCULATOR BECAUSE PAIN :'(
                        'this is only a concept not the final product, look away
                        Dim sumKWh As Double
                        Dim sumPrice As Double
                        Dim divider As Integer = 0

                        For Each row As DataRow In tableOfCSV.Rows
                            'ADD UP ALL THE QUANTITY(kWh)
                            sumKWh += Double.Parse(row("Kogus (kWh)"))


                            'ADD UP ALL THE PRICES
                            sumPrice += Double.Parse(row("Börsihind (EUR / MWh)"))
                            ' tbDebug.AppendText(Environment.NewLine & sumKWh & sumPrice)
                            'tbDebug.Text = sumKWh & sumPrice
                            divider += 1
                        Next
                        'While row("Algus").ToString() = 
                        'Median price of kWh for the WHOLE CSV FILE!!!!! WORK IN PROGRESS
                        sumPrice = sumPrice / divider
                        'sumPrice now in cents per kWh
                        sumPrice = (sumPrice / 1000) * 100
                        'tbDebug.AppendText(Environment.NewLine & "Kokku: " & sumKWh & " kWh ja keskmine kWh hind " & sumPrice & " senti/kWh.")




                    Else
                        'MessageBox.Show("VALE FORMAAT!")
                    End If


                Else
                    'MessageBox.Show("VALE FORMAAT!")

                End If
            End Using
            'End If
            'TABLE

        End If

    End Function

    Public Function ImportCSVFile() As Object Implements ICSVFileImport.ImportCSVFile
        Throw New NotImplementedException()
    End Function
End Class
