<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim InvoiceLabel As System.Windows.Forms.Label
        Dim InvDateLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim InvAmtLabel As System.Windows.Forms.Label
        Dim BalDueLabel As System.Windows.Forms.Label
        Dim ServiceLabel As System.Windows.Forms.Label
        Dim AmtPaidLabel As System.Windows.Forms.Label
        Dim DatePaidLabel As System.Windows.Forms.Label
        Dim RefLabel As System.Windows.Forms.Label
        Dim ItemCodeLabel As System.Windows.Forms.Label
        Dim IdnumLabel As System.Windows.Forms.Label
        Dim IdnumLabel1 As System.Windows.Forms.Label
        Dim CustomerLabel1 As System.Windows.Forms.Label
        Dim LastPaymentDateLabel As System.Windows.Forms.Label
        Dim LastPaymentLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Me.TestDataSet = New Invoice.TestDataSet()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesTableAdapter = New Invoice.TestDataSetTableAdapters.InvoicesTableAdapter()
        Me.TableAdapterManager = New Invoice.TestDataSetTableAdapters.TableAdapterManager()
        Me.InvoicesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.InvoicesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.InvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.InvDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.InvAmtTextBox = New System.Windows.Forms.TextBox()
        Me.BalDueTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.AmtPaidTextBox = New System.Windows.Forms.TextBox()
        Me.DatePaidDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCodeTextBox = New System.Windows.Forms.TextBox()
        Me.IdnumTextBox = New System.Windows.Forms.TextBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Invoice.TestDataSetTableAdapters.CustomersTableAdapter()
        Me.IdnumTextBox1 = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox1 = New System.Windows.Forms.TextBox()
        Me.LastPaymentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LastPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        InvoiceLabel = New System.Windows.Forms.Label()
        InvDateLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        InvAmtLabel = New System.Windows.Forms.Label()
        BalDueLabel = New System.Windows.Forms.Label()
        ServiceLabel = New System.Windows.Forms.Label()
        AmtPaidLabel = New System.Windows.Forms.Label()
        DatePaidLabel = New System.Windows.Forms.Label()
        RefLabel = New System.Windows.Forms.Label()
        ItemCodeLabel = New System.Windows.Forms.Label()
        IdnumLabel = New System.Windows.Forms.Label()
        IdnumLabel1 = New System.Windows.Forms.Label()
        CustomerLabel1 = New System.Windows.Forms.Label()
        LastPaymentDateLabel = New System.Windows.Forms.Label()
        LastPaymentLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicesBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "TestDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.TestDataSet
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Invoice.TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvoicesBindingNavigator
        '
        Me.InvoicesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InvoicesBindingNavigator.BindingSource = Me.InvoicesBindingSource
        Me.InvoicesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InvoicesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InvoicesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InvoicesBindingNavigatorSaveItem})
        Me.InvoicesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InvoicesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InvoicesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InvoicesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InvoicesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InvoicesBindingNavigator.Name = "InvoicesBindingNavigator"
        Me.InvoicesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InvoicesBindingNavigator.Size = New System.Drawing.Size(1088, 25)
        Me.InvoicesBindingNavigator.TabIndex = 0
        Me.InvoicesBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'InvoicesBindingNavigatorSaveItem
        '
        Me.InvoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InvoicesBindingNavigatorSaveItem.Image = CType(resources.GetObject("InvoicesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InvoicesBindingNavigatorSaveItem.Name = "InvoicesBindingNavigatorSaveItem"
        Me.InvoicesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.InvoicesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripLabel, Me.CustomerToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1088, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'CustomerToolStripLabel
        '
        Me.CustomerToolStripLabel.Name = "CustomerToolStripLabel"
        Me.CustomerToolStripLabel.Size = New System.Drawing.Size(62, 22)
        Me.CustomerToolStripLabel.Text = "Customer:"
        '
        'CustomerToolStripTextBox
        '
        Me.CustomerToolStripTextBox.Name = "CustomerToolStripTextBox"
        Me.CustomerToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 19)
        Me.FillToolStripButton.Text = "Fill"
        '
        'InvoiceLabel
        '
        InvoiceLabel.AutoSize = True
        InvoiceLabel.Location = New System.Drawing.Point(115, 78)
        InvoiceLabel.Name = "InvoiceLabel"
        InvoiceLabel.Size = New System.Drawing.Size(45, 13)
        InvoiceLabel.TabIndex = 2
        InvoiceLabel.Text = "Invoice:"
        '
        'InvoiceTextBox
        '
        Me.InvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Invoice", True))
        Me.InvoiceTextBox.Location = New System.Drawing.Point(179, 75)
        Me.InvoiceTextBox.Name = "InvoiceTextBox"
        Me.InvoiceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.InvoiceTextBox.TabIndex = 3
        '
        'InvDateLabel
        '
        InvDateLabel.AutoSize = True
        InvDateLabel.Location = New System.Drawing.Point(115, 105)
        InvDateLabel.Name = "InvDateLabel"
        InvDateLabel.Size = New System.Drawing.Size(51, 13)
        InvDateLabel.TabIndex = 4
        InvDateLabel.Text = "Inv Date:"
        '
        'InvDateDateTimePicker
        '
        Me.InvDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoicesBindingSource, "InvDate", True))
        Me.InvDateDateTimePicker.Location = New System.Drawing.Point(179, 101)
        Me.InvDateDateTimePicker.Name = "InvDateDateTimePicker"
        Me.InvDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.InvDateDateTimePicker.TabIndex = 5
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(115, 130)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(54, 13)
        CustomerLabel.TabIndex = 6
        CustomerLabel.Text = "Customer:"
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(179, 127)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerTextBox.TabIndex = 7
        '
        'InvAmtLabel
        '
        InvAmtLabel.AutoSize = True
        InvAmtLabel.Location = New System.Drawing.Point(115, 156)
        InvAmtLabel.Name = "InvAmtLabel"
        InvAmtLabel.Size = New System.Drawing.Size(46, 13)
        InvAmtLabel.TabIndex = 8
        InvAmtLabel.Text = "Inv Amt:"
        '
        'InvAmtTextBox
        '
        Me.InvAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvAmt", True))
        Me.InvAmtTextBox.Location = New System.Drawing.Point(179, 153)
        Me.InvAmtTextBox.Name = "InvAmtTextBox"
        Me.InvAmtTextBox.Size = New System.Drawing.Size(200, 20)
        Me.InvAmtTextBox.TabIndex = 9
        '
        'BalDueLabel
        '
        BalDueLabel.AutoSize = True
        BalDueLabel.Location = New System.Drawing.Point(115, 182)
        BalDueLabel.Name = "BalDueLabel"
        BalDueLabel.Size = New System.Drawing.Size(48, 13)
        BalDueLabel.TabIndex = 10
        BalDueLabel.Text = "Bal Due:"
        '
        'BalDueTextBox
        '
        Me.BalDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "BalDue", True))
        Me.BalDueTextBox.Location = New System.Drawing.Point(179, 179)
        Me.BalDueTextBox.Name = "BalDueTextBox"
        Me.BalDueTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BalDueTextBox.TabIndex = 11
        '
        'ServiceLabel
        '
        ServiceLabel.AutoSize = True
        ServiceLabel.Location = New System.Drawing.Point(115, 208)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New System.Drawing.Size(46, 13)
        ServiceLabel.TabIndex = 12
        ServiceLabel.Text = "Service:"
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Service", True))
        Me.ServiceTextBox.Location = New System.Drawing.Point(179, 205)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ServiceTextBox.TabIndex = 13
        '
        'AmtPaidLabel
        '
        AmtPaidLabel.AutoSize = True
        AmtPaidLabel.Location = New System.Drawing.Point(115, 234)
        AmtPaidLabel.Name = "AmtPaidLabel"
        AmtPaidLabel.Size = New System.Drawing.Size(52, 13)
        AmtPaidLabel.TabIndex = 14
        AmtPaidLabel.Text = "Amt Paid:"
        '
        'AmtPaidTextBox
        '
        Me.AmtPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "AmtPaid", True))
        Me.AmtPaidTextBox.Location = New System.Drawing.Point(179, 231)
        Me.AmtPaidTextBox.Name = "AmtPaidTextBox"
        Me.AmtPaidTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmtPaidTextBox.TabIndex = 15
        '
        'DatePaidLabel
        '
        DatePaidLabel.AutoSize = True
        DatePaidLabel.Location = New System.Drawing.Point(115, 261)
        DatePaidLabel.Name = "DatePaidLabel"
        DatePaidLabel.Size = New System.Drawing.Size(57, 13)
        DatePaidLabel.TabIndex = 16
        DatePaidLabel.Text = "Date Paid:"
        '
        'DatePaidDateTimePicker
        '
        Me.DatePaidDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoicesBindingSource, "DatePaid", True))
        Me.DatePaidDateTimePicker.Location = New System.Drawing.Point(179, 257)
        Me.DatePaidDateTimePicker.Name = "DatePaidDateTimePicker"
        Me.DatePaidDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatePaidDateTimePicker.TabIndex = 17
        '
        'RefLabel
        '
        RefLabel.AutoSize = True
        RefLabel.Location = New System.Drawing.Point(115, 286)
        RefLabel.Name = "RefLabel"
        RefLabel.Size = New System.Drawing.Size(27, 13)
        RefLabel.TabIndex = 18
        RefLabel.Text = "Ref:"
        '
        'RefTextBox
        '
        Me.RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Ref", True))
        Me.RefTextBox.Location = New System.Drawing.Point(179, 283)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RefTextBox.TabIndex = 19
        '
        'ItemCodeLabel
        '
        ItemCodeLabel.AutoSize = True
        ItemCodeLabel.Location = New System.Drawing.Point(115, 312)
        ItemCodeLabel.Name = "ItemCodeLabel"
        ItemCodeLabel.Size = New System.Drawing.Size(58, 13)
        ItemCodeLabel.TabIndex = 20
        ItemCodeLabel.Text = "Item Code:"
        '
        'ItemCodeTextBox
        '
        Me.ItemCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "ItemCode", True))
        Me.ItemCodeTextBox.Location = New System.Drawing.Point(179, 309)
        Me.ItemCodeTextBox.Name = "ItemCodeTextBox"
        Me.ItemCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ItemCodeTextBox.TabIndex = 21
        '
        'IdnumLabel
        '
        IdnumLabel.AutoSize = True
        IdnumLabel.Location = New System.Drawing.Point(115, 338)
        IdnumLabel.Name = "IdnumLabel"
        IdnumLabel.Size = New System.Drawing.Size(38, 13)
        IdnumLabel.TabIndex = 22
        IdnumLabel.Text = "idnum:"
        '
        'IdnumTextBox
        '
        Me.IdnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "idnum", True))
        Me.IdnumTextBox.Location = New System.Drawing.Point(179, 335)
        Me.IdnumTextBox.Name = "IdnumTextBox"
        Me.IdnumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdnumTextBox.TabIndex = 23
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Invoices_Customers"
        Me.CustomersBindingSource.DataSource = Me.InvoicesBindingSource
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'IdnumLabel1
        '
        IdnumLabel1.AutoSize = True
        IdnumLabel1.Location = New System.Drawing.Point(589, 108)
        IdnumLabel1.Name = "IdnumLabel1"
        IdnumLabel1.Size = New System.Drawing.Size(38, 13)
        IdnumLabel1.TabIndex = 24
        IdnumLabel1.Text = "idnum:"
        '
        'IdnumTextBox1
        '
        Me.IdnumTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "idnum", True))
        Me.IdnumTextBox1.Location = New System.Drawing.Point(695, 105)
        Me.IdnumTextBox1.Name = "IdnumTextBox1"
        Me.IdnumTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.IdnumTextBox1.TabIndex = 25
        '
        'CustomerLabel1
        '
        CustomerLabel1.AutoSize = True
        CustomerLabel1.Location = New System.Drawing.Point(589, 134)
        CustomerLabel1.Name = "CustomerLabel1"
        CustomerLabel1.Size = New System.Drawing.Size(54, 13)
        CustomerLabel1.TabIndex = 26
        CustomerLabel1.Text = "Customer:"
        '
        'CustomerTextBox1
        '
        Me.CustomerTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Customer", True))
        Me.CustomerTextBox1.Location = New System.Drawing.Point(695, 131)
        Me.CustomerTextBox1.Name = "CustomerTextBox1"
        Me.CustomerTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.CustomerTextBox1.TabIndex = 27
        '
        'LastPaymentDateLabel
        '
        LastPaymentDateLabel.AutoSize = True
        LastPaymentDateLabel.Location = New System.Drawing.Point(589, 161)
        LastPaymentDateLabel.Name = "LastPaymentDateLabel"
        LastPaymentDateLabel.Size = New System.Drawing.Size(100, 13)
        LastPaymentDateLabel.TabIndex = 28
        LastPaymentDateLabel.Text = "Last Payment Date:"
        '
        'LastPaymentDateDateTimePicker
        '
        Me.LastPaymentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomersBindingSource, "LastPaymentDate", True))
        Me.LastPaymentDateDateTimePicker.Location = New System.Drawing.Point(695, 157)
        Me.LastPaymentDateDateTimePicker.Name = "LastPaymentDateDateTimePicker"
        Me.LastPaymentDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LastPaymentDateDateTimePicker.TabIndex = 29
        '
        'LastPaymentLabel
        '
        LastPaymentLabel.AutoSize = True
        LastPaymentLabel.Location = New System.Drawing.Point(589, 186)
        LastPaymentLabel.Name = "LastPaymentLabel"
        LastPaymentLabel.Size = New System.Drawing.Size(74, 13)
        LastPaymentLabel.TabIndex = 30
        LastPaymentLabel.Text = "Last Payment:"
        '
        'LastPaymentTextBox
        '
        Me.LastPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastPayment", True))
        Me.LastPaymentTextBox.Location = New System.Drawing.Point(695, 183)
        Me.LastPaymentTextBox.Name = "LastPaymentTextBox"
        Me.LastPaymentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastPaymentTextBox.TabIndex = 31
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(589, 212)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(49, 13)
        BalanceLabel.TabIndex = 32
        BalanceLabel.Text = "Balance:"
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(695, 209)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BalanceTextBox.TabIndex = 33
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(589, 238)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(37, 13)
        CreditLabel.TabIndex = 34
        CreditLabel.Text = "Credit:"
        '
        'CreditTextBox
        '
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Credit", True))
        Me.CreditTextBox.Location = New System.Drawing.Point(695, 235)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CreditTextBox.TabIndex = 35
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 406)
        Me.Controls.Add(IdnumLabel1)
        Me.Controls.Add(Me.IdnumTextBox1)
        Me.Controls.Add(CustomerLabel1)
        Me.Controls.Add(Me.CustomerTextBox1)
        Me.Controls.Add(LastPaymentDateLabel)
        Me.Controls.Add(Me.LastPaymentDateDateTimePicker)
        Me.Controls.Add(LastPaymentLabel)
        Me.Controls.Add(Me.LastPaymentTextBox)
        Me.Controls.Add(BalanceLabel)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(CreditLabel)
        Me.Controls.Add(Me.CreditTextBox)
        Me.Controls.Add(InvoiceLabel)
        Me.Controls.Add(Me.InvoiceTextBox)
        Me.Controls.Add(InvDateLabel)
        Me.Controls.Add(Me.InvDateDateTimePicker)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(InvAmtLabel)
        Me.Controls.Add(Me.InvAmtTextBox)
        Me.Controls.Add(BalDueLabel)
        Me.Controls.Add(Me.BalDueTextBox)
        Me.Controls.Add(ServiceLabel)
        Me.Controls.Add(Me.ServiceTextBox)
        Me.Controls.Add(AmtPaidLabel)
        Me.Controls.Add(Me.AmtPaidTextBox)
        Me.Controls.Add(DatePaidLabel)
        Me.Controls.Add(Me.DatePaidDateTimePicker)
        Me.Controls.Add(RefLabel)
        Me.Controls.Add(Me.RefTextBox)
        Me.Controls.Add(ItemCodeLabel)
        Me.Controls.Add(Me.ItemCodeTextBox)
        Me.Controls.Add(IdnumLabel)
        Me.Controls.Add(Me.IdnumTextBox)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.InvoicesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoicesBindingNavigator.ResumeLayout(False)
        Me.InvoicesBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestDataSet As Invoice.TestDataSet
    Friend WithEvents InvoicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicesTableAdapter As Invoice.TestDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents TableAdapterManager As Invoice.TestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvoicesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InvoicesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CustomerToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CustomerToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomersTableAdapter As Invoice.TestDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents InvoiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmtPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatePaidDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RefTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdnumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdnumTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LastPaymentDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LastPaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
End Class
