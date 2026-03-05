<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Button1 = New Button()
        txtname = New TextBox()
        txtpassword = New TextBox()
        label5 = New Label()
        label4 = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-3, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(829, 296)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.0F)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(658, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 54)
        Label3.TabIndex = 2
        Label3.Text = "2020"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.0F)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(15, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 41)
        Label2.TabIndex = 1
        Label2.Text = "Form Input"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.0F)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(492, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 67)
        Label1.TabIndex = 0
        Label1.Text = "Visual Studio"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(txtname)
        Panel2.Controls.Add(txtpassword)
        Panel2.Controls.Add(label5)
        Panel2.Controls.Add(label4)
        Panel2.Location = New Point(-3, 292)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(823, 526)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatAppearance.MouseDownBackColor = Color.MediumSlateBlue
        Button1.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(170, 197)
        Button1.Name = "Button1"
        Button1.Size = New Size(223, 34)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(170, 68)
        txtname.MaxLength = 6
        txtname.Name = "txtname"
        txtname.Size = New Size(223, 31)
        txtname.TabIndex = 3
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(170, 124)
        txtpassword.MaxLength = 10
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "•"c
        txtpassword.Size = New Size(223, 31)
        txtpassword.TabIndex = 2
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.ForeColor = Color.Transparent
        label5.Location = New Point(36, 68)
        label5.Name = "label5"
        label5.Size = New Size(99, 25)
        label5.TabIndex = 1
        label5.Text = "User Name"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.ForeColor = Color.Transparent
        label4.Location = New Point(36, 124)
        label4.Name = "label4"
        label4.Size = New Size(87, 25)
        label4.TabIndex = 0
        label4.Text = "Password"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(822, 800)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
