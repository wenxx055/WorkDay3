Option Strict On 'by Yunfan Wen, wenxx055, student ID 3938779

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        '-----isNumeric check, calculation and display-----
        Dim FirstNumber As Double
        Dim SecondNumber As Double

        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) = True Then
            FirstNumber = CDbl(txtFirstNum.Text)
            SecondNumber = CDbl(txtSecondNum.Text)

            If FirstNumber - SecondNumber > 0 Then
                txtResult.Text = CStr(FirstNumber) & " is larger"
            ElseIf FirstNumber - SecondNumber < 0 Then
                txtResult.Text = CStr(SecondNumber) & " is larger"
            ElseIf FirstNumber - SecondNumber = 0 Then
                txtResult.Text = "They are equal"
            End If

            '-----numeric check fail message-----
        Else
            MessageBox.Show("Please enter a valid number")
        End If

    End Sub
End Class