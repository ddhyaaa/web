Imports MySql.Data.MySqlClient

Public Class admin
    Dim connString As String = "server=localhost;userid=root;password=;database=datakaryawan;Convert Zero Datetime=True"
    Dim query As String = "INSERT INTO karyawan (id, nama, tanggal_lahir, jenis, jabatan, gaji, gambar) VALUES (@id, @nama, @tanggal_lahir, @jenis, @jabatan, @gaji, @gambar)"
    Sub Kosong()
        nama.Clear()
        password.Clear()
        TextBoxImagePath.Clear()
        PictureBox1.Image = Nothing
        Label2.Focus()
    End Sub
    Function cek_input() As Boolean
        If Not IsNumeric(id.Text) Then
            MsgBox("ID harus berupa angka.")
            Return False
        ElseIf nama.Text = "" OrElse Not IsAlpha(nama.Text) Then
            MsgBox("Nama harus diisi dengan huruf.")
            Return False
        ElseIf password.Text.Length < 5 Then
            MsgBox("Password harus memiliki minimal 5 karakter.")
            Return False
        ElseIf jabatan.Text = "" Then
            MsgBox("Jabatan masih kosong.")
            Return False
        ElseIf TextBoxImagePath.Text = "" Then
            MsgBox("Anda harus mengupload gambar.")
            Return False
        Else
            Return True
        End If
    End Function
    Function IsAlpha(ByVal str As String) As Boolean
        For Each c As Char In str
            If Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Function cek_rb() As Boolean
        If RB_laki.Checked Then
            jenis = RB_laki.Text
            Return True
        ElseIf RB_Perempuan.Checked Then
            jenis = RB_Perempuan.Text
            Return True
        End If
        MsgBox("Jenis kelamin masih kosong.")
        Return False
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cek_input() Then
            If cek_rb() Then
                CMD = New MySqlCommand("SELECT * FROM karyawan WHERE id = @id", CONN)
                CMD.Parameters.AddWithValue("@id", id.Text)
                RD = CMD.ExecuteReader
                RD.Read()
                If Not RD.HasRows Then
                    RD.Close()
                    Dim imagePath As String = TextBoxImagePath.Text
                    CMD = New MySqlCommand(query, CONN)
                    CMD.Parameters.AddWithValue("@id", id.Text)
                    CMD.Parameters.AddWithValue("@nama", nama.Text)
                    CMD.Parameters.AddWithValue("@tanggal_lahir", DateTimePicker1.Text)
                    CMD.Parameters.AddWithValue("@jenis", jenis)
                    CMD.Parameters.AddWithValue("@jabatan", jabatan.Text)
                    CMD.Parameters.AddWithValue("@gaji", gaji.Text)
                    CMD.Parameters.AddWithValue("@gambar", imagePath)
                    CMD.ExecuteNonQuery()
                    CMD = New MySqlCommand("INSERT INTO akun VALUES (@id, @password)", CONN)
                    CMD.Parameters.AddWithValue("@id", id.Text)
                    CMD.Parameters.AddWithValue("@password", password.Text)
                    CMD.ExecuteNonQuery()
                    Kosong()
                    MsgBox("Simpan Data Sukses!")
                    Label1.Focus()
                Else
                    RD.Close()
                    MsgBox("Data Tersebut Sudah Ada.")
                End If
            End If
        End If
    End Sub

    Private Sub btn_lihat_Click(sender As Object, e As EventArgs) Handles btn_lihat.Click
        lihat.Show()
    End Sub

    Private Sub btn_out_Click(sender As Object, e As EventArgs) Handles btn_out.Click
        Me.Hide()
    End Sub

    Private Sub gaji_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gaji.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*"
        openFileDialog.InitialDirectory = "D:\"
        openFileDialog.Title = "Select an image file"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim selectedImagePath As String = openFileDialog.FileName
                PictureBox1.Image = Image.FromFile(selectedImagePath)
                TextBoxImagePath.Text = selectedImagePath
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private TextBoxImagePath As New TextBox()

    Public Sub New()
        InitializeComponent()
    End Sub
End Class
