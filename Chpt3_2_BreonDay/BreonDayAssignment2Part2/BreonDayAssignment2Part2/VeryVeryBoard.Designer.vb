<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VeryVeryBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VeryVeryBoard))
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SnowboardswBootsTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SnowBoardsTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.SnowBoardsValueWithBootsTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SnowBoardsValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TodaysAverageTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TodaysTotalCharges = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TodaysSnowBoardsWithBootsTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TodaysSnowboardTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(12, 345)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(102, 54)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "Calculate &order"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(120, 345)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(102, 54)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAllButton.Location = New System.Drawing.Point(228, 345)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(102, 54)
        Me.ClearAllButton.TabIndex = 2
        Me.ClearAllButton.Text = "Clear &All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(336, 345)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(102, 54)
        Me.PrintButton.TabIndex = 3
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(444, 345)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 54)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SnowboardswBootsTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.SnowBoardsTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'SnowboardswBootsTextBox
        '
        Me.SnowboardswBootsTextBox.Location = New System.Drawing.Point(12, 123)
        Me.SnowboardswBootsTextBox.Name = "SnowboardswBootsTextBox"
        Me.SnowboardswBootsTextBox.Size = New System.Drawing.Size(259, 22)
        Me.SnowboardswBootsTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Number of snowboards with boots"
        '
        'SnowBoardsTextBox
        '
        Me.SnowBoardsTextBox.Location = New System.Drawing.Point(11, 78)
        Me.SnowBoardsTextBox.Name = "SnowBoardsTextBox"
        Me.SnowBoardsTextBox.Size = New System.Drawing.Size(259, 22)
        Me.SnowBoardsTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of Snowboards"
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(13, 170)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(259, 22)
        Me.IdTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(12, 31)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(259, 22)
        Me.NameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id or driver's license #:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TotalTextBox)
        Me.GroupBox2.Controls.Add(Me.SnowBoardsValueWithBootsTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.SnowBoardsValueTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(288, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 197)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "customer total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(7, 169)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(252, 22)
        Me.TotalTextBox.TabIndex = 6
        Me.TotalTextBox.TabStop = False
        '
        'SnowBoardsValueWithBootsTextBox
        '
        Me.SnowBoardsValueWithBootsTextBox.Location = New System.Drawing.Point(6, 122)
        Me.SnowBoardsValueWithBootsTextBox.Name = "SnowBoardsValueWithBootsTextBox"
        Me.SnowBoardsValueWithBootsTextBox.ReadOnly = True
        Me.SnowBoardsValueWithBootsTextBox.Size = New System.Drawing.Size(253, 22)
        Me.SnowBoardsValueWithBootsTextBox.TabIndex = 5
        Me.SnowBoardsValueWithBootsTextBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "value of the snowboards with boots "
        '
        'SnowBoardsValueTextBox
        '
        Me.SnowBoardsValueTextBox.Location = New System.Drawing.Point(5, 77)
        Me.SnowBoardsValueTextBox.Name = "SnowBoardsValueTextBox"
        Me.SnowBoardsValueTextBox.ReadOnly = True
        Me.SnowBoardsValueTextBox.Size = New System.Drawing.Size(253, 22)
        Me.SnowBoardsValueTextBox.TabIndex = 3
        Me.SnowBoardsValueTextBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "value of the snowboards:"
        '
        'TodaysAverageTextBox
        '
        Me.TodaysAverageTextBox.Location = New System.Drawing.Point(275, 91)
        Me.TodaysAverageTextBox.Name = "TodaysAverageTextBox"
        Me.TodaysAverageTextBox.ReadOnly = True
        Me.TodaysAverageTextBox.Size = New System.Drawing.Size(207, 22)
        Me.TodaysAverageTextBox.TabIndex = 9
        Me.TodaysAverageTextBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(210, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Mean charges per customer : "
        '
        'TodaysTotalCharges
        '
        Me.TodaysTotalCharges.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodaysTotalCharges.Location = New System.Drawing.Point(12, 92)
        Me.TodaysTotalCharges.Name = "TodaysTotalCharges"
        Me.TodaysTotalCharges.ReadOnly = True
        Me.TodaysTotalCharges.Size = New System.Drawing.Size(206, 22)
        Me.TodaysTotalCharges.TabIndex = 7
        Me.TodaysTotalCharges.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Charges for the day:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TodaysAverageTextBox)
        Me.GroupBox3.Controls.Add(Me.TodaysSnowBoardsWithBootsTotalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TodaysTotalCharges)
        Me.GroupBox3.Controls.Add(Me.TodaysSnowboardTotalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(545, 131)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'TodaysSnowBoardsWithBootsTotalTextBox
        '
        Me.TodaysSnowBoardsWithBootsTotalTextBox.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodaysSnowBoardsWithBootsTotalTextBox.Location = New System.Drawing.Point(284, 39)
        Me.TodaysSnowBoardsWithBootsTotalTextBox.Name = "TodaysSnowBoardsWithBootsTotalTextBox"
        Me.TodaysSnowBoardsWithBootsTotalTextBox.ReadOnly = True
        Me.TodaysSnowBoardsWithBootsTotalTextBox.Size = New System.Drawing.Size(198, 22)
        Me.TodaysSnowBoardsWithBootsTotalTextBox.TabIndex = 9
        Me.TodaysSnowBoardsWithBootsTotalTextBox.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Snowboards with boots total:"
        '
        'TodaysSnowboardTotalTextBox
        '
        Me.TodaysSnowboardTotalTextBox.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodaysSnowboardTotalTextBox.Location = New System.Drawing.Point(13, 39)
        Me.TodaysSnowboardTotalTextBox.Name = "TodaysSnowboardTotalTextBox"
        Me.TodaysSnowboardTotalTextBox.ReadOnly = True
        Me.TodaysSnowboardTotalTextBox.Size = New System.Drawing.Size(205, 22)
        Me.TodaysSnowboardTotalTextBox.TabIndex = 7
        Me.TodaysSnowboardTotalTextBox.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Snowboards total for the day:"
        '
        'VeryVeryBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 415)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Name = "VeryVeryBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TodaysAverageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TodaysTotalCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SnowBoardsValueWithBootsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SnowBoardsValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SnowboardswBootsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SnowBoardsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TodaysSnowBoardsWithBootsTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TodaysSnowboardTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox

End Class
