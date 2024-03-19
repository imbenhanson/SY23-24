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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ClickerControl2 = New feb5.ClickerControl()
        Me.ClickerControl3 = New feb5.ClickerControl()
        Me.ClickerControl4 = New feb5.ClickerControl()
        Me.SuspendLayout()
        '
        'ClickerControl2
        '
        Me.ClickerControl2.BackColor = System.Drawing.Color.Yellow
        Me.ClickerControl2.Location = New System.Drawing.Point(107, 155)
        Me.ClickerControl2.Name = "ClickerControl2"
        Me.ClickerControl2.Size = New System.Drawing.Size(137, 108)
        Me.ClickerControl2.TabIndex = 0
        '
        'ClickerControl3
        '
        Me.ClickerControl3.BackColor = System.Drawing.Color.Red
        Me.ClickerControl3.Location = New System.Drawing.Point(316, 155)
        Me.ClickerControl3.Name = "ClickerControl3"
        Me.ClickerControl3.Size = New System.Drawing.Size(137, 108)
        Me.ClickerControl3.TabIndex = 1
        '
        'ClickerControl4
        '
        Me.ClickerControl4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClickerControl4.Location = New System.Drawing.Point(531, 155)
        Me.ClickerControl4.Name = "ClickerControl4"
        Me.ClickerControl4.Size = New System.Drawing.Size(137, 108)
        Me.ClickerControl4.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClickerControl4)
        Me.Controls.Add(Me.ClickerControl3)
        Me.Controls.Add(Me.ClickerControl2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClickerControl1 As ClickerControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ClickerControl2 As ClickerControl
    Friend WithEvents ClickerControl3 As ClickerControl
    Friend WithEvents ClickerControl4 As ClickerControl
End Class
