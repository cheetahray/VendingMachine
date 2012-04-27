

Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents ItemGateImg As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Hershey As System.Windows.Forms.PictureBox
    Friend WithEvents MnMBrown As System.Windows.Forms.PictureBox
    Friend WithEvents MnMYellow As System.Windows.Forms.PictureBox
    Friend WithEvents Snickers As System.Windows.Forms.PictureBox
    Friend WithEvents Skittles As System.Windows.Forms.PictureBox
    Friend WithEvents QuarterImg As System.Windows.Forms.PictureBox
    Friend WithEvents dimeImg As System.Windows.Forms.PictureBox
    Friend WithEvents NickelImg As System.Windows.Forms.PictureBox
    Friend WithEvents DollarBillImg As System.Windows.Forms.PictureBox
    Friend WithEvents DollarReturnImg As System.Windows.Forms.PictureBox
    Friend WithEvents QuarterReturnImg As System.Windows.Forms.PictureBox
    Friend WithEvents NickelReturnImg As System.Windows.Forms.PictureBox
    Friend WithEvents DimeReturnImg As System.Windows.Forms.PictureBox
    Friend WithEvents DollarReturnLBL As System.Windows.Forms.Label
    Friend WithEvents QuarterReturnLBL As System.Windows.Forms.Label
    Friend WithEvents DimeReturnLBL As System.Windows.Forms.Label
    Friend WithEvents NickelReturnLBL As System.Windows.Forms.Label
    Friend WithEvents ChangeReturnBTN As System.Windows.Forms.Button
    Friend WithEvents MoneyReturnTB As System.Windows.Forms.TextBox
    Friend WithEvents MoneyDepositTB As System.Windows.Forms.TextBox
    Friend WithEvents gateRightImg As System.Windows.Forms.PictureBox
    Friend WithEvents gateLeftImg As System.Windows.Forms.PictureBox
    Friend WithEvents skittlesBtn As System.Windows.Forms.Button
    Friend WithEvents snickersBtn As System.Windows.Forms.Button
    Friend WithEvents MnM2Btn As System.Windows.Forms.Button
    Friend WithEvents MnM1Btn As System.Windows.Forms.Button
    Friend WithEvents HersBtn As System.Windows.Forms.Button
    Friend WithEvents CheezitBtn As System.Windows.Forms.PictureBox
    Friend WithEvents chipsBtn As System.Windows.Forms.Button
    Friend WithEvents LaysBtn As System.Windows.Forms.Button
    Friend WithEvents pringlesBtn As System.Windows.Forms.Button
    Friend WithEvents FritosBtn As System.Windows.Forms.Button
    Friend WithEvents cokeBtn As System.Windows.Forms.Button
    Friend WithEvents SnappleBtn As System.Windows.Forms.Button
    Friend WithEvents pepsiBtn As System.Windows.Forms.Button
    Friend WithEvents mntdewBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusTB As System.Windows.Forms.RichTextBox
    Friend WithEvents evianBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Hershey = New System.Windows.Forms.PictureBox
        Me.MnMBrown = New System.Windows.Forms.PictureBox
        Me.MnMYellow = New System.Windows.Forms.PictureBox
        Me.Snickers = New System.Windows.Forms.PictureBox
        Me.Skittles = New System.Windows.Forms.PictureBox
        Me.skittlesBtn = New System.Windows.Forms.Button
        Me.snickersBtn = New System.Windows.Forms.Button
        Me.MnM2Btn = New System.Windows.Forms.Button
        Me.MnM1Btn = New System.Windows.Forms.Button
        Me.HersBtn = New System.Windows.Forms.Button
        Me.CheezitBtn = New System.Windows.Forms.PictureBox
        Me.chipsBtn = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.LaysBtn = New System.Windows.Forms.Button
        Me.pringlesBtn = New System.Windows.Forms.Button
        Me.FritosBtn = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.PictureBox10 = New System.Windows.Forms.PictureBox
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.cokeBtn = New System.Windows.Forms.Button
        Me.SnappleBtn = New System.Windows.Forms.Button
        Me.pepsiBtn = New System.Windows.Forms.Button
        Me.mntdewBtn = New System.Windows.Forms.Button
        Me.evianBtn = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.PictureBox13 = New System.Windows.Forms.PictureBox
        Me.PictureBox14 = New System.Windows.Forms.PictureBox
        Me.PictureBox15 = New System.Windows.Forms.PictureBox
        Me.PictureBox16 = New System.Windows.Forms.PictureBox
        Me.ItemGateImg = New System.Windows.Forms.PictureBox
        Me.gateRightImg = New System.Windows.Forms.PictureBox
        Me.gateLeftImg = New System.Windows.Forms.PictureBox
        Me.MoneyDepositTB = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.QuarterImg = New System.Windows.Forms.PictureBox
        Me.dimeImg = New System.Windows.Forms.PictureBox
        Me.NickelImg = New System.Windows.Forms.PictureBox
        Me.DollarBillImg = New System.Windows.Forms.PictureBox
        Me.ChangeReturnBTN = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.DollarReturnLBL = New System.Windows.Forms.Label
        Me.DimeReturnImg = New System.Windows.Forms.PictureBox
        Me.NickelReturnImg = New System.Windows.Forms.PictureBox
        Me.QuarterReturnImg = New System.Windows.Forms.PictureBox
        Me.DollarReturnImg = New System.Windows.Forms.PictureBox
        Me.QuarterReturnLBL = New System.Windows.Forms.Label
        Me.DimeReturnLBL = New System.Windows.Forms.Label
        Me.NickelReturnLBL = New System.Windows.Forms.Label
        Me.MoneyReturnTB = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.StatusTB = New System.Windows.Forms.RichTextBox
        Me.Panel1.SuspendLayout()
        CType(Me.Hershey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MnMBrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MnMYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Snickers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skittles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheezitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemGateImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gateRightImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gateLeftImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarterImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NickelImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DollarBillImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DimeReturnImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NickelReturnImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarterReturnImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DollarReturnImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(32, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 80)
        Me.Panel1.TabIndex = 1
        '
        'Hershey
        '
        Me.Hershey.Image = CType(resources.GetObject("Hershey.Image"), System.Drawing.Image)
        Me.Hershey.Location = New System.Drawing.Point(40, 8)
        Me.Hershey.Name = "Hershey"
        Me.Hershey.Size = New System.Drawing.Size(24, 64)
        Me.Hershey.TabIndex = 0
        Me.Hershey.TabStop = False
        '
        'MnMBrown
        '
        Me.MnMBrown.Image = CType(resources.GetObject("MnMBrown.Image"), System.Drawing.Image)
        Me.MnMBrown.Location = New System.Drawing.Point(104, 8)
        Me.MnMBrown.Name = "MnMBrown"
        Me.MnMBrown.Size = New System.Drawing.Size(32, 64)
        Me.MnMBrown.TabIndex = 2
        Me.MnMBrown.TabStop = False
        '
        'MnMYellow
        '
        Me.MnMYellow.Image = CType(resources.GetObject("MnMYellow.Image"), System.Drawing.Image)
        Me.MnMYellow.InitialImage = CType(resources.GetObject("MnMYellow.InitialImage"), System.Drawing.Image)
        Me.MnMYellow.Location = New System.Drawing.Point(168, 8)
        Me.MnMYellow.Name = "MnMYellow"
        Me.MnMYellow.Size = New System.Drawing.Size(32, 56)
        Me.MnMYellow.TabIndex = 2
        Me.MnMYellow.TabStop = False
        '
        'Snickers
        '
        Me.Snickers.Image = CType(resources.GetObject("Snickers.Image"), System.Drawing.Image)
        Me.Snickers.Location = New System.Drawing.Point(232, 8)
        Me.Snickers.Name = "Snickers"
        Me.Snickers.Size = New System.Drawing.Size(24, 64)
        Me.Snickers.TabIndex = 2
        Me.Snickers.TabStop = False
        '
        'Skittles
        '
        Me.Skittles.Image = CType(resources.GetObject("Skittles.Image"), System.Drawing.Image)
        Me.Skittles.Location = New System.Drawing.Point(304, 16)
        Me.Skittles.Name = "Skittles"
        Me.Skittles.Size = New System.Drawing.Size(24, 56)
        Me.Skittles.TabIndex = 2
        Me.Skittles.TabStop = False
        '
        'skittlesBtn
        '
        Me.skittlesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.skittlesBtn.Location = New System.Drawing.Point(328, 120)
        Me.skittlesBtn.Name = "skittlesBtn"
        Me.skittlesBtn.Size = New System.Drawing.Size(48, 32)
        Me.skittlesBtn.TabIndex = 2
        Me.skittlesBtn.Text = "0.55"
        '
        'snickersBtn
        '
        Me.snickersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.snickersBtn.Location = New System.Drawing.Point(256, 120)
        Me.snickersBtn.Name = "snickersBtn"
        Me.snickersBtn.Size = New System.Drawing.Size(48, 32)
        Me.snickersBtn.TabIndex = 3
        Me.snickersBtn.Text = "0.95"
        '
        'MnM2Btn
        '
        Me.MnM2Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MnM2Btn.Location = New System.Drawing.Point(192, 120)
        Me.MnM2Btn.Name = "MnM2Btn"
        Me.MnM2Btn.Size = New System.Drawing.Size(48, 32)
        Me.MnM2Btn.TabIndex = 4
        Me.MnM2Btn.Text = "0.70"
        '
        'MnM1Btn
        '
        Me.MnM1Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MnM1Btn.Location = New System.Drawing.Point(128, 120)
        Me.MnM1Btn.Name = "MnM1Btn"
        Me.MnM1Btn.Size = New System.Drawing.Size(48, 32)
        Me.MnM1Btn.TabIndex = 5
        Me.MnM1Btn.Text = "0.70"
        '
        'HersBtn
        '
        Me.HersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HersBtn.Location = New System.Drawing.Point(64, 120)
        Me.HersBtn.Name = "HersBtn"
        Me.HersBtn.Size = New System.Drawing.Size(48, 32)
        Me.HersBtn.TabIndex = 6
        Me.HersBtn.Text = "0.85"
        '
        'CheezitBtn
        '
        Me.CheezitBtn.BackColor = System.Drawing.Color.White
        Me.CheezitBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CheezitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheezitBtn.Image = CType(resources.GetObject("CheezitBtn.Image"), System.Drawing.Image)
        Me.CheezitBtn.Location = New System.Drawing.Point(16, 8)
        Me.CheezitBtn.Name = "CheezitBtn"
        Me.CheezitBtn.Size = New System.Drawing.Size(400, 584)
        Me.CheezitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CheezitBtn.TabIndex = 0
        Me.CheezitBtn.TabStop = False
        '
        'chipsBtn
        '
        Me.chipsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chipsBtn.Location = New System.Drawing.Point(64, 264)
        Me.chipsBtn.Name = "chipsBtn"
        Me.chipsBtn.Size = New System.Drawing.Size(48, 32)
        Me.chipsBtn.TabIndex = 12
        Me.chipsBtn.Text = "0.50"
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Location = New System.Drawing.Point(200, 264)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(48, 32)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "1.25"
        '
        'LaysBtn
        '
        Me.LaysBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaysBtn.Location = New System.Drawing.Point(136, 264)
        Me.LaysBtn.Name = "LaysBtn"
        Me.LaysBtn.Size = New System.Drawing.Size(48, 32)
        Me.LaysBtn.TabIndex = 11
        Me.LaysBtn.Text = "0.50"
        '
        'pringlesBtn
        '
        Me.pringlesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pringlesBtn.Location = New System.Drawing.Point(264, 264)
        Me.pringlesBtn.Name = "pringlesBtn"
        Me.pringlesBtn.Size = New System.Drawing.Size(48, 32)
        Me.pringlesBtn.TabIndex = 9
        Me.pringlesBtn.Text = "1.25"
        '
        'FritosBtn
        '
        Me.FritosBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FritosBtn.Location = New System.Drawing.Point(328, 264)
        Me.FritosBtn.Name = "FritosBtn"
        Me.FritosBtn.Size = New System.Drawing.Size(48, 32)
        Me.FritosBtn.TabIndex = 8
        Me.FritosBtn.Text = "0.50"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.PictureBox9)
        Me.Panel2.Controls.Add(Me.PictureBox10)
        Me.Panel2.Controls.Add(Me.PictureBox11)
        Me.Panel2.Location = New System.Drawing.Point(32, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 80)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(32, 8)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(48, 56)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(104, 8)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(40, 56)
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(168, 8)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(40, 56)
        Me.PictureBox9.TabIndex = 2
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(240, 8)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(24, 64)
        Me.PictureBox10.TabIndex = 2
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(296, 8)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(48, 56)
        Me.PictureBox11.TabIndex = 2
        Me.PictureBox11.TabStop = False
        '
        'cokeBtn
        '
        Me.cokeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cokeBtn.Location = New System.Drawing.Point(64, 408)
        Me.cokeBtn.Name = "cokeBtn"
        Me.cokeBtn.Size = New System.Drawing.Size(48, 32)
        Me.cokeBtn.TabIndex = 18
        Me.cokeBtn.Text = "1.00"
        '
        'SnappleBtn
        '
        Me.SnappleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SnappleBtn.Location = New System.Drawing.Point(192, 408)
        Me.SnappleBtn.Name = "SnappleBtn"
        Me.SnappleBtn.Size = New System.Drawing.Size(48, 32)
        Me.SnappleBtn.TabIndex = 16
        Me.SnappleBtn.Text = "1.00"
        '
        'pepsiBtn
        '
        Me.pepsiBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pepsiBtn.Location = New System.Drawing.Point(128, 408)
        Me.pepsiBtn.Name = "pepsiBtn"
        Me.pepsiBtn.Size = New System.Drawing.Size(48, 32)
        Me.pepsiBtn.TabIndex = 17
        Me.pepsiBtn.Text = "0.70"
        '
        'mntdewBtn
        '
        Me.mntdewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mntdewBtn.Location = New System.Drawing.Point(256, 408)
        Me.mntdewBtn.Name = "mntdewBtn"
        Me.mntdewBtn.Size = New System.Drawing.Size(48, 32)
        Me.mntdewBtn.TabIndex = 15
        Me.mntdewBtn.Text = "1.00"
        '
        'evianBtn
        '
        Me.evianBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.evianBtn.Location = New System.Drawing.Point(328, 408)
        Me.evianBtn.Name = "evianBtn"
        Me.evianBtn.Size = New System.Drawing.Size(48, 32)
        Me.evianBtn.TabIndex = 14
        Me.evianBtn.Text = "1.00"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.PictureBox12)
        Me.Panel3.Controls.Add(Me.PictureBox13)
        Me.Panel3.Controls.Add(Me.PictureBox14)
        Me.Panel3.Controls.Add(Me.PictureBox15)
        Me.Panel3.Controls.Add(Me.PictureBox16)
        Me.Panel3.Location = New System.Drawing.Point(32, 320)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(368, 80)
        Me.Panel3.TabIndex = 13
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(40, 0)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(40, 72)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 0
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(104, 0)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(40, 64)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 2
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(168, 0)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(40, 72)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 2
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(232, 0)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(32, 72)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 2
        Me.PictureBox15.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(304, 0)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(32, 72)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 2
        Me.PictureBox16.TabStop = False
        '
        'ItemGateImg
        '
        Me.ItemGateImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemGateImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemGateImg.Location = New System.Drawing.Point(184, 480)
        Me.ItemGateImg.Name = "ItemGateImg"
        Me.ItemGateImg.Size = New System.Drawing.Size(80, 72)
        Me.ItemGateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ItemGateImg.TabIndex = 21
        Me.ItemGateImg.TabStop = False
        '
        'gateRightImg
        '
        Me.gateRightImg.BackColor = System.Drawing.Color.Maroon
        Me.gateRightImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gateRightImg.Image = Global.TermProject2.My.Resources.Resources.orange_purple_glassa
        Me.gateRightImg.Location = New System.Drawing.Point(224, 465)
        Me.gateRightImg.Name = "gateRightImg"
        Me.gateRightImg.Size = New System.Drawing.Size(88, 104)
        Me.gateRightImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gateRightImg.TabIndex = 22
        Me.gateRightImg.TabStop = False
        '
        'gateLeftImg
        '
        Me.gateLeftImg.BackColor = System.Drawing.Color.Maroon
        Me.gateLeftImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gateLeftImg.Image = Global.TermProject2.My.Resources.Resources.orange_purple_glassa
        Me.gateLeftImg.Location = New System.Drawing.Point(136, 465)
        Me.gateLeftImg.Name = "gateLeftImg"
        Me.gateLeftImg.Size = New System.Drawing.Size(88, 104)
        Me.gateLeftImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gateLeftImg.TabIndex = 23
        Me.gateLeftImg.TabStop = False
        '
        'MoneyDepositTB
        '
        Me.MoneyDepositTB.BackColor = System.Drawing.Color.Silver
        Me.MoneyDepositTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyDepositTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MoneyDepositTB.Location = New System.Drawing.Point(602, 8)
        Me.MoneyDepositTB.Name = "MoneyDepositTB"
        Me.MoneyDepositTB.ReadOnly = True
        Me.MoneyDepositTB.Size = New System.Drawing.Size(150, 26)
        Me.MoneyDepositTB.TabIndex = 24
        Me.MoneyDepositTB.Text = "MoneyDepositTB"
        Me.MoneyDepositTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(472, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Click on money to deposit in machine"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuarterImg
        '
        Me.QuarterImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuarterImg.Image = CType(resources.GetObject("QuarterImg.Image"), System.Drawing.Image)
        Me.QuarterImg.Location = New System.Drawing.Point(456, 88)
        Me.QuarterImg.Name = "QuarterImg"
        Me.QuarterImg.Size = New System.Drawing.Size(89, 85)
        Me.QuarterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuarterImg.TabIndex = 26
        Me.QuarterImg.TabStop = False
        '
        'dimeImg
        '
        Me.dimeImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dimeImg.Image = CType(resources.GetObject("dimeImg.Image"), System.Drawing.Image)
        Me.dimeImg.Location = New System.Drawing.Point(592, 116)
        Me.dimeImg.Name = "dimeImg"
        Me.dimeImg.Size = New System.Drawing.Size(58, 55)
        Me.dimeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dimeImg.TabIndex = 27
        Me.dimeImg.TabStop = False
        '
        'NickelImg
        '
        Me.NickelImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NickelImg.Image = CType(resources.GetObject("NickelImg.Image"), System.Drawing.Image)
        Me.NickelImg.Location = New System.Drawing.Point(704, 102)
        Me.NickelImg.Name = "NickelImg"
        Me.NickelImg.Size = New System.Drawing.Size(77, 69)
        Me.NickelImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NickelImg.TabIndex = 28
        Me.NickelImg.TabStop = False
        '
        'DollarBillImg
        '
        Me.DollarBillImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DollarBillImg.Image = CType(resources.GetObject("DollarBillImg.Image"), System.Drawing.Image)
        Me.DollarBillImg.Location = New System.Drawing.Point(545, 190)
        Me.DollarBillImg.Name = "DollarBillImg"
        Me.DollarBillImg.Size = New System.Drawing.Size(172, 81)
        Me.DollarBillImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DollarBillImg.TabIndex = 29
        Me.DollarBillImg.TabStop = False
        '
        'ChangeReturnBTN
        '
        Me.ChangeReturnBTN.BackColor = System.Drawing.Color.Silver
        Me.ChangeReturnBTN.Location = New System.Drawing.Point(448, 368)
        Me.ChangeReturnBTN.Name = "ChangeReturnBTN"
        Me.ChangeReturnBTN.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.ChangeReturnBTN.Size = New System.Drawing.Size(128, 56)
        Me.ChangeReturnBTN.TabIndex = 30
        Me.ChangeReturnBTN.Text = "&Return Change"
        Me.ChangeReturnBTN.UseVisualStyleBackColor = False
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
        Me.Panel4.Location = New System.Drawing.Point(448, 448)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(360, 136)
        Me.Panel4.TabIndex = 31
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
        Me.DollarReturnImg.Location = New System.Drawing.Point(16, 8)
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
        'MoneyReturnTB
        '
        Me.MoneyReturnTB.BackColor = System.Drawing.Color.Maroon
        Me.MoneyReturnTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyReturnTB.ForeColor = System.Drawing.Color.Silver
        Me.MoneyReturnTB.Location = New System.Drawing.Point(704, 424)
        Me.MoneyReturnTB.Name = "MoneyReturnTB"
        Me.MoneyReturnTB.ReadOnly = True
        Me.MoneyReturnTB.Size = New System.Drawing.Size(104, 22)
        Me.MoneyReturnTB.TabIndex = 32
        Me.MoneyReturnTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(504, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Amount Available:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(611, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Money Returned:"
        '
        'StatusTB
        '
        Me.StatusTB.BackColor = System.Drawing.Color.White
        Me.StatusTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StatusTB.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusTB.Location = New System.Drawing.Point(472, 277)
        Me.StatusTB.Name = "StatusTB"
        Me.StatusTB.ReadOnly = True
        Me.StatusTB.Size = New System.Drawing.Size(312, 71)
        Me.StatusTB.TabIndex = 35
        Me.StatusTB.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 606)
        Me.Controls.Add(Me.StatusTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MoneyReturnTB)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.ChangeReturnBTN)
        Me.Controls.Add(Me.DollarBillImg)
        Me.Controls.Add(Me.NickelImg)
        Me.Controls.Add(Me.dimeImg)
        Me.Controls.Add(Me.QuarterImg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MoneyDepositTB)
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
        Me.Controls.Add(Me.Button7)
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
        Me.Controls.Add(Me.CheezitBtn)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Vending Machine"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Hershey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MnMBrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MnMYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Snickers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skittles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheezitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemGateImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gateRightImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gateLeftImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarterImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimeImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NickelImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DollarBillImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DimeReturnImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NickelReturnImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarterReturnImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DollarReturnImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Global Variables
    Dim MoneyAvailable As Decimal = 0.0
    Dim ItemCost As Decimal = 0.0




    'start mouse over behavior


    '''''''''''''''''''''''''''Dollar '''''''''''''''''''''''
    Private Sub DollarBillImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DollarBillImg.MouseEnter

        DollarBillImg.Location = New Point(DollarBillImg.Location.X + 2, DollarBillImg.Location.Y + 2)
    End Sub


    Private Sub DollarBillImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DollarBillImg.MouseLeave


        DollarBillImg.Location = New Point(DollarBillImg.Location.X - 2, DollarBillImg.Location.Y - 2)
    End Sub
    '''''''''''''''''''''''''''Quarter '''''''''''''''''''''''
    Private Sub QuarterImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuarterImg.MouseEnter


        QuarterImg.Location = New Point(QuarterImg.Location.X + 2, QuarterImg.Location.Y + 2)
    End Sub


    Private Sub QuarterImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuarterImg.MouseLeave

        QuarterImg.Location = New Point(QuarterImg.Location.X - 2, QuarterImg.Location.Y - 2)
    End Sub

    '''''''''''''''''''''''''''Dime '''''''''''''''''''''''

    Private Sub dimeImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dimeImg.MouseEnter
        dimeImg.Location = New Point(dimeImg.Location.X + 2, dimeImg.Location.Y + 2)
    End Sub

    Private Sub dimeImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dimeImg.MouseLeave
        dimeImg.Location = New Point(dimeImg.Location.X - 2, dimeImg.Location.Y - 2)
    End Sub

    '''''''''''''''''''''''''''Nickel '''''''''''''''''''''''
    Private Sub NickelImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles NickelImg.MouseEnter
        NickelImg.Location = New Point(NickelImg.Location.X + 2, NickelImg.Location.Y + 2)
    End Sub

    Private Sub NickelImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NickelImg.MouseLeave
        NickelImg.Location = New Point(NickelImg.Location.X - 2, NickelImg.Location.Y - 2)
    End Sub

    'end mouse over behavior


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'set 'Money Return' images visibility = false
        DollarReturnImg.Visible = False
        NickelReturnImg.Visible = False
        DimeReturnImg.Visible = False
        QuarterReturnImg.Visible = False


    End Sub

    Private Sub ChangeReturnBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeReturnBTN.Click
        If (MoneyAvailable > 0) Then

            CalculateChange(MoneyAvailable)


        Else
            MsgBox("You do not have any deposited money to return", MsgBoxStyle.Exclamation, "Zero Balance")


        End If





    End Sub


    'Skittles
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skittlesBtn.Click
        ItemCost = 0.55

        If (ItemCost <= MoneyAvailable) Then
            skittlesBtn.Enabled = False



            MoneyAvailable -= ItemCost
            MoneyDepositTB.Text = MoneyAvailable.ToString("C")
            SendItemToGate(Skittles)

            skittlesBtn.Enabled = True

        Else
            MsgBox("Please deposit more money to purchase this item.", MsgBoxStyle.Information, "Deposit Money")

        End If



    End Sub

    Private Sub DollarBillImg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DollarBillImg.Click

        Dim i As Integer
        Dim TempMoneyCount As Decimal

        For i = 1 To 100 Step 3
            TempMoneyCount = i / 100 + MoneyAvailable
            Me.Refresh()

            MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        Next

        MoneyAvailable = MoneyAvailable + 1.0

    End Sub

    Private Sub NickelImg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NickelImg.Click
        Dim i As Integer
        Dim TempMoneyCount As Decimal

        For i = 1 To 5
            TempMoneyCount = i / 100 + MoneyAvailable
            Me.Refresh()

            MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        Next

        MoneyAvailable = MoneyAvailable + 0.05
    End Sub

    Private Sub dimeImg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dimeImg.Click
        Dim i As Integer
        Dim TempMoneyCount As Decimal

        For i = 1 To 10
            TempMoneyCount = i / 100 + MoneyAvailable
            Me.Refresh()

            MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        Next

        MoneyAvailable = MoneyAvailable + 0.1
    End Sub

    Private Sub QuarterImg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuarterImg.Click
        Dim i As Integer
        Dim TempMoneyCount As Decimal

        For i = 1 To 25 Step 3
            TempMoneyCount = i / 100 + MoneyAvailable
            Me.Refresh()

            MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        Next

        MoneyAvailable = MoneyAvailable + 0.25
    End Sub

    'evian
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evianBtn.Click

        Call OpenGate()


    End Sub

    Private Sub OpenGate()
        StatusTB.Text = "Please remove your item..."
        Dim i As System.Drawing.Point

        Dim ixLeftGate, ixRightGate, r As Integer

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
            System.Threading.Thread.Sleep(10)            '   sleep for .1 a second

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


            System.Threading.Thread.Sleep(10)            '   sleep for .1 a second

        Next
    End Sub

    Private Sub snickersBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snickersBtn.Click
        ItemCost = 0.95


        If (ItemCost <= MoneyAvailable) Then
            snickersBtn.Enabled = False



            MoneyAvailable -= ItemCost
            MoneyDepositTB.Text = MoneyAvailable.ToString("C")
            SendItemToGate(Snickers)

            snickersBtn.Enabled = True

        Else
            MsgBox("Please deposit more money to purchase this item.", MsgBoxStyle.Information, "Deposit Money")

        End If
    End Sub

    Private Sub SendItemToGate(ByVal ItemName As PictureBox)
        Dim i As System.Drawing.Point
        Dim iy As Integer


        i = ItemName.Location()
        iy = ItemName.Location.Y
        Dim r As Integer
        For r = 1 To 50
            iy = ItemName.Location.Y
            iy = iy + 10
            ItemName.Location() = New Point(ItemName.Location.X, iy)
            Me.Refresh()
            System.Threading.Thread.Sleep(10)            '   sleep for .1 a second

        Next

        ItemGateImg.Image = ItemName.Image
        Call OpenGate()

    End Sub

    Private Sub MnM2Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnM2Btn.Click
        MnM2Btn.Enabled = False

        ItemCost = 0.7

        MoneyAvailable -= ItemCost
        MoneyDepositTB.Text = MoneyAvailable.ToString("C")
        SendItemToGate(MnMYellow)
        MnM2Btn.Enabled = True



    End Sub

    Private Sub checkDepositAmount()
        If (ItemCost > MoneyAvailable) Then
            MsgBox("Please deposit more money to purchase this item.", MsgBoxStyle.Information, "Deposit Money")

        End If
    End Sub

    Private Sub CalculateChange(ByVal AvailableMoney As Decimal)
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
            ' System.Threading.Thread.Sleep(100)
            ' DollarReturnImg.Visible = False
            ' DollarReturnLBL.Text = ""

        End If

        If (quaterCounter >= 1) Then
            QuarterReturnImg.Visible = True
            QuarterReturnLBL.Text = "x " & quaterCounter
            ' System.Threading.Thread.Sleep(100)
            ' QuarterReturnImg.Visible = False
            ' QuarterReturnLBL.Text = ""
        End If

        If (dimeCounter >= 1) Then
            DimeReturnImg.Visible = True
            DimeReturnLBL.Text = "x " & dimeCounter
            '  System.Threading.Thread.Sleep(100)
            '  DimeReturnImg.Visible = False
            ' DimeReturnLBL.Text = ""
        End If

        If (nickleCounter >= 1) Then
            NickelReturnImg.Visible = True
            NickelReturnLBL.Text = "x " & nickleCounter
            ' System.Threading.Thread.Sleep(100)
            ' NickelReturnImg.Visible = False
            ' NickelReturnLBL.Text = ""


        End If
        StatusTB.Text = "Please remove your change..."

        MoneyReturnTB.Text = MoneyAvailable.ToString("C")
        MoneyDepositTB.Text = ""

        MoneyAvailable = 0.0







    End Sub


    Private Sub MnM1Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnM1Btn.Click
        ItemCost = 0.7


        If (ItemCost <= MoneyAvailable) Then
            MnM1Btn.Enabled = False



            MoneyAvailable -= ItemCost
            MoneyDepositTB.Text = MoneyAvailable.ToString("C")
            SendItemToGate(MnMBrown)

            MnM1Btn.Enabled = True

            If MsgBox("Would you like to make another purchase?", MsgBoxStyle.YesNo, "Continue?") = MsgBoxResult.Yes Then
                Call ResetComponents()
                Exit Sub
            Else
                CalculateChange(MoneyAvailable)
            End If

        Else
            MsgBox("Please deposit more money to purchase this item.", MsgBoxStyle.Information, "Deposit Money")

        End If
    End Sub

    Private Sub HersBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HersBtn.Click
        ItemCost = 0.85


        If (ItemCost <= MoneyAvailable) Then

            StatusTB.Text = "Processing, Please Wait..."
            HersBtn.Enabled = False



            MoneyAvailable -= ItemCost
            MoneyDepositTB.Text = MoneyAvailable.ToString("C")
            SendItemToGate(Hershey)

            HersBtn.Enabled = True

            If MsgBox("Would you like to make another purchase?", MsgBoxStyle.YesNo, "Continue?") = MsgBoxResult.Yes Then
                Call ResetComponents()
                Exit Sub
            Else
                CalculateChange(MoneyAvailable)
            End If

        Else
            MsgBox("Please deposit more money to purchase this item.", MsgBoxStyle.Information, "Deposit Money")

        End If
    End Sub



    Private Sub ResetComponents()
        DollarReturnImg.Visible = False
        NickelReturnImg.Visible = False
        DimeReturnImg.Visible = False
        QuarterReturnImg.Visible = False

        MoneyAvailable = 0.0
        ItemCost = 0.0

        StatusTB.Text = ""
        DollarReturnLBL.Text = ""
        QuarterReturnLBL.Text = ""
        DimeReturnLBL.Text = ""
        NickelReturnLBL.Text = ""


    End Sub





End Class
