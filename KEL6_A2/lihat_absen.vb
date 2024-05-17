Imports MySql.Data.MySqlClient
Public Class lihat_absen
    Sub aturGrid()
        DataGridView1.Columns(0).Width = 50 ' Kolom ID
        DataGridView1.Columns(1).Width = 400 ' Kolom Nama Karyawan
        DataGridView1.Columns(2).Width = 400 ' Kolom Tanggal Absen
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Nama Karyawan"
        DataGridView1.Columns(2).HeaderText = "Tanggal Absen"
    End Sub
    Sub tampilJenis()
        DataGridView1.Rows.Clear()
        CMD = New MySqlCommand("SELECT absen.idK, karyawan.nama, absen.tanggal FROM absen JOIN karyawan ON karyawan.id = absen.idK ORDER BY absen.tanggal", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = RD("idK")
            row.Cells(1).Value = RD("nama")
            row.Cells(2).Value = RD("tanggal")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilJenis()
        aturGrid()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text <> Nothing Then
            CMD = New MySqlCommand("SELECT absen.idK, karyawan.nama, absen.tanggal FROM absen JOIN karyawan ON karyawan.id = absen.idK WHERE karyawan.nama LIKE '%" & txtSearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DataGridView1.Rows.Clear()
                While RD.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)
                    row.Cells(0).Value = RD("idK")
                    row.Cells(1).Value = RD("nama")
                    row.Cells(2).Value = RD("tanggal")
                    DataGridView1.Rows.Add(row)
                End While
            Else
                MsgBox("Data tidak ditemukan")
            End If
            RD.Close()
        Else
            tampilJenis()
        End If
    End Sub
End Class
