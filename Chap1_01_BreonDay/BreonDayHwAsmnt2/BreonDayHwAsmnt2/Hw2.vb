'Project name Hw2
'Programmer name Breon Day
'Date 1/23/2015
'Description Displays store hours and store locations

Public Class Hw2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit the project
        Me.Close()
    End Sub


    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' Print the form on the printer
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub DowntownDisplayButton_Click(sender As Object, e As EventArgs) Handles DowntownDisplayButton.Click
        'Displays the Downtowns hours and location
        DowntownHours.Text = "7:00am-10:00pm"
        DowntownLocation.Text = "1234 westwood st"
    End Sub

    Private Sub MallDisplayButton_Click(sender As Object, e As EventArgs) Handles MallDisplayButton.Click
        'Displays the Malls hours and location
        MallHours.Text = "8:00am-9:00pm"
        MallLocation.Text = "110 Park Avenue "

    End Sub

    Private Sub SuburbsDisplayButton_Click(sender As Object, e As EventArgs) Handles SuburbsDisplayButton.Click
        'Display the Suburb store hours and location
        SuburbHours.Text = "7:30am-5:00pm"
        SuburbLocation.Text = "100 Summer Street"


    End Sub
End Class
