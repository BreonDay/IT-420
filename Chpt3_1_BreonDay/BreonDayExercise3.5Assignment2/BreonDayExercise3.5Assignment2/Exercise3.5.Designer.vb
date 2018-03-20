<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.YearsHeldTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InterestRateTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InvestmentTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FutureValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(15, 342)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(110, 35)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(137, 342)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 35)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(259, 342)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(110, 35)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(381, 342)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(110, 35)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.YearsHeldTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.InterestRateTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.InvestmentTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'YearsHeldTextBox
        '
        Me.YearsHeldTextBox.Location = New System.Drawing.Point(335, 54)
        Me.YearsHeldTextBox.Name = "YearsHeldTextBox"
        Me.YearsHeldTextBox.Size = New System.Drawing.Size(135, 29)
        Me.YearsHeldTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Years to hold:"
        '
        'InterestRateTextBox
        '
        Me.InterestRateTextBox.Location = New System.Drawing.Point(173, 54)
        Me.InterestRateTextBox.Name = "InterestRateTextBox"
        Me.InterestRateTextBox.Size = New System.Drawing.Size(135, 29)
        Me.InterestRateTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Interest Rate:"
        '
        'InvestmentTextBox
        '
        Me.InvestmentTextBox.Location = New System.Drawing.Point(7, 54)
        Me.InvestmentTextBox.Name = "InvestmentTextBox"
        Me.InvestmentTextBox.Size = New System.Drawing.Size(135, 29)
        Me.InvestmentTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Investment:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FutureValueTextBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 121)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'FutureValueTextBox
        '
        Me.FutureValueTextBox.Location = New System.Drawing.Point(152, 71)
        Me.FutureValueTextBox.Name = "FutureValueTextBox"
        Me.FutureValueTextBox.ReadOnly = True
        Me.FutureValueTextBox.Size = New System.Drawing.Size(174, 29)
        Me.FutureValueTextBox.TabIndex = 1
        Me.FutureValueTextBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Future Value"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 395)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interest Rate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents YearsHeldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InterestRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InvestmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FutureValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
