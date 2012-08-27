<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlyStatements
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
        Me.txtInvNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelProcessMonthlyInvoices = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInvMonth = New System.Windows.Forms.Label()
        Me.lblInvDate = New System.Windows.Forms.Label()
        Me.lblInvNum = New System.Windows.Forms.Label()
        Me.txtInvMonth = New System.Windows.Forms.ComboBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonProcess = New System.Windows.Forms.Button()
        Me.txtInvDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtInvNum
        '
        Me.txtInvNum.Location = New System.Drawing.Point(278, 138)
        Me.txtInvNum.Name = "txtInvNum"
        Me.txtInvNum.Size = New System.Drawing.Size(88, 20)
        Me.txtInvNum.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Please Enter the Following Information to Process Monthly Statements"
        '
        'LabelProcessMonthlyInvoices
        '
        Me.LabelProcessMonthlyInvoices.AutoSize = True
        Me.LabelProcessMonthlyInvoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProcessMonthlyInvoices.Location = New System.Drawing.Point(136, 37)
        Me.LabelProcessMonthlyInvoices.Name = "LabelProcessMonthlyInvoices"
        Me.LabelProcessMonthlyInvoices.Size = New System.Drawing.Size(266, 16)
        Me.LabelProcessMonthlyInvoices.TabIndex = 7
        Me.LabelProcessMonthlyInvoices.Text = "Process Monthly Statements/Invoices"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Beginning Invoice Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Invoice Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Invoice Date (mm/dd/yyyy)"
        '
        'lblInvMonth
        '
        Me.lblInvMonth.AutoSize = True
        Me.lblInvMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvMonth.ForeColor = System.Drawing.Color.DarkRed
        Me.lblInvMonth.Location = New System.Drawing.Point(372, 197)
        Me.lblInvMonth.Name = "lblInvMonth"
        Me.lblInvMonth.Size = New System.Drawing.Size(65, 13)
        Me.lblInvMonth.TabIndex = 14
        Me.lblInvMonth.Text = "Enter Month"
        Me.lblInvMonth.Visible = False
        '
        'lblInvDate
        '
        Me.lblInvDate.AutoSize = True
        Me.lblInvDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvDate.ForeColor = System.Drawing.Color.DarkRed
        Me.lblInvDate.Location = New System.Drawing.Point(372, 168)
        Me.lblInvDate.Name = "lblInvDate"
        Me.lblInvDate.Size = New System.Drawing.Size(58, 13)
        Me.lblInvDate.TabIndex = 13
        Me.lblInvDate.Text = "Enter Date"
        Me.lblInvDate.Visible = False
        '
        'lblInvNum
        '
        Me.lblInvNum.AutoSize = True
        Me.lblInvNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNum.ForeColor = System.Drawing.Color.DarkRed
        Me.lblInvNum.Location = New System.Drawing.Point(372, 142)
        Me.lblInvNum.Name = "lblInvNum"
        Me.lblInvNum.Size = New System.Drawing.Size(72, 13)
        Me.lblInvNum.TabIndex = 12
        Me.lblInvNum.Text = "Enter Number"
        Me.lblInvNum.Visible = False
        '
        'txtInvMonth
        '
        Me.txtInvMonth.FormattingEnabled = True
        Me.txtInvMonth.Items.AddRange(New Object() {"", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.txtInvMonth.Location = New System.Drawing.Point(278, 193)
        Me.txtInvMonth.Name = "txtInvMonth"
        Me.txtInvMonth.Size = New System.Drawing.Size(88, 21)
        Me.txtInvMonth.TabIndex = 15
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(277, 248)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(89, 23)
        Me.ButtonCancel.TabIndex = 17
        Me.ButtonCancel.Text = "Close"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonProcess
        '
        Me.ButtonProcess.Location = New System.Drawing.Point(165, 248)
        Me.ButtonProcess.Name = "ButtonProcess"
        Me.ButtonProcess.Size = New System.Drawing.Size(91, 23)
        Me.ButtonProcess.TabIndex = 16
        Me.ButtonProcess.Text = "Process"
        Me.ButtonProcess.UseVisualStyleBackColor = True
        '
        'txtInvDate
        '
        Me.txtInvDate.Location = New System.Drawing.Point(278, 164)
        Me.txtInvDate.Name = "txtInvDate"
        Me.txtInvDate.Size = New System.Drawing.Size(88, 20)
        Me.txtInvDate.TabIndex = 5
        Me.txtInvDate.Tag = ""
        '
        'frmMonthlyStatements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 316)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonProcess)
        Me.Controls.Add(Me.txtInvMonth)
        Me.Controls.Add(Me.lblInvMonth)
        Me.Controls.Add(Me.lblInvDate)
        Me.Controls.Add(Me.lblInvNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelProcessMonthlyInvoices)
        Me.Controls.Add(Me.txtInvDate)
        Me.Controls.Add(Me.txtInvNum)
        Me.Name = "frmMonthlyStatements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Monthly Statements"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInvNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelProcessMonthlyInvoices As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblInvMonth As System.Windows.Forms.Label
    Friend WithEvents lblInvDate As System.Windows.Forms.Label
    Friend WithEvents lblInvNum As System.Windows.Forms.Label
    Friend WithEvents txtInvMonth As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonProcess As System.Windows.Forms.Button
    Friend WithEvents txtInvDate As System.Windows.Forms.TextBox
End Class
