Public Class FormTrial


    Private Sub Shutdown()
        End
    End Sub

    Private Sub FormTrial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False

        LabelTrialLife.Text = My.Settings.Trial

        If My.Settings.TEnd = "Yes" Then
            FormWalcame.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Settings.Trial -= 1
        'My.Settings.Save()
        'Me.Label1.Text = My.Settings.Trial
        'If My.Settings.Trial >= 0 Then
        '    FormWalcame.Show()
        '    Me.Close()
        'End If

        'If My.Settings.Trial <= 0 Then
        '    MsgBox("Your Trial Has Expired, Please Buy A Key", MsgBoxStyle.Information, "Trial Expired")
        '    Dim EnterKey = TextBoxKey.Text
        '    If EnterKey = "000-000-000-000-000" Then
        '        My.Settings.TEnd = "Yes"
        '        FormWalcame.Show()
        '        Me.Close()

        '    Else
        '        Me.Close()
        '    End If
        'End If


        My.Settings.Trial -= 1
        My.Settings.Save()
        Me.Label1.Text = My.Settings.Trial
        If My.Settings.Trial >= 0 Then
            FormWalcame.Show()
            Me.Close()
        End If

        If My.Settings.Trial <= 0 Then
            MsgBox("Your Trial Has Expired, Please Buy A Key", MsgBoxStyle.Information, "Trial Expired")
            Dim EnterKey = InputBox("wertgerwt")
            If EnterKey = "000-000-000-000-000" Then
                My.Settings.TEnd = "Yes"
                FormWalcame.Show()
                Me.Close()

            Else
                Me.Close()
            End If
        End If
    End Sub

    
    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Shutdown()
    End Sub

    Private Sub FormTrial_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Shutdown()
    End Sub
End Class
