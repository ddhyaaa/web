Public Class Menu_Admin

    Private Sub TambahDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataToolStripMenuItem.Click
        admin.Show()
    End Sub

    Private Sub DaftarKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarKaryawanToolStripMenuItem.Click
        lihat.Show()
    End Sub

    Private Sub DataAbsensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAbsensiToolStripMenuItem.Click
        lihat_absen.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataToolStripMenuItem.Click, DaftarKaryawanToolStripMenuItem.Click, DataAbsensiToolStripMenuItem.Click, KeluarToolStripMenuItem.Click
        Dim clickedItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)

        If clickedItem IsNot Nothing Then
            For Each item As ToolStripMenuItem In MenuStrip1.Items
                item.BackColor = Color.Indigo
                For Each subItem As ToolStripMenuItem In item.DropDownItems
                    subItem.BackColor = Color.Indigo
                Next
            Next
            clickedItem.BackColor = Color.FromArgb(229, 204, 255)
        End If
    End Sub
    Private Sub ToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles TambahDataToolStripMenuItem.DropDownOpened, DaftarKaryawanToolStripMenuItem.DropDownOpened, DataAbsensiToolStripMenuItem.DropDownOpened, KeluarToolStripMenuItem.DropDownOpened
        Dim clickedItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clickedItem IsNot Nothing Then
            For Each subItem As ToolStripItem In clickedItem.DropDownItems
                If TypeOf subItem Is ToolStripMenuItem Then
                    subItem.BackColor = Color.FromArgb(229, 204, 255)
                End If
            Next
        End If
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        DataKaryawanToolStripMenuItem.ForeColor = Color.Indigo
        For Each subItem As ToolStripItem In DataKaryawanToolStripMenuItem.DropDownItems
            If TypeOf subItem Is ToolStripMenuItem Then
                subItem.BackColor = Color.Indigo
                subItem.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub AbsensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.Click
        AbsensiToolStripMenuItem.ForeColor = Color.Indigo
        For Each subItem As ToolStripItem In AbsensiToolStripMenuItem.DropDownItems
            If TypeOf subItem Is ToolStripMenuItem Then
                subItem.BackColor = Color.Indigo
                subItem.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.DropDownClosed
        DataKaryawanToolStripMenuItem.BackColor = Color.Indigo
        DataKaryawanToolStripMenuItem.ForeColor = Color.White
        For Each subItem As ToolStripItem In DataKaryawanToolStripMenuItem.DropDownItems
            If TypeOf subItem Is ToolStripMenuItem Then
                subItem.BackColor = Color.Indigo
                subItem.ForeColor = Color.White
            End If
        Next
    End Sub
    Private Sub AbsensiToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.DropDownClosed
        AbsensiToolStripMenuItem.BackColor = Color.Indigo
        AbsensiToolStripMenuItem.ForeColor = Color.White
        For Each subItem As ToolStripItem In AbsensiToolStripMenuItem.DropDownItems
            If TypeOf subItem Is ToolStripMenuItem Then
                subItem.BackColor = Color.Indigo
                subItem.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.MouseEnter
        DataKaryawanToolStripMenuItem.ShowDropDown()
        DataKaryawanToolStripMenuItem.ForeColor = Color.Indigo
    End Sub

    Private Sub AbsensiToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.MouseEnter
        AbsensiToolStripMenuItem.ShowDropDown()
        AbsensiToolStripMenuItem.ForeColor = Color.Indigo
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.MouseLeave
        If Not DataKaryawanToolStripMenuItem.DropDown.Visible Then
            DataKaryawanToolStripMenuItem.ForeColor = Color.White
        End If
    End Sub

    Private Sub AbsensiToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.MouseLeave
        If Not AbsensiToolStripMenuItem.DropDown.Visible Then
            AbsensiToolStripMenuItem.ForeColor = Color.White
        End If
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.DropDownOpened
        DataKaryawanToolStripMenuItem.ForeColor = Color.Indigo
        For Each subItem As ToolStripItem In DataKaryawanToolStripMenuItem.DropDownItems
            If TypeOf subItem Is ToolStripMenuItem Then
                subItem.BackColor = Color.Indigo
                subItem.ForeColor = Color.White
            End If
        Next
    End Sub
    Private Sub AbsensiToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.DropDownOpened
        AbsensiToolStripMenuItem.ForeColor = Color.Indigo
        For Each subItem As ToolStripItem In AbsensiToolStripMenuItem.DropDownItems
            If TypeOf subItem Is ToolStripMenuItem Then
                subItem.BackColor = Color.Indigo
                subItem.ForeColor = Color.White
            End If
        Next
    End Sub
    Private Sub Menu_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class