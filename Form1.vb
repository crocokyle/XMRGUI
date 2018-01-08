Option Explicit On
Imports System.Net
Imports System
Imports System.IO
Imports System.Text
Imports System.IO.Compression
Public Class Form1
    Dim WithEvents WC As New WebClient
    Dim WithEvents xmrstak As New WebClient
    Dim pInfo As New ProcessStartInfo()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'copy install files and check if configuration has been run
        Dim self = Application.ExecutablePath
        Dim objShell = CreateObject("WScript.Shell")
        Dim oFSO = CreateObject("Scripting.FileSystemObject")
        Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
        Dim configfile = strAppData & "\XMRGUI\gpuconfig.dat"
        Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
        Dim installxmr = strAppData & "\XMRGUI\xmr.zip"
        If Dir(configfile) <> "" Then
            hidesetup()
        End If
        If Dir(installexe) <> "" Then
        Else
            My.Computer.FileSystem.CopyFile(self, installexe)
            Button1.Visible = False
            Button2.Visible = False
            Label1.Text = "Downloading and installing XMRGUI"
            xmrstak.DownloadFileAsync(New Uri("https://akhawaii.com/xmr.zip"), installxmr)
        End If

    End Sub
    Sub UnZip()
        Dim objShell = CreateObject("WScript.Shell")
        Dim oFSO = CreateObject("Scripting.FileSystemObject")
        Dim strAppData = objShell.ExpandEnvironmentStrings("%APPDATA%")
        Dim configfile = strAppData & "\XMRGUI\config.dat"
        Dim installexe = strAppData & "\XMRGUI\xmrgui.exe"
        Dim installxmr = strAppData & "\XMRGUI\xmr.zip"
        Dim installdir = strAppData & "\XMRGUI"
        Using archive As ZipArchive = ZipFile.OpenRead(installxmr)
            For Each entry As ZipArchiveEntry In archive.Entries
                entry.ExtractToFile(Path.Combine(installdir, entry.FullName), True)
            Next
        End Using
        ProgressBar1.Value = 0
        Label2.Text = 0
        Button1.Visible = True
        Button2.Visible = True
        Button1.Enabled = True
        Button2.Enabled = True
        Label1.Text = "Are you using a NVIDIA GPU?"
        My.Application.DoEvents()
    End Sub
    Private Sub xmrstak_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles xmrstak.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label2.Text = e.ProgressPercentage
        Label1.Text = "Downloading XMRGUI setup files..."
        Button1.Enabled = False
        Button2.Enabled = False
        If ProgressBar1.Value = 100 Then
            My.Application.DoEvents()
            ProgressBar1.Value = 0
            UnZip()
        End If
    End Sub
    Private Sub hidesetup()
        miner.Show()
        Me.Opacity = 0
        Me.ShowInTaskbar = False
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Dir("C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v9.0\version.txt") <> "" Then
            MsgBox("You have CUDA installed! Good job miner.")
        Else
            WC.DownloadFileAsync(New Uri("https://akhawaii.com/cuda_9.1.85_win10.exe"), "C:\temp\cuda_9.1.85_win10.exe")
        End If
    End Sub
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label2.Text = e.ProgressPercentage
        Label1.Text = "Downloading CUDA. Go smoke a bowl. CUDA is huge..."
        Button1.Enabled = False
        Button2.Enabled = False
        If ProgressBar1.Value = 100 Then
            InstallCuda()
        End If
    End Sub

    Private Sub InstallCuda()
        pInfo.FileName = "C:\temp\cuda_9.1.85_win10.exe"
        pInfo.Arguments = "-s nvcc_9.1 Display.Driver"
        Dim perc = 0
        Label1.Text = "Installing Cuda..."
        Label2.Text = ""
        Label3.Text = ""
        Dim p As Process = Process.Start(pInfo)
        While perc < 101
            ProgressBar1.Value = perc
            perc += 1
            Threading.Thread.Sleep(100)
        End While
        p.WaitForExit()
        If Dir("C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v9.1\bin\nvcc.exe") <> "" Then
            Label1.Text = "CUDA Installed Successfully."
            amdsetup.Show()
            Me.Hide()
        Else
            Dim result As Integer = MessageBox.Show("CUDA Install Failed. This program was written to install CUDA on Windows 10 64 bit. Press OK to go to the download page and restart XMRGUI when you have finished installing.", "Install Failed", MessageBoxButtons.OKCancel)
            If result = DialogResult.Cancel Then
                Close()
            ElseIf result = DialogResult.OK Then
                Process.Start("https://developer.nvidia.com/cuda-downloads?target_os=Windows&target_arch=x86_64")
            End If
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        amdsetup.Show()
        Me.Hide()
    End Sub
    Private Sub frmSimple_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.Close()
        amdsetup.Close()
        miner.Close()
    End Sub
End Class
