Imports System.IO
Imports System.Windows

Public Class FormTambahKoleksi
    Dim kategori_list As New List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dtp_tanggalmasuk.Format = DateTimePickerFormat.Custom
        dtp_tanggalmasuk.CustomFormat = "yyyy/MM/dd"
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

    Private Sub txt_tahunterbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tahunterbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub txt_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub btn_tambahkoleksi_Click(sender As Object, e As EventArgs) Handles btn_tambahkoleksi.Click
        FormPerpustakaan.koleksi.GSNama = txt_tambahnama.Text
        FormPerpustakaan.koleksi.GSJenisKoleksiValue = cb_jeniskoleksi.SelectedItem()
        FormPerpustakaan.koleksi.GSDeskripsi = rtb_deskripsi.Text
        FormPerpustakaan.koleksi.GSPenerbit = txt_penerbit.Text
        FormPerpustakaan.koleksi.GSTahunTerbit = txt_tahunterbit.Text
        FormPerpustakaan.koleksi.GSLokasiRak = txt_lokasirak.Text
        FormPerpustakaan.koleksi.GSTanggalMasuk = dtp_tanggalmasuk.Value.ToLongDateString()
        FormPerpustakaan.koleksi.GSStock = txt_stock.Text

        If rb_indonesia.Checked = True Then
            FormPerpustakaan.koleksi.GSBahasa = "Bahasa Indonesia"
        ElseIf rb_bahasainggris.Checked = True Then
            FormPerpustakaan.koleksi.GSBahasa = "Bahasa Inggris"
        End If

        If cb_sains.Checked() Then
            kategori_list.Add("Sains")
            'MessageBox.Show("sains")
        End If

        If cb_sosial.Checked() Then
            kategori_list.Add("Sosial")
        End If

        If cb_teknologi.Checked() Then
            kategori_list.Add("Teknologi")
        End If

        If cb_budaya.Checked() Then
            kategori_list.Add("Budaya")
        End If

        FormPerpustakaan.koleksi.GSKategoriList = kategori_list
        'MessageBox.Show(kategori_list)



        FormPerpustakaan.ListBox1.Items.Add(FormPerpustakaan.koleksi.GSNama)

        Dim convertedkategori = FormPerpustakaan.koleksi.Convertkoleksitostring(FormPerpustakaan.koleksi.GSKategoriList)
        '    FormPerpustakaan.koleksi.Addkoleksidatatable(
        '                                                 FormPerpustakaan.koleksi.GSNama,
        '                                                 FormPerpustakaan.koleksi.GSJenisKoleksiValue,
        '                                                 FormPerpustakaan.koleksi.GSPenerbit,
        '                                                 FormPerpustakaan.koleksi.GSDeskripsi,
        '                                                 FormPerpustakaan.koleksi.GSTahunTerbit,
        '                                                 FormPerpustakaan.koleksi.GSLokasiRak,
        '                                                 FormPerpustakaan.koleksi.GSTanggalMasuk,
        '                                                 FormPerpustakaan.koleksi.GSStock,
        '                                                 FormPerpustakaan.koleksi.GSBahasa,
        '                                                 convertedkoleksi,
        '                                                 FormPerpustakaan.koleksi.GSFotoBuku
        '                                                 )
        'End Sub

        FormPerpustakaan.koleksi.AddDataKoleksiDatabase(FormPerpustakaan.koleksi.GSNama,
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