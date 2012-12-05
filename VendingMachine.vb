'Term Project 2
'Anupam Pandeya 07/23/06
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing
Imports System.IO.MemoryStream

Public Class VendingMachine
    Inherits System.Windows.Forms.Form
    'Global Variables
    Dim list_Name As New ArrayList
    Dim list_Pic As New ArrayList
    Dim list_Price As New ArrayList
    Dim list_Video As New ArrayList
    Dim list_Print As New ArrayList
    Dim list_Strike As New ArrayList
    Dim TotalNum As Integer
    Dim Page As Integer = 1
    Dim oweMoney As Integer
    Private comOpen As Boolean 'comPort
    Dim ItemQuantity As Integer = 0
    'Quantity of Items available
    Dim objRandom As New System.Random(CType(System.DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer))
    Dim formGraphics As System.Drawing.Graphics
    Dim drawFont As System.Drawing.Font
    Dim drawBrush As System.Drawing.SolidBrush
    Dim drawFormat As System.Drawing.StringFormat
    Dim appobject As AppClass
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker     'Quantity of Items available
    Friend WithEvents Price1 As System.Windows.Forms.Label
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Price2 As System.Windows.Forms.Label
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Price3 As System.Windows.Forms.Label
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer0 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer5 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer6 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents UdpTimer As System.Windows.Forms.Timer
    Friend WithEvents RotateTimer As System.Windows.Forms.Timer
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ProductName_3 As System.Windows.Forms.Label
    Friend WithEvents ProductName_2 As System.Windows.Forms.Label
    Friend WithEvents ProductName_1 As System.Windows.Forms.Label
    Friend WithEvents MsgTimer As System.Windows.Forms.Timer
    Friend WithEvents PrintError As System.Drawing.Printing.PrintDocument
    'Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cboComPort As System.Windows.Forms.ComboBox
    Friend WithEvents picOpen As System.Windows.Forms.PictureBox
    Friend WithEvents Price5 As System.Windows.Forms.Label
    Friend WithEvents Price6 As System.Windows.Forms.Label
    Friend WithEvents Price4 As System.Windows.Forms.Label
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents ProductName_6 As System.Windows.Forms.Label
    Friend WithEvents ProductName_5 As System.Windows.Forms.Label
    Friend WithEvents ProductName_4 As System.Windows.Forms.Label
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

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
    Friend WithEvents MoneyReturnTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MoneyDepositTB As System.Windows.Forms.TextBox
    Friend WithEvents ChangeReturnBTN As System.Windows.Forms.Button
    Friend WithEvents ResetMoneyReturnTimer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendingMachine))
        Me.ProductName_3 = New System.Windows.Forms.Label()
        Me.ProductName_2 = New System.Windows.Forms.Label()
        Me.ProductName_1 = New System.Windows.Forms.Label()
        Me.Price3 = New System.Windows.Forms.Label()
        Me.Price2 = New System.Windows.Forms.Label()
        Me.Price1 = New System.Windows.Forms.Label()
        Me.MoneyReturnTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MoneyDepositTB = New System.Windows.Forms.TextBox()
        Me.ChangeReturnBTN = New System.Windows.Forms.Button()
        Me.ResetMoneyReturnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer0 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.UdpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RotateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MsgTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PrintError = New System.Drawing.Printing.PrintDocument()
        Me.cboComPort = New System.Windows.Forms.ComboBox()
        Me.picOpen = New System.Windows.Forms.PictureBox()
        Me.Price5 = New System.Windows.Forms.Label()
        Me.Price6 = New System.Windows.Forms.Label()
        Me.Price4 = New System.Windows.Forms.Label()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.ProductName_6 = New System.Windows.Forms.Label()
        Me.ProductName_5 = New System.Windows.Forms.Label()
        Me.ProductName_4 = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductName_3
        '
        Me.ProductName_3.AutoSize = True
        Me.ProductName_3.BackColor = System.Drawing.Color.White
        Me.ProductName_3.Location = New System.Drawing.Point(501, 111)
        Me.ProductName_3.Name = "ProductName_3"
        Me.ProductName_3.Size = New System.Drawing.Size(53, 12)
        Me.ProductName_3.TabIndex = 91
        Me.ProductName_3.Text = "產品名稱"
        Me.ProductName_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProductName_3.Visible = False
        '
        'ProductName_2
        '
        Me.ProductName_2.AutoSize = True
        Me.ProductName_2.BackColor = System.Drawing.Color.White
        Me.ProductName_2.Location = New System.Drawing.Point(501, 411)
        Me.ProductName_2.Name = "ProductName_2"
        Me.ProductName_2.Size = New System.Drawing.Size(53, 12)
        Me.ProductName_2.TabIndex = 91
        Me.ProductName_2.Text = "產品名稱"
        Me.ProductName_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProductName_2.Visible = False
        '
        'ProductName_1
        '
        Me.ProductName_1.AutoSize = True
        Me.ProductName_1.BackColor = System.Drawing.Color.White
        Me.ProductName_1.Location = New System.Drawing.Point(501, 704)
        Me.ProductName_1.Name = "ProductName_1"
        Me.ProductName_1.Size = New System.Drawing.Size(53, 12)
        Me.ProductName_1.TabIndex = 91
        Me.ProductName_1.Text = "產品名稱"
        Me.ProductName_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ProductName_1.Visible = False
        '
        'Price3
        '
        Me.Price3.AutoSize = True
        Me.Price3.BackColor = System.Drawing.Color.White
        Me.Price3.Location = New System.Drawing.Point(501, 158)
        Me.Price3.Name = "Price3"
        Me.Price3.Size = New System.Drawing.Size(23, 12)
        Me.Price3.TabIndex = 88
        Me.Price3.Text = "100"
        Me.Price3.Visible = False
        '
        'Price2
        '
        Me.Price2.AutoSize = True
        Me.Price2.BackColor = System.Drawing.Color.White
        Me.Price2.Location = New System.Drawing.Point(501, 449)
        Me.Price2.Name = "Price2"
        Me.Price2.Size = New System.Drawing.Size(23, 12)
        Me.Price2.TabIndex = 87
        Me.Price2.Text = "100"
        Me.Price2.Visible = False
        '
        'Price1
        '
        Me.Price1.AutoSize = True
        Me.Price1.BackColor = System.Drawing.Color.White
        Me.Price1.Location = New System.Drawing.Point(501, 749)
        Me.Price1.Name = "Price1"
        Me.Price1.Size = New System.Drawing.Size(23, 12)
        Me.Price1.TabIndex = 86
        Me.Price1.Text = "100"
        Me.Price1.Visible = False
        '
        'MoneyReturnTB
        '
        Me.MoneyReturnTB.BackColor = System.Drawing.Color.Maroon
        Me.MoneyReturnTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyReturnTB.ForeColor = System.Drawing.Color.Silver
        Me.MoneyReturnTB.Location = New System.Drawing.Point(4, 357)
        Me.MoneyReturnTB.Name = "MoneyReturnTB"
        Me.MoneyReturnTB.ReadOnly = True
        Me.MoneyReturnTB.Size = New System.Drawing.Size(104, 22)
        Me.MoneyReturnTB.TabIndex = 47
        Me.MoneyReturnTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MoneyReturnTB.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(9, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 14)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Money Returned:"
        Me.Label2.Visible = False
        '
        'MoneyDepositTB
        '
        Me.MoneyDepositTB.BackColor = System.Drawing.Color.Silver
        Me.MoneyDepositTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.MoneyDepositTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MoneyDepositTB.Location = New System.Drawing.Point(55, 463)
        Me.MoneyDepositTB.MaxLength = 32
        Me.MoneyDepositTB.Multiline = True
        Me.MoneyDepositTB.Name = "MoneyDepositTB"
        Me.MoneyDepositTB.ReadOnly = True
        Me.MoneyDepositTB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MoneyDepositTB.Size = New System.Drawing.Size(27, 92)
        Me.MoneyDepositTB.TabIndex = 50
        Me.MoneyDepositTB.Text = "50"
        Me.MoneyDepositTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MoneyDepositTB.Visible = False
        '
        'ChangeReturnBTN
        '
        Me.ChangeReturnBTN.BackColor = System.Drawing.Color.Silver
        Me.ChangeReturnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangeReturnBTN.Location = New System.Drawing.Point(12, 212)
        Me.ChangeReturnBTN.Name = "ChangeReturnBTN"
        Me.ChangeReturnBTN.Size = New System.Drawing.Size(70, 41)
        Me.ChangeReturnBTN.TabIndex = 58
        Me.ChangeReturnBTN.Text = "退幣"
        Me.ChangeReturnBTN.UseVisualStyleBackColor = False
        Me.ChangeReturnBTN.Visible = False
        '
        'ResetMoneyReturnTimer
        '
        Me.ResetMoneyReturnTimer.Interval = 250
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.Location = New System.Drawing.Point(435, 581)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(50, 142)
        Me.Btn1.TabIndex = 86
        Me.Btn1.UseVisualStyleBackColor = False
        Me.Btn1.Visible = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn2.Location = New System.Drawing.Point(435, 319)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(50, 141)
        Me.Btn2.TabIndex = 88
        Me.Btn2.UseVisualStyleBackColor = False
        Me.Btn2.Visible = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn3.Location = New System.Drawing.Point(435, 64)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(50, 142)
        Me.Btn3.TabIndex = 90
        Me.Btn3.UseVisualStyleBackColor = False
        Me.Btn3.Visible = False
        '
        'AxWindowsMediaPlayer0
        '
        Me.AxWindowsMediaPlayer0.Enabled = True
        Me.AxWindowsMediaPlayer0.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer0.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer0.Name = "AxWindowsMediaPlayer0"
        Me.AxWindowsMediaPlayer0.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer0.Size = New System.Drawing.Size(1024, 768)
        Me.AxWindowsMediaPlayer0.TabIndex = 1000
        Me.AxWindowsMediaPlayer0.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(139, 540)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(278, 178)
        Me.AxWindowsMediaPlayer1.TabIndex = 1000
        Me.AxWindowsMediaPlayer1.TabStop = False
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(139, 311)
        Me.AxWindowsMediaPlayer2.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(278, 173)
        Me.AxWindowsMediaPlayer2.TabIndex = 1000
        Me.AxWindowsMediaPlayer2.TabStop = False
        '
        'AxWindowsMediaPlayer3
        '
        Me.AxWindowsMediaPlayer3.Enabled = True
        Me.AxWindowsMediaPlayer3.Location = New System.Drawing.Point(139, 60)
        Me.AxWindowsMediaPlayer3.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer3.Name = "AxWindowsMediaPlayer3"
        Me.AxWindowsMediaPlayer3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer3.Size = New System.Drawing.Size(278, 173)
        Me.AxWindowsMediaPlayer3.TabIndex = 1000
        Me.AxWindowsMediaPlayer3.TabStop = False
        '
        'AxWindowsMediaPlayer4
        '
        Me.AxWindowsMediaPlayer4.Enabled = True
        Me.AxWindowsMediaPlayer4.Location = New System.Drawing.Point(628, 539)
        Me.AxWindowsMediaPlayer4.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer4.Name = "AxWindowsMediaPlayer4"
        Me.AxWindowsMediaPlayer4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer4.Size = New System.Drawing.Size(315, 178)
        Me.AxWindowsMediaPlayer4.TabIndex = 1000
        Me.AxWindowsMediaPlayer4.TabStop = False
        '
        'AxWindowsMediaPlayer5
        '
        Me.AxWindowsMediaPlayer5.Enabled = True
        Me.AxWindowsMediaPlayer5.Location = New System.Drawing.Point(628, 305)
        Me.AxWindowsMediaPlayer5.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer5.Name = "AxWindowsMediaPlayer5"
        Me.AxWindowsMediaPlayer5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer5.Size = New System.Drawing.Size(315, 173)
        Me.AxWindowsMediaPlayer5.TabIndex = 1000
        Me.AxWindowsMediaPlayer5.TabStop = False
        '
        'AxWindowsMediaPlayer6
        '
        Me.AxWindowsMediaPlayer6.Enabled = True
        Me.AxWindowsMediaPlayer6.Location = New System.Drawing.Point(628, 74)
        Me.AxWindowsMediaPlayer6.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer6.Name = "AxWindowsMediaPlayer6"
        Me.AxWindowsMediaPlayer6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer6.Size = New System.Drawing.Size(315, 173)
        Me.AxWindowsMediaPlayer6.TabIndex = 1000
        Me.AxWindowsMediaPlayer6.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'UdpTimer
        '
        Me.UdpTimer.Interval = 1000
        '
        'RotateTimer
        '
        Me.RotateTimer.Interval = 10000
        '
        'PrintDocument1
        '
        '
        'MsgTimer
        '
        Me.MsgTimer.Interval = 3000
        '
        'PrintError
        '
        '
        'cboComPort
        '
        Me.cboComPort.FormattingEnabled = True
        Me.cboComPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4"})
        Me.cboComPort.Location = New System.Drawing.Point(594, 14)
        Me.cboComPort.Name = "cboComPort"
        Me.cboComPort.Size = New System.Drawing.Size(65, 20)
        Me.cboComPort.TabIndex = 1002
        Me.cboComPort.Visible = False
        '
        'picOpen
        '
        Me.picOpen.BackColor = System.Drawing.SystemColors.Control
        Me.picOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picOpen.InitialImage = CType(resources.GetObject("picOpen.InitialImage"), System.Drawing.Image)
        Me.picOpen.Location = New System.Drawing.Point(692, 14)
        Me.picOpen.Name = "picOpen"
        Me.picOpen.Size = New System.Drawing.Size(20, 21)
        Me.picOpen.TabIndex = 1001
        Me.picOpen.TabStop = False
        Me.picOpen.Visible = False
        '
        'Price5
        '
        Me.Price5.AutoSize = True
        Me.Price5.BackColor = System.Drawing.Color.White
        Me.Price5.Location = New System.Drawing.Point(1029, 449)
        Me.Price5.Name = "Price5"
        Me.Price5.Size = New System.Drawing.Size(23, 12)
        Me.Price5.TabIndex = 90
        Me.Price5.Text = "200"
        Me.Price5.Visible = False
        '
        'Price6
        '
        Me.Price6.AutoSize = True
        Me.Price6.BackColor = System.Drawing.Color.White
        Me.Price6.Location = New System.Drawing.Point(1029, 158)
        Me.Price6.Name = "Price6"
        Me.Price6.Size = New System.Drawing.Size(23, 12)
        Me.Price6.TabIndex = 91
        Me.Price6.Text = "100"
        Me.Price6.Visible = False
        '
        'Price4
        '
        Me.Price4.AutoSize = True
        Me.Price4.BackColor = System.Drawing.Color.White
        Me.Price4.Location = New System.Drawing.Point(1029, 749)
        Me.Price4.Name = "Price4"
        Me.Price4.Size = New System.Drawing.Size(17, 12)
        Me.Price4.TabIndex = 89
        Me.Price4.Text = "50"
        Me.Price4.Visible = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn6.Location = New System.Drawing.Point(966, 58)
        Me.Btn6.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(55, 150)
        Me.Btn6.TabIndex = 95
        Me.Btn6.UseVisualStyleBackColor = False
        Me.Btn6.Visible = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn5.Location = New System.Drawing.Point(965, 323)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(55, 141)
        Me.Btn5.TabIndex = 94
        Me.Btn5.UseVisualStyleBackColor = False
        Me.Btn5.Visible = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn4.Location = New System.Drawing.Point(965, 578)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(55, 145)
        Me.Btn4.TabIndex = 92
        Me.Btn4.UseVisualStyleBackColor = False
        Me.Btn4.Visible = False
        '
        'ProductName_6
        '
        Me.ProductName_6.AutoSize = True
        Me.ProductName_6.BackColor = System.Drawing.Color.White
        Me.ProductName_6.Location = New System.Drawing.Point(1029, 111)
        Me.ProductName_6.Name = "ProductName_6"
        Me.ProductName_6.Size = New System.Drawing.Size(53, 12)
        Me.ProductName_6.TabIndex = 91
        Me.ProductName_6.Text = "產品名稱"
        Me.ProductName_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ProductName_6.Visible = False
        '
        'ProductName_5
        '
        Me.ProductName_5.AutoSize = True
        Me.ProductName_5.BackColor = System.Drawing.Color.White
        Me.ProductName_5.Location = New System.Drawing.Point(1029, 411)
        Me.ProductName_5.Name = "ProductName_5"
        Me.ProductName_5.Size = New System.Drawing.Size(53, 12)
        Me.ProductName_5.TabIndex = 91
        Me.ProductName_5.Text = "產品名稱"
        Me.ProductName_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProductName_5.Visible = False
        '
        'ProductName_4
        '
        Me.ProductName_4.AutoSize = True
        Me.ProductName_4.BackColor = System.Drawing.Color.White
        Me.ProductName_4.Location = New System.Drawing.Point(1026, 704)
        Me.ProductName_4.Name = "ProductName_4"
        Me.ProductName_4.Size = New System.Drawing.Size(53, 12)
        Me.ProductName_4.TabIndex = 91
        Me.ProductName_4.Text = "產品名稱"
        Me.ProductName_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProductName_4.Visible = False
        '
        'VendingMachine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TermProject2.My.Resources.Resources.vendor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.Price3)
        Me.Controls.Add(Me.ProductName_3)
        Me.Controls.Add(Me.ProductName_2)
        Me.Controls.Add(Me.Price2)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Price4)
        Me.Controls.Add(Me.ProductName_1)
        Me.Controls.Add(Me.ProductName_4)
        Me.Controls.Add(Me.Price1)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.ProductName_5)
        Me.Controls.Add(Me.Price5)
        Me.Controls.Add(Me.cboComPort)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.ProductName_6)
        Me.Controls.Add(Me.Price6)
        Me.Controls.Add(Me.picOpen)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.ChangeReturnBTN)
        Me.Controls.Add(Me.MoneyDepositTB)
        Me.Controls.Add(Me.MoneyReturnTB)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer3)
        Me.Controls.Add(Me.AxWindowsMediaPlayer4)
        Me.Controls.Add(Me.AxWindowsMediaPlayer5)
        Me.Controls.Add(Me.AxWindowsMediaPlayer6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendingMachine"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Vending Machine"
        Me.TopMost = True
        CType(Me.AxWindowsMediaPlayer0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOpen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'form on load settings
    Private Sub VendingMachine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim screen As Screen

        ' We want to display a form on screen 1

        screen = screen.AllScreens(1)

        If (screen.AllScreens.Length = 2) Then
            Dim formRay As New Form
            ' Set the StartPosition to Manual otherwise the system will assign an automatic start position
            formRay.StartPosition = FormStartPosition.Manual
            ' Set the form location so it appears at Location (100, 100) on the screen 1
            formRay.Location = screen.Bounds.Location ' + New Point(100, 100)
            ' Show the form
            formRay.BackColor = Color.Black
            formRay.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            formRay.WindowState = FormWindowState.Maximized
            formRay.Controls.Add(Me.AxWindowsMediaPlayer0)
            formRay.Show() 'Dialog(Me)
        End If

        Dim strDbCon As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=test.mdb"
        Dim objCon As OleDbConnection = New OleDbConnection(strDbCon)
        objCon.Open()
        ' SQL語法
        Dim objCmd As OleDbCommand = New OleDbCommand("SELECT * FROM test order by P_Num", objCon)
        Dim objDataReader As OleDbDataReader = objCmd.ExecuteReader()
        'Dim out As String
        ' 讀取singer欄位的值
        While objDataReader.Read()
            TotalNum = TotalNum + 1
            'out += objDataReader.Item("P_Name")
            list_Name.Add(objDataReader.Item("P_Name"))
            list_Pic.Add(objDataReader.Item("P_Pic"))
            list_Price.Add(objDataReader.Item("P_Price"))
            list_Video.Add(objDataReader.Item("Animation"))
            list_Strike.Add(objDataReader.Item("Strike"))
            list_Print.Add(objDataReader.Item("Content_Pic"))
        End While
        ' 關閉資料庫的連結
        objDataReader.Close()
        objCon.Close()

        appobject = New AppClass()
        'If (Math.Ceiling(TotalNum / 10) > 1) Then btn_next.Visible = True
        PageSetting()

        'MsgBox(Math.Ceiling(TotalNum / 10))

        'set 'Money Return' images visibility = false
        ' read avaiable COM Ports:
        Dim Portnames As String() = System.IO.Ports.SerialPort.GetPortNames
        If Portnames Is Nothing Then
            MsgBox("There are no Com Ports detected!")
            Me.Close()
        End If
        cboComPort.Items.AddRange(Portnames)
        cboComPort.Text = "COM4"
        OpenComPort()

        If BackgroundWorker1.IsBusy = False Then
            Dim myObj As New CSState
            myObj.myUDPClient = New UdpClient(12344)
            myObj.RemoteIpEndPoint = New IPEndPoint(IPAddress.Parse("127.0.0.1"), 0) '<==這是Server接收的一個重點，要用(IPAddress.Any, 0)的原因在於Server端程式一開始無法預測會是哪個IP從哪個Port傳給它﹝除非有其它原因要鎖住來源﹞。 
            BackgroundWorker1.RunWorkerAsync(myObj)
        End If
        UdpTimer.Enabled = True
        RotateTimer.Enabled = True
    End Sub

    'start mouse over behavior
    'Private Sub DollarBillImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
    '    DollarBillImg.Location = New Point(DollarBillImg.Location.X + 2, DollarBillImg.Location.Y + 2)
    'End Sub

    'Private Sub DollarBillImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    DollarBillImg.Location = New Point(DollarBillImg.Location.X - 2, DollarBillImg.Location.Y - 2)
    'End Sub

    'Private Sub QuarterImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
    '    QuarterImg.Location = New Point(QuarterImg.Location.X + 2, QuarterImg.Location.Y + 2)
    'End Sub

    'Private Sub QuarterImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    QuarterImg.Location = New Point(QuarterImg.Location.X - 2, QuarterImg.Location.Y - 2)
    'End Sub


    'Private Sub dimeImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
    '   dimeImg.Location = New Point(dimeImg.Location.X + 2, dimeImg.Location.Y + 2)
    'End Sub


    'Private Sub dimeImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    dimeImg.Location = New Point(dimeImg.Location.X - 2, dimeImg.Location.Y - 2)
    'End Sub


    'Private Sub NickelImg_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
    '    NickelImg.Location = New Point(NickelImg.Location.X + 2, NickelImg.Location.Y + 2)
    'End Sub

    'Private Sub NickelImg_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    NickelImg.Location = New Point(NickelImg.Location.X - 2, NickelImg.Location.Y - 2)
    'End Sub

    ' Returns a random number, between the optional Low and High parameters 
    Public Function GetRandomNumber(Optional ByVal Low As Integer = 1, Optional ByVal High As Integer = 100) As Integer
        Return objRandom.Next(Low, High + 1)
    End Function

    'Calculates the amount to return after transaction找錢
    Private Sub CalculateChange(ByVal AvailableMoney As Decimal)

        MoneyReturnTB.Text = appobject.MoneyAvailable.ToString("C")
        MoneyDepositTB.Text = "   "
        DrawVerticalText(MoneyDepositTB.Text)
        Btn_Show()

    End Sub

    'Clears fields and resets them to remove any values
    Private Sub ResetComponents()
        MoneyReturnTB.Text = "   "
    End Sub

    'Returns unused amount to user
    Private Sub ChangeReturnBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeReturnBTN.Click
        DrawVerticalText("50")

        'If (appobject.MoneyAvailable > 0) Then
        'CalculateChange(appobject.MoneyAvailable)
        'ResetMoneyReturnTimer.Enabled = True
        'Else
        'MsgBox("You do not have any deposited money to return", MsgBoxStyle.Exclamation, "Zero Balance")
        'End If

        'Btn_Show()
    End Sub

    'Private Sub DollarBillImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim i As Integer
    'Dim TempMoneyCount As Decimal
    'For i = 1 To 100 Step 3
    'TempMoneyCount = i / 100 + MoneyAvailable
    'Me.Refresh()
    'MoneyDepositTB.Text = TempMoneyCount.ToString("C")
    'Next
    'MoneyAvailable = MoneyAvailable + 1.0

    'ChangeMoney(0, 1, 0, 0, 0)

    'End Sub


    'Private Sub QuarterImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim i As Integer
    'Dim TempMoneyCount As Decimal

    'For i = 1 To 25 Step 3
    'TempMoneyCount = i / 100 + MoneyAvailable
    'Me.Refresh()

    'MoneyDepositTB.Text = TempMoneyCount.ToString("C")
    'Next

    'MoneyAvailable = MoneyAvailable + 0.25
    'End Sub

    'Private Sub dimeImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim i As Integer
    'Dim TempMoneyCount As Decimal

    'For i = 1 To 10
    'TempMoneyCount = i / 100 + MoneyAvailable
    'Me.Refresh()

    'MoneyDepositTB.Text = TempMoneyCount.ToString("C")
    'Next

    'MoneyAvailable = MoneyAvailable + 0.1
    'End Sub

    'Private Sub NickelImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim i As Integer
    'Dim TempMoneyCount As Decimal

    'For i = 1 To 5
    'TempMoneyCount = i / 100 + MoneyAvailable
    'Me.Refresh()

    'MoneyDepositTB.Text = TempMoneyCount.ToString("C")
    'Next

    'MoneyAvailable = MoneyAvailable + 0.05
    'End Sub

    '時間
    Private Sub ResetMoneyReturnTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetMoneyReturnTimer.Tick

        Call ResetComponents()

        ResetMoneyReturnTimer.Enabled = False
        '撥放影片
        PlayMovie()

    End Sub
    '買買買
    Private Sub PerformTransaction(ByVal ItemPrice As Decimal)

        appobject.ItemCost = ItemPrice
        appobject.Submit()

        If (appobject.ItemCost <= appobject.MoneyAvailable) Then

            appobject.MoneyAvailable -= appobject.ItemCost 'Reduce MoneyAvailable after purchase
            MoneyDepositTB.Text = appobject.MoneyAvailable
            DrawVerticalText(MoneyDepositTB.Text)
            UdpTimer.Enabled = False
            
            Select Case appobject.ProductNum
                Case 1
                    AxWindowsMediaPlayer1.settings.setMode("loop", False)
                    AxWindowsMediaPlayer1.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                Case 2
                    AxWindowsMediaPlayer2.settings.setMode("loop", False)
                    AxWindowsMediaPlayer2.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                Case 3
                    AxWindowsMediaPlayer3.settings.setMode("loop", False)
                    AxWindowsMediaPlayer3.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    AxWindowsMediaPlayer3.Ctlcontrols.play()
                Case 4
                    AxWindowsMediaPlayer4.settings.setMode("loop", False)
                    AxWindowsMediaPlayer4.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    AxWindowsMediaPlayer4.Ctlcontrols.play()
                Case 5
                    AxWindowsMediaPlayer5.settings.setMode("loop", False)
                    AxWindowsMediaPlayer5.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    AxWindowsMediaPlayer5.Ctlcontrols.play()
                Case 6
                    AxWindowsMediaPlayer6.settings.setMode("loop", False)
                    AxWindowsMediaPlayer6.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    AxWindowsMediaPlayer6.Ctlcontrols.play()
            End Select

            Btn_Show()

        End If 'ITEM COST

    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        appobject.ProductNum = 1 '+ (Page - 1) * 10
        Call PerformTransaction(Price1.Text) '(Pic_1, Btn1, Price1.Text)
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        appobject.ProductNum = 2 '+ (Page - 1) * 10
        Call PerformTransaction(Price2.Text)
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        appobject.ProductNum = 3 '+ (Page - 1) * 10
        Call PerformTransaction(Price3.Text)
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        appobject.ProductNum = 4 '+ (Page - 1) * 10
        Call PerformTransaction(Price4.Text)
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        appobject.ProductNum = 5 '+ (Page - 1) * 10
        Call PerformTransaction(Price5.Text)
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        appobject.ProductNum = 6 '+ (Page - 1) * 10
        Call PerformTransaction(Price6.Text)
    End Sub

    'Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    appobject.ProductNum = 7 + (Page - 1) * 10
    '    Call PerformTransaction(Pic_7, Btn7, Price7.Text, Index7)
    'End Sub

    'Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    appobject.ProductNum = 8 + (Page - 1) * 10
    '    Call PerformTransaction(Pic_8, Btn8, Price8.Text, Index8)
    'End Sub

    'Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    appobject.ProductNum = 9 + (Page - 1) * 10
    '    Call PerformTransaction(Pic_9, Btn9, Price9.Text, Index9)
    'End Sub

    'Private Sub Btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    appobject.ProductNum = 10 + (Page - 1) * 10
    '    Call PerformTransaction(Pic_10, Btn10, Price10.Text, Index10)
    'End Sub

    Private Sub PlayMovie()
        If (appobject.ProductNum >= 1 And appobject.ProductNum <= 6) Then
            'appobject.SendBytes = "play"
            'UdpTimer.Enabled = False
            'RotateTimer.Enabled = False
            'MsgBox(Application.StartupPath & "\" & list_Video((appobject.ProductNum - 1)))
            AxWindowsMediaPlayer0.URL = Application.StartupPath & "\" & list_Video((appobject.ProductNum - 1))
        End If
    End Sub

    '按鈕狀態
    Private Sub Btn_Show()
        Btn1.Visible = appobject.MoneyAvailable >= Val(Price1.Text) And Price1.Text <> ""
        Btn2.Visible = appobject.MoneyAvailable >= Val(Price2.Text) And Price2.Text <> ""
        Btn3.Visible = appobject.MoneyAvailable >= Val(Price3.Text) And Price3.Text <> ""
        Btn4.Visible = appobject.MoneyAvailable >= Val(Price4.Text) And Price4.Text <> ""
        Btn5.Visible = appobject.MoneyAvailable >= Val(Price5.Text) And Price5.Text <> ""
        Btn6.Visible = appobject.MoneyAvailable >= Val(Price6.Text) And Price6.Text <> ""
        'Btn7.Visible = MoneyAvailable >= Val(Price7.Text) And Price7.Text <> ""
        'Btn8.Visible = MoneyAvailable >= Val(Price8.Text) And Price8.Text <> ""
        'Btn9.Visible = MoneyAvailable >= Val(Price9.Text) And Price9.Text <> ""
        'Btn10.Visible = MoneyAvailable >= Val(Price10.Text) And Price10.Text <> ""
    End Sub

    Private Sub GlassAndMovie()
        appobject.ToNext()

        If comOpen Then
            SerialPort1.Write("1")
        End If

        ResetMoneyReturnTimer.Enabled = True
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer2_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer2.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayer2.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer3_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer3.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayer3.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer4_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer4.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayer4.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer5_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer5.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayer5.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer6_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer6.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayer6.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer0_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer0.PlayStateChange
        If (AxWindowsMediaPlayer0.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            UdpTimer.Enabled = True
            appobject.Change()
            PrintDocument1.Print()
            RayStartCase(appobject.ProductNum, False)
            appobject.BackStart()
            CalculateChange(appobject.MoneyAvailable)
            If comOpen Then
                SerialPort1.Write("0")
            End If
            AxWindowsMediaPlayer0.Visible = False
            appobject.SendBytes = "done"
            allContinue()
            RotateTimer.Enabled = True
        ElseIf (AxWindowsMediaPlayer0.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            AxWindowsMediaPlayer0.Visible = True
            ' MsgBox(AxWindowsMediaPlayer0.playState, MsgBoxStyle.Information, "狀態")
        End If

    End Sub

    Private Sub OpenComPort()
        ' device params
        With SerialPort1

            .ParityReplace = &H3B                    ' replace ";" when parity error occurs
            .PortName = "COM4"
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
            'picOpen.BackColor = Color.Red
        End Try

        If comOpen Then
            'picOpen.BackColor = Color.Green
            cboComPort.Enabled = False
        End If

    End Sub
    'Esc 關閉
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Escape Then
            Close_Comport()
            Me.Close()
        End If
        'Me.Close()
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
                    appobject.ReceiveBytes = Encoding.GetEncoding(0).GetString(myObj.myUDPClient.Receive(myObj.RemoteIpEndPoint))
                End If
                If String.IsNullOrEmpty(appobject.SendBytes) = False Then
                    Dim myBytes As Byte()
                    If appobject.SendBytes = "play" Or appobject.SendBytes = "done" Then
                        myBytes = Encoding.GetEncoding(0).GetBytes(Trim(appobject.SendBytes))
                        myObj.myUDPClient.Send(myBytes, myBytes.Length, New IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345))
                        myObj.myUDPClient.Send(myBytes, myBytes.Length, New IPEndPoint(IPAddress.Parse("127.0.0.1"), 12346))
                    ElseIf appobject.SendBytes.StartsWith("@@") Then
                        myBytes = Encoding.GetEncoding(0).GetBytes(Trim(appobject.SendBytes.Substring("@@".Length)))
                        myObj.myUDPClient.Send(myBytes, myBytes.Length, New IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345))
                    Else
                        myBytes = Encoding.GetEncoding(0).GetBytes(Trim(appobject.SendBytes))
                        myObj.myUDPClient.Send(myBytes, myBytes.Length, myObj.RemoteIpEndPoint)
                    End If
                    appobject.SendBytes = String.Empty
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End While
    End Sub

    Private Sub RotateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateTimer.Tick
        appobject.Over10Sec()
        appobject.backToRotate()
        'Select Case appobject.ProductNum
        '    Case 1
        'AxWindowsMediaPlayer1.settings.setMode("loop", False)
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\" & list_Pic(0) & appobject.RayPos(0) & ".wmv"
        '    Case 2
        'AxWindowsMediaPlayer2.settings.setMode("loop", False)
        AxWindowsMediaPlayer2.URL = Application.StartupPath & "\" & list_Pic(1) & appobject.RayPos(1) & ".wmv"
        '    Case 3
        'AxWindowsMediaPlayer3.settings.setMode("loop", False)
        AxWindowsMediaPlayer3.URL = Application.StartupPath & "\" & list_Pic(2) & appobject.RayPos(2) & ".wmv"
        '    Case 4
        'AxWindowsMediaPlayer4.settings.setMode("loop", False)
        AxWindowsMediaPlayer4.URL = Application.StartupPath & "\" & list_Pic(3) & appobject.RayPos(3) & ".wmv"
        '    Case 5
        'AxWindowsMediaPlayer5.settings.setMode("loop", False)
        AxWindowsMediaPlayer5.URL = Application.StartupPath & "\" & list_Pic(4) & appobject.RayPos(4) & ".wmv"
        '    Case 6
        'AxWindowsMediaPlayer6.settings.setMode("loop", False)
        AxWindowsMediaPlayer6.URL = Application.StartupPath & "\" & list_Pic(5) & appobject.RayPos(5) & ".wmv"
        'End Select
        AxWindowsMediaPlayer1.SetBounds(appobject.RaySix(0).wmv.Left, appobject.RaySix(0).wmv.Top, appobject.RaySix(0).wmv.Width, appobject.RaySix(0).wmv.Height)
        Btn1.SetBounds(appobject.RaySix(0).btn.Left, appobject.RaySix(0).btn.Top, appobject.RaySix(0).btn.Width, appobject.RaySix(0).btn.Height)
        AxWindowsMediaPlayer2.SetBounds(appobject.RaySix(1).wmv.Left, appobject.RaySix(1).wmv.Top, appobject.RaySix(1).wmv.Width, appobject.RaySix(1).wmv.Height)
        Btn2.SetBounds(appobject.RaySix(1).btn.Left, appobject.RaySix(1).btn.Top, appobject.RaySix(1).btn.Width, appobject.RaySix(1).btn.Height)
        AxWindowsMediaPlayer3.SetBounds(appobject.RaySix(2).wmv.Left, appobject.RaySix(2).wmv.Top, appobject.RaySix(2).wmv.Width, appobject.RaySix(2).wmv.Height)
        Btn3.SetBounds(appobject.RaySix(2).btn.Left, appobject.RaySix(2).btn.Top, appobject.RaySix(2).btn.Width, appobject.RaySix(2).btn.Height)
        AxWindowsMediaPlayer4.SetBounds(appobject.RaySix(3).wmv.Left, appobject.RaySix(3).wmv.Top, appobject.RaySix(3).wmv.Width, appobject.RaySix(3).wmv.Height)
        Btn4.SetBounds(appobject.RaySix(3).btn.Left, appobject.RaySix(3).btn.Top, appobject.RaySix(3).btn.Width, appobject.RaySix(3).btn.Height)
        AxWindowsMediaPlayer5.SetBounds(appobject.RaySix(4).wmv.Left, appobject.RaySix(4).wmv.Top, appobject.RaySix(4).wmv.Width, appobject.RaySix(4).wmv.Height)
        Btn5.SetBounds(appobject.RaySix(4).btn.Left, appobject.RaySix(4).btn.Top, appobject.RaySix(4).btn.Width, appobject.RaySix(4).btn.Height)
        AxWindowsMediaPlayer6.SetBounds(appobject.RaySix(5).wmv.Left, appobject.RaySix(5).wmv.Top, appobject.RaySix(5).wmv.Width, appobject.RaySix(5).wmv.Height)
        Btn6.SetBounds(appobject.RaySix(5).btn.Left, appobject.RaySix(5).btn.Top, appobject.RaySix(5).btn.Width, appobject.RaySix(5).btn.Height)
    End Sub

    Private Sub CoinFirstFrame()
        appobject.CoinIn()
        allFirst()
        End Sub

    Private Sub BillFirstFrame()
        appobject.BillIn()
        allFirst()
    End Sub

    Private Sub allFirst()
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        AxWindowsMediaPlayer2.Ctlcontrols.currentPosition = 0
        AxWindowsMediaPlayer2.Ctlcontrols.pause()
        AxWindowsMediaPlayer3.Ctlcontrols.currentPosition = 0
        AxWindowsMediaPlayer3.Ctlcontrols.pause()
        AxWindowsMediaPlayer4.Ctlcontrols.currentPosition = 0
        AxWindowsMediaPlayer4.Ctlcontrols.pause()
        AxWindowsMediaPlayer5.Ctlcontrols.currentPosition = 0
        AxWindowsMediaPlayer5.Ctlcontrols.pause()
        AxWindowsMediaPlayer6.Ctlcontrols.currentPosition = 0
        AxWindowsMediaPlayer6.Ctlcontrols.pause()
    End Sub

    Private Sub allContinue()
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer2.Ctlcontrols.play()
        AxWindowsMediaPlayer3.Ctlcontrols.play()
        AxWindowsMediaPlayer4.Ctlcontrols.play()
        AxWindowsMediaPlayer5.Ctlcontrols.play()
        AxWindowsMediaPlayer6.Ctlcontrols.play()
    End Sub

    Private Sub UdpTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UdpTimer.Tick
        If String.IsNullOrEmpty(appobject.ReceiveBytes) = False Then
            Dim intrec As Integer
            If appobject.ReceiveBytes = "100" Then
                If appobject.MoneyAvailable = 0 Then
                    BillFirstFrame()
                Else
                    appobject.BillInAgain()
                End If
                MoneyDepositTB.Text = appobject.MoneyAvailable
                DrawVerticalText(MoneyDepositTB.Text)
                Btn_Show()
                RotateTimer.Enabled = False
            ElseIf appobject.ReceiveBytes = "50" Then
                If appobject.MoneyAvailable = 0 Then
                    CoinFirstFrame()
                Else
                    appobject.CoinInAgain()
                End If
                MoneyDepositTB.Text = appobject.MoneyAvailable
                DrawVerticalText(MoneyDepositTB.Text)
                Btn_Show()
                RotateTimer.Enabled = False
            ElseIf appobject.ReceiveBytes.StartsWith("-") Then
                intrec = Integer.Parse(appobject.ReceiveBytes)
                appobject.ReceiveBytes = String.Empty
                CalculateError(intrec)
            End If
        End If
    End Sub

    'Public Sub AutosizeImage(ByVal ImagePath As String, ByVal picBox As PictureBox, Optional ByVal pSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.CenterImage)
    '   Try
    '      picBox.Image = Nothing
    '     picBox.SizeMode = pSizeMode
    '    If System.IO.File.Exists(ImagePath) Then
    'Dim imgOrg As Bitmap
    'Dim imgShow As Bitmap
    'Dim g As Graphics
    'Dim divideBy, divideByH, divideByW As Double
    '           imgOrg = DirectCast(Bitmap.FromFile(ImagePath), Bitmap)

    '            divideByW = imgOrg.Width / picBox.Width
    '           divideByH = imgOrg.Height / picBox.Height
    '          If divideByW > 1 Or divideByH > 1 Then
    '             If divideByW > divideByH Then
    '                divideBy = divideByW
    '           Else
    '              divideBy = divideByH
    '         End If

    '               imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
    '                imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
    '               g = Graphics.FromImage(imgShow)
    '              g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    '            g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
    '             g.Dispose()
    '       Else
    '          imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
    '         imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
    '        g = Graphics.FromImage(imgShow)
    '       g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    '      g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
    '     g.Dispose()
    'End If
    'imgOrg.Dispose()

    '            picBox.Image = imgShow
    '       Else
    '          picBox.Image = Nothing
    '     End If


    '    Catch ex As Exception
    '       MsgBox(ex.ToString)
    '  End Try

    'End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim path As String = Application.StartupPath & "\" & list_Print(appobject.ProductNum - 1)
        'MsgBox(path)
        e.Graphics.DrawImage(New Bitmap(path), New Point(10, 10))
    End Sub

    Private Sub PageSetting()
        For n As Integer = 1 To 6 'For value As Integer = 1 To 10

            'Dim n As Integer = (Page - 1) * 10 + value
            'If (n > TotalNum) Then
            'Dim a As Integer = (n Mod 10)
            'For i As Integer = a To 10
            'Select Case i
            'Case 1
            'Pic_1.Image = Nothing
            'ProductName_1.Text = ""
            'Price1.Text = ""
            'Case 2
            'Pic_2.Image = Nothing
            'ProductName_2.Text = ""
            'Price2.Text = ""
            'Case 3
            'Pic_3.Image = Nothing
            'ProductName_3.Text = ""
            'Price3.Text = ""
            'Case 4
            'Pic_4.Image = Nothing
            'ProductName_4.Text = ""
            'Price4.Text = ""
            'Case 5
            'Pic_5.Image = Nothing
            'ProductName_5.Text = ""
            'Price5.Text = ""
            'Case 6
            'Pic_6.Image = Nothing
            'ProductName_6.Text = ""
            'Price6.Text = ""
            'Case 7
            '    Pic_7.Image = Nothing
            '    ProductName_7.Text = ""
            '    Price7.Text = ""
            'Case 8
            '    Pic_8.Image = Nothing
            '    ProductName_8.Text = ""
            '    Price8.Text = ""
            'Case 9
            '    Pic_9.Image = Nothing
            '    ProductName_9.Text = ""
            '    Price9.Text = ""
            'Case 10
            '    Pic_10.Image = Nothing
            '    ProductName_10.Text = ""
            '    Price10.Text = ""

            'End Select
            'Next
            'Exit For
            'End If

            RayStartCase(n, True)
        Next

    End Sub

    Private Sub RayStartCase(ByVal n As Integer, ByVal isPos As Boolean)
        Select Case n
            Case 1
                AxWindowsMediaPlayer1.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "1.wmv" 'Pic_1.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                AxWindowsMediaPlayer1.settings.setMode("loop", True)
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_1)
                'ProductName_1.Text = list_Name(n - 1)
                Price1.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.RaySix(0).wmv = New Rectangle(AxWindowsMediaPlayer1.Location.X, AxWindowsMediaPlayer1.Location.Y _
                                              , AxWindowsMediaPlayer1.Size.Width, AxWindowsMediaPlayer1.Size.Height)
                    appobject.RaySix(0).btn = New Rectangle(Btn1.Location.X, Btn1.Location.Y _
                                              , Btn1.Size.Width, Btn1.Size.Height)
                End If
            Case 2
                AxWindowsMediaPlayer2.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "2.wmv"
                AxWindowsMediaPlayer2.settings.setMode("loop", True)
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_2)
                'ProductName_2.Text = list_Name(n - 1)
                Price2.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.RaySix(1).wmv = New Rectangle(AxWindowsMediaPlayer2.Location.X, AxWindowsMediaPlayer2.Location.Y _
                                              , AxWindowsMediaPlayer2.Size.Width, AxWindowsMediaPlayer2.Size.Height)
                    appobject.RaySix(1).btn = New Rectangle(Btn2.Location.X, Btn2.Location.Y _
                                              , Btn2.Size.Width, Btn2.Size.Height)
                End If
            Case 3
                AxWindowsMediaPlayer3.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "3.wmv"
                AxWindowsMediaPlayer3.settings.setMode("loop", True)
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_3)
                'ProductName_3.Text = list_Name(n - 1)
                Price3.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.RaySix(2).wmv = New Rectangle(AxWindowsMediaPlayer3.Location.X, AxWindowsMediaPlayer3.Location.Y _
                                                             , AxWindowsMediaPlayer3.Size.Width, AxWindowsMediaPlayer3.Size.Height)
                    appobject.RaySix(2).btn = New Rectangle(Btn3.Location.X, Btn3.Location.Y _
                                                  , Btn3.Size.Width, Btn3.Size.Height)
                End If
            Case 4
                AxWindowsMediaPlayer4.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "4.wmv"
                AxWindowsMediaPlayer4.settings.setMode("loop", True)
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_4)
                'ProductName_4.Text = list_Name(n - 1)
                'Price4.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.RaySix(3).wmv = New Rectangle(AxWindowsMediaPlayer4.Location.X, AxWindowsMediaPlayer4.Location.Y _
                                                  , AxWindowsMediaPlayer4.Size.Width, AxWindowsMediaPlayer4.Size.Height)
                    appobject.RaySix(3).btn = New Rectangle(Btn4.Location.X, Btn4.Location.Y _
                                                  , Btn4.Size.Width, Btn4.Size.Height)
                End If
            Case 5
                AxWindowsMediaPlayer5.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "5.wmv"
                AxWindowsMediaPlayer5.settings.setMode("loop", True)
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_5)
                'ProductName_5.Text = list_Name(n - 1)
                Price5.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.RaySix(4).wmv = New Rectangle(AxWindowsMediaPlayer5.Location.X, AxWindowsMediaPlayer5.Location.Y _
                                                  , AxWindowsMediaPlayer5.Size.Width, AxWindowsMediaPlayer5.Size.Height)
                    appobject.RaySix(4).btn = New Rectangle(Btn5.Location.X, Btn5.Location.Y _
                                                  , Btn5.Size.Width, Btn5.Size.Height)
                End If
            Case 6
                AxWindowsMediaPlayer6.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "6.wmv"
                AxWindowsMediaPlayer6.settings.setMode("loop", True)
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_6)
                'ProductName_6.Text = list_Name(n - 1)
                Price6.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.RaySix(5).wmv = New Rectangle(AxWindowsMediaPlayer6.Location.X, AxWindowsMediaPlayer6.Location.Y _
                                                            , AxWindowsMediaPlayer6.Size.Width, AxWindowsMediaPlayer6.Size.Height)
                    appobject.RaySix(5).btn = New Rectangle(Btn6.Location.X, Btn6.Location.Y _
                                                  , Btn6.Size.Width, Btn6.Size.Height)
                End If
                'Case 7
                'Pic_7.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_7)
                'ProductName_7.Text = list_Name(n - 1)
                'Price7.Text = list_Price(n - 1)
                'Case 8
                'Pic_8.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_8)
                'ProductName_8.Text = list_Name(n - 1)
                'Price8.Text = list_Price(n - 1)
                'Case 9
                'Pic_9.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_9)
                'ProductName_9.Text = list_Name(n - 1)
                'Price9.Text = list_Price(n - 1)
                'Case 10
                'Pic_10.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_10)
                'ProductName_10.Text = list_Name(n - 1)
                'Price10.Text = list_Price(n - 1)

        End Select
    End Sub


    'Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Page = Page + 1

    'If (Math.Ceiling(TotalNum / 10) > Page) Then
    'btn_next.Visible = True
    'Else
    'btn_next.Visible = False
    'End If

    'If (Page > 1) Then
    'btn_pre.Visible = True
    'Else
    'btn_pre.Visible = False
    'End If

    'PageSetting()
    'End Sub

    'Private Sub btn_pre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Page = Page - 1

    'If (Math.Ceiling(TotalNum / 10) > Page) Then
    'btn_next.Visible = True
    'Else
    'btn_next.Visible = False
    'End If

    'If (Page > 1) Then
    'btn_pre.Visible = True
    'Else
    'btn_pre.Visible = False
    'End If

    'PageSetting()
    'End Sub

    Private Sub CalculateError(ByVal money As Integer)
        oweMoney = Math.Abs(money)
        'PrintDialog1.Document = PrintError
        'If PrintDialog1.ShowDialog() = DialogResult.OK Then
        PrintError.Print()
        'End If
        MsgTimer.Enabled = True
        MessageBox.Show("販賣機餘額不足，請領取收據至櫃檯兌換找零" & oweMoney & "元。", "餘額不足", MessageBoxButtons.OK)
    End Sub

    Private Sub MsgTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgTimer.Tick

        Dim hWnd As Integer
        hWnd = FindWindow(vbNullString, "餘額不足")
        If hWnd <> 0 Then
            PostMessage(hWnd, &H10, 0, 0)
        End If

        oweMoney = 0
        MsgTimer.Enabled = False

    End Sub

    Private Sub PrintError_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintError.PrintPage
        'e.Graphics.DrawImage(New Bitmap(path), New Point(0, 0))
        Dim dateFont As New Font("Arial", 8)
        Dim prtFont As New Font("微軟正黑體", 12)

        'Time Location
        Dim right As Single = e.MarginBounds.Right - 80
        Dim top As Single = 50

        ' Create rectangle for drawing.
        Dim x As Single = 20
        Dim y As Single = 70
        Dim width As Single = e.MarginBounds.Height
        Dim height As Single = e.MarginBounds.Width
        Dim drawRect As New RectangleF(x, y, width, height)

        ' Set format of string.
        Dim drawFormat As New StringFormat
        drawFormat.Alignment = StringAlignment.Near

        Dim dtNow As Date = Now()
        Dim content As String = "很抱歉，販賣機內零錢餘額" & Chr(13) & Chr(10) & _
        "不足。請持本收據至噪咖櫃" & Chr(13) & Chr(10) & _
        "檯兌換找零" & oweMoney & "元" & Chr(13) & Chr(10) & " " & Chr(13) & Chr(10) & " " & Chr(13) & Chr(10) & " "

        e.Graphics.DrawImage(New Bitmap(Application.StartupPath & "\noiseKitchenKNT.jpg"), New Point(10, 10))
        e.Graphics.DrawString(dtNow.ToLocalTime().ToString(), dateFont, Brushes.Black, right, top)
        e.Graphics.DrawString(content, prtFont, Brushes.Black, drawRect, drawFormat)
        'e.Graphics.DrawImage(New Bitmap(Application.StartupPath & "\white.JPG"), New Point(10, 150))

    End Sub

    Private Sub DrawVerticalText(ByVal drawString As String)
        Dim xx As Single = -150
        Dim yy As Single = -150
        If formGraphics Is Nothing Then
            formGraphics = Me.CreateGraphics
            formGraphics.RotateTransform(180.0F)
            drawFont = New System.Drawing.Font("Arial", 32)
            drawBrush = New System.Drawing.SolidBrush(System.Drawing.Color.Black)
            drawFormat = New System.Drawing.StringFormat(StringFormatFlags.DirectionVertical)
        End If
        drawString = "$" & drawString
        formGraphics.FillRectangle(Brushes.White, xx, yy, 40, 120)
        formGraphics.DrawString(drawString, drawFont, drawBrush, xx, yy, drawFormat)
        'drawFont.Dispose()
        'drawBrush.Dispose()
        'formGraphics.Dispose()

    End Sub

End Class
