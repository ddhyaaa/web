Imports MySql.Data.MySqlClient
Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RA As MySqlDataReader
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Public jenis As String
    Public gaji As String
    Public jabatan As String
    Public id_user As String
    Public idData As String
    Public gambar As String
    Public user As String
    Public tanggal As DateTime

    Sub koneksi()
        Try
            Dim STR As String =
            "server=localhost;userid=root;password=;database=datakaryawan;Convert Zero Datetime=True"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
