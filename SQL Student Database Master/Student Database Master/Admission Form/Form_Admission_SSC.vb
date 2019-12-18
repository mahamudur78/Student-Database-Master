Public Class Form_Admission_SSC

    Private Sub Form_Admission_SSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet._Secondary_School_Certificate__SSC_' table. You can move, or remove it, as needed.
        Me.Secondary_School_Certificate__SSC_TableAdapter.Fill(Me.StudentDatabaseDataSet._Secondary_School_Certificate__SSC_)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form_SSC_SelectSubject.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form_Subject_View.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form_Admission_PSC.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Back.Click
        FormAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Secondary_School_Certificate__SSC_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Secondary_School_Certificate__SSC_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Secondary_School_Certificate__SSC_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TextBox11.Text = Me.TextBox2.Text
            Me.TextBox10.Text = Me.TextBox3.Text
            Me.TextBox9.Text = Me.TextBox4.Text
            Me.TextBox8.Text = Me.TextBox5.Text
            Me.TextBox7.Text = Me.TextBox6.Text

        ElseIf CheckBox1.Checked = False Then
            Me.TextBox11.Clear()
            Me.TextBox10.Clear()
            Me.TextBox9.Clear()
            Me.TextBox8.Clear()
            Me.TextBox7.Clear()
        End If

    End Sub
End Class