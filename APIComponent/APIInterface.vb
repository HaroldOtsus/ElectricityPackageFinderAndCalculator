' FAILINIMI: APIInterface.vb
' AUTOR: Harold Otsus
' LOODUD: 22.03.2023
' MUUDETUD: 06.05.2023
'
' KIRJELDUS: Liides APIComponent'i jaoks.
' Eeldused: On olemas APIComponent.
' Sisendid: Puuduvad.
' Tulem: Info Eleringi veebilehelt.
Public Interface APIInterface

    'Function returns 2x24 string arrays
    'First array of strings contains one pricees, based on the order of strings
    'Second array of strings contains timestamps, based on the order of strings
    'First string is always the earliest price/timestamp and last string is the latest price/timestamp
    Function GetDataFromEleringAPI() As (String(), String())
    'Function returns 2x24 string arrays
    'and takes in 2 strings that have to be in date format "YYYY-MM-DD HH:mm:ss"
    'First array of strings contains one pricees, based on the order of strings
    'Second array of strings contains timestamps, based on the order of strings
    'First string is always the earliest price/timestamp and last string is the latest price/timestamp
    Function GetDataFromEleringAPIWithDates(ByVal strStartDate As String, ByVal strEndDate As String) As (String(), String())

End Interface
