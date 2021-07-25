Imports System.Data.OleDb
Public Class formCustLogin

    'Connect with database Access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CSC301 - Visual Programming\SARAH SHORT CAKES – SALES ORDER SYSTEM\bin\Debug\Sarahs_Short_Cake.accdb")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Link label to open register form 
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        formRegister.Show()
        Me.Hide()
    End Sub

    'Welcome tool strip to open welcome form
    Private Sub WelcomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WelcomeToolStripMenuItem.Click
        formWelcome.Show()
        Me.Hide()
    End Sub

    'Exit tool strip to exit application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Button for customer login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Command Query to retrieve data from tables CUSTOMER for user verification
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT Username, Password FROM CUSTOMER WHERE Username='" & TextBox1.Text & "' AND Password='" & TextBox2.Text & "'", con)
        Dim username As String = ""
        Dim password As String = ""

        con.Open() 'Connection open
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        If sdr.Read = True Then

            username = sdr("Username")
            password = sdr("Password")

            MessageBox.Show("Login Successful")
            formCustHome.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login Failed")
        End If
        con.Close() 'Connection close
    End Sub
End Class
