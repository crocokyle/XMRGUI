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
        Me.StartupBehaviourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableOnIdleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayOnlyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvisibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.startbtn = New System.Windows.Forms.Button()
        Me.stopbtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.PieChart3 = New LiveCharts.WinForms.PieChart()
        Me.PieChart4 = New LiveCharts.WinForms.PieChart()
        Me.PieChart2 = New LiveCharts.WinForms.PieChart()
        Me.PieChart1 = New LiveCharts.WinForms.PieChart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.devdonatetimer = New System.Windows.Forms.Timer(Me.components)
        Me.userminingtimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.timerclearlog = New System.Windows.Forms.Timer(Me.components)
        Me.timeroutput = New System.Windows.Forms.Timer(Me.components)
        Me.Labelhashrate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
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
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonationLevelToolStripMenuItem, Me.StartupBehaviourToolStripMenuItem, Me.TerminalColorsToolStripMenuItem, Me.VisibilityToolStripMenuItem})
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'DonationLevelToolStripMenuItem
        '
        Me.DonationLevelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DonationLevelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DonationLevelToolStripMenuItem.Name = "DonationLevelToolStripMenuItem"
        Me.DonationLevelToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DonationLevelToolStripMenuItem.Text = "Donation Level"
        '
        'StartupBehaviourToolStripMenuItem
        '
        Me.StartupBehaviourToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StartupBehaviourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableOnIdleToolStripMenuItem, Me.EnableOnStartupToolStripMenuItem})
        Me.StartupBehaviourToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.StartupBehaviourToolStripMenuItem.Name = "StartupBehaviourToolStripMenuItem"
        Me.StartupBehaviourToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.StartupBehaviourToolStripMenuItem.Text = "Set and Forget"
        '
        'EnableOnIdleToolStripMenuItem
        '
        Me.EnableOnIdleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.EnableOnIdleToolStripMenuItem.CheckOnClick = True
        Me.EnableOnIdleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EnableOnIdleToolStripMenuItem.Name = "EnableOnIdleToolStripMenuItem"
        Me.EnableOnIdleToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EnableOnIdleToolStripMenuItem.Text = "Enable on Idle"
        '
        'EnableOnStartupToolStripMenuItem
        '
        Me.EnableOnStartupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.EnableOnStartupToolStripMenuItem.CheckOnClick = True
        Me.EnableOnStartupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EnableOnStartupToolStripMenuItem.Name = "EnableOnStartupToolStripMenuItem"
        Me.EnableOnStartupToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EnableOnStartupToolStripMenuItem.Text = "Enable on Startup"
        '
        'TerminalColorsToolStripMenuItem
        '
        Me.TerminalColorsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TerminalColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlueToolStripMenuItem, Me.GreenToolStripMenuItem, Me.OrangeToolStripMenuItem})
        Me.TerminalColorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.TerminalColorsToolStripMenuItem.Name = "TerminalColorsToolStripMenuItem"
        Me.TerminalColorsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.TerminalColorsToolStripMenuItem.Text = "Terminal Colors"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BlueToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GreenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.OrangeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'VisibilityToolStripMenuItem
        '
        Me.VisibilityToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.VisibilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrayOnlyToolStripMenuItem, Me.TrayOnlyToolStripMenuItem1, Me.InvisibleToolStripMenuItem})
        Me.VisibilityToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VisibilityToolStripMenuItem.Name = "VisibilityToolStripMenuItem"
        Me.VisibilityToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.VisibilityToolStripMenuItem.Text = "Visibility"
        '
        'TrayOnlyToolStripMenuItem
        '
        Me.TrayOnlyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TrayOnlyToolStripMenuItem.CheckOnClick = True
        Me.TrayOnlyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TrayOnlyToolStripMenuItem.Name = "TrayOnlyToolStripMenuItem"
        Me.TrayOnlyToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TrayOnlyToolStripMenuItem.Text = "Windowed"
        '
        'TrayOnlyToolStripMenuItem1
        '
        Me.TrayOnlyToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TrayOnlyToolStripMenuItem1.CheckOnClick = True
        Me.TrayOnlyToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TrayOnlyToolStripMenuItem1.Name = "TrayOnlyToolStripMenuItem1"
        Me.TrayOnlyToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.TrayOnlyToolStripMenuItem1.Text = "Tray Only"
        '
        'InvisibleToolStripMenuItem
        '
        Me.InvisibleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.InvisibleToolStripMenuItem.CheckOnClick = True
        Me.InvisibleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InvisibleToolStripMenuItem.Name = "InvisibleToolStripMenuItem"
        Me.InvisibleToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.InvisibleToolStripMenuItem.Text = "Invisible"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.InstructionsToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.InstructionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
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
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
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
        'CartesianChart1
        '
        Me.CartesianChart1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(781, 297)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Approximate Earnings"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(164, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(455, 76)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Coming Soon!"
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
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(13, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "XMR Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(28, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pool URL:"
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
        Me.Label3.AutoSize = True
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
        Me.port.Location = New System.Drawing.Point(443, 361)
        Me.port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(108, 16)
        Me.port.TabIndex = 3
        Me.port.Value = New Decimal(New Integer() {5555, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Location = New System.Drawing.Point(564, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Refresh Inverval (seconds):"
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
        Me.refreshint.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(554, 386)
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
        Me.poolpass.Location = New System.Drawing.Point(640, 383)
        Me.poolpass.Name = "poolpass"
        Me.poolpass.Size = New System.Drawing.Size(161, 20)
        Me.poolpass.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.CheckBox1.Location = New System.Drawing.Point(16, 416)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(158, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Use automatic configuration"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Silver
        Me.LinkLabel1.Location = New System.Drawing.Point(180, 417)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Help?"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.NumericUpDown1.Location = New System.Drawing.Point(628, 413)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 16)
        Me.NumericUpDown1.TabIndex = 16
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.NumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.NumericUpDown2.Location = New System.Drawing.Point(758, 413)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(43, 16)
        Me.NumericUpDown2.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(548, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CPU Threads:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(677, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "GPU Threads:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Location = New System.Drawing.Point(327, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Clear Terminal"
        Me.Button1.UseVisualStyleBackColor = False
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
        'timerclearlog
        '
        Me.timerclearlog.Interval = 2200000
        '
        'timeroutput
        '
        Me.timeroutput.Interval = 1000
        '
        'Labelhashrate
        '
        Me.Labelhashrate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Labelhashrate.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Labelhashrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelhashrate.Location = New System.Drawing.Point(567, 3)
        Me.Labelhashrate.Name = "Labelhashrate"
        Me.Labelhashrate.Size = New System.Drawing.Size(150, 18)
        Me.Labelhashrate.TabIndex = 1
        Me.Labelhashrate.Text = "0"
        Me.Labelhashrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(717, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "H/s"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'miner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 504)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Labelhashrate)
        Me.Controls.Add(Me.Button2)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "miner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XMRGUI v1.0 "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents StartupBehaviourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableOnStartupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableOnIdleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisibilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrayOnlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrayOnlyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvisibleToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents devdonatetimer As Timer
    Friend WithEvents userminingtimer As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents TerminalColorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents timerclearlog As Timer
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PieChart4 As LiveCharts.WinForms.PieChart
    Friend WithEvents PieChart2 As LiveCharts.WinForms.PieChart
    Friend WithEvents PieChart1 As LiveCharts.WinForms.PieChart
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents PieChart3 As LiveCharts.WinForms.PieChart
    Friend WithEvents timeroutput As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents Labelhashrate As Label
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
End Class
