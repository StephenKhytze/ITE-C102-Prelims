Imports System.DirectoryServices.ActiveDirectory
Imports System.Reflection

Public Class Form2
    Private Sub btnPeri_Click(sender As Object, e As EventArgs) Handles btnRPeri.Click
        Dim length, width, peri As Integer
        Dim First, Middle, Last As String
        First = Form1.txtFirst.Text.ToUpper
        Middle = Form1.txtMiddle.Text.ToUpper
        Last = Form1.txtLast.Text.ToLower
        Dim output As String
        length = txtLength.Text
        width = txtWidth.Text

        peri = (length + width) * 2
        output = "Thank you " + First + " " + Middle + " " + Last + " for using the app. The perimeter of the rectangle is" + Str(peri)
        MessageBox.Show(output, "Geometry Calculator Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnRArea.Click
        Dim length, width, area As Integer
        Dim output As String
        Dim First, Middle, Last As String
        First = Form1.txtFirst.Text.ToUpper
        Middle = Form1.txtMiddle.Text.ToUpper
        Last = Form1.txtLast.Text.ToLower
        length = txtLength.Text
        width = txtWidth.Text

        area = length * width
        output = "Thank you " + First + " " + Middle + " " + Last + " for using the app. The area of the rectangle is" + Str(area)
        MessageBox.Show(output, "Geometry Calculator Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnVol_Click(sender As Object, e As EventArgs) Handles btnRVol.Click
        Dim length, width, height, vol As Integer
        Dim output As String
        Dim First, Middle, Last As String
        First = Form1.txtFirst.Text.ToUpper
        Middle = Form1.txtMiddle.Text.ToUpper
        Last = Form1.txtLast.Text.ToLower
        length = txtLength.Text
        width = txtWidth.Text
        height = txtHeight.Text

        vol = length * width * height
        output = "Thank you " + First + " " + Middle + " " + Last + " for using the app. The volume of the rectangle is" + Str(vol)
        MessageBox.Show(output, "Geometry Calculator Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSPeri_Click(sender As Object, e As EventArgs) Handles btnSPeri.Click
        Dim Side, Peri As Integer
        Dim output As String
        Dim First, Middle, Last As String
        Side = txtSide.Text
        Peri = 4 * Side
        First = Form1.txtFirst.Text.ToUpper
        Middle = Form1.txtMiddle.Text.ToUpper
        Last = Form1.txtLast.Text.ToLower
        output = "Thank you " + First + " " + Middle + " " + Last + " for using the app. The Perimeter of the Square is" + Str(Peri)
        MessageBox.Show(output, "Geometry Calculator Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnSArea_Click(sender As Object, e As EventArgs) Handles btnSArea.Click
        Dim Side, Area As Integer
        Dim output As String
        Dim First, Middle, Last As String
        Side = txtSide.Text
        Area = Side * Side
        First = Form1.txtFirst.Text.ToUpper
        Middle = Form1.txtMiddle.Text.ToUpper
        Last = Form1.txtLast.Text.ToLower
        output = "Thank you " + First + " " + Middle + " " + Last + " for using the app. The Area of the Square is" + Str(Area)
        MessageBox.Show(output, "Geometry Calculator Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnSVol_Click(sender As Object, e As EventArgs) Handles btnSVol.Click
        Dim Side, Volume As Integer
        Dim output As String
        Dim First, Middle, Last As String
        Side = txtSide.Text
        Volume = Side * Side * Side
        First = Form1.txtFirst.Text.ToUpper
        Middle = Form1.txtMiddle.Text.ToUpper
        Last = Form1.txtLast.Text.ToLower
        output = "Thank you " + First + " " + Middle + " " + Last + " for using the app. The Perimeter of the Square is" + Str(Volume)
        MessageBox.Show(output, "Geometry Calculator Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class