'Project name Hw5
'Programmer name Breon Day
'Date 2/20/2015
'Exercise in adding menus to a program
Public Class Exercise54
    ' Global Variables
    Private SumTotal As Integer
    Private NumReaders As Integer
    Private Average As Integer

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' closes the application
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' about me
        MessageBox.Show("Programmer: Breon Day", "About My Project")
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'clears the user input boxes  note the session doesnt end till the program does global variables remain since i wasnt told to clear them
        NameTextBox.Text = Nothing
        BookNumberTextBox.Text = Nothing

        BonusPointsLabel.Text = "Bonus Points:"
        NameTextBox.Focus()
    End Sub


    Private Sub PointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PointsToolStripMenuItem.Click
        '  calculates your bonus points based on the total books read
        Dim Remaining As Integer
        Dim BonusPts As Integer
        Dim total As Integer
        Try




            Remaining = Integer.Parse(BookNumberTextBox.Text)
            SumTotal += Remaining
            NumReaders += 1
            If (Remaining > 6) Then
                BonusPts = 3 * 10 + 3 * 15
                Remaining -= 6
                Remaining = Remaining * 20
                total = Remaining + BonusPts
            End If

            If (Remaining <= 3) Then
                total = Remaining * 10
            End If
            If (Remaining > 3 AndAlso Remaining <= 6) Then
                total = 30 + ((Remaining - 3) * 15)

            End If

            


            BonusPointsLabel.Text = "Bonus Points: " + total.ToString
        Catch ex As Exception
            MessageBox.Show("Please enter a name and some number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        'edits the dialogs color
        ColorDialog1.Color = BonusPointsLabel.ForeColor

        With ColorDialog1

            .ShowDialog()
            BonusPointsLabel.ForeColor = .Color

        End With

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        'editss the dialogs font
        FontDialog1.Font = BonusPointsLabel.Font
        With FontDialog1
            .ShowDialog()
            BonusPointsLabel.Font = .Font

        End With
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        '[rints the average
        Average = SumTotal / NumReaders
        MessageBox.Show("Average for this session" + Average.ToString(), "Summary")
    End Sub
End Class
