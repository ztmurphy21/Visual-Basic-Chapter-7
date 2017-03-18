'State Capital Program
' Shows the capital of selected state in combo box
'Programmer: Zach Murphy on 3-17-2017

Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Fill combo box with states
        cboStates.Items.Add("Alabama")
        cboStates.Items.Add("Hawaii")
        cboStates.Items.Add("California")
        cboStates.Items.Add("Maine")
        cboStates.Items.Add("Louisiana")
        cboStates.Text = "Maine"
    End Sub


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim stateSelected As String
        stateSelected = cboStates.Text.ToString()
        ' Dim capital As String



        'display the correct capital
        Select Case stateSelected
            Case "Alabama"
                lblCapital.Text = "Montgomery"
            Case "Hawaii"
                lblCapital.Text = "Honolulu"
            Case "California"
                lblCapital.Text = "Sacramento"
            Case "Maine"
                lblCapital.Text = "Augusta"
            Case "Louisiana"
                lblCapital.Text = "Baton Rouge"
        End Select

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, cboStates.TextChanged
        'clear values if clear button pressed or value changed in combo box
        lblCapital.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the application
        Me.Close()

    End Sub
End Class
