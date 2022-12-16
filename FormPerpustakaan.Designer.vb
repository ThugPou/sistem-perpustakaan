<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPerpustakaan
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstambahkoleksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbl_tambah = New System.Windows.Forms.Label()
        Me.lbl_kurang = New System.Windows.Forms.Label()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(2079, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstambahkoleksi})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'tstambahkoleksi
        '
        Me.tstambahkoleksi.Name = "tstambahkoleksi"
        Me.tstambahkoleksi.Size = New System.Drawing.Size(236, 34)
        Me.tstambahkoleksi.Text = "Tambah Koleksi"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(18, 77)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(132, 264)
        Me.ListBox1.TabIndex = 1
        '
        'lbl_tambah
        '
        Me.lbl_tambah.AutoSize = True
        Me.lbl_tambah.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_tambah.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_tambah.Location = New System.Drawing.Point(18, 37)
        Me.lbl_tambah.Name = "lbl_tambah"
        Me.lbl_tambah.Size = New System.Drawing.Size(18, 20)
        Me.lbl_tambah.TabIndex = 2
        Me.lbl_tambah.Text = "+"
        '
        'lbl_kurang
        '
        Me.lbl_kurang.AutoSize = True
        Me.lbl_kurang.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_kurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_kurang.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_kurang.Location = New System.Drawing.Point(42, 37)
        Me.lbl_kurang.Name = "lbl_kurang"
        Me.lbl_kurang.Size = New System.Drawing.Size(16, 22)
        Me.lbl_kurang.TabIndex = 3
        Me.lbl_kurang.Text = "-"
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(159, 77)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowHeadersWidth = 62
        Me.DataGridKoleksi.RowTemplate.Height = 28
        Me.DataGridKoleksi.Size = New System.Drawing.Size(1898, 255)
        Me.DataGridKoleksi.TabIndex = 37
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(188, 340)
        Me.btn_show.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(112, 35)
        Me.btn_show.TabIndex = 38
        Me.btn_show.Text = "Show"
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(326, 340)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 35)
        Me.btn_update.TabIndex = 39
        Me.btn_update.Text = "Uodate"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(471, 340)
        Me.btn_remove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(112, 35)
        Me.btn_remove.TabIndex = 40
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'FormPerpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2079, 411)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.lbl_kurang)
        Me.Controls.Add(Me.lbl_tambah)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPerpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tstambahkoleksi As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lbl_tambah As Label
    Friend WithEvents lbl_kurang As Label
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents btn_show As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_remove As Button
End Class
