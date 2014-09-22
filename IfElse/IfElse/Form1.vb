Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        ' Modify the program such that it does not crash 
        ' if the user types incorrect input

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text


        'Checkpoint for non-numeric values
        If Not (IsNumeric(st1) And IsNumeric(st2)) Then
            MessageBox.Show("Please Type a Number.")
            Return
        End If

        'Now the program can proceed with correct inputs.
        num1 = CDbl(st1)
        num2 = CDbl(st2)


        'After the input is checked as an integer, it is now checked for negative values.
        If Not ((CDbl(st1) > 0) And (CDbl(st2) > 0)) Then
            MessageBox.Show("Type a Positive Integer.")
            Return
        End If

        Dim result As String

        If num1 > num2 Then
            result = "The larger number is " & num1
        ElseIf num2 > num1 Then
            result = "The larger number is " & num2

        Else
            result = "They are equal"
        End If


        txtResult.Text = result


    End Sub

End Class
