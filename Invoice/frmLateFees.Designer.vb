<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLateFees
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
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.txtLateFeeRate = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLateFeeDate = New System.Windows.Forms.TextBox()
        Me.lblInvDate = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblInvRate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(75, 164)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(107, 23)
        Me.btnProcess.TabIndex = 12
        Me.btnProcess.Text = "Process Late Fees"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'txtLateFeeRate
        '
        Me.txtLateFeeRate.Location = New System.Drawing.Point(227, 107)
        Me.txtLateFeeRate.Name = "txtLateFeeRate"
        Me.txtLateFeeRate.Size = New System.Drawing.Size(69, 20)
        Me.txtLateFeeRate.TabIndex = 14
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(188, 164)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Close Late Fees"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Late Fee Rate  1.5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Process Late Fee as of "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Process Late Fees"
        '
        'txtLateFeeDate
        '
        Me.txtLateFeeDate.Location = New System.Drawing.Point(228, 80)
        Me.txtLateFeeDate.Name = "txtLateFeeDate"
        Me.txtLateFeeDate.Size = New System.Drawing.Size(68, 20)
        Me.txtLateFeeDate.TabIndex = 18
        '
        'lblInvDate
        '
        Me.lblInvDate.AutoSize = True
        Me.lblInvDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvDate.ForeColor = System.Drawing.Color.DarkRed
        Me.lblInvDate.Location = New System.Drawing.Point(313, 83)
        Me.lblInvDate.Name = "lblInvDate"
        Me.lblInvDate.Size = New System.Drawing.Size(84, 13)
        Me.lblInvDate.TabIndex = 19
        Me.lblInvDate.Text = "Enter Valid Date"
        Me.lblInvDate.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 193)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(640, 322)
        Me.TextBox1.TabIndex = 20
        '
        'lblInvRate
        '
        Me.lblInvRate.AutoSize = True
        Me.lblInvRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvRate.ForeColor = System.Drawing.Color.DarkRed
        Me.lblInvRate.Location = New System.Drawing.Point(313, 110)
        Me.lblInvRate.Name = "lblInvRate"
        Me.lblInvRate.Size = New System.Drawing.Size(84, 13)
        Me.lblInvRate.TabIndex = 21
        Me.lblInvRate.Text = "Enter Valid Rate"
        Me.lblInvRate.Visible = False
        '
        'frmLateFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 527)
        Me.Controls.Add(Me.lblInvRate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblInvDate)
        Me.Controls.Add(Me.txtLateFeeDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.txtLateFeeRate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLateFees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Late Fees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents txtLateFeeRate As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLateFeeDate As System.Windows.Forms.TextBox
    Friend WithEvents lblInvDate As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblInvRate As System.Windows.Forms.Label
End Class
