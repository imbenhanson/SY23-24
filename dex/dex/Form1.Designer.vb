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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.McDonaldsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StarbucksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubwayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TacoBellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChickFilAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WendysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BurgerKingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DominosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PizzaHutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.field1 = New System.Windows.Forms.TextBox()
        Me.field2 = New System.Windows.Forms.TextBox()
        Me.field3 = New System.Windows.Forms.TextBox()
        Me.field4 = New System.Windows.Forms.TextBox()
        Me.field5 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.firstbutton = New System.Windows.Forms.Button()
        Me.prevbutton = New System.Windows.Forms.Button()
        Me.nextbutton = New System.Windows.Forms.Button()
        Me.lastbutton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(441, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Annual Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "# of Locations"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "# of Employees"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "# of Countries"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Income per Location"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.McDonaldsToolStripMenuItem, Me.StarbucksToolStripMenuItem, Me.SubwayToolStripMenuItem, Me.TacoBellToolStripMenuItem, Me.ChickFilAToolStripMenuItem, Me.WendysToolStripMenuItem, Me.BurgerKingToolStripMenuItem, Me.DominosToolStripMenuItem, Me.ToolStripMenuItem1, Me.PizzaHutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'McDonaldsToolStripMenuItem
        '
        Me.McDonaldsToolStripMenuItem.Name = "McDonaldsToolStripMenuItem"
        Me.McDonaldsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.McDonaldsToolStripMenuItem.Text = "McDonald's"
        '
        'StarbucksToolStripMenuItem
        '
        Me.StarbucksToolStripMenuItem.Name = "StarbucksToolStripMenuItem"
        Me.StarbucksToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.StarbucksToolStripMenuItem.Text = "Starbucks"
        '
        'SubwayToolStripMenuItem
        '
        Me.SubwayToolStripMenuItem.Name = "SubwayToolStripMenuItem"
        Me.SubwayToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SubwayToolStripMenuItem.Text = "Subway"
        '
        'TacoBellToolStripMenuItem
        '
        Me.TacoBellToolStripMenuItem.Name = "TacoBellToolStripMenuItem"
        Me.TacoBellToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TacoBellToolStripMenuItem.Text = "Taco Bell"
        '
        'ChickFilAToolStripMenuItem
        '
        Me.ChickFilAToolStripMenuItem.Name = "ChickFilAToolStripMenuItem"
        Me.ChickFilAToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ChickFilAToolStripMenuItem.Text = "Chick-Fil-A"
        '
        'WendysToolStripMenuItem
        '
        Me.WendysToolStripMenuItem.Name = "WendysToolStripMenuItem"
        Me.WendysToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.WendysToolStripMenuItem.Text = "Wendy's"
        '
        'BurgerKingToolStripMenuItem
        '
        Me.BurgerKingToolStripMenuItem.Name = "BurgerKingToolStripMenuItem"
        Me.BurgerKingToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BurgerKingToolStripMenuItem.Text = "Burger King"
        '
        'DominosToolStripMenuItem
        '
        Me.DominosToolStripMenuItem.Name = "DominosToolStripMenuItem"
        Me.DominosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DominosToolStripMenuItem.Text = "Domino's"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem1.Text = "Dunkin"
        '
        'PizzaHutToolStripMenuItem
        '
        Me.PizzaHutToolStripMenuItem.Name = "PizzaHutToolStripMenuItem"
        Me.PizzaHutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PizzaHutToolStripMenuItem.Text = "Pizza Hut"
        '
        'field1
        '
        Me.field1.Location = New System.Drawing.Point(269, 121)
        Me.field1.Name = "field1"
        Me.field1.Size = New System.Drawing.Size(125, 27)
        Me.field1.TabIndex = 7
        '
        'field2
        '
        Me.field2.Location = New System.Drawing.Point(269, 159)
        Me.field2.Name = "field2"
        Me.field2.Size = New System.Drawing.Size(125, 27)
        Me.field2.TabIndex = 8
        '
        'field3
        '
        Me.field3.Location = New System.Drawing.Point(269, 203)
        Me.field3.Name = "field3"
        Me.field3.Size = New System.Drawing.Size(125, 27)
        Me.field3.TabIndex = 9
        '
        'field4
        '
        Me.field4.Location = New System.Drawing.Point(269, 245)
        Me.field4.Name = "field4"
        Me.field4.Size = New System.Drawing.Size(125, 27)
        Me.field4.TabIndex = 10
        '
        'field5
        '
        Me.field5.Location = New System.Drawing.Point(269, 292)
        Me.field5.Name = "field5"
        Me.field5.Size = New System.Drawing.Size(125, 27)
        Me.field5.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'firstbutton
        '
        Me.firstbutton.Location = New System.Drawing.Point(300, 379)
        Me.firstbutton.Name = "firstbutton"
        Me.firstbutton.Size = New System.Drawing.Size(94, 29)
        Me.firstbutton.TabIndex = 12
        Me.firstbutton.Text = "First"
        Me.firstbutton.UseVisualStyleBackColor = True
        '
        'prevbutton
        '
        Me.prevbutton.Location = New System.Drawing.Point(441, 379)
        Me.prevbutton.Name = "prevbutton"
        Me.prevbutton.Size = New System.Drawing.Size(94, 29)
        Me.prevbutton.TabIndex = 13
        Me.prevbutton.Text = "Previous"
        Me.prevbutton.UseVisualStyleBackColor = True
        '
        'nextbutton
        '
        Me.nextbutton.Location = New System.Drawing.Point(570, 379)
        Me.nextbutton.Name = "nextbutton"
        Me.nextbutton.Size = New System.Drawing.Size(94, 29)
        Me.nextbutton.TabIndex = 14
        Me.nextbutton.Text = "Next"
        Me.nextbutton.UseVisualStyleBackColor = True
        '
        'lastbutton
        '
        Me.lastbutton.Location = New System.Drawing.Point(694, 379)
        Me.lastbutton.Name = "lastbutton"
        Me.lastbutton.Size = New System.Drawing.Size(94, 29)
        Me.lastbutton.TabIndex = 15
        Me.lastbutton.Text = "Last"
        Me.lastbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lastbutton)
        Me.Controls.Add(Me.nextbutton)
        Me.Controls.Add(Me.prevbutton)
        Me.Controls.Add(Me.firstbutton)
        Me.Controls.Add(Me.field5)
        Me.Controls.Add(Me.field4)
        Me.Controls.Add(Me.field3)
        Me.Controls.Add(Me.field2)
        Me.Controls.Add(Me.field1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents field1 As TextBox
    Friend WithEvents field2 As TextBox
    Friend WithEvents field3 As TextBox
    Friend WithEvents field4 As TextBox
    Friend WithEvents field5 As TextBox
    Friend WithEvents McDonaldsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StarbucksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubwayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TacoBellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChickFilAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WendysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BurgerKingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DominosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PizzaHutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents firstbutton As Button
    Friend WithEvents prevbutton As Button
    Friend WithEvents nextbutton As Button
    Friend WithEvents lastbutton As Button
End Class
