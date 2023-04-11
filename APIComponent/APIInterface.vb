Public Interface APIInterface

    'Function returns 24 strings in an array
    '1 string contains one price at that hour, based on the order of strings
    'First string is always the earliest price and last string is the latest price
    Function GetDataFromEleringAPI() As String()
    'Function returns 24 strings in an array and takes in 2 strings that have to be in date format "YYYY-MM-DD"
    '1 string contains one price at that hour, based on the order of strings
    'First string is always the earliest price and last string is the latest price
    Function GetDataFromEleringAPIWithDates(ByVal strStartDate As String, ByVal strEndDate As String) As String()

End Interface
