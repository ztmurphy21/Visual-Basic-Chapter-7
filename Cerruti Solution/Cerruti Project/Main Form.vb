Option Explicit On
Option Strict On
Option Infer Off
' Name:         Cerruti Project
' Purpose:      Displays gross pay, taxes, and net pay
' Programmer:   Zach Murphy on 3-19-2017

Imports System.ComponentModel

Public Class frmMain

    ' GetFwt function
    Private Function GetFwt(ByVal dblWeekPay As Double, ByVal intNumAllow As Integer, ByVal strMarital As String) As Double
        'calculates and returns the fwt
        Const dblOne_ALLOW As Double = 76
        Dim dblTaxWages As Double
        Dim dblTax As Double

        'calc taxable wages
        dblTaxWages = dblWeekPay - intNumAllow * dblOne_ALLOW

        'determine marital status and then calc FWT
        If strMarital = "S" Then
            Select Case dblTaxWages
                Case Is <= 43
                    dblTax = 0
                Case Is <= 218
                    dblTax = 0.1 * (dblTaxWages - 43)
                Case Is <= 753
                    dblTax = 17.5 + 0.15 * (dblTaxWages - 218)
                Case Is <= 1762
                    dblTax = 97.75 + 0.25 * (dblTaxWages - 753)
                Case Is <= 3627
                    dblTax = 350 + 0.28 * (dblTaxWages - 1762)
                Case Is <= 7834
                    dblTax = 872.2 + 0.33 * (dblTaxWages - 3627)
                Case Is <= 7865
                    dblTax = 2260.51 + 0.35 * (dblTaxWages - 7834)
                Case Else
                    dblTax = 2271.36 + 0.396 * (dblTaxWages - 7865)
            End Select
        Else 'strMarital = "M"
            Select Case dblTaxWages
                Case Is <= 163
                    dblTax = 0
                Case Is <= 512
                    dblTax = 0.1 * (dblTaxWages - 163)
                Case Is <= 1582
                    dblTax = 34.9 + 0.15 * (dblTaxWages - 512)
                Case Is <= 3025
                    dblTax = 195.4 + 0.25 * (dblTaxWages - 1582)
                Case Is <= 4525
                    dblTax = 556.15 + 0.28 * (dblTaxWages - 3025)
                Case Is <= 7953
                    dblTax = 976.15 + 0.33 * (dblTaxWages - 4525)
                Case Is <= 8963
                    dblTax = 2107.39 + 0.35 * (dblTaxWages - 7953)
                Case Else
                    dblTax = 2460.89 + 0.396 * (dblTaxWages - 8963)
            End Select
        End If

        Return dblTax

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        ' select the existing text

        txtName.SelectAll()
    End Sub

    Private Sub cboAllowances_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAllowances.KeyPress
        ' allow only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles lstHours.SelectedValueChanged,
        lstRates.SelectedValueChanged, radSingle.CheckedChanged, radMarried.CheckedChanged,
        txtName.TextChanged, cboAllowances.TextChanged

        lblGross.Text = String.Empty
        lblFwt.Text = String.Empty
        lblFica.Text = String.Empty
        lblNet.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list boxes and combo box with values
        ' then select a default value in each

        For dblHours As Double = 0 To 55 Step 0.5
            lstHours.Items.Add(dblHours.ToString("N1"))
        Next dblHours

        For dblRates As Double = 7.5 To 15.5 Step 0.5
            lstRates.Items.Add(dblRates.ToString("N2"))
        Next dblRates

        For intAllow As Integer = 0 To 10
            cboAllowances.Items.Add(intAllow.ToString)
        Next intAllow

        lstHours.SelectedItem = "40.0"
        lstRates.SelectedItem = "9.50"
        cboAllowances.SelectedIndex = 0
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'verify the user wants to exit the application

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Cerruti Company", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        'if the No button was selected, don't close the form
        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'displays gross pay, taxes, and net pay

        Const dblFICA_RATE As Double = 0.0765
        Dim strStaus As String
        Dim dblHours As Double
        Dim dblPayRate As Double
        Dim intAllowances As Integer
        Dim dblGross As Double
        Dim dblFwt As Double
        Dim dblFica As Double
        Dim dblNet As Double

        Double.TryParse(lstHours.SelectedItem.ToString, dblHours)
        Double.TryParse(lstRates.SelectedItem.ToString, dblPayRate)
        Integer.TryParse(cboAllowances.Text, intAllowances)

        If radSingle.Checked Then
            strStaus = "S"
        Else
            strStaus = "M"
        End If

        'calc gross pay
        If dblHours <= 40 Then
            dblGross = dblHours * dblPayRate
        Else
            dblGross = 40 * dblPayRate + (dblHours - 40) * dblPayRate * 1.5
        End If

        'get the FWT
        dblFwt = GetFwt(dblGross, intAllowances, strStaus)

        'cacl fica tax
        dblFica = dblGross * dblFICA_RATE

        'round gross pay, fwt, and fica tax
        dblGross = Math.Round(dblGross, 2)
        dblFwt = Math.Round(dblFwt, 2)
        dblFica = Math.Round(dblFica, 2)

        'calculate net pay
        dblNet = dblGross - dblFwt - dblFica

        ' display calculated amounts
        lblGross.Text = dblGross.ToString("n2")
        lblFwt.Text = dblFwt.ToString("n2")
        lblFica.Text = dblFica.ToString("n2")
        lblNet.Text = dblNet.ToString("n2")
    End Sub
End Class
