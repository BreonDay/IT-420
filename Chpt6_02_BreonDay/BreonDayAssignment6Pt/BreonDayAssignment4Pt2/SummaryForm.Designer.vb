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
        Me.NumOrdersTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumShirtsTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumDollarsTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number Of Orders:"
        '
        'NumOrdersTextBox
        '
        Me.NumOrdersTextBox.Location = New System.Drawing.Point(124, 113)
        Me.NumOrdersTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumOrdersTextBox.Name = "NumOrdersTextBox"
        Me.NumOrdersTextBox.ReadOnly = True
        Me.NumOrdersTextBox.Size = New System.Drawing.Size(148, 24)
        Me.NumOrdersTextBox.TabIndex = 1
        Me.NumOrdersTextBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Here Is Your Order Summary"
        '
        'NumShirtsTextBox
        '
        Me.NumShirtsTextBox.Location = New System.Drawing.Point(124, 193)
        Me.NumShirtsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumShirtsTextBox.Name = "NumShirtsTextBox"
        Me.NumShirtsTextBox.ReadOnly = True
        Me.NumShirtsTextBox.Size = New System.Drawing.Size(148, 24)
        Me.NumShirtsTextBox.TabIndex = 4
        Me.NumShirtsTextBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number Of Shirts:"
        '
        'NumDollarsTextBox
        '
        Me.NumDollarsTextBox.Location = New System.Drawing.Point(124, 267)
        Me.NumDollarsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumDollarsTextBox.Name = "NumDollarsTextBox"
        Me.NumDollarsTextBox.ReadOnly = True
        Me.NumDollarsTextBox.Size = New System.Drawing.Size(148, 24)
        Me.NumDollarsTextBox.TabIndex = 6
        Me.NumDollarsTextBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dollar Total:"
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 336)
        Me.Controls.Add(Me.NumDollarsTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumShirtsTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumOrdersTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumOrdersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumShirtsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumDollarsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
