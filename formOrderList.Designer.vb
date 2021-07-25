<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOrderList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOrderList))
        Me.Sarahs_Short_CakeDataSet = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSet()
        Me.ORDERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDERTableAdapter = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.ORDERTableAdapter()
        Me.TableAdapterManager = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.TableAdapterManager()
        Me.CUPCAKESTableAdapter = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.CUPCAKESTableAdapter()
        Me.ORDERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ORDERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CUPCAKESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSearchCupcakeCode = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.Sarahs_Short_CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ORDERBindingNavigator.SuspendLayout()
        CType(Me.CUPCAKESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sarahs_Short_CakeDataSet
        '
        Me.Sarahs_Short_CakeDataSet.DataSetName = "Sarahs_Short_CakeDataSet"
        Me.Sarahs_Short_CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORDERBindingSource
        '
        Me.ORDERBindingSource.DataMember = "ORDER"
        Me.ORDERBindingSource.DataSource = Me.Sarahs_Short_CakeDataSet
        '
        'ORDERTableAdapter
        '
        Me.ORDERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUPCAKESTableAdapter = Me.CUPCAKESTableAdapter
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Me.ORDERTableAdapter
        Me.TableAdapterManager.ORDTableAdapter = Nothing
        Me.TableAdapterManager.SPECIALTableAdapter = Nothing
        Me.TableAdapterManager.STAFFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CUPCAKESTableAdapter
        '
        Me.CUPCAKESTableAdapter.ClearBeforeFill = True
        '
        'ORDERBindingNavigator
        '
        Me.ORDERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ORDERBindingNavigator.BindingSource = Me.ORDERBindingSource
        Me.ORDERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ORDERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ORDERBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ORDERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ORDERBindingNavigatorSaveItem})
        Me.ORDERBindingNavigator.Location = New System.Drawing.Point(0, 367)
        Me.ORDERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ORDERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ORDERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ORDERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ORDERBindingNavigator.Name = "ORDERBindingNavigator"
        Me.ORDERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ORDERBindingNavigator.Size = New System.Drawing.Size(913, 25)
        Me.ORDERBindingNavigator.TabIndex = 0
        Me.ORDERBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ORDERBindingNavigatorSaveItem
        '
        Me.ORDERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ORDERBindingNavigatorSaveItem.Image = CType(resources.GetObject("ORDERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ORDERBindingNavigatorSaveItem.Name = "ORDERBindingNavigatorSaveItem"
        Me.ORDERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ORDERBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CUPCAKESBindingSource
        '
        Me.CUPCAKESBindingSource.DataMember = "CUPCAKES"
        Me.CUPCAKESBindingSource.DataSource = Me.Sarahs_Short_CakeDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(913, 24)
        Me.MenuStrip1.TabIndex = 31
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Order Code:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 59)
        Me.TextBox1.MaxLength = 7
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 37
        '
        'btnSearchCupcakeCode
        '
        Me.btnSearchCupcakeCode.Location = New System.Drawing.Point(123, 85)
        Me.btnSearchCupcakeCode.Name = "btnSearchCupcakeCode"
        Me.btnSearchCupcakeCode.Size = New System.Drawing.Size(55, 23)
        Me.btnSearchCupcakeCode.TabIndex = 35
        Me.btnSearchCupcakeCode.Text = "Search"
        Me.btnSearchCupcakeCode.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(833, 150)
        Me.DataGridView1.TabIndex = 38
        '
        'formOrderList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 392)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearchCupcakeCode)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ORDERBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formOrderList"
        Me.Text = "Sarah's Short Cake - Order List"
        CType(Me.Sarahs_Short_CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ORDERBindingNavigator.ResumeLayout(False)
        Me.ORDERBindingNavigator.PerformLayout()
        CType(Me.CUPCAKESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sarahs_Short_CakeDataSet As Sarahs_Short_CakeDataSet
    Friend WithEvents ORDERBindingSource As BindingSource
    Friend WithEvents ORDERTableAdapter As Sarahs_Short_CakeDataSetTableAdapters.ORDERTableAdapter
    Friend WithEvents TableAdapterManager As Sarahs_Short_CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ORDERBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ORDERBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CUPCAKESTableAdapter As Sarahs_Short_CakeDataSetTableAdapters.CUPCAKESTableAdapter
    Friend WithEvents CUPCAKESBindingSource As BindingSource
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSearchCupcakeCode As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
