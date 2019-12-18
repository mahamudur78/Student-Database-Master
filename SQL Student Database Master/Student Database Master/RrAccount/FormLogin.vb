Public Class FormLogin


    Private Sub Shutdown()
        End
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet.ReAccount' table. You can move, or remove it, as needed.
        'Me.ReAccountTableAdapter.Fill(Me.StudentDatabaseDataSet.ReAccount)
        ProgressBar1Login.Hide()
        ProgressBar1.Hide()
        Label4Login.Hide()
        Label5Login.Hide()
        Me.MaximizeBox = False
        LogoutToolStripMenuItem.Enabled = False
       
    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        Dim Connection As New SqlClient.SqlConnection
        Dim Command As New SqlClient.SqlCommand
        Dim Adapter As New SqlClient.SqlDataAdapter
        Dim dataset As New DataSet

        Me.ComBoxSelectUsear.Enabled = False
        Me.TextBoxUserName.Enabled = False
        Me.TextBoxPassword.Enabled = False
        Me.TimerAdmin.Stop()
        Me.TimerWrongPassword.Stop()
        Me.ProgressBar1Login.Value = 0
        Me.ProgressBar1.Value = 0
        Me.Label4Login.Hide()
        Me.Label5Login.Hide()

        Try

            Connection.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\DataStore\StudentDatabase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
            Command.CommandText = "SELECT * FROM UserAccount WHERE SelectUser='" & ComBoxSelectUsear.Text & "' AND UserName='" & TextBoxUserName.Text & "' AND Password='" & TextBoxPassword.Text & "';"
            Connection.Open()

            Command.Connection = Connection

            Adapter.SelectCommand = Command
            Adapter.Fill(dataset, "0")

            Dim count = dataset.Tables(0).Rows.Count

            If count > 0 Then

                Label4Login.Show()
                ProgressBar1Login.Show()
                Me.ProgressBar1.Hide()
                If ComBoxSelectUsear.Text = "Administrator" Then
                    Me.TimerAdmin.Start()
                    'Form_A_Eight_B.LabelUsagerName.Text = Me.TextBoxUserName.Text
                ElseIf ComBoxSelectUsear.Text = "Guest" Then
                    Me.TimerGest.Start()
                    'Form_A_Eight_B.LabelUsagerName.Text = Me.TextBoxUserName.Text
                End If
            Else
                If ComBoxSelectUsear.Text = "" Then
                    MessageBox.Show("Select ''Usager'", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Me.ComBoxSelectUsear.Enabled = True
                    Me.TextBoxUserName.Enabled = True
                    Me.TextBoxPassword.Enabled = True
                ElseIf TextBoxUserName.Text = "" Then
                    MessageBox.Show("Input ''Usager Name''", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Me.ComBoxSelectUsear.Enabled = True
                    Me.TextBoxUserName.Enabled = True
                    Me.TextBoxPassword.Enabled = True
                    Me.TextBoxUserName.Select()
                ElseIf TextBoxPassword.Text = "" Then
                    MessageBox.Show("Input ''Possword''", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Me.ComBoxSelectUsear.Enabled = True
                    Me.TextBoxUserName.Enabled = True
                    Me.TextBoxPassword.Enabled = True
                    TextBoxPassword.Select()
                Else
                    Me.TimerWrongPassword.Start()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try

       
    End Sub

    Private Sub TimerWrongPassword_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerWrongPassword.Tick
        ProgressBar1.Show()
        Label4Login.Show()
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            TimerWrongPassword.Stop()
            Label5Login.Show()
            Me.ComBoxSelectUsear.Enabled = True
            Me.TextBoxUserName.Enabled = True
            Me.TextBoxPassword.Enabled = True
            Me.TextBoxUserName.Clear()
            Me.TextBoxPassword.Clear()
        End If
    End Sub

    Private Sub TimerGest_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGest.Tick
        ProgressBar1Login.Increment(1)
        If ProgressBar1Login.Value = 100 Then
            TimerGest.Stop()
            FormGest.Show()
            Me.Hide()
            MessageBox.Show("Login Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.ProgressBar1Login.Value = 0
            Me.ProgressBar1Login.Value = 0
            Me.ProgressBar1.Hide()
            Me.ProgressBar1Login.Hide()
            Me.Label4Login.Hide()
            Me.Label5Login.Hide()
            Me.TextBoxUserName.Clear()
            Me.TextBoxPassword.Clear()
            Me.ComBoxSelectUsear.Enabled = True
            Me.TextBoxUserName.Enabled = True
            Me.TextBoxPassword.Enabled = True
        End If
    End Sub

    Private Sub TimerAdmin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAdmin.Tick
        ProgressBar1Login.Increment(1)
        If ProgressBar1Login.Value = 100 Then
            FormAdmin.Show()
            Me.Hide()
            TimerAdmin.Stop()
            MessageBox.Show("Login Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ProgressBar1Login.Value = 0
            Me.ProgressBar1Login.Value = 0
            Me.ProgressBar1.Hide()
            Me.ProgressBar1Login.Hide()
            Me.Label4Login.Hide()
            Me.Label5Login.Hide()
            Me.TextBoxUserName.Clear()
            Me.TextBoxPassword.Clear()
            Me.ComBoxSelectUsear.Enabled = True
            Me.TextBoxUserName.Enabled = True
            Me.TextBoxPassword.Enabled = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub FormLogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Shutdown()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Me.TextBoxUserName.Clear()
        Me.TextBoxPassword.Clear()

    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Shutdown()
    End Sub

    Private Sub LinkLabelCrAccount_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelCrAccount.LinkClicked
        FormAcGRegister.ShowDialog()
    End Sub

    Private Sub ReAccountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.ReAccountBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub

    Private Sub ReAccountBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.ReAccountBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub

    Private Sub AboutDevelopurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutDevelopurToolStripMenuItem.Click
        Form_ADeveloper.ShowDialog()
    End Sub

    Private Sub ActivateProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateProductToolStripMenuItem.Click

    End Sub
End Class