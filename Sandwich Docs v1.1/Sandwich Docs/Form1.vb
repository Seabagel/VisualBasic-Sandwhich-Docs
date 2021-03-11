Public Class Form1

    Private Sub btnTo_Click(sender As Object, e As EventArgs) Handles btnTo.Click
        If (fbdNewpath.ShowDialog() = DialogResult.OK) Then
            txtNewpath.Text = fbdNewpath.SelectedPath
        End If
    End Sub

    Private Sub btnFrom_Click(sender As Object, e As EventArgs) Handles btnFrom.Click
        If txtNewpath.Text = "" Then
            txtNewpath.Text = "C:/TEMPfilemov"
        End If
        If Not IO.Directory.Exists(txtNewpath.Text & "\") Then
            IO.Directory.CreateDirectory(txtNewpath.Text & "\")
        End If
        lbxDirectory.Items.Clear()
        Dim fileArr

        If (fbdOldpath.ShowDialog() = DialogResult.OK) Then
            Try
                fileArr = fbdOldpath.SelectedPath
                MessageBox.Show(fbdOldpath.SelectedPath)
                For i As Integer = 0 To IO.Directory.GetFiles(fileArr).Length - 1
                    If Not IO.Directory.GetFiles(fileArr)(i).EndsWith("db") Then
                        lbxDirectory.Items.Add(IO.Directory.GetFiles(fileArr)(i))
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("cannot read" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        If lbxDirectory.Items.Count <> 0 Then
            For i As Integer = 0 To lbxDirectory.Items.Count - 1
                IO.File.Copy(lbxDirectory.Items(i), txtNewpath.Text & "\" & txtTemplate.Text & lbxDirectory.Items(i).ToString.Substring(fbdOldpath.SelectedPath.Length + 1))
            Next
        Else
            MsgBox("No Documents Selected to Rename")
        End If
    End Sub

End Class
