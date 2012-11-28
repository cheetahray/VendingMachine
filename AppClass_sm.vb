
'
' The contents of this file are subject to the Mozilla Public
' License Version 1.1 (the "License"); you may not use this file
' except in compliance with the License. You may obtain a copy of
' the License at http://www.mozilla.org/MPL/
' 
' Software distributed under the License is distributed on an "AS
' IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or
' implied. See the License for the specific language governing
' rights and limitations under the License.
' 
' The Original Code is State Machine Compiler (SMC).
' 
' The Initial Developer of the Original Code is Charles W. Rapp.
' Portions created by Charles W. Rapp are
' Copyright (C) 2000 - 2003 Charles W. Rapp.
' All Rights Reserved.
' 
' Contributor(s): 
'
' State Machine
'	This state machine is recognizes the regular expression 0*1*.
'
' RCS ID
' $Id: AppClass.sm,v 1.1 2005/05/28 18:15:21 cwrapp Exp $
'
' CHANGE LOG
' $Log: AppClass.sm,v $
' Revision 1.1  2005/05/28 18:15:21  cwrapp
' Added VB.net examples 1 - 4.
'
' Revision 1.0  2004/05/30 21:12:03  charlesr
' Initial revision
'



Public NotInheritable Class AppClassContext
    Inherits statemap.FSMContext

    '------------------------------------------------------------
    ' Member data
    '

    ' The associated application class instance.
    Private _owner As AppClass

    '------------------------------------------------------------
    ' Properties
    '

    Public Property State() As AppClassState
        Get
            If state_ Is Nothing _
            Then
                Throw New statemap.StateUndefinedException()
            End If

            Return state_
        End Get

        Set(ByVal state As AppClassState)

            state_ = state
        End Set
    End Property

    Public Property Owner() As AppClass
        Get
            Return _owner
        End Get
        Set(ByVal owner As AppClass)

            If owner Is Nothing _
            Then
                Throw New NullReferenceException
            End If

            _owner = owner
        End Set
    End Property

    '------------------------------------------------------------
    ' Member methods
    '

    Public Sub New(ByRef owner As AppClass)

        MyBase.New(Vending.Rotate)
        _owner = owner
    End Sub

    Public Overrides Sub EnterStartState()

        State.Entry(Me)
    End Sub

    Public Sub Autoback()

        transition_ = "Autoback"
        State.Autoback(Me)
        transition_ = ""
    End Sub

    Public Sub BackStart()

        transition_ = "BackStart"
        State.BackStart(Me)
        transition_ = ""
    End Sub

    Public Sub BillIn()

        transition_ = "BillIn"
        State.BillIn(Me)
        transition_ = ""
    End Sub

    Public Sub BillInAgain()

        transition_ = "BillInAgain"
        State.BillInAgain(Me)
        transition_ = ""
    End Sub

    Public Sub BillOut()

        transition_ = "BillOut"
        State.BillOut(Me)
        transition_ = ""
    End Sub

    Public Sub BillOutAgain()

        transition_ = "BillOutAgain"
        State.BillOutAgain(Me)
        transition_ = ""
    End Sub

    Public Sub Change()

        transition_ = "Change"
        State.Change(Me)
        transition_ = ""
    End Sub

    Public Sub CoinIn()

        transition_ = "CoinIn"
        State.CoinIn(Me)
        transition_ = ""
    End Sub

    Public Sub CoinInAgain()

        transition_ = "CoinInAgain"
        State.CoinInAgain(Me)
        transition_ = ""
    End Sub

    Public Sub CoinOut()

        transition_ = "CoinOut"
        State.CoinOut(Me)
        transition_ = ""
    End Sub

    Public Sub CoinOutAgain()

        transition_ = "CoinOutAgain"
        State.CoinOutAgain(Me)
        transition_ = ""
    End Sub

    Public Sub Over10Sec()

        transition_ = "Over10Sec"
        State.Over10Sec(Me)
        transition_ = ""
    End Sub

    Public Sub Submit()

        transition_ = "Submit"
        State.Submit(Me)
        transition_ = ""
    End Sub

    Public Sub ToNext()

        transition_ = "ToNext"
        State.ToNext(Me)
        transition_ = ""
    End Sub

End Class

