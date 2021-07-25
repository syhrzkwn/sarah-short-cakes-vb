<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Order_CodeLabel As System.Windows.Forms.Label
        Dim OrderDateLabel As System.Windows.Forms.Label
        Dim DateNeededLabel As System.Windows.Forms.Label
        Dim TimeNeededLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim Cupcake_CodeLabel As System.Windows.Forms.Label
        Dim DeliveryLabel As System.Windows.Forms.Label
        Dim PickUpLabel As System.Windows.Forms.Label
        Dim Cupcake_CodeLabel1 As System.Windows.Forms.Label
        Dim Order_QuantityLabel As System.Windows.Forms.Label
        Dim FlavourLabel As System.Windows.Forms.Label
        Dim ColourFlavourLabel As System.Windows.Forms.Label
        Dim IcingLabel As System.Windows.Forms.Label
        Dim ColourIcingLabel As System.Windows.Forms.Label
        Dim Deco_CodeLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOrder))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Order_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.ORDERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sarahs_Short_CakeDataSet = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSet()
        Me.OrderDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateNeededDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeNeededDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Cupcake_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.DeliveryCheckBox = New System.Windows.Forms.CheckBox()
        Me.PickUpCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTotalPrice = New System.Windows.Forms.Button()
        Me.Cupcake_CodeTextBox1 = New System.Windows.Forms.TextBox()
        Me.CUPCAKESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.FlavourComboBox = New System.Windows.Forms.ComboBox()
        Me.ColourFlavourComboBox = New System.Windows.Forms.ComboBox()
        Me.IcingComboBox = New System.Windows.Forms.ComboBox()
        Me.ColourIcingComboBox = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Deco_CodeComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ORDERTableAdapter = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.ORDERTableAdapter()
        Me.TableAdapterManager = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.TableAdapterManager()
        Me.CUPCAKESTableAdapter = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.CUPCAKESTableAdapter()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Order_CodeLabel = New System.Windows.Forms.Label()
        OrderDateLabel = New System.Windows.Forms.Label()
        DateNeededLabel = New System.Windows.Forms.Label()
        TimeNeededLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        Cupcake_CodeLabel = New System.Windows.Forms.Label()
        DeliveryLabel = New System.Windows.Forms.Label()
        PickUpLabel = New System.Windows.Forms.Label()
        Cupcake_CodeLabel1 = New System.Windows.Forms.Label()
        Order_QuantityLabel = New System.Windows.Forms.Label()
        FlavourLabel = New System.Windows.Forms.Label()
        ColourFlavourLabel = New System.Windows.Forms.Label()
        IcingLabel = New System.Windows.Forms.Label()
        ColourIcingLabel = New System.Windows.Forms.Label()
        Deco_CodeLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ORDERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sarahs_Short_CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CUPCAKESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ORDERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ORDERBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_CodeLabel
        '
        Order_CodeLabel.AutoSize = True
        Order_CodeLabel.Location = New System.Drawing.Point(49, 47)
        Order_CodeLabel.Name = "Order_CodeLabel"
        Order_CodeLabel.Size = New System.Drawing.Size(64, 13)
        Order_CodeLabel.TabIndex = 0
        Order_CodeLabel.Text = "Order Code:"
        '
        'OrderDateLabel
        '
        OrderDateLabel.AutoSize = True
        OrderDateLabel.Location = New System.Drawing.Point(49, 74)
        OrderDateLabel.Name = "OrderDateLabel"
        OrderDateLabel.Size = New System.Drawing.Size(62, 13)
        OrderDateLabel.TabIndex = 2
        OrderDateLabel.Text = "Order Date:"
        '
        'DateNeededLabel
        '
        DateNeededLabel.AutoSize = True
        DateNeededLabel.Location = New System.Drawing.Point(49, 100)
        DateNeededLabel.Name = "DateNeededLabel"
        DateNeededLabel.Size = New System.Drawing.Size(74, 13)
        DateNeededLabel.TabIndex = 4
        DateNeededLabel.Text = "Date Needed:"
        '
        'TimeNeededLabel
        '
        TimeNeededLabel.AutoSize = True
        TimeNeededLabel.Location = New System.Drawing.Point(49, 126)
        TimeNeededLabel.Name = "TimeNeededLabel"
        TimeNeededLabel.Size = New System.Drawing.Size(74, 13)
        TimeNeededLabel.TabIndex = 6
        TimeNeededLabel.Text = "Time Needed:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(49, 151)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 8
        UsernameLabel.Text = "Username:"
        '
        'Cupcake_CodeLabel
        '
        Cupcake_CodeLabel.AutoSize = True
        Cupcake_CodeLabel.Location = New System.Drawing.Point(49, 177)
        Cupcake_CodeLabel.Name = "Cupcake_CodeLabel"
        Cupcake_CodeLabel.Size = New System.Drawing.Size(81, 13)
        Cupcake_CodeLabel.TabIndex = 10
        Cupcake_CodeLabel.Text = "Cupcake Code:"
        '
        'DeliveryLabel
        '
        DeliveryLabel.AutoSize = True
        DeliveryLabel.Location = New System.Drawing.Point(49, 205)
        DeliveryLabel.Name = "DeliveryLabel"
        DeliveryLabel.Size = New System.Drawing.Size(91, 13)
        DeliveryLabel.TabIndex = 12
        DeliveryLabel.Text = "Deliver or Pickup:"
        '
        'PickUpLabel
        '
        PickUpLabel.AutoSize = True
        PickUpLabel.Location = New System.Drawing.Point(49, 235)
        PickUpLabel.Name = "PickUpLabel"
        PickUpLabel.Size = New System.Drawing.Size(0, 13)
        PickUpLabel.TabIndex = 14
        '
        'Cupcake_CodeLabel1
        '
        Cupcake_CodeLabel1.AutoSize = True
        Cupcake_CodeLabel1.Location = New System.Drawing.Point(30, 40)
        Cupcake_CodeLabel1.Name = "Cupcake_CodeLabel1"
        Cupcake_CodeLabel1.Size = New System.Drawing.Size(81, 13)
        Cupcake_CodeLabel1.TabIndex = 19
        Cupcake_CodeLabel1.Text = "Cupcake Code:"
        '
        'Order_QuantityLabel
        '
        Order_QuantityLabel.AutoSize = True
        Order_QuantityLabel.Location = New System.Drawing.Point(30, 66)
        Order_QuantityLabel.Name = "Order_QuantityLabel"
        Order_QuantityLabel.Size = New System.Drawing.Size(78, 13)
        Order_QuantityLabel.TabIndex = 21
        Order_QuantityLabel.Text = "Order Quantity:"
        '
        'FlavourLabel
        '
        FlavourLabel.AutoSize = True
        FlavourLabel.Location = New System.Drawing.Point(30, 92)
        FlavourLabel.Name = "FlavourLabel"
        FlavourLabel.Size = New System.Drawing.Size(45, 13)
        FlavourLabel.TabIndex = 23
        FlavourLabel.Text = "Flavour:"
        '
        'ColourFlavourLabel
        '
        ColourFlavourLabel.AutoSize = True
        ColourFlavourLabel.Location = New System.Drawing.Point(30, 119)
        ColourFlavourLabel.Name = "ColourFlavourLabel"
        ColourFlavourLabel.Size = New System.Drawing.Size(78, 13)
        ColourFlavourLabel.TabIndex = 25
        ColourFlavourLabel.Text = "Colour Flavour:"
        '
        'IcingLabel
        '
        IcingLabel.AutoSize = True
        IcingLabel.Location = New System.Drawing.Point(30, 146)
        IcingLabel.Name = "IcingLabel"
        IcingLabel.Size = New System.Drawing.Size(33, 13)
        IcingLabel.TabIndex = 27
        IcingLabel.Text = "Icing:"
        '
        'ColourIcingLabel
        '
        ColourIcingLabel.AutoSize = True
        ColourIcingLabel.Location = New System.Drawing.Point(30, 173)
        ColourIcingLabel.Name = "ColourIcingLabel"
        ColourIcingLabel.Size = New System.Drawing.Size(66, 13)
        ColourIcingLabel.TabIndex = 29
        ColourIcingLabel.Text = "Colour Icing:"
        '
        'Deco_CodeLabel
        '
        Deco_CodeLabel.AutoSize = True
        Deco_CodeLabel.Location = New System.Drawing.Point(30, 200)
        Deco_CodeLabel.Name = "Deco_CodeLabel"
        Deco_CodeLabel.Size = New System.Drawing.Size(64, 13)
        Deco_CodeLabel.TabIndex = 31
        Deco_CodeLabel.Text = "Deco Code:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(30, 227)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 33
        PriceLabel.Text = "Price:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(307, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Order_CodeLabel)
        Me.GroupBox1.Controls.Add(Me.Order_CodeTextBox)
        Me.GroupBox1.Controls.Add(OrderDateLabel)
        Me.GroupBox1.Controls.Add(Me.OrderDateDateTimePicker)
        Me.GroupBox1.Controls.Add(DateNeededLabel)
        Me.GroupBox1.Controls.Add(Me.DateNeededDateTimePicker)
        Me.GroupBox1.Controls.Add(TimeNeededLabel)
        Me.GroupBox1.Controls.Add(Me.TimeNeededDateTimePicker)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(Cupcake_CodeLabel)
        Me.GroupBox1.Controls.Add(Me.Cupcake_CodeTextBox)
        Me.GroupBox1.Controls.Add(DeliveryLabel)
        Me.GroupBox1.Controls.Add(Me.DeliveryCheckBox)
        Me.GroupBox1.Controls.Add(PickUpLabel)
        Me.GroupBox1.Controls.Add(Me.PickUpCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 295)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Details"
        '
        'Order_CodeTextBox
        '
        Me.Order_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "Order_Code", True))
        Me.Order_CodeTextBox.Location = New System.Drawing.Point(136, 44)
        Me.Order_CodeTextBox.Name = "Order_CodeTextBox"
        Me.Order_CodeTextBox.Size = New System.Drawing.Size(112, 20)
        Me.Order_CodeTextBox.TabIndex = 1
        '
        'ORDERBindingSource
        '
        Me.ORDERBindingSource.DataMember = "ORDER"
        Me.ORDERBindingSource.DataSource = Me.Sarahs_Short_CakeDataSet
        '
        'Sarahs_Short_CakeDataSet
        '
        Me.Sarahs_Short_CakeDataSet.DataSetName = "Sarahs_Short_CakeDataSet"
        Me.Sarahs_Short_CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderDateDateTimePicker
        '
        Me.OrderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ORDERBindingSource, "OrderDate", True))
        Me.OrderDateDateTimePicker.Location = New System.Drawing.Point(136, 70)
        Me.OrderDateDateTimePicker.Name = "OrderDateDateTimePicker"
        Me.OrderDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.OrderDateDateTimePicker.TabIndex = 3
        '
        'DateNeededDateTimePicker
        '
        Me.DateNeededDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ORDERBindingSource, "DateNeeded", True))
        Me.DateNeededDateTimePicker.Location = New System.Drawing.Point(136, 96)
        Me.DateNeededDateTimePicker.Name = "DateNeededDateTimePicker"
        Me.DateNeededDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateNeededDateTimePicker.TabIndex = 5
        '
        'TimeNeededDateTimePicker
        '
        Me.TimeNeededDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ORDERBindingSource, "TimeNeeded", True))
        Me.TimeNeededDateTimePicker.Location = New System.Drawing.Point(136, 122)
        Me.TimeNeededDateTimePicker.Name = "TimeNeededDateTimePicker"
        Me.TimeNeededDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TimeNeededDateTimePicker.TabIndex = 7
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(136, 148)
        Me.UsernameTextBox.MaxLength = 10
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(112, 20)
        Me.UsernameTextBox.TabIndex = 9
        '
        'Cupcake_CodeTextBox
        '
        Me.Cupcake_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORDERBindingSource, "Cupcake_Code", True))
        Me.Cupcake_CodeTextBox.Location = New System.Drawing.Point(136, 174)
        Me.Cupcake_CodeTextBox.Name = "Cupcake_CodeTextBox"
        Me.Cupcake_CodeTextBox.Size = New System.Drawing.Size(112, 20)
        Me.Cupcake_CodeTextBox.TabIndex = 11
        '
        'DeliveryCheckBox
        '
        Me.DeliveryCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ORDERBindingSource, "Delivery", True))
        Me.DeliveryCheckBox.Location = New System.Drawing.Point(164, 200)
        Me.DeliveryCheckBox.Name = "DeliveryCheckBox"
        Me.DeliveryCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.DeliveryCheckBox.TabIndex = 13
        Me.DeliveryCheckBox.Text = "Delivery"
        Me.DeliveryCheckBox.UseVisualStyleBackColor = True
        '
        'PickUpCheckBox
        '
        Me.PickUpCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ORDERBindingSource, "PickUp", True))
        Me.PickUpCheckBox.Location = New System.Drawing.Point(164, 227)
        Me.PickUpCheckBox.Name = "PickUpCheckBox"
        Me.PickUpCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.PickUpCheckBox.TabIndex = 15
        Me.PickUpCheckBox.Text = "Pick Up"
        Me.PickUpCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Cupcake_CodeLabel1)
        Me.GroupBox2.Controls.Add(Me.btnTotalPrice)
        Me.GroupBox2.Controls.Add(Me.Cupcake_CodeTextBox1)
        Me.GroupBox2.Controls.Add(Order_QuantityLabel)
        Me.GroupBox2.Controls.Add(Me.Order_QuantityTextBox)
        Me.GroupBox2.Controls.Add(FlavourLabel)
        Me.GroupBox2.Controls.Add(Me.FlavourComboBox)
        Me.GroupBox2.Controls.Add(ColourFlavourLabel)
        Me.GroupBox2.Controls.Add(Me.ColourFlavourComboBox)
        Me.GroupBox2.Controls.Add(IcingLabel)
        Me.GroupBox2.Controls.Add(Me.IcingComboBox)
        Me.GroupBox2.Controls.Add(ColourIcingLabel)
        Me.GroupBox2.Controls.Add(Me.ColourIcingComboBox)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Deco_CodeLabel)
        Me.GroupBox2.Controls.Add(Me.Deco_CodeComboBox)
        Me.GroupBox2.Controls.Add(PriceLabel)
        Me.GroupBox2.Controls.Add(Me.PriceTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 295)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cupcake Details"
        '
        'btnTotalPrice
        '
        Me.btnTotalPrice.Location = New System.Drawing.Point(117, 249)
        Me.btnTotalPrice.Name = "btnTotalPrice"
        Me.btnTotalPrice.Size = New System.Drawing.Size(75, 23)
        Me.btnTotalPrice.TabIndex = 32
        Me.btnTotalPrice.Text = "Total Price"
        Me.btnTotalPrice.UseVisualStyleBackColor = True
        '
        'Cupcake_CodeTextBox1
        '
        Me.Cupcake_CodeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUPCAKESBindingSource, "Cupcake_Code", True))
        Me.Cupcake_CodeTextBox1.Location = New System.Drawing.Point(117, 37)
        Me.Cupcake_CodeTextBox1.Name = "Cupcake_CodeTextBox1"
        Me.Cupcake_CodeTextBox1.Size = New System.Drawing.Size(101, 20)
        Me.Cupcake_CodeTextBox1.TabIndex = 20
        '
        'CUPCAKESBindingSource
        '
        Me.CUPCAKESBindingSource.DataMember = "CUPCAKES"
        Me.CUPCAKESBindingSource.DataSource = Me.Sarahs_Short_CakeDataSet
        '
        'Order_QuantityTextBox
        '
        Me.Order_QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUPCAKESBindingSource, "Order_Quantity", True))
        Me.Order_QuantityTextBox.Location = New System.Drawing.Point(117, 63)
        Me.Order_QuantityTextBox.Name = "Order_QuantityTextBox"
        Me.Order_QuantityTextBox.Size = New System.Drawing.Size(101, 20)
        Me.Order_QuantityTextBox.TabIndex = 22
        '
        'FlavourComboBox
        '
        Me.FlavourComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUPCAKESBindingSource, "Flavour", True))
        Me.FlavourComboBox.FormattingEnabled = True
        Me.FlavourComboBox.Location = New System.Drawing.Point(117, 89)
        Me.FlavourComboBox.Name = "FlavourComboBox"
        Me.FlavourComboBox.Size = New System.Drawing.Size(164, 21)
        Me.FlavourComboBox.TabIndex = 24
        '
        'ColourFlavourComboBox
        '
        Me.ColourFlavourComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUPCAKESBindingSource, "ColourFlavour", True))
        Me.ColourFlavourComboBox.FormattingEnabled = True
        Me.ColourFlavourComboBox.Location = New System.Drawing.Point(117, 116)
        Me.ColourFlavourComboBox.Name = "ColourFlavourComboBox"
        Me.ColourFlavourComboBox.Size = New System.Drawing.Size(164, 21)
        Me.ColourFlavourComboBox.TabIndex = 26
        '
        'IcingComboBox
        '
        Me.IcingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUPCAKESBindingSource, "Icing", True))
        Me.IcingComboBox.FormattingEnabled = True
        Me.IcingComboBox.Location = New System.Drawing.Point(117, 143)
        Me.IcingComboBox.Name = "IcingComboBox"
        Me.IcingComboBox.Size = New System.Drawing.Size(164, 21)
        Me.IcingComboBox.TabIndex = 28
        '
        'ColourIcingComboBox
        '
        Me.ColourIcingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUPCAKESBindingSource, "ColourIcing", True))
        Me.ColourIcingComboBox.FormattingEnabled = True
        Me.ColourIcingComboBox.Location = New System.Drawing.Point(117, 170)
        Me.ColourIcingComboBox.Name = "ColourIcingComboBox"
        Me.ColourIcingComboBox.Size = New System.Drawing.Size(164, 21)
        Me.ColourIcingComboBox.TabIndex = 30
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.IndianRed
        Me.LinkLabel1.Location = New System.Drawing.Point(287, 204)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(67, 13)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Deco Code?"
        '
        'Deco_CodeComboBox
        '
        Me.Deco_CodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUPCAKESBindingSource, "Deco_Code", True))
        Me.Deco_CodeComboBox.FormattingEnabled = True
        Me.Deco_CodeComboBox.Location = New System.Drawing.Point(117, 197)
        Me.Deco_CodeComboBox.Name = "Deco_CodeComboBox"
        Me.Deco_CodeComboBox.Size = New System.Drawing.Size(164, 21)
        Me.Deco_CodeComboBox.TabIndex = 32
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUPCAKESBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(117, 224)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(101, 20)
        Me.PriceTextBox.TabIndex = 34
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(824, 325)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(97, 23)
        Me.btnOrder.TabIndex = 25
        Me.btnOrder.Text = "NEW ORDER"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(824, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 23)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(824, 385)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 23)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(824, 440)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 23)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(949, 24)
        Me.MenuStrip1.TabIndex = 29
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
        'ORDERBindingNavigator
        '
        Me.ORDERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ORDERBindingNavigator.BindingSource = Me.ORDERBindingSource
        Me.ORDERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ORDERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ORDERBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ORDERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ORDERBindingNavigatorSaveItem})
        Me.ORDERBindingNavigator.Location = New System.Drawing.Point(0, 531)
        Me.ORDERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ORDERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ORDERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ORDERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ORDERBindingNavigator.Name = "ORDERBindingNavigator"
        Me.ORDERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ORDERBindingNavigator.Size = New System.Drawing.Size(949, 25)
        Me.ORDERBindingNavigator.TabIndex = 30
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
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(729, 492)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintReceipt.TabIndex = 33
        Me.btnPrintReceipt.Text = "RECEIPT"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 537)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 34
        Me.DataGridView1.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(335, 537)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 35
        Me.DataGridView2.Visible = False
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
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(241, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "+RM 5 for Delivery"
        '
        'formOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 556)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.ORDERBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formOrder"
        Me.Text = "Sarah's Short Cake - Customer Order"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ORDERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sarahs_Short_CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CUPCAKESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ORDERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ORDERBindingNavigator.ResumeLayout(False)
        Me.ORDERBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnTotalPrice As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents Order_CodeTextBox As TextBox
    Friend WithEvents OrderDateDateTimePicker As DateTimePicker
    Friend WithEvents DateNeededDateTimePicker As DateTimePicker
    Friend WithEvents TimeNeededDateTimePicker As DateTimePicker
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Cupcake_CodeTextBox As TextBox
    Friend WithEvents DeliveryCheckBox As CheckBox
    Friend WithEvents PickUpCheckBox As CheckBox
    Friend WithEvents Cupcake_CodeTextBox1 As TextBox
    Friend WithEvents Order_QuantityTextBox As TextBox
    Friend WithEvents FlavourComboBox As ComboBox
    Friend WithEvents ColourFlavourComboBox As ComboBox
    Friend WithEvents IcingComboBox As ComboBox
    Friend WithEvents ColourIcingComboBox As ComboBox
    Friend WithEvents Deco_CodeComboBox As ComboBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
End Class
