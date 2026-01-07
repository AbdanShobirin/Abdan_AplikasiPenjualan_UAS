Imports MySql.Data.MySqlClient
Imports System.IO

Module GlobalModule
    Public SettingFilePath As String = Application.StartupPath & "\setting.ini"
    Public ConnStr As String
    Public Conn As MySqlConnection

    'Baca setting dari file
    Public Function ReadSetting(key As String) As String
        If Not File.Exists(SettingFilePath) Then Return ""
        For Each line As String In File.ReadAllLines(SettingFilePath)
            If line.StartsWith(key & "=") Then
                Return line.Substring(key.Length + 1)
            End If
        Next
        Return ""
    End Function

    'Tulis setting ke file
    Public Sub WriteSetting(key As String, value As String)
        Dim lines As New List(Of String)
        If File.Exists(SettingFilePath) Then
            lines = File.ReadAllLines(SettingFilePath).ToList()
        End If
        Dim updated As Boolean = False
        For i As Integer = 0 To lines.Count - 1
            If lines(i).StartsWith(key & "=") Then
                lines(i) = key & "=" & value
                updated = True
                Exit For
            End If
        Next
        If Not updated Then lines.Add(key & "=" & value)
        File.WriteAllLines(SettingFilePath, lines)
    End Sub
End Module
