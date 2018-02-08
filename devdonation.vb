Public Class devdonation
    Public donatelevel
    Public savedlevel
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        donatelevel = NumericUpDown1.Value
        miner.mydv = NumericUpDown1.Value
        If donatelevel = 100 Then
            miner.devdonatetimer.Interval = 6000000 * (donatelevel / 100)
            miner.userminingtimer.Interval = 1
            savedlevel = NumericUpDown1.Value
        Else
            miner.devdonatetimer.Interval = 6000000 * (donatelevel / 100)
            miner.userminingtimer.Interval = 6000000 * ((100 - donatelevel) / 100)
            savedlevel = NumericUpDown1.Value
        End If
        miner.savesettings()
        miner.loadsettings(miner.configfile)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Button2.Enabled = True
    End Sub
    Private Sub devdonation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miner.loadsettings(miner.configfile)
        Dim intlevel = Convert.ToInt32(savedlevel)
        If intlevel < 1 Then
        Else
            NumericUpDown1.Value = intlevel
        End If
    End Sub
End Class