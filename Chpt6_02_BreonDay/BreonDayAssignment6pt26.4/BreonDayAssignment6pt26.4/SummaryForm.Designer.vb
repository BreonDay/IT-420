<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.WinnerTextBox = New System.Windows.Forms.TextBox()
        Me.PPAverageTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AAAverageTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalTestersTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 224)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Winner:"
        '
        'WinnerTextBox
        '
        Me.WinnerTextBox.Location = New System.Drawing.Point(18, 245)
        Me.WinnerTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WinnerTextBox.Name = "WinnerTextBox"
        Me.WinnerTextBox.ReadOnly = True
        Me.WinnerTextBox.Size = New System.Drawing.Size(166, 24)
        Me.WinnerTextBox.TabIndex = 1
        Me.WinnerTextBox.TabStop = False
        '
        'PPAverageTextBox
        '
        Me.PPAverageTextBox.Location = New System.Drawing.Point(10, 114)
        Me.PPAverageTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PPAverageTextBox.Name = "PPAverageTextBox"
        Me.PPAverageTextBox.ReadOnly = True
        Me.PPAverageTextBox.Size = New System.Drawing.Size(175, 24)
        Me.PPAverageTextBox.TabIndex = 3
        Me.PPAverageTextBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prune Punch Average:"
        '
        'AAAverageTextBox
        '
        Me.AAAverageTextBox.Location = New System.Drawing.Point(18, 179)
        Me.AAAverageTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AAAverageTextBox.Name = "AAAverageTextBox"
        Me.AAAverageTextBox.ReadOnly = True
        Me.AAAverageTextBox.Size = New System.Drawing.Size(168, 24)
        Me.AAAverageTextBox.TabIndex = 5
        Me.AAAverageTextBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "AppleAdeAverage"
        '
        'TotalTestersTextBox
        '
        Me.TotalTestersTextBox.Location = New System.Drawing.Point(18, 42)
        Me.TotalTestersTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalTestersTextBox.Name = "TotalTestersTextBox"
        Me.TotalTestersTextBox.ReadOnly = True
        Me.TotalTestersTextBox.Size = New System.Drawing.Size(166, 24)
        Me.TotalTestersTextBox.TabIndex = 7
        Me.TotalTestersTextBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TotalTesters"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(250, 290)
        Me.OkButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(112, 30)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 336)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.TotalTestersTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AAAverageTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PPAverageTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WinnerTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WinnerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PPAverageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AAAverageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalTestersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OkButton As System.Windows.Forms.Button
End Class
