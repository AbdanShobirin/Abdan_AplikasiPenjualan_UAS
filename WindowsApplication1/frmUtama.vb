Public Class frmUtama

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem.Click
        Dim frm As New frmListItem

        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Dim frm As New frmSale

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        Dim frm As New FormSalesReport

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMasterToolStripMenuItem.Click

    End Sub

    Private Sub SupplierToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim frm As New frmListSupplier

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        Dim frm As New frmBuy

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem1.Click
        Dim frm As New FormBuyReport

        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class