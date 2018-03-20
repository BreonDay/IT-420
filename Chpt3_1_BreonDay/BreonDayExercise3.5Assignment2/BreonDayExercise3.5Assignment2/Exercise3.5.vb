Public Class Form1
    ' Project : Exercise3.5 assignment 2
    'Programmer :Breon Day  
    'Date:1/29/2016
    'Description: interest rate calculation form

  
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'ends the application
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'calculates the interest given years initial investment and years held and displays it
        'also displays an error message if incorrect data is entered
        Dim Investment As Decimal
        Dim InterestRate As Decimal
        Dim YearsHeld As Integer
        Dim FutureValue As Decimal

        Try
            Investment = Decimal.Parse(InvestmentTextBox.Text)
            InterestRate = Decimal.Parse(InterestRateTextBox.Text)
            YearsHeld = Integer.Parse(YearsHeldTextBox.Text)
            FutureValue = Investment * (1 + InterestRate) ^ YearsHeld
            FutureValueTextBox.Text = FutureValue.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Nonnumeric or missing entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clears the text of the user input
        InvestmentTextBox.Text = ""
        InterestRateTextBox.Text = ""
        YearsHeldTextBox.Text = ""
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' Prints the form on the printer.
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
