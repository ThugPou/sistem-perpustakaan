Public Class FormLogin

    Public Shared users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        users = New Users()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim plainUsername As String = txt_username.Text
        Dim plainPassword As String = txt_password.Text
        'Dim Encrypted As String = Users. EncryptData(plainPassword)
        'MessageBox.Show(Encrypted)

        Dim data_users As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)

        'Dim AuthStatus As Boolean = users.CheckAuth(plainUsername, plainPassword)
        ''MessageBox.Show(AuthStatus)
        'If AuthStatus Then
        '    FormPerpustakaan.Show()
        'Else
        '    MessageBox.Show("Wrong Password")
        'End If

        If data_users.Count > 0 Then
            users.GSUsername = data_users(1)
            FormPerpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If
    End Sub

    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        Dim formdaftar = New FormDaftar()
        formdaftar.Show()
    End Sub

End Class