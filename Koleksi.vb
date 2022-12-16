Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Koleksi

    Private dir_gambar As String
    Private nama_koleksi As String
    Private jenis_koleksi As String
    Private deskripsi As String
    Private penerbit As String
    Private tahun_terbit As String
    Private lokasi As String
    Private tanggal_masuk_koleksi As String
    Private stock As String
    Private bahasa As String
    Private kategori_list As New List(Of String)

    Private koleksidatatable As New ArrayList()
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"


    Public Property GSFotoBuku() As String
        Get
            Return dir_gambar
        End Get
        Set(ByVal value As String)
            dir_gambar = value
        End Set
    End Property

    Public Property GSNama() As String
        Get
            Return nama_koleksi
        End Get
        Set(ByVal value As String)
            nama_koleksi = value
        End Set
    End Property

    Public Property GSJenisKoleksiValue() As String
        Get
            Return jenis_koleksi
        End Get
        Set(ByVal value As String)
            jenis_koleksi = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(ByVal value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahunTerbit() As String
        Get
            Return tahun_terbit
        End Get
        Set(ByVal value As String)
            tahun_terbit = value
        End Set
    End Property

    Public Property GSLokasiRak() As String
        Get
            Return lokasi
        End Get
        Set(ByVal value As String)
            lokasi = value
        End Set
    End Property

    Public Property GSTanggalMasuk() As String
        Get
            Return tanggal_masuk_koleksi
        End Get
        Set(ByVal value As String)
            tanggal_masuk_koleksi = value
        End Set
    End Property

    Public Property GSStock() As String
        Get
            Return stock
        End Get
        Set(ByVal value As String)
            stock = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSKategoriList() As List(Of String)
        Get
            Return kategori_list
        End Get
        Set(ByVal value As List(Of String))
            kategori_list = value
        End Set
    End Property

    Public Function addkategori(value As String)
        kategori_list.Add(value)
    End Function

    Public ReadOnly Property getkategori() As List(Of String)
        Get
            Return kategori_list
        End Get
    End Property

    Public Function resetkategori(value As String)
        kategori_list.Clear()
    End Function

    Public Function Convertkoleksitostring(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function Convertstringtokoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'convert to list
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    'Public Function Addkoleksidatatable(
    '                                    nama As String,
    '                                    jenis_koleksi_value As String,
    '                                    penerbit As String,
    '                                    deskripsi As String,
    '                                    tahun_terbit As String,
    '                                    lokasi_rak As String,
    '                                    tanggal_masuk As String,
    '                                    stock As String,
    '                                    bahasa As String,
    '                                    kategori_list As String,
    '                                    foto_buku As String
    '                                   )
    '    koleksidatatable.Add({
    '                         nama,
    '                         jenis_koleksi_value,
    '                         penerbit,
    '                         deskripsi,
    '                         tahun_terbit,
    '                         lokasi_rak,
    '                         tanggal_masuk,
    '                         stock,
    '                         bahasa,
    '                         kategori_list,
    '                         foto_buku
    '                        })
    'End Function

    'Public Function Removekoleksidatatable(index As Integer)
    '    koleksidatatable.RemoveAt(index)
    'End Function

    'Public ReadOnly Property getkoleksidatatable() As ArrayList
    '    Get
    '        Return koleksidatatable
    '    End Get
    'End Property

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                  nama_koleksi as 'Nama Koleksi',
                                  dir_gambar as 'Gambar',
                                  deskripsi AS 'Deskripsi',
                                  penerbit AS 'Penerbit',
                                  jenis_koleksi AS 'Jenis Koleksi',
                                  tahun_terbit AS 'Tahun Terbit',
                                  lokasi AS 'Lokasi Rak',
                                  tanggal_masuk_koleksi AS 'Tanggal Masuk',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa',
                                  kategori as 'Kategori'
                                  FROM koleksi"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(
                                        nama_koleksi As String,
                                        dir_gambar As String,
                                        deskripsi As String,
                                        penerbit As String,
                                        jenis_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi As String,
                                        tanggal_masuk_koleksi As Date,
                                        stock As String,
                                        bahasa As String,
                                        kategori As String
                                       )

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO KOLEKSI (nama_koleksi, dir_gambar, deskripsi, penerbit, jenis_koleksi,
                        tahun_terbit, lokasi, tanggal_masuk_koleksi, stock, bahasa, kategori) VALUE('" _
                        & nama_koleksi & "', '" _
                        & dir_gambar & "', '" _
                        & deskripsi & "', '" _
                        & penerbit & "', '" _
                        & jenis_koleksi & "', '" _
                        & tahun_terbit & "', '" _
                        & lokasi & "', '" _
                        & tanggal_masuk_koleksi.ToString("yyyy/MM/dd") & "', '" _
                        & stock & "', '" _
                        & bahasa & "', '" _
                        & kategori & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'FormPerpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi,
                                nama_koleksi,
                                dir_gambar,
                                deskripsi,
                                penerbit,
                                jenis_koleksi,
                                tahun_terbit,
                                lokasi,
                                tanggal_masuk_koleksi,
                                stock,
                                bahasa,
                                kategori
                                FROM koleksi
                                WHERE id_koleksi='" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  nama_koleksi As String,
                                                  dir_gambar As String,
                                                  deskripsi As String,
                                                  penerbit As String,
                                                  jenis_koleksi As String,
                                                  tahun_terbit As String,
                                                  lokasi As String,
                                                  tanggal_masuk_koleksi As Date,
                                                  stock As String,
                                                  bahasa As String,
                                                  kategori As String)
        tahun_terbit = tahun_terbit.ToString("yyyy")
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET" &
                        "nama_koleksi='" & nama_koleksi & "', " &
                        "dir_gambar='" & dir_gambar & "', " &
                        "deskripsi='" & deskripsi & "', " &
                        "penerbit='" & penerbit & "', " &
                        "jenis_koleksi='" & jenis_koleksi & "', " &
                        "tahun_terbit='" & tahun_terbit & "', " &
                        "lokasi='" & lokasi & "', " &
                        "tanggal_masuk_koleksi='" & tanggal_masuk_koleksi & "', " &
                        "stock='" & stock & "', " &
                        "bahasa='" & bahasa & "', " &
                        "kategori='" & kategori & "', " &
                        "WHERE id_koleksi='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi " &
                        "WHERE id_koleksi='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


End Class