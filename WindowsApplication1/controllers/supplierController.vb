Public Class supplierController
    Public Function LoadItems() As DataTable
        Return supplierModel.getAll()
    End Function

    Public Function GetItemById(id As Integer) As supplierModel
        Return supplierModel.GetItemById(id)
    End Function

    Public Function Create(item As supplierModel) As Boolean
        If Not ValidateItem(item) Then Return False
        Return item.CreateItem(item)
    End Function

    ' UPDATE
    Public Function Update(item As supplierModel) As Boolean
        If Not ValidateItem(item) Then Return False
        Return item.UpdateItem(item)
    End Function

    ' DELETE
    Public Function Delete(id As Integer) As Boolean
        Return New supplierModel().DeleteItem(id)
    End Function
    Private Function ValidateItem(item As supplierModel) As Boolean
        If String.IsNullOrWhiteSpace(item.supplierID) Then
            MessageBox.Show("Supplier ID tidak boleh kosong")
            Return False
        End If

        If String.IsNullOrWhiteSpace(item.supplierName) Then
            MessageBox.Show("Nama Supllier tidak boleh kosong")
            Return False
        End If

        Return True
    End Function


End Class
