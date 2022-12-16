Public Class FormPerpustakaan
    Public Shared koleksi As Koleksi
    Public Shared SelectedTableKoleksi As String
    Public Shared SelectedTableKoleksiNama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.

        koleksi = New Koleksi()
        ReloadDataTableDatabase()
    End Sub

    Private Sub lbl_tambah_Click(sender As Object, e As EventArgs) Handles lbl_tambah.Click
        Dim tambah_koleksi = New FormTambahKoleksi()
        tambah_koleksi.Show()
    End Sub

    Private Sub lbl_kurang_Click(sender As Object, e As EventArgs) Handles lbl_kurang.Click
        If ListBox1.SelectedItem = "" Then
            MessageBox.Show("Tidak ada koleksi yang dipilih")
        Else
            Dim kurang_koleksi = New FormKurangKoleksi()
            kurang_koleksi.Show()
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = koleksi.GetDataKoleksiDatabase()
    End Sub

    'Public Sub Updatedatatablearraylist()
    '    DataGridKoleksi.Rows.Clear()
    '    For Each rowKoleksi In koleksi.getkoleksidatatable()
    '        Dim datatable As String() = {rowKoleksi(0),
    '                                     rowKoleksi(1),
    '                                     rowKoleksi(2),
    '                                     rowKoleksi(3),
    '                                     rowKoleksi(4),
    '                                     rowKoleksi(5),
    '                                     rowKoleksi(6),
    '                                     rowKoleksi(7),
    '                                     rowKoleksi(8),
    '                                     rowKoleksi(9),
    '                                     rowKoleksi(10)}
    '        DataGridKoleksi.Rows.Add(datatable)
    '    Next
    'End Sub

    Private Sub FormPerpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Updatedatatablearraylist()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'SelectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        SelectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        Dim selectedkoleksi As List(Of String) = koleksi.GetDataKoleksiByIDDatabase(SelectedTableKoleksi)

        koleksi.GSNama = selectedkoleksi(1)
        koleksi.GSFotoBuku = selectedkoleksi(2)
        koleksi.GSJenisKoleksiValue = selectedkoleksi(5)
        koleksi.GSPenerbit = selectedkoleksi(4)
        koleksi.GSDeskripsi = selectedkoleksi(3)
        koleksi.GSTahunTerbit = selectedkoleksi(6)
        koleksi.GSLokasiRak = selectedkoleksi(7)
        koleksi.GSTanggalMasuk = selectedkoleksi(8)
        koleksi.GSStock = selectedkoleksi(9)
        koleksi.GSBahasa = selectedkoleksi(10)

        Dim data_kategori As List(Of String) = koleksi.Convertstringtokoleksi(selectedkoleksi(11))

        For Each info_kategori In data_kategori
            koleksi.addkategori(info_kategori)
        Next

        Dim formInfo = New FormInfoKoleksi()
        formInfo.Show()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIDDatabase(SelectedTableKoleksi)



        koleksi.GSNama = selectedKoleksi(1)
        koleksi.GSFotoBuku = selectedKoleksi(2)
        koleksi.GSJenisKoleksiValue = selectedKoleksi(5)
        koleksi.GSPenerbit = selectedKoleksi(4)
        koleksi.GSDeskripsi = selectedKoleksi(3)
        koleksi.GSTahunTerbit = selectedKoleksi(6)
        koleksi.GSLokasiRak = selectedKoleksi(7)
        koleksi.GSTanggalMasuk = selectedKoleksi(8)
        koleksi.GSStock = selectedKoleksi(9)
        koleksi.GSBahasa = selectedKoleksi(10)

        Dim data_kategori As List(Of String) = koleksi.Convertstringtokoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            koleksi.addkategori(info_kategori)
        Next

        Dim formUpdate = New FormUpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim formHapus = New FormKurangKoleksi()
        formHapus.show()
    End Sub
End Class