<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lihat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lihat))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NamaD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jabatan1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Indigo
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaD, Me.tgl, Me.jenis1, Me.Jabatan1})
        Me.DataGridView1.Location = New System.Drawing.Point(60, 213)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.MaximumSize = New System.Drawing.Size(867, 361)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(867, 361)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(867, 361)
        Me.DataGridView1.TabIndex = 20
        '
        'NamaD
        '
        Me.NamaD.HeaderText = "Nama"
        Me.NamaD.Name = "NamaD"
        '
        'tgl
        '
        Me.tgl.HeaderText = "Tanggal Lahir"
        Me.tgl.Name = "tgl"
        '
        'jenis1
        '
        Me.jenis1.HeaderText = "Jenis Kelamin"
        Me.jenis1.Name = "jenis1"
        '
        'Jabatan1
        '
        Me.Jabatan1.HeaderText = "Jabatan"
        Me.Jabatan1.Name = "Jabatan1"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtSearch.Location = New System.Drawing.Point(214, 62)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(694, 32)
        Me.txtSearch.TabIndex = 25
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.BlueViolet
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhapus.Location = New System.Drawing.Point(52, 135)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(140, 35)
        Me.btnhapus.TabIndex = 27
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.BlueViolet
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUpdate.Location = New System.Drawing.Point(203, 134)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(140, 35)
        Me.BtnUpdate.TabIndex = 28
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'lihat
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 613)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "lihat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NamaD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jabatan1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
End Class
