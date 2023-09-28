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
        lblStudent = New Label()
        lblFirst = New Label()
        lblMiddle = New Label()
        lblLast = New Label()
        lblAge = New Label()
        lblBirthday = New Label()
        lblAddress = New Label()
        lblGradeLevel = New Label()
        txtFirst = New TextBox()
        txtMiddle = New TextBox()
        txtLast = New TextBox()
        txtAge = New TextBox()
        txtBirthday = New TextBox()
        txtAddress = New TextBox()
        txtGradeLevel = New TextBox()
        btnEnable = New Button()
        btnDisable = New Button()
        btnSmallcaps = New Button()
        btnInput = New Button()
        btnAllCaps = New Button()
        btnClearAll = New Button()
        rchOutput = New RichTextBox()
        btnHideAll = New Button()
        btnRed = New Button()
        btnBlue = New Button()
        btnGreen = New Button()
        btnShow = New Button()
        txtFontSize = New TextBox()
        lblFontSize = New Label()
        btnGeom = New Button()
        btnWhite = New Button()
        SuspendLayout()
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblStudent.Location = New Point(694, 11)
        lblStudent.Margin = New Padding(4, 0, 4, 0)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(220, 26)
        lblStudent.TabIndex = 0
        lblStudent.Text = "Student Information"
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblFirst.Location = New Point(64, 93)
        lblFirst.Margin = New Padding(4, 0, 4, 0)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(127, 26)
        lblFirst.TabIndex = 1
        lblFirst.Text = "First Name"
        ' 
        ' lblMiddle
        ' 
        lblMiddle.AutoSize = True
        lblMiddle.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblMiddle.Location = New Point(40, 136)
        lblMiddle.Margin = New Padding(4, 0, 4, 0)
        lblMiddle.Name = "lblMiddle"
        lblMiddle.Size = New Size(151, 26)
        lblMiddle.TabIndex = 2
        lblMiddle.Text = "Middle Name"
        ' 
        ' lblLast
        ' 
        lblLast.AutoSize = True
        lblLast.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblLast.Location = New Point(69, 179)
        lblLast.Margin = New Padding(4, 0, 4, 0)
        lblLast.Name = "lblLast"
        lblLast.Size = New Size(122, 26)
        lblLast.TabIndex = 3
        lblLast.Text = "Last Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAge.Location = New Point(139, 222)
        lblAge.Margin = New Padding(4, 0, 4, 0)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(52, 26)
        lblAge.TabIndex = 4
        lblAge.Text = "Age"
        ' 
        ' lblBirthday
        ' 
        lblBirthday.AutoSize = True
        lblBirthday.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblBirthday.Location = New Point(87, 261)
        lblBirthday.Margin = New Padding(4, 0, 4, 0)
        lblBirthday.Name = "lblBirthday"
        lblBirthday.Size = New Size(104, 26)
        lblBirthday.TabIndex = 5
        lblBirthday.Text = "Birthday"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAddress.Location = New Point(96, 308)
        lblAddress.Margin = New Padding(4, 0, 4, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(95, 26)
        lblAddress.TabIndex = 6
        lblAddress.Text = "Address"
        ' 
        ' lblGradeLevel
        ' 
        lblGradeLevel.AutoSize = True
        lblGradeLevel.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblGradeLevel.Location = New Point(52, 351)
        lblGradeLevel.Margin = New Padding(4, 0, 4, 0)
        lblGradeLevel.Name = "lblGradeLevel"
        lblGradeLevel.Size = New Size(139, 26)
        lblGradeLevel.TabIndex = 7
        lblGradeLevel.Text = "Grade Level"
        ' 
        ' txtFirst
        ' 
        txtFirst.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFirst.Location = New Point(206, 84)
        txtFirst.Margin = New Padding(4)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(221, 35)
        txtFirst.TabIndex = 8
        ' 
        ' txtMiddle
        ' 
        txtMiddle.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtMiddle.Location = New Point(206, 127)
        txtMiddle.Margin = New Padding(4)
        txtMiddle.Name = "txtMiddle"
        txtMiddle.Size = New Size(221, 35)
        txtMiddle.TabIndex = 9
        ' 
        ' txtLast
        ' 
        txtLast.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtLast.Location = New Point(206, 170)
        txtLast.Margin = New Padding(4)
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(221, 35)
        txtLast.TabIndex = 10
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtAge.Location = New Point(206, 213)
        txtAge.Margin = New Padding(4)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(221, 35)
        txtAge.TabIndex = 11
        ' 
        ' txtBirthday
        ' 
        txtBirthday.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBirthday.Location = New Point(206, 256)
        txtBirthday.Margin = New Padding(4)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(221, 35)
        txtBirthday.TabIndex = 12
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtAddress.Location = New Point(206, 299)
        txtAddress.Margin = New Padding(4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(221, 35)
        txtAddress.TabIndex = 13
        ' 
        ' txtGradeLevel
        ' 
        txtGradeLevel.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtGradeLevel.Location = New Point(206, 342)
        txtGradeLevel.Margin = New Padding(4)
        txtGradeLevel.Name = "txtGradeLevel"
        txtGradeLevel.Size = New Size(221, 35)
        txtGradeLevel.TabIndex = 14
        ' 
        ' btnEnable
        ' 
        btnEnable.BackColor = Color.Honeydew
        btnEnable.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnable.Location = New Point(1046, 136)
        btnEnable.Margin = New Padding(4)
        btnEnable.Name = "btnEnable"
        btnEnable.Size = New Size(118, 36)
        btnEnable.TabIndex = 15
        btnEnable.Text = "Enable"
        btnEnable.UseVisualStyleBackColor = False
        ' 
        ' btnDisable
        ' 
        btnDisable.BackColor = Color.Honeydew
        btnDisable.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDisable.Location = New Point(1234, 135)
        btnDisable.Margin = New Padding(4)
        btnDisable.Name = "btnDisable"
        btnDisable.Size = New Size(118, 36)
        btnDisable.TabIndex = 16
        btnDisable.Text = "Disable"
        btnDisable.UseVisualStyleBackColor = False
        ' 
        ' btnSmallcaps
        ' 
        btnSmallcaps.BackColor = Color.Honeydew
        btnSmallcaps.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSmallcaps.Location = New Point(1018, 188)
        btnSmallcaps.Margin = New Padding(4)
        btnSmallcaps.Name = "btnSmallcaps"
        btnSmallcaps.Size = New Size(168, 36)
        btnSmallcaps.TabIndex = 17
        btnSmallcaps.Text = "Small Caps"
        btnSmallcaps.UseVisualStyleBackColor = False
        ' 
        ' btnInput
        ' 
        btnInput.BackColor = Color.Honeydew
        btnInput.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnInput.Location = New Point(1018, 232)
        btnInput.Margin = New Padding(4)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(357, 55)
        btnInput.TabIndex = 18
        btnInput.Text = "Generate input"
        btnInput.UseVisualStyleBackColor = False
        ' 
        ' btnAllCaps
        ' 
        btnAllCaps.BackColor = Color.Honeydew
        btnAllCaps.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAllCaps.Location = New Point(1207, 188)
        btnAllCaps.Margin = New Padding(4)
        btnAllCaps.Name = "btnAllCaps"
        btnAllCaps.Size = New Size(168, 36)
        btnAllCaps.TabIndex = 19
        btnAllCaps.Text = "All Caps"
        btnAllCaps.UseVisualStyleBackColor = False
        ' 
        ' btnClearAll
        ' 
        btnClearAll.BackColor = Color.Honeydew
        btnClearAll.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnClearAll.Location = New Point(1018, 295)
        btnClearAll.Margin = New Padding(4)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(357, 48)
        btnClearAll.TabIndex = 20
        btnClearAll.Text = "Clear All"
        btnClearAll.UseVisualStyleBackColor = False
        ' 
        ' rchOutput
        ' 
        rchOutput.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rchOutput.Location = New Point(456, 84)
        rchOutput.Margin = New Padding(4)
        rchOutput.Name = "rchOutput"
        rchOutput.Size = New Size(554, 336)
        rchOutput.TabIndex = 21
        rchOutput.Text = ""
        ' 
        ' btnHideAll
        ' 
        btnHideAll.BackColor = Color.Honeydew
        btnHideAll.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnHideAll.Location = New Point(1018, 360)
        btnHideAll.Margin = New Padding(4)
        btnHideAll.Name = "btnHideAll"
        btnHideAll.Size = New Size(168, 36)
        btnHideAll.TabIndex = 22
        btnHideAll.Text = "Hide All"
        btnHideAll.UseVisualStyleBackColor = False
        ' 
        ' btnRed
        ' 
        btnRed.BackColor = Color.Red
        btnRed.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRed.Location = New Point(458, 428)
        btnRed.Margin = New Padding(4)
        btnRed.Name = "btnRed"
        btnRed.Size = New Size(282, 58)
        btnRed.TabIndex = 23
        btnRed.UseVisualStyleBackColor = False
        ' 
        ' btnBlue
        ' 
        btnBlue.BackColor = Color.Blue
        btnBlue.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBlue.Location = New Point(726, 428)
        btnBlue.Margin = New Padding(4)
        btnBlue.Name = "btnBlue"
        btnBlue.Size = New Size(284, 59)
        btnBlue.TabIndex = 24
        btnBlue.UseVisualStyleBackColor = False
        ' 
        ' btnGreen
        ' 
        btnGreen.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnGreen.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnGreen.Location = New Point(726, 487)
        btnGreen.Margin = New Padding(4)
        btnGreen.Name = "btnGreen"
        btnGreen.Size = New Size(284, 58)
        btnGreen.TabIndex = 25
        btnGreen.UseVisualStyleBackColor = False
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = Color.Honeydew
        btnShow.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnShow.Location = New Point(1207, 360)
        btnShow.Margin = New Padding(4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(168, 36)
        btnShow.TabIndex = 26
        btnShow.Text = "Show All"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' txtFontSize
        ' 
        txtFontSize.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFontSize.Location = New Point(206, 385)
        txtFontSize.Margin = New Padding(4)
        txtFontSize.Name = "txtFontSize"
        txtFontSize.Size = New Size(221, 35)
        txtFontSize.TabIndex = 27
        ' 
        ' lblFontSize
        ' 
        lblFontSize.AutoSize = True
        lblFontSize.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblFontSize.Location = New Point(85, 394)
        lblFontSize.Margin = New Padding(4, 0, 4, 0)
        lblFontSize.Name = "lblFontSize"
        lblFontSize.Size = New Size(106, 26)
        lblFontSize.TabIndex = 28
        lblFontSize.Text = "Font Size"
        ' 
        ' btnGeom
        ' 
        btnGeom.BackColor = Color.Honeydew
        btnGeom.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnGeom.Location = New Point(1018, 430)
        btnGeom.Margin = New Padding(4)
        btnGeom.Name = "btnGeom"
        btnGeom.Size = New Size(357, 57)
        btnGeom.TabIndex = 29
        btnGeom.Text = "Go to Geometry Class"
        btnGeom.UseVisualStyleBackColor = False
        ' 
        ' btnWhite
        ' 
        btnWhite.BackColor = Color.White
        btnWhite.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnWhite.Location = New Point(458, 487)
        btnWhite.Margin = New Padding(4)
        btnWhite.Name = "btnWhite"
        btnWhite.Size = New Size(273, 58)
        btnWhite.TabIndex = 30
        btnWhite.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1692, 689)
        Controls.Add(btnWhite)
        Controls.Add(btnGeom)
        Controls.Add(lblFontSize)
        Controls.Add(txtFontSize)
        Controls.Add(btnShow)
        Controls.Add(btnGreen)
        Controls.Add(btnBlue)
        Controls.Add(btnRed)
        Controls.Add(btnHideAll)
        Controls.Add(rchOutput)
        Controls.Add(btnClearAll)
        Controls.Add(btnAllCaps)
        Controls.Add(btnInput)
        Controls.Add(btnSmallcaps)
        Controls.Add(btnDisable)
        Controls.Add(btnEnable)
        Controls.Add(txtGradeLevel)
        Controls.Add(txtAddress)
        Controls.Add(txtBirthday)
        Controls.Add(txtAge)
        Controls.Add(txtLast)
        Controls.Add(txtMiddle)
        Controls.Add(txtFirst)
        Controls.Add(lblGradeLevel)
        Controls.Add(lblAddress)
        Controls.Add(lblBirthday)
        Controls.Add(lblAge)
        Controls.Add(lblLast)
        Controls.Add(lblMiddle)
        Controls.Add(lblFirst)
        Controls.Add(lblStudent)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Student Information"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStudent As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGradeLevel As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtGradeLevel As TextBox
    Friend WithEvents btnEnable As Button
    Friend WithEvents btnDisable As Button
    Friend WithEvents btnSmallcaps As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents btnAllCaps As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents rchOutput As RichTextBox
    Friend WithEvents btnHideAll As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents txtFontSize As TextBox
    Friend WithEvents lblFontSize As Label
    Friend WithEvents btnGeom As Button
    Friend WithEvents btnWhite As Button
End Class
