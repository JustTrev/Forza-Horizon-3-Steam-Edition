<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountSettings
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
        Me.lblNotices = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.headForm = New System.Windows.Forms.Label()
        Me.pHeadForm = New System.Windows.Forms.Panel()
        Me.pSize = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pHeadForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(611, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblNotices)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtPName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 394)
        Me.Panel1.TabIndex = 5
        '
        'lblNotices
        '
        Me.lblNotices.AutoSize = True
        Me.lblNotices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotices.ForeColor = System.Drawing.Color.Red
        Me.lblNotices.Location = New System.Drawing.Point(103, 45)
        Me.lblNotices.Name = "lblNotices"
        Me.lblNotices.Size = New System.Drawing.Size(35, 16)
        Me.lblNotices.TabIndex = 3
        Me.lblNotices.Text = "Alert"
        Me.lblNotices.Visible = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(514, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save && Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPName
        '
        Me.txtPName.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPName.Location = New System.Drawing.Point(106, 25)
        Me.txtPName.MaxLength = 20
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(211, 17)
        Me.txtPName.TabIndex = 1
        Me.txtPName.Text = "BLOODED CYBORG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Display Name:"
        '
        'headForm
        '
        Me.headForm.AutoSize = True
        Me.headForm.BackColor = System.Drawing.Color.Transparent
        Me.headForm.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.headForm.Location = New System.Drawing.Point(11, 3)
        Me.headForm.Name = "headForm"
        Me.headForm.Size = New System.Drawing.Size(139, 22)
        Me.headForm.TabIndex = 2
        Me.headForm.Text = "Profile Settings"
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
        Me.pHeadForm.TabIndex = 6
        '
        'pSize
        '
        Me.pSize.BackColor = System.Drawing.Color.Transparent
        Me.pSize.BackgroundImage = Global.Forza_Horizon_3_Steam_Edition.My.Resources.Resources.PEANUT2
        Me.pSize.Location = New System.Drawing.Point(606, 419)
        Me.pSize.Name = "pSize"
        Me.pSize.Size = New System.Drawing.Size(31, 38)
        Me.pSize.TabIndex = 7
        '
        'frmAccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Forza_Horizon_3_Steam_Edition.My.Resources.Resources.PEANUT2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 447)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pHeadForm)
        Me.Controls.Add(Me.pSize)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAccountSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAccountSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pHeadForm.ResumeLayout(False)
        Me.pHeadForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents headForm As Label
    Friend WithEvents pHeadForm As Panel
    Friend WithEvents pSize As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPName As TextBox
    Friend WithEvents lblNotices As Label
End Class
