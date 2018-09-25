Public Class UserControl1
    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of Form1).Any Then
        Else
            My.Forms.Form1.Show()
        End If
    End Sub

    Private Sub MarketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarketsToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of Form2).Any Then
        Else
            My.Forms.Form2.Show()
        End If
    End Sub
End Class
