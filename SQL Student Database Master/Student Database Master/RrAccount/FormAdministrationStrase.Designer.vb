<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrationStrase
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5Login = New System.Windows.Forms.Label()
        Me.Label4Login = New System.Windows.Forms.Label()
        Me.ProgressBar1Login = New System.Windows.Forms.ProgressBar()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UserAccountDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UserAccountDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(147, 147)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(140, 23)
        Me.ProgressBar1.TabIndex = 37
        '
        'Label5Login
        '
        Me.Label5Login.AutoSize = True
        Me.Label5Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5Login.ForeColor = System.Drawing.Color.Red
        Me.Label5Login.Location = New System.Drawing.Point(144, 173)
        Me.Label5Login.Name = "Label5Login"
        Me.Label5Login.Size = New System.Drawing.Size(126, 15)
        Me.Label5Login.TabIndex = 36
        Me.Label5Login.Text = "Wrong Password..."
        '
        'Label4Login
        '
        Me.Label4Login.AutoSize = True
        Me.Label4Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4Login.Location = New System.Drawing.Point(14, 154)
        Me.Label4Login.Name = "Label4Login"
        Me.Label4Login.Size = New System.Drawing.Size(94, 15)
        Me.Label4Login.TabIndex = 35
        Me.Label4Login.Text = "Progressing......."
        '
        'ProgressBar1Login
        '
        Me.ProgressBar1Login.Location = New System.Drawing.Point(147, 147)
        Me.ProgressBar1Login.Name = "ProgressBar1Login"
        Me.ProgressBar1Login.Size = New System.Drawing.Size(140, 23)
        Me.ProgressBar1Login.TabIndex = 34
        '
        'ButtonClose
        '
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(220, 114)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(67, 27)
        Me.ButtonClose.TabIndex = 33
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.Location = New System.Drawing.Point(147, 114)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(67, 27)
        Me.ButtonLogin.TabIndex = 32
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Password :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "UserName :-"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(147, 88)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(137, 21)
        Me.TextBoxPassword.TabIndex = 29
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserName.Location = New System.Drawing.Point(147, 62)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(137, 21)
        Me.TextBoxUserName.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.ButtonLogin)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.TextBoxUserName)
        Me.Panel1.Controls.Add(Me.Label5Login)
        Me.Panel1.Controls.Add(Me.TextBoxPassword)
        Me.Panel1.Controls.Add(Me.Label4Login)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ProgressBar1Login)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ButtonClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 203)
        Me.Panel1.TabIndex = 38
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(965, 50)
        Me.Panel4.TabIndex = 157
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administration Strase"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UserAccountDataGridView)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 203)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(965, 295)
        Me.Panel2.TabIndex = 39
        '
        'UserAccountDataGridView
        '
        Me.UserAccountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserAccountDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserAccountDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.UserAccountDataGridView.Name = "UserAccountDataGridView"
        Me.UserAccountDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserAccountDataGridView.Size = New System.Drawing.Size(965, 270)
        Me.UserAccountDataGridView.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 270)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(965, 25)
        Me.Panel3.TabIndex = 0
        '
        'FormAdministrationStrase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(965, 498)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAdministrationStrase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdministrationStrase"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UserAccountDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5Login As System.Windows.Forms.Label
    Friend WithEvents Label4Login As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1Login As System.Windows.Forms.ProgressBar
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserAccountDataGridView As System.Windows.Forms.DataGridView
End Class
