Imports DinamoTestCore

Public Class Form1
    Private employee As New List(Of Employee)()



    Private Sub rbFullTime_CheckedChanged(sender As Object, e As EventArgs) Handles rbFullTime.CheckedChanged
        If rbFullTime.Checked Then
            lblSalary.Text = "Annaul Salary :"
            txtHour.Visible = False
            lblHour.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHour.Visible = False
        lblHour.Visible = False
    End Sub

    Private Sub rbPartTime_CheckedChanged(sender As Object, e As EventArgs) Handles rbPartTime.CheckedChanged
        If rbPartTime.Checked Then
            lblSalary.Text = "Hourly Rate:"
            txtHour.Visible = True
            lblHour.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtId.Text) OrElse
           String.IsNullOrWhiteSpace(txtSalary.Text) Then
            MessageBox.Show("Please Fiil in All Required Fieleds.")
            Return
        End If
        Dim Name As String = txtName.Text
        Dim Id As Integer
        Dim Salary As Decimal
        If Not Integer.TryParse(txtId.Text, Id) Then
            MessageBox.Show("Please Enter A Valid Id .", "Imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not Decimal.TryParse(txtSalary.Text, Salary) Then
            MessageBox.Show("Please Enter A Valid Salary.", "Imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If rbFullTime.Checked Then
            Dim FullTimeEmp As New FullTimeEmployee(Name, Id, Salary)
            employee.Add(FullTimeEmp)
            lstEmployees.Items.Add($"FullTime Emplyee : {Name} (Id : {Salary})")
        ElseIf rbPartTime.Checked Then
            If String.IsNullOrWhiteSpace(txtHour.Text) Then
                MessageBox.Show("Please Enter Hour Worked For Part Time Employee.", "Imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim Hours As Decimal
            If Not Decimal.TryParse(txtHour.Text, Hours) Then
                MessageBox.Show("Please Enter A Valed Namber Of Hours Worked.", "Imput Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim partTimeEmp As New PartTimeEmployee(Name, Id, Salary, Hours)
            employee.Add(partTimeEmp)
            lstEmployees.Items.Add($"Part Time Employee : {Name} , (ID : {Id})")
        Else
            MessageBox.Show("Please Select The Employee Type .")
            Return

        End If
        txtName.Clear()
        txtId.Clear()
        txtSalary.Clear()
        txtHour.Clear()

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        If lstEmployees.SelectedIndex = -1 Then
            MessageBox.Show("Please Select An Employee From List.")
            Return
        End If
        Dim SelectedEmployee As Employee = employee(lstEmployees.SelectedIndex)
        SelectedEmployee.GetDetails()
    End Sub


End Class



