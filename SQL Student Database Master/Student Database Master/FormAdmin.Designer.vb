<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LabelLoding = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonGoTo = New System.Windows.Forms.Button()
        Me.ComBoxAdmin = New System.Windows.Forms.ComboBox()
        Me.GestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmissionFromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmissionFormPSCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmissionFormJSCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmissionFormSSCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(213, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Select Class "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(145, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(102, 79)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(342, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'LabelLoding
        '
        Me.LabelLoding.AutoSize = True
        Me.LabelLoding.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoding.Location = New System.Drawing.Point(12, 79)
        Me.LabelLoding.Name = "LabelLoding"
        Me.LabelLoding.Size = New System.Drawing.Size(72, 16)
        Me.LabelLoding.TabIndex = 10
        Me.LabelLoding.Text = "Loading....."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'ButtonGoTo
        '
        Me.ButtonGoTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGoTo.Location = New System.Drawing.Point(369, 37)
        Me.ButtonGoTo.Name = "ButtonGoTo"
        Me.ButtonGoTo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGoTo.TabIndex = 9
        Me.ButtonGoTo.Text = "Go To"
        Me.ButtonGoTo.UseVisualStyleBackColor = True
        '
        'ComBoxAdmin
        '
        Me.ComBoxAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxAdmin.FormattingEnabled = True
        Me.ComBoxAdmin.Items.AddRange(New Object() {"Primary School Certificate (PSC)", "Junior School Certificate (JSC)", "Secondary School Certificate (SSC)"})
        Me.ComBoxAdmin.Location = New System.Drawing.Point(126, 37)
        Me.ComBoxAdmin.Name = "ComBoxAdmin"
        Me.ComBoxAdmin.Size = New System.Drawing.Size(237, 24)
        Me.ComBoxAdmin.TabIndex = 8
        '
        'GestToolStripMenuItem
        '
        Me.GestToolStripMenuItem.Name = "GestToolStripMenuItem"
        Me.GestToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GestToolStripMenuItem.Text = "Gest Account"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestToolStripMenuItem, Me.ToolStripSeparator1, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripSeparator2, Me.EndToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Class :-"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.AdmissionFromToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(461, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminAccountToolStripMenuItem, Me.GestAccountToolStripMenuItem})
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'AdminAccountToolStripMenuItem
        '
        Me.AdminAccountToolStripMenuItem.Name = "AdminAccountToolStripMenuItem"
        Me.AdminAccountToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AdminAccountToolStripMenuItem.Text = "Account Regisrer"
        '
        'GestAccountToolStripMenuItem
        '
        Me.GestAccountToolStripMenuItem.Name = "GestAccountToolStripMenuItem"
        Me.GestAccountToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.GestAccountToolStripMenuItem.Text = "Administration strase"
        '
        'AdmissionFromToolStripMenuItem
        '
        Me.AdmissionFromToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmissionFormPSCToolStripMenuItem, Me.AdmissionFormJSCToolStripMenuItem, Me.AdmissionFormSSCToolStripMenuItem})
        Me.AdmissionFromToolStripMenuItem.Name = "AdmissionFromToolStripMenuItem"
        Me.AdmissionFromToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.AdmissionFromToolStripMenuItem.Text = "Admission Form"
        '
        'AdmissionFormPSCToolStripMenuItem
        '
        Me.AdmissionFormPSCToolStripMenuItem.Name = "AdmissionFormPSCToolStripMenuItem"
        Me.AdmissionFormPSCToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AdmissionFormPSCToolStripMenuItem.Text = "Admission Form PSC"
        '
        'AdmissionFormJSCToolStripMenuItem
        '
        Me.AdmissionFormJSCToolStripMenuItem.Name = "AdmissionFormJSCToolStripMenuItem"
        Me.AdmissionFormJSCToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AdmissionFormJSCToolStripMenuItem.Text = "Admission Form JSC"
        '
        'AdmissionFormSSCToolStripMenuItem
        '
        Me.AdmissionFormSSCToolStripMenuItem.Name = "AdmissionFormSSCToolStripMenuItem"
        Me.AdmissionFormSSCToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AdmissionFormSSCToolStripMenuItem.Text = "Admission Form SSC"
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(461, 114)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LabelLoding)
        Me.Controls.Add(Me.ButtonGoTo)
        Me.Controls.Add(Me.ComBoxAdmin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelLoding As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ButtonGoTo As System.Windows.Forms.Button
    Friend WithEvents ComBoxAdmin As System.Windows.Forms.ComboBox
    Friend WithEvents GestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmissionFromToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmissionFormPSCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmissionFormJSCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmissionFormSSCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
