<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDropOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDropOut))
        Me.lblSure = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblmoney = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSure
        '
        Me.lblSure.AutoSize = True
        Me.lblSure.BackColor = System.Drawing.Color.Transparent
        Me.lblSure.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSure.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSure.Location = New System.Drawing.Point(29, 82)
        Me.lblSure.Name = "lblSure"
        Me.lblSure.Size = New System.Drawing.Size(308, 48)
        Me.lblSure.TabIndex = 0
        Me.lblSure.Text = "Are you sure you want to drop out? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You will only recieve: "
        '
        'btnYes
        '
        Me.btnYes.BackgroundImage = CType(resources.GetObject("btnYes.BackgroundImage"), System.Drawing.Image)
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(12, 273)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(132, 57)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.BackgroundImage = CType(resources.GetObject("btnNo.BackgroundImage"), System.Drawing.Image)
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(225, 273)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(132, 57)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'lblmoney
        '
        Me.lblmoney.AutoSize = True
        Me.lblmoney.BackColor = System.Drawing.Color.Transparent
        Me.lblmoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmoney.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblmoney.Location = New System.Drawing.Point(221, 106)
        Me.lblmoney.Name = "lblmoney"
        Me.lblmoney.Size = New System.Drawing.Size(0, 24)
        Me.lblmoney.TabIndex = 3
        '
        'frmDropOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(369, 342)
        Me.Controls.Add(Me.lblmoney)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblSure)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDropOut"
        Me.Text = "Are You Sure?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSure As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents lblmoney As System.Windows.Forms.Label
End Class
