<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.studentinfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maskedtextbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.majortextbox = New System.Windows.Forms.TextBox()
        Me.nametextbox = New System.Windows.Forms.TextBox()
        Me.Textout = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textcheckbox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.snowtextbox = New System.Windows.Forms.PictureBox()
        Me.suntextbox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.studentinfoGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.snowtextbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.suntextbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentinfoGroupBox
        '
        Me.studentinfoGroupBox.Controls.Add(Me.Label3)
        Me.studentinfoGroupBox.Controls.Add(Me.maskedtextbox)
        Me.studentinfoGroupBox.Controls.Add(Me.Label2)
        Me.studentinfoGroupBox.Controls.Add(Me.Label1)
        Me.studentinfoGroupBox.Controls.Add(Me.majortextbox)
        Me.studentinfoGroupBox.Controls.Add(Me.nametextbox)
        Me.studentinfoGroupBox.Location = New System.Drawing.Point(33, 34)
        Me.studentinfoGroupBox.Name = "studentinfoGroupBox"
        Me.studentinfoGroupBox.Size = New System.Drawing.Size(538, 150)
        Me.studentinfoGroupBox.TabIndex = 0
        Me.studentinfoGroupBox.TabStop = False
        Me.studentinfoGroupBox.Text = "Student Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Phone"
        '
        'maskedtextbox
        '
        Me.maskedtextbox.Location = New System.Drawing.Point(105, 101)
        Me.maskedtextbox.Mask = "(999) 000-0000"
        Me.maskedtextbox.Name = "maskedtextbox"
        Me.maskedtextbox.Size = New System.Drawing.Size(150, 31)
        Me.maskedtextbox.TabIndex = 1
        Me.maskedtextbox.Text = "0797877563"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Major"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'majortextbox
        '
        Me.majortextbox.Location = New System.Drawing.Point(105, 64)
        Me.majortextbox.Name = "majortextbox"
        Me.majortextbox.Size = New System.Drawing.Size(150, 31)
        Me.majortextbox.TabIndex = 1
        Me.majortextbox.Text = "IT Consultant"
        '
        'nametextbox
        '
        Me.nametextbox.Location = New System.Drawing.Point(105, 27)
        Me.nametextbox.Name = "nametextbox"
        Me.nametextbox.Size = New System.Drawing.Size(150, 31)
        Me.nametextbox.TabIndex = 0
        Me.nametextbox.Text = "Benard Kimani"
        '
        'Textout
        '
        Me.Textout.Location = New System.Drawing.Point(138, 204)
        Me.Textout.Multiline = True
        Me.Textout.Name = "Textout"
        Me.Textout.Size = New System.Drawing.Size(433, 106)
        Me.Textout.TabIndex = 1
        Me.Textout.Text = "My name: Benard Kimani" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Major: IT Consultant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phone: 079777563"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Output"
        '
        'textcheckbox
        '
        Me.textcheckbox.AutoSize = True
        Me.textcheckbox.Checked = True
        Me.textcheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.textcheckbox.Location = New System.Drawing.Point(138, 316)
        Me.textcheckbox.Name = "textcheckbox"
        Me.textcheckbox.Size = New System.Drawing.Size(164, 29)
        Me.textcheckbox.TabIndex = 3
        Me.textcheckbox.Text = "Message Visible"
        Me.textcheckbox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(589, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 167)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Background"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(46, 121)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(83, 29)
        Me.RadioButton4.TabIndex = 9
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Green"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(46, 94)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(70, 29)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Blue"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(46, 30)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(67, 29)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Red"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(46, 59)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 29)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Gray"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Location = New System.Drawing.Point(589, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 97)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Text Color"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(46, 65)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(83, 29)
        Me.RadioButton6.TabIndex = 10
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "White"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(46, 30)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(77, 29)
        Me.RadioButton5.TabIndex = 9
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Black"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'snowtextbox
        '
        Me.snowtextbox.Image = CType(resources.GetObject("snowtextbox.Image"), System.Drawing.Image)
        Me.snowtextbox.Location = New System.Drawing.Point(97, 351)
        Me.snowtextbox.Name = "snowtextbox"
        Me.snowtextbox.Size = New System.Drawing.Size(70, 77)
        Me.snowtextbox.TabIndex = 6
        Me.snowtextbox.TabStop = False
        Me.snowtextbox.Visible = False
        '
        'suntextbox
        '
        Me.suntextbox.Image = CType(resources.GetObject("suntextbox.Image"), System.Drawing.Image)
        Me.suntextbox.Location = New System.Drawing.Point(109, 367)
        Me.suntextbox.Name = "suntextbox"
        Me.suntextbox.Size = New System.Drawing.Size(48, 48)
        Me.suntextbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.suntextbox.TabIndex = 7
        Me.suntextbox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(221, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 52)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Display Message"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(378, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 52)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(531, 367)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(112, 52)
        Me.Exitbtn.TabIndex = 10
        Me.Exitbtn.Text = "E&xit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.suntextbox)
        Me.Controls.Add(Me.snowtextbox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.textcheckbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Textout)
        Me.Controls.Add(Me.studentinfoGroupBox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KCA University -  Message Appication"
        Me.studentinfoGroupBox.ResumeLayout(False)
        Me.studentinfoGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.snowtextbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.suntextbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentinfoGroupBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents maskedtextbox As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents majortextbox As TextBox
    Friend WithEvents nametextbox As TextBox
    Friend WithEvents Textout As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents snowtextbox As PictureBox
    Friend WithEvents suntextbox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents textcheckbox As CheckBox
End Class
