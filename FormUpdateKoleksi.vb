Public Class FormUpdateKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bookpicture.Load(FormPerpustakaan.koleksi.GSFotoBuku)
        bookpicture.SizeMode = PictureBoxSizeMode.StretchImage
        dtp_tanggalmasuk.Format = DateTimePickerFormat.Custom
        dtp_tanggalmasuk.CustomFormat = "yyyy/MM/dd"
        txt_tambahnama.Text = FormPerpustakaan.koleksi.GSNama
        cb_jeniskoleksi.SelectedItem() = FormPerpustakaan.koleksi.GSJenisKoleksiValue
        rtb_deskripsi.Text = FormPerpustakaan.koleksi.GSDeskripsi
        txt_penerbit.Text = FormPerpustakaan.koleksi.GSPenerbit
        txt_tahunterbit.Text = FormPerpustakaan.koleksi.GSTahunTerbit
        txt_lokasirak.Text = FormPerpustakaan.koleksi.GSLokasiRak
        dtp_tanggalmasuk.Value = FormPerpustakaan.koleksi.GSTanggalMasuk
        txt_stock.Text = FormPerpustakaan.koleksi.GSStock

        If String.Compare(FormPerpustakaan.koleksi.GSBahasa, "Bahasa Indonesia") = 0 Then
            rb_indonesia.Checked = True
        ElseIf String.Compare(FormPerpustakaan.koleksi.GSBahasa, "Bahasa Inggris") = 0 Then
            rb_bahasainggris.Checked = True
        End If

        For Each kategoriItem In FormPerpustakaan.koleksi.getkategori

            If String.Compare(kategoriItem, "Sains") = 0 Then
                cb_sains.Checked() = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                cb_sosial.Checked() = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                cb_teknologi.Checked() = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                cb_budaya.Checked() = True
            End If
        Next
        FormPerpustakaan.koleksi.resetkategori()
    End Sub

    Private Sub btn_tambahgambar_Click(sender As Object, e As EventArgs) Handles btn_tambahgambar.Click
        OpenFilePicture.InitialDirectory = "~/Pictures"
        OpenFilePicture.Title = "Buka Foto"
        OpenFilePicture.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFilePicture.ShowDialog()

        Dim fotobuku As String = OpenFilePicture.FileName

        bookpicture.Load(fotobuku)
        bookpicture.SizeMode = PictureBoxSizeMode.StretchImage
        FormPerpustakaan.koleksi.GSFotoBuku = fotobuku.ToString()
        FormPerpustakaan.koleksi.GSFotoBuku = FormPerpustakaan.koleksi.GSFotoBuku.Replace("\", "/")
    End Sub

    Private Sub btn_updatekoleksi_Click(sender As Object, e As EventArgs) Handles btn_updatekoleksi.Click
        FormPerpustakaan.koleksi.GSNama = txt_tambahnama.Text.ToString()
        FormPerpustakaan.koleksi.GSJenisKoleksiValue = cb_jeniskoleksi.SelectedItem().ToString()
        FormPerpustakaan.koleksi.GSDeskripsi = rtb_deskripsi.Text.ToString()
        FormPerpustakaan.koleksi.GSPenerbit = txt_penerbit.Text.ToString()
        FormPerpustakaan.koleksi.GSTahunTerbit = Integer.Parse(txt_tahunterbit.Text)
        FormPerpustakaan.koleksi.GSLokasiRak = txt_lokasirak.Text.ToString()
        FormPerpustakaan.koleksi.GSTanggalMasuk = dtp_tanggalmasuk.Value.ToString("yyyy/MM/dd")
        FormPerpustakaan.koleksi.GSStock = Integer.Parse(txt_stock.Text)

        If rb_indonesia.Checked = True Then
            FormPerpustakaan.koleksi.GSBahasa = "Bahasa Indonesia"
        ElseIf rb_bahasainggris.Checked = True Then
            FormPerpustakaan.koleksi.GSBahasa = "Bahasa Inggris"
        End If

        If cb_sains.Checked() Then
            FormPerpustakaan.koleksi.addkategori("Sains")
        End If

        If cb_sosial.Checked() Then
            FormPerpustakaan.koleksi.addkategori("Sosial")
        End If

        If cb_teknologi.Checked() Then
            FormPerpustakaan.koleksi.addkategori("Teknologi")
        End If

        If cb_budaya.Checked() Then
            FormPerpustakaan.koleksi.addkategori("Budaya")
        End If

        Dim convertedkategori = FormPerpustakaan.koleksi.Convertkoleksitostring(FormPerpustakaan.koleksi.GSKategoriList)
        FormPerpustakaan.koleksi.UpdateDataKoleksiByIDDatabase(FormPerpustakaan.SelectedTableKoleksi,
                                                               FormPerpustakaan.koleksi.GSNama,
                                                               FormPerpustakaan.koleksi.GSFotoBuku,
                                                               FormPerpustakaan.koleksi.GSDeskripsi,
                                                               FormPerpustakaan.koleksi.GSPenerbit,
                                                               FormPerpustakaan.koleksi.GSJenisKoleksiValue,
                                                               FormPerpustakaan.koleksi.GSTahunTerbit,
                                                               FormPerpustakaan.koleksi.GSLokasiRak,
                                                               FormPerpustakaan.koleksi.GSTanggalMasuk,
                                                               FormPerpustakaan.koleksi.GSStock,
                                                               FormPerpustakaan.koleksi.GSBahasa,
                                                               convertedkategori
                                                               )
        Dim form_tambah_koleksi = New FormInfoKoleksi()
        form_tambah_koleksi.Show()
        Me.Close()
    End Sub
End Class