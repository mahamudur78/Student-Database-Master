Public Class Form_Admission_JSC

    Private Sub Form_Admission_JSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet._Junior_School_Certificate__JSC_' table. You can move, or remove it, as needed.
        Me.Junior_School_Certificate__JSC_TableAdapter.Fill(Me.StudentDatabaseDataSet._Junior_School_Certificate__JSC_)

    End Sub

    Private Sub ToolStripButton_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Back.Click
        FormAdmin.Show()
        Me.Hide()
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

 

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

   
    Private Sub Junior_School_Certificate__JSC_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Junior_School_Certificate__JSC_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Junior_School_Certificate__JSC_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub
End Class