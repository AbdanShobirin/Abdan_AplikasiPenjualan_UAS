Imports System.IO

Public Class FormSetting
    Private Sub FormSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(GlobalModule.SettingFilePath) Then
            txtServer.Text = GlobalModule.ReadSetting("server")
            txtUser.Text = GlobalModule.ReadSetting("user")
            txtPass.Text = GlobalModule.ReadSetting("password")
            txtDB.Text = GlobalModule.ReadSetting("database")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        GlobalModule.WriteSetting("server", txtServer.Text)
        GlobalModule.WriteSetting("user", txtUser.Text)
        GlobalModule.WriteSetting("password", txtPass.Text)
        GlobalModule.WriteSetting("database", txtDB.Text)

        MessageBox.Show("Setting disimpan. Silakan restart aplikasi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
