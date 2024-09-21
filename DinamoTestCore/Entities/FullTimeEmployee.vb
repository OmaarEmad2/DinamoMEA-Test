Imports System.Net.Http
Imports System.Windows
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class FullTimeEmployee

    Inherits Employee
    Public Sub New(Name As String, Id As Integer, annualSalary As Decimal)
        MyBase.New(Name, Id, annualSalary)
    End Sub

    Public Overrides Sub GetDetails()
        MessageBox.Show($"FullTime Emmloyee Details : " & vbCrLf &
                        $"Name : {Name}" & vbCrLf &
                        $"Id : {Id}" & vbCrLf &
                        $"Annual Salary : {Salary:C}")
    End Sub

End Class
