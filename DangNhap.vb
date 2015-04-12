Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmDangnhap

    Private Sub frmDangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bntThoat_Click(sender As Object, e As EventArgs) Handles bntThoat.Click
        Me.Close()

    End Sub

    Private Sub bntNhaplai_Click(sender As Object, e As EventArgs) Handles bntNhaplai.Click
        txtMatkhau.Clear()
        txtTaikhoan.Clear()

    End Sub

    Private Sub bntDangnhap_Click(sender As Object, e As EventArgs) Handles bntDangnhap.Click
        Dim ChuoiSoome As String = "workstation id=ps02087.mssql.somee.com;packet size=4096;user id=ps02087_SQLLogin_1;pwd=pxfkb5d1jo;data source=ps02087.mssql.somee.com;persist security info=False;initial catalog=ps02087"
        Dim Ketnoi As SqlConnection = New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from BNhanVien where MaNV ='" & txtTaikhoan.Text & "'and Matkhau ='" & txtMatkhau.Text & "'", Ketnoi)
        Dim table As New DataTable
        Try
            Ketnoi.Open()
            sqlAdapter.Fill(table)
            If table.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công")
                frmGiaodien.Show()
                Me.Hide()
                frmGiaodien.lblHienthi.Text = "Chào mừng " + txtTaikhoan.Text + " sử dụng phần mềm"

            Else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class