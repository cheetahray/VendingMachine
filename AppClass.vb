'
' The contents of this file are subject to the Mozilla Public
' License Version 1.1 (the "License"); you may not use this file
' except in compliance with the License. You may obtain a copy
' of the License at http://www.mozilla.org/MPL/
' 
' Software distributed under the License is distributed on an
' "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or
' implied. See the License for the specific language governing
' rights and limitations under the License.
' 
' The Original Code is State Machine Compiler (SMC).
' 
' The Initial Developer of the Original Code is Charles W. Rapp.
' Portions created by Charles W. Rapp are
' Copyright (C) 2003, 2009. Charles W. Rapp.
' All Rights Reserved.
' 
' Contributor(s): 
'
' Function
'   Main
'
' Description
'  This routine starts the finite state machine running.
'
' RCS ID
' $Id: AppClass.vb,v 1.3 2009/12/17 19:51:43 cwrapp Exp $
'
' CHANGE LOG
' $Log: AppClass.vb,v $
' Revision 1.3  2009/12/17 19:51:43  cwrapp
' Testing complete.
'
' Revision 1.2  2009/03/01 18:20:40  cwrapp
' Preliminary v. 6.0.0 commit.
'
' Revision 1.1  2005/05/28 18:15:21  cwrapp
' Added VB.net examples 1 - 4.
'
' Revision 1.0  2004/05/30 21:12:11  charlesr
' Initial revision
'

Public NotInheritable Class AppClass

    '-----------------------------------------------------------
    ' Member data.
    '
    Dim NoRandom As Integer
    Public RaySix(6), tmpSix(6), FirstSix(6) As SixRandom
    ' The class' associated finite state machine.
    Private _fsm As AppClassContext
    Dim rand As New Random()
    ' Set this flag to true if the given string is accepted by
    ' the FSM.
    'Private _isAcceptable As Boolean
    Public ReceiveBytes, SendBytes As String
    '-----------------------------------------------------------
    ' Member methods.
    '
    Public RayPos(6) As Integer
    Private RayBol(6) As Boolean
    Public MoneyAvailable As Decimal = 0 ' Money deposited by user 
    Public ItemCost As Decimal = 0.0       'Cost of the item
    Public ProductNum As Integer = 0 '商品編號

    Public Sub New()
        For ctr As Integer = 0 To 5
            RaySix(ctr) = New SixRandom
            FirstSix(ctr) = New SixRandom
            RayPos(ctr) = ctr + 1
            tmpSix(ctr) = New SixRandom
            RayBol(ctr) = False
        Next
        NoRandom = 5
        '_isAcceptable = False
        _fsm = New AppClassContext(Me)
        _fsm.EnterStartState()
    End Sub

    Public Sub Over10Sec()
        _fsm.Over10Sec()
    End Sub

    Public Sub backToRotate()
        _fsm.Autoback()
    End Sub

    Public Sub BillIn()
        _fsm.BillIn()
    End Sub

    Public Sub CoinIn()
        _fsm.CoinIn()
    End Sub

    Public Sub BillInAgain()
        _fsm.BillInAgain()
    End Sub

    Public Sub CoinInAgain()
        _fsm.CoinInAgain()
    End Sub

    Public Sub Submit()
        _fsm.Submit()
    End Sub

    Public Sub BillFirstFrame()
        BillAdd()
    End Sub

    Public Sub ToNext()
        _fsm.ToNext()
    End Sub

    Public Sub Change()
        _fsm.Change()
    End Sub

    Public Sub BackStart()
        _fsm.BackStart()
    End Sub

    '錢幣投入
    Private Function ChangeMoney(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer) As Integer
        Dim total As Integer = a * 50 + b * 100 + e * 200 + d * 500 + e * 1000
        'MsgBox(total, MsgBoxStyle.Information, "About")
        MoneyAvailable += total
        Return total
    End Function

    Public Sub CoinFirstFrame()
        CoinAdd()
    End Sub

    Public Sub arrangecombine()
        If NoRandom > 0 Then
            Select Case NoRandom
                Case 1
                    RayPos(0) = 6
                    RayPos(1) = 1
                    RayPos(2) = 2
                    RayPos(3) = 3
                    RayPos(4) = 4
                    RayPos(5) = 5
                Case 2
                    RayPos(0) = 5
                    RayPos(1) = 6
                    RayPos(2) = 1
                    RayPos(3) = 2
                    RayPos(4) = 3
                    RayPos(5) = 4
                Case 3
                    RayPos(0) = 4
                    RayPos(1) = 5
                    RayPos(2) = 6
                    RayPos(3) = 1
                    RayPos(4) = 2
                    RayPos(5) = 3
                Case 4
                    RayPos(0) = 3
                    RayPos(1) = 4
                    RayPos(2) = 5
                    RayPos(3) = 6
                    RayPos(4) = 1
                    RayPos(5) = 2
                Case 5
                    RayPos(0) = 2
                    RayPos(1) = 3
                    RayPos(2) = 4
                    RayPos(3) = 5
                    RayPos(4) = 6
                    RayPos(5) = 1
            End Select
            NoRandom = NoRandom - 1
        Else
            Dim p As Integer
            For ctr As Integer = 0 To 5
                p = rand.NextDouble() * 5
                While RayBol(p) = True
                    p = rand.NextDouble() * 5
                End While
                RayBol(p) = True
                tmpSix(ctr).wmv = FirstSix(p).wmv
                tmpSix(ctr).btn = FirstSix(p).btn
                RayPos(ctr) = p + 1
            Next
        End If
    End Sub

    Public Sub playagain()
        For ctr As Integer = 0 To 5
            RaySix(ctr).wmv = tmpSix(ctr).wmv
            RaySix(ctr).btn = tmpSix(ctr).btn
            RayBol(ctr) = False
        Next
    End Sub

    Public Sub BillAdd()
        Dim intrec As Integer
        intrec = Integer.Parse(ReceiveBytes) / 100
        ReceiveBytes = String.Empty
        ChangeMoney(0, intrec, 0, 0, 0)
        SendBytes = "100ok"
    End Sub

    Public Sub CoinAdd()
        Dim intrec As Integer
        intrec = Integer.Parse(ReceiveBytes) / 50
        ReceiveBytes = String.Empty
        ChangeMoney(intrec, 0, 0, 0, 0)
        SendBytes = "50ok"
    End Sub

    Public Sub playBoom()
        'ItemCost = ItemPrice

        If (ItemCost <= MoneyAvailable) Then

            'MoneyDepositTB.Text = MoneyAvailable.ToString("C")
            SendBytes = "play"

        End If 'ITEM COST

    End Sub

    Public Sub MoviePlayBillOut()

    End Sub

    Public Sub MoviePlayCoinOut()

    End Sub

    Public Sub GlassAndMovie()

    End Sub

    Public Sub PrintImages()

        Dim num As Integer = MoneyAvailable / 50
        MoneyAvailable = 0
        If num <> 0 Then
            SendBytes = "@@" + num.ToString 'MsgBox(num, MsgBoxStyle.Information, "找錢")
        End If
        
    End Sub

    Public Sub glassMoneyChange()

        'ProductNum = 7

    End Sub

End Class
