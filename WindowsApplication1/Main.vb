Imports MySql.Data.MySqlClient
Imports System.IO

Module Main
    Sub Main()
        'Cek apakah file setting.ini sudah ada
        If Not File.Exists(GlobalModule.SettingFilePath) Then
            File.WriteAllText(GlobalModule.SettingFilePath, "")
            Using fset As New FormSetting()
                fset.ShowDialog()
            End Using
        End If

        'Baca setting dari file
        Dim server As String = GlobalModule.ReadSetting("server")
        Dim user As String = GlobalModule.ReadSetting("user")
        Dim pass As String = GlobalModule.ReadSetting("password")
        Dim db As String = GlobalModule.ReadSetting("database")

        'Bentuk string koneksi
        GlobalModule.ConnStr = $"server={server};uid={user};pwd={pass};database={db};"

        'Uji koneksi
        Try
            GlobalModule.Conn = New MySqlConnection(GlobalModule.ConnStr)
            GlobalModule.Conn.Open()
            MessageBox.Show("Koneksi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalModule.Conn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal koneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Kalau gagal, buka form setting ulang
            Using fset As New FormSetting()
                fset.ShowDialog()
            End Using
        End Try

        'Jika koneksi sukses, lanjut ke form login
        Dim oFrmLogin As New frmLogin()
        If oFrmLogin.ShowDialog() = DialogResult.OK Then
            Application.Run(New frmUtama())
        End If
    End Sub
End Module
