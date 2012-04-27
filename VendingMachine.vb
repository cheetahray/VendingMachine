'Term Project 2
'Anupam Pandeya 07/23/06


Public Class VendingMachine
    Inherits System.Windows.Forms.Form
    'Global Variables
    Dim MoneyAvailable As Decimal = 0.0 ' Money deposited by user
    Dim ItemCost As Decimal = 0.0       'Cost of the item
    Dim ItemQuantity As Integer = 0     'Quantity of Items available
    Dim objRandom As New System.Random( _
   CType(System.DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer))



#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents gateLeftImg As System.Windows.Forms.PictureBox
    Friend WithEvents gateRightImg As System.Windows.Forms.PictureBox
    Friend WithEvents ItemGateImg As System.Windows.Forms.PictureBox
    Friend WithEvents cokeBtn As System.Windows.Forms.Button
    Friend WithEvents SnappleBtn As System.Windows.Forms.Button
    Friend WithEvents pepsiBtn As System.Windows.Forms.Button
    Friend WithEvents mntdewBtn As System.Windows.Forms.Button
    Friend WithEvents evianBtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Coke As System.Windows.Forms.PictureBox
    Friend WithEvents Pepsi As System.Windows.Forms.PictureBox
    Friend WithEvents Snapple As System.Windows.Forms.PictureBox
    Friend WithEvents MountainDew As System.Windows.Forms.PictureBox
    Friend WithEvents Evian As System.Windows.Forms.PictureBox
    Friend WithEvents chipsBtn As System.Windows.Forms.Button
    Friend WithEvents CheezBtn As System.Windows.Forms.Button
    Friend WithEvents LaysBtn As System.Windows.Forms.Button
    Friend WithEvents pringlesBtn As System.Windows.Forms.Button
    Friend WithEvents FritosBtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Chips As System.Windows.Forms.PictureBox
    Friend WithEvents Lays As System.Windows.Forms.PictureBox
    Friend WithEvents CheezIt As System.Windows.Forms.PictureBox
    Friend WithEvents Pringles As System.Windows.Forms.PictureBox
    Friend WithEvents Fritos As System.Windows.Forms.PictureBox
    Friend WithEvents HersBtn As System.Windows.Forms.Button
    Friend WithEvents MnM1Btn As System.Windows.Forms.Button
    Friend WithEvents MnM2Btn As System.Windows.Forms.Button
    Friend WithEvents snickersBtn As System.Windows.Forms.Button
    Friend WithEvents skittlesBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Hershey As System.Windows.Forms.PictureBox
    Friend WithEvents MnMBrown As System.Windows.Forms.PictureBox
    Friend WithEvents MnMYellow As System.Windows.Forms.PictureBox
    Friend WithEvents Snickers As System.Windows.Forms.PictureBox
    Friend WithEvents Skittles As System.Windows.Forms.PictureBox
    Friend WithEvents MoneyReturnTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DollarReturnLBL As System.Windows.Forms.Label
    Friend WithEvents DimeReturnImg As System.Windows.Forms.PictureBox
    Friend WithEvents NickelReturnImg As System.Windows.Forms.PictureBox
    Friend WithEvents QuarterReturnImg As System.Windows.Forms.PictureBox
    Friend WithEvents DollarReturnImg As System.Windows.Forms.PictureBox
    Friend WithEvents QuarterReturnLBL As System.Windows.Forms.Label
    Friend WithEvents DimeReturnLBL As System.Windows.Forms.Label
    Friend WithEvents NickelReturnLBL As System.Windows.Forms.Label
    Friend WithEvents StatusTB As System.Windows.Forms.RichTextBox
    Friend WithEvents dimeImg As System.Windows.Forms.PictureBox
    Friend WithEvents QuarterImg As System.Windows.Forms.PictureBox
    Friend WithEvents DollarBillImg As System.Windows.Forms.PictureBox
    Friend WithEvents NickelImg As System.Windows.Forms.PictureBox
    Friend WithEvents MoneyAvailLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MoneyDepositTB As System.Windows.Forms.TextBox
    Friend WithEvents ChangeReturnBTN As System.Windows.Forms.Button
    Friend WithEvents SkittlesSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents SnickersSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents MnMYellowSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents MnMBrownSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents HersheysSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents FritosSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents PringlesSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents CheezItSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents LaysSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents ChipsSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents EvianSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents MntDewSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents SnapplesSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents PepsiSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents CokeSoldOutLBL As System.Windows.Forms.Label
    Friend WithEvents VendingMachineIMG As System.Windows.Forms.PictureBox
    Friend WithEvents ResetMoneyReturnTimer As System.Windows.Forms.Timer
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(VendingMachine))
        Me.gateLeftImg = New System.Windows.Forms.PictureBox
        Me.gateRightImg = New System.Windows.Forms.PictureBox
        Me.ItemGateImg = New System.Windows.Forms.PictureBox
        Me.cokeBtn = New System.Windows.Forms.Button
        Me.SnappleBtn = New System.Windows.Forms.Button
        Me.pepsiBtn = New System.Windows.Forms.Button
        Me.mntdewBtn = New System.Windows.Forms.Button
        Me.evianBtn = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Coke = New System.Windows.Forms.PictureBox
        Me.Pepsi = New System.Windows.Forms.PictureBox
        Me.Snapple = New System.Windows.Forms.PictureBox
        Me.MountainDew = New System.Windows.Forms.PictureBox
        Me.Evian = New System.Windows.Forms.PictureBox
        Me.chipsBtn = New System.Windows.Forms.Button
        Me.CheezBtn = New System.Windows.Forms.Button
        Me.LaysBtn = New System.Windows.Forms.Button
        Me.pringlesBtn = New System.Windows.Forms.Button
        Me.FritosBtn = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Chips = New System.Windows.Forms.PictureBox
        Me.Lays = New System.Windows.Forms.PictureBox
        Me.CheezIt = New System.Windows.Forms.PictureBox
        Me.Pringles = New System.Windows.Forms.PictureBox
        Me.Fritos = New System.Windows.Forms.PictureBox
        Me.HersBtn = New System.Windows.Forms.Button
        Me.MnM1Btn = New System.Windows.Forms.Button
        Me.MnM2Btn = New System.Windows.Forms.Button
        Me.snickersBtn = New System.Windows.Forms.Button
        Me.skittlesBtn = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Hershey = New System.Windows.Forms.PictureBox
        Me.MnMBrown = New System.Windows.Forms.PictureBox
        Me.MnMYellow = New System.Windows.Forms.PictureBox
        Me.Snickers = New System.Windows.Forms.PictureBox
        Me.Skittles = New System.Windows.Forms.PictureBox
        Me.VendingMachineIMG = New System.Windows.Forms.PictureBox
        Me.MoneyReturnTB = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.DollarReturnLBL = New System.Windows.Forms.Label
        Me.DimeReturnImg = New System.Windows.Forms.PictureBox
        Me.NickelReturnImg = New System.Windows.Forms.PictureBox
        Me.QuarterReturnImg = New System.Windows.Forms.PictureBox
        Me.DollarReturnImg = New System.Windows.Forms.PictureBox
        Me.QuarterReturnLBL = New System.Windows.Forms.Label
        Me.DimeReturnLBL = New System.Windows.Forms.Label
        Me.NickelReturnLBL = New System.Windows.Forms.Label
        Me.StatusTB = New System.Windows.Forms.RichTextBox
        Me.dimeImg = New System.Windows.Forms.PictureBox
        Me.QuarterImg = New System.Windows.Forms.PictureBox
        Me.DollarBillImg = New System.Windows.Forms.PictureBox
        Me.NickelImg = New System.Windows.Forms.PictureBox
        Me.MoneyAvailLbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MoneyDepositTB = New System.Windows.Forms.TextBox
        Me.SkittlesSoldOutLBL = New System.Windows.Forms.Label
        Me.ChangeReturnBTN = New System.Windows.Forms.Button
        Me.SnickersSoldOutLBL = New System.Windows.Forms.Label
        Me.MnMYellowSoldOutLBL = New System.Windows.Forms.Label
        Me.MnMBrownSoldOutLBL = New System.Windows.Forms.Label
        Me.HersheysSoldOutLBL = New System.Windows.Forms.Label
        Me.FritosSoldOutLBL = New System.Windows.Forms.Label
        Me.PringlesSoldOutLBL = New System.Windows.Forms.Label
        Me.CheezItSoldOutLBL = New System.Windows.Forms.Label
        Me.LaysSoldOutLBL = New System.Windows.Forms.Label
        Me.ChipsSoldOutLBL = New System.Windows.Forms.Label
        Me.EvianSoldOutLBL = New System.Windows.Forms.Label
        Me.MntDewSoldOutLBL = New System.Windows.Forms.Label
        Me.SnapplesSoldOutLBL = New System.Windows.Forms.Label
        Me.PepsiSoldOutLBL = New System.Windows.Forms.Label
        Me.CokeSoldOutLBL = New System.Windows.Forms.Label
        Me.ResetMoneyReturnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cmdAbout = New System.Windows.Forms.Button
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gateLeftImg
        '
        Me.gateLeftImg.BackColor = System.Drawing.Color.Maroon
        Me.gateLeftImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gateLeftImg.Image = CType(resources.GetObject("gateLeftImg.Image"), System.Drawing.Image)
        Me.gateLeftImg.Location = New System.Drawing.Point(96, 448)
        Me.gateLeftImg.Name = "gateLeftImg"
        Me.gateLeftImg.Size = New System.Drawing.Size(88, 104)
        Me.gateLeftImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gateLeftImg.TabIndex = 45
        Me.gateLeftImg.TabStop = False
        '
        'gateRightImg
        '
        Me.gateRightImg.BackColor = System.Drawing.Color.Maroon
        Me.gateRightImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gateRightImg.Image = CType(resources.GetObject("gateRightImg.Image"), System.Drawing.Image)
        Me.gateRightImg.Location = New System.Drawing.Point(184, 448)
        Me.gateRightImg.Name = "gateRightImg"
        Me.gateRightImg.Size = New System.Drawing.Size(88, 104)
        Me.gateRightImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gateRightImg.TabIndex = 44
        Me.gateRightImg.TabStop = False
        '
        'ItemGateImg
        '
        Me.ItemGateImg.BackgroundImage = CType(resources.GetObject("ItemGateImg.BackgroundImage"), System.Drawing.Image)
        Me.ItemGateImg.Location = New System.Drawing.Point(160, 464)
        Me.ItemGateImg.Name = "ItemGateImg"
        Me.ItemGateImg.Size = New System.Drawing.Size(48, 72)
        Me.ItemGateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ItemGateImg.TabIndex = 43
        Me.ItemGateImg.TabStop = False
        '
        'cokeBtn
        '
        Me.cokeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cokeBtn.Location = New System.Drawing.Point(40, 400)
        Me.cokeBtn.Name = "cokeBtn"
        Me.cokeBtn.Size = New System.Drawing.Size(40, 24)
        Me.cokeBtn.TabIndex = 42
        Me.cokeBtn.Text = "1.00"
        '
        'SnappleBtn
        '
        Me.SnappleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SnappleBtn.Location = New System.Drawing.Point(152, 400)
        Me.SnappleBtn.Name = "SnappleBtn"
        Me.SnappleBtn.Size = New System.Drawing.Size(40, 24)
        Me.SnappleBtn.TabIndex = 40
        Me.SnappleBtn.Text = "1.00"
        '
        'pepsiBtn
        '
        Me.pepsiBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pepsiBtn.Location = New System.Drawing.Point(96, 400)
        Me.pepsiBtn.Name = "pepsiBtn"
        Me.pepsiBtn.Size = New System.Drawing.Size(40, 24)
        Me.pepsiBtn.TabIndex = 41
        Me.pepsiBtn.Text = "0.70"
        '
        'mntdewBtn
        '
        Me.mntdewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mntdewBtn.Location = New System.Drawing.Point(208, 400)
        Me.mntdewBtn.Name = "mntdewBtn"
        Me.mntdewBtn.Size = New System.Drawing.Size(40, 24)
        Me.mntdewBtn.TabIndex = 39
        Me.mntdewBtn.Text = "1.00"
        '
        'evianBtn
        '
        Me.evianBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.evianBtn.Location = New System.Drawing.Point(264, 400)
        Me.evianBtn.Name = "evianBtn"
        Me.evianBtn.Size = New System.Drawing.Size(40, 24)
        Me.evianBtn.TabIndex = 38
        Me.evianBtn.Text = "1.00"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Coke)
        Me.Panel3.Controls.Add(Me.Pepsi)
        Me.Panel3.Controls.Add(Me.Snapple)
        Me.Panel3.Controls.Add(Me.MountainDew)
        Me.Panel3.Controls.Add(Me.Evian)
        Me.Panel3.Location = New System.Drawing.Point(24, 312)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(312, 80)
        Me.Panel3.TabIndex = 37
        '
        'Coke
        '
        Me.Coke.Image = CType(resources.GetObject("Coke.Image"), System.Drawing.Image)
        Me.Coke.Location = New System.Drawing.Point(16, 0)
        Me.Coke.Name = "Coke"
        Me.Coke.Size = New System.Drawing.Size(40, 72)
        Me.Coke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coke.TabIndex = 0
        Me.Coke.TabStop = False
        '
        'Pepsi
        '
        Me.Pepsi.Image = CType(resources.GetObject("Pepsi.Image"), System.Drawing.Image)
        Me.Pepsi.Location = New System.Drawing.Point(72, 0)
        Me.Pepsi.Name = "Pepsi"
        Me.Pepsi.Size = New System.Drawing.Size(40, 64)
        Me.Pepsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pepsi.TabIndex = 2
        Me.Pepsi.TabStop = False
        '
        'Snapple
        '
        Me.Snapple.Image = CType(resources.GetObject("Snapple.Image"), System.Drawing.Image)
        Me.Snapple.Location = New System.Drawing.Point(128, 0)
        Me.Snapple.Name = "Snapple"
        Me.Snapple.Size = New System.Drawing.Size(40, 72)
        Me.Snapple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Snapple.TabIndex = 2
        Me.Snapple.TabStop = False
        '
        'MountainDew
        '
        Me.MountainDew.Image = CType(resources.GetObject("MountainDew.Image"), System.Drawing.Image)
        Me.MountainDew.Location = New System.Drawing.Point(184, 0)
        Me.MountainDew.Name = "MountainDew"
        Me.MountainDew.Size = New System.Drawing.Size(32, 72)
        Me.MountainDew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MountainDew.TabIndex = 2
        Me.MountainDew.TabStop = False
        '
        'Evian
        '
        Me.Evian.Image = CType(resources.GetObject("Evian.Image"), System.Drawing.Image)
        Me.Evian.Location = New System.Drawing.Point(240, 0)
        Me.Evian.Name = "Evian"
        Me.Evian.Size = New System.Drawing.Size(32, 72)
        Me.Evian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Evian.TabIndex = 2
        Me.Evian.TabStop = False
        '
        'chipsBtn
        '
        Me.chipsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chipsBtn.Location = New System.Drawing.Point(48, 256)
        Me.chipsBtn.Name = "chipsBtn"
        Me.chipsBtn.Size = New System.Drawing.Size(40, 24)
        Me.chipsBtn.TabIndex = 36
        Me.chipsBtn.Text = "0.50"
        '
        'CheezBtn
        '
        Me.CheezBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheezBtn.Location = New System.Drawing.Point(152, 256)
        Me.CheezBtn.Name = "CheezBtn"
        Me.CheezBtn.Size = New System.Drawing.Size(40, 24)
        Me.CheezBtn.TabIndex = 34
        Me.CheezBtn.Text = "1.25"
        '
        'LaysBtn
        '
        Me.LaysBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaysBtn.Location = New System.Drawing.Point(96, 256)
        Me.LaysBtn.Name = "LaysBtn"
        Me.LaysBtn.Size = New System.Drawing.Size(40, 24)
        Me.LaysBtn.TabIndex = 35
        Me.LaysBtn.Text = "0.50"
        '
        'pringlesBtn
        '
        Me.pringlesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pringlesBtn.Location = New System.Drawing.Point(208, 256)
        Me.pringlesBtn.Name = "pringlesBtn"
        Me.pringlesBtn.Size = New System.Drawing.Size(40, 24)
        Me.pringlesBtn.TabIndex = 33
        Me.pringlesBtn.Text = "1.25"
        '
        'FritosBtn
        '
        Me.FritosBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FritosBtn.Location = New System.Drawing.Point(264, 256)
        Me.FritosBtn.Name = "FritosBtn"
        Me.FritosBtn.Size = New System.Drawing.Size(40, 24)
        Me.FritosBtn.TabIndex = 32
        Me.FritosBtn.Text = "0.50"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Chips)
        Me.Panel2.Controls.Add(Me.Lays)
        Me.Panel2.Controls.Add(Me.CheezIt)
        Me.Panel2.Controls.Add(Me.Pringles)
        Me.Panel2.Controls.Add(Me.Fritos)
        Me.Panel2.Location = New System.Drawing.Point(24, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 80)
        Me.Panel2.TabIndex = 31
        '
        'Chips
        '
        Me.Chips.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(255, Byte))
        Me.Chips.Image = CType(resources.GetObject("Chips.Image"), System.Drawing.Image)
        Me.Chips.Location = New System.Drawing.Point(16, 8)
        Me.Chips.Name = "Chips"
        Me.Chips.Size = New System.Drawing.Size(48, 56)
        Me.Chips.TabIndex = 0
        Me.Chips.TabStop = False
        '
        'Lays
        '
        Me.Lays.Image = CType(resources.GetObject("Lays.Image"), System.Drawing.Image)
        Me.Lays.Location = New System.Drawing.Point(72, 8)
        Me.Lays.Name = "Lays"
        Me.Lays.Size = New System.Drawing.Size(40, 56)
        Me.Lays.TabIndex = 2
        Me.Lays.TabStop = False
        '
        'CheezIt
        '
        Me.CheezIt.Image = CType(resources.GetObject("CheezIt.Image"), System.Drawing.Image)
        Me.CheezIt.Location = New System.Drawing.Point(128, 8)
        Me.CheezIt.Name = "CheezIt"
        Me.CheezIt.Size = New System.Drawing.Size(40, 56)
        Me.CheezIt.TabIndex = 2
        Me.CheezIt.TabStop = False
        '
        'Pringles
        '
        Me.Pringles.Image = CType(resources.GetObject("Pringles.Image"), System.Drawing.Image)
        Me.Pringles.Location = New System.Drawing.Point(192, 8)
        Me.Pringles.Name = "Pringles"
        Me.Pringles.Size = New System.Drawing.Size(24, 64)
        Me.Pringles.TabIndex = 2
        Me.Pringles.TabStop = False
        '
        'Fritos
        '
        Me.Fritos.Image = CType(resources.GetObject("Fritos.Image"), System.Drawing.Image)
        Me.Fritos.Location = New System.Drawing.Point(232, 8)
        Me.Fritos.Name = "Fritos"
        Me.Fritos.Size = New System.Drawing.Size(48, 56)
        Me.Fritos.TabIndex = 2
        Me.Fritos.TabStop = False
        '
        'HersBtn
        '
        Me.HersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HersBtn.Location = New System.Drawing.Point(40, 112)
        Me.HersBtn.Name = "HersBtn"
        Me.HersBtn.Size = New System.Drawing.Size(40, 24)
        Me.HersBtn.TabIndex = 30
        Me.HersBtn.Text = "0.85"
        '
        'MnM1Btn
        '
        Me.MnM1Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MnM1Btn.Location = New System.Drawing.Point(96, 112)
        Me.MnM1Btn.Name = "MnM1Btn"
        Me.MnM1Btn.Size = New System.Drawing.Size(40, 24)
        Me.MnM1Btn.TabIndex = 29
        Me.MnM1Btn.Text = "0.70"
        '
        'MnM2Btn
        '
        Me.MnM2Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MnM2Btn.Location = New System.Drawing.Point(152, 112)
        Me.MnM2Btn.Name = "MnM2Btn"
        Me.MnM2Btn.Size = New System.Drawing.Size(40, 24)
        Me.MnM2Btn.TabIndex = 28
        Me.MnM2Btn.Text = "0.70"
        '
        'snickersBtn
        '
        Me.snickersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.snickersBtn.Location = New System.Drawing.Point(208, 112)
        Me.snickersBtn.Name = "snickersBtn"
        Me.snickersBtn.Size = New System.Drawing.Size(40, 24)
        Me.snickersBtn.TabIndex = 27
        Me.snickersBtn.Text = "0.95"
        '
        'skittlesBtn
        '
        Me.skittlesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.skittlesBtn.Location = New System.Drawing.Point(264, 112)
        Me.skittlesBtn.Name = "skittlesBtn"
        Me.skittlesBtn.Size = New System.Drawing.Size(40, 24)
        Me.skittlesBtn.TabIndex = 26
        Me.skittlesBtn.Text = "0.55"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Hershey)
        Me.Panel1.Controls.Add(Me.MnMBrown)
        Me.Panel1.Controls.Add(Me.MnMYellow)
        Me.Panel1.Controls.Add(Me.Snickers)
        Me.Panel1.Controls.Add(Me.Skittles)
        Me.Panel1.Location = New System.Drawing.Point(24, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 80)
        Me.Panel1.TabIndex = 25
        '
        'Hershey
        '
        Me.Hershey.Image = CType(resources.GetObject("Hershey.Image"), System.Drawing.Image)
        Me.Hershey.Location = New System.Drawing.Point(24, 8)
        Me.Hershey.Name = "Hershey"
        Me.Hershey.Size = New System.Drawing.Size(24, 64)
        Me.Hershey.TabIndex = 0
        Me.Hershey.TabStop = False
        '
        'MnMBrown
        '
        Me.MnMBrown.Image = CType(resources.GetObject("MnMBrown.Image"), System.Drawing.Image)
        Me.MnMBrown.Location = New System.Drawing.Point(72, 8)
        Me.MnMBrown.Name = "MnMBrown"
        Me.MnMBrown.Size = New System.Drawing.Size(32, 64)
        Me.MnMBrown.TabIndex = 2
        Me.MnMBrown.TabStop = False
        '
        'MnMYellow
        '
        Me.MnMYellow.Image = CType(resources.GetObject("MnMYellow.Image"), System.Drawing.Image)
        Me.MnMYellow.Location = New System.Drawing.Point(128, 8)
        Me.MnMYellow.Name = "MnMYellow"
        Me.MnMYellow.Size = New System.Drawing.Size(32, 56)
        Me.MnMYellow.TabIndex = 2
        Me.MnMYellow.TabStop = False
        '
        'Snickers
        '
        Me.Snickers.Image = CType(resources.GetObject("Snickers.Image"), System.Drawing.Image)
        Me.Snickers.Location = New System.Drawing.Point(192, 8)
        Me.Snickers.Name = "Snickers"
        Me.Snickers.Size = New System.Drawing.Size(24, 64)
        Me.Snickers.TabIndex = 2
        Me.Snickers.TabStop = False
        '
        'Skittles
        '
        Me.Skittles.Image = CType(resources.GetObject("Skittles.Image"), System.Drawing.Image)
        Me.Skittles.Location = New System.Drawing.Point(248, 8)
        Me.Skittles.Name = "Skittles"
        Me.Skittles.Size = New System.Drawing.Size(24, 56)
        Me.Skittles.TabIndex = 2
        Me.Skittles.TabStop = False
        '
        'VendingMachineIMG
        '
        Me.VendingMachineIMG.BackColor = System.Drawing.Color.White
        Me.VendingMachineIMG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VendingMachineIMG.Cursor = System.Windows.Forms.Cursors.Help
        Me.VendingMachineIMG.Image = CType(resources.GetObject("VendingMachineIMG.Image"), System.Drawing.Image)
        Me.VendingMachineIMG.Location = New System.Drawing.Point(8, 8)
        Me.VendingMachineIMG.Name = "VendingMachineIMG"
        Me.VendingMachineIMG.Size = New System.Drawing.Size(352, 584)
        Me.VendingMachineIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VendingMachineIMG.TabIndex = 24
        Me.VendingMachineIMG.TabStop = False
        '
        'MoneyReturnTB
        '
        Me.MoneyReturnTB.AutoSize = False
        Me.MoneyReturnTB.BackColor = System.Drawing.Color.Maroon
        Me.MoneyReturnTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyReturnTB.ForeColor = System.Drawing.Color.Silver
        Me.MoneyReturnTB.Location = New System.Drawing.Point(624, 424)
        Me.MoneyReturnTB.Name = "MoneyReturnTB"
        Me.MoneyReturnTB.ReadOnly = True
        Me.MoneyReturnTB.Size = New System.Drawing.Size(104, 24)
        Me.MoneyReturnTB.TabIndex = 47
        Me.MoneyReturnTB.Text = ""
        Me.MoneyReturnTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(528, 432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Money Returned:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.DollarReturnLBL)
        Me.Panel4.Controls.Add(Me.DimeReturnImg)
        Me.Panel4.Controls.Add(Me.NickelReturnImg)
        Me.Panel4.Controls.Add(Me.QuarterReturnImg)
        Me.Panel4.Controls.Add(Me.DollarReturnImg)
        Me.Panel4.Controls.Add(Me.QuarterReturnLBL)
        Me.Panel4.Controls.Add(Me.DimeReturnLBL)
        Me.Panel4.Controls.Add(Me.NickelReturnLBL)
        Me.Panel4.Location = New System.Drawing.Point(368, 448)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(360, 136)
        Me.Panel4.TabIndex = 46
        '
        'DollarReturnLBL
        '
        Me.DollarReturnLBL.Location = New System.Drawing.Point(104, 24)
        Me.DollarReturnLBL.Name = "DollarReturnLBL"
        Me.DollarReturnLBL.Size = New System.Drawing.Size(72, 16)
        Me.DollarReturnLBL.TabIndex = 4
        '
        'DimeReturnImg
        '
        Me.DimeReturnImg.Image = CType(resources.GetObject("DimeReturnImg.Image"), System.Drawing.Image)
        Me.DimeReturnImg.Location = New System.Drawing.Point(48, 80)
        Me.DimeReturnImg.Name = "DimeReturnImg"
        Me.DimeReturnImg.Size = New System.Drawing.Size(40, 40)
        Me.DimeReturnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DimeReturnImg.TabIndex = 3
        Me.DimeReturnImg.TabStop = False
        '
        'NickelReturnImg
        '
        Me.NickelReturnImg.Image = CType(resources.GetObject("NickelReturnImg.Image"), System.Drawing.Image)
        Me.NickelReturnImg.Location = New System.Drawing.Point(200, 80)
        Me.NickelReturnImg.Name = "NickelReturnImg"
        Me.NickelReturnImg.Size = New System.Drawing.Size(56, 48)
        Me.NickelReturnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NickelReturnImg.TabIndex = 2
        Me.NickelReturnImg.TabStop = False
        '
        'QuarterReturnImg
        '
        Me.QuarterReturnImg.Image = CType(resources.GetObject("QuarterReturnImg.Image"), System.Drawing.Image)
        Me.QuarterReturnImg.Location = New System.Drawing.Point(192, 0)
        Me.QuarterReturnImg.Name = "QuarterReturnImg"
        Me.QuarterReturnImg.Size = New System.Drawing.Size(64, 64)
        Me.QuarterReturnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuarterReturnImg.TabIndex = 1
        Me.QuarterReturnImg.TabStop = False
        '
        'DollarReturnImg
        '
        Me.DollarReturnImg.Image = CType(resources.GetObject("DollarReturnImg.Image"), System.Drawing.Image)
        Me.DollarReturnImg.Location = New System.Drawing.Point(8, 8)
        Me.DollarReturnImg.Name = "DollarReturnImg"
        Me.DollarReturnImg.Size = New System.Drawing.Size(80, 40)
        Me.DollarReturnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DollarReturnImg.TabIndex = 0
        Me.DollarReturnImg.TabStop = False
        '
        'QuarterReturnLBL
        '
        Me.QuarterReturnLBL.Location = New System.Drawing.Point(272, 24)
        Me.QuarterReturnLBL.Name = "QuarterReturnLBL"
        Me.QuarterReturnLBL.Size = New System.Drawing.Size(72, 16)
        Me.QuarterReturnLBL.TabIndex = 32
        '
        'DimeReturnLBL
        '
        Me.DimeReturnLBL.Location = New System.Drawing.Point(104, 96)
        Me.DimeReturnLBL.Name = "DimeReturnLBL"
        Me.DimeReturnLBL.Size = New System.Drawing.Size(72, 16)
        Me.DimeReturnLBL.TabIndex = 32
        '
        'NickelReturnLBL
        '
        Me.NickelReturnLBL.Location = New System.Drawing.Point(272, 96)
        Me.NickelReturnLBL.Name = "NickelReturnLBL"
        Me.NickelReturnLBL.Size = New System.Drawing.Size(72, 16)
        Me.NickelReturnLBL.TabIndex = 32
        '
        'StatusTB
        '
        Me.StatusTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StatusTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTB.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.StatusTB.Location = New System.Drawing.Point(384, 280)
        Me.StatusTB.Name = "StatusTB"
        Me.StatusTB.ReadOnly = True
        Me.StatusTB.Size = New System.Drawing.Size(344, 96)
        Me.StatusTB.TabIndex = 49
        Me.StatusTB.Text = ""
        '
        'dimeImg
        '
        Me.dimeImg.BackColor = System.Drawing.Color.White
        Me.dimeImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dimeImg.Image = CType(resources.GetObject("dimeImg.Image"), System.Drawing.Image)
        Me.dimeImg.Location = New System.Drawing.Point(512, 104)
        Me.dimeImg.Name = "dimeImg"
        Me.dimeImg.Size = New System.Drawing.Size(48, 48)
        Me.dimeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dimeImg.TabIndex = 54
        Me.dimeImg.TabStop = False
        '
        'QuarterImg
        '
        Me.QuarterImg.BackColor = System.Drawing.Color.White
        Me.QuarterImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuarterImg.Image = CType(resources.GetObject("QuarterImg.Image"), System.Drawing.Image)
        Me.QuarterImg.Location = New System.Drawing.Point(384, 80)
        Me.QuarterImg.Name = "QuarterImg"
        Me.QuarterImg.Size = New System.Drawing.Size(80, 72)
        Me.QuarterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuarterImg.TabIndex = 53
        Me.QuarterImg.TabStop = False
        '
        'DollarBillImg
        '
        Me.DollarBillImg.BackColor = System.Drawing.Color.White
        Me.DollarBillImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DollarBillImg.Image = CType(resources.GetObject("DollarBillImg.Image"), System.Drawing.Image)
        Me.DollarBillImg.Location = New System.Drawing.Point(424, 168)
        Me.DollarBillImg.Name = "DollarBillImg"
        Me.DollarBillImg.Size = New System.Drawing.Size(232, 104)
        Me.DollarBillImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DollarBillImg.TabIndex = 56
        Me.DollarBillImg.TabStop = False
        '
        'NickelImg
        '
        Me.NickelImg.BackColor = System.Drawing.Color.White
        Me.NickelImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NickelImg.Image = CType(resources.GetObject("NickelImg.Image"), System.Drawing.Image)
        Me.NickelImg.Location = New System.Drawing.Point(632, 88)
        Me.NickelImg.Name = "NickelImg"
        Me.NickelImg.Size = New System.Drawing.Size(64, 64)
        Me.NickelImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NickelImg.TabIndex = 55
        Me.NickelImg.TabStop = False
        '
        'MoneyAvailLbl
        '
        Me.MoneyAvailLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyAvailLbl.ForeColor = System.Drawing.Color.Maroon
        Me.MoneyAvailLbl.Location = New System.Drawing.Point(440, 24)
        Me.MoneyAvailLbl.Name = "MoneyAvailLbl"
        Me.MoneyAvailLbl.Size = New System.Drawing.Size(96, 16)
        Me.MoneyAvailLbl.TabIndex = 52
        Me.MoneyAvailLbl.Text = "Money Available:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(416, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Click on money to deposit in machine"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MoneyDepositTB
        '
        Me.MoneyDepositTB.AutoSize = False
        Me.MoneyDepositTB.BackColor = System.Drawing.Color.Silver
        Me.MoneyDepositTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyDepositTB.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.MoneyDepositTB.Location = New System.Drawing.Point(544, 16)
        Me.MoneyDepositTB.Name = "MoneyDepositTB"
        Me.MoneyDepositTB.ReadOnly = True
        Me.MoneyDepositTB.Size = New System.Drawing.Size(176, 32)
        Me.MoneyDepositTB.TabIndex = 50
        Me.MoneyDepositTB.Text = ""
        Me.MoneyDepositTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SkittlesSoldOutLBL
        '
        Me.SkittlesSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.SkittlesSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkittlesSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.SkittlesSoldOutLBL.Location = New System.Drawing.Point(264, 112)
        Me.SkittlesSoldOutLBL.Name = "SkittlesSoldOutLBL"
        Me.SkittlesSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.SkittlesSoldOutLBL.TabIndex = 57
        Me.SkittlesSoldOutLBL.Text = "Sold Out"
        Me.SkittlesSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SkittlesSoldOutLBL.Visible = False
        '
        'ChangeReturnBTN
        '
        Me.ChangeReturnBTN.BackColor = System.Drawing.Color.Silver
        Me.ChangeReturnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangeReturnBTN.Location = New System.Drawing.Point(376, 384)
        Me.ChangeReturnBTN.Name = "ChangeReturnBTN"
        Me.ChangeReturnBTN.Size = New System.Drawing.Size(128, 56)
        Me.ChangeReturnBTN.TabIndex = 58
        Me.ChangeReturnBTN.Text = "&Return Change"
        '
        'SnickersSoldOutLBL
        '
        Me.SnickersSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.SnickersSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SnickersSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.SnickersSoldOutLBL.Location = New System.Drawing.Point(208, 112)
        Me.SnickersSoldOutLBL.Name = "SnickersSoldOutLBL"
        Me.SnickersSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.SnickersSoldOutLBL.TabIndex = 59
        Me.SnickersSoldOutLBL.Text = "Sold Out"
        Me.SnickersSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SnickersSoldOutLBL.Visible = False
        '
        'MnMYellowSoldOutLBL
        '
        Me.MnMYellowSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.MnMYellowSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnMYellowSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MnMYellowSoldOutLBL.Location = New System.Drawing.Point(152, 112)
        Me.MnMYellowSoldOutLBL.Name = "MnMYellowSoldOutLBL"
        Me.MnMYellowSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.MnMYellowSoldOutLBL.TabIndex = 60
        Me.MnMYellowSoldOutLBL.Text = "Sold Out"
        Me.MnMYellowSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MnMYellowSoldOutLBL.Visible = False
        '
        'MnMBrownSoldOutLBL
        '
        Me.MnMBrownSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.MnMBrownSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnMBrownSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MnMBrownSoldOutLBL.Location = New System.Drawing.Point(96, 112)
        Me.MnMBrownSoldOutLBL.Name = "MnMBrownSoldOutLBL"
        Me.MnMBrownSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.MnMBrownSoldOutLBL.TabIndex = 61
        Me.MnMBrownSoldOutLBL.Text = "Sold Out"
        Me.MnMBrownSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MnMBrownSoldOutLBL.Visible = False
        '
        'HersheysSoldOutLBL
        '
        Me.HersheysSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.HersheysSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HersheysSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.HersheysSoldOutLBL.Location = New System.Drawing.Point(40, 112)
        Me.HersheysSoldOutLBL.Name = "HersheysSoldOutLBL"
        Me.HersheysSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.HersheysSoldOutLBL.TabIndex = 62
        Me.HersheysSoldOutLBL.Text = "Sold Out"
        Me.HersheysSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HersheysSoldOutLBL.Visible = False
        '
        'FritosSoldOutLBL
        '
        Me.FritosSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.FritosSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FritosSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.FritosSoldOutLBL.Location = New System.Drawing.Point(264, 256)
        Me.FritosSoldOutLBL.Name = "FritosSoldOutLBL"
        Me.FritosSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.FritosSoldOutLBL.TabIndex = 63
        Me.FritosSoldOutLBL.Text = "Sold Out"
        Me.FritosSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FritosSoldOutLBL.Visible = False
        '
        'PringlesSoldOutLBL
        '
        Me.PringlesSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.PringlesSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PringlesSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.PringlesSoldOutLBL.Location = New System.Drawing.Point(208, 256)
        Me.PringlesSoldOutLBL.Name = "PringlesSoldOutLBL"
        Me.PringlesSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.PringlesSoldOutLBL.TabIndex = 64
        Me.PringlesSoldOutLBL.Text = "Sold Out"
        Me.PringlesSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PringlesSoldOutLBL.Visible = False
        '
        'CheezItSoldOutLBL
        '
        Me.CheezItSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.CheezItSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheezItSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.CheezItSoldOutLBL.Location = New System.Drawing.Point(152, 256)
        Me.CheezItSoldOutLBL.Name = "CheezItSoldOutLBL"
        Me.CheezItSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.CheezItSoldOutLBL.TabIndex = 65
        Me.CheezItSoldOutLBL.Text = "Sold Out"
        Me.CheezItSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheezItSoldOutLBL.Visible = False
        '
        'LaysSoldOutLBL
        '
        Me.LaysSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.LaysSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaysSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LaysSoldOutLBL.Location = New System.Drawing.Point(96, 256)
        Me.LaysSoldOutLBL.Name = "LaysSoldOutLBL"
        Me.LaysSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.LaysSoldOutLBL.TabIndex = 66
        Me.LaysSoldOutLBL.Text = "Sold Out"
        Me.LaysSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LaysSoldOutLBL.Visible = False
        '
        'ChipsSoldOutLBL
        '
        Me.ChipsSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.ChipsSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChipsSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.ChipsSoldOutLBL.Location = New System.Drawing.Point(48, 256)
        Me.ChipsSoldOutLBL.Name = "ChipsSoldOutLBL"
        Me.ChipsSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.ChipsSoldOutLBL.TabIndex = 67
        Me.ChipsSoldOutLBL.Text = "Sold Out"
        Me.ChipsSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChipsSoldOutLBL.Visible = False
        '
        'EvianSoldOutLBL
        '
        Me.EvianSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.EvianSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EvianSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.EvianSoldOutLBL.Location = New System.Drawing.Point(264, 400)
        Me.EvianSoldOutLBL.Name = "EvianSoldOutLBL"
        Me.EvianSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.EvianSoldOutLBL.TabIndex = 68
        Me.EvianSoldOutLBL.Text = "Sold Out"
        Me.EvianSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EvianSoldOutLBL.Visible = False
        '
        'MntDewSoldOutLBL
        '
        Me.MntDewSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.MntDewSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MntDewSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MntDewSoldOutLBL.Location = New System.Drawing.Point(208, 400)
        Me.MntDewSoldOutLBL.Name = "MntDewSoldOutLBL"
        Me.MntDewSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.MntDewSoldOutLBL.TabIndex = 69
        Me.MntDewSoldOutLBL.Text = "Sold Out"
        Me.MntDewSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MntDewSoldOutLBL.Visible = False
        '
        'SnapplesSoldOutLBL
        '
        Me.SnapplesSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.SnapplesSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SnapplesSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.SnapplesSoldOutLBL.Location = New System.Drawing.Point(152, 400)
        Me.SnapplesSoldOutLBL.Name = "SnapplesSoldOutLBL"
        Me.SnapplesSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.SnapplesSoldOutLBL.TabIndex = 70
        Me.SnapplesSoldOutLBL.Text = "Sold Out"
        Me.SnapplesSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SnapplesSoldOutLBL.Visible = False
        '
        'PepsiSoldOutLBL
        '
        Me.PepsiSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.PepsiSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PepsiSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.PepsiSoldOutLBL.Location = New System.Drawing.Point(96, 400)
        Me.PepsiSoldOutLBL.Name = "PepsiSoldOutLBL"
        Me.PepsiSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.PepsiSoldOutLBL.TabIndex = 71
        Me.PepsiSoldOutLBL.Text = "Sold Out"
        Me.PepsiSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PepsiSoldOutLBL.Visible = False
        '
        'CokeSoldOutLBL
        '
        Me.CokeSoldOutLBL.BackColor = System.Drawing.Color.IndianRed
        Me.CokeSoldOutLBL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CokeSoldOutLBL.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.CokeSoldOutLBL.Location = New System.Drawing.Point(40, 400)
        Me.CokeSoldOutLBL.Name = "CokeSoldOutLBL"
        Me.CokeSoldOutLBL.Size = New System.Drawing.Size(40, 24)
        Me.CokeSoldOutLBL.TabIndex = 72
        Me.CokeSoldOutLBL.Text = "Sold Out"
        Me.CokeSoldOutLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CokeSoldOutLBL.Visible = False
        '
        'ResetMoneyReturnTimer
        '
        Me.ResetMoneyReturnTimer.Interval = 5000
        '
        'cmdAbout
        '
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbout.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.Location = New System.Drawing.Point(296, 552)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(40, 24)
        Me.cmdAbout.TabIndex = 73
        Me.cmdAbout.Text = "&About"
        '
        'VendingMachine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 598)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.CokeSoldOutLBL)
        Me.Controls.Add(Me.PepsiSoldOutLBL)
        Me.Controls.Add(Me.SnapplesSoldOutLBL)
        Me.Controls.Add(Me.MntDewSoldOutLBL)
        Me.Controls.Add(Me.EvianSoldOutLBL)
        Me.Controls.Add(Me.ChipsSoldOutLBL)
        Me.Controls.Add(Me.LaysSoldOutLBL)
        Me.Controls.Add(Me.CheezItSoldOutLBL)
        Me.Controls.Add(Me.PringlesSoldOutLBL)
        Me.Controls.Add(Me.FritosSoldOutLBL)
        Me.Controls.Add(Me.HersheysSoldOutLBL)
        Me.Controls.Add(Me.MnMBrownSoldOutLBL)
        Me.Controls.Add(Me.MnMYellowSoldOutLBL)
        Me.Controls.Add(Me.SnickersSoldOutLBL)
        Me.Controls.Add(Me.ChangeReturnBTN)
        Me.Controls.Add(Me.SkittlesSoldOutLBL)
        Me.Controls.Add(Me.dimeImg)
        Me.Controls.Add(Me.QuarterImg)
        Me.Controls.Add(Me.DollarBillImg)
        Me.Controls.Add(Me.NickelImg)
        Me.Controls.Add(Me.MoneyAvailLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MoneyDepositTB)
        Me.Controls.Add(Me.StatusTB)
        Me.Controls.Add(Me.MoneyReturnTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.gateLeftImg)
        Me.Controls.Add(Me.gateRightImg)
        Me.Controls.Add(Me.ItemGateImg)
        Me.Controls.Add(Me.cokeBtn)
        Me.Controls.Add(Me.SnappleBtn)
        Me.Controls.Add(Me.pepsiBtn)
        Me.Controls.Add(Me.mntdewBtn)
        Me.Controls.Add(Me.evianBtn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.chipsBtn)
        Me.Controls.Add(Me.CheezBtn)
        Me.Controls.Add(Me.LaysBtn)
        Me.Controls.Add(Me.pringlesBtn)
        Me.Controls.Add(Me.FritosBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.HersBtn)
        Me.Controls.Add(Me.MnM1Btn)
        Me.Controls.Add(Me.MnM2Btn)
        Me.Controls.Add(Me.snickersBtn)
        Me.Controls.Add(Me.skittlesBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VendingMachineIMG)
        Me.MaximizeBox = False
        Me.Name = "VendingMachine"
        Me.Text = "Vending Machine"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'form on load settings
    Private Sub VendingMachine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set 'Money Return' images visibility = false
        DollarReturnImg.Visible = False
        NickelReturnImg.Visible = False
        DimeReturnImg.Visible = False
        QuarterReturnImg.Visible = False


    End Sub

    'start mouse over behavior
    Private Sub DollarBillImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DollarBillImg.MouseEnter
        DollarBillImg.Location = New Point(DollarBillImg.Location.X + 2, DollarBillImg.Location.Y + 2)

    End Sub

    Private Sub DollarBillImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DollarBillImg.MouseLeave

        DollarBillImg.Location = New Point(DollarBillImg.Location.X - 2, DollarBillImg.Location.Y - 2)

    End Sub




    Private Sub QuarterImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuarterImg.MouseEnter
        QuarterImg.Location = New Point(QuarterImg.Location.X + 2, QuarterImg.Location.Y + 2)
    End Sub

    Private Sub QuarterImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuarterImg.MouseLeave
        QuarterImg.Location = New Point(QuarterImg.Location.X - 2, QuarterImg.Location.Y - 2)
    End Sub


    Private Sub dimeImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dimeImg.MouseEnter
        dimeImg.Location = New Point(dimeImg.Location.X + 2, dimeImg.Location.Y + 2)
    End Sub


    Private Sub dimeImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dimeImg.MouseLeave
        dimeImg.Location = New Point(dimeImg.Location.X - 2, dimeImg.Location.Y - 2)
    End Sub


    Private Sub NickelImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles NickelImg.MouseEnter
        NickelImg.Location = New Point(NickelImg.Location.X + 2, NickelImg.Location.Y + 2)
    End Sub

    Private Sub NickelImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NickelImg.MouseLeave
        NickelImg.Location = New Point(NickelImg.Location.X - 2, NickelImg.Location.Y - 2)
    End Sub




    ' Returns a random number, between the optional Low and High parameters 
    Public Function GetRandomNumber( _
          Optional ByVal Low As Integer = 1, _
          Optional ByVal High As Integer = 100) As Integer

        Return objRandom.Next(Low, High + 1)
    End Function


    'Calculates the amount to return after transaction
    Private Sub CalculateChange(ByVal AvailableMoney As Decimal)

        If (AvailableMoney = 0) Then
            MoneyAvailable = 0
            MoneyDepositTB.Text = ""
            Exit Sub


        End If

        Dim dollar As Single = 1.0

        Dim quater As Single = 0.25

        Dim dime As Single = 0.1

        Dim nickle As Single = 0.05

        Dim amount As Decimal

        Dim sale As Decimal

        Dim dollarCounter As Single = 0

        Dim quaterCounter As Single = 0

        Dim dimeCounter As Single = 0

        Dim nickleCounter As Single = 0

        sale = AvailableMoney

        amount = sale

        Do Until amount < 1.0

            If amount >= 1.0 Then

                amount += Convert.ToDecimal(-dollar)

                dollarCounter += 1

            End If

        Loop

        Do Until amount < 0.25

            If amount >= 0.25 Then

                amount += Convert.ToDecimal(-quater)

                quaterCounter += 1

            End If

        Loop

        Do Until amount < 0.1

            If amount >= 0.1 Then

                amount += Convert.ToDecimal(-dime)

                dimeCounter += 1

            End If

        Loop

        Do Until amount < 0.05

            If amount >= 0.05 Then

                amount += Convert.ToDecimal(-nickle)

                nickleCounter += 1

            End If

        Loop

        If (dollarCounter >= 1) Then
            DollarReturnImg.Visible = True
            DollarReturnLBL.Text = "x " & dollarCounter


        End If

        If (quaterCounter >= 1) Then
            QuarterReturnImg.Visible = True
            QuarterReturnLBL.Text = "x " & quaterCounter

        End If

        If (dimeCounter >= 1) Then
            DimeReturnImg.Visible = True
            DimeReturnLBL.Text = "x " & dimeCounter

        End If

        If (nickleCounter >= 1) Then
            NickelReturnImg.Visible = True
            NickelReturnLBL.Text = "x " & nickleCounter



        End If
        StatusTB.Text = "Please remove your change..."

        MoneyReturnTB.Text = MoneyAvailable.ToString("C")
        MoneyDepositTB.Text = ""

        MoneyAvailable = 0.0







    End Sub

    'moves two picture boxes to create the feeling of a gate opening.
    Private Sub OpenGate()

        StatusTB.Text = "Please remove your item."

        Dim i As System.Drawing.Point

        Dim ixLeftGate, ixRightGate, r, r2 As Integer

        i = gateLeftImg.Location()

        ixLeftGate = gateLeftImg.Location.X
        ixRightGate = gateRightImg.Location.X

        For r = 1 To 20
            ixLeftGate = gateLeftImg.Location.X
            ixLeftGate = ixLeftGate - 1
            gateLeftImg.Location() = New Point(ixLeftGate, gateLeftImg.Location.Y)




            ixRightGate = gateRightImg.Location.X
            ixRightGate = ixRightGate + 1
            gateRightImg.Location() = New Point(ixRightGate, gateRightImg.Location.Y)

            Me.Refresh()
            System.Threading.Thread.Sleep(100)            '   sleep for .1 a second

        Next

        System.Threading.Thread.Sleep(1000) 'milliseconds



        For r = 1 To 20
            ixLeftGate = gateLeftImg.Location.X
            ixLeftGate = ixLeftGate + 1
            gateLeftImg.Location() = New Point(ixLeftGate, gateLeftImg.Location.Y)




            ixRightGate = gateRightImg.Location.X
            ixRightGate = ixRightGate - 1
            gateRightImg.Location() = New Point(ixRightGate, gateRightImg.Location.Y)

            Me.Refresh()
            System.Threading.Thread.Sleep(100)            '   sleep for .1 a second

        Next
    End Sub


    Private Sub SendItemToGate(ByVal ItemName As PictureBox)
        Dim i As System.Drawing.Point
        Dim iy As Integer




        i = ItemName.Location()
        iy = ItemName.Location.Y
        Dim r As Integer
        For r = 1 To 20
            iy = ItemName.Location.Y
            iy = iy + 5
            ItemName.Location() = New Point(ItemName.Location.X, iy)
            Me.Refresh()
            System.Threading.Thread.Sleep(30)            '   sleep for .1 a second

        Next

        ItemGateImg.Image = ItemName.Image
        Call OpenGate()

        'Put the picturebox back in its original location
        For r = 1 To 20
            iy = ItemName.Location.Y
            iy = iy - 5
            ItemName.Location() = New Point(ItemName.Location.X, iy)

        Next


    End Sub

    'Clears fields and resets them to remove any values
    Private Sub ResetComponents()

        DollarReturnImg.Visible = False
        NickelReturnImg.Visible = False
        DimeReturnImg.Visible = False
        QuarterReturnImg.Visible = False



        StatusTB.Text = ""
        MoneyReturnTB.Text = ""

        DollarReturnLBL.Text = ""
        QuarterReturnLBL.Text = ""
        DimeReturnLBL.Text = ""
        NickelReturnLBL.Text = ""


    End Sub

    'Returns unused amount to user
    Private Sub ChangeReturnBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeReturnBTN.Click
        If (MoneyAvailable > 0) Then

            CalculateChange(MoneyAvailable)
            ResetMoneyReturnTimer.Enabled = True

        Else
            MsgBox("You do not have any deposited money to return", MsgBoxStyle.Exclamation, "Zero Balance")


        End If
    End Sub




    Private Sub DollarBillImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DollarBillImg.Click
        Dim i As Integer
        Dim TempMoneyCount As Decimal

        For i = 1 To 100 Step 3
            TempMoneyCount = i / 100 + MoneyAvailable
            Me.Refresh()

            MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        Next

        MoneyAvailable = MoneyAvailable + 1.0

    End Sub


    Private Sub QuarterImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuarterImg.Click
        Dim i As Integer
        Dim TempMoneyCount As Decimal

        For i = 1 To 25 Step 3
            TempMoneyCount = i / 100 + MoneyAvailable
            Me.Refresh()

            MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        Next

        MoneyAvailable = MoneyAvailable + 0.25
    End Sub

    Private Sub dimeImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dimeImg.Click
        Dim i As Integer
        Dim TempMoneyCount As Decimal

        For i = 1 To 10
            TempMoneyCount = i / 100 + MoneyAvailable
            Me.Refresh()

            MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        Next

        MoneyAvailable = MoneyAvailable + 0.1
    End Sub

    Private Sub NickelImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NickelImg.Click
        Dim i As Integer
        Dim TempMoneyCount As Decimal

        For i = 1 To 5
            TempMoneyCount = i / 100 + MoneyAvailable
            Me.Refresh()

            MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        Next

        MoneyAvailable = MoneyAvailable + 0.05
    End Sub


    Private Sub ResetMoneyReturnTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetMoneyReturnTimer.Tick


        Call ResetComponents()

        ResetMoneyReturnTimer.Enabled = False


    End Sub

    Private Sub PerformTransaction(ByVal ItemName As PictureBox, ByVal ButtonName As Button, ByVal ItemPrice As Decimal, ByVal SoldOutLabel As Label)

        StatusTB.Text = "Processing, please wait..."

        ItemCost = ItemPrice


        'assign a random integer to Item Quantity
        ItemQuantity = GetRandomNumber(0, 5)




        If (ItemCost <= MoneyAvailable) Then
            ButtonName.Enabled = False



            MoneyAvailable -= ItemCost 'Reduce MoneyAvailable after purchase
            MoneyDepositTB.Text = MoneyAvailable.ToString("C")
            SendItemToGate(ItemName)


            ItemQuantity -= 1 'Reduce ItemQuantity after purchase



            'Check if stock is available for purchase
            If (ItemQuantity = 0) Then

                ButtonName.Enabled = False
                SoldOutLabel.Visible = True


            Else
                ButtonName.Enabled = True


            End If 'ITEM QUANTITY

            If MsgBox("Would you like to make another purchase?", MsgBoxStyle.YesNo, "Continue?") = MsgBoxResult.Yes Then
                StatusTB.Text = ""
                Exit Sub
            Else
                CalculateChange(MoneyAvailable)

                ResetMoneyReturnTimer.Enabled = True

            End If ' MSGBOX

        Else
            MsgBox("Please deposit more money to purchase this item.", MsgBoxStyle.Information, "Deposit Money")
            StatusTB.Text = ""

        End If 'ITEM COST
    End Sub


    Private Sub skittlesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skittlesBtn.Click


        Call PerformTransaction(Skittles, skittlesBtn, 0.55, SkittlesSoldOutLBL)
    End Sub

    Private Sub snickersBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snickersBtn.Click

        Call PerformTransaction(Snickers, snickersBtn, 0.95, SnickersSoldOutLBL)
    End Sub

    Private Sub MnM2Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnM2Btn.Click

        Call PerformTransaction(MnMYellow, MnM2Btn, 0.7, MnMYellowSoldOutLBL)
    End Sub

    Private Sub MnM1Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnM1Btn.Click

        Call PerformTransaction(MnMBrown, MnM1Btn, 0.7, MnMBrownSoldOutLBL)

    End Sub

    Private Sub HersBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HersBtn.Click

        Call PerformTransaction(Hershey, HersBtn, 0.85, HersheysSoldOutLBL)

    End Sub



    Private Sub FritosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FritosBtn.Click

        Call PerformTransaction(Fritos, FritosBtn, 0.5, FritosSoldOutLBL)

    End Sub

    Private Sub pringlesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pringlesBtn.Click

        Call PerformTransaction(Pringles, pringlesBtn, 1.25, PringlesSoldOutLBL)
    End Sub

    Private Sub CheezBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheezBtn.Click

        Call PerformTransaction(CheezIt, CheezBtn, 1.25, CheezItSoldOutLBL)

    End Sub

    Private Sub LaysBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaysBtn.Click


        Call PerformTransaction(Lays, LaysBtn, 0.5, LaysSoldOutLBL)

    End Sub

    Private Sub chipsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chipsBtn.Click

        Call PerformTransaction(Chips, chipsBtn, 0.5, ChipsSoldOutLBL)

    End Sub

    Private Sub evianBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evianBtn.Click


        Call PerformTransaction(Evian, evianBtn, 1.0, EvianSoldOutLBL)

    End Sub

    Private Sub mntdewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mntdewBtn.Click
        Call PerformTransaction(MountainDew, mntdewBtn, 1.0, MntDewSoldOutLBL)
    End Sub

    Private Sub SnappleBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnappleBtn.Click
        Call PerformTransaction(Snapple, SnappleBtn, 1.0, SnapplesSoldOutLBL)
    End Sub

    Private Sub pepsiBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pepsiBtn.Click
        Call PerformTransaction(Pepsi, pepsiBtn, 0.7, PepsiSoldOutLBL)

    End Sub

    Private Sub cokeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cokeBtn.Click
        Call PerformTransaction(Coke, cokeBtn, 1.0, CokeSoldOutLBL)
    End Sub







    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click

        MsgBox("Written by Anupam Pandeya", MsgBoxStyle.Information, "About")


    End Sub
End Class
