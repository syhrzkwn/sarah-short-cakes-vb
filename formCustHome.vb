Public Class formCustHome

    'Button to open form cupcake order
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formOrder.Show()
        Me.Hide()
    End Sub

    'Button to logout back to customer login form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formCustLogin.Show()
        Me.Hide()
        formCustLogin.TextBox1.Clear()
        formCustLogin.TextBox2.Clear()
    End Sub

    'Button to exit application
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Exit tool strip to exit application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class