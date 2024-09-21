Imports System.Runtime.CompilerServices
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public MustInherit Class Employee

    Private _Name As String
    Private _Id As Integer
    Private _Salary As Decimal

    Public Sub New(Name As String, Id As Integer, Salary As Decimal)
        _Name = Name
        _Id = _Id
        _Salary = Salary
    End Sub

    Public Property Name As String
        Get
            Return _Name

        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Id As Integer
        Get

            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Salary As Decimal
        Get
            Return _Salary
        End Get
        Set(value As Decimal)
            _Salary = value
        End Set
    End Property


    Public MustOverride Sub GetDetails()

End Class
