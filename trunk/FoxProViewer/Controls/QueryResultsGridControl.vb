Imports System.ComponentModel

<ToolboxItem(False)> _
Public Class QueryResultsGridControl

  Private mDataSource As DataSet
  Private mResultControls As List(Of SingleResultGridControl)

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.NewCommon()
  End Sub

  Private Sub NewCommon()
    mResultControls = New List(Of SingleResultGridControl)
  End Sub

  <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
  Public Property DataSource() As DataSet
    Get
      Return mDataSource
    End Get
    Set(ByVal value As DataSet)
      Me.SetDataSource(value)
    End Set
  End Property

  <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
  Public ReadOnly Property ResultControls() As List(Of SingleResultGridControl)
    Get
      Return Me.mResultControls
    End Get
  End Property

  <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
  Public ReadOnly Property TotalRecords() As Integer
    Get
      If Me.DataSource Is Nothing OrElse Me.DataSource.Tables.Count = 0 Then Return 0
      Dim iTally As Integer = 0
      For Each t As DataTable In Me.DataSource.Tables
        iTally += t.Rows.Count
      Next
      Return iTally
    End Get
  End Property


  Public Sub SetDataSource(ByVal ds As DataSet)
    mDataSource = ds
    Me.ClearResults()
    If ds Is Nothing OrElse ds.Tables.Count = 0 Then Return
    'If ds.Tables.Count <> Me.ResultControls.Count Then
    Me.ClearResults()
    'End If
    For Each t As DataTable In ds.Tables
      Me.AddResultTable(t, ds.Tables.Count)
    Next

    'Me.AutoSizeGridPanel()

  End Sub

  Private Sub AddResultTable(ByVal resultTable As DataTable, ByVal totalCount As Integer)

    Dim resultControl As New SingleResultGridControl
    Me.ResultControls.Add(resultControl)
    resultControl.Dock = DockStyle.Fill
    Dim nHeight As Integer = CInt(Me.Height / totalCount)


    If Me.ResultControls.Count > 1 Then
      resultControl.Dock = DockStyle.Bottom
      resultControl.ResultSplitter = New Splitter
      'resultControl.BringToFront()

      With resultControl.ResultSplitter
        .Parent = Me
        .Dock = DockStyle.Bottom
        '.BringToFront()
        .SendToBack()
      End With
    End If

    With resultControl
      .Name = "resultControl" & Me.ResultControls.Count.ToString
      .Parent = Me
      .Height = nHeight
      '.Dock = DockStyle.Fill
      .Grid.DataSource = resultTable
      .SendToBack()
    End With



  End Sub


  Public Sub ClearResults()

    For Each resultCtrl As SingleResultGridControl In Me.ResultControls
      resultCtrl.Parent = Nothing
      If resultCtrl.ResultSplitter IsNot Nothing Then
        'remove this also
        resultCtrl.ResultSplitter.Parent = Nothing
        resultCtrl.ResultSplitter = Nothing
      End If
      resultCtrl.Dispose()
    Next

    Me.ResultControls.Clear()

  End Sub

  'Private Sub AutoSizeGridPanel()

  '  Dim iHeight As Integer = 0
  '  For Each ctrl As Control In Me.Panel1.Controls
  '    iHeight += ctrl.Height
  '  Next
  '  If iHeight < Me.Height Then iHeight = Me.Height
  '  If Me.ResultControls IsNot Nothing Then
  '    If Me.ResultControls.Count <= 1 Then iHeight = Me.Height
  '  End If
  '  Me.Panel1.Height = iHeight
  'End Sub


  'Private Sub QueryResultsGridControl_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
  '  Me.AutoSizeGridPanel()
  'End Sub

End Class
