<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoading))
        Me.prgbarLoading = New System.Windows.Forms.ProgressBar()
        Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
        Me.picSpinningDiamond = New System.Windows.Forms.PictureBox()
        CType(Me.picSpinningDiamond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prgbarLoading
        '
        Me.prgbarLoading.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.prgbarLoading.Location = New System.Drawing.Point(334, 425)
        Me.prgbarLoading.Margin = New System.Windows.Forms.Padding(2)
        Me.prgbarLoading.Name = "prgbarLoading"
        Me.prgbarLoading.Size = New System.Drawing.Size(293, 27)
        Me.prgbarLoading.TabIndex = 0
        '
        'tmrLoading
        '
        '
        'picSpinningDiamond
        '
        Me.picSpinningDiamond.BackColor = System.Drawing.Color.Transparent
        Me.picSpinningDiamond.Image = Global.WindowsApplication1.My.Resources.Resources.Sims_3_Spinning_Diamond
        Me.picSpinningDiamond.Location = New System.Drawing.Point(418, 82)
        Me.picSpinningDiamond.Name = "picSpinningDiamond"
        Me.picSpinningDiamond.Size = New System.Drawing.Size(122, 269)
        Me.picSpinningDiamond.TabIndex = 1
        Me.picSpinningDiamond.TabStop = False
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(968, 563)
        Me.Controls.Add(Me.picSpinningDiamond)
        Me.Controls.Add(Me.prgbarLoading)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoading"
        Me.Text = "Loading...."
        CType(Me.picSpinningDiamond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prgbarLoading As ProgressBar
    Friend WithEvents tmrLoading As Timer
    Friend WithEvents picSpinningDiamond As PictureBox
End Class
