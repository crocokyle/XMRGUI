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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class