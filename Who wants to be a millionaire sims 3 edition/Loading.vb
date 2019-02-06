Public Class frmLoading

    Private Sub frmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrLoading.Start() 'timer starts, the time is for the progress bar to start going 
        My.Computer.Audio.Play(My.Resources.The_Sims_3_all_Loading_Screens_to_Showtime, AudioPlayMode.Background) 'music starts

    End Sub

    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        prgbarLoading.Increment(1) 'progress bar adds 1 tick per second
        If prgbarLoading.Value = prgbarLoading.Maximum Then 'if the bar reaches maximum
            Me.Hide() 'this form will hide
            My.Computer.Audio.Stop() 'music stops playing
            frmGameInterface.Show() 'gameinterface form shows up
            tmrLoading.Stop() 'timer stops 
        End If
    End Sub
End Class