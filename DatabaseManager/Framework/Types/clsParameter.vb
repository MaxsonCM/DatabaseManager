Public Class clsParameter
    Dim _COLUMN_NAME As String
    Dim _VALUE As String

    Public Sub New()
        _COLUMN_NAME = ""
        _VALUE = ""
    End Sub

    Public Property COLUMN_NAME As String
        Get
            Return _COLUMN_NAME
        End Get
        Set(ByVal value As String)
            _COLUMN_NAME = value
        End Set
    End Property

    Public Property VALUE As String
        Get
            Return _VALUE
        End Get
        Set(ByVal value As String)
            _VALUE = value
        End Set
    End Property
End Class
