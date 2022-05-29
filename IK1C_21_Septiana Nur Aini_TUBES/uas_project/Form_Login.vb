Public Class Form_Login

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtuser.Text = "septiana" And txtpass.Text = "admin" Then
            MsgBox("Login Berhasil!!!", MsgBoxStyle.Information, "Login")
            Form_Menu.ShowDialog()
            Me.Close()
        Else
            If txtuser.Text = "" And txtpass.Text = "" Then
                MsgBox("Masukkan Username atau Password", MsgBoxStyle.Critical, "Error")
            Else
                If txtuser.Text = "" Then
                    MsgBox("Tidak ada Username", MsgBoxStyle.Critical, "Error")
                Else
                    If txtpass.Text = "" Then
                        MsgBox("Tidak ada Password", MsgBoxStyle.Critical, "Error")
                    Else
                        MsgBox("Username atau Password Yang Anda Masukkan Salah", MsgBoxStyle.Critical, "Error")
                    End If
                End If
                    End If

        End If
    End Sub
End Class
