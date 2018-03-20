'o	Project name:Hw Assignment 9 part 1 (9.2)
'o	Programmer name Breon Day
'o	Date:4/9/2016
'o	Description:web site for rough riders rodeo ticket sales
Public Class _Default
    Inherits System.Web.UI.Page
    Private amountDue As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        Try
            If (AttendingCheckBox.Checked = True And CardTypeDropDownList.SelectedIndex > 0 And addressNameTextBox.Text <> Nothing And CreditCardExpirationDateNameTextBox2.Text <> Nothing) Then

                amountDue = Integer.Parse(numTicketsTextBox.Text) * 25
                AmountDueLabel.Text = amountDue.ToString("C")
                AmountDueLabel.Visible = True
                AmountDueLabel2.Visible = True
                ConfirmHyperLink.Visible = True
                MissingInputLabel.Visible = False
            Else

            End If
            If (AttendingCheckBox.Checked = False And CardTypeDropDownList.SelectedIndex > 0 And addressNameTextBox.Text <> Nothing And CreditCardExpirationDateNameTextBox2.Text <> Nothing) Then
                amountDue = Integer.Parse(numTicketsTextBox.Text) * 15
                AmountDueLabel.Text = amountDue.ToString("C")
                AmountDueLabel.Visible = True
                AmountDueLabel2.Visible = True
                ConfirmHyperLink.Visible = True
                MissingInputLabel.Visible = False

            End If
            ' sets the values back  to false if there isnt the correct amount of input
            If (AttendingCheckBox.Checked = False And CardTypeDropDownList.SelectedIndex = 0 Or addressNameTextBox.Text = Nothing Or CreditCardExpirationDateNameTextBox2.Text = Nothing) Then
                AmountDueLabel.Visible = False
                AmountDueLabel2.Visible = False
                ConfirmHyperLink.Visible = False
                MissingInputLabel.Visible = True

            End If
            If (AttendingCheckBox.Checked = True And CardTypeDropDownList.SelectedIndex = 0 Or addressNameTextBox.Text = Nothing Or CreditCardExpirationDateNameTextBox2.Text = Nothing) Then
                AmountDueLabel.Visible = False
                AmountDueLabel2.Visible = False
                ConfirmHyperLink.Visible = False
                MissingInputLabel.Visible = True

            End If
        Catch ex As Exception
            AmountDueLabel.Visible = False
            AmountDueLabel2.Visible = False
            ConfirmHyperLink.Visible = False
            MissingInputLabel.Visible = True
        End Try




    End Sub
End Class