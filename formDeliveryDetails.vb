Imports System.Data.OleDb
Public Class formDeliveryDetails
    'Home tool strip to go back to Home form for staff
    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        formStaffHome.Show()
        Me.Hide()
        formStaffLogin.TextBox1.Clear()
        formStaffLogin.TextBox2.Clear()
    End Sub

    'Check box = True will appear all delivery detail that the shop have
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CSC301 - Visual Programming\SARAH SHORT CAKES – SALES ORDER SYSTEM\bin\Debug\Sarahs_Short_Cake.accdb")
        If con.State = ConnectionState.Closed Then
            con.Open() 'Conection open

        End If

        'Command Query to display tables of delivery details
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT ORDER.Order_Code, CUSTOMER.FirstName, CUSTOMER.LastName, CUSTOMER.EmailAddress, CUSTOMER.PhoneNumber, CUSTOMER.Street, CUSTOMER.City, ORDER.OrderDate, ORDER.DateNeeded, ORDER.TimeNeeded, ORDER.Cupcake_Code, ORDER.Delivery
FROM CUSTOMER INNER JOIN [ORDER] ON CUSTOMER.Username = ORDER.Username WHERE ORDER.Delivery = Yes", con)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        Dim delivery As String = ""
        Dim sdr As OleDbDataReader = cmd.ExecuteReader

        If sdr.Read = True Then

            delivery = sdr("Delivery")
            DataGridView1.DataSource = dt

            'Set name header for every table
            DataGridView1.Columns(0).HeaderText = "ORDER CODE"
            DataGridView1.Columns(1).HeaderText = "FIRST NAME"
            DataGridView1.Columns(2).HeaderText = "LAST NAME"
            DataGridView1.Columns(3).HeaderText = "EMAIL ADDRESS"
            DataGridView1.Columns(4).HeaderText = "PHONE NUMBER"
            DataGridView1.Columns(5).HeaderText = "STREET"
            DataGridView1.Columns(6).HeaderText = "CITY"
            DataGridView1.Columns(7).HeaderText = "ORDER DATE"
            DataGridView1.Columns(8).HeaderText = "DATE NEEDED"
            DataGridView1.Columns(9).HeaderText = "TIME NEEDED"
            DataGridView1.Columns(10).HeaderText = "CUPCAKE CODE"
            DataGridView1.Columns(11).HeaderText = "DELIVERY"

        Else
            MessageBox.Show("There is no cupcake for delivery")
        End If

        con.Close() 'Connection close
    End Sub

    'Button to print form as a Delivery Details
    Private Bitmap As Bitmap
    Private Sub btnPrintDeliveryDetails_Click(sender As Object, e As EventArgs) Handles btnPrintDeliveryDetails.Click

        Dim panel As New Panel()
        Me.Controls.Add(panel)

        Dim grp As Graphics = panel.CreateGraphics
        Dim formSize As Size = Me.ClientSize
        Bitmap = New Bitmap(formSize.Width, formSize.Height, grp)
        grp = Graphics.FromImage(Bitmap)

        Dim panelLocation As Point = PointToScreen(panel.Location)
        grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize)

        'Print Preview Dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(Bitmap, 0, 0)

    End Sub
End Class