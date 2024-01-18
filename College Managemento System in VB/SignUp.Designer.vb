<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        Button2 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(296, 544)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(158, 23)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(82, 694)
        Label4.Name = "Label4"
        Label4.Size = New Size(313, 21)
        Label4.TabIndex = 20
        Label4.Text = "Already Register ? Click here to login"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(368, 611)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 29)
        Button2.TabIndex = 19
        Button2.Text = "Register"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 13.8F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(82, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 27)
        Label3.TabIndex = 17
        Label3.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 13.8F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(82, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 27)
        Label2.TabIndex = 16
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(204, 71)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(348, 86)
        Label1.TabIndex = 15
        Label1.Text = "Welcome To College Management System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.Location = New Point(296, 255)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(290, 26)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.Location = New Point(296, 192)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(290, 26)
        TextBox1.TabIndex = 13
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(690, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 13.8F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(82, 311)
        Label6.Name = "Label6"
        Label6.Size = New Size(181, 27)
        Label6.TabIndex = 26
        Label6.Text = "Phone Number"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.WhiteSmoke
        TextBox4.Location = New Point(296, 311)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(290, 26)
        TextBox4.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 13.8F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(82, 498)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 27)
        Label7.TabIndex = 31
        Label7.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Gothic", 13.8F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(82, 435)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 27)
        Label8.TabIndex = 30
        Label8.Text = "Email"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.WhiteSmoke
        TextBox5.Location = New Point(296, 498)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(290, 26)
        TextBox5.TabIndex = 29
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.WhiteSmoke
        TextBox6.Location = New Point(296, 435)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(290, 26)
        TextBox6.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 13.8F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(82, 376)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 27)
        Label5.TabIndex = 32
        Label5.Text = "Gender"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.WhiteSmoke
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Others"})
        ComboBox1.Location = New Point(296, 375)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(101, 28)
        ComboBox1.TabIndex = 33
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(468, 686)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 29)
        Button1.TabIndex = 34
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(758, 753)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(TextBox5)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(CheckBox1)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUp"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
