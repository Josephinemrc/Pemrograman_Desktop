Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputDecimal As Integer
        If Integer.TryParse(txtbasis10.Text, inputDecimal) Then

            Dim binary As String = Convert.ToString(inputDecimal, 2)
            txtBasis2.Text = binary
            Dim octal As String = Convert.ToString(inputDecimal, 8)
            txtBasis8.Text = octal
            Dim hex As String = Convert.ToString(inputDecimal, 16)
            txtBasis16.Text = hex.ToUpper()
        Else
            MsgBox("Input harus bilangan bulat!")
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
