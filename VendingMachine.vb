'Term Project 2
'Anupam Pandeya 07/23/06
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class VendingMachine
    Inherits System.Windows.Forms.Form
    'Global Variables
    Dim ProductNum As Integer = 0 '商品編號
    Private comOpen As Boolean 'comPort
    Dim MoneyAvailable As Decimal = 0 ' Money deposited by user 
    Dim ItemCost As Decimal = 0.0       'Cost of the item
    Dim ItemQuantity As Integer = 0
    Dim ReceiveBytes, SendBytes As String
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker     'Quantity of Items available
    Friend WithEvents Index6 As System.Windows.Forms.Label
    Friend WithEvents Pic_5 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_3 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_7 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_10 As System.Windows.Forms.PictureBox
    Friend WithEvents Price1 As System.Windows.Forms.Label
    Friend WithEvents Index1 As System.Windows.Forms.Label
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Price2 As System.Windows.Forms.Label
    Friend WithEvents Index2 As System.Windows.Forms.Label
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Price3 As System.Windows.Forms.Label
    Friend WithEvents Index3 As System.Windows.Forms.Label
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Price4 As System.Windows.Forms.Label
    Friend WithEvents Index4 As System.Windows.Forms.Label
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents Price5 As System.Windows.Forms.Label
    Friend WithEvents Index5 As System.Windows.Forms.Label
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents Price6 As System.Windows.Forms.Label
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents Price7 As System.Windows.Forms.Label
    Friend WithEvents Index7 As System.Windows.Forms.Label
    Friend WithEvents Btn7 As System.Windows.Forms.Button
    Friend WithEvents Price8 As System.Windows.Forms.Label
    Friend WithEvents Index8 As System.Windows.Forms.Label
    Friend WithEvents Btn8 As System.Windows.Forms.Button
    Friend WithEvents Price9 As System.Windows.Forms.Label
    Friend WithEvents Index9 As System.Windows.Forms.Label
    Friend WithEvents Btn9 As System.Windows.Forms.Button
    Friend WithEvents Price10 As System.Windows.Forms.Label
    Friend WithEvents Index10 As System.Windows.Forms.Label
    Friend WithEvents Btn10 As System.Windows.Forms.Button
    Friend WithEvents QuarterImg As System.Windows.Forms.PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents picOpen As System.Windows.Forms.PictureBox
    Friend WithEvents cboComPort As System.Windows.Forms.ComboBox
    Friend WithEvents UdpTimer As System.Windows.Forms.Timer
    'Quantity of Items available
    Dim objRandom As New System.Random( _
   CType(System.DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer))

    Private Class CSState
        Public RemoteIpEndPoint As IPEndPoint
        Public myUDPClient As UdpClient
    End Class

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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Pic_2 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_9 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_6 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_8 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pic_1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_4 As System.Windows.Forms.PictureBox
    Friend WithEvents MoneyReturnTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dimeImg As System.Windows.Forms.PictureBox
    Friend WithEvents DollarBillImg As System.Windows.Forms.PictureBox
    Friend WithEvents NickelImg As System.Windows.Forms.PictureBox
    Friend WithEvents MoneyDepositTB As System.Windows.Forms.TextBox
    Friend WithEvents ChangeReturnBTN As System.Windows.Forms.Button
    Friend WithEvents VendingMachineIMG As System.Windows.Forms.PictureBox
    Friend WithEvents ResetMoneyReturnTimer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendingMachine))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Price10 = New System.Windows.Forms.Label()
        Me.Price9 = New System.Windows.Forms.Label()
        Me.Price8 = New System.Windows.Forms.Label()
        Me.Price7 = New System.Windows.Forms.Label()
        Me.Price6 = New System.Windows.Forms.Label()
        Me.Pic_10 = New System.Windows.Forms.PictureBox()
        Me.Pic_6 = New System.Windows.Forms.PictureBox()
        Me.Pic_7 = New System.Windows.Forms.PictureBox()
        Me.Pic_8 = New System.Windows.Forms.PictureBox()
        Me.Pic_9 = New System.Windows.Forms.PictureBox()
        Me.Pic_2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Price5 = New System.Windows.Forms.Label()
        Me.Price4 = New System.Windows.Forms.Label()
        Me.Pic_5 = New System.Windows.Forms.PictureBox()
        Me.Price3 = New System.Windows.Forms.Label()
        Me.Price2 = New System.Windows.Forms.Label()
        Me.Price1 = New System.Windows.Forms.Label()
        Me.Pic_3 = New System.Windows.Forms.PictureBox()
        Me.Pic_1 = New System.Windows.Forms.PictureBox()
        Me.Pic_4 = New System.Windows.Forms.PictureBox()
        Me.VendingMachineIMG = New System.Windows.Forms.PictureBox()
        Me.MoneyReturnTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dimeImg = New System.Windows.Forms.PictureBox()
        Me.DollarBillImg = New System.Windows.Forms.PictureBox()
        Me.NickelImg = New System.Windows.Forms.PictureBox()
        Me.MoneyDepositTB = New System.Windows.Forms.TextBox()
        Me.ChangeReturnBTN = New System.Windows.Forms.Button()
        Me.ResetMoneyReturnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Index6 = New System.Windows.Forms.Label()
        Me.Index1 = New System.Windows.Forms.Label()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Index2 = New System.Windows.Forms.Label()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Index3 = New System.Windows.Forms.Label()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Index4 = New System.Windows.Forms.Label()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Index5 = New System.Windows.Forms.Label()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Index7 = New System.Windows.Forms.Label()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Index8 = New System.Windows.Forms.Label()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Index9 = New System.Windows.Forms.Label()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Index10 = New System.Windows.Forms.Label()
        Me.Btn10 = New System.Windows.Forms.Button()
        Me.QuarterImg = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.picOpen = New System.Windows.Forms.PictureBox()
        Me.cboComPort = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.UdpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.Pic_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Pic_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendingMachineIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DollarBillImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NickelImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarterImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Price10)
        Me.Panel2.Controls.Add(Me.Price9)
        Me.Panel2.Controls.Add(Me.Price8)
        Me.Panel2.Controls.Add(Me.Price7)
        Me.Panel2.Controls.Add(Me.Price6)
        Me.Panel2.Controls.Add(Me.Pic_10)
        Me.Panel2.Controls.Add(Me.Pic_6)
        Me.Panel2.Controls.Add(Me.Pic_7)
        Me.Panel2.Controls.Add(Me.Pic_8)
        Me.Panel2.Controls.Add(Me.Pic_9)
        Me.Panel2.Location = New System.Drawing.Point(30, 347)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 208)
        Me.Panel2.TabIndex = 31
        '
        'Price10
        '
        Me.Price10.AutoSize = True
        Me.Price10.BackColor = System.Drawing.Color.White
        Me.Price10.Location = New System.Drawing.Point(718, 150)
        Me.Price10.Name = "Price10"
        Me.Price10.Size = New System.Drawing.Size(32, 17)
        Me.Price10.TabIndex = 93
        Me.Price10.Text = "150"
        '
        'Price9
        '
        Me.Price9.AutoSize = True
        Me.Price9.BackColor = System.Drawing.Color.White
        Me.Price9.Location = New System.Drawing.Point(562, 150)
        Me.Price9.Name = "Price9"
        Me.Price9.Size = New System.Drawing.Size(24, 17)
        Me.Price9.TabIndex = 92
        Me.Price9.Text = "50"
        '
        'Price8
        '
        Me.Price8.AutoSize = True
        Me.Price8.BackColor = System.Drawing.Color.White
        Me.Price8.Location = New System.Drawing.Point(374, 150)
        Me.Price8.Name = "Price8"
        Me.Price8.Size = New System.Drawing.Size(32, 17)
        Me.Price8.TabIndex = 91
        Me.Price8.Text = "200"
        '
        'Price7
        '
        Me.Price7.AutoSize = True
        Me.Price7.BackColor = System.Drawing.Color.White
        Me.Price7.Location = New System.Drawing.Point(210, 153)
        Me.Price7.Name = "Price7"
        Me.Price7.Size = New System.Drawing.Size(24, 17)
        Me.Price7.TabIndex = 91
        Me.Price7.Text = "50"
        '
        'Price6
        '
        Me.Price6.AutoSize = True
        Me.Price6.BackColor = System.Drawing.Color.White
        Me.Price6.Location = New System.Drawing.Point(32, 153)
        Me.Price6.Name = "Price6"
        Me.Price6.Size = New System.Drawing.Size(32, 17)
        Me.Price6.TabIndex = 91
        Me.Price6.Text = "100"
        '
        'Pic_10
        '
        Me.Pic_10.Image = CType(resources.GetObject("Pic_10.Image"), System.Drawing.Image)
        Me.Pic_10.Location = New System.Drawing.Point(706, 36)
        Me.Pic_10.Name = "Pic_10"
        Me.Pic_10.Size = New System.Drawing.Size(48, 74)
        Me.Pic_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_10.TabIndex = 2
        Me.Pic_10.TabStop = False
        '
        'Pic_6
        '
        Me.Pic_6.Image = CType(resources.GetObject("Pic_6.Image"), System.Drawing.Image)
        Me.Pic_6.Location = New System.Drawing.Point(26, 45)
        Me.Pic_6.Name = "Pic_6"
        Me.Pic_6.Size = New System.Drawing.Size(48, 65)
        Me.Pic_6.TabIndex = 2
        Me.Pic_6.TabStop = False
        '
        'Pic_7
        '
        Me.Pic_7.Image = CType(resources.GetObject("Pic_7.Image"), System.Drawing.Image)
        Me.Pic_7.Location = New System.Drawing.Point(199, 27)
        Me.Pic_7.Name = "Pic_7"
        Me.Pic_7.Size = New System.Drawing.Size(48, 83)
        Me.Pic_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_7.TabIndex = 0
        Me.Pic_7.TabStop = False
        '
        'Pic_8
        '
        Me.Pic_8.Image = CType(resources.GetObject("Pic_8.Image"), System.Drawing.Image)
        Me.Pic_8.Location = New System.Drawing.Point(378, 36)
        Me.Pic_8.Name = "Pic_8"
        Me.Pic_8.Size = New System.Drawing.Size(29, 74)
        Me.Pic_8.TabIndex = 2
        Me.Pic_8.TabStop = False
        '
        'Pic_9
        '
        Me.Pic_9.Image = CType(resources.GetObject("Pic_9.Image"), System.Drawing.Image)
        Me.Pic_9.Location = New System.Drawing.Point(546, 36)
        Me.Pic_9.Name = "Pic_9"
        Me.Pic_9.Size = New System.Drawing.Size(48, 64)
        Me.Pic_9.TabIndex = 2
        Me.Pic_9.TabStop = False
        '
        'Pic_2
        '
        Me.Pic_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pic_2.Image = CType(resources.GetObject("Pic_2.Image"), System.Drawing.Image)
        Me.Pic_2.Location = New System.Drawing.Point(202, 43)
        Me.Pic_2.Name = "Pic_2"
        Me.Pic_2.Size = New System.Drawing.Size(57, 64)
        Me.Pic_2.TabIndex = 0
        Me.Pic_2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Price5)
        Me.Panel1.Controls.Add(Me.Price4)
        Me.Panel1.Controls.Add(Me.Pic_5)
        Me.Panel1.Controls.Add(Me.Price3)
        Me.Panel1.Controls.Add(Me.Price2)
        Me.Panel1.Controls.Add(Me.Price1)
        Me.Panel1.Controls.Add(Me.Pic_3)
        Me.Panel1.Controls.Add(Me.Pic_1)
        Me.Panel1.Controls.Add(Me.Pic_2)
        Me.Panel1.Controls.Add(Me.Pic_4)
        Me.Panel1.Location = New System.Drawing.Point(31, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 208)
        Me.Panel1.TabIndex = 25
        '
        'Price5
        '
        Me.Price5.AutoSize = True
        Me.Price5.BackColor = System.Drawing.Color.White
        Me.Price5.Location = New System.Drawing.Point(719, 145)
        Me.Price5.Name = "Price5"
        Me.Price5.Size = New System.Drawing.Size(32, 17)
        Me.Price5.TabIndex = 90
        Me.Price5.Text = "200"
        '
        'Price4
        '
        Me.Price4.AutoSize = True
        Me.Price4.BackColor = System.Drawing.Color.White
        Me.Price4.Location = New System.Drawing.Point(563, 145)
        Me.Price4.Name = "Price4"
        Me.Price4.Size = New System.Drawing.Size(24, 17)
        Me.Price4.TabIndex = 89
        Me.Price4.Text = "50"
        '
        'Pic_5
        '
        Me.Pic_5.Image = CType(resources.GetObject("Pic_5.Image"), System.Drawing.Image)
        Me.Pic_5.Location = New System.Drawing.Point(712, 30)
        Me.Pic_5.Name = "Pic_5"
        Me.Pic_5.Size = New System.Drawing.Size(38, 83)
        Me.Pic_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_5.TabIndex = 2
        Me.Pic_5.TabStop = False
        '
        'Price3
        '
        Me.Price3.AutoSize = True
        Me.Price3.BackColor = System.Drawing.Color.White
        Me.Price3.Location = New System.Drawing.Point(388, 145)
        Me.Price3.Name = "Price3"
        Me.Price3.Size = New System.Drawing.Size(32, 17)
        Me.Price3.TabIndex = 88
        Me.Price3.Text = "100"
        '
        'Price2
        '
        Me.Price2.AutoSize = True
        Me.Price2.BackColor = System.Drawing.Color.White
        Me.Price2.Location = New System.Drawing.Point(218, 145)
        Me.Price2.Name = "Price2"
        Me.Price2.Size = New System.Drawing.Size(32, 17)
        Me.Price2.TabIndex = 87
        Me.Price2.Text = "100"
        '
        'Price1
        '
        Me.Price1.AutoSize = True
        Me.Price1.BackColor = System.Drawing.Color.White
        Me.Price1.Location = New System.Drawing.Point(48, 147)
        Me.Price1.Name = "Price1"
        Me.Price1.Size = New System.Drawing.Size(24, 17)
        Me.Price1.TabIndex = 86
        Me.Price1.Text = "50"
        '
        'Pic_3
        '
        Me.Pic_3.Image = CType(resources.GetObject("Pic_3.Image"), System.Drawing.Image)
        Me.Pic_3.Location = New System.Drawing.Point(379, 30)
        Me.Pic_3.Name = "Pic_3"
        Me.Pic_3.Size = New System.Drawing.Size(48, 83)
        Me.Pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_3.TabIndex = 2
        Me.Pic_3.TabStop = False
        '
        'Pic_1
        '
        Me.Pic_1.Image = CType(resources.GetObject("Pic_1.Image"), System.Drawing.Image)
        Me.Pic_1.Location = New System.Drawing.Point(37, 39)
        Me.Pic_1.Name = "Pic_1"
        Me.Pic_1.Size = New System.Drawing.Size(39, 74)
        Me.Pic_1.TabIndex = 2
        Me.Pic_1.TabStop = False
        '
        'Pic_4
        '
        Me.Pic_4.Image = CType(resources.GetObject("Pic_4.Image"), System.Drawing.Image)
        Me.Pic_4.Location = New System.Drawing.Point(566, 30)
        Me.Pic_4.Name = "Pic_4"
        Me.Pic_4.Size = New System.Drawing.Size(29, 65)
        Me.Pic_4.TabIndex = 2
        Me.Pic_4.TabStop = False
        '
        'VendingMachineIMG
        '
        Me.VendingMachineIMG.BackColor = System.Drawing.Color.AliceBlue
        Me.VendingMachineIMG.Cursor = System.Windows.Forms.Cursors.Help
        Me.VendingMachineIMG.Image = CType(resources.GetObject("VendingMachineIMG.Image"), System.Drawing.Image)
        Me.VendingMachineIMG.Location = New System.Drawing.Point(-11, -27)
        Me.VendingMachineIMG.Margin = New System.Windows.Forms.Padding(0)
        Me.VendingMachineIMG.Name = "VendingMachineIMG"
        Me.VendingMachineIMG.Size = New System.Drawing.Size(960, 704)
        Me.VendingMachineIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VendingMachineIMG.TabIndex = 24
        Me.VendingMachineIMG.TabStop = False
        '
        'MoneyReturnTB
        '
        Me.MoneyReturnTB.BackColor = System.Drawing.Color.Maroon
        Me.MoneyReturnTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyReturnTB.ForeColor = System.Drawing.Color.Silver
        Me.MoneyReturnTB.Location = New System.Drawing.Point(971, 392)
        Me.MoneyReturnTB.Name = "MoneyReturnTB"
        Me.MoneyReturnTB.ReadOnly = True
        Me.MoneyReturnTB.Size = New System.Drawing.Size(125, 26)
        Me.MoneyReturnTB.TabIndex = 47
        Me.MoneyReturnTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(967, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Money Returned:"
        '
        'dimeImg
        '
        Me.dimeImg.BackColor = System.Drawing.Color.White
        Me.dimeImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dimeImg.Image = CType(resources.GetObject("dimeImg.Image"), System.Drawing.Image)
        Me.dimeImg.Location = New System.Drawing.Point(1151, 500)
        Me.dimeImg.Name = "dimeImg"
        Me.dimeImg.Size = New System.Drawing.Size(57, 55)
        Me.dimeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dimeImg.TabIndex = 54
        Me.dimeImg.TabStop = False
        Me.dimeImg.Visible = False
        '
        'DollarBillImg
        '
        Me.DollarBillImg.BackColor = System.Drawing.Color.White
        Me.DollarBillImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DollarBillImg.Image = CType(resources.GetObject("DollarBillImg.Image"), System.Drawing.Image)
        Me.DollarBillImg.Location = New System.Drawing.Point(971, 194)
        Me.DollarBillImg.Name = "DollarBillImg"
        Me.DollarBillImg.Size = New System.Drawing.Size(237, 94)
        Me.DollarBillImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DollarBillImg.TabIndex = 56
        Me.DollarBillImg.TabStop = False
        '
        'NickelImg
        '
        Me.NickelImg.BackColor = System.Drawing.Color.White
        Me.NickelImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NickelImg.Image = CType(resources.GetObject("NickelImg.Image"), System.Drawing.Image)
        Me.NickelImg.Location = New System.Drawing.Point(1073, 481)
        Me.NickelImg.Name = "NickelImg"
        Me.NickelImg.Size = New System.Drawing.Size(77, 74)
        Me.NickelImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NickelImg.TabIndex = 55
        Me.NickelImg.TabStop = False
        Me.NickelImg.Visible = False
        '
        'MoneyDepositTB
        '
        Me.MoneyDepositTB.BackColor = System.Drawing.Color.Silver
        Me.MoneyDepositTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyDepositTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MoneyDepositTB.Location = New System.Drawing.Point(857, 591)
        Me.MoneyDepositTB.Name = "MoneyDepositTB"
        Me.MoneyDepositTB.ReadOnly = True
        Me.MoneyDepositTB.Size = New System.Drawing.Size(81, 30)
        Me.MoneyDepositTB.TabIndex = 50
        Me.MoneyDepositTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChangeReturnBTN
        '
        Me.ChangeReturnBTN.BackColor = System.Drawing.Color.Silver
        Me.ChangeReturnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangeReturnBTN.Location = New System.Drawing.Point(857, 629)
        Me.ChangeReturnBTN.Name = "ChangeReturnBTN"
        Me.ChangeReturnBTN.Size = New System.Drawing.Size(84, 40)
        Me.ChangeReturnBTN.TabIndex = 58
        Me.ChangeReturnBTN.Text = "退幣"
        Me.ChangeReturnBTN.UseVisualStyleBackColor = False
        '
        'ResetMoneyReturnTimer
        '
        Me.ResetMoneyReturnTimer.Interval = 1000
        '
        'Index6
        '
        Me.Index6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index6.Image = CType(resources.GetObject("Index6.Image"), System.Drawing.Image)
        Me.Index6.Location = New System.Drawing.Point(43, 569)
        Me.Index6.Name = "Index6"
        Me.Index6.Size = New System.Drawing.Size(102, 37)
        Me.Index6.TabIndex = 74
        Me.Index6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Index1
        '
        Me.Index1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index1.Image = CType(resources.GetObject("Index1.Image"), System.Drawing.Image)
        Me.Index1.Location = New System.Drawing.Point(53, 260)
        Me.Index1.Name = "Index1"
        Me.Index1.Size = New System.Drawing.Size(101, 28)
        Me.Index1.TabIndex = 61
        Me.Index1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn1
        '
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.Image = CType(resources.GetObject("Btn1.Image"), System.Drawing.Image)
        Me.Btn1.Location = New System.Drawing.Point(48, 293)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(112, 37)
        Me.Btn1.TabIndex = 86
        Me.Btn1.Visible = False
        '
        'Index2
        '
        Me.Index2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index2.Image = CType(resources.GetObject("Index2.Image"), System.Drawing.Image)
        Me.Index2.Location = New System.Drawing.Point(223, 260)
        Me.Index2.Name = "Index2"
        Me.Index2.Size = New System.Drawing.Size(101, 28)
        Me.Index2.TabIndex = 87
        Me.Index2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn2
        '
        Me.Btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn2.Image = CType(resources.GetObject("Btn2.Image"), System.Drawing.Image)
        Me.Btn2.Location = New System.Drawing.Point(220, 293)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(111, 37)
        Me.Btn2.TabIndex = 88
        Me.Btn2.Visible = False
        '
        'Index3
        '
        Me.Index3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index3.Image = CType(resources.GetObject("Index3.Image"), System.Drawing.Image)
        Me.Index3.Location = New System.Drawing.Point(396, 260)
        Me.Index3.Name = "Index3"
        Me.Index3.Size = New System.Drawing.Size(101, 28)
        Me.Index3.TabIndex = 89
        Me.Index3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn3
        '
        Me.Btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn3.Image = CType(resources.GetObject("Btn3.Image"), System.Drawing.Image)
        Me.Btn3.Location = New System.Drawing.Point(390, 293)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(112, 37)
        Me.Btn3.TabIndex = 90
        Me.Btn3.Visible = False
        '
        'Index4
        '
        Me.Index4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index4.Image = CType(resources.GetObject("Index4.Image"), System.Drawing.Image)
        Me.Index4.Location = New System.Drawing.Point(571, 260)
        Me.Index4.Name = "Index4"
        Me.Index4.Size = New System.Drawing.Size(101, 28)
        Me.Index4.TabIndex = 91
        Me.Index4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn4
        '
        Me.Btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn4.Image = CType(resources.GetObject("Btn4.Image"), System.Drawing.Image)
        Me.Btn4.Location = New System.Drawing.Point(558, 293)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(112, 37)
        Me.Btn4.TabIndex = 92
        Me.Btn4.Visible = False
        '
        'Index5
        '
        Me.Index5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index5.Image = CType(resources.GetObject("Index5.Image"), System.Drawing.Image)
        Me.Index5.Location = New System.Drawing.Point(725, 260)
        Me.Index5.Name = "Index5"
        Me.Index5.Size = New System.Drawing.Size(101, 28)
        Me.Index5.TabIndex = 93
        Me.Index5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn5
        '
        Me.Btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn5.Image = CType(resources.GetObject("Btn5.Image"), System.Drawing.Image)
        Me.Btn5.Location = New System.Drawing.Point(718, 292)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(111, 37)
        Me.Btn5.TabIndex = 94
        Me.Btn5.Visible = False
        '
        'Btn6
        '
        Me.Btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn6.Image = CType(resources.GetObject("Btn6.Image"), System.Drawing.Image)
        Me.Btn6.Location = New System.Drawing.Point(41, 609)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(111, 37)
        Me.Btn6.TabIndex = 95
        Me.Btn6.Visible = False
        '
        'Index7
        '
        Me.Index7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index7.Image = CType(resources.GetObject("Index7.Image"), System.Drawing.Image)
        Me.Index7.Location = New System.Drawing.Point(215, 569)
        Me.Index7.Name = "Index7"
        Me.Index7.Size = New System.Drawing.Size(102, 37)
        Me.Index7.TabIndex = 96
        Me.Index7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn7
        '
        Me.Btn7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn7.Image = CType(resources.GetObject("Btn7.Image"), System.Drawing.Image)
        Me.Btn7.Location = New System.Drawing.Point(208, 609)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(111, 37)
        Me.Btn7.TabIndex = 97
        Me.Btn7.Visible = False
        '
        'Index8
        '
        Me.Index8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index8.Image = CType(resources.GetObject("Index8.Image"), System.Drawing.Image)
        Me.Index8.Location = New System.Drawing.Point(394, 569)
        Me.Index8.Name = "Index8"
        Me.Index8.Size = New System.Drawing.Size(102, 37)
        Me.Index8.TabIndex = 98
        Me.Index8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn8
        '
        Me.Btn8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn8.Image = CType(resources.GetObject("Btn8.Image"), System.Drawing.Image)
        Me.Btn8.Location = New System.Drawing.Point(389, 609)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(111, 37)
        Me.Btn8.TabIndex = 99
        Me.Btn8.Visible = False
        '
        'Index9
        '
        Me.Index9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index9.Image = CType(resources.GetObject("Index9.Image"), System.Drawing.Image)
        Me.Index9.Location = New System.Drawing.Point(569, 569)
        Me.Index9.Name = "Index9"
        Me.Index9.Size = New System.Drawing.Size(102, 37)
        Me.Index9.TabIndex = 100
        Me.Index9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn9
        '
        Me.Btn9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn9.Image = CType(resources.GetObject("Btn9.Image"), System.Drawing.Image)
        Me.Btn9.Location = New System.Drawing.Point(559, 609)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(112, 37)
        Me.Btn9.TabIndex = 101
        Me.Btn9.Visible = False
        '
        'Index10
        '
        Me.Index10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Index10.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Index10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Index10.Image = CType(resources.GetObject("Index10.Image"), System.Drawing.Image)
        Me.Index10.Location = New System.Drawing.Point(722, 569)
        Me.Index10.Name = "Index10"
        Me.Index10.Size = New System.Drawing.Size(102, 37)
        Me.Index10.TabIndex = 102
        Me.Index10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn10
        '
        Me.Btn10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn10.Image = CType(resources.GetObject("Btn10.Image"), System.Drawing.Image)
        Me.Btn10.Location = New System.Drawing.Point(716, 609)
        Me.Btn10.Name = "Btn10"
        Me.Btn10.Size = New System.Drawing.Size(112, 37)
        Me.Btn10.TabIndex = 103
        Me.Btn10.Visible = False
        '
        'QuarterImg
        '
        Me.QuarterImg.BackColor = System.Drawing.Color.White
        Me.QuarterImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuarterImg.Image = CType(resources.GetObject("QuarterImg.Image"), System.Drawing.Image)
        Me.QuarterImg.Location = New System.Drawing.Point(971, 472)
        Me.QuarterImg.Name = "QuarterImg"
        Me.QuarterImg.Size = New System.Drawing.Size(96, 83)
        Me.QuarterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuarterImg.TabIndex = 53
        Me.QuarterImg.TabStop = False
        Me.QuarterImg.Visible = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(954, 677)
        Me.AxWindowsMediaPlayer1.TabIndex = 1000
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'picOpen
        '
        Me.picOpen.BackColor = System.Drawing.SystemColors.Control
        Me.picOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picOpen.InitialImage = CType(resources.GetObject("picOpen.InitialImage"), System.Drawing.Image)
        Me.picOpen.Location = New System.Drawing.Point(1074, 14)
        Me.picOpen.Name = "picOpen"
        Me.picOpen.Size = New System.Drawing.Size(24, 23)
        Me.picOpen.TabIndex = 1001
        Me.picOpen.TabStop = False
        '
        'cboComPort
        '
        Me.cboComPort.FormattingEnabled = True
        Me.cboComPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4"})
        Me.cboComPort.Location = New System.Drawing.Point(989, 14)
        Me.cboComPort.Name = "cboComPort"
        Me.cboComPort.Size = New System.Drawing.Size(78, 24)
        Me.cboComPort.TabIndex = 1002
        '
        'BackgroundWorker1
        '
        '
        'UdpTimer
        '
        Me.UdpTimer.Interval = 1000
        '
        'VendingMachine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.cboComPort)
        Me.Controls.Add(Me.picOpen)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Btn10)
        Me.Controls.Add(Me.Index10)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Index9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Index8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.Index7)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Index5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Index4)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Index3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Index2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.DollarBillImg)
        Me.Controls.Add(Me.Index1)
        Me.Controls.Add(Me.Index6)
        Me.Controls.Add(Me.ChangeReturnBTN)
        Me.Controls.Add(Me.dimeImg)
        Me.Controls.Add(Me.QuarterImg)
        Me.Controls.Add(Me.NickelImg)
        Me.Controls.Add(Me.MoneyDepositTB)
        Me.Controls.Add(Me.MoneyReturnTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VendingMachineIMG)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "VendingMachine"
        Me.Text = "Vending Machine"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Pic_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pic_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendingMachineIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimeImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DollarBillImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NickelImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarterImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOpen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'form on load settings
    Private Sub VendingMachine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set 'Money Return' images visibility = false
        ' read avaiable COM Ports:
        Dim Portnames As String() = System.IO.Ports.SerialPort.GetPortNames
        If Portnames Is Nothing Then
            MsgBox("There are no Com Ports detected!")
            Me.Close()
        End If
        cboComPort.Items.AddRange(Portnames)
        cboComPort.Text = "COM19"

        OpenComPort()

        If BackgroundWorker1.IsBusy = False Then
            Dim myObj As New CSState
            myObj.myUDPClient = New UdpClient(12344)
            myObj.RemoteIpEndPoint = New IPEndPoint(IPAddress.Parse("192.168.11.170"), 12345) '<==這是Server接收的一個重點，要用(IPAddress.Any, 0)的原因在於Server端程式一開始無法預測會是哪個IP從哪個Port傳給它﹝除非有其它原因要鎖住來源﹞。 
            BackgroundWorker1.RunWorkerAsync(myObj)
        End If
        UdpTimer.Enabled = True
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

    'Calculates the amount to return after transaction找錢
    Private Sub CalculateChange(ByVal AvailableMoney As Decimal)

        If (AvailableMoney = 0) Then
            MoneyAvailable = 0
            MoneyDepositTB.Text = ""
            Exit Sub
        Else
            Dim num As Integer = AvailableMoney / 50
            MsgBox(num, MsgBoxStyle.Information, "找錢")
        End If


        MoneyReturnTB.Text = MoneyAvailable.ToString("C")
        MoneyDepositTB.Text = ""
	SendBytes = MoneyReturnTB.Text
        MoneyAvailable = 0.0

    End Sub



    'Clears fields and resets them to remove any values
    Private Sub ResetComponents()


        MoneyReturnTB.Text = ""



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
        'Dim i As Integer
        'Dim TempMoneyCount As Decimal

        'For i = 1 To 100 Step 3
        'TempMoneyCount = i / 100 + MoneyAvailable
        'Me.Refresh()

        'MoneyDepositTB.Text = TempMoneyCount.ToString("C")
        'Next

        'MoneyAvailable = MoneyAvailable + 1.0

        ChangeMoney(0, 1, 0, 0, 0)



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

    '時間
    Private Sub ResetMoneyReturnTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetMoneyReturnTimer.Tick


        Call ResetComponents()

        ResetMoneyReturnTimer.Enabled = False

        '撥放影片
        PlayMovie()

    End Sub
    '買買買
    Private Sub PerformTransaction(ByVal ItemName As PictureBox, ByVal ButtonName As Button, ByVal ItemPrice As Decimal, ByVal SoldOutLabel As Label)


        ItemCost = ItemPrice

        If (ItemCost <= MoneyAvailable) Then
            ' ButtonName.Enabled = False

            MoneyAvailable -= ItemCost 'Reduce MoneyAvailable after purchase
            'MoneyDepositTB.Text = MoneyAvailable.ToString("C")
            MoneyDepositTB.Text = MoneyAvailable

            If comOpen Then SerialPort1.Write("1")
            '按鈕隱藏
            'ButtonName.Visible = False
            Btn_Visible()

            CalculateChange(MoneyAvailable)

            ResetMoneyReturnTimer.Enabled = True



        End If 'ITEM COST
    End Sub




    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        ProductNum = 1
        Call PerformTransaction(Pic_1, Btn1, Price1.Text, Index1)

    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        ProductNum = 2
        Call PerformTransaction(Pic_2, Btn2, Price2.Text, Index2)

    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        ProductNum = 3
        Call PerformTransaction(Pic_3, Btn3, Price3.Text, Index3)

    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        ProductNum = 4
        Call PerformTransaction(Pic_4, Btn4, Price4.Text, Index4)

    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        ProductNum = 5
        Call PerformTransaction(Pic_5, Btn5, Price5.Text, Index5)

    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        ProductNum = 6
        Call PerformTransaction(Pic_6, Btn6, Price6.Text, Index6)

    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        ProductNum = 7
        Call PerformTransaction(Pic_7, Btn7, Price7.Text, Index7)

    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        ProductNum = 8
        Call PerformTransaction(Pic_8, Btn8, Price8.Text, Index8)

    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        ProductNum = 9
        Call PerformTransaction(Pic_9, Btn9, Price9.Text, Index9)

    End Sub

    Private Sub Btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn10.Click
        ProductNum = 10
        Call PerformTransaction(Pic_10, Btn10, Price10.Text, Index10)

    End Sub

    Private Sub PlayMovie()
        'If (ProductNum = 1) Then AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
        Select Case ProductNum
            Case 1
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 2
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 3
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 4
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 5
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 6
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 7
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 8
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 9
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
            Case 10
                AxWindowsMediaPlayer1.URL = "C:/Wildlife.wmv"
        End Select
    End Sub
    '按鈕隱藏
    Private Sub Btn_Visible()
        Btn1.Visible = False
        Btn2.Visible = False
        Btn3.Visible = False
        Btn4.Visible = False
        Btn5.Visible = False
        Btn6.Visible = False
        Btn7.Visible = False
        Btn8.Visible = False
        Btn9.Visible = False
        Btn10.Visible = False
    End Sub

    '錢幣投入
    Public Function ChangeMoney(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer) As Integer
        Dim total As Integer = a * 50 + b * 100 + e * 200 + d * 500 + e * 1000
        'MsgBox(total, MsgBoxStyle.Information, "About")
        MoneyAvailable += total
        MoneyDepositTB.Text = MoneyAvailable

        If (MoneyAvailable >= Price1.Text) Then Btn1.Visible = True
        If (MoneyAvailable >= Price2.Text) Then Btn2.Visible = True
        If (MoneyAvailable >= Price3.Text) Then Btn3.Visible = True
        If (MoneyAvailable >= Price4.Text) Then Btn4.Visible = True
        If (MoneyAvailable >= Price5.Text) Then Btn5.Visible = True
        If (MoneyAvailable >= Price6.Text) Then Btn6.Visible = True
        If (MoneyAvailable >= Price7.Text) Then Btn7.Visible = True
        If (MoneyAvailable >= Price8.Text) Then Btn8.Visible = True
        If (MoneyAvailable >= Price9.Text) Then Btn9.Visible = True
        If (MoneyAvailable >= Price10.Text) Then Btn10.Visible = True

        Return total

    End Function
    Private Sub AxWindowsMediaPlayer1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange

        If (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            If comOpen Then SerialPort1.Write("0")
            AxWindowsMediaPlayer1.Visible = False
            ProductNum = 0
        ElseIf (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            AxWindowsMediaPlayer1.Visible = True
            ' MsgBox(AxWindowsMediaPlayer1.playState, MsgBoxStyle.Information, "狀態")
        End If

    End Sub

    Private Sub OpenComPort()
        ' device params
        With SerialPort1

            .ParityReplace = &H3B                    ' replace ";" when parity error occurs
            .PortName = "COM19"
            .BaudRate = 9600
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .RtsEnable = False
            .ReceivedBytesThreshold = 1             'threshold: one byte in buffer > event is fired
            .NewLine = vbCr         ' CR must be the last char in frame. This terminates the SerialPort.readLine
            .ReadTimeout = 10000

        End With

        ' check whether device is avaiable:
        Try
            SerialPort1.Open()
            comOpen = SerialPort1.IsOpen
        Catch ex As Exception
            comOpen = False
            MsgBox("Error Open: " & ex.Message)
            picOpen.BackColor = Color.Red
        End Try

        If comOpen Then
            picOpen.BackColor = Color.Green
            cboComPort.Enabled = False
        End If
        
    End Sub
    'Esc 關閉
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Escape Then
            Close_Comport()
            Me.Close()
        End If
        Me.Close()
    End Function

    Private Sub Close_Comport()
        If comOpen Then
            ' clear input buffer
            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()
        End If
        comOpen = False
        picOpen.BackColor = Color.Red

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim myObj As CSState = CType(e.Argument, CSState)
        While True
            Try
                If myObj.myUDPClient.Available > 0 Then
                    ReceiveBytes = Encoding.GetEncoding(0).GetString(myObj.myUDPClient.Receive(myObj.RemoteIpEndPoint))
                End If
                If String.IsNullOrEmpty(SendBytes) = False Then
                    Dim myBytes As Byte()
                    myBytes = Encoding.GetEncoding(0).GetBytes(Trim(SendBytes))
                    myObj.myUDPClient.Send(myBytes, myBytes.Length, myObj.RemoteIpEndPoint)
                    SendBytes = String.Empty
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End While
    End Sub

    Private Sub UdpTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UdpTimer.Tick
        If String.IsNullOrEmpty(ReceiveBytes) = False Then
            MoneyDepositTB.Text = ReceiveBytes
            MoneyAvailable += Integer.Parse(ReceiveBytes)
            ReceiveBytes = String.Empty
        End If
    End Sub
End Class
