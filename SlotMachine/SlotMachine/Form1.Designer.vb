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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Reelcontrol23 = New SlotMachine.reelcontrol2()
        Me.Reelcontrol22 = New SlotMachine.reelcontrol2()
        Me.Reelcontrol21 = New SlotMachine.reelcontrol2()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Pristina", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(658, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 90)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "beaker2.jpg")
        Me.ImageList1.Images.SetKeyName(1, "fozzie.jpeg")
        Me.ImageList1.Images.SetKeyName(2, "gonzo.jpg")
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(469, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(804, 471)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(-3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 121)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Dollars"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(-3, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 115)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Quarters"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(-3, 237)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 118)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Dimes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(-3, 354)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 102)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Nickel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Label4"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(226, 397)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 44)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Coin Return"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Reelcontrol23
        '
        Me.Reelcontrol23.itemValue = 0
        Me.Reelcontrol23.Location = New System.Drawing.Point(454, 182)
        Me.Reelcontrol23.Name = "Reelcontrol23"
        Me.Reelcontrol23.Size = New System.Drawing.Size(116, 109)
        Me.Reelcontrol23.spinTime = 2000
        Me.Reelcontrol23.TabIndex = 4
        '
        'Reelcontrol22
        '
        Me.Reelcontrol22.itemValue = 0
        Me.Reelcontrol22.Location = New System.Drawing.Point(331, 182)
        Me.Reelcontrol22.Name = "Reelcontrol22"
        Me.Reelcontrol22.Size = New System.Drawing.Size(117, 109)
        Me.Reelcontrol22.spinTime = 2000
        Me.Reelcontrol22.TabIndex = 3
        '
        'Reelcontrol21
        '
        Me.Reelcontrol21.itemValue = 0
        Me.Reelcontrol21.Location = New System.Drawing.Point(205, 182)
        Me.Reelcontrol21.Name = "Reelcontrol21"
        Me.Reelcontrol21.Size = New System.Drawing.Size(120, 109)
        Me.Reelcontrol21.spinTime = 2000
        Me.Reelcontrol21.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Reelcontrol23)
        Me.Controls.Add(Me.Reelcontrol22)
        Me.Controls.Add(Me.Reelcontrol21)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Reelcontrol21 As reelcontrol2
    Friend WithEvents Reelcontrol22 As reelcontrol2
    Friend WithEvents Reelcontrol23 As reelcontrol2
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button6 As Button
End Class
