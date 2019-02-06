Public Class frmMoney
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.Close() 'if the okay button is clicked then the money form closes
    End Sub

    Private Sub frmMoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWinings.Text = FormatCurrency(frmGameInterface.qvalue, 0) 'when the form comes up it will display the money that has so far been earned
    End Sub
End Class