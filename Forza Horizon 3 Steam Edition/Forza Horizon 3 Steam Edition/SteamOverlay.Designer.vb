<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SteamOverlay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            Try
                MyBase.Dispose(disposing)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SteamOverlay))
        Me.Overlay = New System.ComponentModel.BackgroundWorker()
        Me.clock = New System.Windows.Forms.Timer(Me.components)
        Me.shiftTabListener = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.gameRunningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sendDelay = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.frmCommunityHub = New System.Windows.Forms.LinkLabel()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GameTitle = New System.Windows.Forms.Label()
        Me.DateStamp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnkReturn = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pMainPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.lnkAccountDetails = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_LoadChat = New System.ComponentModel.BackgroundWorker()
        Me.pMainPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Overlay
        '
        Me.Overlay.WorkerReportsProgress = True
        Me.Overlay.WorkerSupportsCancellation = True
        '
        'clock
        '
        Me.clock.Enabled = True
        Me.clock.Interval = 1000
        '
        'shiftTabListener
        '
        Me.shiftTabListener.Interval = 12
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Forza Horizon 3 Steam Edition"
        Me.NotifyIcon1.Visible = True
        '
        'gameRunningTimer
        '
        Me.gameRunningTimer.Interval = 9000
        '
        'sendDelay
        '
        Me.sendDelay.Interval = 800
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'frmCommunityHub
        '
        Me.frmCommunityHub.ActiveLinkColor = System.Drawing.Color.Silver
        Me.frmCommunityHub.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.frmCommunityHub.AutoSize = True
        Me.frmCommunityHub.BackColor = System.Drawing.Color.Transparent
        Me.frmCommunityHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmCommunityHub.LinkColor = System.Drawing.Color.DarkGray
        Me.frmCommunityHub.Location = New System.Drawing.Point(308, 649)
        Me.frmCommunityHub.Name = "frmCommunityHub"
        Me.frmCommunityHub.Size = New System.Drawing.Size(122, 20)
        Me.frmCommunityHub.TabIndex = 20
        Me.frmCommunityHub.TabStop = True
        Me.frmCommunityHub.Text = "Community Hub"
        Me.frmCommunityHub.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.Color.Silver
        Me.btnQuit.Location = New System.Drawing.Point(1232, 649)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(52, 23)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "QUIT"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(20, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(328, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "0 hours - total"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(20, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(328, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "0 hours - past two weeks"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(20, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "0 minutes - current session"
        '
        'GameTitle
        '
        Me.GameTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameTitle.BackColor = System.Drawing.Color.Transparent
        Me.GameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameTitle.ForeColor = System.Drawing.Color.Silver
        Me.GameTitle.Location = New System.Drawing.Point(752, 0)
        Me.GameTitle.Name = "GameTitle"
        Me.GameTitle.Size = New System.Drawing.Size(518, 43)
        Me.GameTitle.TabIndex = 13
        Me.GameTitle.Text = "Game Title"
        Me.GameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateStamp
        '
        Me.DateStamp.BackColor = System.Drawing.Color.Transparent
        Me.DateStamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateStamp.ForeColor = System.Drawing.Color.Silver
        Me.DateStamp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DateStamp.Location = New System.Drawing.Point(20, 9)
        Me.DateStamp.Name = "DateStamp"
        Me.DateStamp.Size = New System.Drawing.Size(328, 34)
        Me.DateStamp.TabIndex = 14
        Me.DateStamp.Text = "Wednesday, December 31, 9999"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(540, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "SHIFT+TAB  also closes the overlay"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lnkReturn
        '
        Me.lnkReturn.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.lnkReturn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnkReturn.BackColor = System.Drawing.Color.Transparent
        Me.lnkReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkReturn.ForeColor = System.Drawing.Color.Silver
        Me.lnkReturn.LinkColor = System.Drawing.Color.Silver
        Me.lnkReturn.Location = New System.Drawing.Point(541, 26)
        Me.lnkReturn.Name = "lnkReturn"
        Me.lnkReturn.Size = New System.Drawing.Size(198, 19)
        Me.lnkReturn.TabIndex = 12
        Me.lnkReturn.TabStop = True
        Me.lnkReturn.Text = "Click here to close Peanut"
        Me.lnkReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lnkReturn.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(542, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Peanut Overlay"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pMainPanel
        '
        Me.pMainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMainPanel.BackColor = System.Drawing.Color.Transparent
        Me.pMainPanel.BackgroundImage = Global.Forza_Horizon_3_Steam_Edition.My.Resources.Resources.coconut2
        Me.pMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pMainPanel.Controls.Add(Me.btnQuit)
        Me.pMainPanel.Controls.Add(Me.LinkLabel3)
        Me.pMainPanel.Controls.Add(Me.lnkAccountDetails)
        Me.pMainPanel.Controls.Add(Me.LinkLabel2)
        Me.pMainPanel.Controls.Add(Me.LinkLabel1)
        Me.pMainPanel.Controls.Add(Me.frmCommunityHub)
        Me.pMainPanel.Controls.Add(Me.DateStamp)
        Me.pMainPanel.Controls.Add(Me.Label5)
        Me.pMainPanel.Controls.Add(Me.GameTitle)
        Me.pMainPanel.Controls.Add(Me.Label4)
        Me.pMainPanel.Controls.Add(Me.Label3)
        Me.pMainPanel.Controls.Add(Me.Label2)
        Me.pMainPanel.Controls.Add(Me.lnkReturn)
        Me.pMainPanel.Controls.Add(Me.Label1)
        Me.pMainPanel.Controls.Add(Me.PictureBox1)
        Me.pMainPanel.Location = New System.Drawing.Point(12, 12)
        Me.pMainPanel.Name = "pMainPanel"
        Me.pMainPanel.Size = New System.Drawing.Size(1289, 677)
        Me.pMainPanel.TabIndex = 23
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(883, 649)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(68, 20)
        Me.LinkLabel3.TabIndex = 24
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Settings"
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'lnkAccountDetails
        '
        Me.lnkAccountDetails.ActiveLinkColor = System.Drawing.Color.Silver
        Me.lnkAccountDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lnkAccountDetails.AutoSize = True
        Me.lnkAccountDetails.BackColor = System.Drawing.Color.Transparent
        Me.lnkAccountDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAccountDetails.LinkColor = System.Drawing.Color.DarkGray
        Me.lnkAccountDetails.Location = New System.Drawing.Point(761, 649)
        Me.lnkAccountDetails.Name = "lnkAccountDetails"
        Me.lnkAccountDetails.Size = New System.Drawing.Size(53, 20)
        Me.lnkAccountDetails.TabIndex = 23
        Me.lnkAccountDetails.TabStop = True
        Me.lnkAccountDetails.Text = "Profile"
        Me.lnkAccountDetails.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel2.Location = New System.Drawing.Point(631, 649)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(58, 20)
        Me.LinkLabel2.TabIndex = 22
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Market"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Silver
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel1.Location = New System.Drawing.Point(490, 649)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(62, 20)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Friends"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Forza_Horizon_3_Steam_Edition.My.Resources.Resources.Forzaas
        Me.PictureBox1.Location = New System.Drawing.Point(1127, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker2
        '
        '
        'BackgroundWorker_LoadChat
        '
        Me.BackgroundWorker_LoadChat.WorkerReportsProgress = True
        '
        'SteamOverlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Forza_Horizon_3_Steam_Edition.My.Resources.Resources.PEANUTBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1313, 701)
        Me.Controls.Add(Me.pMainPanel)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SteamOverlay"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SteamOverlay"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pMainPanel.ResumeLayout(False)
        Me.pMainPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Overlay As System.ComponentModel.BackgroundWorker
    Friend WithEvents clock As Timer
    Friend WithEvents shiftTabListener As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents gameRunningTimer As Timer
    Friend WithEvents sendDelay As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents frmCommunityHub As LinkLabel
    Friend WithEvents btnQuit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GameTitle As Label
    Friend WithEvents DateStamp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lnkReturn As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents pMainPanel As Panel
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lnkAccountDetails As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker_LoadChat As System.ComponentModel.BackgroundWorker
End Class
