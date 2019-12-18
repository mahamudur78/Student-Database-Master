<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentDatabessHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentDatabessOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivateProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecebookFaneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutStudentDatabessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5Login = New System.Windows.Forms.Label()
        Me.Label4Login = New System.Windows.Forms.Label()
        Me.ProgressBar1Login = New System.Windows.Forms.ProgressBar()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.ComBoxSelectUsear = New System.Windows.Forms.ComboBox()
        Me.TimerAdmin = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGest = New System.Windows.Forms.Timer(Me.components)
        Me.TimerWrongPassword = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabelCrAccount = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AboutDevelopurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(620, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentDatabessHelpToolStripMenuItem, Me.StudentDatabessOnlineToolStripMenuItem, Me.ContactUsToolStripMenuItem, Me.ActivateProductToolStripMenuItem, Me.FecebookFaneToolStripMenuItem, Me.AboutStudentDatabessToolStripMenuItem, Me.AboutDevelopurToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'StudentDatabessHelpToolStripMenuItem
        '
        Me.StudentDatabessHelpToolStripMenuItem.Name = "StudentDatabessHelpToolStripMenuItem"
        Me.StudentDatabessHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.StudentDatabessHelpToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.StudentDatabessHelpToolStripMenuItem.Text = "Student Data Managements Help"
        '
        'StudentDatabessOnlineToolStripMenuItem
        '
        Me.StudentDatabessOnlineToolStripMenuItem.Name = "StudentDatabessOnlineToolStripMenuItem"
        Me.StudentDatabessOnlineToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.StudentDatabessOnlineToolStripMenuItem.Text = "Student Data Managements Online"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'ActivateProductToolStripMenuItem
        '
        Me.ActivateProductToolStripMenuItem.Name = "ActivateProductToolStripMenuItem"
        Me.ActivateProductToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.ActivateProductToolStripMenuItem.Text = "Activate Product"
        '
        'FecebookFaneToolStripMenuItem
        '
        Me.FecebookFaneToolStripMenuItem.Name = "FecebookFaneToolStripMenuItem"
        Me.FecebookFaneToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FecebookFaneToolStripMenuItem.Text = "Fecebook Fane"
        '
        'AboutStudentDatabessToolStripMenuItem
        '
        Me.AboutStudentDatabessToolStripMenuItem.Name = "AboutStudentDatabessToolStripMenuItem"
        Me.AboutStudentDatabessToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.AboutStudentDatabessToolStripMenuItem.Text = "About Student Data Managements"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(431, 190)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(140, 23)
        Me.ProgressBar1.TabIndex = 26
        '
        'Label5Login
        '
        Me.Label5Login.AutoSize = True
        Me.Label5Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5Login.ForeColor = System.Drawing.Color.Red
        Me.Label5Login.Location = New System.Drawing.Point(428, 216)
        Me.Label5Login.Name = "Label5Login"
        Me.Label5Login.Size = New System.Drawing.Size(126, 15)
        Me.Label5Login.TabIndex = 25
        Me.Label5Login.Text = "Wrong Password..."
        '
        'Label4Login
        '
        Me.Label4Login.AutoSize = True
        Me.Label4Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4Login.Location = New System.Drawing.Point(298, 197)
        Me.Label4Login.Name = "Label4Login"
        Me.Label4Login.Size = New System.Drawing.Size(94, 15)
        Me.Label4Login.TabIndex = 24
        Me.Label4Login.Text = "Progressing......."
        '
        'ProgressBar1Login
        '
        Me.ProgressBar1Login.Location = New System.Drawing.Point(431, 190)
        Me.ProgressBar1Login.Name = "ProgressBar1Login"
        Me.ProgressBar1Login.Size = New System.Drawing.Size(140, 23)
        Me.ProgressBar1Login.TabIndex = 23
        '
        'ButtonClose
        '
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(504, 157)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(67, 27)
        Me.ButtonClose.TabIndex = 22
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.Location = New System.Drawing.Point(431, 157)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(67, 27)
        Me.ButtonLogin.TabIndex = 21
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Password :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "UserName :-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Select Login As :-"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(431, 131)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(137, 21)
        Me.TextBoxPassword.TabIndex = 17
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserName.Location = New System.Drawing.Point(431, 105)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(137, 21)
        Me.TextBoxUserName.TabIndex = 16
        '
        'ComBoxSelectUsear
        '
        Me.ComBoxSelectUsear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxSelectUsear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxSelectUsear.FormattingEnabled = True
        Me.ComBoxSelectUsear.Items.AddRange(New Object() {"Administrator", "Guest"})
        Me.ComBoxSelectUsear.Location = New System.Drawing.Point(431, 57)
        Me.ComBoxSelectUsear.Name = "ComBoxSelectUsear"
        Me.ComBoxSelectUsear.Size = New System.Drawing.Size(137, 23)
        Me.ComBoxSelectUsear.TabIndex = 15
        '
        'TimerAdmin
        '
        Me.TimerAdmin.Interval = 30
        '
        'TimerGest
        '
        Me.TimerGest.Interval = 30
        '
        'TimerWrongPassword
        '
        Me.TimerWrongPassword.Interval = 35
        '
        'LinkLabelCrAccount
        '
        Me.LinkLabelCrAccount.AutoSize = True
        Me.LinkLabelCrAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelCrAccount.Location = New System.Drawing.Point(298, 163)
        Me.LinkLabelCrAccount.Name = "LinkLabelCrAccount"
        Me.LinkLabelCrAccount.Size = New System.Drawing.Size(89, 15)
        Me.LinkLabelCrAccount.TabIndex = 27
        Me.LinkLabelCrAccount.TabStop = True
        Me.LinkLabelCrAccount.Text = "Create Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Data_Managements.My.Resources.Resources.lock
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 225)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'AboutDevelopurToolStripMenuItem
        '
        Me.AboutDevelopurToolStripMenuItem.Name = "AboutDevelopurToolStripMenuItem"
        Me.AboutDevelopurToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.AboutDevelopurToolStripMenuItem.Text = "About Developur"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(620, 278)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabelCrAccount)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5Login)
        Me.Controls.Add(Me.Label4Login)
        Me.Controls.Add(Me.ProgressBar1Login)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.ComBoxSelectUsear)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentDatabessHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentDatabessOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivateProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecebookFaneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutStudentDatabessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5Login As System.Windows.Forms.Label
    Friend WithEvents Label4Login As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1Login As System.Windows.Forms.ProgressBar
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents ComBoxSelectUsear As System.Windows.Forms.ComboBox
    Friend WithEvents TimerAdmin As System.Windows.Forms.Timer
    Friend WithEvents TimerGest As System.Windows.Forms.Timer
    Friend WithEvents TimerWrongPassword As System.Windows.Forms.Timer
    Friend WithEvents LinkLabelCrAccount As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AboutDevelopurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
