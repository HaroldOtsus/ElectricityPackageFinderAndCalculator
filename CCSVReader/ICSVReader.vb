' FAILINIMI: ICSVReader.vb
' AUTOR: Karl Paabut
' LOODUD: 29.04.2023
' MUUDETUD: 06.05.2023
' KIRJELDUS: Komponent loeb sisse CSV faili
' Eeldused: Tingimused, mis peavad edukaks käivituseks täidetud olema, ReadCSV() sisendiks peab olema korrektne filePath 
' Sisendid: filePath, see täpsustab ära faili ja selle asukoha mida parse-ima hakatakse.
' Tulem: TableOfCSV täidetakse CSV faili sisuga.
Public Interface ICSVReader

        Function ReadCSV(selectedFile As String) As DataTable

End Interface
