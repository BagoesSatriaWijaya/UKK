Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Login
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

    Private Property InputData As Integer

    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click
        txtuser.Clear()
    End Sub

    Private Sub txtpass_Click(sender As Object, e As EventArgs) Handles txtpass.Click
        txtpass.Clear()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If txtuser.Text = "" Or txtpass.Text = "" Then
                MessageBox.Show("Isi Username dan Password terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Call Koneksi()
                cmd = New SqlCommand("select * from tb_user WHERE username = '" & txtuser.Text & "' And password = '" & getMD5Hash(txtpass.Text) & "'", Conn)
                Rd = cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    HalamanUtama.Slabel2.Text = Rd("username")
                    HalamanUtama.Slabel4.Text = Rd("nama")
                    HalamanUtama.Slabel6.Text = Rd("role")

                    HalamanUtama.PenggunaIcon.Enabled = True
                    HalamanUtama.btnPengguna.Enabled = True
                    HalamanUtama.PelangganIcon.Enabled = True
                    HalamanUtama.btnMember.Enabled = True
                    HalamanUtama.OutletIcon.Enabled = True
                    HalamanUtama.btnOutlet.Enabled = True
                    HalamanUtama.PaketIcon.Enabled = True
                    HalamanUtama.btnPaket.Enabled = True
                    HalamanUtama.TransaksiIcon.Enabled = True
                    HalamanUtama.btnTransaksi.Enabled = True
                    HalamanUtama.DetailTransaksiIcon.Enabled = True
                    HalamanUtama.btnDetailTransaksi.Enabled = True

                    If Rd("role") = "Admin" Then
                        Me.Hide()
                        HalamanUtama.Show()
                        HalamanUtama.Label4.Text = "Selamat Datang Admin"
                    ElseIf Rd("role") = "Kasir" Then
                        HalamanUtama.PenggunaIcon.Enabled = False
                        HalamanUtama.btnPengguna.Enabled = False
                        HalamanUtama.OutletIcon.Enabled = False
                        HalamanUtama.btnOutlet.Enabled = False
                        HalamanUtama.PaketIcon.Enabled = False
                        HalamanUtama.btnPaket.Enabled = False
                        Me.Hide()
                        HalamanUtama.Show()
                        HalamanUtama.Label4.Text = "Selamat Datang Kasir"
                    ElseIf Rd("role") = "Owner" Then
                        HalamanUtama.PelangganIcon.Enabled = False
                        HalamanUtama.btnMember.Enabled = False
                        HalamanUtama.PenggunaIcon.Enabled = False
                        HalamanUtama.btnPengguna.Enabled = False
                        HalamanUtama.OutletIcon.Enabled = False
                        HalamanUtama.btnOutlet.Enabled = False
                        HalamanUtama.PaketIcon.Enabled = False
                        HalamanUtama.btnPaket.Enabled = False
                        HalamanUtama.TransaksiIcon.Enabled = False
                        HalamanUtama.btnTransaksi.Enabled = False
                        HalamanUtama.DetailTransaksiIcon.Enabled = False
                        HalamanUtama.btnDetailTransaksi.Enabled = False
                        Me.Hide()
                        HalamanUtama.Show()
                        HalamanUtama.Label4.Text = "Selamat Datang Owner"
                    End If
                Else
                    MsgBox("Nama pengguna dan kata sandi tidak tersedia", MsgBoxStyle.Information)
                    txtuser.Text = ""
                    txtpass.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan! " & ex.Message)
            Application.Restart()
        End Try
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ERIN8O5;Initial Catalog=db_UKK_Bagoes;Integrated Security=True"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub txtuser_MouseEnter(sender As Object, e As EventArgs) Handles txtuser.MouseEnter
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub txtuser_MouseLeave(sender As Object, e As EventArgs) Handles txtuser.MouseLeave
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
            txtuser.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub txtpass_MouseEnter(sender As Object, e As EventArgs) Handles txtpass.MouseEnter
        If txtpass.Text = "Password" Then
            txtpass.Text = ""
            txtpass.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub txtpass_MouseLeave(sender As Object, e As EventArgs) Handles txtpass.MouseLeave
        If txtpass.Text = "" Then
            txtpass.Text = "Password"
            txtpass.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub
End Class