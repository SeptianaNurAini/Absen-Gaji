<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Menu))
        Me.btnabsensi = New System.Windows.Forms.Button()
        Me.btnpenggajian = New System.Windows.Forms.Button()
        Me.btngajilembur = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnabsensi
        '
        Me.btnabsensi.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.btnabsensi.BackColor = System.Drawing.Color.Teal
        Me.btnabsensi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabsensi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnabsensi.Location = New System.Drawing.Point(535, 308)
        Me.btnabsensi.Name = "btnabsensi"
        Me.btnabsensi.Size = New System.Drawing.Size(304, 65)
        Me.btnabsensi.TabIndex = 10
        Me.btnabsensi.Text = "ABSENSI"
        Me.btnabsensi.UseVisualStyleBackColor = False
        '
        'btnpenggajian
        '
        Me.btnpenggajian.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.btnpenggajian.BackColor = System.Drawing.Color.Teal
        Me.btnpenggajian.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpenggajian.ForeColor = System.Drawing.SystemColors.Control
        Me.btnpenggajian.Location = New System.Drawing.Point(535, 379)
        Me.btnpenggajian.Name = "btnpenggajian"
        Me.btnpenggajian.Size = New System.Drawing.Size(304, 69)
        Me.btnpenggajian.TabIndex = 11
        Me.btnpenggajian.Text = "PENGGAJIAN"
        Me.btnpenggajian.UseVisualStyleBackColor = False
        '
        'btngajilembur
        '
        Me.btngajilembur.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.btngajilembur.BackColor = System.Drawing.Color.Teal
        Me.btngajilembur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngajilembur.ForeColor = System.Drawing.SystemColors.Control
        Me.btngajilembur.Location = New System.Drawing.Point(535, 454)
        Me.btngajilembur.Name = "btngajilembur"
        Me.btngajilembur.Size = New System.Drawing.Size(304, 69)
        Me.btngajilembur.TabIndex = 12
        Me.btngajilembur.Text = "LIHAT GAJI LEMBUR /HARI"
        Me.btngajilembur.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.btnexit.BackColor = System.Drawing.Color.Teal
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnexit.Location = New System.Drawing.Point(535, 531)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(304, 69)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 221)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(281, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Jl. Kemuning Barat, Bogor, Indonesia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(273, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(480, 64)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "PT. PERSERO JAYA"
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1380, 759)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btngajilembur)
        Me.Controls.Add(Me.btnpenggajian)
        Me.Controls.Add(Me.btnabsensi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnabsensi As System.Windows.Forms.Button
    Friend WithEvents btnpenggajian As System.Windows.Forms.Button
    Friend WithEvents btngajilembur As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
