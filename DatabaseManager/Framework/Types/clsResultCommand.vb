Public Class clsResultCommand

    Private _COMMAND As String
    Private _HAS_ERRO As Boolean
    Private _RESULT As String

    Public Sub New()
        _COMMAND = ""
        _HAS_ERRO = False
        _RESULT = ""
    End Sub

    Public Property COMMAND As String
        Get
            Return _COMMAND
        End Get
        Set(ByVal value As String)
            _COMMAND = value
        End Set
    End Property

    Public Property RESULT As String
        Get
            Return _RESULT
        End Get
        Set(ByVal value As String)
            _RESULT = value
        End Set
    End Property

    Public Property HAS_ERRO As Boolean
        Get
            Return _HAS_ERRO
        End Get
        Set(ByVal value As Boolean)
            _HAS_ERRO = value
        End Set
    End Property
End Class
