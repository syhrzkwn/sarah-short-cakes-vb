Public Class formCustDetails

    'Home tool strip to go back to Home form of staff
    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        formStaffHome.Show()
        Me.Hide()
        formStaffLogin.TextBox1.Clear()
        formStaffLogin.TextBox2.Clear()
    End Sub

    Private Sub CUSTOMERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CUSTOMERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sarahs_Short_CakeDataSet)

    End Sub

    Private Sub formCustDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sarahs_Short_CakeDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.Sarahs_Short_CakeDataSet.CUSTOMER)

    End Sub

    'Button delete to delete data in database by rows
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show(Me, "Are you sure, you want to DELETE?", "Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CUSTOMERBindingSource.RemoveCurrent()
            CUSTOMERTableAdapter.Update(Me.Sarahs_Short_CakeDataSet)
        End If
    End Sub

    'Button to print the form of customer list
    Private Bitmap As Bitmap
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
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