'o	Project name:Hw Assignment 6 part 2 (6.4)
'o	Programmer name Breon Day
'o	Date:2/27/2016
'o	Description:Drink popularity voting form

Public Class PruneVsApple
    Friend PrunePunchScore As Integer
    Friend AppleAdeScore As Integer
    Friend NumVoters As Integer
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'adds the about form to the screen
        AboutBoxForm.ShowDialog()
    End Sub

    Private Sub NewTesterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTesterToolStripMenuItem.Click
        'adds the voter form to the screen
        NewTesterForm.ShowDialog()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        'adds the summary form to the screen
        SummaryForm.ShowDialog()
    End Sub
End Class
