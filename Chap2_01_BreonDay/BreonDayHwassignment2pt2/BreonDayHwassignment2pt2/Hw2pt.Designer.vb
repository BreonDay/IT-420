<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hw2pt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hw2pt))
        Me.CompanyNameLabel = New System.Windows.Forms.Label()
        Me.SloganLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BlackRadioButton = New System.Windows.Forms.RadioButton()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.RedRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgrammerCheckBox = New System.Windows.Forms.CheckBox()
        Me.LogoCheckBox = New System.Windows.Forms.CheckBox()
        Me.SloganCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompanyNameCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompanyNameLabel
        '
        Me.CompanyNameLabel.AutoSize = True
        Me.CompanyNameLabel.Location = New System.Drawing.Point(160, 48)
        Me.CompanyNameLabel.Name = "CompanyNameLabel"
        Me.CompanyNameLabel.Size = New System.Drawing.Size(140, 22)
        Me.CompanyNameLabel.TabIndex = 0
        Me.CompanyNameLabel.Text = "Summer Surf"
        Me.ToolTip1.SetToolTip(Me.CompanyNameLabel, "Our company name")
        '
        'SloganLabel
        '
        Me.SloganLabel.AutoSize = True
        Me.SloganLabel.ForeColor = System.Drawing.Color.Red
        Me.SloganLabel.Location = New System.Drawing.Point(46, 108)
        Me.SloganLabel.Name = "SloganLabel"
        Me.SloganLabel.Size = New System.Drawing.Size(447, 22)
        Me.SloganLabel.TabIndex = 1
        Me.SloganLabel.Text = "Catch the perfect waves in the Summer Surf"
        Me.ToolTip1.SetToolTip(Me.SloganLabel, "Our Slogan")
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.BreonDayHwassignment2pt2.My.Resources.Resources.surfing_vector_drawing_represents_design_39256790
        Me.LogoPictureBox.Location = New System.Drawing.Point(361, 10)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(191, 95)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 2
        Me.LogoPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LogoPictureBox, "Our logo")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BlackRadioButton)
        Me.GroupBox1.Controls.Add(Me.GreenRadioButton)
        Me.GroupBox1.Controls.Add(Me.BlueRadioButton)
        Me.GroupBox1.Controls.Add(Me.RedRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 209)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Slogan Color"
        '
        'BlackRadioButton
        '
        Me.BlackRadioButton.AutoSize = True
        Me.BlackRadioButton.Location = New System.Drawing.Point(7, 177)
        Me.BlackRadioButton.Name = "BlackRadioButton"
        Me.BlackRadioButton.Size = New System.Drawing.Size(83, 26)
        Me.BlackRadioButton.TabIndex = 3
        Me.BlackRadioButton.Text = "Blac&k"
        Me.ToolTip1.SetToolTip(Me.BlackRadioButton, "Change the slogans color to black")
        Me.BlackRadioButton.UseVisualStyleBackColor = True
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.Location = New System.Drawing.Point(7, 136)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(86, 26)
        Me.GreenRadioButton.TabIndex = 2
        Me.GreenRadioButton.Text = "&Green"
        Me.ToolTip1.SetToolTip(Me.GreenRadioButton, "Change the slogans color to green")
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.Location = New System.Drawing.Point(6, 93)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(71, 26)
        Me.BlueRadioButton.TabIndex = 1
        Me.BlueRadioButton.Text = "&Blue"
        Me.ToolTip1.SetToolTip(Me.BlueRadioButton, "Change the slogans color to blue")
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'RedRadioButton
        '
        Me.RedRadioButton.AutoSize = True
        Me.RedRadioButton.Checked = True
        Me.RedRadioButton.Location = New System.Drawing.Point(7, 49)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(67, 26)
        Me.RedRadioButton.TabIndex = 0
        Me.RedRadioButton.TabStop = True
        Me.RedRadioButton.Text = "&Red"
        Me.ToolTip1.SetToolTip(Me.RedRadioButton, "Change the slogans color to red")
        Me.RedRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgrammerCheckBox)
        Me.GroupBox2.Controls.Add(Me.LogoCheckBox)
        Me.GroupBox2.Controls.Add(Me.SloganCheckBox)
        Me.GroupBox2.Controls.Add(Me.CompanyNameCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(235, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 209)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display"
        '
        'ProgrammerCheckBox
        '
        Me.ProgrammerCheckBox.AutoSize = True
        Me.ProgrammerCheckBox.Checked = True
        Me.ProgrammerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProgrammerCheckBox.Location = New System.Drawing.Point(6, 178)
        Me.ProgrammerCheckBox.Name = "ProgrammerCheckBox"
        Me.ProgrammerCheckBox.Size = New System.Drawing.Size(152, 26)
        Me.ProgrammerCheckBox.TabIndex = 3
        Me.ProgrammerCheckBox.Text = "Programmer"
        Me.ProgrammerCheckBox.UseVisualStyleBackColor = True
        '
        'LogoCheckBox
        '
        Me.LogoCheckBox.AutoSize = True
        Me.LogoCheckBox.Checked = True
        Me.LogoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LogoCheckBox.Location = New System.Drawing.Point(6, 137)
        Me.LogoCheckBox.Name = "LogoCheckBox"
        Me.LogoCheckBox.Size = New System.Drawing.Size(75, 26)
        Me.LogoCheckBox.TabIndex = 2
        Me.LogoCheckBox.Text = "Logo"
        Me.LogoCheckBox.UseVisualStyleBackColor = True
        '
        'SloganCheckBox
        '
        Me.SloganCheckBox.AutoSize = True
        Me.SloganCheckBox.Checked = True
        Me.SloganCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SloganCheckBox.Location = New System.Drawing.Point(6, 94)
        Me.SloganCheckBox.Name = "SloganCheckBox"
        Me.SloganCheckBox.Size = New System.Drawing.Size(93, 26)
        Me.SloganCheckBox.TabIndex = 1
        Me.SloganCheckBox.Text = "Slogan"
        Me.SloganCheckBox.UseVisualStyleBackColor = True
        '
        'CompanyNameCheckBox
        '
        Me.CompanyNameCheckBox.AutoSize = True
        Me.CompanyNameCheckBox.Checked = True
        Me.CompanyNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CompanyNameCheckBox.Location = New System.Drawing.Point(7, 50)
        Me.CompanyNameCheckBox.Name = "CompanyNameCheckBox"
        Me.CompanyNameCheckBox.Size = New System.Drawing.Size(174, 26)
        Me.CompanyNameCheckBox.TabIndex = 0
        Me.CompanyNameCheckBox.Text = "CompanyName"
        Me.CompanyNameCheckBox.UseVisualStyleBackColor = True
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Bookman Old Style", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.Location = New System.Drawing.Point(12, 390)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(189, 16)
        Me.ProgrammerLabel.TabIndex = 5
        Me.ProgrammerLabel.Text = "Programmed by:Breon Day"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(361, 369)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(74, 37)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(476, 369)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(74, 37)
        Me.ExitButton.TabIndex = 7
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
        'Hw2pt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 415)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.SloganLabel)
        Me.Controls.Add(Me.CompanyNameLabel)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Hw2pt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Very Very Boards"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompanyNameLabel As System.Windows.Forms.Label
    Friend WithEvents SloganLabel As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BlackRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GreenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BlueRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgrammerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LogoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SloganCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CompanyNameCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
