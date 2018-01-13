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
Imports System.Text.RegularExpressions
Public Class miner
    Dim nvcards
    Dim amdcards
    Dim newhashrate As Double
    Dim oldx = "testi"
    Dim a, b As Integer
    Dim newPoint As New System.Drawing.Point()
    Dim currentversion = "v1.5"
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
    Dim refreshinteger As Int32
    Dim refreshrate = 10000
    Dim lastline = "test"
    Dim rtlateststring As IEnumerable(Of String)

    Dim nvidiacard1 As New LineSeries
    Dim nvidiavalues = New ChartValues(Of Double)
    Dim amdcard1 As New LineSeries
    Dim newser As New SeriesCollection
    Dim test As New LineSeries
    Dim Chartvalues = New ChartValues(Of Double)


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
        timeroutput.Enabled = True
        timeroutput.Start()
        Chartvalues.add(0)

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

    Private Sub RunGPUSetupToolStripMenuItem_Click(sender As Object, e As EventArgs)
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
        Labelhashrate.Text = "0"
        Button1.Enabled = True
        devdonatetimer.Stop()
        devdonatetimer.Enabled = False
        userminingtimer.Stop()
        userminingtimer.Enabled = False
        timeroutput.Enabled = False
        timeroutput.Stop()

        Try
            Process.GetProcessesByName("xmr-stak")(0).Kill()
            Timer1.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Using automatic configuration scans the system and sets your GPU and CPU to use a recommended amount of threads. THIS WILL NOT GIVE YOU OPTIMAL PERFORMANCE! We will add manual configurations for both GPU and CPU soon.")
    End Sub


    Private Sub miner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CartesianChart1.Enabled = True
        CartesianChart1.Series = newser
        test.Title = "Total Hashrate(H/s)"
        newser.Add(test)
        test.Values = Chartvalues
        Chartvalues.Add(0)
        Chartvalues.Add(5)
        Chartvalues.Add(3)
        Chartvalues.Add(6)


        Dim xaxis As New Axis
        CartesianChart1.AxisX.Add(xaxis)
        xaxis.Title = "Timestamp"

        Dim yaxis As New Axis
        CartesianChart1.AxisY.Add(yaxis)
        yaxis.Title = "H/s"

        CartesianChart1.Update()
        nvcards = 0
        amdcards = 0
        ' Check for GPU
        Dim shopList() As String = {"VideoProcessor", "Name", "AdapterRAM"}
        Dim wmiItems As Dictionary(Of String, String)
        wmiItems = WMI.GetWMISettingsDictionary("Win32_VideoController", shopList)
        For Each kvp As KeyValuePair(Of String, String) In wmiItems
            If kvp.Value.Contains("NVIDIA") Then
                'NVIDIA Detected
                nvcards += 1
            ElseIf kvp.Value.Contains("AMD") Then
                'AMD detected, check for OpenCL
                amdcards += 1
            Else

            End If
        Next
        ' Add CPU Chart
        If nvcards = 1 Then
            newser.Add(nvidiacard1)
            nvidiacard1.Title = "NVIDIA GPU"
            nvidiacard1.Values = nvidiavalues
            nvidiavalues.add(0)
            nvidiavalues.add(20)
            nvidiavalues.add(12)
            nvidiavalues.add(31)
            CartesianChart1.Update()
        End If

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
        Dim arguments = Environment.CommandLine
        If arguments = """" & installexe & """" & "  -idle" Then
            ' Start miner with all saved settings
            startbtn.PerformClick()
        Else

        End If
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

    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Chartvalues.count > 50 Then

            For Each point In Chartvalues
                Chartvalues.remove(point)
                GoTo end_of_for
            Next
end_of_for:
        End If
        Chartvalues.Add(newhashrate)
        CartesianChart1.Update()
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
        Try
            Process.GetProcessesByName("xmr-stak")(0).Kill()

            Threading.Thread.Sleep(1000)
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
        Catch
        End Try

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

            Threading.Thread.Sleep(1000)

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
            MsgBox("* Enable on Idle is still buggy!" & vbCrLf & vbCrLf & "* UAC MUST BE DISABLED for XMRGUI to run on Idle." & vbCrLf & vbCrLf & "* No output will be displayed in the terminal or graphs while running as an idle task.")
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

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

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
        Threading.Thread.Sleep(1000)
        If Dir(xmroutput) <> "" Then
            Try

                My.Computer.FileSystem.DeleteFile(xmroutput)
                Application.DoEvents()
            Catch ex As Exception
                'clearing during same session throws exception
            End Try

        End If

        startbtn.PerformClick()
    End Sub

    Private Sub CartesianChart1_ChildChanged_1(sender As Object, e As Integration.ChildChangedEventArgs)


    End Sub
    Private Function ReadLastLinesFromFile(filename As String, numberOfLines As Integer) As IEnumerable(Of String)
        Dim fs As New IO.FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim results As List(Of String) = New List(Of String)

        Dim reader As StreamReader = New StreamReader(fs)

        ' Get the underlying stream
        Dim stream = reader.BaseStream

        ' Move to just before the end of the file
        stream.Seek(-1, SeekOrigin.[End])

        Dim found As Integer = 0

        While found < numberOfLines
            Dim current As Integer = reader.Peek()
            If current = -1 Then
                Return results
            End If
            Dim value As Char = ChrW(current)

            If value = ControlChars.Lf Then
                found += 1
            End If

            ' Move back one character
            stream.Seek(-1, SeekOrigin.Current)
        End While

        ' Move forward to the start of the right line
        stream.Seek(2, SeekOrigin.Current)

        Dim line As String = reader.ReadLine()
        While line IsNot Nothing
            results.Add(line)
            line = reader.ReadLine()
        End While
        fs.Close()
        reader.Close()

        Return results
    End Function
    Private Sub timeroutput_Tick(sender As Object, e As EventArgs) Handles timeroutput.Tick
        Try
            Dim lateststring = ReadLastLinesFromFile(xmroutput, 400)


            If lateststring IsNot rtlateststring Then
                For Each x In lateststring
                    If x <> oldx Then
                        RichTextBox1.AppendText(x & vbCrLf)
                        oldx = x

                    End If
                    If x.Contains("Totals") Then ' Should be "Totals"

                        'Dim regex As Regex = New Regex("\d+?.\d+")
                        Dim regex As Regex = New Regex("\d{1,5}\.\d{1,1}") ' match a double
                        Dim ret = regex.Match(x).Value
                        If ret <> "" Then
                            Labelhashrate.Text = ret
                        Else
                            Labelhashrate.Text = "Initializing..."
                            ret = "0.0"
                        End If

                        'Dim match As Match = regex.Match(lastline)
                        newhashrate = Convert.ToDouble(ret)

                    End If
                    rtlateststring = lateststring
                Next
                RichTextBox1.SelectionStart = RichTextBox1.Text.Length
            End If
        Catch
        End Try








    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        noob.Show()
        Me.Hide()
    End Sub

    Private Sub CartesianChart1_ChildChanged_2(sender As Object, e As Integration.ChildChangedEventArgs) Handles CartesianChart1.ChildChanged

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub
End Class