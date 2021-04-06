Imports System.Data.SqlClient
Public Class Transaksi
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_transaksi"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Transaksi"
        DataGridView1.Columns(1).HeaderText = "ID Outlet"
        DataGridView1.Columns(2).HeaderText = "Kode Invoice"
        DataGridView1.Columns(3).HeaderText = "ID Member"
        DataGridView1.Columns(4).HeaderText = "Tanggal"
        DataGridView1.Columns(5).HeaderText = "Batas Waktu"
        DataGridView1.Columns(6).HeaderText = "Tanggal Bayar"
        DataGridView1.Columns(7).HeaderText = "Biaya Tambahan"
        DataGridView1.Columns(8).HeaderText = "Diskon"
        DataGridView1.Columns(9).HeaderText = "Pajak"
        DataGridView1.Columns(10).HeaderText = "Status"
        DataGridView1.Columns(11).HeaderText = "Dibayar"
        DataGridView1.Columns(12).HeaderText = "ID User"
    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ERIN8O5;Initial Catalog=db_UKK_Bagoes;Integrated Security=True"
        Call tampildata()
        Call KondisiAwal()
        Call auto_outlet()
        Call auto_member()
        Call auto_user()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid.Text = DataGridView1.SelectedCells(0).Value
        txtoutlet.Text = DataGridView1.SelectedCells(1).Value
        txtinvoice.Text = DataGridView1.SelectedCells(2).Value
        txtmember.Text = DataGridView1.SelectedCells(3).Value
        DateTimePicker1.Text = DataGridView1.SelectedCells(4).Value
        DateTimePicker2.Text = DataGridView1.SelectedCells(5).Value
        DateTimePicker3.Text = DataGridView1.SelectedCells(6).Value
        txtbiaya.Text = DataGridView1.SelectedCells(7).Value
        txtdiskon.Text = DataGridView1.SelectedCells(8).Value
        txtpajak.Text = DataGridView1.SelectedCells(9).Value
        cbstatus.Text = DataGridView1.SelectedCells(10).Value
        cbdibayar.Text = DataGridView1.SelectedCells(11).Value
        txtuser.Text = DataGridView1.SelectedCells(12).Value
    End Sub

    Sub KondisiAwal()
        txtid.Text = ""
        txtoutlet.Text = ""
        txtnamaoutlet.Text = ""
        txtinvoice.Text = ""
        txtmember.Text = ""
        txtnamamember.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
        DateTimePicker3.Text = ""
        txtbiaya.Text = ""
        txtbiayarp.Text = ""
        txtdiskon.Text = ""
        txtpajak.Text = "1"
        cbstatus.Text = ""
        cbdibayar.Text = ""
        txtuser.Text = ""
        txtnamauser.Text = ""

        txtid.Enabled = False
        txtoutlet.Enabled = False
        txtnamaoutlet.Enabled = False
        txtinvoice.Enabled = False
        txtmember.Enabled = False
        txtnamamember.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DateTimePicker3.Enabled = False
        txtbiaya.Enabled = False
        txtdiskon.Enabled = False
        txtpajak.Enabled = False
        cbstatus.Enabled = False
        cbdibayar.Enabled = False
        txtuser.Enabled = False
        txtuser.Enabled = False

        DataGridView1.Enabled = False

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

        btntambah.Location = New Point(229, 504)
        btnubah.Location = New Point(339, 504)
        btnhapus.Location = New Point(449, 504)
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtoutlet.Text = ""
        txtnamaoutlet.Text = ""
        txtinvoice.Text = ""
        txtmember.Text = ""
        txtnamamember.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
        DateTimePicker3.Text = ""
        txtbiaya.Text = ""
        txtdiskon.Text = ""
        txtpajak.Text = ""
        cbstatus.Text = ""
        cbdibayar.Text = ""
        txtuser.Text = ""
        txtnamauser.Text = ""
    End Sub

    Sub FieldTambahAndUbah()
        txtid.Enabled = False
        txtoutlet.Enabled = True
        txtnamauser.Enabled = False
        txtinvoice.Enabled = False
        txtmember.Enabled = True
        txtnamamember.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = True
        DateTimePicker3.Enabled = True
        txtbiaya.Enabled = True
        txtdiskon.Enabled = True
        txtpajak.Enabled = False
        cbstatus.Enabled = True
        cbdibayar.Enabled = True
        txtuser.Enabled = True
        txtnamauser.Enabled = False
        txtoutlet.Focus()
    End Sub

    Sub FieldDisable()
        txtid.Enabled = False
        txtoutlet.Enabled = False
        txtnamaoutlet.Enabled = False
        txtinvoice.Enabled = False
        txtmember.Enabled = False
        txtnamamember.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DateTimePicker3.Enabled = False
        txtbiaya.Enabled = False
        txtdiskon.Enabled = False
        txtpajak.Enabled = False
        cbstatus.Enabled = False
        cbdibayar.Enabled = False
        txtuser.Enabled = False
        txtnamauser.Enabled = False
    End Sub

    Sub DataGridViewAktif()
        DataGridView1.Enabled = True
    End Sub

    Sub kodeotomatisid()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_transaksi FROM tb_transaksi"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_transaksi").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid.Text = "TR-0" + Trim(Str(kodeauto))
            Case 2 : txtid.Text = "TR-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Sub kodeotomatisinvoice()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS kode_invoice FROM tb_transaksi"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("kode_invoice").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtinvoice.Text = "INV-0" + Trim(Str(kodeauto))
            Case 2 : txtinvoice.Text = "INV-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    'Outlet
    Sub auto_outlet()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM tb_outlet", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtoutlet.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtoutlet.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txtoutlet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtoutlet.KeyPress
        e.KeyChar = Chr(79)
        txtoutlet.MaxLength = 1
    End Sub

    Private Sub txt_outlet(sender As Object, e As EventArgs) Handles txtoutlet.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_outlet WHERE id_outlet = '" & txtoutlet.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        If rd.Read Then
            txtnamaoutlet.Text = rd("nama")
        End If
        rd.Close()
        cn.Close()
    End Sub

    'Member
    Sub auto_member()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM tb_member", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtmember.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtmember.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txtmember_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmember.KeyPress
        e.KeyChar = Chr(77)
        txtmember.MaxLength = 1
    End Sub

    Private Sub txt_member(sender As Object, e As EventArgs) Handles txtmember.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_member WHERE id_member = '" & txtmember.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        If rd.Read Then
            txtnamamember.Text = rd("nama")
        End If
        rd.Close()
        cn.Close()
    End Sub

    'User
    Sub auto_user()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM tb_user", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtuser.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtuser.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        e.KeyChar = Chr(85)
        txtuser.MaxLength = 1
    End Sub

    Private Sub txt_user(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_user WHERE id_user = '" & txtuser.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        If rd.Read Then
            txtnamauser.Text = rd("nama")
        End If
        rd.Close()
        cn.Close()
    End Sub

    'CRUD
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Text = "Simpan"
            btntambah.Location = New Point(229, 504)
            btnubah.Visible = False
            btnhapus.Visible = False
            btnbatal.Text = "Batal"
            Call FieldTambahAndUbah()
            Call kodeotomatisid()
            Call kodeotomatisinvoice()
        Else
            If txtid.Text = "" Or txtoutlet.Text = "" Or txtinvoice.Text = "" Or txtmember.Text = "" Or DateTimePicker1.Text = "" Or DateTimePicker2.Text = "" Or DateTimePicker3.Text = "" Or txtbiaya.Text = "" Or txtdiskon.Text = "" Or txtpajak.Text = "" Or cbstatus.Text = "" Or cbdibayar.Text = "" Or txtuser.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            ElseIf txtid.Text <> "" Then
                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = "INSERT INTO tb_transaksi VALUES ('" & txtid.Text & "','" & txtoutlet.Text & "','" & txtinvoice.Text & "','" & txtmember.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & DateTimePicker3.Text & "','" & txtbiaya.Text & "','" & txtdiskon.Text & "','" & txtpajak.Text & "','" & cbstatus.Text & "','" & cbdibayar.Text & "','" & txtuser.Text & "')"
                cmd.ExecuteNonQuery()
                cn.Close()
                bersih()
                tampildata()
                Call KondisiAwal()
                MsgBox("Data Transaksi Berhasil Tersimpan, Silahkan Memasukkan Detail Transaksi", MsgBoxStyle.Information)
                HalamanUtama.OpenChildForm(New DetailTransaksi)
                HalamanUtama.hideSubMenu()
            End If
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If btnubah.Text = "Ubah" Then
            btnubah.Text = "Simpan"
            btnubah.Location = New Point(229, 504)
            btntambah.Visible = False
            btnhapus.Visible = False
            btnbatal.Text = "Batal"
            Call FieldTambahAndUbah()
            Call DataGridViewAktif()
        Else
            If txtid.Text = "" Or txtoutlet.Text = "" Or txtinvoice.Text = "" Or txtmember.Text = "" Or DateTimePicker1.Text = "" Or DateTimePicker2.Text = "" Or DateTimePicker3.Text = "" Or txtbiaya.Text = "" Or txtdiskon.Text = "" Or txtpajak.Text = "" Or cbstatus.Text = "" Or cbdibayar.Text = "" Or txtuser.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            ElseIf txtid.Text <> "" Then
                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = "UPDATE tb_transaksi SET id_outlet ='" & txtoutlet.Text & "', kode_invoice ='" & txtinvoice.Text & "', id_member = '" & txtmember.Text & "', tgl = '" & DateTimePicker1.Value &
                    "', batas_waktu = '" & DateTimePicker2.Value & "', tgl_bayar = '" & DateTimePicker3.Value & "', biaya_tambahan = '" & txtbiaya.Text & "', diskon = '" & txtdiskon.Text &
                    "', pajak = '" & txtpajak.Text & "', status = '" & cbstatus.Text & "', dibayar = '" & cbdibayar.Text & "', id_user = '" & txtuser.Text & "' WHERE id_transaksi = '" & txtid.Text & "'"
                cmd.ExecuteNonQuery()
                cn.Close()
                bersih()
                MsgBox("Data Transaksi Berhasil Terubah", MsgBoxStyle.Information)
                tampildata()
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If btnhapus.Text = "Hapus" Then
            btnhapus.Text = "Buang"
            btnhapus.Location = New Point(229, 504)
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
            cmd.CommandText = "DELETE FROM tb_transaksi WHERE id_transaksi = '" + id + "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Data Transaksi Berhasil Terhapus", MsgBoxStyle.Information)
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
        cmd.CommandText = "SELECT * FROM tb_transaksi WHERE id_transaksi LIKE '%" & txtcari.Text & "%' OR id_outlet LIKE '%" & txtcari.Text & "%' OR kode_invoice LIKE '%" & txtcari.Text & "%' OR id_member LIKE '%" & txtcari.Text & "%' OR status LIKE '%" & txtcari.Text & "%' OR dibayar LIKE '%" & txtcari.Text & "%' OR id_user LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub txtbiaya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbiaya.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtdiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiskon.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub cbstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbstatus.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cbdibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbdibayar.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txtbiaya_TextChanged(sender As Object, e As EventArgs) Handles txtbiaya.TextChanged
        Try
            Dim biaya As Integer
            biaya = txtbiaya.Text
            txtbiayarp.Text = "Rp " + FormatNumber(biaya, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub
End Class
