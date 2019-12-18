Public Class FormGest

    Private Sub FormGest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogineToolStripMenuItem.Enabled = False
        Me.Label2.Hide()
        Me.Label3.Hide()
        Me.ProgressBar1.Hide()
    End Sub

    Private Sub loading()
        'Loading
        Me.Label3.Hide()
        Me.Label2.Show()
        Me.ProgressBar1.Show()
        Me.Timer1.Start()
    End Sub

    Private Sub ButtonGoTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGoTo.Click

        'Class six
        If ComBoxGest.Text = "Class Six (A)" Then
            'Loading
            loading()
            'Form_G_Six_A.Show()
            Me.Hide()
        End If


        'Class Seven
        If ComBoxGest.Text = "Class Seven (A)" Then
            'Loading
            loading()
            'Form_G_Seven_A.Show()
            Me.Hide()
        End If

       
        'Class Eight
        If ComBoxGest.Text = "Class Eight (A)" Then
            'Loading
            loading()
            ' Form_G_Eight_A.Show()
            Me.Hide()
        Else
            ComBoxGest.Text = ""
            Me.Label3.Show()

        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        'Form Login
        'FormLogin.ProgressBar1Login.Hide()
        'FormLogin.ProgressBar1.Hide()
        'FormLogin.Label4Login.Hide()
        'FormLogin.Label5Login.Hide()
        'FormLogin.Label6Login.Hide()
        'FormLogin.TextBox1.Text = ""
        'FormLogin.TextBox2.Text = ""
        FormLogin.Show()
        Me.Hide()
        MsgBox("Successfully Logout")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Show()
        Label2.Show()
        ProgressBar1.Increment(33.33)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class