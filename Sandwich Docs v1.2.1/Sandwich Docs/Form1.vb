Public Class Form1
    Dim currentVersion = "1.2.1"
    Dim ListWords As List(Of String) = New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = "version: " + currentVersion
        checkPostTemplate()
    End Sub

    Public Sub checkPostTemplate()
        textRAdd.Enabled = checkReplace.Checked
        textRText.Enabled = checkReplace.Checked
        comboRList.Enabled = checkReplace.Checked
        buttonRAdd.Enabled = checkReplace.Checked
        buttonRRemove.Enabled = checkReplace.Checked
        buttonClearReplace.Enabled = checkReplace.Checked
        buttonRUpdate.Enabled = checkReplace.Checked
    End Sub

    Private Sub btnFrom_Click(sender As Object, e As EventArgs) Handles buttonSource.Click
        If (fbdOldpath.ShowDialog() = DialogResult.OK) Then
            Try
                lbxDirectory.Items.Clear()
                Dim oldPathDirectory = fbdOldpath.SelectedPath

                For i As Integer = 0 To IO.Directory.GetFiles(oldPathDirectory).Length - 1
                    If Not IO.Directory.GetFiles(oldPathDirectory)(i).EndsWith("db") Then
                        lbxDirectory.Items.Add(IO.Directory.GetFiles(oldPathDirectory)(i))
                    End If
                Next

                textOldpath.Text = oldPathDirectory
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnTo_Click(sender As Object, e As EventArgs) Handles buttonDestination.Click
        Try
            If (fbdNewpath.ShowDialog() = DialogResult.OK) Then
                textNewpath.Text = fbdNewpath.SelectedPath

                If textNewpath.Text = textOldpath.Text Then
                    textNewpath.Text = textOldpath.Text & "SandwichDocs"
                End If

                If Not IO.Directory.Exists(textNewpath.Text & "\") Then
                    IO.Directory.CreateDirectory(textNewpath.Text & "\")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles buttonSandwich.Click
        Dim documentCopied As Integer = 0
        Try
            If lbxDirectory.Items.Count <> 0 And textNewpath.Text <> String.Empty Then
                If textTemplate.Text = String.Empty Then
                    If MessageBox.Show("Your Template is empty, do you want to copy the files?", "Title", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        GoTo renameTheFiles
                    Else
                        Exit Try
                    End If
                End If

renameTheFiles:
                For i As Integer = 0 To lbxDirectory.Items.Count - 1

                    Dim fileName As String = lbxDirectory.Items(i).ToString.Substring(fbdOldpath.SelectedPath.Length + 1)
                    Dim fileExtension As String = fileName.Substring(fileName.LastIndexOf("."))
                    fileName = fileName.Replace(fileExtension, String.Empty)

                    IO.File.Copy(lbxDirectory.Items(i), textNewpath.Text & "\" & textTemplate.Text.Replace("$dir", fileName) & fileExtension)

                    documentCopied += 1
                Next
                MsgBox(CStr(documentCopied) & " Documents Copied")
            Else
                If textNewpath.Text = String.Empty Then
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

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles checkReplace.CheckedChanged
        checkPostTemplate()
    End Sub


    'Private Sub buttonRAdd_Click(sender As Object, e As EventArgs) Handles buttonRAdd.Click
    '    comboRList.Items.Add(CStr(textRAdd.Text))
    '    comboRList.SelectedItem = comboRList.Items(comboRList.Items.Count - 1)
    '    textRAdd.Text = String.Empty

    '    ListWords.Add(CStr(textRText.Text))
    '    textRText.Text = String.Empty
    '    'textRText.Text = ListWords.Item(ListWords.Count - 1)

    'End Sub

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
