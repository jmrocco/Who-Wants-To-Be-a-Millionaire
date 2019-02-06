<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcongratulations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcongratulations))
        Me.lblCongrats = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picUniversity = New System.Windows.Forms.PictureBox()
        CType(Me.picUniversity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCongrats
        '
        Me.lblCongrats.AutoSize = True
        Me.lblCongrats.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCongrats.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongrats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCongrats.Location = New System.Drawing.Point(54, 252)
        Me.lblCongrats.Name = "lblCongrats"
        Me.lblCongrats.Size = New System.Drawing.Size(421, 130)
        Me.lblCongrats.TabIndex = 1
        Me.lblCongrats.Text = "Congratulations!! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  You've Won!!!!"
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Location = New System.Drawing.Point(201, 373)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 47)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'picUniversity
        '
        Me.picUniversity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUniversity.Image = Global.WindowsApplication1.My.Resources.Resources.gang
        Me.picUniversity.Location = New System.Drawing.Point(-4, 12)
        Me.picUniversity.Name = "picUniversity"
        Me.picUniversity.Size = New System.Drawing.Size(624, 540)
        Me.picUniversity.TabIndex = 0
        Me.picUniversity.TabStop = False
        '
        'frmcongratulations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(497, 421)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblCongrats)
        Me.Controls.Add(Me.picUniversity)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmcongratulations"
        Me.Text = "Congratulations!!!!"
        CType(Me.picUniversity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picUniversity As PictureBox
    Friend WithEvents lblCongrats As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class
