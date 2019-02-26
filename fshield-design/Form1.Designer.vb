<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FShieldMainForm
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
        Dim Animation2 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim ToggleState1 As Bunifu.ToggleSwitch.ToggleState = New Bunifu.ToggleSwitch.ToggleState()
        Dim ToggleState2 As Bunifu.ToggleSwitch.ToggleState = New Bunifu.ToggleSwitch.ToggleState()
        Dim ToggleState3 As Bunifu.ToggleSwitch.ToggleState = New Bunifu.ToggleSwitch.ToggleState()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim Animation1 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FShieldMainForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SideMenu = New System.Windows.Forms.Panel()
        Me.SmallLogo = New System.Windows.Forms.PictureBox()
        Me.BtnStatistics = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAboutUs = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDNSControl = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnBlockList = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnParentalControl = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAdBlock = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.panelHead = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.CloseBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.LogoAnimator = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.ContainerForm = New System.Windows.Forms.Panel()
        Me.DNSControlPnl = New System.Windows.Forms.Panel()
        Me.CmbBxNetworkAdaptors = New System.Windows.Forms.ComboBox()
        Me.BtnChangeDNS = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TxtBxDNS = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LblDnsControl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.AboutUsPnl = New System.Windows.Forms.Panel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.AdBlockPnl = New System.Windows.Forms.Panel()
        Me.ToggleChildProtection = New Bunifu.ToggleSwitch.BunifuToggleSwitch()
        Me.StatisticsPnl = New System.Windows.Forms.Panel()
        Me.BtnMainOff = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.LblAdblock = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ParentalControlPnl = New System.Windows.Forms.Panel()
        Me.UserName = New Bunifu.UI.WinForms.BunifuLabel()
        Me.TxtBxNewUsername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LblShowPassword = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ChkBxPasswordShow = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.TxtBxUsername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TxtBxNewPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BtnUpdateUser = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Password = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BlockListPnl = New System.Windows.Forms.Panel()
        Me.ListBxBlockedDomains = New System.Windows.Forms.ListBox()
        Me.BtnBlkDomainRemove = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BtnBlkDomainAdd = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TxtBxBlockedDomains = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.PanelAnimator = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnMainOn = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.BunifuLabel8 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.SideMenu.SuspendLayout()
        CType(Me.SmallLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelHead.SuspendLayout()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContainerForm.SuspendLayout()
        Me.DNSControlPnl.SuspendLayout()
        Me.AboutUsPnl.SuspendLayout()
        Me.AdBlockPnl.SuspendLayout()
        Me.ParentalControlPnl.SuspendLayout()
        Me.BlockListPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'SideMenu
        '
        Me.SideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SideMenu.Controls.Add(Me.SmallLogo)
        Me.SideMenu.Controls.Add(Me.BtnStatistics)
        Me.SideMenu.Controls.Add(Me.BtnAboutUs)
        Me.SideMenu.Controls.Add(Me.BtnDNSControl)
        Me.SideMenu.Controls.Add(Me.BtnBlockList)
        Me.SideMenu.Controls.Add(Me.BtnParentalControl)
        Me.SideMenu.Controls.Add(Me.BtnAdBlock)
        Me.SideMenu.Controls.Add(Me.BtnMenu)
        Me.SideMenu.Controls.Add(Me.logo)
        Me.LogoAnimator.SetDecoration(Me.SideMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.SideMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.SideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideMenu.Location = New System.Drawing.Point(0, 42)
        Me.SideMenu.Name = "SideMenu"
        Me.SideMenu.Size = New System.Drawing.Size(243, 529)
        Me.SideMenu.TabIndex = 1
        '
        'SmallLogo
        '
        Me.PanelAnimator.SetDecoration(Me.SmallLogo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.SmallLogo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.SmallLogo.Image = CType(resources.GetObject("SmallLogo.Image"), System.Drawing.Image)
        Me.SmallLogo.Location = New System.Drawing.Point(1, 59)
        Me.SmallLogo.Name = "SmallLogo"
        Me.SmallLogo.Size = New System.Drawing.Size(49, 50)
        Me.SmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SmallLogo.TabIndex = 0
        Me.SmallLogo.TabStop = False
        Me.SmallLogo.Visible = False
        '
        'BtnStatistics
        '
        Me.BtnStatistics.Active = False
        Me.BtnStatistics.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStatistics.BorderRadius = 0
        Me.BtnStatistics.ButtonText = "        Statistics"
        Me.BtnStatistics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnStatistics, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnStatistics, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnStatistics.DisabledColor = System.Drawing.Color.Gray
        Me.BtnStatistics.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BtnStatistics.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnStatistics.Iconimage = CType(resources.GetObject("BtnStatistics.Iconimage"), System.Drawing.Image)
        Me.BtnStatistics.Iconimage_right = Nothing
        Me.BtnStatistics.Iconimage_right_Selected = Nothing
        Me.BtnStatistics.Iconimage_Selected = Nothing
        Me.BtnStatistics.IconMarginLeft = 0
        Me.BtnStatistics.IconMarginRight = 0
        Me.BtnStatistics.IconRightVisible = True
        Me.BtnStatistics.IconRightZoom = 0R
        Me.BtnStatistics.IconVisible = True
        Me.BtnStatistics.IconZoom = 60.0R
        Me.BtnStatistics.IsTab = True
        Me.BtnStatistics.Location = New System.Drawing.Point(0, 378)
        Me.BtnStatistics.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnStatistics.Name = "BtnStatistics"
        Me.BtnStatistics.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnStatistics.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnStatistics.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnStatistics.selected = False
        Me.BtnStatistics.Size = New System.Drawing.Size(244, 48)
        Me.BtnStatistics.TabIndex = 6
        Me.BtnStatistics.Text = "        Statistics"
        Me.BtnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStatistics.Textcolor = System.Drawing.Color.Silver
        Me.BtnStatistics.TextFont = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ToolTip.SetToolTip(Me.BtnStatistics, "White List")
        '
        'BtnAboutUs
        '
        Me.BtnAboutUs.Active = False
        Me.BtnAboutUs.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnAboutUs.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAboutUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAboutUs.BorderRadius = 0
        Me.BtnAboutUs.ButtonText = "        About Us"
        Me.BtnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnAboutUs, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnAboutUs, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnAboutUs.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAboutUs.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BtnAboutUs.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAboutUs.Iconimage = CType(resources.GetObject("BtnAboutUs.Iconimage"), System.Drawing.Image)
        Me.BtnAboutUs.Iconimage_right = Nothing
        Me.BtnAboutUs.Iconimage_right_Selected = Nothing
        Me.BtnAboutUs.Iconimage_Selected = Nothing
        Me.BtnAboutUs.IconMarginLeft = 0
        Me.BtnAboutUs.IconMarginRight = 0
        Me.BtnAboutUs.IconRightVisible = True
        Me.BtnAboutUs.IconRightZoom = 0R
        Me.BtnAboutUs.IconVisible = True
        Me.BtnAboutUs.IconZoom = 60.0R
        Me.BtnAboutUs.IsTab = True
        Me.BtnAboutUs.Location = New System.Drawing.Point(0, 432)
        Me.BtnAboutUs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAboutUs.Name = "BtnAboutUs"
        Me.BtnAboutUs.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAboutUs.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAboutUs.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnAboutUs.selected = False
        Me.BtnAboutUs.Size = New System.Drawing.Size(244, 48)
        Me.BtnAboutUs.TabIndex = 6
        Me.BtnAboutUs.Text = "        About Us"
        Me.BtnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAboutUs.Textcolor = System.Drawing.Color.Silver
        Me.BtnAboutUs.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip.SetToolTip(Me.BtnAboutUs, "About Us")
        '
        'BtnDNSControl
        '
        Me.BtnDNSControl.Active = False
        Me.BtnDNSControl.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnDNSControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDNSControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDNSControl.BorderRadius = 0
        Me.BtnDNSControl.ButtonText = "        DNS Control"
        Me.BtnDNSControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnDNSControl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnDNSControl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnDNSControl.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDNSControl.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BtnDNSControl.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDNSControl.Iconimage = CType(resources.GetObject("BtnDNSControl.Iconimage"), System.Drawing.Image)
        Me.BtnDNSControl.Iconimage_right = Nothing
        Me.BtnDNSControl.Iconimage_right_Selected = Nothing
        Me.BtnDNSControl.Iconimage_Selected = Nothing
        Me.BtnDNSControl.IconMarginLeft = 0
        Me.BtnDNSControl.IconMarginRight = 0
        Me.BtnDNSControl.IconRightVisible = True
        Me.BtnDNSControl.IconRightZoom = 0R
        Me.BtnDNSControl.IconVisible = True
        Me.BtnDNSControl.IconZoom = 60.0R
        Me.BtnDNSControl.IsTab = True
        Me.BtnDNSControl.Location = New System.Drawing.Point(0, 324)
        Me.BtnDNSControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDNSControl.Name = "BtnDNSControl"
        Me.BtnDNSControl.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDNSControl.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDNSControl.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnDNSControl.selected = False
        Me.BtnDNSControl.Size = New System.Drawing.Size(244, 48)
        Me.BtnDNSControl.TabIndex = 5
        Me.BtnDNSControl.Text = "        DNS Control"
        Me.BtnDNSControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDNSControl.Textcolor = System.Drawing.Color.Silver
        Me.BtnDNSControl.TextFont = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ToolTip.SetToolTip(Me.BtnDNSControl, "DNS Control")
        '
        'BtnBlockList
        '
        Me.BtnBlockList.Active = False
        Me.BtnBlockList.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnBlockList.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnBlockList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBlockList.BorderRadius = 0
        Me.BtnBlockList.ButtonText = "        Block List"
        Me.BtnBlockList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnBlockList, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnBlockList, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnBlockList.DisabledColor = System.Drawing.Color.Gray
        Me.BtnBlockList.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.BtnBlockList.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnBlockList.Iconimage = CType(resources.GetObject("BtnBlockList.Iconimage"), System.Drawing.Image)
        Me.BtnBlockList.Iconimage_right = Nothing
        Me.BtnBlockList.Iconimage_right_Selected = Nothing
        Me.BtnBlockList.Iconimage_Selected = Nothing
        Me.BtnBlockList.IconMarginLeft = 0
        Me.BtnBlockList.IconMarginRight = 0
        Me.BtnBlockList.IconRightVisible = True
        Me.BtnBlockList.IconRightZoom = 0R
        Me.BtnBlockList.IconVisible = True
        Me.BtnBlockList.IconZoom = 60.0R
        Me.BtnBlockList.IsTab = True
        Me.BtnBlockList.Location = New System.Drawing.Point(0, 270)
        Me.BtnBlockList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBlockList.Name = "BtnBlockList"
        Me.BtnBlockList.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnBlockList.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnBlockList.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnBlockList.selected = False
        Me.BtnBlockList.Size = New System.Drawing.Size(244, 48)
        Me.BtnBlockList.TabIndex = 4
        Me.BtnBlockList.Text = "        Block List"
        Me.BtnBlockList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBlockList.Textcolor = System.Drawing.Color.Silver
        Me.BtnBlockList.TextFont = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ToolTip.SetToolTip(Me.BtnBlockList, "Block List")
        '
        'BtnParentalControl
        '
        Me.BtnParentalControl.Active = False
        Me.BtnParentalControl.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnParentalControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnParentalControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnParentalControl.BorderRadius = 0
        Me.BtnParentalControl.ButtonText = "        User Control"
        Me.BtnParentalControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnParentalControl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnParentalControl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnParentalControl.DisabledColor = System.Drawing.Color.Gray
        Me.BtnParentalControl.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnParentalControl.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnParentalControl.Iconimage = CType(resources.GetObject("BtnParentalControl.Iconimage"), System.Drawing.Image)
        Me.BtnParentalControl.Iconimage_right = Nothing
        Me.BtnParentalControl.Iconimage_right_Selected = Nothing
        Me.BtnParentalControl.Iconimage_Selected = Nothing
        Me.BtnParentalControl.IconMarginLeft = 0
        Me.BtnParentalControl.IconMarginRight = 0
        Me.BtnParentalControl.IconRightVisible = True
        Me.BtnParentalControl.IconRightZoom = 0R
        Me.BtnParentalControl.IconVisible = True
        Me.BtnParentalControl.IconZoom = 60.0R
        Me.BtnParentalControl.IsTab = True
        Me.BtnParentalControl.Location = New System.Drawing.Point(0, 216)
        Me.BtnParentalControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnParentalControl.Name = "BtnParentalControl"
        Me.BtnParentalControl.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnParentalControl.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnParentalControl.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnParentalControl.selected = False
        Me.BtnParentalControl.Size = New System.Drawing.Size(244, 48)
        Me.BtnParentalControl.TabIndex = 3
        Me.BtnParentalControl.Text = "        User Control"
        Me.BtnParentalControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnParentalControl.Textcolor = System.Drawing.Color.Silver
        Me.BtnParentalControl.TextFont = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ToolTip.SetToolTip(Me.BtnParentalControl, "User Control")
        '
        'BtnAdBlock
        '
        Me.BtnAdBlock.Active = True
        Me.BtnAdBlock.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnAdBlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnAdBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdBlock.BorderRadius = 0
        Me.BtnAdBlock.ButtonText = "        Ad Block"
        Me.BtnAdBlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnAdBlock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnAdBlock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnAdBlock.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAdBlock.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdBlock.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAdBlock.Iconimage = CType(resources.GetObject("BtnAdBlock.Iconimage"), System.Drawing.Image)
        Me.BtnAdBlock.Iconimage_right = Nothing
        Me.BtnAdBlock.Iconimage_right_Selected = Nothing
        Me.BtnAdBlock.Iconimage_Selected = Nothing
        Me.BtnAdBlock.IconMarginLeft = 0
        Me.BtnAdBlock.IconMarginRight = 0
        Me.BtnAdBlock.IconRightVisible = True
        Me.BtnAdBlock.IconRightZoom = 0R
        Me.BtnAdBlock.IconVisible = True
        Me.BtnAdBlock.IconZoom = 60.0R
        Me.BtnAdBlock.IsTab = True
        Me.BtnAdBlock.Location = New System.Drawing.Point(0, 162)
        Me.BtnAdBlock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAdBlock.Name = "BtnAdBlock"
        Me.BtnAdBlock.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAdBlock.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAdBlock.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnAdBlock.selected = True
        Me.BtnAdBlock.Size = New System.Drawing.Size(244, 48)
        Me.BtnAdBlock.TabIndex = 2
        Me.BtnAdBlock.TabStop = False
        Me.BtnAdBlock.Text = "        Ad Block"
        Me.BtnAdBlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdBlock.Textcolor = System.Drawing.Color.Silver
        Me.BtnAdBlock.TextFont = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.ToolTip.SetToolTip(Me.BtnAdBlock, "Ad Block")
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.ImageActive = Nothing
        Me.BtnMenu.Location = New System.Drawing.Point(204, 16)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(30, 26)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMenu.TabIndex = 1
        Me.BtnMenu.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnMenu, "Hide/Show Menu")
        Me.BtnMenu.Zoom = 10
        '
        'logo
        '
        Me.PanelAnimator.SetDecoration(Me.logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(1, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(242, 136)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'panelHead
        '
        Me.panelHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.panelHead.Controls.Add(Me.BunifuImageButton1)
        Me.panelHead.Controls.Add(Me.CloseBtn)
        Me.panelHead.Controls.Add(Me.BunifuCustomLabel1)
        Me.panelHead.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.LogoAnimator.SetDecoration(Me.panelHead, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.panelHead, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.panelHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHead.Location = New System.Drawing.Point(0, 0)
        Me.panelHead.Name = "panelHead"
        Me.panelHead.Size = New System.Drawing.Size(924, 42)
        Me.panelHead.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.ActiveImage = Nothing
        Me.BunifuImageButton1.AllowAnimations = True
        Me.BunifuImageButton1.AllowZooming = False
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.BunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuImageButton1.ErrorImage = CType(resources.GetObject("BunifuImageButton1.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton1.FadeWhenInactive = False
        Me.BunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.ImageLocation = Nothing
        Me.BunifuImageButton1.ImageMargin = 5
        Me.BunifuImageButton1.ImageSize = New System.Drawing.Size(25, 25)
        Me.BunifuImageButton1.ImageZoomSize = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(3, 6)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Rotation = 180
        Me.BunifuImageButton1.ShowActiveImage = True
        Me.BunifuImageButton1.ShowCursorChanges = True
        Me.BunifuImageButton1.ShowImageBorders = True
        Me.BunifuImageButton1.ShowSizeMarkers = True
        Me.BunifuImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton1.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.BunifuImageButton1, "Login Page")
        Me.BunifuImageButton1.ToolTipText = ""
        Me.BunifuImageButton1.WaitOnLoad = False
        Me.BunifuImageButton1.Zoom = 5
        Me.BunifuImageButton1.ZoomSpeed = 10
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAnimator.SetDecoration(Me.CloseBtn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.CloseBtn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.ImageActive = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(882, 0)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(40, 42)
        Me.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBtn.TabIndex = 2
        Me.CloseBtn.TabStop = False
        Me.ToolTip.SetToolTip(Me.CloseBtn, "Close")
        Me.CloseBtn.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelAnimator.SetDecoration(Me.BunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(35, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(83, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "FShield"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.panelHead
        Me.BunifuDragControl1.Vertical = True
        '
        'LogoAnimator
        '
        Me.LogoAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Mosaic
        Me.LogoAnimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 20
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.LogoAnimator.DefaultAnimation = Animation2
        Me.LogoAnimator.MaxAnimationTime = 600
        '
        'ContainerForm
        '
        Me.ContainerForm.Controls.Add(Me.AdBlockPnl)
        Me.ContainerForm.Controls.Add(Me.ParentalControlPnl)
        Me.ContainerForm.Controls.Add(Me.BlockListPnl)
        Me.ContainerForm.Controls.Add(Me.DNSControlPnl)
        Me.ContainerForm.Controls.Add(Me.AboutUsPnl)
        Me.LogoAnimator.SetDecoration(Me.ContainerForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.ContainerForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ContainerForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerForm.Location = New System.Drawing.Point(243, 42)
        Me.ContainerForm.Name = "ContainerForm"
        Me.ContainerForm.Size = New System.Drawing.Size(681, 529)
        Me.ContainerForm.TabIndex = 1
        '
        'DNSControlPnl
        '
        Me.DNSControlPnl.Controls.Add(Me.CmbBxNetworkAdaptors)
        Me.DNSControlPnl.Controls.Add(Me.BtnChangeDNS)
        Me.DNSControlPnl.Controls.Add(Me.TxtBxDNS)
        Me.DNSControlPnl.Controls.Add(Me.LblDnsControl)
        Me.LogoAnimator.SetDecoration(Me.DNSControlPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.DNSControlPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.DNSControlPnl.Location = New System.Drawing.Point(0, 0)
        Me.DNSControlPnl.Name = "DNSControlPnl"
        Me.DNSControlPnl.Size = New System.Drawing.Size(680, 530)
        Me.DNSControlPnl.TabIndex = 21
        '
        'CmbBxNetworkAdaptors
        '
        Me.CmbBxNetworkAdaptors.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelAnimator.SetDecoration(Me.CmbBxNetworkAdaptors, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.CmbBxNetworkAdaptors, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.CmbBxNetworkAdaptors.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.CmbBxNetworkAdaptors.ForeColor = System.Drawing.Color.White
        Me.CmbBxNetworkAdaptors.FormattingEnabled = True
        Me.CmbBxNetworkAdaptors.Location = New System.Drawing.Point(97, 210)
        Me.CmbBxNetworkAdaptors.Name = "CmbBxNetworkAdaptors"
        Me.CmbBxNetworkAdaptors.Size = New System.Drawing.Size(207, 29)
        Me.CmbBxNetworkAdaptors.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.CmbBxNetworkAdaptors, "Choose your Network Interface" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BtnChangeDNS
        '
        Me.BtnChangeDNS.BackColor = System.Drawing.Color.Transparent
        Me.BtnChangeDNS.BackgroundImage = CType(resources.GetObject("BtnChangeDNS.BackgroundImage"), System.Drawing.Image)
        Me.BtnChangeDNS.ButtonText = "Change DNS"
        Me.BtnChangeDNS.ButtonTextMarginLeft = 0
        Me.PanelAnimator.SetDecoration(Me.BtnChangeDNS, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnChangeDNS, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnChangeDNS.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnChangeDNS.DisabledFillColor = System.Drawing.Color.Gray
        Me.BtnChangeDNS.DisabledForecolor = System.Drawing.Color.White
        Me.BtnChangeDNS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnChangeDNS.ForeColor = System.Drawing.Color.White
        Me.BtnChangeDNS.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnChangeDNS.IconPadding = 10
        Me.BtnChangeDNS.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnChangeDNS.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnChangeDNS.IdleBorderRadius = 1
        Me.BtnChangeDNS.IdleBorderThickness = 0
        Me.BtnChangeDNS.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnChangeDNS.IdleIconLeftImage = Nothing
        Me.BtnChangeDNS.IdleIconRightImage = Nothing
        Me.BtnChangeDNS.Location = New System.Drawing.Point(235, 348)
        Me.BtnChangeDNS.Name = "BtnChangeDNS"
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 1
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.BtnChangeDNS.onHoverState = StateProperties4
        Me.BtnChangeDNS.Size = New System.Drawing.Size(210, 45)
        Me.BtnChangeDNS.TabIndex = 8
        Me.BtnChangeDNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.BtnChangeDNS, "Change DNS")
        '
        'TxtBxDNS
        '
        Me.TxtBxDNS.BorderColorFocused = System.Drawing.Color.Blue
        Me.TxtBxDNS.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBxDNS.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TxtBxDNS.BorderThickness = 3
        Me.TxtBxDNS.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtBxDNS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PanelAnimator.SetDecoration(Me.TxtBxDNS, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.TxtBxDNS, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.TxtBxDNS.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.TxtBxDNS.ForeColor = System.Drawing.Color.White
        Me.TxtBxDNS.isPassword = False
        Me.TxtBxDNS.Location = New System.Drawing.Point(374, 201)
        Me.TxtBxDNS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBxDNS.MaxLength = 32767
        Me.TxtBxDNS.Name = "TxtBxDNS"
        Me.TxtBxDNS.Size = New System.Drawing.Size(209, 44)
        Me.TxtBxDNS.TabIndex = 5
        Me.TxtBxDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTip.SetToolTip(Me.TxtBxDNS, "Enter custom DNS Address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex : 8.8.8.8,8.8.4.4")
        '
        'LblDnsControl
        '
        Me.LblDnsControl.AutoSize = True
        Me.PanelAnimator.SetDecoration(Me.LblDnsControl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.LblDnsControl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LblDnsControl.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblDnsControl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblDnsControl.Location = New System.Drawing.Point(272, 54)
        Me.LblDnsControl.Name = "LblDnsControl"
        Me.LblDnsControl.Size = New System.Drawing.Size(137, 23)
        Me.LblDnsControl.TabIndex = 0
        Me.LblDnsControl.Text = "DNS Manager"
        '
        'AboutUsPnl
        '
        Me.AboutUsPnl.Controls.Add(Me.BunifuLabel3)
        Me.LogoAnimator.SetDecoration(Me.AboutUsPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.AboutUsPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.AboutUsPnl.Location = New System.Drawing.Point(0, 0)
        Me.AboutUsPnl.Name = "AboutUsPnl"
        Me.AboutUsPnl.Size = New System.Drawing.Size(680, 530)
        Me.AboutUsPnl.TabIndex = 22
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.BunifuLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel3.Location = New System.Drawing.Point(153, 254)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(375, 23)
        Me.BunifuLabel3.TabIndex = 2
        Me.BunifuLabel3.Text = "Sincere thangs to Mohammed Shafil maarakam"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'AdBlockPnl
        '
        Me.AdBlockPnl.Controls.Add(Me.BunifuLabel8)
        Me.AdBlockPnl.Controls.Add(Me.ToggleChildProtection)
        Me.AdBlockPnl.Controls.Add(Me.StatisticsPnl)
        Me.AdBlockPnl.Controls.Add(Me.LblAdblock)
        Me.AdBlockPnl.Controls.Add(Me.BtnMainOn)
        Me.AdBlockPnl.Controls.Add(Me.BtnMainOff)
        Me.LogoAnimator.SetDecoration(Me.AdBlockPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.AdBlockPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.AdBlockPnl.Location = New System.Drawing.Point(0, 0)
        Me.AdBlockPnl.Name = "AdBlockPnl"
        Me.AdBlockPnl.Size = New System.Drawing.Size(680, 530)
        Me.AdBlockPnl.TabIndex = 17
        '
        'ToggleChildProtection
        '
        Me.ToggleChildProtection.Animation = 5
        Me.ToggleChildProtection.BackColor = System.Drawing.Color.Transparent
        Me.ToggleChildProtection.BackgroundImage = CType(resources.GetObject("ToggleChildProtection.BackgroundImage"), System.Drawing.Image)
        Me.ToggleChildProtection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.ToggleChildProtection, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.ToggleChildProtection, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ToggleChildProtection.Location = New System.Drawing.Point(310, 409)
        Me.ToggleChildProtection.Name = "ToggleChildProtection"
        Me.ToggleChildProtection.Size = New System.Drawing.Size(60, 28)
        Me.ToggleChildProtection.TabIndex = 21
        ToggleState1.BackColor = System.Drawing.Color.Empty
        ToggleState1.BackColorInner = System.Drawing.Color.Empty
        ToggleState1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        ToggleState1.BorderColorInner = System.Drawing.Color.Empty
        ToggleState1.BorderRadius = 1
        ToggleState1.BorderRadiusInner = 1
        ToggleState1.BorderThickness = 1
        ToggleState1.BorderThicknessInner = 1
        Me.ToggleChildProtection.ToggleStateDisabled = ToggleState1
        ToggleState2.BackColor = System.Drawing.Color.Gray
        ToggleState2.BackColorInner = System.Drawing.Color.White
        ToggleState2.BorderColor = System.Drawing.Color.Gray
        ToggleState2.BorderColorInner = System.Drawing.Color.White
        ToggleState2.BorderRadius = 17
        ToggleState2.BorderRadiusInner = 15
        ToggleState2.BorderThickness = 1
        ToggleState2.BorderThicknessInner = 1
        Me.ToggleChildProtection.ToggleStateOff = ToggleState2
        ToggleState3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(166, Byte), Integer))
        ToggleState3.BackColorInner = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ToggleState3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(166, Byte), Integer))
        ToggleState3.BorderColorInner = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ToggleState3.BorderRadius = 17
        ToggleState3.BorderRadiusInner = 15
        ToggleState3.BorderThickness = 1
        ToggleState3.BorderThicknessInner = 1
        Me.ToggleChildProtection.ToggleStateOn = ToggleState3
        Me.ToolTip.SetToolTip(Me.ToggleChildProtection, "Enable/Disable Child Protection")
        Me.ToggleChildProtection.Value = False
        '
        'StatisticsPnl
        '
        Me.LogoAnimator.SetDecoration(Me.StatisticsPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.StatisticsPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.StatisticsPnl.Location = New System.Drawing.Point(53, 38)
        Me.StatisticsPnl.Name = "StatisticsPnl"
        Me.StatisticsPnl.Size = New System.Drawing.Size(193, 92)
        Me.StatisticsPnl.TabIndex = 20
        '
        'BtnMainOff
        '
        Me.BtnMainOff.ActiveImage = CType(resources.GetObject("BtnMainOff.ActiveImage"), System.Drawing.Image)
        Me.BtnMainOff.AllowAnimations = True
        Me.BtnMainOff.AllowZooming = False
        Me.BtnMainOff.BackColor = System.Drawing.Color.Transparent
        Me.BtnMainOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoAnimator.SetDecoration(Me.BtnMainOff, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BtnMainOff, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnMainOff.ErrorImage = CType(resources.GetObject("BtnMainOff.ErrorImage"), System.Drawing.Image)
        Me.BtnMainOff.FadeWhenInactive = False
        Me.BtnMainOff.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BtnMainOff.Image = CType(resources.GetObject("BtnMainOff.Image"), System.Drawing.Image)
        Me.BtnMainOff.ImageActive = CType(resources.GetObject("BtnMainOff.ImageActive"), System.Drawing.Image)
        Me.BtnMainOff.ImageLocation = Nothing
        Me.BtnMainOff.ImageMargin = 0
        Me.BtnMainOff.ImageSize = New System.Drawing.Size(162, 188)
        Me.BtnMainOff.ImageZoomSize = New System.Drawing.Size(162, 188)
        Me.BtnMainOff.InitialImage = CType(resources.GetObject("BtnMainOff.InitialImage"), System.Drawing.Image)
        Me.BtnMainOff.Location = New System.Drawing.Point(366, 162)
        Me.BtnMainOff.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMainOff.Name = "BtnMainOff"
        Me.BtnMainOff.Rotation = 0
        Me.BtnMainOff.ShowActiveImage = True
        Me.BtnMainOff.ShowCursorChanges = True
        Me.BtnMainOff.ShowImageBorders = True
        Me.BtnMainOff.ShowSizeMarkers = True
        Me.BtnMainOff.Size = New System.Drawing.Size(162, 188)
        Me.BtnMainOff.TabIndex = 1
        Me.BtnMainOff.ToolTipText = ""
        Me.BtnMainOff.WaitOnLoad = False
        Me.BtnMainOff.Zoom = 0
        Me.BtnMainOff.ZoomSpeed = 10
        '
        'LblAdblock
        '
        Me.LblAdblock.AutoEllipsis = False
        Me.LblAdblock.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.LblAdblock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.LblAdblock, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LblAdblock.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblAdblock.ForeColor = System.Drawing.Color.White
        Me.LblAdblock.Location = New System.Drawing.Point(294, 54)
        Me.LblAdblock.Name = "LblAdblock"
        Me.LblAdblock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblAdblock.Size = New System.Drawing.Size(92, 25)
        Me.LblAdblock.TabIndex = 0
        Me.LblAdblock.Text = "ADBLOCK"
        Me.LblAdblock.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'ParentalControlPnl
        '
        Me.ParentalControlPnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParentalControlPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ParentalControlPnl.Controls.Add(Me.UserName)
        Me.ParentalControlPnl.Controls.Add(Me.TxtBxNewUsername)
        Me.ParentalControlPnl.Controls.Add(Me.BunifuLabel7)
        Me.ParentalControlPnl.Controls.Add(Me.LblShowPassword)
        Me.ParentalControlPnl.Controls.Add(Me.ChkBxPasswordShow)
        Me.ParentalControlPnl.Controls.Add(Me.TxtBxUsername)
        Me.ParentalControlPnl.Controls.Add(Me.TxtBxNewPassword)
        Me.ParentalControlPnl.Controls.Add(Me.BtnUpdateUser)
        Me.ParentalControlPnl.Controls.Add(Me.Password)
        Me.ParentalControlPnl.Controls.Add(Me.BunifuLabel2)
        Me.LogoAnimator.SetDecoration(Me.ParentalControlPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.ParentalControlPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ParentalControlPnl.Location = New System.Drawing.Point(0, 0)
        Me.ParentalControlPnl.Name = "ParentalControlPnl"
        Me.ParentalControlPnl.Size = New System.Drawing.Size(681, 529)
        Me.ParentalControlPnl.TabIndex = 16
        '
        'UserName
        '
        Me.UserName.AutoEllipsis = False
        Me.UserName.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.UserName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.UserName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.UserName.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.UserName.ForeColor = System.Drawing.Color.White
        Me.UserName.Location = New System.Drawing.Point(114, 134)
        Me.UserName.Name = "UserName"
        Me.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserName.Size = New System.Drawing.Size(153, 23)
        Me.UserName.TabIndex = 1
        Me.UserName.Text = "Current Username :"
        Me.UserName.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'TxtBxNewUsername
        '
        Me.TxtBxNewUsername.BorderColorFocused = System.Drawing.Color.Blue
        Me.TxtBxNewUsername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBxNewUsername.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TxtBxNewUsername.BorderThickness = 3
        Me.TxtBxNewUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtBxNewUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PanelAnimator.SetDecoration(Me.TxtBxNewUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.TxtBxNewUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.TxtBxNewUsername.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.TxtBxNewUsername.ForeColor = System.Drawing.Color.White
        Me.TxtBxNewUsername.isPassword = False
        Me.TxtBxNewUsername.Location = New System.Drawing.Point(354, 193)
        Me.TxtBxNewUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBxNewUsername.MaxLength = 32767
        Me.TxtBxNewUsername.Name = "TxtBxNewUsername"
        Me.TxtBxNewUsername.Size = New System.Drawing.Size(209, 44)
        Me.TxtBxNewUsername.TabIndex = 4
        Me.TxtBxNewUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTip.SetToolTip(Me.TxtBxNewUsername, "Enter new Username")
        '
        'BunifuLabel7
        '
        Me.BunifuLabel7.AutoEllipsis = False
        Me.BunifuLabel7.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.BunifuLabel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuLabel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel7.Location = New System.Drawing.Point(138, 202)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(129, 23)
        Me.BunifuLabel7.TabIndex = 3
        Me.BunifuLabel7.Text = "New Username :"
        Me.BunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'LblShowPassword
        '
        Me.LblShowPassword.AutoEllipsis = False
        Me.LblShowPassword.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.LblShowPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.LblShowPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LblShowPassword.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.LblShowPassword.ForeColor = System.Drawing.Color.White
        Me.LblShowPassword.Location = New System.Drawing.Point(359, 360)
        Me.LblShowPassword.Name = "LblShowPassword"
        Me.LblShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblShowPassword.Size = New System.Drawing.Size(117, 22)
        Me.LblShowPassword.TabIndex = 8
        Me.LblShowPassword.Text = "Show Password"
        Me.LblShowPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.ToolTip.SetToolTip(Me.LblShowPassword, "Show Password")
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
        Me.LogoAnimator.SetDecoration(Me.ChkBxPasswordShow, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.ChkBxPasswordShow, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ChkBxPasswordShow.Location = New System.Drawing.Point(332, 360)
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
        Me.ChkBxPasswordShow.TabIndex = 7
        Me.ChkBxPasswordShow.ThreeState = False
        Me.ToolTip.SetToolTip(Me.ChkBxPasswordShow, "Show Password")
        Me.ChkBxPasswordShow.ToolTipText = Nothing
        '
        'TxtBxUsername
        '
        Me.TxtBxUsername.BorderColorFocused = System.Drawing.Color.Blue
        Me.TxtBxUsername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBxUsername.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TxtBxUsername.BorderThickness = 3
        Me.TxtBxUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtBxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PanelAnimator.SetDecoration(Me.TxtBxUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.TxtBxUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.TxtBxUsername.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.TxtBxUsername.ForeColor = System.Drawing.Color.White
        Me.TxtBxUsername.isPassword = False
        Me.TxtBxUsername.Location = New System.Drawing.Point(354, 125)
        Me.TxtBxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBxUsername.MaxLength = 32767
        Me.TxtBxUsername.Name = "TxtBxUsername"
        Me.TxtBxUsername.Size = New System.Drawing.Size(209, 44)
        Me.TxtBxUsername.TabIndex = 2
        Me.TxtBxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTip.SetToolTip(Me.TxtBxUsername, "Enter Current Username")
        '
        'TxtBxNewPassword
        '
        Me.TxtBxNewPassword.BorderColorFocused = System.Drawing.Color.Blue
        Me.TxtBxNewPassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBxNewPassword.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TxtBxNewPassword.BorderThickness = 3
        Me.TxtBxNewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtBxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PanelAnimator.SetDecoration(Me.TxtBxNewPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.TxtBxNewPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.TxtBxNewPassword.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.TxtBxNewPassword.ForeColor = System.Drawing.Color.White
        Me.TxtBxNewPassword.isPassword = True
        Me.TxtBxNewPassword.Location = New System.Drawing.Point(357, 261)
        Me.TxtBxNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBxNewPassword.MaxLength = 32767
        Me.TxtBxNewPassword.Name = "TxtBxNewPassword"
        Me.TxtBxNewPassword.Size = New System.Drawing.Size(209, 44)
        Me.TxtBxNewPassword.TabIndex = 6
        Me.TxtBxNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTip.SetToolTip(Me.TxtBxNewPassword, "Enter new Password")
        '
        'BtnUpdateUser
        '
        Me.BtnUpdateUser.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdateUser.BackgroundImage = CType(resources.GetObject("BtnUpdateUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdateUser.ButtonText = "Update User"
        Me.BtnUpdateUser.ButtonTextMarginLeft = 0
        Me.BtnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnUpdateUser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnUpdateUser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnUpdateUser.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnUpdateUser.DisabledFillColor = System.Drawing.Color.Gray
        Me.BtnUpdateUser.DisabledForecolor = System.Drawing.Color.White
        Me.BtnUpdateUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdateUser.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateUser.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnUpdateUser.IconPadding = 10
        Me.BtnUpdateUser.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnUpdateUser.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnUpdateUser.IdleBorderRadius = 1
        Me.BtnUpdateUser.IdleBorderThickness = 0
        Me.BtnUpdateUser.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnUpdateUser.IdleIconLeftImage = Nothing
        Me.BtnUpdateUser.IdleIconRightImage = Nothing
        Me.BtnUpdateUser.Location = New System.Drawing.Point(269, 424)
        Me.BtnUpdateUser.Name = "BtnUpdateUser"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BtnUpdateUser.onHoverState = StateProperties1
        Me.BtnUpdateUser.Size = New System.Drawing.Size(143, 45)
        Me.BtnUpdateUser.TabIndex = 9
        Me.BtnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.BtnUpdateUser, "Update user details")
        '
        'Password
        '
        Me.Password.AutoEllipsis = False
        Me.Password.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.Password, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.Password, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Password.ForeColor = System.Drawing.Color.White
        Me.Password.Location = New System.Drawing.Point(147, 272)
        Me.Password.Name = "Password"
        Me.Password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Password.Size = New System.Drawing.Size(123, 23)
        Me.Password.TabIndex = 5
        Me.Password.Text = "New Password :"
        Me.Password.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.BunifuLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel2.Location = New System.Drawing.Point(247, 54)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(186, 25)
        Me.BunifuLabel2.TabIndex = 0
        Me.BunifuLabel2.Text = "PARENTAL CONTROL"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'BlockListPnl
        '
        Me.BlockListPnl.Controls.Add(Me.ListBxBlockedDomains)
        Me.BlockListPnl.Controls.Add(Me.BtnBlkDomainRemove)
        Me.BlockListPnl.Controls.Add(Me.BtnBlkDomainAdd)
        Me.BlockListPnl.Controls.Add(Me.BunifuLabel1)
        Me.BlockListPnl.Controls.Add(Me.TxtBxBlockedDomains)
        Me.LogoAnimator.SetDecoration(Me.BlockListPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BlockListPnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BlockListPnl.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlockListPnl.Location = New System.Drawing.Point(0, 0)
        Me.BlockListPnl.Name = "BlockListPnl"
        Me.BlockListPnl.Size = New System.Drawing.Size(680, 530)
        Me.BlockListPnl.TabIndex = 18
        '
        'ListBxBlockedDomains
        '
        Me.ListBxBlockedDomains.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelAnimator.SetDecoration(Me.ListBxBlockedDomains, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.ListBxBlockedDomains, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ListBxBlockedDomains.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.ListBxBlockedDomains.ForeColor = System.Drawing.Color.White
        Me.ListBxBlockedDomains.FormattingEnabled = True
        Me.ListBxBlockedDomains.ItemHeight = 19
        Me.ListBxBlockedDomains.Location = New System.Drawing.Point(376, 184)
        Me.ListBxBlockedDomains.Name = "ListBxBlockedDomains"
        Me.ListBxBlockedDomains.Size = New System.Drawing.Size(210, 42)
        Me.ListBxBlockedDomains.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.ListBxBlockedDomains, "Blocked Domains List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Select one domain and Click on remove button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To remove Dom" &
        "ains from Block List")
        '
        'BtnBlkDomainRemove
        '
        Me.BtnBlkDomainRemove.BackColor = System.Drawing.Color.Transparent
        Me.BtnBlkDomainRemove.BackgroundImage = CType(resources.GetObject("BtnBlkDomainRemove.BackgroundImage"), System.Drawing.Image)
        Me.BtnBlkDomainRemove.ButtonText = "Remove Domain"
        Me.BtnBlkDomainRemove.ButtonTextMarginLeft = 0
        Me.PanelAnimator.SetDecoration(Me.BtnBlkDomainRemove, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnBlkDomainRemove, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnBlkDomainRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnBlkDomainRemove.DisabledFillColor = System.Drawing.Color.Gray
        Me.BtnBlkDomainRemove.DisabledForecolor = System.Drawing.Color.White
        Me.BtnBlkDomainRemove.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBlkDomainRemove.ForeColor = System.Drawing.Color.White
        Me.BtnBlkDomainRemove.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnBlkDomainRemove.IconPadding = 10
        Me.BtnBlkDomainRemove.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnBlkDomainRemove.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnBlkDomainRemove.IdleBorderRadius = 1
        Me.BtnBlkDomainRemove.IdleBorderThickness = 0
        Me.BtnBlkDomainRemove.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnBlkDomainRemove.IdleIconLeftImage = Nothing
        Me.BtnBlkDomainRemove.IdleIconRightImage = Nothing
        Me.BtnBlkDomainRemove.Location = New System.Drawing.Point(376, 371)
        Me.BtnBlkDomainRemove.Name = "BtnBlkDomainRemove"
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BtnBlkDomainRemove.onHoverState = StateProperties2
        Me.BtnBlkDomainRemove.Size = New System.Drawing.Size(160, 43)
        Me.BtnBlkDomainRemove.TabIndex = 8
        Me.BtnBlkDomainRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.BtnBlkDomainRemove, "Remove Domain from block list")
        '
        'BtnBlkDomainAdd
        '
        Me.BtnBlkDomainAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnBlkDomainAdd.BackgroundImage = CType(resources.GetObject("BtnBlkDomainAdd.BackgroundImage"), System.Drawing.Image)
        Me.BtnBlkDomainAdd.ButtonText = "Add Domain"
        Me.BtnBlkDomainAdd.ButtonTextMarginLeft = 0
        Me.PanelAnimator.SetDecoration(Me.BtnBlkDomainAdd, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnBlkDomainAdd, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnBlkDomainAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnBlkDomainAdd.DisabledFillColor = System.Drawing.Color.Gray
        Me.BtnBlkDomainAdd.DisabledForecolor = System.Drawing.Color.White
        Me.BtnBlkDomainAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBlkDomainAdd.ForeColor = System.Drawing.Color.White
        Me.BtnBlkDomainAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnBlkDomainAdd.IconPadding = 10
        Me.BtnBlkDomainAdd.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnBlkDomainAdd.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnBlkDomainAdd.IdleBorderRadius = 1
        Me.BtnBlkDomainAdd.IdleBorderThickness = 0
        Me.BtnBlkDomainAdd.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnBlkDomainAdd.IdleIconLeftImage = Nothing
        Me.BtnBlkDomainAdd.IdleIconRightImage = Nothing
        Me.BtnBlkDomainAdd.Location = New System.Drawing.Point(144, 371)
        Me.BtnBlkDomainAdd.Name = "BtnBlkDomainAdd"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties3.BorderRadius = 1
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.BtnBlkDomainAdd.onHoverState = StateProperties3
        Me.BtnBlkDomainAdd.Size = New System.Drawing.Size(160, 43)
        Me.BtnBlkDomainAdd.TabIndex = 7
        Me.BtnBlkDomainAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.BtnBlkDomainAdd, "Add Domain to Block List")
        '
        'TxtBxBlockedDomains
        '
        Me.TxtBxBlockedDomains.BorderColorFocused = System.Drawing.Color.Blue
        Me.TxtBxBlockedDomains.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBxBlockedDomains.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TxtBxBlockedDomains.BorderThickness = 3
        Me.TxtBxBlockedDomains.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TxtBxBlockedDomains.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PanelAnimator.SetDecoration(Me.TxtBxBlockedDomains, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.TxtBxBlockedDomains, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.TxtBxBlockedDomains.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.TxtBxBlockedDomains.ForeColor = System.Drawing.Color.White
        Me.TxtBxBlockedDomains.isPassword = False
        Me.TxtBxBlockedDomains.Location = New System.Drawing.Point(95, 183)
        Me.TxtBxBlockedDomains.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBxBlockedDomains.MaxLength = 32767
        Me.TxtBxBlockedDomains.Name = "TxtBxBlockedDomains"
        Me.TxtBxBlockedDomains.Size = New System.Drawing.Size(210, 43)
        Me.TxtBxBlockedDomains.TabIndex = 5
        Me.TxtBxBlockedDomains.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTip.SetToolTip(Me.TxtBxBlockedDomains, "Add Domains to block." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter only one domain at a time." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ex : www.google.com")
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.BunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(290, 54)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(101, 25)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "BLOCK LIST"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.BunifuLabel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuLabel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel6.Location = New System.Drawing.Point(62, 38)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(58, 15)
        Me.BunifuLabel6.TabIndex = 9
        Me.BunifuLabel6.Text = "ABOUT US"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.BunifuLabel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuLabel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel5.Location = New System.Drawing.Point(68, 43)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(65, 15)
        Me.BunifuLabel5.TabIndex = 9
        Me.BunifuLabel5.Text = "STATISTICS"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.BunifuLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel4.Location = New System.Drawing.Point(57, 52)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(81, 15)
        Me.BunifuLabel4.TabIndex = 9
        Me.BunifuLabel4.Text = "DNS CONTROL"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Leaf
        Me.PanelAnimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 1.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.PanelAnimator.DefaultAnimation = Animation1
        Me.PanelAnimator.MaxAnimationTime = 600
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'BtnMainOn
        '
        Me.BtnMainOn.ActiveImage = CType(resources.GetObject("BtnMainOn.ActiveImage"), System.Drawing.Image)
        Me.BtnMainOn.AllowAnimations = True
        Me.BtnMainOn.AllowZooming = False
        Me.BtnMainOn.BackColor = System.Drawing.Color.Transparent
        Me.BtnMainOn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoAnimator.SetDecoration(Me.BtnMainOn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BtnMainOn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BtnMainOn.ErrorImage = CType(resources.GetObject("BtnMainOn.ErrorImage"), System.Drawing.Image)
        Me.BtnMainOn.FadeWhenInactive = False
        Me.BtnMainOn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BtnMainOn.Image = CType(resources.GetObject("BtnMainOn.Image"), System.Drawing.Image)
        Me.BtnMainOn.ImageActive = CType(resources.GetObject("BtnMainOn.ImageActive"), System.Drawing.Image)
        Me.BtnMainOn.ImageLocation = Nothing
        Me.BtnMainOn.ImageMargin = 0
        Me.BtnMainOn.ImageSize = New System.Drawing.Size(162, 188)
        Me.BtnMainOn.ImageZoomSize = New System.Drawing.Size(162, 188)
        Me.BtnMainOn.InitialImage = CType(resources.GetObject("BtnMainOn.InitialImage"), System.Drawing.Image)
        Me.BtnMainOn.Location = New System.Drawing.Point(140, 175)
        Me.BtnMainOn.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMainOn.Name = "BtnMainOn"
        Me.BtnMainOn.Rotation = 0
        Me.BtnMainOn.ShowActiveImage = True
        Me.BtnMainOn.ShowCursorChanges = True
        Me.BtnMainOn.ShowImageBorders = True
        Me.BtnMainOn.ShowSizeMarkers = True
        Me.BtnMainOn.Size = New System.Drawing.Size(162, 188)
        Me.BtnMainOn.TabIndex = 22
        Me.ToolTip.SetToolTip(Me.BtnMainOn, "Start/Stop Protection")
        Me.BtnMainOn.ToolTipText = ""
        Me.BtnMainOn.WaitOnLoad = False
        Me.BtnMainOn.Zoom = 0
        Me.BtnMainOn.ZoomSpeed = 10
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.CursorType = Nothing
        Me.PanelAnimator.SetDecoration(Me.BunifuLabel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuLabel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel8.Location = New System.Drawing.Point(231, 455)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(219, 25)
        Me.BunifuLabel8.TabIndex = 23
        Me.BunifuLabel8.Text = "Enable Child Protection"
        Me.BunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'FShieldMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 571)
        Me.Controls.Add(Me.ContainerForm)
        Me.Controls.Add(Me.SideMenu)
        Me.Controls.Add(Me.panelHead)
        Me.PanelAnimator.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FShieldMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.SideMenu.ResumeLayout(False)
        CType(Me.SmallLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelHead.ResumeLayout(False)
        Me.panelHead.PerformLayout()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContainerForm.ResumeLayout(False)
        Me.DNSControlPnl.ResumeLayout(False)
        Me.DNSControlPnl.PerformLayout()
        Me.AboutUsPnl.ResumeLayout(False)
        Me.AboutUsPnl.PerformLayout()
        Me.AdBlockPnl.ResumeLayout(False)
        Me.AdBlockPnl.PerformLayout()
        Me.ParentalControlPnl.ResumeLayout(False)
        Me.ParentalControlPnl.PerformLayout()
        Me.BlockListPnl.ResumeLayout(False)
        Me.BlockListPnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents SideMenu As Panel
    Friend WithEvents panelHead As Panel
    Friend WithEvents BtnAdBlock As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents logo As PictureBox
    Friend WithEvents CloseBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BtnParentalControl As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnAboutUs As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnDNSControl As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnBlockList As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnStatistics As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelAnimator As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents LogoAnimator As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents SmallLogo As PictureBox
    Friend WithEvents BunifuImageButton1 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents ContainerForm As Panel
    Friend WithEvents BlockListPnl As Panel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents AdBlockPnl As Panel
    Friend WithEvents BtnMainOff As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents LblAdblock As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents ParentalControlPnl As Panel
    Friend WithEvents TxtBxNewUsername As BunifuMetroTextbox
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LblShowPassword As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents ChkBxPasswordShow As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents TxtBxUsername As BunifuMetroTextbox
    Friend WithEvents TxtBxNewPassword As BunifuMetroTextbox
    Friend WithEvents BtnUpdateUser As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Password As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents UserName As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents DNSControlPnl As Panel
    Friend WithEvents StatisticsPnl As Panel
    Friend WithEvents LblDnsControl As BunifuCustomLabel
    Friend WithEvents BtnChangeDNS As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents TxtBxDNS As BunifuMetroTextbox
    Friend WithEvents TxtBxBlockedDomains As BunifuMetroTextbox
    Friend WithEvents BtnBlkDomainRemove As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BtnBlkDomainAdd As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents ListBxBlockedDomains As ListBox
    Friend WithEvents AboutUsPnl As Panel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents CmbBxNetworkAdaptors As ComboBox
    Friend WithEvents ToggleChildProtection As Bunifu.ToggleSwitch.BunifuToggleSwitch
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents BtnMainOn As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
End Class
