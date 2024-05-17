<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Admin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAbsensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Indigo
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKaryawanToolStripMenuItem, Me.AbsensiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(986, 69)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataKaryawanToolStripMenuItem
        '
        Me.DataKaryawanToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DataKaryawanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahDataToolStripMenuItem, Me.DaftarKaryawanToolStripMenuItem})
        Me.DataKaryawanToolStripMenuItem.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.0!)
        Me.DataKaryawanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataKaryawanToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.DataKaryawanToolStripMenuItem.Name = "DataKaryawanToolStripMenuItem"
        Me.DataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(210, 65)
        Me.DataKaryawanToolStripMenuItem.Text = "Data Karyawan"
        '
        'TambahDataToolStripMenuItem
        '
        Me.TambahDataToolStripMenuItem.Name = "TambahDataToolStripMenuItem"
        Me.TambahDataToolStripMenuItem.Size = New System.Drawing.Size(300, 40)
        Me.TambahDataToolStripMenuItem.Text = "Tambah Data"
        '
        'DaftarKaryawanToolStripMenuItem
        '
        Me.DaftarKaryawanToolStripMenuItem.Name = "DaftarKaryawanToolStripMenuItem"
        Me.DaftarKaryawanToolStripMenuItem.Size = New System.Drawing.Size(300, 40)
        Me.DaftarKaryawanToolStripMenuItem.Text = "Daftar Karyawan"
        '
        'AbsensiToolStripMenuItem
        '
        Me.AbsensiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataAbsensiToolStripMenuItem})
        Me.AbsensiToolStripMenuItem.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.0!)
        Me.AbsensiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AbsensiToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Navy
        Me.AbsensiToolStripMenuItem.Name = "AbsensiToolStripMenuItem"
        Me.AbsensiToolStripMenuItem.Size = New System.Drawing.Size(123, 65)
        Me.AbsensiToolStripMenuItem.Text = "Absensi"
        '
        'DataAbsensiToolStripMenuItem
        '
        Me.DataAbsensiToolStripMenuItem.Name = "DataAbsensiToolStripMenuItem"
        Me.DataAbsensiToolStripMenuItem.Size = New System.Drawing.Size(259, 40)
        Me.DataAbsensiToolStripMenuItem.Text = "Data Absensi"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.0!)
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(105, 65)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Menu_Admin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 613)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
