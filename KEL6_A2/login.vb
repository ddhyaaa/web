Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class login
    Private Sub lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click
        Try
            If username.Text = "a" And password.Text = "a" Then
                BukaFormAdmin()
            Else
                CMD = New MySqlCommand("Select * from akun where username ='" & username.Text & "' and password ='" & password.Text & "'", CONN)
                RA = CMD.ExecuteReader()
                RA.Read()
                If RA.HasRows Then
                    RA.Close()
                    CMD = New MySqlCommand("select * from karyawan where id = '" & username.Text & "'", CONN)
                    RD = CMD.ExecuteReader()
                    RD.Read()
                    If RD.HasRows Then
                        id_user = RD("id")
                        user = RD("nama")
                        tanggal = RD("tanggal_lahir")
                        jenis = RD("jenis")
                        jabatan = RD("jabatan")
                        gambar = RD("gambar")
                        RD.Close()
                        BukaFormKaryawan()
                    Else
                        MsgBox("Username Tidak Terdaftar")
                    End If
                Else
                    RA.Close()
                    MsgBox("Login Gagal. Username atau Password Salah.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
    Private Sub BukaFormAdmin()
        If Application.OpenForms().OfType(Of Menu_Admin).Any() Then
            MsgBox("Form Admin sudah terbuka.")
        Else
            Dim formAdmin As New Menu_Admin()
            formAdmin.Show()
        End If
    End Sub
    Private Sub BukaFormKaryawan()
        If Application.OpenForms().OfType(Of Menu_Karyawan).Any() Then
            MsgBox("Form Karyawan sudah terbuka.")
        Else
            Dim formKaryawan As New Menu_Karyawan()
            formKaryawan.Show()
        End If
    End Sub
End Class
