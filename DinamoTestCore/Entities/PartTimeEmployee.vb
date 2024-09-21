Imports System.Windows
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class PartTimeEmployee
    Inherits Employee

    Private _HourlyRate As Decimal
    Private _HoursWorked As Decimal

    Public Sub New(name As String, Id As Integer, HourlyRate As Decimal, HoursWorked As Decimal)
        MyBase.New(name, Id, HourlyRate * HoursWorked)
        _HourlyRate = HourlyRate
        _HoursWorked = _HoursWorked
    End Sub

    Public Property HourlyRate As Decimal
        Get
            Return _HourlyRate
        End Get
        Set(value As Decimal)
            _HourlyRate = value
            Salary = _HourlyRate * _HoursWorked
        End Set
    End Property

    Public Property HoursWorked As Decimal
        Get
            Return _HoursWorked
        End Get
        Set(value As Decimal)
            _HoursWorked = _HoursWorked
            Salary = _HourlyRate * _HoursWorked
        End Set
    End Property

    Public Overrides Sub GetDetails()
        MessageBox.Show($"PartTimeEmployee Details : " & vbCrLf &
                        $"Name : {Name}" & vbCrLf &
                        $"Id : {Id} " & vbCrLf &
                        $"Hourly Rate  : {HourlyRate:C}" & vbCrLf &
                        $"Hours Worked : {HoursWorked:C}" & vbCrLf &
                        $"Salary : {Salary:C}")
    End Sub
End Class
