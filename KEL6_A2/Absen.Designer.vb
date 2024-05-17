<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class absen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(absen))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.kembali = New System.Windows.Forms.Button()
        Me.confirm = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(572, 240)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(347, 32)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2024, 5, 17, 0, 0, 0, 0)
        '
        'kembali
        '
        Me.kembali.BackColor = System.Drawing.Color.BlueViolet
        Me.kembali.ForeColor = System.Drawing.Color.White
        Me.kembali.Location = New System.Drawing.Point(770, 368)
        Me.kembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(129, 36)
        Me.kembali.TabIndex = 1
        Me.kembali.Text = "Kembali"
        Me.kembali.UseVisualStyleBackColor = False
        '
        'confirm
        '
        Me.confirm.BackColor = System.Drawing.Color.BlueViolet
        Me.confirm.ForeColor = System.Drawing.Color.White
        Me.confirm.Location = New System.Drawing.Point(589, 369)
        Me.confirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(130, 35)
        Me.confirm.TabIndex = 2
        Me.confirm.Text = "Confirm"
        Me.confirm.UseVisualStyleBackColor = False
        '
        'absen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 613)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "absen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "absen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents kembali As System.Windows.Forms.Button
    Friend WithEvents confirm As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
