Imports System.Net
Imports System
Imports System.IO
Imports System.Text
Imports IWshRuntimeLibrary
Public Class amdsetup
    Dim self = Application.ExecutablePath
    Dim objShell = CreateObject("WScript.Shell")
    Dim oFSO = CreateObject("Scripting.FileSystemObject")
    Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
    Dim configfile = strAppData & "\XMRGUI\gpuconfig.dat"
    Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
    Dim workingdir = strAppData & "\XMRGUI\"
    Dim WithEvents WC As New WebClient
    Dim pInfo As New ProcessStartInfo()
    Private Sub amdsetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Dir("C:\AMD\AMD-14.41RC1-Win8.1-64Bit-OpenCL2-Sep19\Setup.exe") <> "" Then
            MsgBox("You have OpenCL installed! Good job miner.")
            Dim self = Application.ExecutablePath
            Dim objShell = CreateObject("WScript.Shell")
            Dim oFSO = CreateObject("Scripting.FileSystemObject")
            Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
            Dim configfile = strAppData & "\XMRGUI\gpuconfig.dat"
            Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
            Dim fs As FileStream = IO.File.Create(configfile)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("done")
            fs.Write(info, 0, info.Length)
            fs.Close()
            Dim installxmr = strAppData & "\XMRGUI\xmr.zip"
            Dim installdir = strAppData & "\XMRGUI"
            If Dir(installxmr) <> "" Then
                My.Computer.FileSystem.DeleteFile(installxmr)
            End If

            'create shortcut and start programdir version
            CreateShortCut()
        Else
            WC.DownloadFileAsync(New Uri("https://www2.ati.com/drivers/amd-14.41rc1-win8.1-64bit-opencl2-sep19.exe"), "C:\temp\opencl.exe")
        End If
    End Sub
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label2.Text = e.ProgressPercentage
        Label1.Text = "Downloading OpenCL. Go smoke a bowl..."
        Button1.Enabled = False
        Button2.Enabled = False
        If ProgressBar1.Value = 100 Then
            InstallOpenCL()
        End If
    End Sub

    Private Sub InstallOpenCL()
        pInfo.FileName = "C:\temp\opencl.exe"
        Dim perc = 0
        Label1.Text = "Installing OpenCL..."
        Label2.Text = ""
        Label3.Text = ""
        Dim p As Process = Process.Start(pInfo)
        ProgressBar1.Value = 50
        p.WaitForExit()
        If Dir("C:\AMD\AMD-14.41RC1-Win8.1-64Bit-OpenCL2-Sep19\Setup.exe") <> "" Then
            Label1.Text = "OpenCL Installed Successfully."
            'Save config file
            Dim self = Application.ExecutablePath
            Dim objShell = CreateObject("WScript.Shell")
            Dim oFSO = CreateObject("Scripting.FileSystemObject")
            Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
            Dim configfile = strAppData & "\XMRGUI\config.dat"
            Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
            Dim fs As FileStream = IO.File.Create(configfile)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("done")
            fs.Write(info, 0, info.Length)
            fs.Close()
            miner.Show()
            Me.Hide()
        Else
            Dim result As Integer = MessageBox.Show("OpenCL Install Failed. This program was written to install OpenCL on Windows 10 64 bit. Press OK to go to the download page and restart XMRGUI when you have finished installing.", "Install Failed", MessageBoxButtons.OKCancel)
            If result = DialogResult.Cancel Then
                Close()
            ElseIf result = DialogResult.OK Then
                Process.Start("http://support.amd.com/en-us/kb-articles/Pages/OpenCL2-Driver.aspx")
            End If
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim self = Application.ExecutablePath
        Dim objShell = CreateObject("WScript.Shell")
        Dim oFSO = CreateObject("Scripting.FileSystemObject")
        Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
        Dim configfile = strAppData & "\XMRGUI\gpuconfig.dat"
        Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
        Dim fs As FileStream = IO.File.Create(configfile)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("done")
        fs.Write(info, 0, info.Length)
        fs.Close()
        Dim installxmr = strAppData & "\XMRGUI\xmr.zip"
        Dim installdir = strAppData & "\XMRGUI"
        If Dir(installxmr) <> "" Then
            My.Computer.FileSystem.DeleteFile(installxmr)
        End If

        'create shortcut and start programdir version
        CreateShortCut()
    End Sub


    Private Sub CreateShortCut()
        Try
            Dim WshShell As New WshShell

            Dim MyShortcut As IWshRuntimeLibrary.IWshShortcut

            ' The shortcut will be created on the desktop

            Dim DesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            Dim shortcut = DesktopFolder & "\XMRGUI.lnk"
            MyShortcut = CType(WshShell.CreateShortcut(DesktopFolder & "\XMRGUI.lnk"), IWshRuntimeLibrary.IWshShortcut)

            MyShortcut.TargetPath = installexe 'Specify target app full path
            MyShortcut.WorkingDirectory = workingdir
            MyShortcut.Save()
            Process.Start(shortcut)
            Me.Close()
        Catch ex As System.Exception
            MessageBox.Show("Could not create the shortcut")
        End Try
    End Sub
    Private Sub frmSimple_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Close()
        miner.Close()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class