<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInvoice
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddInvoice))
        Me.MasterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddInvoicesDataSet = New Invoice.AddInvoicesDataSet()
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
        Me.MasterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MasterTableAdapter = New Invoice.AddInvoicesDataSetTableAdapters.MasterTableAdapter()
        Me.TableAdapterManager = New Invoice.AddInvoicesDataSetTableAdapters.TableAdapterManager()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.InvAmtTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.MasterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MasterBindingNavigator.SuspendLayout()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddInvoicesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(127, 83)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 15
        Label1.Text = "Customer"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(300, 83)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 13)
        Label2.TabIndex = 17
        Label2.Text = "Company"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(118, 145)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(63, 13)
        Label3.TabIndex = 19
        Label3.Text = "Invoice Amt"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(276, 145)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(87, 13)
        Label4.TabIndex = 21
        Label4.Text = "Pick up Location"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(433, 83)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 13)
        Label5.TabIndex = 23
        Label5.Text = "Item Code"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(459, 145)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(32, 13)
        Label6.TabIndex = 25
        Label6.Text = "Code"
        '
        'MasterBindingNavigator
        '
        Me.MasterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MasterBindingNavigator.BindingSource = Me.MasterBindingSource
        Me.MasterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MasterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MasterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MasterBindingNavigatorSaveItem})
        Me.MasterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MasterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MasterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MasterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MasterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MasterBindingNavigator.Name = "MasterBindingNavigator"
        Me.MasterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MasterBindingNavigator.Size = New System.Drawing.Size(636, 25)
        Me.MasterBindingNavigator.TabIndex = 0
        Me.MasterBindingNavigator.Text = "BindingNavigator1"
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
        'MasterBindingSource
        '
        Me.MasterBindingSource.DataMember = "Master"
        Me.MasterBindingSource.DataSource = Me.AddInvoicesDataSet
        '
        'AddInvoicesDataSet
        '
        Me.AddInvoicesDataSet.DataSetName = "AddInvoicesDataSet"
        Me.AddInvoicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MasterBindingNavigatorSaveItem
        '
        Me.MasterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MasterBindingNavigatorSaveItem.Image = CType(resources.GetObject("MasterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MasterBindingNavigatorSaveItem.Name = "MasterBindingNavigatorSaveItem"
        Me.MasterBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MasterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(636, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'MasterTableAdapter
        '
        Me.MasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.MasterTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Invoice.AddInvoicesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(121, 99)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(57, 20)
        Me.CustomerTextBox.TabIndex = 27
        Me.CustomerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(184, 99)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(243, 20)
        Me.CompanyTextBox.TabIndex = 29
        Me.CompanyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InvAmtTextBox
        '
        Me.InvAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBindingSource, "InvAmt", True))
        Me.InvAmtTextBox.Location = New System.Drawing.Point(118, 161)
        Me.InvAmtTextBox.Name = "InvAmtTextBox"
        Me.InvAmtTextBox.Size = New System.Drawing.Size(60, 20)
        Me.InvAmtTextBox.TabIndex = 31
        Me.InvAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBindingSource, "Service", True))
        Me.ServiceTextBox.Location = New System.Drawing.Point(184, 161)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(270, 20)
        Me.ServiceTextBox.TabIndex = 33
        Me.ServiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ItemCodeTextBox
        '
        Me.ItemCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBindingSource, "ItemCode", True))
        Me.ItemCodeTextBox.Location = New System.Drawing.Point(433, 99)
        Me.ItemCodeTextBox.Name = "ItemCodeTextBox"
        Me.ItemCodeTextBox.Size = New System.Drawing.Size(55, 20)
        Me.ItemCodeTextBox.TabIndex = 35
        Me.ItemCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(460, 161)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(31, 20)
        Me.CodeTextBox.TabIndex = 37
        Me.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAddInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 253)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(Me.CompanyTextBox)
        Me.Controls.Add(Me.InvAmtTextBox)
        Me.Controls.Add(Me.ServiceTextBox)
        Me.Controls.Add(Me.ItemCodeTextBox)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.MasterBindingNavigator)
        Me.Name = "frmAddInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddInvoice"
        CType(Me.MasterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MasterBindingNavigator.ResumeLayout(False)
        Me.MasterBindingNavigator.PerformLayout()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddInvoicesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddInvoicesDataSet As Invoice.AddInvoicesDataSet
    Friend WithEvents MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterTableAdapter As Invoice.AddInvoicesDataSetTableAdapters.MasterTableAdapter
    Friend WithEvents TableAdapterManager As Invoice.AddInvoicesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MasterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
End Class
