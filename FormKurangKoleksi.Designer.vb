﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKurangKoleksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_hapus = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Ingin Menghapus Koleksi"
        '
        'lbl_hapus
        '
        Me.lbl_hapus.AutoSize = True
        Me.lbl_hapus.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hapus.Location = New System.Drawing.Point(118, 152)
        Me.lbl_hapus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_hapus.Name = "lbl_hapus"
        Me.lbl_hapus.Size = New System.Drawing.Size(239, 41)
        Me.lbl_hapus.TabIndex = 1
        Me.lbl_hapus.Text = "Hapus Koleksi"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 269)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormKurangKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 385)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_hapus)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormKurangKoleksi"
        Me.Text = "HapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_hapus As Label
    Friend WithEvents Button1 As Button
End Class
