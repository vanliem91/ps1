Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmHanghoa
    Dim tb As New DataTable
    Dim ChuoiSoome As String = "workstation id=ps02087.mssql.somee.com;packet size=4096;user id=ps02087_SQLLogin_1;pwd=pxfkb5d1jo;data source=ps02087.mssql.somee.com;persist security info=False;initial catalog=ps02087"

    Private Sub frmHanghoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ketnoi As New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from SanPham ", Ketnoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        dgvBang.DataSource = tb
        Ketnoi.Close()
    End Sub

    Private Sub dgvBang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBang.CellContentClick
        Dim dulieu As Integer = dgvBang.CurrentCell.RowIndex
        txtSanpham.Text = dgvBang.Item(0, dulieu).Value
        txtGia.Text = dgvBang.Item(1, dulieu).Value
        txtSoluong.Text = dgvBang.Item(2, dulieu).Value
        txtLoai.Text = dgvBang.Item(3, dulieu).Value
        txtChitiet.Text = dgvBang.Item(4, dulieu).Value
    End Sub

    Private Sub bntThem_Click(sender As Object, e As EventArgs) Handles bntThem.Click

        Dim ketnoi As New SqlConnection(ChuoiSoome)
        ketnoi.Open()
        Dim Them As String = "INSERT INTO SanPham VALUES (@SanPham, @Gia, @SoLuong, @Loai,@ChiTiet)"

        Dim dulieu As New SqlCommand(Them, ketnoi)
        Try
            dulieu.Parameters.AddWithValue("@SanPham", txtSanpham.Text)
            dulieu.Parameters.AddWithValue("@Gia", txtGia.Text)
            dulieu.Parameters.AddWithValue("@SoLuong", txtSoluong.Text)
            dulieu.Parameters.AddWithValue("@Loai", txtLoai.Text)
            dulieu.Parameters.AddWithValue("@ChiTiet", txtChitiet.Text)
            dulieu.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Bạn đã thêm dữ liệu thành công")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb

        Dim abc As New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from SanPham ", ketnoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        dgvBang.DataSource = tb
        abc.Close()

    End Sub

    Private Sub bntSua_Click(sender As Object, e As EventArgs) Handles bntSua.Click
        Dim ketnoi As New SqlConnection(ChuoiSoome)
        ketnoi.Open()
        Dim Sua As String = "UPDATE SanPham SET Sanpham=@Sanpham, Gia=@Gia, SoLuong=@SoLuong, Loai=@Loai,ChiTiet=@ChiTiet WHERE SanPham=@SanPham"
        Dim dulieu As New SqlCommand(Sua, ketnoi)
        Try
            dulieu.Parameters.AddWithValue("@SanPham", txtSanpham.Text)
            dulieu.Parameters.AddWithValue("@Gia", txtGia.Text)
            dulieu.Parameters.AddWithValue("@SoLuong", txtSoluong.Text)
            dulieu.Parameters.AddWithValue("@Loai", txtLoai.Text)
            dulieu.Parameters.AddWithValue("@ChiTiet", txtChitiet.Text)
            dulieu.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Bạn đã sửa dữ liệu thành công")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb

        Dim abc As New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from SanPham ", ketnoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        dgvBang.DataSource = tb
        abc.Close()

    End Sub

    Private Sub bntXoa_Click(sender As Object, e As EventArgs) Handles bntXoa.Click
        Dim ketnoi As New SqlConnection(ChuoiSoome)
        ketnoi.Open()
        Dim Xoa As String = "DELETE FROM SanPham WHERE  SanPham=@SanPham"
        Dim dulieu As New SqlCommand(Xoa, ketnoi)
        Try
            dulieu.Parameters.AddWithValue("@SanPham", txtSanpham.Text)
            dulieu.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Bạn đã xóa dữ liệu thành công")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb

        Dim abc As New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from SanPham ", ketnoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        dgvBang.DataSource = tb
        abc.Close()

    End Sub

    Private Sub bntThoat_Click(sender As Object, e As EventArgs) Handles bntThoat.Click
        frmGiaodien.Show()
        Me.Hide()

    End Sub
End Class