<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGest
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
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonGoTo = New System.Windows.Forms.Button()
        Me.LogineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComBoxGest = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(196, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Select Class "
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(114, 80)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(315, 23)
        Me.ProgressBar1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Loading....."
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ButtonGoTo
        '
        Me.ButtonGoTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGoTo.Location = New System.Drawing.Point(354, 41)
        Me.ButtonGoTo.Name = "ButtonGoTo"
        Me.ButtonGoTo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGoTo.TabIndex = 12
        Me.ButtonGoTo.Text = "Go To"
        Me.ButtonGoTo.UseVisualStyleBackColor = True
        '
        'LogineToolStripMenuItem
        '
        Me.LogineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LogineToolStripMenuItem.Name = "LogineToolStripMenuItem"
        Me.LogineToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LogineToolStripMenuItem.Text = "Login"
        '
        'ComBoxGest
        '
        Me.ComBoxGest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxGest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxGest.FormattingEnabled = True
        Me.ComBoxGest.Items.AddRange(New Object() {"Class Six (A)", "Class Six (B)", "Class Six (C)", "Class Seven (A)", "Class Seven (B)", "Class Seven (C)", "Class Eight (A)", "Class Eight (B)", "Class Eight (C)"})
        Me.ComBoxGest.Location = New System.Drawing.Point(138, 41)
        Me.ComBoxGest.Name = "ComBoxGest"
        Me.ComBoxGest.Size = New System.Drawing.Size(198, 24)
        Me.ComBoxGest.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select Class :-"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(455, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogineToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Timer1
        '
        '
        'FormGest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 124)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonGoTo)
        Me.Controls.Add(Me.ComBoxGest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormGest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormGest"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonGoTo As System.Windows.Forms.Button
    Friend WithEvents LogineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComBoxGest As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
