Imports System.Data.SqlClient
Public Class Paket
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_paket"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Paket"
        DataGridView1.Columns(1).HeaderText = "ID Outlet"
        DataGridView1.Columns(2).HeaderText = "Jenis"
        DataGridView1.Columns(3).HeaderText = "Nama Paket"
        DataGridView1.Columns(4).HeaderText = "Harga"
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ERIN8O5;Initial Catalog=db_UKK_Bagoes;Integrated Security=True"
        Call tampildata()
        Call KondisiAwal()
        Call auto_outlet()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid.Text = DataGridView1.SelectedCells(0).Value
        txtoutlet.Text = DataGridView1.SelectedCells(1).Value
        cbjenis.Text = DataGridView1.SelectedCells(2).Value
        txtnama.Text = DataGridView1.SelectedCells(3).Value
        txtharga.Text = DataGridView1.SelectedCells(4).Value
    End Sub

    Sub KondisiAwal()
        txtid.Text = ""
        txtoutlet.Text = ""
        txtnamaoutlet.Text = ""
        cbjenis.Text = ""
        txtnama.Text = ""
        txtharga.Text = ""
        txthargarp.Text = ""

        txtid.Enabled = False
        txtoutlet.Enabled = False
        txtnamaoutlet.Enabled = False
        cbjenis.Enabled = False
        txtnama.Enabled = False
        txtharga.Enabled = False

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

        btntambah.Location = New Point(229, 333)
        btnubah.Location = New Point(339, 333)
        btnhapus.Location = New Point(449, 333)
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtoutlet.Text = ""
        txtnamaoutlet.Text = ""
        cbjenis.Text = ""
        txtnama.Text = ""
        txtharga.Text = ""
    End Sub

    Sub FieldIdDisable()
        txtid.Enabled = False
        txtoutlet.Enabled = True
        txtnamaoutlet.Enabled = False
        cbjenis.Enabled = True
        txtnama.Enabled = True
        txtharga.Enabled = True
        txtoutlet.Focus()
    End Sub

    Sub FieldDisable()
        txtid.Enabled = False
        txtoutlet.Enabled = False
        txtnamaoutlet.Enabled = False
        cbjenis.Enabled = False
        txtnama.Enabled = False
        txtharga.Enabled = False
    End Sub

    Sub DataGridViewAktif()
        DataGridView1.Enabled = True
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_paket FROM tb_paket"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_paket").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid.Text = "PK-0" + Trim(Str(kodeauto))
            Case 2 : txtid.Text = "PK-" + Trim(Str(kodeauto))
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

    Private Sub txt_tboutlet(sender As Object, e As EventArgs) Handles txtoutlet.TextChanged
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

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Location = New Point(229, 333)
            btntambah.Text = "Simpan"
            btnubah.Visible = False
            btnhapus.Visible = False
            btnbatal.Text = "Batal"
            Call FieldIdDisable()
            Call kodeotomatis()
        Else
            If txtid.Text = "" Or txtoutlet.Text = "" Or cbjenis.Text = "" Or txtnama.Text = "" Or txtharga.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            ElseIf txtid.Text <> "" Then
                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = "INSERT INTO tb_paket VALUES ('" & txtid.Text & "','" & txtoutlet.Text & "','" & cbjenis.Text & "','" & txtnama.Text & "','" & txtharga.Text & "')"
                cmd.ExecuteNonQuery()
                cn.Close()
                bersih()
                MsgBox("Data Paket Berhasil Tersimpan", MsgBoxStyle.Information)
                tampildata()
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If btnubah.Text = "Ubah" Then
            btnubah.Location = New Point(229, 333)
            btnubah.Text = "Simpan"
            btntambah.Visible = False
            btnhapus.Visible = False
            btnbatal.Text = "Batal"
            Call FieldIdDisable()
            Call DataGridViewAktif()
        Else
            If txtid.Text = "" Or txtoutlet.Text = "" Or cbjenis.Text = "" Or txtnama.Text = "" Or txtharga.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            ElseIf txtid.Text <> "" Then
                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = "UPDATE tb_paket SET id_outlet ='" & txtoutlet.Text & "', jenis ='" & cbjenis.Text & "', nama_paket = '" & txtnama.Text & "', harga = '" & txtharga.Text & "' WHERE id_paket = '" & txtid.Text & "'"
                cmd.ExecuteNonQuery()
                cn.Close()
                bersih()
                MsgBox("Data Paket Berhasil Terubah", MsgBoxStyle.Information)
                tampildata()
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If btnhapus.Text = "Hapus" Then
            btnhapus.Location = New Point(229, 333)
            btnhapus.Text = "Buang"
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
            cmd.CommandText = "DELETE FROM tb_paket WHERE id_paket = '" + id + "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Data Paket Berhasil Terhapus", MsgBoxStyle.Information)
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
        cmd.CommandText = "SELECT * FROM tb_paket WHERE id_paket LIKE '%" & txtcari.Text & "%' OR jenis LIKE '%" & txtcari.Text & "%' OR nama_paket LIKE '%" & txtcari.Text & "%' OR id_outlet LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub cbjenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbjenis.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        Try
            Dim harga As Integer
            harga = txtharga.Text
            txthargarp.Text = "Rp " + FormatNumber(harga, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub
End Class
