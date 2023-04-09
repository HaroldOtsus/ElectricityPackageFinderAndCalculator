Public Interface APIInterface

    'Function returns 24 strings in an array
    '1 string contains one price at that hour, based on the order of strings
    'First string is always the earliest price and last string is the latest price
    Function GetDataFromEleringAPI() As String()

End Interface
