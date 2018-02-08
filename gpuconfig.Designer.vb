<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gpuconfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cpuconfigtextbox = New System.Windows.Forms.RichTextBox()
        Me.nvconfigtextbox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nvlabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.amdconfigtextbox = New System.Windows.Forms.RichTextBox()
        Me.amdlabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cpuconfigtextbox
        '
        Me.cpuconfigtextbox.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cpuconfigtextbox.Location = New System.Drawing.Point(13, 35)
        Me.cpuconfigtextbox.Name = "cpuconfigtextbox"
        Me.cpuconfigtextbox.Size = New System.Drawing.Size(413, 291)
        Me.cpuconfigtextbox.TabIndex = 30
        Me.cpuconfigtextbox.Text = ""
        '
        'nvconfigtextbox
        '
        Me.nvconfigtextbox.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.nvconfigtextbox.Location = New System.Drawing.Point(432, 35)
        Me.nvconfigtextbox.Name = "nvconfigtextbox"
        Me.nvconfigtextbox.Size = New System.Drawing.Size(413, 291)
        Me.nvconfigtextbox.TabIndex = 33
        Me.nvconfigtextbox.Text = ""
        Me.nvconfigtextbox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(168, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(525, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Please edit your config files here (editting the manual files will not work)"
        '
        'nvlabel
        '
        Me.nvlabel.AutoSize = True
        Me.nvlabel.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nvlabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.nvlabel.Location = New System.Drawing.Point(772, 9)
        Me.nvlabel.Name = "nvlabel"
        Me.nvlabel.Size = New System.Drawing.Size(73, 23)
        Me.nvlabel.TabIndex = 35
        Me.nvlabel.Text = "NVIDIA"
        Me.nvlabel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "CPU"
        '
        'amdconfigtextbox
        '
        Me.amdconfigtextbox.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.amdconfigtextbox.Location = New System.Drawing.Point(221, 356)
        Me.amdconfigtextbox.Name = "amdconfigtextbox"
        Me.amdconfigtextbox.Size = New System.Drawing.Size(413, 291)
        Me.amdconfigtextbox.TabIndex = 37
        Me.amdconfigtextbox.Text = ""
        Me.amdconfigtextbox.Visible = False
        '
        'amdlabel
        '
        Me.amdlabel.AutoSize = True
        Me.amdlabel.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amdlabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.amdlabel.Location = New System.Drawing.Point(403, 329)
        Me.amdlabel.Name = "amdlabel"
        Me.amdlabel.Size = New System.Drawing.Size(50, 23)
        Me.amdlabel.TabIndex = 38
        Me.amdlabel.Text = "AMD"
        Me.amdlabel.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(10, 612)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 35)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(640, 612)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 35)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'gpuconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(856, 659)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.amdlabel)
        Me.Controls.Add(Me.amdconfigtextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nvlabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nvconfigtextbox)
        Me.Controls.Add(Me.cpuconfigtextbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gpuconfig"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPU Configuration - XMRGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cpuconfigtextbox As RichTextBox
    Friend WithEvents nvconfigtextbox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nvlabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents amdconfigtextbox As RichTextBox
    Friend WithEvents amdlabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
