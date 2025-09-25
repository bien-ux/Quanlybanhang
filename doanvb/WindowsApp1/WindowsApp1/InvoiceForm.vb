Public Class InvoiceForm
    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        SetupGrid()
        UpdateTotal()
    End Sub

    Private Sub LoadCombo()
        cboNV.DisplayMember = "TenNV"
        cboNV.ValueMember = "MaNV"
        cboNV.DataSource = ExecDataTable("SELECT MaNV, TenNV FROM NhanVien ORDER BY TenNV")

        cboKH.DisplayMember = "TenKH"
        cboKH.ValueMember = "MaKH"
        cboKH.DataSource = ExecDataTable("SELECT MaKH, TenKH FROM KhachHang ORDER BY TenKH")
    End Sub

    Private Sub SetupGrid()
        dgvItems.Columns.Clear()
        dgvItems.AllowUserToAddRows = False
        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvItems.Columns.Add("MaSP", "Mã SP")
        dgvItems.Columns.Add("TenSP", "Tên SP")
        dgvItems.Columns.Add("SoLuong", "Số lượng")
        dgvItems.Columns.Add("DonGia", "Đơn giá")
        dgvItems.Columns.Add("ThanhTien", "Thành tiền")
        dgvItems.Columns("DonGia").ReadOnly = True
        dgvItems.Columns("TenSP").ReadOnly = True
        dgvItems.Columns("ThanhTien").ReadOnly = True
    End Sub

    Private Sub UpdateTotal()
        Dim sum As Decimal = 0D
        For Each r As DataGridViewRow In dgvItems.Rows
            Dim tt As Decimal
            Decimal.TryParse(Convert.ToString(r.Cells("ThanhTien").Value), tt)
            sum += tt
        Next
        lblTong.Text = $"Tổng: {sum:n0} đ"
    End Sub

    Private Function GetSP(ma As String) As DataRow
        Dim dt = ExecDataTable("SELECT MaSP, TenSP, DonGia FROM SanPham WHERE MaSP=@m",
                               New List(Of SqlClient.SqlParameter) From {New SqlClient.SqlParameter("@m", ma)})
        If dt.Rows.Count = 0 Then Return Nothing
        Return dt.Rows(0)
    End Function

    Private Sub btnThemSP_Click(sender As Object, e As EventArgs) Handles btnThemSP.Click
        Dim ma = InputBox("Nhập mã SP:")
        If String.IsNullOrWhiteSpace(ma) Then Return
        Dim dr = GetSP(ma.Trim())
        If dr Is Nothing Then
            MessageBox.Show("Không tìm thấy SP!") : Return
        End If

        Dim slStr = InputBox($"Nhập số lượng cho [{dr("TenSP")}] :")
        Dim sl As Integer
        If Not Integer.TryParse(slStr, sl) OrElse sl <= 0 Then
            MessageBox.Show("Số lượng không hợp lệ!") : Return
        End If

        Dim dg As Decimal = CDec(dr("DonGia"))
        Dim tt As Decimal = dg * sl

        Dim idx = dgvItems.Rows.Add()
        With dgvItems.Rows(idx)
            .Cells("MaSP").Value = dr("MaSP").ToString()
            .Cells("TenSP").Value = dr("TenSP").ToString()
            .Cells("SoLuong").Value = sl
            .Cells("DonGia").Value = dg
            .Cells("ThanhTien").Value = tt
        End With
        UpdateTotal()
    End Sub

    Private Function ValidateInvoice() As Boolean
        If String.IsNullOrWhiteSpace(txtMaHD.Text) Then
            MessageBox.Show("Nhập Mã HĐ!") : Return False
        End If
        If cboNV.SelectedValue Is Nothing Then
            MessageBox.Show("Chọn Nhân viên!") : Return False
        End If
        If dgvItems.Rows.Count = 0 Then
            MessageBox.Show("Chưa có dòng hàng!") : Return False
        End If
        Return True
    End Function

    Private Sub btnLuuHD_Click(sender As Object, e As EventArgs) Handles btnLuuHD.Click
        If Not ValidateInvoice() Then Return

        Try
            ' 1) Tạo Hóa đơn
            Dim pHD = New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@MaHD", txtMaHD.Text.Trim()),
                New SqlClient.SqlParameter("@MaNV", cboNV.SelectedValue.ToString()),
                New SqlClient.SqlParameter("@MaKH", If(cboKH.SelectedValue Is Nothing, CType(DBNull.Value, Object), cboKH.SelectedValue))
            }
            ExecNonQuery("usp_HoaDon_Create", pHD, True)

            ' 2) Thêm từng dòng CTHD (trigger sẽ trừ kho)
            For Each r As DataGridViewRow In dgvItems.Rows
                Dim p = New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@MaHD", txtMaHD.Text.Trim()),
                    New SqlClient.SqlParameter("@MaSP", r.Cells("MaSP").Value.ToString()),
                    New SqlClient.SqlParameter("@SoLuong", Integer.Parse(r.Cells("SoLuong").Value.ToString()))
                }
                ExecNonQuery("usp_CTHD_AddItem", p, True)
            Next

            MessageBox.Show("Lưu hóa đơn thành công!")
            ' xem tổng tiền tính từ cột computed
            Dim tong = ExecScalar(Of Decimal)(
                "SELECT TongTien FROM HoaDon WHERE MaHD=@id",
                New List(Of SqlClient.SqlParameter) From {New SqlClient.SqlParameter("@id", txtMaHD.Text.Trim())}
            )
            lblTong.Text = $"Tổng: {tong:n0} đ"
            dgvItems.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show("Lỗi lưu HĐ: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cboKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKH.SelectedIndexChanged

    End Sub

    Private Sub btnmain_Click(sender As Object, e As EventArgs) Handles btnmain.Click
        Mainfrom.Show()
        Me.Close()

    End Sub
End Class
