Imports System.Data.SqlClient
Public Class HalamanUtama
    Private currentChildForm As Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SubMenu()
        Slabel8.Text = Today
        StatusStrip1.BackColor = Color.Gainsboro
        StatusStrip1.ForeColor = Color.Gainsboro
        Label2.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub Window1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Sub SubMenu()
        PanelRegistrasiSubMenu.Visible = False
        PanelDetailSubMenu.Visible = False
        PanelLaporanSubMenu.Visible = False
    End Sub

    Sub hideSubMenu()
        If (PanelRegistrasiSubMenu.Visible = True) Then
            PanelRegistrasiSubMenu.Visible = False
        Else
            If (PanelDetailSubMenu.Visible = True) Then
                PanelDetailSubMenu.Visible = False
            Else
                If (PanelLaporanSubMenu.Visible = True) Then
                    PanelLaporanSubMenu.Visible = False
                End If
            End If
        End If
    End Sub

    Sub ShowSubMenu(SubMenu)
        If (SubMenu.Visible = False) Then
            hideSubMenu()
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
    End Sub

    'MENU
    'Registrasi'
    Private Sub btnRegistrasi_Click(sender As Object, e As EventArgs) Handles btnRegistrasi.Click
        ShowSubMenu(PanelRegistrasiSubMenu)
    End Sub

    'Detail'
    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        ShowSubMenu(PanelDetailSubMenu)
    End Sub

    'Laporan'
    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        ShowSubMenu(PanelLaporanSubMenu)
    End Sub

    'SUBMENU
    'Pengguna'
    Private Sub btnPengguna_Click(sender As Object, e As EventArgs) Handles btnPengguna.Click
        OpenChildForm(New Pengguna)
    End Sub

    'Member
    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        OpenChildForm(New Member)
    End Sub

    'Outlet
    Private Sub btnOutlet_Click(sender As Object, e As EventArgs) Handles btnOutlet.Click
        OpenChildForm(New Outlet)
    End Sub

    'Paket
    Private Sub btnPaket_Click(sender As Object, e As EventArgs) Handles btnPaket.Click
        OpenChildForm(New Paket)
    End Sub

    'Transaksi
    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        OpenChildForm(New Transaksi)
    End Sub

    'Detail Transaksi
    Private Sub btnDetailTransaksi_Click(sender As Object, e As EventArgs) Handles btnDetailTransaksi.Click
        OpenChildForm(New DetailTransaksi)
    End Sub

    'Keluar
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    'Laporan
    Private Sub btnLapDetail_Click(sender As Object, e As EventArgs) Handles btnLapTransaksi.Click
        OpenChildForm(New LapTransaksi)
    End Sub

    Private Sub btnLapPaket_Click(sender As Object, e As EventArgs) Handles btnLapPaket.Click
        OpenChildForm(New LapPaket)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New LapOutlet)
    End Sub

    Private Sub btnLapMember_Click(sender As Object, e As EventArgs) Handles btnLapMember.Click
        OpenChildForm(New LapMember)
    End Sub

    Sub OpenChildForm(childForm As Form)
        'open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Slabel10.Text = TimeOfDay
        Label3.Text = TimeOfDay
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        hideSubMenu()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        OpenChildForm(New Bantuan)
        hideSubMenu()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        hideSubMenu()
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub PanelChildForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelChildForm.Paint

    End Sub
End Class
