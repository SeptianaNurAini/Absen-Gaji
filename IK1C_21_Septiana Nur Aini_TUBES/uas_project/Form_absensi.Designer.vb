<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_absensi
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.cbgolongan = New System.Windows.Forms.ComboBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        Me.txtjamkeluar = New System.Windows.Forms.TextBox()
        Me.txtjammasuk = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtnomor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Golongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tangggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamKeluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Plum
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.cbgolongan)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btninput)
        Me.GroupBox1.Controls.Add(Me.txtjamkeluar)
        Me.GroupBox1.Controls.Add(Me.txtjammasuk)
        Me.GroupBox1.Controls.Add(Me.txttanggal)
        Me.GroupBox1.Controls.Add(Me.txtnomor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 712)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Absensi"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnsave.Location = New System.Drawing.Point(176, 405)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(123, 48)
        Me.btnsave.TabIndex = 22
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnclear.Location = New System.Drawing.Point(34, 467)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(123, 45)
        Me.btnclear.TabIndex = 21
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'cbgolongan
        '
        Me.cbgolongan.FormattingEnabled = True
        Me.cbgolongan.Items.AddRange(New Object() {"Golongan A", "Golongan B", "Golongan C", "Golongan D"})
        Me.cbgolongan.Location = New System.Drawing.Point(176, 155)
        Me.cbgolongan.Name = "cbgolongan"
        Me.cbgolongan.Size = New System.Drawing.Size(333, 26)
        Me.cbgolongan.TabIndex = 20
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(176, 99)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(333, 24)
        Me.txtnama.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nama Karyawan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnclose.Location = New System.Drawing.Point(176, 465)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(123, 48)
        Me.btnclose.TabIndex = 17
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btndelete.Location = New System.Drawing.Point(317, 431)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(123, 45)
        Me.btndelete.TabIndex = 16
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btninput
        '
        Me.btninput.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btninput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninput.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btninput.Location = New System.Drawing.Point(34, 404)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(123, 48)
        Me.btninput.TabIndex = 14
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = False
        '
        'txtjamkeluar
        '
        Me.txtjamkeluar.Location = New System.Drawing.Point(176, 352)
        Me.txtjamkeluar.Name = "txtjamkeluar"
        Me.txtjamkeluar.Size = New System.Drawing.Size(333, 24)
        Me.txtjamkeluar.TabIndex = 11
        '
        'txtjammasuk
        '
        Me.txtjammasuk.Location = New System.Drawing.Point(176, 284)
        Me.txtjammasuk.Name = "txtjammasuk"
        Me.txtjammasuk.Size = New System.Drawing.Size(333, 24)
        Me.txtjammasuk.TabIndex = 10
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(176, 216)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(333, 24)
        Me.txttanggal.TabIndex = 9
        '
        'txtnomor
        '
        Me.txtnomor.Location = New System.Drawing.Point(176, 44)
        Me.txtnomor.Name = "txtnomor"
        Me.txtnomor.Size = New System.Drawing.Size(333, 24)
        Me.txtnomor.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jam Keluar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jam Masuk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Golongan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Plum
        Me.GroupBox2.Controls.Add(Me.txtcari)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(569, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(789, 712)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tampilan"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(96, 47)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(317, 24)
        Me.txtcari.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nomor, Me.Nama, Me.Golongan, Me.Tangggal, Me.JamMasuk, Me.JamKeluar})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(742, 588)
        Me.DataGridView1.TabIndex = 0
        '
        'Nomor
        '
        Me.Nomor.HeaderText = "Nomor"
        Me.Nomor.Name = "Nomor"
        Me.Nomor.Width = 80
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 150
        '
        'Golongan
        '
        Me.Golongan.HeaderText = "Golongan"
        Me.Golongan.Name = "Golongan"
        '
        'Tangggal
        '
        Me.Tangggal.HeaderText = "Tanggal"
        Me.Tangggal.Name = "Tangggal"
        Me.Tangggal.Width = 170
        '
        'JamMasuk
        '
        Me.JamMasuk.HeaderText = "Jam Masuk"
        Me.JamMasuk.Name = "JamMasuk"
        '
        'JamKeluar
        '
        Me.JamKeluar.HeaderText = "Jam Keluar"
        Me.JamKeluar.Name = "JamKeluar"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form_absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1380, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_absensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_absensi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtjamkeluar As System.Windows.Forms.TextBox
    Friend WithEvents txtjammasuk As System.Windows.Forms.TextBox
    Friend WithEvents txtnomor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btninput As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbgolongan As System.Windows.Forms.ComboBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Golongan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tangggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JamMasuk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JamKeluar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
