<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOldpath = New System.Windows.Forms.TextBox()
        Me.btnFrom = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.lbxDirectory = New System.Windows.Forms.ListBox()
        Me.fbdOldpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTo = New System.Windows.Forms.Button()
        Me.txtNewpath = New System.Windows.Forms.TextBox()
        Me.fbdNewpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtTemplate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOldpath
        '
        Me.txtOldpath.Location = New System.Drawing.Point(111, 421)
        Me.txtOldpath.Name = "txtOldpath"
        Me.txtOldpath.Size = New System.Drawing.Size(224, 22)
        Me.txtOldpath.TabIndex = 0
        '
        'btnFrom
        '
        Me.btnFrom.Location = New System.Drawing.Point(341, 417)
        Me.btnFrom.Name = "btnFrom"
        Me.btnFrom.Size = New System.Drawing.Size(100, 31)
        Me.btnFrom.TabIndex = 2
        Me.btnFrom.Text = "From"
        Me.btnFrom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File Path"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Template"
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(871, 384)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(100, 60)
        Me.btnRename.TabIndex = 7
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'lbxDirectory
        '
        Me.lbxDirectory.FormattingEnabled = True
        Me.lbxDirectory.ItemHeight = 16
        Me.lbxDirectory.Location = New System.Drawing.Point(28, 24)
        Me.lbxDirectory.Name = "lbxDirectory"
        Me.lbxDirectory.Size = New System.Drawing.Size(948, 324)
        Me.lbxDirectory.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "New Path"
        '
        'btnTo
        '
        Me.btnTo.Location = New System.Drawing.Point(341, 380)
        Me.btnTo.Name = "btnTo"
        Me.btnTo.Size = New System.Drawing.Size(100, 31)
        Me.btnTo.TabIndex = 10
        Me.btnTo.Text = "To"
        Me.btnTo.UseVisualStyleBackColor = True
        '
        'txtNewpath
        '
        Me.txtNewpath.Location = New System.Drawing.Point(111, 384)
        Me.txtNewpath.Name = "txtNewpath"
        Me.txtNewpath.Size = New System.Drawing.Size(224, 22)
        Me.txtNewpath.TabIndex = 9
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(528, 384)
        Me.txtTemplate.Multiline = True
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTemplate.Size = New System.Drawing.Size(337, 59)
        Me.txtTemplate.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 475)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTo)
        Me.Controls.Add(Me.txtNewpath)
        Me.Controls.Add(Me.lbxDirectory)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFrom)
        Me.Controls.Add(Me.txtTemplate)
        Me.Controls.Add(Me.txtOldpath)
        Me.Name = "Form1"
        Me.Text = "Sandwich Docs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOldpath As TextBox
    Friend WithEvents btnFrom As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRename As Button
    Friend WithEvents lbxDirectory As ListBox
    Friend WithEvents fbdOldpath As FolderBrowserDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTo As Button
    Friend WithEvents txtNewpath As TextBox
    Friend WithEvents fbdNewpath As FolderBrowserDialog
    Friend WithEvents txtTemplate As TextBox
End Class
