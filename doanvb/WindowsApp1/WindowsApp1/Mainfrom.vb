Public Class Mainfrom
    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnSanPham.Click
        ProductForm.Show()
        Me.Close()
    End Sub

    Private Sub btnHoaDon_Click(sender As Object, e As EventArgs) Handles btnHoaDon.Click
        InvoiceForm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bt.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class