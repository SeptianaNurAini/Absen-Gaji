<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Gaji
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cbhari = New System.Windows.Forms.ComboBox()
        Me.txtalfa = New System.Windows.Forms.TextBox()
        Me.txtsakit = New System.Windows.Forms.TextBox()
        Me.txtijin = New System.Windows.Forms.TextBox()
        Me.txtjamlembur = New System.Windows.Forms.TextBox()
        Me.txtgajilembur = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtgajibersih = New System.Windows.Forms.TextBox()
        Me.txtpotalfa = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtgapok = New System.Windows.Forms.TextBox()
        Me.txttgol = New System.Windows.Forms.TextBox()
        Me.txttmkn = New System.Windows.Forms.TextBox()
        Me.txtttansport = New System.Windows.Forms.TextBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        Me.cbnpk = New System.Windows.Forms.ComboBox()
        Me.txtgolongan = New System.Windows.Forms.TextBox()
        Me.DGVView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.DGVView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA KARYAWAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NPK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Golongan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Hari Kerja"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(121, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alfa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(121, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sakit "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ijin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "LEMBUR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 384)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Jumlah Jam Lembur"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(50, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Gaji Lembur"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(204, 166)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(121, 22)
        Me.txtnama.TabIndex = 12
        '
        'cbhari
        '
        Me.cbhari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbhari.FormattingEnabled = True
        Me.cbhari.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbhari.Location = New System.Drawing.Point(204, 227)
        Me.cbhari.Name = "cbhari"
        Me.cbhari.Size = New System.Drawing.Size(121, 24)
        Me.cbhari.TabIndex = 14
        '
        'txtalfa
        '
        Me.txtalfa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalfa.Location = New System.Drawing.Point(203, 261)
        Me.txtalfa.Name = "txtalfa"
        Me.txtalfa.Size = New System.Drawing.Size(121, 22)
        Me.txtalfa.TabIndex = 15
        '
        'txtsakit
        '
        Me.txtsakit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsakit.Location = New System.Drawing.Point(203, 293)
        Me.txtsakit.Name = "txtsakit"
        Me.txtsakit.Size = New System.Drawing.Size(121, 22)
        Me.txtsakit.TabIndex = 16
        '
        'txtijin
        '
        Me.txtijin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtijin.Location = New System.Drawing.Point(203, 326)
        Me.txtijin.Name = "txtijin"
        Me.txtijin.Size = New System.Drawing.Size(121, 22)
        Me.txtijin.TabIndex = 17
        '
        'txtjamlembur
        '
        Me.txtjamlembur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjamlembur.Location = New System.Drawing.Point(203, 384)
        Me.txtjamlembur.Name = "txtjamlembur"
        Me.txtjamlembur.Size = New System.Drawing.Size(121, 22)
        Me.txtjamlembur.TabIndex = 18
        '
        'txtgajilembur
        '
        Me.txtgajilembur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgajilembur.Location = New System.Drawing.Point(203, 413)
        Me.txtgajilembur.Name = "txtgajilembur"
        Me.txtgajilembur.Size = New System.Drawing.Size(121, 22)
        Me.txtgajilembur.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 454)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 16)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "GAJI DAN TUNJANGAN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(49, 482)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Gaji Pokok"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(49, 514)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Tunjangan Jabatan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(49, 544)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 16)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Tunjangan Makan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(49, 572)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 16)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Tunjangan Transportasi"
        '
        'txtgajibersih
        '
        Me.txtgajibersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgajibersih.Location = New System.Drawing.Point(207, 674)
        Me.txtgajibersih.Name = "txtgajibersih"
        Me.txtgajibersih.Size = New System.Drawing.Size(121, 22)
        Me.txtgajibersih.TabIndex = 29
        '
        'txtpotalfa
        '
        Me.txtpotalfa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpotalfa.Location = New System.Drawing.Point(207, 641)
        Me.txtpotalfa.Name = "txtpotalfa"
        Me.txtpotalfa.Size = New System.Drawing.Size(121, 22)
        Me.txtpotalfa.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(51, 671)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Gaji Bersih"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(51, 644)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 16)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Potongan Alfa"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(51, 610)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 16)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "POTONGAN"
        '
        'txtgapok
        '
        Me.txtgapok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgapok.Location = New System.Drawing.Point(207, 482)
        Me.txtgapok.Name = "txtgapok"
        Me.txtgapok.Size = New System.Drawing.Size(121, 22)
        Me.txtgapok.TabIndex = 30
        '
        'txttgol
        '
        Me.txttgol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttgol.Location = New System.Drawing.Point(207, 511)
        Me.txttgol.Name = "txttgol"
        Me.txttgol.Size = New System.Drawing.Size(121, 22)
        Me.txttgol.TabIndex = 31
        '
        'txttmkn
        '
        Me.txttmkn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttmkn.Location = New System.Drawing.Point(207, 541)
        Me.txttmkn.Name = "txttmkn"
        Me.txttmkn.Size = New System.Drawing.Size(121, 22)
        Me.txttmkn.TabIndex = 32
        '
        'txtttansport
        '
        Me.txtttansport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtttansport.Location = New System.Drawing.Point(207, 569)
        Me.txtttansport.Name = "txtttansport"
        Me.txtttansport.Size = New System.Drawing.Size(121, 22)
        Me.txtttansport.TabIndex = 33
        '
        'btnhitung
        '
        Me.btnhitung.BackColor = System.Drawing.Color.Teal
        Me.btnhitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.ForeColor = System.Drawing.Color.White
        Me.btnhitung.Location = New System.Drawing.Point(357, 122)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(110, 32)
        Me.btnhitung.TabIndex = 35
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Teal
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(716, 122)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(110, 32)
        Me.btnclear.TabIndex = 36
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btninput
        '
        Me.btninput.BackColor = System.Drawing.Color.Teal
        Me.btninput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninput.ForeColor = System.Drawing.Color.White
        Me.btninput.Location = New System.Drawing.Point(478, 122)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(110, 32)
        Me.btninput.TabIndex = 37
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = False
        '
        'cbnpk
        '
        Me.cbnpk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbnpk.FormattingEnabled = True
        Me.cbnpk.Items.AddRange(New Object() {"11", "22", "33", "44", "55"})
        Me.cbnpk.Location = New System.Drawing.Point(204, 133)
        Me.cbnpk.Name = "cbnpk"
        Me.cbnpk.Size = New System.Drawing.Size(121, 24)
        Me.cbnpk.TabIndex = 38
        '
        'txtgolongan
        '
        Me.txtgolongan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgolongan.Location = New System.Drawing.Point(204, 195)
        Me.txtgolongan.Name = "txtgolongan"
        Me.txtgolongan.Size = New System.Drawing.Size(121, 22)
        Me.txtgolongan.TabIndex = 39
        '
        'DGVView
        '
        Me.DGVView.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.DGVView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DGVView.Location = New System.Drawing.Point(357, 166)
        Me.DGVView.Name = "DGVView"
        Me.DGVView.Size = New System.Drawing.Size(943, 527)
        Me.DGVView.TabIndex = 40
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama Karyawan"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Golongan"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Gaji Lembur"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Gaji Pokok"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tunjangan Golongan"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tunjangan Makan"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Tunjangan Transportasi"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Potongan Alfa"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Gaji Bersih"
        Me.Column9.Name = "Column9"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(45, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(501, 42)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "PENGGAJIAN KARYAWAN"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Teal
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(596, 122)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(110, 32)
        Me.btnsave.TabIndex = 42
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Teal
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(838, 122)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(110, 32)
        Me.btnclose.TabIndex = 43
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Form_Gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1380, 759)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.DGVView)
        Me.Controls.Add(Me.txtgolongan)
        Me.Controls.Add(Me.cbnpk)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txtttansport)
        Me.Controls.Add(Me.txttmkn)
        Me.Controls.Add(Me.txttgol)
        Me.Controls.Add(Me.txtgapok)
        Me.Controls.Add(Me.txtgajibersih)
        Me.Controls.Add(Me.txtpotalfa)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtgajilembur)
        Me.Controls.Add(Me.txtjamlembur)
        Me.Controls.Add(Me.txtijin)
        Me.Controls.Add(Me.txtsakit)
        Me.Controls.Add(Me.txtalfa)
        Me.Controls.Add(Me.cbhari)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Gaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Gaji"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cbhari As System.Windows.Forms.ComboBox
    Friend WithEvents txtalfa As System.Windows.Forms.TextBox
    Friend WithEvents txtsakit As System.Windows.Forms.TextBox
    Friend WithEvents txtijin As System.Windows.Forms.TextBox
    Friend WithEvents txtjamlembur As System.Windows.Forms.TextBox
    Friend WithEvents txtgajilembur As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtgajibersih As System.Windows.Forms.TextBox
    Friend WithEvents txtpotalfa As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtgapok As System.Windows.Forms.TextBox
    Friend WithEvents txttgol As System.Windows.Forms.TextBox
    Friend WithEvents txttmkn As System.Windows.Forms.TextBox
    Friend WithEvents txtttansport As System.Windows.Forms.TextBox
    Friend WithEvents btnhitung As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btninput As System.Windows.Forms.Button
    Friend WithEvents cbnpk As System.Windows.Forms.ComboBox
    Friend WithEvents txtgolongan As System.Windows.Forms.TextBox
    Friend WithEvents DGVView As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
