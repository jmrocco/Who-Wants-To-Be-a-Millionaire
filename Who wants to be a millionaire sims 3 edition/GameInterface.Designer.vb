<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGameInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameInterface))
        Me.btnQue = New System.Windows.Forms.PictureBox()
        Me.btnAnswer1 = New System.Windows.Forms.Button()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.btnAnswer4 = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Button()
        Me.btnMoney = New System.Windows.Forms.Button()
        Me.btnDropOut = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btnPhoneF = New System.Windows.Forms.Button()
        Me.btnPollAud = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl1000000 = New System.Windows.Forms.Label()
        Me.lbl500000 = New System.Windows.Forms.Label()
        Me.lbl250000 = New System.Windows.Forms.Label()
        Me.lbl125000 = New System.Windows.Forms.Label()
        Me.lbl64000 = New System.Windows.Forms.Label()
        Me.lbl32000 = New System.Windows.Forms.Label()
        Me.lbl16000 = New System.Windows.Forms.Label()
        Me.lbl8000 = New System.Windows.Forms.Label()
        Me.lbl4000 = New System.Windows.Forms.Label()
        Me.lbl2000 = New System.Windows.Forms.Label()
        Me.lbl1000 = New System.Windows.Forms.Label()
        Me.lbl500 = New System.Windows.Forms.Label()
        Me.lbl200 = New System.Windows.Forms.Label()
        Me.lbl100 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.btnQue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQue
        '
        Me.btnQue.BackColor = System.Drawing.Color.Transparent
        Me.btnQue.BackgroundImage = CType(resources.GetObject("btnQue.BackgroundImage"), System.Drawing.Image)
        Me.btnQue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQue.Location = New System.Drawing.Point(433, 96)
        Me.btnQue.Name = "btnQue"
        Me.btnQue.Size = New System.Drawing.Size(270, 283)
        Me.btnQue.TabIndex = 0
        Me.btnQue.TabStop = False
        '
        'btnAnswer1
        '
        Me.btnAnswer1.BackColor = System.Drawing.Color.Transparent
        Me.btnAnswer1.BackgroundImage = CType(resources.GetObject("btnAnswer1.BackgroundImage"), System.Drawing.Image)
        Me.btnAnswer1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAnswer1.Location = New System.Drawing.Point(168, 517)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(338, 82)
        Me.btnAnswer1.TabIndex = 2
        Me.btnAnswer1.UseVisualStyleBackColor = False
        '
        'btnAnswer2
        '
        Me.btnAnswer2.BackgroundImage = CType(resources.GetObject("btnAnswer2.BackgroundImage"), System.Drawing.Image)
        Me.btnAnswer2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAnswer2.Location = New System.Drawing.Point(168, 625)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(338, 82)
        Me.btnAnswer2.TabIndex = 3
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.BackgroundImage = CType(resources.GetObject("btnAnswer3.BackgroundImage"), System.Drawing.Image)
        Me.btnAnswer3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAnswer3.Location = New System.Drawing.Point(608, 517)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(338, 82)
        Me.btnAnswer3.TabIndex = 4
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.BackgroundImage = CType(resources.GetObject("btnAnswer4.BackgroundImage"), System.Drawing.Image)
        Me.btnAnswer4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAnswer4.Location = New System.Drawing.Point(608, 625)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(338, 82)
        Me.btnAnswer4.TabIndex = 5
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.BackgroundImage = CType(resources.GetObject("lblQuestion.BackgroundImage"), System.Drawing.Image)
        Me.lblQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.lblQuestion.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.lblQuestion.FlatAppearance.BorderSize = 0
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblQuestion.Location = New System.Drawing.Point(128, 379)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(865, 85)
        Me.lblQuestion.TabIndex = 6
        Me.lblQuestion.UseVisualStyleBackColor = False
        '
        'btnMoney
        '
        Me.btnMoney.BackgroundImage = CType(resources.GetObject("btnMoney.BackgroundImage"), System.Drawing.Image)
        Me.btnMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoney.Location = New System.Drawing.Point(13, 42)
        Me.btnMoney.Name = "btnMoney"
        Me.btnMoney.Size = New System.Drawing.Size(79, 72)
        Me.btnMoney.TabIndex = 8
        Me.btnMoney.UseVisualStyleBackColor = True
        '
        'btnDropOut
        '
        Me.btnDropOut.BackgroundImage = CType(resources.GetObject("btnDropOut.BackgroundImage"), System.Drawing.Image)
        Me.btnDropOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDropOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDropOut.Location = New System.Drawing.Point(108, 42)
        Me.btnDropOut.Name = "btnDropOut"
        Me.btnDropOut.Size = New System.Drawing.Size(79, 72)
        Me.btnDropOut.TabIndex = 8
        Me.btnDropOut.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.BackgroundImage = CType(resources.GetObject("btn50.BackgroundImage"), System.Drawing.Image)
        Me.btn50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn50.Location = New System.Drawing.Point(864, 42)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(82, 72)
        Me.btn50.TabIndex = 10
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btnPhoneF
        '
        Me.btnPhoneF.BackgroundImage = CType(resources.GetObject("btnPhoneF.BackgroundImage"), System.Drawing.Image)
        Me.btnPhoneF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPhoneF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhoneF.Location = New System.Drawing.Point(977, 42)
        Me.btnPhoneF.Name = "btnPhoneF"
        Me.btnPhoneF.Size = New System.Drawing.Size(82, 72)
        Me.btnPhoneF.TabIndex = 11
        Me.btnPhoneF.UseVisualStyleBackColor = True
        '
        'btnPollAud
        '
        Me.btnPollAud.BackgroundImage = CType(resources.GetObject("btnPollAud.BackgroundImage"), System.Drawing.Image)
        Me.btnPollAud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPollAud.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPollAud.Location = New System.Drawing.Point(1081, 42)
        Me.btnPollAud.Name = "btnPollAud"
        Me.btnPollAud.Size = New System.Drawing.Size(82, 72)
        Me.btnPollAud.TabIndex = 12
        Me.btnPollAud.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(523, 39)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(99, 43)
        Me.lblCounter.TabIndex = 7
        Me.lblCounter.Text = "Time"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbl1000000
        '
        Me.lbl1000000.AutoSize = True
        Me.lbl1000000.BackColor = System.Drawing.Color.White
        Me.lbl1000000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1000000.Location = New System.Drawing.Point(1162, 164)
        Me.lbl1000000.Name = "lbl1000000"
        Me.lbl1000000.Size = New System.Drawing.Size(100, 25)
        Me.lbl1000000.TabIndex = 27
        Me.lbl1000000.Text = "$1000000"
        '
        'lbl500000
        '
        Me.lbl500000.AutoSize = True
        Me.lbl500000.BackColor = System.Drawing.Color.White
        Me.lbl500000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl500000.Location = New System.Drawing.Point(1173, 189)
        Me.lbl500000.Name = "lbl500000"
        Me.lbl500000.Size = New System.Drawing.Size(89, 25)
        Me.lbl500000.TabIndex = 26
        Me.lbl500000.Text = "$500000"
        '
        'lbl250000
        '
        Me.lbl250000.AutoSize = True
        Me.lbl250000.BackColor = System.Drawing.Color.White
        Me.lbl250000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl250000.Location = New System.Drawing.Point(1173, 214)
        Me.lbl250000.Name = "lbl250000"
        Me.lbl250000.Size = New System.Drawing.Size(89, 25)
        Me.lbl250000.TabIndex = 25
        Me.lbl250000.Text = "$250000"
        '
        'lbl125000
        '
        Me.lbl125000.AutoSize = True
        Me.lbl125000.BackColor = System.Drawing.Color.White
        Me.lbl125000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl125000.Location = New System.Drawing.Point(1173, 239)
        Me.lbl125000.Name = "lbl125000"
        Me.lbl125000.Size = New System.Drawing.Size(89, 25)
        Me.lbl125000.TabIndex = 24
        Me.lbl125000.Text = "$125000"
        '
        'lbl64000
        '
        Me.lbl64000.AutoSize = True
        Me.lbl64000.BackColor = System.Drawing.Color.White
        Me.lbl64000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl64000.Location = New System.Drawing.Point(1184, 264)
        Me.lbl64000.Name = "lbl64000"
        Me.lbl64000.Size = New System.Drawing.Size(78, 25)
        Me.lbl64000.TabIndex = 23
        Me.lbl64000.Text = "$64000"
        '
        'lbl32000
        '
        Me.lbl32000.AutoSize = True
        Me.lbl32000.BackColor = System.Drawing.Color.White
        Me.lbl32000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl32000.Location = New System.Drawing.Point(1184, 289)
        Me.lbl32000.Name = "lbl32000"
        Me.lbl32000.Size = New System.Drawing.Size(78, 25)
        Me.lbl32000.TabIndex = 22
        Me.lbl32000.Text = "$32000"
        '
        'lbl16000
        '
        Me.lbl16000.AutoSize = True
        Me.lbl16000.BackColor = System.Drawing.Color.White
        Me.lbl16000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16000.Location = New System.Drawing.Point(1184, 314)
        Me.lbl16000.Name = "lbl16000"
        Me.lbl16000.Size = New System.Drawing.Size(78, 25)
        Me.lbl16000.TabIndex = 21
        Me.lbl16000.Text = "$16000"
        '
        'lbl8000
        '
        Me.lbl8000.AutoSize = True
        Me.lbl8000.BackColor = System.Drawing.Color.White
        Me.lbl8000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8000.Location = New System.Drawing.Point(1195, 339)
        Me.lbl8000.Name = "lbl8000"
        Me.lbl8000.Size = New System.Drawing.Size(67, 25)
        Me.lbl8000.TabIndex = 20
        Me.lbl8000.Text = "$8000"
        '
        'lbl4000
        '
        Me.lbl4000.AutoSize = True
        Me.lbl4000.BackColor = System.Drawing.Color.White
        Me.lbl4000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4000.Location = New System.Drawing.Point(1195, 364)
        Me.lbl4000.Name = "lbl4000"
        Me.lbl4000.Size = New System.Drawing.Size(67, 25)
        Me.lbl4000.TabIndex = 19
        Me.lbl4000.Text = "$4000"
        '
        'lbl2000
        '
        Me.lbl2000.AutoSize = True
        Me.lbl2000.BackColor = System.Drawing.Color.White
        Me.lbl2000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2000.Location = New System.Drawing.Point(1195, 389)
        Me.lbl2000.Name = "lbl2000"
        Me.lbl2000.Size = New System.Drawing.Size(67, 25)
        Me.lbl2000.TabIndex = 18
        Me.lbl2000.Text = "$2000"
        '
        'lbl1000
        '
        Me.lbl1000.AutoSize = True
        Me.lbl1000.BackColor = System.Drawing.Color.White
        Me.lbl1000.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1000.Location = New System.Drawing.Point(1195, 414)
        Me.lbl1000.Name = "lbl1000"
        Me.lbl1000.Size = New System.Drawing.Size(67, 25)
        Me.lbl1000.TabIndex = 17
        Me.lbl1000.Text = "$1000"
        '
        'lbl500
        '
        Me.lbl500.AutoSize = True
        Me.lbl500.BackColor = System.Drawing.Color.White
        Me.lbl500.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl500.Location = New System.Drawing.Point(1206, 439)
        Me.lbl500.Name = "lbl500"
        Me.lbl500.Size = New System.Drawing.Size(56, 25)
        Me.lbl500.TabIndex = 16
        Me.lbl500.Text = "$500"
        '
        'lbl200
        '
        Me.lbl200.AutoSize = True
        Me.lbl200.BackColor = System.Drawing.Color.White
        Me.lbl200.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl200.Location = New System.Drawing.Point(1206, 464)
        Me.lbl200.Name = "lbl200"
        Me.lbl200.Size = New System.Drawing.Size(56, 25)
        Me.lbl200.TabIndex = 15
        Me.lbl200.Text = "$200"
        '
        'lbl100
        '
        Me.lbl100.AutoSize = True
        Me.lbl100.BackColor = System.Drawing.Color.White
        Me.lbl100.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl100.Location = New System.Drawing.Point(1206, 489)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(56, 25)
        Me.lbl100.TabIndex = 14
        Me.lbl100.Text = "$100"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1261, 25)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.OptionsToolStripMenuItem.BackgroundImage = CType(resources.GetObject("OptionsToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.OptionsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.HelpToolStripMenuItem.BackgroundImage = CType(resources.GetObject("HelpToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ExitToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ExitToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmGameInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1261, 739)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.btnPollAud)
        Me.Controls.Add(Me.lbl200)
        Me.Controls.Add(Me.btnPhoneF)
        Me.Controls.Add(Me.lbl500)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.lbl1000)
        Me.Controls.Add(Me.btnDropOut)
        Me.Controls.Add(Me.lbl2000)
        Me.Controls.Add(Me.btnMoney)
        Me.Controls.Add(Me.lbl4000)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lbl8000)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lbl16000)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.lbl32000)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.lbl64000)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.lbl125000)
        Me.Controls.Add(Me.btnAnswer1)
        Me.Controls.Add(Me.lbl250000)
        Me.Controls.Add(Me.btnQue)
        Me.Controls.Add(Me.lbl500000)
        Me.Controls.Add(Me.lbl1000000)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGameInterface"
        Me.Text = "Who Wants to be a Millionaire: Sims 3 Edition"
        CType(Me.btnQue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQue As System.Windows.Forms.PictureBox
    Friend WithEvents btnAnswer1 As System.Windows.Forms.Button
    Friend WithEvents btnAnswer2 As System.Windows.Forms.Button
    Friend WithEvents btnAnswer3 As System.Windows.Forms.Button
    Friend WithEvents btnAnswer4 As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Button
    Friend WithEvents btnMoney As System.Windows.Forms.Button
    Friend WithEvents btnDropOut As System.Windows.Forms.Button
    Friend WithEvents btn50 As System.Windows.Forms.Button
    Friend WithEvents btnPhoneF As System.Windows.Forms.Button
    Friend WithEvents btnPollAud As System.Windows.Forms.Button
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl100 As Label
    Friend WithEvents lbl200 As Label
    Friend WithEvents lbl500 As Label
    Friend WithEvents lbl1000 As Label
    Friend WithEvents lbl2000 As Label
    Friend WithEvents lbl4000 As Label
    Friend WithEvents lbl8000 As Label
    Friend WithEvents lbl16000 As Label
    Friend WithEvents lbl32000 As Label
    Friend WithEvents lbl64000 As Label
    Friend WithEvents lbl125000 As Label
    Friend WithEvents lbl250000 As Label
    Friend WithEvents lbl500000 As Label
    Friend WithEvents lbl1000000 As Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
