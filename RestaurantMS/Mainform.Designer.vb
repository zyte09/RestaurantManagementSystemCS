﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Mainform_panel = New Panel()
        header_panel = New Panel()
        date_panel = New Panel()
        date_icon = New PictureBox()
        current_datelabel = New Label()
        search_panel = New Panel()
        search_icon = New Button()
        search_text = New TextBox()
        navbtn_panel = New Panel()
        btn_logout = New CircularButton()
        btn_settings = New CircularButton()
        btn_orders = New CircularButton()
        btn_payment = New CircularButton()
        btn_menu = New CircularButton()
        btn_home = New CircularButton()
        receipt_panel = New Panel()
        receipttotal_panel = New Panel()
        subtotal_label = New Label()
        servicechargeno_label = New Label()
        servicecharge_label = New Label()
        totalno_label = New Label()
        total_label = New Label()
        btn_cancelorder = New CircularButton()
        btn_sendorder = New CircularButton()
        subtotalno_label = New Label()
        receiptmenu_panel = New FlowLayoutPanel()
        guesttable_panel = New Panel()
        tableno_label = New Label()
        table_label = New Label()
        table_icon = New PictureBox()
        guestno_label = New Label()
        guest_label = New Label()
        guest_icon = New PictureBox()
        orderno_panel = New Panel()
        order_label = New Label()
        orderno_label = New Label()
        nav_panel = New Panel()
        foodmenu_panel = New Panel()
        btn_maincourse = New CircularButton()
        btn_starter = New CircularButton()
        btn_drinks = New CircularButton()
        btn_desserts = New CircularButton()
        startermenu_panel = New FlowLayoutPanel()
        Label7 = New Label()
        maincoursemenu_panel = New FlowLayoutPanel()
        Label6 = New Label()
        drinksmenu_panel = New FlowLayoutPanel()
        Label5 = New Label()
        dessertsmenu_panel = New FlowLayoutPanel()
        Label2 = New Label()
        orders_panel = New Panel()
        settings_panel = New Panel()
        Label4 = New Label()
        payment_panel = New Panel()
        Label3 = New Label()
        home_panel = New Panel()
        Label1 = New Label()
        Mainform_panel.SuspendLayout()
        header_panel.SuspendLayout()
        date_panel.SuspendLayout()
        CType(date_icon, ComponentModel.ISupportInitialize).BeginInit()
        search_panel.SuspendLayout()
        navbtn_panel.SuspendLayout()
        receipt_panel.SuspendLayout()
        receipttotal_panel.SuspendLayout()
        guesttable_panel.SuspendLayout()
        CType(table_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(guest_icon, ComponentModel.ISupportInitialize).BeginInit()
        orderno_panel.SuspendLayout()
        nav_panel.SuspendLayout()
        foodmenu_panel.SuspendLayout()
        startermenu_panel.SuspendLayout()
        maincoursemenu_panel.SuspendLayout()
        drinksmenu_panel.SuspendLayout()
        dessertsmenu_panel.SuspendLayout()
        settings_panel.SuspendLayout()
        payment_panel.SuspendLayout()
        home_panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Mainform_panel
        ' 
        Mainform_panel.Controls.Add(header_panel)
        Mainform_panel.Controls.Add(navbtn_panel)
        Mainform_panel.Controls.Add(receipt_panel)
        Mainform_panel.Controls.Add(nav_panel)
        Mainform_panel.Dock = DockStyle.Fill
        Mainform_panel.Location = New Point(0, 0)
        Mainform_panel.Name = "Mainform_panel"
        Mainform_panel.Size = New Size(1494, 935)
        Mainform_panel.TabIndex = 1
        ' 
        ' header_panel
        ' 
        header_panel.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        header_panel.Controls.Add(date_panel)
        header_panel.Controls.Add(search_panel)
        header_panel.Dock = DockStyle.Top
        header_panel.Location = New Point(0, 0)
        header_panel.Name = "header_panel"
        header_panel.Size = New Size(1494, 97)
        header_panel.TabIndex = 2
        ' 
        ' date_panel
        ' 
        date_panel.Controls.Add(date_icon)
        date_panel.Controls.Add(current_datelabel)
        date_panel.Location = New Point(1046, 26)
        date_panel.Name = "date_panel"
        date_panel.Size = New Size(419, 40)
        date_panel.TabIndex = 1
        ' 
        ' date_icon
        ' 
        date_icon.BackgroundImage = CType(resources.GetObject("date_icon.BackgroundImage"), Image)
        date_icon.BackgroundImageLayout = ImageLayout.Center
        date_icon.Dock = DockStyle.Left
        date_icon.Location = New Point(0, 0)
        date_icon.Name = "date_icon"
        date_icon.Size = New Size(45, 40)
        date_icon.TabIndex = 1
        date_icon.TabStop = False
        ' 
        ' current_datelabel
        ' 
        current_datelabel.AutoSize = True
        current_datelabel.Font = New Font("Segoe UI", 14F)
        current_datelabel.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        current_datelabel.Location = New Point(51, 6)
        current_datelabel.Name = "current_datelabel"
        current_datelabel.Size = New Size(64, 32)
        current_datelabel.TabIndex = 0
        current_datelabel.Text = "Date"
        ' 
        ' search_panel
        ' 
        search_panel.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        search_panel.Controls.Add(search_icon)
        search_panel.Controls.Add(search_text)
        search_panel.Location = New Point(187, 23)
        search_panel.Name = "search_panel"
        search_panel.Size = New Size(357, 58)
        search_panel.TabIndex = 0
        ' 
        ' search_icon
        ' 
        search_icon.BackgroundImage = CType(resources.GetObject("search_icon.BackgroundImage"), Image)
        search_icon.BackgroundImageLayout = ImageLayout.Center
        search_icon.Cursor = Cursors.Hand
        search_icon.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(94), CByte(143), CByte(144))
        search_icon.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(163), CByte(195), CByte(197))
        search_icon.Location = New Point(276, 0)
        search_icon.Name = "search_icon"
        search_icon.Size = New Size(81, 58)
        search_icon.TabIndex = 0
        search_icon.UseVisualStyleBackColor = True
        ' 
        ' search_text
        ' 
        search_text.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        search_text.BorderStyle = BorderStyle.None
        search_text.Font = New Font("Segoe UI", 12F)
        search_text.ForeColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        search_text.Location = New Point(8, 16)
        search_text.Name = "search_text"
        search_text.PlaceholderText = "Search any product..."
        search_text.Size = New Size(262, 27)
        search_text.TabIndex = 1
        ' 
        ' navbtn_panel
        ' 
        navbtn_panel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        navbtn_panel.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        navbtn_panel.Controls.Add(btn_logout)
        navbtn_panel.Controls.Add(btn_settings)
        navbtn_panel.Controls.Add(btn_orders)
        navbtn_panel.Controls.Add(btn_payment)
        navbtn_panel.Controls.Add(btn_menu)
        navbtn_panel.Controls.Add(btn_home)
        navbtn_panel.Location = New Point(0, 0)
        navbtn_panel.Name = "navbtn_panel"
        navbtn_panel.Size = New Size(115, 935)
        navbtn_panel.TabIndex = 1
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.Transparent
        btn_logout.BackgroundColor = Color.Transparent
        btn_logout.BackgroundImage = CType(resources.GetObject("btn_logout.BackgroundImage"), Image)
        btn_logout.BackgroundImageLayout = ImageLayout.Center
        btn_logout.BorderColor = Color.PaleVioletRed
        btn_logout.BorderRadius = 40
        btn_logout.BorderSize = 0
        btn_logout.Cursor = Cursors.Hand
        btn_logout.FlatAppearance.BorderSize = 0
        btn_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_logout.Location = New Point(5, 688)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(100, 100)
        btn_logout.TabIndex = 9
        btn_logout.Text = "Logout"
        btn_logout.TextAlign = ContentAlignment.BottomCenter
        btn_logout.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' btn_settings
        ' 
        btn_settings.BackColor = Color.Transparent
        btn_settings.BackgroundColor = Color.Transparent
        btn_settings.BackgroundImage = CType(resources.GetObject("btn_settings.BackgroundImage"), Image)
        btn_settings.BackgroundImageLayout = ImageLayout.Center
        btn_settings.BorderColor = Color.PaleVioletRed
        btn_settings.BorderRadius = 40
        btn_settings.BorderSize = 0
        btn_settings.Cursor = Cursors.Hand
        btn_settings.FlatAppearance.BorderSize = 0
        btn_settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_settings.FlatStyle = FlatStyle.Flat
        btn_settings.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_settings.Location = New Point(5, 578)
        btn_settings.Name = "btn_settings"
        btn_settings.Size = New Size(100, 100)
        btn_settings.TabIndex = 8
        btn_settings.Text = "Settings"
        btn_settings.TextAlign = ContentAlignment.BottomCenter
        btn_settings.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_settings.UseVisualStyleBackColor = False
        ' 
        ' btn_orders
        ' 
        btn_orders.BackColor = Color.Transparent
        btn_orders.BackgroundColor = Color.Transparent
        btn_orders.BackgroundImage = CType(resources.GetObject("btn_orders.BackgroundImage"), Image)
        btn_orders.BackgroundImageLayout = ImageLayout.Center
        btn_orders.BorderColor = Color.PaleVioletRed
        btn_orders.BorderRadius = 40
        btn_orders.BorderSize = 0
        btn_orders.Cursor = Cursors.Hand
        btn_orders.FlatAppearance.BorderSize = 0
        btn_orders.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_orders.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_orders.FlatStyle = FlatStyle.Flat
        btn_orders.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_orders.Location = New Point(5, 458)
        btn_orders.Name = "btn_orders"
        btn_orders.Size = New Size(100, 100)
        btn_orders.TabIndex = 7
        btn_orders.Text = "Orders"
        btn_orders.TextAlign = ContentAlignment.BottomCenter
        btn_orders.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_orders.UseVisualStyleBackColor = False
        ' 
        ' btn_payment
        ' 
        btn_payment.BackColor = Color.Transparent
        btn_payment.BackgroundColor = Color.Transparent
        btn_payment.BackgroundImage = CType(resources.GetObject("btn_payment.BackgroundImage"), Image)
        btn_payment.BackgroundImageLayout = ImageLayout.Center
        btn_payment.BorderColor = Color.PaleVioletRed
        btn_payment.BorderRadius = 40
        btn_payment.BorderSize = 0
        btn_payment.Cursor = Cursors.Hand
        btn_payment.FlatAppearance.BorderSize = 0
        btn_payment.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_payment.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_payment.FlatStyle = FlatStyle.Flat
        btn_payment.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_payment.Location = New Point(5, 338)
        btn_payment.Name = "btn_payment"
        btn_payment.Size = New Size(100, 100)
        btn_payment.TabIndex = 6
        btn_payment.Text = "Payment"
        btn_payment.TextAlign = ContentAlignment.BottomCenter
        btn_payment.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_payment.UseVisualStyleBackColor = False
        ' 
        ' btn_menu
        ' 
        btn_menu.BackColor = Color.Transparent
        btn_menu.BackgroundColor = Color.Transparent
        btn_menu.BackgroundImage = CType(resources.GetObject("btn_menu.BackgroundImage"), Image)
        btn_menu.BackgroundImageLayout = ImageLayout.Center
        btn_menu.BorderColor = Color.PaleVioletRed
        btn_menu.BorderRadius = 40
        btn_menu.BorderSize = 0
        btn_menu.Cursor = Cursors.Hand
        btn_menu.FlatAppearance.BorderSize = 0
        btn_menu.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_menu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_menu.FlatStyle = FlatStyle.Flat
        btn_menu.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_menu.Location = New Point(5, 218)
        btn_menu.Name = "btn_menu"
        btn_menu.Size = New Size(100, 100)
        btn_menu.TabIndex = 5
        btn_menu.Text = "Menu"
        btn_menu.TextAlign = ContentAlignment.BottomCenter
        btn_menu.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_menu.UseVisualStyleBackColor = False
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.Transparent
        btn_home.BackgroundColor = Color.Transparent
        btn_home.BackgroundImage = CType(resources.GetObject("btn_home.BackgroundImage"), Image)
        btn_home.BackgroundImageLayout = ImageLayout.Center
        btn_home.BorderColor = Color.PaleVioletRed
        btn_home.BorderRadius = 40
        btn_home.BorderSize = 0
        btn_home.Cursor = Cursors.Hand
        btn_home.FlatAppearance.BorderSize = 0
        btn_home.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_home.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_home.FlatStyle = FlatStyle.Flat
        btn_home.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_home.Location = New Point(5, 98)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(100, 100)
        btn_home.TabIndex = 4
        btn_home.Text = "Home"
        btn_home.TextAlign = ContentAlignment.BottomCenter
        btn_home.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_home.UseVisualStyleBackColor = False
        ' 
        ' receipt_panel
        ' 
        receipt_panel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        receipt_panel.Controls.Add(receipttotal_panel)
        receipt_panel.Controls.Add(receiptmenu_panel)
        receipt_panel.Controls.Add(guesttable_panel)
        receipt_panel.Controls.Add(orderno_panel)
        receipt_panel.Location = New Point(1046, 98)
        receipt_panel.Name = "receipt_panel"
        receipt_panel.Size = New Size(448, 837)
        receipt_panel.TabIndex = 3
        ' 
        ' receipttotal_panel
        ' 
        receipttotal_panel.Controls.Add(subtotal_label)
        receipttotal_panel.Controls.Add(servicechargeno_label)
        receipttotal_panel.Controls.Add(servicecharge_label)
        receipttotal_panel.Controls.Add(totalno_label)
        receipttotal_panel.Controls.Add(total_label)
        receipttotal_panel.Controls.Add(btn_cancelorder)
        receipttotal_panel.Controls.Add(btn_sendorder)
        receipttotal_panel.Controls.Add(subtotalno_label)
        receipttotal_panel.Location = New Point(27, 448)
        receipttotal_panel.Name = "receipttotal_panel"
        receipttotal_panel.Size = New Size(392, 271)
        receipttotal_panel.TabIndex = 16
        ' 
        ' subtotal_label
        ' 
        subtotal_label.Anchor = AnchorStyles.None
        subtotal_label.AutoSize = True
        subtotal_label.Font = New Font("Segoe UI", 10F)
        subtotal_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        subtotal_label.Location = New Point(4, 29)
        subtotal_label.Name = "subtotal_label"
        subtotal_label.Size = New Size(87, 23)
        subtotal_label.TabIndex = 11
        subtotal_label.Text = "SUBTOTAL"
        ' 
        ' servicechargeno_label
        ' 
        servicechargeno_label.Anchor = AnchorStyles.None
        servicechargeno_label.AutoSize = True
        servicechargeno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        servicechargeno_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        servicechargeno_label.Location = New Point(348, 29)
        servicechargeno_label.Name = "servicechargeno_label"
        servicechargeno_label.Size = New Size(30, 23)
        servicechargeno_label.TabIndex = 14
        servicechargeno_label.Text = "99"
        ' 
        ' servicecharge_label
        ' 
        servicecharge_label.Anchor = AnchorStyles.None
        servicecharge_label.AutoSize = True
        servicecharge_label.Font = New Font("Segoe UI", 10F)
        servicecharge_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        servicecharge_label.Location = New Point(4, 72)
        servicecharge_label.Name = "servicecharge_label"
        servicecharge_label.Size = New Size(144, 23)
        servicecharge_label.TabIndex = 12
        servicecharge_label.Text = "SERVICE CHARGE"
        ' 
        ' totalno_label
        ' 
        totalno_label.Anchor = AnchorStyles.None
        totalno_label.AutoSize = True
        totalno_label.Font = New Font("Segoe UI", 20F)
        totalno_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        totalno_label.Location = New Point(305, 121)
        totalno_label.Name = "totalno_label"
        totalno_label.Size = New Size(74, 46)
        totalno_label.TabIndex = 16
        totalno_label.Text = "999"
        ' 
        ' total_label
        ' 
        total_label.Anchor = AnchorStyles.None
        total_label.AutoSize = True
        total_label.Font = New Font("Segoe UI", 20F)
        total_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        total_label.Location = New Point(7, 121)
        total_label.Name = "total_label"
        total_label.Size = New Size(114, 46)
        total_label.TabIndex = 15
        total_label.Text = "TOTAL"
        ' 
        ' btn_cancelorder
        ' 
        btn_cancelorder.Anchor = AnchorStyles.None
        btn_cancelorder.BackColor = Color.IndianRed
        btn_cancelorder.BackgroundColor = Color.IndianRed
        btn_cancelorder.BackgroundImageLayout = ImageLayout.Center
        btn_cancelorder.BorderColor = Color.PaleVioletRed
        btn_cancelorder.BorderRadius = 40
        btn_cancelorder.BorderSize = 0
        btn_cancelorder.Cursor = Cursors.Hand
        btn_cancelorder.FlatAppearance.BorderSize = 0
        btn_cancelorder.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_cancelorder.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_cancelorder.FlatStyle = FlatStyle.Flat
        btn_cancelorder.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btn_cancelorder.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_cancelorder.Location = New Point(5, 170)
        btn_cancelorder.Name = "btn_cancelorder"
        btn_cancelorder.Size = New Size(185, 69)
        btn_cancelorder.TabIndex = 9
        btn_cancelorder.Text = "CANCEL ORDER"
        btn_cancelorder.TextColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_cancelorder.UseVisualStyleBackColor = False
        ' 
        ' btn_sendorder
        ' 
        btn_sendorder.Anchor = AnchorStyles.None
        btn_sendorder.BackColor = Color.PaleTurquoise
        btn_sendorder.BackgroundColor = Color.PaleTurquoise
        btn_sendorder.BackgroundImageLayout = ImageLayout.Center
        btn_sendorder.BorderColor = Color.PaleVioletRed
        btn_sendorder.BorderRadius = 40
        btn_sendorder.BorderSize = 0
        btn_sendorder.Cursor = Cursors.Hand
        btn_sendorder.FlatAppearance.BorderSize = 0
        btn_sendorder.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_sendorder.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_sendorder.FlatStyle = FlatStyle.Flat
        btn_sendorder.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btn_sendorder.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_sendorder.Location = New Point(207, 170)
        btn_sendorder.Name = "btn_sendorder"
        btn_sendorder.Size = New Size(185, 69)
        btn_sendorder.TabIndex = 10
        btn_sendorder.Text = "SEND ORDER"
        btn_sendorder.TextColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_sendorder.UseVisualStyleBackColor = False
        ' 
        ' subtotalno_label
        ' 
        subtotalno_label.Anchor = AnchorStyles.None
        subtotalno_label.AutoSize = True
        subtotalno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        subtotalno_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        subtotalno_label.Location = New Point(349, 72)
        subtotalno_label.Name = "subtotalno_label"
        subtotalno_label.Size = New Size(30, 23)
        subtotalno_label.TabIndex = 13
        subtotalno_label.Text = "99"
        ' 
        ' receiptmenu_panel
        ' 
        receiptmenu_panel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        receiptmenu_panel.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        receiptmenu_panel.Location = New Point(27, 114)
        receiptmenu_panel.Name = "receiptmenu_panel"
        receiptmenu_panel.Size = New Size(392, 320)
        receiptmenu_panel.TabIndex = 4
        ' 
        ' guesttable_panel
        ' 
        guesttable_panel.Anchor = AnchorStyles.Right
        guesttable_panel.Controls.Add(tableno_label)
        guesttable_panel.Controls.Add(table_label)
        guesttable_panel.Controls.Add(table_icon)
        guesttable_panel.Controls.Add(guestno_label)
        guesttable_panel.Controls.Add(guest_label)
        guesttable_panel.Controls.Add(guest_icon)
        guesttable_panel.Location = New Point(27, 68)
        guesttable_panel.Name = "guesttable_panel"
        guesttable_panel.Size = New Size(392, 37)
        guesttable_panel.TabIndex = 2
        ' 
        ' tableno_label
        ' 
        tableno_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        tableno_label.AutoSize = True
        tableno_label.Font = New Font("Segoe UI", 10F)
        tableno_label.ForeColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        tableno_label.Location = New Point(331, 7)
        tableno_label.Name = "tableno_label"
        tableno_label.Size = New Size(19, 23)
        tableno_label.TabIndex = 5
        tableno_label.Text = "2"
        ' 
        ' table_label
        ' 
        table_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        table_label.AutoSize = True
        table_label.Font = New Font("Segoe UI", 10F)
        table_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        table_label.Location = New Point(277, 7)
        table_label.Name = "table_label"
        table_label.Size = New Size(65, 23)
        table_label.TabIndex = 4
        table_label.Text = "TABLE: "
        ' 
        ' table_icon
        ' 
        table_icon.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        table_icon.BackgroundImage = CType(resources.GetObject("table_icon.BackgroundImage"), Image)
        table_icon.BackgroundImageLayout = ImageLayout.Zoom
        table_icon.Location = New Point(232, 0)
        table_icon.Name = "table_icon"
        table_icon.Size = New Size(45, 37)
        table_icon.TabIndex = 3
        table_icon.TabStop = False
        ' 
        ' guestno_label
        ' 
        guestno_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        guestno_label.AutoSize = True
        guestno_label.Font = New Font("Segoe UI", 10F)
        guestno_label.ForeColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        guestno_label.Location = New Point(113, 7)
        guestno_label.Name = "guestno_label"
        guestno_label.Size = New Size(19, 23)
        guestno_label.TabIndex = 2
        guestno_label.Text = "5"
        ' 
        ' guest_label
        ' 
        guest_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        guest_label.AutoSize = True
        guest_label.Font = New Font("Segoe UI", 10F)
        guest_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        guest_label.Location = New Point(49, 7)
        guest_label.Name = "guest_label"
        guest_label.Size = New Size(70, 23)
        guest_label.TabIndex = 1
        guest_label.Text = "GUEST: "
        ' 
        ' guest_icon
        ' 
        guest_icon.BackgroundImage = CType(resources.GetObject("guest_icon.BackgroundImage"), Image)
        guest_icon.BackgroundImageLayout = ImageLayout.Zoom
        guest_icon.Dock = DockStyle.Left
        guest_icon.Location = New Point(0, 0)
        guest_icon.Name = "guest_icon"
        guest_icon.Size = New Size(45, 37)
        guest_icon.TabIndex = 0
        guest_icon.TabStop = False
        ' 
        ' orderno_panel
        ' 
        orderno_panel.Anchor = AnchorStyles.None
        orderno_panel.Controls.Add(order_label)
        orderno_panel.Controls.Add(orderno_label)
        orderno_panel.Location = New Point(27, 14)
        orderno_panel.Name = "orderno_panel"
        orderno_panel.Size = New Size(392, 47)
        orderno_panel.TabIndex = 1
        ' 
        ' order_label
        ' 
        order_label.AutoSize = True
        order_label.Dock = DockStyle.Left
        order_label.Font = New Font("Segoe UI", 20F)
        order_label.ForeColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        order_label.Location = New Point(0, 0)
        order_label.Name = "order_label"
        order_label.Size = New Size(156, 46)
        order_label.TabIndex = 0
        order_label.Text = "ORDER #"
        ' 
        ' orderno_label
        ' 
        orderno_label.AutoSize = True
        orderno_label.Dock = DockStyle.Right
        orderno_label.Font = New Font("Segoe UI", 20F)
        orderno_label.ForeColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        orderno_label.Location = New Point(392, 0)
        orderno_label.Name = "orderno_label"
        orderno_label.Size = New Size(0, 46)
        orderno_label.TabIndex = 0
        ' 
        ' nav_panel
        ' 
        nav_panel.Controls.Add(foodmenu_panel)
        nav_panel.Controls.Add(orders_panel)
        nav_panel.Controls.Add(settings_panel)
        nav_panel.Controls.Add(payment_panel)
        nav_panel.Controls.Add(home_panel)
        nav_panel.Location = New Point(111, 98)
        nav_panel.Name = "nav_panel"
        nav_panel.Size = New Size(929, 837)
        nav_panel.TabIndex = 4
        ' 
        ' foodmenu_panel
        ' 
        foodmenu_panel.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        foodmenu_panel.Controls.Add(btn_maincourse)
        foodmenu_panel.Controls.Add(btn_starter)
        foodmenu_panel.Controls.Add(btn_drinks)
        foodmenu_panel.Controls.Add(btn_desserts)
        foodmenu_panel.Controls.Add(startermenu_panel)
        foodmenu_panel.Controls.Add(maincoursemenu_panel)
        foodmenu_panel.Controls.Add(drinksmenu_panel)
        foodmenu_panel.Controls.Add(dessertsmenu_panel)
        foodmenu_panel.Dock = DockStyle.Fill
        foodmenu_panel.Location = New Point(0, 0)
        foodmenu_panel.Name = "foodmenu_panel"
        foodmenu_panel.Size = New Size(929, 837)
        foodmenu_panel.TabIndex = 2
        ' 
        ' btn_maincourse
        ' 
        btn_maincourse.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_maincourse.BackgroundColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_maincourse.BackgroundImageLayout = ImageLayout.Center
        btn_maincourse.BorderColor = Color.PaleVioletRed
        btn_maincourse.BorderRadius = 40
        btn_maincourse.BorderSize = 0
        btn_maincourse.Cursor = Cursors.Hand
        btn_maincourse.FlatAppearance.BorderSize = 0
        btn_maincourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_maincourse.FlatStyle = FlatStyle.Flat
        btn_maincourse.Font = New Font("Segoe UI", 15F)
        btn_maincourse.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_maincourse.Location = New Point(241, 604)
        btn_maincourse.Name = "btn_maincourse"
        btn_maincourse.Size = New Size(207, 80)
        btn_maincourse.TabIndex = 6
        btn_maincourse.Text = "Main Course"
        btn_maincourse.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_maincourse.UseVisualStyleBackColor = False
        ' 
        ' btn_starter
        ' 
        btn_starter.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_starter.BackgroundColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_starter.BackgroundImageLayout = ImageLayout.Center
        btn_starter.BorderColor = Color.PaleVioletRed
        btn_starter.BorderRadius = 40
        btn_starter.BorderSize = 0
        btn_starter.Cursor = Cursors.Hand
        btn_starter.FlatAppearance.BorderSize = 0
        btn_starter.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_starter.FlatStyle = FlatStyle.Flat
        btn_starter.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_starter.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_starter.Location = New Point(10, 604)
        btn_starter.Name = "btn_starter"
        btn_starter.Size = New Size(207, 80)
        btn_starter.TabIndex = 5
        btn_starter.Text = "Starter"
        btn_starter.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_starter.UseVisualStyleBackColor = False
        ' 
        ' btn_drinks
        ' 
        btn_drinks.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_drinks.BackgroundColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_drinks.BackgroundImageLayout = ImageLayout.Center
        btn_drinks.BorderColor = Color.PaleVioletRed
        btn_drinks.BorderRadius = 40
        btn_drinks.BorderSize = 0
        btn_drinks.Cursor = Cursors.Hand
        btn_drinks.FlatAppearance.BorderSize = 0
        btn_drinks.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_drinks.FlatStyle = FlatStyle.Flat
        btn_drinks.Font = New Font("Segoe UI", 15F)
        btn_drinks.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_drinks.Location = New Point(472, 604)
        btn_drinks.Name = "btn_drinks"
        btn_drinks.Size = New Size(207, 80)
        btn_drinks.TabIndex = 7
        btn_drinks.Text = "Drinks"
        btn_drinks.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_drinks.UseVisualStyleBackColor = False
        ' 
        ' btn_desserts
        ' 
        btn_desserts.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_desserts.BackgroundColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_desserts.BackgroundImageLayout = ImageLayout.Center
        btn_desserts.BorderColor = Color.PaleVioletRed
        btn_desserts.BorderRadius = 40
        btn_desserts.BorderSize = 0
        btn_desserts.Cursor = Cursors.Hand
        btn_desserts.FlatAppearance.BorderSize = 0
        btn_desserts.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_desserts.FlatStyle = FlatStyle.Flat
        btn_desserts.Font = New Font("Segoe UI", 15F)
        btn_desserts.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_desserts.Location = New Point(703, 604)
        btn_desserts.Name = "btn_desserts"
        btn_desserts.Size = New Size(207, 80)
        btn_desserts.TabIndex = 8
        btn_desserts.Text = "Desserts"
        btn_desserts.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_desserts.UseVisualStyleBackColor = False
        ' 
        ' startermenu_panel
        ' 
        startermenu_panel.AutoScroll = True
        startermenu_panel.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        startermenu_panel.Controls.Add(Label7)
        startermenu_panel.Location = New Point(0, 0)
        startermenu_panel.Name = "startermenu_panel"
        startermenu_panel.Size = New Size(929, 598)
        startermenu_panel.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 30F)
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(377, 67)
        Label7.TabIndex = 0
        Label7.Text = "STARTER PANEL"
        ' 
        ' maincoursemenu_panel
        ' 
        maincoursemenu_panel.AutoScroll = True
        maincoursemenu_panel.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        maincoursemenu_panel.Controls.Add(Label6)
        maincoursemenu_panel.Location = New Point(0, 0)
        maincoursemenu_panel.Name = "maincoursemenu_panel"
        maincoursemenu_panel.Size = New Size(929, 598)
        maincoursemenu_panel.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 30F)
        Label6.Location = New Point(3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(511, 67)
        Label6.TabIndex = 0
        Label6.Text = "MAIN COURSE PANEL"
        ' 
        ' drinksmenu_panel
        ' 
        drinksmenu_panel.AutoScroll = True
        drinksmenu_panel.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        drinksmenu_panel.Controls.Add(Label5)
        drinksmenu_panel.Location = New Point(0, 0)
        drinksmenu_panel.Name = "drinksmenu_panel"
        drinksmenu_panel.Size = New Size(929, 598)
        drinksmenu_panel.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 30F)
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(357, 67)
        Label5.TabIndex = 0
        Label5.Text = "DRINKS PANEL"
        ' 
        ' dessertsmenu_panel
        ' 
        dessertsmenu_panel.AutoScroll = True
        dessertsmenu_panel.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        dessertsmenu_panel.Controls.Add(Label2)
        dessertsmenu_panel.Location = New Point(0, 0)
        dessertsmenu_panel.Name = "dessertsmenu_panel"
        dessertsmenu_panel.Size = New Size(929, 598)
        dessertsmenu_panel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 30F)
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(405, 67)
        Label2.TabIndex = 0
        Label2.Text = "DESSERTS PANEL"
        ' 
        ' orders_panel
        ' 
        orders_panel.BackColor = Color.LightSteelBlue
        orders_panel.Dock = DockStyle.Fill
        orders_panel.Location = New Point(0, 0)
        orders_panel.Name = "orders_panel"
        orders_panel.Size = New Size(929, 837)
        orders_panel.TabIndex = 1
        ' 
        ' settings_panel
        ' 
        settings_panel.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        settings_panel.Controls.Add(Label4)
        settings_panel.Dock = DockStyle.Fill
        settings_panel.Location = New Point(0, 0)
        settings_panel.Name = "settings_panel"
        settings_panel.Size = New Size(929, 837)
        settings_panel.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 60F)
        Label4.Location = New Point(160, 273)
        Label4.Name = "Label4"
        Label4.Size = New Size(805, 133)
        Label4.TabIndex = 0
        Label4.Text = "SETTIGNS PANEL"
        ' 
        ' payment_panel
        ' 
        payment_panel.BackColor = Color.Fuchsia
        payment_panel.Controls.Add(Label3)
        payment_panel.Dock = DockStyle.Fill
        payment_panel.Location = New Point(0, 0)
        payment_panel.Name = "payment_panel"
        payment_panel.Size = New Size(929, 837)
        payment_panel.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 80F)
        Label3.Location = New Point(70, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(1013, 177)
        Label3.TabIndex = 0
        Label3.Text = "payment PANEL"
        ' 
        ' home_panel
        ' 
        home_panel.BackColor = Color.Maroon
        home_panel.Controls.Add(Label1)
        home_panel.Dock = DockStyle.Fill
        home_panel.Location = New Point(0, 0)
        home_panel.Name = "home_panel"
        home_panel.Size = New Size(929, 837)
        home_panel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 60F)
        Label1.Location = New Point(186, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(658, 133)
        Label1.TabIndex = 0
        Label1.Text = "HOME PANEL"
        ' 
        ' Mainform
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        ClientSize = New Size(1494, 935)
        Controls.Add(Mainform_panel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Mainform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mainform"
        WindowState = FormWindowState.Maximized
        Mainform_panel.ResumeLayout(False)
        header_panel.ResumeLayout(False)
        date_panel.ResumeLayout(False)
        date_panel.PerformLayout()
        CType(date_icon, ComponentModel.ISupportInitialize).EndInit()
        search_panel.ResumeLayout(False)
        search_panel.PerformLayout()
        navbtn_panel.ResumeLayout(False)
        receipt_panel.ResumeLayout(False)
        receipttotal_panel.ResumeLayout(False)
        receipttotal_panel.PerformLayout()
        guesttable_panel.ResumeLayout(False)
        guesttable_panel.PerformLayout()
        CType(table_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(guest_icon, ComponentModel.ISupportInitialize).EndInit()
        orderno_panel.ResumeLayout(False)
        orderno_panel.PerformLayout()
        nav_panel.ResumeLayout(False)
        foodmenu_panel.ResumeLayout(False)
        startermenu_panel.ResumeLayout(False)
        startermenu_panel.PerformLayout()
        maincoursemenu_panel.ResumeLayout(False)
        maincoursemenu_panel.PerformLayout()
        drinksmenu_panel.ResumeLayout(False)
        drinksmenu_panel.PerformLayout()
        dessertsmenu_panel.ResumeLayout(False)
        dessertsmenu_panel.PerformLayout()
        settings_panel.ResumeLayout(False)
        settings_panel.PerformLayout()
        payment_panel.ResumeLayout(False)
        payment_panel.PerformLayout()
        home_panel.ResumeLayout(False)
        home_panel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Mainform_panel As Panel
    Friend WithEvents header_panel As Panel
    Friend WithEvents navbtn_panel As Panel
    Friend WithEvents receipt_panel As Panel
    Friend WithEvents btn_home As CircularButton
    Friend WithEvents btn_logout As CircularButton
    Friend WithEvents btn_settings As CircularButton
    Friend WithEvents btn_orders As CircularButton
    Friend WithEvents btn_payment As CircularButton
    Friend WithEvents btn_menu As CircularButton
    Friend WithEvents search_panel As Panel
    Friend WithEvents search_icon As Button
    Friend WithEvents search_text As TextBox
    Friend WithEvents date_panel As Panel
    Friend WithEvents current_datelabel As Label
    Friend WithEvents date_icon As PictureBox
    Friend WithEvents orderno_label As Label
    Friend WithEvents order_label As Label
    Friend WithEvents orderno_panel As Panel
    Friend WithEvents receiptmenu_panel As FlowLayoutPanel
    Friend WithEvents btn_cancelorder As CircularButton
    Friend WithEvents btn_sendorder As CircularButton
    Friend WithEvents servicecharge_label As Label
    Friend WithEvents subtotal_label As Label
    Friend WithEvents total_label As Label
    Friend WithEvents servicechargeno_label As Label
    Friend WithEvents subtotalno_label As Label
    Friend WithEvents totalno_label As Label
    Friend WithEvents guesttable_panel As Panel
    Friend WithEvents tableno_label As Label
    Friend WithEvents table_label As Label
    Friend WithEvents table_icon As PictureBox
    Friend WithEvents guestno_label As Label
    Friend WithEvents guest_label As Label
    Friend WithEvents guest_icon As PictureBox
    Friend WithEvents receipttotal_panel As Panel
    Friend WithEvents nav_panel As Panel
    Friend WithEvents home_panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents settings_panel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents payment_panel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents startermenu_panel As FlowLayoutPanel
    Friend WithEvents orders_panel As Panel
    Friend WithEvents foodmenu_panel As Panel
    Friend WithEvents btn_desserts As CircularButton
    Friend WithEvents btn_drinks As CircularButton
    Friend WithEvents btn_maincourse As CircularButton
    Friend WithEvents btn_starter As CircularButton
    Friend WithEvents Label7 As Label
    Friend WithEvents maincoursemenu_panel As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents drinksmenu_panel As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents dessertsmenu_panel As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
