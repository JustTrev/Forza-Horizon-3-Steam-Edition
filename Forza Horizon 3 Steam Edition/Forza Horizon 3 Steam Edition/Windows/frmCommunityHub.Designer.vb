<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommunityHub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommunityHub))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.TextField = New System.Windows.Forms.RichTextBox()
        Me.Chat = New System.Windows.Forms.RichTextBox()
        Me.headForm = New System.Windows.Forms.Label()
        Me.pHeadForm = New System.Windows.Forms.Panel()
        Me.sendDelay = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pHeadForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.DimGray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(920, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Controls.Add(Me.TextField)
        Me.Panel1.Controls.Add(Me.Chat)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 309)
        Me.Panel1.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnSend.Location = New System.Drawing.Point(847, 274)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(69, 26)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'TextField
        '
        Me.TextField.AcceptsTab = True
        Me.TextField.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextField.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextField.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextField.DetectUrls = False
        Me.TextField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextField.ForeColor = System.Drawing.Color.Gold
        Me.TextField.Location = New System.Drawing.Point(4, 274)
        Me.TextField.MaxLength = 255
        Me.TextField.Multiline = False
        Me.TextField.Name = "TextField"
        Me.TextField.Size = New System.Drawing.Size(837, 26)
        Me.TextField.TabIndex = 5
        Me.TextField.Text = ""
        '
        'Chat
        '
        Me.Chat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chat.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Chat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chat.Location = New System.Drawing.Point(4, 4)
        Me.Chat.Name = "Chat"
        Me.Chat.ReadOnly = True
        Me.Chat.Size = New System.Drawing.Size(912, 261)
        Me.Chat.TabIndex = 4
        Me.Chat.Text = ""
        '
        'headForm
        '
        Me.headForm.AutoSize = True
        Me.headForm.BackColor = System.Drawing.Color.Transparent
        Me.headForm.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.headForm.Location = New System.Drawing.Point(11, 3)
        Me.headForm.Name = "headForm"
        Me.headForm.Size = New System.Drawing.Size(169, 22)
        Me.headForm.TabIndex = 2
        Me.headForm.Text = "COMMUNITY HUB"
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
        Me.pHeadForm.Size = New System.Drawing.Size(949, 30)
        Me.pHeadForm.TabIndex = 6
        '
        'sendDelay
        '
        Me.sendDelay.Interval = 800
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'frmCommunityHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.Forza_Horizon_3_Steam_Edition.My.Resources.Resources.PEANUTBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(943, 362)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pHeadForm)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(600, 500)
        Me.Name = "frmCommunityHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmCommunityHub"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.pHeadForm.ResumeLayout(False)
        Me.pHeadForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents headForm As Label
    Friend WithEvents pHeadForm As Panel
    Friend WithEvents btnSend As Button
    Friend WithEvents TextField As RichTextBox
    Friend WithEvents Chat As RichTextBox
    Friend WithEvents sendDelay As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
