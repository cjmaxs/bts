<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickInvoice
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
        Dim ServiceLabel As System.Windows.Forms.Label
        Dim ItemCodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuickInvoice))
        Me.InvoicesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuickInvoiceDataSet = New Invoice.QuickInvoiceDataSet()
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
        Me.InvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.InvAmtTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCodeTextBox = New System.Windows.Forms.TextBox()
        Me.InvDateTextBox = New System.Windows.Forms.TextBox()
        Me.InvoicesTableAdapter = New Invoice.QuickInvoiceDataSetTableAdapters.InvoicesTableAdapter()
        Me.TableAdapterManager = New Invoice.QuickInvoiceDataSetTableAdapters.TableAdapterManager()
        InvoiceLabel = New System.Windows.Forms.Label()
        InvDateLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        CompanyLabel = New System.Windows.Forms.Label()
        InvAmtLabel = New System.Windows.Forms.Label()
        ServiceLabel = New System.Windows.Forms.Label()
        ItemCodeLabel = New System.Windows.Forms.Label()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicesBindingNavigator.SuspendLayout()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuickInvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceLabel
        '
        InvoiceLabel.AutoSize = True
        InvoiceLabel.Location = New System.Drawing.Point(166, 137)
        InvoiceLabel.Name = "InvoiceLabel"
        InvoiceLabel.Size = New System.Drawing.Size(85, 13)
        InvoiceLabel.TabIndex = 3
        InvoiceLabel.Text = "Invoice Number:"
        '
        'InvDateLabel
        '
        InvDateLabel.AutoSize = True
        InvDateLabel.Location = New System.Drawing.Point(75, 137)
        InvDateLabel.Name = "InvDateLabel"
        InvDateLabel.Size = New System.Drawing.Size(71, 13)
        InvDateLabel.TabIndex = 5
        InvDateLabel.Text = "Invoice Date:"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(55, 89)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(54, 13)
        CustomerLabel.TabIndex = 7
        CustomerLabel.Text = "Customer:"
        '
        'CompanyLabel
        '
        CompanyLabel.AutoSize = True
        CompanyLabel.Location = New System.Drawing.Point(205, 89)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(54, 13)
        CompanyLabel.TabIndex = 9
        CompanyLabel.Text = "Company:"
        '
        'InvAmtLabel
        '
        InvAmtLabel.AutoSize = True
        InvAmtLabel.Location = New System.Drawing.Point(499, 137)
        InvAmtLabel.Name = "InvAmtLabel"
        InvAmtLabel.Size = New System.Drawing.Size(81, 13)
        InvAmtLabel.TabIndex = 11
        InvAmtLabel.Text = "Invoice Amount"
        '
        'ServiceLabel
        '
        ServiceLabel.AutoSize = True
        ServiceLabel.Location = New System.Drawing.Point(322, 137)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New System.Drawing.Size(87, 13)
        ServiceLabel.TabIndex = 13
        ServiceLabel.Text = "Service Location"
        '
        'ItemCodeLabel
        '
        ItemCodeLabel.AutoSize = True
        ItemCodeLabel.Location = New System.Drawing.Point(605, 137)
        ItemCodeLabel.Name = "ItemCodeLabel"
        ItemCodeLabel.Size = New System.Drawing.Size(58, 13)
        ItemCodeLabel.TabIndex = 17
        ItemCodeLabel.Text = "Item Code:"
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
        Me.InvoicesBindingNavigator.Size = New System.Drawing.Size(763, 25)
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
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.QuickInvoiceDataSet
        '
        'QuickInvoiceDataSet
        '
        Me.QuickInvoiceDataSet.DataSetName = "QuickInvoiceDataSet"
        Me.QuickInvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'InvoiceTextBox
        '
        Me.InvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Invoice", True))
        Me.InvoiceTextBox.Location = New System.Drawing.Point(157, 153)
        Me.InvoiceTextBox.Name = "InvoiceTextBox"
        Me.InvoiceTextBox.Size = New System.Drawing.Size(94, 20)
        Me.InvoiceTextBox.TabIndex = 4
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(119, 86)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(69, 20)
        Me.CustomerTextBox.TabIndex = 8
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(265, 86)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(231, 20)
        Me.CompanyTextBox.TabIndex = 10
        '
        'InvAmtTextBox
        '
        Me.InvAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvAmt", True))
        Me.InvAmtTextBox.Location = New System.Drawing.Point(502, 153)
        Me.InvAmtTextBox.Name = "InvAmtTextBox"
        Me.InvAmtTextBox.Size = New System.Drawing.Size(81, 20)
        Me.InvAmtTextBox.TabIndex = 12
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Service", True))
        Me.ServiceTextBox.Location = New System.Drawing.Point(257, 153)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(239, 20)
        Me.ServiceTextBox.TabIndex = 14
        '
        'ItemCodeTextBox
        '
        Me.ItemCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "ItemCode", True))
        Me.ItemCodeTextBox.Location = New System.Drawing.Point(589, 153)
        Me.ItemCodeTextBox.Name = "ItemCodeTextBox"
        Me.ItemCodeTextBox.Size = New System.Drawing.Size(88, 20)
        Me.ItemCodeTextBox.TabIndex = 18
        '
        'InvDateTextBox
        '
        Me.InvDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "InvDate", True))
        Me.InvDateTextBox.Location = New System.Drawing.Point(58, 153)
        Me.InvDateTextBox.Name = "InvDateTextBox"
        Me.InvDateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.InvDateTextBox.TabIndex = 19
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Invoice.QuickInvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmQuickInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 258)
        Me.Controls.Add(Me.InvDateTextBox)
        Me.Controls.Add(InvoiceLabel)
        Me.Controls.Add(Me.InvoiceTextBox)
        Me.Controls.Add(InvDateLabel)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(CompanyLabel)
        Me.Controls.Add(Me.CompanyTextBox)
        Me.Controls.Add(InvAmtLabel)
        Me.Controls.Add(Me.InvAmtTextBox)
        Me.Controls.Add(ServiceLabel)
        Me.Controls.Add(Me.ServiceTextBox)
        Me.Controls.Add(ItemCodeLabel)
        Me.Controls.Add(Me.ItemCodeTextBox)
        Me.Controls.Add(Me.InvoicesBindingNavigator)
        Me.Name = "frmQuickInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Quick Invoice"
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoicesBindingNavigator.ResumeLayout(False)
        Me.InvoicesBindingNavigator.PerformLayout()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuickInvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuickInvoiceDataSet As Invoice.QuickInvoiceDataSet
    Friend WithEvents InvoicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicesTableAdapter As Invoice.QuickInvoiceDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents TableAdapterManager As Invoice.QuickInvoiceDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents InvoiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvDateTextBox As System.Windows.Forms.TextBox
End Class
