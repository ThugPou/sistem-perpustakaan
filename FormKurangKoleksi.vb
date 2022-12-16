Public Class FormKurangKoleksi

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'FormPerpustakaan.ListBox1.Items.RemoveAt(FormPerpustakaan.ListBox1.SelectedIndex)
        FormPerpustakaan.koleksi.DeleteDataKoleksiByIDDatabase(FormPerpustakaan.SelectedTableKoleksi)
        Me.Close()
    End Sub
End Class