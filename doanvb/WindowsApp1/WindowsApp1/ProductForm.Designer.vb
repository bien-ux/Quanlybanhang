<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtDVT = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtTon = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnmain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(15, 33)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(1006, 347)
        Me.dgv.TabIndex = 0
        '
        'txtMa
        '
        Me.txtMa.AccessibleDescription = ""
        Me.txtMa.AccessibleName = ""
        Me.txtMa.Location = New System.Drawing.Point(111, 401)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(431, 22)
        Me.txtMa.TabIndex = 1
        Me.txtMa.Tag = ""
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(111, 429)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(431, 22)
        Me.txtTen.TabIndex = 2
        '
        'txtDVT
        '
        Me.txtDVT.Location = New System.Drawing.Point(111, 459)
        Me.txtDVT.Name = "txtDVT"
        Me.txtDVT.Size = New System.Drawing.Size(431, 22)
        Me.txtDVT.TabIndex = 3
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(111, 487)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(431, 22)
        Me.txtDonGia.TabIndex = 4
        '
        'txtTon
        '
        Me.txtTon.Location = New System.Drawing.Point(111, 515)
        Me.txtTon.Name = "txtTon"
        Me.txtTon.Size = New System.Drawing.Size(431, 22)
        Me.txtTon.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(635, 399)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(386, 22)
        Me.txtSearch.TabIndex = 6
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(635, 428)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 7
        Me.btnThem.Text = "Thêm "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(716, 427)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(797, 427)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xóa "
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnmain
        '
        Me.btnmain.Location = New System.Drawing.Point(878, 427)
        Me.btnmain.Name = "btnmain"
        Me.btnmain.Size = New System.Drawing.Size(75, 23)
        Me.btnmain.TabIndex = 10
        Me.btnmain.Text = "Về Main"
        Me.btnmain.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tên sản phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Đơn vị tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Đơn giá"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Số lượng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(567, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tìm kiếm"
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1030, 549)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmain)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtTon)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtDVT)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtMa)
        Me.Controls.Add(Me.dgv)
        Me.Name = "ProductForm"
        Me.Text = "Quản lý Sản phẩm"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtMa As TextBox
    Friend WithEvents txtTen As TextBox
    Friend WithEvents txtDVT As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtTon As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnmain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
