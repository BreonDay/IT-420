'o	Project name:Hw Assignment 9 part 2 
'o	Programmer name Breon Day
'o	Date:4/9/2016
'o	Description: io for file read selection and write
Imports System.IO
Imports Microsoft.VisualBasic.FileIO


Public Class Form1
    Private userNum As Integer
    Private TextParser As TextFieldParser
    Private FieldString() As String
    Private ResponseDialogResult As DialogResult
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StoreButton_Click(sender As Object, e As EventArgs) Handles StoreButton.Click
        'stores the data overwritting its own line with each new store all other data is perserved
        If (MemSizeTextBox.Text <> Nothing And HardDriveSizeTextBox.Text <> Nothing And CpuSpeedTextBox.Text <> Nothing And BrandInfoTextBox.Text <> Nothing) Then
            userNum = userNum + 1
            MissingInputLabel.Visible = False
            My.Computer.FileSystem.WriteAllText("UserInfo.txt ", "User#" & userNum & "," & "Memory size: " & MemSizeTextBox.Text & "," & "Hard Drive Size: " & HardDriveSizeTextBox.Text & "," & "Cpu Speed: " & CpuSpeedTextBox.Text & "," & "Brand: " & BrandInfoTextBox.Text & Environment.NewLine, False)
        Else
            MissingInputLabel.Visible = True
        End If

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        ' appends its data to a new line
        If (MemSizeTextBox.Text <> Nothing And HardDriveSizeTextBox.Text <> Nothing And CpuSpeedTextBox.Text <> Nothing And BrandInfoTextBox.Text <> Nothing) Then
            userNum = userNum + 1
            MissingInputLabel.Visible = False
            My.Computer.FileSystem.WriteAllText("UserInfo.txt ", "User#" & userNum & "," & "Memory size: " & MemSizeTextBox.Text & "," & "Hard Drive Size: " & HardDriveSizeTextBox.Text & "," & "Cpu Speed: " & CpuSpeedTextBox.Text & "," & "Brand: " & BrandInfoTextBox.Text & Environment.NewLine, True)
        Else
            MissingInputLabel.Visible = True
        End If

    End Sub

    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        
        
        ' opens the file dialog so the user can select a txt file must be delimted by , and have 4 entries per line
        With OpenFileDialog1
            .InitialDirectory = IO.Directory.GetCurrentDirectory()
            .FileName = "UserInfo.txt "
            .Title = "Select File or Directory for File"
            ResponseDialogResult = .ShowDialog()
        End With
        ' parses the file and defines its delimiter 
        Try
            TextParser = New TextFieldParser(OpenFileDialog1.FileName)
            TextParser.TextFieldType = FieldType.Delimited
            TextParser.SetDelimiters(",")
        Catch ex As Exception
            MessageBox.Show("Unable to read the file:" & OpenFileDialog1.FileName, "File Error")
        End Try

       

    End Sub

    Private Sub ReadNextButton_Click(sender As Object, e As EventArgs) Handles ReadNextButton.Click
        ' goes through the selected parsed data filing in the form
        If Not TextParser.EndOfData Then
            FieldString = TextParser.ReadFields()
            UserTextBox.Text = FieldString(0)
            MemSizeTextBox.Text = FieldString(1)
            HardDriveSizeTextBox.Text = FieldString(2)
            CpuSpeedTextBox.Text = FieldString(3)
            BrandInfoTextBox.Text = FieldString(4)
        Else
            MessageBox.Show("no more records to display.", "End of Data")
        End If
    End Sub

  

   
  
End Class
