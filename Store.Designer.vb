<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Store
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Store))
        MenuStrip1 = New MenuStrip()
        MenuTool2 = New ToolStripMenuItem()
        ContinueToolStripMenuItem = New ToolStripMenuItem()
        ExitMenu2 = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        BTNDownload = New Button()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        GroupBox2 = New GroupBox()
        BTNDownload2 = New Button()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuTool2})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(661, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuTool2
        ' 
        MenuTool2.DropDownItems.AddRange(New ToolStripItem() {ContinueToolStripMenuItem, ExitMenu2})
        MenuTool2.Name = "MenuTool2"
        MenuTool2.Size = New Size(50, 20)
        MenuTool2.Text = "Menu"
        ' 
        ' ContinueToolStripMenuItem
        ' 
        ContinueToolStripMenuItem.Name = "ContinueToolStripMenuItem"
        ContinueToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        ContinueToolStripMenuItem.Size = New Size(203, 22)
        ContinueToolStripMenuItem.Text = "&Continue Game"
        ' 
        ' ExitMenu2
        ' 
        ExitMenu2.Name = "ExitMenu2"
        ExitMenu2.ShortcutKeys = Keys.Control Or Keys.Alt Or Keys.Q
        ExitMenu2.Size = New Size(203, 22)
        ExitMenu2.Text = "&Exit"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(BTNDownload)
        GroupBox1.Controls.Add(PictureBox3)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(12, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(637, 177)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' BTNDownload
        ' 
        BTNDownload.BackColor = Color.Lime
        BTNDownload.Location = New Point(478, 136)
        BTNDownload.Name = "BTNDownload"
        BTNDownload.Size = New Size(153, 35)
        BTNDownload.TabIndex = 4
        BTNDownload.Text = "Free Download"
        BTNDownload.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(165, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(466, 160)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(11, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(148, 143)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(BTNDownload2)
        GroupBox2.Controls.Add(PictureBox4)
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Location = New Point(12, 210)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(637, 177)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        ' 
        ' BTNDownload2
        ' 
        BTNDownload2.BackColor = Color.Lime
        BTNDownload2.Location = New Point(478, 136)
        BTNDownload2.Name = "BTNDownload2"
        BTNDownload2.Size = New Size(153, 35)
        BTNDownload2.TabIndex = 5
        BTNDownload2.Text = "Free Download"
        BTNDownload2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(165, 13)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(466, 158)
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(11, 22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(148, 143)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Store
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(661, 398)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Store"
        Text = "Store"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuTool2 As ToolStripMenuItem
    Friend WithEvents ContinueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenu2 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTNDownload As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNDownload2 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
