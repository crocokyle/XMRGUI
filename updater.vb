Imports System.IO
Imports System.Text
Imports System.Net
Imports Microsoft.Win32.TaskScheduler
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Windows.Media
Imports System.ComponentModel

Public Class updater
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
    Dim updatefile = strAppData & "\XMRGUIUpdate\update.exe"
    Dim updatepath = strAppData & "\XMRGUIUpdate"
    Dim WithEvents updatedownloader As New WebClient

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        miner.Show()
        Me.Hide()
    End Sub

    Private Sub no_Click(sender As Object, e As EventArgs) Handles no.Click
        miner.Show()
        Me.Hide()
    End Sub

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        Label5.Text = "Downloading update..."
        yes.Enabled = False
        no.Text = "Cancel"
        System.IO.Directory.CreateDirectory(updatepath)
        Try
            AddHandler updatedownloader.DownloadFileCompleted, AddressOf downloadcomplete
            updatedownloader.DownloadFileAsync(New Uri("http://akhawaii.com/update.exe"), updatefile)

        Catch
            MsgBox("Update Failed")
            miner.Show()
            Me.Hide()
        End Try

    End Sub
    Private Sub downloadcomplete(sender As Object, e As AsyncCompletedEventArgs)
        Process.Start(updatefile)
        Application.Exit()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class