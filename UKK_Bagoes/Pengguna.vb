Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class Pengguna
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5obj As New MD5CryptoServiceProvider()
        Dim BytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        BytesToHash = md5obj.ComputeHash(BytesToHash)
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In BytesToHash
            strResult += b.ToString("x2")

        Next
        Return strResult
    End Function

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_user"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID User"
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Username"
        DataGridView1.Columns(3).HeaderText = "Password"
        DataGridView1.Columns(4).HeaderText = "ID Outlet"
        DataGridView1.Columns(5).HeaderText = "Role"
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ERIN8O5;Initial Catalog=db_UKK_Bagoes;Integrated Security=True"
        Call tampildata()
        Call KondisiAwal()
        Call auto_outlet()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid.Text = DataGridView1.SelectedCells(0).Value
        txtnama.Text = DataGridView1.SelectedCells(1).Value
        txtuser.Text = DataGridView1.SelectedCells(2).Value
        txtoutlet.Text = DataGridView1.SelectedCells(4).Value
        cbrole.Text = DataGridView1.SelectedCells(5).Value
    End Sub

    Sub KondisiAwal()
        txtid.Text = ""
        txtnama.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txtoutlet.Text = ""
        txtnamaoutlet.Text = ""
        cbrole.Text = ""

        txtid.Enabled = False
        txtnama.Enabled = False
        txtuser.Enabled = False
        txtpass.Enabled = False
        txtoutlet.Enabled = False
        txtnamaoutlet.Enabled = False
        cbrole.Enabled = False

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
        txtuser.Text = ""
        txtpass.Text = ""
        txtoutlet.Text = ""
        txtnamaoutlet.Text = ""
        cbrole.Text = ""
    End Sub

    Sub FieldIdDisable()
        txtid.Enabled = False
        txtnama.Enabled = True
        txtuser.Enabled = True
        txtpass.Enabled = True
        txtoutlet.Enabled = True
        txtnamaoutlet.Enabled = False
        cbrole.Enabled = True
        txtnama.Focus()
    End Sub

    Sub EditPengguna()
        txtid.Enabled = False
        txtnama.Enabled = True
        txtuser.Enabled = False
        txtpass.Enabled = True
        txtoutlet.Enabled = True
        txtnamaoutlet.Enabled = False
        cbrole.Enabled = True
        txtnama.Focus()
    End Sub

    Sub FieldDisable()
        txtid.Enabled = False
        txtnama.Enabled = False
        txtuser.Enabled = False
        txtpass.Enabled = False
        txtoutlet.Enabled = False
        txtnamaoutlet.Enabled = False
        cbrole.Enabled = False
    End Sub

    Sub DataGridViewAktif()
        DataGridView1.Enabled = True
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_user FROM tb_user"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_user").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid.Text = "USR-0" + Trim(Str(kodeauto))
            Case 2 : txtid.Text = "USR-" + Trim(Str(kodeauto))
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
        Try
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
        Catch ex As Exception
            cn.Close()
        End Try
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

            If txtid.Text = "" Or txtnama.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Or txtoutlet.Text = "" Or cbrole.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            Else
                Call koneksi()
                cmd = New SqlCommand("Select * from tb_user where username='" & txtuser.Text & "'", Conn)
                Rd = cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("Username Sudah Dipakai, Silahkan masukkan Username lain")
                    txtuser.Clear()
                    txtuser.Focus()
                Else
                    Call Koneksi()
                    cmd = New SqlCommand("INSERT INTO tb_user VALUES ('" & txtid.Text & "','" & txtnama.Text & "','" & txtuser.Text & "','" & getMD5Hash(txtpass.Text) & "','" & txtoutlet.Text & "','" & cbrole.Text & "')", Conn)
                    cmd.ExecuteNonQuery()
                    bersih()
                    MsgBox("Data User Berhasil Tersimpan", MsgBoxStyle.Information)
                    tampildata()
                    Call KondisiAwal()
                End If
                rd.Close()
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
            Call EditPengguna()
            Call DataGridViewAktif()
        Else
            If txtid.Text = "" Or txtnama.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Or cbrole.Text = "" Then
                MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
            ElseIf txtid.Text <> "" Then
                cn.Open()
                cmd.Connection = cn
                cmd.CommandText = "UPDATE tb_user SET nama ='" & txtnama.Text & "', username ='" & txtuser.Text & "', password = '" & getMD5Hash(txtpass.Text) & "', id_outlet ='" & txtoutlet.Text & "', role ='" & cbrole.Text & "' WHERE id_user = '" & txtid.Text & "'"
                cmd.ExecuteNonQuery()
                cn.Close()
                bersih()
                MsgBox("Data User Berhasil Terubah", MsgBoxStyle.Information)
                tampildata()
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            If btnhapus.Text = "Hapus" Then
                btnhapus.Location = New Point(229, 333)
                btnhapus.Text = "Buang"
                btntambah.Visible = False
                btnubah.Visible = False
                btnbatal.Text = "Batal"
                Call FieldDisable()
                Call DataGridViewAktif()
            Else
                If txtid.Text = "" Or txtnama.Text = "" Or txtuser.Text = "" Or cbrole.Text = "" Then
                    MessageBox.Show("Semua Data Wajib Diisi, Tidak Boleh Dikosongkan")
                ElseIf cbrole.Text = "Admin" Then
                    cn.Open()
                    cmd.Connection = cn
                    cmd.CommandText = "DELETE FROM tb_user WHERE id_user = '" & txtid.Text & "'"
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Role Admin Terhapus, Harap Login Ulang")
                    Me.Hide()
                    HalamanUtama.Hide()
                    Login.Show()
                Else
                    Dim baris As Integer
                    Dim id As String

                    baris = DataGridView1.CurrentCell.RowIndex
                    id = DataGridView1(0, baris).Value.ToString

                    cn.Open()
                    cmd.Connection = cn
                    cmd.CommandText = "DELETE FROM tb_user WHERE id_user = '" + id + "'"
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Data User Berhasil Terhapus", MsgBoxStyle.Information)
                    tampildata()
                    Call KondisiAwal()
                End If
            End If
        Catch ex As Exception
            MsgBox("Data Tidak Terhapus", MsgBoxStyle.Information)
        End Try
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
        cmd.CommandText = "SELECT * FROM tb_user WHERE id_user LIKE '%" & txtcari.Text & "%' OR nama LIKE '%" & txtcari.Text & "%' OR username LIKE '%" & txtcari.Text & "%' OR role LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub cbrole_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbrole.KeyPress
        e.KeyChar = Chr(0)
    End Sub
End Class
