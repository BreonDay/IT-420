<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hw2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hw2))
        Me.DowntownDisplayButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MallDisplayButton = New System.Windows.Forms.Button()
        Me.SuburbsDisplayButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DowntownHours = New System.Windows.Forms.Label()
        Me.DowntownLocation = New System.Windows.Forms.Label()
        Me.MallHours = New System.Windows.Forms.Label()
        Me.MallLocation = New System.Windows.Forms.Label()
        Me.SuburbHours = New System.Windows.Forms.Label()
        Me.SuburbLocation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DowntownDisplayButton
        '
        Me.DowntownDisplayButton.Location = New System.Drawing.Point(54, 70)
        Me.DowntownDisplayButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DowntownDisplayButton.Name = "DowntownDisplayButton"
        Me.DowntownDisplayButton.Size = New System.Drawing.Size(150, 37)
        Me.DowntownDisplayButton.TabIndex = 0
        Me.DowntownDisplayButton.Text = "Display"
        Me.DowntownDisplayButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(54, 347)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(150, 37)
        Me.PrintButton.TabIndex = 3
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(412, 347)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(150, 37)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(574, 379)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "by Breon Day"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MallDisplayButton
        '
        Me.MallDisplayButton.Location = New System.Drawing.Point(54, 142)
        Me.MallDisplayButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MallDisplayButton.Name = "MallDisplayButton"
        Me.MallDisplayButton.Size = New System.Drawing.Size(150, 37)
        Me.MallDisplayButton.TabIndex = 6
        Me.MallDisplayButton.Text = "Display"
        Me.MallDisplayButton.UseVisualStyleBackColor = True
        '
        'SuburbsDisplayButton
        '
        Me.SuburbsDisplayButton.Location = New System.Drawing.Point(54, 223)
        Me.SuburbsDisplayButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.SuburbsDisplayButton.Name = "SuburbsDisplayButton"
        Me.SuburbsDisplayButton.Size = New System.Drawing.Size(150, 37)
        Me.SuburbsDisplayButton.TabIndex = 7
        Me.SuburbsDisplayButton.Text = "Display"
        Me.SuburbsDisplayButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Downtown"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 231)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Suburbs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mall"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hours:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Store:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(521, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Location"
        '
        'DowntownHours
        '
        Me.DowntownHours.AutoSize = True
        Me.DowntownHours.Location = New System.Drawing.Point(339, 78)
        Me.DowntownHours.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.DowntownHours.Name = "DowntownHours"
        Me.DowntownHours.Size = New System.Drawing.Size(0, 22)
        Me.DowntownHours.TabIndex = 14
        '
        'DowntownLocation
        '
        Me.DowntownLocation.AutoSize = True
        Me.DowntownLocation.Location = New System.Drawing.Point(521, 78)
        Me.DowntownLocation.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.DowntownLocation.Name = "DowntownLocation"
        Me.DowntownLocation.Size = New System.Drawing.Size(0, 22)
        Me.DowntownLocation.TabIndex = 15
        '
        'MallHours
        '
        Me.MallHours.AutoSize = True
        Me.MallHours.Location = New System.Drawing.Point(339, 150)
        Me.MallHours.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MallHours.Name = "MallHours"
        Me.MallHours.Size = New System.Drawing.Size(0, 22)
        Me.MallHours.TabIndex = 16
        '
        'MallLocation
        '
        Me.MallLocation.AutoSize = True
        Me.MallLocation.Location = New System.Drawing.Point(521, 150)
        Me.MallLocation.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MallLocation.Name = "MallLocation"
        Me.MallLocation.Size = New System.Drawing.Size(0, 22)
        Me.MallLocation.TabIndex = 17
        '
        'SuburbHours
        '
        Me.SuburbHours.AutoSize = True
        Me.SuburbHours.Location = New System.Drawing.Point(339, 231)
        Me.SuburbHours.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.SuburbHours.Name = "SuburbHours"
        Me.SuburbHours.Size = New System.Drawing.Size(0, 22)
        Me.SuburbHours.TabIndex = 18
        '
        'SuburbLocation
        '
        Me.SuburbLocation.AutoSize = True
        Me.SuburbLocation.Location = New System.Drawing.Point(521, 231)
        Me.SuburbLocation.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.SuburbLocation.Name = "SuburbLocation"
        Me.SuburbLocation.Size = New System.Drawing.Size(0, 22)
        Me.SuburbLocation.TabIndex = 19
        '
        'Hw2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 415)
        Me.Controls.Add(Me.SuburbLocation)
        Me.Controls.Add(Me.SuburbHours)
        Me.Controls.Add(Me.MallLocation)
        Me.Controls.Add(Me.MallHours)
        Me.Controls.Add(Me.DowntownLocation)
        Me.Controls.Add(Me.DowntownHours)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SuburbsDisplayButton)
        Me.Controls.Add(Me.MallDisplayButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DowntownDisplayButton)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Hw2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Very Very Boards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DowntownDisplayButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SuburbsDisplayButton As System.Windows.Forms.Button
    Friend WithEvents MallDisplayButton As System.Windows.Forms.Button
    Friend WithEvents SuburbLocation As System.Windows.Forms.Label
    Friend WithEvents SuburbHours As System.Windows.Forms.Label
    Friend WithEvents MallLocation As System.Windows.Forms.Label
    Friend WithEvents MallHours As System.Windows.Forms.Label
    Friend WithEvents DowntownLocation As System.Windows.Forms.Label
    Friend WithEvents DowntownHours As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
