'this program was developed fully by Ako Tavershima
'date: Tuesday, ‎August ‎01, ‎2017, ‏‎7:44:26 PM to Sunday, August 6, 2017 3:40 PM
'copyright tatarprofessional 2017
'this program is protected by copyright laws
Module ClockModule
    Public Second As Integer
    Public Minute As Integer
    Public Hour As Integer
    Dim Section As Integer
    Public Sub StartClock()
        Second = CInt(ClockForm.lblSec.Text) + 1 'Modified
        Minute = CInt(ClockForm.lblMin.Text)
        Hour = CInt(ClockForm.lblHour.Text)

        If Second = 60 Then
            Minute += 1
            Second = 0
            If Minute = 60 Then
                Hour += 1
                'Added code
                Minute = 0
                If Hour = Section Then
                    If ClockForm.rdbtn12.Checked = True Then
                        'here it decides whether to display am or pm if 12Hour radio button is checked
                        If ClockForm.lblSunlight.Text = "am" Then
                            ClockForm.lblSunlight.Text = "pm"
                        ElseIf ClockForm.lblSunlight.Text = "pm" Then
                            ClockForm.lblSunlight.Text = "am"
                        End If
                    End If
                    Hour = 0
                End If
            End If
        End If
        'Added code passing the value back to the labels
        'Padleft ensures that each value has 2 digits 
        'other way values below 10 will be shown, example 01 instead of 1, 02 insted 2
        ClockForm.lblSec.Text = Second.ToString.PadLeft(2, CChar("0"))
        ClockForm.lblMin.Text = Minute.ToString.PadLeft(2, CChar("0"))
        ClockForm.lblHour.Text = Hour.ToString.PadLeft(2, CChar("0"))
    End Sub
    Public Sub SetTime()
        'check to see the seconds textbox is; (1)an empty string (2)not a number (3) greater than 60
        If ClockForm.txtbxSec.Text = "" Then
            IsNothing(ClockForm.txtbxSec.Text)
        ElseIf Not IsNumeric(ClockForm.txtbxSec.Text) Then
            IsNothing(ClockForm.txtbxSec.Text)
        ElseIf CInt(ClockForm.txtbxSec.Text) >= 60 Then
            IsNothing(ClockForm.txtbxSec.Text)
        Else
            ClockForm.lblSec.Text = ClockForm.txtbxSec.Text
        End If
        'test to see if the minutes textbox value is; (1)an empty string (2)not a number (3)greater than 60
        If ClockForm.txtbxMin.Text = "" Then
            IsNothing(ClockForm.txtbxMin.Text)
        ElseIf Not IsNumeric(ClockForm.txtbxMin.Text) Then
            IsNothing(ClockForm.txtbxMin.Text)
        ElseIf CInt(ClockForm.txtbxMin.Text) >= 60 Then
            IsNothing(ClockForm.txtbxMin.Text)
        Else
            ClockForm.lblMin.Text = ClockForm.txtbxMin.Text
        End If
        'test to see if the hour textbox value is; (1)an empty string (2)not a number (3)greater than 12 0r 24 
        If ClockForm.txtbxHour.Text = "" Then
            IsNothing(ClockForm.txtbxHour.Text)
        ElseIf Not IsNumeric(ClockForm.txtbxHour.Text) Then
            IsNothing(ClockForm.txtbxHour.Text)
        ElseIf CInt(ClockForm.txtbxHour.Text) >= Section Then
            IsNothing(ClockForm.txtbxHour.Text)
        Else
            ClockForm.lblHour.Text = ClockForm.txtbxHour.Text
        End If
        'do not display time section on 24hour clock
        If ClockForm.rdbtn24.Checked = True Then
            Section = 24
            ClockForm.lblSunlight.Text = ""
        End If
        If ClockForm.cmbSection.Text = "" Then
            IsNothing(ClockForm.cmbSection)
        Else
            'set the section label to the combo box time section 
            ClockForm.lblSunlight.Text = ClockForm.cmbSection.Text
        End If
        'do not display am/pm in 24hour clock when ok is pressed 
        If ClockForm.rdbtn24.Checked = True Then
            Section = 24
            ClockForm.lblSunlight.Text = ""
        End If
        'set the time adjustment textboxes to readonly
        ClockForm.txtbxSec.ReadOnly = True
        ClockForm.txtbxMin.ReadOnly = True
        ClockForm.txtbxHour.ReadOnly = True
        ClockForm.cmbSection.Enabled = False
    End Sub
    Public Sub SectionDetermine()
        'determine which time format to use
        If ClockForm.rdbtn12.Checked = True Then
            Section = 12
            'convert an initial 24 hour time to 12 hour time
            If CInt(ClockForm.lblHour.Text) >= 12 Then
                ClockForm.lblHour.Text = CStr(CInt(ClockForm.lblHour.Text) - 12)
            End If
        ElseIf ClockForm.rdbtn24.Checked = True Then
            Section = 24
            'convert an initial 12 hour time to 24 hour time
            If CInt(ClockForm.lblHour.Text) < 12 Then
                If ClockForm.lblSunlight.Text = "pm" Then
                    ClockForm.lblHour.Text = CStr(Hour + 12)
                End If
            Else
                ClockForm.lblHour.Text = CStr(Hour + 12)
            End If
            ClockForm.lblSunlight.Text = ""
        End If
    End Sub
    Public Sub AssignSectionFor12Hour()
        If Hour > 12 Then
            ClockForm.lblSunlight.Text = "pm"
        Else
            ClockForm.lblSunlight.Text = "am"
        End If
    End Sub
End Module
