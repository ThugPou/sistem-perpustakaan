Public Class FormDaftar
    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftarform.Click
        FormLogin.users.Adddatauser(txt_usernamedaftar.Text, txt_passworddaftar.Text)
        Me.Close()
    End Sub
End Class