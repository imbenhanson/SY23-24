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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scorelabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Mover1 = New Platformer2.mover()
        Me.Mover2 = New Platformer2.mover()
        Me.Mover3 = New Platformer2.mover()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.picPlayer.BackgroundImage = CType(resources.GetObject("picPlayer.BackgroundImage"), System.Drawing.Image)
        Me.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayer.Location = New System.Drawing.Point(45, 425)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(62, 49)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picAir
        '
        Me.picAir.BackColor = System.Drawing.SystemColors.Highlight
        Me.picAir.BackgroundImage = CType(resources.GetObject("picAir.BackgroundImage"), System.Drawing.Image)
        Me.picAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAir.Location = New System.Drawing.Point(-4, -1)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(1116, 489)
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        Me.picAir.Tag = ""
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Green
        Me.picGround.BackgroundImage = CType(resources.GetObject("picGround.BackgroundImage"), System.Drawing.Image)
        Me.picGround.Location = New System.Drawing.Point(-4, 480)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(1116, 139)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 20
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 20
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 20
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.PictureBox1.Location = New System.Drawing.Point(493, 287)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.MenuText
        Me.PictureBox2.Location = New System.Drawing.Point(261, 370)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Desktop
        Me.PictureBox3.Location = New System.Drawing.Point(821, 230)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Red
        Me.PictureBox4.Location = New System.Drawing.Point(316, 332)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(21, 62)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "restart"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Red
        Me.PictureBox5.Location = New System.Drawing.Point(819, 188)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(110, 52)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "restart"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox6.Location = New System.Drawing.Point(803, 128)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(51, 42)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "coin"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox7.Location = New System.Drawing.Point(435, 280)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(51, 42)
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "coin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Points:"
        '
        'scorelabel
        '
        Me.scorelabel.AutoSize = True
        Me.scorelabel.Location = New System.Drawing.Point(135, 46)
        Me.scorelabel.Name = "scorelabel"
        Me.scorelabel.Size = New System.Drawing.Size(53, 20)
        Me.scorelabel.TabIndex = 12
        Me.scorelabel.Text = "Label2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(927, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 13
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.BackgroundImage = CType(resources.GetObject("Mover1.BackgroundImage"), System.Drawing.Image)
        Me.Mover1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(135, 230)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(294, 72)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox7
        Me.Mover1.TabIndex = 14
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.BackgroundImage = CType(resources.GetObject("Mover2.BackgroundImage"), System.Drawing.Image)
        Me.Mover2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(543, 138)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(294, 26)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.PictureBox6
        Me.Mover2.TabIndex = 15
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.BackgroundImage = CType(resources.GetObject("Mover3.BackgroundImage"), System.Drawing.Image)
        Me.Mover3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(559, 198)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(294, 26)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox5
        Me.Mover3.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1113, 579)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.scorelabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.picAir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents scorelabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents Mover2 As mover
    Friend WithEvents Mover3 As mover
End Class
