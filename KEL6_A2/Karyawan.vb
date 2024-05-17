Imports MySql.Data.MySqlClient


Public Class Karyawan

    Sub tampil()
        CMD = New MySqlCommand("select * from karyawan where id = '" & id_user & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            nama.Text = RD("nama")
            tanggal.Text = RD("tanggal_lahir")
            jenis.Text = RD("jenis")
            jabatan.Text = RD("jabatan")
            gaji.Text = RD("gaji")
            idK.Text = RD("id")
            RD.Close()
        End If
    End Sub
    Private Sub Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
    End Sub
    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Hide()
    End Sub
    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Try
            If txtPwBaru.Text = "" Then
                MsgBox("Password baru tidak boleh kosong.")
            ElseIf txtPwBaru.Text.Length < 5 Then
                MsgBox("Password baru harus memiliki setidaknya 5 karakter.")
            Else
                Dim CMD As New MySqlCommand("SELECT password FROM akun WHERE username = @username", CONN)
                CMD.Parameters.AddWithValue("@username", id_user)
                Dim reader As MySqlDataReader = CMD.ExecuteReader()
                If reader.Read() Then
                    Dim currentPassword As String = reader("password").ToString()
                    reader.Close()
                    If txtPwLama.Text = currentPassword Then
                        CMD = New MySqlCommand("UPDATE akun SET password = @password WHERE username = @username", CONN)
                        CMD.Parameters.AddWithValue("@password", txtPwBaru.Text)
                        CMD.Parameters.AddWithValue("@username", id_user)
                        CMD.ExecuteNonQuery()
                        MsgBox("Password berhasil direset.")
                        txtPwBaru.Text = ""
                        txtPwLama.Text = ""
                        tampil()
                    Else
                        MsgBox("Password lama salah.")
                    End If
                Else
                    reader.Close()
                    MsgBox("Pengguna tidak ditemukan.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat mereset password: " & ex.Message)
        End Try
    End Sub
End Class
