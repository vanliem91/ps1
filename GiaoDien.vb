Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmGiaodien

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmGiaodien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        frmDangnhap.Show()
        Me.Hide()

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub DanhSáchNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhânViênToolStripMenuItem.Click
        frmNhanvien.Show()
        Me.Hide()

    End Sub

    Private Sub HàngTrongKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HàngTrongKhoToolStripMenuItem.Click
        frmHanghoa.Show()
        Me.Hide()

    End Sub
End Class