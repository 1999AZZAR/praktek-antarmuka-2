Public Class Form1
    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles QUITToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Aktifitas1_Click(sender As Object, e As EventArgs) Handles Aktifitas1.Click
        Dim Aktifitas1 = New AKTIFITAS1
        Aktifitas1.Show()
    End Sub
    Private Sub Aktifitas2_Click(sender As Object, e As EventArgs) Handles Aktifitas2.Click
        Dim Aktifitas2 = New AKTIFITAS2
        Aktifitas2.Show()
    End Sub
    Private Sub Aktifitas3_Click(sender As Object, e As EventArgs) Handles Aktifitas3.Click
        Dim Aktifitas3 = New AKTIFITAS3
        Aktifitas3.Show()
    End Sub
    Private Sub Aktifitas4_Click(sender As Object, e As EventArgs) Handles Aktifitas4.Click
        Dim Aktifitas4 = New AKTIFITAS4
        Aktifitas4.Show()
    End Sub
    Private Sub Aktifitas5_Click(sender As Object, e As EventArgs) Handles Aktifitas5.Click
        Dim Aktifitas5 = New AKTIFITAS5
        Aktifitas5.Show()
    End Sub

End Class