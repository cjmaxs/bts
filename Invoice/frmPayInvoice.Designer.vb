<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayInvoice
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
        Dim InvoiceLabel As System.Windows.Forms.Label
        Dim InvDateLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim CompanyLabel As System.Windows.Forms.Label
        Dim InvAmtLabel As System.Windows.Forms.Label
        Dim BalDueLabel As System.Windows.Forms.Label
        Dim ServiceLabel As System.Windows.Forms.Label
        Dim AmtPaidLabel As System.Windows.Forms.Label
        Dim DatePaidLabel As System.Windows.Forms.Label
        Dim RefLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayInvoice))
        Me.PayInvoiceDataSet = New Invoice.PayInvoiceDataSet()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesTableAdapter = New Invoice.PayInvoiceDataSetTableAdapters.InvoicesTableAdapter()
        Me.TableAdapterManager = New Invoice.PayInvoiceDataSetTableAdapters.TableAdapterManager()
        Me.InvoicesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.InvoicesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.InvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.InvDateTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.InvAmtTextBox = New System.Windows.Forms.TextBox()
        Me.BalDueTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.AmtPaidTextBox = New System.Windows.Forms.TextBox()
        Me.DatePaidTextBox = New System.Windows.Forms.TextBox()
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOpenCredit = New System.Windows.Forms.TextBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Invoice.PayInvoiceDataSetTableAdapters.CustomersTableAdapter()
        Me.btnPay = New System.Windows.Forms.Button()
        InvoiceLabel = New System.Windows.Forms.Label()
        InvDateLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        CompanyLabel = New System.Windows.Forms.Label()
        InvAmtLabel = New System.Windows.Forms.Label()
        BalDueLabel = New System.Windows.Forms.Label()
        ServiceLabel = New System.Windows.Forms.Label()
        AmtPaidLabel = New System.Windows.Forms.Label()
        DatePaidLabel = New System.Windows.Forms.Label()
        RefLabel = New System.Windows.Forms.Label()
        CType(Me.PayInvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicesBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceLabel
        '
        InvoiceLabel.AutoSize = True
        InvoiceLabel.Location = New System.Drawing.Point(161, 125)
        InvoiceLabel.Name = "InvoiceLabel"
        InvoiceLabel.Size = New System.Drawing.Size(45, 13)
        InvoiceLabel.TabIndex = 2
        InvoiceLabel.Text = "Invoice:"
        '
        'InvDateLabel
        '
        InvDateLabel.AutoSize = True
        InvDateLabel.Location = New System.Drawing.Point(57, 125)
        InvDateLabel.Name = "InvDateLabel"
        InvDateLabel.Size = New System.Drawing.Size(51, 13)
        InvDateLabel.TabIndex = 4
        InvDateLabel.Text = "Inv Date:"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(22, 88)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(54, 13)
        CustomerLabel.TabIndex = 6
        CustomerLabel.Text = "Customer:"
        '
        'CompanyLabel
        '
        CompanyLabel.AutoSize = True
        CompanyLabel.Location = New System.Drawing.Point(211, 88)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(54, 13)
        CompanyLabel.TabIndex = 8
        CompanyLabel.Text = "Company:"
        '
        'InvAmtLabel
        '
        InvAmtLabel.AutoSize = True
        InvAmtLabel.Location = New System.Drawing.Point(454, 125)
        InvAmtLabel.Name = "InvAmtLabel"
        InvAmtLabel.Size = New System.Drawing.Size(46, 13)
        InvAmtLabel.TabIndex = 10
        InvAmtLabel.Text = "Inv Amt:"
        '
        'BalDueLabel
        '
        BalDueLabel.AutoSize = True
        BalDueLabel.Location = New System.Drawing.Point(661, 125)
        BalDueLabel.Name = "BalDueLabel"
        BalDueLabel.Size = New System.Drawing.Size(48, 13)
        BalDueLabel.TabIndex = 12
        BalDueLabel.Text = "Bal Due:"
        '
        'ServiceLabel
        '
        ServiceLabel.AutoSize = True
        ServiceLabel.Location = New System.Drawing.Point(319, 125)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New System.Drawing.Size(46, 13)
        ServiceLabel.TabIndex = 14
        ServiceLabel.Text = "Service:"
        '
        'AmtPaidLabel
        '
        AmtPaidLabel.AutoSize = True
        AmtPaidLabel.Location = New System.Drawing.Point(554, 125)
        AmtPaidLabel.Name = "AmtPaidLabel"
        AmtPaidLabel.Size = New System.Drawing.Size(52, 13)
        AmtPaidLabel.TabIndex = 16
        AmtPaidLabel.Text = "Amt Paid:"
        '
        'DatePaidLabel
        '
        DatePaidLabel.AutoSize = True
        DatePaidLabel.Location = New System.Drawing.Point(336, 220)
        DatePaidLabel.Name = "DatePaidLabel"
        DatePaidLabel.Size = New System.Drawing.Size(57, 13)
        DatePaidLabel.TabIndex = 18
        DatePaidLabel.Text = "Date Paid:"
        '
        'RefLabel
        '
        RefLabel.AutoSize = True
        RefLabel.Location = New System.Drawing.Point(439, 220)
        RefLabel.Name = "RefLabel"
        RefLabel.Size = New System.Drawing.Size(57, 13)
        RefLabel.TabIndex = 20
        RefLabel.Text = "Reference"
        '
        'PayInvoiceDataSet
        '
        Me.PayInvoiceDataSet.DataSetName = "PayInvoiceDataSet"
        Me.PayInvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.PayInvoiceDataSet
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Invoice.PayInvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.InvoicesBindingNavigator.Size = New System.Drawing.Size(749, 25)
        Me.InvoicesBindingNavigator.TabIndex = 0
        Me.InvoicesBindingNavigator.Text = "BindingNavigator1"
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
        'InvoicesBindingNavigatorSaveItem
        '
        Me.InvoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InvoicesBindingNavigatorSaveItem.Image = CType(resources.GetObject("InvoicesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InvoicesBindingNavigatorSaveItem.Name = "InvoicesBindingNavigatorSaveItem"
        Me.InvoicesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InvoicesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripLabel, Me.CustomerToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(749, 25)
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
        Me.CustomerToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'InvoiceTextBox
        '
        Me.InvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Invoice", True))
        Me.InvoiceTextBox.Location = New System.Drawing.Point(140, 141)
        Me.InvoiceTextBox.Name = "InvoiceTextBox"
        Me.InvoiceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InvoiceTextBox.TabIndex = 3
        '
        'InvDateTextBox
        '
        Me.InvDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvDate", True))
        Me.InvDateTextBox.Location = New System.Drawing.Point(25, 141)
        Me.InvDateTextBox.Name = "InvDateTextBox"
        Me.InvDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InvDateTextBox.TabIndex = 5
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(86, 85)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerTextBox.TabIndex = 7
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(275, 85)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(227, 20)
        Me.CompanyTextBox.TabIndex = 9
        '
        'InvAmtTextBox
        '
        Me.InvAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvAmt", True))
        Me.InvAmtTextBox.Location = New System.Drawing.Point(430, 141)
        Me.InvAmtTextBox.Name = "InvAmtTextBox"
        Me.InvAmtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InvAmtTextBox.TabIndex = 11
        '
        'BalDueTextBox
        '
        Me.BalDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "BalDue", True))
        Me.BalDueTextBox.Location = New System.Drawing.Point(637, 141)
        Me.BalDueTextBox.Name = "BalDueTextBox"
        Me.BalDueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BalDueTextBox.TabIndex = 13
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Service", True))
        Me.ServiceTextBox.Location = New System.Drawing.Point(246, 141)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(178, 20)
        Me.ServiceTextBox.TabIndex = 15
        '
        'AmtPaidTextBox
        '
        Me.AmtPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "AmtPaid", True))
        Me.AmtPaidTextBox.Location = New System.Drawing.Point(536, 141)
        Me.AmtPaidTextBox.Name = "AmtPaidTextBox"
        Me.AmtPaidTextBox.Size = New System.Drawing.Size(95, 20)
        Me.AmtPaidTextBox.TabIndex = 17
        '
        'DatePaidTextBox
        '
        Me.DatePaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "DatePaid", True))
        Me.DatePaidTextBox.Location = New System.Drawing.Point(313, 236)
        Me.DatePaidTextBox.Name = "DatePaidTextBox"
        Me.DatePaidTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DatePaidTextBox.TabIndex = 19
        '
        'RefTextBox
        '
        Me.RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Ref", True))
        Me.RefTextBox.Location = New System.Drawing.Point(419, 236)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RefTextBox.TabIndex = 21
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(212, 236)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(95, 20)
        Me.txtPayment.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Open Credit"
        '
        'txtOpenCredit
        '
        Me.txtOpenCredit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Credit", True))
        Me.txtOpenCredit.Location = New System.Drawing.Point(111, 236)
        Me.txtOpenCredit.Name = "txtOpenCredit"
        Me.txtOpenCredit.Size = New System.Drawing.Size(95, 20)
        Me.txtOpenCredit.TabIndex = 24
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.PayInvoiceDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(637, 236)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 26
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'frmPayInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 295)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOpenCredit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(InvoiceLabel)
        Me.Controls.Add(Me.InvoiceTextBox)
        Me.Controls.Add(InvDateLabel)
        Me.Controls.Add(Me.InvDateTextBox)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(CompanyLabel)
        Me.Controls.Add(Me.CompanyTextBox)
        Me.Controls.Add(InvAmtLabel)
        Me.Controls.Add(Me.InvAmtTextBox)
        Me.Controls.Add(BalDueLabel)
        Me.Controls.Add(Me.BalDueTextBox)
        Me.Controls.Add(ServiceLabel)
        Me.Controls.Add(Me.ServiceTextBox)
        Me.Controls.Add(AmtPaidLabel)
        Me.Controls.Add(Me.AmtPaidTextBox)
        Me.Controls.Add(DatePaidLabel)
        Me.Controls.Add(Me.DatePaidTextBox)
        Me.Controls.Add(RefLabel)
        Me.Controls.Add(Me.RefTextBox)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.InvoicesBindingNavigator)
        Me.Name = "frmPayInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Invoice"
        CType(Me.PayInvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PayInvoiceDataSet As Invoice.PayInvoiceDataSet
    Friend WithEvents InvoicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicesTableAdapter As Invoice.PayInvoiceDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents TableAdapterManager As Invoice.PayInvoiceDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents InvoiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmtPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatePaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOpenCredit As System.Windows.Forms.TextBox
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Invoice.PayInvoiceDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents btnPay As System.Windows.Forms.Button
End Class
