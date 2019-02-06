Public Class frmOpening
    Public firstname As String 'firstname is in words
    Public lastname As String 'lastname is in words


    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.Click
        firstname = txtFirstName.Text 'first name is whatever is entered in the firstname text box
        lastname = txtLastName.Text 'last name is whatever is entered in the lastname text box

        If firstname Is "" Then 'if first name text box is left empty then
            MessageBox.Show("Please Enter your first name.", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Error) 'messagebox saying enter first name 
        ElseIf lastname Is "" Then 'if last name text box is left empty then
            MessageBox.Show("Please Enter your last name.", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error) 'messagebox saying enter last name 
        End If
        If lastname <> "" And firstname <> "" Then 'if last name and first name are not equal to nothing, so they're filled in, then 
            frmLoading.Show() 'the loading screen will show
            Me.Hide() 'this opening form is hidden

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'if exit is clicked on in the menu then the application shuts down
    End Sub

    Private Sub AboutTheCreatorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutTheCreatorToolStripMenuItem.Click
        frmAbout.Show() 'if about is clicked on in the menu then the about form will pop up
    End Sub

    Private Sub GameRulesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GameRulesToolStripMenuItem.Click
        frmRules.Show() 'if rules is clicked on in the menu then the rules form will pop up
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        'if start is clicked in the menu instead of the button it repeats the same process as in the start button

        firstname = txtFirstName.Text
        lastname = txtLastName.Text 

        If firstname Is "" Then
            MessageBox.Show("Please Enter your first name.", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf lastname Is "" Then
            MessageBox.Show("Please Enter your last name.", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If lastname <> "" And firstname <> "" Then
            frmLoading.Show()
            Me.Hide()
        End If
    End Sub

End Class
