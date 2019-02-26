<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.UserName = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Password = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BtnCancel = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BtnLogin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.LoginDragPanel = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TxtBxPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TxtBxUsername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.ChkBxPasswordShow = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.LblShowPassword = New Bunifu.UI.WinForms.BunifuLabel()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserName
        '
        Me.UserName.AutoEllipsis = False
        Me.UserName.CursorType = Nothing
        Me.UserName.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.UserName.ForeColor = System.Drawing.Color.White
        Me.UserName.Location = New System.Drawing.Point(287, 264)
        Me.UserName.Name = "UserName"
        Me.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserName.Size = New System.Drawing.Size(137, 32)
        Me.UserName.TabIndex = 2
        Me.UserName.Text = "Username :"
        Me.UserName.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'Password
        '
        Me.Password.AutoEllipsis = False
        Me.Password.CursorType = Nothing
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Password.ForeColor = System.Drawing.Color.White
        Me.Password.Location = New System.Drawing.Point(298, 342)
        Me.Password.Name = "Password"
        Me.Password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Password.Size = New System.Drawing.Size(126, 32)
        Me.Password.TabIndex = 3
        Me.Password.Text = "Password :"
        Me.Password.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.ButtonText = "Cancel"
        Me.BtnCancel.ButtonTextMarginLeft = 0
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnCancel.DisabledFillColor = System.Drawing.Color.Gray
        Me.BtnCancel.DisabledForecolor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnCancel.IconPadding = 10
        Me.BtnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnCancel.IdleBorderRadius = 1
        Me.BtnCancel.IdleBorderThickness = 0
        Me.BtnCancel.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnCancel.IdleIconLeftImage = Nothing
        Me.BtnCancel.IdleIconRightImage = Nothing
        Me.BtnCancel.Location = New System.Drawing.Point(495, 490)
        Me.BtnCancel.Name = "BtnCancel"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BtnCancel.onHoverState = StateProperties1
        Me.BtnCancel.Size = New System.Drawing.Size(100, 45)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BackgroundImage = CType(resources.GetObject("BtnLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogin.ButtonText = "Login"
        Me.BtnLogin.ButtonTextMarginLeft = 0
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnLogin.DisabledFillColor = System.Drawing.Color.Gray
        Me.BtnLogin.DisabledForecolor = System.Drawing.Color.White
        Me.BtnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnLogin.IconPadding = 10
        Me.BtnLogin.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnLogin.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnLogin.IdleBorderRadius = 1
        Me.BtnLogin.IdleBorderThickness = 0
        Me.BtnLogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnLogin.IdleIconLeftImage = Nothing
        Me.BtnLogin.IdleIconRightImage = Nothing
        Me.BtnLogin.Location = New System.Drawing.Point(313, 490)
        Me.BtnLogin.Name = "BtnLogin"
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BtnLogin.onHoverState = StateProperties2
        Me.BtnLogin.Size = New System.Drawing.Size(105, 45)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 71
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(384, 84)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(142, 142)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 6
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'LoginDragPanel
        '
        Me.LoginDragPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LoginDragPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LoginDragPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginDragPanel.Name = "LoginDragPanel"
        Me.LoginDragPanel.Size = New System.Drawing.Size(924, 44)
        Me.LoginDragPanel.TabIndex = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.LoginDragPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'TxtBxPassword
        '
        Me.TxtBxPassword.BorderColorFocused = System.Drawing.Color.Blue
        Me.TxtBxPassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBxPassword.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TxtBxPassword.BorderThickness = 3
        Me.TxtBxPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtBxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBxPassword.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.TxtBxPassword.ForeColor = System.Drawing.Color.White
        Me.TxtBxPassword.isPassword = False
        Me.TxtBxPassword.Location = New System.Drawing.Point(447, 342)
        Me.TxtBxPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBxPassword.MaxLength = 32767
        Me.TxtBxPassword.Name = "TxtBxPassword"
        Me.TxtBxPassword.Size = New System.Drawing.Size(209, 44)
        Me.TxtBxPassword.TabIndex = 8
        Me.TxtBxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtBxUsername
        '
        Me.TxtBxUsername.BorderColorFocused = System.Drawing.Color.Blue
        Me.TxtBxUsername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBxUsername.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TxtBxUsername.BorderThickness = 3
        Me.TxtBxUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtBxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBxUsername.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.TxtBxUsername.ForeColor = System.Drawing.Color.White
        Me.TxtBxUsername.isPassword = False
        Me.TxtBxUsername.Location = New System.Drawing.Point(447, 264)
        Me.TxtBxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBxUsername.MaxLength = 32767
        Me.TxtBxUsername.Name = "TxtBxUsername"
        Me.TxtBxUsername.Size = New System.Drawing.Size(209, 44)
        Me.TxtBxUsername.TabIndex = 9
        Me.TxtBxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ChkBxPasswordShow
        '
        Me.ChkBxPasswordShow.AllowBindingControlAnimation = True
        Me.ChkBxPasswordShow.AllowBindingControlLocation = True
        Me.ChkBxPasswordShow.AllowCheckBoxAnimation = False
        Me.ChkBxPasswordShow.AllowCheckmarkAnimation = True
        Me.ChkBxPasswordShow.AllowOnHoverStates = True
        Me.ChkBxPasswordShow.BackColor = System.Drawing.Color.Transparent
        Me.ChkBxPasswordShow.BackgroundImage = CType(resources.GetObject("ChkBxPasswordShow.BackgroundImage"), System.Drawing.Image)
        Me.ChkBxPasswordShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ChkBxPasswordShow.BindingControl = Nothing
        Me.ChkBxPasswordShow.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.ChkBxPasswordShow.Checked = False
        Me.ChkBxPasswordShow.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Me.ChkBxPasswordShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkBxPasswordShow.CustomCheckmarkImage = Nothing
        Me.ChkBxPasswordShow.Location = New System.Drawing.Point(447, 418)
        Me.ChkBxPasswordShow.MinimumSize = New System.Drawing.Size(17, 17)
        Me.ChkBxPasswordShow.Name = "ChkBxPasswordShow"
        Me.ChkBxPasswordShow.OnCheck.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.ChkBxPasswordShow.OnCheck.BorderRadius = 2
        Me.ChkBxPasswordShow.OnCheck.BorderThickness = 2
        Me.ChkBxPasswordShow.OnCheck.CheckBoxColor = System.Drawing.SystemColors.Highlight
        Me.ChkBxPasswordShow.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.ChkBxPasswordShow.OnCheck.CheckmarkThickness = 2
        Me.ChkBxPasswordShow.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.ChkBxPasswordShow.OnDisable.BorderRadius = 2
        Me.ChkBxPasswordShow.OnDisable.BorderThickness = 2
        Me.ChkBxPasswordShow.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ChkBxPasswordShow.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.ChkBxPasswordShow.OnDisable.CheckmarkThickness = 2
        Me.ChkBxPasswordShow.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkBxPasswordShow.OnHoverChecked.BorderRadius = 2
        Me.ChkBxPasswordShow.OnHoverChecked.BorderThickness = 2
        Me.ChkBxPasswordShow.OnHoverChecked.CheckBoxColor = System.Drawing.SystemColors.Highlight
        Me.ChkBxPasswordShow.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.ChkBxPasswordShow.OnHoverChecked.CheckmarkThickness = 2
        Me.ChkBxPasswordShow.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkBxPasswordShow.OnHoverUnchecked.BorderRadius = 2
        Me.ChkBxPasswordShow.OnHoverUnchecked.BorderThickness = 2
        Me.ChkBxPasswordShow.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ChkBxPasswordShow.OnUncheck.BorderColor = System.Drawing.Color.RoyalBlue
        Me.ChkBxPasswordShow.OnUncheck.BorderRadius = 2
        Me.ChkBxPasswordShow.OnUncheck.BorderThickness = 2
        Me.ChkBxPasswordShow.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.ChkBxPasswordShow.Size = New System.Drawing.Size(21, 21)
        Me.ChkBxPasswordShow.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.ChkBxPasswordShow.TabIndex = 10
        Me.ChkBxPasswordShow.ThreeState = False
        Me.ChkBxPasswordShow.ToolTipText = Nothing
        '
        'LblShowPassword
        '
        Me.LblShowPassword.AutoEllipsis = False
        Me.LblShowPassword.CursorType = Nothing
        Me.LblShowPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblShowPassword.ForeColor = System.Drawing.Color.White
        Me.LblShowPassword.Location = New System.Drawing.Point(474, 416)
        Me.LblShowPassword.Name = "LblShowPassword"
        Me.LblShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblShowPassword.Size = New System.Drawing.Size(121, 23)
        Me.LblShowPassword.TabIndex = 11
        Me.LblShowPassword.Text = "Show Password"
        Me.LblShowPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 571)
        Me.Controls.Add(Me.LblShowPassword)
        Me.Controls.Add(Me.ChkBxPasswordShow)
        Me.Controls.Add(Me.TxtBxUsername)
        Me.Controls.Add(Me.TxtBxPassword)
        Me.Controls.Add(Me.LoginDragPanel)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserName As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Password As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BtnCancel As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BtnLogin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents LoginDragPanel As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TxtBxUsername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TxtBxPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LblShowPassword As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents ChkBxPasswordShow As Bunifu.UI.WinForms.BunifuCheckBox
End Class
