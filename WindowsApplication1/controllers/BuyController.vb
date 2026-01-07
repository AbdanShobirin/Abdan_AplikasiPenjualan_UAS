Public Class buyController
    Public Function SaveNew(buy As buyModel) As Boolean
        Return buyModel.Insert(buy)
    End Function

    Public Function generateCode() As String
        Return buyModel.GenerateKodeTransaksi()
    End Function

End Class
