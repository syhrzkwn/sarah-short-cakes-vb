Imports System.Data.OleDb
Public Class formOrder
    Dim con_str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CSC301 - Visual Programming\SARAH SHORT CAKES – SALES ORDER SYSTEM\bin\Debug\Sarahs_Short_Cake.accdb"
    Dim con As New OleDbConnection()
    Dim cmd As New OleDbCommand
    Dim adapter As OleDbDataAdapter
    'Function get data order
    Sub getDataOrder()
        Using con = New OleDbConnection(con_str) 'Connect With database Access
            Try
                con.Open() 'Connection open
                Dim sql As String = "SELECT * FROM [ORDER]"
                cmd = New OleDbCommand(sql, con)
                adapter = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0) 'DataGridView was set to invisible in properties for privacy purpose

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    'Function to auto generate order code
    Sub GenerateOrderCode()
        Using con = New OleDbConnection(con_str)
            Try
                con.Open()
                Dim sql As String = "SELECT TOP 1 Order_Code FROM [ORDER] ORDER BY Order_Code DESC"
                cmd = New OleDbCommand(sql, con)
                adapter = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)

                If (ds.Tables(0).Rows.Count > 0) Then

                    Dim tmp_ordercode = ds.Tables(0).Rows(0)("Order_Code").ToString().Substring(3, 4)
                    Dim new_ordercode As Integer = CInt(tmp_ordercode) + 1
                    Order_CodeTextBox.Text = "ORD" & new_ordercode.ToString("0000")

                Else
                    Order_CodeTextBox.Text = "ORD0001"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    'Function to get data cupcake
    Sub getDataCupcake()
        Using con = New OleDbConnection(con_str) 'Connect With database Access
            Try
                con.Open() 'Connection open
                Dim sql As String = "SELECT * FROM CUPCAKES"
                cmd = New OleDbCommand(sql, con)
                adapter = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)
                DataGridView2.DataSource = ds.Tables(0) 'DataGridView was set to invisible in properties for privacy purpose

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    'Function to auto generate cupcake code
    Sub GenerateCupcakeCode()
        Using con = New OleDbConnection(con_str)
            Try
                con.Open()
                Dim sql As String = "SELECT TOP 1 Cupcake_Code FROM CUPCAKES ORDER BY Cupcake_Code DESC"
                cmd = New OleDbCommand(sql, con)
                adapter = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)

                If (ds.Tables(0).Rows.Count > 0) Then

                    Dim tmp_ordercode = ds.Tables(0).Rows(0)("Cupcake_Code").ToString().Substring(3, 4)
                    Dim new_ordercode As Integer = CInt(tmp_ordercode) + 1
                    Cupcake_CodeTextBox.Text = "CPC" & new_ordercode.ToString("0000")
                    Cupcake_CodeTextBox1.Text = "CPC" & new_ordercode.ToString("0000")

                Else
                    Cupcake_CodeTextBox.Text = "CPC0001"
                    Cupcake_CodeTextBox1.Text = "CPC0001"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub formOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sarahs_Short_CakeDataSet.CUPCAKES' table. You can move, or remove it, as needed.
        Me.CUPCAKESTableAdapter.Fill(Me.Sarahs_Short_CakeDataSet.CUPCAKES)
        'TODO: This line of code loads data into the 'Sarahs_Short_CakeDataSet.ORDER' table. You can move, or remove it, as needed.
        Me.ORDERTableAdapter.Fill(Me.Sarahs_Short_CakeDataSet.ORDER)

        'Combo Box for Flavour
        FlavourComboBox.Items.Add("Vanilla")
        FlavourComboBox.Items.Add("Strawberry")
        FlavourComboBox.Items.Add("Blueberry")
        FlavourComboBox.Items.Add("Chocolate")
        FlavourComboBox.Items.Add("White Chocolate")
        FlavourComboBox.Items.Add("Double Chocolate")
        FlavourComboBox.Items.Add("Chocolate Chip Cheesecake")
        FlavourComboBox.Items.Add("S'Mores")
        FlavourComboBox.Items.Add("Peanut Butter")
        FlavourComboBox.Items.Add("Pumpkin Spice")
        FlavourComboBox.Items.Add("Apple Cinnamon")
        FlavourComboBox.Items.Add("Cookies and Cream")
        FlavourComboBox.Items.Add("Champagne")
        FlavourComboBox.Items.Add("Mississippi Mud")
        FlavourComboBox.Items.Add("Red Velvet")
        FlavourComboBox.Items.Add("Coconut")

        'Combo Box for Colour Flavour
        ColourFlavourComboBox.Items.Add("Blue")
        ColourFlavourComboBox.Items.Add("Green")
        ColourFlavourComboBox.Items.Add("Purple")
        ColourFlavourComboBox.Items.Add("Red")
        ColourFlavourComboBox.Items.Add("Orange")
        ColourFlavourComboBox.Items.Add("Yellow")
        ColourFlavourComboBox.Items.Add("Chocolate")
        ColourFlavourComboBox.Items.Add("White")

        'Combo Box for Icing
        IcingComboBox.Items.Add("Vanilla")
        IcingComboBox.Items.Add("Butter Cream")
        IcingComboBox.Items.Add("Lemon")
        IcingComboBox.Items.Add("Cream Cheese")
        IcingComboBox.Items.Add("Cookie Crumbs")
        IcingComboBox.Items.Add("Strawberry")
        IcingComboBox.Items.Add("Peanut Butter")
        IcingComboBox.Items.Add("Oreo")
        IcingComboBox.Items.Add("Champagne")
        IcingComboBox.Items.Add("Dark Chocolate")
        IcingComboBox.Items.Add("Milk Chocolate")
        IcingComboBox.Items.Add("Mint Chocolate")
        IcingComboBox.Items.Add("German Chocolate")
        IcingComboBox.Items.Add("Espresso")
        IcingComboBox.Items.Add("Pink Lemonade")
        IcingComboBox.Items.Add("Coconut Pecan")

        'Combo Box for Icing Colour
        ColourIcingComboBox.Items.Add("Blue")
        ColourIcingComboBox.Items.Add("Green")
        ColourIcingComboBox.Items.Add("Purple")
        ColourIcingComboBox.Items.Add("Red")
        ColourIcingComboBox.Items.Add("Orange")
        ColourIcingComboBox.Items.Add("Yellow")
        ColourIcingComboBox.Items.Add("Chocolate")
        ColourIcingComboBox.Items.Add("White")

        'Combo Box for Deco Code
        Deco_CodeComboBox.Items.Add("None")
        Deco_CodeComboBox.Items.Add("F") 'F for Frozen decoration
        Deco_CodeComboBox.Items.Add("U") 'U for Unicorn decoration
        Deco_CodeComboBox.Items.Add("WR") 'White Rose decoration
        Deco_CodeComboBox.Items.Add("RR") 'Red Rose decoration
        Deco_CodeComboBox.Items.Add("BR") 'Blue Rose decoration

    End Sub

    Private Sub CUPCAKESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CUPCAKESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sarahs_Short_CakeDataSet)
    End Sub

    Private Sub ORDERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ORDERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sarahs_Short_CakeDataSet)
    End Sub

    'Button order to insert data into database
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        If btnOrder.Text = "NEW ORDER" Then

            CUPCAKESBindingSource.AddNew()
            ORDERBindingSource.AddNew()
            btnOrder.Text = "CANCEL"
            'Order
            UsernameTextBox.Select()
            Order_CodeTextBox.Select()
            OrderDateDateTimePicker.Select()
            DateNeededDateTimePicker.Select()
            TimeNeededDateTimePicker.Select()
            Cupcake_CodeTextBox.Select()
            DeliveryCheckBox.Select()
            PickUpCheckBox.Select()
            'Cupcake
            Cupcake_CodeTextBox1.Select()
            Order_QuantityTextBox.Select()
            FlavourComboBox.Select()
            ColourFlavourComboBox.Select()
            IcingComboBox.Select()
            ColourIcingComboBox.Select()
            Deco_CodeComboBox.Select()
            PriceTextBox.Select()

            'Time format
            TimeNeededDateTimePicker.Format = DateTimePickerFormat.Custom
            TimeNeededDateTimePicker.CustomFormat = "hh:mm tt"

            'Call Function get data for cupcake and order
            'Call Function auto generate cupcake and ordercode
            getDataCupcake()
            GenerateCupcakeCode()
            getDataOrder()
            GenerateOrderCode()

        Else
            ORDERBindingSource.CancelEdit()
            CUPCAKESBindingSource.CancelEdit()
            btnOrder.Text = "NEW ORDER"

        End If
    End Sub

    'Button to save data into database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Order
        ORDERBindingSource.EndEdit()
        ORDERTableAdapter.Update(Me.Sarahs_Short_CakeDataSet.ORDER)

        'Cupcake
        CUPCAKESBindingSource.EndEdit()
        CUPCAKESTableAdapter.Update(Me.Sarahs_Short_CakeDataSet.CUPCAKES)

        btnOrder.Text = "ORDER"
        MessageBox.Show("We have received your order. Thank You!")

    End Sub

    'Button to delete data in the database
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show(Me, "Are you sure, you want to DELETE?", "Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Order
            ORDERBindingSource.RemoveCurrent()
            ORDERTableAdapter.Update(Me.Sarahs_Short_CakeDataSet)
            'Cupcake
            CUPCAKESBindingSource.RemoveCurrent()
            CUPCAKESTableAdapter.Update(Me.Sarahs_Short_CakeDataSet)
        End If

    End Sub

    'Button clear input
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'to clear Order input
        UsernameTextBox.Clear()
        OrderDateDateTimePicker.ResetText()
        DateNeededDateTimePicker.ResetText()
        TimeNeededDateTimePicker.ResetText()
        DeliveryCheckBox.Checked = False
        PickUpCheckBox.Checked = False
        'to clear Cupcake input
        Order_QuantityTextBox.Clear()
        FlavourComboBox.SelectedIndex() = -1
        ColourFlavourComboBox.SelectedIndex() = -1
        IcingComboBox.SelectedIndex() = -1
        ColourIcingComboBox.SelectedIndex() = -1
        Deco_CodeComboBox.SelectedIndex() = -1
        'to clear total price
        PriceTextBox.Clear()
    End Sub

    'Home tool strip click to go back to home form
    Private Sub HOMEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        formCustHome.Show()
        Me.Hide()
    End Sub

    'Link label to show user detail about deco code
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("F - Frozen, U - Unicorn, WR - White Rose, RR - Red Rose, BR - Blue Rose")
    End Sub

    'Button to calculate the total price
    Private Sub btnTotalPrice_Click(sender As Object, e As EventArgs) Handles btnTotalPrice.Click
        'Total Price
        Dim cupcake As Double = 4.5 'Cupcake price is RM4.50
        Dim totalPrice As Double
        Dim quantity As Integer = Order_QuantityTextBox.Text

        If (DeliveryCheckBox.Checked = True) Then
            totalPrice = (cupcake * quantity) + 5 'RM5 Delivery cost
        Else
            totalPrice = cupcake * quantity
        End If
        PriceTextBox.Text = FormatCurrency(totalPrice, 2)
    End Sub

    'Button to print the sales receipt
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    'Sales Receipt design
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("WELCOME TO SARAH'S SHORT CAKES", New Font("Arial", 22, FontStyle.Italic), Brushes.Black, New Point(120, 20))
        e.Graphics.DrawString("SALES RECEIPT", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(360, 70))
        e.Graphics.DrawString("Receipt Date: " + DateTime.Now, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(70, 100))
        e.Graphics.DrawString("============================================================================================================================================================================== ", New Font("Arial", 12, FontStyle.Italic), Brushes.Black, New Point(0, 120))
        e.Graphics.DrawString("Order Code: " + Order_CodeTextBox.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(70, 150))
        e.Graphics.DrawString("Order Date: " + OrderDateDateTimePicker.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(500, 150))
        e.Graphics.DrawString("Username: " + UsernameTextBox.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(70, 170))
        e.Graphics.DrawString("Date Needed: " + DateNeededDateTimePicker.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(500, 170))
        e.Graphics.DrawString("Time Needed: " + TimeNeededDateTimePicker.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(70, 190))
        e.Graphics.DrawString("Delivery Type: " + DeliveryCheckBox.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(500, 190))
        e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ ", New Font("Arial", 12, FontStyle.Italic), Brushes.Black, New Point(0, 220))
        e.Graphics.DrawString("Cupcake Code: " + Cupcake_CodeTextBox.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(70, 250))
        e.Graphics.DrawString("Quantity: " + Order_QuantityTextBox.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(500, 250))
        e.Graphics.DrawString("Flavour: " + FlavourComboBox.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(70, 270))
        e.Graphics.DrawString("Colour Flavour: " + ColourFlavourComboBox.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(500, 270))
        e.Graphics.DrawString("Icing: " + IcingComboBox.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(70, 290))
        e.Graphics.DrawString("Colour Icing: " + ColourIcingComboBox.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(500, 290))
        e.Graphics.DrawString("Decoration: " + Deco_CodeComboBox.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(70, 310))
        e.Graphics.DrawString("Total Price: " + PriceTextBox.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(500, 310))
        e.Graphics.DrawString("============================================================================================================================================================================== ", New Font("Arial", 12, FontStyle.Italic), Brushes.Black, New Point(0, 340))
        e.Graphics.DrawString("THANK YOU & PLEASE COME AGAIN", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(270, 370))

    End Sub
End Class