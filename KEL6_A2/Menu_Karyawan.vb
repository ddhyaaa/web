Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Menu_Karyawan
    Private Sub LihatProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatProfilToolStripMenuItem.Click
        Karyawan.Show()
    End Sub
    Private Sub CetakKartuIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakKartuIDToolStripMenuItem.Click
        Dim pd As New Printing.PrintDocument
        AddHandler pd.PrintPage, AddressOf pd_PrintPage
        Dim papersize As New Printing.PaperSize("Custom", 500, 300)
        pd.DefaultPageSettings.PaperSize = papersize
        Dim printPreviewDlg As New PrintPreviewDialog()
        printPreviewDlg.Document = pd
        printPreviewDlg.ShowDialog()
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim kartuID As New Bitmap(500, 300)
        Using g As Graphics = Graphics.FromImage(kartuID)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim backgroundBrush As New LinearGradientBrush(New Point(0, 0), New Point(kartuID.Width, kartuID.Height), Color.FromArgb(128, 0, 128), Color.FromArgb(75, 0, 130))
            g.FillRectangle(backgroundBrush, New Rectangle(0, 0, kartuID.Width, kartuID.Height))
            g.DrawRectangle(Pens.White, New Rectangle(0, 0, kartuID.Width - 1, kartuID.Height - 1))
            Dim logo As Image = Image.FromFile("D:\Semester 4\PRAKTIKUM\PROJEK\KEL6_A2_PEMVIS\lonan.png")
            g.DrawImage(logo, New Rectangle(20, 20, 60, 60))
            logo.Dispose()
            Dim fontTitle As New Font("Calibri", 18, FontStyle.Bold)
            Dim fontInfo As New Font("Calibri", 12)
            Dim brushWhite As New SolidBrush(Color.White)
            g.DrawString("Kartu Identitas", fontTitle, brushWhite, 100, 20)
            g.DrawString("lonan Corp", fontTitle, brushWhite, 100, 40)
            g.DrawString("Nomor ID            : " & id_user, fontInfo, brushWhite, 150, 100)
            g.DrawString("Nama                   : " & user, fontInfo, brushWhite, 150, 130)
            g.DrawString("Kelamin               : " & jenis, fontInfo, brushWhite, 150, 160)
            g.DrawString("Tanggal Lahir      : " & tanggal, fontInfo, brushWhite, 150, 190)
            g.DrawString("Jabatan                : " & jabatan, fontInfo, brushWhite, 150, 220)
            If Not String.IsNullOrEmpty(gambar) Then
                Dim originalImage As Image = Image.FromFile(gambar)
                Dim resizedImage As New Bitmap(100, 100)
                Using gr As Graphics = Graphics.FromImage(resizedImage)
                    gr.SmoothingMode = SmoothingMode.AntiAlias
                    gr.DrawImage(originalImage, 0, 0, 100, 100)
                End Using
                originalImage.Dispose()

                Dim photoRect As New Rectangle(20, 100, 100, 100)
                g.DrawImage(resizedImage, photoRect)
                g.DrawRectangle(New Pen(Color.White, 2), photoRect)
                resizedImage.Dispose()
            End If
        End Using
        e.Graphics.DrawImage(kartuID, 0, 0)
    End Sub
    Private Sub AbsenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsenToolStripMenuItem.Click
        absen.Show()
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ProfilToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.MouseEnter
        ProfilToolStripMenuItem.ShowDropDown()
        ProfilToolStripMenuItem.ForeColor = Color.Indigo
    End Sub
    Private Sub AbsensiToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.MouseEnter
        AbsensiToolStripMenuItem.ShowDropDown()
        AbsensiToolStripMenuItem.ForeColor = Color.Indigo
    End Sub
    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatProfilToolStripMenuItem.Click, CetakKartuIDToolStripMenuItem.Click, AbsenToolStripMenuItem.Click, KeluarToolStripMenuItem.Click
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
    Private Sub ToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles LihatProfilToolStripMenuItem.DropDownOpened, CetakKartuIDToolStripMenuItem.DropDownOpened, AbsenToolStripMenuItem.DropDownOpened, KeluarToolStripMenuItem.DropDownOpened
        Dim clickedItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)

        If clickedItem IsNot Nothing Then
            For Each subItem As ToolStripItem In clickedItem.DropDownItems
                If TypeOf subItem Is ToolStripMenuItem Then
                    subItem.BackColor = Color.FromArgb(229, 204, 255)
                End If
            Next
        End If
    End Sub
    Private Sub ProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.Click
        ProfilToolStripMenuItem.ForeColor = Color.Indigo
        For Each subItem As ToolStripItem In ProfilToolStripMenuItem.DropDownItems
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
    Private Sub ProfilToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.DropDownClosed
        ProfilToolStripMenuItem.BackColor = Color.Indigo
        ProfilToolStripMenuItem.ForeColor = Color.White
        For Each subItem As ToolStripItem In ProfilToolStripMenuItem.DropDownItems
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
    Private Sub ProfilToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.MouseLeave
        If Not ProfilToolStripMenuItem.DropDown.Visible Then
            ProfilToolStripMenuItem.ForeColor = Color.White
        End If
    End Sub
    Private Sub AbsensiToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.MouseLeave
        If Not AbsensiToolStripMenuItem.DropDown.Visible Then
            AbsensiToolStripMenuItem.ForeColor = Color.White
        End If
    End Sub
    Private Sub ProfilToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles ProfilToolStripMenuItem.DropDownOpened
        ProfilToolStripMenuItem.ForeColor = Color.Indigo
        For Each subItem As ToolStripItem In ProfilToolStripMenuItem.DropDownItems
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
End Class
