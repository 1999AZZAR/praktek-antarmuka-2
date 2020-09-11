Public Class AKTIFITAS4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim No1 As Double
        Dim No2 As Double
        Dim intError As Integer
        No1 = Val(TextBox1.Text)
        No2 = Val(TextBox2.Text)
        If ComboBox1.SelectedIndex = 0 Then
            Label4.Text = No1 + No2
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label4.Text = No1 - No2
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Label4.Text = No1 * No2
        ElseIf ComboBox1.SelectedIndex = 3 Then
            If No2 = 0 Then
                intError = MsgBox("Can't Divide With 0", vbOKCancel)
            Else
                Label4.Text = No1 / No2
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class