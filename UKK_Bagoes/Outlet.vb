Imports System.Data.SqlClient
Public Class Outlet
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_outlet"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Outlet"
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Alamat"
        DataGridView1.Columns(3).HeaderText = "Telp"
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ERIN8O5;Initial Catalog=db_UKK_Bagoes;Integrated Security=True"
        Call tampildata()
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid.Text = DataGridView1.SelectedCells(0).Value
        txtnama.Text = DataGridView1.SelectedCells(1).Value
        txtalamat.Text = DataGridView1.SelectedCells(2).Value
        txttelp.Text = DataGridView1.SelectedCells(3).Value
    End Sub

    Sub KondisiAwal()
        txtid.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""

        txtid.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txttelp.Enabled = False

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
        txtnama.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
    End Sub

    Sub FieldIdDisable()
        txtid.Enabled = False
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txttelp.Enabled = True
        txtnama.Focus()
    End Sub

    Sub FieldDisable()
        txtid.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txttelp.Enabled = False
    End Sub

    Sub DataGridViewAktif()
        DataGridView1.Enabled = True
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_outlet FROM tb_outlet"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_outlet").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid.Text = "OT-0" + Trim(Str(kodeauto))
            Case 2 : txtid.Text = "OT-" + Trim(Str(kodeauto))
        End Select
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
            If txtid.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txttelp.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            ElseIf txtid.Text <> "" Then
                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = "INSERT INTO tb_outlet VALUES ('" & txtid.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" & txttelp.Text & "')"
                cmd.ExecuteNonQuery()
                cn.Close()
                bersih()
                MsgBox("Data Outlet Berhasil Tersimpan", MsgBoxStyle.Information)
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
            If txtid.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txttelp.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            ElseIf txtid.Text <> "" Then
                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = "UPDATE tb_outlet SET nama ='" & txtnama.Text & "', alamat ='" & txtalamat.Text & "', telp = '" & txttelp.Text & "' WHERE id_outlet = '" & txtid.Text & "'"
                cmd.ExecuteNonQuery()
                cn.Close()
                bersih()
                MsgBox("Data Outlet Berhasil Terubah", MsgBoxStyle.Information)
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
            cmd.CommandText = "DELETE FROM tb_outlet WHERE id_outlet = '" + id + "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Data Outlet Berhasil Terhapus", MsgBoxStyle.Information)
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
        cmd.CommandText = "SELECT * FROM tb_outlet WHERE nama LIKE '%" & txtcari.Text & "%' OR alamat LIKE '%" & txtcari.Text & "%' OR id_outlet LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub txttelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelp.KeyPress
        txttelp.MaxLength = 12
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class
