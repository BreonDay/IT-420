'o	Project name:Hw Assignment 4 part 1
'o	Programmer name Breon Day
'o	Date:2/5/2016
'o	Description:Converts from english measurement to metric and vice versa based on user input

Public Class EnglishToMetricConverter


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes the application
        Me.Close()
    End Sub

    Private Sub InchesConverterButton_Click(sender As Object, e As EventArgs) Handles InchesConverterButton.Click
        'attempts to convert inches to centimeters from the users input
        Dim Inches As Double
        Dim Centimeters As Double

        Try
            Inches = Double.Parse(InchesToCentimetersTextBox.Text)
            Centimeters = 2.54 * Inches
            InchesToCentimetersReadOnlyTextBox.Text = Centimeters.ToString("N")

        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try

    End Sub

    Private Sub CentimeterConverterButton_Click(sender As Object, e As EventArgs) Handles CentimeterConverterButton.Click
        'attempts to convert centimeters to inches from the users input
        Dim Inches As Double
        Dim Centimeters As Double

        Try
            Centimeters = Double.Parse(CentimetersToInchesTextBox.Text)
            Inches = Centimeters / 0.3937
            CentimetersToInchesReadOnlyTextBox.Text = Inches.ToString("N")

        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Sub PoundConverterButton_Click(sender As Object, e As EventArgs) Handles PoundConverterButton.Click
        'attempts to convert pounds to kilograms from the users input
        Dim Kilogram As Double
        Dim Pound As Double

        Try
            Pound = Double.Parse(PoundsToKilogramsTextBox.Text)
            Kilogram = Pound * 2.20462
            PoundsToKilogramsReadOnlyTextBox.Text = Kilogram.ToString("N")

        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Sub KilogramsConverterButton_Click(sender As Object, e As EventArgs) Handles KilogramsConverterButton.Click
        'attempts to convert kilograms to pounds from the users input
        Dim Kilogram As Double
        Dim Pound As Double

        Try

            Kilogram = Double.Parse(KilogramsToPoundsTextBox.Text)
            Pound = (1 / 2.20462) * Kilogram
            KilogramsToPoundsReadOnlyTextBox.Text = Pound.ToString("N")

        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Sub GallonsConverterButton_Click(sender As Object, e As EventArgs) Handles GallonsConverterButton.Click
        'attempts to convert gallons to liters from the users input
        Dim Gallon As Double
        Dim Liter As Double

        Try
            Gallon = Double.Parse(GallonsToLitersTextBox.Text)
            Liter = 3.78541 * Gallon
            GallonsToLitersReadOnlyTextBox.Text = Liter.ToString("N")


        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Sub LitersConverterButton_Click(sender As Object, e As EventArgs) Handles LitersConverterButton.Click
        'attempts to convert liters to gallons from the users input
        Dim Gallon As Double
        Dim Liter As Double
        Try
            Liter = Double.Parse(LitersToGallonsTextBox.Text)
            Gallon = (1 / 3.78541) * Liter
            LitersToGallonsReadOnlyTextBox.Text = Gallon.ToString("N")

        Catch ex As Exception
            MessageBox.Show("Missing or incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' double for loop to check each group box and clear every text box in said group box\
        'gb stands for groub box
        'tb stands for text box
        Dim gb As Control
        Dim tb As Control

        For Each gb In Me.Controls

            If TypeOf gb Is GroupBox Then

                For Each tb In gb.Controls

                    If TypeOf tb Is TextBox Then
                        'for each text box found in the group box set the text to nothing
                        tb.Text = Nothing

                    End If

                Next

            End If

        Next

    End Sub
End Class
