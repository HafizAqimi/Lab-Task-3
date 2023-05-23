Public Class Form1
    Private Sub ExitMenu1_Click(sender As Object, e As EventArgs) Handles ExitMenu1.Click
        Close()
    End Sub

    Private Sub StoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoreToolStripMenuItem.Click
        Store.Show()
        Me.Hide()
    End Sub
End Class
