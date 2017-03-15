' Name:         Concert Project
' Purpose:      Displays the subtotal, discount, and total due for concert tickets
' Programmer:   Zach Murphy on 3-15-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' independent Sub procedure
    Private Sub AssignDiscount(ByVal intNum As Integer,
                               ByVal dblSub As Double,
                               ByRef dblDisc As Double)
        Select Case intNum
            Case Is >= 6
                dblDisc = dblSub * 0.1
            Case Is >= 4
                dblDisc = dblSub * 0.02
            Case Else
                dblDisc = 0
        End Select
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' display subtotal, discount, and total due

        Const dblSTANDARD As Double = 62.5
        Const dblVIP As Double = 102.75
        Dim intTickets As Integer
        Dim dblSubtotal As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Integer.TryParse(txtTickets.Text, intTickets)

        ' calculate subtotal
        If radStandard.Checked Then
            dblSubtotal = intTickets * dblSTANDARD
        Else
            dblSubtotal = intTickets * dblVIP
        End If

        ' call a procedure to assign the discount
        Call AssignDiscount(intTickets, dblSubtotal, dblDiscount)
        ' calculate total due
        dblTotalDue = dblSubtotal - dblDiscount

        lblSubtotal.Text = dblSubtotal.ToString("n2")
        lblDiscount.Text = dblDiscount.ToString("n2")
        lblTotalDue.Text = dblTotalDue.ToString("n2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtTickets_Enter(sender As Object, e As EventArgs) Handles txtTickets.Enter
        txtTickets.SelectAll()
    End Sub

    Private Sub txtTickets_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTickets.KeyPress
        ' allow only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtTickets.TextChanged, radStandard.CheckedChanged, radVip.CheckedChanged
        lblSubtotal.Text = String.Empty
        lblDiscount.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub
End Class
