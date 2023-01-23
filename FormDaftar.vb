Public Class FormDaftar
    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftarform.Click
        If txt_usernamedaftar.Text.Length > 0 And txt_passworddaftar.Text > 0 Then
            'FormLogin.users.Adddatauser(txt_usernamedaftar.Text, txt_passworddaftar.Text)
            FormLogin.users.AddUsersDatabase(txt_usernamedaftar.Text, txt_passworddaftar.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub
End Class