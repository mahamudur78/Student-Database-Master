Public Class Form_SSC_SelectSubject

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.Label22.Text = CheckBox1.Text
        ElseIf CheckBox1.Checked = False Then
            Me.Label22.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Me.Label23.Text = CheckBox2.Text
        ElseIf CheckBox2.Checked = False Then
            Me.Label23.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Me.Label24.Text = CheckBox3.Text
        ElseIf CheckBox3.Checked = False Then
            Me.Label24.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Me.CheckBox5.Checked = False
            Me.Label25.Text = CheckBox4.Text
        ElseIf CheckBox4.Checked = False Then
            Me.Label25.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Me.CheckBox4.Checked = False
            Me.Label25.Text = CheckBox5.Text
        ElseIf CheckBox5.Checked = False Then
            Me.Label25.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Me.CheckBox7.Checked = False
            Me.CheckBox8.Checked = False
            Me.CheckBox9.Checked = False
            Me.Label26.Text = CheckBox6.Text
        ElseIf CheckBox6.Checked = False Then
            Me.Label26.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Me.CheckBox6.Checked = False
            Me.CheckBox8.Checked = False
            Me.CheckBox9.Checked = False
            Me.Label26.Text = CheckBox7.Text
        ElseIf CheckBox7.Checked = False Then
            Me.Label26.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            Me.CheckBox6.Checked = False
            Me.CheckBox7.Checked = False
            Me.CheckBox9.Checked = False
            Me.Label26.Text = CheckBox8.Text
        ElseIf CheckBox8.Checked = False Then
            Me.Label26.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            Me.CheckBox6.Checked = False
            Me.CheckBox7.Checked = False
            Me.CheckBox8.Checked = False
            Me.Label26.Text = CheckBox9.Text
        ElseIf CheckBox9.Checked = False Then
            Me.Label26.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            Me.CheckBox11.Checked = False
            Me.CheckBox12.Checked = False
            Me.Label27.Text = CheckBox10.Text
        ElseIf CheckBox10.Checked = False Then
            Me.Label27.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            Me.CheckBox10.Checked = False
            Me.CheckBox12.Checked = False
            Me.Label27.Text = CheckBox11.Text
        ElseIf CheckBox11.Checked = False Then
            Me.Label27.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            Me.CheckBox10.Checked = False
            Me.CheckBox11.Checked = False
            Me.Label27.Text = CheckBox12.Text
        ElseIf CheckBox12.Checked = False Then
            Me.Label27.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            Me.CheckBox14.Checked = False
            Me.CheckBox15.Checked = False
            Me.Label28.Text = CheckBox13.Text
        ElseIf CheckBox13.Checked = False Then
            Me.Label28.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            Me.CheckBox13.Checked = False
            Me.CheckBox15.Checked = False
            Me.Label28.Text = CheckBox14.Text
        ElseIf CheckBox14.Checked = False Then
            Me.Label28.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            Me.CheckBox13.Checked = False
            Me.CheckBox14.Checked = False
            Me.Label28.Text = CheckBox15.Text
        ElseIf CheckBox15.Checked = False Then
            Me.Label28.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            Me.CheckBox17.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox21.Checked = False
            Me.CheckBox22.Checked = False
            Me.Label29.Text = CheckBox16.Text

            'Four Subject
            Me.CheckBox24.Enabled = False

        ElseIf CheckBox16.Checked = False Then
            Me.Label29.Text = "_____________________________"

            'Four Subject
            Me.CheckBox24.Enabled = True
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            Me.CheckBox16.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox21.Checked = False
            Me.CheckBox22.Checked = False
            Me.Label29.Text = CheckBox17.Text

            'Four Subject
            Me.CheckBox25.Enabled = False
        ElseIf CheckBox17.Checked = False Then
            Me.Label29.Text = "_____________________________"

            'Four Subject
            Me.CheckBox25.Enabled = True
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            Me.CheckBox16.Checked = False
            Me.CheckBox17.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox21.Checked = False
            Me.CheckBox22.Checked = False

            'Four Subject
            Me.CheckBox26.Enabled = False
            Me.Label29.Text = CheckBox18.Text
        ElseIf CheckBox18.Checked = False Then
            Me.Label29.Text = "_____________________________"

            'Four Subject
            Me.CheckBox26.Enabled = True
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            Me.CheckBox16.Checked = False
            Me.CheckBox17.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox21.Checked = False
            Me.CheckBox22.Checked = False
            Me.Label29.Text = CheckBox19.Text

            'Four Subject
            Me.CheckBox27.Enabled = False
        ElseIf CheckBox19.Checked = False Then
            Me.Label29.Text = "_____________________________"

            'Four Subject
            Me.CheckBox27.Enabled = True
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            Me.CheckBox16.Checked = False
            Me.CheckBox17.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox21.Checked = False
            Me.CheckBox22.Checked = False
            Me.Label29.Text = CheckBox20.Text
        ElseIf CheckBox20.Checked = False Then
            Me.Label29.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            Me.CheckBox16.Checked = False
            Me.CheckBox17.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox22.Checked = False
            Me.Label29.Text = CheckBox21.Text
        ElseIf CheckBox21.Checked = False Then
            Me.Label29.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            Me.CheckBox16.Checked = False
            Me.CheckBox17.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox21.Checked = False
            Me.Label29.Text = CheckBox22.Text
        ElseIf CheckBox22.Checked = False Then
            Me.Label29.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            Me.Label30.Text = CheckBox23.Text
        ElseIf CheckBox23.Checked = False Then
            Me.Label30.Text = "_____________________________"
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False
            Me.Label31.Text = CheckBox24.Text

            'Four Subject
            Me.CheckBox16.Enabled = False
        ElseIf CheckBox24.Checked = False Then
            Me.Label31.Text = "_____________________________"

            'Four Subject
            Me.CheckBox16.Enabled = True
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            Me.CheckBox24.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False
            Me.Label31.Text = CheckBox25.Text

            'Four Subject
            Me.CheckBox17.Enabled = False
        ElseIf CheckBox25.Checked = False Then
            Me.Label31.Text = "_____________________________"

            'Four Subject
            Me.CheckBox17.Enabled = True
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            Me.CheckBox24.Checked = False
            Me.CheckBox25.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False
            Me.Label31.Text = CheckBox26.Text

            'Four Subject
            Me.CheckBox18.Enabled = False
        ElseIf CheckBox26.Checked = False Then
            Me.Label31.Text = "_____________________________"

            'Four Subject
            Me.CheckBox18.Enabled = True
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            Me.CheckBox24.Checked = False
            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox28.Checked = False
            Me.Label31.Text = CheckBox27.Text

            'Four Subject
            Me.CheckBox19.Enabled = False
        ElseIf CheckBox27.Checked = False Then
            Me.Label31.Text = "_____________________________"

            'Four Subject
            Me.CheckBox19.Enabled = True
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            Me.CheckBox24.Checked = False
            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.Label31.Text = CheckBox28.Text
        ElseIf CheckBox28.Checked = False Then
            Me.Label31.Text = "_____________________________"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.Label33.Text = "Science"
            Me.Label2.Text = "Select Subject ''Science'' "
            Me.CheckBox4.Enabled = True
            Me.CheckBox5.Enabled = False

            Me.CheckBox10.Enabled = True
            Me.CheckBox11.Enabled = False
            Me.CheckBox12.Enabled = False

            Me.CheckBox13.Enabled = True
            Me.CheckBox14.Enabled = False
            Me.CheckBox15.Enabled = False

            Me.CheckBox16.Enabled = True
            Me.CheckBox17.Enabled = True
            Me.CheckBox18.Enabled = True
            Me.CheckBox19.Enabled = True
            Me.CheckBox20.Enabled = False
            Me.CheckBox21.Enabled = False
            Me.CheckBox22.Enabled = False

            Me.CheckBox24.Enabled = True
            Me.CheckBox25.Enabled = True
            Me.CheckBox26.Enabled = True
            Me.CheckBox27.Enabled = True
            Me.CheckBox28.Enabled = False

        ElseIf RadioButton1.Checked = False Then
            Me.CheckBox4.Enabled = True
            Me.CheckBox5.Enabled = True
            Me.CheckBox10.Enabled = True
            Me.CheckBox11.Enabled = True
            Me.CheckBox12.Enabled = True
            Me.CheckBox13.Enabled = True
            Me.CheckBox14.Enabled = True
            Me.CheckBox15.Enabled = True
            Me.CheckBox16.Enabled = True
            Me.CheckBox17.Enabled = True
            Me.CheckBox18.Enabled = True
            Me.CheckBox19.Enabled = True
            Me.CheckBox20.Enabled = True
            Me.CheckBox21.Enabled = True
            Me.CheckBox22.Enabled = True
            Me.CheckBox24.Enabled = True
            Me.CheckBox25.Enabled = True
            Me.CheckBox26.Enabled = True
            Me.CheckBox27.Enabled = True
            Me.CheckBox28.Enabled = True


            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
            Me.CheckBox10.Checked = False
            Me.CheckBox11.Checked = False
            Me.CheckBox12.Checked = False
            Me.CheckBox13.Checked = False
            Me.CheckBox14.Checked = False
            Me.CheckBox15.Checked = False
            Me.CheckBox16.Checked = False
            Me.CheckBox17.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox21.Checked = False
            Me.CheckBox22.Checked = False
            Me.CheckBox24.Checked = False
            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False

        End If

       
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Me.Label33.Text = "Business Studies"
            Me.Label2.Text = "Select Subject ''Business Studies'' "
            Me.CheckBox4.Enabled = False
            Me.CheckBox5.Enabled = True

            Me.CheckBox10.Enabled = False
            Me.CheckBox11.Enabled = True
            Me.CheckBox12.Enabled = False

            Me.CheckBox13.Enabled = False
            Me.CheckBox14.Enabled = True
            Me.CheckBox15.Enabled = False

            Me.CheckBox16.Enabled = False
            Me.CheckBox17.Enabled = False
            Me.CheckBox18.Enabled = False
            Me.CheckBox19.Enabled = False
            Me.CheckBox20.Enabled = True
            Me.CheckBox21.Enabled = False
            Me.CheckBox22.Enabled = False

            Me.CheckBox24.Enabled = False
            Me.CheckBox25.Enabled = False
            Me.CheckBox26.Enabled = True
            Me.CheckBox27.Enabled = True
            Me.CheckBox28.Enabled = True

        ElseIf RadioButton2.Checked = False Then
            Me.CheckBox4.Enabled = True
            Me.CheckBox5.Enabled = True
            Me.CheckBox10.Enabled = True
            Me.CheckBox11.Enabled = True
            Me.CheckBox12.Enabled = True
            Me.CheckBox13.Enabled = True
            Me.CheckBox14.Enabled = True
            Me.CheckBox15.Enabled = True
            Me.CheckBox16.Enabled = True
            Me.CheckBox17.Enabled = True
            Me.CheckBox18.Enabled = True
            Me.CheckBox19.Enabled = True
            Me.CheckBox20.Enabled = True
            Me.CheckBox21.Enabled = True
            Me.CheckBox22.Enabled = True
            Me.CheckBox24.Enabled = True
            Me.CheckBox25.Enabled = True
            Me.CheckBox26.Enabled = True
            Me.CheckBox27.Enabled = True
            Me.CheckBox28.Enabled = True


            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
            Me.CheckBox10.Checked = False
            Me.CheckBox11.Checked = False
            Me.CheckBox12.Checked = False
            Me.CheckBox13.Checked = False
            Me.CheckBox14.Checked = False
            Me.CheckBox15.Checked = False
            Me.CheckBox16.Checked = False
            Me.CheckBox17.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox21.Checked = False
            Me.CheckBox22.Checked = False
            Me.CheckBox24.Checked = False
            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Me.Label33.Text = "Humanities"
            Me.Label2.Text = "Select Subject ''Humanities'' "
            Me.CheckBox4.Enabled = False
            Me.CheckBox5.Enabled = True

            Me.CheckBox10.Enabled = False
            Me.CheckBox11.Enabled = False
            Me.CheckBox12.Enabled = True

            Me.CheckBox13.Enabled = False
            Me.CheckBox14.Enabled = False
            Me.CheckBox15.Enabled = True

            Me.CheckBox16.Enabled = False
            Me.CheckBox17.Enabled = False
            Me.CheckBox18.Enabled = False
            Me.CheckBox19.Enabled = False
            Me.CheckBox20.Enabled = False
            Me.CheckBox21.Enabled = True
            Me.CheckBox22.Enabled = True

            Me.CheckBox24.Enabled = False
            Me.CheckBox25.Enabled = False
            Me.CheckBox26.Enabled = True
            Me.CheckBox27.Enabled = True
            Me.CheckBox28.Enabled = True

        ElseIf RadioButton3.Checked = False Then
            Me.CheckBox4.Enabled = True
            Me.CheckBox5.Enabled = True
            Me.CheckBox10.Enabled = True
            Me.CheckBox11.Enabled = True
            Me.CheckBox12.Enabled = True
            Me.CheckBox13.Enabled = True
            Me.CheckBox14.Enabled = True
            Me.CheckBox15.Enabled = True
            Me.CheckBox16.Enabled = True
            Me.CheckBox17.Enabled = True
            Me.CheckBox18.Enabled = True
            Me.CheckBox19.Enabled = True
            Me.CheckBox20.Enabled = True
            Me.CheckBox21.Enabled = True
            Me.CheckBox22.Enabled = True
            Me.CheckBox24.Enabled = True
            Me.CheckBox25.Enabled = True
            Me.CheckBox26.Enabled = True
            Me.CheckBox27.Enabled = True
            Me.CheckBox28.Enabled = True


            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
            Me.CheckBox10.Checked = False
            Me.CheckBox11.Checked = False
            Me.CheckBox12.Checked = False
            Me.CheckBox13.Checked = False
            Me.CheckBox14.Checked = False
            Me.CheckBox15.Checked = False
            Me.CheckBox16.Checked = False
            Me.CheckBox17.Checked = False
            Me.CheckBox18.Checked = False
            Me.CheckBox19.Checked = False
            Me.CheckBox20.Checked = False
            Me.CheckBox21.Checked = False
            Me.CheckBox22.Checked = False
            Me.CheckBox24.Checked = False
            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Gpoup
        'If RadioButton1.Checked = True Then
        '    Form_SSC.TextBox41.Text = " Science"
        'ElseIf RadioButton2.Checked = True Then
        '    Form_SSC.TextBox41.Text = "Business Studies"
        'ElseIf RadioButton3.Checked = True Then
        '    Form_SSC.TextBox41.Text = "Humanities"
        'End If

        If Label22.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 1''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label23.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 2''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label24.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 3''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label25.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 4''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label26.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 5''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label27.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 6''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label28.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 7''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label29.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 8''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label30.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 9''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Label31.Text = "_____________________________" Then
            MessageBox.Show("Input ''Subject 10''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            'Group

            'Subject 1
            Form_SSC.Label153.Text = Label22.Text
            Form_SSC.Label183.Text = Label22.Text
            Form_SSC.Label11.Text = Label22.Text
            Form_SSC.Label45.Text = Label22.Text

            'Subject 2
            Form_SSC.Label151.Text = Label23.Text
            Form_SSC.Label171.Text = Label23.Text
            Form_SSC.Label34.Text = Label23.Text
            Form_SSC.Label15.Text = Label23.Text

            'Subject 3
            Form_SSC.Label158.Text = Label24.Text
            Form_SSC.Label181.Text = Label24.Text
            Form_SSC.Label12.Text = Label24.Text
            Form_SSC.Label16.Text = Label24.Text

            'Subject 4
            Form_SSC.Label58.Text = Label25.Text
            Form_SSC.Label188.Text = Label25.Text
            Form_SSC.Label13.Text = Label25.Text
            Form_SSC.Label43.Text = Label25.Text

            'Subject 5
            Form_SSC.Label59.Text = Label26.Text
            Form_SSC.Label189.Text = Label26.Text
            Form_SSC.Label14.Text = Label26.Text
            Form_SSC.Label51.Text = Label26.Text

            'Subject 6
            Form_SSC.Label60.Text = Label27.Text
            Form_SSC.Label191.Text = Label27.Text
            Form_SSC.Label22.Text = Label27.Text
            Form_SSC.Label54.Text = Label27.Text

            'Subject 7
            Form_SSC.Label61.Text = Label28.Text
            Form_SSC.Label192.Text = Label28.Text
            Form_SSC.Label23.Text = Label28.Text
            Form_SSC.Label56.Text = Label28.Text

            'Subject 8
            Form_SSC.Label62.Text = Label29.Text
            Form_SSC.Label190.Text = Label29.Text
            Form_SSC.Label17.Text = Label29.Text
            Form_SSC.Label53.Text = Label29.Text

            'Subject 9
            Form_SSC.Label63.Text = Label30.Text
            Form_SSC.Label164.Text = Label30.Text
            Form_SSC.Label18.Text = Label30.Text
            Form_SSC.Label52.Text = Label30.Text

            'Subject 10
            Form_SSC.Label64.Text = Label31.Text
            Form_SSC.Label162.Text = Label31.Text
            Form_SSC.Label285.Text = Label31.Text
            Form_SSC.Label286.Text = Label31.Text


            'subject 6
            If Form_SSC.Label60.Text = "Physics" Then
                Form_SSC.TextBox5.TabStop = True

            ElseIf Form_SSC.Label60.Text = "Business Enterprises" Then
                Form_SSC.TextBox5.TabStop = False

            ElseIf Form_SSC.Label60.Text = "Geography and Environment" Then
                Form_SSC.TextBox5.TabStop = False

                'subject 7
            ElseIf Form_SSC.Label61.Text = "Chemistry" Then
                Form_SSC.TextBox4.TabStop = True

            ElseIf Form_SSC.Label61.Text = "Finance and Banking" Then
                Form_SSC.TextBox4.TabStop = False

            ElseIf Form_SSC.Label61.Text = "History of Bangladesh and World Civilization" Then
                Form_SSC.TextBox4.TabStop = False

                'Subject 8
            ElseIf Form_SSC.Label62.Text = "Higher Mathematics" Then
                Form_SSC.TextBox3.TabStop = True

            ElseIf Form_SSC.Label62.Text = "Biology" Then
                Form_SSC.TextBox3.TabStop = True

            ElseIf Form_SSC.Label62.Text = "Computer Study" Then
                Form_SSC.TextBox3.TabStop = True

            ElseIf Form_SSC.Label62.Text = "Agriculture Studies" Then
                Form_SSC.TextBox3.TabStop = True

            ElseIf Form_SSC.Label62.Text = "Accounting" Then
                Form_SSC.TextBox3.TabStop = False

            ElseIf Form_SSC.Label62.Text = "Economics" Then
                Form_SSC.TextBox3.TabStop = False

            ElseIf Form_SSC.Label62.Text = "Civics and Citizenship" Then
                Form_SSC.TextBox3.TabStop = False
            End If

            Form_SSC.TextBox89.Clear()
            Form_SSC.TextBox652.Clear()
            Form_SSC.TextBox90.Clear()
            Form_SSC.TextBox653.Clear()
            Form_SSC.TextBox10.Clear()
            Form_SSC.TextBox83.Clear()
            Form_SSC.TextBox97.Clear()
            Form_SSC.TextBox95.Clear()

            Form_SSC.TextBox92.Clear()
            Form_SSC.TextBox654.Clear()
            Form_SSC.TextBox91.Clear()
            Form_SSC.TextBox655.Clear()
            Form_SSC.TextBox9.Clear()
            Form_SSC.TextBox82.Clear()
            Form_SSC.TextBox93.Clear()
            Form_SSC.TextBox94.Clear()

            Form_SSC.TextBox675.Clear()
            Form_SSC.TextBox665.Clear()
            Form_SSC.TextBox8.Clear()
            Form_SSC.TextBox96.Clear()
            Form_SSC.TextBox104.Clear()
            Form_SSC.TextBox552.Clear()

            Form_SSC.TextBox674.Clear()
            Form_SSC.TextBox664.Clear()
            Form_SSC.TextBox7.Clear()
            Form_SSC.TextBox98.Clear()
            Form_SSC.TextBox105.Clear()
            Form_SSC.TextBox116.Clear()

            Form_SSC.TextBox673.Clear()
            Form_SSC.TextBox663.Clear()
            Form_SSC.TextBox6.Clear()
            Form_SSC.TextBox99.Clear()
            Form_SSC.TextBox107.Clear()
            Form_SSC.TextBox114.Clear()

            Form_SSC.TextBox672.Clear()
            Form_SSC.TextBox662.Clear()
            Form_SSC.TextBox5.Clear()
            Form_SSC.TextBox100.Clear()
            Form_SSC.TextBox109.Clear()
            Form_SSC.TextBox112.Clear()

            Form_SSC.TextBox671.Clear()
            Form_SSC.TextBox661.Clear()
            Form_SSC.TextBox4.Clear()
            Form_SSC.TextBox101.Clear()
            Form_SSC.TextBox111.Clear()
            Form_SSC.TextBox110.Clear()

            Form_SSC.TextBox670.Clear()
            Form_SSC.TextBox660.Clear()
            Form_SSC.TextBox3.Clear()
            Form_SSC.TextBox102.Clear()
            Form_SSC.TextBox113.Clear()
            Form_SSC.TextBox108.Clear()

            Form_SSC.TextBox669.Clear()
            Form_SSC.TextBox659.Clear()
            Form_SSC.TextBox2.Clear()
            Form_SSC.TextBox103.Clear()
            Form_SSC.TextBox115.Clear()
            Form_SSC.TextBox106.Clear()

            Form_SSC.TextBox668.Clear()
            Form_SSC.TextBox658.Clear()
            Form_SSC.TextBox1.Clear()
            Form_SSC.TextBox79.Clear()
            Form_SSC.TextBox81.Clear()
            Form_SSC.TextBox80.Clear()

            Form_SSC.TextBox87.Clear()
            Form_SSC.TextBox86.Clear()
            Form_SSC.TextBox88.Clear()
            Form_SSC.TextBox85.Clear()
            Form_SSC.TextBox84.Clear()

            Form_SSC.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
            Form_SSC.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.NO_Pic

            Me.Secondary_School_Certificate__SSC_BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

            MessageBox.Show("Input ''Data Recode Saving Successfully'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form_Admission_SSC.Show()
            Me.Close()
        End If

      
    End Sub

    Private Sub Form_SSC_SelectSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        'Me.CheckBox1.Checked = False
        'Me.CheckBox2.Checked = False
        'Me.CheckBox3.Checked = False
        'Me.CheckBox4.Checked = False
        'Me.CheckBox5.Checked = False
        'Me.CheckBox6.Checked = False
        'Me.CheckBox7.Checked = False
        'Me.CheckBox8.Checked = False
        'Me.CheckBox9.Checked = False
        'Me.CheckBox10.Checked = False
        'Me.CheckBox11.Checked = False
        'Me.CheckBox12.Checked = False
        'Me.CheckBox13.Checked = False
        'Me.CheckBox14.Checked = False
        'Me.CheckBox15.Checked = False
        'Me.CheckBox16.Checked = False
        'Me.CheckBox17.Checked = False
        'Me.CheckBox18.Checked = False
        'Me.CheckBox19.Checked = False
        'Me.CheckBox20.Checked = False
        'Me.CheckBox21.Checked = False
        'Me.CheckBox22.Checked = False
        'Me.CheckBox23.Checked = False
        'Me.CheckBox24.Checked = False
        'Me.CheckBox25.Checked = False
        'Me.CheckBox26.Checked = False
        'Me.CheckBox27.Checked = False
        'Me.CheckBox28.Checked = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

  
    Private Sub Secondary_School_Certificate__SSC_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Secondary_School_Certificate__SSC_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDatabaseDataSet)

    End Sub
End Class