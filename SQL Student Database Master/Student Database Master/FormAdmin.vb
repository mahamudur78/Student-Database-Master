Public Class FormAdmin


    Public Sub shutdown()
        Dim myReply As Integer
        myReply = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If myReply = vbYes Then
            End
        End If
    End Sub


    Private Sub FormAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.LabelLoding.Hide()
        Me.Label3.Hide()
        Me.ProgressBar1.Hide()
        LoginToolStripMenuItem.Enabled = False
    End Sub

    Private Sub loading()
        'Loading
        Me.Label3.Hide()
        Me.LabelLoding.Show()
        Me.ProgressBar1.Show()
        Me.Timer1.Start()
    End Sub

    Private Sub ButtonGoTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGoTo.Click

        'Class Six
        If ComBoxAdmin.Text = "Primary School Certificate (PSC)" Then

            loading()
            Form_PSC.Show()
            Me.Hide()
            Me.Timer1.Stop()
            Me.ProgressBar1.Value = 0
            Me.LabelLoding.Hide()
            Me.ProgressBar1.Hide()

        ElseIf ComBoxAdmin.Text = "Junior School Certificate (JSC)" Then
            'Class seven
            loading()
            Form_JSC.Show()
            Me.Hide()
            Me.Timer1.Stop()
            Me.ProgressBar1.Value = 0
            Me.LabelLoding.Hide()
            Me.ProgressBar1.Hide()

        ElseIf ComBoxAdmin.Text = "Secondary School Certificate (SSC)" Then
            loading()
            Form_SSC.Show()
            Me.Hide()
            Me.Timer1.Stop()
            Me.ProgressBar1.Value = 0
            Me.LabelLoding.Hide()
            Me.ProgressBar1.Hide()
        Else
            ComBoxAdmin.Text = ""
            Me.Label3.Show()

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Show()
        LabelLoding.Show()
        ProgressBar1.Increment(33.33)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        'Form Login

        Dim myReply As Integer
        myReply = MessageBox.Show("Are you sure? Logout", "Logout Administrator Account ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If myReply = vbYes Then
            FormLogin.Show()
            Me.Hide()
            MsgBox("Successfully Logout")
        End If
       
    End Sub

    Private Sub GestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestToolStripMenuItem.Click
        FormGest.Show()
        Me.Hide()
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        Me.Shutdown()
    End Sub

    Private Sub FormAdmin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Shutdown()
    End Sub

    Private Sub AdminAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminAccountToolStripMenuItem.Click
        FormAcRegister.ShowDialog()
    End Sub

    Private Sub GestAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestAccountToolStripMenuItem.Click
        FormAdministrationStrase.ShowDialog()
    End Sub

    Private Sub AdmissionFormPSCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionFormPSCToolStripMenuItem.Click
        Form_Admission_PSC.ShowDialog()
    End Sub

    Private Sub AdmissionFormJSCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionFormJSCToolStripMenuItem.Click
        Form_Admission_JSC.ShowDialog()
    End Sub

    Private Sub AdmissionFormSSCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionFormSSCToolStripMenuItem.Click
        Form_Admission_SSC.ShowDialog()
    End Sub
End Class