<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GameScreen = New PictureBox()
        ButtonLayout = New PictureBox()
        LRShoulder = New PictureBox()
        MenuStrip1 = New MenuStrip()
        MenuTool1 = New ToolStripMenuItem()
        StoreToolStripMenuItem = New ToolStripMenuItem()
        ExitMenu1 = New ToolStripMenuItem()
        BTNa = New Button()
        BTNb = New Button()
        BTNSelect = New Button()
        BTNStart = New Button()
        BTNUp = New Button()
        BTNRight = New Button()
        BTNDown = New Button()
        BTNLeft = New Button()
        BTNLeftSh = New Button()
        BTNRightSh = New Button()
        CType(GameScreen, ComponentModel.ISupportInitialize).BeginInit()
        CType(ButtonLayout, ComponentModel.ISupportInitialize).BeginInit()
        CType(LRShoulder, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GameScreen
        ' 
        GameScreen.BackgroundImage = CType(resources.GetObject("GameScreen.BackgroundImage"), Image)
        GameScreen.Location = New Point(19, 46)
        GameScreen.Name = "GameScreen"
        GameScreen.Size = New Size(301, 169)
        GameScreen.TabIndex = 0
        GameScreen.TabStop = False
        ' 
        ' ButtonLayout
        ' 
        ButtonLayout.BackgroundImage = CType(resources.GetObject("ButtonLayout.BackgroundImage"), Image)
        ButtonLayout.Location = New Point(12, 265)
        ButtonLayout.Name = "ButtonLayout"
        ButtonLayout.Size = New Size(315, 294)
        ButtonLayout.TabIndex = 1
        ButtonLayout.TabStop = False
        ' 
        ' LRShoulder
        ' 
        LRShoulder.BackgroundImage = CType(resources.GetObject("LRShoulder.BackgroundImage"), Image)
        LRShoulder.Location = New Point(12, 221)
        LRShoulder.Name = "LRShoulder"
        LRShoulder.Size = New Size(314, 35)
        LRShoulder.TabIndex = 2
        LRShoulder.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuTool1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(338, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuTool1
        ' 
        MenuTool1.DropDownItems.AddRange(New ToolStripItem() {StoreToolStripMenuItem, ExitMenu1})
        MenuTool1.Name = "MenuTool1"
        MenuTool1.Size = New Size(50, 20)
        MenuTool1.Text = "Menu"
        ' 
        ' StoreToolStripMenuItem
        ' 
        StoreToolStripMenuItem.Name = "StoreToolStripMenuItem"
        StoreToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        StoreToolStripMenuItem.Size = New Size(180, 22)
        StoreToolStripMenuItem.Text = "&Store"
        ' 
        ' ExitMenu1
        ' 
        ExitMenu1.Name = "ExitMenu1"
        ExitMenu1.ShortcutKeys = Keys.Control Or Keys.Alt Or Keys.Q
        ExitMenu1.Size = New Size(180, 22)
        ExitMenu1.Text = "&Exit"
        ' 
        ' BTNa
        ' 
        BTNa.BackColor = Color.Transparent
        BTNa.Image = CType(resources.GetObject("BTNa.Image"), Image)
        BTNa.Location = New Point(257, 326)
        BTNa.Name = "BTNa"
        BTNa.Size = New Size(48, 49)
        BTNa.TabIndex = 4
        BTNa.UseVisualStyleBackColor = False
        ' 
        ' BTNb
        ' 
        BTNb.BackColor = Color.Transparent
        BTNb.BackgroundImage = CType(resources.GetObject("BTNb.BackgroundImage"), Image)
        BTNb.Location = New Point(201, 346)
        BTNb.Name = "BTNb"
        BTNb.Size = New Size(48, 49)
        BTNb.TabIndex = 5
        BTNb.UseVisualStyleBackColor = False
        ' 
        ' BTNSelect
        ' 
        BTNSelect.BackgroundImage = CType(resources.GetObject("BTNSelect.BackgroundImage"), Image)
        BTNSelect.BackgroundImageLayout = ImageLayout.Stretch
        BTNSelect.Location = New Point(117, 497)
        BTNSelect.Name = "BTNSelect"
        BTNSelect.Size = New Size(43, 40)
        BTNSelect.TabIndex = 6
        BTNSelect.UseVisualStyleBackColor = True
        ' 
        ' BTNStart
        ' 
        BTNStart.BackgroundImage = CType(resources.GetObject("BTNStart.BackgroundImage"), Image)
        BTNStart.BackgroundImageLayout = ImageLayout.Stretch
        BTNStart.Location = New Point(178, 497)
        BTNStart.Name = "BTNStart"
        BTNStart.Size = New Size(43, 40)
        BTNStart.TabIndex = 7
        BTNStart.UseVisualStyleBackColor = True
        ' 
        ' BTNUp
        ' 
        BTNUp.BackgroundImage = CType(resources.GetObject("BTNUp.BackgroundImage"), Image)
        BTNUp.BackgroundImageLayout = ImageLayout.Stretch
        BTNUp.Location = New Point(67, 316)
        BTNUp.Name = "BTNUp"
        BTNUp.Size = New Size(30, 29)
        BTNUp.TabIndex = 8
        BTNUp.UseVisualStyleBackColor = True
        ' 
        ' BTNRight
        ' 
        BTNRight.BackgroundImage = CType(resources.GetObject("BTNRight.BackgroundImage"), Image)
        BTNRight.BackgroundImageLayout = ImageLayout.Center
        BTNRight.Location = New Point(96, 346)
        BTNRight.Name = "BTNRight"
        BTNRight.Size = New Size(30, 29)
        BTNRight.TabIndex = 9
        BTNRight.UseVisualStyleBackColor = True
        ' 
        ' BTNDown
        ' 
        BTNDown.BackgroundImage = CType(resources.GetObject("BTNDown.BackgroundImage"), Image)
        BTNDown.Location = New Point(67, 376)
        BTNDown.Name = "BTNDown"
        BTNDown.Size = New Size(30, 29)
        BTNDown.TabIndex = 10
        BTNDown.UseVisualStyleBackColor = True
        ' 
        ' BTNLeft
        ' 
        BTNLeft.BackgroundImage = CType(resources.GetObject("BTNLeft.BackgroundImage"), Image)
        BTNLeft.BackgroundImageLayout = ImageLayout.Center
        BTNLeft.Location = New Point(38, 346)
        BTNLeft.Name = "BTNLeft"
        BTNLeft.Size = New Size(30, 29)
        BTNLeft.TabIndex = 11
        BTNLeft.UseVisualStyleBackColor = True
        ' 
        ' BTNLeftSh
        ' 
        BTNLeftSh.BackgroundImage = CType(resources.GetObject("BTNLeftSh.BackgroundImage"), Image)
        BTNLeftSh.Location = New Point(12, 221)
        BTNLeftSh.Name = "BTNLeftSh"
        BTNLeftSh.Size = New Size(66, 35)
        BTNLeftSh.TabIndex = 12
        BTNLeftSh.Text = "LT"
        BTNLeftSh.UseVisualStyleBackColor = True
        ' 
        ' BTNRightSh
        ' 
        BTNRightSh.BackgroundImage = CType(resources.GetObject("BTNRightSh.BackgroundImage"), Image)
        BTNRightSh.Location = New Point(260, 221)
        BTNRightSh.Name = "BTNRightSh"
        BTNRightSh.Size = New Size(66, 35)
        BTNRightSh.TabIndex = 13
        BTNRightSh.Text = "RT"
        BTNRightSh.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(338, 563)
        Controls.Add(BTNRightSh)
        Controls.Add(BTNLeftSh)
        Controls.Add(BTNLeft)
        Controls.Add(BTNDown)
        Controls.Add(BTNRight)
        Controls.Add(BTNUp)
        Controls.Add(BTNStart)
        Controls.Add(BTNSelect)
        Controls.Add(BTNb)
        Controls.Add(BTNa)
        Controls.Add(LRShoulder)
        Controls.Add(ButtonLayout)
        Controls.Add(GameScreen)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "The Legend of Zelda: The Minish Cap"
        CType(GameScreen, ComponentModel.ISupportInitialize).EndInit()
        CType(ButtonLayout, ComponentModel.ISupportInitialize).EndInit()
        CType(LRShoulder, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GameScreen As PictureBox
    Friend WithEvents ButtonLayout As PictureBox
    Friend WithEvents LRShoulder As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuTool1 As ToolStripMenuItem
    Friend WithEvents StoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenu1 As ToolStripMenuItem
    Friend WithEvents BTNa As Button
    Friend WithEvents BTNb As Button
    Friend WithEvents BTNSelect As Button
    Friend WithEvents BTNStart As Button
    Friend WithEvents BTNUp As Button
    Friend WithEvents BTNRight As Button
    Friend WithEvents BTNDown As Button
    Friend WithEvents BTNLeft As Button
    Friend WithEvents BTNLeftSh As Button
    Friend WithEvents BTNRightSh As Button
End Class
