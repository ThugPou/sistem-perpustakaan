<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_tambahgambar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_tambahnama = New System.Windows.Forms.TextBox()
        Me.txt_penerbit = New System.Windows.Forms.TextBox()
        Me.txt_tahunterbit = New System.Windows.Forms.TextBox()
        Me.txt_lokasirak = New System.Windows.Forms.TextBox()
        Me.rtb_deskripsi = New System.Windows.Forms.RichTextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.cb_jeniskoleksi = New System.Windows.Forms.ComboBox()
        Me.btn_tambahkoleksi = New System.Windows.Forms.Button()
        Me.rb_indonesia = New System.Windows.Forms.RadioButton()
        Me.rb_bahasainggris = New System.Windows.Forms.RadioButton()
        Me.gb_bahasa = New System.Windows.Forms.GroupBox()
        Me.cb_sains = New System.Windows.Forms.CheckBox()
        Me.cb_sosial = New System.Windows.Forms.CheckBox()
        Me.cb_teknologi = New System.Windows.Forms.CheckBox()
        Me.cb_budaya = New System.Windows.Forms.CheckBox()
        Me.gb_kategori = New System.Windows.Forms.GroupBox()
        Me.bookpicture = New System.Windows.Forms.PictureBox()
        Me.dtp_tanggalmasuk = New System.Windows.Forms.DateTimePicker()
        Me.OpenFilePicture = New System.Windows.Forms.OpenFileDialog()
        Me.gb_bahasa.SuspendLayout()
        Me.gb_kategori.SuspendLayout()
        CType(Me.bookpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_tambahgambar
        '
        Me.btn_tambahgambar.Location = New System.Drawing.Point(18, 234)
        Me.btn_tambahgambar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tambahgambar.Name = "btn_tambahgambar"
        Me.btn_tambahgambar.Size = New System.Drawing.Size(162, 35)
        Me.btn_tambahgambar.TabIndex = 1
        Me.btn_tambahgambar.Text = "Tambah Gambar"
        Me.btn_tambahgambar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tambah Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Koleksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Deskripsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 434)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 492)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(274, 551)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(274, 614)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 29)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(274, 672)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 29)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(274, 731)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 29)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Bahasa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(274, 860)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 29)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Kategori"
        '
        'txt_tambahnama
        '
        Me.txt_tambahnama.Location = New System.Drawing.Point(627, 85)
        Me.txt_tambahnama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_tambahnama.Name = "txt_tambahnama"
        Me.txt_tambahnama.Size = New System.Drawing.Size(422, 26)
        Me.txt_tambahnama.TabIndex = 13
        '
        'txt_penerbit
        '
        Me.txt_penerbit.Location = New System.Drawing.Point(627, 431)
        Me.txt_penerbit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_penerbit.Name = "txt_penerbit"
        Me.txt_penerbit.Size = New System.Drawing.Size(422, 26)
        Me.txt_penerbit.TabIndex = 14
        '
        'txt_tahunterbit
        '
        Me.txt_tahunterbit.Location = New System.Drawing.Point(627, 489)
        Me.txt_tahunterbit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_tahunterbit.Name = "txt_tahunterbit"
        Me.txt_tahunterbit.Size = New System.Drawing.Size(422, 26)
        Me.txt_tahunterbit.TabIndex = 15
        '
        'txt_lokasirak
        '
        Me.txt_lokasirak.Location = New System.Drawing.Point(627, 548)
        Me.txt_lokasirak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_lokasirak.Name = "txt_lokasirak"
        Me.txt_lokasirak.Size = New System.Drawing.Size(422, 26)
        Me.txt_lokasirak.TabIndex = 16
        '
        'rtb_deskripsi
        '
        Me.rtb_deskripsi.Location = New System.Drawing.Point(627, 212)
        Me.rtb_deskripsi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rtb_deskripsi.Name = "rtb_deskripsi"
        Me.rtb_deskripsi.Size = New System.Drawing.Size(422, 186)
        Me.rtb_deskripsi.TabIndex = 17
        Me.rtb_deskripsi.Text = ""
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(627, 669)
        Me.txt_stock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(422, 26)
        Me.txt_stock.TabIndex = 18
        '
        'cb_jeniskoleksi
        '
        Me.cb_jeniskoleksi.FormattingEnabled = True
        Me.cb_jeniskoleksi.Items.AddRange(New Object() {"Buku Novel", "Buku Pelajaran", "Buku Komik"})
        Me.cb_jeniskoleksi.Location = New System.Drawing.Point(627, 142)
        Me.cb_jeniskoleksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_jeniskoleksi.Name = "cb_jeniskoleksi"
        Me.cb_jeniskoleksi.Size = New System.Drawing.Size(422, 28)
        Me.cb_jeniskoleksi.TabIndex = 19
        '
        'btn_tambahkoleksi
        '
        Me.btn_tambahkoleksi.Location = New System.Drawing.Point(936, 1008)
        Me.btn_tambahkoleksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tambahkoleksi.Name = "btn_tambahkoleksi"
        Me.btn_tambahkoleksi.Size = New System.Drawing.Size(176, 35)
        Me.btn_tambahkoleksi.TabIndex = 21
        Me.btn_tambahkoleksi.Text = "Tambah Koleksi"
        Me.btn_tambahkoleksi.UseVisualStyleBackColor = True
        '
        'rb_indonesia
        '
        Me.rb_indonesia.AutoSize = True
        Me.rb_indonesia.Location = New System.Drawing.Point(9, 29)
        Me.rb_indonesia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rb_indonesia.Name = "rb_indonesia"
        Me.rb_indonesia.Size = New System.Drawing.Size(163, 24)
        Me.rb_indonesia.TabIndex = 22
        Me.rb_indonesia.TabStop = True
        Me.rb_indonesia.Text = "Bahasa Indonesia"
        Me.rb_indonesia.UseVisualStyleBackColor = True
        '
        'rb_bahasainggris
        '
        Me.rb_bahasainggris.AutoSize = True
        Me.rb_bahasainggris.Location = New System.Drawing.Point(9, 65)
        Me.rb_bahasainggris.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rb_bahasainggris.Name = "rb_bahasainggris"
        Me.rb_bahasainggris.Size = New System.Drawing.Size(141, 24)
        Me.rb_bahasainggris.TabIndex = 23
        Me.rb_bahasainggris.TabStop = True
        Me.rb_bahasainggris.Text = "Bahasa Inggris"
        Me.rb_bahasainggris.UseVisualStyleBackColor = True
        '
        'gb_bahasa
        '
        Me.gb_bahasa.Controls.Add(Me.rb_bahasainggris)
        Me.gb_bahasa.Controls.Add(Me.rb_indonesia)
        Me.gb_bahasa.Location = New System.Drawing.Point(627, 731)
        Me.gb_bahasa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_bahasa.Name = "gb_bahasa"
        Me.gb_bahasa.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_bahasa.Size = New System.Drawing.Size(300, 105)
        Me.gb_bahasa.TabIndex = 24
        Me.gb_bahasa.TabStop = False
        Me.gb_bahasa.Text = "Bahasa"
        '
        'cb_sains
        '
        Me.cb_sains.AutoSize = True
        Me.cb_sains.Location = New System.Drawing.Point(9, 32)
        Me.cb_sains.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_sains.Name = "cb_sains"
        Me.cb_sains.Size = New System.Drawing.Size(75, 24)
        Me.cb_sains.TabIndex = 25
        Me.cb_sains.Text = "Sains"
        Me.cb_sains.UseVisualStyleBackColor = True
        '
        'cb_sosial
        '
        Me.cb_sosial.AutoSize = True
        Me.cb_sosial.Location = New System.Drawing.Point(9, 68)
        Me.cb_sosial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_sosial.Name = "cb_sosial"
        Me.cb_sosial.Size = New System.Drawing.Size(78, 24)
        Me.cb_sosial.TabIndex = 26
        Me.cb_sosial.Text = "Sosial"
        Me.cb_sosial.UseVisualStyleBackColor = True
        '
        'cb_teknologi
        '
        Me.cb_teknologi.AutoSize = True
        Me.cb_teknologi.Location = New System.Drawing.Point(9, 103)
        Me.cb_teknologi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_teknologi.Name = "cb_teknologi"
        Me.cb_teknologi.Size = New System.Drawing.Size(103, 24)
        Me.cb_teknologi.TabIndex = 27
        Me.cb_teknologi.Text = "Teknologi"
        Me.cb_teknologi.UseVisualStyleBackColor = True
        '
        'cb_budaya
        '
        Me.cb_budaya.AutoSize = True
        Me.cb_budaya.Location = New System.Drawing.Point(9, 138)
        Me.cb_budaya.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_budaya.Name = "cb_budaya"
        Me.cb_budaya.Size = New System.Drawing.Size(89, 24)
        Me.cb_budaya.TabIndex = 28
        Me.cb_budaya.Text = "Budaya"
        Me.cb_budaya.UseVisualStyleBackColor = True
        '
        'gb_kategori
        '
        Me.gb_kategori.Controls.Add(Me.cb_budaya)
        Me.gb_kategori.Controls.Add(Me.cb_sains)
        Me.gb_kategori.Controls.Add(Me.cb_teknologi)
        Me.gb_kategori.Controls.Add(Me.cb_sosial)
        Me.gb_kategori.Location = New System.Drawing.Point(627, 860)
        Me.gb_kategori.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_kategori.Name = "gb_kategori"
        Me.gb_kategori.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_kategori.Size = New System.Drawing.Size(300, 183)
        Me.gb_kategori.TabIndex = 29
        Me.gb_kategori.TabStop = False
        Me.gb_kategori.Text = "Kategori"
        '
        'bookpicture
        '
        Me.bookpicture.Location = New System.Drawing.Point(18, 83)
        Me.bookpicture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bookpicture.Name = "bookpicture"
        Me.bookpicture.Size = New System.Drawing.Size(162, 142)
        Me.bookpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bookpicture.TabIndex = 0
        Me.bookpicture.TabStop = False
        '
        'dtp_tanggalmasuk
        '
        Me.dtp_tanggalmasuk.Location = New System.Drawing.Point(627, 609)
        Me.dtp_tanggalmasuk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtp_tanggalmasuk.Name = "dtp_tanggalmasuk"
        Me.dtp_tanggalmasuk.Size = New System.Drawing.Size(422, 26)
        Me.dtp_tanggalmasuk.TabIndex = 30
        '
        'OpenFilePicture
        '
        Me.OpenFilePicture.FileName = "OpenFilePicture"
        '
        'FormTambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 1078)
        Me.Controls.Add(Me.dtp_tanggalmasuk)
        Me.Controls.Add(Me.btn_tambahkoleksi)
        Me.Controls.Add(Me.cb_jeniskoleksi)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.rtb_deskripsi)
        Me.Controls.Add(Me.txt_lokasirak)
        Me.Controls.Add(Me.txt_tahunterbit)
        Me.Controls.Add(Me.txt_penerbit)
        Me.Controls.Add(Me.txt_tambahnama)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_tambahgambar)
        Me.Controls.Add(Me.bookpicture)
        Me.Controls.Add(Me.gb_bahasa)
        Me.Controls.Add(Me.gb_kategori)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormTambahKoleksi"
        Me.Text = "TambahKoleksi"
        Me.gb_bahasa.ResumeLayout(False)
        Me.gb_bahasa.PerformLayout()
        Me.gb_kategori.ResumeLayout(False)
        Me.gb_kategori.PerformLayout()
        CType(Me.bookpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bookpicture As PictureBox
    Friend WithEvents btn_tambahgambar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_tambahnama As TextBox
    Friend WithEvents txt_penerbit As TextBox
    Friend WithEvents txt_tahunterbit As TextBox
    Friend WithEvents txt_lokasirak As TextBox
    Friend WithEvents rtb_deskripsi As RichTextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents cb_jeniskoleksi As ComboBox
    Friend WithEvents btn_tambahkoleksi As Button
    Friend WithEvents rb_indonesia As RadioButton
    Friend WithEvents rb_bahasainggris As RadioButton
    Friend WithEvents gb_bahasa As GroupBox
    Friend WithEvents cb_sains As CheckBox
    Friend WithEvents cb_sosial As CheckBox
    Friend WithEvents cb_teknologi As CheckBox
    Friend WithEvents cb_budaya As CheckBox
    Friend WithEvents gb_kategori As GroupBox
    Friend WithEvents dtp_tanggalmasuk As DateTimePicker
    Friend WithEvents OpenFilePicture As OpenFileDialog
End Class
