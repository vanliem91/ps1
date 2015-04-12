<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiaodien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGiaodien))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngHóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngTrongKhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngChờNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HàngĐãBánToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhầnMềmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHienthi = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.HàngHóaToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.PhầnMềmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(436, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng xuất"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'HàngHóaToolStripMenuItem
        '
        Me.HàngHóaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HàngTrongKhoToolStripMenuItem, Me.HàngChờNhậpToolStripMenuItem, Me.HàngĐãBánToolStripMenuItem})
        Me.HàngHóaToolStripMenuItem.Name = "HàngHóaToolStripMenuItem"
        Me.HàngHóaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.HàngHóaToolStripMenuItem.Text = "Hàng hóa"
        '
        'HàngTrongKhoToolStripMenuItem
        '
        Me.HàngTrongKhoToolStripMenuItem.Name = "HàngTrongKhoToolStripMenuItem"
        Me.HàngTrongKhoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.HàngTrongKhoToolStripMenuItem.Text = "Hàng trong kho"
        '
        'HàngChờNhậpToolStripMenuItem
        '
        Me.HàngChờNhậpToolStripMenuItem.Name = "HàngChờNhậpToolStripMenuItem"
        Me.HàngChờNhậpToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.HàngChờNhậpToolStripMenuItem.Text = "Hàng chờ nhập"
        '
        'HàngĐãBánToolStripMenuItem
        '
        Me.HàngĐãBánToolStripMenuItem.Name = "HàngĐãBánToolStripMenuItem"
        Me.HàngĐãBánToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.HàngĐãBánToolStripMenuItem.Text = "Hàng đã bán"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchNhânViênToolStripMenuItem})
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.NhânViênToolStripMenuItem.Text = "Nhân viên"
        '
        'DanhSáchNhânViênToolStripMenuItem
        '
        Me.DanhSáchNhânViênToolStripMenuItem.Name = "DanhSáchNhânViênToolStripMenuItem"
        Me.DanhSáchNhânViênToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DanhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên"
        '
        'PhầnMềmToolStripMenuItem
        '
        Me.PhầnMềmToolStripMenuItem.Name = "PhầnMềmToolStripMenuItem"
        Me.PhầnMềmToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.PhầnMềmToolStripMenuItem.Text = "Phần mềm"
        '
        'lblHienthi
        '
        Me.lblHienthi.AutoSize = True
        Me.lblHienthi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHienthi.Location = New System.Drawing.Point(91, 56)
        Me.lblHienthi.Name = "lblHienthi"
        Me.lblHienthi.Size = New System.Drawing.Size(192, 16)
        Me.lblHienthi.TabIndex = 1
        Me.lblHienthi.Text = "                                              "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 164)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmGiaodien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 275)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHienthi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGiaodien"
        Me.Text = "Giao diện chính"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HàngHóaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HàngTrongKhoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HàngChờNhậpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HàngĐãBánToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhầnMềmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblHienthi As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
