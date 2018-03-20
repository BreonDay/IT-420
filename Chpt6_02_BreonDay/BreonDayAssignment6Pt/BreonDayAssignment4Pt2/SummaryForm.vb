Public Class SummaryForm

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' sets the text in the summary text boxes to the calculated values
        NumOrdersTextBox.Text = VeryVeryBoards.NumOrders.ToString()
        NumShirtsTextBox.Text = VeryVeryBoards.NumShirts.ToString()
        NumDollarsTextBox.Text = VeryVeryBoards.SummaryTotal.ToString("C")
    End Sub
End Class