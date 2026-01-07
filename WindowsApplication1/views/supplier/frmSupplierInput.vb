Public Class frmSupplierInput

    Dim controller As New supplierController
    Dim categoryController As New CategoryController
    Dim editedID As Integer = -1

    Sub New()
        InitializeComponent()
        txtSupplierId.Text = New supplierModel().GenerateItemCode()
        txtSupplierId.Enabled = False
    End Sub
    Sub New(item As supplierModel)
        InitializeComponent()

        With item
            editedID = .id
            txtSupplierId.Text = .supplierID
            txtSupplierName.Text = .supplierName
            txtSupplierUser.Text = .supplierUser
            txtSupplierAlamat.Text = .supplierAlamat
        End With

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim item As New supplierModel With {
        .supplierID = txtSupplierId.Text,
        .supplierName = txtSupplierName.Text,
        .supplierUser = txtSupplierUser.Text,
        .supplierAlamat = txtSupplierAlamat.Text
       }

        If editedID = -1 Then
            controller.Create(item)
        Else
            item.id = editedID
            controller.Update(item)
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtSupplierId_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierId.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub frmSupplierInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSupplierName_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierName.TextChanged

    End Sub

    Private Sub txtSupplierUser_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierUser.TextChanged

    End Sub

    Private Sub txtSupplierAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierAlamat.TextChanged

    End Sub
End Class