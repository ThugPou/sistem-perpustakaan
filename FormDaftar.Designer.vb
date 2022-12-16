<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftar
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
        Me.txt_passworddaftar = New System.Windows.Forms.TextBox()
        Me.txt_usernamedaftar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_hapus = New System.Windows.Forms.Label()
        Me.btn_daftarform = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_passworddaftar
        '
        Me.txt_passworddaftar.Location = New System.Drawing.Point(147, 104)
        Me.txt_passworddaftar.Name = "txt_passworddaftar"
        Me.txt_passworddaftar.Size = New System.Drawing.Size(160, 20)
        Me.txt_passworddaftar.TabIndex = 9
        '
        'txt_usernamedaftar
        '
        Me.txt_usernamedaftar.Location = New System.Drawing.Point(147, 49)
        Me.txt_usernamedaftar.Name = "txt_usernamedaftar"
        Me.txt_usernamedaftar.Size = New System.Drawing.Size(160, 20)
        Me.txt_usernamedaftar.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Password"
        '
        'lbl_hapus
        '
        Me.lbl_hapus.AutoSize = True
        Me.lbl_hapus.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hapus.Location = New System.Drawing.Point(34, 47)
        Me.lbl_hapus.Name = "lbl_hapus"
        Me.lbl_hapus.Size = New System.Drawing.Size(84, 21)
        Me.lbl_hapus.TabIndex = 6
        Me.lbl_hapus.Text = "Username"
        '
        'btn_daftarform
        '
        Me.btn_daftarform.Location = New System.Drawing.Point(232, 155)
        Me.btn_daftarform.Name = "btn_daftarform"
        Me.btn_daftarform.Size = New System.Drawing.Size(75, 23)
        Me.btn_daftarform.TabIndex = 10
        Me.btn_daftarform.Text = "Daftar"
        Me.btn_daftarform.UseVisualStyleBackColor = True
        '
        'FormDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 214)
        Me.Controls.Add(Me.btn_daftarform)
        Me.Controls.Add(Me.txt_passworddaftar)
        Me.Controls.Add(Me.txt_usernamedaftar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_hapus)
        Me.Name = "FormDaftar"
        Me.Text = "Daftar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_passworddaftar As TextBox
    Friend WithEvents txt_usernamedaftar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_hapus As Label
    Friend WithEvents btn_daftarform As Button
End Class
