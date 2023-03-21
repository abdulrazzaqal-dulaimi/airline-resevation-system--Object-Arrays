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
        TabControl1 = New TabControl()
        Tab1 = New TabPage()
        TabPage2 = New TabPage()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Tab1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(8, 6)
        TabControl1.Margin = New Padding(2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1183, 718)
        TabControl1.TabIndex = 4
        ' 
        ' Tab1
        ' 
        Tab1.AccessibleName = ""
        Tab1.AutoScroll = True
        Tab1.BackColor = Color.Salmon
        Tab1.BackgroundImageLayout = ImageLayout.None
        Tab1.Location = New Point(4, 29)
        Tab1.Margin = New Padding(2)
        Tab1.Name = "Tab1"
        Tab1.Padding = New Padding(2)
        Tab1.Size = New Size(1175, 685)
        Tab1.TabIndex = 0
        Tab1.Text = "Biz Class"' 
        ' TabPage2
        ' 
        TabPage2.AutoScroll = True
        TabPage2.BackColor = Color.Salmon
        TabPage2.Location = New Point(4, 29)
        TabPage2.Margin = New Padding(2)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(2)
        TabPage2.Size = New Size(1175, 685)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Eco Class"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Pink
        ClientSize = New Size(1640, 735)
        Controls.Add(TabControl1)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tab1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
