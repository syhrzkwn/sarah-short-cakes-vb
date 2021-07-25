Public Class formWelcome

    'Button Customer Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formCustLogin.Show()
        Me.Hide()
    End Sub

    'Button Staff Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formStaffLogin.Show()
        Me.Hide()
    End Sub

    'Menu tool strip to exit the application
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class