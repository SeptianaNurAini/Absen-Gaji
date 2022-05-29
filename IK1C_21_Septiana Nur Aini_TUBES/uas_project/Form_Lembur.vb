Imports System.Data.OleDb

Public Class Form_Lembur
    Private bonus As Integer
    Private gaji As Integer
    Private lembur As Integer
    Private total As Object
    Private upah As Integer

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        If cbgolongan.Text = "Golongan A" Then
            txtgaji.Text = Val(txtlembur.Text) * 60000 + (9000 * Val(txtjamkerja.Text))
        End If
        If cbgolongan.Text = "Golongan B" Then
            txtgaji.Text = Val(txtlembur.Text) * 50000 + (8000 * Val(txtjamkerja.Text))
        End If
        If cbgolongan.Text = "Golongan C" Then
            txtgaji.Text = Val(txtlembur.Text) * 40000 + (7000 * Val(txtjamkerja.Text))
        End If
        If cbgolongan.Text = "Golongan D" Then
            txtgaji.Text = Val(txtlembur.Text) * 30000 + (6000 * Val(txtjamkerja.Text))
        End If

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txttanggal.Text = Format(Now, "MM/dd/yyyy")
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        If txtnama.Text = "" Or txtjamkerja.Text = "" Or txtlembur.Text = "" Or cbgolongan.Text = "" Then
            MsgBox("Anda Harus Mengisi Semua Data!", MsgBoxStyle.Information + vbOKOnly, "Atention")
            txtnama.Focus()
        Else
            DGVview.Rows.Add(1)
            DGVview.Rows(DGVview.RowCount - 2).Cells(0).Value = txtnama.Text
            DGVview.Rows(DGVview.RowCount - 2).Cells(1).Value = cbgolongan.Text
            DGVview.Rows(DGVview.RowCount - 2).Cells(2).Value = txtjamkerja.Text
            DGVview.Rows(DGVview.RowCount - 2).Cells(3).Value = txtlembur.Text
            DGVview.Rows(DGVview.RowCount - 2).Cells(4).Value = txttanggal.Text
            DGVview.Rows(DGVview.RowCount - 2).Cells(5).Value = txtgaji.Text
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtnama.Text = "" Or txtjamkerja.Text = "" Or txtlembur.Text = "" Or cbgolongan.Text = "" Then
            MessageBox.Show("Data Yang Anda Masukkan Belum Lengkap!")
        Else
                'simpan data di database
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_gajilembur(NamaKaryawan,Golongan,JamKerja,Lembur,Tanggal,Total)values('" & txtnama.Text &
                                        "','" & cbgolongan.Text &
                                        "','" & txtjamkerja.Text &
                                        "','" & txtlembur.Text &
                                        "','" & txttanggal.Text &
                                        "','" & txtgaji.Text &
                                        "')", conn)
                cmd.ExecuteNonQuery()
                For baris As Integer = 0 To DGVview.Rows.Count - 2
                cmd = New OleDbCommand("insert into tbl_gajilembur values('" & DGVview.Rows(baris).Cells(0).Value &
                                        "','" & DGVview.Rows(baris).Cells(1).Value &
                                        "','" & DGVview.Rows(baris).Cells(2).Value &
                                        "','" & DGVview.Rows(baris).Cells(3).Value &
                                        "','" & DGVview.Rows(baris).Cells(4).Value &
                                        "','" & DGVview.Rows(baris).Cells(5).Value &
                                        "')", conn)

            Next

            MessageBox.Show("Data Berhasil Disimpan!")
            txtnama.Text = ""
            txtgaji.Text = ""
            txtjamkerja.Text = ""
            txtlembur.Text = ""
            cbgolongan.Text = ""
            txtnama.Focus()
            End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DGVview.Rows.RemoveAt(DGVview.CurrentRow.Index)
        If DGVview.Rows.Count > 1 Then
            btndelete.Enabled = True
        ElseIf DGVview.Rows.Count <= 1 Then
            btndelete.Enabled = True
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtnama.Text = ""
        txtgaji.Text = ""
        txtjamkerja.Text = ""
        txtlembur.Text = ""
        cbgolongan.Text = ""
        txtnama.Focus()
    End Sub

    Sub show_golongan()
        cmd = New OleDbCommand("select*from tbl_golongan", conn)
        rd = cmd.ExecuteReader
        DGVGOL.Rows.Clear()
        Do While rd.Read = True
            DGVGOL.Rows.Add(rd(0), rd(1))
        Loop

    End Sub

    
    Sub show_gaji()
        cmd = New OleDbCommand("select*from tbl_gajilembur", conn)
        rd = cmd.ExecuteReader
        DGVview.Rows.Clear()
        Do While rd.Read = True
            DGVview.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
        Loop

    End Sub

    Private Sub Form_Lembur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call show_golongan()
        Call show_gaji()

    End Sub
    
    Private Sub txtgaji_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgaji.TextChanged
        
    End Sub
End Class

