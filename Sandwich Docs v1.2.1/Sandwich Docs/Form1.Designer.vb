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
        Me.buttonSandwich = New System.Windows.Forms.Button()
        Me.lbxDirectory = New System.Windows.Forms.ListBox()
        Me.fbdOldpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdNewpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.textTemplate = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.textOldpath = New System.Windows.Forms.TextBox()
        Me.buttonSource = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.textNewpath = New System.Windows.Forms.TextBox()
        Me.buttonDestination = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.checkDir = New System.Windows.Forms.CheckBox()
        Me.checkNum = New System.Windows.Forms.CheckBox()
        Me.checkReplace = New System.Windows.Forms.CheckBox()
        Me.textRAdd = New System.Windows.Forms.TextBox()
        Me.textRText = New System.Windows.Forms.TextBox()
        Me.comboRList = New System.Windows.Forms.ComboBox()
        Me.buttonRAdd = New System.Windows.Forms.Button()
        Me.buttonRRemove = New System.Windows.Forms.Button()
        Me.buttonClearReplace = New System.Windows.Forms.Button()
        Me.buttonRUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buttonClearTemplate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.buttonClearForm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 246)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Template"
        '
        'buttonSandwich
        '
        Me.buttonSandwich.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSandwich.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonSandwich.FlatAppearance.BorderSize = 0
        Me.buttonSandwich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonSandwich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonSandwich.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSandwich.ForeColor = System.Drawing.Color.White
        Me.buttonSandwich.Location = New System.Drawing.Point(372, 285)
        Me.buttonSandwich.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonSandwich.Name = "buttonSandwich"
        Me.buttonSandwich.Size = New System.Drawing.Size(100, 39)
        Me.buttonSandwich.TabIndex = 7
        Me.buttonSandwich.Text = "Sandwich"
        Me.buttonSandwich.UseVisualStyleBackColor = False
        '
        'lbxDirectory
        '
        Me.lbxDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxDirectory.FormattingEnabled = True
        Me.lbxDirectory.HorizontalScrollbar = True
        Me.lbxDirectory.ItemHeight = 18
        Me.lbxDirectory.Location = New System.Drawing.Point(495, 114)
        Me.lbxDirectory.Name = "lbxDirectory"
        Me.lbxDirectory.Size = New System.Drawing.Size(542, 544)
        Me.lbxDirectory.TabIndex = 8
        '
        'textTemplate
        '
        Me.textTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textTemplate.Location = New System.Drawing.Point(124, 244)
        Me.textTemplate.Margin = New System.Windows.Forms.Padding(4)
        Me.textTemplate.Multiline = True
        Me.textTemplate.Name = "textTemplate"
        Me.textTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textTemplate.Size = New System.Drawing.Size(240, 80)
        Me.textTemplate.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(70, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(210, 32)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Sandwich Docs"
        '
        'textOldpath
        '
        Me.textOldpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textOldpath.Location = New System.Drawing.Point(124, 177)
        Me.textOldpath.Margin = New System.Windows.Forms.Padding(4)
        Me.textOldpath.Name = "textOldpath"
        Me.textOldpath.Size = New System.Drawing.Size(240, 24)
        Me.textOldpath.TabIndex = 0
        '
        'buttonSource
        '
        Me.buttonSource.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonSource.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonSource.FlatAppearance.BorderSize = 0
        Me.buttonSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSource.ForeColor = System.Drawing.Color.White
        Me.buttonSource.Location = New System.Drawing.Point(372, 177)
        Me.buttonSource.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonSource.Name = "buttonSource"
        Me.buttonSource.Size = New System.Drawing.Size(100, 24)
        Me.buttonSource.TabIndex = 2
        Me.buttonSource.Text = "Source"
        Me.buttonSource.UseVisualStyleBackColor = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.Black
        Me.label.Location = New System.Drawing.Point(47, 180)
        Me.label.Margin = New System.Windows.Forms.Padding(8)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(65, 18)
        Me.label.TabIndex = 5
        Me.label.Text = "Old Path"
        '
        'textNewpath
        '
        Me.textNewpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textNewpath.Location = New System.Drawing.Point(124, 209)
        Me.textNewpath.Margin = New System.Windows.Forms.Padding(4)
        Me.textNewpath.Name = "textNewpath"
        Me.textNewpath.Size = New System.Drawing.Size(240, 24)
        Me.textNewpath.TabIndex = 9
        '
        'buttonDestination
        '
        Me.buttonDestination.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonDestination.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonDestination.FlatAppearance.BorderSize = 0
        Me.buttonDestination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonDestination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDestination.ForeColor = System.Drawing.Color.White
        Me.buttonDestination.Location = New System.Drawing.Point(372, 209)
        Me.buttonDestination.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonDestination.Name = "buttonDestination"
        Me.buttonDestination.Size = New System.Drawing.Size(100, 24)
        Me.buttonDestination.TabIndex = 10
        Me.buttonDestination.Text = "Destination"
        Me.buttonDestination.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 212)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "New Path"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1068, 64)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'checkDir
        '
        Me.checkDir.AutoSize = True
        Me.checkDir.Checked = True
        Me.checkDir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDir.ForeColor = System.Drawing.Color.Black
        Me.checkDir.Location = New System.Drawing.Point(124, 114)
        Me.checkDir.Margin = New System.Windows.Forms.Padding(4)
        Me.checkDir.Name = "checkDir"
        Me.checkDir.Size = New System.Drawing.Size(332, 24)
        Me.checkDir.TabIndex = 17
        Me.checkDir.Text = "Replace $dir with the Original File Name"
        Me.checkDir.UseVisualStyleBackColor = True
        '
        'checkNum
        '
        Me.checkNum.AutoSize = True
        Me.checkNum.Checked = True
        Me.checkNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkNum.ForeColor = System.Drawing.Color.Black
        Me.checkNum.Location = New System.Drawing.Point(124, 144)
        Me.checkNum.Margin = New System.Windows.Forms.Padding(4)
        Me.checkNum.Name = "checkNum"
        Me.checkNum.Size = New System.Drawing.Size(249, 24)
        Me.checkNum.TabIndex = 18
        Me.checkNum.Text = "Replace $num with File index"
        Me.checkNum.UseVisualStyleBackColor = True
        '
        'checkReplace
        '
        Me.checkReplace.AutoSize = True
        Me.checkReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkReplace.ForeColor = System.Drawing.Color.Black
        Me.checkReplace.Location = New System.Drawing.Point(124, 366)
        Me.checkReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.checkReplace.Name = "checkReplace"
        Me.checkReplace.Size = New System.Drawing.Size(303, 24)
        Me.checkReplace.TabIndex = 19
        Me.checkReplace.Text = "Add/Remove words inside Word List"
        Me.checkReplace.UseVisualStyleBackColor = True
        '
        'textRAdd
        '
        Me.textRAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textRAdd.Location = New System.Drawing.Point(124, 432)
        Me.textRAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.textRAdd.Name = "textRAdd"
        Me.textRAdd.Size = New System.Drawing.Size(240, 24)
        Me.textRAdd.TabIndex = 20
        '
        'textRText
        '
        Me.textRText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textRText.Location = New System.Drawing.Point(124, 464)
        Me.textRText.Margin = New System.Windows.Forms.Padding(4)
        Me.textRText.Multiline = True
        Me.textRText.Name = "textRText"
        Me.textRText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textRText.Size = New System.Drawing.Size(240, 60)
        Me.textRText.TabIndex = 21
        '
        'comboRList
        '
        Me.comboRList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.comboRList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRList.FormattingEnabled = True
        Me.comboRList.Location = New System.Drawing.Point(124, 398)
        Me.comboRList.Margin = New System.Windows.Forms.Padding(4)
        Me.comboRList.Name = "comboRList"
        Me.comboRList.Size = New System.Drawing.Size(240, 26)
        Me.comboRList.TabIndex = 22
        '
        'buttonRAdd
        '
        Me.buttonRAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonRAdd.FlatAppearance.BorderSize = 0
        Me.buttonRAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonRAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonRAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonRAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRAdd.ForeColor = System.Drawing.Color.White
        Me.buttonRAdd.Location = New System.Drawing.Point(372, 432)
        Me.buttonRAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRAdd.Name = "buttonRAdd"
        Me.buttonRAdd.Size = New System.Drawing.Size(100, 24)
        Me.buttonRAdd.TabIndex = 23
        Me.buttonRAdd.Text = "Add"
        Me.buttonRAdd.UseVisualStyleBackColor = False
        '
        'buttonRRemove
        '
        Me.buttonRRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonRRemove.FlatAppearance.BorderSize = 0
        Me.buttonRRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonRRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonRRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonRRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRRemove.ForeColor = System.Drawing.Color.White
        Me.buttonRRemove.Location = New System.Drawing.Point(372, 397)
        Me.buttonRRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRRemove.Name = "buttonRRemove"
        Me.buttonRRemove.Size = New System.Drawing.Size(100, 27)
        Me.buttonRRemove.TabIndex = 24
        Me.buttonRRemove.Text = "Remove"
        Me.buttonRRemove.UseVisualStyleBackColor = False
        '
        'buttonClearReplace
        '
        Me.buttonClearReplace.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonClearReplace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonClearReplace.FlatAppearance.BorderSize = 0
        Me.buttonClearReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonClearReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonClearReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonClearReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClearReplace.ForeColor = System.Drawing.Color.White
        Me.buttonClearReplace.Location = New System.Drawing.Point(372, 464)
        Me.buttonClearReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClearReplace.Name = "buttonClearReplace"
        Me.buttonClearReplace.Size = New System.Drawing.Size(100, 25)
        Me.buttonClearReplace.TabIndex = 25
        Me.buttonClearReplace.Text = "Clear"
        Me.buttonClearReplace.UseVisualStyleBackColor = False
        '
        'buttonRUpdate
        '
        Me.buttonRUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonRUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonRUpdate.FlatAppearance.BorderSize = 0
        Me.buttonRUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonRUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonRUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonRUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRUpdate.ForeColor = System.Drawing.Color.White
        Me.buttonRUpdate.Location = New System.Drawing.Point(372, 495)
        Me.buttonRUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRUpdate.Name = "buttonRUpdate"
        Me.buttonRUpdate.Size = New System.Drawing.Size(100, 26)
        Me.buttonRUpdate.TabIndex = 26
        Me.buttonRUpdate.Text = "Update"
        Me.buttonRUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 401)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Select Word"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(33, 434)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "New Word"
        '
        'buttonClearTemplate
        '
        Me.buttonClearTemplate.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonClearTemplate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonClearTemplate.FlatAppearance.BorderSize = 0
        Me.buttonClearTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonClearTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonClearTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonClearTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClearTemplate.ForeColor = System.Drawing.Color.White
        Me.buttonClearTemplate.Location = New System.Drawing.Point(372, 244)
        Me.buttonClearTemplate.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClearTemplate.Name = "buttonClearTemplate"
        Me.buttonClearTemplate.Size = New System.Drawing.Size(100, 33)
        Me.buttonClearTemplate.TabIndex = 30
        Me.buttonClearTemplate.Text = "Clear"
        Me.buttonClearTemplate.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1068, 32)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 365)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Replace"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(12, 70)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(188, 20)
        Me.lblVersion.TabIndex = 33
        Me.lblVersion.Text = "Sandwich Docs Version"
        '
        'buttonClearForm
        '
        Me.buttonClearForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.buttonClearForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonClearForm.FlatAppearance.BorderSize = 0
        Me.buttonClearForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.buttonClearForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.buttonClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClearForm.ForeColor = System.Drawing.Color.White
        Me.buttonClearForm.Location = New System.Drawing.Point(128, 58)
        Me.buttonClearForm.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClearForm.Name = "buttonClearForm"
        Me.buttonClearForm.Size = New System.Drawing.Size(100, 33)
        Me.buttonClearForm.TabIndex = 34
        Me.buttonClearForm.Text = "Clear Form"
        Me.buttonClearForm.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.buttonClearForm)
        Me.GroupBox1.Location = New System.Drawing.Point(124, 545)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 103)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clear Form"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(6, 75)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(96, 21)
        Me.RadioButton3.TabIndex = 37
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Everything"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(6, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 21)
        Me.RadioButton2.TabIndex = 36
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Replace"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 21)
        Me.RadioButton1.TabIndex = 35
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Template"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.buttonClearTemplate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonRUpdate)
        Me.Controls.Add(Me.buttonClearReplace)
        Me.Controls.Add(Me.buttonRRemove)
        Me.Controls.Add(Me.buttonRAdd)
        Me.Controls.Add(Me.comboRList)
        Me.Controls.Add(Me.textRText)
        Me.Controls.Add(Me.textRAdd)
        Me.Controls.Add(Me.checkReplace)
        Me.Controls.Add(Me.checkNum)
        Me.Controls.Add(Me.checkDir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buttonDestination)
        Me.Controls.Add(Me.textNewpath)
        Me.Controls.Add(Me.lbxDirectory)
        Me.Controls.Add(Me.buttonSandwich)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.buttonSource)
        Me.Controls.Add(Me.textTemplate)
        Me.Controls.Add(Me.textOldpath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sandwich Docs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonSandwich As Button
    Friend WithEvents lbxDirectory As ListBox
    Friend WithEvents fbdOldpath As FolderBrowserDialog
    Friend WithEvents fbdNewpath As FolderBrowserDialog
    Friend WithEvents textTemplate As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents textOldpath As TextBox
    Friend WithEvents buttonSource As Button
    Friend WithEvents label As Label
    Friend WithEvents textNewpath As TextBox
    Friend WithEvents buttonDestination As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents checkDir As CheckBox
    Friend WithEvents checkNum As CheckBox
    Friend WithEvents checkReplace As CheckBox
    Friend WithEvents textRAdd As TextBox
    Friend WithEvents textRText As TextBox
    Friend WithEvents comboRList As ComboBox
    Friend WithEvents buttonRAdd As Button
    Friend WithEvents buttonRRemove As Button
    Friend WithEvents buttonClearReplace As Button
    Friend WithEvents buttonRUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents buttonClearTemplate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents buttonClearForm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
