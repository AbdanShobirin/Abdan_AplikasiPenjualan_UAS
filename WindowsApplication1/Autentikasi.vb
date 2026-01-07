Imports MySql.Data.MySqlClient
' Jika kamu install BCrypt.Net-Next, gunakan Verify/Hash dari namespace ini:
' Install-Package BCrypt.Net-Next
' Imports BCrypt.Net    ' tidak wajib import (bisa panggil dengan nama penuh)

Public Class Autentikasi
    Public username As String
    Public password As String
    Public isLogin As Boolean

    ' Opsional: simpan info user setelah login
    Public userId As Integer
    Public fullname As String

    ' Sesuaikan connection string ini jika berbeda
    Private connStr As String = "server=localhost;port=3306;database=dbpenjualan;uid=root;pwd=;"


    Public Sub Login()
        isLogin = False
        userId = 0
        fullname = String.Empty

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                Dim sql As String = "SELECT id, username, password_hash, password, fullname FROM users WHERE username = @username LIMIT 1;"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@username", username)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim storedHash As String = ""
                            Dim storedPlain As String = ""

                            If Not reader.IsDBNull(reader.GetOrdinal("password_hash")) Then
                                storedHash = reader.GetString("password_hash")
                            End If
                            If Not reader.IsDBNull(reader.GetOrdinal("password")) Then
                                storedPlain = reader.GetString("password")
                            End If

                            ' Jika ada hash, verifikasi pakai BCrypt
                            If Not String.IsNullOrEmpty(storedHash) Then
                                Try
                                    If BCrypt.Net.BCrypt.Verify(password, storedHash) Then
                                        isLogin = True
                                    End If
                                Catch ex As Exception
                                    ' jika BCrypt.Verify gagal karena format hash, fallback ke cek plain
                                    isLogin = False
                                End Try
                            Else
                                ' Fallback: cek plain text password (tidak aman)
                                If Not String.IsNullOrEmpty(storedPlain) Then
                                    If password = storedPlain Then
                                        isLogin = True
                                    End If
                                End If

                            End If

                            If isLogin Then
                                If Not reader.IsDBNull(reader.GetOrdinal("id")) Then
                                    userId = reader.GetInt32("id")
                                End If
                                If Not reader.IsDBNull(reader.GetOrdinal("fullname")) Then
                                    fullname = reader.GetString("fullname")
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Untuk debugging tampilkan pesan; di produksi log saja
            MessageBox.Show("Error autentikasi: " & ex.ToString())
        End Try
    End Sub

    ' Optional: helper untuk membuat hash password (gunakan sekali saat membuat user baru)
    Public Function HashPassword(ByVal plainPassword As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(plainPassword)
    End Function

End Class

