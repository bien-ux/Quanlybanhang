<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainfrom
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
        Me.btnSanPham = New System.Windows.Forms.Button()
        Me.btnHoaDon = New System.Windows.Forms.Button()
        Me.Bt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSanPham
        '
        Me.btnSanPham.AutoSize = True
        Me.btnSanPham.Location = New System.Drawing.Point(95, 75)
        Me.btnSanPham.Name = "btnSanPham"
        Me.btnSanPham.Size = New System.Drawing.Size(141, 26)
        Me.btnSanPham.TabIndex = 0
        Me.btnSanPham.Text = "Quản lý sản phẩm"
        Me.btnSanPham.UseVisualStyleBackColor = True
        '
        'btnHoaDon
        '
        Me.btnHoaDon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHoaDon.Location = New System.Drawing.Point(95, 107)
        Me.btnHoaDon.Name = "btnHoaDon"
        Me.btnHoaDon.Size = New System.Drawing.Size(141, 26)
        Me.btnHoaDon.TabIndex = 1
        Me.btnHoaDon.Text = "Lập hóa đơn"
        Me.btnHoaDon.UseVisualStyleBackColor = True
        '
        'Bt
        '
        Me.Bt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt.Location = New System.Drawing.Point(95, 139)
        Me.Bt.Name = "Bt"
        Me.Bt.Size = New System.Drawing.Size(141, 23)
        Me.Bt.TabIndex = 2
        Me.Bt.Text = "Thoát"
        Me.Bt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu"
        '
        'Mainfrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 214)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt)
        Me.Controls.Add(Me.btnHoaDon)
        Me.Controls.Add(Me.btnSanPham)
        Me.Name = "Mainfrom"
        Me.Text = "Mainfrom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSanPham As Button
    Friend WithEvents btnHoaDon As Button
    Friend WithEvents Bt As Button
    Friend WithEvents Label1 As Label
End Class
