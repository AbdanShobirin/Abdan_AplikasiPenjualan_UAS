Imports MySql.Data.MySqlClient

Public Class supplierModel
    Public Property id As Integer
    Public Property supplierID As String
    Public Property supplierName As String
    Public Property supplierUser As String
    Public Property supplierAlamat As String
    Public Shared Function getAll() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT * FROM supplier"

        Using conn = Koneksi.OpenConnection()
            Using cmd As New MySqlCommand(query, conn)
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using
        Return dt

    End Function
    Public Shared Function GetItemById(id As Integer) As supplierModel
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM supplier WHERE id=@id"

        Using conn = Koneksi.OpenConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using

        If dt.Rows.Count = 0 Then Return Nothing

        Dim row = dt.Rows(0)

        Return New supplierModel With {
           .id = row("id"),
           .supplierID = row("supplierID").ToString(),
           .supplierName = row("supplierName").ToString(),
           .supplierUser = row("supplierUser").ToString(),
           .supplierAlamat = row("supplierAlamat").ToString()
        }
    End Function

    ' CREATE
    Public Function CreateItem(item As supplierModel) As Boolean
        Using conn = Koneksi.OpenConnection()
            Dim query = "INSERT INTO supplier (supplierID, supplierName, supplierUser, supplierAlamat) VALUES " &
                "(@supplierID, @supplierName, @supplierUser, @supplierAlamat)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@supplierID", item.supplierID)
                cmd.Parameters.AddWithValue("@supplierName", item.supplierName)
                cmd.Parameters.AddWithValue("@supplierUser", item.supplierUser)
                cmd.Parameters.AddWithValue("@supplierAlamat", item.supplierAlamat)

                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' UPDATE
    Public Function UpdateItem(item As supplierModel) As Boolean
        Using conn = Koneksi.OpenConnection()
            Dim query As String = "UPDATE supplier SET " &
                              "supplierID=@supplierID, " &
                              "supplierName=@supplierName, " &
                              "supplierUser=@supplierUser, " &
                              "supplierAlamat=@supplierAlamat " &
                              "WHERE id=@id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@supplierID", item.supplierID)
                cmd.Parameters.AddWithValue("@supplierName", item.supplierName)
                cmd.Parameters.AddWithValue("@supplierUser", item.supplierUser)
                cmd.Parameters.AddWithValue("@supplierAlamat", item.supplierAlamat)
                cmd.Parameters.AddWithValue("@id", item.id)

                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function


    ' DELETE
    Public Function DeleteItem(id As Integer) As Boolean
        Using conn = Koneksi.OpenConnection()
            Dim query = "DELETE FROM supplier WHERE id=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
    Public Function GenerateItemCode() As String
        Dim newCode As String = "S0001"
        Dim query As String = "SELECT supplierID FROM supplier ORDER BY supplierID DESC LIMIT 1"

        Try
            Using conn = Koneksi.OpenConnection()
                Dim cmd As New MySqlCommand(query, conn)
                Dim lastCode As Object = cmd.ExecuteScalar()

                If lastCode IsNot Nothing AndAlso Not IsDBNull(lastCode) Then
                    Dim numberPart As Integer = CInt(Mid(lastCode.ToString(), 4))

                    numberPart += 1

                    ' Format ulang menjadi Bxxxx
                    newCode = "S" & numberPart.ToString("0000")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return newCode
    End Function


End Class
