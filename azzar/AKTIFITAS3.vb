Public Class AKTIFITAS3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strQuestion As String
        Dim intAnswer As Integer
        'First you must declare your variables’
        'Then use the input and message box functions’
        strQuestion = InputBox("Type in your name!", "Ebeneezer")
        intAnswer = MsgBox("Hello there: " & strQuestion, vbOKCancel, "Chat")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class