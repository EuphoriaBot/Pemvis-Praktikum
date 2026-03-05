<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        label3 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold)
        Label1.Location = New Point(178, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(481, 81)
        Label1.TabIndex = 1
        Label1.Text = "Selamat Datang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label2.Location = New Point(297, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 54)
        Label2.TabIndex = 2
        Label2.Text = "user_name"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(241, 168)
        label3.Name = "label3"
        label3.Size = New Size(306, 25)
        label3.TabIndex = 3
        label3.Text = "Semoga Hari Harinya Menyenangkan"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkRed
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(13, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 34)
        Button1.TabIndex = 0
        Button1.Text = "Keluar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-1, 297)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(813, 168)
        Panel1.TabIndex = 4
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
