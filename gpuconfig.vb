Public Class gpuconfig
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub gpuconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ' RECONFIGURE THE DISPLAY BASED ON GPU DETECTION
        If miner.settings.nvcards = "True" Then
            nvconfigtextbox.Visible = True
            nvlabel.Visible = True
        End If
        If miner.settings.amdcards = "True" Then
            amdconfigtextbox.Visible = True
            amdlabel.Visible = True
        End If
        If miner.settings.nvcards = "False" AndAlso miner.settings.amdcards = "False" Then
            cpuconfigtextbox.Size = New System.Drawing.Size(831, 571)
        End If
        If miner.settings.nvcards = "True" AndAlso miner.settings.amdcards = "False" Then
            Me.Size = New System.Drawing.Size(856, 382)
            Button1.Location = New Point(10, 332)
            Button2.Location = New Point(640, 332)
            Me.CenterToScreen()
        End If
        If miner.settings.nvcards = "False" AndAlso miner.settings.amdcards = "True" Then
            Me.Size = New System.Drawing.Size(856, 382)
            Button1.Location = New Point(10, 332)
            Button2.Location = New Point(640, 332)
            amdconfigtextbox.Location = New Point(432, 35)
            amdlabel.Location = New Point(772, 9)
            Me.CenterToScreen()
        End If
        ' END GRAPHICAL CONFIGURATION

        ' BEGIN LOADING GPU CONFIG FILES
        If Dir(miner.cpuconfigfile) <> "" Then
            cpuconfigtextbox.LoadFile(miner.cpuconfigfile, RichTextBoxStreamType.PlainText)
        End If
        If miner.settings.nvcards = "True" Then
            If Dir(miner.nvconfigfile) <> "" Then
                nvconfigtextbox.LoadFile(miner.nvconfigfile, RichTextBoxStreamType.PlainText)
            End If
        End If
        If miner.settings.amdcards = "True" Then
            If Dir(miner.amdconfigfile) <> "" Then
                amdconfigtextbox.LoadFile(miner.amdconfigfile, RichTextBoxStreamType.PlainText)
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If miner.settings.nvcards = "True" Then
            nvconfigtextbox.SaveFile(miner.nvconfigfile, RichTextBoxStreamType.PlainText)
        End If
        If miner.settings.amdcards = "True" Then
            amdconfigtextbox.SaveFile(miner.amdconfigfile, RichTextBoxStreamType.PlainText)
        End If
        cpuconfigtextbox.SaveFile(miner.cpuconfigfile, RichTextBoxStreamType.PlainText)
        Me.Hide()
    End Sub
End Class