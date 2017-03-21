'Donut Project
' Calculates order total based off selection
'Programmer: Zach Murphy on 3-20-2017



Public Class Main_Form
    Private Function GetSubTotal(ByVal donut As Double, ByVal coffee As Double) As Double
        'function to determine the subtotal
        Dim subTotal As Double
        subTotal = donut + coffee
        Return subTotal
    End Function

    Private Function GetTax(ByVal orderSubTotal As Double, ByVal taxRate As Double) As Double
        'function to determine the sales tax
        Dim tax As Double
        tax = orderSubTotal * taxRate
        Return tax
    End Function

    Private Function GetOrderTotal(ByVal sTotal As Double, ByVal taxCost As Double) As Double
        'function to determine the order total
        Dim orderTotal As Double
        orderTotal = sTotal + taxCost
        Return orderTotal
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'variable declarations
        Const GLAZED As Double = 0.75
        Const SUGAR As Double = 0.75
        Const CHOC As Double = 0.75
        Const FILLED As Double = 0.95
        Const REG As Double = 1.5
        Const CAPP As Double = 2.75
        Const TAX_RATE As Double = 0.045
        Dim donutCost As Double
        Dim coffeeCost As Double
        Dim subtotal As Double
        Dim salesTax As Double
        Dim total As Double

        'determine donut cost
        If rbGlazed.Checked Then
            donutCost = GLAZED
        ElseIf rbSugar.Checked Then
            donutCost = SUGAR
        ElseIf rbChoc.Checked Then
            donutCost = CHOC
        ElseIf rbFilled.Checked Then
            donutCost = FILLED
        Else
            donutCost = 0.0
        End If

        'determine coffe cost
        If rbReg.Checked Then
            coffeeCost = REG
        ElseIf rbCapp.Checked Then
            coffeeCost = CAPP
        Else
            coffeeCost = 0.0
        End If

        'make total calculations
        'after each calculation is made round the decimals
        subtotal = GetSubTotal(donutCost, coffeeCost)
        subtotal = Math.Round(subtotal, 2)
        salesTax = GetTax(subtotal, TAX_RATE)
        salesTax = Math.Round(salesTax, 2)
        total = GetOrderTotal(subtotal, salesTax)
        total = Math.Round(total, 2)

        'format decimal places along with output
        lblSubTotal.Text = subtotal.ToString("n2")
        lblTax.Text = salesTax.ToString("n2")
        lblTotal.Text = total.ToString("n2")
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        'verify the user wants to exit the application

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Cerruti Company", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        'if the No button was selected, don't close the form
        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit the form
        Me.Close()
    End Sub

End Class
