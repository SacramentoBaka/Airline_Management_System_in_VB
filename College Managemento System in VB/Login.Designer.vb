<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Label7 = New Label()
        Label8 = New Label()
        LoginPassword = New TextBox()
        LoginEmail = New TextBox()
        CheckBox1 = New CheckBox()
        LoginButton = New Button()
        Label4 = New Label()
        CheckBox2 = New CheckBox()
        LoginRegister = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 13.8F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(108, 202)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 27)
        Label7.TabIndex = 36
        Label7.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Gothic", 13.8F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(108, 139)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 27)
        Label8.TabIndex = 35
        Label8.Text = "Email"
        ' 
        ' LoginPassword
        ' 
        LoginPassword.BackColor = Color.WhiteSmoke
        LoginPassword.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginPassword.Location = New Point(262, 202)
        LoginPassword.Name = "LoginPassword"
        LoginPassword.Size = New Size(241, 30)
        LoginPassword.TabIndex = 34
        LoginPassword.UseSystemPasswordChar = True
        ' 
        ' LoginEmail
        ' 
        LoginEmail.BackColor = Color.WhiteSmoke
        LoginEmail.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginEmail.Location = New Point(262, 139)
        LoginEmail.Name = "LoginEmail"
        LoginEmail.Size = New Size(241, 30)
        LoginEmail.TabIndex = 33
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(262, 248)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(158, 23)
        CheckBox1.TabIndex = 32
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.WhiteSmoke
        LoginButton.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.Location = New Point(262, 328)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(94, 29)
        LoginButton.TabIndex = 38
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(108, 398)
        Label4.Name = "Label4"
        Label4.Size = New Size(333, 21)
        Label4.TabIndex = 37
        Label4.Text = "Not yet Register ? Click here to Register"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox2.ForeColor = Color.White
        CheckBox2.Location = New Point(262, 289)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(153, 23)
        CheckBox2.TabIndex = 39
        CheckBox2.Text = "Remember Me"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' LoginRegister
        ' 
        LoginRegister.BackColor = Color.WhiteSmoke
        LoginRegister.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginRegister.Location = New Point(467, 394)
        LoginRegister.Name = "LoginRegister"
        LoginRegister.Size = New Size(94, 29)
        LoginRegister.TabIndex = 40
        LoginRegister.Text = "Register"
        LoginRegister.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(262, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 34)
        Label1.TabIndex = 41
        Label1.Text = "LOGIN"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(616, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 42
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(668, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(LoginRegister)
        Controls.Add(CheckBox2)
        Controls.Add(LoginButton)
        Controls.Add(Label4)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(LoginPassword)
        Controls.Add(LoginEmail)
        Controls.Add(CheckBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LoginPassword As TextBox
    Friend WithEvents LoginEmail As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents LoginRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
