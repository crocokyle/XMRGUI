Public Class Profiles
    Private Sub Profiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Dim profilenamereader As System.IO.StreamReader
        profilenamereader = My.Computer.FileSystem.OpenTextFileReader(miner.profilenames)
        Do While profilenamereader.Peek() >= 0
            Dim name = profilenamereader.ReadLine
            ListBox1.Items.Add(name)
        Loop
        profilenamereader.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        miner.loadprofilenames()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim defaultprofile = ListBox1.SelectedIndex
        Dim str = defaultprofile.ToString
        If Dir(miner.defaultset) <> "" Then
            My.Computer.FileSystem.DeleteFile(miner.defaultset)
        End If
        Dim defaultwriter As System.IO.StreamWriter
        defaultwriter = My.Computer.FileSystem.OpenTextFileWriter(miner.defaultset, False)
        defaultwriter.WriteLine(str)
        defaultwriter.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x = ListBox1.SelectedIndex
        Dim newname = TextBox1.Text
        ListBox1.Items.RemoveAt(x)
        ListBox1.Items.Insert(x, newname)
        If Dir(miner.profilenames) <> "" Then
            My.Computer.FileSystem.DeleteFile(miner.profilenames)
        End If
        Dim profilenamewriter As System.IO.StreamWriter
        profilenamewriter = My.Computer.FileSystem.OpenTextFileWriter(miner.profilenames, False)
        For Each i As String In ListBox1.Items
            profilenamewriter.WriteLine(i)
        Next
        profilenamewriter.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.SelectedItem
    End Sub
End Class