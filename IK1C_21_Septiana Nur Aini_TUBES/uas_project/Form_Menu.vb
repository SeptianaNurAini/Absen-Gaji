Public Class Form_Menu

    Private Sub AbsensiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_absensi.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub GajiLemburToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_Lembur.ShowDialog()
    End Sub

    Private Sub btnabsensi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabsensi.Click
        Form_absensi.ShowDialog()
    End Sub

    Private Sub btnpenggajian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpenggajian.Click
        Form_Gaji.ShowDialog()
    End Sub

    Private Sub btngajilembur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngajilembur.Click
        Form_Lembur.ShowDialog()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()
    End Sub
End Class