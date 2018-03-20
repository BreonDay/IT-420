Public Class SummaryForm

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Me.Close()

    End Sub

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'calculates the winner based on the information stored in Prune vs Apple
        ' as well as gets the average and number of voters
        If PruneVsApple.AppleAdeScore > PruneVsApple.PrunePunchScore Then
            WinnerTextBox.Text = "Apple Ade Is The Winner"
        End If
        If PruneVsApple.AppleAdeScore < PruneVsApple.PrunePunchScore Then
            WinnerTextBox.Text = "Prune Punch Is The Winner"
        End If
        If PruneVsApple.AppleAdeScore = PruneVsApple.PrunePunchScore Then
            WinnerTextBox.Text = "Its A Tie"
        End If
        TotalTestersTextBox.Text = PruneVsApple.NumVoters
        AAAverageTextBox.Text = PruneVsApple.AppleAdeScore / PruneVsApple.NumVoters
        PPAverageTextBox.Text = PruneVsApple.PrunePunchScore / PruneVsApple.NumVoters

    End Sub
End Class