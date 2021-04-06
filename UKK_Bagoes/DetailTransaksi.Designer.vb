<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailTransaksi
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtpaket = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txttransaksi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttotalrp = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbiaya = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtpajak = New System.Windows.Forms.TextBox()
        Me.txtdiskon = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtket = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txthargarp = New System.Windows.Forms.TextBox()
        Me.txtbiayarp = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtnamapaket = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 317)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1149, 325)
        Me.DataGridView1.TabIndex = 0
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(55, 286)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(112, 20)
        Me.txtcari.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("FontAwesome", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(22, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 21)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = ""
        '
        'btnbatal
        '
        Me.btnbatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnbatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnbatal.Location = New System.Drawing.Point(1097, 285)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 50
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnhapus.Location = New System.Drawing.Point(333, 285)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 49
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnubah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnubah.Location = New System.Drawing.Point(253, 285)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 48
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btntambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btntambah.Location = New System.Drawing.Point(173, 285)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 47
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'txtpaket
        '
        Me.txtpaket.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtpaket.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtpaket.Location = New System.Drawing.Point(173, 130)
        Me.txtpaket.Name = "txtpaket"
        Me.txtpaket.Size = New System.Drawing.Size(100, 20)
        Me.txtpaket.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(34, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(885, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 31)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(35, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "ID Paket"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(34, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "ID Transaksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(12, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 18)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Detail Transaksi"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(173, 62)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 53
        '
        'txttransaksi
        '
        Me.txttransaksi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txttransaksi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txttransaksi.Location = New System.Drawing.Point(173, 96)
        Me.txttransaksi.Name = "txttransaksi"
        Me.txttransaksi.Size = New System.Drawing.Size(100, 20)
        Me.txttransaksi.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "ID Detail"
        '
        'txttotalrp
        '
        Me.txttotalrp.Enabled = False
        Me.txttotalrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalrp.Location = New System.Drawing.Point(988, 58)
        Me.txttotalrp.Name = "txttotalrp"
        Me.txttotalrp.Size = New System.Drawing.Size(156, 38)
        Me.txttotalrp.TabIndex = 58
        '
        'txtharga
        '
        Me.txtharga.Enabled = False
        Me.txtharga.Location = New System.Drawing.Point(298, 197)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(120, 20)
        Me.txtharga.TabIndex = 60
        Me.txtharga.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(34, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(745, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 20)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "%"
        '
        'txtbiaya
        '
        Me.txtbiaya.Enabled = False
        Me.txtbiaya.Location = New System.Drawing.Point(820, 96)
        Me.txtbiaya.Name = "txtbiaya"
        Me.txtbiaya.Size = New System.Drawing.Size(100, 20)
        Me.txtbiaya.TabIndex = 93
        Me.txtbiaya.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(575, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Biaya Tambahan"
        '
        'txtpajak
        '
        Me.txtpajak.Enabled = False
        Me.txtpajak.Location = New System.Drawing.Point(714, 164)
        Me.txtpajak.Name = "txtpajak"
        Me.txtpajak.Size = New System.Drawing.Size(25, 20)
        Me.txtpajak.TabIndex = 91
        Me.txtpajak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdiskon
        '
        Me.txtdiskon.Enabled = False
        Me.txtdiskon.Location = New System.Drawing.Point(714, 130)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(25, 20)
        Me.txtdiskon.TabIndex = 90
        Me.txtdiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(575, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 20)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Pajak"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Location = New System.Drawing.Point(575, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 20)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "Diskon"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(745, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 20)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "%"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Location = New System.Drawing.Point(279, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(268, 18)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "*Tekan T Untuk Menampilkan Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(279, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(268, 18)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "*Tekan P Untuk Menampilkan Data"
        '
        'txtket
        '
        Me.txtket.Location = New System.Drawing.Point(172, 230)
        Me.txtket.Name = "txtket"
        Me.txtket.Size = New System.Drawing.Size(217, 20)
        Me.txtket.TabIndex = 98
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(714, 62)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(35, 20)
        Me.txtjumlah.TabIndex = 100
        Me.txtjumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(575, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Jumlah"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(755, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 20)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Kg"
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(988, 102)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(156, 38)
        Me.txttotal.TabIndex = 102
        Me.txttotal.Visible = False
        '
        'txthargarp
        '
        Me.txthargarp.Enabled = False
        Me.txthargarp.Location = New System.Drawing.Point(172, 197)
        Me.txthargarp.Name = "txthargarp"
        Me.txthargarp.Size = New System.Drawing.Size(120, 20)
        Me.txthargarp.TabIndex = 103
        '
        'txtbiayarp
        '
        Me.txtbiayarp.Enabled = False
        Me.txtbiayarp.Location = New System.Drawing.Point(714, 96)
        Me.txtbiayarp.Name = "txtbiayarp"
        Me.txtbiayarp.Size = New System.Drawing.Size(100, 20)
        Me.txtbiayarp.TabIndex = 104
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(34, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 20)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Nama Paket"
        '
        'txtnamapaket
        '
        Me.txtnamapaket.Location = New System.Drawing.Point(172, 162)
        Me.txtnamapaket.Name = "txtnamapaket"
        Me.txtnamapaket.Size = New System.Drawing.Size(147, 20)
        Me.txtnamapaket.TabIndex = 105
        '
        'DetailTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1193, 663)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtnamapaket)
        Me.Controls.Add(Me.txtbiayarp)
        Me.Controls.Add(Me.txthargarp)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtket)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbiaya)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtpajak)
        Me.Controls.Add(Me.txtdiskon)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttotalrp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttransaksi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtpaket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DetailTransaksi"
        Me.Text = "Detail Transaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents txtpaket As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txttransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotalrp As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtpajak As System.Windows.Forms.TextBox
    Friend WithEvents txtdiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtket As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txthargarp As System.Windows.Forms.TextBox
    Friend WithEvents txtbiayarp As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtnamapaket As System.Windows.Forms.TextBox

End Class
