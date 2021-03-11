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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.lbxDirectory = New System.Windows.Forms.ListBox()
        Me.fbdOldpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdNewpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtTemplate = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtOldpath = New System.Windows.Forms.TextBox()
        Me.btnFrom = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.txtNewpath = New System.Windows.Forms.TextBox()
        Me.btnTo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(497, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Template"
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRename.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRename.FlatAppearance.BorderSize = 0
        Me.btnRename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.Location = New System.Drawing.Point(890, 186)
        Me.btnRename.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(100, 60)
        Me.btnRename.TabIndex = 7
        Me.btnRename.Text = "Sandwich"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'lbxDirectory
        '
        Me.lbxDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxDirectory.FormattingEnabled = True
        Me.lbxDirectory.HorizontalScrollbar = True
        Me.lbxDirectory.ItemHeight = 18
        Me.lbxDirectory.Location = New System.Drawing.Point(16, 123)
        Me.lbxDirectory.Name = "lbxDirectory"
        Me.lbxDirectory.Size = New System.Drawing.Size(457, 580)
        Me.lbxDirectory.TabIndex = 8
        '
        'txtTemplate
        '
        Me.txtTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemplate.Location = New System.Drawing.Point(578, 186)
        Me.txtTemplate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTemplate.Multiline = True
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTemplate.Size = New System.Drawing.Size(306, 60)
        Me.txtTemplate.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(70, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(210, 32)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Sandwich Docs"
        '
        'txtOldpath
        '
        Me.txtOldpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldpath.Location = New System.Drawing.Point(578, 122)
        Me.txtOldpath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldpath.Name = "txtOldpath"
        Me.txtOldpath.Size = New System.Drawing.Size(306, 24)
        Me.txtOldpath.TabIndex = 0
        '
        'btnFrom
        '
        Me.btnFrom.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFrom.FlatAppearance.BorderSize = 0
        Me.btnFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrom.Location = New System.Drawing.Point(890, 122)
        Me.btnFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFrom.Name = "btnFrom"
        Me.btnFrom.Size = New System.Drawing.Size(100, 24)
        Me.btnFrom.TabIndex = 2
        Me.btnFrom.Text = "From"
        Me.btnFrom.UseVisualStyleBackColor = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(501, 125)
        Me.label.Margin = New System.Windows.Forms.Padding(8)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(65, 18)
        Me.label.TabIndex = 5
        Me.label.Text = "Old Path"
        '
        'txtNewpath
        '
        Me.txtNewpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewpath.Location = New System.Drawing.Point(578, 154)
        Me.txtNewpath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewpath.Name = "txtNewpath"
        Me.txtNewpath.Size = New System.Drawing.Size(306, 24)
        Me.txtNewpath.TabIndex = 9
        '
        'btnTo
        '
        Me.btnTo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTo.FlatAppearance.BorderSize = 0
        Me.btnTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTo.Location = New System.Drawing.Point(890, 154)
        Me.btnTo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTo.Name = "btnTo"
        Me.btnTo.Size = New System.Drawing.Size(100, 24)
        Me.btnTo.TabIndex = 10
        Me.btnTo.Text = "To"
        Me.btnTo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(494, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "New Path"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1018, 64)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 87)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Directory"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(578, 263)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(291, 22)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Replace $dir with the Original File Name"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(578, 293)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(220, 22)
        Me.CheckBox2.TabIndex = 18
        Me.CheckBox2.Text = "Replace $num with File index"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(578, 342)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(139, 24)
        Me.CheckBox3.TabIndex = 19
        Me.CheckBox3.Text = "Post Template"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(578, 374)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(306, 24)
        Me.TextBox1.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(578, 406)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(306, 60)
        Me.TextBox2.TabIndex = 21
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(578, 474)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(306, 26)
        Me.ComboBox1.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(890, 374)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 24)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(890, 474)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 26)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(890, 406)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(890, 437)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 29)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 378)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Replace"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 410)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "New Text"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(494, 478)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Word List"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Chocolate
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(890, 16)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 32)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Clear Form"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 725)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTo)
        Me.Controls.Add(Me.txtNewpath)
        Me.Controls.Add(Me.lbxDirectory)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.btnFrom)
        Me.Controls.Add(Me.txtTemplate)
        Me.Controls.Add(Me.txtOldpath)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sandwich Docs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRename As Button
    Friend WithEvents lbxDirectory As ListBox
    Friend WithEvents fbdOldpath As FolderBrowserDialog
    Friend WithEvents fbdNewpath As FolderBrowserDialog
    Friend WithEvents txtTemplate As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtOldpath As TextBox
    Friend WithEvents btnFrom As Button
    Friend WithEvents label As Label
    Friend WithEvents txtNewpath As TextBox
    Friend WithEvents btnTo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
End Class
