Imports System.IO
Imports System.Text
Imports System.Net
Imports Microsoft.Win32.TaskScheduler
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.WinForms
Imports System.Windows.Media
Imports System.ComponentModel

Public Class miner
    Dim a, b As Integer
    Dim newPoint As New System.Drawing.Point()
    Dim currentversion = "v1.0"
    Dim self = Application.ExecutablePath
    Dim objShell = CreateObject("WScript.Shell")
    Dim oFSO = CreateObject("Scripting.FileSystemObject")
    Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
    Dim configfile = strAppData & "\XMRGUI\config.dat"
    Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
    Dim xmrconfig = strAppData & "\XMRGUI\config.txt"
    Dim xmrstak = strAppData & "\XMRGUI\xmr-stak.exe"
    Dim xmroutput = strAppData & "\XMRGUI\output.txt"
    Dim xmroutput2 = strAppData & "\XMRGUI\output2.txt"
    Dim xmrguidir = strAppData & "\XMRGUI"
    Dim addr = strAppData & "\XMRGUI\addr.dat"
    Dim pool = strAppData & "\XMRGUI\pool.dat"
    Dim portf = strAppData & "\XMRGUI\port.dat"
    Dim password = strAppData & "\XMRGUI\password.dat"
    Dim idlebat = strAppData & "\XMRGUI\xmridle.bat"
    Dim startupbat = strAppData & "\Microsoft\Windows\Start Menu\Programs\Startup\xmrgui.bat"
    Dim serverversion = strAppData & "\XMRGUI\serverversion.txt"
    Dim clientversion = strAppData & "\XMRGUI\version.txt"
    Dim WithEvents versioncheck As New WebClient
    Dim refreshinteger As Int32
    Dim refreshrate = 10000
    Dim lastlinetb = "test"
    Dim lastLine As String = Nothing ' same here
    Private Sub ab_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        a = MousePosition.X - Me.Location.X
        b = MousePosition.Y - Me.Location.Y
    End Sub



    Private Sub ab_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            newPoint = MousePosition
            newPoint.X = newPoint.X - a
            newPoint.Y = newPoint.Y - b
            Me.Location = newPoint
        End If
    End Sub


    Private Sub TrayOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrayOnlyToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        timerclearlog.Enabled = True
        timerclearlog.Start()
        If Dir(xmroutput) <> "" Then
            Try
                My.Computer.FileSystem.DeleteFile(xmroutput)
            Catch ex As Exception
                'clearing during same session throws exception
            End Try

        End If
        If poolurl.Text = "" Or xmraddr.Text = "" Or poolpass.Text = "" Then
            MsgBox("Please enter a Pool URL, Password, and XMR Address.")
        Else
            poolurl.Enabled = False
            poolpass.Enabled = False
            xmraddr.Enabled = False
            port.Enabled = False
            refreshint.Enabled = False
            startbtn.Enabled = False
            stopbtn.Enabled = True
            writeuserconfig()
        End If

    End Sub
    Private Sub writeuserconfig()
        Dim xmraddress = xmraddr.Text
        Dim pooladdress = poolurl.Text
        Dim poolpassword = poolpass.Text
        Dim poolport = port.Value
        If Dir(xmrconfig) <> "" Then
            Try
                My.Computer.FileSystem.DeleteFile(xmrconfig)
            Catch ex As Exception
                MsgBox(ex)
            End Try

        End If
        'write adress file for GUI
        If Dir(addr) <> "" Then
            My.Computer.FileSystem.DeleteFile(addr)
        End If
        Dim afile As System.IO.StreamWriter
        afile = My.Computer.FileSystem.OpenTextFileWriter(addr, True)
        afile.WriteLine(xmraddress)
        afile.Close()
        'write pool file for GUI
        If Dir(pool) <> "" Then
            My.Computer.FileSystem.DeleteFile(pool)
        End If
        Dim pfile As System.IO.StreamWriter
        pfile = My.Computer.FileSystem.OpenTextFileWriter(pool, True)
        pfile.WriteLine(pooladdress)
        pfile.Close()
        'write port file for GUI
        If Dir(portf) <> "" Then
            My.Computer.FileSystem.DeleteFile(portf)
        End If
        Dim portfile As System.IO.StreamWriter
        portfile = My.Computer.FileSystem.OpenTextFileWriter(portf, True)
        portfile.WriteLine(poolport)
        portfile.Close()
        'write password file for GUI
        If Dir(password) <> "" Then
            My.Computer.FileSystem.DeleteFile(password)
        End If
        Dim passfile As System.IO.StreamWriter
        passfile = My.Computer.FileSystem.OpenTextFileWriter(password, True)
        passfile.WriteLine(poolpassword)
        passfile.Close()
        'write config for xmr-stak
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(xmrconfig, True)
        file.WriteLine("""pool_list"" :")
        file.WriteLine("[")
        file.WriteLine("	{""pool_address"" : """ & pooladdress & ":" & poolport & """, ""wallet_address"" : """ & xmraddress & """, ""pool_password"" : """ & poolpassword & """, ""use_nicehash"" : false, ""use_tls"" : false, ""tls_fingerprint"" : """", ""pool_weight"" : 1 },")
        file.WriteLine("],")
        file.WriteLine("""currency"" : ""monero"",")
        file.WriteLine("""call_timeout"" : 10,")
        file.WriteLine("""retry_time"" : 30,")
        file.WriteLine("""giveup_limit"" : 0,")
        file.WriteLine("""verbose_level"" : 4,")
        file.WriteLine("""print_motd"" : true,")
        file.WriteLine("""h_print_time"" : 3,")
        file.WriteLine("""aes_override"" : null,")
        file.WriteLine("""use_slow_memory"" : ""warn"",")
        file.WriteLine("""tls_secure_algo"" : true,")
        file.WriteLine("""daemon_mode"" : false,")
        file.WriteLine("""flush_stdout"" : true,")
        file.WriteLine("""output_file"" : ""output.txt"",")
        file.WriteLine("""httpd_port"" : 8080,")
        file.WriteLine("""http_login"" : """",")
        file.WriteLine("""http_pass"" : """",")
        file.WriteLine("""prefer_ipv4"" : true,")
        file.Close()
        startminer()
    End Sub
    Private Sub startminer()
        Dim startInfo As New ProcessStartInfo
        With startInfo
            .UseShellExecute = True
            .FileName = xmrstak
            .WindowStyle = ProcessWindowStyle.Hidden
            .Verb = "runas" 'add this to prompt for elevation
            '.Arguments = "-c " & xmrconfig
        End With
        Dim proc = Process.Start(startInfo)
        Timer1.Interval = refreshrate
        Timer1.Enabled = True
        Timer1.Start()
        Button1.Enabled = False
        userminingtimer.Enabled = True
        userminingtimer.Start()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub RunGPUSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunGPUSetupToolStripMenuItem.Click
        Dim self = Application.ExecutablePath
        Dim objShell = CreateObject("WScript.Shell")
        Dim oFSO = CreateObject("Scripting.FileSystemObject")
        Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
        Dim configfile = strAppData & "\XMRGUI\config.dat"
        Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
        My.Computer.FileSystem.DeleteFile(configfile)
        Form1.Show()
        Threading.Thread.Sleep(1000)
        Me.Hide()
    End Sub
    Private Sub frmSimple_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Process.GetProcessesByName("xmr-stak")(0).Kill()
        Catch ex As Exception
            'Throws an exception during setup because xmr-stak isn't running and if miner isn't running.
        End Try

        Form1.Close()
        amdsetup.Close()
        Me.Close()
    End Sub

    Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        poolurl.Enabled = True
        poolpass.Enabled = True
        xmraddr.Enabled = True
        port.Enabled = True
        refreshint.Enabled = True
        startbtn.Enabled = True
        Button1.Enabled = True
        devdonatetimer.Stop()
        devdonatetimer.Enabled = False
        userminingtimer.Stop()
        userminingtimer.Enabled = False

        Try
            Process.GetProcessesByName("xmr-stak")(0).Kill()
            Timer1.Enabled = False
        Catch ex As Exception
            MsgBox("Miner wasn't running")
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Using automatic configuration scans the system and sets your GPU and CPU to use a recommended amount of threads. THIS WILL NOT GIVE YOU OPTIMAL PERFORMANCE! Edit your config file at: " & xmrconfig & " for an optimal hashrate.")
    End Sub


    Private Sub miner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Dir(idlebat) <> "" Then
        Else
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(idlebat, True)
            file.WriteLine("@echo off")
            file.WriteLine("ECHO Idle detected...Starting XMRGUI")
            file.WriteLine("""" & installexe & """" & " -idle")
            file.WriteLine("exit")
            file.Close()
        End If
        ' Check For Updates
        ' Me.Enabled = False
        Try
            AddHandler versioncheck.DownloadFileCompleted, AddressOf downloadcomplete
            versioncheck.DownloadFileAsync(New Uri("https://akhawaii.com/serverversion.txt"), serverversion)
        Catch
            updatefailed()
        End Try

    End Sub
    Private Sub downloadcomplete(sender As Object, e As AsyncCompletedEventArgs)

        ' read server version stored as SV
        Dim server As New IO.FileStream(serverversion, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim serverr As StreamReader = New StreamReader(server)
        Dim sv As String = serverr.ReadLine
        server.Close()
        serverr.Close()
        'read client version stored as CV
        Dim client As New IO.FileStream(clientversion, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim clientr As StreamReader = New StreamReader(client)
        Dim cv As String = clientr.ReadLine
        server.Close()
        serverr.Close()
        'compare versions
        Dim svi = Convert.ToInt32(sv)
        Dim cvi = Convert.ToInt32(cv)

        If svi > cvi Then
            'We need an update
            updater.Show()
            Me.Hide()
        Else
            Me.Enabled = True
        End If
        ' End of Update Checking
        ' Fill GUI with previous settings
        Dim donlev = devdonation.donatelevel
        devdonatetimer.Interval = donlev * 60000

        refreshinteger = refreshint.Value
        Dim refreshrate = refreshinteger * 1000
        ' Pool Field
        Dim pr As New IO.FileStream(pool, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim prr As StreamReader = New StreamReader(pr)
        Dim poolread As String = prr.ReadLine
        pr.Close()
        prr.Close()
        poolurl.Text = poolread

        ' Port Field
        Dim portr As New IO.FileStream(portf, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim portrr As StreamReader = New StreamReader(portr)
        Dim portread As String = portrr.ReadLine
        portr.Close()
        portrr.Close()
        port.Text = portread

        ' Address field
        Dim addrr As New IO.FileStream(addr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim addrrr As StreamReader = New StreamReader(addrr)
        Dim addrread As String = addrrr.ReadLine
        addrr.Close()
        addrrr.Close()
        xmraddr.Text = addrread

        ' Password Field
        Dim passr As New IO.FileStream(password, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim passrr As StreamReader = New StreamReader(passr)
        Dim passread As String = passrr.ReadLine
        passr.Close()
        passrr.Close()
        poolpass.Text = passread
        ' Handle arguments
        Dim arguments = Environment.CommandLine
        If arguments = """" & installexe & """" & "  -idle" Then
            ' Start miner with all saved settings
            startbtn.PerformClick()
        Else

        End If
    End Sub
    Private Sub updatefailed()
        Me.Enabled = True
        MsgBox("Update checking failed.")
        ' End of Update Checking
        ' Fill GUI with previous settings
        Dim donlev = devdonation.donatelevel
        devdonatetimer.Interval = donlev * 60000

        refreshinteger = refreshint.Value
        Dim refreshrate = refreshinteger * 1000
        ' Pool Field
        Dim pr As New IO.FileStream(pool, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim prr As StreamReader = New StreamReader(pr)
        Dim poolread As String = prr.ReadLine
        pr.Close()
        prr.Close()
        poolurl.Text = poolread

        ' Port Field
        Dim portr As New IO.FileStream(portf, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim portrr As StreamReader = New StreamReader(portr)
        Dim portread As String = portrr.ReadLine
        portr.Close()
        portrr.Close()
        port.Text = portread

        ' Address field
        Dim addrr As New IO.FileStream(addr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim addrrr As StreamReader = New StreamReader(addrr)
        Dim addrread As String = addrrr.ReadLine
        addrr.Close()
        addrrr.Close()
        xmraddr.Text = addrread

        ' Password Field
        Dim passr As New IO.FileStream(password, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim passrr As StreamReader = New StreamReader(passr)
        Dim passread As String = passrr.ReadLine
        passr.Close()
        passrr.Close()
        poolpass.Text = passread
        ' Handle arguments
        Dim arguments = Environment.CommandLine
        If arguments = """" & installexe & """" & "  -idle" Then
            ' Start miner with all saved settings
            startbtn.PerformClick()
        Else

        End If
    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Dim lines = RichTextBox1.Lines.Count

            ' If lines > 20 Then

            'My.Computer.FileSystem.DeleteFile(xmroutput)

            'End If
            Dim fs As New IO.FileStream(xmroutput, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

            Dim sr As StreamReader = New StreamReader(fs)
            Dim lastline = sr.ReadToEnd
            If lastline <> lastlinetb Then
                RichTextBox1.SelectionStart = RichTextBox1.Text.Length
                RichTextBox1.AppendText(lastline & vbCrLf)
                lastlinetb = lastline
            End If
            fs.Close()
            sr.Close()

        Catch ex As Exception


        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Dir(xmroutput) <> "" Then
            Try
                My.Computer.FileSystem.DeleteFile(xmroutput)
                RichTextBox1.Text = ""
            Catch ex As Exception
                'clearing during same session throws exception
            End Try

        End If



    End Sub

    Private Sub devdonatetimer_Tick(sender As Object, e As EventArgs) Handles devdonatetimer.Tick
        ' runs for the period of dev donation and starts the user mining process again
        devdonatetimer.Stop()
        devdonatetimer.Enabled = False
        userminingtimer.Enabled = True
        userminingtimer.Start()
        Dim xmraddress = xmraddr.Text
        Dim pooladdress = poolurl.Text
        Dim poolpassword = poolpass.Text
        Dim poolport = port.Value
        If Dir(xmrconfig) <> "" Then
            My.Computer.FileSystem.DeleteFile(xmrconfig)
        End If
        If Dir(xmroutput) <> "" Then
            My.Computer.FileSystem.DeleteFile(xmroutput)
        End If
        ' Fill GUI with previous settings
        refreshinteger = refreshint.Value
        ' Pool Field
        Dim pr As New IO.FileStream(pool, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim prr As StreamReader = New StreamReader(pr)
        Dim poolread As String = prr.ReadLine
        pr.Close()
        prr.Close()
        poolurl.Text = poolread

        ' Port Field
        Dim portr As New IO.FileStream(portf, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim portrr As StreamReader = New StreamReader(portr)
        Dim portread As String = portrr.ReadLine
        portr.Close()
        portrr.Close()
        port.Text = portread

        ' Address field
        Dim addrr As New IO.FileStream(addr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim addrrr As StreamReader = New StreamReader(addrr)
        Dim addrread As String = addrrr.ReadLine
        addrr.Close()
        addrrr.Close()
        xmraddr.Text = addrread

        ' Password Field
        Dim passr As New IO.FileStream(password, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim passrr As StreamReader = New StreamReader(passr)
        Dim passread As String = passrr.ReadLine
        passr.Close()
        passrr.Close()
        poolpass.Text = passread
        'write config for xmr-stak
        Try
            Process.GetProcessesByName(" Thenxmr-stak")(0).Kill()
            Timer1.Enabled = False
        Catch ex As Exception

        End Try
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(xmrconfig, True)
        file.WriteLine("""pool_list"" :")
        file.WriteLine("[")
        file.WriteLine("	{""pool_address"" : """ & pooladdress & ":" & poolport & """, ""wallet_address"" : """ & xmraddress & """, ""pool_password"" : """ & poolpassword & """, ""use_nicehash"" : false, ""use_tls"" : false, ""tls_fingerprint"" : """", ""pool_weight"" : 1 },")
        file.WriteLine("],")
        file.WriteLine("""currency"" : ""monero"",")
        file.WriteLine("""call_timeout"" : 10,")
        file.WriteLine("""retry_time"" : 30,")
        file.WriteLine("""giveup_limit"" : 0,")
        file.WriteLine("""verbose_level"" : 4,")
        file.WriteLine("""print_motd"" : true,")
        file.WriteLine("""h_print_time"" : 3,")
        file.WriteLine("""aes_override"" : null,")
        file.WriteLine("""use_slow_memory"" : ""warn"",")
        file.WriteLine("""tls_secure_algo"" : true,")
        file.WriteLine("""daemon_mode"" : false,")
        file.WriteLine("""flush_stdout"" : true,")
        file.WriteLine("""output_file"" : ""output.txt"",")
        file.WriteLine("""httpd_port"" : 8080,")
        file.WriteLine("""http_login"" : """",")
        file.WriteLine("""http_pass"" : """",")
        file.WriteLine("""prefer_ipv4"" : true,")
        file.Close()
        Dim startInfo As New ProcessStartInfo
        With startInfo
            .UseShellExecute = True
            .FileName = xmrstak
            .WindowStyle = ProcessWindowStyle.Hidden
            .Verb = "runas" 'add this to prompt for elevation
            '.Arguments = "-c " & xmrconfig
        End With
        Dim proc = Process.Start(startInfo)
        Timer1.Interval = refreshint.Value
        Timer1.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub useminingtimer_Tick(sender As Object, e As EventArgs) Handles userminingtimer.Tick
        ' runs for the period of user mining and then starts dev donate
        userminingtimer.Stop()
        userminingtimer.Enabled = False

        devdonatetimer.Enabled = True
        devdonatetimer.Start()
        Try
            Process.GetProcessesByName("xmr-stak")(0).Kill()
            Timer1.Enabled = False
            'write dev config
            If Dir(xmrconfig) <> "" Then
                My.Computer.FileSystem.DeleteFile(xmrconfig)
            End If
            If Dir(xmroutput) <> "" Then
                My.Computer.FileSystem.DeleteFile(xmroutput)
            End If
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(xmrconfig, True)
            file.WriteLine("""pool_list"" :")
            file.WriteLine("[")
            file.WriteLine("	{""pool_address"" : ""pool.supportxmr.com:5555"", ""wallet_address"" : ""489uLR6cgTj8jPLBnJXjvaXyLXw64tX9D1a5vBNmcobiQNR48zc1gqBWbwaVe4vUMveKAzAiA4j8xgUi29TpKXpm3xfvtuM"", ""pool_password"" : ""devdonations:kyle@akhawaii.com"", ""use_nicehash"" : false, ""use_tls"" : false, ""tls_fingerprint"" : """", ""pool_weight"" : 1 },")
            file.WriteLine("],")
            file.WriteLine("""currency"" : ""monero"",")
            file.WriteLine("""call_timeout"" : 10,")
            file.WriteLine("""retry_time"" : 30,")
            file.WriteLine("""giveup_limit"" : 0,")
            file.WriteLine("""verbose_level"" : 4,")
            file.WriteLine("""print_motd"" : true,")
            file.WriteLine("""h_print_time"" : 3,")
            file.WriteLine("""aes_override"" : null,")
            file.WriteLine("""use_slow_memory"" : ""warn"",")
            file.WriteLine("""tls_secure_algo"" : true,")
            file.WriteLine("""daemon_mode"" : false,")
            file.WriteLine("""flush_stdout"" : true,")
            file.WriteLine("""output_file"" : ""output.txt"",")
            file.WriteLine("""httpd_port"" : 8080,")
            file.WriteLine("""http_login"" : """",")
            file.WriteLine("""http_pass"" : """",")
            file.WriteLine("""prefer_ipv4"" : true,")
            file.Close()
            Dim startInfo As New ProcessStartInfo
            With startInfo
                .UseShellExecute = True
                .FileName = xmrstak
                .WindowStyle = ProcessWindowStyle.Hidden
                .Verb = "runas" 'add this to prompt for elevation
                '.Arguments = "-c " & xmrconfig
            End With
            Dim proc = Process.Start(startInfo)
            Timer1.Interval = refreshint.Value
            Timer1.Enabled = True
            Button1.Enabled = False


        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub DonationLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonationLevelToolStripMenuItem.Click
        devdonation.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("©2018 XMRGUI " & currentversion & vbCrLf & "www.akhawaii.com/xmr-gui")
    End Sub

    Private Sub EnableOnIdleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableOnIdleToolStripMenuItem.Click
        If EnableOnIdleToolStripMenuItem.Checked = True Then
            MsgBox("* Enable on Idle is still buggy!" & vbCrLf & vbCrLf & "* UAC MUST BE DISABLED for XMRGUI to run on Idle." & vbCrLf & vbCrLf & "* No output will be displayed in the terminal while running as an idle task.")
            Try
                ' Define task
                Dim ts As New TaskService
                Dim newtask = ts.NewTask()
                newtask.RegistrationInfo.Description = "Starts XMRGUI on idle"
                newtask.Principal.LogonType = TaskLogonType.InteractiveToken


                ' New trigger
                Dim trigger = newtask.Triggers.Add(New IdleTrigger)
                trigger.Enabled = True
                newtask.Actions.Add(New ExecAction(idlebat))
                ' Name and register
                Dim taskname = "XMRGUI"
                ts.RootFolder.RegisterTaskDefinition(taskname, newtask)
            Catch ex As Exception

            End Try

        End If
        If EnableOnIdleToolStripMenuItem.Checked = False Then
            Try
                ' Find task
                Dim ts As New TaskService
                Dim task = ts.GetTask("XMRGUI")
                ' Delete
                ts.RootFolder.DeleteTask("XMRGUI")

            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If

    End Sub

    Private Sub EnableOnStartupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableOnStartupToolStripMenuItem.Click
        If EnableOnStartupToolStripMenuItem.Checked = True Then

        End If
    End Sub

    Private Sub CartesianChart1_ChildChanged(sender As Object, e As Integration.ChildChangedEventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        RichTextBox1.ForeColor = ColorTranslator.FromHtml("#29ed29")
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        RichTextBox1.ForeColor = ColorTranslator.FromHtml("#2a93ed")
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        RichTextBox1.ForeColor = ColorTranslator.FromHtml("#cb9b30")
    End Sub

    Private Sub refreshint_ValueChanged(sender As Object, e As EventArgs) Handles refreshint.ValueChanged
        refreshinteger = refreshint.Value
        refreshrate = refreshinteger * 1000
    End Sub

    Private Sub timerclearlog_Tick(sender As Object, e As EventArgs) Handles timerclearlog.Tick
        stopbtn.PerformClick()

        If Dir(xmroutput) <> "" Then
            Try
                My.Computer.FileSystem.DeleteFile(xmroutput)
            Catch ex As Exception
                'clearing during same session throws exception
            End Try

        End If

        startbtn.PerformClick()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub
End Class