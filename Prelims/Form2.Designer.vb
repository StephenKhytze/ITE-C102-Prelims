<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtLength = New TextBox()
        txtWidth = New TextBox()
        txtHeight = New TextBox()
        btnRPeri = New Button()
        btnRArea = New Button()
        btnRVol = New Button()
        Label5 = New Label()
        txtSide = New TextBox()
        Label6 = New Label()
        btnSVol = New Button()
        btnSArea = New Button()
        btnSPeri = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(158, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 32)
        Label1.TabIndex = 0
        Label1.Text = "Rectangle"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(52, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 32)
        Label2.TabIndex = 1
        Label2.Text = "Length"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(52, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 32)
        Label3.TabIndex = 2
        Label3.Text = "Width"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(52, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 32)
        Label4.TabIndex = 3
        Label4.Text = "Height"
        ' 
        ' txtLength
        ' 
        txtLength.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        txtLength.Location = New Point(158, 75)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(150, 40)
        txtLength.TabIndex = 4
        ' 
        ' txtWidth
        ' 
        txtWidth.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        txtWidth.Location = New Point(158, 121)
        txtWidth.Name = "txtWidth"
        txtWidth.Size = New Size(150, 40)
        txtWidth.TabIndex = 5
        ' 
        ' txtHeight
        ' 
        txtHeight.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        txtHeight.Location = New Point(158, 166)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(150, 40)
        txtHeight.TabIndex = 6
        ' 
        ' btnRPeri
        ' 
        btnRPeri.BackColor = Color.Honeydew
        btnRPeri.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnRPeri.Location = New Point(350, 75)
        btnRPeri.Name = "btnRPeri"
        btnRPeri.Size = New Size(154, 37)
        btnRPeri.TabIndex = 7
        btnRPeri.Text = "Perimeter"
        btnRPeri.UseVisualStyleBackColor = False
        ' 
        ' btnRArea
        ' 
        btnRArea.BackColor = Color.Honeydew
        btnRArea.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnRArea.Location = New Point(350, 119)
        btnRArea.Name = "btnRArea"
        btnRArea.Size = New Size(154, 42)
        btnRArea.TabIndex = 8
        btnRArea.Text = "Area"
        btnRArea.UseVisualStyleBackColor = False
        ' 
        ' btnRVol
        ' 
        btnRVol.BackColor = Color.Honeydew
        btnRVol.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnRVol.Location = New Point(350, 167)
        btnRVol.Name = "btnRVol"
        btnRVol.Size = New Size(154, 39)
        btnRVol.TabIndex = 9
        btnRVol.Text = "Volume"
        btnRVol.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(717, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 32)
        Label5.TabIndex = 10
        Label5.Text = "Square"
        ' 
        ' txtSide
        ' 
        txtSide.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        txtSide.Location = New Point(681, 124)
        txtSide.Name = "txtSide"
        txtSide.Size = New Size(150, 40)
        txtSide.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(601, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 32)
        Label6.TabIndex = 11
        Label6.Text = "Side"
        ' 
        ' btnSVol
        ' 
        btnSVol.BackColor = Color.Honeydew
        btnSVol.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnSVol.Location = New Point(859, 167)
        btnSVol.Name = "btnSVol"
        btnSVol.Size = New Size(148, 39)
        btnSVol.TabIndex = 15
        btnSVol.Text = "Volume"
        btnSVol.UseVisualStyleBackColor = False
        ' 
        ' btnSArea
        ' 
        btnSArea.BackColor = Color.Honeydew
        btnSArea.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnSArea.Location = New Point(859, 116)
        btnSArea.Name = "btnSArea"
        btnSArea.Size = New Size(148, 45)
        btnSArea.TabIndex = 14
        btnSArea.Text = "Area"
        btnSArea.UseVisualStyleBackColor = False
        ' 
        ' btnSPeri
        ' 
        btnSPeri.BackColor = Color.Honeydew
        btnSPeri.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnSPeri.Location = New Point(859, 75)
        btnSPeri.Name = "btnSPeri"
        btnSPeri.Size = New Size(148, 35)
        btnSPeri.TabIndex = 13
        btnSPeri.Text = "Perimeter"
        btnSPeri.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.RoyalBlue
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(290, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.RoyalBlue
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(822, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(60, 60)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1056, 261)
        Controls.Add(PictureBox2)
        Controls.Add(btnSVol)
        Controls.Add(btnSArea)
        Controls.Add(btnSPeri)
        Controls.Add(txtSide)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnRVol)
        Controls.Add(btnRArea)
        Controls.Add(btnRPeri)
        Controls.Add(txtHeight)
        Controls.Add(txtWidth)
        Controls.Add(txtLength)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents btnRPeri As Button
    Friend WithEvents btnRArea As Button
    Friend WithEvents btnRVol As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSide As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSVol As Button
    Friend WithEvents btnSArea As Button
    Friend WithEvents btnSPeri As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
