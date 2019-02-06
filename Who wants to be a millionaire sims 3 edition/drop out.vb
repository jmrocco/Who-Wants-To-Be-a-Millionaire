Public Class frmDropOut
    Public wordmoney As String
    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        frmCheque.Show() 'if yes is clicked then the cheque will come up
        frmGameInterface.Close() 'the gameinterface form will close
        Me.Close() 'this form will close
      
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Me.Close() 'if no is clicked then this form closes
    End Sub

    Private Sub frmDropOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'the purpose of this section is that, the system knows how many questions you have correctly answered so if you click drop out it uses the number of times an answer button has been clicked to determine your winnings thus far in the game 
        If frmGameInterface.bclicks = 1 Then 'if bclicks is 1 then the system knows that no question was answered at all so 
            lblmoney.Text = "Nothing" 'they earned no money so it will say that they earned nothing are you sure you want to drop out
            frmGameInterface.money = 0 'no money in dollars
            wordmoney = "Zero~~~~~~~~~~~~~~" 'money in words is zero
        ElseIf frmGameInterface.bclicks = 2 Then
            lblmoney.Text = "$100"
            frmGameInterface.money = 100
            wordmoney = "One Hundred~~~~~~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 3 Then
            lblmoney.Text = "$200"
            frmGameInterface.money = 200
            wordmoney = "Two Hundred~~~~~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 4 Then
            lblmoney.Text = "$500"
            frmGameInterface.money = 500
            wordmoney = "Five Hundred~~~~~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 5 Then
            lblmoney.Text = "$1000"
            frmGameInterface.money = 1000
            wordmoney = "One Thousand~~~~~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 6 Then
            lblmoney.Text = "$2000"
            frmGameInterface.money = 2000
            wordmoney = "Two Thousand~~~~~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 7 Then
            lblmoney.Text = "$4000"
            frmGameInterface.money = 4000
            wordmoney = "Four Thousand~~~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 8 Then
            lblmoney.Text = "$8000"
            frmGameInterface.money = 8000
            wordmoney = "Eight Thousand~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 9 Then
            lblmoney.Text = "$16000"
            frmGameInterface.money = 16000
            wordmoney = "Sixteen Thousand~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 10 Then
            lblmoney.Text = "$32000"
            frmGameInterface.money = 32000
            wordmoney = "Thirty Two Thousand~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 11 Then
            lblmoney.Text = "$64000"
            frmGameInterface.money = 64000
            wordmoney = "Sixty Four Thousand~~~~~~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 12 Then
            lblmoney.Text = "$125000"
            frmGameInterface.money = 125000
            wordmoney = "One Hundred Twenty Five Thousand~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 13 Then
            lblmoney.Text = "$250000"
            frmGameInterface.money = 250000
            wordmoney = "Two Hundred Fifty Thousand~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 14 Then
            lblmoney.Text = "$500000"
            frmGameInterface.money = 5000000
            wordmoney = "Five Hundred Thousand~~~~~~~~~~~~~~~~~~"
        ElseIf frmGameInterface.bclicks = 15 Then
            lblmoney.Text = "$1000000"
            frmGameInterface.money = 1000000
            wordmoney = "One Million~~~~~~~~~~~~~~~~~~"
        End If
    End Sub
End Class