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

    ' The class' associated finite state machine.
    Private _fsm As AppClassContext

    ' Set this flag to true if the given string is accepted by
    ' the FSM.
    'Private _isAcceptable As Boolean

    '-----------------------------------------------------------
    ' Member methods.
    '

    Public Sub New()

        '_isAcceptable = False
        _fsm = New AppClassContext(Me)
    End Sub

    Public Function CheckString(ByVal s As String) As Boolean

        _fsm.EnterStartState()

        Return True
    End Function

    Public Sub BillFirstFrame()

    End Sub

    Public Sub CoinFirstFrame()

    End Sub

    Public Sub arrangecombine()

    End Sub

    Public Sub playagain()

    End Sub

    Public Sub BillAdd()

    End Sub

    Public Sub CoinAdd()

    End Sub

    Public Sub playBoom()

    End Sub

    Public Sub MoviePlayBillOut()

    End Sub

    Public Sub MoviePlayCoinOut()

    End Sub

    Public Sub GlassAndMovie()

    End Sub

    Public Sub PrintImages()

    End Sub

    Public Sub glassMoneyChange()

    End Sub

End Class
