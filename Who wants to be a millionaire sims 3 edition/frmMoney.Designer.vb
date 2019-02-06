<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoney
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoney))
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblWinings = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.BackColor = System.Drawing.Color.Transparent
        Me.lblStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatement.Location = New System.Drawing.Point(73, 100)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(228, 20)
        Me.lblStatement.TabIndex = 0
        Me.lblStatement.Text = "Your Current Winnings Are:"
        '
        'lblWinings
        '
        Me.lblWinings.AutoSize = True
        Me.lblWinings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinings.Location = New System.Drawing.Point(145, 148)
        Me.lblWinings.Name = "lblWinings"
        Me.lblWinings.Size = New System.Drawing.Size(0, 25)
        Me.lblWinings.TabIndex = 1
        '
        'btnok
        '
        Me.btnok.BackgroundImage = CType(resources.GetObject("btnok.BackgroundImage"), System.Drawing.Image)
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(129, 272)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(109, 52)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "Okay"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'frmMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(388, 360)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.lblWinings)
        Me.Controls.Add(Me.lblStatement)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMoney"
        Me.Text = "Current Balance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatement As Label
    Friend WithEvents lblWinings As Label
    Friend WithEvents btnok As Button
End Class
