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
    Me.components = New System.ComponentModel.Container
    Me.btnDataFolder = New System.Windows.Forms.Button
    Me.txtDataFolder = New System.Windows.Forms.TextBox
    Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog
    Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
    Me.LblDbFolder = New System.Windows.Forms.Label
    Me.cboTables = New System.Windows.Forms.ComboBox
    Me.btnFillDbTables = New System.Windows.Forms.Button
    Me.Label2 = New System.Windows.Forms.Label
    Me.Grid = New System.Windows.Forms.DataGridView
    Me.btnRefreshTable = New System.Windows.Forms.Button
    Me.btnSaveTable = New System.Windows.Forms.Button
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
    Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
    Me.btnClearCommandText = New System.Windows.Forms.Button
    Me.btnExecuteCommand = New System.Windows.Forms.Button
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtCommandText = New System.Windows.Forms.TextBox
    Me.chkUseDbContainer = New System.Windows.Forms.CheckBox
    Me.chkBracketTableName = New System.Windows.Forms.CheckBox
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
    CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnDataFolder
    '
    Me.btnDataFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnDataFolder.Location = New System.Drawing.Point(611, 12)
    Me.btnDataFolder.Name = "btnDataFolder"
    Me.btnDataFolder.Size = New System.Drawing.Size(51, 23)
    Me.btnDataFolder.TabIndex = 0
    Me.btnDataFolder.Text = "..."
    Me.btnDataFolder.UseVisualStyleBackColor = True
    '
    'txtDataFolder
    '
    Me.txtDataFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtDataFolder.Location = New System.Drawing.Point(83, 14)
    Me.txtDataFolder.Name = "txtDataFolder"
    Me.txtDataFolder.Size = New System.Drawing.Size(522, 20)
    Me.txtDataFolder.TabIndex = 1
    '
    'LblDbFolder
    '
    Me.LblDbFolder.AutoSize = True
    Me.LblDbFolder.Location = New System.Drawing.Point(12, 17)
    Me.LblDbFolder.Name = "LblDbFolder"
    Me.LblDbFolder.Size = New System.Drawing.Size(72, 13)
    Me.LblDbFolder.TabIndex = 2
    Me.LblDbFolder.Text = "Db Container:"
    '
    'cboTables
    '
    Me.cboTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTables.FormattingEnabled = True
    Me.cboTables.Location = New System.Drawing.Point(83, 46)
    Me.cboTables.MaxDropDownItems = 20
    Me.cboTables.Name = "cboTables"
    Me.cboTables.Size = New System.Drawing.Size(498, 21)
    Me.cboTables.TabIndex = 3
    '
    'btnFillDbTables
    '
    Me.btnFillDbTables.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnFillDbTables.Location = New System.Drawing.Point(587, 46)
    Me.btnFillDbTables.Name = "btnFillDbTables"
    Me.btnFillDbTables.Size = New System.Drawing.Size(75, 23)
    Me.btnFillDbTables.TabIndex = 4
    Me.btnFillDbTables.Text = "Fill"
    Me.btnFillDbTables.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 49)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(34, 13)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Table"
    '
    'Grid
    '
    Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Grid.Location = New System.Drawing.Point(0, 0)
    Me.Grid.Name = "Grid"
    Me.Grid.Size = New System.Drawing.Size(579, 279)
    Me.Grid.TabIndex = 6
    '
    'btnRefreshTable
    '
    Me.btnRefreshTable.Location = New System.Drawing.Point(12, 73)
    Me.btnRefreshTable.Name = "btnRefreshTable"
    Me.btnRefreshTable.Size = New System.Drawing.Size(65, 23)
    Me.btnRefreshTable.TabIndex = 7
    Me.btnRefreshTable.Text = "Refresh"
    Me.btnRefreshTable.UseVisualStyleBackColor = True
    '
    'btnSaveTable
    '
    Me.btnSaveTable.Location = New System.Drawing.Point(12, 111)
    Me.btnSaveTable.Name = "btnSaveTable"
    Me.btnSaveTable.Size = New System.Drawing.Size(65, 23)
    Me.btnSaveTable.TabIndex = 8
    Me.btnSaveTable.Text = "Save"
    Me.btnSaveTable.UseVisualStyleBackColor = True
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
    Me.SplitContainer1.Location = New System.Drawing.Point(83, 73)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.Grid)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.LinkLabel3)
    Me.SplitContainer1.Panel2.Controls.Add(Me.LinkLabel2)
    Me.SplitContainer1.Panel2.Controls.Add(Me.LinkLabel1)
    Me.SplitContainer1.Panel2.Controls.Add(Me.btnClearCommandText)
    Me.SplitContainer1.Panel2.Controls.Add(Me.btnExecuteCommand)
    Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
    Me.SplitContainer1.Panel2.Controls.Add(Me.txtCommandText)
    Me.SplitContainer1.Size = New System.Drawing.Size(579, 355)
    Me.SplitContainer1.SplitterDistance = 279
    Me.SplitContainer1.TabIndex = 9
    '
    'LinkLabel2
    '
    Me.LinkLabel2.AutoSize = True
    Me.LinkLabel2.Location = New System.Drawing.Point(274, -1)
    Me.LinkLabel2.Name = "LinkLabel2"
    Me.LinkLabel2.Size = New System.Drawing.Size(92, 13)
    Me.LinkLabel2.TabIndex = 5
    Me.LinkLabel2.TabStop = True
    Me.LinkLabel2.Text = "Update Command"
    '
    'LinkLabel1
    '
    Me.LinkLabel1.AutoSize = True
    Me.LinkLabel1.Location = New System.Drawing.Point(186, 0)
    Me.LinkLabel1.Name = "LinkLabel1"
    Me.LinkLabel1.Size = New System.Drawing.Size(82, 13)
    Me.LinkLabel1.TabIndex = 4
    Me.LinkLabel1.TabStop = True
    Me.LinkLabel1.Text = "Insert Table File"
    '
    'btnClearCommandText
    '
    Me.btnClearCommandText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnClearCommandText.Location = New System.Drawing.Point(501, 17)
    Me.btnClearCommandText.Name = "btnClearCommandText"
    Me.btnClearCommandText.Size = New System.Drawing.Size(75, 23)
    Me.btnClearCommandText.TabIndex = 3
    Me.btnClearCommandText.Text = "Clear"
    Me.btnClearCommandText.UseVisualStyleBackColor = True
    '
    'btnExecuteCommand
    '
    Me.btnExecuteCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExecuteCommand.Location = New System.Drawing.Point(501, 46)
    Me.btnExecuteCommand.Name = "btnExecuteCommand"
    Me.btnExecuteCommand.Size = New System.Drawing.Size(75, 23)
    Me.btnExecuteCommand.TabIndex = 2
    Me.btnExecuteCommand.Text = "GO"
    Me.btnExecuteCommand.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(3, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(134, 13)
    Me.Label3.TabIndex = 1
    Me.Label3.Text = "Execute Maunal Command"
    '
    'txtCommandText
    '
    Me.txtCommandText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtCommandText.BackColor = System.Drawing.SystemColors.ActiveCaption
    Me.txtCommandText.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCommandText.ForeColor = System.Drawing.Color.Lime
    Me.txtCommandText.Location = New System.Drawing.Point(3, 15)
    Me.txtCommandText.Multiline = True
    Me.txtCommandText.Name = "txtCommandText"
    Me.txtCommandText.Size = New System.Drawing.Size(495, 53)
    Me.txtCommandText.TabIndex = 0
    '
    'chkUseDbContainer
    '
    Me.chkUseDbContainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkUseDbContainer.BackColor = System.Drawing.SystemColors.Control
    Me.chkUseDbContainer.Checked = True
    Me.chkUseDbContainer.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkUseDbContainer.Location = New System.Drawing.Point(8, 369)
    Me.chkUseDbContainer.Name = "chkUseDbContainer"
    Me.chkUseDbContainer.Size = New System.Drawing.Size(72, 59)
    Me.chkUseDbContainer.TabIndex = 10
    Me.chkUseDbContainer.Text = "Use Db Container"
    Me.chkUseDbContainer.UseVisualStyleBackColor = False
    '
    'chkBracketTableName
    '
    Me.chkBracketTableName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkBracketTableName.BackColor = System.Drawing.SystemColors.Control
    Me.chkBracketTableName.Checked = True
    Me.chkBracketTableName.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkBracketTableName.Location = New System.Drawing.Point(5, 315)
    Me.chkBracketTableName.Name = "chkBracketTableName"
    Me.chkBracketTableName.Size = New System.Drawing.Size(72, 48)
    Me.chkBracketTableName.TabIndex = 11
    Me.chkBracketTableName.Text = "Bracket Table Name"
    Me.ToolTip1.SetToolTip(Me.chkBracketTableName, "i.e. [table name]")
    Me.chkBracketTableName.UseVisualStyleBackColor = False
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = Global.FoxProViewer.My.Resources.Resources.foxpro7logocut
    Me.PictureBox1.Location = New System.Drawing.Point(12, 153)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(60, 70)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.PictureBox1.TabIndex = 7
    Me.PictureBox1.TabStop = False
    '
    'LinkLabel3
    '
    Me.LinkLabel3.AutoSize = True
    Me.LinkLabel3.Location = New System.Drawing.Point(143, 0)
    Me.LinkLabel3.Name = "LinkLabel3"
    Me.LinkLabel3.Size = New System.Drawing.Size(37, 13)
    Me.LinkLabel3.TabIndex = 6
    Me.LinkLabel3.TabStop = True
    Me.LinkLabel3.Text = "Select"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(674, 440)
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
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Fox Pro Viewer"
    CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.Panel2.PerformLayout()
    Me.SplitContainer1.ResumeLayout(False)
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents Grid As System.Windows.Forms.DataGridView
  Friend WithEvents btnRefreshTable As System.Windows.Forms.Button
  Friend WithEvents btnSaveTable As System.Windows.Forms.Button
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCommandText As System.Windows.Forms.TextBox
  Friend WithEvents btnClearCommandText As System.Windows.Forms.Button
  Friend WithEvents btnExecuteCommand As System.Windows.Forms.Button
  Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
  Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
  Friend WithEvents chkUseDbContainer As System.Windows.Forms.CheckBox
  Friend WithEvents chkBracketTableName As System.Windows.Forms.CheckBox
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel

End Class
