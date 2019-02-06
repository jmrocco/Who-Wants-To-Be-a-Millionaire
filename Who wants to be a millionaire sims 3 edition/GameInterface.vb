Public Class frmGameInterface
    Public clicks As Integer 'clicks refers to the question 
    Public Shared money As Integer 'money is money
    Public bclicks As Integer = 1 'number of times the answer buttons have been clicked
    Public qvalue As Integer 'question value 
    Dim aclicks As String 'aclicks refers to answer clicks so the answer that goes with the question
    Dim hintclicks As Integer 'number of times the hint buttons have been clicked 
    Dim int As Integer = 30 'the timer will start at 30 seconds 
    Dim one As String 'question one answer 
    Dim two As String   'question two answer
    Dim three As String 'question three answer
    Dim four As String  'question four answer
    Dim five As String  'question five answer
    Dim six As String   'question six answer
    Dim seven As String 'question seven answer  
    Dim eight As String 'question eight answer
    Dim nine As String  'question nine answer
    Dim ten As String   'question ten answer 
    Dim eleven As String 'question eleven answer
    Dim twelve As String 'question twelve answer
    Dim thirteen As String  'question thirteen answer 
    Dim fourteen As String  'question fourteen answer
    Private Sub frmGameInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show(" Click on the 'Who Wants to be a Millionaire: Sims 3 Edition' Logo to que questions throughout the game.", "Que Questions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '(Messagebox above) When the gameinterface form loads, a messagebox will appear informing the user that to que a question, they must click the logo in the middle of the screen

    End Sub



    Private Sub btnQue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQue.Click
        clicks = clicks + 1 'a tally of how many times the que button has been clicked, the question is determined by how many times the que button is clicked 
        '(the section below) the answer for each question
        one = "Green" 'answer for question 1: Green
        two = "Depressed Individual" 'answer for question 2: Depressed Individual
        three = "All of the Above" 'answer for question 3: All of the Above
        four = "Romance" 'answer for question 4: Romance
        five = "Sims 3 Desert Island" 'answer for question 5: Sims 3 Desert Island
        six = "Barnacle Bay" 'answer for question 6: Barnacle BaY
        seven = "Italy" 'answer for question 7: Italy 
        eight = "Guitar" 'answer for question 8: Guitar
        nine = "They can do it at a pond if they have laundry soap in their inventory" 'answer for question 9: They can do it at a pond if they have laundry soap in their inventory
        ten = "Xie Li's Garden" 'answer for question 10: Xie Li's Garden
        eleven = "False" 'answer for question 11: False 
        twelve = "Symphonic" 'answer for question 12: Symphonic
        thirteen = "Teen" 'answer for question 13: Teen
        fourteen = "Jared Frio" 'answer for question 14: Jared Frio


        '(the section below) how many times the que button has been clicked determines the value of the variable 'aclicks', 
        If clicks = 1 Then 'if the que button is clicked once then the variable aclicks is now associated with the answer for question 1
            aclicks = one
            money = money + 0 'the variable "money" is being used for if the person loses, so if they lose they have 0 dollars 
        ElseIf clicks = 2 Then
            aclicks = two
            money = money + 0
        ElseIf clicks = 3 Then
            aclicks = three
            money = money + 0
        ElseIf clicks = 4 Then
            aclicks = four
            money = money + 0
        ElseIf clicks = 5 Then 'if the que button is clicked five times then aclicks is now associated with the answer for question five
            aclicks = five
            money = money + 1000 'if the person loses they will walk away with 1000 dollars
        ElseIf clicks = 6 Then
            aclicks = six
            money = money + 0
        ElseIf clicks = 7 Then
            aclicks = seven
            money = money + 0
        ElseIf clicks = 8 Then
            aclicks = eight
            money = money + 0
        ElseIf clicks = 9 Then
            aclicks = nine
            money = money + 0
        ElseIf clicks = 10 Then 'if the que button is clicked ten times then aclicks is now associated with the answer for question ten
            aclicks = ten
            money = (money - 1000) + 32000 'if the person loses they will walk away with 32000 dollars(the reason i did money-1000 was because i wanted money to be reset to 0 so i could then add 32000. money wasn't working before and this method fixed the problem)
        ElseIf clicks = 11 Then
            aclicks = eleven
            money = money + 0
        ElseIf clicks = 12 Then
            aclicks = twelve
            money = money + 0
        ElseIf clicks = 13 Then
            aclicks = thirteen
            money = money + 0
        ElseIf clicks = 14 Then
            aclicks = fourteen
            money = money + 0
        End If

        'the reason i used the logo for a que button is because i wanted the player to have the choice as to when they wanted to answer the question,
        'they have a chance to breathe before the next question pops up, since they only have 30 seconds to answer

        '(this section below) when the que button is clicked a question and multiple choice answers will appear
        If clicks = 1 Then 'if que button clicks is 1 
            Timer1.Enabled = True 'timer is now enabled
            Timer1.Start() 'timer starts
            lblQuestion.Text = " Question 1 for : $100" & vbCrLf & "What colour is the 'Sims 3' diamond?" 'question , vbcrlf is a break in the line, to make the question spread over more than 1 line. 
            btnAnswer1.Text = "Blue" ' answer
            btnAnswer2.Text = "Yellow" 'answer
            btnAnswer3.Text = "Pink" 'answer
            btnAnswer4.Text = "Green" 'answer
        ElseIf clicks = 2 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 2 for : $200" & vbCrLf & "Which of the following is not a 'Sims 3' character trait?"
            btnAnswer1.Text = "Flirty"
            btnAnswer2.Text = "Hopeless Romantic"
            btnAnswer3.Text = "Depressed individual"
            btnAnswer4.Text = "Born Salesman"
        ElseIf clicks = 3 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 3 for : $500" & vbCrLf & "The food Ambrosia requires what skills levels?"
            btnAnswer1.Text = "Cooking level 10"
            btnAnswer2.Text = "Fishing level 10"
            btnAnswer3.Text = "Gardening level 7"
            btnAnswer4.Text = "All of the Above"
        ElseIf clicks = 4 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 4 for : $1000" & vbCrLf & "Which of the following is not a Sims need?"
            btnAnswer1.Text = "Hunger"
            btnAnswer2.Text = "Romance"
            btnAnswer3.Text = "Fun"
            btnAnswer4.Text = "Social"
        ElseIf clicks = 5 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 5 for : $2000" & vbCrLf & "Which of the following is not a 'Sims 3' Expansion pack? "
            btnAnswer1.Text = "Sims 3 Late Night"
            btnAnswer2.Text = "Sims 3 Into the Future"
            btnAnswer3.Text = "Sims 3 Desert Island"
            btnAnswer4.Text = "Sims 3 Supernatural"
        ElseIf clicks = 6 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 6 for : $4000" & vbCrLf & "Which of the following Sim Towns costs SimPoints? "
            btnAnswer1.Text = "Barnacle Bay"
            btnAnswer2.Text = "Riverview"
            btnAnswer3.Text = "Shantix"
            btnAnswer4.Text = "Sunset Valley"
        ElseIf clicks = 7 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 7 for : $8000" & vbCrLf & "Which country can you not visit in 'The Sims 3: World Adventures'?"
            btnAnswer1.Text = "France"
            btnAnswer2.Text = "China"
            btnAnswer3.Text = "Egypt"
            btnAnswer4.Text = "Italy"
        ElseIf clicks = 8 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 8 for : $16,000" & vbCrLf & "Which of these is a skill from the base game?"
            btnAnswer1.Text = "Guitar"
            btnAnswer2.Text = "Martial Arts"
            btnAnswer3.Text = "Scuplting"
            btnAnswer4.Text = "Nectar Making"
        ElseIf clicks = 9 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 9 for : $32,000" & vbCrLf & "Which of these is not an option for Sims to do their laundry?"
            btnAnswer1.Text = "They can buy a washing machine and a dryer"
            btnAnswer2.Text = "They can go to the Laundromat"
            btnAnswer3.Text = "They can do it at a pond if they have laundry soap in their inventory"
            btnAnswer4.Text = "They can buy a washing machine and a clothesline"
        ElseIf clicks = 10 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 10 for : $64,000" & vbCrLf & "Which of these songs can Sims not learn to sing?"
            btnAnswer1.Text = "Oh Where is my Mummy?"
            btnAnswer2.Text = "Philipe's Kenspa"
            btnAnswer3.Text = "Xie Li's Garden"
            btnAnswer4.Text = "Je T'aime"
        ElseIf clicks = 11 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = "Question 11 for : $125,000" & vbCrLf & "What is the last name of the couple: Mortimer and Bella who are present in 'The Sims 3'."
            btnAnswer1.Text = "Crumplebottom"
            btnAnswer2.Text = "Goth"
            btnAnswer3.Text = "Rocco"
            btnAnswer4.Text = "Hicks"
        ElseIf clicks = 12 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 12 for : $250,000" & vbCrLf & "Which of these is a branch in the Music career"
            btnAnswer1.Text = "Country"
            btnAnswer2.Text = "Pop"
            btnAnswer3.Text = "Symphonic"
            btnAnswer4.Text = "Rap"
        ElseIf clicks = 13 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = " Question 13 for : $500,000" & vbCrLf & "There is a Goth Family in the sims 3, with Mortimer Goth as a...."
            btnAnswer1.Text = "Child"
            btnAnswer2.Text = "Teen"
            btnAnswer3.Text = "Young Adult"
            btnAnswer4.Text = "Elder"
        ElseIf clicks = 14 Then
            Timer1.Enabled = True
            Timer1.Start()
            lblQuestion.Text = "Question 14 for : $1,000,000!!!" & vbCrLf & "Who is the father of Claire Ursine's unborn baby?"
            btnAnswer1.Text = "Malcolm Landgraab"
            btnAnswer2.Text = "Jared Frio"
            btnAnswer3.Text = "Cycl0n3 Sw0rd"
            btnAnswer4.Text = "Christopher Steel"
        End If

        'this section of code is for, an error message will appear if you try to click the que twice in a row without answering the question
        If bclicks <> clicks Then 'bclicks(answer button clicks) is already pre-set to 1 so if at anytime bclicks and clicks are equal to each other then an error message will appear to tell you to answer the question
            Timer1.Stop() 'stop timer
            clicks = clicks - 2 'clicks subtracts 2 from its tally so it can reply the question that the person didn't answer
            btnAnswer1.Text = "" 'answer button 1's text is reset to nothing
            btnAnswer2.Text = "" 'answer button 2's text is reset to nothing
            btnAnswer3.Text = "" 'answer button 3's text is reset to nothing
            btnAnswer4.Text = "" 'answer button 4's text is reset to nothing 
            lblQuestion.Text = "" 'the question label/button is reset to nothing 
            MessageBox.Show("Please answer the question before continuing.", "Answer The Question.", MessageBoxButtons.OK, MessageBoxIcon.Error) 'messagebox with error message 

        End If

    End Sub


    Private Sub btnAnswer1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer1.Click
        bclicks = bclicks + 1 'everytime answer button 1 is clicked it adds a click to the bclicks tally 

        Select Case lblQuestion.Text 'if an answer button is pressed and there is no question it will tell you there is no question 
            Case Is = ""
                MessageBox.Show("There is no question to answer.", "No Question")
                bclicks = bclicks - 1
                GoTo Line289 ' because the system would have kept reading the code underneath which is if you get the question wrong or right; it would
                'have first told you that there is no question then it would tell you that is incorrect and the cheque would come up, i made it so that it skips over
                'the code underneath so that only the no question dialog comes up
        End Select

        Select Case clicks
            Case Is = 1, 2, 3, 4 'if it is question 1, 2 , 3 , or 4 and button 1 is clicked 
                Timer1.Stop() 'the timer will stop
                int = 30 'the timer will reset
                frmDropOut.wordmoney = "Zero ~~~~~~~~~~~~~~~~~~~~" 'money earned in words is zero dollars
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background) 'the incorrect answer sound will play
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'messagebox will appear telling you, that you have lost and will display the correct answer in the title bar
                Me.Close() 'the gameinterface form will close 
                frmCheque.Show() 'the cheque will show 
        End Select

        Select Case clicks
            Case Is = 5, 7, 9 'if the question is 5,7,9 and button 1 is clicked
                Timer1.Stop() 'timer stops
                int = 30 'timer reset
                frmDropOut.wordmoney = "One Thousand ~~~~~~~~~~~~~~~" 'they passed the 1000 mark so in words, they have earned one thousand dollars
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background) 'incorrect sound plays 
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'messagebox;incorrect, answer in title
                Me.Close() 'closes form
                frmCheque.Show() 'cheque form comes up
        End Select

        Select Case clicks
            Case Is = 10, 11, 12, 13, 14  'if it is question 10,11,12,13,14 and button 1 is clicked 
                Timer1.Stop() 'timer stops 
                int = 30 'timer resets
                frmDropOut.wordmoney = "Thirty Two Thousand ~~~~~~~~~~~~~" 'they passed the 32000 mark so in words, they have eanred thirty two thousand dollars
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background) 'incorrect sound plays
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'messagebox; incorrect, answer in title
                Me.Close() 'forms close
                frmCheque.Show() 'cheque comes up
        End Select

        Select Case clicks
            Case Is = 6, 8 'if it is question 6 or 8 and button 1 is clicked 
                Timer1.Stop() 'timer stops 
                hintclicks = hintclicks + 1 'adds a tally to the hintclick tally, the purpose of hint click is so that you can't use a hint when there is no question on the screen
                int = 30 'timer resets
                My.Computer.Audio.Play(My.Resources.Question_Right, AudioPlayMode.Background) 'correct sound plays
                MessageBox.Show("That is correct!!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information) 'messagebox; correct
                lblQuestion.Text = "" 'reset text
                btnAnswer1.Text = "" 'reset text
                btnAnswer2.Text = "" 'reset text
                btnAnswer3.Text = "" 'reset text
                btnAnswer4.Text = "" 'reset text

        End Select

        'this section are the correct answers; it's extra things that happen when the user answers correctly, the reason they are here is because i used select case and i couldn't individually write something for only one number in selct case 
Line289: If clicks = 6 Then 'if it is question 6(this is line 289, if an answer button is pressed and there is no question it will skip to this line and keep going)
            qvalue = 4000 'the variable qvalue(questionvalue) changes to 4000
            lbl4000.BackColor = Color.Green 'the question 6 spot on the progress bar lights up
        ElseIf clicks = 8 Then
            qvalue = 16000
            lbl16000.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub btnAnswer2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer2.Click
        bclicks = bclicks + 1

        Select Case lblQuestion.Text
            Case Is = ""
                MessageBox.Show("There is no question to answer.", "No Question")
                bclicks = bclicks - 1
                GoTo line355
        End Select

        Select Case clicks
            Case Is = 1, 2, 3
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "Zero~~~~~~~~~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

        Select Case clicks
            Case Is = 5, 6, 7, 8, 9
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "One Thousand~~~~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

        Select Case clicks
            Case Is = 10, 12
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "Thirty Two Thousand~~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

      
        Select Case clicks
            Case Is = 4, 11, 13
                Timer1.Stop()
                hintclicks = hintclicks + 1
                int = 30
                My.Computer.Audio.Play(My.Resources.Question_Right, AudioPlayMode.Background)
                MessageBox.Show("That is correct!!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblQuestion.Text = ""
                btnAnswer1.Text = ""
                btnAnswer2.Text = ""
                btnAnswer3.Text = ""
                btnAnswer4.Text = ""
        End Select

line355: If clicks = 4 Then
            qvalue = 1000
            lbl1000.BackColor = Color.LawnGreen
        ElseIf clicks = 11 Then
            qvalue = 125000
            lbl125000.BackColor = Color.DarkSeaGreen
        ElseIf clicks = 13 Then
            qvalue = 500000
            lbl500000.BackColor = Color.DarkOliveGreen
        End If

        If clicks = 14 Then 'if it is the final question and they choose button 2 as their answer
            Timer1.Stop() 'timer stops
            qvalue = 1000000 'question value is one million
            money = 1000000 'money is one million
            frmDropOut.wordmoney = "One Million~~~~~~~~~~~~~~~~~~~~~~~" 'money in words is one million
            lbl1000000.BackColor = Color.GreenYellow '
            MessageBox.Show("Congratulations! You have won 'Who Wants to be a Millionaire: The Sims 3 Edition!!!!!", "Congratulations!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            frmcongratulations.Show()
        End If

    End Sub

    Private Sub btnAnswer3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer3.Click
        bclicks = bclicks + 1

        Select Case lblQuestion.Text
            Case Is = ""
                MessageBox.Show("There is no question to answer.", "No Question")
                bclicks = bclicks - 1
                GoTo line434
        End Select

        Select Case clicks
            Case Is = 1, 3, 4
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "Zero~~~~~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

        Select Case clicks
            Case Is = 6, 7, 8
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "One Thousand~~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

        Select Case clicks
            Case Is = 11, 13, 14
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "Thirty Two Thousand~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

        Select Case clicks
            Case Is = 2, 5, 9, 10, 12
                Timer1.Stop()
                hintclicks = hintclicks + 1
                int = 30
                My.Computer.Audio.Play(My.Resources.Question_Right, AudioPlayMode.Background)
                MessageBox.Show("That is correct!!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblQuestion.Text = ""
                btnAnswer1.Text = ""
                btnAnswer2.Text = ""
                btnAnswer3.Text = ""
                btnAnswer4.Text = ""
        End Select

line434: If clicks = 2 Then
            qvalue = 200
            lbl200.BackColor = Color.LightSeaGreen
        ElseIf clicks = 5 Then
            qvalue = 2000
            lbl2000.BackColor = Color.LightGreen
        ElseIf clicks = 9 Then
            qvalue = 32000
            lbl32000.BackColor = Color.MediumSpringGreen
        ElseIf clicks = 10 Then
            qvalue = 64000
            lbl64000.BackColor = Color.LimeGreen
        ElseIf clicks = 12 Then
            qvalue = 250000
            lbl250000.BackColor = Color.ForestGreen
        End If


    End Sub

    Private Sub btnAnswer4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer4.Click
        bclicks = bclicks + 1

        Select Case lblQuestion.Text
            Case Is = ""
                MessageBox.Show("There is no question to answer.", "No Question")
                bclicks = bclicks - 1
                GoTo line513
        End Select

        Select Case clicks
            Case Is = 2, 4
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "Zero~~~~~~~~~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

        Select Case clicks
            Case Is = 5, 6, 8, 9
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "One Thousand~~~~~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

        Select Case clicks
            Case Is = 10, 11, 12, 13, 14
                Timer1.Stop()
                int = 30
                frmDropOut.wordmoney = "Thirty Two Thousand~~~~~~~~~~~~"
                My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
                MessageBox.Show("Sorry that is incorrect. You have lost the game.", "The Correct Answer was: " & aclicks, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                frmCheque.Show()
        End Select

        Select Case clicks
            Case Is = 1, 3, 7
                Timer1.Stop()
                hintclicks = hintclicks + 1
                int = 30
                My.Computer.Audio.Play(My.Resources.Question_Right, AudioPlayMode.Background)
                MessageBox.Show("That is correct!!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblQuestion.Text = ""
                btnAnswer1.Text = ""
                btnAnswer2.Text = ""
                btnAnswer3.Text = ""
                btnAnswer4.Text = ""

        End Select

line513: If clicks = 1 Then
            qvalue = 100
            lbl100.BackColor = Color.DarkOliveGreen
        ElseIf clicks = 3 Then
            qvalue = 500
            lbl500.BackColor = Color.ForestGreen
        ElseIf clicks = 7 Then
            qvalue = 8000
            lbl8000.BackColor = Color.DarkOliveGreen
        End If


    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000 'the timer interval is 1 second 
        lblCounter.Text = int 'the lbl that is being used for the timer will correspond to int which is the time on the timer
        int -= 1 'timer counts down
        If int = 0 And clicks < 5 Then 'if the timer hits 0 and the question is less than 5 then
            lblCounter.Text = "0" 'timer will say 0
            Timer1.Stop() 'timer stops
            Timer1.Enabled = False 'timer is now not enabled 
            My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background) 'wrong answer sound
            frmDropOut.wordmoney = "Zero~~~~~~~~~~~~~~~~" 'the person didn't pass the 1000 mark so they earned zero in words
            MessageBox.Show("You have not answered in time! You have lost the game!!!", "The answer was:" & aclicks) 'messagebox; you've lost, correct answer in title 
            frmCheque.Show() 'cheque comes up
            Me.Close() 'gameinterface form closes
        ElseIf int = 0 And clicks < 9 Then 'if the timer hits 0 and the question is less than 9 then
            lblCounter.Text = "0"
            Timer1.Stop()
            Timer1.Enabled = False
            My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
            frmDropOut.wordmoney = "One Thousand~~~~~~~~~~~~~~~~" 'the person passed the 1000 mark so they earned one thousand in words 
            MessageBox.Show("You have not answered in time! You have lost the game!!!", "The answer was:" & aclicks)
            frmCheque.Show()
            Me.Close()
        ElseIf int = 0 And clicks < 14 Then 'if the timer hits 0 and the question is less than 14 then
            lblCounter.Text = "0"
            Timer1.Stop()
            Timer1.Enabled = False
            My.Computer.Audio.Play(My.Resources.Question_Wrong, AudioPlayMode.Background)
            frmDropOut.wordmoney = "Thirty Two Thousand~~~~~~~~~~~~~~~~" 'the person passed the 32000 mark so they earned thiry two thousand in words
            MessageBox.Show("You have not answered in time! You have lost the game!!!", "The answer was:" & aclicks)
            frmCheque.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnMoney_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoney.Click
        frmMoney.Show() 'if the money button is clicked it will bring up the money form which tells you how much money you earned 
        My.Computer.Audio.Play(My.Resources.cha_ching_wav, AudioPlayMode.Background)

    End Sub

    Private Sub btnDropOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDropOut.Click
        My.Computer.Audio.Play(My.Resources.boo_wav, AudioPlayMode.Background)
        frmDropOut.Show() 'if you click the drop out button it will bring up the drop out form

    End Sub

    Private Sub btn50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn50.Click
        If hintclicks = clicks Then 'if hintclicks tally is equal to clicks then the system knows that there is no question displayed right now so a hint cannot be used
            MessageBox.Show("You cannot use a hint right now.", "Cannot Use Hint", MessageBoxButtons.OK) 'error message; you can't use a hint right now
        ElseIf clicks = 1 Then 'if it's question 1 and the 50/50 button is clicked then
            Timer1.Stop() 'timer stops 
            MessageBox.Show("Pink and Blue are incorrect answers.", "Do not choose these answers:50/50 chance") 'it tells you which 2 answers are incorrect
            Timer1.Start() 'timer starts 
            btn50.Hide() 'button goes away and can't be used again
        ElseIf clicks = 2 Then
            Timer1.Stop()
            MessageBox.Show("Born Salesman and Flirty are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 3 Then
            Timer1.Stop()
            MessageBox.Show("Gardening Level 7 and Fishing Level 10 are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 4 Then
            Timer1.Stop()
            MessageBox.Show("Hunger and Social are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 5 Then
            Timer1.Stop()
            MessageBox.Show("Sims 3 Late Night and Sims 3 Into the Future are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 6 Then
            Timer1.Stop()
            MessageBox.Show("Riverview and Sunset Valley are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 7 Then
            Timer1.Stop()
            MessageBox.Show("France and Egypt are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 8 Then
            Timer1.Stop()
            MessageBox.Show("Scuplting and Nectar Making are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 9 Then
            Timer1.Stop()
            MessageBox.Show("They can buy a washing machine and a dryer and They can go to the Laundromat are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 10 Then
            Timer1.Stop()
            MessageBox.Show("Oh Where is my Mummy? and Je T'aime are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 11 Then
            Timer1.Stop()
            MessageBox.Show("Rocco and Hicks are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 12 Then
            Timer1.Stop()
            MessageBox.Show("Rap and Country are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 13 Then
            Timer1.Stop()
            MessageBox.Show("Child and Young Adult are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        ElseIf clicks = 14 Then
            Timer1.Stop()
            MessageBox.Show("Christopher Steel and Malcolm Landgraab are incorrect answers.", "Do not choose these answers:50/50 chance")
            Timer1.Start()
            btn50.Hide()
        End If
    End Sub

    Private Sub btnPhoneF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoneF.Click
        If hintclicks = clicks Then 'if hintclicks tally is equal to clicks then the system knows that there is no question displayed right now so a hint cannot be used
            MessageBox.Show("You cannot use a hint right now.", "Cannot Use Hint", MessageBoxButtons.OK) 'error message saying you can't use hints right now
        ElseIf hintclicks <> clicks Then 'if hint clicks is not equal to clicks then the system knows that there is a question displayed so it 
            Timer1.Stop() 'stops the timer
            frmPhone.Show() 'brings up the phone a friend form 
            My.Computer.Audio.Play(My.Resources.phone_dial_wav, AudioPlayMode.Background) 'plays music 
        End If


    End Sub

    Private Sub btnPollAud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPollAud.Click
        If hintclicks = clicks Then 'if hintclicks tally is equal to clicks then the system knows that there is no question displayed right now so a hint cannot be used
            MessageBox.Show("You cannot use a hint right now.", "Cannot Use Hint", MessageBoxButtons.OK) 'error message saying you can't a hint
        ElseIf clicks = 1 Then 'if it is question 1 then
            Timer1.Stop() 'timer stops 
            MessageBox.Show("The Sims 3 Diamond is on this page.", "Hint") 'a hint is displayed in a messagebox
            Timer1.Start() 'timer stars where it left off 
            btnPollAud.Hide() 'the hint/poll the audience button goes away and cannot be used again
        ElseIf clicks = 2 Then
            Timer1.Stop()
            MessageBox.Show("Sims are never just depressed.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 3 Then
            Timer1.Stop()
            MessageBox.Show("Ambrosia is made up of fish, and garden ingredients which require a very high cooking level experience.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 4 Then
            Timer1.Stop()
            MessageBox.Show("Sims do not have to have a significant other.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 5 Then
            Timer1.Stop()
            MessageBox.Show("Sims are never required to use or have survival skills.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 6 Then
            Timer1.Stop()
            MessageBox.Show("Consists of two words. First Word containing the letter a.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 7 Then
            Timer1.Stop()
            MessageBox.Show("' When in ____' (popular phrase).", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 8 Then
            Timer1.Stop()
            MessageBox.Show("It's music.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 9 Then
            Timer1.Stop()
            MessageBox.Show("Laundry soap is rarely used in the game.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 10 Then
            Timer1.Stop()
            MessageBox.Show("Garden.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 11 Then
            Timer1.Stop()
            MessageBox.Show("They are a very 'gothic' family.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 12 Then
            Timer1.Stop()
            MessageBox.Show("Starts with an S.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 13 Then
            Timer1.Stop()
            MessageBox.Show("Mortimer Goth is in high school.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()
        ElseIf clicks = 14 Then
            Timer1.Stop()
            MessageBox.Show("Jared and Claire were once in love.", "Hint")
            Timer1.Start()
            btnPollAud.Hide()

        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmRules.Show() 'if under the menu, rules is clicked, rules will be displayed for the user to read

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'if under the menu, exit is clicked, the application shuts down
    End Sub
End Class
