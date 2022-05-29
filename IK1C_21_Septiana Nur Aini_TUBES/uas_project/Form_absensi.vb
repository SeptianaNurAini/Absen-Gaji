Imports System.Data.OleDb

Public Class Form_absensi

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txttanggal.Text = Format(Now, "MM/dd/yyyy")
    End Sub

    Private Sub btninput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninput.Click
        If txtnama.Text = "" Or txtnomor.Text = "" Or txtjammasuk.Text = "" Or txtjamkeluar.Text = "" Or cbgolongan.Text = "" Then
            MsgBox("Anda Harus Mengisi Semua Data!", MsgBoxStyle.Information + vbOKOnly, "Atention")
            txtnomor.Focus()
        Else
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = txtnomor.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = txtnama.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = cbgolongan.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = txttanggal.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = txtjammasuk.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = txtjamkeluar.Text
        End If

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        If DataGridView1.Rows.Count > 1 Then
            btndelete.Enabled = True
        ElseIf DataGridView1.Rows.Count <= 1 Then
            btndelete.Enabled = True
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtnomor.Text = ""
        txtnama.Text = ""
        cbgolongan.Text = ""
        txtjamkeluar.Text = ""
        txtjammasuk.Text = ""
        txtnomor.Focus()
    End Sub

    Sub show_golongan()
        cmd = New OleDbCommand("select*from tbl_absensi", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
        Loop

    End Sub
    Private Sub Form_absensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call show_golongan()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtnama.Text = "" Or txtnomor.Text = "" Or txtjammasuk.Text = "" Or txtjamkeluar.Text = "" Or cbgolongan.Text = "" Then
            MessageBox.Show("Semua Data Wajib Diisi!")
        Else
            cmd = New OleDbCommand("select * from tbl_absensi where Nomor= '" & txtnomor.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                cmd = New OleDbCommand("insert into tbl_absensi values('" & txtnomor.Text &
                                        "','" & txtnama.Text &
                                        "','" & cbgolongan.Text &
                                        "','" & txttanggal.Text &
                                        "','" & txtjammasuk.Text &
                                        "','" & txtjamkeluar.Text &
                                        "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan!")
                txtnomor.Text = ""
                txtnama.Text = ""
                txtjamkeluar.Text = ""
                txtjammasuk.Text = ""
                cbgolongan.Text = ""
                txtnomor.Focus()

            End If

        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        cmd = New OleDbCommand("select * from tbl_absensi where NamaKaryawan like '%" & txtcari.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
        Loop
    End Sub
End Class