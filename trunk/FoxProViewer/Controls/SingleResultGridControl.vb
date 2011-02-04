Imports System.ComponentModel

Public Class SingleResultGridControl

  Private mResultSplitter As Splitter

  <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
  Public Property ResultSplitter() As Splitter
    Get
      Return mResultSplitter
    End Get
    Set(ByVal value As Splitter)
      mResultSplitter = value
    End Set
  End Property

End Class
