Public Class formStaffHome

    'Button to exit application
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    'Button to open staff login form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formStaffLogin.Show()
        Me.Hide()
        formStaffLogin.TextBox1.Clear()
        formStaffLogin.TextBox2.Clear()
    End Sub

    'Button to open form Delivery Details
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formDeliveryDetails.Show()
        Me.Hide()
    End Sub

    'Button to open form Order List
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formOrderList.Show()
        Me.Hide()
    End Sub

    'Button to open customer details
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        formCustDetails.Show()
        Me.Hide()
    End Sub
End Class