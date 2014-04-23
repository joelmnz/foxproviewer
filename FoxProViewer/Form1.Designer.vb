<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnDataFolder = New System.Windows.Forms.Button()
        Me.txtDataFolder = New System.Windows.Forms.TextBox()
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.LblDbFolder = New System.Windows.Forms.Label()
        Me.cboTables = New System.Windows.Forms.ComboBox()
        Me.btnFillDbTables = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefreshTable = New System.Windows.Forms.Button()
        Me.btnSaveTable = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnExecuteCommand = New System.Windows.Forms.Button()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCommandText = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.chkUseDbContainer = New System.Windows.Forms.CheckBox()
        Me.chkBracketTableName = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSchema = New System.Windows.Forms.Button()
        Me.BtnDBSchema = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExecutionTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenSQLCreateTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateConnectionStringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDataFolder
        '
        Me.btnDataFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDataFolder.Location = New System.Drawing.Point(636, 26)
        Me.btnDataFolder.Name = "btnDataFolder"
        Me.btnDataFolder.Size = New System.Drawing.Size(51, 23)
        Me.btnDataFolder.TabIndex = 2
        Me.btnDataFolder.Text = "..."
        Me.btnDataFolder.UseVisualStyleBackColor = True
        '
        'txtDataFolder
        '
        Me.txtDataFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataFolder.Location = New System.Drawing.Point(83, 28)
        Me.txtDataFolder.Name = "txtDataFolder"
        Me.txtDataFolder.Size = New System.Drawing.Size(547, 20)
        Me.txtDataFolder.TabIndex = 1
        '
        'LblDbFolder
        '
        Me.LblDbFolder.AutoSize = True
        Me.LblDbFolder.Location = New System.Drawing.Point(12, 31)
        Me.LblDbFolder.Name = "LblDbFolder"
        Me.LblDbFolder.Size = New System.Drawing.Size(72, 13)
        Me.LblDbFolder.TabIndex = 0
        Me.LblDbFolder.Text = "Db Container:"
        '
        'cboTables
        '
        Me.cboTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTables.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTables.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTables.FormattingEnabled = True
        Me.cboTables.Location = New System.Drawing.Point(80, 55)
        Me.cboTables.MaxDropDownItems = 20
        Me.cboTables.Name = "cboTables"
        Me.cboTables.Size = New System.Drawing.Size(523, 21)
        Me.cboTables.TabIndex = 4
        '
        'btnFillDbTables
        '
        Me.btnFillDbTables.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFillDbTables.Location = New System.Drawing.Point(609, 55)
        Me.btnFillDbTables.Name = "btnFillDbTables"
        Me.btnFillDbTables.Size = New System.Drawing.Size(75, 23)
        Me.btnFillDbTables.TabIndex = 5
        Me.btnFillDbTables.Text = "Fill"
        Me.btnFillDbTables.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Table"
        '
        'btnRefreshTable
        '
        Me.btnRefreshTable.Location = New System.Drawing.Point(5, 89)
        Me.btnRefreshTable.Name = "btnRefreshTable"
        Me.btnRefreshTable.Size = New System.Drawing.Size(72, 23)
        Me.btnRefreshTable.TabIndex = 6
        Me.btnRefreshTable.Text = "select *"
        Me.btnRefreshTable.UseVisualStyleBackColor = True
        '
        'btnSaveTable
        '
        Me.btnSaveTable.Location = New System.Drawing.Point(5, 173)
        Me.btnSaveTable.Name = "btnSaveTable"
        Me.btnSaveTable.Size = New System.Drawing.Size(72, 23)
        Me.btnSaveTable.TabIndex = 10
        Me.btnSaveTable.Text = "Save"
        Me.btnSaveTable.UseVisualStyleBackColor = True
        Me.btnSaveTable.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(83, 84)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExecuteCommand)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCommandText)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(604, 416)
        Me.SplitContainer1.SplitterDistance = 115
        Me.SplitContainer1.TabIndex = 7
        '
        'btnExecuteCommand
        '
        Me.btnExecuteCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecuteCommand.Location = New System.Drawing.Point(526, 2)
        Me.btnExecuteCommand.Name = "btnExecuteCommand"
        Me.btnExecuteCommand.Size = New System.Drawing.Size(75, 21)
        Me.btnExecuteCommand.TabIndex = 1
        Me.btnExecuteCommand.Text = "GO (F5)"
        Me.btnExecuteCommand.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(143, 5)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Select"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Execute Maunal Command"
        '
        'txtCommandText
        '
        Me.txtCommandText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommandText.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCommandText.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommandText.ForeColor = System.Drawing.Color.White
        Me.txtCommandText.Location = New System.Drawing.Point(6, 21)
        Me.txtCommandText.Multiline = True
        Me.txtCommandText.Name = "txtCommandText"
        Me.txtCommandText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCommandText.Size = New System.Drawing.Size(595, 91)
        Me.txtCommandText.TabIndex = 0
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(274, 4)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(92, 13)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Update Command"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(186, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(82, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Insert Table File"
        '
        'chkUseDbContainer
        '
        Me.chkUseDbContainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkUseDbContainer.BackColor = System.Drawing.SystemColors.Control
        Me.chkUseDbContainer.Checked = True
        Me.chkUseDbContainer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseDbContainer.Location = New System.Drawing.Point(8, 450)
        Me.chkUseDbContainer.Name = "chkUseDbContainer"
        Me.chkUseDbContainer.Size = New System.Drawing.Size(72, 59)
        Me.chkUseDbContainer.TabIndex = 13
        Me.chkUseDbContainer.Text = "Use Db Container"
        Me.chkUseDbContainer.UseVisualStyleBackColor = False
        '
        'chkBracketTableName
        '
        Me.chkBracketTableName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkBracketTableName.BackColor = System.Drawing.SystemColors.Control
        Me.chkBracketTableName.Checked = True
        Me.chkBracketTableName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBracketTableName.Location = New System.Drawing.Point(5, 396)
        Me.chkBracketTableName.Name = "chkBracketTableName"
        Me.chkBracketTableName.Size = New System.Drawing.Size(72, 48)
        Me.chkBracketTableName.TabIndex = 12
        Me.chkBracketTableName.Text = "Bracket Table Name"
        Me.ToolTip1.SetToolTip(Me.chkBracketTableName, "i.e. [table name]")
        Me.chkBracketTableName.UseVisualStyleBackColor = False
        '
        'BtnSchema
        '
        Me.BtnSchema.Location = New System.Drawing.Point(5, 118)
        Me.BtnSchema.Name = "BtnSchema"
        Me.BtnSchema.Size = New System.Drawing.Size(72, 23)
        Me.BtnSchema.TabIndex = 8
        Me.BtnSchema.Text = "Tbl Schema"
        Me.ToolTip1.SetToolTip(Me.BtnSchema, "Gets the schema for this table")
        Me.BtnSchema.UseVisualStyleBackColor = True
        '
        'BtnDBSchema
        '
        Me.BtnDBSchema.Location = New System.Drawing.Point(5, 144)
        Me.BtnDBSchema.Name = "BtnDBSchema"
        Me.BtnDBSchema.Size = New System.Drawing.Size(72, 23)
        Me.BtnDBSchema.TabIndex = 9
        Me.BtnDBSchema.Text = "DB Schema"
        Me.ToolTip1.SetToolTip(Me.BtnDBSchema, "gets the schema for this database")
        Me.BtnDBSchema.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(5, 293)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(72, 23)
        Me.btnExport.TabIndex = 11
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'dlgSave
        '
        Me.dlgSave.DefaultExt = "xml"
        Me.dlgSave.Filter = "XML (*.xml)|*.xml"
        Me.dlgSave.Title = "Save As"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 503)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Execution Time:"
        '
        'lblExecutionTime
        '
        Me.lblExecutionTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblExecutionTime.AutoSize = True
        Me.lblExecutionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExecutionTime.Location = New System.Drawing.Point(187, 503)
        Me.lblExecutionTime.Name = "lblExecutionTime"
        Me.lblExecutionTime.Size = New System.Drawing.Size(16, 15)
        Me.lblExecutionTime.TabIndex = 15
        Me.lblExecutionTime.Text = "..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FoxProViewer.My.Resources.Resources.foxpro7logocut
        Me.PictureBox1.Location = New System.Drawing.Point(12, 217)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FILEToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenSQLCreateTableToolStripMenuItem, Me.CreateConnectionStringToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'GenSQLCreateTableToolStripMenuItem
        '
        Me.GenSQLCreateTableToolStripMenuItem.Name = "GenSQLCreateTableToolStripMenuItem"
        Me.GenSQLCreateTableToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.GenSQLCreateTableToolStripMenuItem.Text = "Gen SQL Create Table"
        '
        'CreateConnectionStringToolStripMenuItem
        '
        Me.CreateConnectionStringToolStripMenuItem.Name = "CreateConnectionStringToolStripMenuItem"
        Me.CreateConnectionStringToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CreateConnectionStringToolStripMenuItem.Text = "Create Connection String"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 521)
        Me.Controls.Add(Me.BtnDBSchema)
        Me.Controls.Add(Me.BtnSchema)
        Me.Controls.Add(Me.lblExecutionTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkBracketTableName)
        Me.Controls.Add(Me.chkUseDbContainer)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnSaveTable)
        Me.Controls.Add(Me.btnRefreshTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFillDbTables)
        Me.Controls.Add(Me.cboTables)
        Me.Controls.Add(Me.LblDbFolder)
        Me.Controls.Add(Me.txtDataFolder)
        Me.Controls.Add(Me.btnDataFolder)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents btnDataFolder As System.Windows.Forms.Button
  Friend WithEvents txtDataFolder As System.Windows.Forms.TextBox
  Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
  Friend WithEvents LblDbFolder As System.Windows.Forms.Label
  Friend WithEvents cboTables As System.Windows.Forms.ComboBox
  Friend WithEvents btnFillDbTables As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnRefreshTable As System.Windows.Forms.Button
  Friend WithEvents btnSaveTable As System.Windows.Forms.Button
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCommandText As System.Windows.Forms.TextBox
  Friend WithEvents btnExecuteCommand As System.Windows.Forms.Button
  Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
  Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
  Friend WithEvents chkUseDbContainer As System.Windows.Forms.CheckBox
  Friend WithEvents chkBracketTableName As System.Windows.Forms.CheckBox
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
  Friend WithEvents btnExport As System.Windows.Forms.Button
  Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblExecutionTime As System.Windows.Forms.Label
  Friend WithEvents BtnSchema As System.Windows.Forms.Button
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenSQLCreateTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnDBSchema As System.Windows.Forms.Button
    Friend WithEvents CreateConnectionStringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
