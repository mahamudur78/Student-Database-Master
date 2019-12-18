Public Class Form_PSC

    Private Sub Form_PSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDatabaseDataSet._Primary_School_Certificate__PSC_' table. You can move, or remove it, as needed.

        Try
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub
    Public Sub shutdown()
        Dim myReply As Integer
        myReply = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If myReply = vbYes Then
            End
        End If
        'If MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) - DialogResult.No Then
        '    Application.Exit()
        'End If
    End Sub

   
    Private Sub Three_JAN()
        Me.TextBox181.Text = Val(TextBox350.Text) + Val(TextBox349.Text) + Val(TextBox348.Text) + Val(TextBox347.Text) + Val(TextBox346.Text) + Val(TextBox345.Text) + Val(TextBox344.Text) + Val(TextBox343.Text) + Val(TextBox342.Text) + Val(TextBox341.Text) + Val(TextBox340.Text) + Val(TextBox339.Text)
    End Sub

    Private Sub Three_Feb()
        Me.TextBox180.Text = Val(TextBox325.Text) + Val(TextBox326.Text) + Val(TextBox327.Text) + Val(TextBox328.Text) + Val(TextBox329.Text) + Val(TextBox330.Text) + Val(TextBox331.Text) + Val(TextBox332.Text) + Val(TextBox333.Text) + Val(TextBox334.Text) + Val(TextBox335.Text) + Val(TextBox336.Text)
    End Sub

    Private Sub Three_Mar()
        Me.TextBox179.Text = Val(TextBox311.Text) + Val(TextBox312.Text) + Val(TextBox313.Text) + Val(TextBox314.Text) + Val(TextBox315.Text) + Val(TextBox316.Text) + Val(TextBox317.Text) + Val(TextBox318.Text) + Val(TextBox319.Text) + Val(TextBox320.Text) + Val(TextBox321.Text) + Val(TextBox322.Text)
    End Sub

    Private Sub Three_April()
        Me.TextBox178.Text = Val(TextBox297.Text) + Val(TextBox298.Text) + Val(TextBox299.Text) + Val(TextBox300.Text) + Val(TextBox301.Text) + Val(TextBox302.Text) + Val(TextBox303.Text) + Val(TextBox304.Text) + Val(TextBox305.Text) + Val(TextBox306.Text) + Val(TextBox307.Text) + Val(TextBox308.Text)
    End Sub

    Private Sub Three_May()
        Me.TextBox177.Text = Val(TextBox283.Text) + Val(TextBox284.Text) + Val(TextBox285.Text) + Val(TextBox286.Text) + Val(TextBox287.Text) + Val(TextBox288.Text) + Val(TextBox289.Text) + Val(TextBox290.Text) + Val(TextBox291.Text) + Val(TextBox292.Text) + Val(TextBox293.Text) + Val(TextBox294.Text)
    End Sub

    Private Sub Three_Jun()
        Me.TextBox176.Text = Val(TextBox268.Text) + Val(TextBox269.Text) + Val(TextBox270.Text) + Val(TextBox271.Text) + Val(TextBox272.Text) + Val(TextBox273.Text) + Val(TextBox275.Text) + Val(TextBox276.Text) + Val(TextBox277.Text) + Val(TextBox278.Text) + Val(TextBox279.Text) + Val(TextBox280.Text)
    End Sub

    Private Sub Three_July()
        Me.TextBox175.Text = Val(TextBox254.Text) + Val(TextBox255.Text) + Val(TextBox256.Text) + Val(TextBox257.Text) + Val(TextBox258.Text) + Val(TextBox259.Text) + Val(TextBox260.Text) + Val(TextBox261.Text) + Val(TextBox262.Text) + Val(TextBox263.Text) + Val(TextBox264.Text) + Val(TextBox265.Text)
    End Sub

    Private Sub Three_Aug()
        Me.TextBox174.Text = Val(TextBox240.Text) + Val(TextBox241.Text) + Val(TextBox242.Text) + Val(TextBox243.Text) + Val(TextBox244.Text) + Val(TextBox245.Text) + Val(TextBox246.Text) + Val(TextBox247.Text) + Val(TextBox248.Text) + Val(TextBox249.Text) + Val(TextBox250.Text) + Val(TextBox251.Text)
    End Sub

    Private Sub Three_Septimbar()
        Me.TextBox173.Text = Val(TextBox226.Text) + Val(TextBox227.Text) + Val(TextBox228.Text) + Val(TextBox229.Text) + Val(TextBox230.Text) + Val(TextBox231.Text) + Val(TextBox232.Text) + Val(TextBox233.Text) + Val(TextBox234.Text) + Val(TextBox235.Text) + Val(TextBox236.Text) + Val(TextBox237.Text)

    End Sub

    Private Sub Three_October()
        Me.TextBox172.Text = Val(TextBox212.Text) + Val(TextBox213.Text) + Val(TextBox214.Text) + Val(TextBox215.Text) + Val(TextBox216.Text) + Val(TextBox217.Text) + Val(TextBox218.Text) + Val(TextBox219.Text) + Val(TextBox220.Text) + Val(TextBox221.Text) + Val(TextBox222.Text) + Val(TextBox223.Text)
    End Sub

    Private Sub Three_November()
        Me.TextBox171.Text = Val(TextBox198.Text) + Val(TextBox199.Text) + Val(TextBox200.Text) + Val(TextBox201.Text) + Val(TextBox202.Text) + Val(TextBox203.Text) + Val(TextBox204.Text) + Val(TextBox205.Text) + Val(TextBox206.Text) + Val(TextBox207.Text) + Val(TextBox208.Text) + Val(TextBox209.Text)
    End Sub

    Private Sub Three_Decembar()
        Me.TextBox170.Text = Val(TextBox184.Text) + Val(TextBox185.Text) + Val(TextBox186.Text) + Val(TextBox187.Text) + Val(TextBox188.Text) + Val(TextBox189.Text) + Val(TextBox190.Text) + Val(TextBox191.Text) + Val(TextBox192.Text) + Val(TextBox193.Text) + Val(TextBox194.Text) + Val(TextBox195.Text)
    End Sub

    Private Sub Three_AccountTotal()

        Me.TextBox169.Text = Val(TextBox350.Text) + Val(TextBox336.Text) + Val(TextBox322.Text) + Val(TextBox308.Text) + Val(TextBox294.Text) + Val(TextBox280.Text) + Val(TextBox265.Text) + Val(TextBox251.Text) + Val(TextBox237.Text) + Val(TextBox223.Text) + Val(TextBox209.Text) + Val(TextBox195.Text)
        Me.TextBox168.Text = Val(TextBox349.Text) + Val(TextBox335.Text) + Val(TextBox321.Text) + Val(TextBox307.Text) + Val(TextBox293.Text) + Val(TextBox279.Text) + Val(TextBox264.Text) + Val(TextBox250.Text) + Val(TextBox236.Text) + Val(TextBox222.Text) + Val(TextBox208.Text) + Val(TextBox194.Text)
        Me.TextBox167.Text = Val(TextBox348.Text) + Val(TextBox334.Text) + Val(TextBox320.Text) + Val(TextBox306.Text) + Val(TextBox292.Text) + Val(TextBox278.Text) + Val(TextBox263.Text) + Val(TextBox249.Text) + Val(TextBox235.Text) + Val(TextBox221.Text) + Val(TextBox207.Text) + Val(TextBox193.Text)
        Me.TextBox166.Text = Val(TextBox347.Text) + Val(TextBox333.Text) + Val(TextBox319.Text) + Val(TextBox305.Text) + Val(TextBox291.Text) + Val(TextBox277.Text) + Val(TextBox262.Text) + Val(TextBox248.Text) + Val(TextBox234.Text) + Val(TextBox220.Text) + Val(TextBox206.Text) + Val(TextBox192.Text)
        Me.TextBox165.Text = Val(TextBox346.Text) + Val(TextBox332.Text) + Val(TextBox318.Text) + Val(TextBox304.Text) + Val(TextBox290.Text) + Val(TextBox276.Text) + Val(TextBox261.Text) + Val(TextBox247.Text) + Val(TextBox233.Text) + Val(TextBox219.Text) + Val(TextBox205.Text) + Val(TextBox191.Text)
        Me.TextBox164.Text = Val(TextBox345.Text) + Val(TextBox331.Text) + Val(TextBox317.Text) + Val(TextBox303.Text) + Val(TextBox289.Text) + Val(TextBox275.Text) + Val(TextBox260.Text) + Val(TextBox246.Text) + Val(TextBox232.Text) + Val(TextBox218.Text) + Val(TextBox204.Text) + Val(TextBox190.Text)
        Me.TextBox163.Text = Val(TextBox344.Text) + Val(TextBox330.Text) + Val(TextBox316.Text) + Val(TextBox302.Text) + Val(TextBox288.Text) + Val(TextBox273.Text) + Val(TextBox259.Text) + Val(TextBox245.Text) + Val(TextBox231.Text) + Val(TextBox217.Text) + Val(TextBox203.Text) + Val(TextBox189.Text)
        Me.TextBox162.Text = Val(TextBox343.Text) + Val(TextBox329.Text) + Val(TextBox315.Text) + Val(TextBox301.Text) + Val(TextBox287.Text) + Val(TextBox272.Text) + Val(TextBox258.Text) + Val(TextBox244.Text) + Val(TextBox230.Text) + Val(TextBox216.Text) + Val(TextBox202.Text) + Val(TextBox188.Text)
        Me.TextBox161.Text = Val(TextBox342.Text) + Val(TextBox328.Text) + Val(TextBox314.Text) + Val(TextBox300.Text) + Val(TextBox286.Text) + Val(TextBox271.Text) + Val(TextBox257.Text) + Val(TextBox243.Text) + Val(TextBox229.Text) + Val(TextBox215.Text) + Val(TextBox201.Text) + Val(TextBox187.Text)
        Me.TextBox160.Text = Val(TextBox341.Text) + Val(TextBox327.Text) + Val(TextBox313.Text) + Val(TextBox299.Text) + Val(TextBox285.Text) + Val(TextBox270.Text) + Val(TextBox256.Text) + Val(TextBox242.Text) + Val(TextBox228.Text) + Val(TextBox214.Text) + Val(TextBox200.Text) + Val(TextBox186.Text)
        Me.TextBox159.Text = Val(TextBox340.Text) + Val(TextBox326.Text) + Val(TextBox312.Text) + Val(TextBox298.Text) + Val(TextBox284.Text) + Val(TextBox269.Text) + Val(TextBox255.Text) + Val(TextBox241.Text) + Val(TextBox227.Text) + Val(TextBox213.Text) + Val(TextBox199.Text) + Val(TextBox185.Text)
        Me.TextBox158.Text = Val(TextBox339.Text) + Val(TextBox325.Text) + Val(TextBox311.Text) + Val(TextBox297.Text) + Val(TextBox283.Text) + Val(TextBox268.Text) + Val(TextBox254.Text) + Val(TextBox240.Text) + Val(TextBox226.Text) + Val(TextBox212.Text) + Val(TextBox198.Text) + Val(TextBox184.Text)
       

        'Total
        Me.TextBox155.Text = Val(TextBox158.Text) + Val(TextBox159.Text) + Val(TextBox160.Text) + Val(TextBox161.Text) + Val(TextBox162.Text) + Val(TextBox163.Text) + Val(TextBox164.Text) + Val(TextBox165.Text) + Val(TextBox166.Text) + Val(TextBox167.Text) + Val(TextBox168.Text) + Val(TextBox169.Text)


        If TextBox169.Text = "0" Then
            TextBox169.Clear()
        End If

        If TextBox168.Text = "0" Then
            TextBox168.Clear()
        End If

        If TextBox167.Text = "0" Then
            TextBox167.Clear()
        End If

        If TextBox166.Text = "0" Then
            TextBox166.Clear()
        End If

        If TextBox165.Text = "0" Then
            TextBox165.Clear()
        End If

        If TextBox164.Text = "0" Then
            TextBox164.Clear()
        End If

        If TextBox163.Text = "0" Then
            TextBox163.Clear()
        End If

        If TextBox162.Text = "0" Then
            TextBox162.Clear()
        End If

        If TextBox161.Text = "0" Then
            TextBox161.Clear()
        End If

        If TextBox160.Text = "0" Then
            TextBox160.Clear()
        End If

        If TextBox159.Text = "0" Then
            TextBox159.Clear()
        End If

        If TextBox158.Text = "0" Then
            TextBox158.Clear()
        End If


        If TextBox155.Text = "0" Then
            TextBox155.Clear()
        End If


        If TextBox181.Text = "0" Then
            TextBox181.Clear()
        End If

        If TextBox180.Text = "0" Then
            TextBox180.Clear()
        End If
        If TextBox179.Text = "0" Then
            TextBox179.Clear()
        End If

        If TextBox178.Text = "0" Then
            TextBox178.Clear()
        End If

        If TextBox177.Text = "0" Then
            TextBox177.Clear()
        End If

        If TextBox176.Text = "0" Then
            TextBox176.Clear()
        End If

        If TextBox175.Text = "0" Then
            TextBox175.Clear()
        End If

        If TextBox174.Text = "0" Then
            TextBox174.Clear()
        End If

        If TextBox173.Text = "0" Then
            TextBox173.Clear()
        End If

        If TextBox172.Text = "0" Then
            TextBox172.Clear()
        End If

        If TextBox171.Text = "0" Then
            TextBox171.Clear()
        End If

        If TextBox170.Text = "0" Then
            TextBox170.Clear()
        End If
    End Sub


    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            Me.TextBox350.Enabled = True
            Me.TextBox349.Enabled = True
            Me.TextBox348.Enabled = True
            Me.TextBox347.Enabled = True
            Me.TextBox346.Enabled = True
            Me.TextBox345.Enabled = True
            Me.TextBox344.Enabled = True
            Me.TextBox343.Enabled = True
            Me.TextBox342.Enabled = True
            Me.TextBox341.Enabled = True
            Me.TextBox340.Enabled = True
            Me.TextBox339.Enabled = True
            Me.TextBox558.Enabled = True
            Me.DateTimePicker24.Enabled = True

        ElseIf RadioButton13.Checked = False Then
            Me.TextBox350.Enabled = False
            Me.TextBox349.Enabled = False
            Me.TextBox348.Enabled = False
            Me.TextBox347.Enabled = False
            Me.TextBox346.Enabled = False
            Me.TextBox345.Enabled = False
            Me.TextBox344.Enabled = False
            Me.TextBox343.Enabled = False
            Me.TextBox342.Enabled = False
            Me.TextBox341.Enabled = False
            Me.TextBox340.Enabled = False
            Me.TextBox339.Enabled = False
            Me.TextBox558.Enabled = False
            Me.DateTimePicker24.Enabled = False
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Me.TextBox325.Enabled = True
            Me.TextBox326.Enabled = True
            Me.TextBox327.Enabled = True
            Me.TextBox328.Enabled = True
            Me.TextBox329.Enabled = True
            Me.TextBox330.Enabled = True
            Me.TextBox331.Enabled = True
            Me.TextBox332.Enabled = True
            Me.TextBox333.Enabled = True
            Me.TextBox334.Enabled = True
            Me.TextBox335.Enabled = True
            Me.TextBox336.Enabled = True
            Me.TextBox559.Enabled = True
            Me.DateTimePicker23.Enabled = True

        ElseIf RadioButton12.Checked = False Then
            Me.TextBox325.Enabled = False
            Me.TextBox326.Enabled = False
            Me.TextBox327.Enabled = False
            Me.TextBox328.Enabled = False
            Me.TextBox329.Enabled = False
            Me.TextBox330.Enabled = False
            Me.TextBox331.Enabled = False
            Me.TextBox332.Enabled = False
            Me.TextBox333.Enabled = False
            Me.TextBox334.Enabled = False
            Me.TextBox335.Enabled = False
            Me.TextBox336.Enabled = False
            Me.TextBox559.Enabled = False
            Me.DateTimePicker23.Enabled = False

        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            Me.TextBox311.Enabled = True
            Me.TextBox312.Enabled = True
            Me.TextBox313.Enabled = True
            Me.TextBox314.Enabled = True
            Me.TextBox315.Enabled = True
            Me.TextBox316.Enabled = True
            Me.TextBox317.Enabled = True
            Me.TextBox318.Enabled = True
            Me.TextBox319.Enabled = True
            Me.TextBox320.Enabled = True
            Me.TextBox321.Enabled = True
            Me.TextBox322.Enabled = True
            Me.TextBox560.Enabled = True
            Me.DateTimePicker22.Enabled = True

        ElseIf RadioButton11.Checked = False Then
            Me.TextBox311.Enabled = False
            Me.TextBox312.Enabled = False
            Me.TextBox313.Enabled = False
            Me.TextBox314.Enabled = False
            Me.TextBox315.Enabled = False
            Me.TextBox316.Enabled = False
            Me.TextBox317.Enabled = False
            Me.TextBox318.Enabled = False
            Me.TextBox319.Enabled = False
            Me.TextBox320.Enabled = False
            Me.TextBox321.Enabled = False
            Me.TextBox322.Enabled = False
            Me.TextBox560.Enabled = False
            Me.DateTimePicker22.Enabled = False

        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            Me.TextBox297.Enabled = True
            Me.TextBox298.Enabled = True
            Me.TextBox299.Enabled = True
            Me.TextBox300.Enabled = True
            Me.TextBox301.Enabled = True
            Me.TextBox302.Enabled = True
            Me.TextBox303.Enabled = True
            Me.TextBox304.Enabled = True
            Me.TextBox305.Enabled = True
            Me.TextBox306.Enabled = True
            Me.TextBox307.Enabled = True
            Me.TextBox308.Enabled = True
            Me.TextBox561.Enabled = True
            Me.DateTimePicker21.Enabled = True

        ElseIf RadioButton10.Checked = False Then
            Me.TextBox297.Enabled = False
            Me.TextBox298.Enabled = False
            Me.TextBox299.Enabled = False
            Me.TextBox300.Enabled = False
            Me.TextBox301.Enabled = False
            Me.TextBox302.Enabled = False
            Me.TextBox303.Enabled = False
            Me.TextBox304.Enabled = False
            Me.TextBox305.Enabled = False
            Me.TextBox306.Enabled = False
            Me.TextBox307.Enabled = False
            Me.TextBox308.Enabled = False
            Me.TextBox561.Enabled = False
            Me.DateTimePicker21.Enabled = False

        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            Me.TextBox283.Enabled = True
            Me.TextBox284.Enabled = True
            Me.TextBox285.Enabled = True
            Me.TextBox286.Enabled = True
            Me.TextBox287.Enabled = True
            Me.TextBox288.Enabled = True
            Me.TextBox289.Enabled = True
            Me.TextBox290.Enabled = True
            Me.TextBox291.Enabled = True
            Me.TextBox292.Enabled = True
            Me.TextBox293.Enabled = True
            Me.TextBox294.Enabled = True
            Me.TextBox562.Enabled = True
            Me.DateTimePicker20.Enabled = True

        ElseIf RadioButton9.Checked = False Then
            Me.TextBox283.Enabled = False
            Me.TextBox284.Enabled = False
            Me.TextBox285.Enabled = False
            Me.TextBox286.Enabled = False
            Me.TextBox287.Enabled = False
            Me.TextBox288.Enabled = False
            Me.TextBox289.Enabled = False
            Me.TextBox290.Enabled = False
            Me.TextBox291.Enabled = False
            Me.TextBox292.Enabled = False
            Me.TextBox293.Enabled = False
            Me.TextBox294.Enabled = False
            Me.TextBox562.Enabled = False
            Me.DateTimePicker20.Enabled = False

        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Me.TextBox268.Enabled = True
            Me.TextBox269.Enabled = True
            Me.TextBox270.Enabled = True
            Me.TextBox271.Enabled = True
            Me.TextBox272.Enabled = True
            Me.TextBox273.Enabled = True
            Me.TextBox275.Enabled = True
            Me.TextBox276.Enabled = True
            Me.TextBox277.Enabled = True
            Me.TextBox278.Enabled = True
            Me.TextBox279.Enabled = True
            Me.TextBox280.Enabled = True
            Me.TextBox563.Enabled = True
            Me.DateTimePicker19.Enabled = True

        ElseIf RadioButton8.Checked = False Then
            Me.TextBox268.Enabled = False
            Me.TextBox269.Enabled = False
            Me.TextBox270.Enabled = False
            Me.TextBox271.Enabled = False
            Me.TextBox272.Enabled = False
            Me.TextBox273.Enabled = False
            Me.TextBox275.Enabled = False
            Me.TextBox276.Enabled = False
            Me.TextBox277.Enabled = False
            Me.TextBox278.Enabled = False
            Me.TextBox279.Enabled = False
            Me.TextBox280.Enabled = False
            Me.TextBox563.Enabled = False
            Me.DateTimePicker19.Enabled = False

        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            Me.TextBox254.Enabled = True
            Me.TextBox255.Enabled = True
            Me.TextBox256.Enabled = True
            Me.TextBox257.Enabled = True
            Me.TextBox258.Enabled = True
            Me.TextBox259.Enabled = True
            Me.TextBox260.Enabled = True
            Me.TextBox261.Enabled = True
            Me.TextBox262.Enabled = True
            Me.TextBox263.Enabled = True
            Me.TextBox264.Enabled = True
            Me.TextBox265.Enabled = True
            Me.TextBox564.Enabled = True
            Me.DateTimePicker18.Enabled = True

        ElseIf RadioButton7.Checked = False Then
            Me.TextBox254.Enabled = False
            Me.TextBox255.Enabled = False
            Me.TextBox256.Enabled = False
            Me.TextBox257.Enabled = False
            Me.TextBox258.Enabled = False
            Me.TextBox259.Enabled = False
            Me.TextBox260.Enabled = False
            Me.TextBox261.Enabled = False
            Me.TextBox262.Enabled = False
            Me.TextBox263.Enabled = False
            Me.TextBox264.Enabled = False
            Me.TextBox265.Enabled = False
            Me.TextBox564.Enabled = False
            Me.DateTimePicker18.Enabled = False

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Me.TextBox240.Enabled = True
            Me.TextBox241.Enabled = True
            Me.TextBox242.Enabled = True
            Me.TextBox243.Enabled = True
            Me.TextBox244.Enabled = True
            Me.TextBox245.Enabled = True
            Me.TextBox246.Enabled = True
            Me.TextBox247.Enabled = True
            Me.TextBox248.Enabled = True
            Me.TextBox249.Enabled = True
            Me.TextBox250.Enabled = True
            Me.TextBox251.Enabled = True
            Me.TextBox565.Enabled = True
            Me.DateTimePicker17.Enabled = True

        ElseIf RadioButton6.Checked = False Then
            Me.TextBox240.Enabled = False
            Me.TextBox241.Enabled = False
            Me.TextBox242.Enabled = False
            Me.TextBox243.Enabled = False
            Me.TextBox244.Enabled = False
            Me.TextBox245.Enabled = False
            Me.TextBox246.Enabled = False
            Me.TextBox247.Enabled = False
            Me.TextBox248.Enabled = False
            Me.TextBox249.Enabled = False
            Me.TextBox250.Enabled = False
            Me.TextBox251.Enabled = False
            Me.TextBox565.Enabled = False
            Me.DateTimePicker17.Enabled = False

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Me.TextBox226.Enabled = True
            Me.TextBox227.Enabled = True
            Me.TextBox228.Enabled = True
            Me.TextBox229.Enabled = True
            Me.TextBox230.Enabled = True
            Me.TextBox231.Enabled = True
            Me.TextBox232.Enabled = True
            Me.TextBox233.Enabled = True
            Me.TextBox234.Enabled = True
            Me.TextBox235.Enabled = True
            Me.TextBox236.Enabled = True
            Me.TextBox237.Enabled = True
            Me.TextBox566.Enabled = True
            Me.DateTimePicker16.Enabled = True

        ElseIf RadioButton5.Checked = False Then
            Me.TextBox226.Enabled = False
            Me.TextBox227.Enabled = False
            Me.TextBox228.Enabled = False
            Me.TextBox229.Enabled = False
            Me.TextBox230.Enabled = False
            Me.TextBox231.Enabled = False
            Me.TextBox232.Enabled = False
            Me.TextBox233.Enabled = False
            Me.TextBox234.Enabled = False
            Me.TextBox235.Enabled = False
            Me.TextBox236.Enabled = False
            Me.TextBox237.Enabled = False
            Me.TextBox566.Enabled = False
            Me.DateTimePicker16.Enabled = False

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Me.TextBox212.Enabled = True
            Me.TextBox213.Enabled = True
            Me.TextBox214.Enabled = True
            Me.TextBox215.Enabled = True
            Me.TextBox216.Enabled = True
            Me.TextBox217.Enabled = True
            Me.TextBox218.Enabled = True
            Me.TextBox219.Enabled = True
            Me.TextBox220.Enabled = True
            Me.TextBox221.Enabled = True
            Me.TextBox222.Enabled = True
            Me.TextBox223.Enabled = True
            Me.TextBox567.Enabled = True
            Me.DateTimePicker15.Enabled = True

        ElseIf RadioButton4.Checked = False Then
            Me.TextBox212.Enabled = False
            Me.TextBox213.Enabled = False
            Me.TextBox214.Enabled = False
            Me.TextBox215.Enabled = False
            Me.TextBox216.Enabled = False
            Me.TextBox217.Enabled = False
            Me.TextBox218.Enabled = False
            Me.TextBox219.Enabled = False
            Me.TextBox220.Enabled = False
            Me.TextBox221.Enabled = False
            Me.TextBox222.Enabled = False
            Me.TextBox223.Enabled = False
            Me.TextBox567.Enabled = False
            Me.DateTimePicker15.Enabled = False

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Me.TextBox198.Enabled = True
            Me.TextBox199.Enabled = True
            Me.TextBox200.Enabled = True
            Me.TextBox201.Enabled = True
            Me.TextBox202.Enabled = True
            Me.TextBox203.Enabled = True
            Me.TextBox204.Enabled = True
            Me.TextBox205.Enabled = True
            Me.TextBox206.Enabled = True
            Me.TextBox207.Enabled = True
            Me.TextBox208.Enabled = True
            Me.TextBox209.Enabled = True
            Me.TextBox568.Enabled = True
            Me.DateTimePicker14.Enabled = True

        ElseIf RadioButton3.Checked = False Then
            Me.TextBox198.Enabled = False
            Me.TextBox199.Enabled = False
            Me.TextBox200.Enabled = False
            Me.TextBox201.Enabled = False
            Me.TextBox202.Enabled = False
            Me.TextBox203.Enabled = False
            Me.TextBox204.Enabled = False
            Me.TextBox205.Enabled = False
            Me.TextBox206.Enabled = False
            Me.TextBox207.Enabled = False
            Me.TextBox208.Enabled = False
            Me.TextBox209.Enabled = False
            Me.TextBox568.Enabled = False
            Me.DateTimePicker14.Enabled = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Me.TextBox184.Enabled = True
            Me.TextBox185.Enabled = True
            Me.TextBox186.Enabled = True
            Me.TextBox187.Enabled = True
            Me.TextBox188.Enabled = True
            Me.TextBox189.Enabled = True
            Me.TextBox190.Enabled = True
            Me.TextBox191.Enabled = True
            Me.TextBox192.Enabled = True
            Me.TextBox193.Enabled = True
            Me.TextBox194.Enabled = True
            Me.TextBox195.Enabled = True
            Me.TextBox569.Enabled = True
            Me.DateTimePicker13.Enabled = True

        ElseIf RadioButton2.Checked = False Then
            Me.TextBox184.Enabled = False
            Me.TextBox185.Enabled = False
            Me.TextBox186.Enabled = False
            Me.TextBox187.Enabled = False
            Me.TextBox188.Enabled = False
            Me.TextBox189.Enabled = False
            Me.TextBox190.Enabled = False
            Me.TextBox191.Enabled = False
            Me.TextBox192.Enabled = False
            Me.TextBox193.Enabled = False
            Me.TextBox194.Enabled = False
            Me.TextBox195.Enabled = False
            Me.TextBox569.Enabled = False
            Me.DateTimePicker13.Enabled = False

        End If
    End Sub

    
    Private Sub TextBox350_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox350.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox349_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox349.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox348_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox348.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox347_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox347.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox346_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox346.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox345_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox345.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox344_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox344.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox343_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox343.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox342_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox342.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox341_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox341.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox340_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox340.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox339_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox339.TextChanged
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox338_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox337_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_JAN()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox336_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox336.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox335_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox335.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox334_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox334.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox333_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox333.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox332_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox332.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox331_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox331.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox330_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox330.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox329_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox329.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox328_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox328.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox327_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox327.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox326_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox326.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox325_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox325.TextChanged
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox324_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox323_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Feb()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox322_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox322.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox321_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox321.TextChanged
        Me.Three_AccountTotal()

    End Sub

    Private Sub TextBox320_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox320.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox319_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox319.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox318_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox318.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox317_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox317.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox316_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox316.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox315_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox315.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox314_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox314.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox313_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox313.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox312_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox312.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox311_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox311.TextChanged
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox310_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox309_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Mar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox308_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox308.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox307_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox307.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox306_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox306.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox305_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox305.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox304_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox304.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox303_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox303.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox302_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox302.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox301_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox301.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox300_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox300.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox299_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox299.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox298_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox298.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox297_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox297.TextChanged
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox296_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox295_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_April()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox294_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox294.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox293_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox293.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox292_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox292.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox291_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox291.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox290_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox290.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox289_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox289.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox288_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox288.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox287_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox287.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox286_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox286.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox285_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox285.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox284_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox284.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox283_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox283.TextChanged
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox282_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox281_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_May()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox280_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox280.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox279_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox279.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox278_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox278.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox277_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox277.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox276_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox276.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox275_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox275.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox273_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox273.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox272_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox272.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox271_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox271.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox270_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox270.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox269_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox269.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox268_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox268.TextChanged
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox267_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox266_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Jun()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox265_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox265.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox264_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox264.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox263_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox263.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox262_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox262.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox261_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox261.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox260_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox260.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox259_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox259.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox258_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox258.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox257_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox257.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox256_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox256.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox255_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox255.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox254_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox254.TextChanged
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox253_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox252_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_July()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox251_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox251.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox250_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox250.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox249_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox249.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox248_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox248.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox247_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox247.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox246_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox246.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox245_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox245.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox244_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox244.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox243_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox243.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox242_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox242.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox241_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox241.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox240_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox240.TextChanged
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox239_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox238_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Aug()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox237_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox237.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox236_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox236.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()

    End Sub

    Private Sub TextBox235_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox235.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox234_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox234.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox233_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox233.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox232_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox232.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox231_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox231.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox230_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox230.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox229_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox229.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox228_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox228.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox227_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox227.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox226_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox226.TextChanged
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox225_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox224_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Septimbar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox223_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox223.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox222_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox222.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox221_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox221.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox220_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox220.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox219_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox219.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox218_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox218.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox217_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox217.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox216_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox216.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox215_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox215.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox214_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox214.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox213_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox213.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox212_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox212.TextChanged
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox211_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox210_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_October()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox209_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox209.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox208_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox208.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox207_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox207.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox206_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox206.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox205_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox205.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox204_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox204.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox203_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox203.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox202_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox202.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox201_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox201.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox200_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox200.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox199_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox199.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox198_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox198.TextChanged
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox197_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox196_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_November()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox195_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox195.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox194_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox194.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox193_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox193.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox192_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox192.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox191_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox191.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox190_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox190.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox189_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox189.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox188_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox188.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox187_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox187.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox186_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox186.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox185_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox185.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox184_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox184.TextChanged
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox183_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub

    Private Sub TextBox182_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Three_Decembar()
        Me.Three_AccountTotal()
    End Sub


    Private Sub Four_AccountTotal()
        Me.TextBox365.Text = Val(TextBox545.Text) + Val(TextBox531.Text) + Val(TextBox517.Text) + Val(TextBox503.Text) + Val(TextBox489.Text) + Val(TextBox475.Text) + Val(TextBox461.Text) + Val(TextBox447.Text) + Val(TextBox433.Text) + Val(TextBox419.Text) + Val(TextBox405.Text) + Val(TextBox391.Text)
        Me.TextBox364.Text = Val(TextBox544.Text) + Val(TextBox530.Text) + Val(TextBox516.Text) + Val(TextBox502.Text) + Val(TextBox488.Text) + Val(TextBox474.Text) + Val(TextBox460.Text) + Val(TextBox446.Text) + Val(TextBox432.Text) + Val(TextBox418.Text) + Val(TextBox404.Text) + Val(TextBox390.Text)
        Me.TextBox363.Text = Val(TextBox543.Text) + Val(TextBox529.Text) + Val(TextBox515.Text) + Val(TextBox501.Text) + Val(TextBox487.Text) + Val(TextBox473.Text) + Val(TextBox459.Text) + Val(TextBox445.Text) + Val(TextBox431.Text) + Val(TextBox417.Text) + Val(TextBox403.Text) + Val(TextBox389.Text)
        Me.TextBox362.Text = Val(TextBox542.Text) + Val(TextBox528.Text) + Val(TextBox514.Text) + Val(TextBox500.Text) + Val(TextBox486.Text) + Val(TextBox472.Text) + Val(TextBox458.Text) + Val(TextBox444.Text) + Val(TextBox430.Text) + Val(TextBox416.Text) + Val(TextBox402.Text) + Val(TextBox388.Text)
        Me.TextBox361.Text = Val(TextBox541.Text) + Val(TextBox527.Text) + Val(TextBox513.Text) + Val(TextBox499.Text) + Val(TextBox485.Text) + Val(TextBox471.Text) + Val(TextBox457.Text) + Val(TextBox443.Text) + Val(TextBox429.Text) + Val(TextBox415.Text) + Val(TextBox401.Text) + Val(TextBox387.Text)
        Me.TextBox360.Text = Val(TextBox540.Text) + Val(TextBox526.Text) + Val(TextBox512.Text) + Val(TextBox498.Text) + Val(TextBox484.Text) + Val(TextBox470.Text) + Val(TextBox456.Text) + Val(TextBox442.Text) + Val(TextBox428.Text) + Val(TextBox414.Text) + Val(TextBox400.Text) + Val(TextBox386.Text)
        Me.TextBox359.Text = Val(TextBox539.Text) + Val(TextBox525.Text) + Val(TextBox511.Text) + Val(TextBox493.Text) + Val(TextBox483.Text) + Val(TextBox469.Text) + Val(TextBox455.Text) + Val(TextBox441.Text) + Val(TextBox427.Text) + Val(TextBox413.Text) + Val(TextBox399.Text) + Val(TextBox385.Text)
        Me.TextBox358.Text = Val(TextBox538.Text) + Val(TextBox524.Text) + Val(TextBox510.Text) + Val(TextBox497.Text) + Val(TextBox482.Text) + Val(TextBox468.Text) + Val(TextBox454.Text) + Val(TextBox440.Text) + Val(TextBox426.Text) + Val(TextBox412.Text) + Val(TextBox398.Text) + Val(TextBox384.Text)
        Me.TextBox357.Text = Val(TextBox537.Text) + Val(TextBox523.Text) + Val(TextBox509.Text) + Val(TextBox496.Text) + Val(TextBox481.Text) + Val(TextBox467.Text) + Val(TextBox453.Text) + Val(TextBox439.Text) + Val(TextBox425.Text) + Val(TextBox411.Text) + Val(TextBox397.Text) + Val(TextBox383.Text)
        Me.TextBox356.Text = Val(TextBox536.Text) + Val(TextBox522.Text) + Val(TextBox508.Text) + Val(TextBox495.Text) + Val(TextBox480.Text) + Val(TextBox466.Text) + Val(TextBox452.Text) + Val(TextBox438.Text) + Val(TextBox424.Text) + Val(TextBox410.Text) + Val(TextBox396.Text) + Val(TextBox382.Text)
        Me.TextBox355.Text = Val(TextBox535.Text) + Val(TextBox521.Text) + Val(TextBox507.Text) + Val(TextBox493.Text) + Val(TextBox479.Text) + Val(TextBox465.Text) + Val(TextBox451.Text) + Val(TextBox437.Text) + Val(TextBox423.Text) + Val(TextBox409.Text) + Val(TextBox395.Text) + Val(TextBox381.Text)
        Me.TextBox354.Text = Val(TextBox534.Text) + Val(TextBox520.Text) + Val(TextBox506.Text) + Val(TextBox492.Text) + Val(TextBox478.Text) + Val(TextBox464.Text) + Val(TextBox450.Text) + Val(TextBox436.Text) + Val(TextBox422.Text) + Val(TextBox408.Text) + Val(TextBox394.Text) + Val(TextBox380.Text)

        'Total
        Me.TextBox351.Text = Val(TextBox354.Text) + Val(TextBox355.Text) + Val(TextBox356.Text) + Val(TextBox357.Text) + Val(TextBox358.Text) + Val(TextBox359.Text) + Val(TextBox360.Text) + Val(TextBox361.Text) + Val(TextBox362.Text) + Val(TextBox363.Text) + Val(TextBox364.Text) + Val(TextBox365.Text)


        If TextBox354.Text = "0" Then
            Me.TextBox354.Clear()
        End If

        If TextBox355.Text = "0" Then
            Me.TextBox355.Clear()
        End If

        If TextBox356.Text = "0" Then
            Me.TextBox356.Clear()
        End If

        If TextBox357.Text = "0" Then
            Me.TextBox357.Clear()
        End If

        If TextBox358.Text = "0" Then
            Me.TextBox358.Clear()
        End If

        If TextBox359.Text = "0" Then
            Me.TextBox359.Clear()
        End If

        If TextBox360.Text = "0" Then
            Me.TextBox360.Clear()
        End If

        If TextBox361.Text = "0" Then
            Me.TextBox361.Clear()
        End If

        If TextBox362.Text = "0" Then
            Me.TextBox362.Clear()
        End If

        If TextBox363.Text = "0" Then
            Me.TextBox363.Clear()
        End If

        If TextBox364.Text = "0" Then
            Me.TextBox364.Clear()
        End If

        If TextBox365.Text = "0" Then
            Me.TextBox365.Clear()
        End If

        '******************************

        If TextBox366.Text = "0" Then
            Me.TextBox366.Clear()
        End If

        If TextBox367.Text = "0" Then
            Me.TextBox367.Clear()
        End If

        If TextBox368.Text = "0" Then
            Me.TextBox368.Clear()
        End If

        If TextBox369.Text = "0" Then
            Me.TextBox369.Clear()
        End If

        If TextBox370.Text = "0" Then
            Me.TextBox370.Clear()
        End If

        If TextBox371.Text = "0" Then
            Me.TextBox371.Clear()
        End If

        If TextBox372.Text = "0" Then
            Me.TextBox372.Clear()
        End If

        If TextBox373.Text = "0" Then
            Me.TextBox373.Clear()
        End If

        If TextBox374.Text = "0" Then
            Me.TextBox374.Clear()
        End If

        If TextBox375.Text = "0" Then
            Me.TextBox375.Clear()
        End If

        If TextBox376.Text = "0" Then
            Me.TextBox376.Clear()
        End If

        If TextBox377.Text = "0" Then
            Me.TextBox377.Clear()
        End If

        If TextBox351.Text = "0" Then
            Me.TextBox351.Clear()
        End If

    End Sub


    Private Sub Four_JAN()
        Me.TextBox377.Text = Val(TextBox534.Text) + Val(TextBox535.Text) + Val(TextBox536.Text) + Val(TextBox537.Text) + Val(TextBox538.Text) + Val(TextBox539.Text) + Val(TextBox540.Text) + Val(TextBox541.Text) + Val(TextBox542.Text) + Val(TextBox543.Text) + Val(TextBox544.Text) + Val(TextBox545.Text)
    End Sub

    Private Sub Four_Feb()
        Me.TextBox376.Text = Val(TextBox520.Text) + Val(TextBox521.Text) + Val(TextBox522.Text) + Val(TextBox523.Text) + Val(TextBox524.Text) + Val(TextBox525.Text) + Val(TextBox526.Text) + Val(TextBox527.Text) + Val(TextBox528.Text) + Val(TextBox529.Text) + Val(TextBox530.Text) + Val(TextBox531.Text)
    End Sub

    Private Sub Four_Mar()
        Me.TextBox375.Text = Val(TextBox506.Text) + Val(TextBox507.Text) + Val(TextBox508.Text) + Val(TextBox509.Text) + Val(TextBox510.Text) + Val(TextBox511.Text) + Val(TextBox512.Text) + Val(TextBox513.Text) + Val(TextBox514.Text) + Val(TextBox515.Text) + Val(TextBox516.Text) + Val(TextBox517.Text)
    End Sub

    Private Sub Four_April()
        Me.TextBox374.Text = Val(TextBox492.Text) + Val(TextBox493.Text) + Val(TextBox494.Text) + Val(TextBox495.Text) + Val(TextBox496.Text) + Val(TextBox497.Text) + Val(TextBox498.Text) + Val(TextBox499.Text) + Val(TextBox500.Text) + Val(TextBox501.Text) + Val(TextBox502.Text) + Val(TextBox503.Text)
    End Sub

    Private Sub Four_May()
        Me.TextBox373.Text = Val(TextBox478.Text) + Val(TextBox479.Text) + Val(TextBox480.Text) + Val(TextBox481.Text) + Val(TextBox482.Text) + Val(TextBox483.Text) + Val(TextBox484.Text) + Val(TextBox485.Text) + Val(TextBox486.Text) + Val(TextBox487.Text) + Val(TextBox488.Text) + Val(TextBox489.Text)
    End Sub

    Private Sub Four_Jun()
        Me.TextBox372.Text = Val(TextBox464.Text) + Val(TextBox465.Text) + Val(TextBox466.Text) + Val(TextBox467.Text) + Val(TextBox468.Text) + Val(TextBox469.Text) + Val(TextBox470.Text) + Val(TextBox471.Text) + Val(TextBox472.Text) + Val(TextBox473.Text) + Val(TextBox474.Text) + Val(TextBox475.Text)
    End Sub

    Private Sub Four_July()
        Me.TextBox371.Text = Val(TextBox450.Text) + Val(TextBox451.Text) + Val(TextBox452.Text) + Val(TextBox453.Text) + Val(TextBox454.Text) + Val(TextBox455.Text) + Val(TextBox456.Text) + Val(TextBox457.Text) + Val(TextBox458.Text) + Val(TextBox459.Text) + Val(TextBox460.Text) + Val(TextBox461.Text)
    End Sub

    Private Sub Four_Aug()
        Me.TextBox370.Text = Val(TextBox436.Text) + Val(TextBox437.Text) + Val(TextBox438.Text) + Val(TextBox439.Text) + Val(TextBox440.Text) + Val(TextBox441.Text) + Val(TextBox442.Text) + Val(TextBox443.Text) + Val(TextBox444.Text) + Val(TextBox445.Text) + Val(TextBox446.Text) + Val(TextBox447.Text)
    End Sub

    Private Sub Four_Septimbar()
        Me.TextBox369.Text = Val(TextBox422.Text) + Val(TextBox423.Text) + Val(TextBox424.Text) + Val(TextBox425.Text) + Val(TextBox426.Text) + Val(TextBox427.Text) + Val(TextBox428.Text) + Val(TextBox429.Text) + Val(TextBox430.Text) + Val(TextBox431.Text) + Val(TextBox432.Text) + Val(TextBox433.Text)
    End Sub

    Private Sub Four_October()
        Me.TextBox368.Text = Val(TextBox408.Text) + Val(TextBox409.Text) + Val(TextBox410.Text) + Val(TextBox411.Text) + Val(TextBox412.Text) + Val(TextBox413.Text) + Val(TextBox414.Text) + Val(TextBox415.Text) + Val(TextBox416.Text) + Val(TextBox417.Text) + Val(TextBox418.Text) + Val(TextBox419.Text)
    End Sub

    Private Sub Four_November()
        Me.TextBox367.Text = Val(TextBox394.Text) + Val(TextBox395.Text) + Val(TextBox396.Text) + Val(TextBox397.Text) + Val(TextBox398.Text) + Val(TextBox399.Text) + Val(TextBox400.Text) + Val(TextBox401.Text) + Val(TextBox402.Text) + Val(TextBox403.Text) + Val(TextBox404.Text) + Val(TextBox405.Text)
    End Sub

    Private Sub Four_Decembar()
        Me.TextBox366.Text = Val(TextBox380.Text) + Val(TextBox381.Text) + Val(TextBox382.Text) + Val(TextBox383.Text) + Val(TextBox384.Text) + Val(TextBox385.Text) + Val(TextBox386.Text) + Val(TextBox387.Text) + Val(TextBox388.Text) + Val(TextBox389.Text) + Val(TextBox390.Text) + Val(TextBox391.Text)
    End Sub

    Private Sub RadioButton26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton26.CheckedChanged
        If RadioButton26.Checked = True Then
            Me.TextBox534.Enabled = True
            Me.TextBox535.Enabled = True
            Me.TextBox536.Enabled = True
            Me.TextBox537.Enabled = True
            Me.TextBox538.Enabled = True
            Me.TextBox539.Enabled = True
            Me.TextBox540.Enabled = True
            Me.TextBox541.Enabled = True
            Me.TextBox542.Enabled = True
            Me.TextBox543.Enabled = True
            Me.TextBox544.Enabled = True
            Me.TextBox545.Enabled = True
            Me.TextBox581.Enabled = True
            Me.DateTimePicker25.Enabled = True

        ElseIf RadioButton26.Checked = False Then
            Me.TextBox534.Enabled = False
            Me.TextBox535.Enabled = False
            Me.TextBox536.Enabled = False
            Me.TextBox537.Enabled = False
            Me.TextBox538.Enabled = False
            Me.TextBox539.Enabled = False
            Me.TextBox540.Enabled = False
            Me.TextBox541.Enabled = False
            Me.TextBox542.Enabled = False
            Me.TextBox543.Enabled = False
            Me.TextBox544.Enabled = False
            Me.TextBox545.Enabled = False
            Me.TextBox581.Enabled = False
            Me.DateTimePicker25.Enabled = False

        End If
    End Sub

    Private Sub RadioButton25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton25.CheckedChanged
        If RadioButton25.Checked = True Then
            Me.TextBox520.Enabled = True
            Me.TextBox521.Enabled = True
            Me.TextBox522.Enabled = True
            Me.TextBox523.Enabled = True
            Me.TextBox524.Enabled = True
            Me.TextBox525.Enabled = True
            Me.TextBox526.Enabled = True
            Me.TextBox527.Enabled = True
            Me.TextBox528.Enabled = True
            Me.TextBox529.Enabled = True
            Me.TextBox530.Enabled = True
            Me.TextBox531.Enabled = True
            Me.TextBox580.Enabled = True
            Me.DateTimePicker36.Enabled = True

        ElseIf RadioButton25.Checked = False Then
            Me.TextBox520.Enabled = False
            Me.TextBox521.Enabled = False
            Me.TextBox522.Enabled = False
            Me.TextBox523.Enabled = False
            Me.TextBox524.Enabled = False
            Me.TextBox525.Enabled = False
            Me.TextBox526.Enabled = False
            Me.TextBox527.Enabled = False
            Me.TextBox528.Enabled = False
            Me.TextBox529.Enabled = False
            Me.TextBox530.Enabled = False
            Me.TextBox531.Enabled = False
            Me.TextBox580.Enabled = False
            Me.DateTimePicker36.Enabled = False

        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked = True Then
            Me.TextBox506.Enabled = True
            Me.TextBox507.Enabled = True
            Me.TextBox508.Enabled = True
            Me.TextBox509.Enabled = True
            Me.TextBox510.Enabled = True
            Me.TextBox511.Enabled = True
            Me.TextBox512.Enabled = True
            Me.TextBox513.Enabled = True
            Me.TextBox514.Enabled = True
            Me.TextBox515.Enabled = True
            Me.TextBox516.Enabled = True
            Me.TextBox517.Enabled = True
            Me.TextBox579.Enabled = True
            Me.DateTimePicker35.Enabled = True

        ElseIf RadioButton24.Checked = False Then
            Me.TextBox506.Enabled = False
            Me.TextBox507.Enabled = False
            Me.TextBox508.Enabled = False
            Me.TextBox509.Enabled = False
            Me.TextBox510.Enabled = False
            Me.TextBox511.Enabled = False
            Me.TextBox512.Enabled = False
            Me.TextBox513.Enabled = False
            Me.TextBox514.Enabled = False
            Me.TextBox515.Enabled = False
            Me.TextBox516.Enabled = False
            Me.TextBox517.Enabled = False
            Me.TextBox579.Enabled = False
            Me.DateTimePicker35.Enabled = False

        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton23.CheckedChanged
        If RadioButton23.Checked = True Then
            Me.TextBox492.Enabled = True
            Me.TextBox493.Enabled = True
            Me.TextBox494.Enabled = True
            Me.TextBox495.Enabled = True
            Me.TextBox496.Enabled = True
            Me.TextBox497.Enabled = True
            Me.TextBox498.Enabled = True
            Me.TextBox499.Enabled = True
            Me.TextBox500.Enabled = True
            Me.TextBox501.Enabled = True
            Me.TextBox502.Enabled = True
            Me.TextBox503.Enabled = True
            Me.TextBox578.Enabled = True
            Me.DateTimePicker34.Enabled = True

        ElseIf RadioButton23.Checked = False Then
            Me.TextBox492.Enabled = False
            Me.TextBox493.Enabled = False
            Me.TextBox494.Enabled = False
            Me.TextBox495.Enabled = False
            Me.TextBox496.Enabled = False
            Me.TextBox497.Enabled = False
            Me.TextBox498.Enabled = False
            Me.TextBox499.Enabled = False
            Me.TextBox500.Enabled = False
            Me.TextBox501.Enabled = False
            Me.TextBox502.Enabled = False
            Me.TextBox503.Enabled = False
            Me.TextBox578.Enabled = False
            Me.DateTimePicker34.Enabled = False

        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton22.CheckedChanged
        If RadioButton22.Checked = True Then
            Me.TextBox478.Enabled = True
            Me.TextBox479.Enabled = True
            Me.TextBox480.Enabled = True
            Me.TextBox481.Enabled = True
            Me.TextBox482.Enabled = True
            Me.TextBox483.Enabled = True
            Me.TextBox484.Enabled = True
            Me.TextBox485.Enabled = True
            Me.TextBox486.Enabled = True
            Me.TextBox487.Enabled = True
            Me.TextBox488.Enabled = True
            Me.TextBox489.Enabled = True
            Me.TextBox577.Enabled = True
            Me.DateTimePicker33.Enabled = True

        ElseIf RadioButton22.Checked = False Then
            Me.TextBox478.Enabled = False
            Me.TextBox479.Enabled = False
            Me.TextBox480.Enabled = False
            Me.TextBox481.Enabled = False
            Me.TextBox482.Enabled = False
            Me.TextBox483.Enabled = False
            Me.TextBox484.Enabled = False
            Me.TextBox485.Enabled = False
            Me.TextBox486.Enabled = False
            Me.TextBox487.Enabled = False
            Me.TextBox488.Enabled = False
            Me.TextBox489.Enabled = False
            Me.TextBox577.Enabled = False
            Me.DateTimePicker33.Enabled = False

        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked = True Then
            Me.TextBox464.Enabled = True
            Me.TextBox465.Enabled = True
            Me.TextBox466.Enabled = True
            Me.TextBox467.Enabled = True
            Me.TextBox468.Enabled = True
            Me.TextBox469.Enabled = True
            Me.TextBox470.Enabled = True
            Me.TextBox471.Enabled = True
            Me.TextBox472.Enabled = True
            Me.TextBox473.Enabled = True
            Me.TextBox474.Enabled = True
            Me.TextBox475.Enabled = True
            Me.TextBox576.Enabled = True
            Me.DateTimePicker32.Enabled = True

        ElseIf RadioButton21.Checked = False Then
            Me.TextBox464.Enabled = False
            Me.TextBox465.Enabled = False
            Me.TextBox466.Enabled = False
            Me.TextBox467.Enabled = False
            Me.TextBox468.Enabled = False
            Me.TextBox469.Enabled = False
            Me.TextBox470.Enabled = False
            Me.TextBox471.Enabled = False
            Me.TextBox472.Enabled = False
            Me.TextBox473.Enabled = False
            Me.TextBox474.Enabled = False
            Me.TextBox475.Enabled = False
            Me.TextBox576.Enabled = False
            Me.DateTimePicker32.Enabled = False

        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked = True Then
            Me.TextBox450.Enabled = True
            Me.TextBox451.Enabled = True
            Me.TextBox452.Enabled = True
            Me.TextBox453.Enabled = True
            Me.TextBox454.Enabled = True
            Me.TextBox455.Enabled = True
            Me.TextBox456.Enabled = True
            Me.TextBox457.Enabled = True
            Me.TextBox458.Enabled = True
            Me.TextBox459.Enabled = True
            Me.TextBox460.Enabled = True
            Me.TextBox461.Enabled = True
            Me.TextBox575.Enabled = True
            Me.DateTimePicker31.Enabled = True

        ElseIf RadioButton20.Checked = False Then
            Me.TextBox450.Enabled = False
            Me.TextBox451.Enabled = False
            Me.TextBox452.Enabled = False
            Me.TextBox453.Enabled = False
            Me.TextBox454.Enabled = False
            Me.TextBox455.Enabled = False
            Me.TextBox456.Enabled = False
            Me.TextBox457.Enabled = False
            Me.TextBox458.Enabled = False
            Me.TextBox459.Enabled = False
            Me.TextBox460.Enabled = False
            Me.TextBox461.Enabled = False
            Me.TextBox575.Enabled = False
            Me.DateTimePicker31.Enabled = False

        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked = True Then
            Me.TextBox436.Enabled = True
            Me.TextBox437.Enabled = True
            Me.TextBox438.Enabled = True
            Me.TextBox439.Enabled = True
            Me.TextBox440.Enabled = True
            Me.TextBox441.Enabled = True
            Me.TextBox442.Enabled = True
            Me.TextBox443.Enabled = True
            Me.TextBox444.Enabled = True
            Me.TextBox445.Enabled = True
            Me.TextBox446.Enabled = True
            Me.TextBox447.Enabled = True
            Me.TextBox574.Enabled = True
            Me.DateTimePicker30.Enabled = True

        ElseIf RadioButton19.Checked = False Then
            Me.TextBox436.Enabled = False
            Me.TextBox437.Enabled = False
            Me.TextBox438.Enabled = False
            Me.TextBox439.Enabled = False
            Me.TextBox440.Enabled = False
            Me.TextBox441.Enabled = False
            Me.TextBox442.Enabled = False
            Me.TextBox443.Enabled = False
            Me.TextBox444.Enabled = False
            Me.TextBox445.Enabled = False
            Me.TextBox446.Enabled = False
            Me.TextBox447.Enabled = False
            Me.TextBox574.Enabled = False
            Me.DateTimePicker30.Enabled = False

        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            Me.TextBox422.Enabled = True
            Me.TextBox423.Enabled = True
            Me.TextBox424.Enabled = True
            Me.TextBox425.Enabled = True
            Me.TextBox426.Enabled = True
            Me.TextBox427.Enabled = True
            Me.TextBox428.Enabled = True
            Me.TextBox429.Enabled = True
            Me.TextBox430.Enabled = True
            Me.TextBox431.Enabled = True
            Me.TextBox432.Enabled = True
            Me.TextBox433.Enabled = True
            Me.TextBox573.Enabled = True
            Me.DateTimePicker29.Enabled = True

        ElseIf RadioButton18.Checked = False Then
            Me.TextBox422.Enabled = False
            Me.TextBox423.Enabled = False
            Me.TextBox424.Enabled = False
            Me.TextBox425.Enabled = False
            Me.TextBox426.Enabled = False
            Me.TextBox427.Enabled = False
            Me.TextBox428.Enabled = False
            Me.TextBox429.Enabled = False
            Me.TextBox430.Enabled = False
            Me.TextBox431.Enabled = False
            Me.TextBox432.Enabled = False
            Me.TextBox433.Enabled = False
            Me.TextBox573.Enabled = False
            Me.DateTimePicker29.Enabled = False

        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            Me.TextBox408.Enabled = True
            Me.TextBox409.Enabled = True
            Me.TextBox410.Enabled = True
            Me.TextBox411.Enabled = True
            Me.TextBox412.Enabled = True
            Me.TextBox413.Enabled = True
            Me.TextBox414.Enabled = True
            Me.TextBox415.Enabled = True
            Me.TextBox416.Enabled = True
            Me.TextBox417.Enabled = True
            Me.TextBox418.Enabled = True
            Me.TextBox419.Enabled = True
            Me.TextBox572.Enabled = True
            Me.DateTimePicker28.Enabled = True

        ElseIf RadioButton17.Checked = False Then
            Me.TextBox408.Enabled = False
            Me.TextBox409.Enabled = False
            Me.TextBox410.Enabled = False
            Me.TextBox411.Enabled = False
            Me.TextBox412.Enabled = False
            Me.TextBox413.Enabled = False
            Me.TextBox414.Enabled = False
            Me.TextBox415.Enabled = False
            Me.TextBox416.Enabled = False
            Me.TextBox417.Enabled = False
            Me.TextBox418.Enabled = False
            Me.TextBox419.Enabled = False
            Me.TextBox572.Enabled = False
            Me.DateTimePicker28.Enabled = False

        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            Me.TextBox394.Enabled = True
            Me.TextBox395.Enabled = True
            Me.TextBox396.Enabled = True
            Me.TextBox397.Enabled = True
            Me.TextBox398.Enabled = True
            Me.TextBox399.Enabled = True
            Me.TextBox400.Enabled = True
            Me.TextBox401.Enabled = True
            Me.TextBox402.Enabled = True
            Me.TextBox403.Enabled = True
            Me.TextBox404.Enabled = True
            Me.TextBox405.Enabled = True
            Me.TextBox571.Enabled = True
            Me.DateTimePicker27.Enabled = True

        ElseIf RadioButton16.Checked = False Then
            Me.TextBox394.Enabled = False
            Me.TextBox395.Enabled = False
            Me.TextBox396.Enabled = False
            Me.TextBox397.Enabled = False
            Me.TextBox398.Enabled = False
            Me.TextBox399.Enabled = False
            Me.TextBox400.Enabled = False
            Me.TextBox401.Enabled = False
            Me.TextBox402.Enabled = False
            Me.TextBox403.Enabled = False
            Me.TextBox404.Enabled = False
            Me.TextBox405.Enabled = False
            Me.TextBox571.Enabled = False
            Me.DateTimePicker27.Enabled = False

        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            Me.TextBox380.Enabled = True
            Me.TextBox381.Enabled = True
            Me.TextBox382.Enabled = True
            Me.TextBox383.Enabled = True
            Me.TextBox384.Enabled = True
            Me.TextBox385.Enabled = True
            Me.TextBox386.Enabled = True
            Me.TextBox387.Enabled = True
            Me.TextBox388.Enabled = True
            Me.TextBox389.Enabled = True
            Me.TextBox390.Enabled = True
            Me.TextBox391.Enabled = True
            Me.TextBox570.Enabled = True
            Me.DateTimePicker26.Enabled = True

        ElseIf RadioButton15.Checked = False Then
            Me.TextBox380.Enabled = False
            Me.TextBox381.Enabled = False
            Me.TextBox382.Enabled = False
            Me.TextBox383.Enabled = False
            Me.TextBox384.Enabled = False
            Me.TextBox385.Enabled = False
            Me.TextBox386.Enabled = False
            Me.TextBox387.Enabled = False
            Me.TextBox388.Enabled = False
            Me.TextBox389.Enabled = False
            Me.TextBox390.Enabled = False
            Me.TextBox391.Enabled = False
            Me.TextBox570.Enabled = False
            Me.DateTimePicker26.Enabled = False

        End If
    End Sub

    Private Sub TextBox545_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox545.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox544_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox544.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox543_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox543.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox542_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox542.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox541_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox541.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox540_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox540.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox539_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox539.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox538_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox538.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox537_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox537.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox536_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox536.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox535_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox535.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox534_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox534.TextChanged
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox533_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox532_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_JAN()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox531_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox531.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox530_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox530.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox529_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox529.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox528_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox528.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox527_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox527.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox526_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox526.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox525_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox525.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox524_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox524.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox523_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox523.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox522_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox522.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox521_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox521.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox520_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox520.TextChanged
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox519_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox518_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Feb()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox517_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox517.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox516_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox516.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox515_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox515.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox514_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox514.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox513_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox513.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox512_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox512.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox511_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox511.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox510_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox510.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox509_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox509.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox508_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox508.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox507_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox507.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox506_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox506.TextChanged
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox505_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox504_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Mar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox503_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox503.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox502_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox502.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox501_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox501.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox500_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox500.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox499_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox499.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox498_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox498.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox497_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox497.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox496_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox496.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox495_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox495.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox494_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox494.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox493_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox493.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox492_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox492.TextChanged
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox491_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox490_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_April()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox489_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox489.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox488_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox488.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox487_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox487.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox486_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox486.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox485_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox485.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox484_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox484.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox483_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox483.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox482_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox482.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox481_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox481.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox480_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox480.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox479_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox479.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox478_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox478.TextChanged
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox477_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox476_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_May()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox475_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox475.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox474_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox474.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox473_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox473.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox472_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox472.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox471_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox471.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox470_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox470.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox469_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox469.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox468_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox468.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox467_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox467.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox466_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox466.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox465_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox465.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox464_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox464.TextChanged
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox463_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox462_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Jun()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox461_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox461.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox460_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox460.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox459_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox459.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox458_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox458.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox457_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox457.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox456_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox456.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox455_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox455.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox454_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox454.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox453_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox453.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox452_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox452.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox451_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox451.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox450_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox450.TextChanged
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox449_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox448_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_July()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox447_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox447.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox446_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox446.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox445_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox445.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox444_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox444.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox443_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox443.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox442_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox442.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox441_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox441.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox440_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox440.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox439_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox439.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox438_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox438.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox437_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox437.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox436_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox436.TextChanged
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox435_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox434_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Aug()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox433_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox433.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox432_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox432.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox431_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox431.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox430_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox430.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox429_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox429.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox428_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox428.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox427_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox427.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox426_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox426.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox425_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox425.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox424_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox424.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox423_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox423.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox422_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox422.TextChanged
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox421_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox420_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Septimbar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox419_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox419.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox418_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox418.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox417_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox417.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox416_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox416.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox415_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox415.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox414_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox414.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox413_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox413.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox412_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox412.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox411_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox411.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox410_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox410.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox409_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox409.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox408_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox408.TextChanged
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox407_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox406_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_October()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox405_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox405.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox404_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox404.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox403_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox403.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox402_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox402.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox401_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox401.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox400_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox400.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox399_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox399.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox398_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox398.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox397_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox397.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox396_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox396.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox395_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox395.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox394_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox394.TextChanged
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox393_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox392_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_November()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox391_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox391.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox390_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox390.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox389_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox389.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox388_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox388.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox387_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox387.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox386_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox386.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox385_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox385.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox384_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox384.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox383_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox383.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox382_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox382.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox381_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox381.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox380_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox380.TextChanged
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox379_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub TextBox378_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Four_Decembar()
        Me.Four_AccountTotal()
    End Sub

    Private Sub DateTimePicker25_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker25.ValueChanged
        Me.TextBox581.Text = DateTimePicker25.Text
    End Sub

    Private Sub DateTimePicker36_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker36.ValueChanged
        Me.TextBox580.Text = DateTimePicker36.Text
    End Sub

    Private Sub DateTimePicker35_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker35.ValueChanged
        Me.TextBox579.Text = DateTimePicker35.Text
    End Sub

    Private Sub DateTimePicker34_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker34.ValueChanged
        Me.TextBox578.Text = DateTimePicker34.Text
    End Sub

    Private Sub DateTimePicker33_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker33.ValueChanged
        Me.TextBox577.Text = DateTimePicker33.Text
    End Sub

    Private Sub DateTimePicker32_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker32.ValueChanged
        Me.TextBox576.Text = DateTimePicker32.Text
    End Sub

    Private Sub DateTimePicker31_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker31.ValueChanged
        Me.TextBox575.Text = DateTimePicker31.Text
    End Sub

    Private Sub DateTimePicker30_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker30.ValueChanged
        Me.TextBox574.Text = DateTimePicker30.Text
    End Sub

    Private Sub DateTimePicker29_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker29.ValueChanged
        Me.TextBox573.Text = DateTimePicker29.Text
    End Sub

    Private Sub DateTimePicker28_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker28.ValueChanged
        Me.TextBox572.Text = DateTimePicker28.Text
    End Sub

    Private Sub DateTimePicker27_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker27.ValueChanged
        Me.TextBox571.Text = DateTimePicker27.Text
    End Sub

    Private Sub DateTimePicker26_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker26.ValueChanged
        Me.TextBox570.Text = DateTimePicker26.Text
    End Sub


    Private Sub RadioButtonJan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonJan.CheckedChanged
        If RadioButtonJan.Checked = True Then
            Me.TextBoxEigJan1.Enabled = True
            Me.TextBoxEigJan2.Enabled = True
            Me.TextBoxEigJan3.Enabled = True
            Me.TextBoxEigJan4.Enabled = True
            Me.TextBoxEigJan5.Enabled = True
            Me.TextBoxEigJan6.Enabled = True
            Me.TextBoxEigJan7.Enabled = True
            Me.TextBoxEigJan8.Enabled = True
            Me.TextBoxEigJan9.Enabled = True
            Me.TextBoxEigJan10.Enabled = True
            Me.TextBoxEigJan11.Enabled = True
            Me.TextBoxEigJan12.Enabled = True
            Me.TextBox593.Enabled = True
            Me.DateTimePicker1.Enabled = True

        ElseIf RadioButtonJan.Checked = False Then
            Me.TextBoxEigJan1.Enabled = False
            Me.TextBoxEigJan2.Enabled = False
            Me.TextBoxEigJan3.Enabled = False
            Me.TextBoxEigJan4.Enabled = False
            Me.TextBoxEigJan5.Enabled = False
            Me.TextBoxEigJan6.Enabled = False
            Me.TextBoxEigJan7.Enabled = False
            Me.TextBoxEigJan8.Enabled = False
            Me.TextBoxEigJan9.Enabled = False
            Me.TextBoxEigJan10.Enabled = False
            Me.TextBoxEigJan11.Enabled = False
            Me.TextBoxEigJan12.Enabled = False
            Me.TextBox593.Enabled = False
            Me.DateTimePicker1.Enabled = False

        End If

    End Sub

    Private Sub RadioButtonFeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonFeb.CheckedChanged
        If RadioButtonFeb.Checked = True Then
            Me.TextBoxEigFeb1.Enabled = True
            Me.TextBoxEigFeb2.Enabled = True
            Me.TextBoxEigFeb3.Enabled = True
            Me.TextBoxEigFeb4.Enabled = True
            Me.TextBoxEigFeb5.Enabled = True
            Me.TextBoxEigFeb6.Enabled = True
            Me.TextBoxEigFeb7.Enabled = True
            Me.TextBoxEigFeb8.Enabled = True
            Me.TextBoxEigFeb9.Enabled = True
            Me.TextBoxEigFeb10.Enabled = True
            Me.TextBoxEigFeb11.Enabled = True
            Me.TextBoxEigFeb12.Enabled = True
            Me.TextBox592.Enabled = True
            Me.DateTimePicker12.Enabled = True



        ElseIf RadioButtonFeb.Checked = False Then
            Me.TextBoxEigFeb1.Enabled = False
            Me.TextBoxEigFeb2.Enabled = False
            Me.TextBoxEigFeb3.Enabled = False
            Me.TextBoxEigFeb4.Enabled = False
            Me.TextBoxEigFeb5.Enabled = False
            Me.TextBoxEigFeb6.Enabled = False
            Me.TextBoxEigFeb7.Enabled = False
            Me.TextBoxEigFeb8.Enabled = False
            Me.TextBoxEigFeb9.Enabled = False
            Me.TextBoxEigFeb10.Enabled = False
            Me.TextBoxEigFeb11.Enabled = False
            Me.TextBoxEigFeb12.Enabled = False
            Me.TextBox592.Enabled = False
            Me.DateTimePicker12.Enabled = False

        End If

    End Sub

    Private Sub RadioButtonMar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMar.CheckedChanged
        If RadioButtonMar.Checked = True Then
            Me.TextBoxMar1.Enabled = True
            Me.TextBoxMar2.Enabled = True
            Me.TextBoxMar3.Enabled = True
            Me.TextBoxMar4.Enabled = True
            Me.TextBoxMar5.Enabled = True
            Me.TextBoxMar6.Enabled = True
            Me.TextBoxMar7.Enabled = True
            Me.TextBoxMar8.Enabled = True
            Me.TextBoxMar9.Enabled = True
            Me.TextBoxMar10.Enabled = True
            Me.TextBoxMar11.Enabled = True
            Me.TextBoxMar12.Enabled = True
            Me.TextBox591.Enabled = True
            Me.DateTimePicker11.Enabled = True

        ElseIf RadioButtonMar.Checked = False Then
            Me.TextBoxMar1.Enabled = False
            Me.TextBoxMar2.Enabled = False
            Me.TextBoxMar3.Enabled = False
            Me.TextBoxMar4.Enabled = False
            Me.TextBoxMar5.Enabled = False
            Me.TextBoxMar6.Enabled = False
            Me.TextBoxMar7.Enabled = False
            Me.TextBoxMar8.Enabled = False
            Me.TextBoxMar9.Enabled = False
            Me.TextBoxMar10.Enabled = False
            Me.TextBoxMar11.Enabled = False
            Me.TextBoxMar12.Enabled = False
            Me.TextBox591.Enabled = False
            Me.DateTimePicker11.Enabled = False

        End If
    End Sub

    Private Sub RadioButtonApr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonApr.CheckedChanged
        If RadioButtonApr.Checked = True Then
            Me.TextBoxApr1.Enabled = True
            Me.TextBoxApr2.Enabled = True
            Me.TextBoxApr3.Enabled = True
            Me.TextBoxApr4.Enabled = True
            Me.TextBoxApr5.Enabled = True
            Me.TextBoxApr6.Enabled = True
            Me.TextBoxApr7.Enabled = True
            Me.TextBoxApr8.Enabled = True
            Me.TextBoxApr9.Enabled = True
            Me.TextBoxApr10.Enabled = True
            Me.TextBoxApr11.Enabled = True
            Me.TextBoxApr12.Enabled = True
            Me.TextBox590.Enabled = True
            Me.DateTimePicker10.Enabled = True


        ElseIf RadioButtonApr.Checked = False Then
            Me.TextBoxApr1.Enabled = False
            Me.TextBoxApr2.Enabled = False
            Me.TextBoxApr3.Enabled = False
            Me.TextBoxApr4.Enabled = False
            Me.TextBoxApr5.Enabled = False
            Me.TextBoxApr6.Enabled = False
            Me.TextBoxApr7.Enabled = False
            Me.TextBoxApr8.Enabled = False
            Me.TextBoxApr9.Enabled = False
            Me.TextBoxApr10.Enabled = False
            Me.TextBoxApr11.Enabled = False
            Me.TextBoxApr12.Enabled = False
            Me.TextBox590.Enabled = False
            Me.DateTimePicker10.Enabled = False

        End If
    End Sub

    Private Sub RadioButtonMay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMay.CheckedChanged
        If RadioButtonMay.Checked = True Then
            Me.TextBoxMay1.Enabled = True
            Me.TextBoxMay2.Enabled = True
            Me.TextBoxMay3.Enabled = True
            Me.TextBoxMay4.Enabled = True
            Me.TextBoxMay5.Enabled = True
            Me.TextBoxMay6.Enabled = True
            Me.TextBoxMay7.Enabled = True
            Me.TextBoxMay8.Enabled = True
            Me.TextBoxMay9.Enabled = True
            Me.TextBoxMay10.Enabled = True
            Me.TextBoxMay11.Enabled = True
            Me.TextBoxMay12.Enabled = True
            Me.TextBox589.Enabled = True
            Me.DateTimePicker9.Enabled = True


        ElseIf RadioButtonMay.Checked = False Then
            Me.TextBoxMay1.Enabled = False
            Me.TextBoxMay2.Enabled = False
            Me.TextBoxMay3.Enabled = False
            Me.TextBoxMay4.Enabled = False
            Me.TextBoxMay5.Enabled = False
            Me.TextBoxMay6.Enabled = False
            Me.TextBoxMay7.Enabled = False
            Me.TextBoxMay8.Enabled = False
            Me.TextBoxMay9.Enabled = False
            Me.TextBoxMay10.Enabled = False
            Me.TextBoxMay11.Enabled = False
            Me.TextBoxMay12.Enabled = False
            Me.TextBox589.Enabled = False
            Me.DateTimePicker9.Enabled = False

        End If

    End Sub

    Private Sub RadioButtonJun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonJun.CheckedChanged
        If RadioButtonJun.Checked = True Then
            Me.TextBoxJun1.Enabled = True
            Me.TextBoxJun2.Enabled = True
            Me.TextBoxJun3.Enabled = True
            Me.TextBoxJun4.Enabled = True
            Me.TextBoxJun5.Enabled = True
            Me.TextBoxJun6.Enabled = True
            Me.TextBoxJun7.Enabled = True
            Me.TextBoxJun8.Enabled = True
            Me.TextBoxJun9.Enabled = True
            Me.TextBoxJun10.Enabled = True
            Me.TextBoxJun11.Enabled = True
            Me.TextBoxJun12.Enabled = True
            Me.TextBox588.Enabled = True
            Me.DateTimePicker8.Enabled = True


        ElseIf RadioButtonJun.Checked = False Then
            Me.TextBoxJun1.Enabled = False
            Me.TextBoxJun2.Enabled = False
            Me.TextBoxJun3.Enabled = False
            Me.TextBoxJun4.Enabled = False
            Me.TextBoxJun5.Enabled = False
            Me.TextBoxJun6.Enabled = False
            Me.TextBoxJun7.Enabled = False
            Me.TextBoxJun8.Enabled = False
            Me.TextBoxJun9.Enabled = False
            Me.TextBoxJun10.Enabled = False
            Me.TextBoxJun11.Enabled = False
            Me.TextBoxJun12.Enabled = False
            Me.TextBox588.Enabled = False
            Me.DateTimePicker8.Enabled = False

        End If
    End Sub

    Private Sub RadioButtonJul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonJul.CheckedChanged
        If RadioButtonJul.Checked = True Then
            Me.TextBoxJul1.Enabled = True
            Me.TextBoxJul2.Enabled = True
            Me.TextBoxJul4.Enabled = True
            Me.TextBoxJul3.Enabled = True
            Me.TextBoxJul5.Enabled = True
            Me.TextBoxJul6.Enabled = True
            Me.TextBoxJul7.Enabled = True
            Me.TextBoxJul8.Enabled = True
            Me.TextBoxJul9.Enabled = True
            Me.TextBoxJul10.Enabled = True
            Me.TextBoxJul11.Enabled = True
            Me.TextBoxJul12.Enabled = True
            Me.TextBox587.Enabled = True
            Me.DateTimePicker7.Enabled = True

        ElseIf RadioButtonJul.Checked = False Then
            Me.TextBoxJul1.Enabled = False
            Me.TextBoxJul2.Enabled = False
            Me.TextBoxJul3.Enabled = False
            Me.TextBoxJul4.Enabled = False
            Me.TextBoxJul5.Enabled = False
            Me.TextBoxJul6.Enabled = False
            Me.TextBoxJul7.Enabled = False
            Me.TextBoxJul8.Enabled = False
            Me.TextBoxJul9.Enabled = False
            Me.TextBoxJul10.Enabled = False
            Me.TextBoxJul11.Enabled = False
            Me.TextBoxJul12.Enabled = False
            Me.TextBox587.Enabled = False
            Me.DateTimePicker7.Enabled = False

        End If
    End Sub
    Private Sub RadioButtonAug_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAug.CheckedChanged
        If RadioButtonAug.Checked = True Then
            Me.TextBoxAug1.Enabled = True
            Me.TextBoxAug2.Enabled = True
            Me.TextBoxAug3.Enabled = True
            Me.TextBoxAug4.Enabled = True
            Me.TextBoxAug5.Enabled = True
            Me.TextBoxAug6.Enabled = True
            Me.TextBoxAug7.Enabled = True
            Me.TextBoxAug8.Enabled = True
            Me.TextBoxAug9.Enabled = True
            Me.TextBoxAug10.Enabled = True
            Me.TextBoxAug11.Enabled = True
            Me.TextBoxAug12.Enabled = True
            Me.TextBox586.Enabled = True
            Me.DateTimePicker6.Enabled = True

        ElseIf RadioButtonAug.Checked = False Then
            Me.TextBoxAug1.Enabled = False
            Me.TextBoxAug2.Enabled = False
            Me.TextBoxAug3.Enabled = False
            Me.TextBoxAug4.Enabled = False
            Me.TextBoxAug5.Enabled = False
            Me.TextBoxAug6.Enabled = False
            Me.TextBoxAug7.Enabled = False
            Me.TextBoxAug8.Enabled = False
            Me.TextBoxAug9.Enabled = False
            Me.TextBoxAug10.Enabled = False
            Me.TextBoxAug11.Enabled = False
            Me.TextBoxAug12.Enabled = False
            Me.TextBox586.Enabled = False
            Me.DateTimePicker6.Enabled = False
        End If
    End Sub

    Private Sub RadioButtonSep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonSep.CheckedChanged
        If RadioButtonSep.Checked = True Then
            Me.TextBoxSep1.Enabled = True
            Me.TextBoxSep2.Enabled = True
            Me.TextBoxSep3.Enabled = True
            Me.TextBoxSep4.Enabled = True
            Me.TextBoxSep5.Enabled = True
            Me.TextBoxSep6.Enabled = True
            Me.TextBoxSep7.Enabled = True
            Me.TextBoxSep8.Enabled = True
            Me.TextBoxSep9.Enabled = True
            Me.TextBoxSep10.Enabled = True
            Me.TextBoxSep11.Enabled = True
            Me.TextBoxSep12.Enabled = True
            Me.TextBox585.Enabled = True
            Me.DateTimePicker5.Enabled = True

        ElseIf RadioButtonSep.Checked = False Then
            Me.TextBoxSep1.Enabled = False
            Me.TextBoxSep2.Enabled = False
            Me.TextBoxSep3.Enabled = False
            Me.TextBoxSep4.Enabled = False
            Me.TextBoxSep5.Enabled = False
            Me.TextBoxSep6.Enabled = False
            Me.TextBoxSep7.Enabled = False
            Me.TextBoxSep8.Enabled = False
            Me.TextBoxSep9.Enabled = False
            Me.TextBoxSep10.Enabled = False
            Me.TextBoxSep11.Enabled = False
            Me.TextBoxSep12.Enabled = False
            Me.TextBox585.Enabled = False
            Me.DateTimePicker5.Enabled = False

        End If
    End Sub

    Private Sub RadioButtonOct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonOct.CheckedChanged
        If RadioButtonOct.Checked = True Then
            Me.TextBoxOct1.Enabled = True
            Me.TextBoxOct2.Enabled = True
            Me.TextBoxOct3.Enabled = True
            Me.TextBoxOct4.Enabled = True
            Me.TextBoxOct5.Enabled = True
            Me.TextBoxOct6.Enabled = True
            Me.TextBoxOct7.Enabled = True
            Me.TextBoxOct8.Enabled = True
            Me.TextBoxOct9.Enabled = True
            Me.TextBoxOct10.Enabled = True
            Me.TextBoxOct11.Enabled = True
            Me.TextBoxOct12.Enabled = True
            Me.TextBox584.Enabled = True
            Me.DateTimePicker4.Enabled = True

        ElseIf RadioButtonOct.Checked = False Then
            Me.TextBoxOct1.Enabled = False
            Me.TextBoxOct2.Enabled = False
            Me.TextBoxOct3.Enabled = False
            Me.TextBoxOct4.Enabled = False
            Me.TextBoxOct5.Enabled = False
            Me.TextBoxOct6.Enabled = False
            Me.TextBoxOct7.Enabled = False
            Me.TextBoxOct8.Enabled = False
            Me.TextBoxOct9.Enabled = False
            Me.TextBoxOct10.Enabled = False
            Me.TextBoxOct11.Enabled = False
            Me.TextBoxOct12.Enabled = False
            Me.TextBox584.Enabled = False
            Me.DateTimePicker4.Enabled = False

        End If
    End Sub

    Private Sub RadioButtonNov_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNov.CheckedChanged
        If RadioButtonNov.Checked = True Then
            Me.TextBoxNov1.Enabled = True
            Me.TextBoxNov2.Enabled = True
            Me.TextBoxNov3.Enabled = True
            Me.TextBoxNov4.Enabled = True
            Me.TextBoxNov5.Enabled = True
            Me.TextBoxNov6.Enabled = True
            Me.TextBoxNov7.Enabled = True
            Me.TextBoxNov8.Enabled = True
            Me.TextBoxNov9.Enabled = True
            Me.TextBoxNov10.Enabled = True
            Me.TextBoxNov11.Enabled = True
            Me.TextBoxNov12.Enabled = True
            Me.TextBox583.Enabled = True
            Me.DateTimePicker3.Enabled = True

        ElseIf RadioButtonNov.Checked = False Then
            Me.TextBoxNov1.Enabled = False
            Me.TextBoxNov2.Enabled = False
            Me.TextBoxNov3.Enabled = False
            Me.TextBoxNov4.Enabled = False
            Me.TextBoxNov5.Enabled = False
            Me.TextBoxNov6.Enabled = False
            Me.TextBoxNov7.Enabled = False
            Me.TextBoxNov8.Enabled = False
            Me.TextBoxNov9.Enabled = False
            Me.TextBoxNov10.Enabled = False
            Me.TextBoxNov11.Enabled = False
            Me.TextBoxNov12.Enabled = False
            Me.TextBox583.Enabled = False
            Me.DateTimePicker3.Enabled = False

        End If
    End Sub

    Private Sub RadioButtonDec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDec.CheckedChanged
        If RadioButtonDec.Checked = True Then
            Me.TextBoxDec1.Enabled = True
            Me.TextBoxDec2.Enabled = True
            Me.TextBoxDec3.Enabled = True
            Me.TextBoxDec4.Enabled = True
            Me.TextBoxDec5.Enabled = True
            Me.TextBoxDec6.Enabled = True
            Me.TextBoxDec7.Enabled = True
            Me.TextBoxDec8.Enabled = True
            Me.TextBoxDec9.Enabled = True
            Me.TextBoxDec10.Enabled = True
            Me.TextBoxDec11.Enabled = True
            Me.TextBoxDec12.Enabled = True
            Me.TextBox582.Enabled = True
            Me.DateTimePicker2.Enabled = True

        ElseIf RadioButtonDec.Checked = False Then
            Me.TextBoxDec1.Enabled = False
            Me.TextBoxDec2.Enabled = False
            Me.TextBoxDec3.Enabled = False
            Me.TextBoxDec4.Enabled = False
            Me.TextBoxDec5.Enabled = False
            Me.TextBoxDec6.Enabled = False
            Me.TextBoxDec7.Enabled = False
            Me.TextBoxDec8.Enabled = False
            Me.TextBoxDec9.Enabled = False
            Me.TextBoxDec10.Enabled = False
            Me.TextBoxDec11.Enabled = False
            Me.TextBoxDec12.Enabled = False
            Me.TextBox582.Enabled = False
            Me.DateTimePicker2.Enabled = False

        End If
    End Sub

    Private Sub Five_JAN()
        Me.TextBoxEigJanTotal.Text = Val(TextBoxEigJan1.Text) + Val(TextBoxEigJan2.Text) + Val(TextBoxEigJan3.Text) + Val(TextBoxEigJan4.Text) + Val(TextBoxEigJan5.Text) + Val(TextBoxEigJan6.Text) + Val(TextBoxEigJan7.Text) + Val(TextBoxEigJan8.Text) + Val(TextBoxEigJan9.Text) + Val(TextBoxEigJan10.Text) + Val(TextBoxEigJan11.Text) + Val(TextBoxEigJan12.Text)
      
    End Sub

    Private Sub Five_Feb()
        Me.TextBoxEigFebTotal.Text = Val(TextBoxEigFeb1.Text) + Val(TextBoxEigFeb2.Text) + Val(TextBoxEigFeb3.Text) + Val(TextBoxEigFeb4.Text) + Val(TextBoxEigFeb5.Text) + Val(TextBoxEigFeb6.Text) + Val(TextBoxEigFeb7.Text) + Val(TextBoxEigFeb8.Text) + Val(TextBoxEigFeb9.Text) + Val(TextBoxEigFeb10.Text) + Val(TextBoxEigFeb11.Text) + Val(TextBoxEigFeb12.Text)

    End Sub


    Private Sub Five_Mar()
        Me.TextBoxMarTotal.Text = Val(TextBoxMar1.Text) + Val(TextBoxMar2.Text) + Val(TextBoxMar3.Text) + Val(TextBoxMar4.Text) + Val(TextBoxMar5.Text) + Val(TextBoxMar6.Text) + Val(TextBoxMar7.Text) + Val(TextBoxMar8.Text) + Val(TextBoxMar9.Text) + Val(TextBoxMar10.Text) + Val(TextBoxMar11.Text) + Val(TextBoxMar12.Text)

    End Sub

    Private Sub Five_April()
        Me.TextBoxAprTotal.Text = Val(TextBoxApr1.Text) + Val(TextBoxApr2.Text) + Val(TextBoxApr3.Text) + Val(TextBoxApr4.Text) + Val(TextBoxApr5.Text) + Val(TextBoxApr6.Text) + Val(TextBoxApr7.Text) + Val(TextBoxApr8.Text) + Val(TextBoxApr9.Text) + Val(TextBoxApr10.Text) + Val(TextBoxApr11.Text) + Val(TextBoxApr12.Text)

    End Sub

    Private Sub Five_May()
        Me.TextBoxMayTotal.Text = Val(TextBoxMay1.Text) + Val(TextBoxMay2.Text) + Val(TextBoxMay3.Text) + Val(TextBoxMay4.Text) + Val(TextBoxMay5.Text) + Val(TextBoxMay6.Text) + Val(TextBoxMay7.Text) + Val(TextBoxMay8.Text) + Val(TextBoxMay9.Text) + Val(TextBoxMay10.Text) + Val(TextBoxMay11.Text) + Val(TextBoxMay12.Text)


    End Sub

    Private Sub Five_Jun()
        Me.TextBoxJunTotal.Text = Val(TextBoxJun1.Text) + Val(TextBoxJun2.Text) + Val(TextBoxJun3.Text) + Val(TextBoxJun4.Text) + Val(TextBoxJun5.Text) + Val(TextBoxJun6.Text) + Val(TextBoxJun7.Text) + Val(TextBoxJun8.Text) + Val(TextBoxJun9.Text) + Val(TextBoxJun10.Text) + Val(TextBoxJun11.Text) + Val(TextBoxJun12.Text)

    End Sub

    Private Sub Five_July()
        Me.TextBoxJulTotal.Text = Val(TextBoxJul1.Text) + Val(TextBoxJul2.Text) + Val(TextBoxJul3.Text) + Val(TextBoxJul4.Text) + Val(TextBoxJul5.Text) + Val(TextBoxJul6.Text) + Val(TextBoxJul7.Text) + Val(TextBoxJul8.Text) + Val(TextBoxJul9.Text) + Val(TextBoxJul10.Text) + Val(TextBoxJul11.Text) + Val(TextBoxJul12.Text)


    End Sub

    Private Sub Five_Aug()
        Me.TextBoxAugTotal.Text = Val(TextBoxAug1.Text) + Val(TextBoxAug2.Text) + Val(TextBoxAug3.Text) + Val(TextBoxAug4.Text) + Val(TextBoxAug5.Text) + Val(TextBoxAug6.Text) + Val(TextBoxAug7.Text) + Val(TextBoxAug8.Text) + Val(TextBoxAug9.Text) + Val(TextBoxAug10.Text) + Val(TextBoxAug11.Text) + Val(TextBoxAug12.Text)


    End Sub

    Private Sub Five_Septimbar()
        Me.TextBoxSepTotal.Text = Val(TextBoxSep1.Text) + Val(TextBoxSep2.Text) + Val(TextBoxSep3.Text) + Val(TextBoxSep4.Text) + Val(TextBoxSep5.Text) + Val(TextBoxSep6.Text) + Val(TextBoxSep7.Text) + Val(TextBoxSep8.Text) + Val(TextBoxSep9.Text) + Val(TextBoxSep10.Text) + Val(TextBoxSep11.Text) + Val(TextBoxSep12.Text)


    End Sub

    Private Sub Five_October()
        Me.TextBoxOctTotal.Text = Val(TextBoxOct1.Text) + Val(TextBoxOct2.Text) + Val(TextBoxOct3.Text) + Val(TextBoxOct4.Text) + Val(TextBoxOct5.Text) + Val(TextBoxOct6.Text) + Val(TextBoxOct7.Text) + Val(TextBoxOct8.Text) + Val(TextBoxOct9.Text) + Val(TextBoxOct10.Text) + Val(TextBoxOct11.Text) + Val(TextBoxOct12.Text)


    End Sub

    Private Sub Five_November()
        Me.TextBoxNovTotal.Text = Val(TextBoxNov1.Text) + Val(TextBoxNov2.Text) + Val(TextBoxNov3.Text) + Val(TextBoxNov4.Text) + Val(TextBoxNov5.Text) + Val(TextBoxNov6.Text) + Val(TextBoxNov7.Text) + Val(TextBoxNov8.Text) + Val(TextBoxNov9.Text) + Val(TextBoxNov10.Text) + Val(TextBoxNov11.Text) + Val(TextBoxNov12.Text)


    End Sub

    Private Sub Five_Decembar()
        Me.TextBoxDecTotal.Text = Val(TextBoxDec1.Text) + Val(TextBoxDec2.Text) + Val(TextBoxDec3.Text) + Val(TextBoxDec4.Text) + Val(TextBoxDec5.Text) + Val(TextBoxDec6.Text) + Val(TextBoxDec7.Text) + Val(TextBoxDec8.Text) + Val(TextBoxDec9.Text) + Val(TextBoxDec10.Text) + Val(TextBoxDec11.Text) + Val(TextBoxDec12.Text)


    End Sub


    Private Sub Five_AccoundTotal()

        Me.TextBoxTotal1.Text = Val(TextBoxEigJan1.Text) + Val(TextBoxEigFeb1.Text) + Val(TextBoxMar1.Text) + Val(TextBoxApr1.Text) + Val(TextBoxMay1.Text) + Val(TextBoxJun1.Text) + Val(TextBoxJul1.Text) + Val(TextBoxAug1.Text) + Val(TextBoxSep1.Text) + Val(TextBoxOct1.Text) + Val(TextBoxNov1.Text) + Val(TextBoxDec1.Text)
        Me.TextBoxTotal2.Text = Val(TextBoxEigJan2.Text) + Val(TextBoxEigFeb2.Text) + Val(TextBoxMar2.Text) + Val(TextBoxApr2.Text) + Val(TextBoxMay2.Text) + Val(TextBoxJun2.Text) + Val(TextBoxJul2.Text) + Val(TextBoxAug2.Text) + Val(TextBoxSep2.Text) + Val(TextBoxOct2.Text) + Val(TextBoxNov2.Text) + Val(TextBoxDec2.Text)
        Me.TextBoxTotal3.Text = Val(TextBoxEigJan3.Text) + Val(TextBoxEigFeb3.Text) + Val(TextBoxMar3.Text) + Val(TextBoxApr3.Text) + Val(TextBoxMay3.Text) + Val(TextBoxJun3.Text) + Val(TextBoxJul3.Text) + Val(TextBoxAug3.Text) + Val(TextBoxSep3.Text) + Val(TextBoxOct3.Text) + Val(TextBoxNov3.Text) + Val(TextBoxDec3.Text)
        Me.TextBoxTotal4.Text = Val(TextBoxEigJan4.Text) + Val(TextBoxEigFeb4.Text) + Val(TextBoxMar4.Text) + Val(TextBoxApr4.Text) + Val(TextBoxMay4.Text) + Val(TextBoxJun4.Text) + Val(TextBoxJul4.Text) + Val(TextBoxAug4.Text) + Val(TextBoxSep4.Text) + Val(TextBoxOct4.Text) + Val(TextBoxNov4.Text) + Val(TextBoxDec4.Text)
        Me.TextBoxTotal5.Text = Val(TextBoxEigJan5.Text) + Val(TextBoxEigFeb5.Text) + Val(TextBoxMar5.Text) + Val(TextBoxApr5.Text) + Val(TextBoxMay5.Text) + Val(TextBoxJun5.Text) + Val(TextBoxJul5.Text) + Val(TextBoxAug5.Text) + Val(TextBoxSep5.Text) + Val(TextBoxOct5.Text) + Val(TextBoxNov5.Text) + Val(TextBoxDec5.Text)
        Me.TextBoxTotal6.Text = Val(TextBoxEigJan6.Text) + Val(TextBoxEigFeb6.Text) + Val(TextBoxMar6.Text) + Val(TextBoxApr6.Text) + Val(TextBoxMay6.Text) + Val(TextBoxJun6.Text) + Val(TextBoxJul6.Text) + Val(TextBoxAug6.Text) + Val(TextBoxSep6.Text) + Val(TextBoxOct6.Text) + Val(TextBoxNov6.Text) + Val(TextBoxDec6.Text)
        Me.TextBoxTotal7.Text = Val(TextBoxEigJan7.Text) + Val(TextBoxEigFeb7.Text) + Val(TextBoxMar7.Text) + Val(TextBoxApr7.Text) + Val(TextBoxMay7.Text) + Val(TextBoxJun7.Text) + Val(TextBoxJul7.Text) + Val(TextBoxAug7.Text) + Val(TextBoxSep7.Text) + Val(TextBoxOct7.Text) + Val(TextBoxNov7.Text) + Val(TextBoxDec7.Text)
        Me.TextBoxTotal8.Text = Val(TextBoxEigJan8.Text) + Val(TextBoxEigFeb8.Text) + Val(TextBoxMar8.Text) + Val(TextBoxApr8.Text) + Val(TextBoxMay8.Text) + Val(TextBoxJun8.Text) + Val(TextBoxJul8.Text) + Val(TextBoxAug8.Text) + Val(TextBoxSep8.Text) + Val(TextBoxOct8.Text) + Val(TextBoxNov8.Text) + Val(TextBoxDec8.Text)
        Me.TextBoxTotal9.Text = Val(TextBoxEigJan9.Text) + Val(TextBoxEigFeb9.Text) + Val(TextBoxMar9.Text) + Val(TextBoxApr9.Text) + Val(TextBoxMay9.Text) + Val(TextBoxJun9.Text) + Val(TextBoxJul9.Text) + Val(TextBoxAug9.Text) + Val(TextBoxSep9.Text) + Val(TextBoxOct9.Text) + Val(TextBoxNov9.Text) + Val(TextBoxDec9.Text)
        Me.TextBoxTotal10.Text = Val(TextBoxEigJan10.Text) + Val(TextBoxEigFeb10.Text) + Val(TextBoxMar10.Text) + Val(TextBoxApr10.Text) + Val(TextBoxMay10.Text) + Val(TextBoxJun10.Text) + Val(TextBoxJul10.Text) + Val(TextBoxAug10.Text) + Val(TextBoxSep10.Text) + Val(TextBoxOct10.Text) + Val(TextBoxNov10.Text) + Val(TextBoxDec10.Text)
        Me.TextBoxTotal11.Text = Val(TextBoxEigJan11.Text) + Val(TextBoxEigFeb11.Text) + Val(TextBoxMar11.Text) + Val(TextBoxApr11.Text) + Val(TextBoxMay11.Text) + Val(TextBoxJun11.Text) + Val(TextBoxJul11.Text) + Val(TextBoxAug11.Text) + Val(TextBoxSep11.Text) + Val(TextBoxOct11.Text) + Val(TextBoxNov11.Text) + Val(TextBoxDec11.Text)
        Me.TextBoxTotal12.Text = Val(TextBoxEigJan12.Text) + Val(TextBoxEigFeb12.Text) + Val(TextBoxMar12.Text) + Val(TextBoxApr12.Text) + Val(TextBoxMay12.Text) + Val(TextBoxJun12.Text) + Val(TextBoxJul12.Text) + Val(TextBoxAug12.Text) + Val(TextBoxSep12.Text) + Val(TextBoxOct12.Text) + Val(TextBoxNov12.Text) + Val(TextBoxDec12.Text)
       
        'Total
        Me.TextBoxTotalTotal.Text = Val(TextBoxTotal1.Text) + Val(TextBoxTotal2.Text) + Val(TextBoxTotal3.Text) + Val(TextBoxTotal4.Text) + Val(TextBoxTotal5.Text) + Val(TextBoxTotal6.Text) + Val(TextBoxTotal7.Text) + Val(TextBoxTotal8.Text) + Val(TextBoxTotal9.Text) + Val(TextBoxTotal10.Text) + Val(TextBoxTotal11.Text) + Val(TextBoxTotal12.Text)

        '
        If TextBoxTotal1.Text = "0" Then
            Me.TextBoxTotal1.Clear()
        End If

        If TextBoxTotal2.Text = "0" Then
            Me.TextBoxTotal2.Clear()
        End If

        If TextBoxTotal3.Text = "0" Then
            Me.TextBoxTotal3.Clear()
        End If

        If TextBoxTotal4.Text = "0" Then
            Me.TextBoxTotal4.Clear()
        End If

        If TextBoxTotal5.Text = "0" Then
            Me.TextBoxTotal5.Clear()
        End If

        If TextBoxTotal6.Text = "0" Then
            Me.TextBoxTotal6.Clear()
        End If

        If TextBoxTotal7.Text = "0" Then
            Me.TextBoxTotal7.Clear()
        End If

        If TextBoxTotal8.Text = "0" Then
            TextBoxTotal8.Clear()
        End If

        If TextBoxTotal9.Text = "0" Then
            Me.TextBoxTotal9.Clear()
        End If

        If TextBoxTotal10.Text = "0" Then
            Me.TextBoxTotal10.Clear()
        End If

        If TextBoxTotal11.Text = "0" Then
            Me.TextBoxTotal11.Clear()
        End If

        If TextBoxTotal12.Text = "0" Then
            Me.TextBoxTotal12.Clear()
        End If


        If TextBoxTotalTotal.Text = "0" Then
            Me.TextBoxTotalTotal.Clear()
        End If

        If TextBoxEigJanTotal.Text = "0" Then
            Me.TextBoxEigJanTotal.Clear()
        End If

        If TextBoxEigFebTotal.Text = "0" Then
            Me.TextBoxEigFebTotal.Clear()
        End If

        If TextBoxMarTotal.Text = "0" Then
            Me.TextBoxMarTotal.Clear()
        End If

        If TextBoxAprTotal.Text = "0" Then
            Me.TextBoxAprTotal.Clear()
        End If

        If TextBoxMayTotal.Text = "0" Then
            Me.TextBoxMayTotal.Clear()
        End If

        If TextBoxJunTotal.Text = "0" Then
            Me.TextBoxJunTotal.Clear()
        End If

        If TextBoxJulTotal.Text = "0" Then
            Me.TextBoxJulTotal.Clear()
        End If

        If TextBoxAugTotal.Text = "0" Then
            Me.TextBoxAugTotal.Clear()
        End If

        If TextBoxSepTotal.Text = "0" Then
            Me.TextBoxSepTotal.Clear()
        End If

        If TextBoxOctTotal.Text = "0" Then
            Me.TextBoxOctTotal.Clear()
        End If

        If TextBoxNovTotal.Text = "0" Then
            Me.TextBoxNovTotal.Clear()
        End If

        If TextBoxDecTotal.Text = "0" Then
            Me.TextBoxDecTotal.Clear()
        End If
    End Sub

    Private Sub TextBoxJan1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan1.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan2.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan3.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan4.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan5.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan6.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan7.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan8.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan9.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan10.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan11.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigJan12.TextChanged
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJan14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_JAN()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb1.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb2.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb3.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb4.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb5.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb6.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb7.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb8.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb9.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb10.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb11.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEigFeb12.TextChanged
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxFeb14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Feb()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar1.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar2.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar3.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar4.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar5.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar6.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar7.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar8.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar9.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar10.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar11.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMar12.TextChanged
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMar14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Mar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr1.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr2.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr3.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr4.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr5.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr6.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr7.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr8.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr9.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr10.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr11.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxApr12.TextChanged
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxApr14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_April()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay1.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay2.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay3.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay4.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay5.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay6.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay7.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay8.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay9.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay10.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay11.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxMay12.TextChanged
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxMay14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_May()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun1.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun2.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun3.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun4.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun5.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun6.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun7.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun8.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun9.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun10.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun11.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJun12.TextChanged
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJun14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Jun()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul1.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul2.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul3.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul4.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul5.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul6.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul7.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul8.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul9.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul10.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul11.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxJul12.TextChanged
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxJul14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_July()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug1.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug2.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug3.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug4.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug5.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug6.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug7.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug8.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug9.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug10.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug11.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAug12.TextChanged
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxAug14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Aug()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep1.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep2.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep3.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep4.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep5.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep6.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep7.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep8.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep9.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep10.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep11.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSep12.TextChanged
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxSep14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Septimbar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct1.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct2.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct3.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct4.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct5.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct6.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct7.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct8.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct9.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct10.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct11.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOct12.TextChanged
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxOct14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_October()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov1.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov2.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov3.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov4.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov5.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov6.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov7.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov8.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov9.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov10.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov11.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNov12.TextChanged
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxNov14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_November()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec1.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec2.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec3.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec4.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec5.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec6.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec7.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec8.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec9.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec10.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec11.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDec12.TextChanged
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

    Private Sub TextBoxDec14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Five_Decembar()
        Me.Five_AccoundTotal()
    End Sub

  
    Private Sub ToolStripButton_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton_Back.Click
        FormAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub DateTimePicker24_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker24.ValueChanged
        Me.TextBox558.Text = DateTimePicker24.Text
    End Sub

    'Private Sub DateTimePicker37_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.TextBoxDateofBirth.Text = DateTimePicker37.Text
    'End Sub

    Private Sub DateTimePicker23_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker23.ValueChanged
        Me.TextBox559.Text = DateTimePicker23.Text
    End Sub

    Private Sub DateTimePicker22_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker22.ValueChanged
        Me.TextBox560.Text = DateTimePicker22.Text
    End Sub

    Private Sub DateTimePicker21_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker21.ValueChanged
        Me.TextBox561.Text = DateTimePicker21.Text
    End Sub

    Private Sub DateTimePicker20_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker20.ValueChanged
        Me.TextBox562.Text = DateTimePicker20.Text
    End Sub

    Private Sub DateTimePicker19_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker19.ValueChanged
        Me.TextBox563.Text = DateTimePicker19.Text
    End Sub

    Private Sub DateTimePicker18_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker18.ValueChanged
        Me.TextBox564.Text = DateTimePicker18.Text
    End Sub

    Private Sub DateTimePicker17_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker17.ValueChanged
        Me.TextBox565.Text = DateTimePicker17.Text
    End Sub

    Private Sub DateTimePicker16_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker16.ValueChanged
        Me.TextBox566.Text = DateTimePicker16.Text
    End Sub

    Private Sub DateTimePicker15_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker15.ValueChanged
        Me.TextBox567.Text = DateTimePicker15.Text
    End Sub

    Private Sub DateTimePicker14_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker14.ValueChanged
        Me.TextBox568.Text = DateTimePicker14.Text
    End Sub

    Private Sub DateTimePicker13_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker13.ValueChanged
        Me.TextBox569.Text = DateTimePicker13.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Me.TextBox593.Text = DateTimePicker1.Text
    End Sub

    Private Sub DateTimePicker12_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker12.ValueChanged
        Me.TextBox592.Text = DateTimePicker12.Text
    End Sub

    Private Sub DateTimePicker11_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker11.ValueChanged
        Me.TextBox591.Text = DateTimePicker11.Text
    End Sub

    Private Sub DateTimePicker10_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker10.ValueChanged
        Me.TextBox590.Text = DateTimePicker10.Text
    End Sub

    Private Sub DateTimePicker9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker9.ValueChanged
        Me.TextBox589.Text = DateTimePicker9.Text
    End Sub

    Private Sub DateTimePicker8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker8.ValueChanged
        Me.TextBox588.Text = DateTimePicker8.Text
    End Sub

    Private Sub DateTimePicker7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker7.ValueChanged
        Me.TextBox587.Text = DateTimePicker7.Text
    End Sub

    Private Sub DateTimePicker6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker6.ValueChanged
        Me.TextBox586.Text = DateTimePicker6.Text
    End Sub

    Private Sub DateTimePicker5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker5.ValueChanged
        Me.TextBox585.Text = DateTimePicker5.Text
    End Sub

    Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker4.ValueChanged
        Me.TextBox584.Text = DateTimePicker4.Text
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        Me.TextBox583.Text = DateTimePicker3.Text
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Me.TextBox582.Text = DateTimePicker2.Text
    End Sub

    Private Sub Form_PSC_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.shutdown()
    End Sub

    
    '----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    
    'Class Four 2St

    'Marks Information
    Private Sub Four_2st_MarkInformation()

        'Total Mark
        Me.TextBox125.Text = Val(TextBox121.Text) + Val(TextBox120.Text) + Val(TextBox134.Text) + Val(TextBox136.Text) + Val(TextBox137.Text) + Val(TextBox138.Text)

        'Average
        Me.TextBox124.Text = Format(((Val(TextBox121.Text) + Val(TextBox120.Text) + Val(TextBox134.Text) + Val(TextBox136.Text) + Val(TextBox137.Text) + Val(TextBox138.Text)) / 6), "0.00")

        'GPA
        Me.TextBox123.Text = Format(((Val(TextBox133.Text) + Val(TextBox132.Text) + Val(TextBox555.Text) + Val(TextBox154.Text) + Val(TextBox152.Text) + Val(TextBox150.Text)) / 6), "0.00")
        Me.TextBox122.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox121.Text) Then
            If Val(TextBox121.Text) >= 0 And Val(TextBox121.Text) <= 32 Then
                Me.TextBox135.Text = "F"
                Me.TextBox133.Text = "0.00"
                Me.TextBox125.Clear()
                Me.TextBox124.Clear()
                Me.TextBox126.Clear()
                Me.TextBox123.Clear()
                Me.TextBox122.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox120.Text) Then
            If Val(TextBox120.Text) >= 0 And Val(TextBox120.Text) <= 32 Then
                Me.TextBox131.Text = "F"
                Me.TextBox132.Text = "0.00"
                Me.TextBox125.Clear()
                Me.TextBox124.Clear()
                Me.TextBox126.Clear()
                Me.TextBox123.Clear()
                Me.TextBox122.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox134.Text) Then
            If Val(TextBox134.Text) >= 0 And Val(TextBox134.Text) <= 32 Then
                Me.TextBox142.Text = "F"
                Me.TextBox555.Text = "0.00"
                Me.TextBox125.Clear()
                Me.TextBox124.Clear()
                Me.TextBox126.Clear()
                Me.TextBox123.Clear()
                Me.TextBox122.Text = "Fail"
            End If
        End If

        'Bangladesh And Global Studies
        If IsNumeric(TextBox136.Text) Then
            If Val(TextBox136.Text) >= 0 And Val(TextBox136.Text) <= 32 Then
                Me.TextBox143.Text = "F"
                Me.TextBox154.Text = "0.00"
                Me.TextBox125.Clear()
                Me.TextBox124.Clear()
                Me.TextBox126.Clear()
                Me.TextBox123.Clear()
                Me.TextBox122.Text = "Fail"
            End If
        End If

        'Science
        If IsNumeric(TextBox137.Text) Then
            If Val(TextBox137.Text) >= 0 And Val(TextBox137.Text) <= 32 Then
                Me.TextBox145.Text = "F"
                Me.TextBox152.Text = "0.00"
                Me.TextBox125.Clear()
                Me.TextBox124.Clear()
                Me.TextBox126.Clear()
                Me.TextBox123.Clear()
                Me.TextBox122.Text = "Fail"
            End If
        End If


        'Islam Religion
        If IsNumeric(TextBox138.Text) Then
            If Val(TextBox138.Text) >= 0 And Val(TextBox138.Text) <= 32 Then
                Me.TextBox147.Text = "F"
                Me.TextBox150.Text = "0.00"
                Me.TextBox125.Clear()
                Me.TextBox124.Clear()
                Me.TextBox126.Clear()
                Me.TextBox123.Clear()
                Me.TextBox122.Text = "Fail"
            End If
        End If


        'Timar

        'Bangla
        If Me.TextBox121.Text = "" Then
            Me.TextBox125.Clear()
            Me.TextBox124.Clear()
            Me.TextBox126.Clear()
            Me.TextBox123.Clear()
            Me.TextBox122.Text = "Fail"
        End If

        'English
        If Me.TextBox120.Text = "" Then
            Me.TextBox125.Clear()
            Me.TextBox124.Clear()
            Me.TextBox126.Clear()
            Me.TextBox123.Clear()
            Me.TextBox122.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox134.Text = "" Then
            Me.TextBox125.Clear()
            Me.TextBox124.Clear()
            Me.TextBox126.Clear()
            Me.TextBox123.Clear()
            Me.TextBox122.Text = "Fail"
        End If

        'Bangladesh and Global Studies
        If Me.TextBox136.Text = "" Then
            Me.TextBox125.Clear()
            Me.TextBox124.Clear()
            Me.TextBox126.Clear()
            Me.TextBox123.Clear()
            Me.TextBox122.Text = "Fail"
        End If

        'Science
        If Me.TextBox137.Text = "" Then
            Me.TextBox125.Clear()
            Me.TextBox124.Clear()
            Me.TextBox126.Clear()
            Me.TextBox123.Clear()
            Me.TextBox122.Text = "Fail"
        End If

        'Islam and moral Education
        If Me.TextBox138.Text = "" Then
            Me.TextBox125.Clear()
            Me.TextBox124.Clear()
            Me.TextBox126.Clear()
            Me.TextBox123.Clear()
            Me.TextBox122.Text = "Fail"
        End If
    End Sub

    'Check Box
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Me.TextBox556.Enabled = True
            Me.TextBox557.Enabled = True
        ElseIf CheckBox4.Checked = False Then
            Me.TextBox556.Enabled = False
            Me.TextBox557.Enabled = False

            Me.TextBox556.Clear()
            Me.TextBox557.Clear()
        End If
    End Sub

    'Bangla
    Private Sub TextBox121_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox121.TextChanged
        If Me.TextBox121.Text = "" Then
            Me.PictureBox19.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox121.Text) >= 0 And Val(TextBox121.Text) <= 100 Then
            Me.PictureBox19.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox121.Text) >= 101 And Val(TextBox121.Text) <= 100000 Then
            Me.PictureBox19.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox121.Text = ""
        Else
            Me.PictureBox19.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox121.Text = "" Then
            Me.TextBox135.Text = "F"
            Me.TextBox133.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox121.Text) Then
            If Val(TextBox121.Text) >= 80 And Val(TextBox121.Text) <= 100 Then
                Me.TextBox135.Text = "A+"
                Me.TextBox133.Text = "5.00"
            ElseIf Val(TextBox121.Text) >= 70 And Val(TextBox121.Text) <= 79 Then
                Me.TextBox135.Text = "A"
                Me.TextBox133.Text = "4.00"
            ElseIf Val(TextBox121.Text) >= 60 And Val(TextBox121.Text) <= 69 Then
                Me.TextBox135.Text = "A-"
                Me.TextBox133.Text = "3.50"
            ElseIf Val(TextBox121.Text) >= 50 And Val(TextBox121.Text) <= 59 Then
                Me.TextBox135.Text = "B"
                Me.TextBox133.Text = "3.00"
            ElseIf Val(TextBox121.Text) >= 40 And Val(TextBox121.Text) <= 49 Then
                Me.TextBox135.Text = "C"
                Me.TextBox133.Text = "2.00"
            ElseIf Val(TextBox121.Text) >= 32 And Val(TextBox121.Text) <= 39 Then
                Me.TextBox135.Text = "D"
                Me.TextBox133.Text = "1.00"
            Else
                Me.TextBox135.Text = "F"
                Me.TextBox133.Text = "0.00"
            End If
        End If
        Me.Four_2st_MarkInformation()
    End Sub

    'English For Today
    Private Sub TextBox120_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox120.TextChanged
        If Me.TextBox120.Text = "" Then
            Me.PictureBox18.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox120.Text) >= 0 And Val(TextBox120.Text) <= 100 Then
            Me.PictureBox18.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox120.Text) >= 101 And Val(TextBox120.Text) <= 100000 Then
            Me.PictureBox18.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox120.Text = ""
        Else
            Me.PictureBox18.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox120.Text = "" Then
            Me.TextBox131.Text = "F"
            Me.TextBox132.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox120.Text) Then
            If Val(TextBox120.Text) >= 80 And Val(TextBox120.Text) <= 100 Then
                Me.TextBox131.Text = "A+"
                Me.TextBox132.Text = "5.00"
            ElseIf Val(TextBox120.Text) >= 70 And Val(TextBox120.Text) <= 79 Then
                Me.TextBox131.Text = "A"
                Me.TextBox132.Text = "4.00"
            ElseIf Val(TextBox120.Text) >= 60 And Val(TextBox120.Text) <= 69 Then
                Me.TextBox131.Text = "A-"
                Me.TextBox132.Text = "3.50"
            ElseIf Val(TextBox120.Text) >= 50 And Val(TextBox120.Text) <= 59 Then
                Me.TextBox131.Text = "B"
                Me.TextBox132.Text = "3.00"
            ElseIf Val(TextBox120.Text) >= 40 And Val(TextBox120.Text) <= 49 Then
                Me.TextBox131.Text = "C"
                Me.TextBox132.Text = "2.00"
            ElseIf Val(TextBox120.Text) >= 32 And Val(TextBox120.Text) <= 39 Then
                Me.TextBox131.Text = "D"
                Me.TextBox132.Text = "1.00"
            Else
                Me.TextBox131.Text = "F"
                Me.TextBox132.Text = "0.00"
            End If
        End If
        Me.Four_2st_MarkInformation()
    End Sub

    'Mathematic
    Private Sub TextBox134_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox134.TextChanged
        If Me.TextBox134.Text = "" Then
            Me.PictureBox17.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox134.Text) >= 0 And Val(TextBox134.Text) <= 100 Then
            Me.PictureBox17.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox134.Text) >= 101 And Val(TextBox134.Text) <= 100000 Then
            Me.PictureBox17.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox134.Text = ""
        Else
            Me.PictureBox17.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox134.Text = "" Then
            Me.TextBox142.Text = "F"
            Me.TextBox555.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox134.Text) Then
            If Val(TextBox134.Text) >= 80 And Val(TextBox134.Text) <= 100 Then
                Me.TextBox142.Text = "A+"
                Me.TextBox555.Text = "5.00"
            ElseIf Val(TextBox134.Text) >= 70 And Val(TextBox134.Text) <= 79 Then
                Me.TextBox142.Text = "A"
                Me.TextBox555.Text = "4.00"
            ElseIf Val(TextBox134.Text) >= 60 And Val(TextBox134.Text) <= 69 Then
                Me.TextBox142.Text = "A-"
                Me.TextBox555.Text = "3.50"
            ElseIf Val(TextBox134.Text) >= 50 And Val(TextBox134.Text) <= 59 Then
                Me.TextBox142.Text = "B"
                Me.TextBox555.Text = "3.00"
            ElseIf Val(TextBox134.Text) >= 40 And Val(TextBox134.Text) <= 49 Then
                Me.TextBox142.Text = "C"
                Me.TextBox555.Text = "2.00"
            ElseIf Val(TextBox134.Text) >= 32 And Val(TextBox134.Text) <= 39 Then
                Me.TextBox142.Text = "D"
                Me.TextBox555.Text = "1.00"
            Else
                Me.TextBox142.Text = "F"
                Me.TextBox555.Text = "0.00"
            End If
        End If

        Me.Four_2st_MarkInformation()
    End Sub

    'Bangladesh and Global Studies
    Private Sub TextBox136_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox136.TextChanged
        If Me.TextBox136.Text = "" Then
            Me.PictureBox16.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox136.Text) >= 0 And Val(TextBox136.Text) <= 100 Then
            Me.PictureBox16.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox136.Text) >= 101 And Val(TextBox136.Text) <= 100000 Then
            Me.PictureBox16.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangladesh and Global Studies Creative Marks")
            Me.TextBox136.Text = ""
        Else
            Me.PictureBox16.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox136.Text = "" Then
            Me.TextBox143.Text = "F"
            Me.TextBox154.Text = "0.00"
        End If

        'Bangladesh and Global Studies 100
        If IsNumeric(TextBox136.Text) Then
            If Val(TextBox136.Text) >= 80 And Val(TextBox136.Text) <= 100 Then
                Me.TextBox143.Text = "A+"
                Me.TextBox154.Text = "5.00"
            ElseIf Val(TextBox136.Text) >= 70 And Val(TextBox136.Text) <= 79 Then
                Me.TextBox143.Text = "A"
                Me.TextBox154.Text = "4.00"
            ElseIf Val(TextBox136.Text) >= 60 And Val(TextBox136.Text) <= 69 Then
                Me.TextBox143.Text = "A-"
                Me.TextBox154.Text = "3.50"
            ElseIf Val(TextBox136.Text) >= 50 And Val(TextBox136.Text) <= 59 Then
                Me.TextBox143.Text = "B"
                Me.TextBox154.Text = "3.00"
            ElseIf Val(TextBox136.Text) >= 40 And Val(TextBox136.Text) <= 49 Then
                Me.TextBox143.Text = "C"
                Me.TextBox154.Text = "2.00"
            ElseIf Val(TextBox136.Text) >= 32 And Val(TextBox136.Text) <= 39 Then
                Me.TextBox143.Text = "D"
                Me.TextBox154.Text = "1.00"
            Else
                Me.TextBox143.Text = "F"
                Me.TextBox154.Text = "0.00"
            End If
        End If

        Me.Four_2st_MarkInformation()
    End Sub

    'Science
    Private Sub TextBox137_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox137.TextChanged
        If Me.TextBox137.Text = "" Then
            Me.PictureBox15.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox137.Text) >= 0 And Val(TextBox137.Text) <= 100 Then
            Me.PictureBox15.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox137.Text) >= 101 And Val(TextBox137.Text) <= 100000 Then
            Me.PictureBox15.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Science Creative Marks")
            Me.TextBox137.Text = ""
        Else
            Me.PictureBox15.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox137.Text = "" Then
            Me.TextBox145.Text = "F"
            Me.TextBox152.Text = "0.00"
        End If

        'Science 100
        If IsNumeric(TextBox137.Text) Then
            If Val(TextBox137.Text) >= 80 And Val(TextBox137.Text) <= 100 Then
                Me.TextBox145.Text = "A+"
                Me.TextBox152.Text = "5.00"
            ElseIf Val(TextBox137.Text) >= 70 And Val(TextBox137.Text) <= 79 Then
                Me.TextBox145.Text = "A"
                Me.TextBox152.Text = "4.00"
            ElseIf Val(TextBox137.Text) >= 60 And Val(TextBox137.Text) <= 69 Then
                Me.TextBox145.Text = "A-"
                Me.TextBox152.Text = "3.50"
            ElseIf Val(TextBox137.Text) >= 50 And Val(TextBox137.Text) <= 59 Then
                Me.TextBox145.Text = "B"
                Me.TextBox152.Text = "3.00"
            ElseIf Val(TextBox137.Text) >= 40 And Val(TextBox137.Text) <= 49 Then
                Me.TextBox145.Text = "C"
                Me.TextBox152.Text = "2.00"
            ElseIf Val(TextBox137.Text) >= 32 And Val(TextBox137.Text) <= 39 Then
                Me.TextBox145.Text = "D"
                Me.TextBox152.Text = "1.00"
            Else
                Me.TextBox145.Text = "F"
                Me.TextBox152.Text = "0.00"
            End If
        End If

        Me.Four_2st_MarkInformation()
    End Sub

    'Islam Religion
    Private Sub TextBox138_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox138.TextChanged
        If ComboBox4.Text = "Islam Religion" Then
            If Me.TextBox138.Text = "" Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox138.Text) >= 0 And Val(TextBox138.Text) <= 100 Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox138.Text) >= 101 And Val(TextBox138.Text) <= 100000 Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Islam Religion Creative Marks")
                Me.TextBox138.Text = ""
            Else
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox4.Text = "Hindu Religion" Then
            If Me.TextBox138.Text = "" Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox138.Text) >= 0 And Val(TextBox138.Text) <= 100 Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox138.Text) >= 101 And Val(TextBox138.Text) <= 100000 Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Hindu Religion Creative Marks")
                Me.TextBox138.Text = ""
            Else
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox4.Text = "Christian Religion" Then
            If Me.TextBox138.Text = "" Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox138.Text) >= 0 And Val(TextBox138.Text) <= 100 Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox138.Text) >= 101 And Val(TextBox138.Text) <= 100000 Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Christian Religion Creative Marks")
                Me.TextBox138.Text = ""
            Else
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox4.Text = "Buddhist Religion" Then
            If Me.TextBox138.Text = "" Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox138.Text) >= 0 And Val(TextBox138.Text) <= 100 Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox138.Text) >= 101 And Val(TextBox138.Text) <= 100000 Then
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Buddhist Religion Creative Marks")
                Me.TextBox138.Text = ""
            Else
                Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox138.Text = "" Then
            Me.TextBox147.Text = "F"
            Me.TextBox150.Text = "0.00"
        End If

        'Islam Religion
        If IsNumeric(TextBox138.Text) Then
            If Val(TextBox138.Text) >= 80 And Val(TextBox138.Text) <= 100 Then
                Me.TextBox147.Text = "A+"
                Me.TextBox150.Text = "5.00"
            ElseIf Val(TextBox138.Text) >= 70 And Val(TextBox138.Text) <= 79 Then
                Me.TextBox147.Text = "A"
                Me.TextBox150.Text = "4.00"
            ElseIf Val(TextBox138.Text) >= 60 And Val(TextBox138.Text) <= 69 Then
                Me.TextBox147.Text = "A-"
                Me.TextBox150.Text = "3.50"
            ElseIf Val(TextBox138.Text) >= 50 And Val(TextBox138.Text) <= 59 Then
                Me.TextBox147.Text = "B"
                Me.TextBox150.Text = "3.00"
            ElseIf Val(TextBox138.Text) >= 40 And Val(TextBox138.Text) <= 49 Then
                Me.TextBox147.Text = "C"
                Me.TextBox150.Text = "2.00"
            ElseIf Val(TextBox138.Text) >= 32 And Val(TextBox138.Text) <= 39 Then
                Me.TextBox147.Text = "D"
                Me.TextBox150.Text = "1.00"
            Else
                Me.TextBox147.Text = "F"
                Me.TextBox150.Text = "0.00"
            End If
        End If

        Me.Four_2st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox123_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox123.TextChanged
        If IsNumeric(TextBox123.Text) Then
            If Val(TextBox123.Text) > 4.99 Then
                Me.TextBox126.Text = "A+"
            ElseIf Val(TextBox123.Text) > 3.99 Then
                Me.TextBox126.Text = "A"
            ElseIf Val(TextBox123.Text) > 3.49 Then
                Me.TextBox126.Text = "A-"
            ElseIf Val(TextBox123.Text) > 2.99 Then
                Me.TextBox126.Text = "B"
            ElseIf Val(TextBox123.Text) > 1.99 Then
                Me.TextBox126.Text = "C"
            ElseIf Val(TextBox123.Text) > 0.99 Then
                Me.TextBox126.Text = "D"
            Else
                Me.TextBox126.Text = "F"
            End If
        End If

        If IsNumeric(TextBox123.Text) Then
            If Val(TextBox123.Text) >= 4.99 And Val(TextBox123.Text) <= 100000 Then
                TextBox123.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        'Bangla
        If TextBox121.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox121.Select()

            'English For Today
        ElseIf TextBox120.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox120.Select()

            'Mathematics
        ElseIf TextBox134.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox134.Select()

            'Bangladesh and Global Studies
        ElseIf TextBox136.Text = "" Then
            MessageBox.Show("Input ''Bangladesh and Global Studies Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox136.Select()

            'Science
        ElseIf TextBox137.Text = "" Then
            MessageBox.Show("Input ''Science Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox137.Select()

            'Islam and Moral Education
        ElseIf TextBox138.Text = "" Then
            If ComboBox4.Text = "Islam Religion" Then
                MessageBox.Show("Input ''Islam Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox4.Text = "Hindu Religion" Then
                MessageBox.Show("Input ''Hindu Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox4.Text = "Christian Religion" Then
                MessageBox.Show("Input ''Christian Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox4.Text = "Buddhist Religion" Then
                MessageBox.Show("Input ''Buddhist Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox138.Select()

        Else
            '
            '
            MessageBox.Show("Four Second Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button73.Click
        'Bangla
        Me.TextBox121.Clear()
        Me.TextBox135.Clear()
        Me.TextBox133.Clear()

        'English for Today
        Me.TextBox120.Clear()
        Me.TextBox131.Clear()
        Me.TextBox132.Clear()

        'Mathematics
        Me.TextBox134.Clear()
        Me.TextBox142.Clear()
        Me.TextBox555.Clear()

        'Bangladesh and Global Studies
        Me.TextBox136.Clear()
        Me.TextBox143.Clear()
        Me.TextBox154.Clear()

        'Science
        Me.TextBox137.Clear()
        Me.TextBox145.Clear()
        Me.TextBox152.Clear()

        'Islam amd moral Education
        Me.TextBox138.Clear()
        Me.TextBox147.Clear()
        Me.TextBox150.Clear()

        'Result Information
        Me.TextBox125.Clear()
        Me.TextBox124.Clear()
        Me.TextBox126.Clear()
        Me.TextBox123.Clear()
        Me.TextBox122.Clear()

        'PIC Box
        Me.PictureBox19.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox18.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox17.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox16.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox15.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox14.Image = Global.Student_Data_Managements.My.Resources.NO_Pic

        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Button Back
    Private Sub Button72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button72.Click

    End Sub

    'Button Next
    Private Sub Button71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button71.Click

    End Sub

    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    'Class Four 1st

    'Marks Information
    Private Sub Four_1st_MarkInformation()

        'Total Mark
        Me.TextBox87.Text = Val(TextBox83.Text) + Val(TextBox82.Text) + Val(TextBox96.Text) + Val(TextBox98.Text) + Val(TextBox99.Text) + Val(TextBox100.Text)

        'Average
        Me.TextBox86.Text = Format(((Val(TextBox83.Text) + Val(TextBox82.Text) + Val(TextBox96.Text) + Val(TextBox98.Text) + Val(TextBox99.Text) + Val(TextBox100.Text)) / 6), "0.00")

        'GPA
        Me.TextBox85.Text = Format(((Val(TextBox95.Text) + Val(TextBox94.Text) + Val(TextBox552.Text) + Val(TextBox116.Text) + Val(TextBox114.Text) + Val(TextBox112.Text)) / 6), "0.00")
        Me.TextBox84.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox83.Text) Then
            If Val(TextBox83.Text) >= 0 And Val(TextBox83.Text) <= 32 Then
                Me.TextBox97.Text = "F"
                Me.TextBox95.Text = "0.00"
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox82.Text) Then
            If Val(TextBox82.Text) >= 0 And Val(TextBox82.Text) <= 32 Then
                Me.TextBox93.Text = "F"
                Me.TextBox94.Text = "0.00"
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox96.Text) Then
            If Val(TextBox96.Text) >= 0 And Val(TextBox96.Text) <= 32 Then
                Me.TextBox104.Text = "F"
                Me.TextBox552.Text = "0.00"
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        'Bangladesh And Global Studies
        If IsNumeric(TextBox98.Text) Then
            If Val(TextBox98.Text) >= 0 And Val(TextBox98.Text) <= 32 Then
                Me.TextBox105.Text = "F"
                Me.TextBox116.Text = "0.00"
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If

        'Science
        If IsNumeric(TextBox99.Text) Then
            If Val(TextBox99.Text) >= 0 And Val(TextBox99.Text) <= 32 Then
                Me.TextBox107.Text = "F"
                Me.TextBox114.Text = "0.00"
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If


        'Islam Religion
        If IsNumeric(TextBox100.Text) Then
            If Val(TextBox100.Text) >= 0 And Val(TextBox100.Text) <= 32 Then
                Me.TextBox109.Text = "F"
                Me.TextBox112.Text = "0.00"
                Me.TextBox87.Clear()
                Me.TextBox86.Clear()
                Me.TextBox88.Clear()
                Me.TextBox85.Clear()
                Me.TextBox84.Text = "Fail"
            End If
        End If


        'Timar

        'Bangla
        If Me.TextBox83.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'English
        If Me.TextBox82.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox96.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'Bangladesh and Global Studies
        If Me.TextBox98.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'Science
        If Me.TextBox99.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If

        'Islam and moral Education
        If Me.TextBox100.Text = "" Then
            Me.TextBox87.Clear()
            Me.TextBox86.Clear()
            Me.TextBox88.Clear()
            Me.TextBox85.Clear()
            Me.TextBox84.Text = "Fail"
        End If
    End Sub

    'Check Box
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

    'Combo Box
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Me.Label314.Text = ComboBox4.Text
    End Sub

    'Bangla
    Private Sub TextBox83_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox83.TextChanged
        If Me.TextBox83.Text = "" Then
            Me.PictureBox13.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox83.Text) >= 0 And Val(TextBox83.Text) <= 100 Then
            Me.PictureBox13.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox83.Text) >= 101 And Val(TextBox83.Text) <= 100000 Then
            Me.PictureBox13.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox83.Text = ""
        Else
            Me.PictureBox13.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox83.Text = "" Then
            Me.TextBox97.Text = "F"
            Me.TextBox95.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox83.Text) Then
            If Val(TextBox83.Text) >= 80 And Val(TextBox83.Text) <= 100 Then
                Me.TextBox97.Text = "A+"
                Me.TextBox95.Text = "5.00"
            ElseIf Val(TextBox83.Text) >= 70 And Val(TextBox83.Text) <= 79 Then
                Me.TextBox97.Text = "A"
                Me.TextBox95.Text = "4.00"
            ElseIf Val(TextBox83.Text) >= 60 And Val(TextBox83.Text) <= 69 Then
                Me.TextBox97.Text = "A-"
                Me.TextBox95.Text = "3.50"
            ElseIf Val(TextBox83.Text) >= 50 And Val(TextBox83.Text) <= 59 Then
                Me.TextBox97.Text = "B"
                Me.TextBox95.Text = "3.00"
            ElseIf Val(TextBox83.Text) >= 40 And Val(TextBox83.Text) <= 49 Then
                Me.TextBox97.Text = "C"
                Me.TextBox95.Text = "2.00"
            ElseIf Val(TextBox83.Text) >= 32 And Val(TextBox83.Text) <= 39 Then
                Me.TextBox97.Text = "D"
                Me.TextBox95.Text = "1.00"
            Else
                Me.TextBox97.Text = "F"
                Me.TextBox95.Text = "0.00"
            End If
        End If
        Me.Four_1st_MarkInformation()
    End Sub

    'English For Today
    Private Sub TextBox82_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox82.TextChanged
        If Me.TextBox82.Text = "" Then
            Me.PictureBox12.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox82.Text) >= 0 And Val(TextBox82.Text) <= 100 Then
            Me.PictureBox12.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox82.Text) >= 101 And Val(TextBox82.Text) <= 100000 Then
            Me.PictureBox12.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox82.Text = ""
        Else
            Me.PictureBox12.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox82.Text = "" Then
            Me.TextBox93.Text = "F"
            Me.TextBox94.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox82.Text) Then
            If Val(TextBox82.Text) >= 80 And Val(TextBox82.Text) <= 100 Then
                Me.TextBox93.Text = "A+"
                Me.TextBox94.Text = "5.00"
            ElseIf Val(TextBox82.Text) >= 70 And Val(TextBox82.Text) <= 79 Then
                Me.TextBox93.Text = "A"
                Me.TextBox94.Text = "4.00"
            ElseIf Val(TextBox82.Text) >= 60 And Val(TextBox82.Text) <= 69 Then
                Me.TextBox93.Text = "A-"
                Me.TextBox94.Text = "3.50"
            ElseIf Val(TextBox82.Text) >= 50 And Val(TextBox82.Text) <= 59 Then
                Me.TextBox93.Text = "B"
                Me.TextBox94.Text = "3.00"
            ElseIf Val(TextBox82.Text) >= 40 And Val(TextBox82.Text) <= 49 Then
                Me.TextBox93.Text = "C"
                Me.TextBox94.Text = "2.00"
            ElseIf Val(TextBox82.Text) >= 32 And Val(TextBox82.Text) <= 39 Then
                Me.TextBox93.Text = "D"
                Me.TextBox94.Text = "1.00"
            Else
                Me.TextBox93.Text = "F"
                Me.TextBox94.Text = "0.00"
            End If
        End If
        Me.Four_1st_MarkInformation()
    End Sub

    'Mathematics
    Private Sub TextBox96_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox96.TextChanged
        If Me.TextBox96.Text = "" Then
            Me.PictureBox11.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox96.Text) >= 0 And Val(TextBox96.Text) <= 100 Then
            Me.PictureBox11.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox96.Text) >= 101 And Val(TextBox96.Text) <= 100000 Then
            Me.PictureBox11.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox96.Text = ""
        Else
            Me.PictureBox11.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox96.Text = "" Then
            Me.TextBox104.Text = "F"
            Me.TextBox552.Text = "0.00"
        End If

        'Mathematic 100
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
                Me.TextBox552.Text = "2.00"
            ElseIf Val(TextBox96.Text) >= 32 And Val(TextBox96.Text) <= 39 Then
                Me.TextBox104.Text = "D"
                Me.TextBox552.Text = "1.00"
            Else
                Me.TextBox104.Text = "F"
                Me.TextBox552.Text = "0.00"
            End If
        End If

        Me.Four_1st_MarkInformation()
    End Sub

    'Bangladesh and Global Studies
    Private Sub TextBox98_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox98.TextChanged
        If Me.TextBox98.Text = "" Then
            Me.PictureBox10.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox98.Text) >= 0 And Val(TextBox98.Text) <= 100 Then
            Me.PictureBox10.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox98.Text) >= 101 And Val(TextBox98.Text) <= 100000 Then
            Me.PictureBox10.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangladesh and Global Studies Creative Marks")
            Me.TextBox98.Text = ""
        Else
            Me.PictureBox10.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox98.Text = "" Then
            Me.TextBox105.Text = "F"
            Me.TextBox116.Text = "0.00"
        End If

        'Bangladesh and Global Studies 100
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

        Me.Four_1st_MarkInformation()
    End Sub

    'Science
    Private Sub TextBox99_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox99.TextChanged
        If Me.TextBox99.Text = "" Then
            Me.PictureBox9.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox99.Text) >= 0 And Val(TextBox99.Text) <= 100 Then
            Me.PictureBox9.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox99.Text) >= 101 And Val(TextBox99.Text) <= 100000 Then
            Me.PictureBox9.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Science Creative Marks")
            Me.TextBox99.Text = ""
        Else
            Me.PictureBox9.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox99.Text = "" Then
            Me.TextBox107.Text = "F"
            Me.TextBox114.Text = "0.00"
        End If

        'Science 100
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

        Me.Four_1st_MarkInformation()
    End Sub

    'Islam Religion
    Private Sub TextBox100_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox100.TextChanged
        If ComboBox4.Text = "Islam Religion" Then
            If Me.TextBox100.Text = "" Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox100.Text) >= 0 And Val(TextBox100.Text) <= 100 Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox100.Text) >= 101 And Val(TextBox100.Text) <= 100000 Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Islam Religion Creative Marks")
                Me.TextBox100.Text = ""
            Else
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox4.Text = "Hindu Religion" Then
            If Me.TextBox100.Text = "" Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox100.Text) >= 0 And Val(TextBox100.Text) <= 100 Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox100.Text) >= 101 And Val(TextBox100.Text) <= 100000 Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Hindu Religion Creative Marks")
                Me.TextBox100.Text = ""
            Else
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox4.Text = "Christian Religion" Then
            If Me.TextBox100.Text = "" Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox100.Text) >= 0 And Val(TextBox100.Text) <= 100 Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox100.Text) >= 101 And Val(TextBox100.Text) <= 100000 Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Christian Religion Creative Marks")
                Me.TextBox100.Text = ""
            Else
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox4.Text = "Buddhist Religion" Then
            If Me.TextBox100.Text = "" Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox100.Text) >= 0 And Val(TextBox100.Text) <= 100 Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox100.Text) >= 101 And Val(TextBox100.Text) <= 100000 Then
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Buddhist Religion Creative Marks")
                Me.TextBox100.Text = ""
            Else
                Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox100.Text = "" Then
            Me.TextBox109.Text = "F"
            Me.TextBox112.Text = "0.00"
        End If

        'Islam Religion
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

        Me.Four_1st_MarkInformation()
    End Sub

    'GPA
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
        'Bangla
        If TextBox83.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox83.Select()

            'English For Today
        ElseIf TextBox82.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox82.Select()

            'Mathematics
        ElseIf TextBox96.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox96.Select()

            'Bangladesh and Global Studies
        ElseIf TextBox98.Text = "" Then
            MessageBox.Show("Input ''Bangladesh and Global Studies Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox98.Select()

            'Science
        ElseIf TextBox99.Text = "" Then
            MessageBox.Show("Input ''Science Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox99.Select()

            'Islam and Moral Education
        ElseIf TextBox100.Text = "" Then
            If ComboBox4.Text = "Islam Religion" Then
                MessageBox.Show("Input ''Islam Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox4.Text = "Hindu Religion" Then
                MessageBox.Show("Input ''Hindu Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox4.Text = "Christian Religion" Then
                MessageBox.Show("Input ''Christian Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox4.Text = "Buddhist Religion" Then
                MessageBox.Show("Input ''Buddhist Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox100.Select()

        Else
            '
            '
            MessageBox.Show("Four Second Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button70.Click
        'Bangla
        Me.TextBox83.Clear()
        Me.TextBox97.Clear()
        Me.TextBox95.Clear()

        'English for Today
        Me.TextBox82.Clear()
        Me.TextBox93.Clear()
        Me.TextBox94.Clear()

        'Mathematics
        Me.TextBox96.Clear()
        Me.TextBox104.Clear()
        Me.TextBox552.Clear()

        'Bangladesh and Global Studies
        Me.TextBox98.Clear()
        Me.TextBox105.Clear()
        Me.TextBox116.Clear()

        'Science
        Me.TextBox99.Clear()
        Me.TextBox107.Clear()
        Me.TextBox114.Clear()

        'Islam amd moral Education
        Me.TextBox100.Clear()
        Me.TextBox109.Clear()
        Me.TextBox112.Clear()

        'Result Information
        Me.TextBox87.Clear()
        Me.TextBox86.Clear()
        Me.TextBox88.Clear()
        Me.TextBox85.Clear()
        Me.TextBox84.Clear()

        'PIC Box
        Me.PictureBox13.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox12.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox11.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox10.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox9.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox8.Image = Global.Student_Data_Managements.My.Resources.NO_Pic

        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Button Back
    Private Sub Button69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button69.Click

    End Sub

    'Button Next
    Private Sub Button68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button68.Click

    End Sub


    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    'Class Three 1st

    'Marks Information
    Private Sub Three_1st_MarkInformation()

        'Total Mark
        Me.TextBox8.Text = Val(TextBox4.Text) + Val(TextBox3.Text) + Val(TextBox17.Text) + Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text)

        'Average
        Me.TextBox7.Text = Format(((Val(TextBox4.Text) + Val(TextBox3.Text) + Val(TextBox17.Text) + Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text)) / 6), "0.00")

        'GPA
        Me.TextBox6.Text = Format(((Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox35.Text) + Val(TextBox33.Text)) / 6), "0.00")
        Me.TextBox5.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox4.Text) Then
            If Val(TextBox4.Text) >= 0 And Val(TextBox4.Text) <= 32 Then
                Me.TextBox18.Text = "F"
                Me.TextBox16.Text = "0.00"
                Me.TextBox8.Clear()
                Me.TextBox7.Clear()
                Me.TextBox9.Clear()
                Me.TextBox6.Clear()
                Me.TextBox5.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox3.Text) Then
            If Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 32 Then
                Me.TextBox14.Text = "F"
                Me.TextBox15.Text = "0.00"
                Me.TextBox8.Clear()
                Me.TextBox7.Clear()
                Me.TextBox9.Clear()
                Me.TextBox6.Clear()
                Me.TextBox5.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox17.Text) Then
            If Val(TextBox17.Text) >= 0 And Val(TextBox17.Text) <= 32 Then
                Me.TextBox25.Text = "F"
                Me.TextBox38.Text = "0.00"
                Me.TextBox8.Clear()
                Me.TextBox7.Clear()
                Me.TextBox9.Clear()
                Me.TextBox6.Clear()
                Me.TextBox5.Text = "Fail"
            End If
        End If

        'Bangladesh And Global Studies
        If IsNumeric(TextBox19.Text) Then
            If Val(TextBox19.Text) >= 0 And Val(TextBox19.Text) <= 32 Then
                Me.TextBox26.Text = "F"
                Me.TextBox37.Text = "0.00"
                Me.TextBox8.Clear()
                Me.TextBox7.Clear()
                Me.TextBox9.Clear()
                Me.TextBox6.Clear()
                Me.TextBox5.Text = "Fail"
            End If
        End If

        'Science
        If IsNumeric(TextBox20.Text) Then
            If Val(TextBox20.Text) >= 0 And Val(TextBox20.Text) <= 32 Then
                Me.TextBox28.Text = "F"
                Me.TextBox35.Text = "0.00"
                Me.TextBox8.Clear()
                Me.TextBox7.Clear()
                Me.TextBox9.Clear()
                Me.TextBox6.Clear()
                Me.TextBox5.Text = "Fail"
            End If
        End If


        'Islam Religion
        If IsNumeric(TextBox21.Text) Then
            If Val(TextBox21.Text) >= 0 And Val(TextBox21.Text) <= 32 Then
                Me.TextBox30.Text = "F"
                Me.TextBox33.Text = "0.00"
                Me.TextBox8.Clear()
                Me.TextBox7.Clear()
                Me.TextBox9.Clear()
                Me.TextBox6.Clear()
                Me.TextBox5.Text = "Fail"
            End If
        End If


        'Timar

        'Bangla
        If Me.TextBox4.Text = "" Then
            Me.TextBox8.Clear()
            Me.TextBox7.Clear()
            Me.TextBox9.Clear()
            Me.TextBox6.Clear()
            Me.TextBox5.Text = "Fail"
        End If

        'English
        If Me.TextBox3.Text = "" Then
            Me.TextBox8.Clear()
            Me.TextBox7.Clear()
            Me.TextBox9.Clear()
            Me.TextBox6.Clear()
            Me.TextBox5.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox17.Text = "" Then
            Me.TextBox8.Clear()
            Me.TextBox7.Clear()
            Me.TextBox9.Clear()
            Me.TextBox6.Clear()
            Me.TextBox5.Text = "Fail"
        End If

        'Bangladesh and Global Studies
        If Me.TextBox19.Text = "" Then
            Me.TextBox8.Clear()
            Me.TextBox7.Clear()
            Me.TextBox9.Clear()
            Me.TextBox6.Clear()
            Me.TextBox5.Text = "Fail"
        End If

        'Science
        If Me.TextBox20.Text = "" Then
            Me.TextBox8.Clear()
            Me.TextBox7.Clear()
            Me.TextBox9.Clear()
            Me.TextBox6.Clear()
            Me.TextBox5.Text = "Fail"
        End If

        'Islam and moral Education
        If Me.TextBox21.Text = "" Then
            Me.TextBox8.Clear()
            Me.TextBox7.Clear()
            Me.TextBox9.Clear()
            Me.TextBox6.Clear()
            Me.TextBox5.Text = "Fail"
        End If
    End Sub


    'Check Box
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TextBox39.Enabled = True
            Me.TextBox40.Enabled = True
        ElseIf CheckBox1.Checked = False Then
            Me.TextBox39.Enabled = False
            Me.TextBox40.Enabled = False

            Me.TextBox39.Clear()
            Me.TextBox40.Clear()
        End If
    End Sub

    'Combo Box
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Me.Label313.Text = ComboBox3.Text
    End Sub

    'Bangla
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Me.TextBox4.Text = "" Then
            Me.PictureBox25.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox4.Text) >= 0 And Val(TextBox4.Text) <= 100 Then
            Me.PictureBox25.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox4.Text) >= 101 And Val(TextBox4.Text) <= 100000 Then
            Me.PictureBox25.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox4.Text = ""
        Else
            Me.PictureBox25.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox4.Text = "" Then
            Me.TextBox18.Text = "F"
            Me.TextBox16.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox4.Text) Then
            If Val(TextBox4.Text) >= 80 And Val(TextBox4.Text) <= 100 Then
                Me.TextBox18.Text = "A+"
                Me.TextBox16.Text = "5.00"
            ElseIf Val(TextBox4.Text) >= 70 And Val(TextBox4.Text) <= 79 Then
                Me.TextBox18.Text = "A"
                Me.TextBox16.Text = "4.00"
            ElseIf Val(TextBox4.Text) >= 60 And Val(TextBox4.Text) <= 69 Then
                Me.TextBox18.Text = "A-"
                Me.TextBox16.Text = "3.50"
            ElseIf Val(TextBox4.Text) >= 50 And Val(TextBox4.Text) <= 59 Then
                Me.TextBox18.Text = "B"
                Me.TextBox16.Text = "3.00"
            ElseIf Val(TextBox4.Text) >= 40 And Val(TextBox4.Text) <= 49 Then
                Me.TextBox18.Text = "C"
                Me.TextBox16.Text = "2.00"
            ElseIf Val(TextBox4.Text) >= 32 And Val(TextBox4.Text) <= 39 Then
                Me.TextBox18.Text = "D"
                Me.TextBox16.Text = "1.00"
            Else
                Me.TextBox18.Text = "F"
                Me.TextBox16.Text = "0.00"
            End If
        End If
        Me.Three_1st_MarkInformation()
    End Sub

    'English
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If Me.TextBox3.Text = "" Then
            Me.PictureBox24.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 100 Then
            Me.PictureBox24.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox3.Text) >= 101 And Val(TextBox3.Text) <= 100000 Then
            Me.PictureBox24.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox3.Text = ""
        Else
            Me.PictureBox24.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox3.Text = "" Then
            Me.TextBox14.Text = "F"
            Me.TextBox15.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox3.Text) Then
            If Val(TextBox3.Text) >= 80 And Val(TextBox3.Text) <= 100 Then
                Me.TextBox14.Text = "A+"
                Me.TextBox15.Text = "5.00"
            ElseIf Val(TextBox3.Text) >= 70 And Val(TextBox3.Text) <= 79 Then
                Me.TextBox14.Text = "A"
                Me.TextBox15.Text = "4.00"
            ElseIf Val(TextBox3.Text) >= 60 And Val(TextBox3.Text) <= 69 Then
                Me.TextBox14.Text = "A-"
                Me.TextBox15.Text = "3.50"
            ElseIf Val(TextBox3.Text) >= 50 And Val(TextBox3.Text) <= 59 Then
                Me.TextBox14.Text = "B"
                Me.TextBox15.Text = "3.00"
            ElseIf Val(TextBox3.Text) >= 40 And Val(TextBox3.Text) <= 49 Then
                Me.TextBox14.Text = "C"
                Me.TextBox15.Text = "2.00"
            ElseIf Val(TextBox3.Text) >= 32 And Val(TextBox3.Text) <= 39 Then
                Me.TextBox14.Text = "D"
                Me.TextBox15.Text = "1.00"
            Else
                Me.TextBox14.Text = "F"
                Me.TextBox15.Text = "0.00"
            End If
        End If
        Me.Three_1st_MarkInformation()
    End Sub

    'Mathematics
    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged
        If Me.TextBox17.Text = "" Then
            Me.PictureBox23.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox17.Text) >= 0 And Val(TextBox17.Text) <= 100 Then
            Me.PictureBox23.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox17.Text) >= 101 And Val(TextBox17.Text) <= 100000 Then
            Me.PictureBox23.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox17.Text = ""
        Else
            Me.PictureBox23.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox17.Text = "" Then
            Me.TextBox25.Text = "F"
            Me.TextBox38.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox17.Text) Then
            If Val(TextBox17.Text) >= 80 And Val(TextBox17.Text) <= 100 Then
                Me.TextBox25.Text = "A+"
                Me.TextBox38.Text = "5.00"
            ElseIf Val(TextBox17.Text) >= 70 And Val(TextBox17.Text) <= 79 Then
                Me.TextBox25.Text = "A"
                Me.TextBox38.Text = "4.00"
            ElseIf Val(TextBox17.Text) >= 60 And Val(TextBox17.Text) <= 69 Then
                Me.TextBox25.Text = "A-"
                Me.TextBox38.Text = "3.50"
            ElseIf Val(TextBox17.Text) >= 50 And Val(TextBox17.Text) <= 59 Then
                Me.TextBox25.Text = "B"
                Me.TextBox38.Text = "3.00"
            ElseIf Val(TextBox17.Text) >= 40 And Val(TextBox17.Text) <= 49 Then
                Me.TextBox25.Text = "C"
                Me.TextBox38.Text = "2.00"
            ElseIf Val(TextBox17.Text) >= 32 And Val(TextBox17.Text) <= 39 Then
                Me.TextBox25.Text = "D"
                Me.TextBox38.Text = "1.00"
            Else
                Me.TextBox25.Text = "F"
                Me.TextBox38.Text = "0.00"
            End If
        End If

        Me.Three_1st_MarkInformation()
    End Sub

    'Bangladesh and Global Studies
    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        If Me.TextBox19.Text = "" Then
            Me.PictureBox22.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox19.Text) >= 0 And Val(TextBox19.Text) <= 100 Then
            Me.PictureBox22.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox19.Text) >= 101 And Val(TextBox19.Text) <= 100000 Then
            Me.PictureBox22.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangladesh and Global Studies Creative Marks")
            Me.TextBox19.Text = ""
        Else
            Me.PictureBox22.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox19.Text = "" Then
            Me.TextBox26.Text = "F"
            Me.TextBox37.Text = "0.00"
        End If

        'Bangladesh and Global Studies 100
        If IsNumeric(TextBox19.Text) Then
            If Val(TextBox19.Text) >= 80 And Val(TextBox19.Text) <= 100 Then
                Me.TextBox26.Text = "A+"
                Me.TextBox37.Text = "5.00"
            ElseIf Val(TextBox19.Text) >= 70 And Val(TextBox19.Text) <= 79 Then
                Me.TextBox26.Text = "A"
                Me.TextBox37.Text = "4.00"
            ElseIf Val(TextBox19.Text) >= 60 And Val(TextBox19.Text) <= 69 Then
                Me.TextBox26.Text = "A-"
                Me.TextBox37.Text = "3.50"
            ElseIf Val(TextBox19.Text) >= 50 And Val(TextBox19.Text) <= 59 Then
                Me.TextBox26.Text = "B"
                Me.TextBox37.Text = "3.00"
            ElseIf Val(TextBox19.Text) >= 40 And Val(TextBox19.Text) <= 49 Then
                Me.TextBox26.Text = "C"
                Me.TextBox37.Text = "2.00"
            ElseIf Val(TextBox19.Text) >= 32 And Val(TextBox19.Text) <= 39 Then
                Me.TextBox26.Text = "D"
                Me.TextBox37.Text = "1.00"
            Else
                Me.TextBox26.Text = "F"
                Me.TextBox37.Text = "0.00"
            End If
        End If

        Me.Three_1st_MarkInformation()
    End Sub

    'Science
    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged
        If Me.TextBox20.Text = "" Then
            Me.PictureBox21.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox20.Text) >= 0 And Val(TextBox20.Text) <= 100 Then
            Me.PictureBox21.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox20.Text) >= 101 And Val(TextBox20.Text) <= 100000 Then
            Me.PictureBox21.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Science Creative Marks")
            Me.TextBox20.Text = ""
        Else
            Me.PictureBox21.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox20.Text = "" Then
            Me.TextBox28.Text = "F"
            Me.TextBox35.Text = "0.00"
        End If

        'Science 100
        If IsNumeric(TextBox20.Text) Then
            If Val(TextBox20.Text) >= 80 And Val(TextBox20.Text) <= 100 Then
                Me.TextBox28.Text = "A+"
                Me.TextBox35.Text = "5.00"
            ElseIf Val(TextBox20.Text) >= 70 And Val(TextBox20.Text) <= 79 Then
                Me.TextBox28.Text = "A"
                Me.TextBox35.Text = "4.00"
            ElseIf Val(TextBox20.Text) >= 60 And Val(TextBox20.Text) <= 69 Then
                Me.TextBox28.Text = "A-"
                Me.TextBox35.Text = "3.50"
            ElseIf Val(TextBox20.Text) >= 50 And Val(TextBox20.Text) <= 59 Then
                Me.TextBox28.Text = "B"
                Me.TextBox35.Text = "3.00"
            ElseIf Val(TextBox20.Text) >= 40 And Val(TextBox20.Text) <= 49 Then
                Me.TextBox28.Text = "C"
                Me.TextBox35.Text = "2.00"
            ElseIf Val(TextBox20.Text) >= 32 And Val(TextBox20.Text) <= 39 Then
                Me.TextBox28.Text = "D"
                Me.TextBox35.Text = "1.00"
            Else
                Me.TextBox28.Text = "F"
                Me.TextBox35.Text = "0.00"
            End If
        End If

        Me.Three_1st_MarkInformation()
    End Sub

    'Islam Religon
    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged
        If ComboBox3.Text = "Islam Religion" Then
            If Me.TextBox21.Text = "" Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox21.Text) >= 0 And Val(TextBox21.Text) <= 100 Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox21.Text) >= 101 And Val(TextBox21.Text) <= 100000 Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Islam Religion Creative Marks")
                Me.TextBox21.Text = ""
            Else
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox3.Text = "Hindu Religion" Then
            If Me.TextBox21.Text = "" Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox21.Text) >= 0 And Val(TextBox21.Text) <= 100 Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox21.Text) >= 101 And Val(TextBox21.Text) <= 100000 Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Hindu Religion Creative Marks")
                Me.TextBox21.Text = ""
            Else
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox3.Text = "Christian Religion" Then
            If Me.TextBox21.Text = "" Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox21.Text) >= 0 And Val(TextBox21.Text) <= 100 Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox21.Text) >= 101 And Val(TextBox21.Text) <= 100000 Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Christian Religion Creative Marks")
                Me.TextBox21.Text = ""
            Else
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox3.Text = "Buddhist Religion" Then
            If Me.TextBox21.Text = "" Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox21.Text) >= 0 And Val(TextBox21.Text) <= 100 Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox21.Text) >= 101 And Val(TextBox21.Text) <= 100000 Then
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Buddhist Religion Creative Marks")
                Me.TextBox21.Text = ""
            Else
                Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox21.Text = "" Then
            Me.TextBox30.Text = "F"
            Me.TextBox33.Text = "0.00"
        End If

        'Islam Religion
        If IsNumeric(TextBox21.Text) Then
            If Val(TextBox21.Text) >= 80 And Val(TextBox21.Text) <= 100 Then
                Me.TextBox30.Text = "A+"
                Me.TextBox33.Text = "5.00"
            ElseIf Val(TextBox21.Text) >= 70 And Val(TextBox21.Text) <= 79 Then
                Me.TextBox30.Text = "A"
                Me.TextBox33.Text = "4.00"
            ElseIf Val(TextBox21.Text) >= 60 And Val(TextBox21.Text) <= 69 Then
                Me.TextBox30.Text = "A-"
                Me.TextBox33.Text = "3.50"
            ElseIf Val(TextBox21.Text) >= 50 And Val(TextBox21.Text) <= 59 Then
                Me.TextBox30.Text = "B"
                Me.TextBox33.Text = "3.00"
            ElseIf Val(TextBox21.Text) >= 40 And Val(TextBox21.Text) <= 49 Then
                Me.TextBox30.Text = "C"
                Me.TextBox33.Text = "2.00"
            ElseIf Val(TextBox21.Text) >= 32 And Val(TextBox21.Text) <= 39 Then
                Me.TextBox30.Text = "D"
                Me.TextBox33.Text = "1.00"
            Else
                Me.TextBox30.Text = "F"
                Me.TextBox33.Text = "0.00"
            End If
        End If

        Me.Three_1st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If IsNumeric(TextBox6.Text) Then
            If Val(TextBox6.Text) > 4.99 Then
                Me.TextBox9.Text = "A+"
            ElseIf Val(TextBox6.Text) > 3.99 Then
                Me.TextBox9.Text = "A"
            ElseIf Val(TextBox6.Text) > 3.49 Then
                Me.TextBox9.Text = "A-"
            ElseIf Val(TextBox6.Text) > 2.99 Then
                Me.TextBox9.Text = "B"
            ElseIf Val(TextBox6.Text) > 1.99 Then
                Me.TextBox9.Text = "C"
            ElseIf Val(TextBox6.Text) > 0.99 Then
                Me.TextBox9.Text = "D"
            Else
                Me.TextBox9.Text = "F"
            End If
        End If

        If IsNumeric(TextBox6.Text) Then
            If Val(TextBox6.Text) >= 4.99 And Val(TextBox6.Text) <= 100000 Then
                TextBox6.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Bangla
        If TextBox4.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox4.Select()

            'English For Today
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox3.Select()

            'Mathematics
        ElseIf TextBox17.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox17.Select()

            'Bangladesh and Global Studies
        ElseIf TextBox19.Text = "" Then
            MessageBox.Show("Input ''Bangladesh and Global Studies Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox19.Select()

            'Science
        ElseIf TextBox20.Text = "" Then
            MessageBox.Show("Input ''Science Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox20.Select()

            'Islam and Moral Education
        ElseIf TextBox21.Text = "" Then
            If ComboBox3.Text = "Islam Religion" Then
                MessageBox.Show("Input ''Islam Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox3.Text = "Hindu Religion" Then
                MessageBox.Show("Input ''Hindu Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox3.Text = "Christian Religion" Then
                MessageBox.Show("Input ''Christian Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox3.Text = "Buddhist Religion" Then
                MessageBox.Show("Input ''Buddhist Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox21.Select()

        Else
            '
            '
            MessageBox.Show("Four Second Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button64.Click
        'Bangla
        Me.TextBox4.Clear()
        Me.TextBox18.Clear()
        Me.TextBox16.Clear()

        'English for Today
        Me.TextBox3.Clear()
        Me.TextBox14.Clear()
        Me.TextBox15.Clear()

        'Mathematics
        Me.TextBox17.Clear()
        Me.TextBox25.Clear()
        Me.TextBox38.Clear()

        'Bangladesh and Global Studies
        Me.TextBox19.Clear()
        Me.TextBox26.Clear()
        Me.TextBox37.Clear()

        'Science
        Me.TextBox20.Clear()
        Me.TextBox28.Clear()
        Me.TextBox35.Clear()

        'Islam amd moral Education
        Me.TextBox21.Clear()
        Me.TextBox30.Clear()
        Me.TextBox33.Clear()

        'Result Information
        Me.TextBox8.Clear()
        Me.TextBox7.Clear()
        Me.TextBox9.Clear()
        Me.TextBox6.Clear()
        Me.TextBox5.Clear()

        'PIC Box
        Me.PictureBox25.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox24.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox23.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox22.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox21.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox20.Image = Global.Student_Data_Managements.My.Resources.NO_Pic

        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Button Back
    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button63.Click

    End Sub

    'Button Next
    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click

    End Sub


    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    'Class Three 2st

    'Marks Information
    Private Sub Three_2st_MarkInformation()

        'Total Mark
        Me.TextBox49.Text = Val(TextBox45.Text) + Val(TextBox44.Text) + Val(TextBox58.Text) + Val(TextBox60.Text) + Val(TextBox61.Text) + Val(TextBox62.Text)

        'Average
        Me.TextBox48.Text = Format(((Val(TextBox45.Text) + Val(TextBox44.Text) + Val(TextBox58.Text) + Val(TextBox60.Text) + Val(TextBox61.Text) + Val(TextBox62.Text)) / 6), "0.00")

        'GPA
        Me.TextBox47.Text = Format(((Val(TextBox57.Text) + Val(TextBox56.Text) + Val(TextBox549.Text) + Val(TextBox78.Text) + Val(TextBox76.Text) + Val(TextBox74.Text)) / 6), "0.00")
        Me.TextBox46.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox45.Text) Then
            If Val(TextBox45.Text) >= 0 And Val(TextBox45.Text) <= 32 Then
                Me.TextBox59.Text = "F"
                Me.TextBox57.Text = "0.00"
                Me.TextBox49.Clear()
                Me.TextBox48.Clear()
                Me.TextBox50.Clear()
                Me.TextBox47.Clear()
                Me.TextBox46.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox44.Text) Then
            If Val(TextBox44.Text) >= 0 And Val(TextBox44.Text) <= 32 Then
                Me.TextBox55.Text = "F"
                Me.TextBox56.Text = "0.00"
                Me.TextBox49.Clear()
                Me.TextBox48.Clear()
                Me.TextBox50.Clear()
                Me.TextBox47.Clear()
                Me.TextBox46.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox58.Text) Then
            If Val(TextBox58.Text) >= 0 And Val(TextBox58.Text) <= 32 Then
                Me.TextBox66.Text = "F"
                Me.TextBox549.Text = "0.00"
                Me.TextBox49.Clear()
                Me.TextBox48.Clear()
                Me.TextBox50.Clear()
                Me.TextBox47.Clear()
                Me.TextBox46.Text = "Fail"
            End If
        End If

        'Bangladesh And Global Studies
        If IsNumeric(TextBox60.Text) Then
            If Val(TextBox60.Text) >= 0 And Val(TextBox60.Text) <= 32 Then
                Me.TextBox67.Text = "F"
                Me.TextBox78.Text = "0.00"
                Me.TextBox49.Clear()
                Me.TextBox48.Clear()
                Me.TextBox50.Clear()
                Me.TextBox47.Clear()
                Me.TextBox46.Text = "Fail"
            End If
        End If

        'Science
        If IsNumeric(TextBox61.Text) Then
            If Val(TextBox61.Text) >= 0 And Val(TextBox61.Text) <= 32 Then
                Me.TextBox69.Text = "F"
                Me.TextBox76.Text = "0.00"
                Me.TextBox49.Clear()
                Me.TextBox48.Clear()
                Me.TextBox50.Clear()
                Me.TextBox47.Clear()
                Me.TextBox46.Text = "Fail"
            End If
        End If


        'Islam Religion
        If IsNumeric(TextBox62.Text) Then
            If Val(TextBox62.Text) >= 0 And Val(TextBox62.Text) <= 32 Then
                Me.TextBox71.Text = "F"
                Me.TextBox74.Text = "0.00"
                Me.TextBox49.Clear()
                Me.TextBox48.Clear()
                Me.TextBox50.Clear()
                Me.TextBox47.Clear()
                Me.TextBox46.Text = "Fail"
            End If
        End If


        'Timar

        'Bangla
        If Me.TextBox45.Text = "" Then
            Me.TextBox49.Clear()
            Me.TextBox48.Clear()
            Me.TextBox50.Clear()
            Me.TextBox47.Clear()
            Me.TextBox46.Text = "Fail"
        End If

        'English
        If Me.TextBox44.Text = "" Then
            Me.TextBox49.Clear()
            Me.TextBox48.Clear()
            Me.TextBox50.Clear()
            Me.TextBox47.Clear()
            Me.TextBox46.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox58.Text = "" Then
            Me.TextBox49.Clear()
            Me.TextBox48.Clear()
            Me.TextBox50.Clear()
            Me.TextBox47.Clear()
            Me.TextBox46.Text = "Fail"
        End If

        'Bangladesh and Global Studies
        If Me.TextBox60.Text = "" Then
            Me.TextBox49.Clear()
            Me.TextBox48.Clear()
            Me.TextBox50.Clear()
            Me.TextBox47.Clear()
            Me.TextBox46.Text = "Fail"
        End If

        'Science
        If Me.TextBox61.Text = "" Then
            Me.TextBox49.Clear()
            Me.TextBox48.Clear()
            Me.TextBox50.Clear()
            Me.TextBox47.Clear()
            Me.TextBox46.Text = "Fail"
        End If

        'Islam and moral Education
        If Me.TextBox62.Text = "" Then
            Me.TextBox49.Clear()
            Me.TextBox48.Clear()
            Me.TextBox50.Clear()
            Me.TextBox47.Clear()
            Me.TextBox46.Text = "Fail"
        End If
    End Sub

    'Check Box
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Me.TextBox550.Enabled = True
            Me.TextBox551.Enabled = True
        ElseIf CheckBox2.Checked = False Then
            Me.TextBox550.Enabled = False
            Me.TextBox551.Enabled = False

            Me.TextBox550.Clear()
            Me.TextBox551.Clear()
        End If
    End Sub

    'Bangla
    Private Sub TextBox45_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox45.TextChanged
        If Me.TextBox45.Text = "" Then
            Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox45.Text) >= 0 And Val(TextBox45.Text) <= 100 Then
            Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox45.Text) >= 101 And Val(TextBox45.Text) <= 100000 Then
            Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox45.Text = ""
        Else
            Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox45.Text = "" Then
            Me.TextBox59.Text = "F"
            Me.TextBox57.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox45.Text) Then
            If Val(TextBox45.Text) >= 80 And Val(TextBox45.Text) <= 100 Then
                Me.TextBox59.Text = "A+"
                Me.TextBox57.Text = "5.00"
            ElseIf Val(TextBox45.Text) >= 70 And Val(TextBox45.Text) <= 79 Then
                Me.TextBox59.Text = "A"
                Me.TextBox57.Text = "4.00"
            ElseIf Val(TextBox45.Text) >= 60 And Val(TextBox45.Text) <= 69 Then
                Me.TextBox59.Text = "A-"
                Me.TextBox57.Text = "3.50"
            ElseIf Val(TextBox45.Text) >= 50 And Val(TextBox45.Text) <= 59 Then
                Me.TextBox59.Text = "B"
                Me.TextBox57.Text = "3.00"
            ElseIf Val(TextBox45.Text) >= 40 And Val(TextBox45.Text) <= 49 Then
                Me.TextBox59.Text = "C"
                Me.TextBox57.Text = "2.00"
            ElseIf Val(TextBox45.Text) >= 32 And Val(TextBox45.Text) <= 39 Then
                Me.TextBox59.Text = "D"
                Me.TextBox57.Text = "1.00"
            Else
                Me.TextBox59.Text = "F"
                Me.TextBox57.Text = "0.00"
            End If
        End If
        Me.Three_2st_MarkInformation()
    End Sub

    'English
    Private Sub TextBox44_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox44.TextChanged
        If Me.TextBox44.Text = "" Then
            Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox44.Text) >= 0 And Val(TextBox44.Text) <= 100 Then
            Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox44.Text) >= 101 And Val(TextBox44.Text) <= 100000 Then
            Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox44.Text = ""
        Else
            Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox44.Text = "" Then
            Me.TextBox55.Text = "F"
            Me.TextBox56.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox44.Text) Then
            If Val(TextBox44.Text) >= 80 And Val(TextBox44.Text) <= 100 Then
                Me.TextBox55.Text = "A+"
                Me.TextBox56.Text = "5.00"
            ElseIf Val(TextBox44.Text) >= 70 And Val(TextBox44.Text) <= 79 Then
                Me.TextBox55.Text = "A"
                Me.TextBox56.Text = "4.00"
            ElseIf Val(TextBox44.Text) >= 60 And Val(TextBox44.Text) <= 69 Then
                Me.TextBox55.Text = "A-"
                Me.TextBox56.Text = "3.50"
            ElseIf Val(TextBox44.Text) >= 50 And Val(TextBox44.Text) <= 59 Then
                Me.TextBox55.Text = "B"
                Me.TextBox56.Text = "3.00"
            ElseIf Val(TextBox44.Text) >= 40 And Val(TextBox44.Text) <= 49 Then
                Me.TextBox55.Text = "C"
                Me.TextBox56.Text = "2.00"
            ElseIf Val(TextBox44.Text) >= 32 And Val(TextBox44.Text) <= 39 Then
                Me.TextBox55.Text = "D"
                Me.TextBox56.Text = "1.00"
            Else
                Me.TextBox55.Text = "F"
                Me.TextBox56.Text = "0.00"
            End If
        End If
        Me.Three_2st_MarkInformation()
    End Sub

    'Mathematice
    Private Sub TextBox58_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox58.TextChanged
        If Me.TextBox58.Text = "" Then
            Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox58.Text) >= 0 And Val(TextBox58.Text) <= 100 Then
            Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox58.Text) >= 101 And Val(TextBox58.Text) <= 100000 Then
            Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox58.Text = ""
        Else
            Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox58.Text = "" Then
            Me.TextBox66.Text = "F"
            Me.TextBox549.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox58.Text) Then
            If Val(TextBox58.Text) >= 80 And Val(TextBox58.Text) <= 100 Then
                Me.TextBox66.Text = "A+"
                Me.TextBox549.Text = "5.00"
            ElseIf Val(TextBox58.Text) >= 70 And Val(TextBox58.Text) <= 79 Then
                Me.TextBox66.Text = "A"
                Me.TextBox549.Text = "4.00"
            ElseIf Val(TextBox58.Text) >= 60 And Val(TextBox58.Text) <= 69 Then
                Me.TextBox66.Text = "A-"
                Me.TextBox549.Text = "3.50"
            ElseIf Val(TextBox58.Text) >= 50 And Val(TextBox58.Text) <= 59 Then
                Me.TextBox66.Text = "B"
                Me.TextBox549.Text = "3.00"
            ElseIf Val(TextBox58.Text) >= 40 And Val(TextBox58.Text) <= 49 Then
                Me.TextBox66.Text = "C"
                Me.TextBox549.Text = "2.00"
            ElseIf Val(TextBox58.Text) >= 32 And Val(TextBox58.Text) <= 39 Then
                Me.TextBox66.Text = "D"
                Me.TextBox549.Text = "1.00"
            Else
                Me.TextBox66.Text = "F"
                Me.TextBox549.Text = "0.00"
            End If
        End If

        Me.Three_2st_MarkInformation()
    End Sub

    'Bangladesh and Globel Studies
    Private Sub TextBox60_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox60.TextChanged
        If Me.TextBox60.Text = "" Then
            Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox60.Text) >= 0 And Val(TextBox60.Text) <= 100 Then
            Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox60.Text) >= 101 And Val(TextBox60.Text) <= 100000 Then
            Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangladesh and Global Studies Creative Marks")
            Me.TextBox60.Text = ""
        Else
            Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox60.Text = "" Then
            Me.TextBox67.Text = "F"
            Me.TextBox78.Text = "0.00"
        End If

        'Bangladesh and Global Studies 100
        If IsNumeric(TextBox60.Text) Then
            If Val(TextBox60.Text) >= 80 And Val(TextBox60.Text) <= 100 Then
                Me.TextBox67.Text = "A+"
                Me.TextBox78.Text = "5.00"
            ElseIf Val(TextBox60.Text) >= 70 And Val(TextBox60.Text) <= 79 Then
                Me.TextBox67.Text = "A"
                Me.TextBox78.Text = "4.00"
            ElseIf Val(TextBox60.Text) >= 60 And Val(TextBox60.Text) <= 69 Then
                Me.TextBox67.Text = "A-"
                Me.TextBox78.Text = "3.50"
            ElseIf Val(TextBox60.Text) >= 50 And Val(TextBox60.Text) <= 59 Then
                Me.TextBox67.Text = "B"
                Me.TextBox78.Text = "3.00"
            ElseIf Val(TextBox60.Text) >= 40 And Val(TextBox60.Text) <= 49 Then
                Me.TextBox67.Text = "C"
                Me.TextBox78.Text = "2.00"
            ElseIf Val(TextBox60.Text) >= 32 And Val(TextBox60.Text) <= 39 Then
                Me.TextBox67.Text = "D"
                Me.TextBox78.Text = "1.00"
            Else
                Me.TextBox67.Text = "F"
                Me.TextBox78.Text = "0.00"
            End If
        End If

        Me.Three_2st_MarkInformation()
    End Sub

    'Science
    Private Sub TextBox61_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox61.TextChanged
        If Me.TextBox61.Text = "" Then
            Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox61.Text) >= 0 And Val(TextBox61.Text) <= 100 Then
            Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox61.Text) >= 101 And Val(TextBox61.Text) <= 100000 Then
            Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Science Creative Marks")
            Me.TextBox61.Text = ""
        Else
            Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox61.Text = "" Then
            Me.TextBox69.Text = "F"
            Me.TextBox76.Text = "0.00"
        End If

        'Science 100
        If IsNumeric(TextBox61.Text) Then
            If Val(TextBox61.Text) >= 80 And Val(TextBox61.Text) <= 100 Then
                Me.TextBox69.Text = "A+"
                Me.TextBox76.Text = "5.00"
            ElseIf Val(TextBox61.Text) >= 70 And Val(TextBox61.Text) <= 79 Then
                Me.TextBox69.Text = "A"
                Me.TextBox76.Text = "4.00"
            ElseIf Val(TextBox61.Text) >= 60 And Val(TextBox61.Text) <= 69 Then
                Me.TextBox69.Text = "A-"
                Me.TextBox76.Text = "3.50"
            ElseIf Val(TextBox61.Text) >= 50 And Val(TextBox61.Text) <= 59 Then
                Me.TextBox69.Text = "B"
                Me.TextBox76.Text = "3.00"
            ElseIf Val(TextBox61.Text) >= 40 And Val(TextBox61.Text) <= 49 Then
                Me.TextBox69.Text = "C"
                Me.TextBox76.Text = "2.00"
            ElseIf Val(TextBox61.Text) >= 32 And Val(TextBox61.Text) <= 39 Then
                Me.TextBox69.Text = "D"
                Me.TextBox76.Text = "1.00"
            Else
                Me.TextBox69.Text = "F"
                Me.TextBox76.Text = "0.00"
            End If
        End If

        Me.Three_2st_MarkInformation()
    End Sub

    'Islam Religion
    Private Sub TextBox62_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox62.TextChanged
        If ComboBox3.Text = "Islam Religion" Then
            If Me.TextBox62.Text = "" Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox62.Text) >= 0 And Val(TextBox62.Text) <= 100 Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox62.Text) >= 101 And Val(TextBox62.Text) <= 100000 Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Islam Religion Creative Marks")
                Me.TextBox62.Text = ""
            Else
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox3.Text = "Hindu Religion" Then
            If Me.TextBox62.Text = "" Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox62.Text) >= 0 And Val(TextBox62.Text) <= 100 Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox62.Text) >= 101 And Val(TextBox62.Text) <= 100000 Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Hindu Religion Creative Marks")
                Me.TextBox62.Text = ""
            Else
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox3.Text = "Christian Religion" Then
            If Me.TextBox62.Text = "" Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox62.Text) >= 0 And Val(TextBox62.Text) <= 100 Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox62.Text) >= 101 And Val(TextBox62.Text) <= 100000 Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Christian Religion Creative Marks")
                Me.TextBox62.Text = ""
            Else
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox3.Text = "Buddhist Religion" Then
            If Me.TextBox62.Text = "" Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox62.Text) >= 0 And Val(TextBox62.Text) <= 100 Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox62.Text) >= 101 And Val(TextBox62.Text) <= 100000 Then
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Buddhist Religion Creative Marks")
                Me.TextBox62.Text = ""
            Else
                Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox62.Text = "" Then
            Me.TextBox71.Text = "F"
            Me.TextBox74.Text = "0.00"
        End If

        'Islam Religion
        If IsNumeric(TextBox62.Text) Then
            If Val(TextBox62.Text) >= 80 And Val(TextBox62.Text) <= 100 Then
                Me.TextBox71.Text = "A+"
                Me.TextBox74.Text = "5.00"
            ElseIf Val(TextBox62.Text) >= 70 And Val(TextBox62.Text) <= 79 Then
                Me.TextBox71.Text = "A"
                Me.TextBox74.Text = "4.00"
            ElseIf Val(TextBox62.Text) >= 60 And Val(TextBox62.Text) <= 69 Then
                Me.TextBox71.Text = "A-"
                Me.TextBox74.Text = "3.50"
            ElseIf Val(TextBox62.Text) >= 50 And Val(TextBox62.Text) <= 59 Then
                Me.TextBox71.Text = "B"
                Me.TextBox74.Text = "3.00"
            ElseIf Val(TextBox62.Text) >= 40 And Val(TextBox62.Text) <= 49 Then
                Me.TextBox71.Text = "C"
                Me.TextBox74.Text = "2.00"
            ElseIf Val(TextBox62.Text) >= 32 And Val(TextBox62.Text) <= 39 Then
                Me.TextBox71.Text = "D"
                Me.TextBox74.Text = "1.00"
            Else
                Me.TextBox71.Text = "F"
                Me.TextBox74.Text = "0.00"
            End If
        End If

        Me.Three_2st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox47_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox47.TextChanged
        If IsNumeric(TextBox47.Text) Then
            If Val(TextBox47.Text) > 4.99 Then
                Me.TextBox50.Text = "A+"
            ElseIf Val(TextBox47.Text) > 3.99 Then
                Me.TextBox50.Text = "A"
            ElseIf Val(TextBox47.Text) > 3.49 Then
                Me.TextBox50.Text = "A-"
            ElseIf Val(TextBox47.Text) > 2.99 Then
                Me.TextBox50.Text = "B"
            ElseIf Val(TextBox47.Text) > 1.99 Then
                Me.TextBox50.Text = "C"
            ElseIf Val(TextBox47.Text) > 0.99 Then
                Me.TextBox50.Text = "D"
            Else
                Me.TextBox50.Text = "F"
            End If
        End If

        If IsNumeric(TextBox47.Text) Then
            If Val(TextBox47.Text) >= 4.99 And Val(TextBox47.Text) <= 100000 Then
                TextBox47.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'Bangla
        If TextBox45.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox45.Select()

            'English For Today
        ElseIf TextBox44.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox44.Select()

            'Mathematics
        ElseIf TextBox58.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox58.Select()

            'Bangladesh and Global Studies
        ElseIf TextBox60.Text = "" Then
            MessageBox.Show("Input ''Bangladesh and Global Studies Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox60.Select()

            'Science
        ElseIf TextBox61.Text = "" Then
            MessageBox.Show("Input ''Science Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox61.Select()

            'Islam and Moral Education
        ElseIf TextBox62.Text = "" Then
            If ComboBox3.Text = "Islam Religion" Then
                MessageBox.Show("Input ''Islam Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox3.Text = "Hindu Religion" Then
                MessageBox.Show("Input ''Hindu Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox3.Text = "Christian Religion" Then
                MessageBox.Show("Input ''Christian Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox3.Text = "Buddhist Religion" Then
                MessageBox.Show("Input ''Buddhist Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox62.Select()

        Else
            '
            '
            MessageBox.Show("Four Second Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button67.Click
        'Bangla
        Me.TextBox45.Clear()
        Me.TextBox59.Clear()
        Me.TextBox57.Clear()

        'English for Today
        Me.TextBox44.Clear()
        Me.TextBox55.Clear()
        Me.TextBox56.Clear()

        'Mathematics
        Me.TextBox58.Clear()
        Me.TextBox66.Clear()
        Me.TextBox549.Clear()

        'Bangladesh and Global Studies
        Me.TextBox60.Clear()
        Me.TextBox67.Clear()
        Me.TextBox78.Clear()

        'Science
        Me.TextBox61.Clear()
        Me.TextBox69.Clear()
        Me.TextBox76.Clear()

        'Islam amd moral Education
        Me.TextBox62.Clear()
        Me.TextBox71.Clear()
        Me.TextBox74.Clear()

        'Result Information
        Me.TextBox49.Clear()
        Me.TextBox48.Clear()
        Me.TextBox50.Clear()
        Me.TextBox47.Clear()
        Me.TextBox46.Clear()

        'PIC Box
        Me.PictureBox31.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox30.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox29.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox28.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox27.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox26.Image = Global.Student_Data_Managements.My.Resources.NO_Pic

        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    ''Button Back
    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button66.Click

    End Sub

    'Button Next
    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button65.Click

    End Sub



    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    'Class Five 1st

    'Marks Information
    Private Sub Five_1st_MarkInformation()

        'Total Mark
        Me.TextBox1027.Text = Val(TextBox274.Text) + Val(TextBox130.Text) + Val(TextBox1032.Text) + Val(TextBox1034.Text) + Val(TextBox1035.Text) + Val(TextBox1036.Text)

        'Average
        Me.TextBox1026.Text = Format(((Val(TextBox274.Text) + Val(TextBox130.Text) + Val(TextBox1032.Text) + Val(TextBox1034.Text) + Val(TextBox1035.Text) + Val(TextBox1036.Text)) / 6), "0.00")

        'GPA
        Me.TextBox1025.Text = Format(((Val(TextBox1031.Text) + Val(TextBox1030.Text) + Val(TextBox1044.Text) + Val(TextBox1043.Text) + Val(TextBox1042.Text) + Val(TextBox1041.Text)) / 6), "0.00")
        Me.TextBox1024.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox274.Text) Then
            If Val(TextBox274.Text) >= 0 And Val(TextBox274.Text) <= 32 Then
                Me.TextBox1033.Text = "F"
                Me.TextBox1031.Text = "0.00"
                Me.TextBox1027.Clear()
                Me.TextBox1026.Clear()
                Me.TextBox1028.Clear()
                Me.TextBox1025.Clear()
                Me.TextBox1024.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox130.Text) Then
            If Val(TextBox130.Text) >= 0 And Val(TextBox130.Text) <= 32 Then
                Me.TextBox1029.Text = "F"
                Me.TextBox1030.Text = "0.00"
                Me.TextBox1027.Clear()
                Me.TextBox1026.Clear()
                Me.TextBox1028.Clear()
                Me.TextBox1025.Clear()
                Me.TextBox1024.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox1032.Text) Then
            If Val(TextBox1032.Text) >= 0 And Val(TextBox1032.Text) <= 32 Then
                Me.TextBox1037.Text = "F"
                Me.TextBox1044.Text = "0.00"
                Me.TextBox1027.Clear()
                Me.TextBox1026.Clear()
                Me.TextBox1028.Clear()
                Me.TextBox1025.Clear()
                Me.TextBox1024.Text = "Fail"
            End If
        End If

        'Bangladesh And Global Studies
        If IsNumeric(TextBox1034.Text) Then
            If Val(TextBox1034.Text) >= 0 And Val(TextBox1034.Text) <= 32 Then
                Me.TextBox1038.Text = "F"
                Me.TextBox1043.Text = "0.00"
                Me.TextBox1027.Clear()
                Me.TextBox1026.Clear()
                Me.TextBox1028.Clear()
                Me.TextBox1025.Clear()
                Me.TextBox1024.Text = "Fail"
            End If
        End If

        'Science
        If IsNumeric(TextBox1035.Text) Then
            If Val(TextBox1035.Text) >= 0 And Val(TextBox1035.Text) <= 32 Then
                Me.TextBox1039.Text = "F"
                Me.TextBox1042.Text = "0.00"
                Me.TextBox1027.Clear()
                Me.TextBox1026.Clear()
                Me.TextBox1028.Clear()
                Me.TextBox1025.Clear()
                Me.TextBox1024.Text = "Fail"
            End If
        End If


        'Islam Religion
        If IsNumeric(TextBox1036.Text) Then
            If Val(TextBox1036.Text) >= 0 And Val(TextBox1036.Text) <= 32 Then
                Me.TextBox1040.Text = "F"
                Me.TextBox1041.Text = "0.00"
                Me.TextBox1027.Clear()
                Me.TextBox1026.Clear()
                Me.TextBox1028.Clear()
                Me.TextBox1025.Clear()
                Me.TextBox1024.Text = "Fail"
            End If
        End If


        'Timar

        'Bangla
        If Me.TextBox274.Text = "" Then
            Me.TextBox1027.Clear()
            Me.TextBox1026.Clear()
            Me.TextBox1028.Clear()
            Me.TextBox1025.Clear()
            Me.TextBox1024.Text = "Fail"
        End If

        'English
        If Me.TextBox130.Text = "" Then
            Me.TextBox1027.Clear()
            Me.TextBox1026.Clear()
            Me.TextBox1028.Clear()
            Me.TextBox1025.Clear()
            Me.TextBox1024.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox1032.Text = "" Then
            Me.TextBox1027.Clear()
            Me.TextBox1026.Clear()
            Me.TextBox1028.Clear()
            Me.TextBox1025.Clear()
            Me.TextBox1024.Text = "Fail"
        End If

        'Bangladesh and Global Studies
        If Me.TextBox1034.Text = "" Then
            Me.TextBox1027.Clear()
            Me.TextBox1026.Clear()
            Me.TextBox1028.Clear()
            Me.TextBox1025.Clear()
            Me.TextBox1024.Text = "Fail"
        End If

        'Science
        If Me.TextBox1035.Text = "" Then
            Me.TextBox1027.Clear()
            Me.TextBox1026.Clear()
            Me.TextBox1028.Clear()
            Me.TextBox1025.Clear()
            Me.TextBox1024.Text = "Fail"
        End If

        'Islam and moral Education
        If Me.TextBox1036.Text = "" Then
            Me.TextBox1027.Clear()
            Me.TextBox1026.Clear()
            Me.TextBox1028.Clear()
            Me.TextBox1025.Clear()
            Me.TextBox1024.Text = "Fail"
        End If
    End Sub

    'Chech Box
    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            Me.TextBox1070.Enabled = True
            Me.TextBox1071.Enabled = True
        ElseIf CheckBox14.Checked = False Then
            Me.TextBox1070.Enabled = False
            Me.TextBox1071.Enabled = False

            Me.TextBox1070.Clear()
            Me.TextBox1071.Clear()
        End If
    End Sub

    'Combo Box
    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Me.Label170.Text = ComboBox5.Text
    End Sub

    'Bangla
    Private Sub TextBox274_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox274.TextChanged
        If Me.TextBox274.Text = "" Then
            Me.PictureBox37.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox274.Text) >= 0 And Val(TextBox274.Text) <= 100 Then
            Me.PictureBox37.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox274.Text) >= 101 And Val(TextBox274.Text) <= 100000 Then
            Me.PictureBox37.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox274.Text = ""
        Else
            Me.PictureBox37.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox274.Text = "" Then
            Me.TextBox1033.Text = "F"
            Me.TextBox1031.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox274.Text) Then
            If Val(TextBox274.Text) >= 80 And Val(TextBox274.Text) <= 100 Then
                Me.TextBox1033.Text = "A+"
                Me.TextBox1031.Text = "5.00"
            ElseIf Val(TextBox274.Text) >= 70 And Val(TextBox274.Text) <= 79 Then
                Me.TextBox1033.Text = "A"
                Me.TextBox1031.Text = "4.00"
            ElseIf Val(TextBox274.Text) >= 60 And Val(TextBox274.Text) <= 69 Then
                Me.TextBox1033.Text = "A-"
                Me.TextBox1031.Text = "3.50"
            ElseIf Val(TextBox274.Text) >= 50 And Val(TextBox274.Text) <= 59 Then
                Me.TextBox1033.Text = "B"
                Me.TextBox1031.Text = "3.00"
            ElseIf Val(TextBox274.Text) >= 40 And Val(TextBox274.Text) <= 49 Then
                Me.TextBox1033.Text = "C"
                Me.TextBox1031.Text = "2.00"
            ElseIf Val(TextBox274.Text) >= 32 And Val(TextBox274.Text) <= 39 Then
                Me.TextBox1033.Text = "D"
                Me.TextBox1031.Text = "1.00"
            Else
                Me.TextBox1033.Text = "F"
                Me.TextBox1031.Text = "0.00"
            End If
        End If
        Me.Five_1st_MarkInformation()
    End Sub

    'English
    Private Sub TextBox130_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox130.TextChanged
        If Me.TextBox130.Text = "" Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox130.Text) >= 0 And Val(TextBox130.Text) <= 100 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox130.Text) >= 101 And Val(TextBox130.Text) <= 100000 Then
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox130.Text = ""
        Else
            Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox130.Text = "" Then
            Me.TextBox1029.Text = "F"
            Me.TextBox1030.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox130.Text) Then
            If Val(TextBox130.Text) >= 80 And Val(TextBox130.Text) <= 100 Then
                Me.TextBox1029.Text = "A+"
                Me.TextBox1030.Text = "5.00"
            ElseIf Val(TextBox130.Text) >= 70 And Val(TextBox130.Text) <= 79 Then
                Me.TextBox1029.Text = "A"
                Me.TextBox1030.Text = "4.00"
            ElseIf Val(TextBox130.Text) >= 60 And Val(TextBox130.Text) <= 69 Then
                Me.TextBox1029.Text = "A-"
                Me.TextBox1030.Text = "3.50"
            ElseIf Val(TextBox130.Text) >= 50 And Val(TextBox130.Text) <= 59 Then
                Me.TextBox1029.Text = "B"
                Me.TextBox1030.Text = "3.00"
            ElseIf Val(TextBox130.Text) >= 40 And Val(TextBox130.Text) <= 49 Then
                Me.TextBox1029.Text = "C"
                Me.TextBox1030.Text = "2.00"
            ElseIf Val(TextBox130.Text) >= 32 And Val(TextBox130.Text) <= 39 Then
                Me.TextBox1029.Text = "D"
                Me.TextBox1030.Text = "1.00"
            Else
                Me.TextBox1029.Text = "F"
                Me.TextBox1030.Text = "0.00"
            End If
        End If
        Me.Five_1st_MarkInformation()
    End Sub

    'Mathmatics
    Private Sub TextBox1032_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1032.TextChanged
        If Me.TextBox1032.Text = "" Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox1032.Text) >= 0 And Val(TextBox1032.Text) <= 100 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox1032.Text) >= 101 And Val(TextBox1032.Text) <= 100000 Then
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox1032.Text = ""
        Else
            Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox1032.Text = "" Then
            Me.TextBox1037.Text = "F"
            Me.TextBox1044.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox1032.Text) Then
            If Val(TextBox1032.Text) >= 80 And Val(TextBox1032.Text) <= 100 Then
                Me.TextBox1037.Text = "A+"
                Me.TextBox1044.Text = "5.00"
            ElseIf Val(TextBox1032.Text) >= 70 And Val(TextBox1032.Text) <= 79 Then
                Me.TextBox1037.Text = "A"
                Me.TextBox1044.Text = "4.00"
            ElseIf Val(TextBox1032.Text) >= 60 And Val(TextBox1032.Text) <= 69 Then
                Me.TextBox1037.Text = "A-"
                Me.TextBox1044.Text = "3.50"
            ElseIf Val(TextBox1032.Text) >= 50 And Val(TextBox1032.Text) <= 59 Then
                Me.TextBox1037.Text = "B"
                Me.TextBox1044.Text = "3.00"
            ElseIf Val(TextBox1032.Text) >= 40 And Val(TextBox1032.Text) <= 49 Then
                Me.TextBox1037.Text = "C"
                Me.TextBox1044.Text = "2.00"
            ElseIf Val(TextBox1032.Text) >= 32 And Val(TextBox1032.Text) <= 39 Then
                Me.TextBox1037.Text = "D"
                Me.TextBox1044.Text = "1.00"
            Else
                Me.TextBox1037.Text = "F"
                Me.TextBox1044.Text = "0.00"
            End If
        End If

        Me.Five_1st_MarkInformation()
    End Sub

    'Banglidesh amd Global Studies
    Private Sub TextBox1034_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1034.TextChanged
        If Me.TextBox1034.Text = "" Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox1034.Text) >= 0 And Val(TextBox1034.Text) <= 100 Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox1034.Text) >= 101 And Val(TextBox1034.Text) <= 100000 Then
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangladesh and Global Studies Creative Marks")
            Me.TextBox1034.Text = ""
        Else
            Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox1034.Text = "" Then
            Me.TextBox1038.Text = "F"
            Me.TextBox1043.Text = "0.00"
        End If

        'Bangladesh and Global Studies 100
        If IsNumeric(TextBox1034.Text) Then
            If Val(TextBox1034.Text) >= 80 And Val(TextBox1034.Text) <= 100 Then
                Me.TextBox1038.Text = "A+"
                Me.TextBox1043.Text = "5.00"
            ElseIf Val(TextBox1034.Text) >= 70 And Val(TextBox1034.Text) <= 79 Then
                Me.TextBox1038.Text = "A"
                Me.TextBox1043.Text = "4.00"
            ElseIf Val(TextBox1034.Text) >= 60 And Val(TextBox1034.Text) <= 69 Then
                Me.TextBox1038.Text = "A-"
                Me.TextBox1043.Text = "3.50"
            ElseIf Val(TextBox1034.Text) >= 50 And Val(TextBox1034.Text) <= 59 Then
                Me.TextBox1038.Text = "B"
                Me.TextBox1043.Text = "3.00"
            ElseIf Val(TextBox1034.Text) >= 40 And Val(TextBox1034.Text) <= 49 Then
                Me.TextBox1038.Text = "C"
                Me.TextBox1043.Text = "2.00"
            ElseIf Val(TextBox1034.Text) >= 32 And Val(TextBox1034.Text) <= 39 Then
                Me.TextBox1038.Text = "D"
                Me.TextBox1043.Text = "1.00"
            Else
                Me.TextBox1038.Text = "F"
                Me.TextBox1043.Text = "0.00"
            End If
        End If

        Me.Five_1st_MarkInformation()
    End Sub

    'Science
    Private Sub TextBox1035_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1035.TextChanged
        If Me.TextBox1035.Text = "" Then
            Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox1035.Text) >= 0 And Val(TextBox1035.Text) <= 100 Then
            Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox1035.Text) >= 101 And Val(TextBox1035.Text) <= 100000 Then
            Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Science Creative Marks")
            Me.TextBox1035.Text = ""
        Else
            Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox1035.Text = "" Then
            Me.TextBox1039.Text = "F"
            Me.TextBox1042.Text = "0.00"
        End If

        'Science 100
        If IsNumeric(TextBox1035.Text) Then
            If Val(TextBox1035.Text) >= 80 And Val(TextBox1035.Text) <= 100 Then
                Me.TextBox1039.Text = "A+"
                Me.TextBox1042.Text = "5.00"
            ElseIf Val(TextBox1035.Text) >= 70 And Val(TextBox1035.Text) <= 79 Then
                Me.TextBox1039.Text = "A"
                Me.TextBox1042.Text = "4.00"
            ElseIf Val(TextBox1035.Text) >= 60 And Val(TextBox1035.Text) <= 69 Then
                Me.TextBox1039.Text = "A-"
                Me.TextBox1042.Text = "3.50"
            ElseIf Val(TextBox1035.Text) >= 50 And Val(TextBox1035.Text) <= 59 Then
                Me.TextBox1039.Text = "B"
                Me.TextBox1042.Text = "3.00"
            ElseIf Val(TextBox1035.Text) >= 40 And Val(TextBox1035.Text) <= 49 Then
                Me.TextBox1039.Text = "C"
                Me.TextBox1042.Text = "2.00"
            ElseIf Val(TextBox1035.Text) >= 32 And Val(TextBox1035.Text) <= 39 Then
                Me.TextBox1039.Text = "D"
                Me.TextBox1042.Text = "1.00"
            Else
                Me.TextBox1039.Text = "F"
                Me.TextBox1042.Text = "0.00"
            End If
        End If

        Me.Five_1st_MarkInformation()
    End Sub

    'Islam Religion
    Private Sub TextBox1036_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1036.TextChanged
        If ComboBox5.Text = "Islam Religion" Then
            If Me.TextBox1036.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1036.Text) >= 0 And Val(TextBox1036.Text) <= 100 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1036.Text) >= 101 And Val(TextBox1036.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Islam Religion Creative Marks")
                Me.TextBox1036.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox5.Text = "Hindu Religion" Then
            If Me.TextBox1036.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1036.Text) >= 0 And Val(TextBox1036.Text) <= 100 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1036.Text) >= 101 And Val(TextBox1036.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Hindu Religion Creative Marks")
                Me.TextBox1036.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox5.Text = "Christian Religion" Then
            If Me.TextBox1036.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1036.Text) >= 0 And Val(TextBox1036.Text) <= 100 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1036.Text) >= 101 And Val(TextBox1036.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Christian Religion Creative Marks")
                Me.TextBox1036.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox5.Text = "Buddhist Religion" Then
            If Me.TextBox1036.Text = "" Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1036.Text) >= 0 And Val(TextBox1036.Text) <= 100 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1036.Text) >= 101 And Val(TextBox1036.Text) <= 100000 Then
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Buddhist Religion Creative Marks")
                Me.TextBox1036.Text = ""
            Else
                Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox1036.Text = "" Then
            Me.TextBox1040.Text = "F"
            Me.TextBox1041.Text = "0.00"
        End If

        'Islam Religion
        If IsNumeric(TextBox1036.Text) Then
            If Val(TextBox1036.Text) >= 80 And Val(TextBox1036.Text) <= 100 Then
                Me.TextBox1040.Text = "A+"
                Me.TextBox1041.Text = "5.00"
            ElseIf Val(TextBox1036.Text) >= 70 And Val(TextBox1036.Text) <= 79 Then
                Me.TextBox1040.Text = "A"
                Me.TextBox1041.Text = "4.00"
            ElseIf Val(TextBox1036.Text) >= 60 And Val(TextBox1036.Text) <= 69 Then
                Me.TextBox1040.Text = "A-"
                Me.TextBox1041.Text = "3.50"
            ElseIf Val(TextBox1036.Text) >= 50 And Val(TextBox1036.Text) <= 59 Then
                Me.TextBox1040.Text = "B"
                Me.TextBox1041.Text = "3.00"
            ElseIf Val(TextBox1036.Text) >= 40 And Val(TextBox1036.Text) <= 49 Then
                Me.TextBox1040.Text = "C"
                Me.TextBox1041.Text = "2.00"
            ElseIf Val(TextBox1036.Text) >= 32 And Val(TextBox1036.Text) <= 39 Then
                Me.TextBox1040.Text = "D"
                Me.TextBox1041.Text = "1.00"
            Else
                Me.TextBox1040.Text = "F"
                Me.TextBox1041.Text = "0.00"
            End If
        End If

        Me.Five_1st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox1025_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1025.TextChanged
        If IsNumeric(TextBox1025.Text) Then
            If Val(TextBox1025.Text) > 4.99 Then
                Me.TextBox1028.Text = "A+"
            ElseIf Val(TextBox1025.Text) > 3.99 Then
                Me.TextBox1028.Text = "A"
            ElseIf Val(TextBox1025.Text) > 3.49 Then
                Me.TextBox1028.Text = "A-"
            ElseIf Val(TextBox1025.Text) > 2.99 Then
                Me.TextBox1028.Text = "B"
            ElseIf Val(TextBox1025.Text) > 1.99 Then
                Me.TextBox1028.Text = "C"
            ElseIf Val(TextBox1025.Text) > 0.99 Then
                Me.TextBox1028.Text = "D"
            Else
                Me.TextBox1028.Text = "F"
            End If
        End If

        If IsNumeric(TextBox1025.Text) Then
            If Val(TextBox1025.Text) >= 4.99 And Val(TextBox1025.Text) <= 100000 Then
                TextBox1025.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        'Bangla
        If TextBox274.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox274.Select()

            'English For Today
        ElseIf TextBox130.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox130.Select()

            'Mathematics
        ElseIf TextBox1032.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1032.Select()

            'Bangladesh and Global Studies
        ElseIf TextBox1034.Text = "" Then
            MessageBox.Show("Input ''Bangladesh and Global Studies Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1034.Select()

            'Science
        ElseIf TextBox1035.Text = "" Then
            MessageBox.Show("Input ''Science Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1035.Select()

            'Islam and Moral Education
        ElseIf TextBox1036.Text = "" Then
            If ComboBox5.Text = "Islam Religion" Then
                MessageBox.Show("Input ''Islam Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox5.Text = "Hindu Religion" Then
                MessageBox.Show("Input ''Hindu Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox5.Text = "Christian Religion" Then
                MessageBox.Show("Input ''Christian Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox5.Text = "Buddhist Religion" Then
                MessageBox.Show("Input ''Buddhist Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox1036.Select()

        Else
            '
            '
            MessageBox.Show("Four Second Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button76.Click
        'Bangla
        Me.TextBox274.Clear()
        Me.TextBox1033.Clear()
        Me.TextBox1031.Clear()

        'English for Today
        Me.TextBox130.Clear()
        Me.TextBox1029.Clear()
        Me.TextBox1030.Clear()

        'Mathematics
        Me.TextBox1032.Clear()
        Me.TextBox1037.Clear()
        Me.TextBox1044.Clear()

        'Bangladesh and Global Studies
        Me.TextBox1034.Clear()
        Me.TextBox1038.Clear()
        Me.TextBox1043.Clear()

        'Science
        Me.TextBox1035.Clear()
        Me.TextBox1039.Clear()
        Me.TextBox1042.Clear()

        'Islam amd moral Education
        Me.TextBox1036.Clear()
        Me.TextBox1040.Clear()
        Me.TextBox1041.Clear()

        'Result Information
        Me.TextBox1027.Clear()
        Me.TextBox1026.Clear()
        Me.TextBox1028.Clear()
        Me.TextBox1025.Clear()
        Me.TextBox1024.Clear()

        'PIC Box
        Me.PictureBox37.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox36.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox35.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox34.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox33.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox32.Image = Global.Student_Data_Managements.My.Resources.NO_Pic

        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Button Back
    Private Sub Button75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button75.Click

    End Sub

    'Button Next
    Private Sub Button74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button74.Click

    End Sub


    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    'Class Five 2st

    'Marks Information
    Private Sub Five_2st_MarkInformation()

        'Total Mark
        Me.TextBox1050.Text = Val(TextBox1046.Text) + Val(TextBox1045.Text) + Val(TextBox1055.Text) + Val(TextBox1057.Text) + Val(TextBox1058.Text) + Val(TextBox1059.Text)

        'Average
        Me.TextBox1049.Text = Format(((Val(TextBox1046.Text) + Val(TextBox1045.Text) + Val(TextBox1055.Text) + Val(TextBox1057.Text) + Val(TextBox1058.Text) + Val(TextBox1059.Text)) / 6), "0.00")

        'GPA
        Me.TextBox1048.Text = Format(((Val(TextBox1054.Text) + Val(TextBox1053.Text) + Val(TextBox1067.Text) + Val(TextBox1066.Text) + Val(TextBox1065.Text) + Val(TextBox1064.Text)) / 6), "0.00")
        Me.TextBox1047.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox1046.Text) Then
            If Val(TextBox1046.Text) >= 0 And Val(TextBox1046.Text) <= 32 Then
                Me.TextBox1056.Text = "F"
                Me.TextBox1054.Text = "0.00"
                Me.TextBox1050.Clear()
                Me.TextBox1049.Clear()
                Me.TextBox1051.Clear()
                Me.TextBox1048.Clear()
                Me.TextBox1047.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox1045.Text) Then
            If Val(TextBox1045.Text) >= 0 And Val(TextBox1045.Text) <= 32 Then
                Me.TextBox1052.Text = "F"
                Me.TextBox1053.Text = "0.00"
                Me.TextBox1050.Clear()
                Me.TextBox1049.Clear()
                Me.TextBox1051.Clear()
                Me.TextBox1048.Clear()
                Me.TextBox1047.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox1055.Text) Then
            If Val(TextBox1055.Text) >= 0 And Val(TextBox1055.Text) <= 32 Then
                Me.TextBox1060.Text = "F"
                Me.TextBox1067.Text = "0.00"
                Me.TextBox1050.Clear()
                Me.TextBox1049.Clear()
                Me.TextBox1051.Clear()
                Me.TextBox1048.Clear()
                Me.TextBox1047.Text = "Fail"
            End If
        End If

        'Bangladesh And Global Studies
        If IsNumeric(TextBox1057.Text) Then
            If Val(TextBox1057.Text) >= 0 And Val(TextBox1057.Text) <= 32 Then
                Me.TextBox1061.Text = "F"
                Me.TextBox1066.Text = "0.00"
                Me.TextBox1050.Clear()
                Me.TextBox1049.Clear()
                Me.TextBox1051.Clear()
                Me.TextBox1048.Clear()
                Me.TextBox1047.Text = "Fail"
            End If
        End If

        'Science
        If IsNumeric(TextBox1058.Text) Then
            If Val(TextBox1058.Text) >= 0 And Val(TextBox1058.Text) <= 32 Then
                Me.TextBox1062.Text = "F"
                Me.TextBox1065.Text = "0.00"
                Me.TextBox1050.Clear()
                Me.TextBox1049.Clear()
                Me.TextBox1051.Clear()
                Me.TextBox1048.Clear()
                Me.TextBox1047.Text = "Fail"
            End If
        End If


        'Islam Religion
        If IsNumeric(TextBox1059.Text) Then
            If Val(TextBox1059.Text) >= 0 And Val(TextBox1059.Text) <= 32 Then
                Me.TextBox1063.Text = "F"
                Me.TextBox1064.Text = "0.00"
                Me.TextBox1050.Clear()
                Me.TextBox1049.Clear()
                Me.TextBox1051.Clear()
                Me.TextBox1048.Clear()
                Me.TextBox1047.Text = "Fail"
            End If
        End If


        'Timar

        'Bangla
        If Me.TextBox1046.Text = "" Then
            Me.TextBox1050.Clear()
            Me.TextBox1049.Clear()
            Me.TextBox1051.Clear()
            Me.TextBox1048.Clear()
            Me.TextBox1047.Text = "Fail"
        End If

        'English
        If Me.TextBox1045.Text = "" Then
            Me.TextBox1050.Clear()
            Me.TextBox1049.Clear()
            Me.TextBox1051.Clear()
            Me.TextBox1048.Clear()
            Me.TextBox1047.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox1055.Text = "" Then
            Me.TextBox1050.Clear()
            Me.TextBox1049.Clear()
            Me.TextBox1051.Clear()
            Me.TextBox1048.Clear()
            Me.TextBox1047.Text = "Fail"
        End If

        'Bangladesh and Global Studies
        If Me.TextBox1057.Text = "" Then
            Me.TextBox1050.Clear()
            Me.TextBox1049.Clear()
            Me.TextBox1051.Clear()
            Me.TextBox1048.Clear()
            Me.TextBox1047.Text = "Fail"
        End If

        'Science
        If Me.TextBox1058.Text = "" Then
            Me.TextBox1050.Clear()
            Me.TextBox1049.Clear()
            Me.TextBox1051.Clear()
            Me.TextBox1048.Clear()
            Me.TextBox1047.Text = "Fail"
        End If

        'Islam and moral Education
        If Me.TextBox1059.Text = "" Then
            Me.TextBox1050.Clear()
            Me.TextBox1049.Clear()
            Me.TextBox1051.Clear()
            Me.TextBox1048.Clear()
            Me.TextBox1047.Text = "Fail"
        End If
    End Sub

    'Check Box
    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            Me.TextBox1068.Enabled = True
            Me.TextBox1069.Enabled = True
        ElseIf CheckBox13.Checked = False Then
            Me.TextBox1068.Enabled = False
            Me.TextBox1069.Enabled = False

            Me.TextBox1068.Clear()
            Me.TextBox1069.Clear()
        End If
    End Sub

    'Bangla
    Private Sub TextBox1046_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1046.TextChanged
        If Me.TextBox1046.Text = "" Then
            Me.PictureBox43.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox1046.Text) >= 0 And Val(TextBox1046.Text) <= 100 Then
            Me.PictureBox43.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox1046.Text) >= 101 And Val(TextBox1046.Text) <= 100000 Then
            Me.PictureBox43.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox1046.Text = ""
        Else
            Me.PictureBox43.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox1046.Text = "" Then
            Me.TextBox1056.Text = "F"
            Me.TextBox1054.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox1046.Text) Then
            If Val(TextBox1046.Text) >= 80 And Val(TextBox1046.Text) <= 100 Then
                Me.TextBox1056.Text = "A+"
                Me.TextBox1054.Text = "5.00"
            ElseIf Val(TextBox1046.Text) >= 70 And Val(TextBox1046.Text) <= 79 Then
                Me.TextBox1056.Text = "A"
                Me.TextBox1054.Text = "4.00"
            ElseIf Val(TextBox1046.Text) >= 60 And Val(TextBox1046.Text) <= 69 Then
                Me.TextBox1056.Text = "A-"
                Me.TextBox1054.Text = "3.50"
            ElseIf Val(TextBox1046.Text) >= 50 And Val(TextBox1046.Text) <= 59 Then
                Me.TextBox1056.Text = "B"
                Me.TextBox1054.Text = "3.00"
            ElseIf Val(TextBox1046.Text) >= 40 And Val(TextBox1046.Text) <= 49 Then
                Me.TextBox1056.Text = "C"
                Me.TextBox1054.Text = "2.00"
            ElseIf Val(TextBox1046.Text) >= 32 And Val(TextBox1046.Text) <= 39 Then
                Me.TextBox1056.Text = "D"
                Me.TextBox1054.Text = "1.00"
            Else
                Me.TextBox1056.Text = "F"
                Me.TextBox1054.Text = "0.00"
            End If
        End If
        Me.Five_2st_MarkInformation()
    End Sub

    'English
    Private Sub TextBox1045_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1045.TextChanged
        If Me.TextBox1045.Text = "" Then
            Me.PictureBox42.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox1045.Text) >= 0 And Val(TextBox1045.Text) <= 100 Then
            Me.PictureBox42.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox1045.Text) >= 101 And Val(TextBox1045.Text) <= 100000 Then
            Me.PictureBox42.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox1045.Text = ""
        Else
            Me.PictureBox42.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox1045.Text = "" Then
            Me.TextBox1052.Text = "F"
            Me.TextBox1053.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox1045.Text) Then
            If Val(TextBox1045.Text) >= 80 And Val(TextBox1045.Text) <= 100 Then
                Me.TextBox1052.Text = "A+"
                Me.TextBox1053.Text = "5.00"
            ElseIf Val(TextBox1045.Text) >= 70 And Val(TextBox1045.Text) <= 79 Then
                Me.TextBox1052.Text = "A"
                Me.TextBox1053.Text = "4.00"
            ElseIf Val(TextBox1045.Text) >= 60 And Val(TextBox1045.Text) <= 69 Then
                Me.TextBox1052.Text = "A-"
                Me.TextBox1053.Text = "3.50"
            ElseIf Val(TextBox1045.Text) >= 50 And Val(TextBox1045.Text) <= 59 Then
                Me.TextBox1052.Text = "B"
                Me.TextBox1053.Text = "3.00"
            ElseIf Val(TextBox1045.Text) >= 40 And Val(TextBox1045.Text) <= 49 Then
                Me.TextBox1052.Text = "C"
                Me.TextBox1053.Text = "2.00"
            ElseIf Val(TextBox1045.Text) >= 32 And Val(TextBox1045.Text) <= 39 Then
                Me.TextBox1052.Text = "D"
                Me.TextBox1053.Text = "1.00"
            Else
                Me.TextBox1052.Text = "F"
                Me.TextBox1053.Text = "0.00"
            End If
        End If
        Me.Five_2st_MarkInformation()
    End Sub

    'Mathematics
    Private Sub TextBox1055_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1055.TextChanged
        If Me.TextBox1055.Text = "" Then
            Me.PictureBox41.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox1055.Text) >= 0 And Val(TextBox1055.Text) <= 100 Then
            Me.PictureBox41.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox1055.Text) >= 101 And Val(TextBox1055.Text) <= 100000 Then
            Me.PictureBox41.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox1055.Text = ""
        Else
            Me.PictureBox41.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox1055.Text = "" Then
            Me.TextBox1060.Text = "F"
            Me.TextBox1067.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox1055.Text) Then
            If Val(TextBox1055.Text) >= 80 And Val(TextBox1055.Text) <= 100 Then
                Me.TextBox1060.Text = "A+"
                Me.TextBox1067.Text = "5.00"
            ElseIf Val(TextBox1055.Text) >= 70 And Val(TextBox1055.Text) <= 79 Then
                Me.TextBox1060.Text = "A"
                Me.TextBox1067.Text = "4.00"
            ElseIf Val(TextBox1055.Text) >= 60 And Val(TextBox1055.Text) <= 69 Then
                Me.TextBox1060.Text = "A-"
                Me.TextBox1067.Text = "3.50"
            ElseIf Val(TextBox1055.Text) >= 50 And Val(TextBox1055.Text) <= 59 Then
                Me.TextBox1060.Text = "B"
                Me.TextBox1067.Text = "3.00"
            ElseIf Val(TextBox1055.Text) >= 40 And Val(TextBox1055.Text) <= 49 Then
                Me.TextBox1060.Text = "C"
                Me.TextBox1067.Text = "2.00"
            ElseIf Val(TextBox1055.Text) >= 32 And Val(TextBox1055.Text) <= 39 Then
                Me.TextBox1060.Text = "D"
                Me.TextBox1067.Text = "1.00"
            Else
                Me.TextBox1060.Text = "F"
                Me.TextBox1067.Text = "0.00"
            End If
        End If

        Me.Five_2st_MarkInformation()
    End Sub

    'Bangladesh and Global Studies
    Private Sub TextBox1057_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1057.TextChanged
        If Me.TextBox1057.Text = "" Then
            Me.PictureBox40.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox1057.Text) >= 0 And Val(TextBox1057.Text) <= 100 Then
            Me.PictureBox40.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox1057.Text) >= 101 And Val(TextBox1057.Text) <= 100000 Then
            Me.PictureBox40.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangladesh and Global Studies Creative Marks")
            Me.TextBox1057.Text = ""
        Else
            Me.PictureBox40.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox1057.Text = "" Then
            Me.TextBox1061.Text = "F"
            Me.TextBox1066.Text = "0.00"
        End If

        'Bangladesh and Global Studies 100
        If IsNumeric(TextBox1057.Text) Then
            If Val(TextBox1057.Text) >= 80 And Val(TextBox1057.Text) <= 100 Then
                Me.TextBox1061.Text = "A+"
                Me.TextBox1066.Text = "5.00"
            ElseIf Val(TextBox1057.Text) >= 70 And Val(TextBox1057.Text) <= 79 Then
                Me.TextBox1061.Text = "A"
                Me.TextBox1066.Text = "4.00"
            ElseIf Val(TextBox1057.Text) >= 60 And Val(TextBox1057.Text) <= 69 Then
                Me.TextBox1061.Text = "A-"
                Me.TextBox1066.Text = "3.50"
            ElseIf Val(TextBox1057.Text) >= 50 And Val(TextBox1057.Text) <= 59 Then
                Me.TextBox1061.Text = "B"
                Me.TextBox1066.Text = "3.00"
            ElseIf Val(TextBox1057.Text) >= 40 And Val(TextBox1057.Text) <= 49 Then
                Me.TextBox1061.Text = "C"
                Me.TextBox1066.Text = "2.00"
            ElseIf Val(TextBox1057.Text) >= 32 And Val(TextBox1057.Text) <= 39 Then
                Me.TextBox1061.Text = "D"
                Me.TextBox1066.Text = "1.00"
            Else
                Me.TextBox1061.Text = "F"
                Me.TextBox1066.Text = "0.00"
            End If
        End If

        Me.Five_2st_MarkInformation()
    End Sub

    'Science
    Private Sub TextBox1058_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1058.TextChanged
        If Me.TextBox1058.Text = "" Then
            Me.PictureBox39.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox1058.Text) >= 0 And Val(TextBox1058.Text) <= 100 Then
            Me.PictureBox39.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox1058.Text) >= 101 And Val(TextBox1058.Text) <= 100000 Then
            Me.PictureBox39.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Science Creative Marks")
            Me.TextBox1058.Text = ""
        Else
            Me.PictureBox39.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox1058.Text = "" Then
            Me.TextBox1062.Text = "F"
            Me.TextBox1065.Text = "0.00"
        End If

        'Science 100
        If IsNumeric(TextBox1058.Text) Then
            If Val(TextBox1058.Text) >= 80 And Val(TextBox1058.Text) <= 100 Then
                Me.TextBox1062.Text = "A+"
                Me.TextBox1065.Text = "5.00"
            ElseIf Val(TextBox1058.Text) >= 70 And Val(TextBox1058.Text) <= 79 Then
                Me.TextBox1062.Text = "A"
                Me.TextBox1065.Text = "4.00"
            ElseIf Val(TextBox1058.Text) >= 60 And Val(TextBox1058.Text) <= 69 Then
                Me.TextBox1062.Text = "A-"
                Me.TextBox1065.Text = "3.50"
            ElseIf Val(TextBox1058.Text) >= 50 And Val(TextBox1058.Text) <= 59 Then
                Me.TextBox1062.Text = "B"
                Me.TextBox1065.Text = "3.00"
            ElseIf Val(TextBox1058.Text) >= 40 And Val(TextBox1058.Text) <= 49 Then
                Me.TextBox1062.Text = "C"
                Me.TextBox1065.Text = "2.00"
            ElseIf Val(TextBox1058.Text) >= 32 And Val(TextBox1058.Text) <= 39 Then
                Me.TextBox1062.Text = "D"
                Me.TextBox1065.Text = "1.00"
            Else
                Me.TextBox1062.Text = "F"
                Me.TextBox1065.Text = "0.00"
            End If
        End If

        Me.Five_2st_MarkInformation()
    End Sub

    'Islam Religion
    Private Sub TextBox1059_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1059.TextChanged
        If ComboBox5.Text = "Islam Religion" Then
            If Me.TextBox1059.Text = "" Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1059.Text) >= 0 And Val(TextBox1059.Text) <= 100 Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1059.Text) >= 101 And Val(TextBox1059.Text) <= 100000 Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Islam Religion Creative Marks")
                Me.TextBox1059.Text = ""
            Else
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox5.Text = "Hindu Religion" Then
            If Me.TextBox1059.Text = "" Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1059.Text) >= 0 And Val(TextBox1059.Text) <= 100 Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1059.Text) >= 101 And Val(TextBox1059.Text) <= 100000 Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Hindu Religion Creative Marks")
                Me.TextBox1059.Text = ""
            Else
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox5.Text = "Christian Religion" Then
            If Me.TextBox1059.Text = "" Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1059.Text) >= 0 And Val(TextBox1059.Text) <= 100 Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1059.Text) >= 101 And Val(TextBox1059.Text) <= 100000 Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Christian Religion Creative Marks")
                Me.TextBox1059.Text = ""
            Else
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If

        ElseIf ComboBox5.Text = "Buddhist Religion" Then
            If Me.TextBox1059.Text = "" Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
            ElseIf Val(TextBox1059.Text) >= 0 And Val(TextBox1059.Text) <= 100 Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
            ElseIf Val(TextBox1059.Text) >= 101 And Val(TextBox1059.Text) <= 100000 Then
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
                MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Buddhist Religion Creative Marks")
                Me.TextBox1059.Text = ""
            Else
                Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            End If
        End If

        If Me.TextBox1059.Text = "" Then
            Me.TextBox1063.Text = "F"
            Me.TextBox1064.Text = "0.00"
        End If

        'Islam Religion
        If IsNumeric(TextBox1059.Text) Then
            If Val(TextBox1059.Text) >= 80 And Val(TextBox1059.Text) <= 100 Then
                Me.TextBox1063.Text = "A+"
                Me.TextBox1064.Text = "5.00"
            ElseIf Val(TextBox1059.Text) >= 70 And Val(TextBox1059.Text) <= 79 Then
                Me.TextBox1063.Text = "A"
                Me.TextBox1064.Text = "4.00"
            ElseIf Val(TextBox1059.Text) >= 60 And Val(TextBox1059.Text) <= 69 Then
                Me.TextBox1063.Text = "A-"
                Me.TextBox1064.Text = "3.50"
            ElseIf Val(TextBox1059.Text) >= 50 And Val(TextBox1059.Text) <= 59 Then
                Me.TextBox1063.Text = "B"
                Me.TextBox1064.Text = "3.00"
            ElseIf Val(TextBox1059.Text) >= 40 And Val(TextBox1059.Text) <= 49 Then
                Me.TextBox1063.Text = "C"
                Me.TextBox1064.Text = "2.00"
            ElseIf Val(TextBox1059.Text) >= 32 And Val(TextBox1059.Text) <= 39 Then
                Me.TextBox1063.Text = "D"
                Me.TextBox1064.Text = "1.00"
            Else
                Me.TextBox1063.Text = "F"
                Me.TextBox1064.Text = "0.00"
            End If
        End If

        Me.Five_2st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox1048_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1048.TextChanged
        If IsNumeric(TextBox1048.Text) Then
            If Val(TextBox1048.Text) > 4.99 Then
                Me.TextBox1051.Text = "A+"
            ElseIf Val(TextBox1048.Text) > 3.99 Then
                Me.TextBox1051.Text = "A"
            ElseIf Val(TextBox1048.Text) > 3.49 Then
                Me.TextBox1051.Text = "A-"
            ElseIf Val(TextBox1048.Text) > 2.99 Then
                Me.TextBox1051.Text = "B"
            ElseIf Val(TextBox1048.Text) > 1.99 Then
                Me.TextBox1051.Text = "C"
            ElseIf Val(TextBox1048.Text) > 0.99 Then
                Me.TextBox1051.Text = "D"
            Else
                Me.TextBox1051.Text = "F"
            End If
        End If

        If IsNumeric(TextBox1048.Text) Then
            If Val(TextBox1048.Text) >= 4.99 And Val(TextBox1048.Text) <= 100000 Then
                TextBox1048.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        'Bangla
        If TextBox1046.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1046.Select()

            'English For Today
        ElseIf TextBox1045.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1045.Select()

            'Mathematics
        ElseIf TextBox1055.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1055.Select()

            'Bangladesh and Global Studies
        ElseIf TextBox1057.Text = "" Then
            MessageBox.Show("Input ''Bangladesh and Global Studies Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1057.Select()

            'Science
        ElseIf TextBox1058.Text = "" Then
            MessageBox.Show("Input ''Science Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox1058.Select()

            'Islam and Moral Education
        ElseIf TextBox1059.Text = "" Then
            If ComboBox5.Text = "Islam Religion" Then
                MessageBox.Show("Input ''Islam Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox5.Text = "Hindu Religion" Then
                MessageBox.Show("Input ''Hindu Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox5.Text = "Christian Religion" Then
                MessageBox.Show("Input ''Christian Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ComboBox5.Text = "Buddhist Religion" Then
                MessageBox.Show("Input ''Buddhist Religion Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.TextBox1059.Select()

        Else
            '
            '
            MessageBox.Show("Four Second Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button79.Click
        'Bangla
        Me.TextBox1046.Clear()
        Me.TextBox1056.Clear()
        Me.TextBox1054.Clear()

        'English for Today
        Me.TextBox1045.Clear()
        Me.TextBox1052.Clear()
        Me.TextBox1053.Clear()

        'Mathematics
        Me.TextBox1055.Clear()
        Me.TextBox1060.Clear()
        Me.TextBox1067.Clear()

        'Bangladesh and Global Studies
        Me.TextBox1057.Clear()
        Me.TextBox1061.Clear()
        Me.TextBox1066.Clear()

        'Science
        Me.TextBox1058.Clear()
        Me.TextBox1062.Clear()
        Me.TextBox1065.Clear()

        'Islam amd moral Education
        Me.TextBox1059.Clear()
        Me.TextBox1063.Clear()
        Me.TextBox1064.Clear()

        'Result Information
        Me.TextBox1050.Clear()
        Me.TextBox1049.Clear()
        Me.TextBox1051.Clear()
        Me.TextBox1048.Clear()
        Me.TextBox1047.Clear()

        'PIC Box
        Me.PictureBox43.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox42.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox41.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox40.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox39.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox38.Image = Global.Student_Data_Managements.My.Resources.NO_Pic

        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Button Back
    Private Sub Button78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button78.Click

    End Sub

    'Button Next
    Private Sub Button77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button77.Click

    End Sub



    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    'Class One 1st

    'Marks Information
    Private Sub One_1st_MarkInformation()

        'Total Mark
        Me.TextBox31.Text = Val(TextBox34.Text) + Val(TextBox42.Text) + Val(TextBox65.Text)

        'Average
        Me.TextBox29.Text = Format(((Val(TextBox34.Text) + Val(TextBox42.Text) + Val(TextBox65.Text)) / 3), "0.00")

        'GPA
        Me.TextBox27.Text = Format(((Val(TextBox64.Text) + Val(TextBox63.Text) + Val(TextBox103.Text)) / 3), "0.00")
        Me.TextBox24.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox34.Text) Then
            If Val(TextBox34.Text) >= 0 And Val(TextBox34.Text) <= 32 Then
                Me.TextBox68.Text = "F"
                Me.TextBox64.Text = "0.00"
                Me.TextBox31.Clear()
                Me.TextBox29.Clear()
                Me.TextBox32.Clear()
                Me.TextBox27.Clear()
                Me.TextBox24.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox42.Text) Then
            If Val(TextBox42.Text) >= 0 And Val(TextBox42.Text) <= 32 Then
                Me.TextBox43.Text = "F"
                Me.TextBox63.Text = "0.00"
                Me.TextBox31.Clear()
                Me.TextBox29.Clear()
                Me.TextBox32.Clear()
                Me.TextBox27.Clear()
                Me.TextBox24.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox65.Text) Then
            If Val(TextBox65.Text) >= 0 And Val(TextBox65.Text) <= 32 Then
                Me.TextBox75.Text = "F"
                Me.TextBox103.Text = "0.00"
                Me.TextBox31.Clear()
                Me.TextBox29.Clear()
                Me.TextBox32.Clear()
                Me.TextBox27.Clear()
                Me.TextBox24.Text = "Fail"
            End If
        End If

        'Timar

        'Bangla
        If Me.TextBox34.Text = "" Then
            Me.TextBox31.Clear()
            Me.TextBox29.Clear()
            Me.TextBox32.Clear()
            Me.TextBox27.Clear()
            Me.TextBox24.Text = "Fail"
        End If

        'English
        If Me.TextBox42.Text = "" Then
            Me.TextBox31.Clear()
            Me.TextBox29.Clear()
            Me.TextBox32.Clear()
            Me.TextBox27.Clear()
            Me.TextBox24.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox65.Text = "" Then
            Me.TextBox31.Clear()
            Me.TextBox29.Clear()
            Me.TextBox32.Clear()
            Me.TextBox27.Clear()
            Me.TextBox24.Text = "Fail"
        End If

    End Sub

    'CheckBox
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Me.TextBox106.Enabled = True
            Me.TextBox108.Enabled = True
        ElseIf CheckBox5.Checked = False Then
            Me.TextBox106.Enabled = False
            Me.TextBox108.Enabled = False

            Me.TextBox106.Clear()
            Me.TextBox108.Clear()
        End If
    End Sub

    'Bangla
    Private Sub TextBox34_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox34.TextChanged
        If Me.TextBox34.Text = "" Then
            Me.PictureBox4.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox34.Text) >= 0 And Val(TextBox34.Text) <= 100 Then
            Me.PictureBox4.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox34.Text) >= 101 And Val(TextBox34.Text) <= 100000 Then
            Me.PictureBox4.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox34.Text = ""
        Else
            Me.PictureBox4.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox34.Text = "" Then
            Me.TextBox68.Text = "F"
            Me.TextBox64.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox34.Text) Then
            If Val(TextBox34.Text) >= 80 And Val(TextBox34.Text) <= 100 Then
                Me.TextBox68.Text = "A+"
                Me.TextBox64.Text = "5.00"
            ElseIf Val(TextBox34.Text) >= 70 And Val(TextBox34.Text) <= 79 Then
                Me.TextBox68.Text = "A"
                Me.TextBox64.Text = "4.00"
            ElseIf Val(TextBox34.Text) >= 60 And Val(TextBox34.Text) <= 69 Then
                Me.TextBox68.Text = "A-"
                Me.TextBox64.Text = "3.50"
            ElseIf Val(TextBox34.Text) >= 50 And Val(TextBox34.Text) <= 59 Then
                Me.TextBox68.Text = "B"
                Me.TextBox64.Text = "3.00"
            ElseIf Val(TextBox34.Text) >= 40 And Val(TextBox34.Text) <= 49 Then
                Me.TextBox68.Text = "C"
                Me.TextBox64.Text = "2.00"
            ElseIf Val(TextBox34.Text) >= 32 And Val(TextBox34.Text) <= 39 Then
                Me.TextBox68.Text = "D"
                Me.TextBox64.Text = "1.00"
            Else
                Me.TextBox68.Text = "F"
                Me.TextBox64.Text = "0.00"
            End If
        End If
        Me.One_1st_MarkInformation()
    End Sub

    'English
    Private Sub TextBox42_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox42.TextChanged
        If Me.TextBox42.Text = "" Then
            Me.PictureBox2.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox42.Text) >= 0 And Val(TextBox42.Text) <= 100 Then
            Me.PictureBox2.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox42.Text) >= 101 And Val(TextBox42.Text) <= 100000 Then
            Me.PictureBox2.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox42.Text = ""
        Else
            Me.PictureBox2.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox42.Text = "" Then
            Me.TextBox43.Text = "F"
            Me.TextBox63.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox42.Text) Then
            If Val(TextBox42.Text) >= 80 And Val(TextBox42.Text) <= 100 Then
                Me.TextBox43.Text = "A+"
                Me.TextBox63.Text = "5.00"
            ElseIf Val(TextBox42.Text) >= 70 And Val(TextBox42.Text) <= 79 Then
                Me.TextBox43.Text = "A"
                Me.TextBox63.Text = "4.00"
            ElseIf Val(TextBox42.Text) >= 60 And Val(TextBox42.Text) <= 69 Then
                Me.TextBox43.Text = "A-"
                Me.TextBox63.Text = "3.50"
            ElseIf Val(TextBox42.Text) >= 50 And Val(TextBox42.Text) <= 59 Then
                Me.TextBox43.Text = "B"
                Me.TextBox63.Text = "3.00"
            ElseIf Val(TextBox42.Text) >= 40 And Val(TextBox42.Text) <= 49 Then
                Me.TextBox43.Text = "C"
                Me.TextBox63.Text = "2.00"
            ElseIf Val(TextBox42.Text) >= 32 And Val(TextBox42.Text) <= 39 Then
                Me.TextBox43.Text = "D"
                Me.TextBox63.Text = "1.00"
            Else
                Me.TextBox43.Text = "F"
                Me.TextBox63.Text = "0.00"
            End If
        End If
        Me.One_1st_MarkInformation()
    End Sub

    'Mathemotics
    Private Sub TextBox65_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox65.TextChanged
        If Me.TextBox65.Text = "" Then
            Me.PictureBox3.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox65.Text) >= 0 And Val(TextBox65.Text) <= 100 Then
            Me.PictureBox3.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox65.Text) >= 101 And Val(TextBox65.Text) <= 100000 Then
            Me.PictureBox3.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox65.Text = ""
        Else
            Me.PictureBox3.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox65.Text = "" Then
            Me.TextBox75.Text = "F"
            Me.TextBox103.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox65.Text) Then
            If Val(TextBox65.Text) >= 80 And Val(TextBox65.Text) <= 100 Then
                Me.TextBox75.Text = "A+"
                Me.TextBox103.Text = "5.00"
            ElseIf Val(TextBox65.Text) >= 70 And Val(TextBox65.Text) <= 79 Then
                Me.TextBox75.Text = "A"
                Me.TextBox103.Text = "4.00"
            ElseIf Val(TextBox65.Text) >= 60 And Val(TextBox65.Text) <= 69 Then
                Me.TextBox75.Text = "A-"
                Me.TextBox103.Text = "3.50"
            ElseIf Val(TextBox65.Text) >= 50 And Val(TextBox65.Text) <= 59 Then
                Me.TextBox75.Text = "B"
                Me.TextBox103.Text = "3.00"
            ElseIf Val(TextBox65.Text) >= 40 And Val(TextBox65.Text) <= 49 Then
                Me.TextBox75.Text = "C"
                Me.TextBox103.Text = "2.00"
            ElseIf Val(TextBox65.Text) >= 32 And Val(TextBox65.Text) <= 39 Then
                Me.TextBox75.Text = "D"
                Me.TextBox103.Text = "1.00"
            Else
                Me.TextBox75.Text = "F"
                Me.TextBox103.Text = "0.00"
            End If
        End If

        Me.One_1st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox27_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox27.TextChanged
        If IsNumeric(TextBox27.Text) Then
            If Val(TextBox27.Text) > 4.99 Then
                Me.TextBox32.Text = "A+"
            ElseIf Val(TextBox27.Text) > 3.99 Then
                Me.TextBox32.Text = "A"
            ElseIf Val(TextBox27.Text) > 3.49 Then
                Me.TextBox32.Text = "A-"
            ElseIf Val(TextBox27.Text) > 2.99 Then
                Me.TextBox32.Text = "B"
            ElseIf Val(TextBox27.Text) > 1.99 Then
                Me.TextBox32.Text = "C"
            ElseIf Val(TextBox27.Text) > 0.99 Then
                Me.TextBox32.Text = "D"
            Else
                Me.TextBox32.Text = "F"
            End If
        End If

        If IsNumeric(TextBox27.Text) Then
            If Val(TextBox27.Text) >= 4.99 And Val(TextBox27.Text) <= 100000 Then
                TextBox27.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        'Bangla
        If TextBox34.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox34.Select()

            'English For Today
        ElseIf TextBox42.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox42.Select()

            'Mathematics
        ElseIf TextBox65.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox65.Select()

        Else
            '
            '
            MessageBox.Show(" One First Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        'Bangla
        Me.TextBox34.Clear()
        Me.TextBox68.Clear()
        Me.TextBox64.Clear()

        'English for Today
        Me.TextBox42.Clear()
        Me.TextBox43.Clear()
        Me.TextBox63.Clear()

        'Mathematics
        Me.TextBox65.Clear()
        Me.TextBox75.Clear()
        Me.TextBox103.Clear()

        'Result Information
        Me.TextBox31.Clear()
        Me.TextBox29.Clear()
        Me.TextBox32.Clear()
        Me.TextBox27.Clear()
        Me.TextBox24.Clear()

        'PIC Box
        Me.PictureBox4.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox2.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox3.Image = Global.Student_Data_Managements.My.Resources.NO_Pic


        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Button Back
    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click

    End Sub

    'Button Next
    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click

    End Sub

    '-----------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------

    'Class One 2st

    'Marks Information
    Private Sub One_2st_MarkInformation()

        'Total Mark
        Me.TextBox41.Text = Val(TextBox72.Text) + Val(TextBox73.Text) + Val(TextBox81.Text)

        'Average
        Me.TextBox36.Text = Format(((Val(TextBox72.Text) + Val(TextBox73.Text) + Val(TextBox81.Text)) / 3), "0.00")

        'GPA
        Me.TextBox23.Text = Format(((Val(TextBox80.Text) + Val(TextBox79.Text) + Val(TextBox110.Text)) / 3), "0.00")
        Me.TextBox22.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox72.Text) Then
            If Val(TextBox72.Text) >= 0 And Val(TextBox72.Text) <= 32 Then
                Me.TextBox101.Text = "F"
                Me.TextBox80.Text = "0.00"
                Me.TextBox41.Clear()
                Me.TextBox36.Clear()
                Me.TextBox70.Clear()
                Me.TextBox23.Clear()
                Me.TextBox22.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox73.Text) Then
            If Val(TextBox73.Text) >= 0 And Val(TextBox73.Text) <= 32 Then
                Me.TextBox77.Text = "F"
                Me.TextBox79.Text = "0.00"
                Me.TextBox41.Clear()
                Me.TextBox36.Clear()
                Me.TextBox70.Clear()
                Me.TextBox23.Clear()
                Me.TextBox22.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox81.Text) Then
            If Val(TextBox81.Text) >= 0 And Val(TextBox81.Text) <= 32 Then
                Me.TextBox102.Text = "F"
                Me.TextBox110.Text = "0.00"
                Me.TextBox41.Clear()
                Me.TextBox36.Clear()
                Me.TextBox70.Clear()
                Me.TextBox23.Clear()
                Me.TextBox22.Text = "Fail"
            End If
        End If

        'Timar

        'Bangla
        If Me.TextBox72.Text = "" Then
            Me.TextBox41.Clear()
            Me.TextBox36.Clear()
            Me.TextBox70.Clear()
            Me.TextBox23.Clear()
            Me.TextBox22.Text = "Fail"
        End If

        'English
        If Me.TextBox73.Text = "" Then
            Me.TextBox41.Clear()
            Me.TextBox36.Clear()
            Me.TextBox70.Clear()
            Me.TextBox23.Clear()
            Me.TextBox22.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox81.Text = "" Then
            Me.TextBox41.Clear()
            Me.TextBox36.Clear()
            Me.TextBox70.Clear()
            Me.TextBox23.Clear()
            Me.TextBox22.Text = "Fail"
        End If

    End Sub

    'Check Box
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Me.TextBox111.Enabled = True
            Me.TextBox113.Enabled = True
        ElseIf CheckBox6.Checked = False Then
            Me.TextBox111.Enabled = False
            Me.TextBox113.Enabled = False

            Me.TextBox111.Clear()
            Me.TextBox113.Clear()
        End If
    End Sub

    'Bangla
    Private Sub TextBox72_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox72.TextChanged
        If Me.TextBox72.Text = "" Then
            Me.PictureBox7.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox72.Text) >= 0 And Val(TextBox72.Text) <= 100 Then
            Me.PictureBox7.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox72.Text) >= 101 And Val(TextBox72.Text) <= 100000 Then
            Me.PictureBox7.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox72.Text = ""
        Else
            Me.PictureBox7.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox72.Text = "" Then
            Me.TextBox101.Text = "F"
            Me.TextBox80.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox72.Text) Then
            If Val(TextBox72.Text) >= 80 And Val(TextBox72.Text) <= 100 Then
                Me.TextBox101.Text = "A+"
                Me.TextBox80.Text = "5.00"
            ElseIf Val(TextBox72.Text) >= 70 And Val(TextBox72.Text) <= 79 Then
                Me.TextBox101.Text = "A"
                Me.TextBox80.Text = "4.00"
            ElseIf Val(TextBox72.Text) >= 60 And Val(TextBox72.Text) <= 69 Then
                Me.TextBox101.Text = "A-"
                Me.TextBox80.Text = "3.50"
            ElseIf Val(TextBox72.Text) >= 50 And Val(TextBox72.Text) <= 59 Then
                Me.TextBox101.Text = "B"
                Me.TextBox80.Text = "3.00"
            ElseIf Val(TextBox72.Text) >= 40 And Val(TextBox72.Text) <= 49 Then
                Me.TextBox101.Text = "C"
                Me.TextBox80.Text = "2.00"
            ElseIf Val(TextBox72.Text) >= 32 And Val(TextBox72.Text) <= 39 Then
                Me.TextBox101.Text = "D"
                Me.TextBox80.Text = "1.00"
            Else
                Me.TextBox101.Text = "F"
                Me.TextBox80.Text = "0.00"
            End If
        End If
        Me.One_2st_MarkInformation()
    End Sub

    'English
    Private Sub TextBox73_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox73.TextChanged
        If Me.TextBox73.Text = "" Then
            Me.PictureBox6.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox73.Text) >= 0 And Val(TextBox73.Text) <= 100 Then
            Me.PictureBox6.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox73.Text) >= 101 And Val(TextBox73.Text) <= 100000 Then
            Me.PictureBox6.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox73.Text = ""
        Else
            Me.PictureBox6.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox73.Text = "" Then
            Me.TextBox77.Text = "F"
            Me.TextBox79.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox73.Text) Then
            If Val(TextBox73.Text) >= 80 And Val(TextBox73.Text) <= 100 Then
                Me.TextBox77.Text = "A+"
                Me.TextBox79.Text = "5.00"
            ElseIf Val(TextBox73.Text) >= 70 And Val(TextBox73.Text) <= 79 Then
                Me.TextBox77.Text = "A"
                Me.TextBox79.Text = "4.00"
            ElseIf Val(TextBox73.Text) >= 60 And Val(TextBox73.Text) <= 69 Then
                Me.TextBox77.Text = "A-"
                Me.TextBox79.Text = "3.50"
            ElseIf Val(TextBox73.Text) >= 50 And Val(TextBox73.Text) <= 59 Then
                Me.TextBox77.Text = "B"
                Me.TextBox79.Text = "3.00"
            ElseIf Val(TextBox73.Text) >= 40 And Val(TextBox73.Text) <= 49 Then
                Me.TextBox77.Text = "C"
                Me.TextBox79.Text = "2.00"
            ElseIf Val(TextBox73.Text) >= 32 And Val(TextBox73.Text) <= 39 Then
                Me.TextBox77.Text = "D"
                Me.TextBox79.Text = "1.00"
            Else
                Me.TextBox77.Text = "F"
                Me.TextBox79.Text = "0.00"
            End If
        End If
        Me.One_2st_MarkInformation()
    End Sub

    'Mathematics
    Private Sub TextBox81_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox81.TextChanged
        If Me.TextBox81.Text = "" Then
            Me.PictureBox5.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox81.Text) >= 0 And Val(TextBox81.Text) <= 100 Then
            Me.PictureBox5.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox81.Text) >= 101 And Val(TextBox81.Text) <= 100000 Then
            Me.PictureBox5.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox81.Text = ""
        Else
            Me.PictureBox5.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox81.Text = "" Then
            Me.TextBox102.Text = "F"
            Me.TextBox110.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox81.Text) Then
            If Val(TextBox81.Text) >= 80 And Val(TextBox81.Text) <= 100 Then
                Me.TextBox102.Text = "A+"
                Me.TextBox110.Text = "5.00"
            ElseIf Val(TextBox81.Text) >= 70 And Val(TextBox81.Text) <= 79 Then
                Me.TextBox102.Text = "A"
                Me.TextBox110.Text = "4.00"
            ElseIf Val(TextBox81.Text) >= 60 And Val(TextBox81.Text) <= 69 Then
                Me.TextBox102.Text = "A-"
                Me.TextBox110.Text = "3.50"
            ElseIf Val(TextBox81.Text) >= 50 And Val(TextBox81.Text) <= 59 Then
                Me.TextBox102.Text = "B"
                Me.TextBox110.Text = "3.00"
            ElseIf Val(TextBox81.Text) >= 40 And Val(TextBox81.Text) <= 49 Then
                Me.TextBox102.Text = "C"
                Me.TextBox110.Text = "2.00"
            ElseIf Val(TextBox81.Text) >= 32 And Val(TextBox81.Text) <= 39 Then
                Me.TextBox102.Text = "D"
                Me.TextBox110.Text = "1.00"
            Else
                Me.TextBox102.Text = "F"
                Me.TextBox110.Text = "0.00"
            End If
        End If

        Me.One_2st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox23.TextChanged
        If IsNumeric(TextBox23.Text) Then
            If Val(TextBox23.Text) > 4.99 Then
                Me.TextBox70.Text = "A+"
            ElseIf Val(TextBox23.Text) > 3.99 Then
                Me.TextBox70.Text = "A"
            ElseIf Val(TextBox23.Text) > 3.49 Then
                Me.TextBox70.Text = "A-"
            ElseIf Val(TextBox23.Text) > 2.99 Then
                Me.TextBox70.Text = "B"
            ElseIf Val(TextBox23.Text) > 1.99 Then
                Me.TextBox70.Text = "C"
            ElseIf Val(TextBox23.Text) > 0.99 Then
                Me.TextBox70.Text = "D"
            Else
                Me.TextBox70.Text = "F"
            End If
        End If

        If IsNumeric(TextBox23.Text) Then
            If Val(TextBox23.Text) >= 4.99 And Val(TextBox23.Text) <= 100000 Then
                TextBox23.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        'Bangla
        If TextBox72.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox72.Select()

            'English For Today
        ElseIf TextBox73.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox73.Select()

            'Mathematics
        ElseIf TextBox81.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox81.Select()

        Else
            '
            '
            MessageBox.Show(" One First Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear 
    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'Bangla
        Me.TextBox72.Clear()
        Me.TextBox101.Clear()
        Me.TextBox80.Clear()

        'English for Today
        Me.TextBox73.Clear()
        Me.TextBox77.Clear()
        Me.TextBox79.Clear()

        'Mathematics
        Me.TextBox81.Clear()
        Me.TextBox102.Clear()
        Me.TextBox110.Clear()

        'Result Information
        Me.TextBox41.Clear()
        Me.TextBox36.Clear()
        Me.TextBox70.Clear()
        Me.TextBox23.Clear()
        Me.TextBox22.Clear()


        'PIC Box
        Me.PictureBox7.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox6.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox5.Image = Global.Student_Data_Managements.My.Resources.NO_Pic


        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Button Back

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

    End Sub

    'Button Next
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub



    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    'Class Two 1st

    'Marks Information
    Private Sub Two_1st_MarkInformation()

        'Total Mark
        Me.TextBox119.Text = Val(TextBox140.Text) + Val(TextBox141.Text) + Val(TextBox149.Text)

        'Average
        Me.TextBox118.Text = Format(((Val(TextBox140.Text) + Val(TextBox141.Text) + Val(TextBox149.Text)) / 3), "0.00")

        'GPA
        Me.TextBox117.Text = Format(((Val(TextBox148.Text) + Val(TextBox146.Text) + Val(TextBox546.Text)) / 3), "0.00")
        Me.TextBox115.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox140.Text) Then
            If Val(TextBox140.Text) >= 0 And Val(TextBox140.Text) <= 32 Then
                Me.TextBox151.Text = "F"
                Me.TextBox148.Text = "0.00"
                Me.TextBox119.Clear()
                Me.TextBox118.Clear()
                Me.TextBox139.Clear()
                Me.TextBox117.Clear()
                Me.TextBox115.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox141.Text) Then
            If Val(TextBox141.Text) >= 0 And Val(TextBox141.Text) <= 32 Then
                Me.TextBox144.Text = "F"
                Me.TextBox146.Text = "0.00"
                Me.TextBox119.Clear()
                Me.TextBox118.Clear()
                Me.TextBox139.Clear()
                Me.TextBox117.Clear()
                Me.TextBox115.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox149.Text) Then
            If Val(TextBox149.Text) >= 0 And Val(TextBox149.Text) <= 32 Then
                Me.TextBox153.Text = "F"
                Me.TextBox546.Text = "0.00"
                Me.TextBox119.Clear()
                Me.TextBox118.Clear()
                Me.TextBox139.Clear()
                Me.TextBox117.Clear()
                Me.TextBox115.Text = "Fail"
            End If
        End If

        'Timar

        'Bangla
        If Me.TextBox140.Text = "" Then
            Me.TextBox119.Clear()
            Me.TextBox118.Clear()
            Me.TextBox139.Clear()
            Me.TextBox117.Clear()
            Me.TextBox115.Text = "Fail"
        End If

        'English
        If Me.TextBox141.Text = "" Then
            Me.TextBox119.Clear()
            Me.TextBox118.Clear()
            Me.TextBox139.Clear()
            Me.TextBox117.Clear()
            Me.TextBox115.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox149.Text = "" Then
            Me.TextBox119.Clear()
            Me.TextBox118.Clear()
            Me.TextBox139.Clear()
            Me.TextBox117.Clear()
            Me.TextBox115.Text = "Fail"
        End If

    End Sub

    'Check Box
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Me.TextBox547.Enabled = True
            Me.TextBox548.Enabled = True
        ElseIf CheckBox7.Checked = False Then
            Me.TextBox547.Enabled = False
            Me.TextBox548.Enabled = False

            Me.TextBox547.Clear()
            Me.TextBox548.Clear()
        End If
    End Sub

    'Bangla
    Private Sub TextBox140_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox140.TextChanged
        If Me.TextBox140.Text = "" Then
            Me.PictureBox46.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox140.Text) >= 0 And Val(TextBox140.Text) <= 100 Then
            Me.PictureBox46.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox140.Text) >= 101 And Val(TextBox140.Text) <= 100000 Then
            Me.PictureBox46.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox140.Text = ""
        Else
            Me.PictureBox46.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox140.Text = "" Then
            Me.TextBox151.Text = "F"
            Me.TextBox148.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox140.Text) Then
            If Val(TextBox140.Text) >= 80 And Val(TextBox140.Text) <= 100 Then
                Me.TextBox151.Text = "A+"
                Me.TextBox148.Text = "5.00"
            ElseIf Val(TextBox140.Text) >= 70 And Val(TextBox140.Text) <= 79 Then
                Me.TextBox151.Text = "A"
                Me.TextBox148.Text = "4.00"
            ElseIf Val(TextBox140.Text) >= 60 And Val(TextBox140.Text) <= 69 Then
                Me.TextBox151.Text = "A-"
                Me.TextBox148.Text = "3.50"
            ElseIf Val(TextBox140.Text) >= 50 And Val(TextBox140.Text) <= 59 Then
                Me.TextBox151.Text = "B"
                Me.TextBox148.Text = "3.00"
            ElseIf Val(TextBox140.Text) >= 40 And Val(TextBox140.Text) <= 49 Then
                Me.TextBox151.Text = "C"
                Me.TextBox148.Text = "2.00"
            ElseIf Val(TextBox140.Text) >= 32 And Val(TextBox140.Text) <= 39 Then
                Me.TextBox151.Text = "D"
                Me.TextBox148.Text = "1.00"
            Else
                Me.TextBox151.Text = "F"
                Me.TextBox148.Text = "0.00"
            End If
        End If
        Me.Two_1st_MarkInformation()
    End Sub

    'English
    Private Sub TextBox141_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox141.TextChanged
        If Me.TextBox141.Text = "" Then
            Me.PictureBox45.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox141.Text) >= 0 And Val(TextBox141.Text) <= 100 Then
            Me.PictureBox45.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox141.Text) >= 101 And Val(TextBox141.Text) <= 100000 Then
            Me.PictureBox45.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox141.Text = ""
        Else
            Me.PictureBox45.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox141.Text = "" Then
            Me.TextBox144.Text = "F"
            Me.TextBox146.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox141.Text) Then
            If Val(TextBox141.Text) >= 80 And Val(TextBox141.Text) <= 100 Then
                Me.TextBox144.Text = "A+"
                Me.TextBox146.Text = "5.00"
            ElseIf Val(TextBox141.Text) >= 70 And Val(TextBox141.Text) <= 79 Then
                Me.TextBox144.Text = "A"
                Me.TextBox146.Text = "4.00"
            ElseIf Val(TextBox141.Text) >= 60 And Val(TextBox141.Text) <= 69 Then
                Me.TextBox144.Text = "A-"
                Me.TextBox146.Text = "3.50"
            ElseIf Val(TextBox141.Text) >= 50 And Val(TextBox141.Text) <= 59 Then
                Me.TextBox144.Text = "B"
                Me.TextBox146.Text = "3.00"
            ElseIf Val(TextBox141.Text) >= 40 And Val(TextBox141.Text) <= 49 Then
                Me.TextBox144.Text = "C"
                Me.TextBox146.Text = "2.00"
            ElseIf Val(TextBox141.Text) >= 32 And Val(TextBox141.Text) <= 39 Then
                Me.TextBox144.Text = "D"
                Me.TextBox146.Text = "1.00"
            Else
                Me.TextBox144.Text = "F"
                Me.TextBox146.Text = "0.00"
            End If
        End If
        Me.Two_1st_MarkInformation()
    End Sub

    'Mathematics
    Private Sub TextBox149_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox149.TextChanged
        If Me.TextBox149.Text = "" Then
            Me.PictureBox44.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox149.Text) >= 0 And Val(TextBox149.Text) <= 100 Then
            Me.PictureBox44.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox149.Text) >= 101 And Val(TextBox149.Text) <= 100000 Then
            Me.PictureBox44.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox149.Text = ""
        Else
            Me.PictureBox44.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox149.Text = "" Then
            Me.TextBox153.Text = "F"
            Me.TextBox546.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox149.Text) Then
            If Val(TextBox149.Text) >= 80 And Val(TextBox149.Text) <= 100 Then
                Me.TextBox153.Text = "A+"
                Me.TextBox546.Text = "5.00"
            ElseIf Val(TextBox149.Text) >= 70 And Val(TextBox149.Text) <= 79 Then
                Me.TextBox153.Text = "A"
                Me.TextBox546.Text = "4.00"
            ElseIf Val(TextBox149.Text) >= 60 And Val(TextBox149.Text) <= 69 Then
                Me.TextBox153.Text = "A-"
                Me.TextBox546.Text = "3.50"
            ElseIf Val(TextBox149.Text) >= 50 And Val(TextBox149.Text) <= 59 Then
                Me.TextBox153.Text = "B"
                Me.TextBox546.Text = "3.00"
            ElseIf Val(TextBox149.Text) >= 40 And Val(TextBox149.Text) <= 49 Then
                Me.TextBox153.Text = "C"
                Me.TextBox546.Text = "2.00"
            ElseIf Val(TextBox149.Text) >= 32 And Val(TextBox149.Text) <= 39 Then
                Me.TextBox153.Text = "D"
                Me.TextBox546.Text = "1.00"
            Else
                Me.TextBox153.Text = "F"
                Me.TextBox546.Text = "0.00"
            End If
        End If

        Me.Two_1st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox117_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox117.TextChanged
        If IsNumeric(TextBox117.Text) Then
            If Val(TextBox117.Text) > 4.99 Then
                Me.TextBox139.Text = "A+"
            ElseIf Val(TextBox117.Text) > 3.99 Then
                Me.TextBox139.Text = "A"
            ElseIf Val(TextBox117.Text) > 3.49 Then
                Me.TextBox139.Text = "A-"
            ElseIf Val(TextBox117.Text) > 2.99 Then
                Me.TextBox139.Text = "B"
            ElseIf Val(TextBox117.Text) > 1.99 Then
                Me.TextBox139.Text = "C"
            ElseIf Val(TextBox117.Text) > 0.99 Then
                Me.TextBox139.Text = "D"
            Else
                Me.TextBox139.Text = "F"
            End If
        End If

        If IsNumeric(TextBox117.Text) Then
            If Val(TextBox117.Text) >= 4.99 And Val(TextBox117.Text) <= 100000 Then
                TextBox117.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        'Bangla
        If TextBox140.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox140.Select()

            'English For Today
        ElseIf TextBox141.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox141.Select()

            'Mathematics
        ElseIf TextBox149.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox149.Select()

        Else
            '
            '
            MessageBox.Show(" Two First Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        'Bangla
        Me.TextBox140.Clear()
        Me.TextBox151.Clear()
        Me.TextBox148.Clear()

        'English for Today
        Me.TextBox141.Clear()
        Me.TextBox144.Clear()
        Me.TextBox146.Clear()

        'Mathematics
        Me.TextBox149.Clear()
        Me.TextBox153.Clear()
        Me.TextBox546.Clear()

        'Result Information
        Me.TextBox119.Clear()
        Me.TextBox118.Clear()
        Me.TextBox139.Clear()
        Me.TextBox117.Clear()
        Me.TextBox115.Clear()

        'PIC Box
        Me.PictureBox46.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox45.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox44.Image = Global.Student_Data_Managements.My.Resources.NO_Pic


        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Button Back
    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click

    End Sub

    'Button Next
    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click

    End Sub

    '------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------

    'Class Two 2st

    'Marks Information
    Private Sub Two_2st_MarkInformation()

        'Total Mark
        Me.TextBox597.Text = Val(TextBox599.Text) + Val(TextBox600.Text) + Val(TextBox604.Text)

        'Average
        Me.TextBox596.Text = Format(((Val(TextBox599.Text) + Val(TextBox600.Text) + Val(TextBox604.Text)) / 3), "0.00")

        'GPA
        Me.TextBox595.Text = Format(((Val(TextBox603.Text) + Val(TextBox602.Text) + Val(TextBox607.Text)) / 3), "0.00")
        Me.TextBox594.Text = "Pass"

        'Bangla
        If IsNumeric(TextBox599.Text) Then
            If Val(TextBox599.Text) >= 0 And Val(TextBox599.Text) <= 32 Then
                Me.TextBox605.Text = "F"
                Me.TextBox603.Text = "0.00"
                Me.TextBox597.Clear()
                Me.TextBox596.Clear()
                Me.TextBox598.Clear()
                Me.TextBox595.Clear()
                Me.TextBox594.Text = "Fail"
            End If
        End If

        'English
        If IsNumeric(TextBox600.Text) Then
            If Val(TextBox600.Text) >= 0 And Val(TextBox600.Text) <= 32 Then
                Me.TextBox601.Text = "F"
                Me.TextBox602.Text = "0.00"
                Me.TextBox597.Clear()
                Me.TextBox596.Clear()
                Me.TextBox598.Clear()
                Me.TextBox595.Clear()
                Me.TextBox594.Text = "Fail"
            End If
        End If

        'Mathematics
        If IsNumeric(TextBox604.Text) Then
            If Val(TextBox604.Text) >= 0 And Val(TextBox604.Text) <= 32 Then
                Me.TextBox606.Text = "F"
                Me.TextBox607.Text = "0.00"
                Me.TextBox597.Clear()
                Me.TextBox596.Clear()
                Me.TextBox598.Clear()
                Me.TextBox595.Clear()
                Me.TextBox594.Text = "Fail"
            End If
        End If

        'Timar

        'Bangla
        If Me.TextBox599.Text = "" Then
            Me.TextBox597.Clear()
            Me.TextBox596.Clear()
            Me.TextBox598.Clear()
            Me.TextBox595.Clear()
            Me.TextBox594.Text = "Fail"
        End If

        'English
        If Me.TextBox600.Text = "" Then
            Me.TextBox597.Clear()
            Me.TextBox596.Clear()
            Me.TextBox598.Clear()
            Me.TextBox595.Clear()
            Me.TextBox594.Text = "Fail"
        End If

        'Mathematics
        If Me.TextBox604.Text = "" Then
            Me.TextBox597.Clear()
            Me.TextBox596.Clear()
            Me.TextBox598.Clear()
            Me.TextBox595.Clear()
            Me.TextBox594.Text = "Fail"
        End If

    End Sub

    'Check Box
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            Me.TextBox608.Enabled = True
            Me.TextBox609.Enabled = True
        ElseIf CheckBox8.Checked = False Then
            Me.TextBox608.Enabled = False
            Me.TextBox609.Enabled = False

            Me.TextBox608.Clear()
            Me.TextBox609.Clear()
        End If
    End Sub

    'Bangla
    Private Sub TextBox599_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox599.TextChanged
        If Me.TextBox599.Text = "" Then
            Me.PictureBox49.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox599.Text) >= 0 And Val(TextBox599.Text) <= 100 Then
            Me.PictureBox49.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox599.Text) >= 101 And Val(TextBox599.Text) <= 100000 Then
            Me.PictureBox49.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Bangla Creative Marks")
            Me.TextBox599.Text = ""
        Else
            Me.PictureBox49.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox599.Text = "" Then
            Me.TextBox605.Text = "F"
            Me.TextBox603.Text = "0.00"
        End If

        'Bangla 100
        If IsNumeric(TextBox599.Text) Then
            If Val(TextBox599.Text) >= 80 And Val(TextBox599.Text) <= 100 Then
                Me.TextBox605.Text = "A+"
                Me.TextBox603.Text = "5.00"
            ElseIf Val(TextBox599.Text) >= 70 And Val(TextBox599.Text) <= 79 Then
                Me.TextBox605.Text = "A"
                Me.TextBox603.Text = "4.00"
            ElseIf Val(TextBox599.Text) >= 60 And Val(TextBox599.Text) <= 69 Then
                Me.TextBox605.Text = "A-"
                Me.TextBox603.Text = "3.50"
            ElseIf Val(TextBox599.Text) >= 50 And Val(TextBox599.Text) <= 59 Then
                Me.TextBox605.Text = "B"
                Me.TextBox603.Text = "3.00"
            ElseIf Val(TextBox599.Text) >= 40 And Val(TextBox599.Text) <= 49 Then
                Me.TextBox605.Text = "C"
                Me.TextBox603.Text = "2.00"
            ElseIf Val(TextBox599.Text) >= 32 And Val(TextBox599.Text) <= 39 Then
                Me.TextBox605.Text = "D"
                Me.TextBox603.Text = "1.00"
            Else
                Me.TextBox605.Text = "F"
                Me.TextBox603.Text = "0.00"
            End If
        End If
        Me.Two_2st_MarkInformation()
    End Sub

    'English
    Private Sub TextBox600_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox600.TextChanged
        If Me.TextBox600.Text = "" Then
            Me.PictureBox48.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox600.Text) >= 0 And Val(TextBox600.Text) <= 100 Then
            Me.PictureBox48.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox600.Text) >= 101 And Val(TextBox600.Text) <= 100000 Then
            Me.PictureBox48.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "English For Today Creative Marks")
            Me.TextBox600.Text = ""
        Else
            Me.PictureBox48.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox600.Text = "" Then
            Me.TextBox601.Text = "F"
            Me.TextBox602.Text = "0.00"
        End If

        'English 100
        If IsNumeric(TextBox600.Text) Then
            If Val(TextBox600.Text) >= 80 And Val(TextBox600.Text) <= 100 Then
                Me.TextBox601.Text = "A+"
                Me.TextBox602.Text = "5.00"
            ElseIf Val(TextBox600.Text) >= 70 And Val(TextBox600.Text) <= 79 Then
                Me.TextBox601.Text = "A"
                Me.TextBox602.Text = "4.00"
            ElseIf Val(TextBox600.Text) >= 60 And Val(TextBox600.Text) <= 69 Then
                Me.TextBox601.Text = "A-"
                Me.TextBox602.Text = "3.50"
            ElseIf Val(TextBox600.Text) >= 50 And Val(TextBox600.Text) <= 59 Then
                Me.TextBox601.Text = "B"
                Me.TextBox602.Text = "3.00"
            ElseIf Val(TextBox600.Text) >= 40 And Val(TextBox600.Text) <= 49 Then
                Me.TextBox601.Text = "C"
                Me.TextBox602.Text = "2.00"
            ElseIf Val(TextBox600.Text) >= 32 And Val(TextBox600.Text) <= 39 Then
                Me.TextBox601.Text = "D"
                Me.TextBox602.Text = "1.00"
            Else
                Me.TextBox601.Text = "F"
                Me.TextBox602.Text = "0.00"
            End If
        End If
        Me.Two_2st_MarkInformation()
    End Sub

    'Mathematics
    Private Sub TextBox604_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox604.TextChanged
        If Me.TextBox604.Text = "" Then
            Me.PictureBox47.Image = Global.Student_Data_Managements.My.Resources.Normal_Numbar
        ElseIf Val(TextBox604.Text) >= 0 And Val(TextBox604.Text) <= 100 Then
            Me.PictureBox47.Image = Global.Student_Data_Managements.My.Resources.Valide_Numbar
        ElseIf Val(TextBox604.Text) >= 101 And Val(TextBox604.Text) <= 100000 Then
            Me.PictureBox47.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
            MsgBox("Input 0-100 Value", MsgBoxStyle.Critical, "Mathematic Creative Marks")
            Me.TextBox604.Text = ""
        Else
            Me.PictureBox47.Image = Global.Student_Data_Managements.My.Resources.Invalide_Numbar
        End If

        If Me.TextBox604.Text = "" Then
            Me.TextBox606.Text = "F"
            Me.TextBox607.Text = "0.00"
        End If

        'Mathematic 100
        If IsNumeric(TextBox604.Text) Then
            If Val(TextBox604.Text) >= 80 And Val(TextBox604.Text) <= 100 Then
                Me.TextBox606.Text = "A+"
                Me.TextBox607.Text = "5.00"
            ElseIf Val(TextBox604.Text) >= 70 And Val(TextBox604.Text) <= 79 Then
                Me.TextBox606.Text = "A"
                Me.TextBox607.Text = "4.00"
            ElseIf Val(TextBox604.Text) >= 60 And Val(TextBox604.Text) <= 69 Then
                Me.TextBox606.Text = "A-"
                Me.TextBox607.Text = "3.50"
            ElseIf Val(TextBox604.Text) >= 50 And Val(TextBox604.Text) <= 59 Then
                Me.TextBox606.Text = "B"
                Me.TextBox607.Text = "3.00"
            ElseIf Val(TextBox604.Text) >= 40 And Val(TextBox604.Text) <= 49 Then
                Me.TextBox606.Text = "C"
                Me.TextBox607.Text = "2.00"
            ElseIf Val(TextBox604.Text) >= 32 And Val(TextBox604.Text) <= 39 Then
                Me.TextBox606.Text = "D"
                Me.TextBox607.Text = "1.00"
            Else
                Me.TextBox606.Text = "F"
                Me.TextBox607.Text = "0.00"
            End If
        End If

        Me.Two_2st_MarkInformation()
    End Sub

    'GPA
    Private Sub TextBox595_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox595.TextChanged
        If IsNumeric(TextBox595.Text) Then
            If Val(TextBox595.Text) > 4.99 Then
                Me.TextBox598.Text = "A+"
            ElseIf Val(TextBox595.Text) > 3.99 Then
                Me.TextBox598.Text = "A"
            ElseIf Val(TextBox595.Text) > 3.49 Then
                Me.TextBox598.Text = "A-"
            ElseIf Val(TextBox595.Text) > 2.99 Then
                Me.TextBox598.Text = "B"
            ElseIf Val(TextBox595.Text) > 1.99 Then
                Me.TextBox598.Text = "C"
            ElseIf Val(TextBox595.Text) > 0.99 Then
                Me.TextBox598.Text = "D"
            Else
                Me.TextBox598.Text = "F"
            End If
        End If

        If IsNumeric(TextBox595.Text) Then
            If Val(TextBox595.Text) >= 4.99 And Val(TextBox595.Text) <= 100000 Then
                TextBox595.Text = "5.00"
            End If
        End If
    End Sub

    'Button Added
    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        'Bangla
        If TextBox599.Text = "" Then
            MessageBox.Show("Input ''Bangla Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox599.Select()

            'English For Today
        ElseIf TextBox600.Text = "" Then
            MessageBox.Show("Input ''English for Today Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox600.Select()

            'Mathematics
        ElseIf TextBox604.Text = "" Then
            MessageBox.Show("Input ''Mathematics Creative Marks''", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TextBox604.Select()

        Else
            '
            '
            MessageBox.Show(" Two First Terminal Exm Record Saving Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Button Clear
    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click

        'Bangla
        Me.TextBox599.Clear()
        Me.TextBox605.Clear()
        Me.TextBox603.Clear()

        'English for Today
        Me.TextBox600.Clear()
        Me.TextBox601.Clear()
        Me.TextBox602.Clear()

        'Mathematics
        Me.TextBox604.Clear()
        Me.TextBox606.Clear()
        Me.TextBox607.Clear()

        'Result Information
        Me.TextBox597.Clear()
        Me.TextBox596.Clear()
        Me.TextBox598.Clear()
        Me.TextBox595.Clear()
        Me.TextBox594.Clear()

        'PIC Box
        Me.PictureBox49.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox48.Image = Global.Student_Data_Managements.My.Resources.NO_Pic
        Me.PictureBox47.Image = Global.Student_Data_Managements.My.Resources.NO_Pic


        MessageBox.Show("Marks Clear Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Button Back
    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click

    End Sub


    'Button Next
    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click

    End Sub



    '---------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------

    'Account Details Class One
    Private Sub One_AccountTotal()

        Me.TextBox636.Text = Val(TextBox816.Text) + Val(TextBox802.Text) + Val(TextBox788.Text) + Val(TextBox774.Text) + Val(TextBox760.Text) + Val(TextBox746.Text) + Val(TextBox732.Text) + Val(TextBox718.Text) + Val(TextBox704.Text) + Val(TextBox690.Text) + Val(TextBox676.Text) + Val(TextBox662.Text)
        Me.TextBox635.Text = Val(TextBox815.Text) + Val(TextBox801.Text) + Val(TextBox787.Text) + Val(TextBox773.Text) + Val(TextBox759.Text) + Val(TextBox745.Text) + Val(TextBox731.Text) + Val(TextBox717.Text) + Val(TextBox703.Text) + Val(TextBox689.Text) + Val(TextBox675.Text) + Val(TextBox661.Text)
        Me.TextBox634.Text = Val(TextBox814.Text) + Val(TextBox800.Text) + Val(TextBox786.Text) + Val(TextBox772.Text) + Val(TextBox758.Text) + Val(TextBox744.Text) + Val(TextBox730.Text) + Val(TextBox716.Text) + Val(TextBox702.Text) + Val(TextBox688.Text) + Val(TextBox674.Text) + Val(TextBox660.Text)
        Me.TextBox633.Text = Val(TextBox813.Text) + Val(TextBox799.Text) + Val(TextBox785.Text) + Val(TextBox771.Text) + Val(TextBox757.Text) + Val(TextBox743.Text) + Val(TextBox729.Text) + Val(TextBox715.Text) + Val(TextBox701.Text) + Val(TextBox687.Text) + Val(TextBox673.Text) + Val(TextBox659.Text)
        Me.TextBox632.Text = Val(TextBox812.Text) + Val(TextBox798.Text) + Val(TextBox784.Text) + Val(TextBox770.Text) + Val(TextBox756.Text) + Val(TextBox742.Text) + Val(TextBox728.Text) + Val(TextBox714.Text) + Val(TextBox700.Text) + Val(TextBox686.Text) + Val(TextBox672.Text) + Val(TextBox658.Text)
        Me.TextBox631.Text = Val(TextBox811.Text) + Val(TextBox797.Text) + Val(TextBox783.Text) + Val(TextBox769.Text) + Val(TextBox755.Text) + Val(TextBox741.Text) + Val(TextBox727.Text) + Val(TextBox713.Text) + Val(TextBox699.Text) + Val(TextBox685.Text) + Val(TextBox671.Text) + Val(TextBox657.Text)
        Me.TextBox630.Text = Val(TextBox810.Text) + Val(TextBox796.Text) + Val(TextBox782.Text) + Val(TextBox768.Text) + Val(TextBox754.Text) + Val(TextBox740.Text) + Val(TextBox726.Text) + Val(TextBox712.Text) + Val(TextBox698.Text) + Val(TextBox684.Text) + Val(TextBox670.Text) + Val(TextBox656.Text)
        Me.TextBox629.Text = Val(TextBox809.Text) + Val(TextBox795.Text) + Val(TextBox781.Text) + Val(TextBox767.Text) + Val(TextBox753.Text) + Val(TextBox739.Text) + Val(TextBox725.Text) + Val(TextBox711.Text) + Val(TextBox697.Text) + Val(TextBox683.Text) + Val(TextBox669.Text) + Val(TextBox655.Text)
        Me.TextBox628.Text = Val(TextBox808.Text) + Val(TextBox794.Text) + Val(TextBox780.Text) + Val(TextBox766.Text) + Val(TextBox752.Text) + Val(TextBox738.Text) + Val(TextBox724.Text) + Val(TextBox710.Text) + Val(TextBox696.Text) + Val(TextBox682.Text) + Val(TextBox668.Text) + Val(TextBox654.Text)
        Me.TextBox627.Text = Val(TextBox807.Text) + Val(TextBox793.Text) + Val(TextBox779.Text) + Val(TextBox765.Text) + Val(TextBox751.Text) + Val(TextBox737.Text) + Val(TextBox723.Text) + Val(TextBox709.Text) + Val(TextBox695.Text) + Val(TextBox681.Text) + Val(TextBox667.Text) + Val(TextBox653.Text)
        Me.TextBox626.Text = Val(TextBox806.Text) + Val(TextBox792.Text) + Val(TextBox778.Text) + Val(TextBox764.Text) + Val(TextBox750.Text) + Val(TextBox736.Text) + Val(TextBox722.Text) + Val(TextBox708.Text) + Val(TextBox694.Text) + Val(TextBox680.Text) + Val(TextBox666.Text) + Val(TextBox652.Text)
        Me.TextBox625.Text = Val(TextBox805.Text) + Val(TextBox791.Text) + Val(TextBox777.Text) + Val(TextBox763.Text) + Val(TextBox749.Text) + Val(TextBox735.Text) + Val(TextBox721.Text) + Val(TextBox707.Text) + Val(TextBox693.Text) + Val(TextBox679.Text) + Val(TextBox665.Text) + Val(TextBox651.Text)
       
        ''Total
        Me.TextBox622.Text = Val(TextBox636.Text) + Val(TextBox635.Text) + Val(TextBox634.Text) + Val(TextBox633.Text) + Val(TextBox632.Text) + Val(TextBox631.Text) + Val(TextBox630.Text) + Val(TextBox629.Text) + Val(TextBox628.Text) + Val(TextBox627.Text) + Val(TextBox626.Text) + Val(TextBox625.Text)

        ''Total Month Account
        Me.TextBox648.Text = Val(TextBox816.Text) + Val(TextBox815.Text) + Val(TextBox814.Text) + Val(TextBox813.Text) + Val(TextBox812.Text) + Val(TextBox811.Text) + Val(TextBox810.Text) + Val(TextBox809.Text) + Val(TextBox808.Text) + Val(TextBox807.Text) + Val(TextBox806.Text) + Val(TextBox805.Text)
        Me.TextBox647.Text = Val(TextBox802.Text) + Val(TextBox801.Text) + Val(TextBox800.Text) + Val(TextBox799.Text) + Val(TextBox798.Text) + Val(TextBox797.Text) + Val(TextBox796.Text) + Val(TextBox795.Text) + Val(TextBox794.Text) + Val(TextBox793.Text) + Val(TextBox792.Text) + Val(TextBox791.Text)
        Me.TextBox646.Text = Val(TextBox788.Text) + Val(TextBox787.Text) + Val(TextBox786.Text) + Val(TextBox785.Text) + Val(TextBox784.Text) + Val(TextBox783.Text) + Val(TextBox782.Text) + Val(TextBox781.Text) + Val(TextBox780.Text) + Val(TextBox779.Text) + Val(TextBox778.Text) + Val(TextBox777.Text)
        Me.TextBox645.Text = Val(TextBox774.Text) + Val(TextBox773.Text) + Val(TextBox772.Text) + Val(TextBox771.Text) + Val(TextBox770.Text) + Val(TextBox769.Text) + Val(TextBox768.Text) + Val(TextBox767.Text) + Val(TextBox766.Text) + Val(TextBox765.Text) + Val(TextBox764.Text) + Val(TextBox763.Text)
        Me.TextBox644.Text = Val(TextBox760.Text) + Val(TextBox759.Text) + Val(TextBox758.Text) + Val(TextBox757.Text) + Val(TextBox756.Text) + Val(TextBox755.Text) + Val(TextBox754.Text) + Val(TextBox753.Text) + Val(TextBox752.Text) + Val(TextBox751.Text) + Val(TextBox750.Text) + Val(TextBox749.Text)
        Me.TextBox643.Text = Val(TextBox746.Text) + Val(TextBox745.Text) + Val(TextBox744.Text) + Val(TextBox743.Text) + Val(TextBox742.Text) + Val(TextBox741.Text) + Val(TextBox740.Text) + Val(TextBox739.Text) + Val(TextBox738.Text) + Val(TextBox737.Text) + Val(TextBox736.Text) + Val(TextBox735.Text)
        Me.TextBox642.Text = Val(TextBox732.Text) + Val(TextBox731.Text) + Val(TextBox730.Text) + Val(TextBox729.Text) + Val(TextBox728.Text) + Val(TextBox727.Text) + Val(TextBox726.Text) + Val(TextBox725.Text) + Val(TextBox724.Text) + Val(TextBox723.Text) + Val(TextBox722.Text) + Val(TextBox721.Text)
        Me.TextBox641.Text = Val(TextBox718.Text) + Val(TextBox717.Text) + Val(TextBox716.Text) + Val(TextBox715.Text) + Val(TextBox714.Text) + Val(TextBox713.Text) + Val(TextBox712.Text) + Val(TextBox711.Text) + Val(TextBox710.Text) + Val(TextBox709.Text) + Val(TextBox708.Text) + Val(TextBox707.Text)
        Me.TextBox640.Text = Val(TextBox704.Text) + Val(TextBox703.Text) + Val(TextBox702.Text) + Val(TextBox701.Text) + Val(TextBox700.Text) + Val(TextBox699.Text) + Val(TextBox698.Text) + Val(TextBox697.Text) + Val(TextBox696.Text) + Val(TextBox695.Text) + Val(TextBox694.Text) + Val(TextBox693.Text)
        Me.TextBox639.Text = Val(TextBox690.Text) + Val(TextBox689.Text) + Val(TextBox688.Text) + Val(TextBox687.Text) + Val(TextBox686.Text) + Val(TextBox685.Text) + Val(TextBox684.Text) + Val(TextBox683.Text) + Val(TextBox682.Text) + Val(TextBox681.Text) + Val(TextBox680.Text) + Val(TextBox679.Text)
        Me.TextBox638.Text = Val(TextBox676.Text) + Val(TextBox675.Text) + Val(TextBox674.Text) + Val(TextBox673.Text) + Val(TextBox672.Text) + Val(TextBox671.Text) + Val(TextBox670.Text) + Val(TextBox669.Text) + Val(TextBox668.Text) + Val(TextBox667.Text) + Val(TextBox666.Text) + Val(TextBox665.Text)
        Me.TextBox637.Text = Val(TextBox662.Text) + Val(TextBox661.Text) + Val(TextBox660.Text) + Val(TextBox659.Text) + Val(TextBox658.Text) + Val(TextBox657.Text) + Val(TextBox656.Text) + Val(TextBox655.Text) + Val(TextBox654.Text) + Val(TextBox653.Text) + Val(TextBox652.Text) + Val(TextBox651.Text)



        'Total Month Clear
        If TextBox636.Text = "0" Then
            TextBox636.Clear()
        End If

        If TextBox635.Text = "0" Then
            TextBox635.Clear()
        End If

        If TextBox634.Text = "0" Then
            TextBox634.Clear()
        End If

        If TextBox633.Text = "0" Then
            TextBox633.Clear()
        End If

        If TextBox632.Text = "0" Then
            TextBox632.Clear()
        End If

        If TextBox631.Text = "0" Then
            TextBox631.Clear()
        End If

        If TextBox630.Text = "0" Then
            TextBox630.Clear()
        End If

        If TextBox629.Text = "0" Then
            TextBox629.Clear()
        End If

        If TextBox628.Text = "0" Then
            TextBox628.Clear()
        End If

        If TextBox627.Text = "0" Then
            TextBox627.Clear()
        End If

        If TextBox626.Text = "0" Then
            TextBox626.Clear()
        End If

        If TextBox625.Text = "0" Then
            TextBox625.Clear()
        End If


        'Total Clear
        If TextBox622.Text = "0" Then
            TextBox622.Clear()
        End If

        'Total Mont
        If TextBox648.Text = "0" Then
            TextBox648.Clear()
        End If

        If TextBox647.Text = "0" Then
            TextBox647.Clear()
        End If
        If TextBox646.Text = "0" Then
            TextBox646.Clear()
        End If

        If TextBox645.Text = "0" Then
            TextBox645.Clear()
        End If

        If TextBox644.Text = "0" Then
            TextBox644.Clear()
        End If

        If TextBox643.Text = "0" Then
            TextBox643.Clear()
        End If

        If TextBox642.Text = "0" Then
            TextBox642.Clear()
        End If

        If TextBox641.Text = "0" Then
            TextBox641.Clear()
        End If

        If TextBox640.Text = "0" Then
            TextBox640.Clear()
        End If

        If TextBox639.Text = "0" Then
            TextBox639.Clear()
        End If

        If TextBox638.Text = "0" Then
            TextBox638.Clear()
        End If

        If TextBox637.Text = "0" Then
            TextBox637.Clear()
        End If
    End Sub


    'Rodio Button Normal 
    Private Sub RadioButton27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton27.CheckedChanged

    End Sub

    'Rodio Button Jan
    Private Sub RadioButton39_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton39.CheckedChanged
        If RadioButton39.Checked = True Then
            Me.TextBox816.Enabled = True
            Me.TextBox815.Enabled = True
            Me.TextBox814.Enabled = True
            Me.TextBox813.Enabled = True
            Me.TextBox812.Enabled = True
            Me.TextBox811.Enabled = True
            Me.TextBox810.Enabled = True
            Me.TextBox809.Enabled = True
            Me.TextBox808.Enabled = True
            Me.TextBox807.Enabled = True
            Me.TextBox806.Enabled = True
            Me.TextBox805.Enabled = True
            Me.TextBox621.Enabled = True
            Me.DateTimePicker38.Enabled = True

        ElseIf RadioButton39.Checked = False Then
            Me.TextBox816.Enabled = False
            Me.TextBox815.Enabled = False
            Me.TextBox814.Enabled = False
            Me.TextBox813.Enabled = False
            Me.TextBox812.Enabled = False
            Me.TextBox811.Enabled = False
            Me.TextBox810.Enabled = False
            Me.TextBox809.Enabled = False
            Me.TextBox808.Enabled = False
            Me.TextBox807.Enabled = False
            Me.TextBox806.Enabled = False
            Me.TextBox805.Enabled = False
            Me.TextBox621.Enabled = False
            Me.DateTimePicker38.Enabled = False

        End If
    End Sub

    'Rodio Button Feb
    Private Sub RadioButton38_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton38.CheckedChanged
        If RadioButton38.Checked = True Then
            Me.TextBox802.Enabled = True
            Me.TextBox801.Enabled = True
            Me.TextBox800.Enabled = True
            Me.TextBox799.Enabled = True
            Me.TextBox798.Enabled = True
            Me.TextBox797.Enabled = True
            Me.TextBox796.Enabled = True
            Me.TextBox795.Enabled = True
            Me.TextBox794.Enabled = True
            Me.TextBox793.Enabled = True
            Me.TextBox792.Enabled = True
            Me.TextBox791.Enabled = True
            Me.TextBox620.Enabled = True
            Me.DateTimePicker49.Enabled = True

        ElseIf RadioButton38.Checked = False Then
            Me.TextBox802.Enabled = False
            Me.TextBox801.Enabled = False
            Me.TextBox800.Enabled = False
            Me.TextBox799.Enabled = False
            Me.TextBox798.Enabled = False
            Me.TextBox797.Enabled = False
            Me.TextBox796.Enabled = False
            Me.TextBox795.Enabled = False
            Me.TextBox794.Enabled = False
            Me.TextBox793.Enabled = False
            Me.TextBox792.Enabled = False
            Me.TextBox791.Enabled = False
            Me.TextBox620.Enabled = False
            Me.DateTimePicker49.Enabled = False

        End If
    End Sub

    'Rodio Button Mar
    Private Sub RadioButton37_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton37.CheckedChanged
        If RadioButton37.Checked = True Then
            Me.TextBox788.Enabled = True
            Me.TextBox787.Enabled = True
            Me.TextBox786.Enabled = True
            Me.TextBox785.Enabled = True
            Me.TextBox784.Enabled = True
            Me.TextBox783.Enabled = True
            Me.TextBox782.Enabled = True
            Me.TextBox781.Enabled = True
            Me.TextBox780.Enabled = True
            Me.TextBox779.Enabled = True
            Me.TextBox778.Enabled = True
            Me.TextBox777.Enabled = True
            Me.TextBox619.Enabled = True
            Me.DateTimePicker48.Enabled = True

        ElseIf RadioButton37.Checked = False Then
            Me.TextBox788.Enabled = False
            Me.TextBox787.Enabled = False
            Me.TextBox786.Enabled = False
            Me.TextBox785.Enabled = False
            Me.TextBox784.Enabled = False
            Me.TextBox783.Enabled = False
            Me.TextBox782.Enabled = False
            Me.TextBox781.Enabled = False
            Me.TextBox780.Enabled = False
            Me.TextBox779.Enabled = False
            Me.TextBox778.Enabled = False
            Me.TextBox777.Enabled = False
            Me.TextBox619.Enabled = False
            Me.DateTimePicker48.Enabled = False
        End If
    End Sub

    'Rodio Button Apr
    Private Sub RadioButton36_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton36.CheckedChanged
        If RadioButton36.Checked = True Then
            Me.TextBox774.Enabled = True
            Me.TextBox773.Enabled = True
            Me.TextBox772.Enabled = True
            Me.TextBox771.Enabled = True
            Me.TextBox770.Enabled = True
            Me.TextBox769.Enabled = True
            Me.TextBox768.Enabled = True
            Me.TextBox767.Enabled = True
            Me.TextBox766.Enabled = True
            Me.TextBox765.Enabled = True
            Me.TextBox764.Enabled = True
            Me.TextBox763.Enabled = True
            Me.TextBox618.Enabled = True
            Me.DateTimePicker47.Enabled = True

        ElseIf RadioButton36.Checked = False Then
            Me.TextBox774.Enabled = False
            Me.TextBox773.Enabled = False
            Me.TextBox772.Enabled = False
            Me.TextBox771.Enabled = False
            Me.TextBox770.Enabled = False
            Me.TextBox769.Enabled = False
            Me.TextBox768.Enabled = False
            Me.TextBox767.Enabled = False
            Me.TextBox766.Enabled = False
            Me.TextBox765.Enabled = False
            Me.TextBox764.Enabled = False
            Me.TextBox763.Enabled = False
            Me.TextBox618.Enabled = False
            Me.DateTimePicker47.Enabled = False
        End If
    End Sub

    'Rodio Button May
    Private Sub RadioButton35_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton35.CheckedChanged
        If RadioButton35.Checked = True Then
            Me.TextBox760.Enabled = True
            Me.TextBox759.Enabled = True
            Me.TextBox758.Enabled = True
            Me.TextBox757.Enabled = True
            Me.TextBox756.Enabled = True
            Me.TextBox755.Enabled = True
            Me.TextBox754.Enabled = True
            Me.TextBox753.Enabled = True
            Me.TextBox752.Enabled = True
            Me.TextBox751.Enabled = True
            Me.TextBox750.Enabled = True
            Me.TextBox749.Enabled = True
            Me.TextBox617.Enabled = True
            Me.DateTimePicker46.Enabled = True

        ElseIf RadioButton35.Checked = False Then
            Me.TextBox760.Enabled = False
            Me.TextBox759.Enabled = False
            Me.TextBox758.Enabled = False
            Me.TextBox757.Enabled = False
            Me.TextBox756.Enabled = False
            Me.TextBox755.Enabled = False
            Me.TextBox754.Enabled = False
            Me.TextBox753.Enabled = False
            Me.TextBox752.Enabled = False
            Me.TextBox751.Enabled = False
            Me.TextBox750.Enabled = False
            Me.TextBox749.Enabled = False
            Me.TextBox617.Enabled = False
            Me.DateTimePicker46.Enabled = False
        End If
    End Sub

    'Rodio Button Jun
    Private Sub RadioButton34_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton34.CheckedChanged
        If RadioButton34.Checked = True Then
            Me.TextBox746.Enabled = True
            Me.TextBox745.Enabled = True
            Me.TextBox744.Enabled = True
            Me.TextBox743.Enabled = True
            Me.TextBox742.Enabled = True
            Me.TextBox741.Enabled = True
            Me.TextBox740.Enabled = True
            Me.TextBox739.Enabled = True
            Me.TextBox738.Enabled = True
            Me.TextBox737.Enabled = True
            Me.TextBox736.Enabled = True
            Me.TextBox735.Enabled = True
            Me.TextBox616.Enabled = True
            Me.DateTimePicker45.Enabled = True

        ElseIf RadioButton34.Checked = False Then
            Me.TextBox746.Enabled = False
            Me.TextBox745.Enabled = False
            Me.TextBox744.Enabled = False
            Me.TextBox743.Enabled = False
            Me.TextBox742.Enabled = False
            Me.TextBox741.Enabled = False
            Me.TextBox740.Enabled = False
            Me.TextBox739.Enabled = False
            Me.TextBox738.Enabled = False
            Me.TextBox737.Enabled = False
            Me.TextBox736.Enabled = False
            Me.TextBox735.Enabled = False
            Me.TextBox616.Enabled = False
            Me.DateTimePicker45.Enabled = False
        End If
    End Sub

    'Rodio Button Jul
    Private Sub RadioButton33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton33.CheckedChanged
        If RadioButton33.Checked = True Then
            Me.TextBox732.Enabled = True
            Me.TextBox731.Enabled = True
            Me.TextBox730.Enabled = True
            Me.TextBox729.Enabled = True
            Me.TextBox728.Enabled = True
            Me.TextBox727.Enabled = True
            Me.TextBox726.Enabled = True
            Me.TextBox725.Enabled = True
            Me.TextBox724.Enabled = True
            Me.TextBox723.Enabled = True
            Me.TextBox722.Enabled = True
            Me.TextBox721.Enabled = True
            Me.TextBox615.Enabled = True
            Me.DateTimePicker44.Enabled = True

        ElseIf RadioButton33.Checked = False Then
            Me.TextBox732.Enabled = False
            Me.TextBox731.Enabled = False
            Me.TextBox730.Enabled = False
            Me.TextBox729.Enabled = False
            Me.TextBox728.Enabled = False
            Me.TextBox727.Enabled = False
            Me.TextBox726.Enabled = False
            Me.TextBox725.Enabled = False
            Me.TextBox724.Enabled = False
            Me.TextBox723.Enabled = False
            Me.TextBox722.Enabled = False
            Me.TextBox721.Enabled = False
            Me.TextBox615.Enabled = False
            Me.DateTimePicker44.Enabled = False
        End If
    End Sub

    'Rodio Button Aug
    Private Sub RadioButton32_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton32.CheckedChanged
        If RadioButton32.Checked = True Then
            Me.TextBox718.Enabled = True
            Me.TextBox717.Enabled = True
            Me.TextBox716.Enabled = True
            Me.TextBox715.Enabled = True
            Me.TextBox714.Enabled = True
            Me.TextBox713.Enabled = True
            Me.TextBox712.Enabled = True
            Me.TextBox711.Enabled = True
            Me.TextBox710.Enabled = True
            Me.TextBox709.Enabled = True
            Me.TextBox708.Enabled = True
            Me.TextBox707.Enabled = True
            Me.TextBox614.Enabled = True
            Me.DateTimePicker43.Enabled = True

        ElseIf RadioButton32.Checked = False Then
            Me.TextBox718.Enabled = False
            Me.TextBox717.Enabled = False
            Me.TextBox716.Enabled = False
            Me.TextBox715.Enabled = False
            Me.TextBox714.Enabled = False
            Me.TextBox713.Enabled = False
            Me.TextBox712.Enabled = False
            Me.TextBox711.Enabled = False
            Me.TextBox710.Enabled = False
            Me.TextBox709.Enabled = False
            Me.TextBox708.Enabled = False
            Me.TextBox707.Enabled = False
            Me.TextBox614.Enabled = False
            Me.DateTimePicker43.Enabled = False
        End If
    End Sub

    'Rodio Button Sep
    Private Sub RadioButton31_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton31.CheckedChanged
        If RadioButton31.Checked = True Then
            Me.TextBox704.Enabled = True
            Me.TextBox703.Enabled = True
            Me.TextBox702.Enabled = True
            Me.TextBox701.Enabled = True
            Me.TextBox700.Enabled = True
            Me.TextBox699.Enabled = True
            Me.TextBox698.Enabled = True
            Me.TextBox697.Enabled = True
            Me.TextBox696.Enabled = True
            Me.TextBox695.Enabled = True
            Me.TextBox694.Enabled = True
            Me.TextBox693.Enabled = True
            Me.TextBox613.Enabled = True
            Me.DateTimePicker42.Enabled = True

        ElseIf RadioButton31.Checked = False Then
            Me.TextBox704.Enabled = False
            Me.TextBox703.Enabled = False
            Me.TextBox702.Enabled = False
            Me.TextBox701.Enabled = False
            Me.TextBox700.Enabled = False
            Me.TextBox699.Enabled = False
            Me.TextBox698.Enabled = False
            Me.TextBox697.Enabled = False
            Me.TextBox696.Enabled = False
            Me.TextBox695.Enabled = False
            Me.TextBox694.Enabled = False
            Me.TextBox693.Enabled = False
            Me.TextBox613.Enabled = False
            Me.DateTimePicker42.Enabled = False
        End If
    End Sub

    'Rodio Button Oct
    Private Sub RadioButton30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton30.CheckedChanged
        If RadioButton30.Checked = True Then
            Me.TextBox690.Enabled = True
            Me.TextBox689.Enabled = True
            Me.TextBox688.Enabled = True
            Me.TextBox687.Enabled = True
            Me.TextBox686.Enabled = True
            Me.TextBox685.Enabled = True
            Me.TextBox684.Enabled = True
            Me.TextBox683.Enabled = True
            Me.TextBox682.Enabled = True
            Me.TextBox681.Enabled = True
            Me.TextBox680.Enabled = True
            Me.TextBox679.Enabled = True
            Me.TextBox612.Enabled = True
            Me.DateTimePicker41.Enabled = True

        ElseIf RadioButton30.Checked = False Then
            Me.TextBox690.Enabled = False
            Me.TextBox689.Enabled = False
            Me.TextBox688.Enabled = False
            Me.TextBox687.Enabled = False
            Me.TextBox686.Enabled = False
            Me.TextBox685.Enabled = False
            Me.TextBox684.Enabled = False
            Me.TextBox683.Enabled = False
            Me.TextBox682.Enabled = False
            Me.TextBox681.Enabled = False
            Me.TextBox680.Enabled = False
            Me.TextBox679.Enabled = False
            Me.TextBox612.Enabled = False
            Me.DateTimePicker41.Enabled = False
        End If
    End Sub

    'Rodio Button Nov
    Private Sub RadioButton29_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton29.CheckedChanged
        If RadioButton29.Checked = True Then
            Me.TextBox676.Enabled = True
            Me.TextBox675.Enabled = True
            Me.TextBox674.Enabled = True
            Me.TextBox673.Enabled = True
            Me.TextBox672.Enabled = True
            Me.TextBox671.Enabled = True
            Me.TextBox670.Enabled = True
            Me.TextBox669.Enabled = True
            Me.TextBox668.Enabled = True
            Me.TextBox667.Enabled = True
            Me.TextBox666.Enabled = True
            Me.TextBox665.Enabled = True
            Me.TextBox611.Enabled = True
            Me.DateTimePicker40.Enabled = True

        ElseIf RadioButton29.Checked = False Then
            Me.TextBox676.Enabled = False
            Me.TextBox675.Enabled = False
            Me.TextBox674.Enabled = False
            Me.TextBox673.Enabled = False
            Me.TextBox672.Enabled = False
            Me.TextBox671.Enabled = False
            Me.TextBox670.Enabled = False
            Me.TextBox669.Enabled = False
            Me.TextBox668.Enabled = False
            Me.TextBox667.Enabled = False
            Me.TextBox666.Enabled = False
            Me.TextBox665.Enabled = False
            Me.TextBox611.Enabled = False
            Me.DateTimePicker40.Enabled = False
        End If
    End Sub

    'Rodio Button Dec
    Private Sub RadioButton28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton28.CheckedChanged
        If RadioButton28.Checked = True Then
            Me.TextBox662.Enabled = True
            Me.TextBox661.Enabled = True
            Me.TextBox660.Enabled = True
            Me.TextBox659.Enabled = True
            Me.TextBox658.Enabled = True
            Me.TextBox657.Enabled = True
            Me.TextBox656.Enabled = True
            Me.TextBox655.Enabled = True
            Me.TextBox654.Enabled = True
            Me.TextBox653.Enabled = True
            Me.TextBox652.Enabled = True
            Me.TextBox651.Enabled = True
            Me.TextBox610.Enabled = True
            Me.DateTimePicker39.Enabled = True

        ElseIf RadioButton28.Checked = False Then
            Me.TextBox662.Enabled = False
            Me.TextBox661.Enabled = False
            Me.TextBox660.Enabled = False
            Me.TextBox659.Enabled = False
            Me.TextBox658.Enabled = False
            Me.TextBox657.Enabled = False
            Me.TextBox656.Enabled = False
            Me.TextBox655.Enabled = False
            Me.TextBox654.Enabled = False
            Me.TextBox653.Enabled = False
            Me.TextBox652.Enabled = False
            Me.TextBox651.Enabled = False
            Me.TextBox610.Enabled = False
            Me.DateTimePicker39.Enabled = False
        End If
    End Sub


    'Account TextBox Jan
    Private Sub TextBox816_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox816.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox815_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox815.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox814_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox814.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox813_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox813.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox812_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox812.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox811_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox811.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox810_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox810.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox809_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox809.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox808_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox808.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox807_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox807.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox806_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox806.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox805_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox805.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox804_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox803_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Feb
    Private Sub TextBox802_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox802.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox801_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox801.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox800_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox800.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox799_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox799.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox798_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox798.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox797_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox797.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox796_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox796.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox795_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox795.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox794_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox794.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox793_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox793.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox792_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox792.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox791_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox791.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox790_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox789_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Mar
    Private Sub TextBox788_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox788.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox787_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox787.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox786_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox786.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox785_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox785.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox784_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox784.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox783_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox783.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox782_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox782.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox781_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox781.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox780_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox780.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox779_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox779.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox778_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox778.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox777_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox777.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox776_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox775_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Apr
    Private Sub TextBox774_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox774.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox773_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox773.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox772_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox772.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox771_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox771.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox770_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox770.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox769_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox769.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox768_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox768.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox767_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox767.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox766_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox766.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox765_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox765.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox764_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox764.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox763_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox763.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox762_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox761_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox May
    Private Sub TextBox760_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox760.TextChanged
        Me.One_AccountTotal()
    End Sub

    Private Sub TextBox759_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox759.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox758_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox758.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox757_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox757.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox756_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox756.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox755_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox755.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox754_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox754.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox753_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox753.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox752_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox752.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox751_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox751.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox750_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox750.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox749_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox749.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox748_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox747_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Jun
    Private Sub TextBox746_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox746.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox745_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox745.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox744_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox744.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox743_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox743.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox742_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox742.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox741_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox741.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox740_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox740.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox739_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox739.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox738_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox738.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox737_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox737.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox736_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox736.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox735_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox735.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox734_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox733_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Jul
    Private Sub TextBox732_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox732.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox731_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox731.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox730_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox730.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox729_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox729.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox728_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox728.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox727_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox727.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox726_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox726.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox725_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox725.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox724_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox724.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox723_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox723.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox722_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox722.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox721_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox721.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox720_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox719_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Aug
    Private Sub TextBox718_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox718.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox717_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox717.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox716_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox716.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox715_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox715.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox714_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox714.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox713_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox713.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox712_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox712.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox711_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox711.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox710_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox710.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox709_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox709.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox708_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox708.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox707_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox707.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox706_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox705_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Sep
    Private Sub TextBox704_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox704.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox703_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox703.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox702_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox702.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox701_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox701.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox700_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox700.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox699_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox699.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox698_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox698.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox697_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox697.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox696_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox696.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox695_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox695.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox694_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox694.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox693_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox693.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox692_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox691_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Oct
    Private Sub TextBox690_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox690.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox689_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox689.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox688_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox688.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox687_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox687.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox686_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox686.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox685_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox685.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox684_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox684.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox683_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox683.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox682_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox682.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox681_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox681.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox680_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox680.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox679_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox679.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox678_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox677_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Nov
    Private Sub TextBox676_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox676.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox675_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox675.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox674_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox674.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox673_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox673.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox672_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox672.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox671_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox671.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox670_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox670.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox669_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox669.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox668_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox668.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox667_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox667.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox666_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox666.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox665_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox665.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox664_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox663_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Account TextBox Dec
    Private Sub TextBox662_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox662.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox661_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox661.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox660_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox660.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox659_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox659.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox658_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox658.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox657_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox657.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox656_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox656.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox655_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox655.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox654_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox654.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox653_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox653.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox652_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox652.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox651_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox651.TextChanged
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox650_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub
    Private Sub TextBox649_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.One_AccountTotal()
    End Sub

    'Date Time Picker 
    Private Sub DateTimePicker38_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker38.ValueChanged
        Me.TextBox621.Text = DateTimePicker38.Text
    End Sub

    Private Sub DateTimePicker49_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker49.ValueChanged
        Me.TextBox620.Text = DateTimePicker49.Text
    End Sub

    Private Sub DateTimePicker48_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker48.ValueChanged
        Me.TextBox619.Text = DateTimePicker48.Text
    End Sub

    Private Sub DateTimePicker47_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker47.ValueChanged
        Me.TextBox618.Text = DateTimePicker47.Text
    End Sub

    Private Sub DateTimePicker46_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker46.ValueChanged
        Me.TextBox617.Text = DateTimePicker46.Text
    End Sub

    Private Sub DateTimePicker45_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker45.ValueChanged
        Me.TextBox616.Text = DateTimePicker45.Text
    End Sub

    Private Sub DateTimePicker44_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker44.ValueChanged
        Me.TextBox615.Text = DateTimePicker44.Text
    End Sub

    Private Sub DateTimePicker43_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker43.ValueChanged
        Me.TextBox614.Text = DateTimePicker43.Text
    End Sub

    Private Sub DateTimePicker42_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker42.ValueChanged
        Me.TextBox613.Text = DateTimePicker42.Text
    End Sub

    Private Sub DateTimePicker41_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker41.ValueChanged
        Me.TextBox612.Text = DateTimePicker41.Text
    End Sub

    Private Sub DateTimePicker40_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker40.ValueChanged
        Me.TextBox611.Text = DateTimePicker40.Text
    End Sub

    Private Sub DateTimePicker39_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker39.ValueChanged
        Me.TextBox610.Text = DateTimePicker39.Text
    End Sub


    '---------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------

    'Account Details Class Two

    Private Sub Two_AccountTotal()

        Me.TextBox843.Text = Val(TextBox1023.Text) + Val(TextBox1009.Text) + Val(TextBox995.Text) + Val(TextBox981.Text) + Val(TextBox967.Text) + Val(TextBox953.Text) + Val(TextBox939.Text) + Val(TextBox925.Text) + Val(TextBox911.Text) + Val(TextBox897.Text) + Val(TextBox883.Text) + Val(TextBox869.Text)
        Me.TextBox842.Text = Val(TextBox1022.Text) + Val(TextBox1008.Text) + Val(TextBox994.Text) + Val(TextBox980.Text) + Val(TextBox966.Text) + Val(TextBox952.Text) + Val(TextBox938.Text) + Val(TextBox924.Text) + Val(TextBox910.Text) + Val(TextBox896.Text) + Val(TextBox882.Text) + Val(TextBox868.Text)
        Me.TextBox841.Text = Val(TextBox1021.Text) + Val(TextBox1007.Text) + Val(TextBox993.Text) + Val(TextBox979.Text) + Val(TextBox965.Text) + Val(TextBox951.Text) + Val(TextBox937.Text) + Val(TextBox923.Text) + Val(TextBox909.Text) + Val(TextBox895.Text) + Val(TextBox881.Text) + Val(TextBox867.Text)
        Me.TextBox840.Text = Val(TextBox1020.Text) + Val(TextBox1006.Text) + Val(TextBox992.Text) + Val(TextBox978.Text) + Val(TextBox964.Text) + Val(TextBox950.Text) + Val(TextBox936.Text) + Val(TextBox922.Text) + Val(TextBox908.Text) + Val(TextBox894.Text) + Val(TextBox880.Text) + Val(TextBox866.Text)
        Me.TextBox839.Text = Val(TextBox1019.Text) + Val(TextBox1005.Text) + Val(TextBox991.Text) + Val(TextBox977.Text) + Val(TextBox963.Text) + Val(TextBox949.Text) + Val(TextBox935.Text) + Val(TextBox921.Text) + Val(TextBox907.Text) + Val(TextBox893.Text) + Val(TextBox879.Text) + Val(TextBox865.Text)
        Me.TextBox838.Text = Val(TextBox1018.Text) + Val(TextBox1004.Text) + Val(TextBox990.Text) + Val(TextBox976.Text) + Val(TextBox962.Text) + Val(TextBox948.Text) + Val(TextBox934.Text) + Val(TextBox920.Text) + Val(TextBox906.Text) + Val(TextBox892.Text) + Val(TextBox878.Text) + Val(TextBox864.Text)
        Me.TextBox837.Text = Val(TextBox1017.Text) + Val(TextBox1003.Text) + Val(TextBox989.Text) + Val(TextBox975.Text) + Val(TextBox961.Text) + Val(TextBox947.Text) + Val(TextBox933.Text) + Val(TextBox919.Text) + Val(TextBox905.Text) + Val(TextBox891.Text) + Val(TextBox877.Text) + Val(TextBox863.Text)
        Me.TextBox836.Text = Val(TextBox1016.Text) + Val(TextBox1002.Text) + Val(TextBox988.Text) + Val(TextBox974.Text) + Val(TextBox960.Text) + Val(TextBox946.Text) + Val(TextBox932.Text) + Val(TextBox918.Text) + Val(TextBox904.Text) + Val(TextBox890.Text) + Val(TextBox876.Text) + Val(TextBox862.Text)
        Me.TextBox835.Text = Val(TextBox1015.Text) + Val(TextBox1001.Text) + Val(TextBox987.Text) + Val(TextBox973.Text) + Val(TextBox959.Text) + Val(TextBox945.Text) + Val(TextBox931.Text) + Val(TextBox917.Text) + Val(TextBox903.Text) + Val(TextBox889.Text) + Val(TextBox875.Text) + Val(TextBox861.Text)
        Me.TextBox834.Text = Val(TextBox1014.Text) + Val(TextBox1000.Text) + Val(TextBox986.Text) + Val(TextBox972.Text) + Val(TextBox958.Text) + Val(TextBox944.Text) + Val(TextBox930.Text) + Val(TextBox916.Text) + Val(TextBox902.Text) + Val(TextBox888.Text) + Val(TextBox874.Text) + Val(TextBox860.Text)
        Me.TextBox833.Text = Val(TextBox1013.Text) + Val(TextBox999.Text) + Val(TextBox985.Text) + Val(TextBox971.Text) + Val(TextBox957.Text) + Val(TextBox943.Text) + Val(TextBox929.Text) + Val(TextBox915.Text) + Val(TextBox901.Text) + Val(TextBox887.Text) + Val(TextBox873.Text) + Val(TextBox859.Text)
        Me.TextBox832.Text = Val(TextBox1012.Text) + Val(TextBox998.Text) + Val(TextBox984.Text) + Val(TextBox970.Text) + Val(TextBox956.Text) + Val(TextBox942.Text) + Val(TextBox928.Text) + Val(TextBox914.Text) + Val(TextBox900.Text) + Val(TextBox886.Text) + Val(TextBox872.Text) + Val(TextBox858.Text)
       
        'Total
        Me.TextBox829.Text = Val(TextBox843.Text) + Val(TextBox842.Text) + Val(TextBox841.Text) + Val(TextBox840.Text) + Val(TextBox839.Text) + Val(TextBox838.Text) + Val(TextBox837.Text) + Val(TextBox836.Text) + Val(TextBox835.Text) + Val(TextBox834.Text) + Val(TextBox833.Text) + Val(TextBox832.Text)

        'Total Month Account
        Me.TextBox855.Text = Val(TextBox1023.Text) + Val(TextBox1022.Text) + Val(TextBox1021.Text) + Val(TextBox1020.Text) + Val(TextBox1019.Text) + Val(TextBox1018.Text) + Val(TextBox1017.Text) + Val(TextBox1016.Text) + Val(TextBox1015.Text) + Val(TextBox1014.Text) + Val(TextBox1013.Text) + Val(TextBox1012.Text)
        Me.TextBox854.Text = Val(TextBox1009.Text) + Val(TextBox1008.Text) + Val(TextBox1007.Text) + Val(TextBox1006.Text) + Val(TextBox1005.Text) + Val(TextBox1004.Text) + Val(TextBox1003.Text) + Val(TextBox1002.Text) + Val(TextBox1001.Text) + Val(TextBox1000.Text) + Val(TextBox999.Text) + Val(TextBox998.Text)
        Me.TextBox853.Text = Val(TextBox995.Text) + Val(TextBox994.Text) + Val(TextBox993.Text) + Val(TextBox992.Text) + Val(TextBox991.Text) + Val(TextBox990.Text) + Val(TextBox989.Text) + Val(TextBox988.Text) + Val(TextBox987.Text) + Val(TextBox986.Text) + Val(TextBox985.Text) + Val(TextBox984.Text)
        Me.TextBox852.Text = Val(TextBox981.Text) + Val(TextBox980.Text) + Val(TextBox979.Text) + Val(TextBox978.Text) + Val(TextBox977.Text) + Val(TextBox976.Text) + Val(TextBox975.Text) + Val(TextBox974.Text) + Val(TextBox973.Text) + Val(TextBox972.Text) + Val(TextBox971.Text) + Val(TextBox970.Text)
        Me.TextBox851.Text = Val(TextBox967.Text) + Val(TextBox966.Text) + Val(TextBox965.Text) + Val(TextBox964.Text) + Val(TextBox963.Text) + Val(TextBox962.Text) + Val(TextBox961.Text) + Val(TextBox960.Text) + Val(TextBox959.Text) + Val(TextBox958.Text) + Val(TextBox957.Text) + Val(TextBox956.Text)
        Me.TextBox850.Text = Val(TextBox953.Text) + Val(TextBox952.Text) + Val(TextBox951.Text) + Val(TextBox950.Text) + Val(TextBox949.Text) + Val(TextBox948.Text) + Val(TextBox947.Text) + Val(TextBox946.Text) + Val(TextBox945.Text) + Val(TextBox944.Text) + Val(TextBox943.Text) + Val(TextBox942.Text)
        Me.TextBox849.Text = Val(TextBox939.Text) + Val(TextBox938.Text) + Val(TextBox937.Text) + Val(TextBox936.Text) + Val(TextBox935.Text) + Val(TextBox934.Text) + Val(TextBox933.Text) + Val(TextBox932.Text) + Val(TextBox931.Text) + Val(TextBox930.Text) + Val(TextBox929.Text) + Val(TextBox928.Text)
        Me.TextBox848.Text = Val(TextBox925.Text) + Val(TextBox924.Text) + Val(TextBox923.Text) + Val(TextBox922.Text) + Val(TextBox921.Text) + Val(TextBox920.Text) + Val(TextBox919.Text) + Val(TextBox918.Text) + Val(TextBox917.Text) + Val(TextBox916.Text) + Val(TextBox915.Text) + Val(TextBox914.Text)
        Me.TextBox847.Text = Val(TextBox911.Text) + Val(TextBox910.Text) + Val(TextBox909.Text) + Val(TextBox908.Text) + Val(TextBox907.Text) + Val(TextBox906.Text) + Val(TextBox905.Text) + Val(TextBox904.Text) + Val(TextBox903.Text) + Val(TextBox902.Text) + Val(TextBox901.Text) + Val(TextBox900.Text) 
        Me.TextBox846.Text = Val(TextBox897.Text) + Val(TextBox896.Text) + Val(TextBox895.Text) + Val(TextBox894.Text) + Val(TextBox893.Text) + Val(TextBox892.Text) + Val(TextBox891.Text) + Val(TextBox890.Text) + Val(TextBox889.Text) + Val(TextBox888.Text) + Val(TextBox887.Text) + Val(TextBox886.Text)
        Me.TextBox845.Text = Val(TextBox883.Text) + Val(TextBox882.Text) + Val(TextBox881.Text) + Val(TextBox880.Text) + Val(TextBox879.Text) + Val(TextBox878.Text) + Val(TextBox877.Text) + Val(TextBox876.Text) + Val(TextBox875.Text) + Val(TextBox874.Text) + Val(TextBox873.Text) + Val(TextBox872.Text)
        Me.TextBox844.Text = Val(TextBox869.Text) + Val(TextBox868.Text) + Val(TextBox867.Text) + Val(TextBox866.Text) + Val(TextBox865.Text) + Val(TextBox864.Text) + Val(TextBox863.Text) + Val(TextBox862.Text) + Val(TextBox861.Text) + Val(TextBox860.Text) + Val(TextBox859.Text) + Val(TextBox858.Text)



        'Total Month Clear
        If TextBox843.Text = "0" Then
            TextBox843.Clear()
        End If

        If TextBox842.Text = "0" Then
            TextBox842.Clear()
        End If

        If TextBox841.Text = "0" Then
            TextBox841.Clear()
        End If

        If TextBox840.Text = "0" Then
            TextBox840.Clear()
        End If

        If TextBox839.Text = "0" Then
            TextBox839.Clear()
        End If

        If TextBox838.Text = "0" Then
            TextBox838.Clear()
        End If

        If TextBox837.Text = "0" Then
            TextBox837.Clear()
        End If

        If TextBox836.Text = "0" Then
            TextBox836.Clear()
        End If

        If TextBox835.Text = "0" Then
            TextBox835.Clear()
        End If

        If TextBox834.Text = "0" Then
            TextBox834.Clear()
        End If

        If TextBox833.Text = "0" Then
            TextBox833.Clear()
        End If

        If TextBox832.Text = "0" Then
            TextBox832.Clear()
        End If


        'Total Clear
        If TextBox829.Text = "0" Then
            TextBox829.Clear()
        End If

        'Total Mont
        If TextBox855.Text = "0" Then
            TextBox855.Clear()
        End If

        If TextBox854.Text = "0" Then
            TextBox854.Clear()
        End If
        If TextBox853.Text = "0" Then
            TextBox853.Clear()
        End If

        If TextBox852.Text = "0" Then
            TextBox852.Clear()
        End If

        If TextBox851.Text = "0" Then
            TextBox851.Clear()
        End If

        If TextBox850.Text = "0" Then
            TextBox850.Clear()
        End If

        If TextBox849.Text = "0" Then
            TextBox849.Clear()
        End If

        If TextBox848.Text = "0" Then
            TextBox848.Clear()
        End If

        If TextBox847.Text = "0" Then
            TextBox847.Clear()
        End If

        If TextBox846.Text = "0" Then
            TextBox846.Clear()
        End If

        If TextBox845.Text = "0" Then
            TextBox845.Clear()
        End If

        If TextBox844.Text = "0" Then
            TextBox844.Clear()
        End If
    End Sub

    'Rodio Button Normail
    Private Sub RadioButton40_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton40.CheckedChanged

    End Sub

    'Rodio Button Jan
    Private Sub RadioButton52_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton52.CheckedChanged
        If RadioButton52.Checked = True Then
            Me.TextBox1023.Enabled = True
            Me.TextBox1022.Enabled = True
            Me.TextBox1021.Enabled = True
            Me.TextBox1020.Enabled = True
            Me.TextBox1019.Enabled = True
            Me.TextBox1018.Enabled = True
            Me.TextBox1017.Enabled = True
            Me.TextBox1016.Enabled = True
            Me.TextBox1015.Enabled = True
            Me.TextBox1014.Enabled = True
            Me.TextBox1013.Enabled = True
            Me.TextBox1012.Enabled = True
            Me.TextBox828.Enabled = True
            Me.DateTimePicker50.Enabled = True

        ElseIf RadioButton52.Checked = False Then
            Me.TextBox1023.Enabled = False
            Me.TextBox1022.Enabled = False
            Me.TextBox1021.Enabled = False
            Me.TextBox1020.Enabled = False
            Me.TextBox1019.Enabled = False
            Me.TextBox1018.Enabled = False
            Me.TextBox1017.Enabled = False
            Me.TextBox1016.Enabled = False
            Me.TextBox1015.Enabled = False
            Me.TextBox1014.Enabled = False
            Me.TextBox1013.Enabled = False
            Me.TextBox1012.Enabled = False
            Me.TextBox828.Enabled = False
            Me.DateTimePicker50.Enabled = False
        End If
    End Sub

    'Rodio Button Feb
    Private Sub RadioButton51_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton51.CheckedChanged
        If RadioButton51.Checked = True Then
            Me.TextBox1009.Enabled = True
            Me.TextBox1008.Enabled = True
            Me.TextBox1007.Enabled = True
            Me.TextBox1006.Enabled = True
            Me.TextBox1005.Enabled = True
            Me.TextBox1004.Enabled = True
            Me.TextBox1003.Enabled = True
            Me.TextBox1002.Enabled = True
            Me.TextBox1001.Enabled = True
            Me.TextBox1000.Enabled = True
            Me.TextBox999.Enabled = True
            Me.TextBox998.Enabled = True
            Me.TextBox827.Enabled = True
            Me.DateTimePicker61.Enabled = True

        ElseIf RadioButton51.Checked = False Then
            Me.TextBox1009.Enabled = False
            Me.TextBox1008.Enabled = False
            Me.TextBox1007.Enabled = False
            Me.TextBox1006.Enabled = False
            Me.TextBox1005.Enabled = False
            Me.TextBox1004.Enabled = False
            Me.TextBox1003.Enabled = False
            Me.TextBox1002.Enabled = False
            Me.TextBox1001.Enabled = False
            Me.TextBox1000.Enabled = False
            Me.TextBox999.Enabled = False
            Me.TextBox998.Enabled = False
            Me.TextBox827.Enabled = False
            Me.DateTimePicker61.Enabled = False
        End If
    End Sub

    'Rodio Button MAr
    Private Sub RadioButton50_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton50.CheckedChanged
        If RadioButton50.Checked = True Then
            Me.TextBox995.Enabled = True
            Me.TextBox994.Enabled = True
            Me.TextBox993.Enabled = True
            Me.TextBox992.Enabled = True
            Me.TextBox991.Enabled = True
            Me.TextBox990.Enabled = True
            Me.TextBox989.Enabled = True
            Me.TextBox988.Enabled = True
            Me.TextBox987.Enabled = True
            Me.TextBox986.Enabled = True
            Me.TextBox985.Enabled = True
            Me.TextBox984.Enabled = True
            Me.TextBox826.Enabled = True
            Me.DateTimePicker60.Enabled = True

        ElseIf RadioButton50.Checked = False Then
            Me.TextBox995.Enabled = False
            Me.TextBox994.Enabled = False
            Me.TextBox993.Enabled = False
            Me.TextBox992.Enabled = False
            Me.TextBox991.Enabled = False
            Me.TextBox990.Enabled = False
            Me.TextBox989.Enabled = False
            Me.TextBox988.Enabled = False
            Me.TextBox987.Enabled = False
            Me.TextBox986.Enabled = False
            Me.TextBox985.Enabled = False
            Me.TextBox984.Enabled = False
            Me.TextBox826.Enabled = False
            Me.DateTimePicker60.Enabled = False
        End If
    End Sub

    'Rodio Button Apr
    Private Sub RadioButton49_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton49.CheckedChanged
        If RadioButton49.Checked = True Then
            Me.TextBox981.Enabled = True
            Me.TextBox980.Enabled = True
            Me.TextBox979.Enabled = True
            Me.TextBox978.Enabled = True
            Me.TextBox977.Enabled = True
            Me.TextBox976.Enabled = True
            Me.TextBox975.Enabled = True
            Me.TextBox974.Enabled = True
            Me.TextBox973.Enabled = True
            Me.TextBox972.Enabled = True
            Me.TextBox971.Enabled = True
            Me.TextBox970.Enabled = True
            Me.TextBox825.Enabled = True
            Me.DateTimePicker59.Enabled = True

        ElseIf RadioButton49.Checked = False Then
            Me.TextBox981.Enabled = False
            Me.TextBox980.Enabled = False
            Me.TextBox979.Enabled = False
            Me.TextBox978.Enabled = False
            Me.TextBox977.Enabled = False
            Me.TextBox976.Enabled = False
            Me.TextBox975.Enabled = False
            Me.TextBox974.Enabled = False
            Me.TextBox973.Enabled = False
            Me.TextBox972.Enabled = False
            Me.TextBox971.Enabled = False
            Me.TextBox970.Enabled = False
            Me.TextBox825.Enabled = False
            Me.DateTimePicker59.Enabled = False
        End If
    End Sub

    'Rodio Button May
    Private Sub RadioButton48_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton48.CheckedChanged
        If RadioButton48.Checked = True Then
            Me.TextBox967.Enabled = True
            Me.TextBox966.Enabled = True
            Me.TextBox965.Enabled = True
            Me.TextBox964.Enabled = True
            Me.TextBox963.Enabled = True
            Me.TextBox962.Enabled = True
            Me.TextBox961.Enabled = True
            Me.TextBox960.Enabled = True
            Me.TextBox959.Enabled = True
            Me.TextBox958.Enabled = True
            Me.TextBox957.Enabled = True
            Me.TextBox956.Enabled = True
            Me.TextBox824.Enabled = True
            Me.DateTimePicker58.Enabled = True

        ElseIf RadioButton48.Checked = False Then
            Me.TextBox967.Enabled = False
            Me.TextBox966.Enabled = False
            Me.TextBox965.Enabled = False
            Me.TextBox964.Enabled = False
            Me.TextBox963.Enabled = False
            Me.TextBox962.Enabled = False
            Me.TextBox961.Enabled = False
            Me.TextBox960.Enabled = False
            Me.TextBox959.Enabled = False
            Me.TextBox958.Enabled = False
            Me.TextBox957.Enabled = False
            Me.TextBox956.Enabled = False
            Me.TextBox824.Enabled = False
            Me.DateTimePicker58.Enabled = False
        End If
    End Sub

    'Rodio Button Jun
    Private Sub RadioButton47_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton47.CheckedChanged
        If RadioButton47.Checked = True Then
            Me.TextBox953.Enabled = True
            Me.TextBox952.Enabled = True
            Me.TextBox951.Enabled = True
            Me.TextBox950.Enabled = True
            Me.TextBox949.Enabled = True
            Me.TextBox948.Enabled = True
            Me.TextBox947.Enabled = True
            Me.TextBox946.Enabled = True
            Me.TextBox945.Enabled = True
            Me.TextBox944.Enabled = True
            Me.TextBox943.Enabled = True
            Me.TextBox942.Enabled = True
            Me.TextBox823.Enabled = True
            Me.DateTimePicker57.Enabled = True

        ElseIf RadioButton47.Checked = False Then
            Me.TextBox953.Enabled = False
            Me.TextBox952.Enabled = False
            Me.TextBox951.Enabled = False
            Me.TextBox950.Enabled = False
            Me.TextBox949.Enabled = False
            Me.TextBox948.Enabled = False
            Me.TextBox947.Enabled = False
            Me.TextBox946.Enabled = False
            Me.TextBox945.Enabled = False
            Me.TextBox944.Enabled = False
            Me.TextBox943.Enabled = False
            Me.TextBox942.Enabled = False
            Me.TextBox823.Enabled = False
            Me.DateTimePicker57.Enabled = False
        End If
    End Sub

    'Rodio Button Jul
    Private Sub RadioButton46_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton46.CheckedChanged
        If RadioButton46.Checked = True Then
            Me.TextBox939.Enabled = True
            Me.TextBox938.Enabled = True
            Me.TextBox937.Enabled = True
            Me.TextBox936.Enabled = True
            Me.TextBox935.Enabled = True
            Me.TextBox934.Enabled = True
            Me.TextBox933.Enabled = True
            Me.TextBox932.Enabled = True
            Me.TextBox931.Enabled = True
            Me.TextBox930.Enabled = True
            Me.TextBox929.Enabled = True
            Me.TextBox928.Enabled = True
            Me.TextBox822.Enabled = True
            Me.DateTimePicker56.Enabled = True

        ElseIf RadioButton46.Checked = False Then
            Me.TextBox939.Enabled = False
            Me.TextBox938.Enabled = False
            Me.TextBox937.Enabled = False
            Me.TextBox936.Enabled = False
            Me.TextBox935.Enabled = False
            Me.TextBox934.Enabled = False
            Me.TextBox933.Enabled = False
            Me.TextBox932.Enabled = False
            Me.TextBox931.Enabled = False
            Me.TextBox930.Enabled = False
            Me.TextBox929.Enabled = False
            Me.TextBox928.Enabled = False
            Me.TextBox822.Enabled = False
            Me.DateTimePicker56.Enabled = False
        End If
    End Sub

    'Rodio Button Aug
    Private Sub RadioButton45_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton45.CheckedChanged
        If RadioButton45.Checked = True Then
            Me.TextBox925.Enabled = True
            Me.TextBox924.Enabled = True
            Me.TextBox923.Enabled = True
            Me.TextBox922.Enabled = True
            Me.TextBox921.Enabled = True
            Me.TextBox920.Enabled = True
            Me.TextBox919.Enabled = True
            Me.TextBox918.Enabled = True
            Me.TextBox917.Enabled = True
            Me.TextBox916.Enabled = True
            Me.TextBox915.Enabled = True
            Me.TextBox914.Enabled = True
            Me.TextBox821.Enabled = True
            Me.DateTimePicker55.Enabled = True

        ElseIf RadioButton45.Checked = False Then
            Me.TextBox925.Enabled = False
            Me.TextBox924.Enabled = False
            Me.TextBox923.Enabled = False
            Me.TextBox922.Enabled = False
            Me.TextBox921.Enabled = False
            Me.TextBox920.Enabled = False
            Me.TextBox919.Enabled = False
            Me.TextBox918.Enabled = False
            Me.TextBox917.Enabled = False
            Me.TextBox916.Enabled = False
            Me.TextBox915.Enabled = False
            Me.TextBox914.Enabled = False
            Me.TextBox821.Enabled = False
            Me.DateTimePicker55.Enabled = False
        End If
    End Sub

    'Rodio Button Sep
    Private Sub RadioButton44_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton44.CheckedChanged
        If RadioButton44.Checked = True Then
            Me.TextBox911.Enabled = True
            Me.TextBox910.Enabled = True
            Me.TextBox909.Enabled = True
            Me.TextBox908.Enabled = True
            Me.TextBox907.Enabled = True
            Me.TextBox906.Enabled = True
            Me.TextBox905.Enabled = True
            Me.TextBox904.Enabled = True
            Me.TextBox903.Enabled = True
            Me.TextBox902.Enabled = True
            Me.TextBox901.Enabled = True
            Me.TextBox900.Enabled = True
            Me.TextBox820.Enabled = True
            Me.DateTimePicker54.Enabled = True

        ElseIf RadioButton44.Checked = False Then
            Me.TextBox911.Enabled = False
            Me.TextBox910.Enabled = False
            Me.TextBox909.Enabled = False
            Me.TextBox908.Enabled = False
            Me.TextBox907.Enabled = False
            Me.TextBox906.Enabled = False
            Me.TextBox905.Enabled = False
            Me.TextBox904.Enabled = False
            Me.TextBox903.Enabled = False
            Me.TextBox902.Enabled = False
            Me.TextBox901.Enabled = False
            Me.TextBox900.Enabled = False
            Me.TextBox820.Enabled = False
            Me.DateTimePicker54.Enabled = False
        End If
    End Sub

    'Rodio Button Oct
    Private Sub RadioButton43_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton43.CheckedChanged
        If RadioButton43.Checked = True Then
            Me.TextBox897.Enabled = True
            Me.TextBox896.Enabled = True
            Me.TextBox895.Enabled = True
            Me.TextBox894.Enabled = True
            Me.TextBox893.Enabled = True
            Me.TextBox892.Enabled = True
            Me.TextBox891.Enabled = True
            Me.TextBox890.Enabled = True
            Me.TextBox889.Enabled = True
            Me.TextBox888.Enabled = True
            Me.TextBox887.Enabled = True
            Me.TextBox886.Enabled = True
            Me.TextBox819.Enabled = True
            Me.DateTimePicker53.Enabled = True

        ElseIf RadioButton43.Checked = False Then
            Me.TextBox897.Enabled = False
            Me.TextBox896.Enabled = False
            Me.TextBox895.Enabled = False
            Me.TextBox894.Enabled = False
            Me.TextBox893.Enabled = False
            Me.TextBox892.Enabled = False
            Me.TextBox891.Enabled = False
            Me.TextBox890.Enabled = False
            Me.TextBox889.Enabled = False
            Me.TextBox888.Enabled = False
            Me.TextBox887.Enabled = False
            Me.TextBox886.Enabled = False
            Me.TextBox819.Enabled = False
            Me.DateTimePicker53.Enabled = False
        End If
    End Sub

    'Rodio Button Nov
    Private Sub RadioButton42_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton42.CheckedChanged
        If RadioButton42.Checked = True Then
            Me.TextBox883.Enabled = True
            Me.TextBox882.Enabled = True
            Me.TextBox881.Enabled = True
            Me.TextBox880.Enabled = True
            Me.TextBox879.Enabled = True
            Me.TextBox878.Enabled = True
            Me.TextBox877.Enabled = True
            Me.TextBox876.Enabled = True
            Me.TextBox875.Enabled = True
            Me.TextBox874.Enabled = True
            Me.TextBox873.Enabled = True
            Me.TextBox872.Enabled = True
            Me.TextBox818.Enabled = True
            Me.DateTimePicker52.Enabled = True

        ElseIf RadioButton42.Checked = False Then
            Me.TextBox883.Enabled = False
            Me.TextBox882.Enabled = False
            Me.TextBox881.Enabled = False
            Me.TextBox880.Enabled = False
            Me.TextBox879.Enabled = False
            Me.TextBox878.Enabled = False
            Me.TextBox877.Enabled = False
            Me.TextBox876.Enabled = False
            Me.TextBox875.Enabled = False
            Me.TextBox874.Enabled = False
            Me.TextBox873.Enabled = False
            Me.TextBox872.Enabled = False
            Me.TextBox818.Enabled = False
            Me.DateTimePicker52.Enabled = False
        End If
    End Sub

    'Rodio Button Dec
    Private Sub RadioButton41_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton41.CheckedChanged
        If RadioButton41.Checked = True Then
            Me.TextBox869.Enabled = True
            Me.TextBox868.Enabled = True
            Me.TextBox867.Enabled = True
            Me.TextBox866.Enabled = True
            Me.TextBox865.Enabled = True
            Me.TextBox864.Enabled = True
            Me.TextBox863.Enabled = True
            Me.TextBox862.Enabled = True
            Me.TextBox861.Enabled = True
            Me.TextBox860.Enabled = True
            Me.TextBox859.Enabled = True
            Me.TextBox858.Enabled = True
            Me.TextBox817.Enabled = True
            Me.DateTimePicker51.Enabled = True

        ElseIf RadioButton41.Checked = False Then
            Me.TextBox869.Enabled = False
            Me.TextBox868.Enabled = False
            Me.TextBox867.Enabled = False
            Me.TextBox866.Enabled = False
            Me.TextBox865.Enabled = False
            Me.TextBox864.Enabled = False
            Me.TextBox863.Enabled = False
            Me.TextBox862.Enabled = False
            Me.TextBox861.Enabled = False
            Me.TextBox860.Enabled = False
            Me.TextBox859.Enabled = False
            Me.TextBox858.Enabled = False
            Me.TextBox817.Enabled = False
            Me.DateTimePicker51.Enabled = False
        End If
    End Sub


    'Account TextBox Jan
    Private Sub TextBox1023_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1023.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1022_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1022.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1021_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1021.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1020_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1020.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1019_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1019.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1018_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1018.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1017_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1017.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1016_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1016.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1015_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1015.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1014_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1014.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1013_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1013.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1012_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1012.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1011_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1010_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Feb
    Private Sub TextBox1009_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1009.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1008_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1008.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1007_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1007.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1006_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1006.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1005_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1005.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1004_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1004.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1003_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1003.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1002_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1002.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1001_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1001.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox1000_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1000.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox999_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox999.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox998_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox998.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox997_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox996_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Mar
    Private Sub TextBox995_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox995.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox994_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox994.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox993_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox993.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox992_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox992.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox991_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox991.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox990_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox990.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox989_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox989.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox988_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox988.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox987_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox987.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox986_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox986.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox985_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox985.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox984_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox984.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox983_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox982_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Apr
    Private Sub TextBox981_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox981.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox980_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox980.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox979_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox979.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox978_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox978.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox977_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox977.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox976_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox976.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox975_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox975.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox974_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox974.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox973_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox973.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox972_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox972.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox971_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox971.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox970_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox970.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox969_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox968_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox May
    Private Sub TextBox967_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox967.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox966_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox966.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox965_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox965.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox964_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox964.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox963_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox963.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox962_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox962.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox961_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox961.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox960_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox960.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox959_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox959.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox958_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox958.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox957_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox957.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox956_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox956.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox955_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox954_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Jun
    Private Sub TextBox953_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox953.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox952_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox952.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox951_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox951.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox950_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox950.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox949_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox949.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox948_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox948.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox947_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox947.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox946_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox946.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox945_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox945.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox944_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox944.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox943_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox943.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox942_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox942.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox941_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox940_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Jun
    Private Sub TextBox939_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox939.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox938_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox938.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox937_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox937.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox936_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox936.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox935_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox935.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox934_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox934.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox933_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox933.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox932_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox932.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox931_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox931.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox930_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox930.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox929_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox929.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox928_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox928.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox927_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox926_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Aug
    Private Sub TextBox925_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox925.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox924_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox924.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox923_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox923.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox922_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox922.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox921_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox921.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox920_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox920.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox919_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox919.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox918_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox918.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox917_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox917.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox916_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox916.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox915_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox915.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox914_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox914.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox913_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox912_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Sep
    Private Sub TextBox911_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox911.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox910_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox910.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox909_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox909.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox908_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox908.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox907_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox907.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox906_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox906.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox905_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox905.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox904_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox904.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox903_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox903.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox902_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox902.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox901_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox901.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox900_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox900.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox899_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox898_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Oct
    Private Sub TextBox897_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox897.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox896_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox896.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox895_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox895.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox894_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox894.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox893_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox893.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox892_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox892.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox891_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox891.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox890_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox890.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox889_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox889.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox888_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox888.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox887_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox887.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox886_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox886.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox885_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox884_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Nov
    Private Sub TextBox883_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox883.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox882_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox882.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox881_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox881.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox880_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox880.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox879_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox879.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox878_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox878.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox877_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox877.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox876_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox876.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox875_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox875.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox874_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox874.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox873_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox873.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox872_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox872.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox871_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox870_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub

    'Account TextBox Dec
    Private Sub TextBox869_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox869.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox868_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox868.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox867_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox867.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox866_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox866.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox865_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox865.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox864_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox864.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox863_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox863.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox862_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox862.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox861_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox861.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox860_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox860.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox859_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox859.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox858_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox858.TextChanged
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox857_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub
    Private Sub TextBox856_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Two_AccountTotal()
    End Sub


    'Date Time Picker
    Private Sub DateTimePicker50_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker50.ValueChanged
        Me.TextBox828.Text = DateTimePicker50.Text
    End Sub

    Private Sub DateTimePicker61_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker61.ValueChanged
        Me.TextBox827.Text = DateTimePicker61.Text
    End Sub

    Private Sub DateTimePicker60_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker60.ValueChanged
        Me.TextBox826.Text = DateTimePicker60.Text
    End Sub

    Private Sub DateTimePicker59_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker59.ValueChanged
        Me.TextBox825.Text = DateTimePicker59.Text
    End Sub

    Private Sub DateTimePicker58_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker58.ValueChanged
        Me.TextBox824.Text = DateTimePicker58.Text
    End Sub

    Private Sub DateTimePicker57_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker57.ValueChanged
        Me.TextBox823.Text = DateTimePicker57.Text
    End Sub

    Private Sub DateTimePicker56_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker56.ValueChanged
        Me.TextBox822.Text = DateTimePicker56.Text
    End Sub

    Private Sub DateTimePicker55_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker55.ValueChanged
        Me.TextBox821.Text = DateTimePicker55.Text
    End Sub

    Private Sub DateTimePicker54_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker54.ValueChanged
        Me.TextBox820.Text = DateTimePicker54.Text
    End Sub

    Private Sub DateTimePicker53_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker53.ValueChanged
        Me.TextBox819.Text = DateTimePicker53.Text
    End Sub

    Private Sub DateTimePicker52_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker52.ValueChanged
        Me.TextBox818.Text = DateTimePicker52.Text
    End Sub

    Private Sub DateTimePicker51_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker51.ValueChanged
        Me.TextBox817.Text = DateTimePicker51.Text
    End Sub

    Private Sub AboutDevelopurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutDevelopurToolStripMenuItem.Click
        Form_ADeveloper.ShowDialog()
    End Sub


    
End Class