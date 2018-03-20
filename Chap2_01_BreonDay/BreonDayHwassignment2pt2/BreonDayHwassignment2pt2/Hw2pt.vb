'Project name Hw2
'Programmer name Breon Day
'Date 1/23/2015
'Description allows the user to edit the display of the labels
Public Class Hw2pt

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes the project
        Me.Close()
    End Sub



    Private Sub ProgrammerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ProgrammerCheckBox.CheckedChanged
        If ProgrammerCheckBox.Checked = False Then
            ProgrammerLabel.Visible = False


        End If
        If ProgrammerCheckBox.Checked = True Then
            ProgrammerLabel.Visible = True

        End If
    End Sub

    Private Sub LogoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LogoCheckBox.CheckedChanged
        If LogoCheckBox.Checked = True Then
            LogoPictureBox.Visible = True


        End If
        If LogoCheckBox.Checked = False Then
            LogoPictureBox.Visible = False


        End If

    End Sub

    Private Sub SloganCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SloganCheckBox.CheckedChanged
        If SloganCheckBox.Checked = True Then
            SloganLabel.Visible = True


        End If
        If SloganCheckBox.Checked = False Then
            SloganLabel.Visible = False
        End If


    End Sub

    Private Sub CompanyNameCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CompanyNameCheckBox.CheckedChanged
        If CompanyNameCheckBox.Checked = False Then
            CompanyNameLabel.Visible = False


        End If
        If CompanyNameCheckBox.Checked = True Then
            CompanyNameLabel.Visible = True

        End If


    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        SloganLabel.ForeColor = Color.Red
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        SloganLabel.ForeColor = Color.Blue

    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        SloganLabel.ForeColor = Color.Green
    End Sub

    Private Sub BlackRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlackRadioButton.CheckedChanged
        SloganLabel.ForeColor = Color.Black
    End Sub
End Class
