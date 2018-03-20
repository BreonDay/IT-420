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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MemSizeTextBox = New System.Windows.Forms.TextBox()
        Me.HardDriveSizeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CpuSpeedTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BrandInfoTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StoreButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MissingInputLabel = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.ReadNextButton = New System.Windows.Forms.Button()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Memory Size"
        '
        'MemSizeTextBox
        '
        Me.MemSizeTextBox.Location = New System.Drawing.Point(16, 60)
        Me.MemSizeTextBox.Name = "MemSizeTextBox"
        Me.MemSizeTextBox.Size = New System.Drawing.Size(318, 20)
        Me.MemSizeTextBox.TabIndex = 1
        '
        'HardDriveSizeTextBox
        '
        Me.HardDriveSizeTextBox.Location = New System.Drawing.Point(16, 109)
        Me.HardDriveSizeTextBox.Name = "HardDriveSizeTextBox"
        Me.HardDriveSizeTextBox.Size = New System.Drawing.Size(318, 20)
        Me.HardDriveSizeTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hard Drive Size"
        '
        'CpuSpeedTextBox
        '
        Me.CpuSpeedTextBox.Location = New System.Drawing.Point(16, 161)
        Me.CpuSpeedTextBox.Name = "CpuSpeedTextBox"
        Me.CpuSpeedTextBox.Size = New System.Drawing.Size(318, 20)
        Me.CpuSpeedTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cpu Speed"
        '
        'BrandInfoTextBox
        '
        Me.BrandInfoTextBox.Location = New System.Drawing.Point(16, 216)
        Me.BrandInfoTextBox.Name = "BrandInfoTextBox"
        Me.BrandInfoTextBox.Size = New System.Drawing.Size(318, 20)
        Me.BrandInfoTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Brand Information"
        '
        'StoreButton
        '
        Me.StoreButton.Location = New System.Drawing.Point(16, 247)
        Me.StoreButton.Name = "StoreButton"
        Me.StoreButton.Size = New System.Drawing.Size(75, 23)
        Me.StoreButton.TabIndex = 8
        Me.StoreButton.Text = "&Store"
        Me.StoreButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(97, 247)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 9
        Me.NextButton.Text = "&Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(340, 247)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MissingInputLabel
        '
        Me.MissingInputLabel.AutoSize = True
        Me.MissingInputLabel.ForeColor = System.Drawing.Color.Red
        Me.MissingInputLabel.Location = New System.Drawing.Point(210, 11)
        Me.MissingInputLabel.Name = "MissingInputLabel"
        Me.MissingInputLabel.Size = New System.Drawing.Size(69, 13)
        Me.MissingInputLabel.TabIndex = 11
        Me.MissingInputLabel.Text = "Missing Input"
        Me.MissingInputLabel.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Open File to Read"
        '
        'ReadButton
        '
        Me.ReadButton.Location = New System.Drawing.Point(178, 247)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(75, 23)
        Me.ReadButton.TabIndex = 12
        Me.ReadButton.Text = "&Read File"
        Me.ReadButton.UseVisualStyleBackColor = True
        '
        'ReadNextButton
        '
        Me.ReadNextButton.Location = New System.Drawing.Point(259, 247)
        Me.ReadNextButton.Name = "ReadNextButton"
        Me.ReadNextButton.Size = New System.Drawing.Size(75, 23)
        Me.ReadNextButton.TabIndex = 13
        Me.ReadNextButton.Text = "R&ead Next"
        Me.ReadNextButton.UseVisualStyleBackColor = True
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(351, 39)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.ReadOnly = True
        Me.UserTextBox.Size = New System.Drawing.Size(75, 20)
        Me.UserTextBox.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "User#"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 282)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ReadNextButton)
        Me.Controls.Add(Me.ReadButton)
        Me.Controls.Add(Me.MissingInputLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.StoreButton)
        Me.Controls.Add(Me.BrandInfoTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CpuSpeedTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HardDriveSizeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MemSizeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MemSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HardDriveSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CpuSpeedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BrandInfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StoreButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents MissingInputLabel As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ReadButton As System.Windows.Forms.Button
    Friend WithEvents ReadNextButton As System.Windows.Forms.Button
    Friend WithEvents UserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
