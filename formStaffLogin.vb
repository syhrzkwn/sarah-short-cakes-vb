Imports System.Data.OleDb
Public Class formStaffLogin

    'Connect with database Access
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CSC301 - Visual Programming\SARAH SHORT CAKES – SALES ORDER SYSTEM\Sarahs_Short_Cake.accdb")

    'Exit tool strip to exit application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Button for Staff login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Command Query to retrieve data from table STAFF for staff login verification
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT STAFFID, PASSWORD FROM STAFF WHERE STAFFID='" & TextBox1.Text & "' AND PASSWORD='" & TextBox2.Text & "'", con)
        Dim username As String = ""
        Dim password As String = ""

        con.Open() 'Connection open
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        If sdr.Read = True Then

            username = sdr("STAFFID")
            password = sdr("PASSWORD")

            MessageBox.Show("Login Successful")
            formStaffHome.Show()
            Me.Hide()
        Else
            MessageBox.Show("STAFF ID or PASSWORD Incorrect")
        End If
        con.Close() 'Connection close
    End Sub

    'Welcome tool strip to open welcome form
    Private Sub WelcomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WelcomeToolStripMenuItem.Click
        formWelcome.Show()
        Me.Hide()
    End Sub

End Class