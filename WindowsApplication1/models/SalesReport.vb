Imports MySql.Data.MySqlClient

Public Class SalesReport
    Public Shared Function getAll() As DataTable
        Dim dt As New DataTable

        Dim query As String = "
            SELECT 
                S.idTrans AS NOTA,
                S.saleDate AS TGL_NOTA,
                SD.itemID AS KODE_BRG,
                I.itemDesc AS NAMA_BRG,
                SD.qtySale AS QTY,
                SD.price AS HARGA,
                I.unit AS UNIT,
                (SD.qtySale * SD.price) AS SUBTOTAL
            FROM sale S
            INNER JOIN saledetail SD ON S.idTrans = SD.idSale
            INNER JOIN items I ON SD.itemID = I.id
            ORDER BY S.idTrans
        "

        Using conn = Koneksi.OpenConnection()
            Using cmd As New MySqlCommand(query, conn)
                Using rd = cmd.ExecuteReader()
                    dt.Load(rd)
                End Using
            End Using
        End Using

        MsgBox("Jumlah baris data: " & dt.Rows.Count)
        Return dt
    End Function
End Class