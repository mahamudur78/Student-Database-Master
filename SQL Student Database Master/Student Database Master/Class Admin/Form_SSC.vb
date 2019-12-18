Public Class Form_SSC


    Private Sub Form_SSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet._Secondary_School_Certificate__SSC_' table. You can move, or remove it, as needed.
        Me.Secondary_School_Certificate__SSC_TableAdapter.Fill(Me.StudentDatabaseDataSet._Secondary_School_Certificate__SSC_)
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub


    'Class Seven 1st

    'Checked Box
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Me.TextBox553.Enabled = True
            Me.TextBox554.Enabled = True
        ElseIf CheckBox3.Checked = False Then
            Me.TextBox553.Enabled = False
            Me.TextBox554.Enabled = False

            Me.TextBox553.Clear()
            Me.TextBox554.Clear()
        End If
    End Sub

    'Marks Information
    Private Sub Seven_1st_MarkInformation()
        'Total Mark

        Me.TextBox87.Text = Val(TextBox83.Text) + Val(TextBox82.Text) + Val(TextBox96.Text) + Val(TextBox98.Text) + Val(TextBox99.Text) + Val(TextBox100.Text) + Val(TextBox101.Text) + Val(TextBox102.Text) + Val(TextBox103.Text) + Val(TextBox79.Text)

        'Average
        Me.TextBox86.Text = Format(((Val(TextBox83.Text) + Val(TextBox82.Text) + Val(TextBox96.Text) + Val(TextBox98.Text) + Val(TextBox99.Text) + Val(TextBox100.Text) + Val(TextBox101.Text) + Val(TextBox102.Text) + Val(TextBox103.Text) + Val(TextBox79.Text)) / 11), "0.00")

        'GPA
        Me.TextBox85.Text = Format(((Val(TextBox95.Text) + Val(TextBox94.Text) + Val(TextBox552.Text) + Val(TextBox116.Text) + Val(TextBox114.Text) + Val(TextBox112.Text) + Val(TextBox110.Text) + Val(TextBox108.Text) + Val(TextBox106.Text) + Val(TextBox80.Text)) / 10), "0.00")
        Me.TextBox84.Text = "Pass"

        'Subject 1
        If IsNumeric(TextBox89.Text) Then
            If Val(TextBox89.Text) >= 0 And Val(TextBox89.Text) <= 19.7 Then
                Me.TextBox83.Text = "0"
                Me.TextBox97.Text = "F"
                Me.TextBox95.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox652.Text) Then
            If Val(TextBox652.Text) >= 0 And Val(TextBox652.Text) <= 9.8 Then
                Me.TextBox83.Text = "0"
                Me.TextBox97.Text = "F"
                Me.TextBox95.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox90.Text) Then
            If Val(TextBox90.Text) >= 0 And Val(TextBox90.Text) <= 13.1 Then
                Me.TextBox83.Text = "0"
                Me.TextBox97.Text = "F"
                Me.TextBox95.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox653.Text) Then
            If Val(TextBox653.Text) >= 0 And Val(TextBox653.Text) <= 6.5 Then
                Me.TextBox83.Text = "0"
                Me.TextBox97.Text = "F"
                Me.TextBox95.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        'Subject 2
        If IsNumeric(TextBox92.Text) Then
            If Val(TextBox92.Text) >= 0 And Val(TextBox92.Text) <= 19.7 Then
                Me.TextBox82.Text = "0"
                Me.TextBox93.Text = "F"
                Me.TextBox94.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox654.Text) Then
            If Val(TextBox654.Text) >= 0 And Val(TextBox654.Text) <= 9.8 Then
                Me.TextBox82.Text = "0"
                Me.TextBox93.Text = "F"
                Me.TextBox94.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox91.Text) Then
            If Val(TextBox91.Text) >= 0 And Val(TextBox91.Text) <= 6.5 Then
                Me.TextBox82.Text = "0"
                Me.TextBox93.Text = "F"
                Me.TextBox94.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox655.Text) Then
            If Val(TextBox655.Text) >= 0 And Val(TextBox655.Text) <= 6.5 Then
                Me.TextBox82.Text = "0"
                Me.TextBox93.Text = "F"
                Me.TextBox94.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        'Subject 3
        If IsNumeric(TextBox675.Text) Then
            If Val(TextBox675.Text) >= 0 And Val(TextBox675.Text) <= 19.7 Then
                Me.TextBox96.Text = "0"
                Me.TextBox104.Text = "F"
                Me.TextBox552.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox665.Text) Then
            If Val(TextBox665.Text) >= 0 And Val(TextBox665.Text) <= 13.1 Then
                Me.TextBox96.Text = "0"
                Me.TextBox104.Text = "F"
                Me.TextBox552.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        'Subject 4
        If IsNumeric(TextBox674.Text) Then
            If Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 19.7 Then
                Me.TextBox98.Text = "0"
                Me.TextBox105.Text = "F"
                Me.TextBox116.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox664.Text) Then
            If Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 13.1 Then
                Me.TextBox98.Text = "0"
                Me.TextBox105.Text = "F"
                Me.TextBox116.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        'Subject 5
        If IsNumeric(TextBox673.Text) Then
            If Val(TextBox673.Text) >= 0 And Val(TextBox673.Text) <= 19.7 Then
                Me.TextBox99.Text = "0"
                Me.TextBox107.Text = "F"
                Me.TextBox114.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox663.Text) Then
            If Val(TextBox663.Text) >= 0 And Val(TextBox663.Text) <= 13.1 Then
                Me.TextBox99.Text = "0"
                Me.TextBox107.Text = "F"
                Me.TextBox114.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        'Subject 6
        If IsNumeric(TextBox672.Text) Then
            If Val(TextBox672.Text) >= 0 And Val(TextBox672.Text) <= 19.7 Then
                Me.TextBox100.Text = "0"
                Me.TextBox109.Text = "F"
                Me.TextBox112.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox662.Text) Then
            If Val(TextBox662.Text) >= 0 And Val(TextBox662.Text) <= 13.1 Then
                Me.TextBox100.Text = "0"
                Me.TextBox109.Text = "F"
                Me.TextBox112.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        'Piratical Marks
        If Label60.Text = "Physics" Then
            If IsNumeric(TextBox5.Text) Then
                If Val(TextBox5.Text) >= 0 And Val(TextBox5.Text) <= 8.24 Then
                    Me.TextBox100.Text = "0"
                    Me.TextBox109.Text = "F"
                    Me.TextBox112.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        'Subject 7
        If IsNumeric(TextBox671.Text) Then
            If Val(TextBox671.Text) >= 0 And Val(TextBox671.Text) <= 19.7 Then
                Me.TextBox101.Text = "0"
                Me.TextBox111.Text = "F"
                Me.TextBox110.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox661.Text) Then
            If Val(TextBox661.Text) >= 0 And Val(TextBox661.Text) <= 13.1 Then
                Me.TextBox101.Text = "0"
                Me.TextBox111.Text = "F"
                Me.TextBox110.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If Label61.Text = "Chemistry" Then
            If IsNumeric(TextBox4.Text) Then
                If Val(TextBox4.Text) >= 0 And Val(TextBox4.Text) <= 8.24 Then
                    Me.TextBox101.Text = "0"
                    Me.TextBox111.Text = "F"
                    Me.TextBox110.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        'Subject 8
        If IsNumeric(TextBox670.Text) Then
            If Val(TextBox670.Text) >= 0 And Val(TextBox670.Text) <= 8.24 Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox660.Text) Then
            If Val(TextBox660.Text) >= 0 And Val(TextBox660.Text) <= 8.24 Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If Label62.Text = "Higher Mathematics" Then
            If IsNumeric(TextBox3.Text) Then
                If Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 8.24 Then
                    Me.TextBox102.Text = "0"
                    Me.TextBox113.Text = "F"
                    Me.TextBox108.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If


        If Label62.Text = "Biology" Then
            If IsNumeric(TextBox3.Text) Then
                If Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 8.24 Then
                    Me.TextBox102.Text = "0"
                    Me.TextBox113.Text = "F"
                    Me.TextBox108.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        If Label62.Text = "Computer Study" Then
            If IsNumeric(TextBox3.Text) Then
                If Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 9.8 Then
                    Me.TextBox102.Text = "0"
                    Me.TextBox113.Text = "F"
                    Me.TextBox108.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        If Label62.Text = "Agriculture Studies" Then
            If IsNumeric(TextBox3.Text) Then
                If Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 8.24 Then
                    Me.TextBox102.Text = "0"
                    Me.TextBox113.Text = "F"
                    Me.TextBox108.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        'Subject 9
        If IsNumeric(TextBox669.Text) Then
            If Val(TextBox669.Text) >= 0 And Val(TextBox669.Text) <= 8.24 Then
                Me.TextBox103.Text = "0"
                Me.TextBox115.Text = "F"
                Me.TextBox106.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox659.Text) Then
            If Val(TextBox659.Text) >= 0 And Val(TextBox659.Text) <= 8.24 Then
                Me.TextBox103.Text = "0"
                Me.TextBox115.Text = "F"
                Me.TextBox106.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox2.Text) Then
            If Val(TextBox2.Text) >= 0 And Val(TextBox2.Text) <= 8.24 Then
                Me.TextBox103.Text = "0"
                Me.TextBox115.Text = "F"
                Me.TextBox106.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        'Subject 10
        If IsNumeric(TextBox668.Text) Then
            If Val(TextBox668.Text) >= 0 And Val(TextBox668.Text) <= 8.24 Then
                Me.TextBox79.Text = "0"
                Me.TextBox81.Text = "F"
                Me.TextBox80.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If IsNumeric(TextBox658.Text) Then
            If Val(TextBox658.Text) >= 0 And Val(TextBox658.Text) <= 8.24 Then
                Me.TextBox79.Text = "0"
                Me.TextBox81.Text = "F"
                Me.TextBox80.Text = "0.00"
                TextBox87.Clear()
                TextBox86.Clear()
                TextBox88.Clear()
                TextBox85.Clear()
                TextBox84.Text = "Fail"
            End If
        End If

        If Label64.Text = "Higher Mathematics" Then
            If IsNumeric(TextBox1.Text) Then
                If Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 8.24 Then
                    Me.TextBox79.Text = "0"
                    Me.TextBox81.Text = "F"
                    Me.TextBox80.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        If Label64.Text = "Biology" Then
            If IsNumeric(TextBox1.Text) Then
                If Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 8.24 Then
                    Me.TextBox79.Text = "0"
                    Me.TextBox81.Text = "F"
                    Me.TextBox80.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        If Label64.Text = "Computer Study" Then
            If IsNumeric(TextBox1.Text) Then
                If Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 9.8 Then
                    Me.TextBox79.Text = "0"
                    Me.TextBox81.Text = "F"
                    Me.TextBox80.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        If Label64.Text = "Agriculture Studies" Then
            If IsNumeric(TextBox1.Text) Then
                If Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 8.24 Then
                    Me.TextBox79.Text = "0"
                    Me.TextBox81.Text = "F"
                    Me.TextBox80.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If

        If Label64.Text = "Home Science" Then
            If IsNumeric(TextBox1.Text) Then
                If Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 8.24 Then
                    Me.TextBox79.Text = "0"
                    Me.TextBox81.Text = "F"
                    Me.TextBox80.Text = "0.00"
                    TextBox87.Clear()
                    TextBox86.Clear()
                    TextBox88.Clear()
                    TextBox85.Clear()
                    TextBox84.Text = "Fail"
                End If
            End If
        End If


        'Timar

        'subject 1
        If Me.TextBox89.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox652.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox90.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If


        If Me.TextBox653.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'Subject 2
        If Me.TextBox92.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox654.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox91.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox655.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If


        'Subject 3
        If Me.TextBox675.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox665.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'Subject 4
        If Me.TextBox674.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox664.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'Subject 5
        If Me.TextBox673.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox663.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'Subject 6
        If Me.TextBox672.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox662.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Label60.Text = "Physics" Then
            If Me.TextBox5.Text = "" Then
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        'Subject 7
        If Me.TextBox671.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox661.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Label61.Text = "Chemistry" Then
            If Me.TextBox4.Text = "" Then
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        'Subject 8
        If Me.TextBox670.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox660.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Label62.Text = "Higher Mathematics" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        If Label62.Text = "Biology" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        If Label62.Text = "Computer Study" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        If Label62.Text = "Agriculture Studies" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        'Subject 9
        If Me.TextBox669.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox659.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If


        If Me.TextBox2.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If


        'Subject 10
        If Me.TextBox668.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox658.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        If Me.TextBox1.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If


    End Sub

    'Bangla
    Private Sub TextBox89_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox89.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label153.Text = "01." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox89_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox89.TextChanged
        Me.TextBox83.Text = Val(TextBox89.Text) + Val(TextBox652.Text) + Val(TextBox90.Text) + Val(TextBox653.Text)
        If Me.TextBox89.Text = "" Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox89.Text) >= 0 And Val(TextBox89.Text) <= 60 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox89.Text) >= 61 And Val(TextBox89.Text) <= 100000 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Bangla I Creative Marks      ")
            Me.TextBox89.Text = ""
        Else
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox89.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox652.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox90.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox653.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()
    End Sub
    Private Sub TextBox652_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox652.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label153.Text = "01." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox652_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox652.TextChanged
        Me.TextBox83.Text = Val(TextBox89.Text) + Val(TextBox652.Text) + Val(TextBox90.Text) + Val(TextBox653.Text)
        If Me.TextBox652.Text = "" Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox652.Text) >= 0 And Val(TextBox652.Text) <= 30 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox652.Text) >= 31 And Val(TextBox652.Text) <= 100000 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-30 Value", MsgBoxStyle.Critical, "Bangla II Creative Marks     ")
            Me.TextBox652.Text = ""
        Else
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox89.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox652.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox90.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox653.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()
    End Sub
    Private Sub TextBox90_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox90.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label153.Text = "01." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox90_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox90.TextChanged
        Me.TextBox83.Text = Val(TextBox89.Text) + Val(TextBox652.Text) + Val(TextBox90.Text) + Val(TextBox653.Text)
        If Me.TextBox90.Text = "" Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox90.Text) >= 0 And Val(TextBox90.Text) <= 40 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox90.Text) >= 41 And Val(TextBox90.Text) <= 100000 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Bangla I MCQ Marks     ")
            Me.TextBox90.Text = ""
        Else
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox89.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox652.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox90.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox653.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox653_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox653.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label153.Text = "01." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox653_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox653.TextChanged
        Me.TextBox83.Text = Val(TextBox89.Text) + Val(TextBox652.Text) + Val(TextBox90.Text) + Val(TextBox653.Text)
        If Me.TextBox653.Text = "" Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox653.Text) >= 0 And Val(TextBox653.Text) <= 20 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox653.Text) >= 21 And Val(TextBox653.Text) <= 100000 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-20 Value", MsgBoxStyle.Critical, "Bangla II MCQ Marks     ")
            Me.TextBox653.Text = ""
        Else
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox89.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox652.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox90.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        If Me.TextBox653.Text = "" Then
            Me.TextBox83.Text = "0"
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()
    End Sub
    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label153.Text = "01." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label153.Text = "Bangla" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        End If


    End Sub
    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub
    Private Sub TextBox83_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox83.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox83_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox83.TextChanged
        If IsNumeric(TextBox83.Text) Then
            If Val(TextBox83.Text) >= 120 And Val(TextBox83.Text) <= 150 Then
                Me.TextBox97.Text = "A+"
                Me.TextBox95.Text = "5.00"
            ElseIf Val(TextBox83.Text) >= 105 And Val(TextBox83.Text) <= 119 Then
                Me.TextBox97.Text = "A"
                Me.TextBox95.Text = "4.00"
            ElseIf Val(TextBox83.Text) >= 90 And Val(TextBox83.Text) <= 104 Then
                Me.TextBox97.Text = "A-"
                Me.TextBox95.Text = "3.50"
            ElseIf Val(TextBox83.Text) >= 75 And Val(TextBox83.Text) <= 89 Then
                Me.TextBox97.Text = "B"
                Me.TextBox95.Text = "3.00"
            ElseIf Val(TextBox83.Text) >= 60 And Val(TextBox83.Text) <= 74 Then
                Me.TextBox97.Text = "C"
                Me.TextBox95.Text = "2.00"
            ElseIf Val(TextBox83.Text) >= 49.5 And Val(TextBox83.Text) <= 59 Then
                Me.TextBox97.Text = "D"
                Me.TextBox95.Text = "1.00"
            Else
                Me.TextBox97.Text = "F"
                Me.TextBox95.Text = "0.00"
            End If
        End If
    End Sub

    'English
    Private Sub TextBox92_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox92.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label151.Text = "02." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox92_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox92.TextChanged
        Me.TextBox82.Text = Val(TextBox92.Text) + Val(TextBox654.Text) + Val(TextBox91.Text) + Val(TextBox655.Text)
        If Me.TextBox92.Text = "" Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox92.Text) >= 0 And Val(TextBox92.Text) <= 60 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox92.Text) >= 61 And Val(TextBox92.Text) <= 100000 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "English I Creative Marks     ")
            Me.TextBox92.Text = ""
        Else
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox92.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox654.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox91.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox655.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()
    End Sub
    Private Sub TextBox654_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox654.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label151.Text = "02." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox654_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox654.TextChanged
        Me.TextBox82.Text = Val(TextBox92.Text) + Val(TextBox654.Text) + Val(TextBox91.Text) + Val(TextBox655.Text)
        If Me.TextBox654.Text = "" Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox654.Text) >= 0 And Val(TextBox654.Text) <= 30 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox654.Text) >= 31 And Val(TextBox654.Text) <= 100000 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-30 Value", MsgBoxStyle.Critical, "English II Creative Marks     ")
            Me.TextBox654.Text = ""
        Else
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox92.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox654.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox91.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox655.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()
    End Sub
    Private Sub TextBox91_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox91.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label151.Text = "02." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox91_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox91.TextChanged
        Me.TextBox82.Text = Val(TextBox92.Text) + Val(TextBox654.Text) + Val(TextBox91.Text) + Val(TextBox655.Text)
        If Me.TextBox91.Text = "" Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox91.Text) >= 0 And Val(TextBox91.Text) <= 40 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox91.Text) >= 41 And Val(TextBox91.Text) <= 100000 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "English I MCQ Marks     ")
            Me.TextBox91.Text = ""
        Else
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox92.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox654.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox91.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox655.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox655_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox655.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label151.Text = "02." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub TextBox655_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox655.TextChanged
        Me.TextBox82.Text = Val(TextBox92.Text) + Val(TextBox654.Text) + Val(TextBox91.Text) + Val(TextBox655.Text)
        If Me.TextBox655.Text = "" Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox655.Text) >= 0 And Val(TextBox655.Text) <= 20 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox655.Text) >= 21 And Val(TextBox655.Text) <= 100000 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-20 Value", MsgBoxStyle.Critical, "English II MCQ Marks     ")
            Me.TextBox655.Text = ""
        Else
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox92.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox654.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox91.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        If Me.TextBox655.Text = "" Then
            Me.TextBox82.Text = "0"
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label151.Text = "02." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label151.Text = "English for Today" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox82_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox82.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox82_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox82.TextChanged
        If IsNumeric(TextBox82.Text) Then
            If Val(TextBox82.Text) >= 120 And Val(TextBox82.Text) <= 150 Then
                Me.TextBox93.Text = "A+"
                Me.TextBox94.Text = "5.00"
            ElseIf Val(TextBox82.Text) >= 105 And Val(TextBox82.Text) <= 119 Then
                Me.TextBox93.Text = "A"
                Me.TextBox94.Text = "4.00"
            ElseIf Val(TextBox82.Text) >= 90 And Val(TextBox82.Text) <= 104 Then
                Me.TextBox93.Text = "A-"
                Me.TextBox94.Text = "3.50"
            ElseIf Val(TextBox82.Text) >= 75 And Val(TextBox82.Text) <= 89 Then
                Me.TextBox93.Text = "B"
                Me.TextBox94.Text = "3.00"
            ElseIf Val(TextBox82.Text) >= 60 And Val(TextBox82.Text) <= 74 Then
                Me.TextBox93.Text = "C"
                Me.TextBox94.Text = "2.00"
            ElseIf Val(TextBox82.Text) >= 49.5 And Val(TextBox82.Text) <= 59 Then
                Me.TextBox93.Text = "D"
                Me.TextBox94.Text = "1.00"
            Else
                Me.TextBox93.Text = "F"
                Me.TextBox94.Text = "0.00"
            End If
        End If
    End Sub

    'Mathematics
    Private Sub TextBox675_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox675.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label158.Text = "03." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox675_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox675.TextChanged
        Me.TextBox96.Text = Val(TextBox675.Text) + Val(TextBox665.Text)
        If Me.TextBox675.Text = "" Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox675.Text) >= 0 And Val(TextBox675.Text) <= 60 Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox675.Text) >= 61 And Val(TextBox675.Text) <= 100000 Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Mathematics Creative Marks     ")
            Me.TextBox675.Text = ""
        Else
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox675.Text = "" Then
            Me.TextBox96.Text = "0"
            Me.TextBox104.Text = "F"
            Me.TextBox552.Text = "0.00"
        End If

        If Me.TextBox665.Text = "" Then
            Me.TextBox96.Text = "0"
            Me.TextBox104.Text = "F"
            Me.TextBox552.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()
    End Sub
    Private Sub TextBox665_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox665.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If Label158.Text = "03." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox665_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox665.TextChanged
        Me.TextBox96.Text = Val(TextBox675.Text) + Val(TextBox665.Text)
        If Me.TextBox665.Text = "" Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox665.Text) >= 0 And Val(TextBox665.Text) <= 40 Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox665.Text) >= 41 And Val(TextBox665.Text) <= 100000 Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Mathematics MCQ Marks     ")
            Me.TextBox665.Text = ""
        Else
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox675.Text = "" Then
            Me.TextBox96.Text = "0"
            Me.TextBox104.Text = "F"
            Me.TextBox552.Text = "0.00"
        End If

        If Me.TextBox665.Text = "" Then
            Me.TextBox96.Text = "0"
            Me.TextBox104.Text = "F"
            Me.TextBox552.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label158.Text = "03." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label158.Text = "Mathematics" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        End If
    End Sub
    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox96_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox96.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox96_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox96.TextChanged
        'Mathematics    100
        If IsNumeric(TextBox96.Text) Then
            If Val(TextBox96.Text) >= 80 And Val(TextBox96.Text) <= 100 Then
                Me.TextBox104.Text = "A+"
                Me.TextBox552.Text = "5.00"
            ElseIf Val(TextBox96.Text) >= 70 And Val(TextBox96.Text) <= 79 Then
                Me.TextBox104.Text = "A"
                Me.TextBox552.Text = "4.00"
            ElseIf Val(TextBox96.Text) >= 60 And Val(TextBox96.Text) <= 69 Then
                Me.TextBox104.Text = "A-"
                Me.TextBox552.Text = "3.50"
            ElseIf Val(TextBox96.Text) >= 50 And Val(TextBox96.Text) <= 59 Then
                Me.TextBox104.Text = "B"
                Me.TextBox552.Text = "3.00"
            ElseIf Val(TextBox96.Text) >= 40 And Val(TextBox96.Text) <= 49 Then
                Me.TextBox104.Text = "C"
                TextBox552.Text = "2.00"
            ElseIf Val(TextBox96.Text) >= 32 And Val(TextBox96.Text) <= 39 Then
                Me.TextBox104.Text = "D"
                Me.TextBox552.Text = "1.00"
            Else
                Me.TextBox104.Text = "F"
                Me.TextBox552.Text = "0.00"
            End If
        End If

    End Sub

    'Bangladesh and Global Studies
    Private Sub TextBox674_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox674.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label58.Text = "04." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox674_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox674.TextChanged
        Me.TextBox98.Text = Val(TextBox674.Text) + Val(TextBox664.Text)

        If Label58.Text = "Bangladesh and Global Studies" Then
            If Me.TextBox674.Text = "" Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 60 Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox674.Text) >= 61 And Val(TextBox674.Text) <= 100000 Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Bangladesh and Global Studies Creative Marks      ")
                Me.TextBox674.Text = ""
            Else
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label58.Text = "Science" Then
            If Me.TextBox674.Text = "" Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 60 Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox674.Text) >= 61 And Val(TextBox674.Text) <= 100000 Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Science Creative Marks      ")
                Me.TextBox674.Text = ""
            Else
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        End If






        'If Label58.Text = "Higher Mathematics" Then
        '    If Me.TextBox674.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 40 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox674.Text) >= 41 And Val(TextBox674.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Higher Mathematics Creative Marks      ")
        '        Me.TextBox674.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Biology" Then
        '    If Me.TextBox674.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 40 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox674.Text) >= 41 And Val(TextBox674.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Biology Creative Marks      ")
        '        Me.TextBox674.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Computer Study" Then
        '    If Me.TextBox674.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 40 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox674.Text) >= 41 And Val(TextBox674.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Computer Study Creative Marks      ")
        '        Me.TextBox674.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Agriculture Studies" Then
        '    If Me.TextBox674.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 60 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox674.Text) >= 61 And Val(TextBox674.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Agriculture Studies Creative Marks      ")
        '        Me.TextBox674.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Islam and moral Education" Then
        '    If Me.TextBox674.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 60 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox674.Text) >= 61 And Val(TextBox674.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Islam and moral Education Creative Marks      ")
        '        Me.TextBox674.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Hindu Religion and moral Education" Then
        '    If Me.TextBox674.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 60 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox674.Text) >= 61 And Val(TextBox674.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Hindu Religion and moral Education Creative Marks      ")
        '        Me.TextBox674.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Christian Religion and moral Education" Then
        '    If Me.TextBox674.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 60 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox674.Text) >= 61 And Val(TextBox674.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Christian Religion and moral Education Creative Marks      ")
        '        Me.TextBox674.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Buddhist Religion and moral Education" Then
        '    If Me.TextBox674.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox674.Text) >= 0 And Val(TextBox674.Text) <= 60 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox674.Text) >= 61 And Val(TextBox674.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Buddhist Religion and moral Education Creative Marks      ")
        '        Me.TextBox674.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'End If


        If Me.TextBox674.Text = "" Then
            Me.TextBox98.Text = "0"
            Me.TextBox105.Text = "F"
            Me.TextBox116.Text = "0.00"
        End If

        If Me.TextBox664.Text = "" Then
            Me.TextBox98.Text = "0"
            Me.TextBox105.Text = "F"
            Me.TextBox116.Text = "0.00"
        End If

        'If Me.TextBox7.Text = "" Then
        '    Me.TextBox98.Text = "0"
        '    Me.TextBox105.Text = "F"
        '    Me.TextBox116.Text = "0.00"
        'End If

        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox664_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox664.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label58.Text = "04." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox664_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox664.TextChanged
        Me.TextBox98.Text = Val(TextBox674.Text) + Val(TextBox664.Text)



        If Label58.Text = "Bangladesh and Global Studies" Then
            If Me.TextBox664.Text = "" Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 40 Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox664.Text) >= 41 And Val(TextBox664.Text) <= 100000 Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Bangladesh and Global Studies MCQ Marks     ")
                Me.TextBox664.Text = ""
            Else
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label58.Text = "Science" Then
            If Me.TextBox664.Text = "" Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 40 Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox664.Text) >= 41 And Val(TextBox664.Text) <= 100000 Then
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Science MCQ Marks     ")
                Me.TextBox664.Text = ""
            Else
                Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        End If

        'If Label58.Text = "Higher Mathematics" Then
        '    If Me.TextBox664.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 35 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox664.Text) >= 36 And Val(TextBox664.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Higher Mathematics MCQ Marks     ")
        '        Me.TextBox664.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Biology" Then
        '    If Me.TextBox664.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 35 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox664.Text) >= 36 And Val(TextBox664.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Biology MCQ Marks     ")
        '        Me.TextBox664.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Computer Study" Then
        '    If Me.TextBox664.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 30 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox664.Text) >= 31 And Val(TextBox664.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-30 Value", MsgBoxStyle.Critical, "Computer Study MCQ Marks     ")
        '        Me.TextBox664.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Agriculture Studies" Then
        '    If Me.TextBox664.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 35 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox664.Text) >= 36 And Val(TextBox664.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Agriculture Studies MCQ Marks     ")
        '        Me.TextBox664.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Islam and moral Education" Then
        '    If Me.TextBox664.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 40 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox664.Text) >= 41 And Val(TextBox664.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Islam and moral Education MCQ Marks     ")
        '        Me.TextBox664.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Hindu Religion and moral Education" Then
        '    If Me.TextBox664.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 40 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox664.Text) >= 41 And Val(TextBox664.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Hindu Religion and moral Education MCQ Marks     ")
        '        Me.TextBox664.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Christian Religion and moral Education" Then
        '    If Me.TextBox664.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 40 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox664.Text) >= 41 And Val(TextBox664.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Christian Religion and moral Education MCQ Marks     ")
        '        Me.TextBox664.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Buddhist Religion and moral Education" Then
        '    If Me.TextBox664.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox664.Text) >= 0 And Val(TextBox664.Text) <= 40 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox664.Text) >= 41 And Val(TextBox664.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Buddhist Religion and moral Education MCQ Marks     ")
        '        Me.TextBox664.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'End If

        If Me.TextBox674.Text = "" Then
            Me.TextBox98.Text = "0"
            Me.TextBox105.Text = "F"
            Me.TextBox116.Text = "0.00"
        End If

        If Me.TextBox664.Text = "" Then
            Me.TextBox98.Text = "0"
            Me.TextBox105.Text = "F"
            Me.TextBox116.Text = "0.00"
        End If

        'If Me.TextBox7.Text = "" Then
        '    Me.TextBox98.Text = "0"
        '    Me.TextBox105.Text = "F"
        '    Me.TextBox116.Text = "0.00"
        'End If

        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label58.Text = "04." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label58.Text = "Bangladesh and Global Studies" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select

        ElseIf Label58.Text = "Science" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        End If
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        'Me.TextBox98.Text = Val(TextBox674.Text) + Val(TextBox664.Text) + Val(TextBox7.Text)

        'If Label58.Text = "Higher Mathematics" Then
        '    If Me.TextBox7.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox7.Text) >= 0 And Val(TextBox7.Text) <= 25 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox7.Text) >= 26 And Val(TextBox7.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Higher Mathematics MCQ Marks     ")
        '        Me.TextBox7.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Biology" Then
        '    If Me.TextBox7.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox7.Text) >= 0 And Val(TextBox7.Text) <= 25 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox7.Text) >= 26 And Val(TextBox7.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Biology MCQ Marks     ")
        '        Me.TextBox7.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Computer Study" Then
        '    If Me.TextBox7.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox7.Text) >= 0 And Val(TextBox7.Text) <= 30 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox7.Text) >= 31 And Val(TextBox7.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-30 Value", MsgBoxStyle.Critical, "Computer Study MCQ Marks     ")
        '        Me.TextBox7.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'ElseIf Label58.Text = "Agriculture Studies" Then
        '    If Me.TextBox7.Text = "" Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Normal_Numbar
        '    ElseIf Val(TextBox7.Text) >= 0 And Val(TextBox7.Text) <= 25 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Valide_Numbar
        '    ElseIf Val(TextBox7.Text) >= 26 And Val(TextBox7.Text) <= 100000 Then
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '        MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Agriculture Studies MCQ Marks     ")
        '        Me.TextBox7.Text = ""
        '    Else
        '        Me.PictureBox33.Image = Global.Student_Database.My.Resources.Invalide_Numbar
        '    End If

        'End If

        'If Me.TextBox674.Text = "" Then
        '    Me.TextBox98.Text = "0"
        '    Me.TextBox105.Text = "F"
        '    Me.TextBox116.Text = "0.00"
        'End If

        'If Me.TextBox664.Text = "" Then
        '    Me.TextBox98.Text = "0"
        '    Me.TextBox105.Text = "F"
        '    Me.TextBox116.Text = "0.00"
        'End If

        'If Me.TextBox7.Text = "" Then
        '    Me.TextBox98.Text = "0"
        '    Me.TextBox105.Text = "F"
        '    Me.TextBox116.Text = "0.00"
        'End If

        'Me.Seven_1st_MarkInformation()
    End Sub
    Private Sub TextBox98_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox98.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox98_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox98.TextChanged
        If IsNumeric(TextBox98.Text) Then
            If Val(TextBox98.Text) >= 80 And Val(TextBox98.Text) <= 100 Then
                Me.TextBox105.Text = "A+"
                Me.TextBox116.Text = "5.00"
            ElseIf Val(TextBox98.Text) >= 70 And Val(TextBox98.Text) <= 79 Then
                Me.TextBox105.Text = "A"
                Me.TextBox116.Text = "4.00"
            ElseIf Val(TextBox98.Text) >= 60 And Val(TextBox98.Text) <= 69 Then
                Me.TextBox105.Text = "A-"
                Me.TextBox116.Text = "3.50"
            ElseIf Val(TextBox98.Text) >= 50 And Val(TextBox98.Text) <= 59 Then
                Me.TextBox105.Text = "B"
                Me.TextBox116.Text = "3.00"
            ElseIf Val(TextBox98.Text) >= 40 And Val(TextBox98.Text) <= 49 Then
                Me.TextBox105.Text = "C"
                Me.TextBox116.Text = "2.00"
            ElseIf Val(TextBox98.Text) >= 32 And Val(TextBox98.Text) <= 39 Then
                Me.TextBox105.Text = "D"
                Me.TextBox116.Text = "1.00"
            Else
                Me.TextBox105.Text = "F"
                Me.TextBox116.Text = "0.00"
            End If
        End If

    End Sub

    'Science
    Private Sub TextBox673_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox673.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label59.Text = "05." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox673_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox673.TextChanged
        Me.TextBox99.Text = Val(TextBox673.Text) + Val(TextBox663.Text)

        If Label59.Text = "Islam Religion and moral Education" Then
            If Me.TextBox673.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox673.Text) >= 0 And Val(TextBox673.Text) <= 60 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox673.Text) >= 61 And Val(TextBox673.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Islam Religion and moral Education Creative Marks     ")
                Me.TextBox673.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label59.Text = "Hindu Religion and moral Education" Then
            If Me.TextBox673.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox673.Text) >= 0 And Val(TextBox673.Text) <= 60 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox673.Text) >= 61 And Val(TextBox673.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Hindu Religion and moral Education Creative Marks     ")
                Me.TextBox673.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label59.Text = "Christian Religion and moral Education" Then
            If Me.TextBox673.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox673.Text) >= 0 And Val(TextBox673.Text) <= 60 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox673.Text) >= 61 And Val(TextBox673.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Christian Religion and moral Education Creative Marks     ")
                Me.TextBox673.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label59.Text = "Buddhist Religion and moral Education" Then
            If Me.TextBox673.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox673.Text) >= 0 And Val(TextBox673.Text) <= 60 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox673.Text) >= 61 And Val(TextBox673.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Buddhist Religion and moral Education Creative Marks     ")
                Me.TextBox673.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox673.Text = "" Then
            Me.TextBox99.Text = "0"
            Me.TextBox107.Text = "F"
            Me.TextBox114.Text = "0.00"
        End If

        If Me.TextBox663.Text = "" Then
            Me.TextBox99.Text = "0"
            Me.TextBox107.Text = "F"
            Me.TextBox114.Text = "0.00"
        End If

        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox663_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox663.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label59.Text = "05." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox663_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox663.TextChanged
        Me.TextBox99.Text = Val(TextBox673.Text) + Val(TextBox663.Text)

        If Label59.Text = "Islam Religion and moral Education" Then
            If Me.TextBox663.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox663.Text) >= 0 And Val(TextBox663.Text) <= 40 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox663.Text) >= 41 And Val(TextBox663.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Islam Religion and moral Education MCQ Marks     ")
                Me.TextBox663.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label59.Text = "Hindu Religion and moral Education" Then
            If Me.TextBox663.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox663.Text) >= 0 And Val(TextBox663.Text) <= 40 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox663.Text) >= 41 And Val(TextBox663.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Hindu Religion and moral Education MCQ Marks     ")
                Me.TextBox663.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If


        ElseIf Label59.Text = "Christian Religion and moral Education" Then
            If Me.TextBox663.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox663.Text) >= 0 And Val(TextBox663.Text) <= 40 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox663.Text) >= 41 And Val(TextBox663.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Christian Religion and moral Education MCQ Marks     ")
                Me.TextBox663.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If


        ElseIf Label59.Text = "Buddhist Religion and moral Education" Then
            If Me.TextBox663.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox663.Text) >= 0 And Val(TextBox663.Text) <= 40 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox663.Text) >= 41 And Val(TextBox663.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Buddhist Religion and moral Education MCQ Marks     ")
                Me.TextBox663.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox673.Text = "" Then
            Me.TextBox99.Text = "0"
            Me.TextBox107.Text = "F"
            Me.TextBox114.Text = "0.00"
        End If

        If Me.TextBox663.Text = "" Then
            Me.TextBox99.Text = "0"
            Me.TextBox107.Text = "F"
            Me.TextBox114.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label59.Text = "05." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label59.Text = "Islam Religion and moral Education" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select

        ElseIf Label59.Text = "Hindu Religion and moral Education" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        ElseIf Label59.Text = "Christian Religion and moral Education" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        ElseIf Label59.Text = "Buddhist Religion and moral Education" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        End If
    End Sub
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub TextBox99_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox99.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox99_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox99.TextChanged
        If IsNumeric(TextBox99.Text) Then
            If Val(TextBox99.Text) >= 80 And Val(TextBox99.Text) <= 100 Then
                Me.TextBox107.Text = "A+"
                Me.TextBox114.Text = "5.00"
            ElseIf Val(TextBox99.Text) >= 70 And Val(TextBox99.Text) <= 79 Then
                Me.TextBox107.Text = "A"
                Me.TextBox114.Text = "4.00"
            ElseIf Val(TextBox99.Text) >= 60 And Val(TextBox99.Text) <= 69 Then
                Me.TextBox107.Text = "A-"
                Me.TextBox114.Text = "3.50"
            ElseIf Val(TextBox99.Text) >= 50 And Val(TextBox99.Text) <= 59 Then
                Me.TextBox107.Text = "B"
                Me.TextBox114.Text = "3.00"
            ElseIf Val(TextBox99.Text) >= 40 And Val(TextBox99.Text) <= 49 Then
                Me.TextBox107.Text = "C"
                Me.TextBox114.Text = "2.00"
            ElseIf Val(TextBox99.Text) >= 32 And Val(TextBox99.Text) <= 39 Then
                Me.TextBox107.Text = "D"
                Me.TextBox114.Text = "1.00"
            Else
                Me.TextBox107.Text = "F"
                Me.TextBox114.Text = "0.00"
            End If
        End If

    End Sub

    'Combobox 6

    Private Sub TextBox672_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox672.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label60.Text = "06." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox672_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox672.TextChanged
        Me.TextBox100.Text = Val(TextBox672.Text) + Val(TextBox662.Text) + Val(TextBox5.Text)

        If Label60.Text = "Physics" Then
            If Me.TextBox672.Text = "" Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox672.Text) >= 0 And Val(TextBox672.Text) <= 40 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox672.Text) >= 41 And Val(TextBox672.Text) <= 100000 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Physics Creative Marks     ")
                Me.TextBox672.Text = ""
            Else
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label60.Text = "Business Enterprises" Then
            If Me.TextBox672.Text = "" Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox672.Text) >= 0 And Val(TextBox672.Text) <= 60 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox672.Text) >= 61 And Val(TextBox672.Text) <= 100000 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Business Enterprises Creative Marks     ")
                Me.TextBox672.Text = ""
            Else
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label60.Text = "Geography and Environment" Then
            If Me.TextBox672.Text = "" Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox672.Text) >= 0 And Val(TextBox672.Text) <= 60 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox672.Text) >= 61 And Val(TextBox672.Text) <= 100000 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Geography and Environment Creative Marks     ")
                Me.TextBox672.Text = ""
            Else
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox672.Text = "" Then
            Me.TextBox100.Text = "0"
            Me.TextBox109.Text = "F"
            Me.TextBox112.Text = "0.00"
        End If

        If Me.TextBox662.Text = "" Then
            Me.TextBox100.Text = "0"
            Me.TextBox109.Text = "F"
            Me.TextBox112.Text = "0.00"
        End If

        If Label60.Text = "Physics" Then
            If Me.TextBox5.Text = "" Then
                Me.TextBox100.Text = "0"
                Me.TextBox109.Text = "F"
                Me.TextBox112.Text = "0.00"
            End If
        End If


        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox662_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox662.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label60.Text = "06." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox662_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox662.TextChanged
        Me.TextBox100.Text = Val(TextBox672.Text) + Val(TextBox662.Text) + Val(TextBox5.Text)

        If Label60.Text = "Physics" Then
            If Me.TextBox662.Text = "" Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox662.Text) >= 0 And Val(TextBox662.Text) <= 35 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox662.Text) >= 36 And Val(TextBox662.Text) <= 100000 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Physics MCQ Marks     ")
                Me.TextBox662.Text = ""
            Else
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label60.Text = "Business Enterprises" Then
            If Me.TextBox662.Text = "" Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox662.Text) >= 0 And Val(TextBox662.Text) <= 40 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox662.Text) >= 41 And Val(TextBox662.Text) <= 100000 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Business Enterprises MCQ Marks     ")
                Me.TextBox662.Text = ""
            Else
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label60.Text = "Geography and Environment" Then
            If Me.TextBox662.Text = "" Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox662.Text) >= 0 And Val(TextBox662.Text) <= 40 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox662.Text) >= 41 And Val(TextBox662.Text) <= 100000 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Geography and Environment MCQ Marks     ")
                Me.TextBox662.Text = ""
            Else
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox672.Text = "" Then
            Me.TextBox100.Text = "0"
            Me.TextBox109.Text = "F"
            Me.TextBox112.Text = "0.00"
        End If

        If Me.TextBox662.Text = "" Then
            Me.TextBox100.Text = "0"
            Me.TextBox109.Text = "F"
            Me.TextBox112.Text = "0.00"
        End If

        If Label60.Text = "Physics" Then
            If Me.TextBox5.Text = "" Then
                Me.TextBox100.Text = "0"
                Me.TextBox109.Text = "F"
                Me.TextBox112.Text = "0.00"
            End If
        End If
        Me.Seven_1st_MarkInformation()

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label60.Text = "06." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label60.Text = "Physics" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label60.Text = "Business Enterprises" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select

        ElseIf Label60.Text = "Geography and Environment" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        End If


    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If Label60.Text = "Physics" Then
            Me.TextBox100.Text = Val(TextBox672.Text) + Val(TextBox662.Text) + Val(TextBox5.Text)
            If Me.TextBox5.Text = "" Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox5.Text) >= 0 And Val(TextBox5.Text) <= 25 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox5.Text) >= 26 And Val(TextBox5.Text) <= 100000 Then
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Physics Piratical Marks     ")
                Me.TextBox5.Text = ""
            Else
                Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

            If Me.TextBox672.Text = "" Then
                Me.TextBox100.Text = "0"
                Me.TextBox109.Text = "F"
                Me.TextBox112.Text = "0.00"
            End If

            If Me.TextBox662.Text = "" Then
                Me.TextBox100.Text = "0"
                Me.TextBox109.Text = "F"
                Me.TextBox112.Text = "0.00"
            End If

            If Label60.Text = "Physics" Then
                If Me.TextBox5.Text = "" Then
                    Me.TextBox100.Text = "0"
                    Me.TextBox109.Text = "F"
                    Me.TextBox112.Text = "0.00"
                End If
            End If


            Me.Seven_1st_MarkInformation()

        End If
    End Sub
    Private Sub TextBox100_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox100.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox100_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox100.TextChanged
        If IsNumeric(TextBox100.Text) Then
            If Val(TextBox100.Text) >= 80 And Val(TextBox100.Text) <= 100 Then
                Me.TextBox109.Text = "A+"
                Me.TextBox112.Text = "5.00"
            ElseIf Val(TextBox100.Text) >= 70 And Val(TextBox100.Text) <= 79 Then
                Me.TextBox109.Text = "A"
                Me.TextBox112.Text = "4.00"
            ElseIf Val(TextBox100.Text) >= 60 And Val(TextBox100.Text) <= 69 Then
                Me.TextBox109.Text = "A-"
                Me.TextBox112.Text = "3.50"
            ElseIf Val(TextBox100.Text) >= 50 And Val(TextBox100.Text) <= 59 Then
                Me.TextBox109.Text = "B"
                Me.TextBox112.Text = "3.00"
            ElseIf Val(TextBox100.Text) >= 40 And Val(TextBox100.Text) <= 49 Then
                Me.TextBox109.Text = "C"
                Me.TextBox112.Text = "2.00"
            ElseIf Val(TextBox100.Text) >= 32 And Val(TextBox100.Text) <= 39 Then
                Me.TextBox109.Text = "D"
                Me.TextBox112.Text = "1.00"
            Else
                Me.TextBox109.Text = "F"
                Me.TextBox112.Text = "0.00"
            End If
        End If

    End Sub

    'Islam and Moral Education
    Private Sub TextBox671_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox671.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label61.Text = "07." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox671_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox671.TextChanged
        Me.TextBox101.Text = Val(TextBox671.Text) + Val(TextBox661.Text) + Val(TextBox4.Text)

        If Label61.Text = "Chemistry" Then
            If Me.TextBox671.Text = "" Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox671.Text) >= 0 And Val(TextBox671.Text) <= 40 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox671.Text) >= 41 And Val(TextBox671.Text) <= 100000 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Chemistry Creative Marks     ")
                Me.TextBox671.Text = ""
            Else
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label61.Text = "Finance and Banking" Then
            If Me.TextBox671.Text = "" Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox671.Text) >= 0 And Val(TextBox671.Text) <= 60 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox671.Text) >= 61 And Val(TextBox671.Text) <= 100000 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Finance and Banking Creative Marks     ")
                Me.TextBox671.Text = ""
            Else
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label61.Text = "History of Bangladesh and World Civilization" Then
            If Me.TextBox671.Text = "" Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox671.Text) >= 0 And Val(TextBox671.Text) <= 60 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox671.Text) >= 61 And Val(TextBox671.Text) <= 100000 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "History of Bangladesh and World Civilization Creative Marks     ")
                Me.TextBox671.Text = ""
            Else
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        End If


        If Me.TextBox671.Text = "" Then
            Me.TextBox101.Text = "0"
            Me.TextBox111.Text = "F"
            Me.TextBox110.Text = "0.00"
        End If

        If Me.TextBox661.Text = "" Then
            Me.TextBox101.Text = "0"
            Me.TextBox111.Text = "F"
            Me.TextBox110.Text = "0.00"
        End If

        If Label61.Text = "Chemistry" Then
            If Me.TextBox4.Text = "" Then
                Me.TextBox101.Text = "0"
                Me.TextBox111.Text = "F"
                Me.TextBox110.Text = "0.00"
            End If
        End If

        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox661_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox661.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label61.Text = "07." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox661_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox661.TextChanged
        Me.TextBox101.Text = Val(TextBox671.Text) + Val(TextBox661.Text) + Val(TextBox4.Text)
        If Label61.Text = "Chemistry" Then
            If Me.TextBox661.Text = "" Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox661.Text) >= 0 And Val(TextBox661.Text) <= 35 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox661.Text) >= 36 And Val(TextBox661.Text) <= 100000 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Chemistry MCQ Marks     ")
                Me.TextBox661.Text = ""
            Else
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label61.Text = "Finance and Banking" Then
            If Me.TextBox661.Text = "" Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox661.Text) >= 0 And Val(TextBox661.Text) <= 40 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox661.Text) >= 41 And Val(TextBox661.Text) <= 100000 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Finance and Banking MCQ Marks     ")
                Me.TextBox661.Text = ""
            Else
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label61.Text = "History of Bangladesh and World Civilization" Then
            If Me.TextBox661.Text = "" Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox661.Text) >= 0 And Val(TextBox661.Text) <= 40 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox661.Text) >= 41 And Val(TextBox661.Text) <= 100000 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "History of Bangladesh and World Civilization MCQ Marks     ")
                Me.TextBox661.Text = ""
            Else
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        End If

        If Me.TextBox671.Text = "" Then
            Me.TextBox101.Text = "0"
            Me.TextBox111.Text = "F"
            Me.TextBox110.Text = "0.00"
        End If

        If Me.TextBox661.Text = "" Then
            Me.TextBox101.Text = "0"
            Me.TextBox111.Text = "F"
            Me.TextBox110.Text = "0.00"
        End If

        If Label61.Text = "Chemistry" Then
            If Me.TextBox4.Text = "" Then
                Me.TextBox101.Text = "0"
                Me.TextBox111.Text = "F"
                Me.TextBox110.Text = "0.00"
            End If
        End If

        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label61.Text = "07." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label61.Text = "Chemistry" Then

            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

        ElseIf Label61.Text = "Finance and Banking" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select

        ElseIf Label61.Text = "History of Bangladesh and World Civilization" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        End If

    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Me.TextBox101.Text = Val(TextBox671.Text) + Val(TextBox661.Text) + Val(TextBox4.Text)
        If Label61.Text = "Chemistry" Then
            If Me.TextBox4.Text = "" Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox4.Text) >= 0 And Val(TextBox4.Text) <= 25 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox4.Text) >= 26 And Val(TextBox4.Text) <= 100000 Then
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Chemistry Piratical Marks     ")
                Me.TextBox4.Text = ""
            Else
                Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

            If Me.TextBox671.Text = "" Then
                Me.TextBox101.Text = "0"
                Me.TextBox111.Text = "F"
                Me.TextBox110.Text = "0.00"
            End If

            If Me.TextBox661.Text = "" Then
                Me.TextBox101.Text = "0"
                Me.TextBox111.Text = "F"
                Me.TextBox110.Text = "0.00"
            End If

            If Label61.Text = "Chemistry" Then
                If Me.TextBox4.Text = "" Then
                    Me.TextBox101.Text = "0"
                    Me.TextBox111.Text = "F"
                    Me.TextBox110.Text = "0.00"
                End If
            End If


            Me.Seven_1st_MarkInformation()
        End If

    End Sub
    Private Sub TextBox101_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox101.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox101_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox101.TextChanged
        If IsNumeric(TextBox101.Text) Then
            If Val(TextBox101.Text) >= 80 And Val(TextBox101.Text) <= 100 Then
                Me.TextBox111.Text = "A+"
                Me.TextBox110.Text = "5.00"
            ElseIf Val(TextBox101.Text) >= 70 And Val(TextBox101.Text) <= 79 Then
                Me.TextBox111.Text = "A"
                Me.TextBox110.Text = "4.00"
            ElseIf Val(TextBox101.Text) >= 60 And Val(TextBox101.Text) <= 69 Then
                Me.TextBox111.Text = "A-"
                Me.TextBox110.Text = "3.50"
            ElseIf Val(TextBox101.Text) >= 50 And Val(TextBox101.Text) <= 59 Then
                Me.TextBox111.Text = "B"
                Me.TextBox110.Text = "3.00"
            ElseIf Val(TextBox101.Text) >= 40 And Val(TextBox101.Text) <= 49 Then
                Me.TextBox111.Text = "C"
                Me.TextBox110.Text = "2.00"
            ElseIf Val(TextBox101.Text) >= 32 And Val(TextBox101.Text) <= 39 Then
                Me.TextBox111.Text = "D"
                Me.TextBox110.Text = "1.00"
            Else
                Me.TextBox111.Text = "F"
                Me.TextBox110.Text = "0.00"
            End If
        End If

    End Sub

    'Phycical Education and Helth
    Private Sub TextBox670_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox670.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label62.Text = "08." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox670_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox670.TextChanged
        Me.TextBox102.Text = Val(TextBox670.Text) + Val(TextBox660.Text) + Val(TextBox3.Text)

        If Label62.Text = "Higher Mathematics" Then
            If Me.TextBox670.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox670.Text) >= 0 And Val(TextBox670.Text) <= 40 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox670.Text) >= 41 And Val(TextBox670.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Higher Mathematics Creative Marks     ")
                Me.TextBox670.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        ElseIf Label62.Text = "Biology" Then
            If Me.TextBox670.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox670.Text) >= 0 And Val(TextBox670.Text) <= 40 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox670.Text) >= 41 And Val(TextBox670.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Biology Creative Marks     ")
                Me.TextBox670.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        ElseIf Label62.Text = "Computer Study" Then
            If Me.TextBox670.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox670.Text) >= 0 And Val(TextBox670.Text) <= 40 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox670.Text) >= 41 And Val(TextBox670.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Computer Study Creative Marks     ")
                Me.TextBox670.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label62.Text = "Agriculture Studies" Then
            If Me.TextBox670.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox670.Text) >= 0 And Val(TextBox670.Text) <= 40 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox670.Text) >= 41 And Val(TextBox670.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Agriculture Studies Creative Marks     ")
                Me.TextBox670.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        ElseIf Label62.Text = "Accounting" Then
            If Me.TextBox670.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox670.Text) >= 0 And Val(TextBox670.Text) <= 60 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox670.Text) >= 61 And Val(TextBox670.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Accounting Creative Marks     ")
                Me.TextBox670.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        ElseIf Label62.Text = "Economics" Then
            If Me.TextBox670.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox670.Text) >= 0 And Val(TextBox670.Text) <= 60 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox670.Text) >= 61 And Val(TextBox670.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Economics Creative Marks     ")
                Me.TextBox670.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        ElseIf Label62.Text = "Civics and Citizenship" Then
            If Me.TextBox670.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox670.Text) >= 0 And Val(TextBox670.Text) <= 60 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox670.Text) >= 61 And Val(TextBox670.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-60 Value", MsgBoxStyle.Critical, "Civics and Citizenship Creative Marks     ")
                Me.TextBox670.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If


        If Me.TextBox670.Text = "" Then
            Me.TextBox102.Text = "0"
            Me.TextBox113.Text = "F"
            Me.TextBox108.Text = "0.00"
        End If

        If Me.TextBox660.Text = "" Then
            Me.TextBox102.Text = "0"
            Me.TextBox113.Text = "F"
            Me.TextBox108.Text = "0.00"
        End If

        If Label62.Text = "Higher Mathematics" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Biology" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Computer Study" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Agriculture Studies" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If



        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox660_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox660.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label62.Text = "08." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox660_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox660.TextChanged
        Me.TextBox102.Text = Val(TextBox670.Text) + Val(TextBox660.Text) + Val(TextBox3.Text)

        If Label62.Text = "Higher Mathematics" Then
            If Me.TextBox660.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox660.Text) >= 0 And Val(TextBox660.Text) <= 35 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox660.Text) >= 36 And Val(TextBox660.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Higher Mathematics MCQ Marks     ")
                Me.TextBox660.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label62.Text = "Biology" Then
            If Me.TextBox660.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox660.Text) >= 0 And Val(TextBox660.Text) <= 35 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox660.Text) >= 36 And Val(TextBox660.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Biology MCQ Marks     ")
                Me.TextBox660.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label62.Text = "Computer Study" Then
            If Me.TextBox660.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox660.Text) >= 0 And Val(TextBox660.Text) <= 30 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox660.Text) >= 36 And Val(TextBox660.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-30 Value", MsgBoxStyle.Critical, "Computer Study MCQ Marks     ")
                Me.TextBox660.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label62.Text = "Agriculture Studies" Then
            If Me.TextBox660.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox660.Text) >= 0 And Val(TextBox660.Text) <= 35 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox660.Text) >= 36 And Val(TextBox660.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Agriculture Studies MCQ Marks     ")
                Me.TextBox660.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        ElseIf Label62.Text = "Accounting" Then
            If Me.TextBox660.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox660.Text) >= 0 And Val(TextBox660.Text) <= 40 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox660.Text) >= 41 And Val(TextBox660.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Accounting MCQ Marks     ")
                Me.TextBox660.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        ElseIf Label62.Text = "Economics" Then
            If Me.TextBox660.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox660.Text) >= 0 And Val(TextBox660.Text) <= 40 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox660.Text) >= 41 And Val(TextBox660.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Economics MCQ Marks     ")
                Me.TextBox660.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label62.Text = "Civics and Citizenship" Then
            If Me.TextBox660.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox660.Text) >= 0 And Val(TextBox660.Text) <= 40 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox660.Text) >= 41 And Val(TextBox660.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Civics and Citizenship MCQ Marks     ")
                Me.TextBox660.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        End If


        If Me.TextBox670.Text = "" Then
            Me.TextBox102.Text = "0"
            Me.TextBox113.Text = "F"
            Me.TextBox108.Text = "0.00"
        End If

        If Me.TextBox660.Text = "" Then
            Me.TextBox102.Text = "0"
            Me.TextBox113.Text = "F"
            Me.TextBox108.Text = "0.00"
        End If

        If Label62.Text = "Higher Mathematics" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Biology" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Computer Study" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Agriculture Studies" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If



        Me.Seven_1st_MarkInformation()

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label62.Text = "08." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label62.Text = "Higher Mathematics" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label62.Text = "Biology" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label62.Text = "Computer Study" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label62.Text = "Agriculture Studies" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label62.Text = "Accounting" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        ElseIf Label62.Text = "Economics" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        ElseIf Label62.Text = "Civics and Citizenship" Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input Piratical Marks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TextBox7.Clear()
            End Select
        End If
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Me.TextBox102.Text = Val(TextBox670.Text) + Val(TextBox660.Text) + Val(TextBox3.Text)

        If Label62.Text = "Higher Mathematics" Then
            If Me.TextBox3.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 25 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox3.Text) >= 26 And Val(TextBox3.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Higher Mathematics Piratical Marks     ")
                Me.TextBox3.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label62.Text = "Biology" Then
            If Me.TextBox3.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 25 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox3.Text) >= 26 And Val(TextBox3.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Biology Piratical Marks     ")
                Me.TextBox3.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label62.Text = "Computer Study" Then
            If Me.TextBox3.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 30 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox3.Text) >= 31 And Val(TextBox3.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-30 Value", MsgBoxStyle.Critical, "Computer Study Piratical Marks     ")
                Me.TextBox3.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label62.Text = "Agriculture Studies" Then
            If Me.TextBox3.Text = "" Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 25 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox3.Text) >= 26 And Val(TextBox3.Text) <= 100000 Then
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Agriculture Studies Piratical Marks     ")
                Me.TextBox3.Text = ""
            Else
                Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If


        If Me.TextBox670.Text = "" Then
            Me.TextBox102.Text = "0"
            Me.TextBox113.Text = "F"
            Me.TextBox108.Text = "0.00"
        End If

        If Me.TextBox660.Text = "" Then
            Me.TextBox102.Text = "0"
            Me.TextBox113.Text = "F"
            Me.TextBox108.Text = "0.00"
        End If

        If Label62.Text = "Higher Mathematics" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Biology" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Computer Study" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        If Label62.Text = "Agriculture Studies" Then
            If Me.TextBox3.Text = "" Then
                Me.TextBox102.Text = "0"
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox102_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox102.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox102_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox102.TextChanged

        If IsNumeric(TextBox102.Text) Then
            If Val(TextBox102.Text) >= 80 And Val(TextBox102.Text) <= 100 Then
                Me.TextBox113.Text = "A+"
                Me.TextBox108.Text = "5.00"
            ElseIf Val(TextBox102.Text) >= 70 And Val(TextBox102.Text) <= 79 Then
                Me.TextBox113.Text = "A"
                Me.TextBox108.Text = "4.00"
            ElseIf Val(TextBox102.Text) >= 60 And Val(TextBox102.Text) <= 69 Then
                Me.TextBox113.Text = "A-"
                Me.TextBox108.Text = "3.50"
            ElseIf Val(TextBox102.Text) >= 50 And Val(TextBox102.Text) <= 59 Then
                Me.TextBox113.Text = "B"
                Me.TextBox108.Text = "3.00"
            ElseIf Val(TextBox102.Text) >= 40 And Val(TextBox102.Text) <= 49 Then
                Me.TextBox113.Text = "C"
                Me.TextBox108.Text = "2.00"
            ElseIf Val(TextBox102.Text) >= 32 And Val(TextBox102.Text) <= 39 Then
                Me.TextBox113.Text = "D"
                Me.TextBox108.Text = "1.00"
            Else
                Me.TextBox113.Text = "F"
                Me.TextBox108.Text = "0.00"
            End If
        End If

    End Sub

    'Art and Crafts
    Private Sub TextBox669_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox669.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label63.Text = "09." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox669_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox669.TextChanged
        Me.TextBox103.Text = Val(TextBox669.Text) + Val(TextBox659.Text) + Val(TextBox2.Text)

        If Label63.Text = "Physical Education and Health" Then
            If Me.TextBox669.Text = "" Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox669.Text) >= 0 And Val(TextBox669.Text) <= 40 Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox669.Text) >= 41 And Val(TextBox669.Text) <= 100000 Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Physical Education and Health Creative Marks     ")
                Me.TextBox669.Text = ""
            Else
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        End If

        If Me.TextBox669.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If

        If Me.TextBox659.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If

        If Me.TextBox2.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If

        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox659_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox659.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label63.Text = "09." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox659_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox659.TextChanged
        Me.TextBox103.Text = Val(TextBox669.Text) + Val(TextBox659.Text) + Val(TextBox2.Text)

        If Label63.Text = "Physical Education and Health" Then
            If Me.TextBox659.Text = "" Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox659.Text) >= 0 And Val(TextBox659.Text) <= 35 Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox659.Text) >= 36 And Val(TextBox659.Text) <= 100000 Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Physical Education and Health MCQ Marks     ")
                Me.TextBox659.Text = ""
            Else
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        End If


        If Me.TextBox669.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If

        If Me.TextBox659.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If

        If Me.TextBox2.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label63.Text = "09." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label63.Text = "Physical Education and Health" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Me.TextBox103.Text = Val(TextBox669.Text) + Val(TextBox659.Text) + Val(TextBox2.Text)

        If Label63.Text = "Physical Education and Health" Then
            If Me.TextBox2.Text = "" Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox2.Text) >= 0 And Val(TextBox2.Text) <= 25 Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox2.Text) >= 26 And Val(TextBox2.Text) <= 100000 Then
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Physical Education and Health Piratical Marks     ")
                Me.TextBox2.Text = ""
            Else
                Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        End If


        If Me.TextBox669.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If

        If Me.TextBox659.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If

        If Me.TextBox2.Text = "" Then
            Me.TextBox103.Text = "0"
            Me.TextBox115.Text = "F"
            Me.TextBox106.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox103_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox103.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox103_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox103.TextChanged

        If IsNumeric(TextBox103.Text) Then
            If Val(TextBox103.Text) >= 80 And Val(TextBox103.Text) <= 100 Then
                Me.TextBox115.Text = "A+"
                Me.TextBox106.Text = "5.00"
            ElseIf Val(TextBox103.Text) >= 70 And Val(TextBox103.Text) <= 79 Then
                Me.TextBox115.Text = "A"
                Me.TextBox106.Text = "4.00"
            ElseIf Val(TextBox103.Text) >= 60 And Val(TextBox103.Text) <= 69 Then
                Me.TextBox115.Text = "A-"
                Me.TextBox106.Text = "3.50"
            ElseIf Val(TextBox103.Text) >= 50 And Val(TextBox103.Text) <= 59 Then
                Me.TextBox115.Text = "B"
                Me.TextBox106.Text = "3.00"
            ElseIf Val(TextBox103.Text) >= 40 And Val(TextBox103.Text) <= 49 Then
                Me.TextBox115.Text = "C"
                Me.TextBox106.Text = "2.00"
            ElseIf Val(TextBox103.Text) >= 32 And Val(TextBox103.Text) <= 39 Then
                Me.TextBox115.Text = "D"
                Me.TextBox106.Text = "1.00"
            Else
                Me.TextBox115.Text = "F"
                Me.TextBox106.Text = "0.00"
            End If
        End If

    End Sub

    'Information and Communication Technology
    Private Sub TextBox668_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox668.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label64.Text = "10." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox668_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox668.TextChanged
        Me.TextBox79.Text = Val(TextBox668.Text) + Val(TextBox658.Text) + Val(TextBox1.Text)

        If Label64.Text = "Higher Mathematics" Then
            If Me.TextBox668.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox668.Text) >= 0 And Val(TextBox668.Text) <= 40 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox668.Text) >= 41 And Val(TextBox668.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Higher Mathematics Creative Marks     ")
                Me.TextBox668.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Biology" Then
            If Me.TextBox668.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox668.Text) >= 0 And Val(TextBox668.Text) <= 40 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox668.Text) >= 41 And Val(TextBox668.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Biology Creative Marks     ")
                Me.TextBox668.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Computer Study" Then
            If Me.TextBox668.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox668.Text) >= 0 And Val(TextBox668.Text) <= 40 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox668.Text) >= 41 And Val(TextBox668.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Computer Study Creative Marks     ")
                Me.TextBox668.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Agriculture Studies" Then
            If Me.TextBox668.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox668.Text) >= 0 And Val(TextBox668.Text) <= 40 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox668.Text) >= 41 And Val(TextBox668.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Agriculture Studies Creative Marks     ")
                Me.TextBox668.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Home Science" Then
            If Me.TextBox668.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox668.Text) >= 0 And Val(TextBox668.Text) <= 40 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox668.Text) >= 41 And Val(TextBox668.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-40 Value", MsgBoxStyle.Critical, "Home Science Creative Marks     ")
                Me.TextBox668.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox668.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If

        If Me.TextBox658.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If

        If Me.TextBox1.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub
    Private Sub TextBox658_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox658.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label64.Text = "10." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
            Case 13
                e.Handled = True
                SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                KeyAscii = 0
            Case Is <= 32
            Case 48 To 57     '<--- this is for numbers
                Exit Sub
            Case Else
                e.Handled = True
                MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
    Private Sub TextBox658_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox658.TextChanged
        Me.TextBox79.Text = Val(TextBox668.Text) + Val(TextBox658.Text) + Val(TextBox1.Text)

        If Label64.Text = "Higher Mathematics" Then
            If Me.TextBox658.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox658.Text) >= 0 And Val(TextBox658.Text) <= 35 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox658.Text) >= 36 And Val(TextBox658.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Higher Mathematics MCQ Marks     ")
                Me.TextBox658.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Biology" Then
            If Me.TextBox658.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox658.Text) >= 0 And Val(TextBox658.Text) <= 35 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox658.Text) >= 36 And Val(TextBox658.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Biology MCQ Marks     ")
                Me.TextBox658.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Computer Study" Then
            If Me.TextBox658.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox658.Text) >= 0 And Val(TextBox658.Text) <= 30 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox658.Text) >= 31 And Val(TextBox658.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-30 Value", MsgBoxStyle.Critical, "Computer Study MCQ Marks     ")
                Me.TextBox658.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Agriculture Studies" Then
            If Me.TextBox658.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox658.Text) >= 0 And Val(TextBox658.Text) <= 35 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox658.Text) >= 36 And Val(TextBox658.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Agriculture Studies MCQ Marks     ")
                Me.TextBox658.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Home Science" Then
            If Me.TextBox658.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox658.Text) >= 0 And Val(TextBox658.Text) <= 35 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox658.Text) >= 36 And Val(TextBox658.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-35 Value", MsgBoxStyle.Critical, "Home Science MCQ Marks     ")
                Me.TextBox658.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox668.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If

        If Me.TextBox658.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If

        If Me.TextBox1.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If Label64.Text = "10." Then
            Select Case KeyAscii
                Case Else
                    e.Handled = True
                    MessageBox.Show("Do not input data! Please Select Subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        ElseIf Label64.Text = "Higher Mathematics" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label64.Text = "Biology" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label64.Text = "Computer Study" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label64.Text = "Agriculture Studies" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        ElseIf Label64.Text = "Home Science" Then
            Select Case KeyAscii
                Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
                Case 13
                    e.Handled = True
                    SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
                    KeyAscii = 0
                Case Is <= 32
                Case 48 To 57     '<--- this is for numbers
                    Exit Sub
                Case Else
                    e.Handled = True
                    MessageBox.Show("You Can Only Import Number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.TextBox79.Text = Val(TextBox668.Text) + Val(TextBox658.Text) + Val(TextBox1.Text)

        If Label64.Text = "Higher Mathematics" Then
            If Me.TextBox1.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 25 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1.Text) >= 26 And Val(TextBox1.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Higher Mathematics Piratical Marks     ")
                Me.TextBox1.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Biology" Then
            If Me.TextBox1.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 25 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1.Text) >= 26 And Val(TextBox1.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Biology Piratical Marks     ")
                Me.TextBox1.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Computer Study" Then
            If Me.TextBox1.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 30 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1.Text) >= 31 And Val(TextBox1.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-30 Value", MsgBoxStyle.Critical, "Computer Study Piratical Marks     ")
                Me.TextBox1.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Agriculture Studies" Then
            If Me.TextBox1.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 25 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1.Text) >= 26 And Val(TextBox1.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Agriculture Studies Piratical Marks     ")
                Me.TextBox1.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf Label64.Text = "Home Science" Then
            If Me.TextBox1.Text = "" Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 25 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1.Text) >= 26 And Val(TextBox1.Text) <= 100000 Then
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-25 Value", MsgBoxStyle.Critical, "Home Science Piratical Marks     ")
                Me.TextBox1.Text = ""
            Else
                Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox668.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If

        If Me.TextBox658.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If

        If Me.TextBox1.Text = "" Then
            Me.TextBox79.Text = "0"
            Me.TextBox81.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If
        Me.Seven_1st_MarkInformation()
    End Sub
    Private Sub TextBox79_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox79.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox79_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox79.TextChanged
        If IsNumeric(TextBox79.Text) Then
            If Val(TextBox79.Text) >= 80 And Val(TextBox79.Text) <= 100 Then
                Me.TextBox81.Text = "A+"
                Me.TextBox80.Text = "5.00"
            ElseIf Val(TextBox79.Text) >= 70 And Val(TextBox79.Text) <= 79 Then
                Me.TextBox81.Text = "A"
                Me.TextBox80.Text = "4.00"
            ElseIf Val(TextBox79.Text) >= 60 And Val(TextBox79.Text) <= 69 Then
                Me.TextBox81.Text = "A-"
                Me.TextBox80.Text = "3.50"
            ElseIf Val(TextBox79.Text) >= 50 And Val(TextBox79.Text) <= 59 Then
                Me.TextBox81.Text = "B"
                Me.TextBox80.Text = "3.00"
            ElseIf Val(TextBox79.Text) >= 40 And Val(TextBox79.Text) <= 49 Then
                Me.TextBox81.Text = "C"
                Me.TextBox80.Text = "2.00"
            ElseIf Val(TextBox79.Text) >= 32 And Val(TextBox79.Text) <= 39 Then
                Me.TextBox81.Text = "D"
                Me.TextBox80.Text = "1.00"
            Else
                Me.TextBox81.Text = "F"
                Me.TextBox80.Text = "0.00"
            End If
        End If

    End Sub

    'GPA
    Private Sub TextBox85_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox85.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Else
                e.Handled = True
                MessageBox.Show("Do not input data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub TextBox85_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox85.TextChanged
        If IsNumeric(TextBox85.Text) Then
            If Val(TextBox85.Text) > 4.99 Then
                Me.TextBox88.Text = "A+"
            ElseIf Val(TextBox85.Text) > 3.99 Then
                Me.TextBox88.Text = "A"
            ElseIf Val(TextBox85.Text) > 3.49 Then
                Me.TextBox88.Text = "A-"
            ElseIf Val(TextBox85.Text) > 2.99 Then
                Me.TextBox88.Text = "B"
            ElseIf Val(TextBox85.Text) > 1.99 Then
                Me.TextBox88.Text = "C"
            ElseIf Val(TextBox85.Text) > 0.99 Then
                Me.TextBox88.Text = "D"
            Else
                Me.TextBox88.Text = "F"
            End If
        End If

        If IsNumeric(TextBox85.Text) Then
            If Val(TextBox85.Text) >= 4.99 And Val(TextBox85.Text) <= 100000 Then
                TextBox85.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        ''Roll
        'If TextBoxSevenRoll.Text = "" Then
        '    MessageBox.Show("Input ''Roll Number''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.TextBoxSevenRoll.Select()
        '    'Student Name
        'ElseIf Label72.Text = "" Then
        '    MessageBox.Show("Input ''Student Name''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.TextBoxName.Select()
        '    'Father Name
        'ElseIf TextBoxFName.Text = "" Then
        '    MessageBox.Show("Input ''Father Name''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.TextBoxFName.Select()
        '    'Mather Namr
        'ElseIf TextBoxMName.Text = "" Then
        '    MessageBox.Show("Input ''Mother Name''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.TextBoxMName.Select()
        '    'Student Gender
        'ElseIf ComBoxGender.Text = "" Then
        '    MessageBox.Show("Input ''Gender''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.ComBoxGender.Select()
        '    'Date of Birth
        'ElseIf TextBoxDateofBirth.Text = "" Then
        '    MessageBox.Show("Input ''Date of Birth''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.TextBoxDateofBirth.Select()
        '    'Phone Numbar
        'ElseIf TextBoxPhone.Text = "" Then
        '    MessageBox.Show("Input ''Phone Number''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.TextBoxPhone.Select()

        '    'Year
        'ElseIf ComboBox13.Text = "" Then
        '    MessageBox.Show("Input ''Year''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.ComboBox13.Select()


        'Bangla
        If TextBox89.Text = "" Then
            MessageBox.Show("Input ''Bangla I Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox89.Select()
        ElseIf TextBox652.Text = "" Then
            MessageBox.Show("Input ''Bangla II Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox652.Select()
        ElseIf TextBox90.Text = "" Then
            MessageBox.Show("Input ''Bangla I MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox90.Select()
        ElseIf TextBox653.Text = "" Then
            MessageBox.Show("Input ''Bangla II MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox653.Select()

            'Englash
        ElseIf TextBox92.Text = "" Then
            MessageBox.Show("Input ''English I Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox92.Select()
        ElseIf TextBox654.Text = "" Then
            MessageBox.Show("Input ''English II Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox654.Select()
        ElseIf TextBox91.Text = "" Then
            MessageBox.Show("Input ''English I MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox91.Select()
        ElseIf TextBox655.Text = "" Then
            MessageBox.Show("Input ''English II Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox655.Select()

            'Mathematics
        ElseIf TextBox675.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox675.Select()
        ElseIf TextBox665.Text = "" Then
            MessageBox.Show("Input ''Mathematics MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox665.Select()

            'Bangladesh and Global Studies
        ElseIf TextBox674.Text = "" Then
            MessageBox.Show("Input ''Bangladesh and Global Studies Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox674.Select()
        ElseIf TextBox664.Text = "" Then
            MessageBox.Show("Input ''Bangladesh and Global Studies MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox664.Select()

            'Science
        ElseIf TextBox673.Text = "" Then
            MessageBox.Show("Input ''Science Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox673.Select()
        ElseIf TextBox663.Text = "" Then
            MessageBox.Show("Input ''Science MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox663.Select()

            'Agriculture Studies
        ElseIf TextBox672.Text = "" Then
            If Label58.Text = "Agriculture Studies" Then
                MessageBox.Show("Input ''Agriculture Studies Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label58.Text = "Home Science" Then
                MessageBox.Show("Input ''Home Science Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox672.Select()

        ElseIf TextBox662.Text = "" Then
            If Label58.Text = "Agriculture studies" Then
                MessageBox.Show("Input ''Agriculture studies MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label58.Text = "Home Science" Then
                MessageBox.Show("Input ''Home Science MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox662.Select()

            'Islam and Moral Education
        ElseIf TextBox671.Text = "" Then
            If Label61.Text = "Islam and moral Education" Then
                MessageBox.Show("Input ''Islam and moral Education Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label61.Text = "Hindu and moral Education" Then
                MessageBox.Show("Input ''Hindu and moral Education Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label61.Text = "Christian and moral Education" Then
                MessageBox.Show("Input ''Christian and moral Education Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label61.Text = "Buddhist and moral Education" Then
                MessageBox.Show("Input ''Buddhist and moral Education Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox671.Select()

        ElseIf TextBox661.Text = "" Then
            If Label61.Text = "Islam and moral Education" Then
                MessageBox.Show("Input ''Islam and moral Education MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label61.Text = "Hindu and moral Education" Then
                MessageBox.Show("Input ''Hindu and moral Education MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label61.Text = "Christian and moral Education" Then
                MessageBox.Show("Input ''Christian and moral Education MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Label61.Text = "Buddhist and moral Education" Then
                MessageBox.Show("Input ''Buddhist and moral Education MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox661.Select()

            'Physical Education and Health
        ElseIf TextBox670.Text = "" Then
            MessageBox.Show("Input ''Physical Education and Health Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox670.Select()
        ElseIf TextBox660.Text = "" Then
            MessageBox.Show("Input ''Physical Education and Health MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox660.Select()

            'Art and Crafts
        ElseIf TextBox669.Text = "" Then
            MessageBox.Show("Input ''Art and Crafts Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox669.Select()
        ElseIf TextBox659.Text = "" Then
            MessageBox.Show("Input ''Art and Crafts MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox659.Select()

            'Information and Communication Technology
        ElseIf TextBox668.Text = "" Then
            MessageBox.Show("Input ''Information and Communication Technology Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox668.Select()
        ElseIf TextBox658.Text = "" Then
            MessageBox.Show("Input ''Information and Communication Technology MCQ Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox658.Select()

        Else
            '
            '
            MessageBox.Show("Seven First Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.TextBox89.Clear()
        Me.TextBox652.Clear()
        Me.TextBox90.Clear()
        Me.TextBox653.Clear()
        Me.TextBox10.Clear()
        Me.TextBox83.Clear()
        Me.TextBox97.Clear()
        Me.TextBox95.Clear()

        Me.TextBox92.Clear()
        Me.TextBox654.Clear()
        Me.TextBox91.Clear()
        Me.TextBox655.Clear()
        Me.TextBox9.Clear()
        Me.TextBox82.Clear()
        Me.TextBox93.Clear()
        Me.TextBox94.Clear()

        Me.TextBox675.Clear()
        Me.TextBox665.Clear()
        Me.TextBox8.Clear()
        Me.TextBox96.Clear()
        Me.TextBox104.Clear()
        Me.TextBox552.Clear()

        Me.TextBox674.Clear()
        Me.TextBox664.Clear()
        Me.TextBox7.Clear()
        Me.TextBox98.Clear()
        Me.TextBox105.Clear()
        Me.TextBox116.Clear()

        Me.TextBox673.Clear()
        Me.TextBox663.Clear()
        Me.TextBox6.Clear()
        Me.TextBox99.Clear()
        Me.TextBox107.Clear()
        Me.TextBox114.Clear()

        Me.TextBox672.Clear()
        Me.TextBox662.Clear()
        Me.TextBox5.Clear()
        Me.TextBox100.Clear()
        Me.TextBox109.Clear()
        Me.TextBox112.Clear()

        Me.TextBox671.Clear()
        Me.TextBox661.Clear()
        Me.TextBox4.Clear()
        Me.TextBox101.Clear()
        Me.TextBox111.Clear()
        Me.TextBox110.Clear()

        Me.TextBox670.Clear()
        Me.TextBox660.Clear()
        Me.TextBox3.Clear()
        Me.TextBox102.Clear()
        Me.TextBox113.Clear()
        Me.TextBox108.Clear()

        Me.TextBox669.Clear()
        Me.TextBox659.Clear()
        Me.TextBox2.Clear()
        Me.TextBox103.Clear()
        Me.TextBox115.Clear()
        Me.TextBox106.Clear()

        Me.TextBox668.Clear()
        Me.TextBox658.Clear()
        Me.TextBox1.Clear()
        Me.TextBox79.Clear()
        Me.TextBox81.Clear()
        Me.TextBox80.Clear()

        Me.TextBox87.Clear()
        Me.TextBox86.Clear()
        Me.TextBox88.Clear()
        Me.TextBox85.Clear()
        Me.TextBox84.Clear()

        Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.NO_Pic

        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    'Button Back
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Button Next
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_SSC_SelectSubject.ShowDialog()
    End Sub

    Private Sub Panel_mahamudur_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel_mahamudur.Paint

    End Sub

    Private Sub ToolStripButton_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Back.Click
        FormAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub AboutDevelopurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutDevelopurToolStripMenuItem.Click
        Form_ADeveloper.ShowDialog()
    End Sub

    Private Sub Secondary_School_Certificate__SSC_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    

    

    

    
    Private Sub Secondary_School_Certificate__SSC_BindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Secondary_School_Certificate__SSC_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Secondary_School_Certificate__SSC_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub

    Private Sub ButtonMoveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMoveFirst.Click
        Secondary_School_Certificate__SSC_DataGridView.RefreshEdit()
    End Sub

  
End Class




