Public Class ClockForm
    Private Sub ClockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'start the timer
        Timer1.Start()
        'set the default time to 12 hour time
        rdbtn12.Checked = True
        lblSunlight.Text = "am"
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        StartClock()
    End Sub

    Private Sub btnAdjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjust.Click
        txtbxSec.ReadOnly = False
        txtbxMin.ReadOnly = False
        txtbxHour.ReadOnly = False
        cmbSection.Enabled = True
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        SetTime()
    End Sub

    Private Sub rdbtn12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn12.CheckedChanged
        SectionDetermine()
    End Sub

    Private Sub rdbtn24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn24.CheckedChanged
        SectionDetermine()
    End Sub

    Private Sub rdbtn12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtn12.Click
        AssignSectionFor12Hour()
    End Sub
End Class
    