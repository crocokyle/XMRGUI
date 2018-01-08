<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class miner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(miner))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonationLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunGPUSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartupBehaviourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableOnIdleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableOnIdleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayOnlyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvisibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.startbtn = New System.Windows.Forms.Button()
        Me.stopbtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.xmraddr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.poolurl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.refreshint = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.poolpass = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.devdonatetimer = New System.Windows.Forms.Timer(Me.components)
        Me.userminingtimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.port, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(813, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonationLevelToolStripMenuItem, Me.RunGPUSetupToolStripMenuItem, Me.StartupBehaviourToolStripMenuItem, Me.VisibilityToolStripMenuItem, Me.WebServerToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'DonationLevelToolStripMenuItem
        '
        Me.DonationLevelToolStripMenuItem.Name = "DonationLevelToolStripMenuItem"
        Me.DonationLevelToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DonationLevelToolStripMenuItem.Text = "Donation Level"
        '
        'RunGPUSetupToolStripMenuItem
        '
        Me.RunGPUSetupToolStripMenuItem.Name = "RunGPUSetupToolStripMenuItem"
        Me.RunGPUSetupToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RunGPUSetupToolStripMenuItem.Text = "Run GPU Setup"
        '
        'StartupBehaviourToolStripMenuItem
        '
        Me.StartupBehaviourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableOnStartupToolStripMenuItem, Me.DisableOnStartupToolStripMenuItem, Me.EnableOnIdleToolStripMenuItem, Me.DisableOnIdleToolStripMenuItem})
        Me.StartupBehaviourToolStripMenuItem.Name = "StartupBehaviourToolStripMenuItem"
        Me.StartupBehaviourToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.StartupBehaviourToolStripMenuItem.Text = "Set and Forget"
        '
        'EnableOnStartupToolStripMenuItem
        '
        Me.EnableOnStartupToolStripMenuItem.CheckOnClick = True
        Me.EnableOnStartupToolStripMenuItem.Name = "EnableOnStartupToolStripMenuItem"
        Me.EnableOnStartupToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EnableOnStartupToolStripMenuItem.Text = "Enable on Startup"
        '
        'DisableOnStartupToolStripMenuItem
        '
        Me.DisableOnStartupToolStripMenuItem.CheckOnClick = True
        Me.DisableOnStartupToolStripMenuItem.Name = "DisableOnStartupToolStripMenuItem"
        Me.DisableOnStartupToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DisableOnStartupToolStripMenuItem.Text = "Disable on Startup"
        '
        'EnableOnIdleToolStripMenuItem
        '
        Me.EnableOnIdleToolStripMenuItem.CheckOnClick = True
        Me.EnableOnIdleToolStripMenuItem.Name = "EnableOnIdleToolStripMenuItem"
        Me.EnableOnIdleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EnableOnIdleToolStripMenuItem.Text = "Enable on Idle"
        '
        'DisableOnIdleToolStripMenuItem
        '
        Me.DisableOnIdleToolStripMenuItem.CheckOnClick = True
        Me.DisableOnIdleToolStripMenuItem.Name = "DisableOnIdleToolStripMenuItem"
        Me.DisableOnIdleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DisableOnIdleToolStripMenuItem.Text = "Disable on Idle"
        '
        'VisibilityToolStripMenuItem
        '
        Me.VisibilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrayOnlyToolStripMenuItem, Me.TrayOnlyToolStripMenuItem1, Me.InvisibleToolStripMenuItem})
        Me.VisibilityToolStripMenuItem.Name = "VisibilityToolStripMenuItem"
        Me.VisibilityToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.VisibilityToolStripMenuItem.Text = "Visibility"
        '
        'TrayOnlyToolStripMenuItem
        '
        Me.TrayOnlyToolStripMenuItem.CheckOnClick = True
        Me.TrayOnlyToolStripMenuItem.Name = "TrayOnlyToolStripMenuItem"
        Me.TrayOnlyToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TrayOnlyToolStripMenuItem.Text = "Windowed"
        '
        'TrayOnlyToolStripMenuItem1
        '
        Me.TrayOnlyToolStripMenuItem1.CheckOnClick = True
        Me.TrayOnlyToolStripMenuItem1.Name = "TrayOnlyToolStripMenuItem1"
        Me.TrayOnlyToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.TrayOnlyToolStripMenuItem1.Text = "Tray Only"
        '
        'InvisibleToolStripMenuItem
        '
        Me.InvisibleToolStripMenuItem.CheckOnClick = True
        Me.InvisibleToolStripMenuItem.Name = "InvisibleToolStripMenuItem"
        Me.InvisibleToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.InvisibleToolStripMenuItem.Text = "Invisible"
        '
        'WebServerToolStripMenuItem
        '
        Me.WebServerToolStripMenuItem.Name = "WebServerToolStripMenuItem"
        Me.WebServerToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.WebServerToolStripMenuItem.Text = "Web Server"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'startbtn
        '
        Me.startbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startbtn.Location = New System.Drawing.Point(12, 439)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(390, 58)
        Me.startbtn.TabIndex = 3
        Me.startbtn.Text = "Mine!"
        Me.startbtn.UseVisualStyleBackColor = True
        '
        'stopbtn
        '
        Me.stopbtn.Enabled = False
        Me.stopbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopbtn.Location = New System.Drawing.Point(411, 439)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.Size = New System.Drawing.Size(390, 58)
        Me.stopbtn.TabIndex = 4
        Me.stopbtn.Text = "Stop"
        Me.stopbtn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(789, 323)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(781, 297)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Graphical"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(781, 297)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Text"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(781, 297)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Approximate Earnings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'xmraddr
        '
        Me.xmraddr.Location = New System.Drawing.Point(90, 383)
        Me.xmraddr.Name = "xmraddr"
        Me.xmraddr.Size = New System.Drawing.Size(458, 20)
        Me.xmraddr.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "XMR Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pool URL:"
        '
        'poolurl
        '
        Me.poolurl.Location = New System.Drawing.Point(90, 357)
        Me.poolurl.Name = "poolurl"
        Me.poolurl.Size = New System.Drawing.Size(312, 20)
        Me.poolurl.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(408, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Port:"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(443, 357)
        Me.port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(115, 20)
        Me.port.TabIndex = 9
        Me.port.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(564, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Refresh Inverval (seconds):"
        '
        'refreshint
        '
        Me.refreshint.Location = New System.Drawing.Point(707, 358)
        Me.refreshint.Name = "refreshint"
        Me.refreshint.Size = New System.Drawing.Size(94, 20)
        Me.refreshint.TabIndex = 11
        Me.refreshint.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(554, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Pool Password:"
        '
        'poolpass
        '
        Me.poolpass.Location = New System.Drawing.Point(640, 383)
        Me.poolpass.Name = "poolpass"
        Me.poolpass.Size = New System.Drawing.Size(161, 20)
        Me.poolpass.TabIndex = 13
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(16, 416)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(158, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Use automatic configuration"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(180, 417)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Help?"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(628, 413)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 20)
        Me.NumericUpDown1.TabIndex = 16
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Location = New System.Drawing.Point(758, 413)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(43, 20)
        Me.NumericUpDown2.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(548, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CPU Threads:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(677, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "GPU Threads:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(7, 4)
        Me.RichTextBox1.MaxLength = 50
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(768, 287)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(455, 76)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Coming Soon!"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(455, 76)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Coming Soon!"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(327, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Clear Terminal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'devdonatetimer
        '
        Me.devdonatetimer.Interval = 120000
        '
        'userminingtimer
        '
        Me.userminingtimer.Interval = 6000000
        '
        'miner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 504)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.poolpass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.refreshint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.poolurl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.xmraddr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stopbtn)
        Me.Controls.Add(Me.startbtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "miner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XMRGUI v1.0 "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.port, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunGPUSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartupBehaviourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableOnStartupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableOnStartupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableOnIdleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableOnIdleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisibilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrayOnlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrayOnlyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvisibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents startbtn As Button
    Friend WithEvents stopbtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DonationLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents xmraddr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents poolurl As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents port As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents refreshint As NumericUpDown
    Friend WithEvents WebServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents poolpass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents devdonatetimer As Timer
    Friend WithEvents userminingtimer As Timer
End Class
