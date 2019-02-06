Public Class frmCheque

    Private Sub frmCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblWordMoney.Text = frmDropOut.wordmoney 'the money in words is displayed
        Me.lblmoney.Text = FormatCurrency(frmGameInterface.money, 2) 'money is displayed
        Me.lblDate.Text = DateAndTime.Today 'todays date is displayed
        Me.lblFirstname.Text = frmOpening.firstname 'first name is displayed
        Me.lblLastname.Text = frmOpening.lastname 'last name is displayed
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog() 'if print is clicked then the print dialog comes up
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit() 'if the close button is clicked in the menu then the application exits 
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit() 'if the close button is clicked then the application exits 

    End Sub
End Class