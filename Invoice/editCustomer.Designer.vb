<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editCustomer
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
        Dim Monthly_ChargeLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Dim Last_PaymentLabel As System.Windows.Forms.Label
        Dim Last_Payment_DateLabel As System.Windows.Forms.Label
        Dim Last_Invoice_DateLabel As System.Windows.Forms.Label
        Dim Start_DateLabel As System.Windows.Forms.Label
        Dim CleanupLabel As System.Windows.Forms.Label
        Dim ActiveLabel As System.Windows.Forms.Label
        Dim End_DateLabel As System.Windows.Forms.Label
        Dim SvcChgLabel As System.Windows.Forms.Label
        Dim TaxableLabel As System.Windows.Forms.Label
        Dim StreetNameLabel As System.Windows.Forms.Label
        Dim ItemCodeLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim lblCrossRef As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editCustomer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboPaymentType = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New Invoice.CustomerDataSet()
        Me.TxtDepAmt = New System.Windows.Forms.TextBox()
        Me.TxtDepDate = New System.Windows.Forms.TextBox()
        Me.TxtDepRef = New System.Windows.Forms.TextBox()
        Me.LastInvoiceDateTextBox = New System.Windows.Forms.TextBox()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.MonthlyChargeTextBox = New System.Windows.Forms.TextBox()
        Me.txtLastPayDate = New System.Windows.Forms.TextBox()
        Me.txtLastPayment = New System.Windows.Forms.TextBox()
        Me.TxtCRNum = New System.Windows.Forms.TextBox()
        Me.TxtCRName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboTerr = New System.Windows.Forms.ComboBox()
        Me.CboContainers = New System.Windows.Forms.ComboBox()
        Me.cboTaxable = New System.Windows.Forms.ComboBox()
        Me.cboSvcChg = New System.Windows.Forms.ComboBox()
        Me.cboActive = New System.Windows.Forms.ComboBox()
        Me.EndDateTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCodeTextBox = New System.Windows.Forms.TextBox()
        Me.StartDateTextBox = New System.Windows.Forms.TextBox()
        Me.cboRecyc = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboCleanup = New System.Windows.Forms.ComboBox()
        Me.GroupBoxCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.EveningTextBox = New System.Windows.Forms.TextBox()
        Me.CellPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Suite_AptTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTelephoneNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelCustomerAddress = New System.Windows.Forms.Label()
        Me.LabelCustomerNumber = New System.Windows.Forms.Label()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.GroupBoxAccountInformation = New System.Windows.Forms.GroupBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.StreetNameTextBox = New System.Windows.Forms.TextBox()
        Me.LabelNotes = New System.Windows.Forms.Label()
        Me.LabelPickupLocation = New System.Windows.Forms.Label()
        Me.CustomersTableAdapter = New Invoice.CustomerDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New Invoice.CustomerDataSetTableAdapters.TableAdapterManager()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonClose = New System.Windows.Forms.ToolStripButton()
        Me.CustomerToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Monthly_ChargeLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
        Last_PaymentLabel = New System.Windows.Forms.Label()
        Last_Payment_DateLabel = New System.Windows.Forms.Label()
        Last_Invoice_DateLabel = New System.Windows.Forms.Label()
        Start_DateLabel = New System.Windows.Forms.Label()
        CleanupLabel = New System.Windows.Forms.Label()
        ActiveLabel = New System.Windows.Forms.Label()
        End_DateLabel = New System.Windows.Forms.Label()
        SvcChgLabel = New System.Windows.Forms.Label()
        TaxableLabel = New System.Windows.Forms.Label()
        StreetNameLabel = New System.Windows.Forms.Label()
        ItemCodeLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        lblCrossRef = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxCustomerInfo.SuspendLayout()
        Me.GroupBoxAccountInformation.SuspendLayout()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Monthly_ChargeLabel
        '
        Monthly_ChargeLabel.AutoSize = True
        Monthly_ChargeLabel.Location = New System.Drawing.Point(35, 32)
        Monthly_ChargeLabel.Name = "Monthly_ChargeLabel"
        Monthly_ChargeLabel.Size = New System.Drawing.Size(84, 13)
        Monthly_ChargeLabel.TabIndex = 68
        Monthly_ChargeLabel.Text = "Monthly Charge:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(27, 49)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(92, 13)
        BalanceLabel.TabIndex = 60
        BalanceLabel.Text = "Account Balance:"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(39, 68)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(80, 13)
        CreditLabel.TabIndex = 61
        CreditLabel.Text = "Account Credit:"
        '
        'Last_PaymentLabel
        '
        Last_PaymentLabel.AutoSize = True
        Last_PaymentLabel.Location = New System.Drawing.Point(216, 49)
        Last_PaymentLabel.Name = "Last_PaymentLabel"
        Last_PaymentLabel.Size = New System.Drawing.Size(74, 13)
        Last_PaymentLabel.TabIndex = 62
        Last_PaymentLabel.Text = "Last Payment:"
        '
        'Last_Payment_DateLabel
        '
        Last_Payment_DateLabel.AutoSize = True
        Last_Payment_DateLabel.Location = New System.Drawing.Point(216, 68)
        Last_Payment_DateLabel.Name = "Last_Payment_DateLabel"
        Last_Payment_DateLabel.Size = New System.Drawing.Size(77, 13)
        Last_Payment_DateLabel.TabIndex = 63
        Last_Payment_DateLabel.Text = "Payment Date:"
        '
        'Last_Invoice_DateLabel
        '
        Last_Invoice_DateLabel.AutoSize = True
        Last_Invoice_DateLabel.Location = New System.Drawing.Point(50, 86)
        Last_Invoice_DateLabel.Name = "Last_Invoice_DateLabel"
        Last_Invoice_DateLabel.Size = New System.Drawing.Size(65, 13)
        Last_Invoice_DateLabel.TabIndex = 64
        Last_Invoice_DateLabel.Text = "Last Invoice"
        '
        'Start_DateLabel
        '
        Start_DateLabel.AutoSize = True
        Start_DateLabel.Location = New System.Drawing.Point(19, 29)
        Start_DateLabel.Name = "Start_DateLabel"
        Start_DateLabel.Size = New System.Drawing.Size(58, 13)
        Start_DateLabel.TabIndex = 57
        Start_DateLabel.Text = "Start Date:"
        '
        'CleanupLabel
        '
        CleanupLabel.AutoSize = True
        CleanupLabel.Location = New System.Drawing.Point(190, 28)
        CleanupLabel.Name = "CleanupLabel"
        CleanupLabel.Size = New System.Drawing.Size(74, 13)
        CleanupLabel.TabIndex = 69
        CleanupLabel.Text = "Auto Cleanup:"
        '
        'ActiveLabel
        '
        ActiveLabel.AutoSize = True
        ActiveLabel.Location = New System.Drawing.Point(224, 68)
        ActiveLabel.Name = "ActiveLabel"
        ActiveLabel.Size = New System.Drawing.Size(40, 13)
        ActiveLabel.TabIndex = 65
        ActiveLabel.Text = "Active:"
        '
        'End_DateLabel
        '
        End_DateLabel.AutoSize = True
        End_DateLabel.Location = New System.Drawing.Point(19, 49)
        End_DateLabel.Name = "End_DateLabel"
        End_DateLabel.Size = New System.Drawing.Size(55, 13)
        End_DateLabel.TabIndex = 58
        End_DateLabel.Text = "End Date:"
        '
        'SvcChgLabel
        '
        SvcChgLabel.AutoSize = True
        SvcChgLabel.Location = New System.Drawing.Point(19, 69)
        SvcChgLabel.Name = "SvcChgLabel"
        SvcChgLabel.Size = New System.Drawing.Size(57, 13)
        SvcChgLabel.TabIndex = 67
        SvcChgLabel.Text = "Recycling:"
        '
        'TaxableLabel
        '
        TaxableLabel.AutoSize = True
        TaxableLabel.Location = New System.Drawing.Point(216, 49)
        TaxableLabel.Name = "TaxableLabel"
        TaxableLabel.Size = New System.Drawing.Size(48, 13)
        TaxableLabel.TabIndex = 66
        TaxableLabel.Text = "Taxable:"
        '
        'StreetNameLabel
        '
        StreetNameLabel.AutoSize = True
        StreetNameLabel.Location = New System.Drawing.Point(296, 41)
        StreetNameLabel.Name = "StreetNameLabel"
        StreetNameLabel.Size = New System.Drawing.Size(77, 13)
        StreetNameLabel.TabIndex = 70
        StreetNameLabel.Text = "Street Locator:"
        '
        'ItemCodeLabel
        '
        ItemCodeLabel.AutoSize = True
        ItemCodeLabel.Location = New System.Drawing.Point(19, 89)
        ItemCodeLabel.Name = "ItemCodeLabel"
        ItemCodeLabel.Size = New System.Drawing.Size(58, 13)
        ItemCodeLabel.TabIndex = 86
        ItemCodeLabel.Text = "Item Code:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(213, 85)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(51, 13)
        Label6.TabIndex = 88
        Label6.Text = "Svc Chg:"
        '
        'lblCrossRef
        '
        lblCrossRef.AutoSize = True
        lblCrossRef.Location = New System.Drawing.Point(23, 129)
        lblCrossRef.Name = "lblCrossRef"
        lblCrossRef.Size = New System.Drawing.Size(53, 13)
        lblCrossRef.TabIndex = 87
        lblCrossRef.Text = "Cross Ref"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(19, 109)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(60, 13)
        Label7.TabIndex = 90
        Label7.Text = "Containers:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(232, 107)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(32, 13)
        Label8.TabIndex = 92
        Label8.Text = "SOT:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(73, 125)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(46, 13)
        Label9.TabIndex = 90
        Label9.Text = "Deposit:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(216, 29)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(78, 13)
        Label10.TabIndex = 95
        Label10.Text = "Payment Type:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.CboPaymentType)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Me.TxtDepAmt)
        Me.GroupBox1.Controls.Add(Me.TxtDepDate)
        Me.GroupBox1.Controls.Add(Me.TxtDepRef)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Me.LastInvoiceDateTextBox)
        Me.GroupBox1.Controls.Add(Me.CreditTextBox)
        Me.GroupBox1.Controls.Add(Me.BalanceTextBox)
        Me.GroupBox1.Controls.Add(Me.MonthlyChargeTextBox)
        Me.GroupBox1.Controls.Add(Monthly_ChargeLabel)
        Me.GroupBox1.Controls.Add(Me.txtLastPayDate)
        Me.GroupBox1.Controls.Add(BalanceLabel)
        Me.GroupBox1.Controls.Add(CreditLabel)
        Me.GroupBox1.Controls.Add(Me.txtLastPayment)
        Me.GroupBox1.Controls.Add(Last_PaymentLabel)
        Me.GroupBox1.Controls.Add(Last_Payment_DateLabel)
        Me.GroupBox1.Controls.Add(Last_Invoice_DateLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 167)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Information"
        '
        'CboPaymentType
        '
        Me.CboPaymentType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastPaymentType", True))
        Me.CboPaymentType.FormattingEnabled = True
        Me.CboPaymentType.Items.AddRange(New Object() {"Cash", "Cashiers Chk", "Check", "Monet Order"})
        Me.CboPaymentType.Location = New System.Drawing.Point(296, 24)
        Me.CboPaymentType.Name = "CboPaymentType"
        Me.CboPaymentType.Size = New System.Drawing.Size(79, 21)
        Me.CboPaymentType.TabIndex = 82
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtDepAmt
        '
        Me.TxtDepAmt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Deposit", True))
        Me.TxtDepAmt.Location = New System.Drawing.Point(216, 122)
        Me.TxtDepAmt.Name = "TxtDepAmt"
        Me.TxtDepAmt.Size = New System.Drawing.Size(74, 20)
        Me.TxtDepAmt.TabIndex = 94
        Me.TxtDepAmt.Text = "Amount"
        '
        'TxtDepDate
        '
        Me.TxtDepDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "DepDate", True))
        Me.TxtDepDate.Location = New System.Drawing.Point(135, 122)
        Me.TxtDepDate.Name = "TxtDepDate"
        Me.TxtDepDate.Size = New System.Drawing.Size(75, 20)
        Me.TxtDepDate.TabIndex = 93
        Me.TxtDepDate.Text = "Date"
        '
        'TxtDepRef
        '
        Me.TxtDepRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "DepRef", True))
        Me.TxtDepRef.Location = New System.Drawing.Point(296, 122)
        Me.TxtDepRef.Name = "TxtDepRef"
        Me.TxtDepRef.Size = New System.Drawing.Size(79, 20)
        Me.TxtDepRef.TabIndex = 92
        Me.TxtDepRef.Text = "Ref No"
        '
        'LastInvoiceDateTextBox
        '
        Me.LastInvoiceDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastInvoiceDate", True))
        Me.LastInvoiceDateTextBox.Location = New System.Drawing.Point(135, 83)
        Me.LastInvoiceDateTextBox.Name = "LastInvoiceDateTextBox"
        Me.LastInvoiceDateTextBox.Size = New System.Drawing.Size(75, 20)
        Me.LastInvoiceDateTextBox.TabIndex = 86
        '
        'CreditTextBox
        '
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Credit", True))
        Me.CreditTextBox.Location = New System.Drawing.Point(135, 65)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(75, 20)
        Me.CreditTextBox.TabIndex = 84
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(135, 46)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(75, 20)
        Me.BalanceTextBox.TabIndex = 83
        Me.BalanceTextBox.Text = "0.00"
        '
        'MonthlyChargeTextBox
        '
        Me.MonthlyChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "MonthlyCharge", True))
        Me.MonthlyChargeTextBox.Location = New System.Drawing.Point(135, 26)
        Me.MonthlyChargeTextBox.Name = "MonthlyChargeTextBox"
        Me.MonthlyChargeTextBox.Size = New System.Drawing.Size(75, 20)
        Me.MonthlyChargeTextBox.TabIndex = 82
        '
        'txtLastPayDate
        '
        Me.txtLastPayDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastPaymentDate", True))
        Me.txtLastPayDate.Location = New System.Drawing.Point(296, 65)
        Me.txtLastPayDate.Name = "txtLastPayDate"
        Me.txtLastPayDate.Size = New System.Drawing.Size(79, 20)
        Me.txtLastPayDate.TabIndex = 64
        '
        'txtLastPayment
        '
        Me.txtLastPayment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastPayment", True))
        Me.txtLastPayment.Location = New System.Drawing.Point(296, 45)
        Me.txtLastPayment.Name = "txtLastPayment"
        Me.txtLastPayment.Size = New System.Drawing.Size(79, 20)
        Me.txtLastPayment.TabIndex = 63
        '
        'TxtCRNum
        '
        Me.TxtCRNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CRNum", True))
        Me.TxtCRNum.Location = New System.Drawing.Point(83, 126)
        Me.TxtCRNum.Name = "TxtCRNum"
        Me.TxtCRNum.Size = New System.Drawing.Size(69, 20)
        Me.TxtCRNum.TabIndex = 89
        Me.TxtCRNum.Text = "Cust No"
        '
        'TxtCRName
        '
        Me.TxtCRName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CRName", True))
        Me.TxtCRName.Location = New System.Drawing.Point(158, 126)
        Me.TxtCRName.Name = "TxtCRName"
        Me.TxtCRName.Size = New System.Drawing.Size(239, 20)
        Me.TxtCRName.TabIndex = 88
        Me.TxtCRName.Text = "Company"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.TxtCRNum)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Me.CboTerr)
        Me.GroupBox2.Controls.Add(Me.CboContainers)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(lblCrossRef)
        Me.GroupBox2.Controls.Add(Me.TxtCRName)
        Me.GroupBox2.Controls.Add(Me.cboTaxable)
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(Me.cboSvcChg)
        Me.GroupBox2.Controls.Add(Me.cboActive)
        Me.GroupBox2.Controls.Add(Me.EndDateTextBox)
        Me.GroupBox2.Controls.Add(ItemCodeLabel)
        Me.GroupBox2.Controls.Add(Me.ItemCodeTextBox)
        Me.GroupBox2.Controls.Add(Me.StartDateTextBox)
        Me.GroupBox2.Controls.Add(Me.cboRecyc)
        Me.GroupBox2.Controls.Add(SvcChgLabel)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Start_DateLabel)
        Me.GroupBox2.Controls.Add(Me.cboCleanup)
        Me.GroupBox2.Controls.Add(CleanupLabel)
        Me.GroupBox2.Controls.Add(ActiveLabel)
        Me.GroupBox2.Controls.Add(End_DateLabel)
        Me.GroupBox2.Controls.Add(TaxableLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(419, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 167)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Information"
        '
        'CboTerr
        '
        Me.CboTerr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Terr", True))
        Me.CboTerr.FormattingEnabled = True
        Me.CboTerr.Items.AddRange(New Object() {"NE", "SE", "NW", "SW"})
        Me.CboTerr.Location = New System.Drawing.Point(270, 105)
        Me.CboTerr.Name = "CboTerr"
        Me.CboTerr.Size = New System.Drawing.Size(58, 21)
        Me.CboTerr.TabIndex = 93
        '
        'CboContainers
        '
        Me.CboContainers.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Containers", True))
        Me.CboContainers.FormattingEnabled = True
        Me.CboContainers.Items.AddRange(New Object() {"Can(s)", "Dumpster(s)", "Can(s) & Dumpster(s)"})
        Me.CboContainers.Location = New System.Drawing.Point(83, 105)
        Me.CboContainers.Name = "CboContainers"
        Me.CboContainers.Size = New System.Drawing.Size(130, 21)
        Me.CboContainers.TabIndex = 91
        '
        'cboTaxable
        '
        Me.cboTaxable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Taxable", True))
        Me.cboTaxable.FormattingEnabled = True
        Me.cboTaxable.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboTaxable.Location = New System.Drawing.Point(270, 44)
        Me.cboTaxable.Name = "cboTaxable"
        Me.cboTaxable.Size = New System.Drawing.Size(58, 21)
        Me.cboTaxable.TabIndex = 67
        '
        'cboSvcChg
        '
        Me.cboSvcChg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "SvcChg", True))
        Me.cboSvcChg.FormattingEnabled = True
        Me.cboSvcChg.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboSvcChg.Location = New System.Drawing.Point(270, 84)
        Me.cboSvcChg.Name = "cboSvcChg"
        Me.cboSvcChg.Size = New System.Drawing.Size(58, 21)
        Me.cboSvcChg.TabIndex = 89
        '
        'cboActive
        '
        Me.cboActive.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Active", True))
        Me.cboActive.FormattingEnabled = True
        Me.cboActive.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboActive.Location = New System.Drawing.Point(270, 65)
        Me.cboActive.Name = "cboActive"
        Me.cboActive.Size = New System.Drawing.Size(58, 21)
        Me.cboActive.TabIndex = 66
        '
        'EndDateTextBox
        '
        Me.EndDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "EndDate", True))
        Me.EndDateTextBox.Location = New System.Drawing.Point(83, 46)
        Me.EndDateTextBox.Name = "EndDateTextBox"
        Me.EndDateTextBox.Size = New System.Drawing.Size(88, 20)
        Me.EndDateTextBox.TabIndex = 76
        '
        'ItemCodeTextBox
        '
        Me.ItemCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ItemCode", True))
        Me.ItemCodeTextBox.Location = New System.Drawing.Point(83, 85)
        Me.ItemCodeTextBox.Name = "ItemCodeTextBox"
        Me.ItemCodeTextBox.Size = New System.Drawing.Size(88, 20)
        Me.ItemCodeTextBox.TabIndex = 87
        '
        'StartDateTextBox
        '
        Me.StartDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StartDate", True))
        Me.StartDateTextBox.Location = New System.Drawing.Point(83, 26)
        Me.StartDateTextBox.Name = "StartDateTextBox"
        Me.StartDateTextBox.Size = New System.Drawing.Size(88, 20)
        Me.StartDateTextBox.TabIndex = 75
        '
        'cboRecyc
        '
        Me.cboRecyc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Recycling", True))
        Me.cboRecyc.FormattingEnabled = True
        Me.cboRecyc.Items.AddRange(New Object() {"Recycle A", "Recycle B"})
        Me.cboRecyc.Location = New System.Drawing.Point(83, 66)
        Me.cboRecyc.Name = "cboRecyc"
        Me.cboRecyc.Size = New System.Drawing.Size(88, 21)
        Me.cboRecyc.TabIndex = 68
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(339, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 23)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboCleanup
        '
        Me.cboCleanup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Cleanup", True))
        Me.cboCleanup.FormattingEnabled = True
        Me.cboCleanup.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboCleanup.Location = New System.Drawing.Point(270, 24)
        Me.cboCleanup.Name = "cboCleanup"
        Me.cboCleanup.Size = New System.Drawing.Size(58, 21)
        Me.cboCleanup.TabIndex = 70
        '
        'GroupBoxCustomerInfo
        '
        Me.GroupBoxCustomerInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxCustomerInfo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBoxCustomerInfo.Controls.Add(Me.EveningTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.CellPhoneTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.BusinessTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.ZipTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.StateTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.CityTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Suite_AptTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.AddressTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.ContactTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.CompanyTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.CustomerTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label5)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label4)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.LabelTelephoneNumber)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label3)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label1)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label2)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.LabelCustomerAddress)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.LabelCustomerNumber)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.LabelCustomerName)
        Me.GroupBoxCustomerInfo.Location = New System.Drawing.Point(25, 62)
        Me.GroupBoxCustomerInfo.Name = "GroupBoxCustomerInfo"
        Me.GroupBoxCustomerInfo.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBoxCustomerInfo.Size = New System.Drawing.Size(398, 238)
        Me.GroupBoxCustomerInfo.TabIndex = 74
        Me.GroupBoxCustomerInfo.TabStop = False
        Me.GroupBoxCustomerInfo.Text = "Customer Information"
        '
        'EveningTextBox
        '
        Me.EveningTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Evening", True))
        Me.EveningTextBox.Location = New System.Drawing.Point(135, 189)
        Me.EveningTextBox.Name = "EveningTextBox"
        Me.EveningTextBox.Size = New System.Drawing.Size(240, 20)
        Me.EveningTextBox.TabIndex = 92
        '
        'CellPhoneTextBox
        '
        Me.CellPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CellPhone", True))
        Me.CellPhoneTextBox.Location = New System.Drawing.Point(135, 170)
        Me.CellPhoneTextBox.MaxLength = 20
        Me.CellPhoneTextBox.Name = "CellPhoneTextBox"
        Me.CellPhoneTextBox.Size = New System.Drawing.Size(240, 20)
        Me.CellPhoneTextBox.TabIndex = 93
        '
        'BusinessTextBox
        '
        Me.BusinessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Business", True))
        Me.BusinessTextBox.Location = New System.Drawing.Point(135, 153)
        Me.BusinessTextBox.Name = "BusinessTextBox"
        Me.BusinessTextBox.Size = New System.Drawing.Size(240, 20)
        Me.BusinessTextBox.TabIndex = 90
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(332, 135)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(43, 20)
        Me.ZipTextBox.TabIndex = 89
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(296, 135)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(30, 20)
        Me.StateTextBox.TabIndex = 88
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(135, 135)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(155, 20)
        Me.CityTextBox.TabIndex = 87
        '
        'Suite_AptTextBox
        '
        Me.Suite_AptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Suite/Apt", True))
        Me.Suite_AptTextBox.Location = New System.Drawing.Point(135, 115)
        Me.Suite_AptTextBox.Name = "Suite_AptTextBox"
        Me.Suite_AptTextBox.Size = New System.Drawing.Size(240, 20)
        Me.Suite_AptTextBox.TabIndex = 86
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(135, 96)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(240, 20)
        Me.AddressTextBox.TabIndex = 85
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(135, 76)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ContactTextBox.TabIndex = 84
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(135, 58)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(240, 20)
        Me.CompanyTextBox.TabIndex = 83
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(135, 38)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerTextBox.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Evening Phone"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cell Phone "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTelephoneNumber
        '
        Me.LabelTelephoneNumber.AutoSize = True
        Me.LabelTelephoneNumber.Location = New System.Drawing.Point(35, 160)
        Me.LabelTelephoneNumber.Name = "LabelTelephoneNumber"
        Me.LabelTelephoneNumber.Size = New System.Drawing.Size(69, 13)
        Me.LabelTelephoneNumber.TabIndex = 16
        Me.LabelTelephoneNumber.Text = "Office Phone"
        Me.LabelTelephoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "City, State, Zip"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Suite/Apt #"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCustomerAddress
        '
        Me.LabelCustomerAddress.AutoSize = True
        Me.LabelCustomerAddress.Location = New System.Drawing.Point(36, 83)
        Me.LabelCustomerAddress.Name = "LabelCustomerAddress"
        Me.LabelCustomerAddress.Size = New System.Drawing.Size(44, 13)
        Me.LabelCustomerAddress.TabIndex = 4
        Me.LabelCustomerAddress.Text = "Contact"
        Me.LabelCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCustomerNumber
        '
        Me.LabelCustomerNumber.AutoSize = True
        Me.LabelCustomerNumber.Location = New System.Drawing.Point(35, 45)
        Me.LabelCustomerNumber.Name = "LabelCustomerNumber"
        Me.LabelCustomerNumber.Size = New System.Drawing.Size(91, 13)
        Me.LabelCustomerNumber.TabIndex = 3
        Me.LabelCustomerNumber.Text = "Customer Number"
        Me.LabelCustomerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Location = New System.Drawing.Point(35, 65)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(51, 13)
        Me.LabelCustomerName.TabIndex = 0
        Me.LabelCustomerName.Text = "Company"
        Me.LabelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBoxAccountInformation
        '
        Me.GroupBoxAccountInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxAccountInformation.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBoxAccountInformation.Controls.Add(Me.NotesTextBox)
        Me.GroupBoxAccountInformation.Controls.Add(Me.ServiceTextBox)
        Me.GroupBoxAccountInformation.Controls.Add(Me.StreetNameTextBox)
        Me.GroupBoxAccountInformation.Controls.Add(StreetNameLabel)
        Me.GroupBoxAccountInformation.Controls.Add(Me.LabelNotes)
        Me.GroupBoxAccountInformation.Controls.Add(Me.LabelPickupLocation)
        Me.GroupBoxAccountInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAccountInformation.Location = New System.Drawing.Point(419, 62)
        Me.GroupBoxAccountInformation.Name = "GroupBoxAccountInformation"
        Me.GroupBoxAccountInformation.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBoxAccountInformation.Size = New System.Drawing.Size(406, 262)
        Me.GroupBoxAccountInformation.TabIndex = 75
        Me.GroupBoxAccountInformation.TabStop = False
        Me.GroupBoxAccountInformation.Text = "Pickup Location"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(20, 130)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(365, 82)
        Me.NotesTextBox.TabIndex = 79
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Service", True))
        Me.ServiceTextBox.Location = New System.Drawing.Point(20, 59)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(245, 20)
        Me.ServiceTextBox.TabIndex = 78
        '
        'StreetNameTextBox
        '
        Me.StreetNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StreetName", True))
        Me.StreetNameTextBox.Location = New System.Drawing.Point(285, 59)
        Me.StreetNameTextBox.Name = "StreetNameTextBox"
        Me.StreetNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StreetNameTextBox.TabIndex = 77
        '
        'LabelNotes
        '
        Me.LabelNotes.AutoSize = True
        Me.LabelNotes.Location = New System.Drawing.Point(183, 114)
        Me.LabelNotes.Name = "LabelNotes"
        Me.LabelNotes.Size = New System.Drawing.Size(35, 13)
        Me.LabelNotes.TabIndex = 32
        Me.LabelNotes.Text = "Notes"
        '
        'LabelPickupLocation
        '
        Me.LabelPickupLocation.AutoSize = True
        Me.LabelPickupLocation.Location = New System.Drawing.Point(107, 41)
        Me.LabelPickupLocation.Name = "LabelPickupLocation"
        Me.LabelPickupLocation.Size = New System.Drawing.Size(84, 13)
        Me.LabelPickupLocation.TabIndex = 30
        Me.LabelPickupLocation.Text = "Pickup Location"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Invoice.CustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Nothing
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem, Me.ToolStripButtonClose})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(864, 25)
        Me.CustomersBindingNavigator.TabIndex = 80
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(44, 22)
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
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(38, 22)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save "
        '
        'ToolStripButtonClose
        '
        Me.ToolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonClose.Image = CType(resources.GetObject("ToolStripButtonClose.Image"), System.Drawing.Image)
        Me.ToolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonClose.Name = "ToolStripButtonClose"
        Me.ToolStripButtonClose.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripButtonClose.Text = "Close"
        '
        'CustomerToolStripLabel
        '
        Me.CustomerToolStripLabel.Name = "CustomerToolStripLabel"
        Me.CustomerToolStripLabel.Size = New System.Drawing.Size(85, 22)
        Me.CustomerToolStripLabel.Text = "Edit Customer:"
        '
        'CustomerToolStripTextBox
        '
        Me.CustomerToolStripTextBox.AcceptsReturn = True
        Me.CustomerToolStripTextBox.AcceptsTab = True
        Me.CustomerToolStripTextBox.Name = "CustomerToolStripTextBox"
        Me.CustomerToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(34, 22)
        Me.FillToolStripButton.Text = "Find"
        Me.FillToolStripButton.ToolTipText = "Find"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripLabel, Me.CustomerToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(864, 25)
        Me.FillToolStrip.TabIndex = 81
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(750, 468)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 79
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(659, 468)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 78
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'editCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(864, 523)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxCustomerInfo)
        Me.Controls.Add(Me.GroupBoxAccountInformation)
        Me.Name = "editCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxCustomerInfo.ResumeLayout(False)
        Me.GroupBoxCustomerInfo.PerformLayout()
        Me.GroupBoxAccountInformation.ResumeLayout(False)
        Me.GroupBoxAccountInformation.PerformLayout()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastPayDate As System.Windows.Forms.TextBox
    Friend WithEvents txtLastPayment As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCleanup As System.Windows.Forms.ComboBox
    Friend WithEvents cboActive As System.Windows.Forms.ComboBox
    Friend WithEvents cboTaxable As System.Windows.Forms.ComboBox
    Friend WithEvents cboRecyc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelTelephoneNumber As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerAddress As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerNumber As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAccountInformation As System.Windows.Forms.GroupBox
    Friend WithEvents LabelNotes As System.Windows.Forms.Label
    Friend WithEvents LabelPickupLocation As System.Windows.Forms.Label
    Friend WithEvents CustomerDataSet As Invoice.CustomerDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Invoice.CustomerDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As Invoice.CustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EveningTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BusinessTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Suite_AptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CustomerToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonthlyChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StreetNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastInvoiceDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CellPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cboSvcChg As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCRNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtCRName As System.Windows.Forms.TextBox
    Friend WithEvents CboContainers As System.Windows.Forms.ComboBox
    Friend WithEvents CboTerr As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDepAmt As System.Windows.Forms.TextBox
    Friend WithEvents TxtDepDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtDepRef As System.Windows.Forms.TextBox
    Friend WithEvents CboPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButtonClose As System.Windows.Forms.ToolStripButton
End Class
