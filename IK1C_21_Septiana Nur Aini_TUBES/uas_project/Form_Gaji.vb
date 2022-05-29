Imports System.Data.OleDb

Public Class Form_Gaji
    Dim gaber As Double
    Private Sub cbnpk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbnpk.SelectedIndexChanged
        Select Case cbnpk.Text
            Case "11"
                txtnama.Text = "Riana"
                txtgolongan.Text = "Golongan B"
            Case "22"
                txtnama.Text = "Fadilah"
                txtgolongan.Text = "Golongan A"
            Case "33"
                txtnama.Text = "Hilda"
                txtgolongan.Text = "Golongan B"
            Case "44"
                txtnama.Text = "Haki"
                txtgolongan.Text = "Golongan C"
            Case "55"
                txtnama.Text = "Alvaro"
                txtgolongan.Text = "Golongan D"
        End Select

        'gaji pokok dari golongan
        Select Case txtgolongan.Text
            Case "Golongan A"
                txtgapok.Text = 2700000
            Case "Golongan B"
                txtgapok.Text = 2400000
            Case "Golongan C"
                txtgapok.Text = 2100000
            Case "Golongan D"
                txtgapok.Text = 1800000
        End Select

        'tunjangan golongan dari golongan
        Select Case txtgolongan.Text
            Case "Golongan A"
                txttgol.Text = 500000
            Case "Golongan B"
                txttgol.Text = 400000
            Case "Golongan C"
                txttgol.Text = 300000
            Case "Golongan D"
                txttgol.Text = 200000
        End Select
        'tunjangan masing - masing
        txtttansport.Text = Val(txtgapok.Text) * 40 / 100
        txttmkn.Text = Val(txtgapok.Text) * 30 / 100
    End Sub

    Private Sub btnhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        If txtalfa.Text = "" Or txtnama.Text = "" Or txtgolongan.Text = "" Or txtgajilembur.Text = "" Or
            txtgapok.Text = "" Or txttgol.Text = "" Or txttmkn.Text = "" Or txtttansport.Text = "" Then
            MsgBox("Anda Harus Mengisi Semua Data!", MsgBoxStyle.Information + vbOKOnly, "Atention")
            cbnpk.Focus()

        Else
            Dim tunjangantransportA As Double
            Dim tunjanganmakanA As Double

            Dim tunjangantransportB As Double
            Dim tunjanganmakanB As Double

            Dim tunjangantransportC As Double
            Dim tunjanganmakanC As Double

            Dim tunjangantransportD As Double
            Dim tunjanganmakanD As Double

            If txtgolongan.Text = "Golongan A" Then
                tunjangantransportA = Val(txtttansport.Text) - Val(txtalfa.Text * 100000)
                tunjanganmakanA = Val(txttmkn.Text) - Val(txtalfa.Text * 100000)
                txtttansport.Text = tunjangantransportA
                txttmkn.Text = tunjanganmakanA
                txtpotalfa.Text = Val(txtalfa.Text) * 200000
            End If
            If txtgolongan.Text = "Golongan B" Then
                tunjangantransportB = Val(txtttansport.Text) - Val(txtalfa.Text * 90000)
                tunjanganmakanB = Val(txttmkn.Text) - Val(txtalfa.Text * 90000)
                txtttansport.Text = tunjangantransportB
                txttmkn.Text = tunjanganmakanB
                txtpotalfa.Text = Val(txtalfa.Text) * 150000
            End If
            If txtgolongan.Text = "Golongan C" Then
                tunjangantransportC = Val(txtttansport.Text) - Val(txtalfa.Text * 80000)
                tunjanganmakanC = Val(txttmkn.Text) - Val(txtalfa.Text * 80000)
                txtttansport.Text = tunjangantransportC
                txttmkn.Text = tunjanganmakanC
                txtpotalfa.Text = Val(txtalfa.Text) * 100000
            End If
            If txtgolongan.Text = "Golongan D" Then
                tunjangantransportD = Val(txtttansport.Text) - Val(txtalfa.Text * 70000)
                tunjanganmakanD = Val(txttmkn.Text) - Val(txtalfa.Text * 70000)
                txtttansport.Text = tunjangantransportD
                txttmkn.Text = tunjanganmakanD
                txtpotalfa.Text = Val(txtalfa.Text) * 75000
            End If
            gaber = Val(txtgapok.Text) + Val(txtttansport.Text) + Val(txttmkn.Text) + Val(txttgol.Text) + Val(txtgajilembur.Text) - Val(txtpotalfa.Text)
        End If
        txtgajibersih.Text = Format(gaber, "Rp ###,###,###")
    End Sub

    Private Sub txtgajilembur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgajilembur.TextChanged
        If txtgolongan.Text = "Golongan A" Then
            txtgajilembur.Text = Val(txtjamlembur.Text) * 60000
        End If
        If txtgolongan.Text = "Golongan B" Then
            txtgajilembur.Text = Val(txtjamlembur.Text) * 50000
        End If
        If txtgolongan.Text = "Golongan C" Then
            txtgajilembur.Text = Val(txtjamlembur.Text) * 40000
        End If
        If txtgolongan.Text = "Golongan D" Then
            txtgajilembur.Text = Val(txtjamlembur.Text) * 30000
        End If
    End Sub

    

    Private Sub btninput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninput.Click
        If txtnama.Text = "" Or txtgolongan.Text = "" Or txtgajilembur.Text = "" Or txtgapok.Text = "" Or txttgol.Text = "" Or
            txttmkn.Text = "" Or txtttansport.Text = "" Or txtpotalfa.Text = "" Or txtgajibersih.Text = "" Then
            MsgBox("Anda Harus Mengisi Semua Data!", MsgBoxStyle.Information + vbOKOnly, "Atention")
            txtnama.Focus()
        Else
            DGVView.Rows.Add(1)
            DGVView.Rows(DGVView.RowCount - 2).Cells(0).Value = txtnama.Text
            DGVView.Rows(DGVView.RowCount - 2).Cells(1).Value = txtgolongan.Text
            DGVView.Rows(DGVView.RowCount - 2).Cells(2).Value = txtgajilembur.Text
            DGVView.Rows(DGVView.RowCount - 2).Cells(3).Value = txtgapok.Text
            DGVView.Rows(DGVView.RowCount - 2).Cells(4).Value = txttgol.Text
            DGVView.Rows(DGVView.RowCount - 2).Cells(5).Value = txttmkn.Text
            DGVView.Rows(DGVView.RowCount - 2).Cells(6).Value = txtttansport.Text
            DGVView.Rows(DGVView.RowCount - 2).Cells(7).Value = txtpotalfa.Text
            DGVView.Rows(DGVView.RowCount - 2).Cells(8).Value = txtgajibersih.Text

        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtnama.Text = "" Or txtgolongan.Text = "" Or txtgajilembur.Text = "" Or txtgapok.Text = "" Or txttgol.Text = "" Or
            txttmkn.Text = "" Or txtttansport.Text = "" Or txtpotalfa.Text = "" Or txtgajibersih.Text = "" Then
            MessageBox.Show("Data Yang Anda Masukkan Belum Lengkap!")
        Else
            'simpan data di database
            Call koneksi()
            cmd = New OleDbCommand("insert into tbl_gaji(NamaKaryawan,Golongan,GajiLembur,GajiPokok,TunjanganGolongan,TunjanganMakan,TunjanganTransportasi,PotonganAlfa,GajiBersih)values('" & txtnama.Text &
                                    "','" & txtgolongan.Text &
                                    "','" & txtgajilembur.Text &
                                    "','" & txtgapok.Text &
                                    "','" & txttgol.Text &
                                    "','" & txttmkn.Text &
                                    "','" & txtttansport.Text &
                                    "','" & txtpotalfa.Text &
                                    "','" & txtgajibersih.Text &
                                    "')", conn)
            cmd.ExecuteNonQuery()
            For baris As Integer = 0 To DGVView.Rows.Count - 2
                cmd = New OleDbCommand("insert into tbl_gaji values('" & DGVView.Rows(baris).Cells(0).Value &
                                        "','" & DGVView.Rows(baris).Cells(1).Value &
                                        "','" & DGVView.Rows(baris).Cells(2).Value &
                                        "','" & DGVView.Rows(baris).Cells(3).Value &
                                        "','" & DGVView.Rows(baris).Cells(4).Value &
                                        "','" & DGVView.Rows(baris).Cells(5).Value &
                                        "','" & DGVView.Rows(baris).Cells(6).Value &
                                        "','" & DGVView.Rows(baris).Cells(7).Value &
                                        "','" & DGVView.Rows(baris).Cells(8).Value &
                                        "')", conn)
            Next

            MessageBox.Show("Data Berhasil Disimpan!")
            cbnpk.Text = ""
            txtnama.Text = ""
            txtgolongan.Text = ""
            txtgajibersih.Text = ""
            txtgajilembur.Text = ""
            cbhari.Text = ""
            txttgol.Text = ""
            txttmkn.Text = ""
            txtttansport.Text = ""
            txtijin.Text = ""
            txtjamlembur.Text = ""
            txtalfa.Text = ""
            txtgapok.Text = ""
            txtsakit.Text = ""
            txtpotalfa.Text = ""
            cbnpk.Focus()
        End If
    End Sub
    Sub show_penggajian()
        cmd = New OleDbCommand("select*from tbl_gaji", conn)
        rd = cmd.ExecuteReader
        DGVView.Rows.Clear()
        Do While rd.Read = True
            DGVView.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6), rd(7), rd(8))
        Loop
    End Sub
    Private Sub Form_Gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call show_penggajian()

        Dim i As Integer
        i = 0
        While i < 30
            i = i + 1
            cbhari.Items.Add(i)
        End While
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cbnpk.Text = ""
        txtnama.Text = ""
        txtjamlembur.Text = ""
        txtgapok.Text = ""
        txtgolongan.Text = ""
        txtgajibersih.Text = ""
        txtgajilembur.Text = ""
        cbhari.Text = ""
        txttgol.Text = ""
        txttmkn.Text = ""
        txtttansport.Text = ""
        txtijin.Text = ""
        txtalfa.Text = ""
        txtsakit.Text = ""
        txtpotalfa.Text = ""
        cbnpk.Focus()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()

    End Sub
End Class