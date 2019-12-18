Public Class Form_Admission_PSC

    Private Sub Form_Admission_PSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet._Primary_School_Certificate__PSC_' table. You can move, or remove it, as needed.
        Me.Primary_School_Certificate__PSC_TableAdapter.Fill(Me.StudentDatabaseDataSet._Primary_School_Certificate__PSC_)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel_MainPage_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel_MainPage.Paint

    End Sub

    

    Private Sub ToolStripButton_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Back.Click
        FormAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Primary_School_Certificate__PSC_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Primary_School_Certificate__PSC_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Primary_School_Certificate__PSC_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub
End Class