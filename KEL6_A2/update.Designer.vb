<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(update))
        Me.id = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gaji = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.btn_Ubah = New System.Windows.Forms.Button()
        Me.jabatan = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RB_Perempuan = New System.Windows.Forms.RadioButton()
        Me.RB_laki = New System.Windows.Forms.RadioButton()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(284, 128)
        Me.id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(316, 26)
        Me.id.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.BlueViolet
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(670, 379)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 38)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gaji
        '
        Me.gaji.Location = New System.Drawing.Point(284, 236)
        Me.gaji.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gaji.Name = "gaji"
        Me.gaji.Size = New System.Drawing.Size(316, 26)
        Me.gaji.TabIndex = 52
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(284, 200)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(316, 26)
        Me.password.TabIndex = 50
        '
        'btn_Ubah
        '
        Me.btn_Ubah.BackColor = System.Drawing.Color.BlueViolet
        Me.btn_Ubah.ForeColor = System.Drawing.Color.White
        Me.btn_Ubah.Location = New System.Drawing.Point(412, 485)
        Me.btn_Ubah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Ubah.Name = "btn_Ubah"
        Me.btn_Ubah.Size = New System.Drawing.Size(159, 38)
        Me.btn_Ubah.TabIndex = 46
        Me.btn_Ubah.Text = "Ubah"
        Me.btn_Ubah.UseVisualStyleBackColor = False
        '
        'jabatan
        '
        Me.jabatan.FormattingEnabled = True
        Me.jabatan.Items.AddRange(New Object() {"Bendahara", "Sekretaris", "Manajer", "Cleaning Service", "Customer Service"})
        Me.jabatan.Location = New System.Drawing.Point(284, 308)
        Me.jabatan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(316, 28)
        Me.jabatan.TabIndex = 44
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(284, 272)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.MaxDate = New Date(2024, 5, 17, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(316, 26)
        Me.DateTimePicker1.TabIndex = 43
        Me.DateTimePicker1.Value = New Date(2024, 3, 13, 0, 0, 0, 0)
        '
        'RB_Perempuan
        '
        Me.RB_Perempuan.AutoSize = True
        Me.RB_Perempuan.BackColor = System.Drawing.Color.Transparent
        Me.RB_Perempuan.ForeColor = System.Drawing.Color.White
        Me.RB_Perempuan.Location = New System.Drawing.Point(412, 346)
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
        Me.RB_laki.Location = New System.Drawing.Point(284, 346)
        Me.RB_laki.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB_laki.Name = "RB_laki"
        Me.RB_laki.Size = New System.Drawing.Size(91, 24)
        Me.RB_laki.TabIndex = 0
        Me.RB_laki.TabStop = True
        Me.RB_laki.Text = "Laki-laki"
        Me.RB_laki.UseVisualStyleBackColor = False
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(284, 164)
        Me.nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(316, 26)
        Me.nama.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.BlueViolet
        Me.PictureBox1.Location = New System.Drawing.Point(637, 110)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'update
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 613)
        Me.Controls.Add(Me.RB_Perempuan)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.RB_laki)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gaji)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.btn_Ubah)
        Me.Controls.Add(Me.jabatan)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.nama)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "update"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gaji As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents btn_Ubah As System.Windows.Forms.Button
    Friend WithEvents jabatan As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RB_Perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents RB_laki As System.Windows.Forms.RadioButton
    Friend WithEvents nama As System.Windows.Forms.TextBox
End Class
