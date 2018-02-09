
Public Class HashrateMonitor



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        miner.HRMactive = False
        Dim convertcmd As String
        Dim convertarg As String
        convertcmd = TextBox1.Text
        convertarg = TextBox2.Text
        Dim doubleslash As String = Chr(92) & Chr(92)
        convertcmd = convertcmd.Replace("\", doubleslash)
        convertarg = convertarg.Replace("\", doubleslash)
        miner.OCCommand = convertcmd
        miner.OCArgs = convertarg
        miner.savesettings()
        miner.loadsettings(miner.configfile)
        Me.Hide()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            NumericUpDown1.Maximum = 1000000000
            NumericUpDown1.Value = 1000
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            NumericUpDown1.Maximum = 99
            NumericUpDown1.Value = 95
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        miner.HRMactive = True
        If RadioButton1.Checked = True Then
            miner.perchs = "%"
        Else
            miner.perchs = "H/s"
        End If
        miner.HRMValue = NumericUpDown1.Value
        miner.HRMTime = NumericUpDown2.Value
        If CheckBox1.Checked = True Then
            miner.OCon = True
        Else
            miner.OCon = False
        End If
        Dim convertcmd As String
        Dim convertarg As String
        convertcmd = TextBox1.Text
        convertarg = TextBox2.Text
        Dim doubleslash As String = Chr(92) & Chr(92)
        convertcmd = convertcmd.Replace("\", doubleslash)
        convertarg = convertarg.Replace("\", doubleslash)
        miner.OCCommand = convertcmd
        miner.OCArgs = convertarg
        miner.savesettings()
        miner.loadsettings(miner.configfile)
        Me.Hide()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox1.Text = OpenFileDialog1.FileName.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Title = "Please Select a Program To Run When Hashrates Drop"
        OpenFileDialog1.InitialDirectory = "C:\Users"
        OpenFileDialog1.FileName = "OCProgram.exe"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button3.Enabled = True
            TextBox2.Enabled = True
            Button4.Enabled = True
        Else
            Button3.Enabled = False
            TextBox2.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim args As String
        args = TextBox2.Text
        If TextBox2.Text = "Args" Then
            args = ""
        End If
        Process.Start(TextBox1.Text, args)
    End Sub
End Class