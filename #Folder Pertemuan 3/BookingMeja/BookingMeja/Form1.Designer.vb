<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbMeja = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.lbNama = New System.Windows.Forms.Label()
        Me.lbTamu = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.lbTanggal = New System.Windows.Forms.Label()
        Me.btNext = New System.Windows.Forms.Button()
        Me.MtbWaktu = New System.Windows.Forms.MaskedTextBox()
        Me.lbWaktu = New System.Windows.Forms.Label()
        Me.OpsiJmlTamu = New System.Windows.Forms.NumericUpDown()
        Me.cbMeja = New System.Windows.Forms.ComboBox()
        CType(Me.OpsiJmlTamu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbMeja
        '
        Me.lbMeja.AutoSize = True
        Me.lbMeja.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMeja.ForeColor = System.Drawing.Color.Black
        Me.lbMeja.Location = New System.Drawing.Point(45, 233)
        Me.lbMeja.Name = "lbMeja"
        Me.lbMeja.Size = New System.Drawing.Size(104, 20)
        Me.lbMeja.TabIndex = 1
        Me.lbMeja.Text = "Meja Tersedia"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(165, 46)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(200, 22)
        Me.tbNama.TabIndex = 2
        '
        'lbNama
        '
        Me.lbNama.AutoSize = True
        Me.lbNama.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama.ForeColor = System.Drawing.Color.Black
        Me.lbNama.Location = New System.Drawing.Point(45, 48)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(55, 20)
        Me.lbNama.TabIndex = 3
        Me.lbNama.Text = "Nama "
        '
        'lbTamu
        '
        Me.lbTamu.AutoSize = True
        Me.lbTamu.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTamu.ForeColor = System.Drawing.Color.Black
        Me.lbTamu.Location = New System.Drawing.Point(45, 188)
        Me.lbTamu.Name = "lbTamu"
        Me.lbTamu.Size = New System.Drawing.Size(102, 20)
        Me.lbTamu.TabIndex = 4
        Me.lbTamu.Text = "Jumlah Tamu"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(165, 98)
        Me.dtpTanggal.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dtpTanggal.MinDate = New Date(2025, 2, 18, 0, 0, 0, 0)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 22)
        Me.dtpTanggal.TabIndex = 6
        Me.dtpTanggal.Value = New Date(2025, 2, 18, 0, 0, 0, 0)
        '
        'lbTanggal
        '
        Me.lbTanggal.AutoSize = True
        Me.lbTanggal.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTanggal.ForeColor = System.Drawing.Color.Black
        Me.lbTanggal.Location = New System.Drawing.Point(45, 95)
        Me.lbTanggal.Name = "lbTanggal"
        Me.lbTanggal.Size = New System.Drawing.Size(67, 20)
        Me.lbTanggal.TabIndex = 8
        Me.lbTanggal.Text = "Tanggal "
        '
        'btNext
        '
        Me.btNext.Location = New System.Drawing.Point(49, 287)
        Me.btNext.Name = "btNext"
        Me.btNext.Size = New System.Drawing.Size(85, 32)
        Me.btNext.TabIndex = 10
        Me.btNext.Text = "Next"
        Me.btNext.UseVisualStyleBackColor = True
        '
        'MtbWaktu
        '
        Me.MtbWaktu.Location = New System.Drawing.Point(165, 144)
        Me.MtbWaktu.Mask = "00:00"
        Me.MtbWaktu.Name = "MtbWaktu"
        Me.MtbWaktu.Size = New System.Drawing.Size(55, 22)
        Me.MtbWaktu.TabIndex = 11
        Me.MtbWaktu.ValidatingType = GetType(Date)
        '
        'lbWaktu
        '
        Me.lbWaktu.AutoSize = True
        Me.lbWaktu.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWaktu.ForeColor = System.Drawing.Color.Black
        Me.lbWaktu.Location = New System.Drawing.Point(45, 141)
        Me.lbWaktu.Name = "lbWaktu"
        Me.lbWaktu.Size = New System.Drawing.Size(54, 20)
        Me.lbWaktu.TabIndex = 12
        Me.lbWaktu.Text = "Waktu"
        '
        'OpsiJmlTamu
        '
        Me.OpsiJmlTamu.Location = New System.Drawing.Point(165, 189)
        Me.OpsiJmlTamu.Name = "OpsiJmlTamu"
        Me.OpsiJmlTamu.Size = New System.Drawing.Size(42, 22)
        Me.OpsiJmlTamu.TabIndex = 5
        '
        'cbMeja
        '
        Me.cbMeja.FormattingEnabled = True
        Me.cbMeja.Items.AddRange(New Object() {"Meja 1 (2 Kursi)", "Meja 2 (4 Kursi)", "Meja 3 (6 Kursi)", "Meja 4 (8 Kursi)"})
        Me.cbMeja.Location = New System.Drawing.Point(165, 233)
        Me.cbMeja.Name = "cbMeja"
        Me.cbMeja.Size = New System.Drawing.Size(137, 24)
        Me.cbMeja.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 450)
        Me.Controls.Add(Me.cbMeja)
        Me.Controls.Add(Me.lbWaktu)
        Me.Controls.Add(Me.MtbWaktu)
        Me.Controls.Add(Me.btNext)
        Me.Controls.Add(Me.lbTanggal)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.OpsiJmlTamu)
        Me.Controls.Add(Me.lbTamu)
        Me.Controls.Add(Me.lbNama)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.lbMeja)
        Me.Name = "Form1"
        Me.Text = "Pesan Meja"
        CType(Me.OpsiJmlTamu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbMeja As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents lbNama As Label
    Friend WithEvents lbTamu As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lbTanggal As Label
    Friend WithEvents btNext As Button
    Friend WithEvents MtbWaktu As MaskedTextBox
    Friend WithEvents lbWaktu As Label
    Friend WithEvents OpsiJmlTamu As NumericUpDown
    Friend WithEvents cbMeja As ComboBox
End Class
