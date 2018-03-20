'o	Project name:Hw Assignment 8 part 2 (8.4)
'o	Programmer name Breon Day
'o	Date:3/26/2016
'o	Description:state and territory look up 
Public Class Form1
    

    Structure State
        ' state struct
        Dim Name As String
        Dim Abrv As String
    End Structure
    'array of 56 states and territories

    Dim States(55) As State

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'annoyingly long list of us territories and states
        States(0).Abrv = "AL"
        States(0).Name = "Alabama"
        States(1).Abrv = "AK"
        States(1).Name = "Alaska"
        States(2).Abrv = "AS"
        States(2).Name = "American Samoa"
        States(3).Abrv = "AZ"
        States(3).Name = "Arizona"
        States(4).Abrv = "AR"
        States(4).Name = "Arkansas"
        States(5).Abrv = "CA"
        States(5).Name = "California"
        States(6).Abrv = "CO"
        States(6).Name = "Colorado"
        States(7).Abrv = "CT"
        States(7).Name = "Connecticut"
        States(8).Abrv = "DE"
        States(8).Name = "Deleware"
        States(9).Abrv = "DC"
        States(9).Name = "District of Columbia"
        States(10).Abrv = "FL"
        States(10).Name = "Florida"
        States(11).Abrv = "GA"
        States(11).Name = "Georgia"
        States(12).Abrv = "GU"
        States(12).Name = "Guam"
        States(13).Abrv = "Hi"
        States(13).Name = "Hawaii"
        States(14).Abrv = "ID"
        States(14).Name = "Idaho"
        States(15).Abrv = "IL"
        States(15).Name = "Illinois"
        States(16).Abrv = "IN"
        States(16).Name = "Indiana"
        States(17).Abrv = "IA"
        States(17).Name = "Iowa"
        States(18).Abrv = "KS"
        States(18).Name = "Kansas"
        States(19).Abrv = "KY"
        States(19).Name = "Kentucky"
        States(20).Abrv = "La"
        States(20).Name = "Lousiana"
        States(21).Abrv = "ME"
        States(21).Name = "Maine"
        States(22).Abrv = "Md"
        States(22).Name = "Maryland"
        States(23).Abrv = "MA"
        States(23).Name = "Massachusetts"
        States(24).Abrv = "Mi"
        States(24).Name = "Michigan"
        States(25).Abrv = "MN"
        States(25).Name = "Minisota"
        States(26).Abrv = "MS"
        States(26).Name = "Mississippi"
        States(27).Abrv = "MO"
        States(27).Name = "Missouri"
        States(28).Abrv = "MT"
        States(28).Name = "Montana"
        States(29).Abrv = "NE"
        States(29).Name = "Nebraska"
        States(30).Abrv = "NV"
        States(30).Name = "Nevada"
        States(31).Abrv = "NH"
        States(31).Name = "New Hampshire"
        States(32).Abrv = "NJ"
        States(32).Name = "New Jersey"
        States(33).Abrv = "NM"
        States(33).Name = "New Mexico"
        States(34).Abrv = "NY"
        States(34).Name = "New York"
        States(35).Abrv = "NC"
        States(35).Name = "North Carolina"
        States(36).Abrv = "ND"
        States(36).Name = "North Dakota"
        States(37).Abrv = "OH"
        States(37).Name = "Ohio"
        States(38).Abrv = "OK"
        States(38).Name = "Oklahoma"
        States(39).Abrv = "OR"
        States(39).Name = "Oregon"
        States(40).Abrv = "PA"
        States(40).Name = "Pennsylvania"
        States(41).Abrv = "PR"
        States(41).Name = "Puerto Rico"
        States(42).Abrv = "RI"
        States(42).Name = "Rhode Island"
        States(43).Abrv = "SC"
        States(43).Name = "South Carolina"
        States(44).Abrv = "SD"
        States(44).Name = "South Dakota"
        States(45).Abrv = "TN"
        States(45).Name = "Tennessee"
        States(46).Abrv = "TX"
        States(46).Name = "Texas"
        States(47).Abrv = "TT"
        States(47).Name = "Trust Territories"
        States(48).Abrv = "UT"
        States(48).Name = "Utah"
        States(49).Abrv = "VT"
        States(49).Name = "Vermont"
        States(50).Abrv = "Va"
        States(50).Name = "Virginia"
        States(51).Abrv = "VI"
        States(51).Name = "Virgin Islands"
        States(52).Abrv = "WA"
        States(52).Name = "Washington"
        States(53).Abrv = "WV"
        States(53).Name = "West Virginia"
        States(54).Abrv = "WI"
        States(54).Name = "Wisconsin"
        States(55).Abrv = "WY"
        States(55).Name = "Wyoming"
       
    End Sub


    Private Sub RadioButtons_CheckedChanged(sender As Object, ByVal e As EventArgs) Handles NameRadioButton.CheckedChanged, AbrvRadioButton.CheckedChanged
        Dim SelectedRadioButton As RadioButton
        SelectedRadioButton = CType(sender, RadioButton)
        Select Case SelectedRadioButton.Name
            Case "NameRadioButton"
                NameTextBox.Focus()
                NameTextBox.Text = Nothing
                NameTextBox.ReadOnly = False
                AbrvTextBox.ReadOnly = True
            Case "AbrvRadioButton"
                NameTextBox.ReadOnly = True
                AbrvTextBox.ReadOnly = False
                AbrvTextBox.Focus()
                AbrvTextBox.Text = Nothing

        End Select
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LookUpButton_Click(sender As Object, e As EventArgs) Handles LookUpButton.Click
        'checks to see if the text box value matches any of the array values
        ' if so it gives the appropriate abrreviation or name depending on which box is read only
        ' it converts both to upper case for the comparison so case is not an issue but spaces still are
        Dim found As Boolean = False

        For Each usstate As State In States
            If (NameTextBox.ReadOnly = True) Then
                If (AbrvTextBox.Text.ToUpper = usstate.Abrv.ToUpper) Then
                    NameTextBox.Text = usstate.Name
                    found = True
                End If
            End If
            If (AbrvTextBox.ReadOnly = True) Then
                If (NameTextBox.Text.ToUpper = usstate.Name.ToUpper) Then
                    AbrvTextBox.Text = usstate.Abrv
                    found = True
                End If
            End If

        Next
        If (found = False) Then
            MessageBox.Show("match can not be found")
        End If

    End Sub
End Class
