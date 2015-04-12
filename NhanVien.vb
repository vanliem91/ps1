Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmNhanvien
    Dim tb As New DataTable
    Dim ChuoiSoome As String = "workstation id=ps02087.mssql.somee.com;packet size=4096;user id=ps02087_SQLLogin_1;pwd=pxfkb5d1jo;data source=ps02087.mssql.somee.com;persist security info=False;initial catalog=ps02087"

    Private Sub frmNhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ketnoi As New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from TNhanVien ", Ketnoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        dgvBang.DataSource = tb
        Ketnoi.Close()
    End Sub

    Private Sub dgvBang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBang.CellContentClick
        Dim dulieu As Integer = dgvBang.CurrentCell.RowIndex
        txtHoten.Text = dgvBang.Item(0, dulieu).Value
        txtChucvu.Text = dgvBang.Item(1, dulieu).Value
        txtSDT.Text = dgvBang.Item(2, dulieu).Value
        txtLuong.Text = dgvBang.Item(3, dulieu).Value

    End Sub

    Private Sub bntThem_Click(sender As Object, e As EventArgs) Handles bntThem.Click

        Dim ketnoi As New SqlConnection(ChuoiSoome)
        ketnoi.Open()
        Dim Them As String = "INSERT INTO TNhanVien VALUES (@HoTen, @ChucVu, @SDT, @Luong)"

        Dim dulieu As New SqlCommand(Them, ketnoi)
        Try
            dulieu.Parameters.AddWithValue("@HoTen", txtHoten.Text)
            dulieu.Parameters.AddWithValue("@ChucVu", txtChucvu.Text)
            dulieu.Parameters.AddWithValue("@SDT", txtSDT.Text)
            dulieu.Parameters.AddWithValue("@Luong", txtLuong.Text)
            dulieu.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Bạn đã thêm dữ liệu thành công")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb

        Dim abc As New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from TNhanVien ", ketnoi)
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
        Dim Sua As String = "UPDATE TNhanVien SET HoTen=@HoTen, ChucVu=@ChucVu, SDT=@SDT, Luong=@Luong WHERE HoTen=@HoTen"
        Dim dulieu As New SqlCommand(Sua, ketnoi)
        Try
            dulieu.Parameters.AddWithValue("@HoTen", txtHoten.Text)
            dulieu.Parameters.AddWithValue("@ChucVu", txtChucvu.Text)
            dulieu.Parameters.AddWithValue("@SDT", txtSDT.Text)
            dulieu.Parameters.AddWithValue("@Luong", txtLuong.Text)
            dulieu.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Bạn đã sửa dữ liệu thành công")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb

        Dim abc As New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from TNhanVien ", Ketnoi)
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
        Dim Xoa As String = "DELETE FROM TNhanVien WHERE  HoTen=@HoTen"
        Dim dulieu As New SqlCommand(Xoa, ketnoi)
        Try
            dulieu.Parameters.AddWithValue("@HoTen", txtHoten.Text)
            dulieu.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Bạn đã xóa dữ liệu thành công")
        Catch ex As Exception

        End Try
        tb.Clear()
        dgvBang.DataSource = tb

        Dim abc As New SqlConnection(ChuoiSoome)
        Dim sqlAdapter As New SqlDataAdapter("Select * from TNhanVien ", ketnoi)
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
