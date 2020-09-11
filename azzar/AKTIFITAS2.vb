Public Class AKTIFITAS2
    Private Sub CC()
        Label1.BackColor = Color.FromArgb(HScrollBar1.Value,
        HScrollBar2.Value, HScrollBar3.Value)
        Label8.BackColor = Color.FromArgb(HScrollBar1.Value,
        HScrollBar2.Value, HScrollBar3.Value)
        Label1.ForeColor = Color.FromArgb(255 - HScrollBar1.Value, 255 -
        HScrollBar2.Value, 255 - HScrollBar3.Value)
        Label8.ForeColor = Color.FromArgb(255 - HScrollBar1.Value, 255 -
        HScrollBar2.Value, 255 - HScrollBar3.Value)
        Label8.Visible = True
        Label8.Text = "AWESOME"
        Label5.BackColor = Color.FromArgb(HScrollBar1.Value, 0, 0)
        Label6.BackColor = Color.FromArgb(0, HScrollBar2.Value, 0)
        Label7.BackColor = Color.FromArgb(0, 0, HScrollBar3.Value)
        Label2.Text = HScrollBar1.Value
        Label3.Text = HScrollBar2.Value
        Label4.Text = HScrollBar3.Value
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        CC()
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        CC()
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        CC()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class