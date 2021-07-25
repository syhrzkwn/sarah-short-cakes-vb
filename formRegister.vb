Imports System.Data.OleDb
Public Class formRegister

    'Connect with database Access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CSC301 - Visual Programming\SARAH SHORT CAKES – SALES ORDER SYSTEM\Sarahs_Short_Cake.accdb")

    'Login tool strip to open customer login form 
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        formCustLogin.Show()
        Me.Hide()
    End Sub

    'Exit tool strip to exit application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sarahs_Short_CakeDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.Sarahs_Short_CakeDataSet.CUSTOMER)

        'To clear all the text box in load
        UsernameTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        EmailAddressTextBox.Clear()
        PhoneNumberTextBox.Clear()
        StreetTextBox.Clear()
        CityTextBox.Clear()
        PasswordTextBox.Clear()

    End Sub

    'Button to register new customer
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If btnRegister.Text = "ADD NEW" Then
            CUSTOMERBindingSource.AddNew()
            btnRegister.Text = "CANCEL"
            UsernameTextBox.Select()
            FirstNameTextBox.Select()
            LastNameTextBox.Select()
            EmailAddressTextBox.Select()
            PhoneNumberTextBox.Select()
            StreetTextBox.Select()
            CityTextBox.Select()
            PasswordTextBox.Select()
        Else
            CUSTOMERBindingSource.CancelEdit()
            btnRegister.Text = "ADD NEW"
        End If
    End Sub

    'Button to clear all input
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        UsernameTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        EmailAddressTextBox.Clear()
        PhoneNumberTextBox.Clear()
        StreetTextBox.Clear()
        CityTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    'Button to save data into database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CUSTOMERBindingSource.EndEdit()
        CUSTOMERTableAdapter.Update(Me.Sarahs_Short_CakeDataSet)
        btnRegister.Text = "REGISTER"
        MessageBox.Show("Thank You for register with us!")
    End Sub

    Private Sub CUSTOMERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CUSTOMERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sarahs_Short_CakeDataSet)

    End Sub
End Class