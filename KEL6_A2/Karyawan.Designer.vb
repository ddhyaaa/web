<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Karyawan))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jenis = New System.Windows.Forms.Label()
        Me.jabatan = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.keluar = New System.Windows.Forms.Button()
        Me.gaji = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.idK = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.txtPwBaru = New System.Windows.Forms.TextBox()
        Me.txtpwlama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-27, 195)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 52)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-27, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 54)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-27, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 42)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = ":"
        '
        'jenis
        '
        Me.jenis.BackColor = System.Drawing.Color.Transparent
        Me.jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.jenis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.jenis.Location = New System.Drawing.Point(259, 340)
        Me.jenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(352, 30)
        Me.jenis.TabIndex = 39
        Me.jenis.Text = " "
        '
        'jabatan
        '
        Me.jabatan.BackColor = System.Drawing.Color.Transparent
        Me.jabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.jabatan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.jabatan.Location = New System.Drawing.Point(259, 293)
        Me.jabatan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(352, 30)
        Me.jabatan.TabIndex = 38
        Me.jabatan.Text = " "
        '
        'tanggal
        '
        Me.tanggal.BackColor = System.Drawing.Color.Transparent
        Me.tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.tanggal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tanggal.Location = New System.Drawing.Point(258, 246)
        Me.tanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(353, 30)
        Me.tanggal.TabIndex = 37
        Me.tanggal.Text = " "
        '
        'nama
        '
        Me.nama.BackColor = System.Drawing.Color.Transparent
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.nama.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nama.Location = New System.Drawing.Point(258, 198)
        Me.nama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(353, 30)
        Me.nama.TabIndex = 36
        Me.nama.Text = " "
        '
        'keluar
        '
        Me.keluar.BackColor = System.Drawing.Color.BlueViolet
        Me.keluar.ForeColor = System.Drawing.Color.White
        Me.keluar.Location = New System.Drawing.Point(427, 475)
        Me.keluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(136, 39)
        Me.keluar.TabIndex = 41
        Me.keluar.Text = "Exit"
        Me.keluar.UseVisualStyleBackColor = False
        '
        'gaji
        '
        Me.gaji.BackColor = System.Drawing.Color.Transparent
        Me.gaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.gaji.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gaji.Location = New System.Drawing.Point(259, 384)
        Me.gaji.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gaji.Name = "gaji"
        Me.gaji.Size = New System.Drawing.Size(352, 30)
        Me.gaji.TabIndex = 44
        Me.gaji.Text = " "
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-30, 237)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 52)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = ":"
        '
        'idK
        '
        Me.idK.BackColor = System.Drawing.Color.Transparent
        Me.idK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.idK.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.idK.Location = New System.Drawing.Point(258, 152)
        Me.idK.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idK.Name = "idK"
        Me.idK.Size = New System.Drawing.Size(353, 30)
        Me.idK.TabIndex = 47
        Me.idK.Text = " "
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.BlueViolet
        Me.btn_reset.ForeColor = System.Drawing.Color.White
        Me.btn_reset.Location = New System.Drawing.Point(720, 408)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(137, 39)
        Me.btn_reset.TabIndex = 48
        Me.btn_reset.Text = "Reset Password"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'txtPwBaru
        '
        Me.txtPwBaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtPwBaru.Location = New System.Drawing.Point(667, 326)
        Me.txtPwBaru.Multiline = True
        Me.txtPwBaru.Name = "txtPwBaru"
        Me.txtPwBaru.Size = New System.Drawing.Size(240, 49)
        Me.txtPwBaru.TabIndex = 49
        '
        'txtpwlama
        '
        Me.txtpwlama.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtpwlama.Location = New System.Drawing.Point(667, 242)
        Me.txtpwlama.Multiline = True
        Me.txtpwlama.Name = "txtpwlama"
        Me.txtpwlama.Size = New System.Drawing.Size(240, 49)
        Me.txtpwlama.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(664, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Password Lama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(664, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Password Baru"
        '
        'Karyawan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 613)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpwlama)
        Me.Controls.Add(Me.txtPwBaru)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.idK)
        Me.Controls.Add(Me.gaji)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.jenis)
        Me.Controls.Add(Me.jabatan)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karyawan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents jenis As System.Windows.Forms.Label
    Friend WithEvents jabatan As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents keluar As System.Windows.Forms.Button
    Friend WithEvents gaji As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents idK As System.Windows.Forms.Label
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents txtPwBaru As System.Windows.Forms.TextBox
    Friend WithEvents txtpwlama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
