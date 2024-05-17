Imports MySql.Data.MySqlClient
Public Class absen
    Sub absen1()
        CMD = New MySqlCommand("Select * from absen where nama ='" & id_user & "' and tanggal = '" & DateTimePicker1.Text & "'  ", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            RD.Close()
            CMD = New MySqlCommand("insert into absen values ('" & id_user & "','" & user & "', '" & DateTimePicker1.Text & "')", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Absen Berhasil , Selamat bekerja ")
            Me.Hide()
        Else
            RD.Close()
            MsgBox("Anda Sudah Absen")
        End If
    End Sub
    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        absen1()
    End Sub
    Private Sub absen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Me.Hide()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker1.Enabled = False
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd MMMM yyyy | hh:mm tt" ' "tt" untuk menampilkan AM/PM
    End Sub
End Class