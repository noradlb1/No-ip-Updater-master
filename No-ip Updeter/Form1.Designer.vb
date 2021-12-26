<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ThirteenForm1 = New No_ip_Updater.ThirteenForm()
        Me.ThirteenControlBox1 = New No_ip_Updater.ThirteenControlBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IP = New No_ip_Updater.ThirteenTextBox()
        Me.Host = New No_ip_Updater.ThirteenTextBox()
        Me.Senha = New No_ip_Updater.ThirteenTextBox()
        Me.Useremail = New No_ip_Updater.ThirteenTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ThirteenForm1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = No_ip_Updater.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.ThirteenControlBox1)
        Me.ThirteenForm1.Controls.Add(Me.GroupBox1)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(232, 300)
        Me.ThirteenForm1.TabIndex = 2
        Me.ThirteenForm1.Text = "No-ip Updater"
        '
        'ThirteenControlBox1
        '
        Me.ThirteenControlBox1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThirteenControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenControlBox1.ColorScheme = No_ip_Updater.ThirteenControlBox.ColorSchemes.Dark
        Me.ThirteenControlBox1.ForeColor = System.Drawing.Color.White
        Me.ThirteenControlBox1.Location = New System.Drawing.Point(130, 4)
        Me.ThirteenControlBox1.Name = "ThirteenControlBox1"
        Me.ThirteenControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.ThirteenControlBox1.TabIndex = 1
        Me.ThirteenControlBox1.Text = "ThirteenControlBox1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.IP)
        Me.GroupBox1.Controls.Add(Me.Host)
        Me.GroupBox1.Controls.Add(Me.Senha)
        Me.GroupBox1.Controls.Add(Me.Useremail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<>"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(149, 60)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(53, 21)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "Hide"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(149, 108)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(53, 21)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Hide"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(3, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Updeter IP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IP
        '
        Me.IP.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IP.ColorScheme = No_ip_Updater.ThirteenTextBox.ColorSchemes.Dark
        Me.IP.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.IP.ForeColor = System.Drawing.Color.White
        Me.IP.Location = New System.Drawing.Point(6, 178)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(198, 25)
        Me.IP.TabIndex = 9
        '
        'Host
        '
        Me.Host.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Host.ColorScheme = No_ip_Updater.ThirteenTextBox.ColorSchemes.Dark
        Me.Host.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Host.ForeColor = System.Drawing.Color.White
        Me.Host.Location = New System.Drawing.Point(6, 129)
        Me.Host.Name = "Host"
        Me.Host.Size = New System.Drawing.Size(198, 25)
        Me.Host.TabIndex = 9
        '
        'Senha
        '
        Me.Senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Senha.ColorScheme = No_ip_Updater.ThirteenTextBox.ColorSchemes.Dark
        Me.Senha.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Senha.ForeColor = System.Drawing.Color.White
        Me.Senha.Location = New System.Drawing.Point(6, 81)
        Me.Senha.Name = "Senha"
        Me.Senha.Size = New System.Drawing.Size(198, 25)
        Me.Senha.TabIndex = 9
        '
        'Useremail
        '
        Me.Useremail.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Useremail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Useremail.ColorScheme = No_ip_Updater.ThirteenTextBox.ColorSchemes.Dark
        Me.Useremail.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.Useremail.ForeColor = System.Drawing.Color.White
        Me.Useremail.Location = New System.Drawing.Point(6, 35)
        Me.Useremail.Name = "Useremail"
        Me.Useremail.Size = New System.Drawing.Size(198, 25)
        Me.Useremail.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "IP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pass"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User/Email"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(232, 300)
        Me.Controls.Add(Me.ThirteenForm1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "No-ip Updater"
        Me.ThirteenForm1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IP As ThirteenTextBox
    Friend WithEvents Host As ThirteenTextBox
    Friend WithEvents Senha As ThirteenTextBox
    Friend WithEvents Useremail As ThirteenTextBox
    Friend WithEvents ThirteenForm1 As ThirteenForm
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ThirteenControlBox1 As ThirteenControlBox
End Class
