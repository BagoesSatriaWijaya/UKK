Imports System.Data.SqlClient
Public Class DetailTransaksi
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_detail_transaksi"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Detail Transaksi"
        DataGridView1.Columns(1).HeaderText = "ID Transaksi"
        DataGridView1.Columns(2).HeaderText = "ID Paket"
        DataGridView1.Columns(3).HeaderText = "Jumlah"
        DataGridView1.Columns(4).HeaderText = "Total"
        DataGridView1.Columns(5).HeaderText = "Keterangan"
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ERIN8O5;Initial Catalog=db_UKK_Bagoes;Integrated Security=True"
        Call tampildata()
        Call KondisiAwal()
        Call auto_paket()
        Call auto_transaksi()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid.Text = DataGridView1.SelectedCells(0).Value
        txttransaksi.Text = DataGridView1.SelectedCells(1).Value
        txtpaket.Text = DataGridView1.SelectedCells(2).Value
        txtjumlah.Text = DataGridView1.SelectedCells(3).Value
        txttotal.Text = DataGridView1.SelectedCells(4).Value
        txtket.Text = DataGridView1.SelectedCells(5).Value
    End Sub

    Sub KondisiAwal()
        txtid.Text = ""
        txttransaksi.Text = ""
        txtpaket.Text = ""
        txtnamapaket.Text = ""
        txtharga.Text = ""
        txthargarp.Text = ""
        txtket.Text = ""
        txtjumlah.Text = ""
        txtbiaya.Text = ""
        txtbiayarp.Text = ""
        txtdiskon.Text = ""
        txtpajak.Text = ""
        txttotal.Text = ""
        txttotalrp.Text = ""

        DataGridView1.Enabled = False

        txtid.Enabled = False
        txttransaksi.Enabled = False
        txtpaket.Enabled = False
        txtnamapaket.Enabled = False
        txtharga.Enabled = False
        txtket.Enabled = False
        txtjumlah.Enabled = False
        txtbiaya.Enabled = False
        txtdiskon.Enabled = False
        txtpajak.Enabled = False
        txttotal.Enabled = False

        btntambah.Text = "Tambah"
        btnubah.Text = "Ubah"
        btnhapus.Text = "Hapus"
        btnbatal.Text = "Tutup"

        btntambah.Enabled = True
        btnubah.Enabled = True
        btnhapus.Enabled = True
        btnbatal.Enabled = True

        btntambah.Visible = True
        btnubah.Visible = True
        btnhapus.Visible = True
        btnbatal.Visible = True

        btntambah.Location = New Point(229, 350)
        btnubah.Location = New Point(339, 350)
        btnhapus.Location = New Point(449, 350)
    End Sub

    Sub bersih()
        txtid.Text = ""
        txttransaksi.Text = ""
        txtpaket.Text = ""
        txtnamapaket.Text = ""
        txtharga.Text = ""
        txtket.Text = ""
        txtjumlah.Text = ""
        txtbiaya.Text = ""
        txtdiskon.Text = ""
        txtpajak.Text = ""
        txttotal.Text = ""
    End Sub

    Sub FieldTambahdanEdit()
        txtid.Enabled = False
        txttransaksi.Enabled = True
        txtpaket.Enabled = True
        txtnamapaket.Enabled = False
        txtharga.Enabled = False
        txtket.Enabled = True
        txtjumlah.Enabled = True
        txtbiaya.Enabled = False
        txtdiskon.Enabled = False
        txtpajak.Enabled = False
        txttotal.Enabled = False
        txttransaksi.Focus()
    End Sub

    Sub FieldDisable()
        txtid.Enabled = False
        txttransaksi.Enabled = False
        txtpaket.Enabled = False
        txtnamapaket.Enabled = False
        txtharga.Enabled = False
        txtket.Enabled = False
        txtjumlah.Enabled = False
        txtbiaya.Enabled = False
        txtdiskon.Enabled = False
        txtpajak.Enabled = False
        txttotal.Enabled = False
    End Sub

    Sub DataGridViewAktif()
        DataGridView1.Enabled = True
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_detail FROM tb_detail_transaksi"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_detail").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid.Text = "DT-0" + Trim(Str(kodeauto))
            Case 2 : txtid.Text = "DT-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    'Transaksi
    Sub auto_transaksi()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM tb_transaksi", cn)
            da.Fill(dt)
            Dim r As DataRow
            txttransaksi.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txttransaksi.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txttransaksi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttransaksi.KeyPress
        e.KeyChar = Chr(84)
        txttransaksi.MaxLength = 1
    End Sub

    Private Sub txt_transaksi(sender As Object, e As EventArgs) Handles txttransaksi.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_transaksi WHERE id_transaksi = '" & txttransaksi.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        If rd.Read Then
            txtbiaya.Text = rd("biaya_tambahan")
            txtdiskon.Text = rd("diskon")
            txtpajak.Text = rd("pajak")
        End If
        rd.Close()
        cn.Close()
    End Sub

    'Paket
    Sub auto_paket()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM tb_paket", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtpaket.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtpaket.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txtpaket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpaket.KeyPress
        e.KeyChar = Chr(80)
        txtpaket.MaxLength = 1
    End Sub

    Private Sub txt_paket(sender As Object, e As EventArgs) Handles txtpaket.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_paket WHERE id_paket = '" & txtpaket.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        If rd.Read Then
            txtharga.Text = rd("harga")
            txtnamapaket.Text = rd("nama_paket")
        End If
        rd.Close()
        cn.Close()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Text = "Simpan"
            btntambah.Location = New Point(229, 350)
            btnubah.Visible = False
            btnhapus.Visible = False
            btnbatal.Text = "Batal"
            Call FieldTambahdanEdit()
            Call kodeotomatis()
        Else
            If txtid.Text = "" Or txttransaksi.Text = "" Or txtpaket.Text = "" Or txttotal.Text = "" Or txtket.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            Else
                Call Koneksi()
                cmd = New SqlCommand("Select * from tb_detail_transaksi where id_transaksi='" & txttransaksi.Text & "'", Conn)
                Rd = cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("ID Transaksi Sudah Diinput, Silahkan Masukkan ID Transaksi yang Lain")
                    txttransaksi.Clear()
                    txttransaksi.Focus()
                Else
                    cn.Open()
                    cmd.Connection = cn
                    cmd.CommandText = "INSERT INTO tb_detail_transaksi VALUES ('" & txtid.Text & "','" & txttransaksi.Text & "','" & txtpaket.Text & "','" & txtjumlah.Text & "','" & txttotal.Text & "','" & txtket.Text & "')"
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    bersih()
                    MsgBox("Data Detail Transaksi Berhasil Tersimpan", MsgBoxStyle.Information)
                    tampildata()
                    Call KondisiAwal()
                End If
            End If
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If btnubah.Text = "Ubah" Then
            btnubah.Text = "Simpan"
            btnubah.Location = New Point(229, 350)
            btntambah.Visible = False
            btnhapus.Visible = False
            btnbatal.Text = "Batal"
            Call FieldTambahdanEdit()
            Call DataGridViewAktif()
        Else
            If txtid.Text = "" Or txttransaksi.Text = "" Or txtpaket.Text = "" Or txttotal.Text = "" Or txtket.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            Else
                Call Koneksi()
                cmd = New SqlCommand("Select * from tb_detail_transaksi where id_transaksi='" & txttransaksi.Text & "'", Conn)
                Rd = cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("ID Transaksi Sudah Diinput, Silahkan Masukkan ID Transaksi yang Lain")
                    txttransaksi.Clear()
                    txttransaksi.Focus()
                Else
                    cn.Open()
                    cmd.Connection = cn
                    cmd.CommandText = "UPDATE tb_detail_transaksi SET id_transaksi ='" & txttransaksi.Text & "', id_paket = '" & txtpaket.Text & "', jumlah = '" & txtjumlah.Text & "', total = '" & txttotal.Text & "', keterangan = '" & txtket.Text & "' WHERE id_detail = '" & txtid.Text & "'"
                    cmd.ExecuteNonQuery()

                    cn.Close()
                    bersih()
                    MsgBox("Data Detail Transaksi Berhasil Terubah", MsgBoxStyle.Information)
                    tampildata()
                    Call KondisiAwal()
                End If
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If btnhapus.Text = "Hapus" Then
            btnhapus.Text = "Buang"
            btnhapus.Location = New Point(229, 350)
            btntambah.Visible = False
            btnubah.Visible = False
            btnbatal.Text = "Batal"
            Call FieldDisable()
            Call DataGridViewAktif()
        Else
            Dim baris As Integer
            Dim id As String

            baris = DataGridView1.CurrentCell.RowIndex
            id = DataGridView1(0, baris).Value.ToString

            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "DELETE FROM tb_detail_transaksi WHERE id_detail = '" + id + "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Data Detail Transaksi Berhasil Terhapus", MsgBoxStyle.Information)
            tampildata()
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        If btnbatal.Text = "Tutup" Then
            Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_detail_transaksi WHERE id_detail LIKE '%" & txtcari.Text & "%' OR id_transaksi LIKE '%" & txtcari.Text & "%' OR id_paket LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Sub hitung()
        Dim diskon1, hasildiskon, hasilharga, hasilpajak, total, angka1, angka2, angka3, angka4, angka5 As Integer

        angka1 = Val(txtharga.Text)
        angka2 = Val(txtjumlah.Text)
        angka3 = Val(txtbiaya.Text)
        angka4 = Val(txtdiskon.Text)
        angka5 = Val(txtpajak.Text)

        hasilharga = angka1 * angka2
        'Rumus Diskon
        diskon1 = hasilharga * (angka4 * "0.01")
        hasildiskon = hasilharga - diskon1

        'Rumus Pajak
        hasilpajak = hasildiskon * "0.01" + hasildiskon

        total = hasilpajak + angka3

        txttotal.Text = total
        'txttotal.Text = Format(Val(txttotal.Text), "Rp, ###,###.#0")
    End Sub

    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged
        Call hitung()
    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        Call hitung()
        Try
            Dim total As Integer
            total = txtharga.Text
            txthargarp.Text = "Rp " + FormatNumber(total, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbiaya_TextChanged(sender As Object, e As EventArgs) Handles txtbiaya.TextChanged
        Call hitung()
        Try
            Dim total As Integer
            total = txtbiaya.Text
            txtbiayarp.Text = "Rp " + FormatNumber(total, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtdiskon_TextChanged(sender As Object, e As EventArgs) Handles txtdiskon.TextChanged
        Call hitung()
    End Sub

    Private Sub txtpajak_TextChanged(sender As Object, e As EventArgs) Handles txtpajak.TextChanged
        Call hitung()
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        Call hitung()
        Try
            Dim total As Integer
            total = txttotal.Text
            txttotalrp.Text = "Rp " + FormatNumber(total, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbiayarp_TextChanged(sender As Object, e As EventArgs) Handles txtbiayarp.TextChanged

    End Sub
End Class
