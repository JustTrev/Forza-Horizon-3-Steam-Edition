<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.headForm = New System.Windows.Forms.Label()
        Me.pHeadForm = New System.Windows.Forms.Panel()
        Me.pSize = New System.Windows.Forms.Panel()
        Me.pHeadForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(601, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 394)
        Me.Panel1.TabIndex = 1
        '
        'headForm
        '
        Me.headForm.AutoSize = True
        Me.headForm.BackColor = System.Drawing.Color.Transparent
        Me.headForm.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.headForm.Location = New System.Drawing.Point(11, 3)
        Me.headForm.Name = "headForm"
        Me.headForm.Size = New System.Drawing.Size(119, 22)
        Me.headForm.TabIndex = 2
        Me.headForm.Text = "Test Window"
        '
        'pHeadForm
        '
        Me.pHeadForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pHeadForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pHeadForm.Controls.Add(Me.headForm)
        Me.pHeadForm.Controls.Add(Me.btnClose)
        Me.pHeadForm.Location = New System.Drawing.Point(-3, -1)
        Me.pHeadForm.Name = "pHeadForm"
        Me.pHeadForm.Size = New System.Drawing.Size(640, 30)
        Me.pHeadForm.TabIndex = 3
        '
        'pSize
        '
        Me.pSize.BackColor = System.Drawing.Color.Transparent
        Me.pSize.BackgroundImage = Global.Forza_Horizon_3_Steam_Edition.My.Resources.Resources.PEANUT2
        Me.pSize.Location = New System.Drawing.Point(606, 420)
        Me.pSize.Name = "pSize"
        Me.pSize.Size = New System.Drawing.Size(31, 28)
        Me.pSize.TabIndex = 4
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Forza_Horizon_3_Steam_Edition.My.Resources.Resources.PEANUT2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 447)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pHeadForm)
        Me.Controls.Add(Me.pSize)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Test"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaption
        Me.pHeadForm.ResumeLayout(False)
        Me.pHeadForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents headForm As Label
    Friend WithEvents pHeadForm As Panel
    Friend WithEvents pSize As Panel
End Class
