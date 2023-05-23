<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZeldaWelcome
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
    Friend WithEvents OpeningZelda As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ZeldaWelcome))
        OpeningZelda = New TableLayoutPanel()
        DetailsLayoutPanel = New TableLayoutPanel()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        OpeningZelda.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpeningZelda
        ' 
        OpeningZelda.BackgroundImage = CType(resources.GetObject("OpeningZelda.BackgroundImage"), Image)
        OpeningZelda.BackgroundImageLayout = ImageLayout.Stretch
        OpeningZelda.ColumnCount = 3
        OpeningZelda.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 102F))
        OpeningZelda.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 281F))
        OpeningZelda.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 8F))
        OpeningZelda.Controls.Add(DetailsLayoutPanel, 1, 1)
        OpeningZelda.Dock = DockStyle.Fill
        OpeningZelda.Location = New Point(0, 0)
        OpeningZelda.Name = "OpeningZelda"
        OpeningZelda.RowStyles.Add(New RowStyle(SizeType.Absolute, 218F))
        OpeningZelda.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        OpeningZelda.Size = New Size(496, 303)
        OpeningZelda.TabIndex = 0
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.Controls.Add(ProgressBar1, 0, 0)
        DetailsLayoutPanel.Location = New Point(105, 238)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowCount = 1
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.Size = New Size(275, 45)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.Lime
        ProgressBar1.Location = New Point(3, 3)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(269, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' ZeldaWelcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 303)
        ControlBox = False
        Controls.Add(OpeningZelda)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "ZeldaWelcome"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        OpeningZelda.ResumeLayout(False)
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
