Public Class clsSchemaIndex
    Private _INDEX_NAME As String
    Private _IS_PRIMARY_KEY As Boolean
    Private _IS_UNIQUE As Boolean
    Private _NOT_NULL As Boolean
    Private _COLUMNS_NAME As List(Of String)


    Public Property INDEX_NAME As String
        Get
            Return _INDEX_NAME
        End Get
        Set(ByVal value As String)
            _INDEX_NAME = value
        End Set
    End Property

    Public Property IS_PRIMARY_KEY As Boolean
        Get
            Return _IS_PRIMARY_KEY
        End Get
        Set(ByVal value As Boolean)
            _IS_PRIMARY_KEY = value
        End Set
    End Property

    Public Property IS_UNIQUE As Boolean
        Get
            Return _IS_UNIQUE
        End Get
        Set(ByVal value As Boolean)
            _IS_UNIQUE = value
        End Set
    End Property

    Public Property NOT_NULL As Boolean
        Get
            Return _NOT_NULL
        End Get
        Set(ByVal value As Boolean)
            _NOT_NULL = value
        End Set
    End Property

    Public Property COLUMNS_NAME() As List(Of String)
        Get
            Return _COLUMNS_NAME
        End Get
        Set(ByVal value As List(Of String))
            _COLUMNS_NAME = value
        End Set
    End Property
End Class
