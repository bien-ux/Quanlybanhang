Public Class loginformvb
    Public Property LoggedUser As DataRow

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dt = ExecDataTable("SELECT * FROM NhanVien WHERE TenDangNhap=@u AND MatKhauHash=@p",
                New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@u", txtUser.Text.Trim()),
                    New SqlClient.SqlParameter("@p", txtPass.Text.Trim()) ' DEMO: thực tế dùng hash
                })

        If dt.Rows.Count = 1 Then
            LoggedUser = dt.Rows(0)

            MessageBox.Show("Đăng nhập thành công!", "Thông báo")

            ' Ẩn form login và mở form chính
            Dim main As New Mainfrom
            main.Show()

            Me.Hide()
        Else
            MessageBox.Show("Sai thông tin đăng nhập!", "Lỗi")
        End If
    End Sub

    Private Sub loginformvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        End
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
End Class