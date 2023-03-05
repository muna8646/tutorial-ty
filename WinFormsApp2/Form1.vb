Public Class Form1
    Private GrayBackGroundColor As Color

    Private Sub StudentInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Assign background color to module-level variable
        GrayBackGroundColor = Me.BackColor
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles majortextbox.TextChanged

    End Sub
    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textout.Click
        'Store output message to the output TextBox
        Textout.Text = "My name: " & nametextbox.Text & ControlChars.NewLine & "Major: " & majortextbox.Text & ControlChars.NewLine & "Local phone: " & maskedtextbox.Text
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.Gray

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.BackColor = Color.Gray

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.BackColor = Color.Red
    End Sub


    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clear the input and output TextBox and MaskedTextBox controls - 
        'This code shows use of the Clear method, String.Empty value, and
        'empty double quote marks        
        nametextbox.Clear()
        majortextbox.Text = String.Empty
        maskedtextbox.Clear()
        Textout.Text = ""
        'Reset the form's BackColor to gray 
        'and ForeColor to black
        RadioButton1.Checked = True
        RadioButton5.Checked = True
        'Reset the message display CheckBox control to checked
        textcheckbox.Checked = True
        'Turn on the sun and turn off the snow
        suntextbox.Visible = True
        snowtextbox.Visible = False
        'Set focus to first TextBox
        nametextbox.Focus()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Me.BackColor = Color.Green
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Me.BackColor = Color.Black
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Me.BackColor = Color.White
    End Sub

    Private Sub Textout_TextChanged(sender As Object, e As EventArgs) Handles Textout.TextChanged

    End Sub

    Private Sub textcheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles textcheckbox.CheckedChanged
        'Make the OutputTextBox and OutputLabel invisible 
        textcheckbox.Visible = textcheckbox.Checked
        textcheckbox.Visible = textcheckbox.Checked
    End Sub

    Private Sub snowtextbox_Click(sender As Object, e As EventArgs) Handles snowtextbox.Click
        'Turn the sun into the snow
        snowtextbox.Visible = True
        suntextbox.Visible = False

    End Sub

    Private Sub suntextbox_Click(sender As Object, e As EventArgs) Handles suntextbox.Click
        'Turn the snow into the sun
        snowtextbox.Visible = False
        suntextbox.Visible = True

    End Sub
End Class
