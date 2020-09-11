Public Class AKTIFITAS5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dblNo1 As Double
        Dim dblAnswer As Double
        dblNo1 = Val(TextBox1.Text)
        If (RadioButton1.Checked) Then
            dblAnswer = dblNo1 * ("2.54")
            Label5.Text = ("Centimeters")
        ElseIf (RadioButton2.Checked) Then
            dblAnswer = dblNo1 / ("2.54")
            Label5.Text = ("Inches")
        End If
        Label7.Text = Str(dblAnswer)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class