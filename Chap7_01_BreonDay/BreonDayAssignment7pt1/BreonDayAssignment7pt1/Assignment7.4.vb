Public Class Form1
    ' Project : Exercise7.4 assignment 7
    'Programmer :Breon Day  
    'Date:3/5/2016
    'Description: list box selection by text

    Private Sub ListTextBox_TextChanged(sender As Object, e As EventArgs) Handles ListTextBox.TextChanged

        ' Locate first matching occurrence in the list. taken from the books example
        Dim Indexlnteger As Integer = 0
        Dim FoundBoolean As Boolean = False
        Dim ListCompareString As String
        Dim TextcompareString As String
        Do While Not FoundBoolean And Indexlnteger < ListBox1.Items.Count
            ListCompareString = ListBox1.Items(Indexlnteger).ToString().ToUpper()
            TextcompareString = ListTextBox.Text.ToUpper()
            If ListCompareString.StartsWith(TextcompareString) Then
                ListBox1.SelectedIndex = Indexlnteger
                FoundBoolean = True
            Else
                Indexlnteger += 1
            End If
        Loop

    End Sub

    
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class
