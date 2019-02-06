Public Class frmPhone

    Private Sub picCarson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picCarson.Click
        'the following code is all if carson is clicked to ask about an answer for a question, carson 70% of the time doesn't give correct answers 

        If frmGameInterface.clicks = 1 Then 'if it is question 1
            MessageBox.Show("Hey!, What a loser! You don't know the colour of the Sims 3 diamond!!! HAHAHA, i think it's pink.", "Carson.K On the Phone") 'carson will tell you his opinion
            frmGameInterface.Timer1.Start() 'timer in gameinterface will start once you leave his comment
            frmGameInterface.btnPhoneF.Hide() 'phone button hides and can no longer be used
            Me.Close()
        ElseIf frmGameInterface.clicks = 2 Then
            MessageBox.Show("Hey!, What a loser! You don't know which one is not a Sims 3 trait!!! HAHAHA, i think it's Depressed Individual.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 3 Then
            MessageBox.Show("Hey!, What a loser! You don't know which skills you need to make Ambrosia in the Sims 3!!  HAHAHA, i think it's All the Above.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 4 Then
            MessageBox.Show("Hey!, What a loser! You don't know which which Sims 3 need!! HAHAHA, i think it's fun.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 5 Then
            MessageBox.Show("Hey!, What a loser! You don't know which one isn't an expansion pack!! HAHAHA, i think it's Sims 3 Late Night.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 6 Then
            MessageBox.Show("Hey!, What a loser! You don't know which one you have to pay for!! HAHAHA, i think it's Sims 3 Shantix.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 7 Then
            MessageBox.Show("Hey!, What a loser! You don't know which country you can't visit!! HAHAHA, i think it's Italy.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 8 Then
            MessageBox.Show("Hey!, What a loser! You don't know the answer!! HAHAHA, i think it's Guitar.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 9 Then
            MessageBox.Show("Hey!, What a loser! You don't know the answer!! HAHAHA, i think it's They can do it at a pond if they have laundry soap in their inventory.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 10 Then
            MessageBox.Show("Hey!, What a loser! You don't know the answer!! HAHAHA, i think it's Philipe's Kenspa.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 11 Then
            MessageBox.Show("Hey!, What a loser! You don't know the answer!! HAHAHA, i think it's Rocco.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 12 Then
            MessageBox.Show("Hey!, What a loser! You don't know the answer!! HAHAHA, i think it's Pop.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 13 Then
            MessageBox.Show("Hey!, What a loser! You don't know the answer!! HAHAHA, i think it's Teen.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 14 Then
            MessageBox.Show("Hey!, What a loser! You don't know the answer!! HAHAHA, i think it's Christopher Steel.", "Carson.K On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()

        End If
    End Sub

    Private Sub picJuliette_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picJuliette.Click
        MessageBox.Show("You can't call yourself please select another person.", "Please Call Someone Else") 'if you click Juliette it will tell you that you can't click yourself because the phone that you're using belongs to juliette
    End Sub

    Private Sub picAlek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAlek.Click
        MessageBox.Show("Hey, sorry i can't talk right now i'm hanging out with Jordan, Matt, Eli, Jake, and James, which means they also aren't available. Why don't you call Alejandra or Carson?", "Alek. M On the Phone")
        'if you click alek or any of the other guys they will all tell you that they are busy hanging out with each other and that you should call Alejandra or Carson because they are the only free people
    End Sub

    Private Sub picJake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picJake.Click
        MessageBox.Show("Hey, sorry i can't talk right now i'm hanging out with Jordan, Matt, Eli, Alek,  and James, which means they also aren't available. Why don't you call Alejandra or Carson?", "Jake. G On the Phone")
    End Sub

    Private Sub picMatt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMatt.Click
        MessageBox.Show("Hey, sorry i can't talk right now i'm hanging out with Jordan, Jake, Eli, Alek,  and James, which means they also aren't available. Why don't you call Alejandra or Carson?", "Matt. C On the Phone")
    End Sub

    Private Sub picJordan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picJordan.Click
        MessageBox.Show("Hey, sorry i can't talk right now i'm hanging out with Matt, Jake, Eli, Alek,  and James, which means they also aren't available. Why don't you call Alejandra or Carson?", "Jordan. C On the Phone")
    End Sub

    Private Sub picEli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picEli.Click
        MessageBox.Show("Hey, sorry i can't talk right now i'm hanging out with Matt, Jake, Jordan, Alek,  and James, which means they also aren't available. Why don't you call Alejandra or Carson?", "Eli. A On the Phone")
    End Sub

    Private Sub picJames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picJames.Click
        MessageBox.Show("Hey, sorry i can't talk right now i'm hanging out with Matt, Jake, Eli, Alek, and Jordan which means they also aren't available. Why don't you call Alejandra or Carson?", "James. H On the Phone")
    End Sub

    Private Sub picAlejandra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAlejandra.Click
        'if alejandra is clicked she will give you her opinion, alejandra is 0% correct on all questions 
        If frmGameInterface.clicks = 1 Then 'if it is question 1 then
            MessageBox.Show("Hey!, I think the answer is pink.", "Alejandra. L On the Phone") 'alejandra gives you a wrong answer
            frmGameInterface.Timer1.Start() 'timer in gameinterface starts
            frmGameInterface.btnPhoneF.Hide() 'button phone a friend is disabled
            Me.Close()
        ElseIf frmGameInterface.clicks = 2 Then
            MessageBox.Show("Hey!, I think the answer is flirty.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 3 Then
            MessageBox.Show("Hey!, I think the answer is level 10 Cooking.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 4 Then
            MessageBox.Show("Hey!, I think the answer is fun.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 5 Then
            MessageBox.Show("Hey!, I think the answer is Sims 3 Late Night.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 6 Then
            MessageBox.Show("Hey!, I think the answer is Sims 3 Shantix.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 7 Then
            MessageBox.Show("Hey!, I think the answer is China.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 8 Then
            MessageBox.Show("Hey!, I think the answer is nectar making.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 9 Then
            MessageBox.Show("Hey!, I think the answer is they can buy a washing machine and a clothesline", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 10 Then
            MessageBox.Show("Hey!, I think the answer is Philipe's Kenspa.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 11 Then
            MessageBox.Show("Hey!, I think the answer is Rocco.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 12 Then
            MessageBox.Show("Hey!, I think the answer is Pop.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 13 Then
            MessageBox.Show("Hey!, I think the answer is child.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()
        ElseIf frmGameInterface.clicks = 14 Then
            MessageBox.Show("Hey!, I think the answer is Christopher Steel.", "Alejandra. L On the Phone")
            frmGameInterface.Timer1.Start()
            frmGameInterface.btnPhoneF.Hide()
            Me.Close()

        End If
    End Sub

    Private Sub picCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCancel.Click
        Me.Close() 'if you click the cancel button on the phone this form will close
        frmGameInterface.Timer1.Start() 'timer restarts,  the phone button is not disabled because they didn't use a contact
    End Sub

    Private Sub picRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRefresh.Click
        MessageBox.Show("There is nothing to refresh.") 'if they click the refresh button, it tells them there is nothing to refresh 
    End Sub
End Class