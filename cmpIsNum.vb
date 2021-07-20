'*********************************************************
'****************This Code is written by******************
'******Rupish Arora, Anoop Chargotra, Raj Dev Manhas******
'**********************of GCET Jammu**********************
'****************as their Final Year Project**************
'******************code named "CafeManager"***************
'**********************under guidance of******************
'*****Mrs. Bhawna Sharma(Sr. Lecturer, Computer Deptt.****
'*********************************************************

' This is a component written in Visual Basic .NET
' This component will return true if a string only
' contains digits and false otherwise.

Namespace tmpComp
    Public Class cmpIsNum
        Inherits System.ComponentModel.Component

#Region " Component Designer generated code "

        Public Sub New(ByVal Container As System.ComponentModel.IContainer)
            MyClass.New()

            'Required for Windows.Forms Class Composition Designer support
            Container.Add(Me)
        End Sub

        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'Component overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Component Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
        End Sub

#End Region
        Public Function isNum(ByVal strTemp As String) As Boolean

            Dim intI As Integer

            If IsNumeric(strTemp) Or strTemp = "" Then
                isNum = True
            Else
                isNum = False
            End If

        End Function

        Public Function isNumric(ByVal strTemp As String) As Boolean

            Dim intI As Integer

            If IsNumeric(strTemp) Then
                isNumric = True
            Else
                isNumric = False
            End If

        End Function
    End Class
End Namespace
