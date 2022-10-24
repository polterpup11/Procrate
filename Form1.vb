Public Class Form1

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TextBox1.Lines)
        For i = 0 To ListBox1.Items.Count - 1
            Dim teststring As String = ListBox1.Items.Item(i)
            Dim testarray() As String = Split(teststring)
            If testarray(0) = "print" Then
                MsgBox(testarray(1))

            End If

            If testarray(0) = "beep" Then
                Beep()
            End If
            If testarray(0) = "exit" Then
                End
            End If
        Next
    End Sub
End Class
