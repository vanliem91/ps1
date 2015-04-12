<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHanghoa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bntThoat = New System.Windows.Forms.Button()
        Me.bntXoa = New System.Windows.Forms.Button()
        Me.bntSua = New System.Windows.Forms.Button()
        Me.bntThem = New System.Windows.Forms.Button()
        Me.dgvBang = New System.Windows.Forms.DataGridView()
        Me.txtLoai = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtSanpham = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtChitiet = New System.Windows.Forms.TextBox()
        CType(Me.dgvBang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bntThoat
        '
        Me.bntThoat.Location = New System.Drawing.Point(373, 229)
        Me.bntThoat.Name = "bntThoat"
        Me.bntThoat.Size = New System.Drawing.Size(75, 23)
        Me.bntThoat.TabIndex = 17
        Me.bntThoat.Text = "Thoát"
        Me.bntThoat.UseVisualStyleBackColor = True
        '
        'bntXoa
        '
        Me.bntXoa.Location = New System.Drawing.Point(254, 229)
        Me.bntXoa.Name = "bntXoa"
        Me.bntXoa.Size = New System.Drawing.Size(75, 23)
        Me.bntXoa.TabIndex = 16
        Me.bntXoa.Text = "Xóa"
        Me.bntXoa.UseVisualStyleBackColor = True
        '
        'bntSua
        '
        Me.bntSua.Location = New System.Drawing.Point(134, 229)
        Me.bntSua.Name = "bntSua"
        Me.bntSua.Size = New System.Drawing.Size(75, 23)
        Me.bntSua.TabIndex = 15
        Me.bntSua.Text = "Sửa"
        Me.bntSua.UseVisualStyleBackColor = True
        '
        'bntThem
        '
        Me.bntThem.Location = New System.Drawing.Point(12, 229)
        Me.bntThem.Name = "bntThem"
        Me.bntThem.Size = New System.Drawing.Size(75, 23)
        Me.bntThem.TabIndex = 14
        Me.bntThem.Text = "Thêm"
        Me.bntThem.UseVisualStyleBackColor = True
        '
        'dgvBang
        '
        Me.dgvBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBang.Location = New System.Drawing.Point(12, 270)
        Me.dgvBang.Name = "dgvBang"
        Me.dgvBang.Size = New System.Drawing.Size(447, 150)
        Me.dgvBang.TabIndex = 13
        '
        'txtLoai
        '
        Me.txtLoai.Location = New System.Drawing.Point(158, 130)
        Me.txtLoai.Name = "txtLoai"
        Me.txtLoai.Size = New System.Drawing.Size(248, 20)
        Me.txtLoai.TabIndex = 25
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(158, 89)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(248, 20)
        Me.txtSoluong.TabIndex = 24
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(158, 47)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(248, 20)
        Me.txtGia.TabIndex = 23
        '
        'txtSanpham
        '
        Me.txtSanpham.Location = New System.Drawing.Point(158, 12)
        Me.txtSanpham.Name = "txtSanpham"
        Me.txtSanpham.Size = New System.Drawing.Size(248, 20)
        Me.txtSanpham.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Loại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Số lượng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Giá"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Sản phẩm:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Chi tiết:"
        '
        'txtChitiet
        '
        Me.txtChitiet.Location = New System.Drawing.Point(158, 172)
        Me.txtChitiet.Name = "txtChitiet"
        Me.txtChitiet.Size = New System.Drawing.Size(248, 20)
        Me.txtChitiet.TabIndex = 27
        '
        'frmHanghoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 446)
        Me.Controls.Add(Me.txtChitiet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLoai)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me.txtSanpham)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bntThoat)
        Me.Controls.Add(Me.bntXoa)
        Me.Controls.Add(Me.bntSua)
        Me.Controls.Add(Me.bntThem)
        Me.Controls.Add(Me.dgvBang)
        Me.Name = "frmHanghoa"
        Me.Text = "Quản lý hàng hóa"
        CType(Me.dgvBang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bntThoat As System.Windows.Forms.Button
    Friend WithEvents bntXoa As System.Windows.Forms.Button
    Friend WithEvents bntSua As System.Windows.Forms.Button
    Friend WithEvents bntThem As System.Windows.Forms.Button
    Friend WithEvents dgvBang As System.Windows.Forms.DataGridView
    Friend WithEvents txtLoai As System.Windows.Forms.TextBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents txtSanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtChitiet As System.Windows.Forms.TextBox
End Class
