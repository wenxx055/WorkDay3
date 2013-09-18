Option Strict On 'by Yunfan Wen, wenxx055, student ID 3938779

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        '-----isNumeric check-----
        Dim FirstNumber As Double
        Dim SecondNumber As Double

        FirstNumber = CDbl(txtFirstNum.Text)
        SecondNumber = CDbl(txtSecondNum.Text)

        '-----calculation and display-----
        If FirstNumber - SecondNumber > 0 Then
            txtResult.Text = CStr(FirstNumber)
        End If

        If FirstNumber - SecondNumber < 0 Then
            txtResult.Text = CStr(SecondNumber)
        End If

        If FirstNumber - SecondNumber = 0 Then
            txtResult.Text = "The two are equal"
        End If

    End Sub

End Class
