Public Class Form1
  Implements IMessageFilter


  Dim m_ConnectionString As String
  Dim m_Datasource As DataTable
  Dim m_Da As OleDb.OleDbDataAdapter
  Dim m_Builder As OleDb.OleDbCommandBuilder
  Dim m_TableName As String

  Public Property DataSource() As DataTable
    Get
      Return m_Datasource
    End Get
    Set(ByVal value As DataTable)
      m_Datasource = value
      Me.Grid.DataSource = value
      'If value IsNot Nothing AndAlso value.Tables.Count > 0 Then
      '  Me.Grid.DataSource = value.Tables(0)
      'Else
      '  Me.Grid.DataSource = Nothing
      'End If

    End Set
  End Property

  Public Property CurrentConnectionString() As String
    Get
      Return m_ConnectionString
    End Get
    Set(ByVal value As String)
      m_ConnectionString = value
    End Set
  End Property

  Public Property DataContainer() As String
    Get
      If Me.txtDataFolder.Text.ToLower.EndsWith(".dbc") Then
        Return Me.txtDataFolder.Text
      Else
        Return ""
      End If
    End Get
    Set(ByVal value As String)
      Me.txtDataFolder.Text = value
      'Me.DataFolder = IO.Path.GetDirectoryName(value)
    End Set
  End Property

  Public Property DataFolder() As String
    Get
      If Me.UseDbContainer OrElse LCase(Me.txtDataFolder.Text).EndsWith(".dbc") Then
        Return IO.Path.GetDirectoryName(Me.txtDataFolder.Text)
      Else
        Return Me.txtDataFolder.Text
      End If
    End Get
    Set(ByVal value As String)
      Me.txtDataFolder.Text = value
    End Set
  End Property

  Public Property UseDbContainer() As Boolean
    Get
      Return Me.chkUseDbContainer.Checked
    End Get
    Set(ByVal value As Boolean)
      Me.chkUseDbContainer.Checked = value
    End Set
  End Property

  Private Sub btnFillDbTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFillDbTables.Click
    Me.FillDbTables()
  End Sub

  Private Sub FillDbTables()

    Me.cboTables.Items.Clear()

    If IO.Directory.Exists(Me.DataFolder) = False Then
      MessageBox.Show("Invalid Data folder", "BAD Data Folder!", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Return
    End If

    Dim files() As String = IO.Directory.GetFiles(Me.DataFolder, "*.dbf")

    For Each t As String In files
      'Me.cboTables.Items.Add(t.Replace(".dbf", ""))
      Me.cboTables.Items.Add(IO.Path.GetFileName(t).Replace(".dbf", "").Replace(".DBF", ""))
    Next

  End Sub

  Private Sub btnDataFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataFolder.Click
    If Me.UseDbContainer Then
      With Me.dlgOpen
        .Title = "Open Fox Pro Data"
        .Filter = "Fox Pro Db Container(*.dbc)|*.dbc" '|Fox Pro Data Table (*.dbf)|*.dbf|All Files (*.*)|*.*"
        .Multiselect = False
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Me.DataContainer = .FileName
          Me.FillDbTables()
        End If
      End With
    Else
      If Me.dlgFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
        Me.DataFolder = Me.dlgFolder.SelectedPath
        Me.FillDbTables()
      End If
    End If

  End Sub

  Private Sub cboTables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTables.SelectedIndexChanged
    '### 15/12/2010 : stopped this as major lag if selecting big table
    'Me.OpenTable(Me.cboTables.Text)
  End Sub

  Private Shared Function GetBuilder(ByVal da As OleDb.OleDbDataAdapter) As OleDb.OleDbCommandBuilder
    Dim b As New OleDb.OleDbCommandBuilder(da)
    b.SetAllValues = False
    Return b
  End Function

  Private ReadOnly Property CurrentTableFile() As String
    Get
      Return IO.Path.Combine(Me.DataFolder, Me.cboTables.Text & ".dbf")
    End Get
  End Property


  Private Sub OpenTable(ByVal tableName As String)
    Me.OpenTable(tableName, "")
  End Sub
  Private Sub OpenTable(ByVal tableName As String, ByVal where As String)


    Me.Grid.DataSource = Nothing

    If tableName = "" Then Return
    Dim tableFile As String = IO.Path.Combine(Me.DataFolder, tableName & ".dbf")
    Dim lTableName As String = tableName
    Dim lSql As String = ""
    '    Dim KPDataConnection As New System.Data.OleDb.OleDbConnection(KPConnectionString)
    Dim cnn As OleDb.OleDbConnection = Nothing
    Dim ds As New DataSet '(tableName)
    Dim dtSchema As DataTable = Nothing

    If IO.File.Exists(tableFile) Then
      Me.StartExecutionTimer()
      If Me.UseDbContainer Then
        Me.CurrentConnectionString = BuildConnectionString(Me.DataContainer, tableFile, True)
      Else
        Me.CurrentConnectionString = BuildConnectionString(tableFile)
      End If

      'auto set the command text as well
      'Me.txtCommandText.Text = "UPDATE " & tableFile

      cnn = New OleDb.OleDbConnection(Me.CurrentConnectionString)
      'm_Da = New OleDb.OleDbDataAdapter("SELECT * FROM " & tableFile, cnn)
      m_Da = New OleDb.OleDbDataAdapter

      If Me.chkUseDbContainer.Checked = False Then
        lTableName = tableFile
      End If

      If Me.chkBracketTableName.Checked Then lTableName = "[" & lTableName & "]"

      lSql = "SELECT * FROM " & lTableName
      If Len(where) > 0 Then lSql &= " WHERE " & where

      m_Da.SelectCommand = New OleDb.OleDbCommand(lSql, cnn)

      m_Builder = GetBuilder(m_Da)

      'If da.UpdateCommand Is Nothing Then
      '  MessageBox.Show("Update cmd not created", "TITLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
      'End If

      Try
        m_Da.Fill(ds, tableName)
        Me.DataSource = ds.Tables(0)
        m_TableName = tableName
        Me.StopExecutionTimer()
      Catch ex As Exception
        Me.StopExecutionTimer()
        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        'leave open so can SAVE
      End Try

      'Try
      '  If cnn.State = ConnectionState.Closed Then cnn.Open()
      '  dtSchema = cnn.GetSchema()
      '  dtSchema = cnn.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, Nothing, "TABLE"})
      '  If cnn.State <> ConnectionState.Closed Then cnn.Close()
      '  Me.Grid.DataSource = dtSchema
      'Catch ex As Exception

      'End Try

      'try to gen update cmd
      '### THIS DOENST WORK WITH FOX PRO, IT DOESNT SUPPORT SCHEMA
      'Try
      '  m_Builder.GetUpdateCommand(False)

      '  Me.GridEditable = True
      'Catch ex As Exception
      '  'Trace.WriteLine(ex.Message)
      Me.GridEditable = False
      'End Try

    End If
  End Sub

  Private WriteOnly Property GridEditable() As Boolean
    Set(ByVal value As Boolean)
      Me.btnSaveTable.Enabled = value
      Me.Grid.AllowUserToAddRows = value
      Me.Grid.AllowUserToDeleteRows = value
    End Set
  End Property

  Private Sub SaveTable()
    If Me.DataSource Is Nothing OrElse m_Da Is Nothing OrElse m_Builder Is Nothing Then
      MessageBox.Show("Current Table not set", "Save Table", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      'SAVE
      'Dim dt As DataTable = Me.DataSource.GetChanges
      'If dt IsNot Nothing Then
      '  Try
      '    m_Da.Update(dt)
      '  Catch ex As Exception
      '    MessageBox.Show(ex.Message, "Save FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
      '  End Try
      'End If
      Try
        m_Da.Update(Me.DataSource)
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Save FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

    End If
  End Sub

  Private Shared Function BuildConnectionString(ByVal fileName As String) As String
    Return "Provider=vfpoledb.1;Data Source=" & fileName & ";Collating Sequence=general;"

  End Function
  Private Shared Function BuildConnectionString(ByVal dbContainer As String, ByVal fileName As String, ByVal useDbContainer As Boolean) As String
    'If useDSNLessConnection Then
    '  Return "SourceType=DBF;SourceDB=" & fileName & ";Driver={Microsoft Visual FoxPro Driver}"
    'Else
    'End If

    'cnn example from MS
    'Provider=vfpoledb.1;Data Source=C:\MyDbFolder\MyDbContainer.dbc;Collating Sequence=machine;

    If useDbContainer Then
      Return "Provider=vfpoledb.1;Data Source=" & dbContainer & ";Collating Sequence=machine;"
    Else
      Return BuildConnectionString(fileName)
    End If

  End Function

  Private Sub btnRefreshTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshTable.Click
    Me.OpenTable(Me.cboTables.Text)
  End Sub

  Private Sub BtnSchema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSchema.Click
    Me.OpenTable(Me.cboTables.Text, "1=2")
  End Sub

  Private Sub btnSaveTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTable.Click
    Me.SaveTable()
  End Sub


  Private Sub btnClearCommandText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearCommandText.Click
    Me.txtCommandText.Text = ""
  End Sub


  Private mExecutionTimerStart As Date

  Private Sub StartExecutionTimer()
    Me.lblExecutionTime.Text = ""
    mExecutionTimerStart = Now
  End Sub
  Private Sub StopExecutionTimer()
    Me.SetExecutionTime(mExecutionTimerStart, Now)
  End Sub

  Private Sub SetExecutionTime(ByVal startTime As Date, ByVal endTime As Date)
    Dim ts As TimeSpan = endTime.Subtract(startTime)
    Me.lblExecutionTime.Text = ts.ToString
    If Me.DataSource IsNot Nothing Then
      Me.lblExecutionTime.Text = Me.DataSource.Rows.Count & " Rows took: " & Me.lblExecutionTime.Text
    End If
  End Sub

  Private Sub btnExecuteCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecuteCommand.Click

    If Me.txtCommandText.Text = "" Then Return

    Dim tableFile As String = IO.Path.Combine(Me.DataFolder, Me.cboTables.Text & ".dbf")
    '    Dim KPDataConnection As New System.Data.OleDb.OleDbConnection(KPConnectionString)
    Dim cnn As OleDb.OleDbConnection = Nothing
    Dim cmd As OleDb.OleDbCommand = Nothing

    If IO.File.Exists(tableFile) Then
      Me.StartExecutionTimer()
      cnn = New OleDb.OleDbConnection(BuildConnectionString(tableFile))
      'm_Da = New OleDb.OleDbDataAdapter("SELECT * FROM " & tableFile, cnn)

      'm_Da.SelectCommand = New OleDb.OleDbCommand("SELECT * FROM " & tableFile, cnn)
      'm_Builder = GetBuilder(m_Da)

      cmd = cnn.CreateCommand()
      cmd.CommandText = Me.txtCommandText.Text

      Try
        cnn.Open()
        If Me.txtCommandText.Text.ToLower.StartsWith("select") Then
          Dim dt As New DataTable
          Dim dr As OleDb.OleDbDataReader
          dr = cmd.ExecuteReader

          dt.Load(dr)
          dr.Close()
          dr = Nothing
          'Me.Grid.DataSource = dt

          'Dim dv As DataView = VFPToolkit.vfpData.SqlExecute(cnn, "")
          Me.DataSource = dt
        Else
          cmd.ExecuteNonQuery()
        End If
        Me.StopExecutionTimer()
        'MessageBox.Show("Command seems to have executed correctly", "Execute Command", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        Me.StopExecutionTimer()
        MessageBox.Show(ex.Message, "ERROR EXECUTING COMMAND", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        If cmd IsNot Nothing Then
          cmd.Dispose()
          cmd = Nothing
        End If
        If cnn IsNot Nothing Then
          cnn.Dispose()
          cnn = Nothing
        End If
      End Try
    Else
      MessageBox.Show("Bad Table File", "Table file not found!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub

  Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    If Me.chkUseDbContainer.Checked Then
      Me.txtCommandText.SelectedText = Me.cboTables.Text
    Else
      Me.txtCommandText.SelectedText = Me.CurrentTableFile
    End If
  End Sub

  Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
    If Me.chkUseDbContainer.Checked Then
      Me.txtCommandText.Text = "UPDATE " & Me.cboTables.Text
    Else
      Me.txtCommandText.Text = "UPDATE " & Me.CurrentTableFile
    End If
  End Sub

  Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
    If Me.chkUseDbContainer.Checked Then
      'Me.cboTables.Text
      Me.txtCommandText.Text = "SELECT * FROM " & Me.cboTables.Text
    Else
      Me.txtCommandText.Text = "SELECT * FROM " & Me.CurrentTableFile
    End If

  End Sub

  Private Sub chkUseDbContainer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseDbContainer.CheckedChanged
    If Me.chkUseDbContainer.Checked Then
      LblDbFolder.Text = "Db Container:"
    Else
      LblDbFolder.Text = "Data Folder:"
    End If
  End Sub

  Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Text &= " v" & Application.ProductVersion
  End Sub

#Region "  Drag Drop File Support  "

  Private Declare Function DragAcceptFiles Lib "shell32.dll" (ByVal hwnd As IntPtr, ByVal accept As Boolean) As Long
  Private Declare Function DragQueryFile Lib "shell32.dll" (ByVal hdrop As IntPtr, ByVal ifile As Integer, ByVal fname As System.Text.StringBuilder, ByVal fnsize As Integer) As Integer
  Private Declare Sub DragFinish Lib "Shell32.dll" (ByVal hdrop As IntPtr)

  Public Const WM_DROPFILES As Integer = 563

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Application.AddMessageFilter(Me)
    DragAcceptFiles(Me.Handle, True)
  End Sub

  Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage
    If m.Msg = WM_DROPFILES Then

      'this code to handle multiple dropped files.. 

      'not really neccesary for this example

      Dim nfiles As Integer = DragQueryFile(m.WParam, -1, Nothing, 0)

      Dim i As Integer
      For i = 0 To nfiles
        Dim sb As New System.Text.StringBuilder(256)
        DragQueryFile(m.WParam, i, sb, 256)
        HandleDroppedFiles(sb.ToString())
      Next
      DragFinish(m.WParam)
      Return True
      'Else
      'Trace.WriteLine(m.Msg.ToString)
    End If

    Return False
  End Function

  Public Sub HandleDroppedFiles(ByVal file As String)
    If Len(file) > 0 Then

      'if db container file
      If LCase(file).EndsWith(".dbc") Then
        Me.chkUseDbContainer.Checked = True
        Me.DataContainer = file
        Me.FillDbTables()
        Return
      End If

      'if fox pro db file direct
      If LCase(file).EndsWith(".dbf") Or LCase(file).EndsWith(".cdx") Then
        Me.chkUseDbContainer.Checked = False
        Me.DataContainer = IO.Path.GetDirectoryName(file)
        Me.FillDbTables()
        Me.cboTables.Text = IO.Path.GetFileNameWithoutExtension(file)
        Return
      End If

      'assume its a folder ?
      If IO.Directory.Exists(file) Then
        Dim dbcFiles() As String = IO.Directory.GetFiles(file, "*.dbc", IO.SearchOption.TopDirectoryOnly)
        If dbcFiles.Length > 0 Then
          Me.chkUseDbContainer.Checked = True
          Me.DataContainer = dbcFiles(0)
        Else
          Me.chkUseDbContainer.Checked = False
          Me.DataContainer = file

        End If
        Me.FillDbTables()
      End If


    End If 'file len = 0

  End Sub

#End Region



  Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

    If Me.DataSource Is Nothing Then
      MessageBox.Show("Nothing to save, load some data first", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Return
    End If

    If Me.dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
      'ToDo: all saving to multi formats: csv, xls etc
      Try
        Me.DataSource.WriteXml(Me.dlgSave.FileName)
        MessageBox.Show("Data Exported Successfully", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Hmm, Error exporting data", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If

  End Sub

  
End Class
