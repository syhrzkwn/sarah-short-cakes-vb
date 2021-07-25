<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDeliveryDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDeliveryDetails))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrintDeliveryDetails = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOMEToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(55, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(741, 150)
        Me.DataGridView1.TabIndex = 42
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(152, 50)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox1.TabIndex = 44
        Me.CheckBox1.Text = "Delivery"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Search Details for:"
        '
        'btnPrintDeliveryDetails
        '
        Me.btnPrintDeliveryDetails.Location = New System.Drawing.Point(721, 255)
        Me.btnPrintDeliveryDetails.Name = "btnPrintDeliveryDetails"
        Me.btnPrintDeliveryDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintDeliveryDetails.TabIndex = 47
        Me.btnPrintDeliveryDetails.Text = "PRINT"
        Me.btnPrintDeliveryDetails.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'formDeliveryDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(859, 333)
        Me.Controls.Add(Me.btnPrintDeliveryDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formDeliveryDetails"
        Me.Text = "Sarah's Short Cake - Delivery Details"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrintDeliveryDetails As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
