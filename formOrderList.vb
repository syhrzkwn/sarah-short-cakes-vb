Imports System.Data.OleDb
Public Class formOrderList

    Private Sub ORDERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ORDERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ORDERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sarahs_Short_CakeDataSet)

    End Sub

    Private Sub formOrderList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sarahs_Short_CakeDataSet.CUPCAKES' table. You can move, or remove it, as needed.
        Me.CUPCAKESTableAdapter.Fill(Me.Sarahs_Short_CakeDataSet.CUPCAKES)
        'TODO: This line of code loads data into the 'Sarahs_Short_CakeDataSet.ORDER' table. You can move, or remove it, as needed.
        Me.ORDERTableAdapter.Fill(Me.Sarahs_Short_CakeDataSet.ORDER)

    End Sub

    'Home tool strip to go back to Staff Home form
    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        formStaffHome.Show()
        Me.Hide()
        formStaffLogin.TextBox1.Clear()
        formStaffLogin.TextBox2.Clear()
    End Sub

    'Button to search order list by searching cupcake code
    Private Sub btnSearchCupcakeCode_Click(sender As Object, e As EventArgs) Handles btnSearchCupcakeCode.Click
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CSC301 - Visual Programming\SARAH SHORT CAKES – SALES ORDER SYSTEM\bin\Debug\Sarahs_Short_Cake.accdb")
        If con.State = ConnectionState.Closed Then
            con.Open() 'Connection open

        End If

        'Command Query to show all the data of order list
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT ORDER.Order_Code, ORDER.OrderDate, ORDER.DateNeeded, ORDER.TimeNeeded, ORDER.Username, ORDER.Cupcake_Code, ORDER.Delivery, ORDER.PickUp, CUPCAKES.Cupcake_Code, CUPCAKES.Order_Quantity, CUPCAKES.Flavour, CUPCAKES.ColourFlavour, CUPCAKES.Icing, CUPCAKES.ColourIcing, CUPCAKES.Deco_Code, CUPCAKES.Price
FROM CUPCAKES INNER JOIN [ORDER] ON CUPCAKES.Cupcake_Code = ORDER.Cupcake_Code WHERE ORDER.Order_Code = '" & TextBox1.Text & "'", con)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        Dim order As String = ""
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        If sdr.Read = True Then

            order = sdr("Order_Code")
            DataGridView1.DataSource = dt

            'Set name header for every table
            DataGridView1.Columns(0).HeaderText = "ORDER CODE"
            DataGridView1.Columns(1).HeaderText = "ORDER DATE"
            DataGridView1.Columns(2).HeaderText = "DATE NEEDED"
            DataGridView1.Columns(3).HeaderText = "TIME NEEDED"
            DataGridView1.Columns(4).HeaderText = "USERNAME"
            DataGridView1.Columns(5).HeaderText = "CUPCAKE CODE"
            DataGridView1.Columns(6).HeaderText = "DELIVERY"
            DataGridView1.Columns(7).HeaderText = "PICKUP"
            DataGridView1.Columns(8).HeaderText = "CUPCAKE CODE"
            DataGridView1.Columns(9).HeaderText = "ORDER QUANTITY"
            DataGridView1.Columns(10).HeaderText = "FLAVOUR"
            DataGridView1.Columns(11).HeaderText = "COLOUR FLAVOUR"
            DataGridView1.Columns(12).HeaderText = "ICING"
            DataGridView1.Columns(13).HeaderText = "COLOUR ICING"
            DataGridView1.Columns(14).HeaderText = "DECO CODE"
            DataGridView1.Columns(15).HeaderText = "PRICE"

        Else
            MessageBox.Show("Order code you search is not in the data")
        End If

        con.Close() 'Connection close
    End Sub
End Class