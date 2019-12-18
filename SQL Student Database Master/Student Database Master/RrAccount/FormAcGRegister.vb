Imports System.Data.SqlClient
Public Class FormAcGRegister
    Private Sub FormAcGRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    'Button Register
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Input ''Full Name''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1.Select()

        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("Input ''Select Usear''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ComboBox1.Select()

        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Input ''Usear Name''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox4.Select()

        ElseIf TextBox5.Text = "" Then
            MessageBox.Show("Input ''Password''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox5.Select()

        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Input ''Date Of Birth'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DateTimePicker1.Select()

        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Select ''Gender''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ElseIf TextBox6.Text = "" Then
            MessageBox.Show("Input ''Address''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox6.Select()

        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Input ''Mobile No''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox8.Select()

        Else
            'INSERT
            Try
                Dim A As Integer
                Dim connection As New SqlConnection(" Data Source=.\SQLEXPRESS;AttachDbFilename=D:\DataStore\StudentDatabase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")


                Dim command As New SqlCommand("insert into UserAccount(Name,SelectUser,UserName,Password,DateofBirth,Gender,Address,Telephone,MobilePhone,Email) values ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')", connection)
                connection.Open()
                If connection.State = Data.ConnectionState.Open Then

                    A = command.ExecuteNonQuery()
                    MessageBox.Show("Guest Account Has Been Successfully Content.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                End If
            Catch ex As Exception

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try



            'Clear
            Me.TextBox1.Clear()
            Me.ComboBox1.Text = ""
            Me.TextBox4.Clear()
            Me.TextBox5.Clear()
            Me.DateTimePicker1.Refresh()
            'Me.TextBox2.Clear()
            Me.TextBox6.Clear()
            Me.TextBox7.Clear()
            Me.TextBox8.Clear()
            Me.TextBox9.Clear()
        End If
    End Sub

    'Select User
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Please Select in Dropdown Menu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Administrator" Then
            ComboBox1.Text = "Guest"
            MessageBox.Show("Only Guest Account Registration", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Gender
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.TextBox2.Text = "Male"
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.TextBox2.Text = "Female"
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.TextBox2.Text = "Other"
    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox3.Text = DateTimePicker1.Text
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Please Select in ''Date Time Picker'' Menu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

  
End Class