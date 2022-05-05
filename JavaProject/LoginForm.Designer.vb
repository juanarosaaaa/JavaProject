<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnSignin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlRegister = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnBackToSignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtRegUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContactNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSex = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtReenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRegPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlRegister.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnSignin
        '
        Me.btnSignin.Animated = True
        Me.btnSignin.AutoRoundedCorners = True
        Me.btnSignin.BorderRadius = 23
        Me.btnSignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignin.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSignin.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignin.ForeColor = System.Drawing.Color.White
        Me.btnSignin.Location = New System.Drawing.Point(257, 502)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(147, 48)
        Me.btnSignin.TabIndex = 2
        Me.btnSignin.Text = "Sign in"
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.AutoRoundedCorners = True
        Me.txtUsername.BorderRadius = 23
        Me.txtUsername.BorderThickness = 0
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(213, 358)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(233, 48)
        Me.txtUsername.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.AutoRoundedCorners = True
        Me.txtPassword.BorderRadius = 23
        Me.txtPassword.BorderThickness = 0
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(213, 429)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(233, 48)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 553)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Don't have an account?"
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblSignUp.Location = New System.Drawing.Point(372, 553)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(52, 16)
        Me.lblSignUp.TabIndex = 8
        Me.lblSignUp.Text = "Sign up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(191, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 50)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sign in to Java"
        '
        'pnlRegister
        '
        Me.pnlRegister.Controls.Add(Me.btnBackToSignIn)
        Me.pnlRegister.Controls.Add(Me.txtRegUsername)
        Me.pnlRegister.Controls.Add(Me.txtAge)
        Me.pnlRegister.Controls.Add(Me.txtContactNo)
        Me.pnlRegister.Controls.Add(Me.cmbSex)
        Me.pnlRegister.Controls.Add(Me.txtReenter)
        Me.pnlRegister.Controls.Add(Me.txtSurname)
        Me.pnlRegister.Controls.Add(Me.txtRegPassword)
        Me.pnlRegister.Controls.Add(Me.txtFirstname)
        Me.pnlRegister.Controls.Add(Me.btnSignUp)
        Me.pnlRegister.Controls.Add(Me.Label2)
        Me.pnlRegister.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRegister.Location = New System.Drawing.Point(529, 131)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(641, 510)
        Me.pnlRegister.TabIndex = 10
        Me.pnlRegister.Visible = False
        '
        'btnBackToSignIn
        '
        Me.btnBackToSignIn.Animated = True
        Me.btnBackToSignIn.AnimatedGIF = True
        Me.btnBackToSignIn.AutoRoundedCorners = True
        Me.btnBackToSignIn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnBackToSignIn.BorderRadius = 23
        Me.btnBackToSignIn.BorderThickness = 2
        Me.btnBackToSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackToSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackToSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackToSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackToSignIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnBackToSignIn.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.btnBackToSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnBackToSignIn.Location = New System.Drawing.Point(406, 424)
        Me.btnBackToSignIn.Name = "btnBackToSignIn"
        Me.btnBackToSignIn.Size = New System.Drawing.Size(147, 48)
        Me.btnBackToSignIn.TabIndex = 18
        Me.btnBackToSignIn.Text = "Sign in"
        '
        'txtRegUsername
        '
        Me.txtRegUsername.Animated = True
        Me.txtRegUsername.AutoRoundedCorners = True
        Me.txtRegUsername.BorderRadius = 23
        Me.txtRegUsername.BorderThickness = 0
        Me.txtRegUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegUsername.DefaultText = ""
        Me.txtRegUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtRegUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtRegUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegUsername.Location = New System.Drawing.Point(90, 273)
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegUsername.PlaceholderText = "Username"
        Me.txtRegUsername.SelectedText = ""
        Me.txtRegUsername.Size = New System.Drawing.Size(215, 48)
        Me.txtRegUsername.TabIndex = 17
        '
        'txtAge
        '
        Me.txtAge.Animated = True
        Me.txtAge.AutoRoundedCorners = True
        Me.txtAge.BorderRadius = 23
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.DefaultText = ""
        Me.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Location = New System.Drawing.Point(90, 207)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.PlaceholderText = "Age"
        Me.txtAge.SelectedText = ""
        Me.txtAge.Size = New System.Drawing.Size(77, 48)
        Me.txtAge.TabIndex = 16
        '
        'txtContactNo
        '
        Me.txtContactNo.Animated = True
        Me.txtContactNo.AutoRoundedCorners = True
        Me.txtContactNo.BorderRadius = 23
        Me.txtContactNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNo.DefaultText = ""
        Me.txtContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContactNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtContactNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNo.Location = New System.Drawing.Point(330, 207)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNo.PlaceholderText = "Contact Number"
        Me.txtContactNo.SelectedText = ""
        Me.txtContactNo.Size = New System.Drawing.Size(215, 48)
        Me.txtContactNo.TabIndex = 15
        '
        'cmbSex
        '
        Me.cmbSex.AutoRoundedCorners = True
        Me.cmbSex.BackColor = System.Drawing.Color.Transparent
        Me.cmbSex.BorderRadius = 17
        Me.cmbSex.BorderThickness = 0
        Me.cmbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSex.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSex.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.cmbSex.ItemHeight = 30
        Me.cmbSex.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbSex.Location = New System.Drawing.Point(173, 207)
        Me.cmbSex.MaxDropDownItems = 2
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(147, 36)
        Me.cmbSex.TabIndex = 14
        '
        'txtReenter
        '
        Me.txtReenter.Animated = True
        Me.txtReenter.AutoRoundedCorners = True
        Me.txtReenter.BorderRadius = 23
        Me.txtReenter.BorderThickness = 0
        Me.txtReenter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReenter.DefaultText = ""
        Me.txtReenter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReenter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReenter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReenter.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtReenter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtReenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReenter.Location = New System.Drawing.Point(330, 340)
        Me.txtReenter.Name = "txtReenter"
        Me.txtReenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtReenter.PlaceholderText = "Re-enter Password"
        Me.txtReenter.SelectedText = ""
        Me.txtReenter.Size = New System.Drawing.Size(215, 48)
        Me.txtReenter.TabIndex = 13
        Me.txtReenter.UseSystemPasswordChar = True
        '
        'txtSurname
        '
        Me.txtSurname.Animated = True
        Me.txtSurname.AutoRoundedCorners = True
        Me.txtSurname.BorderRadius = 23
        Me.txtSurname.BorderThickness = 0
        Me.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSurname.DefaultText = ""
        Me.txtSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSurname.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtSurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSurname.Location = New System.Drawing.Point(330, 131)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSurname.PlaceholderText = "Surname"
        Me.txtSurname.SelectedText = ""
        Me.txtSurname.Size = New System.Drawing.Size(215, 48)
        Me.txtSurname.TabIndex = 12
        '
        'txtRegPassword
        '
        Me.txtRegPassword.Animated = True
        Me.txtRegPassword.AutoRoundedCorners = True
        Me.txtRegPassword.BorderRadius = 23
        Me.txtRegPassword.BorderThickness = 0
        Me.txtRegPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegPassword.DefaultText = ""
        Me.txtRegPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtRegPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtRegPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegPassword.Location = New System.Drawing.Point(90, 340)
        Me.txtRegPassword.Name = "txtRegPassword"
        Me.txtRegPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRegPassword.PlaceholderText = "Password"
        Me.txtRegPassword.SelectedText = ""
        Me.txtRegPassword.Size = New System.Drawing.Size(215, 48)
        Me.txtRegPassword.TabIndex = 11
        Me.txtRegPassword.UseSystemPasswordChar = True
        '
        'txtFirstname
        '
        Me.txtFirstname.Animated = True
        Me.txtFirstname.AutoRoundedCorners = True
        Me.txtFirstname.BorderRadius = 23
        Me.txtFirstname.BorderThickness = 0
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.DefaultText = ""
        Me.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(90, 131)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderText = "Firstname"
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.Size = New System.Drawing.Size(215, 48)
        Me.txtFirstname.TabIndex = 11
        '
        'btnSignUp
        '
        Me.btnSignUp.Animated = True
        Me.btnSignUp.AutoRoundedCorners = True
        Me.btnSignUp.BorderRadius = 23
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(232, 424)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(147, 48)
        Me.btnSignUp.TabIndex = 11
        Me.btnSignUp.Text = "Sign up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(159, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 50)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Create an Account"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.JavaProject.My.Resources.Resources.logincoffee
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(657, 168)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(618, 499)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox2.TabIndex = 1
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.JavaProject.My.Resources.Resources.loginLogo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-113, -59)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(591, 312)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'LoginForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1172, 720)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "0"
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnSignin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSignUp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlRegister As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbSex As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtReenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContactNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBackToSignIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtRegUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAge As Guna.UI2.WinForms.Guna2TextBox
End Class
