<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayInvoice
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
        Dim InvoiceLabel As System.Windows.Forms.Label
        Dim InvAmtLabel As System.Windows.Forms.Label
        Dim BalDueLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayInvoice))
        Me.PayInvoiceDataSet = New Invoice.PayInvoiceDataSet()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesTableAdapter = New Invoice.PayInvoiceDataSetTableAdapters.InvoicesTableAdapter()
        Me.TableAdapterManager = New Invoice.PayInvoiceDataSetTableAdapters.TableAdapterManager()
        Me.PaymentsTableAdapter = New Invoice.PayInvoiceDataSetTableAdapters.PaymentsTableAdapter()
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
        Me.InvoicesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Invoice.PayInvoiceDataSetTableAdapters.CustomersTableAdapter()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.AmtPaidTextBox = New System.Windows.Forms.TextBox()
        Me.DatePaidDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnApplyCredit = New System.Windows.Forms.Button()
        Me.InvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.txtAcctBal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.btnSavePayment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPay1 = New System.Windows.Forms.TextBox()
        Me.InvAmtTextBox = New System.Windows.Forms.TextBox()
        Me.BalDueTextBox = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TxtPay2 = New System.Windows.Forms.TextBox()
        RefLabel = New System.Windows.Forms.Label()
        AmtPaidLabel = New System.Windows.Forms.Label()
        DatePaidLabel = New System.Windows.Forms.Label()
        InvoiceLabel = New System.Windows.Forms.Label()
        InvAmtLabel = New System.Windows.Forms.Label()
        BalDueLabel = New System.Windows.Forms.Label()
        CType(Me.PayInvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicesBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.InvoicesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RefLabel
        '
        RefLabel.AutoSize = True
        RefLabel.Location = New System.Drawing.Point(822, 165)
        RefLabel.Name = "RefLabel"
        RefLabel.Size = New System.Drawing.Size(57, 13)
        RefLabel.TabIndex = 5
        RefLabel.Text = "Reference"
        '
        'AmtPaidLabel
        '
        AmtPaidLabel.AutoSize = True
        AmtPaidLabel.Location = New System.Drawing.Point(813, 269)
        AmtPaidLabel.Name = "AmtPaidLabel"
        AmtPaidLabel.Size = New System.Drawing.Size(67, 13)
        AmtPaidLabel.TabIndex = 7
        AmtPaidLabel.Text = "Amount Paid"
        '
        'DatePaidLabel
        '
        DatePaidLabel.AutoSize = True
        DatePaidLabel.Location = New System.Drawing.Point(826, 193)
        DatePaidLabel.Name = "DatePaidLabel"
        DatePaidLabel.Size = New System.Drawing.Size(54, 13)
        DatePaidLabel.TabIndex = 9
        DatePaidLabel.Text = "Date Paid"
        '
        'InvoiceLabel
        '
        InvoiceLabel.AutoSize = True
        InvoiceLabel.Location = New System.Drawing.Point(794, 51)
        InvoiceLabel.Name = "InvoiceLabel"
        InvoiceLabel.Size = New System.Drawing.Size(82, 13)
        InvoiceLabel.TabIndex = 14
        InvoiceLabel.Text = "Invoice Number"
        '
        'InvAmtLabel
        '
        InvAmtLabel.AutoSize = True
        InvAmtLabel.Location = New System.Drawing.Point(799, 103)
        InvAmtLabel.Name = "InvAmtLabel"
        InvAmtLabel.Size = New System.Drawing.Size(81, 13)
        InvAmtLabel.TabIndex = 21
        InvAmtLabel.Text = "Invoice Amount"
        '
        'BalDueLabel
        '
        BalDueLabel.AutoSize = True
        BalDueLabel.Location = New System.Drawing.Point(819, 243)
        BalDueLabel.Name = "BalDueLabel"
        BalDueLabel.Size = New System.Drawing.Size(60, 13)
        BalDueLabel.TabIndex = 22
        BalDueLabel.Text = "Invoice Bal"
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
        Me.TableAdapterManager.PaymentsTableAdapter = Me.PaymentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Invoice.PayInvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
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
        Me.FillToolStrip.Size = New System.Drawing.Size(1010, 25)
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
        'InvoicesDataGridView
        '
        Me.InvoicesDataGridView.AutoGenerateColumns = False
        Me.InvoicesDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.InvoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoicesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.InvoicesDataGridView.DataSource = Me.InvoicesBindingSource
        Me.InvoicesDataGridView.Location = New System.Drawing.Point(0, 53)
        Me.InvoicesDataGridView.Name = "InvoicesDataGridView"
        Me.InvoicesDataGridView.Size = New System.Drawing.Size(773, 369)
        Me.InvoicesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Customer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 76
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Invoice"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Invoice"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 67
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "InvDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "InvDate"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Service"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Service"
        Me.DataGridViewTextBoxColumn7.MaxInputLength = 55
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Company"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "InvAmt"
        Me.DataGridViewTextBoxColumn5.HeaderText = "InvAmt"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "AmtPaid"
        Me.DataGridViewTextBoxColumn8.HeaderText = "AmtPaid"
        Me.DataGridViewTextBoxColumn8.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 71
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BalDue"
        Me.DataGridViewTextBoxColumn6.HeaderText = "BalDue"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 67
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DatePaid"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DatePaid"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Ref"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ref"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ItemCode"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ItemCode"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idnum"
        Me.DataGridViewTextBoxColumn12.HeaderText = "idnum"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
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
        'CreditTextBox
        '
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Credit", True))
        Me.CreditTextBox.Location = New System.Drawing.Point(896, 74)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.ReadOnly = True
        Me.CreditTextBox.Size = New System.Drawing.Size(84, 20)
        Me.CreditTextBox.TabIndex = 4
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.PayInvoiceDataSet
        '
        'RefTextBox
        '
        Me.RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Ref", True))
        Me.RefTextBox.Location = New System.Drawing.Point(896, 162)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.Size = New System.Drawing.Size(84, 20)
        Me.RefTextBox.TabIndex = 6
        '
        'AmtPaidTextBox
        '
        Me.AmtPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "AmtPaid", True))
        Me.AmtPaidTextBox.Location = New System.Drawing.Point(792, 28)
        Me.AmtPaidTextBox.Name = "AmtPaidTextBox"
        Me.AmtPaidTextBox.ReadOnly = True
        Me.AmtPaidTextBox.Size = New System.Drawing.Size(84, 20)
        Me.AmtPaidTextBox.TabIndex = 8
        '
        'DatePaidDateTimePicker
        '
        Me.DatePaidDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentsBindingSource, "DatePaid", True))
        Me.DatePaidDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePaidDateTimePicker.Location = New System.Drawing.Point(896, 187)
        Me.DatePaidDateTimePicker.Name = "DatePaidDateTimePicker"
        Me.DatePaidDateTimePicker.Size = New System.Drawing.Size(84, 20)
        Me.DatePaidDateTimePicker.TabIndex = 12
        '
        'btnApplyCredit
        '
        Me.btnApplyCredit.Location = New System.Drawing.Point(794, 72)
        Me.btnApplyCredit.Name = "btnApplyCredit"
        Me.btnApplyCredit.Size = New System.Drawing.Size(86, 23)
        Me.btnApplyCredit.TabIndex = 13
        Me.btnApplyCredit.Text = "Apply Credit"
        Me.btnApplyCredit.UseVisualStyleBackColor = True
        '
        'InvoiceTextBox
        '
        Me.InvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Invoice", True))
        Me.InvoiceTextBox.Location = New System.Drawing.Point(896, 48)
        Me.InvoiceTextBox.Name = "InvoiceTextBox"
        Me.InvoiceTextBox.ReadOnly = True
        Me.InvoiceTextBox.Size = New System.Drawing.Size(81, 20)
        Me.InvoiceTextBox.TabIndex = 15
        '
        'txtAcctBal
        '
        Me.txtAcctBal.Location = New System.Drawing.Point(896, 312)
        Me.txtAcctBal.Name = "txtAcctBal"
        Me.txtAcctBal.ReadOnly = True
        Me.txtAcctBal.Size = New System.Drawing.Size(84, 20)
        Me.txtAcctBal.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(791, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Account Balance"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(815, 77)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(34, 13)
        Me.lblCredit.TabIndex = 18
        Me.lblCredit.Text = "Credit"
        '
        'btnSavePayment
        '
        Me.btnSavePayment.Location = New System.Drawing.Point(801, 359)
        Me.btnSavePayment.Name = "btnSavePayment"
        Me.btnSavePayment.Size = New System.Drawing.Size(176, 23)
        Me.btnSavePayment.TabIndex = 19
        Me.btnSavePayment.Text = "Apply Payment"
        Me.btnSavePayment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(832, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Payment"
        '
        'txtPay1
        '
        Me.txtPay1.Location = New System.Drawing.Point(896, 214)
        Me.txtPay1.Name = "txtPay1"
        Me.txtPay1.Size = New System.Drawing.Size(84, 20)
        Me.txtPay1.TabIndex = 21
        '
        'InvAmtTextBox
        '
        Me.InvAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvAmt", True))
        Me.InvAmtTextBox.Location = New System.Drawing.Point(896, 100)
        Me.InvAmtTextBox.Name = "InvAmtTextBox"
        Me.InvAmtTextBox.ReadOnly = True
        Me.InvAmtTextBox.Size = New System.Drawing.Size(84, 20)
        Me.InvAmtTextBox.TabIndex = 22
        '
        'BalDueTextBox
        '
        Me.BalDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "BalDue", True))
        Me.BalDueTextBox.Location = New System.Drawing.Point(896, 240)
        Me.BalDueTextBox.Name = "BalDueTextBox"
        Me.BalDueTextBox.ReadOnly = True
        Me.BalDueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.BalDueTextBox.TabIndex = 23
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(804, 399)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(176, 23)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close "
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TxtPay2
        '
        Me.TxtPay2.Location = New System.Drawing.Point(896, 267)
        Me.TxtPay2.Name = "TxtPay2"
        Me.TxtPay2.ReadOnly = True
        Me.TxtPay2.Size = New System.Drawing.Size(84, 20)
        Me.TxtPay2.TabIndex = 25
        '
        'PayInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 442)
        Me.Controls.Add(Me.TxtPay2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(BalDueLabel)
        Me.Controls.Add(Me.BalDueTextBox)
        Me.Controls.Add(InvAmtLabel)
        Me.Controls.Add(Me.InvAmtTextBox)
        Me.Controls.Add(Me.txtPay1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSavePayment)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAcctBal)
        Me.Controls.Add(InvoiceLabel)
        Me.Controls.Add(Me.InvoiceTextBox)
        Me.Controls.Add(Me.btnApplyCredit)
        Me.Controls.Add(Me.DatePaidDateTimePicker)
        Me.Controls.Add(DatePaidLabel)
        Me.Controls.Add(AmtPaidLabel)
        Me.Controls.Add(Me.AmtPaidTextBox)
        Me.Controls.Add(RefLabel)
        Me.Controls.Add(Me.RefTextBox)
        Me.Controls.Add(Me.CreditTextBox)
        Me.Controls.Add(Me.InvoicesDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.InvoicesBindingNavigator)
        Me.Name = "PayInvoice"
        Me.Text = "PayInvoice"
        CType(Me.PayInvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoicesBindingNavigator.ResumeLayout(False)
        Me.InvoicesBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.InvoicesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents InvoicesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Invoice.PayInvoiceDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents PaymentsTableAdapter As Invoice.PayInvoiceDataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RefTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmtPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatePaidDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnApplyCredit As System.Windows.Forms.Button
    Friend WithEvents InvoiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtAcctBal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents btnSavePayment As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPay1 As System.Windows.Forms.TextBox
    Friend WithEvents InvAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtPay2 As System.Windows.Forms.TextBox
End Class
