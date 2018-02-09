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
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.startbtn = New System.Windows.Forms.Button()
        Me.stopbtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.hrmlabel = New System.Windows.Forms.Label()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.PieChart3 = New LiveCharts.WinForms.PieChart()
        Me.PieChart4 = New LiveCharts.WinForms.PieChart()
        Me.PieChart2 = New LiveCharts.WinForms.PieChart()
        Me.PieChart1 = New LiveCharts.WinForms.PieChart()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pooltotalpaid = New System.Windows.Forms.Label()
        Me.poolpendingbalance = New System.Windows.Forms.Label()
        Me.poolinvalidshares = New System.Windows.Forms.Label()
        Me.poolvalidshares = New System.Windows.Forms.Label()
        Me.pooltotalhashes = New System.Windows.Forms.Label()
        Me.poolhashrate = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chatpanel = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cputhreadspicker = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.devdonatetimer = New System.Windows.Forms.Timer(Me.components)
        Me.userminingtimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.timeroutput = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.uptime = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exittraybtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.radiomanualfiles = New System.Windows.Forms.RadioButton()
        Me.radiomanual = New System.Windows.Forms.RadioButton()
        Me.radioautomatic = New System.Windows.Forms.RadioButton()
        Me.configoverridebtn = New System.Windows.Forms.Button()
        Me.poolapitimer = New System.Windows.Forms.Timer(Me.components)
        Me.idletimer = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.hrmlabeltimer = New System.Windows.Forms.Timer(Me.components)
        Me.hrmlabeltimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.HRMTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonationLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HashRateMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartupBehaviourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableOnIdleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeginnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeteranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubredditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.port, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cputhreadspicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(813, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonationLevelToolStripMenuItem, Me.HashRateMonitoringToolStripMenuItem, Me.ProfilesToolStripMenuItem, Me.StartupBehaviourToolStripMenuItem})
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TerminalColorsToolStripMenuItem, Me.TrayIconToolStripMenuItem, Me.UserModeToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.InstructionsToolStripMenuItem, Me.SubredditToolStripMenuItem, Me.WebsiteToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'startbtn
        '
        Me.startbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.startbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startbtn.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.startbtn.Location = New System.Drawing.Point(12, 439)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(390, 58)
        Me.startbtn.TabIndex = 7
        Me.startbtn.Text = "Mine!"
        Me.startbtn.UseVisualStyleBackColor = False
        '
        'stopbtn
        '
        Me.stopbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.stopbtn.Enabled = False
        Me.stopbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.stopbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stopbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopbtn.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.stopbtn.Location = New System.Drawing.Point(411, 439)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.Size = New System.Drawing.Size(390, 58)
        Me.stopbtn.TabIndex = 8
        Me.stopbtn.Text = "Stop"
        Me.stopbtn.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 27)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(789, 323)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(781, 297)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Graphical"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.hrmlabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CartesianChart1)
        Me.SplitContainer1.Panel1MinSize = 450
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Add(Me.PieChart3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PieChart4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PieChart2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PieChart1)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Panel2MinSize = 1
        Me.SplitContainer1.Size = New System.Drawing.Size(781, 297)
        Me.SplitContainer1.SplitterDistance = 450
        Me.SplitContainer1.TabIndex = 0
        '
        'hrmlabel
        '
        Me.hrmlabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.hrmlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hrmlabel.ForeColor = System.Drawing.Color.LimeGreen
        Me.hrmlabel.Location = New System.Drawing.Point(536, 265)
        Me.hrmlabel.Name = "hrmlabel"
        Me.hrmlabel.Size = New System.Drawing.Size(220, 29)
        Me.hrmlabel.TabIndex = 30
        Me.hrmlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CartesianChart1
        '
        Me.CartesianChart1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CartesianChart1.BackColorTransparent = True
        Me.CartesianChart1.Enabled = False
        Me.CartesianChart1.Location = New System.Drawing.Point(3, 3)
        Me.CartesianChart1.MinimumSize = New System.Drawing.Size(445, 291)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Padding = New System.Windows.Forms.Padding(3)
        Me.CartesianChart1.Size = New System.Drawing.Size(773, 291)
        Me.CartesianChart1.TabIndex = 0
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'PieChart3
        '
        Me.PieChart3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PieChart3.Location = New System.Drawing.Point(0, 219)
        Me.PieChart3.MaximumSize = New System.Drawing.Size(325, 73)
        Me.PieChart3.Name = "PieChart3"
        Me.PieChart3.Size = New System.Drawing.Size(94, 73)
        Me.PieChart3.TabIndex = 6
        Me.PieChart3.Text = "PieChart3"
        '
        'PieChart4
        '
        Me.PieChart4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PieChart4.Location = New System.Drawing.Point(0, 146)
        Me.PieChart4.MaximumSize = New System.Drawing.Size(325, 73)
        Me.PieChart4.Name = "PieChart4"
        Me.PieChart4.Size = New System.Drawing.Size(94, 73)
        Me.PieChart4.TabIndex = 5
        Me.PieChart4.Text = "PieChart4"
        '
        'PieChart2
        '
        Me.PieChart2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PieChart2.Location = New System.Drawing.Point(0, 73)
        Me.PieChart2.MaximumSize = New System.Drawing.Size(325, 73)
        Me.PieChart2.Name = "PieChart2"
        Me.PieChart2.Size = New System.Drawing.Size(94, 73)
        Me.PieChart2.TabIndex = 4
        Me.PieChart2.Text = "PieChart2"
        '
        'PieChart1
        '
        Me.PieChart1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PieChart1.Location = New System.Drawing.Point(0, 0)
        Me.PieChart1.MaximumSize = New System.Drawing.Size(325, 73)
        Me.PieChart1.Name = "PieChart1"
        Me.PieChart1.Size = New System.Drawing.Size(94, 73)
        Me.PieChart1.TabIndex = 3
        Me.PieChart1.Text = "PieChart1"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.SplitContainer2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(781, 297)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pool Statistics & Chat"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer2.Panel1.Controls.Add(Me.pooltotalpaid)
        Me.SplitContainer2.Panel1.Controls.Add(Me.poolpendingbalance)
        Me.SplitContainer2.Panel1.Controls.Add(Me.poolinvalidshares)
        Me.SplitContainer2.Panel1.Controls.Add(Me.poolvalidshares)
        Me.SplitContainer2.Panel1.Controls.Add(Me.pooltotalhashes)
        Me.SplitContainer2.Panel1.Controls.Add(Me.poolhashrate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.chatpanel)
        Me.SplitContainer2.Size = New System.Drawing.Size(781, 297)
        Me.SplitContainer2.SplitterDistance = 390
        Me.SplitContainer2.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(2, 272)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(382, 23)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "*  Stats are updated every minute *"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(4, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(382, 23)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "More supported pools on the way!"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pooltotalpaid
        '
        Me.pooltotalpaid.AutoSize = True
        Me.pooltotalpaid.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pooltotalpaid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pooltotalpaid.Location = New System.Drawing.Point(126, 206)
        Me.pooltotalpaid.Name = "pooltotalpaid"
        Me.pooltotalpaid.Size = New System.Drawing.Size(242, 15)
        Me.pooltotalpaid.TabIndex = 11
        Me.pooltotalpaid.Text = "Benchmark Mode (Replace XMR Address)"
        '
        'poolpendingbalance
        '
        Me.poolpendingbalance.AutoSize = True
        Me.poolpendingbalance.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poolpendingbalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.poolpendingbalance.Location = New System.Drawing.Point(126, 191)
        Me.poolpendingbalance.Name = "poolpendingbalance"
        Me.poolpendingbalance.Size = New System.Drawing.Size(242, 15)
        Me.poolpendingbalance.TabIndex = 10
        Me.poolpendingbalance.Text = "Benchmark Mode (Replace XMR Address)"
        '
        'poolinvalidshares
        '
        Me.poolinvalidshares.AutoSize = True
        Me.poolinvalidshares.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poolinvalidshares.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.poolinvalidshares.Location = New System.Drawing.Point(126, 141)
        Me.poolinvalidshares.Name = "poolinvalidshares"
        Me.poolinvalidshares.Size = New System.Drawing.Size(242, 15)
        Me.poolinvalidshares.TabIndex = 9
        Me.poolinvalidshares.Text = "Benchmark Mode (Replace XMR Address)"
        '
        'poolvalidshares
        '
        Me.poolvalidshares.AutoSize = True
        Me.poolvalidshares.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poolvalidshares.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.poolvalidshares.Location = New System.Drawing.Point(126, 126)
        Me.poolvalidshares.Name = "poolvalidshares"
        Me.poolvalidshares.Size = New System.Drawing.Size(242, 15)
        Me.poolvalidshares.TabIndex = 8
        Me.poolvalidshares.Text = "Benchmark Mode (Replace XMR Address)"
        '
        'pooltotalhashes
        '
        Me.pooltotalhashes.AutoSize = True
        Me.pooltotalhashes.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pooltotalhashes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pooltotalhashes.Location = New System.Drawing.Point(126, 88)
        Me.pooltotalhashes.Name = "pooltotalhashes"
        Me.pooltotalhashes.Size = New System.Drawing.Size(242, 15)
        Me.pooltotalhashes.TabIndex = 7
        Me.pooltotalhashes.Text = "Benchmark Mode (Replace XMR Address)"
        '
        'poolhashrate
        '
        Me.poolhashrate.AutoSize = True
        Me.poolhashrate.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poolhashrate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.poolhashrate.Location = New System.Drawing.Point(126, 63)
        Me.poolhashrate.Name = "poolhashrate"
        Me.poolhashrate.Size = New System.Drawing.Size(242, 15)
        Me.poolhashrate.TabIndex = 6
        Me.poolhashrate.Text = "Benchmark Mode (Replace XMR Address)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label14.Location = New System.Drawing.Point(50, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Total Paid:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label13.Location = New System.Drawing.Point(14, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Pending Balance:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label12.Location = New System.Drawing.Point(27, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Invalid Shares:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(37, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Valid Shares:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(35, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Hashes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(24, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Hashrate:"
        '
        'chatpanel
        '
        Me.chatpanel.Location = New System.Drawing.Point(2, 0)
        Me.chatpanel.Name = "chatpanel"
        Me.chatpanel.Size = New System.Drawing.Size(385, 297)
        Me.chatpanel.TabIndex = 1
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
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.RichTextBox1.MaxLength = 50
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.ShowSelectionMargin = True
        Me.RichTextBox1.Size = New System.Drawing.Size(785, 297)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'xmraddr
        '
        Me.xmraddr.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.xmraddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xmraddr.ForeColor = System.Drawing.SystemColors.Menu
        Me.xmraddr.Location = New System.Drawing.Point(93, 383)
        Me.xmraddr.Name = "xmraddr"
        Me.xmraddr.Size = New System.Drawing.Size(458, 20)
        Me.xmraddr.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(0, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "XMR Address:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(0, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 35)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pool URL:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'poolurl
        '
        Me.poolurl.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.poolurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.poolurl.ForeColor = System.Drawing.SystemColors.Info
        Me.poolurl.Location = New System.Drawing.Point(93, 360)
        Me.poolurl.Name = "poolurl"
        Me.poolurl.Size = New System.Drawing.Size(312, 20)
        Me.poolurl.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(408, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Port:"
        '
        'port
        '
        Me.port.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.port.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.port.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.port.Location = New System.Drawing.Point(442, 361)
        Me.port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(108, 16)
        Me.port.TabIndex = 3
        Me.port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.port.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.port.Value = New Decimal(New Integer() {5555, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Location = New System.Drawing.Point(564, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Chart Inverval (seconds):"
        '
        'refreshint
        '
        Me.refreshint.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.refreshint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.refreshint.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.refreshint.Location = New System.Drawing.Point(707, 361)
        Me.refreshint.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.refreshint.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.refreshint.Name = "refreshint"
        Me.refreshint.Size = New System.Drawing.Size(94, 16)
        Me.refreshint.TabIndex = 4
        Me.refreshint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.refreshint.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.refreshint.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(565, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Pool Password:"
        '
        'poolpass
        '
        Me.poolpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.poolpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.poolpass.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.poolpass.Location = New System.Drawing.Point(651, 383)
        Me.poolpass.Name = "poolpass"
        Me.poolpass.Size = New System.Drawing.Size(150, 20)
        Me.poolpass.TabIndex = 6
        '
        'LinkLabel1
        '
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Silver
        Me.LinkLabel1.Location = New System.Drawing.Point(193, 404)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(36, 27)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Help?"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cputhreadspicker
        '
        Me.cputhreadspicker.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cputhreadspicker.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cputhreadspicker.Enabled = False
        Me.cputhreadspicker.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.cputhreadspicker.Location = New System.Drawing.Point(589, 410)
        Me.cputhreadspicker.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.cputhreadspicker.Name = "cputhreadspicker"
        Me.cputhreadspicker.Size = New System.Drawing.Size(43, 16)
        Me.cputhreadspicker.TabIndex = 16
        Me.cputhreadspicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cputhreadspicker.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(509, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CPU Threads:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'devdonatetimer
        '
        Me.devdonatetimer.Interval = 120000
        '
        'userminingtimer
        '
        Me.userminingtimer.Interval = 6000000
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.Location = New System.Drawing.Point(758, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'timeroutput
        '
        Me.timeroutput.Interval = 1000
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(424, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'uptime
        '
        Me.uptime.Interval = 1000
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "XMRGUI v1.9"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.MineToolStripMenuItem, Me.StopToolStripMenuItem, Me.Exittraybtn})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(79, 92)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'MineToolStripMenuItem
        '
        Me.MineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MineToolStripMenuItem.Name = "MineToolStripMenuItem"
        Me.MineToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.MineToolStripMenuItem.Text = "&Mine"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.StopToolStripMenuItem.Text = "&Stop"
        Me.StopToolStripMenuItem.Visible = False
        '
        'Exittraybtn
        '
        Me.Exittraybtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Exittraybtn.Name = "Exittraybtn"
        Me.Exittraybtn.Size = New System.Drawing.Size(78, 22)
        Me.Exittraybtn.Text = "E&xit"
        '
        'radiomanualfiles
        '
        Me.radiomanualfiles.AutoSize = True
        Me.radiomanualfiles.Location = New System.Drawing.Point(235, 409)
        Me.radiomanualfiles.Name = "radiomanualfiles"
        Me.radiomanualfiles.Size = New System.Drawing.Size(98, 17)
        Me.radiomanualfiles.TabIndex = 24
        Me.radiomanualfiles.Text = "Config Override"
        Me.radiomanualfiles.UseVisualStyleBackColor = True
        '
        'radiomanual
        '
        Me.radiomanual.AutoSize = True
        Me.radiomanual.Location = New System.Drawing.Point(417, 409)
        Me.radiomanual.Name = "radiomanual"
        Me.radiomanual.Size = New System.Drawing.Size(85, 17)
        Me.radiomanual.TabIndex = 25
        Me.radiomanual.Text = "Manual CPU"
        Me.radiomanual.UseVisualStyleBackColor = True
        '
        'radioautomatic
        '
        Me.radioautomatic.AutoSize = True
        Me.radioautomatic.Checked = True
        Me.radioautomatic.Location = New System.Drawing.Point(339, 409)
        Me.radioautomatic.Name = "radioautomatic"
        Me.radioautomatic.Size = New System.Drawing.Size(72, 17)
        Me.radioautomatic.TabIndex = 26
        Me.radioautomatic.TabStop = True
        Me.radioautomatic.Text = "Automatic"
        Me.radioautomatic.UseVisualStyleBackColor = True
        '
        'configoverridebtn
        '
        Me.configoverridebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.configoverridebtn.Enabled = False
        Me.configoverridebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.configoverridebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.configoverridebtn.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.configoverridebtn.Location = New System.Drawing.Point(651, 408)
        Me.configoverridebtn.Name = "configoverridebtn"
        Me.configoverridebtn.Size = New System.Drawing.Size(150, 23)
        Me.configoverridebtn.TabIndex = 27
        Me.configoverridebtn.Text = "Config Override"
        Me.configoverridebtn.UseVisualStyleBackColor = False
        '
        'poolapitimer
        '
        Me.poolapitimer.Enabled = True
        Me.poolapitimer.Interval = 60000
        '
        'idletimer
        '
        Me.idletimer.Enabled = True
        Me.idletimer.Interval = 1000
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Profile 1", "Profile 2", "Profile 3", "Profile 4", "Profile 5"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 408)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.savebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.savebtn.Location = New System.Drawing.Point(141, 408)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(46, 23)
        Me.savebtn.TabIndex = 29
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'hrmlabeltimer
        '
        Me.hrmlabeltimer.Interval = 2000
        '
        'hrmlabeltimer2
        '
        Me.hrmlabeltimer2.Interval = 500
        '
        'HRMTimer
        '
        Me.HRMTimer.Interval = 180000
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(835, 337)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "StabilizeT:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(822, 367)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "AVG Locked:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(843, 418)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Average:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label20.Location = New System.Drawing.Point(835, 448)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Threshold:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label21.Location = New System.Drawing.Point(915, 337)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label22.Location = New System.Drawing.Point(916, 367)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Label22"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label23.Location = New System.Drawing.Point(916, 418)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Label23"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label24.Location = New System.Drawing.Point(916, 448)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Label24"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label25.Location = New System.Drawing.Point(917, 390)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "Label25"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label26.Location = New System.Drawing.Point(829, 390)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 13)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "AVG Points:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.XMRGUI.My.Resources.Resources.StackLeft_16x
        Me.PictureBox1.Location = New System.Drawing.Point(992, 481)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.StatusOffline_stop_16x
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DonationLevelToolStripMenuItem
        '
        Me.DonationLevelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DonationLevelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DonationLevelToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.AzureTeam_16x
        Me.DonationLevelToolStripMenuItem.Name = "DonationLevelToolStripMenuItem"
        Me.DonationLevelToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.DonationLevelToolStripMenuItem.Text = "&Donation Level"
        '
        'HashRateMonitoringToolStripMenuItem
        '
        Me.HashRateMonitoringToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.HashRateMonitoringToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HashRateMonitoringToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.Watch_16x
        Me.HashRateMonitoringToolStripMenuItem.Name = "HashRateMonitoringToolStripMenuItem"
        Me.HashRateMonitoringToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.HashRateMonitoringToolStripMenuItem.Text = "&Hash Rate Monitoring"
        '
        'ProfilesToolStripMenuItem
        '
        Me.ProfilesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ProfilesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ProfilesToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.Save_grey_16x_24
        Me.ProfilesToolStripMenuItem.Name = "ProfilesToolStripMenuItem"
        Me.ProfilesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ProfilesToolStripMenuItem.Text = "&Profiles"
        '
        'StartupBehaviourToolStripMenuItem
        '
        Me.StartupBehaviourToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StartupBehaviourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableOnIdleToolStripMenuItem, Me.EnableOnStartupToolStripMenuItem})
        Me.StartupBehaviourToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.StartupBehaviourToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.AzureSchedulerJob_16x
        Me.StartupBehaviourToolStripMenuItem.Name = "StartupBehaviourToolStripMenuItem"
        Me.StartupBehaviourToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.StartupBehaviourToolStripMenuItem.Text = "&Set and Forget"
        '
        'EnableOnIdleToolStripMenuItem
        '
        Me.EnableOnIdleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.EnableOnIdleToolStripMenuItem.CheckOnClick = True
        Me.EnableOnIdleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EnableOnIdleToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.StartTime_16x_32
        Me.EnableOnIdleToolStripMenuItem.Name = "EnableOnIdleToolStripMenuItem"
        Me.EnableOnIdleToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EnableOnIdleToolStripMenuItem.Text = "Enable on Idle"
        '
        'EnableOnStartupToolStripMenuItem
        '
        Me.EnableOnStartupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.EnableOnStartupToolStripMenuItem.CheckOnClick = True
        Me.EnableOnStartupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EnableOnStartupToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.StartRemoteDebugger_16x
        Me.EnableOnStartupToolStripMenuItem.Name = "EnableOnStartupToolStripMenuItem"
        Me.EnableOnStartupToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EnableOnStartupToolStripMenuItem.Text = "Enable on Startup"
        '
        'TerminalColorsToolStripMenuItem
        '
        Me.TerminalColorsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TerminalColorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.TerminalColorsToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.AzureStorageAccountClassic_color_16x
        Me.TerminalColorsToolStripMenuItem.Name = "TerminalColorsToolStripMenuItem"
        Me.TerminalColorsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TerminalColorsToolStripMenuItem.Text = "&Chart and Text Color"
        '
        'TrayIconToolStripMenuItem
        '
        Me.TrayIconToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TrayIconToolStripMenuItem.Checked = True
        Me.TrayIconToolStripMenuItem.CheckOnClick = True
        Me.TrayIconToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TrayIconToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TrayIconToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.Visible_16x
        Me.TrayIconToolStripMenuItem.Name = "TrayIconToolStripMenuItem"
        Me.TrayIconToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TrayIconToolStripMenuItem.Text = "&Tray Icon"
        '
        'UserModeToolStripMenuItem
        '
        Me.UserModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.UserModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeginnerToolStripMenuItem, Me.NoviceToolStripMenuItem, Me.VeteranToolStripMenuItem})
        Me.UserModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.UserModeToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.UserCode_16x
        Me.UserModeToolStripMenuItem.Name = "UserModeToolStripMenuItem"
        Me.UserModeToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UserModeToolStripMenuItem.Text = "&User Mode"
        Me.UserModeToolStripMenuItem.Visible = False
        '
        'BeginnerToolStripMenuItem
        '
        Me.BeginnerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BeginnerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BeginnerToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.baby
        Me.BeginnerToolStripMenuItem.Name = "BeginnerToolStripMenuItem"
        Me.BeginnerToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.BeginnerToolStripMenuItem.Text = "&Beginner"
        '
        'NoviceToolStripMenuItem
        '
        Me.NoviceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.NoviceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NoviceToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.middle
        Me.NoviceToolStripMenuItem.Name = "NoviceToolStripMenuItem"
        Me.NoviceToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.NoviceToolStripMenuItem.Text = "&Novice"
        '
        'VeteranToolStripMenuItem
        '
        Me.VeteranToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.VeteranToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VeteranToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.old
        Me.VeteranToolStripMenuItem.Name = "VeteranToolStripMenuItem"
        Me.VeteranToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.VeteranToolStripMenuItem.Text = "&Veteran"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AboutToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.StatusInformation_grey_16xMD
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.InstructionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InstructionsToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.HelpApplication_16x
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "&Instructions"
        '
        'SubredditToolStripMenuItem
        '
        Me.SubredditToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SubredditToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.SubredditToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.reddit_alien
        Me.SubredditToolStripMenuItem.Name = "SubredditToolStripMenuItem"
        Me.SubredditToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SubredditToolStripMenuItem.Text = "Subreddit"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.WebsiteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.WebsiteToolStripMenuItem.Image = Global.XMRGUI.My.Resources.Resources.globe
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'miner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 504)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.configoverridebtn)
        Me.Controls.Add(Me.radioautomatic)
        Me.Controls.Add(Me.radiomanual)
        Me.Controls.Add(Me.radiomanualfiles)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cputhreadspicker)
        Me.Controls.Add(Me.LinkLabel1)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "miner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XMRGUI v1.9"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.port, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cputhreadspicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartupBehaviourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableOnStartupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableOnIdleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents startbtn As Button
    Friend WithEvents stopbtn As Button
    Friend WithEvents TabControl1 As TabControl
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
    Friend WithEvents Label5 As Label
    Friend WithEvents poolpass As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cputhreadspicker As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents devdonatetimer As Timer
    Friend WithEvents userminingtimer As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PieChart4 As LiveCharts.WinForms.PieChart
    Friend WithEvents PieChart2 As LiveCharts.WinForms.PieChart
    Friend WithEvents PieChart1 As LiveCharts.WinForms.PieChart
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents PieChart3 As LiveCharts.WinForms.PieChart
    Friend WithEvents timeroutput As Timer
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HashRateMonitoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents uptime As Timer
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerminalColorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrayIconToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Exittraybtn As ToolStripMenuItem
    Friend WithEvents MineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents radiomanualfiles As RadioButton
    Friend WithEvents radiomanual As RadioButton
    Friend WithEvents radioautomatic As RadioButton
    Friend WithEvents configoverridebtn As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents chatpanel As Panel
    Friend WithEvents pooltotalpaid As Label
    Friend WithEvents poolpendingbalance As Label
    Friend WithEvents poolinvalidshares As Label
    Friend WithEvents poolvalidshares As Label
    Friend WithEvents pooltotalhashes As Label
    Friend WithEvents poolhashrate As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents poolapitimer As Timer
    Friend WithEvents SubredditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents idletimer As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents savebtn As Button
    Friend WithEvents ProfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeginnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VeteranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents hrmlabel As Label
    Friend WithEvents hrmlabeltimer As Timer
    Friend WithEvents hrmlabeltimer2 As Timer
    Friend WithEvents HRMTimer As Timer
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
