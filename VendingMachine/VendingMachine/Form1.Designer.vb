﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Productcontrol17 = New VendingMachine.productcontrol()
        Me.Productcontrol16 = New VendingMachine.productcontrol()
        Me.Productcontrol15 = New VendingMachine.productcontrol()
        Me.Productcontrol14 = New VendingMachine.productcontrol()
        Me.Productcontrol13 = New VendingMachine.productcontrol()
        Me.Productcontrol12 = New VendingMachine.productcontrol()
        Me.Productcontrol11 = New VendingMachine.productcontrol()
        Me.Productcontrol10 = New VendingMachine.productcontrol()
        Me.Productcontrol9 = New VendingMachine.productcontrol()
        Me.Productcontrol8 = New VendingMachine.productcontrol()
        Me.Productcontrol7 = New VendingMachine.productcontrol()
        Me.Productcontrol6 = New VendingMachine.productcontrol()
        Me.Productcontrol5 = New VendingMachine.productcontrol()
        Me.Productcontrol4 = New VendingMachine.productcontrol()
        Me.Productcontrol2 = New VendingMachine.productcontrol()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        Me.Productcontrol1 = New VendingMachine.productcontrol()
        Me.dimepb = New System.Windows.Forms.PictureBox()
        Me.nickelpb = New System.Windows.Forms.PictureBox()
        Me.quarterpb = New System.Windows.Forms.PictureBox()
        Me.dollarpb = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(535, 497)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(502, 446)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 45)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(551, 565)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(551, 538)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 13
        '
        'Productcontrol17
        '
        Me.Productcontrol17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol17.Location = New System.Drawing.Point(692, 355)
        Me.Productcontrol17.Name = "Productcontrol17"
        Me.Productcontrol17.productcount = 14
        Me.Productcontrol17.productid = "C2"
        Me.Productcontrol17.productpicture = Global.VendingMachine.My.Resources.Resources.twix
        Me.Productcontrol17.productprice = New Decimal(New Integer() {45, 0, 0, 131072})
        Me.Productcontrol17.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol17.TabIndex = 29
        '
        'Productcontrol16
        '
        Me.Productcontrol16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol16.Location = New System.Drawing.Point(302, 355)
        Me.Productcontrol16.Name = "Productcontrol16"
        Me.Productcontrol16.productcount = 13
        Me.Productcontrol16.productid = "C1"
        Me.Productcontrol16.productpicture = Global.VendingMachine.My.Resources.Resources.milky_way
        Me.Productcontrol16.productprice = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.Productcontrol16.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol16.TabIndex = 28
        '
        'Productcontrol15
        '
        Me.Productcontrol15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol15.Location = New System.Drawing.Point(3, 241)
        Me.Productcontrol15.Name = "Productcontrol15"
        Me.Productcontrol15.productcount = 8
        Me.Productcontrol15.productid = "B1"
        Me.Productcontrol15.productpicture = Global.VendingMachine.My.Resources.Resources.pepsi
        Me.Productcontrol15.productprice = New Decimal(New Integer() {80, 0, 0, 131072})
        Me.Productcontrol15.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol15.TabIndex = 27
        '
        'Productcontrol14
        '
        Me.Productcontrol14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol14.Location = New System.Drawing.Point(114, 241)
        Me.Productcontrol14.Name = "Productcontrol14"
        Me.Productcontrol14.productcount = 7
        Me.Productcontrol14.productid = "B2"
        Me.Productcontrol14.productpicture = Global.VendingMachine.My.Resources.Resources.coca_cola
        Me.Productcontrol14.productprice = New Decimal(New Integer() {85, 0, 0, 131072})
        Me.Productcontrol14.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol14.TabIndex = 26
        '
        'Productcontrol13
        '
        Me.Productcontrol13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol13.Location = New System.Drawing.Point(967, 241)
        Me.Productcontrol13.Name = "Productcontrol13"
        Me.Productcontrol13.productcount = 8
        Me.Productcontrol13.productid = "B10"
        Me.Productcontrol13.productpicture = Global.VendingMachine.My.Resources.Resources.mr_pibb
        Me.Productcontrol13.productprice = New Decimal(New Integer() {65, 0, 0, 131072})
        Me.Productcontrol13.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol13.TabIndex = 25
        '
        'Productcontrol12
        '
        Me.Productcontrol12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol12.Location = New System.Drawing.Point(864, 241)
        Me.Productcontrol12.Name = "Productcontrol12"
        Me.Productcontrol12.productcount = 9
        Me.Productcontrol12.productid = "B9"
        Me.Productcontrol12.productpicture = Global.VendingMachine.My.Resources.Resources._7up
        Me.Productcontrol12.productprice = New Decimal(New Integer() {70, 0, 0, 131072})
        Me.Productcontrol12.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol12.TabIndex = 24
        '
        'Productcontrol11
        '
        Me.Productcontrol11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol11.Location = New System.Drawing.Point(758, 241)
        Me.Productcontrol11.Name = "Productcontrol11"
        Me.Productcontrol11.productcount = 5
        Me.Productcontrol11.productid = "B8"
        Me.Productcontrol11.productpicture = Global.VendingMachine.My.Resources.Resources.monster_energy
        Me.Productcontrol11.productprice = New Decimal(New Integer() {85, 0, 0, 131072})
        Me.Productcontrol11.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol11.TabIndex = 23
        '
        'Productcontrol10
        '
        Me.Productcontrol10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol10.Location = New System.Drawing.Point(652, 241)
        Me.Productcontrol10.Name = "Productcontrol10"
        Me.Productcontrol10.productcount = 9
        Me.Productcontrol10.productid = "B7"
        Me.Productcontrol10.productpicture = Global.VendingMachine.My.Resources.Resources.root_beer
        Me.Productcontrol10.productprice = New Decimal(New Integer() {75, 0, 0, 131072})
        Me.Productcontrol10.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol10.TabIndex = 22
        '
        'Productcontrol9
        '
        Me.Productcontrol9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol9.Location = New System.Drawing.Point(545, 241)
        Me.Productcontrol9.Name = "Productcontrol9"
        Me.Productcontrol9.productcount = 13
        Me.Productcontrol9.productid = "B6"
        Me.Productcontrol9.productpicture = Global.VendingMachine.My.Resources.Resources.sprite
        Me.Productcontrol9.productprice = New Decimal(New Integer() {80, 0, 0, 131072})
        Me.Productcontrol9.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol9.TabIndex = 21
        '
        'Productcontrol8
        '
        Me.Productcontrol8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol8.Location = New System.Drawing.Point(436, 241)
        Me.Productcontrol8.Name = "Productcontrol8"
        Me.Productcontrol8.productcount = 8
        Me.Productcontrol8.productid = "B5"
        Me.Productcontrol8.productpicture = Global.VendingMachine.My.Resources.Resources.mountain_dew
        Me.Productcontrol8.productprice = New Decimal(New Integer() {90, 0, 0, 131072})
        Me.Productcontrol8.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol8.TabIndex = 20
        '
        'Productcontrol7
        '
        Me.Productcontrol7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol7.Location = New System.Drawing.Point(328, 241)
        Me.Productcontrol7.Name = "Productcontrol7"
        Me.Productcontrol7.productcount = 11
        Me.Productcontrol7.productid = "B4"
        Me.Productcontrol7.productpicture = Global.VendingMachine.My.Resources.Resources.fanta
        Me.Productcontrol7.productprice = New Decimal(New Integer() {95, 0, 0, 131072})
        Me.Productcontrol7.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol7.TabIndex = 19
        '
        'Productcontrol6
        '
        Me.Productcontrol6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol6.Location = New System.Drawing.Point(219, 241)
        Me.Productcontrol6.Name = "Productcontrol6"
        Me.Productcontrol6.productcount = 9
        Me.Productcontrol6.productid = "B3"
        Me.Productcontrol6.productpicture = Global.VendingMachine.My.Resources.Resources.dr_pepper
        Me.Productcontrol6.productprice = New Decimal(New Integer() {90, 0, 0, 131072})
        Me.Productcontrol6.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol6.TabIndex = 18
        '
        'Productcontrol5
        '
        Me.Productcontrol5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol5.Location = New System.Drawing.Point(745, 128)
        Me.Productcontrol5.Name = "Productcontrol5"
        Me.Productcontrol5.productcount = 5
        Me.Productcontrol5.productid = "A4"
        Me.Productcontrol5.productpicture = Global.VendingMachine.My.Resources.Resources.funyuns
        Me.Productcontrol5.productprice = New Decimal(New Integer() {160, 0, 0, 131072})
        Me.Productcontrol5.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol5.TabIndex = 17
        '
        'Productcontrol4
        '
        Me.Productcontrol4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol4.Location = New System.Drawing.Point(588, 128)
        Me.Productcontrol4.Name = "Productcontrol4"
        Me.Productcontrol4.productcount = 4
        Me.Productcontrol4.productid = "A3"
        Me.Productcontrol4.productpicture = CType(resources.GetObject("Productcontrol4.productpicture"), System.Drawing.Image)
        Me.Productcontrol4.productprice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Productcontrol4.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol4.TabIndex = 16
        '
        'Productcontrol2
        '
        Me.Productcontrol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol2.Location = New System.Drawing.Point(436, 128)
        Me.Productcontrol2.Name = "Productcontrol2"
        Me.Productcontrol2.productcount = 3
        Me.Productcontrol2.productid = "A2"
        Me.Productcontrol2.productpicture = CType(resources.GetObject("Productcontrol2.productpicture"), System.Drawing.Image)
        Me.Productcontrol2.productprice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Productcontrol2.Size = New System.Drawing.Size(105, 92)
        Me.Productcontrol2.TabIndex = 14
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.Location = New System.Drawing.Point(441, 516)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(100, 89)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPictureBox.TabIndex = 11
        Me.ProductPictureBox.TabStop = False
        '
        'Productcontrol1
        '
        Me.Productcontrol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Productcontrol1.Location = New System.Drawing.Point(271, 127)
        Me.Productcontrol1.Name = "Productcontrol1"
        Me.Productcontrol1.productcount = 5
        Me.Productcontrol1.productid = "A1"
        Me.Productcontrol1.productpicture = CType(resources.GetObject("Productcontrol1.productpicture"), System.Drawing.Image)
        Me.Productcontrol1.productprice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol1.Size = New System.Drawing.Size(100, 93)
        Me.Productcontrol1.TabIndex = 10
        '
        'dimepb
        '
        Me.dimepb.Image = CType(resources.GetObject("dimepb.Image"), System.Drawing.Image)
        Me.dimepb.Location = New System.Drawing.Point(258, 518)
        Me.dimepb.Name = "dimepb"
        Me.dimepb.Size = New System.Drawing.Size(149, 84)
        Me.dimepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dimepb.TabIndex = 9
        Me.dimepb.TabStop = False
        '
        'nickelpb
        '
        Me.nickelpb.Image = CType(resources.GetObject("nickelpb.Image"), System.Drawing.Image)
        Me.nickelpb.Location = New System.Drawing.Point(692, 518)
        Me.nickelpb.Name = "nickelpb"
        Me.nickelpb.Size = New System.Drawing.Size(149, 84)
        Me.nickelpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nickelpb.TabIndex = 8
        Me.nickelpb.TabStop = False
        '
        'quarterpb
        '
        Me.quarterpb.Image = CType(resources.GetObject("quarterpb.Image"), System.Drawing.Image)
        Me.quarterpb.Location = New System.Drawing.Point(720, -4)
        Me.quarterpb.Name = "quarterpb"
        Me.quarterpb.Size = New System.Drawing.Size(149, 84)
        Me.quarterpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.quarterpb.TabIndex = 7
        Me.quarterpb.TabStop = False
        '
        'dollarpb
        '
        Me.dollarpb.Image = CType(resources.GetObject("dollarpb.Image"), System.Drawing.Image)
        Me.dollarpb.Location = New System.Drawing.Point(258, -1)
        Me.dollarpb.Name = "dollarpb"
        Me.dollarpb.Size = New System.Drawing.Size(149, 84)
        Me.dollarpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dollarpb.TabIndex = 6
        Me.dollarpb.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(831, 382)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(230, 220)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Nickels"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(2, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(263, 220)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(856, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 197)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Quarters"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(2, -4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(263, 200)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dollars"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 624)
        Me.Controls.Add(Me.Productcontrol17)
        Me.Controls.Add(Me.Productcontrol16)
        Me.Controls.Add(Me.Productcontrol15)
        Me.Controls.Add(Me.Productcontrol14)
        Me.Controls.Add(Me.Productcontrol13)
        Me.Controls.Add(Me.Productcontrol12)
        Me.Controls.Add(Me.Productcontrol11)
        Me.Controls.Add(Me.Productcontrol10)
        Me.Controls.Add(Me.Productcontrol9)
        Me.Controls.Add(Me.Productcontrol8)
        Me.Controls.Add(Me.Productcontrol7)
        Me.Controls.Add(Me.Productcontrol6)
        Me.Controls.Add(Me.Productcontrol5)
        Me.Controls.Add(Me.Productcontrol4)
        Me.Controls.Add(Me.Productcontrol2)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ProductPictureBox)
        Me.Controls.Add(Me.Productcontrol1)
        Me.Controls.Add(Me.dimepb)
        Me.Controls.Add(Me.nickelpb)
        Me.Controls.Add(Me.quarterpb)
        Me.Controls.Add(Me.dollarpb)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents dollarpb As PictureBox
    Friend WithEvents quarterpb As PictureBox
    Friend WithEvents nickelpb As PictureBox
    Friend WithEvents dimepb As PictureBox
    Friend WithEvents Productcontrol1 As productcontrol
    Friend WithEvents ProductPictureBox As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Productcontrol2 As productcontrol
    Friend WithEvents Productcontrol4 As productcontrol
    Friend WithEvents Productcontrol5 As productcontrol
    Friend WithEvents Productcontrol6 As productcontrol
    Friend WithEvents Productcontrol7 As productcontrol
    Friend WithEvents Productcontrol8 As productcontrol
    Friend WithEvents Productcontrol9 As productcontrol
    Friend WithEvents Productcontrol10 As productcontrol
    Friend WithEvents Productcontrol11 As productcontrol
    Friend WithEvents Productcontrol12 As productcontrol
    Friend WithEvents Productcontrol13 As productcontrol
    Friend WithEvents Productcontrol14 As productcontrol
    Friend WithEvents Productcontrol15 As productcontrol
    Friend WithEvents Productcontrol16 As productcontrol
    Friend WithEvents Productcontrol17 As productcontrol
End Class
