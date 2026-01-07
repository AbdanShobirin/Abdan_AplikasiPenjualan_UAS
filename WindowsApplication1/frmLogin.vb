Public Class frmLogin
    Dim oAuth As New Autentikasi()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        With oAuth
            .username = txtUsername.Text
            .password = txtPassword.Text
            .Login()
            If .isLogin Then
                MessageBox.Show("Selamat datang, " & .fullname)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("Gagal login")
            End If
        End With


    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
