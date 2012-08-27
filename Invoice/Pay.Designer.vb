<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pay
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
        Dim RefLabel As System.Windows.Forms.Label
        Dim AmtPaidLabel As System.Windows.Forms.Label
        Dim DatePaidLabel As System.Windows.Forms.Label
        Dim BalDueLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pay))
        Dim InvoiceLabel1 As System.Windows.Forms.Label
        Dim InvDateLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim InvAmtLabel1 As System.Windows.Forms.Label
        Dim BalDueLabel1 As System.Windows.Forms.Label
        Dim ServiceLabel As System.Windows.Forms.Label
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.AmtPaidTextBox = New System.Windows.Forms.TextBox()
        Me.DatePaidDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnApplyCredit = New System.Windows.Forms.Button()
        Me.txtAcctBal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.btnSavePayment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPay1 = New System.Windows.Forms.TextBox()
        Me.BalDueTextBox = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TxtPay2 = New System.Windows.Forms.TextBox()
        Me.PayInvoiceDataSet = New Invoice.PayInvoiceDataSet()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesTableAdapter = New Invoice.PayInvoiceDataSetTableAdapters.InvoicesTableAdapter()
        Me.TableAdapterManager = New Invoice.PayInvoiceDataSetTableAdapters.TableAdapterManager()
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
        Me.InvoiceTextBox1 = New System.Windows.Forms.TextBox()
        Me.InvDateTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.InvAmtTextBox1 = New System.Windows.Forms.TextBox()
        Me.BalDueTextBox1 = New System.Windows.Forms.TextBox()
        Me.ServiceTextBox = New System.Windows.Forms.TextBox()
        RefLabel = New System.Windows.Forms.Label()
        AmtPaidLabel = New System.Windows.Forms.Label()
        DatePaidLabel = New System.Windows.Forms.Label()
        BalDueLabel = New System.Windows.Forms.Label()
        InvoiceLabel1 = New System.Windows.Forms.Label()
        InvDateLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        InvAmtLabel1 = New System.Windows.Forms.Label()
        BalDueLabel1 = New System.Windows.Forms.Label()
        ServiceLabel = New System.Windows.Forms.Label()
        CType(Me.PayInvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicesBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RefLabel
        '
        RefLabel.AutoSize = True
        RefLabel.Location = New System.Drawing.Point(772, 68)
        RefLabel.Name = "RefLabel"
        RefLabel.Size = New System.Drawing.Size(57, 13)
        RefLabel.TabIndex = 5
        RefLabel.Text = "Reference"
        '
        'AmtPaidLabel
        '
        AmtPaidLabel.AutoSize = True
        AmtPaidLabel.Location = New System.Drawing.Point(763, 172)
        AmtPaidLabel.Name = "AmtPaidLabel"
        AmtPaidLabel.Size = New System.Drawing.Size(67, 13)
        AmtPaidLabel.TabIndex = 7
        AmtPaidLabel.Text = "Amount Paid"
        '
        'DatePaidLabel
        '
        DatePaidLabel.AutoSize = True
        DatePaidLabel.Location = New System.Drawing.Point(776, 96)
        DatePaidLabel.Name = "DatePaidLabel"
        DatePaidLabel.Size = New System.Drawing.Size(54, 13)
        DatePaidLabel.TabIndex = 9
        DatePaidLabel.Text = "Date Paid"
        '
        'BalDueLabel
        '
        BalDueLabel.AutoSize = True
        BalDueLabel.Location = New System.Drawing.Point(769, 146)
        BalDueLabel.Name = "BalDueLabel"
        BalDueLabel.Size = New System.Drawing.Size(60, 13)
        BalDueLabel.TabIndex = 22
        BalDueLabel.Text = "Invoice Bal"
        '
        'CreditTextBox
        '
        Me.CreditTextBox.Location = New System.Drawing.Point(568, 114)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.ReadOnly = True
        Me.CreditTextBox.Size = New System.Drawing.Size(84, 20)
        Me.CreditTextBox.TabIndex = 4
        '
        'RefTextBox
        '
        Me.RefTextBox.Location = New System.Drawing.Point(846, 65)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.Size = New System.Drawing.Size(84, 20)
        Me.RefTextBox.TabIndex = 6
        '
        'AmtPaidTextBox
        '
        Me.AmtPaidTextBox.Location = New System.Drawing.Point(792, 28)
        Me.AmtPaidTextBox.Name = "AmtPaidTextBox"
        Me.AmtPaidTextBox.ReadOnly = True
        Me.AmtPaidTextBox.Size = New System.Drawing.Size(84, 20)
        Me.AmtPaidTextBox.TabIndex = 8
        '
        'DatePaidDateTimePicker
        '
        Me.DatePaidDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePaidDateTimePicker.Location = New System.Drawing.Point(846, 90)
        Me.DatePaidDateTimePicker.Name = "DatePaidDateTimePicker"
        Me.DatePaidDateTimePicker.Size = New System.Drawing.Size(84, 20)
        Me.DatePaidDateTimePicker.TabIndex = 12
        '
        'btnApplyCredit
        '
        Me.btnApplyCredit.Location = New System.Drawing.Point(466, 112)
        Me.btnApplyCredit.Name = "btnApplyCredit"
        Me.btnApplyCredit.Size = New System.Drawing.Size(86, 23)
        Me.btnApplyCredit.TabIndex = 13
        Me.btnApplyCredit.Text = "Apply Credit"
        Me.btnApplyCredit.UseVisualStyleBackColor = True
        '
        'txtAcctBal
        '
        Me.txtAcctBal.Location = New System.Drawing.Point(846, 215)
        Me.txtAcctBal.Name = "txtAcctBal"
        Me.txtAcctBal.ReadOnly = True
        Me.txtAcctBal.Size = New System.Drawing.Size(84, 20)
        Me.txtAcctBal.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(741, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Account Balance"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(487, 117)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(34, 13)
        Me.lblCredit.TabIndex = 18
        Me.lblCredit.Text = "Credit"
        '
        'btnSavePayment
        '
        Me.btnSavePayment.Location = New System.Drawing.Point(751, 262)
        Me.btnSavePayment.Name = "btnSavePayment"
        Me.btnSavePayment.Size = New System.Drawing.Size(176, 23)
        Me.btnSavePayment.TabIndex = 19
        Me.btnSavePayment.Text = "Apply Payment"
        Me.btnSavePayment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(782, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Payment"
        '
        'txtPay1
        '
        Me.txtPay1.Location = New System.Drawing.Point(846, 117)
        Me.txtPay1.Name = "txtPay1"
        Me.txtPay1.Size = New System.Drawing.Size(84, 20)
        Me.txtPay1.TabIndex = 21
        '
        'BalDueTextBox
        '
        Me.BalDueTextBox.Location = New System.Drawing.Point(846, 143)
        Me.BalDueTextBox.Name = "BalDueTextBox"
        Me.BalDueTextBox.ReadOnly = True
        Me.BalDueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.BalDueTextBox.TabIndex = 23
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(754, 302)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(176, 23)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close "
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TxtPay2
        '
        Me.TxtPay2.Location = New System.Drawing.Point(846, 170)
        Me.TxtPay2.Name = "TxtPay2"
        Me.TxtPay2.ReadOnly = True
        Me.TxtPay2.Size = New System.Drawing.Size(84, 20)
        Me.TxtPay2.TabIndex = 25
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
        Me.InvoicesBindingNavigator.Size = New System.Drawing.Size(1010, 25)
        Me.InvoicesBindingNavigator.TabIndex = 26
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
        Me.FillToolStrip.Size = New System.Drawing.Size(1010, 25)
        Me.FillToolStrip.TabIndex = 27
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
        'InvoiceLabel1
        '
        InvoiceLabel1.AutoSize = True
        InvoiceLabel1.Location = New System.Drawing.Point(208, 121)
        InvoiceLabel1.Name = "InvoiceLabel1"
        InvoiceLabel1.Size = New System.Drawing.Size(45, 13)
        InvoiceLabel1.TabIndex = 27
        InvoiceLabel1.Text = "Invoice:"
        '
        'InvoiceTextBox1
        '
        Me.InvoiceTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Invoice", True))
        Me.InvoiceTextBox1.Location = New System.Drawing.Point(272, 118)
        Me.InvoiceTextBox1.Name = "InvoiceTextBox1"
        Me.InvoiceTextBox1.Size = New System.Drawing.Size(77, 20)
        Me.InvoiceTextBox1.TabIndex = 28
        '
        'InvDateLabel
        '
        InvDateLabel.AutoSize = True
        InvDateLabel.Location = New System.Drawing.Point(22, 203)
        InvDateLabel.Name = "InvDateLabel"
        InvDateLabel.Size = New System.Drawing.Size(51, 13)
        InvDateLabel.TabIndex = 29
        InvDateLabel.Text = "Inv Date:"
        '
        'InvDateTextBox
        '
        Me.InvDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvDate", True))
        Me.InvDateTextBox.Location = New System.Drawing.Point(76, 200)
        Me.InvDateTextBox.Name = "InvDateTextBox"
        Me.InvDateTextBox.Size = New System.Drawing.Size(51, 20)
        Me.InvDateTextBox.TabIndex = 30
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(12, 118)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(54, 13)
        CustomerLabel.TabIndex = 31
        CustomerLabel.Text = "Customer:"
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(76, 115)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerTextBox.TabIndex = 32
        '
        'InvAmtLabel1
        '
        InvAmtLabel1.AutoSize = True
        InvAmtLabel1.Location = New System.Drawing.Point(414, 206)
        InvAmtLabel1.Name = "InvAmtLabel1"
        InvAmtLabel1.Size = New System.Drawing.Size(46, 13)
        InvAmtLabel1.TabIndex = 35
        InvAmtLabel1.Text = "Inv Amt:"
        '
        'InvAmtTextBox1
        '
        Me.InvAmtTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvAmt", True))
        Me.InvAmtTextBox1.Location = New System.Drawing.Point(466, 203)
        Me.InvAmtTextBox1.Name = "InvAmtTextBox1"
        Me.InvAmtTextBox1.Size = New System.Drawing.Size(54, 20)
        Me.InvAmtTextBox1.TabIndex = 36
        '
        'BalDueLabel1
        '
        BalDueLabel1.AutoSize = True
        BalDueLabel1.Location = New System.Drawing.Point(535, 206)
        BalDueLabel1.Name = "BalDueLabel1"
        BalDueLabel1.Size = New System.Drawing.Size(48, 13)
        BalDueLabel1.TabIndex = 37
        BalDueLabel1.Text = "Bal Due:"
        '
        'BalDueTextBox1
        '
        Me.BalDueTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "BalDue", True))
        Me.BalDueTextBox1.Location = New System.Drawing.Point(589, 203)
        Me.BalDueTextBox1.Name = "BalDueTextBox1"
        Me.BalDueTextBox1.Size = New System.Drawing.Size(63, 20)
        Me.BalDueTextBox1.TabIndex = 38
        '
        'ServiceLabel
        '
        ServiceLabel.AutoSize = True
        ServiceLabel.Location = New System.Drawing.Point(144, 203)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New System.Drawing.Size(46, 13)
        ServiceLabel.TabIndex = 39
        ServiceLabel.Text = "Service:"
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Service", True))
        Me.ServiceTextBox.Location = New System.Drawing.Point(196, 203)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(203, 20)
        Me.ServiceTextBox.TabIndex = 40
        '
        'Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 375)
        Me.Controls.Add(InvoiceLabel1)
        Me.Controls.Add(Me.InvoiceTextBox1)
        Me.Controls.Add(InvDateLabel)
        Me.Controls.Add(Me.InvDateTextBox)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(InvAmtLabel1)
        Me.Controls.Add(Me.InvAmtTextBox1)
        Me.Controls.Add(BalDueLabel1)
        Me.Controls.Add(Me.BalDueTextBox1)
        Me.Controls.Add(ServiceLabel)
        Me.Controls.Add(Me.ServiceTextBox)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.InvoicesBindingNavigator)
        Me.Controls.Add(Me.TxtPay2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(BalDueLabel)
        Me.Controls.Add(Me.BalDueTextBox)
        Me.Controls.Add(Me.txtPay1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSavePayment)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAcctBal)
        Me.Controls.Add(Me.btnApplyCredit)
        Me.Controls.Add(Me.DatePaidDateTimePicker)
        Me.Controls.Add(DatePaidLabel)
        Me.Controls.Add(AmtPaidLabel)
        Me.Controls.Add(Me.AmtPaidTextBox)
        Me.Controls.Add(RefLabel)
        Me.Controls.Add(Me.RefTextBox)
        Me.Controls.Add(Me.CreditTextBox)
        Me.Name = "Pay"
        Me.Text = "Pay"
        CType(Me.PayInvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoicesBindingNavigator.ResumeLayout(False)
        Me.InvoicesBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmtPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatePaidDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnApplyCredit As System.Windows.Forms.Button
    Friend WithEvents txtAcctBal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents btnSavePayment As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPay1 As System.Windows.Forms.TextBox
    Friend WithEvents BalDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TxtPay2 As System.Windows.Forms.TextBox
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
    Friend WithEvents InvoiceTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents InvDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvAmtTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BalDueTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ServiceTextBox As System.Windows.Forms.TextBox
End Class
