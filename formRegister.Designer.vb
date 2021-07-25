<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formRegister
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formRegister))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sarahs_Short_CakeDataSet = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSet()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CUSTOMERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CUSTOMERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CUSTOMERTableAdapter = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.TableAdapterManager = New SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.TableAdapterManager()
        UsernameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sarahs_Short_CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CUSTOMERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CUSTOMERBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(51, 46)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(71, 13)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "USERNAME:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(51, 49)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(75, 13)
        FirstNameLabel.TabIndex = 2
        FirstNameLabel.Text = "FIRST NAME:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(51, 78)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(71, 13)
        LastNameLabel.TabIndex = 4
        LastNameLabel.Text = "LAST NAME:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(51, 110)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(42, 13)
        EmailAddressLabel.TabIndex = 6
        EmailAddressLabel.Text = "EMAIL:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(51, 139)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(67, 13)
        PhoneNumberLabel.TabIndex = 8
        PhoneNumberLabel.Text = "PHONE NO:"
        '
        'StreetLabel
        '
        StreetLabel.AutoSize = True
        StreetLabel.Location = New System.Drawing.Point(51, 169)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(53, 13)
        StreetLabel.TabIndex = 10
        StreetLabel.Text = "STREET:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(51, 197)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(34, 13)
        CityLabel.TabIndex = 12
        CityLabel.Text = "CITY:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(51, 106)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(73, 13)
        PasswordLabel.TabIndex = 14
        PasswordLabel.Text = "PASSWORD:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(954, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENUToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(340, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(EmailAddressLabel)
        Me.GroupBox1.Controls.Add(Me.EmailAddressTextBox)
        Me.GroupBox1.Controls.Add(PhoneNumberLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(StreetLabel)
        Me.GroupBox1.Controls.Add(Me.StreetTextBox)
        Me.GroupBox1.Controls.Add(CityLabel)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 249)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PERSONAL INFORMATION"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(148, 46)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(137, 20)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.Sarahs_Short_CakeDataSet
        '
        'Sarahs_Short_CakeDataSet
        '
        Me.Sarahs_Short_CakeDataSet.DataSetName = "Sarahs_Short_CakeDataSet"
        Me.Sarahs_Short_CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(148, 75)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(137, 20)
        Me.LastNameTextBox.TabIndex = 5
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(148, 107)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(207, 20)
        Me.EmailAddressTextBox.TabIndex = 7
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(148, 136)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(137, 20)
        Me.PhoneNumberTextBox.TabIndex = 9
        '
        'StreetTextBox
        '
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Street", True))
        Me.StreetTextBox.Location = New System.Drawing.Point(148, 166)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(207, 20)
        Me.StreetTextBox.TabIndex = 11
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(148, 194)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(137, 20)
        Me.CityTextBox.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(UsernameLabel)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox2.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox2.Controls.Add(PasswordLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(500, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 150)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCOUNT INFORMATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "*Username can be alphanumeric with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "less or equal to 10 character"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.IndianRed
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.IndianRed
        Me.LinkLabel1.Location = New System.Drawing.Point(292, 49)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 16
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(148, 103)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(137, 20)
        Me.PasswordTextBox.TabIndex = 15
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(148, 43)
        Me.UsernameTextBox.MaxLength = 10
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(137, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(639, 397)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(153, 23)
        Me.btnRegister.TabIndex = 17
        Me.btnRegister.Text = "REGISTER NEW"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(717, 426)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(639, 426)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CUSTOMERBindingNavigator
        '
        Me.CUSTOMERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CUSTOMERBindingNavigator.BindingSource = Me.CUSTOMERBindingSource
        Me.CUSTOMERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CUSTOMERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CUSTOMERBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CUSTOMERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CUSTOMERBindingNavigatorSaveItem})
        Me.CUSTOMERBindingNavigator.Location = New System.Drawing.Point(0, 502)
        Me.CUSTOMERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CUSTOMERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CUSTOMERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CUSTOMERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CUSTOMERBindingNavigator.Name = "CUSTOMERBindingNavigator"
        Me.CUSTOMERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CUSTOMERBindingNavigator.Size = New System.Drawing.Size(954, 25)
        Me.CUSTOMERBindingNavigator.TabIndex = 20
        Me.CUSTOMERBindingNavigator.Text = "BindingNavigator1"
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
        'CUSTOMERBindingNavigatorSaveItem
        '
        Me.CUSTOMERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CUSTOMERBindingNavigatorSaveItem.Image = CType(resources.GetObject("CUSTOMERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CUSTOMERBindingNavigatorSaveItem.Name = "CUSTOMERBindingNavigatorSaveItem"
        Me.CUSTOMERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CUSTOMERBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUPCAKESTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Me.CUSTOMERTableAdapter
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.ORDTableAdapter = Nothing
        Me.TableAdapterManager.SPECIALTableAdapter = Nothing
        Me.TableAdapterManager.STAFFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SARAH_SHORT_CAKES___SALES_ORDER_SYSTEM.Sarahs_Short_CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'formRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 527)
        Me.Controls.Add(Me.CUSTOMERBindingNavigator)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formRegister"
        Me.Text = "Sarah's Short Cake - Customer Register"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sarahs_Short_CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CUSTOMERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CUSTOMERBindingNavigator.ResumeLayout(False)
        Me.CUSTOMERBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Sarahs_Short_CakeDataSet As Sarahs_Short_CakeDataSet
    Friend WithEvents CUSTOMERBindingSource As BindingSource
    Friend WithEvents CUSTOMERTableAdapter As Sarahs_Short_CakeDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents TableAdapterManager As Sarahs_Short_CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CUSTOMERBindingNavigator As BindingNavigator
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
    Friend WithEvents CUSTOMERBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
