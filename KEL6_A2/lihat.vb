Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing
Imports System.IO

Public Class lihat
    Dim connString As String = "server=localhost;userid=root;password=;database=datakaryawan;Convert Zero Datetime=True"
    Dim query As String = "SELECT * FROM karyawan"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        LoadDataIntoGridView()
        SetDataGridViewSize()
    End Sub
    Private Sub LoadDataIntoGridView(Optional searchText As String = "")
        Try
            Using conn As New MySqlConnection(connString)
                Dim finalQuery As String = query
                If Not String.IsNullOrEmpty(searchText) Then
                    finalQuery &= " WHERE nama LIKE @searchText"
                End If
                Using cmd As New MySqlCommand(finalQuery, conn)
                    If Not String.IsNullOrEmpty(searchText) Then
                        cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                    End If
                    conn.Open()
                    Dim dataTable As New DataTable()
                    dataTable.Load(cmd.ExecuteReader())
                    DataGridView1.Columns.Clear()
                    DataGridView1.DataSource = Nothing
                    DataGridView1.DataSource = dataTable
                    If dataTable.Columns.Contains("gambar") Then
                        If DataGridView1.Columns.Contains("gambar") Then
                            DataGridView1.Columns("gambar").Visible = False
                        End If
                        Dim imageColumn As New DataGridViewImageColumn()
                        imageColumn.Name = "ImageColumn"
                        imageColumn.HeaderText = "Gambar"
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
                        DataGridView1.Columns.Add(imageColumn)
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            Dim imagePath As String = TryCast(row.Cells("gambar").Value, String)
                            If Not String.IsNullOrEmpty(imagePath) Then
                                If File.Exists(imagePath) Then
                                    Dim image As Image = Image.FromFile(imagePath)
                                    row.Cells("ImageColumn").Value = image
                                Else
                                    MessageBox.Show("File gambar tidak ditemukan: " & imagePath)
                                End If
                            End If
                        Next
                    Else
                        MessageBox.Show("Kolom 'gambar' tidak ditemukan dalam data.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SetDataGridViewSize()
        DataGridView1.Columns("id").Width = 30
        DataGridView1.Columns("nama").Width = 200
        DataGridView1.Columns("tanggal_lahir").Width = 200
        DataGridView1.Columns("jenis").Width = 90
        DataGridView1.Columns("jabatan").Width = 110
        DataGridView1.Columns("gaji").Width = 90
        DataGridView1.Columns("ImageColumn").Width = 104
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 50
        Next
        DataGridView1.Width = DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DataGridView1.RowHeadersWidth
        Dim totalRowHeight As Integer = DataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DataGridView1.ColumnHeadersHeight
        DataGridView1.Height = totalRowHeight
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim nama As String = selectedRow.Cells("nama").Value.ToString()
                Dim id As String = selectedRow.Cells("id").Value.ToString()
                Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete record with nama: " & nama & "?", "Confirmation", MessageBoxButtons.YesNo)

                If confirmation = DialogResult.Yes Then
                    DeleteRecord(id)
                    LoadDataIntoGridView()
                    MessageBox.Show("DATA TERHAPUS.")
                    SetDataGridViewSize()
                End If
            Else
                MessageBox.Show("PILIH BARIS YANG INGIN DIHAPUS.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteRecord(id As String)
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand("DELETE FROM karyawan WHERE id = @id", conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        LoadDataIntoGridView(searchText)
        SetDataGridViewSize()
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim idData As String = selectedRow.Cells("id").Value.ToString()
            Dim form3 As New update(idData)
            If form3.ShowDialog() = DialogResult.OK Then
                LoadDataIntoGridView()
                SetDataGridViewSize()
            End If
            LoadDataIntoGridView() '
            SetDataGridViewSize()
        Else
            MessageBox.Show("PILIH BARIS YANG INGIN DIUPDATE.")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
