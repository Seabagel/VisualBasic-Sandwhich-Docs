Public Class Form1
    Dim currentVersion = "1.2"

    Private Sub btnFrom_Click(sender As Object, e As EventArgs) Handles btnFrom.Click

        lbxDirectory.Items.Clear()
        Dim oldPathDirectory

        If (fbdOldpath.ShowDialog() = DialogResult.OK) Then
            Try
                oldPathDirectory = fbdOldpath.SelectedPath

                For i As Integer = 0 To IO.Directory.GetFiles(oldPathDirectory).Length - 1
                    If Not IO.Directory.GetFiles(oldPathDirectory)(i).EndsWith("db") Then
                        lbxDirectory.Items.Add(IO.Directory.GetFiles(oldPathDirectory)(i))
                    End If
                Next

                txtOldpath.Text = oldPathDirectory
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnTo_Click(sender As Object, e As EventArgs) Handles btnTo.Click
        Try
            If (fbdNewpath.ShowDialog() = DialogResult.OK) Then
                txtNewpath.Text = fbdNewpath.SelectedPath

                If txtNewpath.Text = txtOldpath.Text Then
                    txtNewpath.Text = txtOldpath.Text & "SandwichDocs"
                End If

                If Not IO.Directory.Exists(txtNewpath.Text & "\") Then
                    IO.Directory.CreateDirectory(txtNewpath.Text & "\")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        Dim documentCopied As Integer = 0
        Try
            If lbxDirectory.Items.Count <> 0 And txtNewpath.Text <> String.Empty Then
                If txtTemplate.Text = String.Empty Then
                    If MessageBox.Show("Your Template is empty, do you want to copy the files?", "Title", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        GoTo renameTheFiles
                    Else
                        Exit Try
                    End If
                End If

renameTheFiles:
                For i As Integer = 0 To lbxDirectory.Items.Count - 1
                    IO.File.Copy(lbxDirectory.Items(i), txtNewpath.Text & "\" & txtTemplate.Text & lbxDirectory.Items(i).ToString.Substring(fbdOldpath.SelectedPath.Length + 1))
                    documentCopied += 1
                Next
                MsgBox(CStr(documentCopied) & " Documents Copied")
            Else
                If txtNewpath.Text = String.Empty Then
                    MsgBox("Select a Destination Folder")
                    If lbxDirectory.Items.Count = 0 Then
                        MsgBox("Select a Source Folder")
                    End If
                Else
                    MsgBox("No Documents Renamed")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Sandwich Docs v" + currentVersion
    End Sub

    'Const WM_NCHITTEST As Integer = &H84
    'Const HTCLIENT As Integer = &H1
    'Const HTCAPTION As Integer = &H2

    'Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
    '    Select Case m.Msg
    '        Case WM_NCHITTEST
    '            MyBase.WndProc(m)
    '            If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
    '        Case Else
    '            MyBase.WndProc(m)
    '    End Select
    'End Sub

End Class
