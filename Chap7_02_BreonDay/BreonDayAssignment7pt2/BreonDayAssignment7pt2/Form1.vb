Public Class Form1
    ' Project : Exercise7.4 assignment 7
    'Programmer :Breon Day  
    'Date:3/5/2016
    'Description: combo box bagel editing program

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        ' attempts to add an item to the list
        Try
            If (ComboBox1.Text = Nothing) Then


            Else
                ComboBox1.Items.Add(ComboBox1.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Illegal input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        ' attempts to remove an item from the list
        Try
            ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
        Catch ex As Exception
            MessageBox.Show("Make sure you selected a bagel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayBagelCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayBagelCountToolStripMenuItem.Click
        ' displays the total number of items in the list
        MessageBox.Show("There are: " + ComboBox1.Items.Count.ToString() + " total bagels", "Total Bagels:", MessageBoxButtons.OK)
    End Sub


    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        ' clears the combo box list
        ComboBox1.Items.Clear()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        ' Print the form on the printer.
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
