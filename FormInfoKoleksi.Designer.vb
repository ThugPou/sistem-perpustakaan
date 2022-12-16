<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInfoKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_namakoleksi = New System.Windows.Forms.Label()
        Me.lbl_jeniskoleksi = New System.Windows.Forms.Label()
        Me.lbl_deskripsi = New System.Windows.Forms.Label()
        Me.lbl_penerbit = New System.Windows.Forms.Label()
        Me.lbl_tahunterbit = New System.Windows.Forms.Label()
        Me.lbl_lokasirak = New System.Windows.Forms.Label()
        Me.lbl_tanggalmasuk = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_bahasa = New System.Windows.Forms.Label()
        Me.ListBoxKategori = New System.Windows.Forms.ListBox()
        Me.btn_tutup_info = New System.Windows.Forms.Button()
        Me.bookpicture = New System.Windows.Forms.PictureBox()
        CType(Me.bookpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(139, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 18)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Kategori"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(139, 433)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Bahasa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(139, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(139, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(139, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nama Koleksi"
        '
        'lbl_namakoleksi
        '
        Me.lbl_namakoleksi.AutoSize = True
        Me.lbl_namakoleksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_namakoleksi.Location = New System.Drawing.Point(362, 12)
        Me.lbl_namakoleksi.Name = "lbl_namakoleksi"
        Me.lbl_namakoleksi.Size = New System.Drawing.Size(130, 18)
        Me.lbl_namakoleksi.TabIndex = 25
        Me.lbl_namakoleksi.Text = "ini nama koleksi"
        '
        'lbl_jeniskoleksi
        '
        Me.lbl_jeniskoleksi.AutoSize = True
        Me.lbl_jeniskoleksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jeniskoleksi.Location = New System.Drawing.Point(362, 54)
        Me.lbl_jeniskoleksi.Name = "lbl_jeniskoleksi"
        Me.lbl_jeniskoleksi.Size = New System.Drawing.Size(130, 18)
        Me.lbl_jeniskoleksi.TabIndex = 26
        Me.lbl_jeniskoleksi.Text = "ini nama koleksi"
        '
        'lbl_deskripsi
        '
        Me.lbl_deskripsi.AutoSize = True
        Me.lbl_deskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deskripsi.Location = New System.Drawing.Point(362, 96)
        Me.lbl_deskripsi.Name = "lbl_deskripsi"
        Me.lbl_deskripsi.Size = New System.Drawing.Size(130, 18)
        Me.lbl_deskripsi.TabIndex = 27
        Me.lbl_deskripsi.Text = "ini nama koleksi"
        '
        'lbl_penerbit
        '
        Me.lbl_penerbit.AutoSize = True
        Me.lbl_penerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_penerbit.Location = New System.Drawing.Point(362, 240)
        Me.lbl_penerbit.Name = "lbl_penerbit"
        Me.lbl_penerbit.Size = New System.Drawing.Size(130, 18)
        Me.lbl_penerbit.TabIndex = 28
        Me.lbl_penerbit.Text = "ini nama koleksi"
        '
        'lbl_tahunterbit
        '
        Me.lbl_tahunterbit.AutoSize = True
        Me.lbl_tahunterbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tahunterbit.Location = New System.Drawing.Point(362, 278)
        Me.lbl_tahunterbit.Name = "lbl_tahunterbit"
        Me.lbl_tahunterbit.Size = New System.Drawing.Size(130, 18)
        Me.lbl_tahunterbit.TabIndex = 29
        Me.lbl_tahunterbit.Text = "ini nama koleksi"
        '
        'lbl_lokasirak
        '
        Me.lbl_lokasirak.AutoSize = True
        Me.lbl_lokasirak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lokasirak.Location = New System.Drawing.Point(362, 316)
        Me.lbl_lokasirak.Name = "lbl_lokasirak"
        Me.lbl_lokasirak.Size = New System.Drawing.Size(130, 18)
        Me.lbl_lokasirak.TabIndex = 30
        Me.lbl_lokasirak.Text = "ini nama koleksi"
        '
        'lbl_tanggalmasuk
        '
        Me.lbl_tanggalmasuk.AutoSize = True
        Me.lbl_tanggalmasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggalmasuk.Location = New System.Drawing.Point(362, 357)
        Me.lbl_tanggalmasuk.Name = "lbl_tanggalmasuk"
        Me.lbl_tanggalmasuk.Size = New System.Drawing.Size(130, 18)
        Me.lbl_tanggalmasuk.TabIndex = 31
        Me.lbl_tanggalmasuk.Text = "ini nama koleksi"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.Location = New System.Drawing.Point(362, 395)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(130, 18)
        Me.lbl_stock.TabIndex = 32
        Me.lbl_stock.Text = "ini nama koleksi"
        '
        'lbl_bahasa
        '
        Me.lbl_bahasa.AutoSize = True
        Me.lbl_bahasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bahasa.Location = New System.Drawing.Point(362, 433)
        Me.lbl_bahasa.Name = "lbl_bahasa"
        Me.lbl_bahasa.Size = New System.Drawing.Size(130, 18)
        Me.lbl_bahasa.TabIndex = 33
        Me.lbl_bahasa.Text = "ini nama koleksi"
        '
        'ListBoxKategori
        '
        Me.ListBoxKategori.FormattingEnabled = True
        Me.ListBoxKategori.Location = New System.Drawing.Point(365, 471)
        Me.ListBoxKategori.Name = "ListBoxKategori"
        Me.ListBoxKategori.Size = New System.Drawing.Size(132, 95)
        Me.ListBoxKategori.TabIndex = 34
        '
        'btn_tutup_info
        '
        Me.btn_tutup_info.Location = New System.Drawing.Point(142, 543)
        Me.btn_tutup_info.Name = "btn_tutup_info"
        Me.btn_tutup_info.Size = New System.Drawing.Size(75, 23)
        Me.btn_tutup_info.TabIndex = 35
        Me.btn_tutup_info.Text = "Tutup"
        Me.btn_tutup_info.UseVisualStyleBackColor = True
        '
        'bookpicture
        '
        Me.bookpicture.Location = New System.Drawing.Point(12, 12)
        Me.bookpicture.Name = "bookpicture"
        Me.bookpicture.Size = New System.Drawing.Size(108, 92)
        Me.bookpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bookpicture.TabIndex = 13
        Me.bookpicture.TabStop = False
        '
        'FormInfoKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 666)
        Me.Controls.Add(Me.btn_tutup_info)
        Me.Controls.Add(Me.ListBoxKategori)
        Me.Controls.Add(Me.lbl_bahasa)
        Me.Controls.Add(Me.lbl_stock)
        Me.Controls.Add(Me.lbl_tanggalmasuk)
        Me.Controls.Add(Me.lbl_lokasirak)
        Me.Controls.Add(Me.lbl_tahunterbit)
        Me.Controls.Add(Me.lbl_penerbit)
        Me.Controls.Add(Me.lbl_deskripsi)
        Me.Controls.Add(Me.lbl_jeniskoleksi)
        Me.Controls.Add(Me.lbl_namakoleksi)
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
        Me.Controls.Add(Me.bookpicture)
        Me.Name = "FormInfoKoleksi"
        Me.Text = "FormInfoKoleksi"
        CType(Me.bookpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bookpicture As PictureBox
    Friend WithEvents lbl_namakoleksi As Label
    Friend WithEvents lbl_jeniskoleksi As Label
    Friend WithEvents lbl_deskripsi As Label
    Friend WithEvents lbl_penerbit As Label
    Friend WithEvents lbl_tahunterbit As Label
    Friend WithEvents lbl_lokasirak As Label
    Friend WithEvents lbl_tanggalmasuk As Label
    Friend WithEvents lbl_stock As Label
    Friend WithEvents lbl_bahasa As Label
    Friend WithEvents ListBoxKategori As ListBox
    Friend WithEvents btn_tutup_info As Button
End Class
