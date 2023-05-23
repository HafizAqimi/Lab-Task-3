Public Class Store
    Private Sub ExitMenu2_Click(sender As Object, e As EventArgs) Handles ExitMenu2.Click
        Close()
    End Sub

    Private Sub ContinueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContinueToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BTNDownload_Click(sender As Object, e As EventArgs) Handles BTNDownload.Click
        MsgBox("Your Download Has Been Ready. You Will Able To Play The game Later.")
    End Sub

    Private Sub BTNDownload2_Click(sender As Object, e As EventArgs) Handles BTNDownload2.Click
        MsgBox("Your Download Has Been Ready. You Will Able To Play The game Later.")
    End Sub
End Class