Imports System.Data
Imports System.Data.SqlClient

Module Db
    ' ĐỔI chuỗi kết nối cho phù hợp máy bạn
    Public Const ConnStr As String =
        "Data Source=LAPTOP-8H4JMGDH\BIEN;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Public Function GetConnection() As SqlConnection
        Dim cn As New SqlConnection(ConnStr)
        cn.Open()
        Return cn
    End Function

    Public Function ExecDataTable(sql As String,
                              Optional params As List(Of SqlParameter) = Nothing,
                              Optional isStored As Boolean = False) As DataTable
        Dim dt As New DataTable()

        ' Nếu là stored procedure và người dùng lỡ truyền "EXEC ..." thì loại bỏ
        If isStored AndAlso sql.Trim().StartsWith("EXEC", StringComparison.OrdinalIgnoreCase) Then
            sql = sql.Trim().Substring(4).Trim() ' bỏ chữ EXEC
        End If

        Using cn As SqlConnection = GetConnection(),
          cmd As New SqlCommand(sql, cn)

            cmd.CommandType = If(isStored, CommandType.StoredProcedure, CommandType.Text)

            If params IsNot Nothing AndAlso params.Count > 0 Then
                cmd.Parameters.AddRange(params.ToArray())
            End If
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function



    Public Function ExecNonQuery(sql As String, Optional params As List(Of SqlParameter) = Nothing,
                                 Optional isStored As Boolean = False) As Integer
        Using cn = GetConnection(), cmd As New SqlCommand(sql, cn)
            cmd.CommandType = If(isStored, CommandType.StoredProcedure, CommandType.Text)
            If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    Public Function ExecScalar(Of T)(sql As String, Optional params As List(Of SqlParameter) = Nothing,
                                     Optional isStored As Boolean = False) As T
        Using cn = GetConnection(), cmd As New SqlCommand(sql, cn)
            cmd.CommandType = If(isStored, CommandType.StoredProcedure, CommandType.Text)
            If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
            Dim o = cmd.ExecuteScalar()
            If o Is Nothing OrElse o Is DBNull.Value Then Return Nothing
            Return CType(o, T)
        End Using
    End Function
End Module

Public Class ProductForm
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData(Optional key As String = "")
        Dim sql = "EXEC usp_SanPham_GetAll"
        Dim dt = ExecDataTable(sql, isStored:=True)
        If key <> "" Then
            dt.DefaultView.RowFilter = $"TenSP LIKE '%{key.Replace("'", "''")}%' OR MaSP LIKE '%{key.Replace("'", "''")}%'"
            dgv.DataSource = dt.DefaultView.ToTable()
        Else
            dgv.DataSource = dt
        End If
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtMa.Text) Then
            MessageBox.Show("Mã SP không được trống") : Return False
        End If
        If String.IsNullOrWhiteSpace(txtTen.Text) Then
            MessageBox.Show("Tên SP không được trống") : Return False
        End If
        Dim gia As Decimal
        If Not Decimal.TryParse(txtDonGia.Text, gia) OrElse gia < 0D Then
            MessageBox.Show("Đơn giá không hợp lệ") : Return False
        End If
        Dim ton As Integer
        If Not Integer.TryParse(txtTon.Text, ton) OrElse ton < 0 Then
            MessageBox.Show("Số lượng tồn không hợp lệ") : Return False
        End If
        Return True
    End Function

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If Not ValidateInput() Then Return
        Dim p = New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@MaSP", txtMa.Text.Trim()),
            New SqlClient.SqlParameter("@TenSP", txtTen.Text.Trim()),
            New SqlClient.SqlParameter("@DonViTinh", txtDVT.Text.Trim()),
            New SqlClient.SqlParameter("@DonGia", Decimal.Parse(txtDonGia.Text)),
            New SqlClient.SqlParameter("@SoLuongTon", Integer.Parse(txtTon.Text))
        }
        ExecNonQuery("usp_SanPham_Insert", p, True)
        LoadData()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If Not ValidateInput() Then Return
        Dim p = New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@MaSP", txtMa.Text.Trim()),
            New SqlClient.SqlParameter("@TenSP", txtTen.Text.Trim()),
            New SqlClient.SqlParameter("@DonViTinh", txtDVT.Text.Trim()),
            New SqlClient.SqlParameter("@DonGia", Decimal.Parse(txtDonGia.Text)),
            New SqlClient.SqlParameter("@SoLuongTon", Integer.Parse(txtTon.Text))
        }
        ExecNonQuery("usp_SanPham_Update", p, True)
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If String.IsNullOrWhiteSpace(txtMa.Text) Then
            MessageBox.Show("Chọn dòng để xóa!") : Return
        End If
        If MessageBox.Show("Xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim p = New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@MaSP", txtMa.Text.Trim())
            }
            ExecNonQuery("usp_SanPham_Delete", p, True)
            LoadData()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim r = dgv.Rows(e.RowIndex)
            txtMa.Text = r.Cells("MaSP").Value?.ToString()
            txtTen.Text = r.Cells("TenSP").Value?.ToString()
            txtDVT.Text = r.Cells("DonViTinh").Value?.ToString()
            txtDonGia.Text = r.Cells("DonGia").Value?.ToString()
            txtTon.Text = r.Cells("SoLuongTon").Value?.ToString()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadData(txtSearch.Text.Trim())
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnmain.Click
        Mainfrom.Show()
        Me.Close()

    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtTon_TextChanged(sender As Object, e As EventArgs) Handles txtTon.TextChanged

    End Sub

    Private Sub txtMa_TextChanged(sender As Object, e As EventArgs) Handles txtMa.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtTen_TextChanged(sender As Object, e As EventArgs) Handles txtTen.TextChanged

    End Sub

    Private Sub txtDVT_TextChanged(sender As Object, e As EventArgs) Handles txtDVT.TextChanged

    End Sub
End Class
