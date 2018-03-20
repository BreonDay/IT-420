<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTesterForm
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
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrunePunchTextBox = New System.Windows.Forms.TextBox()
        Me.AppleAdeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(27, 258)
        Me.OkButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(129, 30)
        Me.OkButton.TabIndex = 3
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(253, 258)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(129, 30)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Prune Punch Score:"
        '
        'PrunePunchTextBox
        '
        Me.PrunePunchTextBox.Location = New System.Drawing.Point(27, 129)
        Me.PrunePunchTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PrunePunchTextBox.Name = "PrunePunchTextBox"
        Me.PrunePunchTextBox.Size = New System.Drawing.Size(146, 24)
        Me.PrunePunchTextBox.TabIndex = 1
        '
        'AppleAdeTextBox
        '
        Me.AppleAdeTextBox.Location = New System.Drawing.Point(253, 129)
        Me.AppleAdeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AppleAdeTextBox.Name = "AppleAdeTextBox"
        Me.AppleAdeTextBox.Size = New System.Drawing.Size(129, 24)
        Me.AppleAdeTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apple Ade Score:"
        '
        'NewTesterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 336)
        Me.Controls.Add(Me.AppleAdeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PrunePunchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.OkButton)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "NewTesterForm"
        Me.Text = "NewTesterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrunePunchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AppleAdeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
