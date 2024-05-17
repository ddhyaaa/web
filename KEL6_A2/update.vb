Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing
Imports System.IO

Public Class update
    Dim connString As String = "server=localhost;userid=root;password=;database=datakaryawan;Convert Zero Datetime=True"
    Dim query As String = "UPDATE karyawan SET tanggal_lahir = @tanggal_lahir, jenis = @jenis, jabatan = @jabatan, gaji = @gaji, gambar = @gambar, nama = @nama WHERE id = @id"
    Dim query2 As String = "UPDATE akun SET password = @password WHERE username = @username"
    Private _namaData As String
    Private _gambarPath As String
    Public Sub New(namaData As String)
        InitializeComponent()
        _namaData = namaData
    End Sub
    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand("SELECT * FROM karyawan WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", _namaData)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        id.Text = reader("id").ToString()
                        nama.Text = reader("nama").ToString()
                        gaji.Text = reader("gaji").ToString()
                        jabatan.SelectedItem = reader("jabatan").ToString()
                        _gambarPath = reader("gambar").ToString()
                        Dim jenis As String = reader("jenis").ToString()
                        Select Case jenis
                            Case "Laki-laki"
                                RB_laki.Checked = True
                            Case "Perempuan"
                                RB_Perempuan.Checked = True
                        End Select
                    End If
                    reader.Close()
                End Using
            End Using
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand("SELECT * FROM akun WHERE username = @id", conn)
                    cmd.Parameters.AddWithValue("@id", _namaData)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        password.Text = reader("password").ToString()
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                _gambarPath = openFileDialog.FileName
                Dim selectedImage As Image = Image.FromFile(_gambarPath)
                PictureBox1.Image = selectedImage
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btn_Ubah_Click(sender As Object, e As EventArgs) Handles btn_Ubah.Click
        Try
            CMD = New MySqlCommand("UPDATE akun SET password = @password WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@password", password.Text)
            CMD.Parameters.AddWithValue("@username", id.Text)
            CMD.ExecuteNonQuery()
            Using conn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Dim jenis As String = ""
                    If RB_laki.Checked Then
                        jenis = RB_laki.Text
                    ElseIf RB_Perempuan.Checked Then
                        jenis = RB_Perempuan.Text
                    End If
                    Dim jabatan1 As String = jabatan.SelectedItem.ToString()

                    cmd.Parameters.AddWithValue("@tanggal_lahir", DateTimePicker1.Text)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@jabatan", jabatan1)
                    cmd.Parameters.AddWithValue("@gaji", gaji.Text)
                    cmd.Parameters.AddWithValue("@gambar", _gambarPath)
                    cmd.Parameters.AddWithValue("@nama", nama.Text)
                    cmd.Parameters.AddWithValue("@id", id.Text)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("DATA BERHASIL DI UPDATE")
                        LoadData()
                    Else
                        MessageBox.Show("TIDAK ADA BARIS.")
                    End If
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Me.Hide()
    End Sub
End Class

