Public Class frmcongratulations

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        frmCheque.Show() 'cheque will show
        My.Computer.Audio.Stop()
        Me.Close() 'this form closes
    End Sub

    Private Sub frmcongratulations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Congrats_sound, AudioPlayMode.Background) 'music starts
    End Sub
End Class