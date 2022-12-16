Public Class FormInfoKoleksi
    Public Shared koleksi As Koleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        koleksi = New Koleksi()

        If Not String.IsNullOrEmpty(FormPerpustakaan.koleksi.GSFotoBuku) Then
            bookpicture.Load(FormPerpustakaan.koleksi.GSFotoBuku)
            bookpicture.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        lbl_namakoleksi.Text = FormPerpustakaan.koleksi.GSNama
        lbl_jeniskoleksi.Text = FormPerpustakaan.koleksi.GSJenisKoleksiValue
        lbl_deskripsi.Text = FormPerpustakaan.koleksi.GSDeskripsi
        lbl_penerbit.Text = FormPerpustakaan.koleksi.GSPenerbit
        lbl_tahunterbit.Text = FormPerpustakaan.koleksi.GSTahunTerbit
        lbl_lokasirak.Text = FormPerpustakaan.koleksi.GSLokasiRak
        lbl_tanggalmasuk.Text = FormPerpustakaan.koleksi.GSTanggalMasuk
        lbl_stock.Text = FormPerpustakaan.koleksi.GSStock
        lbl_bahasa.Text = FormPerpustakaan.koleksi.GSBahasa


        ListBoxKategori.Items.Clear()

        For Each Kategori In FormPerpustakaan.koleksi.GSKategoriList
            ListBoxKategori.Items.Add(Kategori)
        Next

        'FormPerpustakaan.koleksi.GSKategoriList.Clear()
    End Sub

    Private Sub btn_tutup_info_Click(sender As Object, e As EventArgs) Handles btn_tutup_info.Click
        Me.Close()
    End Sub
End Class