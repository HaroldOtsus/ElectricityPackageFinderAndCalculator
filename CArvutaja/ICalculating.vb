Public Interface ICalculating
    Function applianceConsumption(ByVal kodumasina_tarbmimine As String, ByVal kasutusaeg As String, ByVal tunnihind As String) As (consumption As String, aproxPrice As String)
    Function add20Percent(ByRef kuuTasu As String)
End Interface
