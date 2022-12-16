<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.lbl_hapus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_daftar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_hapus
        '
        Me.lbl_hapus.AutoSize = True
        Me.lbl_hapus.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hapus.Location = New System.Drawing.Point(36, 50)
        Me.lbl_hapus.Name = "lbl_hapus"
        Me.lbl_hapus.Size = New System.Drawing.Size(84, 21)
        Me.lbl_hapus.TabIndex = 2
        Me.lbl_hapus.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(151, 50)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(160, 20)
        Me.txt_username.TabIndex = 4
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(151, 105)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(160, 20)
        Me.txt_password.TabIndex = 5
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(236, 148)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_daftar
        '
        Me.btn_daftar.Location = New System.Drawing.Point(151, 148)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(75, 23)
        Me.btn_daftar.TabIndex = 7
        Me.btn_daftar.Text = "Daftar"
        Me.btn_daftar.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 183)
        Me.Controls.Add(Me.btn_daftar)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_hapus)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_hapus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_daftar As Button
End Class
