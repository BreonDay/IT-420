Public Class VeryVeryBoard
    ' Project : Exercise3.5 assignment 2
    'Programmer :Breon Day  
    'Date:1/29/2016
    'Description:summarizes snowboard rental cost per customer and daily 

    Private TodaysTotalSnowBoards As Integer
    Private TodaysTotalSnowBoardsWithBoots As Integer
    Private TodaysAverage As Integer
    Private TodaysNumCustomers As Integer
    Private TodaysTotal As Integer
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes the form    
        Me.Close()

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' Prints the form on the printer.
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'calculates the users order and adds its values to the daily summary
        Dim NumBoards As Integer
        Dim NumBoardsWBoots As Integer

        Dim BoardsValue As Integer
        Dim BoardswithBootsValue As Integer

        Dim sum As Integer


        Try
            'get the number of boards from the text boxes and parse them as intergers
            NumBoards = Integer.Parse(SnowBoardsTextBox.Text)
            NumBoardsWBoots = Integer.Parse(SnowboardswBootsTextBox.Text)
            'multiply those interger values by the boards value and total it
            BoardsValue = NumBoards * 20
            BoardswithBootsValue = NumBoardsWBoots * 30
            sum = BoardsValue + BoardswithBootsValue
            'pass it back as text to the customers box
            SnowBoardsValueTextBox.Text = BoardsValue.ToString("C")
            SnowBoardsValueWithBootsTextBox.Text = BoardswithBootsValue.ToString("C")
            TotalTextBox.Text = sum.ToString("C")
            'summary box updates
            TodaysNumCustomers += 1
            TodaysTotalSnowBoards += NumBoards
            TodaysTotalSnowBoardsWithBoots += NumBoardsWBoots
            TodaysTotal += sum
            TodaysAverage = TodaysTotal / TodaysNumCustomers
            'pass those updated values to the correct text box
            TodaysSnowBoardsWithBootsTotalTextBox.Text = TodaysTotalSnowBoardsWithBoots.ToString()
            TodaysSnowboardTotalTextBox.Text = TodaysTotalSnowBoards.ToString()
            TodaysTotalCharges.Text = TodaysNumCustomers.ToString
            TodaysAverageTextBox.Text = TodaysAverage.ToString("C")


        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'sets the none summary text boxes to a cleared state
        SnowBoardsValueTextBox.Text = ""
        SnowBoardsValueWithBootsTextBox.Text = ""
        TotalTextBox.Text = ""
        SnowboardswBootsTextBox.Text = ""
        SnowBoardsTextBox.Text = ""
        NameTextBox.Text = ""
        IdTextBox.Text = ""
    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        'clears everything including reseting the global values
        'handle daily input
        SnowBoardsValueTextBox.Text = ""
        SnowBoardsValueWithBootsTextBox.Text = ""
        TotalTextBox.Text = ""
        SnowboardswBootsTextBox.Text = ""
        SnowBoardsTextBox.Text = ""
        NameTextBox.Text = ""
        IdTextBox.Text = ""
        'resets global summary
        TodaysTotalSnowBoards = 0
        TodaysTotalSnowBoardsWithBoots = 0
        TodaysAverage = 0
        TodaysNumCustomers = 0
        TodaysTotal = 0
        TodaysSnowBoardsWithBootsTotalTextBox.Text = ""
        TodaysSnowboardTotalTextBox.Text = ""
        TodaysTotalCharges.Text = ""
        TodaysAverageTextBox.Text = ""
    End Sub
End Class
