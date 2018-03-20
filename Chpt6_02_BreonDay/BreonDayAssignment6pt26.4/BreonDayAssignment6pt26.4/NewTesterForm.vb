Public Class NewTesterForm

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        ' allows the user to vote doesnt take in characters or values below 0 or above 10
        Dim PScore As Integer
        Dim AScore As Integer

        If (PrunePunchTextBox.Text = "" Or AppleAdeTextBox.Text = "") Then
            If (PrunePunchTextBox.Text = "") Then
                PrunePunchTextBox.Focus()
                MessageBox.Show("Please vote for both sides ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If (AppleAdeTextBox.Text = "") Then
                AppleAdeTextBox.Focus()
                MessageBox.Show("Please vote for both sides ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
 
        If (AppleAdeTextBox.Text <> "" AndAlso PrunePunchTextBox.Text <> "") Then
            Try
                PScore = Integer.Parse(PrunePunchTextBox.Text)
                AScore = Integer.Parse(AppleAdeTextBox.Text)

                If (PScore >= 0 AndAlso PScore <= 10 AndAlso AScore <= 10 AndAlso AScore >= 0) Then
                    PruneVsApple.NumVoters += 1
                    PruneVsApple.PrunePunchScore += Integer.Parse(PrunePunchTextBox.Text)
                    PruneVsApple.AppleAdeScore += Integer.Parse(AppleAdeTextBox.Text)
                    PrunePunchTextBox.Text = Nothing
                    AppleAdeTextBox.Text = Nothing
                    PrunePunchTextBox.Focus()
                Else
                    MessageBox.Show("Please Keep The Values Whole Numbers Between 0-10 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            Catch ex As Exception
                MessageBox.Show("Please Keep The Values Whole Numbers Between 0-10 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class