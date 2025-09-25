<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.cboNV = New System.Windows.Forms.ComboBox()
        Me.cboKH = New System.Windows.Forms.ComboBox()
        Me.btnThemSP = New System.Windows.Forms.Button()
        Me.btnLuuHD = New System.Windows.Forms.Button()
        Me.lblTong = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmain = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(540, 74)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(8, 8)
        Me.DataGridView2.TabIndex = 1
        '
        'dgvItems
        '
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Location = New System.Drawing.Point(36, 12)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.RowTemplate.Height = 24
        Me.dgvItems.Size = New System.Drawing.Size(792, 301)
        Me.dgvItems.TabIndex = 2
        '
        'cboNV
        '
        Me.cboNV.FormattingEnabled = True
        Me.cboNV.Location = New System.Drawing.Point(141, 330)
        Me.cboNV.Name = "cboNV"
        Me.cboNV.Size = New System.Drawing.Size(328, 24)
        Me.cboNV.TabIndex = 1
        '
        'cboKH
        '
        Me.cboKH.FormattingEnabled = True
        Me.cboKH.Location = New System.Drawing.Point(141, 362)
        Me.cboKH.Name = "cboKH"
        Me.cboKH.Size = New System.Drawing.Size(328, 24)
        Me.cboKH.TabIndex = 2
        '
        'btnThemSP
        '
        Me.btnThemSP.Location = New System.Drawing.Point(521, 328)
        Me.btnThemSP.Name = "btnThemSP"
        Me.btnThemSP.Size = New System.Drawing.Size(114, 26)
        Me.btnThemSP.TabIndex = 4
        Me.btnThemSP.Text = "Thêm sản phẩm"
        Me.btnThemSP.UseVisualStyleBackColor = True
        '
        'btnLuuHD
        '
        Me.btnLuuHD.Location = New System.Drawing.Point(521, 362)
        Me.btnLuuHD.Name = "btnLuuHD"
        Me.btnLuuHD.Size = New System.Drawing.Size(114, 26)
        Me.btnLuuHD.TabIndex = 5
        Me.btnLuuHD.Text = "Lưu hóa đơn"
        Me.btnLuuHD.UseVisualStyleBackColor = True
        '
        'lblTong
        '
        Me.lblTong.AutoSize = True
        Me.lblTong.Location = New System.Drawing.Point(734, 362)
        Me.lblTong.Name = "lblTong"
        Me.lblTong.Size = New System.Drawing.Size(48, 16)
        Me.lblTong.TabIndex = 7
        Me.lblTong.Text = "Label1"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(141, 392)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(328, 22)
        Me.txtMaHD.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nhân Viên "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Mã hóa đơn"
        '
        'btnmain
        '
        Me.btnmain.Location = New System.Drawing.Point(521, 391)
        Me.btnmain.Name = "btnmain"
        Me.btnmain.Size = New System.Drawing.Size(114, 23)
        Me.btnmain.TabIndex = 6
        Me.btnmain.Text = "Về Main"
        Me.btnmain.UseVisualStyleBackColor = True
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 443)
        Me.Controls.Add(Me.btnmain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.lblTong)
        Me.Controls.Add(Me.btnLuuHD)
        Me.Controls.Add(Me.btnThemSP)
        Me.Controls.Add(Me.cboKH)
        Me.Controls.Add(Me.cboNV)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "InvoiceForm"
        Me.Text = "Lập hóa đơn"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents cboNV As ComboBox
    Friend WithEvents cboKH As ComboBox
    Friend WithEvents btnThemSP As Button
    Friend WithEvents btnLuuHD As Button
    Friend WithEvents lblTong As Label
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmain As Button
End Class
