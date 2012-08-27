<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim DumpsterLabel As System.Windows.Forms.Label
        Dim Start_DateLabel As System.Windows.Forms.Label
        Dim CleanupLabel As System.Windows.Forms.Label
        Dim ActiveLabel As System.Windows.Forms.Label
        Dim End_DateLabel As System.Windows.Forms.Label
        Dim SvcChgLabel As System.Windows.Forms.Label
        Dim TaxableLabel As System.Windows.Forms.Label
        Dim StreetNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.GroupBoxCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New Invoice.CustomerDataSet()
        Me.txtEvening = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCell = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBusiness = New System.Windows.Forms.TextBox()
        Me.LabelTelephoneNumber = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtSuite = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelCustomerAddress = New System.Windows.Forms.Label()
        Me.LabelCustomerNumber = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMonthlyCharge = New System.Windows.Forms.TextBox()
        Me.txtLastPayDate = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.txtLastPayment = New System.Windows.Forms.TextBox()
        Me.txtLastInvoiceDate = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DumpsterComboBox = New System.Windows.Forms.ComboBox()
        Me.TruckComboBox = New System.Windows.Forms.ComboBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.cboCleanup = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboActive = New System.Windows.Forms.ComboBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.cboTaxable = New System.Windows.Forms.ComboBox()
        Me.cboSvcChg = New System.Windows.Forms.ComboBox()
        Me.LabelPickupLocation = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.LabelNotes = New System.Windows.Forms.Label()
        Me.txtPickup = New System.Windows.Forms.TextBox()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.GroupBoxAccountInformation = New System.Windows.Forms.GroupBox()
        Me.CustomersTableAdapter = New Invoice.CustomerDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New Invoice.CustomerDataSetTableAdapters.TableAdapterManager()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Monthly_ChargeLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
        Last_PaymentLabel = New System.Windows.Forms.Label()
        Last_Payment_DateLabel = New System.Windows.Forms.Label()
        Last_Invoice_DateLabel = New System.Windows.Forms.Label()
        DumpsterLabel = New System.Windows.Forms.Label()
        Start_DateLabel = New System.Windows.Forms.Label()
        CleanupLabel = New System.Windows.Forms.Label()
        ActiveLabel = New System.Windows.Forms.Label()
        End_DateLabel = New System.Windows.Forms.Label()
        SvcChgLabel = New System.Windows.Forms.Label()
        TaxableLabel = New System.Windows.Forms.Label()
        StreetNameLabel = New System.Windows.Forms.Label()
        Me.GroupBoxCustomerInfo.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxAccountInformation.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Monthly_ChargeLabel
        '
        Monthly_ChargeLabel.AutoSize = True
        Monthly_ChargeLabel.Location = New System.Drawing.Point(35, 35)
        Monthly_ChargeLabel.Name = "Monthly_ChargeLabel"
        Monthly_ChargeLabel.Size = New System.Drawing.Size(84, 13)
        Monthly_ChargeLabel.TabIndex = 68
        Monthly_ChargeLabel.Text = "Monthly Charge:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(36, 52)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(87, 13)
        BalanceLabel.TabIndex = 60
        BalanceLabel.Text = "Invoice Balance:"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(35, 71)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(80, 13)
        CreditLabel.TabIndex = 61
        CreditLabel.Text = "Account Credit:"
        '
        'Last_PaymentLabel
        '
        Last_PaymentLabel.AutoSize = True
        Last_PaymentLabel.Location = New System.Drawing.Point(216, 52)
        Last_PaymentLabel.Name = "Last_PaymentLabel"
        Last_PaymentLabel.Size = New System.Drawing.Size(74, 13)
        Last_PaymentLabel.TabIndex = 62
        Last_PaymentLabel.Text = "Last Payment:"
        '
        'Last_Payment_DateLabel
        '
        Last_Payment_DateLabel.AutoSize = True
        Last_Payment_DateLabel.Location = New System.Drawing.Point(216, 71)
        Last_Payment_DateLabel.Name = "Last_Payment_DateLabel"
        Last_Payment_DateLabel.Size = New System.Drawing.Size(77, 13)
        Last_Payment_DateLabel.TabIndex = 63
        Last_Payment_DateLabel.Text = "Payment Date:"
        '
        'Last_Invoice_DateLabel
        '
        Last_Invoice_DateLabel.AutoSize = True
        Last_Invoice_DateLabel.Location = New System.Drawing.Point(216, 35)
        Last_Invoice_DateLabel.Name = "Last_Invoice_DateLabel"
        Last_Invoice_DateLabel.Size = New System.Drawing.Size(65, 13)
        Last_Invoice_DateLabel.TabIndex = 64
        Last_Invoice_DateLabel.Text = "Last Invoice"
        '
        'DumpsterLabel
        '
        DumpsterLabel.AutoSize = True
        DumpsterLabel.Location = New System.Drawing.Point(294, 72)
        DumpsterLabel.Name = "DumpsterLabel"
        DumpsterLabel.Size = New System.Drawing.Size(55, 13)
        DumpsterLabel.TabIndex = 59
        DumpsterLabel.Text = "Dumpster:"
        '
        'Start_DateLabel
        '
        Start_DateLabel.AutoSize = True
        Start_DateLabel.Location = New System.Drawing.Point(17, 35)
        Start_DateLabel.Name = "Start_DateLabel"
        Start_DateLabel.Size = New System.Drawing.Size(58, 13)
        Start_DateLabel.TabIndex = 57
        Start_DateLabel.Text = "Start Date:"
        '
        'CleanupLabel
        '
        CleanupLabel.AutoSize = True
        CleanupLabel.Location = New System.Drawing.Point(155, 35)
        CleanupLabel.Name = "CleanupLabel"
        CleanupLabel.Size = New System.Drawing.Size(49, 13)
        CleanupLabel.TabIndex = 69
        CleanupLabel.Text = "Cleanup:"
        '
        'ActiveLabel
        '
        ActiveLabel.AutoSize = True
        ActiveLabel.Location = New System.Drawing.Point(17, 71)
        ActiveLabel.Name = "ActiveLabel"
        ActiveLabel.Size = New System.Drawing.Size(40, 13)
        ActiveLabel.TabIndex = 65
        ActiveLabel.Text = "Active:"
        '
        'End_DateLabel
        '
        End_DateLabel.AutoSize = True
        End_DateLabel.Location = New System.Drawing.Point(17, 53)
        End_DateLabel.Name = "End_DateLabel"
        End_DateLabel.Size = New System.Drawing.Size(55, 13)
        End_DateLabel.TabIndex = 58
        End_DateLabel.Text = "End Date:"
        '
        'SvcChgLabel
        '
        SvcChgLabel.AutoSize = True
        SvcChgLabel.Location = New System.Drawing.Point(155, 71)
        SvcChgLabel.Name = "SvcChgLabel"
        SvcChgLabel.Size = New System.Drawing.Size(51, 13)
        SvcChgLabel.TabIndex = 67
        SvcChgLabel.Text = "Svc Chg:"
        '
        'TaxableLabel
        '
        TaxableLabel.AutoSize = True
        TaxableLabel.Location = New System.Drawing.Point(155, 52)
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
        'GroupBoxCustomerInfo
        '
        Me.GroupBoxCustomerInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxCustomerInfo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBoxCustomerInfo.Controls.Add(Me.CustomerTextBox)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtEvening)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label5)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtCell)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label4)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtBusiness)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.LabelTelephoneNumber)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtZip)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtState)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtSuite)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtCity)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtAddress)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtContact)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label3)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label1)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.Label2)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.LabelCustomerAddress)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.LabelCustomerNumber)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.txtCompany)
        Me.GroupBoxCustomerInfo.Controls.Add(Me.LabelCustomerName)
        Me.GroupBoxCustomerInfo.Location = New System.Drawing.Point(19, 77)
        Me.GroupBoxCustomerInfo.Name = "GroupBoxCustomerInfo"
        Me.GroupBoxCustomerInfo.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBoxCustomerInfo.Size = New System.Drawing.Size(398, 255)
        Me.GroupBoxCustomerInfo.TabIndex = 1
        Me.GroupBoxCustomerInfo.TabStop = False
        Me.GroupBoxCustomerInfo.Text = "Customer Information"
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(135, 38)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.ReadOnly = True
        Me.CustomerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerTextBox.TabIndex = 76
        Me.CustomerTextBox.TabStop = False
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
        'txtEvening
        '
        Me.txtEvening.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Evening", True))
        Me.txtEvening.Location = New System.Drawing.Point(135, 189)
        Me.txtEvening.Name = "txtEvening"
        Me.txtEvening.ReadOnly = True
        Me.txtEvening.Size = New System.Drawing.Size(225, 20)
        Me.txtEvening.TabIndex = 21
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
        'txtCell
        '
        Me.txtCell.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CellPhone", True))
        Me.txtCell.Location = New System.Drawing.Point(135, 170)
        Me.txtCell.Name = "txtCell"
        Me.txtCell.ReadOnly = True
        Me.txtCell.Size = New System.Drawing.Size(225, 20)
        Me.txtCell.TabIndex = 19
        Me.txtCell.TabStop = False
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
        'txtBusiness
        '
        Me.txtBusiness.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Business", True))
        Me.txtBusiness.Location = New System.Drawing.Point(135, 153)
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.ReadOnly = True
        Me.txtBusiness.Size = New System.Drawing.Size(225, 20)
        Me.txtBusiness.TabIndex = 17
        Me.txtBusiness.TabStop = False
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
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Zip", True))
        Me.txtZip.Location = New System.Drawing.Point(312, 135)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(48, 20)
        Me.txtZip.TabIndex = 15
        Me.txtZip.TabStop = False
        '
        'txtState
        '
        Me.txtState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "State", True))
        Me.txtState.Location = New System.Drawing.Point(278, 135)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(28, 20)
        Me.txtState.TabIndex = 14
        Me.txtState.TabStop = False
        '
        'txtSuite
        '
        Me.txtSuite.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Suite/Apt", True))
        Me.txtSuite.Location = New System.Drawing.Point(135, 115)
        Me.txtSuite.Name = "txtSuite"
        Me.txtSuite.ReadOnly = True
        Me.txtSuite.Size = New System.Drawing.Size(225, 20)
        Me.txtSuite.TabIndex = 13
        Me.txtSuite.TabStop = False
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(135, 135)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(137, 20)
        Me.txtCity.TabIndex = 12
        Me.txtCity.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(135, 96)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(225, 20)
        Me.txtAddress.TabIndex = 11
        Me.txtAddress.TabStop = False
        '
        'txtContact
        '
        Me.txtContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Contact", True))
        Me.txtContact.Location = New System.Drawing.Point(135, 76)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(225, 20)
        Me.txtContact.TabIndex = 10
        Me.txtContact.TabStop = False
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
        'txtCompany
        '
        Me.txtCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Company", True))
        Me.txtCompany.Location = New System.Drawing.Point(135, 58)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(225, 20)
        Me.txtCompany.TabIndex = 1
        Me.txtCompany.TabStop = False
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.txtMonthlyCharge)
        Me.GroupBox1.Controls.Add(Monthly_ChargeLabel)
        Me.GroupBox1.Controls.Add(Me.txtLastPayDate)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(BalanceLabel)
        Me.GroupBox1.Controls.Add(Me.txtCredit)
        Me.GroupBox1.Controls.Add(CreditLabel)
        Me.GroupBox1.Controls.Add(Me.txtLastPayment)
        Me.GroupBox1.Controls.Add(Last_PaymentLabel)
        Me.GroupBox1.Controls.Add(Last_Payment_DateLabel)
        Me.GroupBox1.Controls.Add(Me.txtLastInvoiceDate)
        Me.GroupBox1.Controls.Add(Last_Invoice_DateLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 132)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Information"
        '
        'txtMonthlyCharge
        '
        Me.txtMonthlyCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "MonthlyCharge", True))
        Me.txtMonthlyCharge.Location = New System.Drawing.Point(135, 29)
        Me.txtMonthlyCharge.Name = "txtMonthlyCharge"
        Me.txtMonthlyCharge.ReadOnly = True
        Me.txtMonthlyCharge.Size = New System.Drawing.Size(64, 20)
        Me.txtMonthlyCharge.TabIndex = 69
        Me.txtMonthlyCharge.TabStop = False
        '
        'txtLastPayDate
        '
        Me.txtLastPayDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastPaymentDate", True))
        Me.txtLastPayDate.Location = New System.Drawing.Point(296, 68)
        Me.txtLastPayDate.Name = "txtLastPayDate"
        Me.txtLastPayDate.ReadOnly = True
        Me.txtLastPayDate.Size = New System.Drawing.Size(64, 20)
        Me.txtLastPayDate.TabIndex = 64
        Me.txtLastPayDate.TabStop = False
        '
        'txtBalance
        '
        Me.txtBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Balance", True))
        Me.txtBalance.Location = New System.Drawing.Point(135, 49)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(64, 20)
        Me.txtBalance.TabIndex = 61
        Me.txtBalance.TabStop = False
        '
        'txtCredit
        '
        Me.txtCredit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Credit", True))
        Me.txtCredit.Location = New System.Drawing.Point(135, 69)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.ReadOnly = True
        Me.txtCredit.Size = New System.Drawing.Size(64, 20)
        Me.txtCredit.TabIndex = 62
        Me.txtCredit.TabStop = False
        '
        'txtLastPayment
        '
        Me.txtLastPayment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastPayment", True))
        Me.txtLastPayment.Location = New System.Drawing.Point(296, 48)
        Me.txtLastPayment.Name = "txtLastPayment"
        Me.txtLastPayment.ReadOnly = True
        Me.txtLastPayment.Size = New System.Drawing.Size(64, 20)
        Me.txtLastPayment.TabIndex = 63
        Me.txtLastPayment.TabStop = False
        '
        'txtLastInvoiceDate
        '
        Me.txtLastInvoiceDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastInvoiceDate", True))
        Me.txtLastInvoiceDate.Location = New System.Drawing.Point(296, 28)
        Me.txtLastInvoiceDate.Name = "txtLastInvoiceDate"
        Me.txtLastInvoiceDate.ReadOnly = True
        Me.txtLastInvoiceDate.Size = New System.Drawing.Size(64, 20)
        Me.txtLastInvoiceDate.TabIndex = 65
        Me.txtLastInvoiceDate.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(DumpsterLabel)
        Me.GroupBox2.Controls.Add(Me.DumpsterComboBox)
        Me.GroupBox2.Controls.Add(Me.TruckComboBox)
        Me.GroupBox2.Controls.Add(Me.txtStartDate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Start_DateLabel)
        Me.GroupBox2.Controls.Add(Me.TextBox21)
        Me.GroupBox2.Controls.Add(Me.cboCleanup)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cboActive)
        Me.GroupBox2.Controls.Add(CleanupLabel)
        Me.GroupBox2.Controls.Add(ActiveLabel)
        Me.GroupBox2.Controls.Add(Me.txtEndDate)
        Me.GroupBox2.Controls.Add(End_DateLabel)
        Me.GroupBox2.Controls.Add(Me.cboTaxable)
        Me.GroupBox2.Controls.Add(SvcChgLabel)
        Me.GroupBox2.Controls.Add(TaxableLabel)
        Me.GroupBox2.Controls.Add(Me.cboSvcChg)
        Me.GroupBox2.Location = New System.Drawing.Point(413, 310)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 132)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Information"
        '
        'DumpsterComboBox
        '
        Me.DumpsterComboBox.FormattingEnabled = True
        Me.DumpsterComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.DumpsterComboBox.Location = New System.Drawing.Point(349, 68)
        Me.DumpsterComboBox.Name = "DumpsterComboBox"
        Me.DumpsterComboBox.Size = New System.Drawing.Size(36, 21)
        Me.DumpsterComboBox.TabIndex = 60
        '
        'TruckComboBox
        '
        Me.TruckComboBox.FormattingEnabled = True
        Me.TruckComboBox.Location = New System.Drawing.Point(297, 49)
        Me.TruckComboBox.Name = "TruckComboBox"
        Me.TruckComboBox.Size = New System.Drawing.Size(46, 21)
        Me.TruckComboBox.TabIndex = 38
        '
        'txtStartDate
        '
        Me.txtStartDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StartDate", True))
        Me.txtStartDate.Location = New System.Drawing.Point(81, 29)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.ReadOnly = True
        Me.txtStartDate.Size = New System.Drawing.Size(56, 20)
        Me.txtStartDate.TabIndex = 58
        Me.txtStartDate.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(346, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Stop #"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(349, 49)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(36, 20)
        Me.TextBox21.TabIndex = 36
        '
        'cboCleanup
        '
        Me.cboCleanup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Cleanup", True))
        Me.cboCleanup.Enabled = False
        Me.cboCleanup.FormattingEnabled = True
        Me.cboCleanup.Location = New System.Drawing.Point(209, 29)
        Me.cboCleanup.Name = "cboCleanup"
        Me.cboCleanup.Size = New System.Drawing.Size(64, 21)
        Me.cboCleanup.TabIndex = 70
        Me.cboCleanup.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Route Sequence"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Truck #"
        '
        'cboActive
        '
        Me.cboActive.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Active", True))
        Me.cboActive.Enabled = False
        Me.cboActive.FormattingEnabled = True
        Me.cboActive.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboActive.Location = New System.Drawing.Point(81, 69)
        Me.cboActive.Name = "cboActive"
        Me.cboActive.Size = New System.Drawing.Size(56, 21)
        Me.cboActive.TabIndex = 66
        Me.cboActive.TabStop = False
        '
        'txtEndDate
        '
        Me.txtEndDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "EndDate", True))
        Me.txtEndDate.Location = New System.Drawing.Point(81, 49)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(56, 20)
        Me.txtEndDate.TabIndex = 59
        Me.txtEndDate.TabStop = False
        '
        'cboTaxable
        '
        Me.cboTaxable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Taxable", True))
        Me.cboTaxable.Enabled = False
        Me.cboTaxable.FormattingEnabled = True
        Me.cboTaxable.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboTaxable.Location = New System.Drawing.Point(209, 49)
        Me.cboTaxable.Name = "cboTaxable"
        Me.cboTaxable.Size = New System.Drawing.Size(64, 21)
        Me.cboTaxable.TabIndex = 67
        Me.cboTaxable.TabStop = False
        '
        'cboSvcChg
        '
        Me.cboSvcChg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "SvcChg", True))
        Me.cboSvcChg.Enabled = False
        Me.cboSvcChg.FormattingEnabled = True
        Me.cboSvcChg.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboSvcChg.Location = New System.Drawing.Point(209, 69)
        Me.cboSvcChg.Name = "cboSvcChg"
        Me.cboSvcChg.Size = New System.Drawing.Size(64, 21)
        Me.cboSvcChg.TabIndex = 68
        Me.cboSvcChg.TabStop = False
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
        'txtNotes
        '
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Notes", True))
        Me.txtNotes.Location = New System.Drawing.Point(18, 130)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.Size = New System.Drawing.Size(367, 82)
        Me.txtNotes.TabIndex = 31
        Me.txtNotes.TabStop = False
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
        'txtPickup
        '
        Me.txtPickup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Service", True))
        Me.txtPickup.Location = New System.Drawing.Point(18, 59)
        Me.txtPickup.Name = "txtPickup"
        Me.txtPickup.ReadOnly = True
        Me.txtPickup.Size = New System.Drawing.Size(247, 20)
        Me.txtPickup.TabIndex = 27
        Me.txtPickup.TabStop = False
        '
        'txtStreetName
        '
        Me.txtStreetName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StreetName", True))
        Me.txtStreetName.Location = New System.Drawing.Point(285, 59)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.ReadOnly = True
        Me.txtStreetName.Size = New System.Drawing.Size(100, 20)
        Me.txtStreetName.TabIndex = 71
        Me.txtStreetName.TabStop = False
        '
        'GroupBoxAccountInformation
        '
        Me.GroupBoxAccountInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxAccountInformation.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBoxAccountInformation.Controls.Add(StreetNameLabel)
        Me.GroupBoxAccountInformation.Controls.Add(Me.txtStreetName)
        Me.GroupBoxAccountInformation.Controls.Add(Me.txtPickup)
        Me.GroupBoxAccountInformation.Controls.Add(Me.LabelNotes)
        Me.GroupBoxAccountInformation.Controls.Add(Me.txtNotes)
        Me.GroupBoxAccountInformation.Controls.Add(Me.LabelPickupLocation)
        Me.GroupBoxAccountInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAccountInformation.Location = New System.Drawing.Point(413, 77)
        Me.GroupBoxAccountInformation.Name = "GroupBoxAccountInformation"
        Me.GroupBoxAccountInformation.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBoxAccountInformation.Size = New System.Drawing.Size(406, 296)
        Me.GroupBoxAccountInformation.TabIndex = 2
        Me.GroupBoxAccountInformation.TabStop = False
        Me.GroupBoxAccountInformation.Text = "Pickup Location"
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
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripLabel, Me.CustomerToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(874, 25)
        Me.FillToolStrip.TabIndex = 75
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
        Me.CustomerToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(84, 22)
        Me.FillToolStripButton.Text = "Get Customer"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(420, 461)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 76
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(501, 461)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 77
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(582, 461)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 78
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(663, 462)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(744, 462)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 80
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(16, 461)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 81
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(98, 461)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 82
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(179, 461)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 83
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(260, 461)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 84
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(874, 517)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxCustomerInfo)
        Me.Controls.Add(Me.GroupBoxAccountInformation)
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.GroupBoxCustomerInfo.ResumeLayout(False)
        Me.GroupBoxCustomerInfo.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxAccountInformation.ResumeLayout(False)
        Me.GroupBoxAccountInformation.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtEvening As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCell As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBusiness As System.Windows.Forms.TextBox
    Friend WithEvents LabelTelephoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtSuite As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerAddress As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerNumber As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonthlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtLastPayDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtLastPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtLastInvoiceDate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DumpsterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TruckComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents cboCleanup As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboActive As System.Windows.Forms.ComboBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents cboTaxable As System.Windows.Forms.ComboBox
    Friend WithEvents cboSvcChg As System.Windows.Forms.ComboBox
    Friend WithEvents LabelPickupLocation As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents LabelNotes As System.Windows.Forms.Label
    Friend WithEvents txtPickup As System.Windows.Forms.TextBox
    Friend WithEvents txtStreetName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxAccountInformation As System.Windows.Forms.GroupBox
    Friend WithEvents CustomerDataSet As Invoice.CustomerDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Invoice.CustomerDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As Invoice.CustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CustomerToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CustomerToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button

End Class
