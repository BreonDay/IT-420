'o	Project name:Hw Assignment 8 part 1 (8.1)
'o	Programmer name Breon Day
'o	Date:3/26/2016
'o	Description:array of structs for poverty linecalculations 
Public Class Form1
    'a position varible i will increment as i add the structs to the array
    Private position As Integer = 0
    'the survey struct with the nessacary varibles to be added to the array
    Private Structure HouseHoldIncomeSurvey
        Dim ID As String
        Dim Income As Integer
        Dim NumPeople As Integer
        Dim BelowPovertyLevel As Boolean
    End Structure
    'the survery array of structs
    Private Survey(19) As HouseHoldIncomeSurvey
    'sum income to find the average
    Private Sum As Integer

    'poverty level comparison array for the final report
    Private PovertyLevel() As Integer = {10210, 13690, 17170, 20650, 24130, 27610, 31090, 34570}

    Private Sub EXitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXitToolStripMenuItem.Click
        'self explanatory
        Me.Close()
    End Sub

    Private Sub EnterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterDataToolStripMenuItem.Click
        ' parses data from the text boxes and sets each struct as above or below the poverty line
        Dim ThePovertyLevel As Integer
        Try

            Survey(position).ID = Integer.Parse(IDTextBox.Text)
            Survey(position).Income = Integer.Parse(AnnualIncomeTextBox.Text)
            If (Integer.Parse(NumPeopleTextBox.Text) <= 7) Then
                Survey(position).NumPeople = Integer.Parse(NumPeopleTextBox.Text)
            End If

            Sum += Survey(position).Income
            If (Survey(position).NumPeople > 7) Then
                ThePovertyLevel = 34570 + ((Survey(position).NumPeople - 7) * 3480)
            Else
                ThePovertyLevel = PovertyLevel(Survey(position).NumPeople)
            End If


            If (ThePovertyLevel > Survey(position).Income) Then
                Survey(position).BelowPovertyLevel = True
            Else
                Survey(position).BelowPovertyLevel = False
            End If


            position += 1
        Catch ex As Exception
            MessageBox.Show("put in input")

        End Try



    End Sub


    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        ' goes through each report in the array to count the total surveys determine the average and print out the needed messages in message boxes
        Dim TotalSurveys As Integer
        Dim AmountBelowPovertyLine As Integer
        Dim PercentBelowPovertyLine As Decimal
        Dim average As Integer
        Dim ReportSummary As String = ""
        Dim message As String = ""
        Try
            For Each report As HouseHoldIncomeSurvey In Survey
                If (report.Income > 0) Then
                    TotalSurveys += 1
                    ReportSummary += report.ID.ToString() + "  " + report.NumPeople.ToString() + "  " + report.Income.ToString() + Environment.NewLine
                End If
                If (report.BelowPovertyLevel = True) Then
                    AmountBelowPovertyLine += 1
                End If
            Next

            average = Sum / TotalSurveys
            For Each report As HouseHoldIncomeSurvey In Survey
                If (report.Income > average) Then
                    message += report.ID.ToString() + "  " + report.Income.ToString() + Environment.NewLine
                End If
            Next
            MessageBox.Show(ReportSummary, "Report Summary")
            MessageBox.Show(message, "ID and Incomes of those above average")
            PercentBelowPovertyLine = AmountBelowPovertyLine / TotalSurveys
            MessageBox.Show("total percent below the poverty line: " + PercentBelowPovertyLine.ToString("P"), "poverty line percent")

        Catch ex As Exception
            MessageBox.Show("enter data first")
        End Try

    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Designed By Breon Day" + Environment.NewLine + "Analyzes an array of structs incomes")
    End Sub
End Class
