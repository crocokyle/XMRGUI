Option Explicit On
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.IO.Compression
Imports System.ComponentModel
Imports IWshRuntimeLibrary


Public Class Form1
    Dim WithEvents WC As New WebClient
    Dim WithEvents xmrstak As New WebClient
    Dim pInfo As New ProcessStartInfo()
    Dim self = Application.ExecutablePath
    Dim objShell = CreateObject("WScript.Shell")
    Dim oFSO = CreateObject("Scripting.FileSystemObject")
    Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
    Dim configfile = strAppData & "\XMRGUI\gpuconfig.dat"
    Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
    Dim workingdir = strAppData & "\XMRGUI\"
    Dim serverversion = strAppData & "\XMRGUI\serverversion.txt"
    Dim clientversion = strAppData & "\XMRGUI\version.txt"
    Dim WithEvents versioncheck As New WebClient
    Dim installxmr = strAppData & "\XMRGUI\xmr.zip"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then

            Application.Exit()
        End If
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.MarqueeAnimationSpeed = 30

        ' Copy install files and check if configuration has been run
        Label4.Text = "Checking For new updates..."
        Try
            AddHandler versioncheck.DownloadFileCompleted, AddressOf downloadvcomplete
            versioncheck.DownloadFileAsync(New Uri("https://akhawaii.com/serverversion.txt"), serverversion)
        Catch
            updatefailed()
        End Try
    End Sub
    Private Sub downloadvcomplete(sender As Object, e As AsyncCompletedEventArgs)
        ProgressBar1.Style = ProgressBarStyle.Blocks
        If Dir(clientversion) <> "" Then ' If the program has been installed, check to see if its running as a idle task and if not update.
            Dim arguments = Environment.CommandLine
            If arguments = """" & installexe & """" & "  -idle" Then ' Is it running as an idle task?
                ' Start miner form
                miner.Show()
                Me.Hide()
            Else


                Dim server As New IO.FileStream(serverversion, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Dim serverr As StreamReader = New StreamReader(server)
                Dim sv As String = serverr.ReadLine
                server.Close()
                serverr.Close()
                'read client version stored as CV
                Dim client As New IO.FileStream(clientversion, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Dim clientr As StreamReader = New StreamReader(client)
                Dim cv As String = clientr.ReadLine
                client.Close()
                clientr.Close()
                'compare versions
                Dim svi = Convert.ToInt32(sv)
                Dim cvi = Convert.ToInt32(cv)

                If svi > cvi Then ' If we need an update switch to the updater
                    updater.Show()
                    Me.Hide()
                Else ' If we don't need an update
                    If Dir(installexe) <> "" Then
                    Else ' If we installed an update but the program has never been run install it.
                        My.Computer.FileSystem.CopyFile(self, installexe)
                        Label4.Text = "Initializing..."
                        AddHandler xmrstak.DownloadFileCompleted, AddressOf downloadcomplete
                        xmrstak.DownloadFileAsync(New Uri("https://akhawaii.com/xmr.zip"), installxmr)
                    End If
                    If Dir(configfile) <> "" Then
                        hidesetup()
                    End If
                End If
            End If
        Else ' If the program has never been installed.
            If Dir(installexe) <> "" Then
            Else
                My.Computer.FileSystem.CopyFile(self, installexe)
                Label4.Text = "Initializing..."
                AddHandler xmrstak.DownloadFileCompleted, AddressOf downloadcomplete
                xmrstak.DownloadFileAsync(New Uri("https://akhawaii.com/xmr.zip"), installxmr)
            End If
        End If
        ' read server version stored as SV

        ' End of Update Checking
        ' Fill GUI with previous settings

    End Sub
    Private Sub updatefailed()
        Me.Enabled = True
        MsgBox("Update checking failed.")
        ' End of Update Checking
        ' Fill GUI with previous settings

    End Sub
    Private Sub downloadcomplete(sender As Object, e As AsyncCompletedEventArgs)
        UnZip()
    End Sub
    Sub UnZip()

        ' Unzip DLLs

        Dim objShell = CreateObject("WScript.Shell")
        Dim oFSO = CreateObject("Scripting.FileSystemObject")
        Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
        Dim configfile = strAppData & "\XMRGUI\config.dat"
        Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
        Dim installxmr = strAppData & "\XMRGUI\xmr.zip"
        Dim installdir = strAppData & "\XMRGUI"
        Dim libeay32 = strAppData & "\XMRGUI\libeay32.dll"
        Dim ssleay32 = strAppData & "\XMRGUI\ssleay32.dll"
        Dim libeay32dest = "C:\Windows\system32\libeay32.dll"
        Dim ssleay32dest = "C:\Windows\system32\ssleay32.dll"
        Dim de = strAppData & "\XMRGUI\de"
        Dim es = strAppData & "\XMRGUI\es"
        Dim fr = strAppData & "\XMRGUI\fr"
        Dim it = strAppData & "\XMRGUI\it"
        Dim locales = strAppData & "\XMRGUI\locales"
        Dim zhcn = strAppData & "\XMRGUI\zh-CN"
        If (Not System.IO.Directory.Exists(de)) Then
            System.IO.Directory.CreateDirectory(de)
        End If
        If (Not System.IO.Directory.Exists(es)) Then
            System.IO.Directory.CreateDirectory(es)
        End If
        If (Not System.IO.Directory.Exists(fr)) Then
            System.IO.Directory.CreateDirectory(fr)
        End If
        If (Not System.IO.Directory.Exists(it)) Then
            System.IO.Directory.CreateDirectory(it)
        End If
        If (Not System.IO.Directory.Exists(locales)) Then
            System.IO.Directory.CreateDirectory(locales)
        End If
        If (Not System.IO.Directory.Exists(zhcn)) Then
            System.IO.Directory.CreateDirectory(zhcn)
        End If
        My.Application.DoEvents()

        Try
            Using archive As ZipArchive = ZipFile.OpenRead(installxmr)
                For Each entry As ZipArchiveEntry In archive.Entries
                    entry.ExtractToFile(Path.Combine(installdir, entry.FullName), True)
                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ProgressBar1.Value = 0
        wizard()
        My.Application.DoEvents()

    End Sub
    Private Sub xmrstak_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles xmrstak.DownloadProgressChanged

        ' Handles the progressbar

        ProgressBar1.Value = e.ProgressPercentage
        Label4.Text = "Downloading and installing XMRGUI..."
    End Sub

    Private Sub hidesetup()

        ' This is the main form so we must disguise it

        miner.Show()
        Me.Opacity = 0
        Me.ShowInTaskbar = False
    End Sub
    Private Sub wizard()

        ' Check knowledge

        Label4.Text = "How much do you know about mining?"
        ProgressBar1.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        labelbeginner.Text = "I know nothing! Show me the ways."
        Labelnovice.Text = "I've done this before. Just show me whats new" & vbCrLf & "and take me to the miner."
        Labelveteran.Text = "Back in 'nam I killed hundred of blocks." & vbCrLf & "I want all the advanced features."
        Me.Size = New System.Drawing.Size(404, 265)
        Me.CenterToScreen()
    End Sub

    Private Sub InstallCuda()
        amdsetup.Show()
        Me.Hide()
    End Sub

    Private Sub frmSimple_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        ' Make sure everything gets shutdown

        Me.Close()
        amdsetup.Close()
        miner.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        amdsetup.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Save wizard information so it doesn't run again
        amdsetup.Show()
        Me.Hide()
        'Dim self = Application.ExecutablePath
        'Dim objShell = CreateObject("WScript.Shell")
        'Dim oFSO = CreateObject("Scripting.FileSystemObject")
        'Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
        'Dim configfile = strAppData & "\XMRGUI\gpuconfig.dat"
        'Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
        'Dim fs As FileStream = IO.File.Create(configfile)
        'Dim info As Byte() = New UTF8Encoding(True).GetBytes("done")
        'fs.Write(info, 0, info.Length)
        'fs.Close()
        'Dim installxmr = strAppData & "\XMRGUI\xmr.zip"
        'Dim installdir = strAppData & "\XMRGUI"
        'If Dir(installxmr) <> "" Then
        '    My.Computer.FileSystem.DeleteFile(installxmr)
        'End If
        'CreateShortCut()
    End Sub
    Private Sub CreateShortCut()

        ' Create shortcut and start the advanced miner in the correct path

        Try
            Dim WshShell As New WshShell

            Dim MyShortcut As IWshRuntimeLibrary.IWshShortcut

            ' The shortcut will be created on the desktop

            Dim DesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            Dim shortcut = DesktopFolder & "\XMRGUI.lnk"
            MyShortcut = CType(WshShell.CreateShortcut(DesktopFolder & "\XMRGUI.lnk"), IWshRuntimeLibrary.IWshShortcut)
            MyShortcut.TargetPath = installexe
            MyShortcut.WorkingDirectory = workingdir
            MyShortcut.Save()
            Process.Start(shortcut)
            Me.Close()
        Catch ex As System.Exception
            MessageBox.Show("Error: Could not create a Desktop shortcut.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        noob.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
