<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Dim InvAmtLabel As System.Windows.Forms.Label
        Dim BalDueLabel As System.Windows.Forms.Label
        Dim ServiceLabel As System.Windows.Forms.Label
        Dim AmtPaidLabel As System.Windows.Forms.Label
        Dim DatePaidLabel As System.Windows.Forms.Label
        Dim RefLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayments))
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
        Me.InvAmtTextBox = New System.Windows.Forms.TextBox()
        Me.BalDueTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.AmtPaidTextBox = New System.Windows.Forms.TextBox()
        Me.DatePaidTextBox = New System.Windows.Forms.TextBox()
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btnApplyPayment = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Invoice.PayInvoiceDataSetTableAdapters.CustomersTableAdapter()
        Me.CustomerTextBox1 = New System.Windows.Forms.TextBox()
        Me.LastPaymentDateTextBox = New System.Windows.Forms.TextBox()
        Me.LastPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.IdnumTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCodeTextBox = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.AmtApplyTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApplyCr = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        InvoiceLabel = New System.Windows.Forms.Label()
        InvDateLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        InvAmtLabel = New System.Windows.Forms.Label()
        BalDueLabel = New System.Windows.Forms.Label()
        ServiceLabel = New System.Windows.Forms.Label()
        AmtPaidLabel = New System.Windows.Forms.Label()
        DatePaidLabel = New System.Windows.Forms.Label()
        RefLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
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
        InvoiceLabel.Location = New System.Drawing.Point(76, 124)
        InvoiceLabel.Name = "InvoiceLabel"
        InvoiceLabel.Size = New System.Drawing.Size(42, 13)
        InvoiceLabel.TabIndex = 19
        InvoiceLabel.Text = "Invoice"
        '
        'InvDateLabel
        '
        InvDateLabel.AutoSize = True
        InvDateLabel.Location = New System.Drawing.Point(76, 152)
        InvDateLabel.Name = "InvDateLabel"
        InvDateLabel.Size = New System.Drawing.Size(48, 13)
        InvDateLabel.TabIndex = 21
        InvDateLabel.Text = "Inv Date"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(76, 73)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(51, 13)
        CustomerLabel.TabIndex = 23
        CustomerLabel.Text = "Customer"
        '
        'InvAmtLabel
        '
        InvAmtLabel.AutoSize = True
        InvAmtLabel.Location = New System.Drawing.Point(76, 178)
        InvAmtLabel.Name = "InvAmtLabel"
        InvAmtLabel.Size = New System.Drawing.Size(43, 13)
        InvAmtLabel.TabIndex = 27
        InvAmtLabel.Text = "Inv Amt"
        '
        'BalDueLabel
        '
        BalDueLabel.AutoSize = True
        BalDueLabel.Location = New System.Drawing.Point(372, 227)
        BalDueLabel.Name = "BalDueLabel"
        BalDueLabel.Size = New System.Drawing.Size(45, 13)
        BalDueLabel.TabIndex = 29
        BalDueLabel.Text = "Bal Due"
        '
        'ServiceLabel
        '
        ServiceLabel.AutoSize = True
        ServiceLabel.Location = New System.Drawing.Point(76, 99)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New System.Drawing.Size(43, 13)
        ServiceLabel.TabIndex = 31
        ServiceLabel.Text = "Service"
        '
        'AmtPaidLabel
        '
        AmtPaidLabel.AutoSize = True
        AmtPaidLabel.Location = New System.Drawing.Point(76, 204)
        AmtPaidLabel.Name = "AmtPaidLabel"
        AmtPaidLabel.Size = New System.Drawing.Size(49, 13)
        AmtPaidLabel.TabIndex = 33
        AmtPaidLabel.Text = "Amt Paid"
        '
        'DatePaidLabel
        '
        DatePaidLabel.AutoSize = True
        DatePaidLabel.Location = New System.Drawing.Point(372, 152)
        DatePaidLabel.Name = "DatePaidLabel"
        DatePaidLabel.Size = New System.Drawing.Size(54, 13)
        DatePaidLabel.TabIndex = 35
        DatePaidLabel.Text = "Date Paid"
        '
        'RefLabel
        '
        RefLabel.AutoSize = True
        RefLabel.Location = New System.Drawing.Point(372, 124)
        RefLabel.Name = "RefLabel"
        RefLabel.Size = New System.Drawing.Size(57, 13)
        RefLabel.TabIndex = 37
        RefLabel.Text = "Reference"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(371, 99)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(63, 13)
        CreditLabel.TabIndex = 50
        CreditLabel.Text = "Open Credit"
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
        Me.InvoicesBindingNavigator.Size = New System.Drawing.Size(667, 25)
        Me.InvoicesBindingNavigator.TabIndex = 18
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
        Me.FillToolStrip.Size = New System.Drawing.Size(667, 25)
        Me.FillToolStrip.TabIndex = 19
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
        Me.InvoiceTextBox.Location = New System.Drawing.Point(133, 121)
        Me.InvoiceTextBox.Name = "InvoiceTextBox"
        Me.InvoiceTextBox.Size = New System.Drawing.Size(132, 20)
        Me.InvoiceTextBox.TabIndex = 20
        Me.InvoiceTextBox.TabStop = False
        '
        'InvDateTextBox
        '
        Me.InvDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvDate", True))
        Me.InvDateTextBox.Location = New System.Drawing.Point(133, 147)
        Me.InvDateTextBox.Name = "InvDateTextBox"
        Me.InvDateTextBox.Size = New System.Drawing.Size(132, 20)
        Me.InvDateTextBox.TabIndex = 22
        Me.InvDateTextBox.TabStop = False
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.CustomerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(133, 70)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(70, 13)
        Me.CustomerTextBox.TabIndex = 24
        Me.CustomerTextBox.TabStop = False
        '
        'InvAmtTextBox
        '
        Me.InvAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvAmt", True))
        Me.InvAmtTextBox.Location = New System.Drawing.Point(133, 174)
        Me.InvAmtTextBox.Name = "InvAmtTextBox"
        Me.InvAmtTextBox.Size = New System.Drawing.Size(132, 20)
        Me.InvAmtTextBox.TabIndex = 28
        Me.InvAmtTextBox.TabStop = False
        '
        'BalDueTextBox
        '
        Me.BalDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "BalDue", True))
        Me.BalDueTextBox.Location = New System.Drawing.Point(440, 223)
        Me.BalDueTextBox.Name = "BalDueTextBox"
        Me.BalDueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BalDueTextBox.TabIndex = 30
        Me.BalDueTextBox.TabStop = False
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Service", True))
        Me.ServiceTextBox.Location = New System.Drawing.Point(133, 96)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(193, 20)
        Me.ServiceTextBox.TabIndex = 32
        Me.ServiceTextBox.TabStop = False
        '
        'AmtPaidTextBox
        '
        Me.AmtPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "AmtPaid", True))
        Me.AmtPaidTextBox.Location = New System.Drawing.Point(133, 200)
        Me.AmtPaidTextBox.Name = "AmtPaidTextBox"
        Me.AmtPaidTextBox.Size = New System.Drawing.Size(132, 20)
        Me.AmtPaidTextBox.TabIndex = 34
        Me.AmtPaidTextBox.TabStop = False
        '
        'DatePaidTextBox
        '
        Me.DatePaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "DatePaid", True))
        Me.DatePaidTextBox.Location = New System.Drawing.Point(440, 145)
        Me.DatePaidTextBox.Name = "DatePaidTextBox"
        Me.DatePaidTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DatePaidTextBox.TabIndex = 2
        '
        'RefTextBox
        '
        Me.RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Ref", True))
        Me.RefTextBox.Location = New System.Drawing.Point(440, 119)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RefTextBox.TabIndex = 3
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(372, 178)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(48, 13)
        Me.lblPayment.TabIndex = 39
        Me.lblPayment.Text = "Payment"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(440, 171)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtPayment.TabIndex = 1
        '
        'btnApplyPayment
        '
        Me.btnApplyPayment.Location = New System.Drawing.Point(226, 283)
        Me.btnApplyPayment.Name = "btnApplyPayment"
        Me.btnApplyPayment.Size = New System.Drawing.Size(97, 23)
        Me.btnApplyPayment.TabIndex = 41
        Me.btnApplyPayment.Text = "Apply Payment"
        Me.btnApplyPayment.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(329, 283)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(97, 23)
        Me.btnX.TabIndex = 42
        Me.btnX.Text = "Cancel"
        Me.btnX.UseVisualStyleBackColor = True
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
        'CustomerTextBox1
        '
        Me.CustomerTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Customer", True))
        Me.CustomerTextBox1.Location = New System.Drawing.Point(182, 338)
        Me.CustomerTextBox1.Name = "CustomerTextBox1"
        Me.CustomerTextBox1.Size = New System.Drawing.Size(90, 20)
        Me.CustomerTextBox1.TabIndex = 43
        Me.CustomerTextBox1.TabStop = False
        Me.CustomerTextBox1.Visible = False
        '
        'LastPaymentDateTextBox
        '
        Me.LastPaymentDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastPaymentDate", True))
        Me.LastPaymentDateTextBox.Location = New System.Drawing.Point(262, 312)
        Me.LastPaymentDateTextBox.Name = "LastPaymentDateTextBox"
        Me.LastPaymentDateTextBox.Size = New System.Drawing.Size(99, 20)
        Me.LastPaymentDateTextBox.TabIndex = 45
        Me.LastPaymentDateTextBox.TabStop = False
        Me.LastPaymentDateTextBox.Visible = False
        '
        'LastPaymentTextBox
        '
        Me.LastPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastPayment", True))
        Me.LastPaymentTextBox.Location = New System.Drawing.Point(93, 312)
        Me.LastPaymentTextBox.Name = "LastPaymentTextBox"
        Me.LastPaymentTextBox.Size = New System.Drawing.Size(104, 20)
        Me.LastPaymentTextBox.TabIndex = 47
        Me.LastPaymentTextBox.TabStop = False
        Me.LastPaymentTextBox.Visible = False
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(355, 338)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(106, 20)
        Me.BalanceTextBox.TabIndex = 49
        Me.BalanceTextBox.TabStop = False
        Me.BalanceTextBox.Visible = False
        '
        'CreditTextBox
        '
        Me.CreditTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Credit", True))
        Me.CreditTextBox.Location = New System.Drawing.Point(440, 93)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditTextBox.TabIndex = 51
        Me.CreditTextBox.TabStop = False
        '
        'IdnumTextBox
        '
        Me.IdnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "idnum", True))
        Me.IdnumTextBox.Location = New System.Drawing.Point(455, 312)
        Me.IdnumTextBox.Name = "IdnumTextBox"
        Me.IdnumTextBox.Size = New System.Drawing.Size(112, 20)
        Me.IdnumTextBox.TabIndex = 53
        Me.IdnumTextBox.TabStop = False
        Me.IdnumTextBox.Visible = False
        '
        'ItemCodeTextBox
        '
        Me.ItemCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "ItemCode", True))
        Me.ItemCodeTextBox.Location = New System.Drawing.Point(133, 226)
        Me.ItemCodeTextBox.Name = "ItemCodeTextBox"
        Me.ItemCodeTextBox.Size = New System.Drawing.Size(132, 20)
        Me.ItemCodeTextBox.TabIndex = 54
        Me.ItemCodeTextBox.TabStop = False
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(17, 283)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(97, 23)
        Me.btnPay.TabIndex = 55
        Me.btnPay.Text = "Pay Invoice"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'AmtApplyTextBox
        '
        Me.AmtApplyTextBox.Location = New System.Drawing.Point(440, 197)
        Me.AmtApplyTextBox.Name = "AmtApplyTextBox"
        Me.AmtApplyTextBox.Size = New System.Drawing.Size(98, 20)
        Me.AmtApplyTextBox.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Amt to Apply"
        '
        'btnApplyCr
        '
        Me.btnApplyCr.Location = New System.Drawing.Point(564, 94)
        Me.btnApplyCr.Name = "btnApplyCr"
        Me.btnApplyCr.Size = New System.Drawing.Size(75, 23)
        Me.btnApplyCr.TabIndex = 58
        Me.btnApplyCr.Text = "Apply Credit"
        Me.btnApplyCr.UseVisualStyleBackColor = True
        Me.btnApplyCr.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Code"
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 329)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnApplyCr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmtApplyTextBox)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.ItemCodeTextBox)
        Me.Controls.Add(Me.CustomerTextBox1)
        Me.Controls.Add(Me.LastPaymentDateTextBox)
        Me.Controls.Add(Me.LastPaymentTextBox)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(CreditLabel)
        Me.Controls.Add(Me.CreditTextBox)
        Me.Controls.Add(Me.IdnumTextBox)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnApplyPayment)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(InvoiceLabel)
        Me.Controls.Add(Me.InvoiceTextBox)
        Me.Controls.Add(InvDateLabel)
        Me.Controls.Add(Me.InvDateTextBox)
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
        Me.Controls.Add(Me.DatePaidTextBox)
        Me.Controls.Add(RefLabel)
        Me.Controls.Add(Me.RefTextBox)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.InvoicesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayments"
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
    Friend WithEvents InvAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmtPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatePaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnApplyPayment As System.Windows.Forms.Button
    Friend WithEvents btnX As System.Windows.Forms.Button
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Invoice.PayInvoiceDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomerTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LastPaymentDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastPaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdnumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents AmtApplyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnApplyCr As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
