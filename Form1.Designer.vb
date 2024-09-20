<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblName = New Label()
        txtName = New TextBox()
        lblId = New Label()
        lblSalary = New Label()
        lblHour = New Label()
        txtId = New TextBox()
        txtSalary = New TextBox()
        rbPartTime = New RadioButton()
        rbFullTime = New RadioButton()
        btnAdd = New Button()
        btnDetails = New Button()
        lstEmployees = New ListBox()
        txtHour = New TextBox()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = SystemColors.ActiveCaption
        lblName.Location = New Point(30, 30)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(150, 27)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 23)
        txtName.TabIndex = 1
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.BackColor = SystemColors.ActiveCaption
        lblId.Location = New Point(30, 70)
        lblId.Name = "lblId"
        lblId.Size = New Size(17, 15)
        lblId.TabIndex = 2
        lblId.Text = "Id"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.BackColor = SystemColors.ActiveCaption
        lblSalary.Location = New Point(30, 110)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(90, 15)
        lblSalary.TabIndex = 3
        lblSalary.Text = "Salary/ HourRat"
        ' 
        ' lblHour
        ' 
        lblHour.AutoSize = True
        lblHour.BackColor = SystemColors.ActiveCaption
        lblHour.Location = New Point(30, 150)
        lblHour.Name = "lblHour"
        lblHour.Size = New Size(80, 15)
        lblHour.TabIndex = 4
        lblHour.Text = "HoursWorked"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(150, 67)
        txtId.Name = "txtId"
        txtId.Size = New Size(200, 23)
        txtId.TabIndex = 5
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(150, 110)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(200, 23)
        txtSalary.TabIndex = 7
        ' 
        ' rbPartTime
        ' 
        rbPartTime.AutoSize = True
        rbPartTime.BackColor = SystemColors.ActiveBorder
        rbPartTime.Location = New Point(226, 190)
        rbPartTime.Name = "rbPartTime"
        rbPartTime.Size = New Size(124, 19)
        rbPartTime.TabIndex = 8
        rbPartTime.TabStop = True
        rbPartTime.Text = "PartTimeEmployee"
        rbPartTime.UseVisualStyleBackColor = False
        ' 
        ' rbFullTime
        ' 
        rbFullTime.AutoSize = True
        rbFullTime.BackColor = SystemColors.ActiveBorder
        rbFullTime.Location = New Point(30, 190)
        rbFullTime.Name = "rbFullTime"
        rbFullTime.Size = New Size(122, 19)
        rbFullTime.TabIndex = 9
        rbFullTime.TabStop = True
        rbFullTime.Text = "FullTimeEmployee"
        rbFullTime.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.MediumBlue
        btnAdd.Location = New Point(30, 230)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 30)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add A New Empolyee"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnDetails
        ' 
        btnDetails.BackColor = Color.MediumBlue
        btnDetails.Location = New Point(200, 230)
        btnDetails.Name = "btnDetails"
        btnDetails.Size = New Size(150, 30)
        btnDetails.TabIndex = 11
        btnDetails.Text = "Details"
        btnDetails.UseVisualStyleBackColor = False
        ' 
        ' lstEmployees
        ' 
        lstEmployees.FormattingEnabled = True
        lstEmployees.ItemHeight = 15
        lstEmployees.Location = New Point(400, 26)
        lstEmployees.Name = "lstEmployees"
        lstEmployees.Size = New Size(300, 214)
        lstEmployees.TabIndex = 12
        ' 
        ' txtHour
        ' 
        txtHour.Location = New Point(150, 147)
        txtHour.Name = "txtHour"
        txtHour.Size = New Size(200, 23)
        txtHour.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(733, 450)
        Controls.Add(lstEmployees)
        Controls.Add(btnDetails)
        Controls.Add(btnAdd)
        Controls.Add(rbFullTime)
        Controls.Add(rbPartTime)
        Controls.Add(txtSalary)
        Controls.Add(txtHour)
        Controls.Add(txtId)
        Controls.Add(lblHour)
        Controls.Add(lblSalary)
        Controls.Add(lblId)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Location = New Point(150, 120)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        Text = "Employee Mangment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents rbPartTime As RadioButton
    Friend WithEvents rbFullTime As RadioButton
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents lstEmployees As ListBox
    Friend WithEvents txtHour As TextBox

End Class
