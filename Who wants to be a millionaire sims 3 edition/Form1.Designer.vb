<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpening
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpening))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameRulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheCreatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picFirstName = New System.Windows.Forms.PictureBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.picLastName = New System.Windows.Forms.PictureBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(978, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.OptionsToolStripMenuItem.BackgroundImage = CType(resources.GetObject("OptionsToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.OptionsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem, Me.GameRulesToolStripMenuItem, Me.AboutTheCreatorToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OptionsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.OptionsToolStripMenuItem.Text = "Options"
        Me.OptionsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StartGameToolStripMenuItem.BackgroundImage = CType(resources.GetObject("StartGameToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.StartGameToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.StartGameToolStripMenuItem.Text = "Start Game"
        '
        'GameRulesToolStripMenuItem
        '
        Me.GameRulesToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.GameRulesToolStripMenuItem.BackgroundImage = CType(resources.GetObject("GameRulesToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.GameRulesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameRulesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GameRulesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.GameRulesToolStripMenuItem.Name = "GameRulesToolStripMenuItem"
        Me.GameRulesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.GameRulesToolStripMenuItem.Text = "Game Rules"
        Me.GameRulesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'AboutTheCreatorToolStripMenuItem
        '
        Me.AboutTheCreatorToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.AboutTheCreatorToolStripMenuItem.BackgroundImage = CType(resources.GetObject("AboutTheCreatorToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.AboutTheCreatorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutTheCreatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AboutTheCreatorToolStripMenuItem.Name = "AboutTheCreatorToolStripMenuItem"
        Me.AboutTheCreatorToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AboutTheCreatorToolStripMenuItem.Text = "About The Creator"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.ExitToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ExitToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'picFirstName
        '
        Me.picFirstName.BackgroundImage = CType(resources.GetObject("picFirstName.BackgroundImage"), System.Drawing.Image)
        Me.picFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFirstName.Location = New System.Drawing.Point(54, 432)
        Me.picFirstName.Name = "picFirstName"
        Me.picFirstName.Size = New System.Drawing.Size(145, 34)
        Me.picFirstName.TabIndex = 2
        Me.picFirstName.TabStop = False
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.SteelBlue
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(205, 432)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(165, 34)
        Me.txtFirstName.TabIndex = 3
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picLastName
        '
        Me.picLastName.BackgroundImage = CType(resources.GetObject("picLastName.BackgroundImage"), System.Drawing.Image)
        Me.picLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLastName.Location = New System.Drawing.Point(621, 432)
        Me.picLastName.Name = "picLastName"
        Me.picLastName.Size = New System.Drawing.Size(145, 34)
        Me.picLastName.TabIndex = 4
        Me.picLastName.TabStop = False
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.SteelBlue
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(772, 432)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(165, 34)
        Me.txtLastName.TabIndex = 5
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.Location = New System.Drawing.Point(389, 430)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(215, 93)
        Me.btnStart.TabIndex = 6
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo.Location = New System.Drawing.Point(297, 38)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(375, 386)
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'frmOpening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(978, 573)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.picLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.picFirstName)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpening"
        Me.Text = "Who Wants to be a Millionaire: The Sims 3 Edition"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameRulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheCreatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picFirstName As System.Windows.Forms.PictureBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents picLastName As System.Windows.Forms.PictureBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents StartGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
End Class
