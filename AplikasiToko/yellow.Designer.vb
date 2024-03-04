<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class yellow
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
        Me.TextBoxIDCari = New System.Windows.Forms.TextBox()
        Me.TextBoxBarang = New System.Windows.Forms.TextBox()
        Me.TextBoxBrand = New System.Windows.Forms.TextBox()
        Me.TextBoxKategori = New System.Windows.Forms.TextBox()
        Me.TextBoxExpired = New System.Windows.Forms.TextBox()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.ButtonBeli = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonRestok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxIDCari
        '
        Me.TextBoxIDCari.Location = New System.Drawing.Point(86, 12)
        Me.TextBoxIDCari.Name = "TextBoxIDCari"
        Me.TextBoxIDCari.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxIDCari.TabIndex = 0
        '
        'TextBoxBarang
        '
        Me.TextBoxBarang.Location = New System.Drawing.Point(176, 62)
        Me.TextBoxBarang.Name = "TextBoxBarang"
        Me.TextBoxBarang.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxBarang.TabIndex = 1
        '
        'TextBoxBrand
        '
        Me.TextBoxBrand.Location = New System.Drawing.Point(176, 88)
        Me.TextBoxBrand.Name = "TextBoxBrand"
        Me.TextBoxBrand.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxBrand.TabIndex = 2
        '
        'TextBoxKategori
        '
        Me.TextBoxKategori.Location = New System.Drawing.Point(176, 114)
        Me.TextBoxKategori.Name = "TextBoxKategori"
        Me.TextBoxKategori.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxKategori.TabIndex = 3
        '
        'TextBoxExpired
        '
        Me.TextBoxExpired.Location = New System.Drawing.Point(176, 140)
        Me.TextBoxExpired.Name = "TextBoxExpired"
        Me.TextBoxExpired.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxExpired.TabIndex = 4
        '
        'ButtonCari
        '
        Me.ButtonCari.Location = New System.Drawing.Point(247, 12)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCari.TabIndex = 5
        Me.ButtonCari.Text = "Cari"
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'ButtonBeli
        '
        Me.ButtonBeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBeli.Location = New System.Drawing.Point(43, 253)
        Me.ButtonBeli.Name = "ButtonBeli"
        Me.ButtonBeli.Size = New System.Drawing.Size(87, 37)
        Me.ButtonBeli.TabIndex = 6
        Me.ButtonBeli.Text = "Beli"
        Me.ButtonBeli.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(133, 253)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(91, 37)
        Me.ButtonClear.TabIndex = 7
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonRestok
        '
        Me.ButtonRestok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRestok.Location = New System.Drawing.Point(230, 253)
        Me.ButtonRestok.Name = "ButtonRestok"
        Me.ButtonRestok.Size = New System.Drawing.Size(92, 37)
        Me.ButtonRestok.TabIndex = 8
        Me.ButtonRestok.Text = "Restok"
        Me.ButtonRestok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(39, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(39, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(39, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(39, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Expired"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(39, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Status"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelStatus.Location = New System.Drawing.Point(170, 187)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 20)
        Me.LabelStatus.TabIndex = 14
        '
        'yellow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(369, 334)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRestok)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonBeli)
        Me.Controls.Add(Me.ButtonCari)
        Me.Controls.Add(Me.TextBoxExpired)
        Me.Controls.Add(Me.TextBoxKategori)
        Me.Controls.Add(Me.TextBoxBrand)
        Me.Controls.Add(Me.TextBoxBarang)
        Me.Controls.Add(Me.TextBoxIDCari)
        Me.Name = "yellow"
        Me.Text = "yellow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxIDCari As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBarang As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBrand As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKategori As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxExpired As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents ButtonBeli As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonRestok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
End Class
