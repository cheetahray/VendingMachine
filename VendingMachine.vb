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
    Friend WithEvents Price2 As System.Windows.Forms.Label
    Friend WithEvents Price3 As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer0 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerA_1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerA_2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerA_3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerA_4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerA_5 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerA_6 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerB_1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerB_2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerB_3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerB_4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerB_5 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerB_6 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerC_1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerC_2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerC_3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerC_4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerC_5 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerC_6 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerD_1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerD_2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerD_3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerD_4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerD_5 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerD_6 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerE_1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerE_2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerE_3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerE_4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerE_5 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerE_6 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerF_1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerF_2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerF_3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerF_4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerF_5 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayerF_6 As AxWMPLib.AxWindowsMediaPlayer
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
    Friend WithEvents ProductName_6 As System.Windows.Forms.Label
    Friend WithEvents ProductName_5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PIC_3 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents PIC_2 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents PIC_1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents PIC_6 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents PIC_5 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents PIC_4 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn4 As System.Windows.Forms.Button
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
        Me.ProductName_6 = New System.Windows.Forms.Label()
        Me.ProductName_5 = New System.Windows.Forms.Label()
        Me.ProductName_4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PIC_3 = New System.Windows.Forms.PictureBox()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.PIC_2 = New System.Windows.Forms.PictureBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.PIC_1 = New System.Windows.Forms.PictureBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.PIC_6 = New System.Windows.Forms.PictureBox()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.PIC_5 = New System.Windows.Forms.PictureBox()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.PIC_4 = New System.Windows.Forms.PictureBox()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayerA_1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerA_2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerA_3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerA_4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerA_5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerA_6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerB_1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerB_2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerB_3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerB_4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerB_5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerB_6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerC_1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerC_2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerC_3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerC_4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerC_5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerC_6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerD_1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerD_2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerD_3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerD_4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerD_5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerD_6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerE_1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerE_2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerE_3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerE_4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerE_5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerE_6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerF_1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerF_2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerF_3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerF_4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerF_5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayerF_6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer0 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.picOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerA_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerA_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerA_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerA_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerA_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerA_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerB_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerB_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerB_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerB_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerB_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerB_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerC_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerC_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerC_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerC_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerC_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerC_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerD_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerD_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerD_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerD_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerD_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerD_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerE_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerE_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerE_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerE_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerE_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerE_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerF_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerF_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerF_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerF_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerF_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayerF_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer0, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1024, 768)
        Me.PictureBox1.TabIndex = 1003
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PIC_3
        '
        Me.PIC_3.Location = New System.Drawing.Point(79, 65)
        Me.PIC_3.Name = "PIC_3"
        Me.PIC_3.Size = New System.Drawing.Size(456, 256)
        Me.PIC_3.TabIndex = 1004
        Me.PIC_3.TabStop = False
        Me.PIC_3.Visible = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn3.Location = New System.Drawing.Point(409, 130)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(50, 123)
        Me.Btn3.TabIndex = 1005
        Me.Btn3.UseVisualStyleBackColor = False
        Me.Btn3.Visible = False
        '
        'PIC_2
        '
        Me.PIC_2.Location = New System.Drawing.Point(79, 300)
        Me.PIC_2.Name = "PIC_2"
        Me.PIC_2.Size = New System.Drawing.Size(456, 256)
        Me.PIC_2.TabIndex = 1006
        Me.PIC_2.TabStop = False
        Me.PIC_2.Visible = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn2.Location = New System.Drawing.Point(409, 366)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(50, 123)
        Me.Btn2.TabIndex = 1007
        Me.Btn2.UseVisualStyleBackColor = False
        Me.Btn2.Visible = False
        '
        'PIC_1
        '
        Me.PIC_1.Location = New System.Drawing.Point(79, 535)
        Me.PIC_1.Name = "PIC_1"
        Me.PIC_1.Size = New System.Drawing.Size(456, 256)
        Me.PIC_1.TabIndex = 1008
        Me.PIC_1.TabStop = False
        Me.PIC_1.Visible = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.Location = New System.Drawing.Point(409, 605)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(50, 122)
        Me.Btn1.TabIndex = 1009
        Me.Btn1.UseVisualStyleBackColor = False
        Me.Btn1.Visible = False
        '
        'PIC_6
        '
        Me.PIC_6.Location = New System.Drawing.Point(563, 65)
        Me.PIC_6.Name = "PIC_6"
        Me.PIC_6.Size = New System.Drawing.Size(456, 256)
        Me.PIC_6.TabIndex = 1010
        Me.PIC_6.TabStop = False
        Me.PIC_6.Visible = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn6.Location = New System.Drawing.Point(892, 130)
        Me.Btn6.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(52, 124)
        Me.Btn6.TabIndex = 1011
        Me.Btn6.UseVisualStyleBackColor = False
        Me.Btn6.Visible = False
        '
        'PIC_5
        '
        Me.PIC_5.Location = New System.Drawing.Point(563, 300)
        Me.PIC_5.Name = "PIC_5"
        Me.PIC_5.Size = New System.Drawing.Size(456, 256)
        Me.PIC_5.TabIndex = 1012
        Me.PIC_5.TabStop = False
        Me.PIC_5.Visible = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn5.Location = New System.Drawing.Point(892, 366)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(53, 123)
        Me.Btn5.TabIndex = 1013
        Me.Btn5.UseVisualStyleBackColor = False
        Me.Btn5.Visible = False
        '
        'PIC_4
        '
        Me.PIC_4.Location = New System.Drawing.Point(563, 535)
        Me.PIC_4.Name = "PIC_4"
        Me.PIC_4.Size = New System.Drawing.Size(456, 256)
        Me.PIC_4.TabIndex = 1014
        Me.PIC_4.TabStop = False
        Me.PIC_4.Visible = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn4.Location = New System.Drawing.Point(892, 605)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(52, 122)
        Me.Btn4.TabIndex = 1015
        Me.Btn4.UseVisualStyleBackColor = False
        Me.Btn4.Visible = False
        '
        'AxWindowsMediaPlayerA_1
        '
        Me.AxWindowsMediaPlayerA_1.Enabled = True
        Me.AxWindowsMediaPlayerA_1.Location = New System.Drawing.Point(79, 535)
        Me.AxWindowsMediaPlayerA_1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerA_1.Name = "AxWindowsMediaPlayerA_1"
        Me.AxWindowsMediaPlayerA_1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerA_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerA_1.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerA_1.TabIndex = 1000
        Me.AxWindowsMediaPlayerA_1.TabStop = False
        '
        'AxWindowsMediaPlayerA_2
        '
        Me.AxWindowsMediaPlayerA_2.Enabled = True
        Me.AxWindowsMediaPlayerA_2.Location = New System.Drawing.Point(79, 300)
        Me.AxWindowsMediaPlayerA_2.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerA_2.Name = "AxWindowsMediaPlayerA_2"
        Me.AxWindowsMediaPlayerA_2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerA_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerA_2.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerA_2.TabIndex = 1000
        Me.AxWindowsMediaPlayerA_2.TabStop = False
        '
        'AxWindowsMediaPlayerA_3
        '
        Me.AxWindowsMediaPlayerA_3.Enabled = True
        Me.AxWindowsMediaPlayerA_3.Location = New System.Drawing.Point(79, 65)
        Me.AxWindowsMediaPlayerA_3.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerA_3.Name = "AxWindowsMediaPlayerA_3"
        Me.AxWindowsMediaPlayerA_3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerA_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerA_3.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerA_3.TabIndex = 1000
        Me.AxWindowsMediaPlayerA_3.TabStop = False
        '
        'AxWindowsMediaPlayerA_4
        '
        Me.AxWindowsMediaPlayerA_4.Enabled = True
        Me.AxWindowsMediaPlayerA_4.Location = New System.Drawing.Point(563, 535)
        Me.AxWindowsMediaPlayerA_4.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerA_4.Name = "AxWindowsMediaPlayerA_4"
        Me.AxWindowsMediaPlayerA_4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerA_4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerA_4.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerA_4.TabIndex = 1000
        Me.AxWindowsMediaPlayerA_4.TabStop = False
        '
        'AxWindowsMediaPlayerA_5
        '
        Me.AxWindowsMediaPlayerA_5.Enabled = True
        Me.AxWindowsMediaPlayerA_5.Location = New System.Drawing.Point(563, 300)
        Me.AxWindowsMediaPlayerA_5.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerA_5.Name = "AxWindowsMediaPlayerA_5"
        Me.AxWindowsMediaPlayerA_5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerA_5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerA_5.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerA_5.TabIndex = 1000
        Me.AxWindowsMediaPlayerA_5.TabStop = False
        '
        'AxWindowsMediaPlayerA_6
        '
        Me.AxWindowsMediaPlayerA_6.Enabled = True
        Me.AxWindowsMediaPlayerA_6.Location = New System.Drawing.Point(563, 65)
        Me.AxWindowsMediaPlayerA_6.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerA_6.Name = "AxWindowsMediaPlayerA_6"
        Me.AxWindowsMediaPlayerA_6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerA_6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerA_6.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerA_6.TabIndex = 1000
        Me.AxWindowsMediaPlayerA_6.TabStop = False
        '
        'AxWindowsMediaPlayerB_1
        '
        Me.AxWindowsMediaPlayerB_1.Enabled = True
        Me.AxWindowsMediaPlayerB_1.Location = New System.Drawing.Point(79, 535)
        Me.AxWindowsMediaPlayerB_1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerB_1.Name = "AxWindowsMediaPlayerB_1"
        Me.AxWindowsMediaPlayerB_1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerB_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerB_1.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerB_1.TabIndex = 1000
        Me.AxWindowsMediaPlayerB_1.TabStop = False
        '
        'AxWindowsMediaPlayerB_2
        '
        Me.AxWindowsMediaPlayerB_2.Enabled = True
        Me.AxWindowsMediaPlayerB_2.Location = New System.Drawing.Point(79, 300)
        Me.AxWindowsMediaPlayerB_2.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerB_2.Name = "AxWindowsMediaPlayerB_2"
        Me.AxWindowsMediaPlayerB_2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerB_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerB_2.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerB_2.TabIndex = 1000
        Me.AxWindowsMediaPlayerB_2.TabStop = False
        '
        'AxWindowsMediaPlayerB_3
        '
        Me.AxWindowsMediaPlayerB_3.Enabled = True
        Me.AxWindowsMediaPlayerB_3.Location = New System.Drawing.Point(79, 65)
        Me.AxWindowsMediaPlayerB_3.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerB_3.Name = "AxWindowsMediaPlayerB_3"
        Me.AxWindowsMediaPlayerB_3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerB_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerB_3.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerB_3.TabIndex = 1000
        Me.AxWindowsMediaPlayerB_3.TabStop = False
        '
        'AxWindowsMediaPlayerB_4
        '
        Me.AxWindowsMediaPlayerB_4.Enabled = True
        Me.AxWindowsMediaPlayerB_4.Location = New System.Drawing.Point(563, 535)
        Me.AxWindowsMediaPlayerB_4.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerB_4.Name = "AxWindowsMediaPlayerB_4"
        Me.AxWindowsMediaPlayerB_4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerB_4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerB_4.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerB_4.TabIndex = 1000
        Me.AxWindowsMediaPlayerB_4.TabStop = False
        '
        'AxWindowsMediaPlayerB_5
        '
        Me.AxWindowsMediaPlayerB_5.Enabled = True
        Me.AxWindowsMediaPlayerB_5.Location = New System.Drawing.Point(563, 300)
        Me.AxWindowsMediaPlayerB_5.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerB_5.Name = "AxWindowsMediaPlayerB_5"
        Me.AxWindowsMediaPlayerB_5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerB_5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerB_5.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerB_5.TabIndex = 1000
        Me.AxWindowsMediaPlayerB_5.TabStop = False
        '
        'AxWindowsMediaPlayerB_6
        '
        Me.AxWindowsMediaPlayerB_6.Enabled = True
        Me.AxWindowsMediaPlayerB_6.Location = New System.Drawing.Point(563, 65)
        Me.AxWindowsMediaPlayerB_6.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerB_6.Name = "AxWindowsMediaPlayerB_6"
        Me.AxWindowsMediaPlayerB_6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerB_6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerB_6.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerB_6.TabIndex = 1000
        Me.AxWindowsMediaPlayerB_6.TabStop = False
        '
        'AxWindowsMediaPlayerC_1
        '
        Me.AxWindowsMediaPlayerC_1.Enabled = True
        Me.AxWindowsMediaPlayerC_1.Location = New System.Drawing.Point(79, 535)
        Me.AxWindowsMediaPlayerC_1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerC_1.Name = "AxWindowsMediaPlayerC_1"
        Me.AxWindowsMediaPlayerC_1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerC_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerC_1.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerC_1.TabIndex = 1000
        Me.AxWindowsMediaPlayerC_1.TabStop = False
        '
        'AxWindowsMediaPlayerC_2
        '
        Me.AxWindowsMediaPlayerC_2.Enabled = True
        Me.AxWindowsMediaPlayerC_2.Location = New System.Drawing.Point(79, 300)
        Me.AxWindowsMediaPlayerC_2.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerC_2.Name = "AxWindowsMediaPlayerC_2"
        Me.AxWindowsMediaPlayerC_2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerC_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerC_2.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerC_2.TabIndex = 1000
        Me.AxWindowsMediaPlayerC_2.TabStop = False
        '
        'AxWindowsMediaPlayerC_3
        '
        Me.AxWindowsMediaPlayerC_3.Enabled = True
        Me.AxWindowsMediaPlayerC_3.Location = New System.Drawing.Point(79, 65)
        Me.AxWindowsMediaPlayerC_3.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerC_3.Name = "AxWindowsMediaPlayerC_3"
        Me.AxWindowsMediaPlayerC_3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerC_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerC_3.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerC_3.TabIndex = 1000
        Me.AxWindowsMediaPlayerC_3.TabStop = False
        '
        'AxWindowsMediaPlayerC_4
        '
        Me.AxWindowsMediaPlayerC_4.Enabled = True
        Me.AxWindowsMediaPlayerC_4.Location = New System.Drawing.Point(563, 535)
        Me.AxWindowsMediaPlayerC_4.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerC_4.Name = "AxWindowsMediaPlayerC_4"
        Me.AxWindowsMediaPlayerC_4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerC_4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerC_4.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerC_4.TabIndex = 1000
        Me.AxWindowsMediaPlayerC_4.TabStop = False
        '
        'AxWindowsMediaPlayerC_5
        '
        Me.AxWindowsMediaPlayerC_5.Enabled = True
        Me.AxWindowsMediaPlayerC_5.Location = New System.Drawing.Point(563, 300)
        Me.AxWindowsMediaPlayerC_5.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerC_5.Name = "AxWindowsMediaPlayerC_5"
        Me.AxWindowsMediaPlayerC_5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerC_5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerC_5.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerC_5.TabIndex = 1000
        Me.AxWindowsMediaPlayerC_5.TabStop = False
        '
        'AxWindowsMediaPlayerC_6
        '
        Me.AxWindowsMediaPlayerC_6.Enabled = True
        Me.AxWindowsMediaPlayerC_6.Location = New System.Drawing.Point(563, 65)
        Me.AxWindowsMediaPlayerC_6.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerC_6.Name = "AxWindowsMediaPlayerC_6"
        Me.AxWindowsMediaPlayerC_6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerC_6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerC_6.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerC_6.TabIndex = 1000
        Me.AxWindowsMediaPlayerC_6.TabStop = False
        '
        'AxWindowsMediaPlayerD_1
        '
        Me.AxWindowsMediaPlayerD_1.Enabled = True
        Me.AxWindowsMediaPlayerD_1.Location = New System.Drawing.Point(79, 535)
        Me.AxWindowsMediaPlayerD_1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerD_1.Name = "AxWindowsMediaPlayerD_1"
        Me.AxWindowsMediaPlayerD_1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerD_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerD_1.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerD_1.TabIndex = 1000
        Me.AxWindowsMediaPlayerD_1.TabStop = False
        '
        'AxWindowsMediaPlayerD_2
        '
        Me.AxWindowsMediaPlayerD_2.Enabled = True
        Me.AxWindowsMediaPlayerD_2.Location = New System.Drawing.Point(79, 300)
        Me.AxWindowsMediaPlayerD_2.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerD_2.Name = "AxWindowsMediaPlayerD_2"
        Me.AxWindowsMediaPlayerD_2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerD_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerD_2.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerD_2.TabIndex = 1000
        Me.AxWindowsMediaPlayerD_2.TabStop = False
        '
        'AxWindowsMediaPlayerD_3
        '
        Me.AxWindowsMediaPlayerD_3.Enabled = True
        Me.AxWindowsMediaPlayerD_3.Location = New System.Drawing.Point(79, 65)
        Me.AxWindowsMediaPlayerD_3.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerD_3.Name = "AxWindowsMediaPlayerD_3"
        Me.AxWindowsMediaPlayerD_3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerD_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerD_3.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerD_3.TabIndex = 1000
        Me.AxWindowsMediaPlayerD_3.TabStop = False
        '
        'AxWindowsMediaPlayerD_4
        '
        Me.AxWindowsMediaPlayerD_4.Enabled = True
        Me.AxWindowsMediaPlayerD_4.Location = New System.Drawing.Point(563, 535)
        Me.AxWindowsMediaPlayerD_4.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerD_4.Name = "AxWindowsMediaPlayerD_4"
        Me.AxWindowsMediaPlayerD_4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerD_4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerD_4.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerD_4.TabIndex = 1000
        Me.AxWindowsMediaPlayerD_4.TabStop = False
        '
        'AxWindowsMediaPlayerD_5
        '
        Me.AxWindowsMediaPlayerD_5.Enabled = True
        Me.AxWindowsMediaPlayerD_5.Location = New System.Drawing.Point(563, 300)
        Me.AxWindowsMediaPlayerD_5.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerD_5.Name = "AxWindowsMediaPlayerD_5"
        Me.AxWindowsMediaPlayerD_5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerD_5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerD_5.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerD_5.TabIndex = 1000
        Me.AxWindowsMediaPlayerD_5.TabStop = False
        '
        'AxWindowsMediaPlayerD_6
        '
        Me.AxWindowsMediaPlayerD_6.Enabled = True
        Me.AxWindowsMediaPlayerD_6.Location = New System.Drawing.Point(563, 65)
        Me.AxWindowsMediaPlayerD_6.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerD_6.Name = "AxWindowsMediaPlayerD_6"
        Me.AxWindowsMediaPlayerD_6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerD_6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerD_6.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerD_6.TabIndex = 1000
        Me.AxWindowsMediaPlayerD_6.TabStop = False
        '
        'AxWindowsMediaPlayerE_1
        '
        Me.AxWindowsMediaPlayerE_1.Enabled = True
        Me.AxWindowsMediaPlayerE_1.Location = New System.Drawing.Point(79, 535)
        Me.AxWindowsMediaPlayerE_1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerE_1.Name = "AxWindowsMediaPlayerE_1"
        Me.AxWindowsMediaPlayerE_1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerE_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerE_1.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerE_1.TabIndex = 1000
        Me.AxWindowsMediaPlayerE_1.TabStop = False
        '
        'AxWindowsMediaPlayerE_2
        '
        Me.AxWindowsMediaPlayerE_2.Enabled = True
        Me.AxWindowsMediaPlayerE_2.Location = New System.Drawing.Point(79, 300)
        Me.AxWindowsMediaPlayerE_2.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerE_2.Name = "AxWindowsMediaPlayerE_2"
        Me.AxWindowsMediaPlayerE_2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerE_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerE_2.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerE_2.TabIndex = 1000
        Me.AxWindowsMediaPlayerE_2.TabStop = False
        '
        'AxWindowsMediaPlayerE_3
        '
        Me.AxWindowsMediaPlayerE_3.Enabled = True
        Me.AxWindowsMediaPlayerE_3.Location = New System.Drawing.Point(79, 65)
        Me.AxWindowsMediaPlayerE_3.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerE_3.Name = "AxWindowsMediaPlayerE_3"
        Me.AxWindowsMediaPlayerE_3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerE_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerE_3.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerE_3.TabIndex = 1000
        Me.AxWindowsMediaPlayerE_3.TabStop = False
        '
        'AxWindowsMediaPlayerE_4
        '
        Me.AxWindowsMediaPlayerE_4.Enabled = True
        Me.AxWindowsMediaPlayerE_4.Location = New System.Drawing.Point(563, 535)
        Me.AxWindowsMediaPlayerE_4.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerE_4.Name = "AxWindowsMediaPlayerE_4"
        Me.AxWindowsMediaPlayerE_4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerE_4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerE_4.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerE_4.TabIndex = 1000
        Me.AxWindowsMediaPlayerE_4.TabStop = False
        '
        'AxWindowsMediaPlayerE_5
        '
        Me.AxWindowsMediaPlayerE_5.Enabled = True
        Me.AxWindowsMediaPlayerE_5.Location = New System.Drawing.Point(563, 300)
        Me.AxWindowsMediaPlayerE_5.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerE_5.Name = "AxWindowsMediaPlayerE_5"
        Me.AxWindowsMediaPlayerE_5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerE_5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerE_5.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerE_5.TabIndex = 1000
        Me.AxWindowsMediaPlayerE_5.TabStop = False
        '
        'AxWindowsMediaPlayerE_6
        '
        Me.AxWindowsMediaPlayerE_6.Enabled = True
        Me.AxWindowsMediaPlayerE_6.Location = New System.Drawing.Point(563, 65)
        Me.AxWindowsMediaPlayerE_6.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerE_6.Name = "AxWindowsMediaPlayerE_6"
        Me.AxWindowsMediaPlayerE_6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerE_6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerE_6.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerE_6.TabIndex = 1000
        Me.AxWindowsMediaPlayerE_6.TabStop = False
        '
        'AxWindowsMediaPlayerF_1
        '
        Me.AxWindowsMediaPlayerF_1.Enabled = True
        Me.AxWindowsMediaPlayerF_1.Location = New System.Drawing.Point(79, 535)
        Me.AxWindowsMediaPlayerF_1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerF_1.Name = "AxWindowsMediaPlayerF_1"
        Me.AxWindowsMediaPlayerF_1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerF_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerF_1.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerF_1.TabIndex = 1000
        Me.AxWindowsMediaPlayerF_1.TabStop = False
        '
        'AxWindowsMediaPlayerF_2
        '
        Me.AxWindowsMediaPlayerF_2.Enabled = True
        Me.AxWindowsMediaPlayerF_2.Location = New System.Drawing.Point(79, 300)
        Me.AxWindowsMediaPlayerF_2.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerF_2.Name = "AxWindowsMediaPlayerF_2"
        Me.AxWindowsMediaPlayerF_2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerF_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerF_2.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerF_2.TabIndex = 1000
        Me.AxWindowsMediaPlayerF_2.TabStop = False
        '
        'AxWindowsMediaPlayerF_3
        '
        Me.AxWindowsMediaPlayerF_3.Enabled = True
        Me.AxWindowsMediaPlayerF_3.Location = New System.Drawing.Point(79, 65)
        Me.AxWindowsMediaPlayerF_3.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerF_3.Name = "AxWindowsMediaPlayerF_3"
        Me.AxWindowsMediaPlayerF_3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerF_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerF_3.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerF_3.TabIndex = 1000
        Me.AxWindowsMediaPlayerF_3.TabStop = False
        '
        'AxWindowsMediaPlayerF_4
        '
        Me.AxWindowsMediaPlayerF_4.Enabled = True
        Me.AxWindowsMediaPlayerF_4.Location = New System.Drawing.Point(563, 535)
        Me.AxWindowsMediaPlayerF_4.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerF_4.Name = "AxWindowsMediaPlayerF_4"
        Me.AxWindowsMediaPlayerF_4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerF_4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerF_4.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerF_4.TabIndex = 1000
        Me.AxWindowsMediaPlayerF_4.TabStop = False
        '
        'AxWindowsMediaPlayerF_5
        '
        Me.AxWindowsMediaPlayerF_5.Enabled = True
        Me.AxWindowsMediaPlayerF_5.Location = New System.Drawing.Point(563, 300)
        Me.AxWindowsMediaPlayerF_5.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerF_5.Name = "AxWindowsMediaPlayerF_5"
        Me.AxWindowsMediaPlayerF_5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerF_5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerF_5.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerF_5.TabIndex = 1000
        Me.AxWindowsMediaPlayerF_5.TabStop = False
        '
        'AxWindowsMediaPlayerF_6
        '
        Me.AxWindowsMediaPlayerF_6.Enabled = True
        Me.AxWindowsMediaPlayerF_6.Location = New System.Drawing.Point(563, 65)
        Me.AxWindowsMediaPlayerF_6.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayerF_6.Name = "AxWindowsMediaPlayerF_6"
        Me.AxWindowsMediaPlayerF_6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerF_6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerF_6.Size = New System.Drawing.Size(456, 256)
        Me.AxWindowsMediaPlayerF_6.TabIndex = 1000
        Me.AxWindowsMediaPlayerF_6.TabStop = False
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
        'VendingMachine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.PIC_4)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.PIC_5)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.PIC_6)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.PIC_1)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.PIC_2)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.PIC_3)
        Me.Controls.Add(Me.Price3)
        Me.Controls.Add(Me.ProductName_3)
        Me.Controls.Add(Me.ProductName_2)
        Me.Controls.Add(Me.Price2)
        Me.Controls.Add(Me.Price4)
        Me.Controls.Add(Me.ProductName_1)
        Me.Controls.Add(Me.ProductName_4)
        Me.Controls.Add(Me.Price1)
        Me.Controls.Add(Me.ProductName_5)
        Me.Controls.Add(Me.Price5)
        Me.Controls.Add(Me.cboComPort)
        Me.Controls.Add(Me.ProductName_6)
        Me.Controls.Add(Me.Price6)
        Me.Controls.Add(Me.picOpen)
        Me.Controls.Add(Me.ChangeReturnBTN)
        Me.Controls.Add(Me.MoneyDepositTB)
        Me.Controls.Add(Me.MoneyReturnTB)
        Me.Controls.Add(Me.AxWindowsMediaPlayerA_1)
        Me.Controls.Add(Me.AxWindowsMediaPlayerA_2)
        Me.Controls.Add(Me.AxWindowsMediaPlayerA_3)
        Me.Controls.Add(Me.AxWindowsMediaPlayerA_4)
        Me.Controls.Add(Me.AxWindowsMediaPlayerA_5)
        Me.Controls.Add(Me.AxWindowsMediaPlayerA_6)
        Me.Controls.Add(Me.AxWindowsMediaPlayerB_1)
        Me.Controls.Add(Me.AxWindowsMediaPlayerB_2)
        Me.Controls.Add(Me.AxWindowsMediaPlayerB_3)
        Me.Controls.Add(Me.AxWindowsMediaPlayerB_4)
        Me.Controls.Add(Me.AxWindowsMediaPlayerB_5)
        Me.Controls.Add(Me.AxWindowsMediaPlayerB_6)
        Me.Controls.Add(Me.AxWindowsMediaPlayerC_1)
        Me.Controls.Add(Me.AxWindowsMediaPlayerC_2)
        Me.Controls.Add(Me.AxWindowsMediaPlayerC_3)
        Me.Controls.Add(Me.AxWindowsMediaPlayerC_4)
        Me.Controls.Add(Me.AxWindowsMediaPlayerC_5)
        Me.Controls.Add(Me.AxWindowsMediaPlayerC_6)
        Me.Controls.Add(Me.AxWindowsMediaPlayerD_1)
        Me.Controls.Add(Me.AxWindowsMediaPlayerD_2)
        Me.Controls.Add(Me.AxWindowsMediaPlayerD_3)
        Me.Controls.Add(Me.AxWindowsMediaPlayerD_4)
        Me.Controls.Add(Me.AxWindowsMediaPlayerD_5)
        Me.Controls.Add(Me.AxWindowsMediaPlayerD_6)
        Me.Controls.Add(Me.AxWindowsMediaPlayerE_1)
        Me.Controls.Add(Me.AxWindowsMediaPlayerE_2)
        Me.Controls.Add(Me.AxWindowsMediaPlayerE_3)
        Me.Controls.Add(Me.AxWindowsMediaPlayerE_4)
        Me.Controls.Add(Me.AxWindowsMediaPlayerE_5)
        Me.Controls.Add(Me.AxWindowsMediaPlayerE_6)
        Me.Controls.Add(Me.AxWindowsMediaPlayerF_1)
        Me.Controls.Add(Me.AxWindowsMediaPlayerF_2)
        Me.Controls.Add(Me.AxWindowsMediaPlayerF_3)
        Me.Controls.Add(Me.AxWindowsMediaPlayerF_4)
        Me.Controls.Add(Me.AxWindowsMediaPlayerF_5)
        Me.Controls.Add(Me.AxWindowsMediaPlayerF_6)
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
        CType(Me.picOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerA_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerA_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerA_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerA_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerA_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerA_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerB_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerB_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerB_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerB_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerB_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerB_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerC_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerC_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerC_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerC_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerC_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerC_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerD_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerD_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerD_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerD_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerD_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerD_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerE_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerE_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerE_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerE_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerE_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerE_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerF_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerF_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerF_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerF_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerF_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayerF_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'form on load settings
    Private Sub VendingMachine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim screen As Screen

        ' We want to display a form on screen 1

        If (screen.AllScreens.Length = 2) Then
            screen = screen.AllScreens(1)

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

        For Each allcontrols As Control In Me.Controls
            allcontrols.Cursor.Hide() 'New Cursor(Application.StartupPath & "\blank.cur")
        Next
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

    Private Function checkPos(ByVal product As Integer) As Integer
        For ctr As Integer = 0 To 5
            If appobject.RayPos(ctr) = product Then
                Return ctr + 1
            End If
        Next
    End Function
    '買買買
    Private Sub PerformTransaction(ByVal ItemPrice As Decimal)

        appobject.ItemCost = ItemPrice
        appobject.Submit()

        If (appobject.ItemCost <= appobject.MoneyAvailable) Then

            'appobject.MoneyAvailable -= appobject.ItemCost 'Reduce MoneyAvailable after purchase
            MoneyDepositTB.Text = appobject.MoneyAvailable
            DrawVerticalText(MoneyDepositTB.Text)
            UdpTimer.Enabled = False

            Select Case appobject.ProductNum
                Case 1
                    Select Case checkPos(appobject.ProductNum)
                        Case 1
                            AxWindowsMediaPlayerA_1.settings.setMode("loop", False)
                            AxWindowsMediaPlayerA_1.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerA_1.Ctlcontrols.play()
                        Case 2
                            AxWindowsMediaPlayerA_2.settings.setMode("loop", False)
                            AxWindowsMediaPlayerA_2.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerA_2.Ctlcontrols.play()
                        Case 3
                            AxWindowsMediaPlayerA_3.settings.setMode("loop", False)
                            AxWindowsMediaPlayerA_3.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerA_3.Ctlcontrols.play()
                        Case 4
                            AxWindowsMediaPlayerA_4.settings.setMode("loop", False)
                            AxWindowsMediaPlayerA_4.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerA_4.Ctlcontrols.play()
                        Case 5
                            AxWindowsMediaPlayerA_5.settings.setMode("loop", False)
                            AxWindowsMediaPlayerA_5.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerA_5.Ctlcontrols.play()
                        Case 6
                            AxWindowsMediaPlayerA_6.settings.setMode("loop", False)
                            AxWindowsMediaPlayerA_6.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerA_6.Ctlcontrols.play()
                    End Select
                Case 2
                    Select Case checkPos(appobject.ProductNum)
                        Case 1
                            AxWindowsMediaPlayerB_1.settings.setMode("loop", False)
                            AxWindowsMediaPlayerB_1.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerB_1.Ctlcontrols.play()
                        Case 2
                            AxWindowsMediaPlayerB_2.settings.setMode("loop", False)
                            AxWindowsMediaPlayerB_2.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerB_2.Ctlcontrols.play()
                        Case 3
                            AxWindowsMediaPlayerB_3.settings.setMode("loop", False)
                            AxWindowsMediaPlayerB_3.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerB_3.Ctlcontrols.play()
                        Case 4
                            AxWindowsMediaPlayerB_4.settings.setMode("loop", False)
                            AxWindowsMediaPlayerB_4.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerB_4.Ctlcontrols.play()
                        Case 5
                            AxWindowsMediaPlayerB_5.settings.setMode("loop", False)
                            AxWindowsMediaPlayerB_5.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerB_5.Ctlcontrols.play()
                        Case 6
                            AxWindowsMediaPlayerB_6.settings.setMode("loop", False)
                            AxWindowsMediaPlayerB_6.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerB_6.Ctlcontrols.play()
                    End Select
                Case 3
                    Select Case checkPos(appobject.ProductNum)
                        Case 1
                            AxWindowsMediaPlayerC_1.settings.setMode("loop", False)
                            AxWindowsMediaPlayerC_1.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerC_1.Ctlcontrols.play()
                        Case 2
                            AxWindowsMediaPlayerC_2.settings.setMode("loop", False)
                            AxWindowsMediaPlayerC_2.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerC_2.Ctlcontrols.play()
                        Case 3
                            AxWindowsMediaPlayerC_3.settings.setMode("loop", False)
                            AxWindowsMediaPlayerC_3.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerC_3.Ctlcontrols.play()
                        Case 4
                            AxWindowsMediaPlayerC_4.settings.setMode("loop", False)
                            AxWindowsMediaPlayerC_4.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerC_4.Ctlcontrols.play()
                        Case 5
                            AxWindowsMediaPlayerC_5.settings.setMode("loop", False)
                            AxWindowsMediaPlayerC_5.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerC_5.Ctlcontrols.play()
                        Case 6
                            AxWindowsMediaPlayerC_6.settings.setMode("loop", False)
                            AxWindowsMediaPlayerC_6.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerC_6.Ctlcontrols.play()
                    End Select
                Case 4
                    Select Case checkPos(appobject.ProductNum)
                        Case 1
                            AxWindowsMediaPlayerD_1.settings.setMode("loop", False)
                            AxWindowsMediaPlayerD_1.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerD_1.Ctlcontrols.play()
                        Case 2
                            AxWindowsMediaPlayerD_2.settings.setMode("loop", False)
                            AxWindowsMediaPlayerD_2.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerD_2.Ctlcontrols.play()
                        Case 3
                            AxWindowsMediaPlayerD_3.settings.setMode("loop", False)
                            AxWindowsMediaPlayerD_3.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerD_3.Ctlcontrols.play()
                        Case 4
                            AxWindowsMediaPlayerD_4.settings.setMode("loop", False)
                            AxWindowsMediaPlayerD_4.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerD_4.Ctlcontrols.play()
                        Case 5
                            AxWindowsMediaPlayerD_5.settings.setMode("loop", False)
                            AxWindowsMediaPlayerD_5.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerD_5.Ctlcontrols.play()
                        Case 6
                            AxWindowsMediaPlayerD_6.settings.setMode("loop", False)
                            AxWindowsMediaPlayerD_6.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerD_6.Ctlcontrols.play()
                    End Select
                Case 5
                    Select Case checkPos(appobject.ProductNum)
                        Case 1
                            AxWindowsMediaPlayerE_1.settings.setMode("loop", False)
                            AxWindowsMediaPlayerE_1.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerE_1.Ctlcontrols.play()
                        Case 2
                            AxWindowsMediaPlayerE_2.settings.setMode("loop", False)
                            AxWindowsMediaPlayerE_2.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerE_2.Ctlcontrols.play()
                        Case 3
                            AxWindowsMediaPlayerE_3.settings.setMode("loop", False)
                            AxWindowsMediaPlayerE_3.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerE_3.Ctlcontrols.play()
                        Case 4
                            AxWindowsMediaPlayerE_4.settings.setMode("loop", False)
                            AxWindowsMediaPlayerE_4.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerE_4.Ctlcontrols.play()
                        Case 5
                            AxWindowsMediaPlayerE_5.settings.setMode("loop", False)
                            AxWindowsMediaPlayerE_5.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerE_5.Ctlcontrols.play()
                        Case 6
                            AxWindowsMediaPlayerE_6.settings.setMode("loop", False)
                            AxWindowsMediaPlayerE_6.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerE_6.Ctlcontrols.play()
                    End Select
                Case 6
                    Select Case checkPos(appobject.ProductNum)
                        Case 1
                            AxWindowsMediaPlayerF_1.settings.setMode("loop", False)
                            AxWindowsMediaPlayerF_1.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerF_1.Ctlcontrols.play()
                        Case 2
                            AxWindowsMediaPlayerF_2.settings.setMode("loop", False)
                            AxWindowsMediaPlayerF_2.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerF_2.Ctlcontrols.play()
                        Case 3
                            AxWindowsMediaPlayerF_3.settings.setMode("loop", False)
                            AxWindowsMediaPlayerF_3.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerF_3.Ctlcontrols.play()
                        Case 4
                            AxWindowsMediaPlayerF_4.settings.setMode("loop", False)
                            AxWindowsMediaPlayerF_4.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerF_4.Ctlcontrols.play()
                        Case 5
                            AxWindowsMediaPlayerF_5.settings.setMode("loop", False)
                            AxWindowsMediaPlayerF_5.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerF_5.Ctlcontrols.play()
                        Case 6
                            AxWindowsMediaPlayerF_6.settings.setMode("loop", False)
                            AxWindowsMediaPlayerF_6.URL = Application.StartupPath & "\" & list_Strike(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                            AxWindowsMediaPlayerF_6.Ctlcontrols.play()
                    End Select
            End Select

            Btn_Hide()

        End If 'ITEM COST

    End Sub

    Private Sub PrepareEndTransaction()

        Select Case appobject.ProductNum
            Case 1
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerA_1.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 2
                        AxWindowsMediaPlayerA_2.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 3
                        AxWindowsMediaPlayerA_3.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 4
                        AxWindowsMediaPlayerA_4.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 5
                        AxWindowsMediaPlayerA_5.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 6
                        AxWindowsMediaPlayerA_6.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                End Select
            Case 2
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerB_1.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 2
                        AxWindowsMediaPlayerB_2.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 3
                        AxWindowsMediaPlayerB_3.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 4
                        AxWindowsMediaPlayerB_4.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 5
                        AxWindowsMediaPlayerB_5.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 6
                        AxWindowsMediaPlayerB_6.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                End Select
            Case 3
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerC_1.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 2
                        AxWindowsMediaPlayerC_2.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 3
                        AxWindowsMediaPlayerC_3.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 4
                        AxWindowsMediaPlayerC_4.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 5
                        AxWindowsMediaPlayerC_5.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 6
                        AxWindowsMediaPlayerC_6.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                End Select
            Case 4
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerD_1.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 2
                        AxWindowsMediaPlayerD_2.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 3
                        AxWindowsMediaPlayerD_3.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 4
                        AxWindowsMediaPlayerD_4.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 5
                        AxWindowsMediaPlayerD_5.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 6
                        AxWindowsMediaPlayerD_6.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                End Select
            Case 5
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerE_1.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 2
                        AxWindowsMediaPlayerE_2.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 3
                        AxWindowsMediaPlayerE_3.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 4
                        AxWindowsMediaPlayerE_4.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 5
                        AxWindowsMediaPlayerE_5.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 6
                        AxWindowsMediaPlayerE_6.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                End Select
            Case 6
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerF_1.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "1.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 2
                        AxWindowsMediaPlayerF_2.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "2.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 3
                        AxWindowsMediaPlayerF_3.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "3.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 4
                        AxWindowsMediaPlayerF_4.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "4.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 5
                        AxWindowsMediaPlayerF_5.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "5.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                    Case 6
                        AxWindowsMediaPlayerF_6.URL = Application.StartupPath & "\" & list_Pic(appobject.ProductNum - 1) & "6.wmv" '& appobject.RayPos(appobject.ProductNum - 1) & ".wmv"
                End Select
        End Select

    End Sub

    Private Sub EndTransaction()

        Select Case appobject.ProductNum
            Case 1
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerA_1.settings.setMode("loop", True)
                        AxWindowsMediaPlayerA_1.Ctlcontrols.play()
                    Case 2
                        AxWindowsMediaPlayerA_2.settings.setMode("loop", True)
                        AxWindowsMediaPlayerA_2.Ctlcontrols.play()
                    Case 3
                        AxWindowsMediaPlayerA_3.settings.setMode("loop", True)
                        AxWindowsMediaPlayerA_3.Ctlcontrols.play()
                    Case 4
                        AxWindowsMediaPlayerA_4.settings.setMode("loop", True)
                        AxWindowsMediaPlayerA_4.Ctlcontrols.play()
                    Case 5
                        AxWindowsMediaPlayerA_5.settings.setMode("loop", True)
                        AxWindowsMediaPlayerA_5.Ctlcontrols.play()
                    Case 6
                        AxWindowsMediaPlayerA_6.settings.setMode("loop", True)
                        AxWindowsMediaPlayerA_6.Ctlcontrols.play()
                End Select
            Case 2
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerB_1.settings.setMode("loop", True)
                        AxWindowsMediaPlayerB_1.Ctlcontrols.play()
                    Case 2
                        AxWindowsMediaPlayerB_2.settings.setMode("loop", True)
                        AxWindowsMediaPlayerB_2.Ctlcontrols.play()
                    Case 3
                        AxWindowsMediaPlayerB_3.settings.setMode("loop", True)
                        AxWindowsMediaPlayerB_3.Ctlcontrols.play()
                    Case 4
                        AxWindowsMediaPlayerB_4.settings.setMode("loop", True)
                        AxWindowsMediaPlayerB_4.Ctlcontrols.play()
                    Case 5
                        AxWindowsMediaPlayerB_5.settings.setMode("loop", True)
                        AxWindowsMediaPlayerB_5.Ctlcontrols.play()
                    Case 6
                        AxWindowsMediaPlayerB_6.settings.setMode("loop", True)
                        AxWindowsMediaPlayerB_6.Ctlcontrols.play()
                End Select
            Case 3
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerC_1.settings.setMode("loop", True)
                        AxWindowsMediaPlayerC_1.Ctlcontrols.play()
                    Case 2
                        AxWindowsMediaPlayerC_2.settings.setMode("loop", True)
                        AxWindowsMediaPlayerC_2.Ctlcontrols.play()
                    Case 3
                        AxWindowsMediaPlayerC_3.settings.setMode("loop", True)
                        AxWindowsMediaPlayerC_3.Ctlcontrols.play()
                    Case 4
                        AxWindowsMediaPlayerC_4.settings.setMode("loop", True)
                        AxWindowsMediaPlayerC_4.Ctlcontrols.play()
                    Case 5
                        AxWindowsMediaPlayerC_5.settings.setMode("loop", True)
                        AxWindowsMediaPlayerC_5.Ctlcontrols.play()
                    Case 6
                        AxWindowsMediaPlayerC_6.settings.setMode("loop", True)
                        AxWindowsMediaPlayerC_6.Ctlcontrols.play()
                End Select
            Case 4
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerD_1.settings.setMode("loop", True)
                        AxWindowsMediaPlayerD_1.Ctlcontrols.play()
                    Case 2
                        AxWindowsMediaPlayerD_2.settings.setMode("loop", True)
                        AxWindowsMediaPlayerD_2.Ctlcontrols.play()
                    Case 3
                        AxWindowsMediaPlayerD_3.settings.setMode("loop", True)
                        AxWindowsMediaPlayerD_3.Ctlcontrols.play()
                    Case 4
                        AxWindowsMediaPlayerD_4.settings.setMode("loop", True)
                        AxWindowsMediaPlayerD_4.Ctlcontrols.play()
                    Case 5
                        AxWindowsMediaPlayerD_5.settings.setMode("loop", True)
                        AxWindowsMediaPlayerD_5.Ctlcontrols.play()
                    Case 6
                        AxWindowsMediaPlayerD_6.settings.setMode("loop", True)
                        AxWindowsMediaPlayerD_6.Ctlcontrols.play()
                End Select
            Case 5
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerE_1.settings.setMode("loop", True)
                        AxWindowsMediaPlayerE_1.Ctlcontrols.play()
                    Case 2
                        AxWindowsMediaPlayerE_2.settings.setMode("loop", True)
                        AxWindowsMediaPlayerE_2.Ctlcontrols.play()
                    Case 3
                        AxWindowsMediaPlayerE_3.settings.setMode("loop", True)
                        AxWindowsMediaPlayerE_3.Ctlcontrols.play()
                    Case 4
                        AxWindowsMediaPlayerE_4.settings.setMode("loop", True)
                        AxWindowsMediaPlayerE_4.Ctlcontrols.play()
                    Case 5
                        AxWindowsMediaPlayerE_5.settings.setMode("loop", True)
                        AxWindowsMediaPlayerE_5.Ctlcontrols.play()
                    Case 6
                        AxWindowsMediaPlayerE_6.settings.setMode("loop", True)
                        AxWindowsMediaPlayerE_6.Ctlcontrols.play()
                End Select
            Case 6
                Select Case checkPos(appobject.ProductNum)
                    Case 1
                        AxWindowsMediaPlayerF_1.settings.setMode("loop", True)
                        AxWindowsMediaPlayerF_1.Ctlcontrols.play()
                    Case 2
                        AxWindowsMediaPlayerF_2.settings.setMode("loop", True)
                        AxWindowsMediaPlayerF_2.Ctlcontrols.play()
                    Case 3
                        AxWindowsMediaPlayerF_3.settings.setMode("loop", True)
                        AxWindowsMediaPlayerF_3.Ctlcontrols.play()
                    Case 4
                        AxWindowsMediaPlayerF_4.settings.setMode("loop", True)
                        AxWindowsMediaPlayerF_4.Ctlcontrols.play()
                    Case 5
                        AxWindowsMediaPlayerF_5.settings.setMode("loop", True)
                        AxWindowsMediaPlayerF_5.Ctlcontrols.play()
                    Case 6
                        AxWindowsMediaPlayerF_6.settings.setMode("loop", True)
                        AxWindowsMediaPlayerF_6.Ctlcontrols.play()
                End Select
        End Select

    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        appobject.ProductNum = appobject.RayPos(0) '+ (Page - 1) * 10
        Call PerformTransaction(Price1.Text) '(Pic_1, Btn1, Price1.Text)
        PIC_1.Visible = False
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        appobject.ProductNum = appobject.RayPos(1) '+ (Page - 1) * 10
        Call PerformTransaction(Price2.Text)
        PIC_2.Visible = False
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        appobject.ProductNum = appobject.RayPos(2) '+ (Page - 1) * 10
        Call PerformTransaction(Price3.Text)
        PIC_3.Visible = False
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        appobject.ProductNum = appobject.RayPos(3) '+ (Page - 1) * 10
        Call PerformTransaction(Price4.Text)
        PIC_4.Visible = False
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        appobject.ProductNum = appobject.RayPos(4) '+ (Page - 1) * 10
        Call PerformTransaction(Price5.Text)
        PIC_5.Visible = False
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        appobject.ProductNum = appobject.RayPos(5) '+ (Page - 1) * 10
        Call PerformTransaction(Price6.Text)
        PIC_6.Visible = False
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

    '按鈕狀態
    Private Sub Btn_Hide()
        Btn1.Visible = False
        Btn2.Visible = False
        Btn3.Visible = False
        Btn4.Visible = False
        Btn5.Visible = False
        Btn6.Visible = False
        'Btn7.Visible = MoneyAvailable >= Val(Price7.Text) And Price7.Text <> ""
        'Btn8.Visible = MoneyAvailable >= Val(Price8.Text) And Price8.Text <> ""
        'Btn9.Visible = MoneyAvailable >= Val(Price9.Text) And Price9.Text <> ""
        'Btn10.Visible = MoneyAvailable >= Val(Price10.Text) And Price10.Text <> ""
    End Sub

    Private Sub GlassAndMovie()
        appobject.ToNext()
        'Me.Hide()
        PictureBox1.Visible = True
        If comOpen Then
            SerialPort1.Write("1")
        End If

        ResetMoneyReturnTimer.Enabled = True
    End Sub

    Private Sub AxWindowsMediaPlayerA_1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerA_1.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerA_1.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerA_2_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerA_2.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerA_2.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerA_3_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerA_3.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerA_3.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerA_4_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerA_4.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerA_4.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerA_5_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerA_5.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerA_5.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerA_6_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerA_6.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerA_6.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerB_1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerB_1.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerB_1.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerB_2_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerB_2.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerB_2.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerB_3_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerB_3.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerB_3.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerB_4_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerB_4.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerB_4.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerB_5_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerB_5.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerB_5.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerB_6_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerB_6.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerB_6.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub


    Private Sub AxWindowsMediaPlayerC_1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerC_1.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerC_1.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerC_2_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerC_2.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerC_2.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerC_3_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerC_3.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerC_3.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerC_4_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerC_4.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerC_4.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerC_5_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerC_5.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerC_5.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerC_6_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerC_6.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerC_6.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerD_1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerD_1.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerD_1.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerD_2_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerD_2.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerD_2.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerD_3_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerD_3.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerD_3.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerD_4_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerD_4.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerD_4.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerD_5_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerD_5.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerD_5.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerD_6_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerD_6.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerD_6.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerE_1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerE_1.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerE_1.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerE_2_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerE_2.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerE_2.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerE_3_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerE_3.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerE_3.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerE_4_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerE_4.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerE_4.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerE_5_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerE_5.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerE_5.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerE_6_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerE_6.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerE_6.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerF_1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerF_1.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerF_1.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerF_2_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerF_2.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerF_2.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerF_3_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerF_3.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerF_3.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerF_4_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerF_4.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerF_4.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerF_5_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerF_5.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerF_5.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
            GlassAndMovie()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayerF_6_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayerF_6.PlayStateChange
        If (UdpTimer.Enabled = False And RotateTimer.Enabled = False And
            AxWindowsMediaPlayerF_6.playState = WMPLib.WMPPlayState.wmppsMediaEnded) Then
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
            PIC_1.Visible = False
            PIC_2.Visible = False
            PIC_3.Visible = False
            PIC_4.Visible = False
            PIC_5.Visible = False
            PIC_6.Visible = False
            'Me.Show()
            PictureBox1.Visible = False
        ElseIf (AxWindowsMediaPlayer0.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            AxWindowsMediaPlayer0.Visible = True
            PrepareEndTransaction()
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

    Private Sub allDisapperStop()
        If AxWindowsMediaPlayerA_1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerA_1.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerB_1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerB_1.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerF_1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerF_1.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerE_1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerE_1.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerD_1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerD_1.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerC_1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerC_1.Ctlcontrols.stop()
        End If
        AxWindowsMediaPlayerA_1.Visible = False
        AxWindowsMediaPlayerB_1.Visible = False
        AxWindowsMediaPlayerC_1.Visible = False
        AxWindowsMediaPlayerD_1.Visible = False
        AxWindowsMediaPlayerE_1.Visible = False
        AxWindowsMediaPlayerF_1.Visible = False
        If AxWindowsMediaPlayerF_2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerF_2.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerE_2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerE_2.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerD_2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerD_2.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerC_2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerC_2.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerB_2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerB_2.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerA_2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerA_2.Ctlcontrols.stop()
        End If
        AxWindowsMediaPlayerA_2.Visible = False
        AxWindowsMediaPlayerB_2.Visible = False
        AxWindowsMediaPlayerC_2.Visible = False
        AxWindowsMediaPlayerD_2.Visible = False
        AxWindowsMediaPlayerE_2.Visible = False
        AxWindowsMediaPlayerF_2.Visible = False
        If AxWindowsMediaPlayerF_3.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerF_3.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerE_3.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerE_3.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerD_3.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerD_3.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerC_3.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerC_3.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerB_3.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerB_3.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerA_3.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerA_3.Ctlcontrols.stop()
        End If
        AxWindowsMediaPlayerA_3.Visible = False
        AxWindowsMediaPlayerB_3.Visible = False
        AxWindowsMediaPlayerC_3.Visible = False
        AxWindowsMediaPlayerD_3.Visible = False
        AxWindowsMediaPlayerE_3.Visible = False
        AxWindowsMediaPlayerF_3.Visible = False
        If AxWindowsMediaPlayerF_4.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerF_4.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerE_4.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerE_4.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerD_4.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerD_4.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerC_4.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerC_4.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerB_4.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerB_4.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerA_4.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerA_4.Ctlcontrols.stop()
        End If
        AxWindowsMediaPlayerA_4.Visible = False
        AxWindowsMediaPlayerB_4.Visible = False
        AxWindowsMediaPlayerC_4.Visible = False
        AxWindowsMediaPlayerD_4.Visible = False
        AxWindowsMediaPlayerE_4.Visible = False
        AxWindowsMediaPlayerF_4.Visible = False
        If AxWindowsMediaPlayerF_5.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerF_5.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerE_5.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerE_5.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerD_5.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerD_5.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerC_5.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerC_5.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerB_5.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerB_5.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerA_5.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerA_5.Ctlcontrols.stop()
        End If
        AxWindowsMediaPlayerA_5.Visible = False
        AxWindowsMediaPlayerB_5.Visible = False
        AxWindowsMediaPlayerC_5.Visible = False
        AxWindowsMediaPlayerD_5.Visible = False
        AxWindowsMediaPlayerE_5.Visible = False
        AxWindowsMediaPlayerF_5.Visible = False
        If AxWindowsMediaPlayerF_6.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerF_6.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerE_6.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerE_6.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerD_6.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerD_6.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerC_6.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerC_6.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerB_6.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerB_6.Ctlcontrols.stop()
        End If
        If AxWindowsMediaPlayerA_6.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayerA_6.Ctlcontrols.stop()
        End If
        AxWindowsMediaPlayerA_6.Visible = False
        AxWindowsMediaPlayerB_6.Visible = False
        AxWindowsMediaPlayerC_6.Visible = False
        AxWindowsMediaPlayerD_6.Visible = False
        AxWindowsMediaPlayerE_6.Visible = False
        AxWindowsMediaPlayerF_6.Visible = False
    End Sub

    Private Sub RotateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateTimer.Tick
        appobject.Over10Sec()
        appobject.backToRotate()
        allDisapperStop()
        Select Case appobject.RayPos(0)
            Case 1
                'AxWindowsMediaPlayerA_1.URL = Application.StartupPath & "\" & list_Pic(0) & "1.wmv" '& appobject.RayPos(0) & ".wmv"
                AxWindowsMediaPlayerA_1.Ctlcontrols.play()
                AxWindowsMediaPlayerA_1.Visible = True 'SetBounds(appobject.RaySix(0).wmv.Left, appobject.RaySix(0).wmv.Top, appobject.RaySix(0).wmv.Width, appobject.RaySix(0).wmv.Height)
            Case 2
                'AxWindowsMediaPlayerB_1.URL = Application.StartupPath & "\" & list_Pic(1) & "1.wmv" '& appobject.RayPos(0) & ".wmv"
                AxWindowsMediaPlayerB_1.Ctlcontrols.play()
                AxWindowsMediaPlayerB_1.Visible = True 'SetBounds(appobject.RaySix(0).wmv.Left, appobject.RaySix(0).wmv.Top, appobject.RaySix(0).wmv.Width, appobject.RaySix(0).wmv.Height)
            Case 3
                'AxWindowsMediaPlayerC_1.URL = Application.StartupPath & "\" & list_Pic(2) & "1.wmv" '& appobject.RayPos(0) & ".wmv"
                AxWindowsMediaPlayerC_1.Ctlcontrols.play()
                AxWindowsMediaPlayerC_1.Visible = True 'SetBounds(appobject.RaySix(0).wmv.Left, appobject.RaySix(0).wmv.Top, appobject.RaySix(0).wmv.Width, appobject.RaySix(0).wmv.Height)
            Case 4
                'AxWindowsMediaPlayerD_1.URL = Application.StartupPath & "\" & list_Pic(3) & "1.wmv" '& appobject.RayPos(0) & ".wmv"
                AxWindowsMediaPlayerD_1.Ctlcontrols.play()
                AxWindowsMediaPlayerD_1.Visible = True 'SetBounds(appobject.RaySix(0).wmv.Left, appobject.RaySix(0).wmv.Top, appobject.RaySix(0).wmv.Width, appobject.RaySix(0).wmv.Height)
            Case 5
                'AxWindowsMediaPlayerE_1.URL = Application.StartupPath & "\" & list_Pic(4) & "1.wmv" '& appobject.RayPos(0) & ".wmv"
                AxWindowsMediaPlayerE_1.Ctlcontrols.play()
                AxWindowsMediaPlayerE_1.Visible = True 'SetBounds(appobject.RaySix(0).wmv.Left, appobject.RaySix(0).wmv.Top, appobject.RaySix(0).wmv.Width, appobject.RaySix(0).wmv.Height)
            Case 6
                'AxWindowsMediaPlayerF_1.URL = Application.StartupPath & "\" & list_Pic(5) & "1.wmv" '& appobject.RayPos(0) & ".wmv"
                AxWindowsMediaPlayerF_1.Ctlcontrols.play()
                AxWindowsMediaPlayerF_1.Visible = True 'SetBounds(appobject.RaySix(0).wmv.Left, appobject.RaySix(0).wmv.Top, appobject.RaySix(0).wmv.Width, appobject.RaySix(0).wmv.Height)
        End Select
        'Btn1.SetBounds(appobject.RaySix(0).btn.Left, appobject.RaySix(0).btn.Top, appobject.RaySix(0).btn.Width, appobject.RaySix(0).btn.Height)

        Select Case appobject.RayPos(1)
            Case 1
                'AxWindowsMediaPlayerA_2.URL = Application.StartupPath & "\" & list_Pic(0) & "2.wmv" '& appobject.RayPos(1) & ".wmv"
                AxWindowsMediaPlayerA_2.Ctlcontrols.play()
                AxWindowsMediaPlayerA_2.Visible = True 'SetBounds(appobject.RaySix(1).wmv.Left, appobject.RaySix(1).wmv.Top, appobject.RaySix(1).wmv.Width, appobject.RaySix(1).wmv.Height)
            Case 2
                'AxWindowsMediaPlayerB_2.URL = Application.StartupPath & "\" & list_Pic(1) & "2.wmv" '& appobject.RayPos(1) & ".wmv"
                AxWindowsMediaPlayerB_2.Ctlcontrols.play()
                AxWindowsMediaPlayerB_2.Visible = True 'SetBounds(appobject.RaySix(1).wmv.Left, appobject.RaySix(1).wmv.Top, appobject.RaySix(1).wmv.Width, appobject.RaySix(1).wmv.Height)
            Case 3
                'AxWindowsMediaPlayerC_2.URL = Application.StartupPath & "\" & list_Pic(2) & "2.wmv" '& appobject.RayPos(1) & ".wmv"
                AxWindowsMediaPlayerC_2.Ctlcontrols.play()
                AxWindowsMediaPlayerC_2.Visible = True 'SetBounds(appobject.RaySix(1).wmv.Left, appobject.RaySix(1).wmv.Top, appobject.RaySix(1).wmv.Width, appobject.RaySix(1).wmv.Height)
            Case 4
                'AxWindowsMediaPlayerD_2.URL = Application.StartupPath & "\" & list_Pic(3) & "2.wmv" '& appobject.RayPos(1) & ".wmv"
                AxWindowsMediaPlayerD_2.Ctlcontrols.play()
                AxWindowsMediaPlayerD_2.Visible = True 'SetBounds(appobject.RaySix(1).wmv.Left, appobject.RaySix(1).wmv.Top, appobject.RaySix(1).wmv.Width, appobject.RaySix(1).wmv.Height)
            Case 5
                'AxWindowsMediaPlayerE_2.URL = Application.StartupPath & "\" & list_Pic(4) & "2.wmv" '& appobject.RayPos(1) & ".wmv"
                AxWindowsMediaPlayerE_2.Ctlcontrols.play()
                AxWindowsMediaPlayerE_2.Visible = True 'SetBounds(appobject.RaySix(1).wmv.Left, appobject.RaySix(1).wmv.Top, appobject.RaySix(1).wmv.Width, appobject.RaySix(1).wmv.Height)
            Case 6
                'AxWindowsMediaPlayerF_2.URL = Application.StartupPath & "\" & list_Pic(5) & "2.wmv" '& appobject.RayPos(1) & ".wmv"
                AxWindowsMediaPlayerF_2.Ctlcontrols.play()
                AxWindowsMediaPlayerF_2.Visible = True 'SetBounds(appobject.RaySix(1).wmv.Left, appobject.RaySix(1).wmv.Top, appobject.RaySix(1).wmv.Width, appobject.RaySix(1).wmv.Height)
        End Select
        'Btn2.SetBounds(appobject.RaySix(1).btn.Left, appobject.RaySix(1).btn.Top, appobject.RaySix(1).btn.Width, appobject.RaySix(1).btn.Height)

        Select Case appobject.RayPos(2)
            Case 1
                'AxWindowsMediaPlayerA_3.URL = Application.StartupPath & "\" & list_Pic(0) & "3.wmv" '& appobject.RayPos(2) & ".wmv"
                AxWindowsMediaPlayerA_3.Ctlcontrols.play()
                AxWindowsMediaPlayerA_3.Visible = True 'SetBounds(appobject.RaySix(2).wmv.Left, appobject.RaySix(2).wmv.Top, appobject.RaySix(2).wmv.Width, appobject.RaySix(2).wmv.Height)
            Case 2
                'AxWindowsMediaPlayerB_3.URL = Application.StartupPath & "\" & list_Pic(1) & "3.wmv" '& appobject.RayPos(2) & ".wmv"
                AxWindowsMediaPlayerB_3.Ctlcontrols.play()
                AxWindowsMediaPlayerB_3.Visible = True 'SetBounds(appobject.RaySix(2).wmv.Left, appobject.RaySix(2).wmv.Top, appobject.RaySix(2).wmv.Width, appobject.RaySix(2).wmv.Height)
            Case 3
                'AxWindowsMediaPlayerC_3.URL = Application.StartupPath & "\" & list_Pic(2) & "3.wmv" '& appobject.RayPos(2) & ".wmv"
                AxWindowsMediaPlayerC_3.Ctlcontrols.play()
                AxWindowsMediaPlayerC_3.Visible = True 'SetBounds(appobject.RaySix(2).wmv.Left, appobject.RaySix(2).wmv.Top, appobject.RaySix(2).wmv.Width, appobject.RaySix(2).wmv.Height)
            Case 4
                'AxWindowsMediaPlayerD_3.URL = Application.StartupPath & "\" & list_Pic(3) & "3.wmv" '& appobject.RayPos(2) & ".wmv"
                AxWindowsMediaPlayerD_3.Ctlcontrols.play()
                AxWindowsMediaPlayerD_3.Visible = True 'SetBounds(appobject.RaySix(2).wmv.Left, appobject.RaySix(2).wmv.Top, appobject.RaySix(2).wmv.Width, appobject.RaySix(2).wmv.Height)
            Case 5
                'AxWindowsMediaPlayerE_3.URL = Application.StartupPath & "\" & list_Pic(4) & "3.wmv" '& appobject.RayPos(2) & ".wmv"
                AxWindowsMediaPlayerE_3.Ctlcontrols.play()
                AxWindowsMediaPlayerE_3.Visible = True 'SetBounds(appobject.RaySix(2).wmv.Left, appobject.RaySix(2).wmv.Top, appobject.RaySix(2).wmv.Width, appobject.RaySix(2).wmv.Height)
            Case 6
                'AxWindowsMediaPlayerF_3.URL = Application.StartupPath & "\" & list_Pic(5) & "3.wmv" '& appobject.RayPos(2) & ".wmv"
                AxWindowsMediaPlayerF_3.Ctlcontrols.play()
                AxWindowsMediaPlayerF_3.Visible = True 'SetBounds(appobject.RaySix(2).wmv.Left, appobject.RaySix(2).wmv.Top, appobject.RaySix(2).wmv.Width, appobject.RaySix(2).wmv.Height)
        End Select
        'Btn3.SetBounds(appobject.RaySix(2).btn.Left, appobject.RaySix(2).btn.Top, appobject.RaySix(2).btn.Width, appobject.RaySix(2).btn.Height)

        Select Case appobject.RayPos(3)
            Case 1
                'AxWindowsMediaPlayerA_4.URL = Application.StartupPath & "\" & list_Pic(0) & "4.wmv" '& appobject.RayPos(3) & ".wmv"
                AxWindowsMediaPlayerA_4.Ctlcontrols.play()
                AxWindowsMediaPlayerA_4.Visible = True 'SetBounds(appobject.RaySix(3).wmv.Left, appobject.RaySix(3).wmv.Top, appobject.RaySix(3).wmv.Width, appobject.RaySix(3).wmv.Height)
            Case 2
                'AxWindowsMediaPlayerB_4.URL = Application.StartupPath & "\" & list_Pic(1) & "4.wmv" '& appobject.RayPos(3) & ".wmv"
                AxWindowsMediaPlayerB_4.Ctlcontrols.play()
                AxWindowsMediaPlayerB_4.Visible = True 'SetBounds(appobject.RaySix(3).wmv.Left, appobject.RaySix(3).wmv.Top, appobject.RaySix(3).wmv.Width, appobject.RaySix(3).wmv.Height)
            Case 3
                'AxWindowsMediaPlayerC_4.URL = Application.StartupPath & "\" & list_Pic(2) & "4.wmv" '& appobject.RayPos(3) & ".wmv"
                AxWindowsMediaPlayerC_4.Ctlcontrols.play()
                AxWindowsMediaPlayerC_4.Visible = True 'SetBounds(appobject.RaySix(3).wmv.Left, appobject.RaySix(3).wmv.Top, appobject.RaySix(3).wmv.Width, appobject.RaySix(3).wmv.Height)
            Case 4
                'AxWindowsMediaPlayerD_4.URL = Application.StartupPath & "\" & list_Pic(3) & "4.wmv" '& appobject.RayPos(3) & ".wmv"
                AxWindowsMediaPlayerD_4.Ctlcontrols.play()
                AxWindowsMediaPlayerD_4.Visible = True 'SetBounds(appobject.RaySix(3).wmv.Left, appobject.RaySix(3).wmv.Top, appobject.RaySix(3).wmv.Width, appobject.RaySix(3).wmv.Height)
            Case 5
                'AxWindowsMediaPlayerE_4.URL = Application.StartupPath & "\" & list_Pic(4) & "4.wmv" '& appobject.RayPos(3) & ".wmv"
                AxWindowsMediaPlayerE_4.Ctlcontrols.play()
                AxWindowsMediaPlayerE_4.Visible = True 'SetBounds(appobject.RaySix(3).wmv.Left, appobject.RaySix(3).wmv.Top, appobject.RaySix(3).wmv.Width, appobject.RaySix(3).wmv.Height)
            Case 6
                'AxWindowsMediaPlayerF_4.URL = Application.StartupPath & "\" & list_Pic(5) & "4.wmv" '& appobject.RayPos(3) & ".wmv"
                AxWindowsMediaPlayerF_4.Ctlcontrols.play()
                AxWindowsMediaPlayerF_4.Visible = True 'SetBounds(appobject.RaySix(3).wmv.Left, appobject.RaySix(3).wmv.Top, appobject.RaySix(3).wmv.Width, appobject.RaySix(3).wmv.Height)
        End Select
        'Btn4.SetBounds(appobject.RaySix(3).btn.Left, appobject.RaySix(3).btn.Top, appobject.RaySix(3).btn.Width, appobject.RaySix(3).btn.Height)

        Select Case appobject.RayPos(4)
            Case 1
                'AxWindowsMediaPlayerA_5.URL = Application.StartupPath & "\" & list_Pic(0) & "5.wmv" '& appobject.RayPos(4) & ".wmv"
                AxWindowsMediaPlayerA_5.Ctlcontrols.play()
                AxWindowsMediaPlayerA_5.Visible = True 'SetBounds(appobject.RaySix(4).wmv.Left, appobject.RaySix(4).wmv.Top, appobject.RaySix(4).wmv.Width, appobject.RaySix(4).wmv.Height)
            Case 2
                'AxWindowsMediaPlayerB_5.URL = Application.StartupPath & "\" & list_Pic(1) & "5.wmv" '& appobject.RayPos(4) & ".wmv"
                AxWindowsMediaPlayerB_5.Ctlcontrols.play()
                AxWindowsMediaPlayerB_5.Visible = True 'SetBounds(appobject.RaySix(4).wmv.Left, appobject.RaySix(4).wmv.Top, appobject.RaySix(4).wmv.Width, appobject.RaySix(4).wmv.Height)
            Case 3
                'AxWindowsMediaPlayerC_5.URL = Application.StartupPath & "\" & list_Pic(2) & "5.wmv" '& appobject.RayPos(4) & ".wmv"
                AxWindowsMediaPlayerC_5.Ctlcontrols.play()
                AxWindowsMediaPlayerC_5.Visible = True 'SetBounds(appobject.RaySix(4).wmv.Left, appobject.RaySix(4).wmv.Top, appobject.RaySix(4).wmv.Width, appobject.RaySix(4).wmv.Height)
            Case 4
                'AxWindowsMediaPlayerD_5.URL = Application.StartupPath & "\" & list_Pic(3) & "5.wmv" '& appobject.RayPos(4) & ".wmv"
                AxWindowsMediaPlayerD_5.Ctlcontrols.play()
                AxWindowsMediaPlayerD_5.Visible = True 'SetBounds(appobject.RaySix(4).wmv.Left, appobject.RaySix(4).wmv.Top, appobject.RaySix(4).wmv.Width, appobject.RaySix(4).wmv.Height)
            Case 5
                'AxWindowsMediaPlayerE_5.URL = Application.StartupPath & "\" & list_Pic(4) & "5.wmv" '& appobject.RayPos(4) & ".wmv"
                AxWindowsMediaPlayerE_5.Ctlcontrols.play()
                AxWindowsMediaPlayerE_5.Visible = True 'SetBounds(appobject.RaySix(4).wmv.Left, appobject.RaySix(4).wmv.Top, appobject.RaySix(4).wmv.Width, appobject.RaySix(4).wmv.Height)
            Case 6
                'AxWindowsMediaPlayerF_5.URL = Application.StartupPath & "\" & list_Pic(5) & "5.wmv" '& appobject.RayPos(4) & ".wmv"
                AxWindowsMediaPlayerF_5.Ctlcontrols.play()
                AxWindowsMediaPlayerF_5.Visible = True 'SetBounds(appobject.RaySix(4).wmv.Left, appobject.RaySix(4).wmv.Top, appobject.RaySix(4).wmv.Width, appobject.RaySix(4).wmv.Height)
        End Select
        'Btn5.SetBounds(appobject.RaySix(4).btn.Left, appobject.RaySix(4).btn.Top, appobject.RaySix(4).btn.Width, appobject.RaySix(4).btn.Height)

        Select Case appobject.RayPos(5)
            Case 1
                'AxWindowsMediaPlayerA_6.URL = Application.StartupPath & "\" & list_Pic(0) & "6.wmv" '& appobject.RayPos(5) & ".wmv"
                AxWindowsMediaPlayerA_6.Ctlcontrols.play()
                AxWindowsMediaPlayerA_6.Visible = True 'SetBounds(appobject.RaySix(5).wmv.Left, appobject.RaySix(5).wmv.Top, appobject.RaySix(5).wmv.Width, appobject.RaySix(5).wmv.Height)
            Case 2
                'AxWindowsMediaPlayerB_6.URL = Application.StartupPath & "\" & list_Pic(1) & "6.wmv" '& appobject.RayPos(5) & ".wmv"
                AxWindowsMediaPlayerB_6.Ctlcontrols.play()
                AxWindowsMediaPlayerB_6.Visible = True 'SetBounds(appobject.RaySix(5).wmv.Left, appobject.RaySix(5).wmv.Top, appobject.RaySix(5).wmv.Width, appobject.RaySix(5).wmv.Height)
            Case 3
                'AxWindowsMediaPlayerC_6.URL = Application.StartupPath & "\" & list_Pic(2) & "6.wmv" '& appobject.RayPos(5) & ".wmv"
                AxWindowsMediaPlayerC_6.Ctlcontrols.play()
                AxWindowsMediaPlayerC_6.Visible = True 'SetBounds(appobject.RaySix(5).wmv.Left, appobject.RaySix(5).wmv.Top, appobject.RaySix(5).wmv.Width, appobject.RaySix(5).wmv.Height)
            Case 4
                'AxWindowsMediaPlayerD_6.URL = Application.StartupPath & "\" & list_Pic(3) & "6.wmv" '& appobject.RayPos(5) & ".wmv"
                AxWindowsMediaPlayerD_6.Ctlcontrols.play()
                AxWindowsMediaPlayerD_6.Visible = True 'SetBounds(appobject.RaySix(5).wmv.Left, appobject.RaySix(5).wmv.Top, appobject.RaySix(5).wmv.Width, appobject.RaySix(5).wmv.Height)
            Case 5
                'AxWindowsMediaPlayerE_6.URL = Application.StartupPath & "\" & list_Pic(4) & "6.wmv" '& appobject.RayPos(5) & ".wmv"
                AxWindowsMediaPlayerE_6.Ctlcontrols.play()
                AxWindowsMediaPlayerE_6.Visible = True 'SetBounds(appobject.RaySix(5).wmv.Left, appobject.RaySix(5).wmv.Top, appobject.RaySix(5).wmv.Width, appobject.RaySix(5).wmv.Height)
            Case 6
                'AxWindowsMediaPlayerF_6.URL = Application.StartupPath & "\" & list_Pic(5) & "6.wmv" '& appobject.RayPos(5) & ".wmv"
                AxWindowsMediaPlayerF_6.Ctlcontrols.play()
                AxWindowsMediaPlayerF_6.Visible = True 'SetBounds(appobject.RaySix(5).wmv.Left, appobject.RaySix(5).wmv.Top, appobject.RaySix(5).wmv.Width, appobject.RaySix(5).wmv.Height)
        End Select
        'Btn6.SetBounds(appobject.RaySix(5).btn.Left, appobject.RaySix(5).btn.Top, appobject.RaySix(5).btn.Width, appobject.RaySix(5).btn.Height)

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

        Select Case appobject.RayPos(0)
            Case 1
                'AxWindowsMediaPlayerA_1.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerA_1.Ctlcontrols.stop()
                PIC_1.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_A-1.JPG")
            Case 2
                'AxWindowsMediaPlayerB_1.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerB_1.Ctlcontrols.stop()
                PIC_1.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_B-1.JPG")
            Case 3
                'AxWindowsMediaPlayerC_1.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerC_1.Ctlcontrols.stop()
                PIC_1.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_C-1.JPG")
            Case 4
                'AxWindowsMediaPlayerD_1.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerD_1.Ctlcontrols.stop()
                PIC_1.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_D-1.JPG")
            Case 5
                'AxWindowsMediaPlayerE_1.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerE_1.Ctlcontrols.stop()
                PIC_1.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_E-1.JPG")
            Case 6
                'AxWindowsMediaPlayerF_1.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerF_1.Ctlcontrols.stop()
                PIC_1.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_F-1.JPG")
        End Select
        Select Case appobject.RayPos(1)
            Case 1
                'AxWindowsMediaPlayerA_2.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerA_2.Ctlcontrols.stop()
                PIC_2.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_A-2.JPG")
            Case 2
                'AxWindowsMediaPlayerB_2.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerB_2.Ctlcontrols.stop()
                PIC_2.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_B-2.JPG")
            Case 3
                'AxWindowsMediaPlayerC_2.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerC_2.Ctlcontrols.stop()
                PIC_2.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_C-2.JPG")
            Case 4
                'AxWindowsMediaPlayerD_2.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerD_2.Ctlcontrols.stop()
                PIC_2.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_D-2.JPG")
            Case 5
                'AxWindowsMediaPlayerE_2.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerE_2.Ctlcontrols.stop()
                PIC_2.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_E-2.JPG")
            Case 6
                'AxWindowsMediaPlayerF_2.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerF_2.Ctlcontrols.stop()
                PIC_2.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_F-2.JPG")
        End Select
        Select Case appobject.RayPos(2)
            Case 1
                'AxWindowsMediaPlayerA_3.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerA_3.Ctlcontrols.stop()
                PIC_3.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_A-3.JPG")
            Case 2
                'AxWindowsMediaPlayerB_3.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerB_3.Ctlcontrols.stop()
                PIC_3.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_B-3.JPG")
            Case 3
                'AxWindowsMediaPlayerC_3.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerC_3.Ctlcontrols.stop()
                PIC_3.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_C-3.JPG")
            Case 4
                'AxWindowsMediaPlayerD_3.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerD_3.Ctlcontrols.stop()
                PIC_3.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_D-3.JPG")
            Case 5
                'AxWindowsMediaPlayerE_3.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerE_3.Ctlcontrols.stop()
                PIC_3.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_E-3.JPG")
            Case 6
                'AxWindowsMediaPlayerF_3.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerF_3.Ctlcontrols.stop()
                PIC_3.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_F-3.JPG")
        End Select
        Select Case appobject.RayPos(3)
            Case 1
                'AxWindowsMediaPlayerA_4.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerA_4.Ctlcontrols.stop()
                PIC_4.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_A-4.JPG")
            Case 2
                'AxWindowsMediaPlayerB_4.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerB_4.Ctlcontrols.stop()
                PIC_4.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_B-4.JPG")
            Case 3
                'AxWindowsMediaPlayerC_4.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerC_4.Ctlcontrols.stop()
                PIC_4.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_C-4.JPG")
            Case 4
                'AxWindowsMediaPlayerD_4.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerD_4.Ctlcontrols.stop()
                PIC_4.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_D-4.JPG")
            Case 5
                'AxWindowsMediaPlayerE_4.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerE_4.Ctlcontrols.stop()
                PIC_4.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_E-4.JPG")
            Case 6
                'AxWindowsMediaPlayerF_4.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerF_4.Ctlcontrols.stop()
                PIC_4.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_F-4.JPG")
        End Select
        Select Case appobject.RayPos(4)
            Case 1
                'AxWindowsMediaPlayerA_5.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerA_5.Ctlcontrols.stop()
                PIC_5.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_A-5.JPG")
            Case 2
                'AxWindowsMediaPlayerB_5.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerB_5.Ctlcontrols.stop()
                PIC_5.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_B-5.JPG")
            Case 3
                'AxWindowsMediaPlayerC_5.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerC_5.Ctlcontrols.stop()
                PIC_5.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_C-5.JPG")
            Case 4
                'AxWindowsMediaPlayerD_5.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerD_5.Ctlcontrols.stop()
                PIC_5.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_D-5.JPG")
            Case 5
                'AxWindowsMediaPlayerE_5.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerE_5.Ctlcontrols.stop()
                PIC_5.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_E-5.JPG")
            Case 6
                'AxWindowsMediaPlayerF_5.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerF_5.Ctlcontrols.stop()
                PIC_5.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_F-5.JPG")
        End Select
        Select Case appobject.RayPos(5)
            Case 1
                'AxWindowsMediaPlayerA_6.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerA_6.Ctlcontrols.stop()
                PIC_6.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_A-6.JPG")
            Case 2
                'AxWindowsMediaPlayerB_6.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerB_6.Ctlcontrols.stop()
                PIC_6.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_B-6.JPG")
            Case 3
                'AxWindowsMediaPlayerC_6.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerC_6.Ctlcontrols.stop()
                PIC_6.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_C-6.JPG")
            Case 4
                'AxWindowsMediaPlayerD_6.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerD_6.Ctlcontrols.stop()
                PIC_6.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_D-6.JPG")
            Case 5
                'AxWindowsMediaPlayerE_6.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerE_6.Ctlcontrols.stop()
                PIC_6.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_E-6.JPG")
            Case 6
                'AxWindowsMediaPlayerF_6.Ctlcontrols.currentPosition = 1.09
                AxWindowsMediaPlayerF_6.Ctlcontrols.stop()
                PIC_6.Image = New System.Drawing.Bitmap("C:\PIC\Rotate_F-6.JPG")
        End Select

        PIC_1.Visible = True
        PIC_2.Visible = True
        PIC_3.Visible = True
        PIC_4.Visible = True
        PIC_5.Visible = True
        PIC_6.Visible = True
    End Sub

    Private Sub allContinue()
        Select Case appobject.RayPos(0)
            Case 1
                AxWindowsMediaPlayerA_1.Ctlcontrols.play()
            Case 2
                AxWindowsMediaPlayerB_1.Ctlcontrols.play()
            Case 3
                AxWindowsMediaPlayerC_1.Ctlcontrols.play()
            Case 4
                AxWindowsMediaPlayerD_1.Ctlcontrols.play()
            Case 5
                AxWindowsMediaPlayerE_1.Ctlcontrols.play()
            Case 6
                AxWindowsMediaPlayerF_1.Ctlcontrols.play()
        End Select
        Select Case appobject.RayPos(1)
            Case 1
                AxWindowsMediaPlayerA_2.Ctlcontrols.play()
            Case 2
                AxWindowsMediaPlayerB_2.Ctlcontrols.play()
            Case 3
                AxWindowsMediaPlayerC_2.Ctlcontrols.play()
            Case 4
                AxWindowsMediaPlayerD_2.Ctlcontrols.play()
            Case 5
                AxWindowsMediaPlayerE_2.Ctlcontrols.play()
            Case 6
                AxWindowsMediaPlayerF_2.Ctlcontrols.play()
        End Select
        Select Case appobject.RayPos(2)
            Case 1
                AxWindowsMediaPlayerA_3.Ctlcontrols.play()
            Case 2
                AxWindowsMediaPlayerB_3.Ctlcontrols.play()
            Case 3
                AxWindowsMediaPlayerC_3.Ctlcontrols.play()
            Case 4
                AxWindowsMediaPlayerD_3.Ctlcontrols.play()
            Case 5
                AxWindowsMediaPlayerE_3.Ctlcontrols.play()
            Case 6
                AxWindowsMediaPlayerF_3.Ctlcontrols.play()
        End Select
        Select Case appobject.RayPos(3)
            Case 1
                AxWindowsMediaPlayerA_4.Ctlcontrols.play()
            Case 2
                AxWindowsMediaPlayerB_4.Ctlcontrols.play()
            Case 3
                AxWindowsMediaPlayerC_4.Ctlcontrols.play()
            Case 4
                AxWindowsMediaPlayerD_4.Ctlcontrols.play()
            Case 5
                AxWindowsMediaPlayerE_4.Ctlcontrols.play()
            Case 6
                AxWindowsMediaPlayerF_4.Ctlcontrols.play()
        End Select
        Select Case appobject.RayPos(4)
            Case 1
                AxWindowsMediaPlayerA_5.Ctlcontrols.play()
            Case 2
                AxWindowsMediaPlayerB_5.Ctlcontrols.play()
            Case 3
                AxWindowsMediaPlayerC_5.Ctlcontrols.play()
            Case 4
                AxWindowsMediaPlayerD_5.Ctlcontrols.play()
            Case 5
                AxWindowsMediaPlayerE_5.Ctlcontrols.play()
            Case 6
                AxWindowsMediaPlayerF_5.Ctlcontrols.play()
        End Select
        Select Case appobject.RayPos(5)
            Case 1
                AxWindowsMediaPlayerA_6.Ctlcontrols.play()
            Case 2
                AxWindowsMediaPlayerB_6.Ctlcontrols.play()
            Case 3
                AxWindowsMediaPlayerC_6.Ctlcontrols.play()
            Case 4
                AxWindowsMediaPlayerD_6.Ctlcontrols.play()
            Case 5
                AxWindowsMediaPlayerE_6.Ctlcontrols.play()
            Case 6
                AxWindowsMediaPlayerF_6.Ctlcontrols.play()
        End Select
    End Sub

    Private Sub UdpTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UdpTimer.Tick
        If String.IsNullOrEmpty(appobject.ReceiveBytes) = False Then
            Dim intrec As Integer
            If appobject.ReceiveBytes = "100" Then
                RotateTimer.Enabled = False
                If appobject.MoneyAvailable = 0 Then
                    BillFirstFrame()
                Else
                    appobject.BillInAgain()
                End If
                MoneyDepositTB.Text = appobject.MoneyAvailable
                DrawVerticalText(MoneyDepositTB.Text)
                Btn_Show()
            ElseIf appobject.ReceiveBytes = "50" Then
                RotateTimer.Enabled = False
                If appobject.MoneyAvailable = 0 Then
                    CoinFirstFrame()
                Else
                    appobject.CoinInAgain()
                End If
                MoneyDepositTB.Text = appobject.MoneyAvailable
                DrawVerticalText(MoneyDepositTB.Text)
                Btn_Show()
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
        Dim i As Integer
        Dim rndNum As New Random()
        i = rndNum.Next(1, 30)

        Dim path As String = Application.StartupPath & "\" & list_Print(appobject.ProductNum - 1) & i & ".png"
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
                AxWindowsMediaPlayerA_1.settings.setMode("loop", True)
                AxWindowsMediaPlayerA_2.settings.setMode("loop", True)
                AxWindowsMediaPlayerA_3.settings.setMode("loop", True)
                AxWindowsMediaPlayerA_4.settings.setMode("loop", True)
                AxWindowsMediaPlayerA_5.settings.setMode("loop", True)
                AxWindowsMediaPlayerA_6.settings.setMode("loop", True)
                Price1.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.FirstSix(0).wmv = New Rectangle(AxWindowsMediaPlayerA_1.Location.X, AxWindowsMediaPlayerA_1.Location.Y _
                                              , AxWindowsMediaPlayerA_1.Size.Width, AxWindowsMediaPlayerA_1.Size.Height)
                    appobject.FirstSix(1).wmv = New Rectangle(AxWindowsMediaPlayerA_2.Location.X, AxWindowsMediaPlayerA_2.Location.Y _
                                              , AxWindowsMediaPlayerA_2.Size.Width, AxWindowsMediaPlayerA_2.Size.Height)
                    appobject.FirstSix(2).wmv = New Rectangle(AxWindowsMediaPlayerA_3.Location.X, AxWindowsMediaPlayerA_3.Location.Y _
                                                             , AxWindowsMediaPlayerA_3.Size.Width, AxWindowsMediaPlayerA_3.Size.Height)
                    appobject.FirstSix(3).wmv = New Rectangle(AxWindowsMediaPlayerA_4.Location.X, AxWindowsMediaPlayerA_4.Location.Y _
                                                  , AxWindowsMediaPlayerA_4.Size.Width, AxWindowsMediaPlayerA_4.Size.Height)
                    appobject.FirstSix(4).wmv = New Rectangle(AxWindowsMediaPlayerA_5.Location.X, AxWindowsMediaPlayerA_5.Location.Y _
                                                  , AxWindowsMediaPlayerA_5.Size.Width, AxWindowsMediaPlayerA_5.Size.Height)
                    appobject.FirstSix(5).wmv = New Rectangle(AxWindowsMediaPlayerA_6.Location.X, AxWindowsMediaPlayerA_6.Location.Y _
                                                            , AxWindowsMediaPlayerA_6.Size.Width, AxWindowsMediaPlayerA_6.Size.Height)
                    appobject.FirstSix(0).btn = New Rectangle(Btn1.Location.X, Btn1.Location.Y _
                                              , Btn1.Size.Width, Btn1.Size.Height)
                    AxWindowsMediaPlayerA_1.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "1.wmv" 'Pic_1.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                    AxWindowsMediaPlayerA_2.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "2.wmv" 'Pic_1.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                    AxWindowsMediaPlayerA_2.Visible = False
                    AxWindowsMediaPlayerA_2.Ctlcontrols.stop()
                    AxWindowsMediaPlayerA_3.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "3.wmv" 'Pic_1.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                    AxWindowsMediaPlayerA_3.Visible = False
                    AxWindowsMediaPlayerA_3.Ctlcontrols.stop()
                    AxWindowsMediaPlayerA_4.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "4.wmv" 'Pic_1.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                    AxWindowsMediaPlayerA_4.Visible = False
                    AxWindowsMediaPlayerA_4.Ctlcontrols.stop()
                    AxWindowsMediaPlayerA_5.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "5.wmv" 'Pic_1.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                    AxWindowsMediaPlayerA_5.Visible = False
                    AxWindowsMediaPlayerA_5.Ctlcontrols.stop()
                    AxWindowsMediaPlayerA_6.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "6.wmv" 'Pic_1.Image = Image.FromFile(Application.StartupPath & "\" & list_Pic(n - 1))
                    AxWindowsMediaPlayerA_6.Visible = False
                    AxWindowsMediaPlayerA_6.Ctlcontrols.stop()
                Else
                    EndTransaction()
                End If
            Case 2
                AxWindowsMediaPlayerB_1.settings.setMode("loop", True)
                AxWindowsMediaPlayerB_2.settings.setMode("loop", True)
                AxWindowsMediaPlayerB_3.settings.setMode("loop", True)
                AxWindowsMediaPlayerB_4.settings.setMode("loop", True)
                AxWindowsMediaPlayerB_5.settings.setMode("loop", True)
                AxWindowsMediaPlayerB_6.settings.setMode("loop", True)
                'AutosizeImage(Application.StartupPath & "\" & list_Pic(n - 1), Pic_2)
                'ProductName_2.Text = list_Name(n - 1)
                Price2.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.FirstSix(1).btn = New Rectangle(Btn2.Location.X, Btn2.Location.Y _
                                              , Btn2.Size.Width, Btn2.Size.Height)
                    AxWindowsMediaPlayerB_1.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "1.wmv"
                    AxWindowsMediaPlayerB_1.Visible = False
                    AxWindowsMediaPlayerB_1.Ctlcontrols.stop()
                    AxWindowsMediaPlayerB_2.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "2.wmv"
                    AxWindowsMediaPlayerB_3.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "3.wmv"
                    AxWindowsMediaPlayerB_3.Visible = False
                    AxWindowsMediaPlayerB_3.Ctlcontrols.stop()
                    AxWindowsMediaPlayerB_4.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "4.wmv"
                    AxWindowsMediaPlayerB_4.Visible = False
                    AxWindowsMediaPlayerB_4.Ctlcontrols.stop()
                    AxWindowsMediaPlayerB_5.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "5.wmv"
                    AxWindowsMediaPlayerB_5.Visible = False
                    AxWindowsMediaPlayerB_5.Ctlcontrols.stop()
                    AxWindowsMediaPlayerB_6.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "6.wmv"
                    AxWindowsMediaPlayerB_6.Visible = False
                    AxWindowsMediaPlayerB_6.Ctlcontrols.stop()
                Else
                    EndTransaction()
                End If
            Case 3
                AxWindowsMediaPlayerC_1.settings.setMode("loop", True)
                AxWindowsMediaPlayerC_2.settings.setMode("loop", True)
                AxWindowsMediaPlayerC_3.settings.setMode("loop", True)
                AxWindowsMediaPlayerC_4.settings.setMode("loop", True)
                AxWindowsMediaPlayerC_5.settings.setMode("loop", True)
                AxWindowsMediaPlayerC_6.settings.setMode("loop", True)
                Price3.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.FirstSix(2).btn = New Rectangle(Btn3.Location.X, Btn3.Location.Y _
                                                  , Btn3.Size.Width, Btn3.Size.Height)
                    AxWindowsMediaPlayerC_1.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "1.wmv"
                    AxWindowsMediaPlayerC_1.Visible = False
                    AxWindowsMediaPlayerC_1.Ctlcontrols.stop()
                    AxWindowsMediaPlayerC_2.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "2.wmv"
                    AxWindowsMediaPlayerC_2.Visible = False
                    AxWindowsMediaPlayerC_2.Ctlcontrols.stop()
                    AxWindowsMediaPlayerC_3.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "3.wmv"
                    AxWindowsMediaPlayerC_4.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "4.wmv"
                    AxWindowsMediaPlayerC_4.Visible = False
                    AxWindowsMediaPlayerC_4.Ctlcontrols.stop()
                    AxWindowsMediaPlayerC_5.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "5.wmv"
                    AxWindowsMediaPlayerC_5.Visible = False
                    AxWindowsMediaPlayerC_5.Ctlcontrols.stop()
                    AxWindowsMediaPlayerC_6.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "6.wmv"
                    AxWindowsMediaPlayerC_6.Visible = False
                    AxWindowsMediaPlayerC_6.Ctlcontrols.stop()
                Else
                    EndTransaction()
                End If
            Case 4
                AxWindowsMediaPlayerD_1.settings.setMode("loop", True)
                AxWindowsMediaPlayerD_2.settings.setMode("loop", True)
                AxWindowsMediaPlayerD_3.settings.setMode("loop", True)
                AxWindowsMediaPlayerD_4.settings.setMode("loop", True)
                AxWindowsMediaPlayerD_5.settings.setMode("loop", True)
                AxWindowsMediaPlayerD_6.settings.setMode("loop", True)
                'Price4.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.FirstSix(3).btn = New Rectangle(Btn4.Location.X, Btn4.Location.Y _
                                                  , Btn4.Size.Width, Btn4.Size.Height)
                    AxWindowsMediaPlayerD_1.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "1.wmv"
                    AxWindowsMediaPlayerD_1.Visible = False
                    AxWindowsMediaPlayerD_1.Ctlcontrols.stop()
                    AxWindowsMediaPlayerD_2.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "2.wmv"
                    AxWindowsMediaPlayerD_2.Visible = False
                    AxWindowsMediaPlayerD_2.Ctlcontrols.stop()
                    AxWindowsMediaPlayerD_3.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "3.wmv"
                    AxWindowsMediaPlayerD_3.Visible = False
                    AxWindowsMediaPlayerD_3.Ctlcontrols.stop()
                    AxWindowsMediaPlayerD_4.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "4.wmv"
                    AxWindowsMediaPlayerD_5.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "5.wmv"
                    AxWindowsMediaPlayerD_5.Visible = False
                    AxWindowsMediaPlayerD_5.Ctlcontrols.stop()
                    AxWindowsMediaPlayerD_6.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "6.wmv"
                    AxWindowsMediaPlayerD_6.Visible = False
                    AxWindowsMediaPlayerD_6.Ctlcontrols.stop()
                Else
                    EndTransaction()
                End If
            Case 5
                AxWindowsMediaPlayerE_1.settings.setMode("loop", True)
                AxWindowsMediaPlayerE_2.settings.setMode("loop", True)
                AxWindowsMediaPlayerE_3.settings.setMode("loop", True)
                AxWindowsMediaPlayerE_4.settings.setMode("loop", True)
                AxWindowsMediaPlayerE_5.settings.setMode("loop", True)
                AxWindowsMediaPlayerE_6.settings.setMode("loop", True)
                Price5.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.FirstSix(4).btn = New Rectangle(Btn5.Location.X, Btn5.Location.Y _
                                                  , Btn5.Size.Width, Btn5.Size.Height)
                    AxWindowsMediaPlayerE_1.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "1.wmv"
                    AxWindowsMediaPlayerE_1.Visible = False
                    AxWindowsMediaPlayerE_1.Ctlcontrols.stop()
                    AxWindowsMediaPlayerE_2.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "2.wmv"
                    AxWindowsMediaPlayerE_2.Visible = False
                    AxWindowsMediaPlayerE_2.Ctlcontrols.stop()
                    AxWindowsMediaPlayerE_3.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "3.wmv"
                    AxWindowsMediaPlayerE_3.Visible = False
                    AxWindowsMediaPlayerE_3.Ctlcontrols.stop()
                    AxWindowsMediaPlayerE_4.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "4.wmv"
                    AxWindowsMediaPlayerE_4.Visible = False
                    AxWindowsMediaPlayerE_4.Ctlcontrols.stop()
                    AxWindowsMediaPlayerE_5.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "5.wmv"
                    AxWindowsMediaPlayerE_6.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "6.wmv"
                    AxWindowsMediaPlayerE_6.Visible = False
                    AxWindowsMediaPlayerE_6.Ctlcontrols.stop()
                Else
                    EndTransaction()
                End If
            Case 6
                AxWindowsMediaPlayerF_1.settings.setMode("loop", True)
                AxWindowsMediaPlayerF_2.settings.setMode("loop", True)
                AxWindowsMediaPlayerF_3.settings.setMode("loop", True)
                AxWindowsMediaPlayerF_4.settings.setMode("loop", True)
                AxWindowsMediaPlayerF_5.settings.setMode("loop", True)
                AxWindowsMediaPlayerF_6.settings.setMode("loop", True)
                Price6.Text = list_Price(n - 1)
                If isPos = True Then
                    appobject.FirstSix(5).btn = New Rectangle(Btn6.Location.X, Btn6.Location.Y _
                                                  , Btn6.Size.Width, Btn6.Size.Height)
                    AxWindowsMediaPlayerF_1.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "1.wmv"
                    AxWindowsMediaPlayerF_1.Visible = False
                    AxWindowsMediaPlayerF_1.Ctlcontrols.stop()
                    AxWindowsMediaPlayerF_2.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "2.wmv"
                    AxWindowsMediaPlayerF_2.Visible = False
                    AxWindowsMediaPlayerF_2.Ctlcontrols.stop()
                    AxWindowsMediaPlayerF_3.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "3.wmv"
                    AxWindowsMediaPlayerF_3.Visible = False
                    AxWindowsMediaPlayerF_3.Ctlcontrols.stop()
                    AxWindowsMediaPlayerF_4.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "4.wmv"
                    AxWindowsMediaPlayerF_4.Visible = False
                    AxWindowsMediaPlayerF_4.Ctlcontrols.stop()
                    AxWindowsMediaPlayerF_5.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "5.wmv"
                    AxWindowsMediaPlayerF_5.Visible = False
                    AxWindowsMediaPlayerF_5.Ctlcontrols.stop()
                    AxWindowsMediaPlayerF_6.URL = Application.StartupPath & "\" & list_Pic(n - 1) & "6.wmv"
                Else
                    EndTransaction()
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
        Dim xx As Single = -80
        Dim yy As Single = -120
        If formGraphics Is Nothing Then
            formGraphics = Me.CreateGraphics
            formGraphics.RotateTransform(180.0F)
            drawFont = New System.Drawing.Font("Arial", 32)
            drawBrush = New System.Drawing.SolidBrush(System.Drawing.Color.White)
            drawFormat = New System.Drawing.StringFormat(StringFormatFlags.DirectionVertical)
        End If
        drawString = "$" & drawString
        formGraphics.FillRectangle(Brushes.Black, xx, yy, 40, 120)
        formGraphics.DrawString(drawString, drawFont, drawBrush, xx, yy, drawFormat)
        'drawFont.Dispose()
        'drawBrush.Dispose()
        'formGraphics.Dispose()

    End Sub

End Class
