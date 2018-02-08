Imports System.IO
Imports Microsoft.Win32.TaskScheduler
Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.Text.RegularExpressions
Imports CefSharp.WinForms
Imports CefSharp
Imports Newtonsoft.Json
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Collections.Generic

Public Class miner
    Dim savedrate
    Dim xoccured As Integer = 1
    Dim stopped As Boolean = True
    Dim msg2color = Color.OrangeRed
    Dim msg1 As String
    Dim msg2 As String
    Private it As New IdleTime
    Dim idlemining As Boolean = False
    Dim mining = False
    Dim oldresults As Dictionary(Of Integer, String)
    Dim proc
    Dim switching = False
    'settings vars
    Dim idletask As Boolean = False
    Public settings
    ' CARD COUNTS
    Dim nvcards As Boolean
    Dim amdcards As Boolean
    ' RANDOM...CAN'T REMEMBER - UI
    Dim devt As Boolean
    Dim startupenabled = False
    Dim mode As String
    Public mydv As Int32
    Dim firstgpuclick = True
    Dim trayicon = True
    Dim oldx = "testi"
    Dim a, b As Integer
    Dim newPoint As New System.Drawing.Point()
    Dim currentversion = "v1.9"
    Dim upseconds = 0
    Dim terminalcolor
    Dim cardtype As String
    ' FILE LOCATIONS
    Dim self = Application.ExecutablePath
    Dim objShell = CreateObject("WScript.Shell")
    Dim oFSO = CreateObject("Scripting.FileSystemObject")
    Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
    Public configfile = strAppData & "\XMRGUI\config.dat"
    Dim visibilitysettingsfile = strAppData & "\XMRGUI\vis.dat"
    Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
    Dim dev = strAppData & "\XMRGUI\dev.dat"
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
    Public cpuconfigfile = strAppData & "\XMRGUI\cpu.txt"
    Public nvconfigfile = strAppData & "\XMRGUI\nvidia.txt"
    Public amdconfigfile = strAppData & "\XMRGUI\amd.txt"
    Dim startupetry = strAppData & "\XMRGUI\XMRGUIStartup.exe"
    Dim startupetryst = strAppData & "\XMRGUI\XMRGUIStartupst.exe"
    Dim chatSupportxmr = strAppData & "\XMRGUI\chatango.html"
    Dim startupdest = strAppData & "\Microsoft\Windows\Start Menu\Programs\Startup\XMRGUIStartup.exe"
    Dim startupdestst = strAppData & "\Microsoft\Windows\Start Menu\Programs\Startup\XMRGUIStartupst.exe"

    Dim profilesdir = strAppData & "\XMRGUI\profiles"
    Public profilenames = strAppData & "\XMRGUI\profiles\profilenames.dat"
    Public defaultset = strAppData & "\XMRGUI\profiles\default.dat"

    Dim profile0conf = strAppData & "\XMRGUI\profiles\profile0conf.dat"
    Dim profile0cpu = strAppData & "\XMRGUI\profiles\profile0cpu.txt"
    Dim profile0nv = strAppData & "\XMRGUI\profiles\profile0nv.txt"
    Dim profile0amd = strAppData & "\XMRGUI\profiles\profile0amd.txt"

    Dim profile1conf = strAppData & "\XMRGUI\profiles\profile1conf.dat"
    Dim profile1cpu = strAppData & "\XMRGUI\profiles\profile1cpu.txt"
    Dim profile1nv = strAppData & "\XMRGUI\profiles\profile1nv.txt"
    Dim profile1amd = strAppData & "\XMRGUI\profiles\profile1amd.txt"

    Dim profile2conf = strAppData & "\XMRGUI\profiles\profile2conf.dat"
    Dim profile2cpu = strAppData & "\XMRGUI\profiles\profile2cpu.txt"
    Dim profile2nv = strAppData & "\XMRGUI\profiles\profile2nv.txt"
    Dim profile2amd = strAppData & "\XMRGUI\profiles\profile2amd.txt"

    Dim profile3conf = strAppData & "\XMRGUI\profiles\profile3conf.dat"
    Dim profile3cpu = strAppData & "\XMRGUI\profiles\profile3cpu.txt"
    Dim profile3nv = strAppData & "\XMRGUI\profiles\profile3nv.txt"
    Dim profile3amd = strAppData & "\XMRGUI\profiles\profile3amd.txt"

    Dim profile4conf = strAppData & "\XMRGUI\profiles\profile4conf.dat"
    Dim profile4xmrstak = strAppData & "\XMRGUI\profiles\profile4xmrgui.txt"
    Dim profile4cpu = strAppData & "\XMRGUI\profiles\profile4cpu.txt"
    Dim profile4nv = strAppData & "\XMRGUI\profiles\profile4nv.txt"
    Dim profile4amd = strAppData & "\XMRGUI\profiles\profile4amd.txt"
    ' MANUAL THREAD CONFIG VARIABLES
    Dim manualmode = False
    Dim pccores = Convert.ToInt16(System.Environment.ProcessorCount)
    ' XMRSTAK OUTPUT CONTROL VARIABLES
    Dim refreshinteger As Int32
    Dim newhashrate As Double
    Dim refreshrate = 10000
    Dim lastline = "test"
    Dim rtlateststring As IEnumerable(Of String)
    ' CHART VALUES AND SERIES
    Dim nvidiacard1 As New LineSeries
    Dim nvidiavalues = New ChartValues(Of Double)
    Dim newser As New SeriesCollection
    Dim test As New LineSeries
    Dim Chartvalues = New ChartValues(Of Double)
    Dim newNVhashRate
    Dim firstNV As Boolean = False
    Dim AMDCard1 As New LineSeries
    Dim AMDValues = New ChartValues(Of Double)
    Dim newAMDhashrate
    Dim firstAMD As Boolean = False
    Dim CPU1 As New LineSeries
    Dim CPUValues = New ChartValues(Of Double)
    Dim newCPUhashrate
    Dim firstCPU As Boolean = False
    'HRMVars
    Public HRMactive = False
    Public perchs As String
    Public HRMValue As String
    Public HRMTime As String
    Public OCon = False
    Public OCCommand As String
    Public OCArgs As String
    Dim HRMdictionary As New Dictionary(Of Integer, Double)
    Dim HRMx As Short = 1
    Dim checkval As Double
    ' NEXT SIX SUBS HANDLE FORM MOVEMENT
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
    Private Sub menu_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        a = MousePosition.X - Me.Location.X
        b = MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub menu_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseMove
        If e.Button = MouseButtons.Left Then
            newPoint = MousePosition
            newPoint.X = newPoint.X - a
            newPoint.Y = newPoint.Y - b
            Me.Location = newPoint
        End If
    End Sub
    Private Sub label_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseDown
        a = MousePosition.X - Me.Location.X
        b = MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub label_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseMove
        If e.Button = MouseButtons.Left Then
            newPoint = MousePosition
            newPoint.X = newPoint.X - a
            newPoint.Y = newPoint.Y - b
            Me.Location = newPoint
        End If
    End Sub
    ' MINE! CLICKED - CLEAR XMR-STAK OUTPUT FILE AND RUN WRITEUSERCONFIG SUB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        mining = True
        timeroutput.Enabled = True
        timeroutput.Start()
        Chartvalues.add(0)
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(upseconds)
        NotifyIcon1.Text = "Uptime - Hours: " & iSpan.Hours & vbCrLf & " Minutes: " & iSpan.Minutes & vbCrLf & " Seconds: " & iSpan.Seconds & vbCrLf & "Initializing..."
        Label8.Text = "Uptime - Hours: " & iSpan.Hours & " Minutes: " & iSpan.Minutes & " Seconds: " & iSpan.Seconds & "            Initializing..."
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
            savebtn.Enabled = False
            poolpass.Enabled = False
            xmraddr.Enabled = False
            port.Enabled = False
            refreshint.Enabled = False
            ComboBox1.Enabled = False
            startbtn.Enabled = False
            stopbtn.Enabled = True
            StopToolStripMenuItem.Enabled = True
            StopToolStripMenuItem.Visible = True
            MineToolStripMenuItem.Enabled = False
            MineToolStripMenuItem.Visible = False
            radiomanualfiles.Enabled = False
            radiomanual.Enabled = False
            radioautomatic.Enabled = False
            cputhreadspicker.Enabled = False
            savesettings()
            switching = False
            writeuserconfig(switching)
        End If

    End Sub
    ' SAVE USER SETTINGS IN DAT FILES, WRITE XMR-STAK CONFIG AND RUN STARTMINER SUB
    Private Sub writeuserconfig(switching As Boolean)
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
        ' WRITE MANUAL MODE SETTINGS
        If manualmode = True Then
            If Dir(cpuconfigfile) <> "" Then
                Try
                    My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            End If
            Dim corenumber As Int16 = 0
            Dim threadcount As Int16 = cputhreadspicker.Value
            Dim cpuconfigwriter As System.IO.StreamWriter
            cpuconfigwriter = My.Computer.FileSystem.OpenTextFileWriter(cpuconfigfile, True)
            cpuconfigwriter.WriteLine("""cpu_threads_conf"" :  ")
            cpuconfigwriter.WriteLine("[")
            If threadcount > pccores / 2 Then
                For x As Integer = 1 To threadcount
                    cpuconfigwriter.WriteLine("    { ""low_power_mode"" :  false, ""no_prefetch"" : true, ""affine_to_cpu"" : " & corenumber & " },")
                    corenumber += 1
                Next
            Else
                For x As Integer = 1 To threadcount
                    cpuconfigwriter.WriteLine("    { ""low_power_mode"" :  false, ""no_prefetch"" : true, ""affine_to_cpu"" : " & corenumber & " },")
                    corenumber += 2
                Next
            End If
            cpuconfigwriter.WriteLine("],")
            cpuconfigwriter.Close()
            If switching = False Then
                startminer()
            End If

        Else
            If switching = False Then
                startminer()
            End If

        End If

    End Sub
    ' RUN XMR-STAK AS ADMIN/HIDDEN AND START ALL TIMERS(DEV DONATION TIMERS AND REFRESH CHART/OUTPUT TIMER)
    Private Sub startminer()
        Dim startInfo As New ProcessStartInfo
        With startInfo
            .UseShellExecute = True
            .FileName = xmrstak
            .WindowStyle = ProcessWindowStyle.Hidden
            .Verb = "runas" 'add this to prompt for elevation
            '.Arguments = "-c " & xmrconfig
        End With
        proc = Process.Start(startInfo)
        Timer1.Interval = refreshrate
        Timer1.Enabled = True
        Timer1.Start()
        devdonatetimer.Enabled = True
        userminingtimer.Enabled = True
        useminingtimer_Tick(Nothing, Nothing)
        uptime.Enabled = True
        uptime.Start()

    End Sub
    ' HANDLES SHUTDOWN PROCEDURE
    Private Sub frmSimple_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Process.GetProcessesByName("xmr-stak")(0).Kill()
        Catch ex As Exception
            'Throws an exception during setup because xmr-stak isn't running if miner HAS NOT BEEN STARTED
        End Try
        Form1.Close()
        amdsetup.Close()
        Me.Close()
    End Sub
    ' STOP CLICKED - ENABLE/DISABLE FORM ITEMS AND KILL XMR-STAK
    Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        HRMTimer.Stop()
        For x As Integer = 1 To HRMdictionary.Count
            HRMdictionary.Remove(x)
        Next
        HRMx = 1
        mining = False
        poolurl.Enabled = True
        savebtn.Enabled = True
        stopbtn.Enabled = False
        poolpass.Enabled = True
        xmraddr.Enabled = True
        port.Enabled = True
        refreshint.Enabled = True
        startbtn.Enabled = True
        ComboBox1.Enabled = True
        devdonatetimer.Stop()
        devdonatetimer.Enabled = False
        userminingtimer.Stop()
        userminingtimer.Enabled = False
        timeroutput.Enabled = False
        timeroutput.Stop()
        uptime.Stop()
        upseconds = 0
        Label8.Text = ""
        StopToolStripMenuItem.Enabled = False
        StopToolStripMenuItem.Visible = False
        MineToolStripMenuItem.Enabled = True
        MineToolStripMenuItem.Visible = True
        radioautomatic.Enabled = True
        radiomanual.Enabled = True
        radiomanualfiles.Enabled = True
        cputhreadspicker.Enabled = True
        Try
            Process.GetProcessesByName("xmr-stak")(0).Kill()
            newhashrate = 0
            newCPUhashrate = 0
            newAMDhashrate = 0
            newNVhashRate = 0
        Catch ex As Exception

        End Try
        loadsettings(configfile)
    End Sub
    ' HELP FOR AUTOMATIC/MANUAL CONFIG
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Using automatic configuration scans the system and sets your GPU and CPU to use a recommended amount of threads. THIS WILL NOT GIVE YOU OPTIMAL PERFORMANCE!" & vbCrLf & "To use your own config files please select ""Config Override""")
    End Sub
    ' SET UP CHARTS, CHECK FOR GPUs, FILL GUI WITH USER'S SETTINGS, CREATES AN IDLE TASK BAT TO BE READY FOR IDLETASKS
    Public Sub savesettings()
        If Dir(configfile) <> "" Then
            My.Computer.FileSystem.DeleteFile(configfile)
        End If

        Dim configwriter As System.IO.StreamWriter
        configwriter = My.Computer.FileSystem.OpenTextFileWriter(configfile, True)
        ' ""xmraddress"":" & xmraddr.Text & ","     - one var
        configwriter.WriteLine("{""xmraddress"":""" & xmraddr.Text & """,""pool"":""" & poolurl.Text & """,""poolport"":""" & port.Value & """,""poolpassword"":""" & poolpass.Text & """,""donatelevel"":""" & mydv & """,""nvcards"":""" & nvcards & """,""amdcards"":""" & amdcards & """,""mode"":""" & mode & """,""cputhreads"":""" & cputhreadspicker.Value & """,""trayicon"":""" & trayicon & """,""idleenabled"":""" & idletask & """,""startupenabled"":""" & startupenabled & """,""HRMEnabled"":""" & HRMactive & """,""perchs"":""" & perchs & """,""HRMValue"":""" & HRMValue & """,""HRMTime"":""" & HRMTime & """,""OCon"":""" & OCon & """,""OCCommand"":""" & OCCommand & """,""OCArgs"":""" & OCArgs & """}")
        configwriter.Close()
        'xmr-stak config writer
        If Dir(xmrconfig) <> "" Then
            My.Computer.FileSystem.DeleteFile(xmrconfig)
        End If
        Dim xmraddress = xmraddr.Text
        Dim pooladdress = poolurl.Text
        Dim poolpassword = poolpass.Text
        Dim poolport = port.Value
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
    End Sub
    Public Sub loadsettings(file As String)
        Try

            Dim configr As New IO.FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim configreader As StreamReader = New StreamReader(configr)
            Dim jsonstring As String = configreader.ReadLine
            settings = JsonConvert.DeserializeObject(Of JSON_settings)(jsonstring) ' insert JSON results string
            xmraddr.Text = settings.xmraddress
            poolurl.Text = settings.pool
            poolpass.Text = settings.poolpassword
            port.Value = Convert.ToInt32(settings.poolport)
            If file Is dev Then

            Else
                If settings.HRMEnabled = "True" Then
                    HRMactive = True
                    hrmlabeltimer.Enabled = True
                    hrmlabeltimer.Start()
                    hrmlabel.ForeColor = Color.LimeGreen
                    hrmlabel.Text = ""
                Else
                    HRMactive = False
                    hrmlabeltimer.Stop()
                    hrmlabeltimer2.Stop()
                    hrmlabel.Text = "HASHRATE MONITORING INACTIVE"
                    hrmlabel.ForeColor = Color.Maroon
                End If
                If settings.perchs = "H/s" Then
                    perchs = "H/s"
                    HashrateMonitor.RadioButton1.Checked = False
                    HashrateMonitor.RadioButton2.Checked = True
                Else
                    perchs = "%"
                    HashrateMonitor.RadioButton1.Checked = True
                    HashrateMonitor.RadioButton2.Checked = False
                End If
                If settings.HRMValue <> "" Then
                    HRMValue = Convert.ToInt32(settings.HRMValue)
                    Try
                        HashrateMonitor.NumericUpDown1.Value = Convert.ToInt32(settings.HRMValue)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
                If settings.hrmtime <> "" Then
                    HRMTime = Convert.ToInt32(settings.HRMTime)
                    HashrateMonitor.NumericUpDown2.Value = Convert.ToInt32(settings.HRMTime)
                Else
                    HRMTime = 3
                    HashrateMonitor.NumericUpDown2.Value = 3
                End If
                If settings.OCon = "True" Then
                    OCon = True
                    HashrateMonitor.CheckBox1.Checked = True
                    HashrateMonitor.Button3.Enabled = True
                    HashrateMonitor.TextBox2.Enabled = True
                    HashrateMonitor.Button4.Enabled = True
                Else
                    OCon = False
                    HashrateMonitor.CheckBox1.Checked = False
                    HashrateMonitor.Button3.Enabled = False
                    HashrateMonitor.TextBox2.Enabled = False
                    HashrateMonitor.Button4.Enabled = False
                End If
                If settings.OCCommand <> "" Then
                    'keep the variable as JSON format
                    Dim cnvtodouble As String
                    Dim doubleslash As String = Chr(92) & Chr(92)
                    cnvtodouble = settings.OCCommand
                    cnvtodouble = cnvtodouble.Replace("\", doubleslash)
                    OCCommand = cnvtodouble
                    'set the textbox as correct
                    Dim convertcmdm As String
                    convertcmdm = settings.OCCommand
                    convertcmdm = convertcmdm.Replace("\\", "\")
                    HashrateMonitor.TextBox1.Text = convertcmdm
                End If
                If settings.OCArgs <> "" Then
                    'keep the variable as JSON  format
                    Dim cnvtodouble As String
                    Dim doubleslash As String = Chr(92) & Chr(92)
                    cnvtodouble = settings.OCArgs
                    cnvtodouble = cnvtodouble.Replace("\", doubleslash)
                    OCArgs = cnvtodouble
                    'set the textbox as correct
                    Dim convertargm As String
                    convertargm = settings.OCArgs
                    convertargm = convertargm.Replace("\\", "\")
                    HashrateMonitor.TextBox2.Text = convertargm
                End If
                If settings.idleenabled = "True" Then
                    EnableOnIdleToolStripMenuItem.Checked = True
                    idletask = True
                Else
                    EnableOnIdleToolStripMenuItem.Checked = False
                    idletask = False
                End If
                If settings.startupenabled = "True" Then
                    EnableOnStartupToolStripMenuItem.Checked = True
                    startupenabled = True
                Else
                    EnableOnIdleToolStripMenuItem.Checked = False
                    startupenabled = False
                End If
                If settings.mode = "manualoverride" Then
                    radiomanual.Checked = False
                    radiomanualfiles.Checked = True
                    radioautomatic.Checked = False
                End If
                If settings.mode = "manual" Then
                    cputhreadspicker.Value = Convert.ToInt32(settings.cputhreads)
                    radiomanual.Checked = True
                    radiomanualfiles.Checked = False
                    radioautomatic.Checked = False
                End If
                If settings.trayicon = "False" Then
                    trayicon = False
                    NotifyIcon1.Visible = False
                    TrayIconToolStripMenuItem.Checked = False
                Else
                    trayicon = True
                    NotifyIcon1.Visible = True
                    TrayIconToolStripMenuItem.Checked = True
                End If
                If settings.donatelevel < 1 Then
                    settings.donatelevel = 2
                End If
                If devdonation.donatelevel = 100 Then
                    devdonation.savedlevel = Convert.ToUInt32(settings.donatelevel)
                    devdonatetimer.Interval = 6000000 * (settings.donatelevel / 100)
                    userminingtimer.Interval = 1

                Else
                    devdonation.savedlevel = Convert.ToUInt32(settings.donatelevel)
                    devdonatetimer.Interval = 6000000 * (settings.donatelevel / 100)
                    userminingtimer.Interval = 6000000 * ((100 - settings.donatelevel) / 100)
                End If

            End If
            configr.Close()
            configreader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub miner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        idletimer.Start()
        CartesianChart1.Enabled = True
        poolapitimer.Start()
        CartesianChart1.Series = newser
        test.Title = "Total Hashrate(H/s)"
        RichTextBox1.ForeColor = Color.FromArgb(069, 245, 010)
        test.Fill = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(&H25, 240, 22, 49))
        test.Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(&HFF, 240, 22, 49))
        newser.Add(test)
        test.Values = Chartvalues
        Chartvalues.Add(0)
        Chartvalues.Add(5)
        Chartvalues.Add(3)
        Chartvalues.Add(6)
        ' verification
        If Dir(dev) <> "" Then
        Else
            Dim configwriter As System.IO.StreamWriter
            configwriter = My.Computer.FileSystem.OpenTextFileWriter(dev, False)
            ' ""xmraddress"":" & xmraddr.Text & ","     - one var
            configwriter.WriteLine("{""xmraddress"":""489uLR6cgTj8jPLBnJXjvaXyLXw64tX9D1a5vBNmcobiQNR48zc1gqBWbwaVe4vUMveKAzAiA4j8xgUi29TpKXpm3xfvtuM"",""pool"":""pool.xmrgui.com"",""poolport"":""3333"",""poolpassword"":""benchmark"",""donatelevel"":""1"",""nvcards"":""False"",""amdcards"":""False""}")
            configwriter.Close()
        End If
        ' create profiles directory
        If Dir(profilesdir) = "" Then
            My.Computer.FileSystem.CreateDirectory(profilesdir)
        End If
        If Dir(defaultset) = "" Then
            'create the default profile file
            Dim defaultwriter As System.IO.StreamWriter
            defaultwriter = My.Computer.FileSystem.OpenTextFileWriter(defaultset, False)
            defaultwriter.WriteLine("none")
            defaultwriter.Close()
        End If
        If Dir(profilenames) = "" Then
            Dim profilenamewriter As System.IO.StreamWriter
            profilenamewriter = My.Computer.FileSystem.OpenTextFileWriter(profilenames, False)
            profilenamewriter.WriteLine("Profile 1")
            profilenamewriter.WriteLine("Profile 2")
            profilenamewriter.WriteLine("Profile 3")
            profilenamewriter.WriteLine("Profile 4")
            profilenamewriter.WriteLine("Profile 5")
            profilenamewriter.Close()
        End If
        'Read profile names
        loadprofilenames()
        ' read the default file
        If Dir(defaultset) <> "" Then
            Dim defaultprofile As String
            Dim defaultreader As System.IO.StreamReader
            defaultreader = My.Computer.FileSystem.OpenTextFileReader(defaultset)
            defaultprofile = defaultreader.ReadLine
            ' copy the settings over
            If defaultprofile = "0" Then
                If Dir(profile0conf) <> "" Then
                    If Dir(configfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(configfile)
                        My.Computer.FileSystem.CopyFile(profile0conf, configfile)
                    End If
                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                        My.Computer.FileSystem.CopyFile(profile0cpu, cpuconfigfile)
                    End If
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(amdconfigfile)
                        My.Computer.FileSystem.CopyFile(profile0amd, amdconfigfile)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(nvconfigfile)
                        My.Computer.FileSystem.CopyFile(profile0nv, nvconfigfile)
                    End If
                Else
                    MsgBox("You haven't saved any settings for this profile. Please save your settings before making it default.")
                End If
            End If
            If defaultprofile = "1" Then
                If Dir(profile1conf) <> "" Then
                    If Dir(configfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(configfile)
                        My.Computer.FileSystem.CopyFile(profile1conf, configfile)
                    End If
                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                        My.Computer.FileSystem.CopyFile(profile1cpu, cpuconfigfile)
                    End If
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(amdconfigfile)
                        My.Computer.FileSystem.CopyFile(profile1amd, amdconfigfile)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(nvconfigfile)
                        My.Computer.FileSystem.CopyFile(profile1nv, nvconfigfile)
                    End If
                Else
                    MsgBox("You haven't saved any settings for this profile. Please save your settings before making it default.")
                End If
            End If
            If defaultprofile = "2" Then
                If Dir(profile2conf) <> "" Then
                    If Dir(configfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(configfile)
                        My.Computer.FileSystem.CopyFile(profile2conf, configfile)
                    End If
                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                        My.Computer.FileSystem.CopyFile(profile2cpu, cpuconfigfile)
                    End If
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(amdconfigfile)
                        My.Computer.FileSystem.CopyFile(profile2amd, amdconfigfile)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(nvconfigfile)
                        My.Computer.FileSystem.CopyFile(profile2nv, nvconfigfile)
                    End If
                Else
                    MsgBox("You haven't saved any settings for this profile. Please save your settings before making it default.")
                End If
            End If
            If defaultprofile = "3" Then
                If Dir(profile3conf) <> "" Then
                    If Dir(configfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(configfile)
                        My.Computer.FileSystem.CopyFile(profile3conf, configfile)
                    End If
                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                        My.Computer.FileSystem.CopyFile(profile3cpu, cpuconfigfile)
                    End If
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(amdconfigfile)
                        My.Computer.FileSystem.CopyFile(profile3amd, amdconfigfile)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(nvconfigfile)
                        My.Computer.FileSystem.CopyFile(profile3nv, nvconfigfile)
                    End If
                Else
                    MsgBox("You haven't saved any settings for this profile. Please save your settings before making it default.")
                End If
            End If
            If defaultprofile = "4" Then
                If Dir(profile4conf) <> "" Then
                    If Dir(configfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(configfile)
                        My.Computer.FileSystem.CopyFile(profile4conf, configfile)
                    End If
                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                        My.Computer.FileSystem.CopyFile(profile4cpu, cpuconfigfile)
                    End If
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(amdconfigfile)
                        My.Computer.FileSystem.CopyFile(profile4amd, amdconfigfile)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.DeleteFile(nvconfigfile)
                        My.Computer.FileSystem.CopyFile(profile4nv, nvconfigfile)
                    End If
                Else
                    MsgBox("You haven't saved any settings for this profile. Please save your settings before making it default.")
                End If
            End If
            If defaultprofile <> "none" Then
                ComboBox1.SelectedIndex = Convert.ToInt32(defaultprofile)
            Else
                ComboBox1.SelectedIndex = 0
            End If
        End If

        ' load the settings into the GUI
        'Charts iitialization
        Dim xaxis As New Axis
        CartesianChart1.AxisX.Add(xaxis)
        xaxis.Title = "Timestamp"

        Dim yaxis As New Axis
        CartesianChart1.AxisY.Add(yaxis)
        yaxis.Title = "H/s"

        CartesianChart1.Update()

        ' LOAD SETTINGS
        loadsettings(configfile)
        Dim arguments = Environment.CommandLine

        If arguments = """" & installexe & """" & " -idlestartup" Then
            NotifyIcon1.Visible = True
            trayicon = True
            savesettings()
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            EnableOnStartupToolStripMenuItem.Checked = True
        End If
        If arguments = """" & installexe & """" & " -startup" Then
            savesettings()
            EnableOnStartupToolStripMenuItem.Checked = True
            startbtn.PerformClick()
        End If
    End Sub
    Public Sub loadprofilenames()
        ComboBox1.Items.Clear()
        Dim profilenamereader As System.IO.StreamReader
        profilenamereader = My.Computer.FileSystem.OpenTextFileReader(profilenames)
        Do While profilenamereader.Peek() >= 0
            Dim name = profilenamereader.ReadLine
            ComboBox1.Items.Add(name)
        Loop
        profilenamereader.Close()
    End Sub
    ' HANDLES THE REFRESH RATE, PLOTS NEW CHART POINTS, AND DELETES 50-TICK OLD POINTS
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim z = 50
        While Chartvalues.count > z

            For Each point In Chartvalues
                Chartvalues.remove(point)
                GoTo end_of_for
            Next
end_of_for: ' YUP I USED GOTO :P

        End While
        While nvidiavalues.count > z

            For Each point In nvidiavalues
                nvidiavalues.remove(point)
                GoTo end_of_for2
            Next
end_of_for2: ' YUP I USED GOTO :P
        End While
        While AMDValues.count > z

            For Each point In AMDValues
                AMDValues.remove(point)
                GoTo end_of_for3
            Next
end_of_for3: ' YUP I USED GOTO :P
        End While
        While CPUValues.count > z

            For Each point In CPUValues
                CPUValues.remove(point)
                GoTo end_of_for4
            Next
end_of_for4: ' YUP I USED GOTO :P
        End While
        While nvidiavalues.count < CPUValues.count
            nvidiavalues.add(newNVhashRate)
        End While
        While CPUValues.count < nvidiavalues.count
            CPUValues.add(newCPUhashrate)
        End While
        While Chartvalues.count < CPUValues.count
            Chartvalues.add(newhashrate)
        End While
        While CPUValues.count < Chartvalues.count
            CPUValues.add(newCPUhashrate)
        End While
        While nvidiavalues.count < Chartvalues.count
            nvidiavalues.add(newNVhashRate)
        End While
        While AMDValues.count < Chartvalues.count
            AMDValues.add(newAMDhashrate)
        End While
        If newNVhashRate > newhashrate Then
            newNVhashRate = 0
        End If
        If newAMDhashrate > newhashrate Then
            newAMDhashrate = 0
        End If
        nvidiavalues.Add(newNVhashRate)
        AMDValues.Add(newAMDhashrate)
        CPUValues.Add(newCPUhashrate)
        Chartvalues.Add(newhashrate)
        CartesianChart1.Update()

    End Sub
    Private WithEvents browser As ChromiumWebBrowser
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim settings As New CefSettings()
        If CefSharp.Cef.IsInitialized Then

        Else
            CefSharp.Cef.Initialize(settings)
        End If

        browser = New ChromiumWebBrowser(chatSupportxmr) With {
           .Dock = DockStyle.Fill
       }
        browser.BackColor = Color.FromArgb(&HFF, 41, 41, 47)
        chatpanel.Controls.Add(browser)

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    ' CLEARS TERMINAL OUTPUT
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        If Dir(xmroutput) <> "" Then
            Try
                My.Computer.FileSystem.DeleteFile(xmroutput)

            Catch ex As Exception
                'clearing during same session throws exception
            End Try

        End If
        RichTextBox1.Text = ""
    End Sub
    ' THIS RUNS WHEN ITS TIME TO MINE ON THE DEV'S POOL - STARTS TIMER FOR x% OF 100 MINUTES, KILLS XMR-STAK, WRITES NEW CONFIG FILE, AND RESTARTS XMR-STAK
    Private Sub devdonatetimer_Tick(sender As Object, e As EventArgs) Handles devdonatetimer.Tick
        ' runs for the period of dev donation and starts the user mining process again
        devdonatetimer.Stop()
        devdonatetimer.Enabled = False
        userminingtimer.Enabled = True
        userminingtimer.Start()
        devt = False
        Process.GetProcessesByName("xmr-stak")(0).Kill()
        If Not proc.WaitForExit(30000) Then
            MsgBox("Failed to shut down xmr-stak.exe. Please terminate it with task manager.")
        Else
            Threading.Thread.Sleep(1000)
            Try
                If Dir(xmroutput) <> "" Then
                    My.Computer.FileSystem.DeleteFile(xmroutput)
                End If
            Catch
            End Try
            ' Fill GUI with previous settings
            refreshinteger = refreshint.Value
            loadsettings(configfile)

            switching = True
            writeuserconfig(switching)
            Dim startInfo As New ProcessStartInfo
            With startInfo
                .UseShellExecute = True
                .FileName = xmrstak
                .WindowStyle = ProcessWindowStyle.Hidden
                .Verb = "runas" 'add this to prompt for elevation
                '.Arguments = "-c " & xmrconfig
            End With
            Dim proc = Process.Start(startInfo)
        End If
    End Sub
    ' THIS RUNS WHEN ITS TIME TO MINE FOR THE USER AGAIN - STARTS THE TIMER FOR 100 MINUTES, KILLS XMR-STAK, WRITES NEW CONFIG FILE, AND RESTARTS XMR-STAK
    Private Sub useminingtimer_Tick(sender As Object, e As EventArgs) Handles userminingtimer.Tick
        ' runs for the period of user mining and then starts dev donate
        userminingtimer.Stop()
        userminingtimer.Enabled = False
        devt = True
        Process.GetProcessesByName("xmr-stak")(0).Kill()
        If Not proc.WaitForExit(30000) Then
            MsgBox("Failed to shut down xmr-stak.exe. Please terminate it with task manager.")
        Else
            loadsettings(dev)
            switching = True
            writeuserconfig(switching)

            Dim startInfo As New ProcessStartInfo
            With startInfo
                .UseShellExecute = True
                .FileName = xmrstak
                .WindowStyle = ProcessWindowStyle.Hidden
                .Verb = "runas" 'add this to prompt for elevation
                '.Arguments = "-c " & xmrconfig
            End With
            Dim proc = Process.Start(startInfo)

        End If

        'write dev config
        devdonatetimer.Enabled = True
        devdonatetimer.Start()
    End Sub
    ' OPENS DEV DONATION MENU
    Private Sub DonationLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonationLevelToolStripMenuItem.Click
        devdonation.Show()
    End Sub
    ' OPENS ABOUT MENU
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("©2018 XMRGUI " & currentversion & " Kyle Dixon" & vbCrLf & "www.xmrgui.com")
    End Sub
    ' CREATES AND IDLE TASK TO THE BAT WE CREATED
    Private Sub EnableOnIdleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableOnIdleToolStripMenuItem.Click
        If EnableOnIdleToolStripMenuItem.Checked = True Then
            MsgBox("* Enable on idle will only work while XMRGUI is running. A startup entry will be added. *" & vbCrLf & vbCrLf & "XMRGUI begin mining 5 minutes after you stop using your PC." & vbCrLf & vbCrLf & "Its is also recommeded that you fully exit XMRGUI while watching videos, etc to avoid system lag.")
            idletask = True
            savesettings()
            If Dir(startupetry) <> "" And Dir(startupdest) = "" Then
                My.Computer.FileSystem.CopyFile(startupetry, startupdest)
            End If
            If Dir(startupdestst) <> "" Then
                My.Computer.FileSystem.DeleteFile(startupdestst)
            End If
            EnableOnStartupToolStripMenuItem.Checked = True
        End If
        If EnableOnIdleToolStripMenuItem.Checked = False Then
            idletask = False
            EnableOnStartupToolStripMenuItem.Checked = False
            savesettings()
            If Dir(startupdest) <> "" Then
                My.Computer.FileSystem.DeleteFile(startupdest)
            End If
        End If
    End Sub
    ' CREATES A STARTUP ENTRY - NEED TO FINISH
    Private Sub EnableOnStartupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableOnStartupToolStripMenuItem.Click
        If EnableOnStartupToolStripMenuItem.Checked = True Then
            If idletask = True Then
                MsgBox("Sorry, ""Enable on Idle"" must be disbled to run on startup.")
            Else
                If Dir(startupetryst) <> "" And Dir(startupdestst) = "" Then
                    My.Computer.FileSystem.CopyFile(startupetryst, startupdestst)
                End If
                startupenabled = True
                savesettings()
            End If
        End If
        If EnableOnStartupToolStripMenuItem.Checked = False Then
            If idletask = True Then
                MsgBox("Sorry. For the ""Enable on Idle"" Feature to work, XMRGUI has to run on startup. To disable this uncheck ""Enable on Idle"".")
                EnableOnStartupToolStripMenuItem.Checked = True
            Else
                If Dir(startupdestst) <> "" Then
                    My.Computer.FileSystem.DeleteFile(startupdestst)
                End If
                startupenabled = False
                savesettings()
            End If
        End If
    End Sub
    ' EXIT BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If trayicon = False Then
            Me.Close()
        Else
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            NotifyIcon1.BalloonTipTitle = "XMRGUI v1.9"
            NotifyIcon1.BalloonTipText = "XMRGUI Will continue to run in the background. To disable this, click View and toggle ""Tray Icon""."
            NotifyIcon1.ShowBalloonTip(3)
        End If

    End Sub
    ' CHANGES THE CHART'S REFRESH INTERVAL
    Private Sub refreshint_ValueChanged(sender As Object, e As EventArgs) Handles refreshint.ValueChanged
        refreshinteger = refreshint.Value
        refreshrate = refreshinteger * 1000
    End Sub

    ' GRABS XMR-STAK OUTPUT AND RUNS A REGEX ON THE HASHRATE TO PROVIDE VALUES TO THE CHART
    Private Sub timeroutput_Tick(sender As Object, e As EventArgs) Handles timeroutput.Tick
        Try
            'Dim lateststring = getlastlines(xmroutput, 30)
            ' START NEW TEST
            Dim fs = File.Open(xmroutput, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim reader As StreamReader = New StreamReader(fs)
            Dim wholefile = reader.ReadToEnd
            RichTextBox1.Text = wholefile
            RichTextBox1.SelectionStart = RichTextBox1.Text.Length
            fs.Close()
            reader.Close()

            For x As Integer = 1 To 18
                Dim line As String = RichTextBox1.Lines(RichTextBox1.Lines.Length - x)
                If line.Contains("Totals") Then ' Should be "Totals"
                    'Dim regex As Regex = New Regex("\d+?.\d+")
                    Dim regex As Regex = New Regex("\d{1,5}\.\d{1,1}") ' match a double
                    Dim ret = regex.Match(line).Value

                    If ret <> "" Then
                        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(upseconds)
                        Label8.Text = "Uptime - Hours: " & iSpan.Hours & " Minutes: " & iSpan.Minutes & " Seconds: " & iSpan.Seconds & "               " & ret & " H/s"
                        NotifyIcon1.Text = "Uptime - Hours: " & iSpan.Hours & vbCrLf & " Minutes: " & iSpan.Minutes & vbCrLf & " Seconds: " & iSpan.Seconds & vbCrLf & ret & " H/s"
                    Else
                        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(upseconds)
                        NotifyIcon1.Text = "Uptime - Hours: " & iSpan.Hours & vbCrLf & " Minutes: " & iSpan.Minutes & vbCrLf & " Seconds: " & iSpan.Seconds & vbCrLf & "Initializing..."
                        Label8.Text = "Uptime - Hours: " & iSpan.Hours & " Minutes: " & iSpan.Minutes & " Seconds: " & iSpan.Seconds & "            Initializing..."
                        ret = "0.0"
                    End If
                    'Dim match As Match = regex.Match(lastline)
                    newhashrate = Convert.ToDouble(ret)
                ElseIf line.Contains("NVIDIA") Then
                    Dim regexnv As Regex = New Regex("\d{1,5}\.\d{1,1}") ' match a double
                    Dim retnv = regexnv.Match(line).Value
                    newNVhashRate = Convert.ToDouble(retnv)
                    If firstNV = False Then
                        newser.Add(nvidiacard1)
                        nvidiacard1.Title = "NIVIDIA Hashrate(H/s)"
                        nvidiacard1.Values = nvidiavalues
                        For Each z In Chartvalues
                            Chartvalues.remove(z)
                        Next
                        nvidiavalues.add(0)
                        firstNV = True
                    End If
                ElseIf line.Contains("AMD") Then

                    Dim regexAMD As Regex = New Regex("\d{1,5}\.\d{1,1}") ' match a double
                    Dim retAMD = regexAMD.Match(line).Value
                    newAMDhashrate = Convert.ToDouble(retAMD)
                    If firstAMD = False Then
                        newser.Add(AMDCard1)
                        AMDCard1.Title = "AMD Hashrate(H/s)"
                        AMDCard1.Values = AMDValues
                        For Each z In Chartvalues
                            Chartvalues.remove(z)
                        Next
                        AMDValues.add(0)
                        firstAMD = True
                    End If
                End If
                ' Now if a GPU exists, add a new lineseries for CPU
                If firstAMD = True Or firstNV = True Then
                    If firstCPU = False Then
                        newser.Add(CPU1)
                        CPU1.Title = "CPU Hashrate(H/s)"
                        CPU1.Values = CPUValues
                        For Each z In Chartvalues
                            Chartvalues.remove(z)
                        Next
                        CPUValues.add(0)
                        Chartvalues.add(0)
                        test.Fill = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(&H25, 112, 250, 79))
                        test.Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(&HFF, 112, 250, 79))
                        firstCPU = True
                    End If
                    newCPUhashrate = newhashrate - newNVhashRate - newAMDhashrate
                    If newCPUhashrate < 0 Then
                        newCPUhashrate = 0
                    End If
                End If
            Next
            'Begin hashrate monitoring

        Catch
        End Try
        'begin problem catching



        If newhashrate = savedrate Then
            xoccured += 1
        Else
            xoccured = 0
        End If
        savedrate = newhashrate
        If xoccured > 45 And mining = True Then

            hrmlabel.ForeColor = Color.Red
            stopbtn.PerformClick()
            hrmlabel.Text = "PROBLEM DETECTED...RESTARTING"
            Threading.Thread.Sleep(10000)
            startbtn.PerformClick()
            xoccured = 0
            If HRMactive = "True" Then
                hrmlabel.Text = "HASHRATE MONITORING ACTIVE"
                hrmlabel.ForeColor = Color.LimeGreen
            Else
                hrmlabel.Text = "HASHRATE MONITORING INACTIVE"
                hrmlabel.ForeColor = Color.Maroon
            End If

        End If
        'begin hashrate monitoring

        If HRMactive = True Then
            If devt = False Then
                If HRMdictionary.ContainsKey(HRMx) Then
                    HRMdictionary.Remove(HRMx)
                End If
                HRMdictionary.Add(HRMx, newhashrate)
                HRMx += 1
            End If
            Dim count = HRMdictionary.Count
            Label25.Text = count
            If HRMx > 120 Then 'should be 119
                HRMdictionary.Remove(1)
                HRMx = 1
            End If
            Dim sum As Double
            For Each z As KeyValuePair(Of Integer, Double) In HRMdictionary
                sum += z.Value
            Next
            Dim avg = sum / count
            Label22.Text = devt 'rem
            Label23.Text = avg 'rem
            If perchs = "%" Then
                Dim percentage = Convert.ToInt32(HRMValue)
                Dim threshold = avg * (percentage / 100)
                Label24.Text = threshold 'rem
                If newhashrate < threshold Then
                    'start timing and save checkval
                    devt = True
                    If HRMTime < 1 Then
                        HRMTime = 1
                    End If
                    HRMTimer.Interval = Convert.ToInt16(HRMTime) * 60000
                    Label21.Text = HRMTimer.Interval 'rem
                    HRMTimer.Enabled = True
                    HRMTimer.Start()
                    msg2 = "Low Hashrate Detected"
                    msg1 = "Waiting for Stabilization"
                Else
                    'stop timing
                    devt = False
                    HRMTimer.Stop()
                    HRMTimer.Enabled = False
                    'hashrate stabilized in time
                    msg1 = "HASHRATE MONITORING ACTIVE"
                    msg2 = ""
                End If
            End If
            If perchs = "H/s" Then
                Dim threshold = Convert.ToInt32(HRMValue)
                If newhashrate < threshold Then
                    devt = True
                    HRMTimer.Interval = Convert.ToInt16(HRMTime) * 60000
                    HRMTimer.Enabled = True
                    HRMTimer.Start()
                    msg2 = "Low Hashrate Detected"
                    msg1 = "Waiting for Stabilization"
                Else
                    'stop timing
                    devt = False
                    HRMTimer.Stop()
                    HRMTimer.Enabled = False
                    'hashrate stabilized in time
                    msg1 = "HASHRATE MONITORING ACTIVE"
                    msg2 = ""
                End If
            End If
        End If
        ' END NEW TEST
    End Sub
    ' FILE EXIT BUTTON
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    ' HANDLES THE UPTIMER
    Private Sub uptime_Tick(sender As Object, e As EventArgs) Handles uptime.Tick
        upseconds += 1
    End Sub
    ' WRITES CPU CONFIGURATION FILE FOR MANUAL MODE
    Private Sub cpuconfigwrite()
        If cputhreadspicker.Value > pccores Then
            MsgBox("XMRGUI has detected that your PC can't run higher than " & pccores.ToString & " threads.")
            cputhreadspicker.Value = pccores
        End If
        If manualmode = True Then
            If Dir(cpuconfigfile) <> "" Then
                Try
                    My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            End If
            Dim corenumber As Int16 = 0
            Dim threadcount As Int16 = cputhreadspicker.Value
            Dim cpuconfigwriter As System.IO.StreamWriter
            cpuconfigwriter = My.Computer.FileSystem.OpenTextFileWriter(cpuconfigfile, True)
            cpuconfigwriter.WriteLine("""cpu_threads_conf"" :  ")
            cpuconfigwriter.WriteLine("[")
            If threadcount > pccores / 2 Then
                For x As Integer = 1 To threadcount
                    cpuconfigwriter.WriteLine("    { ""low_power_mode"" :  false, ""no_prefetch"" : true, ""affine_to_cpu"" : " & corenumber & " },")
                    corenumber += 1
                Next
            Else
                For x As Integer = 1 To threadcount
                    cpuconfigwriter.WriteLine("    { ""low_power_mode"" :  false, ""no_prefetch"" : true, ""affine_to_cpu"" : " & corenumber & " },")
                    corenumber += 2
                Next
            End If
            cpuconfigwriter.WriteLine("],")
            cpuconfigwriter.Close()
        End If
    End Sub
    Private Sub cputhreadspicker_ValueChanged(sender As Object, e As EventArgs) Handles cputhreadspicker.ValueChanged
        cpuconfigwrite()
    End Sub

    Private Sub Exittraybtn_Click(sender As Object, e As EventArgs) Handles Exittraybtn.Click
        Me.Close()
    End Sub

    Private Sub TrayIconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrayIconToolStripMenuItem.Click
        If TrayIconToolStripMenuItem.Checked = True Then
            NotifyIcon1.Visible = True
            trayicon = True
            savesettings()
            'save this setting
        Else
            NotifyIcon1.Visible = False
            trayicon = False
            savesettings()
            'save this setting
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub
    ' SETS CHART AND TERMINAL COLORS
    Private Sub TerminalColorsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TerminalColorsToolStripMenuItem.Click
        If ColorDialog1.ShowDialog <> DialogResult.Cancel Then
            terminalcolor = ColorDialog1.Color
            RichTextBox1.ForeColor = terminalcolor
            test.Fill = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(&H25, ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B))
            test.Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(&HFF, ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B))
            CartesianChart1.Update()
        End If
    End Sub

    Private Sub MineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MineToolStripMenuItem.Click
        startbtn.PerformClick()
        StopToolStripMenuItem.Enabled = True
        StopToolStripMenuItem.Visible = True
        MineToolStripMenuItem.Enabled = False
        MineToolStripMenuItem.Visible = False
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        stopbtn.PerformClick()
        StopToolStripMenuItem.Enabled = False
        StopToolStripMenuItem.Visible = False
        MineToolStripMenuItem.Enabled = True
        MineToolStripMenuItem.Visible = True
    End Sub

    Private Sub HashRateMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HashRateMonitoringToolStripMenuItem.Click
        HashrateMonitor.Show()
    End Sub

    Private Sub radioautomatic_CheckedChanged(sender As Object, e As EventArgs) Handles radioautomatic.CheckedChanged
        If radioautomatic.Checked = True Then
            cputhreadspicker.Enabled = False
            configoverridebtn.Enabled = False
            radiomanual.Checked = False
            radiomanualfiles.Checked = False
            mode = "auto"
            manualmode = False
            Try
                My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                My.Computer.FileSystem.DeleteFile(nvconfigfile)
                My.Computer.FileSystem.DeleteFile(amdconfigfile)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub radiomanual_CheckedChanged(sender As Object, e As EventArgs) Handles radiomanual.CheckedChanged
        If radiomanual.Checked = True Then
            cputhreadspicker.Enabled = True
            configoverridebtn.Enabled = False
            radiomanualfiles.Checked = False
            radioautomatic.Checked = False
            manualmode = True
            mode = "manual"
            Try
                My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                My.Computer.FileSystem.DeleteFile(nvconfigfile)
                My.Computer.FileSystem.DeleteFile(amdconfigfile)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub radiomanualfiles_CheckedChanged(sender As Object, e As EventArgs) Handles radiomanualfiles.CheckedChanged
        If radiomanualfiles.Checked = True Then
            radiomanual.Checked = False
            radioautomatic.Checked = False
            cputhreadspicker.Enabled = False
            configoverridebtn.Enabled = True
            mode = "manualoverride"
        End If
    End Sub
    ' UPDATES POOL INFORMATION FROM JSON API
    Private Sub poolapitimer_Tick(sender As Object, e As EventArgs) Handles poolapitimer.Tick
        If poolurl.Text = "pool.supportxmr.com" Then
            'Recieve info
            Try
                Dim jsonurl = "https://supportxmr.com/api/miner/" & xmraddr.Text & "/stats"
                Dim request As HttpWebRequest
                Dim response As HttpWebResponse = Nothing
                Dim reader As StreamReader
                Dim correctedamtdue
                Dim correctedamtpaid
                request = DirectCast(WebRequest.Create(jsonurl), HttpWebRequest)

                response = DirectCast(request.GetResponse(), HttpWebResponse)
                reader = New StreamReader(response.GetResponseStream())

                Dim rawresp As String
                rawresp = reader.ReadToEnd()
                'END RECIEVE

                Dim obj = JsonConvert.DeserializeObject(Of JSON_result)(rawresp) ' insert JSON results string
                'Start correcting balance decimals
                ' peding balance correction
                If obj.amtDue.Length > 12 Then
                    Dim decimaldue = obj.amtDue.Substring(obj.amtDue.Length - 12)
                    Dim decplaces = obj.amtDue.Length
                    Dim getthismanycharacters = decplaces - 12
                    Dim fullxmr = obj.amtDue.Substring(0, getthismanycharacters)
                    correctedamtdue = fullxmr & "." & decimaldue
                Else
                    Dim decplaces = obj.amtDue.Length
                    Dim addthismanyzeros = 12 - decplaces
                    correctedamtdue = "0." & StrDup(addthismanyzeros, "0") & obj.amtDue
                End If
                ' total paid correction
                If obj.amtPaid.Length > 12 Then
                    Dim decimaldue = obj.amtPaid.Substring(obj.amtPaid.Length - 12)
                    Dim decplaces = obj.amtPaid.Length
                    Dim getthismanycharacters = decplaces - 12
                    Dim fullxmr = obj.amtPaid.Substring(0, getthismanycharacters)
                    correctedamtpaid = fullxmr & "." & decimaldue
                Else
                    Dim decplaces = obj.amtPaid.Length
                    Dim addthismanyzeros = 12 - decplaces
                    correctedamtpaid = "0." & StrDup(addthismanyzeros, "0") & obj.amtPaid
                End If


                'End correcting balance decimals
                poolhashrate.Text = obj.hash & " H/s"
                pooltotalhashes.Text = obj.totalHashes
                poolvalidshares.Text = obj.validShares
                poolinvalidshares.Text = obj.invalidshares
                poolpendingbalance.Text = correctedamtdue & " XMR"
                pooltotalpaid.Text = correctedamtpaid & " XMR"
            Catch
            End Try
        End If
    End Sub

    Private Sub configoverridebtn_Click(sender As Object, e As EventArgs) Handles configoverridebtn.Click
        startbtn.Text = "Please Wait..."
        startbtn.Enabled = False

        If Dir(cpuconfigfile) <> "" Then
            Try
                My.Computer.FileSystem.DeleteFile(cpuconfigfile)
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
        If Dir(nvconfigfile) <> "" Then

            Try
                My.Computer.FileSystem.DeleteFile(nvconfigfile)
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
        If Dir(amdconfigfile) <> "" Then

            Try
                My.Computer.FileSystem.DeleteFile(amdconfigfile)
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
        startminer()
        While System.IO.File.Exists(cpuconfigfile) = False
        End While
        startbtn.Enabled = True
        startbtn.Text = "Mine!"
        stopminer()
        If Dir(amdconfigfile) <> "" Then
            amdcards = True
        End If
        If Dir(nvconfigfile) <> "" Then
            nvcards = True
        End If
        ' Write new universal settings file - still needs to be cleaned from startminer
        savesettings()
        loadsettings(configfile)
        gpuconfig.Show()
    End Sub
    Private Sub stopminer()
        poolurl.Enabled = True
        stopbtn.Enabled = False
        poolpass.Enabled = True
        xmraddr.Enabled = True
        port.Enabled = True
        refreshint.Enabled = True
        startbtn.Enabled = True
        devdonatetimer.Stop()
        devdonatetimer.Enabled = False
        userminingtimer.Stop()
        userminingtimer.Enabled = False
        timeroutput.Enabled = False
        timeroutput.Stop()
        uptime.Stop()
        upseconds = 0
        Label8.Text = ""
        StopToolStripMenuItem.Enabled = False
        StopToolStripMenuItem.Visible = False
        MineToolStripMenuItem.Enabled = True
        MineToolStripMenuItem.Visible = True
        radioautomatic.Enabled = True
        radiomanual.Enabled = True
        radiomanualfiles.Enabled = True
        cputhreadspicker.Enabled = True
        Try
            Process.GetProcessesByName("xmr-stak")(0).Kill()
            Timer1.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("http://xmrgui.com/")
    End Sub
    Private Sub SubredditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubredditToolStripMenuItem.Click
        Process.Start("http://reddit.com/r/XMRGUI/")
    End Sub

    Private Sub MinuteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MinutesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MinutesToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub idletimer_Tick(sender As Object, e As EventArgs) Handles idletimer.Tick
        If idletask = True Then
            If mining = False Then
                If it.IdleTime > 300 Then
                    startbtn.PerformClick()
                    idlemining = True
                End If
            End If
            If mining = True And idlemining = True Then
                If it.IdleTime < 2 Then
                    idlemining = False
                    stopbtn.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            If Dir(profile0conf) <> "" Then
                My.Computer.FileSystem.DeleteFile(configfile)
                My.Computer.FileSystem.CopyFile(profile0conf, configfile)
                If Dir(amdconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(amdconfigfile)
                End If
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                End If
                If Dir(nvconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(nvconfigfile)
                End If
                If Dir(profile0cpu) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile0cpu, cpuconfigfile)
                End If
                If Dir(profile0amd) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile0amd, amdconfigfile)
                End If
                If Dir(profile0nv) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile0nv, nvconfigfile)
                End If
            End If
        End If
        If ComboBox1.SelectedIndex = 1 Then
            If Dir(profile1conf) <> "" Then
                My.Computer.FileSystem.DeleteFile(configfile)
                My.Computer.FileSystem.CopyFile(profile1conf, configfile)
                If Dir(amdconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(amdconfigfile)
                End If
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                End If
                If Dir(nvconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(nvconfigfile)
                End If
                If Dir(profile1cpu) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile1cpu, cpuconfigfile)
                End If
                If Dir(profile1amd) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile1amd, amdconfigfile)
                End If
                If Dir(profile1nv) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile1nv, nvconfigfile)
                End If
            End If
        End If
        If ComboBox1.SelectedIndex = 2 Then
            If Dir(profile2conf) <> "" Then
                My.Computer.FileSystem.DeleteFile(configfile)
                My.Computer.FileSystem.CopyFile(profile2conf, configfile)
                If Dir(amdconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(amdconfigfile)
                End If
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                End If
                If Dir(nvconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(nvconfigfile)
                End If
                If Dir(profile2cpu) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile2cpu, cpuconfigfile)
                End If
                If Dir(profile2amd) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile2amd, amdconfigfile)
                End If
                If Dir(profile2nv) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile2nv, nvconfigfile)
                End If
            End If
        End If
        If ComboBox1.SelectedIndex = 3 Then
            If Dir(profile3conf) <> "" Then
                My.Computer.FileSystem.DeleteFile(configfile)
                My.Computer.FileSystem.CopyFile(profile3conf, configfile)
                If Dir(amdconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(amdconfigfile)
                End If
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                End If
                If Dir(nvconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(nvconfigfile)
                End If
                If Dir(profile3cpu) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile3cpu, cpuconfigfile)
                End If
                If Dir(profile3amd) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile3amd, amdconfigfile)
                End If
                If Dir(profile3nv) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile3nv, nvconfigfile)
                End If
            End If
        End If
        If ComboBox1.SelectedIndex = 4 Then
            If Dir(profile4conf) <> "" Then
                My.Computer.FileSystem.DeleteFile(configfile)
                My.Computer.FileSystem.CopyFile(profile4conf, configfile)
                If Dir(amdconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(amdconfigfile)
                End If
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(cpuconfigfile)
                End If
                If Dir(nvconfigfile) <> "" Then
                    My.Computer.FileSystem.DeleteFile(nvconfigfile)
                End If
                If Dir(profile4cpu) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile4cpu, cpuconfigfile)
                End If
                If Dir(profile4amd) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile4amd, amdconfigfile)
                End If
                If Dir(profile4nv) <> "" Then
                    My.Computer.FileSystem.CopyFile(profile4nv, nvconfigfile)
                End If
            End If
        End If
        loadsettings(configfile)
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        ' The biggest piece of shit code I've ever written :(
        If radioautomatic.Checked = True Then
            If Dir(cpuconfigfile) <> "" Then
                My.Computer.FileSystem.DeleteFile(cpuconfigfile)
            End If
            startbtn.PerformClick()
            While System.IO.File.Exists(cpuconfigfile) = False
            End While
            stopbtn.PerformClick()
        End If
        If ComboBox1.SelectedIndex = 0 Then
            If Dir(profile0conf) <> "" Then
                'prompt for overwrite
                Dim result As Integer = MessageBox.Show("Do you want to overwrite the profile " & ComboBox1.SelectedText, "Overwrite?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(profile0conf)
                    If Dir(profile0cpu) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile0cpu)
                    End If
                    If Dir(profile0nv) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile0nv)
                    End If
                    If Dir(profile0amd) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile0amd)
                    End If

                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(cpuconfigfile, profile0cpu)
                        My.Computer.FileSystem.CopyFile(configfile, profile0conf)
                        If Dir(amdconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(amdconfigfile, profile0amd)
                        End If
                        If Dir(nvconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(nvconfigfile, profile0nv)
                        End If
                    Else
                        MsgBox("You need to run the miner before saving this profile.")
                    End If
                End If
            Else
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.CopyFile(cpuconfigfile, profile0cpu)
                    My.Computer.FileSystem.CopyFile(configfile, profile0conf)
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(amdconfigfile, profile0amd)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(nvconfigfile, profile0nv)
                    End If
                Else
                    MsgBox("You need to run the miner before saving this profile.")
                End If
            End If
        End If
        If ComboBox1.SelectedIndex = 1 Then
            If Dir(profile1conf) <> "" Then
                'prompt for overwrite
                Dim result As Integer = MessageBox.Show("Do you want to overwrite the profile " & ComboBox1.SelectedText, "Overwrite?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(profile1conf)
                    If Dir(profile1cpu) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile1cpu)
                    End If
                    If Dir(profile1nv) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile1nv)
                    End If
                    If Dir(profile1amd) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile1amd)
                    End If

                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(cpuconfigfile, profile1cpu)
                        My.Computer.FileSystem.CopyFile(configfile, profile1conf)
                        If Dir(amdconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(amdconfigfile, profile1amd)
                        End If
                        If Dir(nvconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(nvconfigfile, profile1nv)
                        End If
                    Else
                        MsgBox("You need to run the miner before saving this profile.")
                    End If
                End If
            Else
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.CopyFile(cpuconfigfile, profile1cpu)
                    My.Computer.FileSystem.CopyFile(configfile, profile1conf)
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(amdconfigfile, profile1amd)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(nvconfigfile, profile1nv)
                    End If
                Else
                    MsgBox("You need to run the miner before saving this profile.")
                End If
            End If
        End If
        If ComboBox1.SelectedIndex = 2 Then
            If Dir(profile2conf) <> "" Then
                'prompt for overwrite
                Dim result As Integer = MessageBox.Show("Do you want to overwrite the profile " & ComboBox1.SelectedText, "Overwrite?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(profile2conf)
                    If Dir(profile2cpu) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile2cpu)
                    End If
                    If Dir(profile2nv) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile2nv)
                    End If
                    If Dir(profile2amd) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile2amd)
                    End If

                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(cpuconfigfile, profile2cpu)
                        My.Computer.FileSystem.CopyFile(configfile, profile2conf)
                        If Dir(amdconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(amdconfigfile, profile2amd)
                        End If
                        If Dir(nvconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(nvconfigfile, profile2nv)
                        End If
                    Else
                        MsgBox("You need to run the miner before saving this profile.")
                    End If
                End If
            Else
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.CopyFile(cpuconfigfile, profile2cpu)
                    My.Computer.FileSystem.CopyFile(configfile, profile2conf)
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(amdconfigfile, profile2amd)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(nvconfigfile, profile2nv)
                    End If
                Else
                    MsgBox("You need to run the miner before saving this profile.")
                End If
            End If
        End If
        If ComboBox1.SelectedIndex = 3 Then
            If Dir(profile3conf) <> "" Then
                'prompt for overwrite
                Dim result As Integer = MessageBox.Show("Do you want to overwrite the profile " & ComboBox1.SelectedText, "Overwrite?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(profile3conf)
                    If Dir(profile3cpu) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile3cpu)
                    End If
                    If Dir(profile3nv) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile3nv)
                    End If
                    If Dir(profile3amd) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile3amd)
                    End If

                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(cpuconfigfile, profile3cpu)
                        My.Computer.FileSystem.CopyFile(configfile, profile3conf)
                        If Dir(amdconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(amdconfigfile, profile3amd)
                        End If
                        If Dir(nvconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(nvconfigfile, profile3nv)
                        End If
                    Else
                        MsgBox("You need to run the miner before saving this profile.")
                    End If
                End If
            Else
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.CopyFile(cpuconfigfile, profile3cpu)
                    My.Computer.FileSystem.CopyFile(configfile, profile3conf)
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(amdconfigfile, profile3amd)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(nvconfigfile, profile3nv)
                    End If
                Else
                    MsgBox("You need to run the miner before saving this profile.")
                End If
            End If
        End If
        If ComboBox1.SelectedIndex = 4 Then
            If Dir(profile4conf) <> "" Then
                'prompt for overwrite
                Dim result As Integer = MessageBox.Show("Do you want to overwrite the profile " & ComboBox1.SelectedText, "Overwrite?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(profile4conf)
                    If Dir(profile4cpu) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile4cpu)
                    End If
                    If Dir(profile4nv) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile4nv)
                    End If
                    If Dir(profile4amd) <> "" Then
                        My.Computer.FileSystem.DeleteFile(profile4amd)
                    End If

                    If Dir(cpuconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(cpuconfigfile, profile4cpu)
                        My.Computer.FileSystem.CopyFile(configfile, profile4conf)
                        If Dir(amdconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(amdconfigfile, profile4amd)
                        End If
                        If Dir(nvconfigfile) <> "" Then
                            My.Computer.FileSystem.CopyFile(nvconfigfile, profile4nv)
                        End If
                    Else
                        MsgBox("You need to run the miner before saving this profile.")
                    End If
                End If
            Else
                If Dir(cpuconfigfile) <> "" Then
                    My.Computer.FileSystem.CopyFile(cpuconfigfile, profile4cpu)
                    My.Computer.FileSystem.CopyFile(configfile, profile4conf)
                    If Dir(amdconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(amdconfigfile, profile4amd)
                    End If
                    If Dir(nvconfigfile) <> "" Then
                        My.Computer.FileSystem.CopyFile(nvconfigfile, profile4nv)
                    End If
                Else
                    MsgBox("You need to run the miner before saving this profile.")
                End If
            End If
        End If
    End Sub

    Private Sub ProfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilesToolStripMenuItem.Click
        Profiles.Show()
    End Sub
    Private Sub beginnerui()

    End Sub
    Private Sub noviceui()

    End Sub
    Private Sub advancedui()

    End Sub
    Private Sub BeginnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeginnerToolStripMenuItem.Click

    End Sub

    Private Sub hrmlabeltimer_Tick(sender As Object, e As EventArgs) Handles hrmlabeltimer.Tick
        hrmlabel.Text = "HASHRATE MONITORING ACTIVE"
        hrmlabeltimer2.Enabled = True
        hrmlabel.ForeColor = Color.LimeGreen
        hrmlabeltimer2.Start()
        hrmlabeltimer.Stop()
    End Sub

    Private Sub hrmlabeltimer2_Tick(sender As Object, e As EventArgs) Handles hrmlabeltimer2.Tick
        hrmlabel.Text = msg2
        hrmlabel.ForeColor = msg2color
        hrmlabeltimer2.Stop()
        hrmlabeltimer.Start()
    End Sub

    Private Sub HRMTimer_Tick(sender As Object, e As EventArgs) Handles HRMTimer.Tick
        HRMTimer.Stop() ' stop timing, we dont want it repeating itself
        msg2 = "Restarting Miner"
        msg2color = Color.Red
        devt = True ' stop averaging...the average will drop while restarting
        stopbtn.PerformClick()
        Try
            Process.Start(OCCommand, OCArgs)
        Catch ex As Exception

        End Try
        Threading.Thread.Sleep(1000)
        For x As Integer = 1 To HRMdictionary.Count
            HRMdictionary.Remove(x)
        Next
        HRMx = 1
        Threading.Thread.Sleep(10000)
        startbtn.PerformClick()
        devt = False
        msg2 = ""
        msg2color = Color.OrangeRed
    End Sub

    ' RUNS WIZARD
    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        noob.Show()
        Me.Hide()
    End Sub
End Class
Public Class JSON_result
    Public hash As String
    Public totalHashes As String
    Public validShares As String
    Public invalidshares As String
    Public amtPaid As String
    Public amtDue As String
End Class
Public Class JSON_settings
    Public idleenabled As String
    Public xmraddress As String
    Public pool As String
    Public poolport As String
    Public poolpassword As String
    Public donatelevel As String
    Public nvcards As String
    Public amdcards As String
    Public mode As String
    Public cputhreads As String
    Public trayicon As String
    Public HRMEnabled As String
    Public perchs As String
    Public HRMValue As String
    Public HRMTime As String
    Public OCon As String
    Public OCCommand As String
    Public OCArgs As String
    Public startupenabled As String
End Class
Public Class IdleTime

    Private Declare Function GetLastInputInfo Lib "User32.dll" _
      (ByRef lastInput As LASTINPUTINFO) As Boolean

    <StructLayout(LayoutKind.Sequential)>
    Public Structure LASTINPUTINFO
        Public cbSize As Int32
        Public dwTime As Int32
    End Structure


    Public ReadOnly Property IdleTime() As Integer

        Get

            Dim lastInput As New LASTINPUTINFO

            lastInput.cbSize = Marshal.SizeOf(lastInput)

            If GetLastInputInfo(lastInput) Then

                Return (Environment.TickCount - lastInput.dwTime) / 1000

            End If

        End Get

    End Property

End Class