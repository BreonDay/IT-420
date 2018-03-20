'o	Project name:Hw Assignment 6 part 1
'o	Programmer name Breon Day
'o	Date:2/27/2016
'o	Description:shirt ordering form with menus and additional forms

Public Class VeryVeryBoards
    'global varibles
    Friend SummaryTotal As Integer
    Private Complete As Boolean

    Public NumOrders As Integer
    Friend NumShirts As Integer


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes the program
        Me.Close()
    End Sub

    Private Sub AddShirtsButton_Click(sender As Object, e As EventArgs) Handles AddShirtsButton.Click
        ' checks to see what size the user picked and what options they want with it to calculate the order adding it to a summary
        Dim Quantity As Integer
        Dim OrderPrice As Integer
        Dim Small As Integer = 10
        Dim Medium As Integer = 10
        Dim Large As Integer = 10
        Dim ExtraLarge As Integer = 11
        Dim XXL As Integer = 12
        Dim Monogramed = 2
        Dim HasPocket = 1
        Try
            Quantity = Integer.Parse(QuantityTextBox.Text)
            If (Quantity < 1) Then
                MessageBox.Show("Insufficient Quantity of shirts ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If (Quantity >= 1) Then
                NumOrders += 1
                NumShirts += Quantity
                CustomerNameTextBox.ReadOnly = True
                CustomerNameTextBox.TabStop = False
                OrderNumberTextBox.ReadOnly = True
                OrderNumberTextBox.TabStop = False
                If (SizeSmallRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (Small)

                End If

                If (SizeMediumRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (Medium)

                End If
                If (SizeLargeRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (Large)

                End If
                If (SizeExtraLargeRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (ExtraLarge)

                End If
                If (SizeXXLRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (XXL)

                End If

                If (MonogramedCheckBox.Checked = True) Then
                    OrderPrice += Quantity * Monogramed
                End If

                If (PocketCheckBox.Checked = True) Then
                    OrderPrice += Quantity * HasPocket

                End If

            End If
            OrderTotalTextBox.Text = OrderPrice
            SummaryTotal += OrderPrice
            SummaryTotalTextBox.Text = SummaryTotal
            'message box display code
        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  
    Private Sub ClearOrderButton_Click(sender As Object, e As EventArgs) Handles ClearOrderButton.Click
        ' clears the choices except the name and order number
        QuantityTextBox.Text = Nothing
        SizeSmallRadioButton.Checked = False
        SizeMediumRadioButton.Checked = False
        SizeLargeRadioButton.Checked = False
        SizeExtraLargeRadioButton.Checked = False
        SizeXXLRadioButton.Checked = False
        MonogramedCheckBox.Checked = False
        PocketCheckBox.Checked = False
    End Sub

    Private Sub CompleteButton_Click(sender As Object, e As EventArgs) Handles CompleteButton.Click
        'sets complete to true
        Complete = True
    End Sub

    
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
              ' checks to see if the order is complete the shows the final results on a summary form

        Dim buttonResult As DialogResult
        If (Complete = True) Then
            SummaryForm.ShowDialog()

            buttonResult = MessageBox.Show("would you like to start a new order?", "Summary?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (buttonResult = Windows.Forms.DialogResult.Yes) Then
                CustomerNameTextBox.Text = Nothing
                CustomerNameTextBox.ReadOnly = False
                CustomerNameTextBox.TabStop = True
                OrderNumberTextBox.Text = Nothing
                OrderNumberTextBox.ReadOnly = False
                OrderNumberTextBox.TabStop = True
                QuantityTextBox.Text = Nothing
                SizeSmallRadioButton.Checked = False
                SizeMediumRadioButton.Checked = False
                SizeLargeRadioButton.Checked = False
                SizeExtraLargeRadioButton.Checked = False
                SizeXXLRadioButton.Checked = False
                MonogramedCheckBox.Checked = False
                PocketCheckBox.Checked = False

                SummaryTotal = 0
                NumOrders = 0
                NumShirts = 0

            End If
        End If
        If (Complete = False) Then
            MessageBox.Show("Complete your order first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub


  
    Private Sub SloganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SloganToolStripMenuItem.Click

        If (SloganToolStripMenuItem.Checked) Then
            SloganLabel.Visible = False

            SloganToolStripMenuItem.Checked = False

        Else
            SloganLabel.Visible = True

            SloganToolStripMenuItem.Checked = True


        End If

    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoToolStripMenuItem.Click
        If (LogoToolStripMenuItem.Checked) Then

            
            LogoPictureBox.Visible = False
            LogoToolStripMenuItem.Checked = False


        Else

            LogoToolStripMenuItem.Checked = True
            LogoPictureBox.Visible = True


        End If

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.Color = SloganLabel.ForeColor

        With ColorDialog1

            .ShowDialog()

            SloganLabel.ForeColor = .Color
        End With

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.Font = SloganLabel.Font
        With FontDialog1
            .ShowDialog()
            SloganLabel.Font = .Font
        End With

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBoxForm.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddToOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToOrderToolStripMenuItem.Click
        ' checks to see what size the user picked and what options they want with it to calculate the order adding it to a summary
        Dim Quantity As Integer
        Dim OrderPrice As Integer
        Dim Small As Integer = 10
        Dim Medium As Integer = 10
        Dim Large As Integer = 10
        Dim ExtraLarge As Integer = 11
        Dim XXL As Integer = 12
        Dim Monogramed = 2
        Dim HasPocket = 1
        Try
            Quantity = Integer.Parse(QuantityTextBox.Text)
            If (Quantity < 1) Then
                MessageBox.Show("Insufficient Quantity of shirts ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If (Quantity >= 1) Then
                NumOrders += 1
                NumShirts += Quantity
                CustomerNameTextBox.ReadOnly = True
                CustomerNameTextBox.TabStop = False
                OrderNumberTextBox.ReadOnly = True
                OrderNumberTextBox.TabStop = False
                If (SizeSmallRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (Small)

                End If

                If (SizeMediumRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (Medium)

                End If
                If (SizeLargeRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (Large)

                End If
                If (SizeExtraLargeRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (ExtraLarge)

                End If
                If (SizeXXLRadioButton.Checked = True) Then
                    OrderPrice = Quantity * (XXL)

                End If

                If (MonogramedCheckBox.Checked = True) Then
                    OrderPrice += Quantity * Monogramed
                End If

                If (PocketCheckBox.Checked = True) Then
                    OrderPrice += Quantity * HasPocket

                End If

            End If
            OrderTotalTextBox.Text = OrderPrice
            SummaryTotal += OrderPrice
            SummaryTotalTextBox.Text = SummaryTotal
            'message box display code
        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SummayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummayToolStripMenuItem.Click
        ' checks to see if the order is complete the shows the final results on a summary form
        
        Dim buttonResult As DialogResult
        If (Complete = True) Then
            SummaryForm.ShowDialog()
           
            buttonResult = MessageBox.Show("would you like to start a new order?", "Summary?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (buttonResult = Windows.Forms.DialogResult.Yes) Then
                CustomerNameTextBox.Text = Nothing
                CustomerNameTextBox.ReadOnly = False
                CustomerNameTextBox.TabStop = True
                OrderNumberTextBox.Text = Nothing
                OrderNumberTextBox.ReadOnly = False
                OrderNumberTextBox.TabStop = True
                QuantityTextBox.Text = Nothing
                SizeSmallRadioButton.Checked = False
                SizeMediumRadioButton.Checked = False
                SizeLargeRadioButton.Checked = False
                SizeExtraLargeRadioButton.Checked = False
                SizeXXLRadioButton.Checked = False
                MonogramedCheckBox.Checked = False
                PocketCheckBox.Checked = False

                SummaryTotal = 0
                NumOrders = 0
                NumShirts = 0

            End If
        End If
        If (Complete = False) Then
            MessageBox.Show("Complete your order first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Private Sub ClearThisItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearThisItemToolStripMenuItem.Click
        ' clears the choices except the name and order number
        QuantityTextBox.Text = Nothing
        SizeSmallRadioButton.Checked = False
        SizeMediumRadioButton.Checked = False
        SizeLargeRadioButton.Checked = False
        SizeExtraLargeRadioButton.Checked = False
        SizeXXLRadioButton.Checked = False
        MonogramedCheckBox.Checked = False
        PocketCheckBox.Checked = False
    End Sub

    Private Sub OrderCompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderCompleteToolStripMenuItem.Click
        'sets complete to true
        Complete = True
    End Sub
End Class
