﻿Public Interface ICalculating
    Function applianceConsumption(ByVal kodumasina_tarbmimine As String, ByVal kasutusaeg As String, ByVal tunnihind As String) As (consumption As String, aproxPrice As String)
End Interface
