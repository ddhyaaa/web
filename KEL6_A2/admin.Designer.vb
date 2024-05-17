<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.btn_lihat = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.RB_Perempuan = New System.Windows.Forms.RadioButton()
        Me.RB_laki = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.jabatan = New System.Windows.Forms.ComboBox()
        Me.btn_out = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.gaji = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_lihat
        '
        Me.btn_lihat.BackColor = System.Drawing.Color.BlueViolet
        Me.btn_lihat.ForeColor = System.Drawing.Color.White
        Me.btn_lihat.Location = New System.Drawing.Point(414, 486)
        Me.btn_lihat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_lihat.Name = "btn_lihat"
        Me.btn_lihat.Size = New System.Drawing.Size(160, 38)
        Me.btn_lihat.TabIndex = 18
        Me.btn_lihat.Text = "Lihat"
        Me.btn_lihat.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.BlueViolet
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(219, 486)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(159, 38)
        Me.btnSimpan.TabIndex = 17
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(316, 162)
        Me.nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(237, 26)
        Me.nama.TabIndex = 11
        '
        'RB_Perempuan
        '
        Me.RB_Perempuan.AutoSize = True
        Me.RB_Perempuan.BackColor = System.Drawing.Color.Transparent
        Me.RB_Perempuan.ForeColor = System.Drawing.Color.White
        Me.RB_Perempuan.Location = New System.Drawing.Point(436, 351)
        Me.RB_Perempuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB_Perempuan.Name = "RB_Perempuan"
        Me.RB_Perempuan.Size = New System.Drawing.Size(116, 24)
        Me.RB_Perempuan.TabIndex = 8
        Me.RB_Perempuan.TabStop = True
        Me.RB_Perempuan.Text = "Perempuan"
        Me.RB_Perempuan.UseVisualStyleBackColor = False
        '
        'RB_laki
        '
        Me.RB_laki.AutoSize = True
        Me.RB_laki.BackColor = System.Drawing.Color.Transparent
        Me.RB_laki.ForeColor = System.Drawing.Color.White
        Me.RB_laki.Location = New System.Drawing.Point(319, 351)
        Me.RB_laki.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB_laki.Name = "RB_laki"
        Me.RB_laki.Size = New System.Drawing.Size(91, 24)
        Me.RB_laki.TabIndex = 0
        Me.RB_laki.TabStop = True
        Me.RB_laki.Text = "Laki-laki"
        Me.RB_laki.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(316, 273)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.MaxDate = New Date(2024, 5, 17, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(237, 26)
        Me.DateTimePicker1.TabIndex = 21
        Me.DateTimePicker1.Value = New Date(2024, 5, 17, 0, 0, 0, 0)
        '
        'jabatan
        '
        Me.jabatan.FormattingEnabled = True
        Me.jabatan.Items.AddRange(New Object() {"Bendahara", "Sekretaris", "Manajer", "Cleaning Service", "Customer Service"})
        Me.jabatan.Location = New System.Drawing.Point(316, 311)
        Me.jabatan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(237, 28)
        Me.jabatan.TabIndex = 22
        '
        'btn_out
        '
        Me.btn_out.BackColor = System.Drawing.Color.BlueViolet
        Me.btn_out.ForeColor = System.Drawing.Color.White
        Me.btn_out.Location = New System.Drawing.Point(610, 486)
        Me.btn_out.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_out.Name = "btn_out"
        Me.btn_out.Size = New System.Drawing.Size(155, 38)
        Me.btn_out.TabIndex = 27
        Me.btn_out.Text = "Log out"
        Me.btn_out.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(316, 199)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(237, 26)
        Me.password.TabIndex = 29
        '
        'gaji
        '
        Me.gaji.Location = New System.Drawing.Point(316, 236)
        Me.gaji.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gaji.Name = "gaji"
        Me.gaji.Size = New System.Drawing.Size(237, 26)
        Me.gaji.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.BlueViolet
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(670, 381)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 38)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(315, 125)
        Me.id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(237, 26)
        Me.id.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.BlueViolet
        Me.PictureBox1.Location = New System.Drawing.Point(636, 109)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 246)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(525, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 38
        '
        'admin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 613)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RB_Perempuan)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.RB_laki)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gaji)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.btn_out)
        Me.Controls.Add(Me.jabatan)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btn_lihat)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.nama)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_lihat As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents RB_Perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents RB_laki As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents jabatan As System.Windows.Forms.ComboBox
    Friend WithEvents btn_out As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents gaji As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