Public MustInherit Class AppClassState
    Inherits statemap.State

    '------------------------------------------------------------
    ' Member methods
    '

    Protected Sub New(ByVal name As String, ByVal id As Integer)

        MyBase.New(name, id)
    End Sub

    Public Overridable Sub Entry(ByRef context As AppClassContext)
    End Sub

    Public Overridable Sub Exit_(ByRef context As AppClassContext)
    End Sub

    Public Overridable Sub Autoback(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub BackStart(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub BillIn(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub BillInAgain(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub BillOut(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub BillOutAgain(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub Change(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub CoinIn(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub CoinInAgain(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub CoinOut(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub CoinOutAgain(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub Over10Sec(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub Submit(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub ToNext(ByRef context As AppClassContext)

        Default_(context)
    End Sub

    Public Overridable Sub Default_(ByRef context As AppClassContext)

        Throw New statemap.TransitionUndefinedException( _
            String.Concat("State: ", _
               context.State.Name, _
               ", Transition: ", _
               context.GetTransition()))
    End Sub
End Class

Public MustInherit Class Vending

    '------------------------------------------------------------
    ' Shared data
    '

    Public Shared Rotate As Vending_Rotate = _
        New Vending_Rotate("Vending.Rotate", 0)
    Public Shared RandomRay As Vending_RandomRay = _
        New Vending_RandomRay("Vending.RandomRay", 1)
    Public Shared Attentation As Vending_Attentation = _
        New Vending_Attentation("Vending.Attentation", 2)
    Public Shared Strike As Vending_Strike = _
        New Vending_Strike("Vending.Strike", 3)
    Public Shared SecondView As Vending_SecondView = _
        New Vending_SecondView("Vending.SecondView", 4)
    Public Shared ReturnRay As Vending_ReturnRay = _
        New Vending_ReturnRay("Vending.ReturnRay", 5)
    Private Shared Default_ As Vending_Default = _
        New Vending_Default("Vending.Default", -1)

End Class

Public Class Vending_Default
    Inherits AppClassState

    '------------------------------------------------------------
    ' Member methods
    '

    Public Sub New(ByVal name As String, ByVal id As Integer)

        MyBase.New(name, id)
    End Sub

End Class

Public NotInheritable Class Vending_Rotate
    Inherits Vending_Default

    '------------------------------------------------------------
    ' Member methods
    '

    Public Sub New(ByVal name As String, ByVal id As Integer)

        MyBase.New(name, id)
    End Sub

    Public Overrides Sub BillIn(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.BillFirstFrame()
        Finally
            context.State = Vending.Attentation
            context.State.Entry(context)
        End Try
    End Sub

    Public Overrides Sub CoinIn(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.CoinFirstFrame()
        Finally
            context.State = Vending.Attentation
            context.State.Entry(context)
        End Try
    End Sub

    Public Overrides Sub Over10Sec(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.arrangecombine()
        Finally
            context.State = Vending.RandomRay
            context.State.Entry(context)
        End Try
    End Sub
End Class

Public NotInheritable Class Vending_RandomRay
    Inherits Vending_Default

    '------------------------------------------------------------
    ' Member methods
    '

    Public Sub New(ByVal name As String, ByVal id As Integer)

        MyBase.New(name, id)
    End Sub

    Public Overrides Sub Autoback(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.playagain()
        Finally
            context.State = Vending.Rotate
            context.State.Entry(context)
        End Try
    End Sub
End Class

Public NotInheritable Class Vending_Attentation
    Inherits Vending_Default

    '------------------------------------------------------------
    ' Member methods
    '

    Public Sub New(ByVal name As String, ByVal id As Integer)

        MyBase.New(name, id)
    End Sub

    Public Overrides Sub BillInAgain(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.BillAdd()
        Finally
            context.State = Vending.Attentation
            context.State.Entry(context)
        End Try
    End Sub

    Public Overrides Sub CoinInAgain(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.CoinAdd()
        Finally
            context.State = Vending.Attentation
            context.State.Entry(context)
        End Try
    End Sub

    Public Overrides Sub Submit(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.playBoom()
        Finally
            context.State = Vending.Strike
            context.State.Entry(context)
        End Try
    End Sub
End Class

Public NotInheritable Class Vending_Strike
    Inherits Vending_Default

    '------------------------------------------------------------
    ' Member methods
    '

    Public Sub New(ByVal name As String, ByVal id As Integer)

        MyBase.New(name, id)
    End Sub

    Public Overrides Sub BillOut(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.MoviePlayBillOut()
        Finally
            context.State = Vending.Strike
            context.State.Entry(context)
        End Try
    End Sub

    Public Overrides Sub CoinOut(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.MoviePlayCoinOut()
        Finally
            context.State = Vending.Strike
            context.State.Entry(context)
        End Try
    End Sub

    Public Overrides Sub ToNext(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.GlassAndMovie()
        Finally
            context.State = Vending.SecondView
            context.State.Entry(context)
        End Try
    End Sub
End Class

Public NotInheritable Class Vending_SecondView
    Inherits Vending_Default

    '------------------------------------------------------------
    ' Member methods
    '

    Public Sub New(ByVal name As String, ByVal id As Integer)

        MyBase.New(name, id)
    End Sub

    Public Overrides Sub BillOutAgain(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.MoviePlayBillOut()
        Finally
            context.State = Vending.SecondView
            context.State.Entry(context)
        End Try
    End Sub

    Public Overrides Sub Change(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.PrintImages()
        Finally
            context.State = Vending.ReturnRay
            context.State.Entry(context)
        End Try
    End Sub

    Public Overrides Sub CoinOutAgain(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.MoviePlayCoinOut()
        Finally
            context.State = Vending.SecondView
            context.State.Entry(context)
        End Try
    End Sub
End Class

Public NotInheritable Class Vending_ReturnRay
    Inherits Vending_Default

    '------------------------------------------------------------
    ' Member methods
    '

    Public Sub New(ByVal name As String, ByVal id As Integer)

        MyBase.New(name, id)
    End Sub

    Public Overrides Sub BackStart(ByRef context As AppClassContext)

        Dim ctxt As AppClass = context.Owner
        context.State.Exit_(context)
        context.ClearState()
        Try
            ctxt.glassMoneyChange()
        Finally
            context.State = Vending.Rotate
            context.State.Entry(context)
        End Try
    End Sub
End Class
