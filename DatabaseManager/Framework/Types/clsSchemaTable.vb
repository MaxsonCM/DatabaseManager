Public Class clsSchemaTable
    Dim _POSITION As Integer
    Dim _COLUMN_NAME As String
    Dim _DEFAULT_VALUE As String
    Dim _IS_NULLABLE As Boolean
    Dim _IS_PRIMARY_KEY As Boolean
    Dim _DATA_TYPE_CODE As Integer
    Dim _DATA_TYPE As String
    Dim _CHARACTER_LENGHT As Long
    Dim _NUMERIC_PRECISION As Long
    Dim _NUMERIC_SCALE As Long
    Dim _DESCRIPTION As String
    Dim _SEGMENT_LENGTH As Long

    Public Sub New()
        _POSITION = -1
        _COLUMN_NAME = ""
        _DEFAULT_VALUE = ""
        _IS_NULLABLE = True
        _IS_PRIMARY_KEY = False
        _DATA_TYPE_CODE = Nothing
        _DATA_TYPE = ""
        _CHARACTER_LENGHT = Nothing
        _NUMERIC_PRECISION = Nothing
        _NUMERIC_SCALE = Nothing
        _DESCRIPTION = ""
        _SEGMENT_LENGTH = Nothing
    End Sub

    Public Property POSITION As Integer
        Get
            Return _POSITION
        End Get
        Set(ByVal value As Integer)
            _POSITION = value
        End Set
    End Property

    Public Property COLUMN_NAME As String
        Get
            Return _COLUMN_NAME
        End Get
        Set(ByVal value As String)
            _COLUMN_NAME = value
        End Set
    End Property

    Public Property DEFAULT_VALUE As String
        Get
            Return _DEFAULT_VALUE
        End Get
        Set(ByVal value As String)
            _DEFAULT_VALUE = value
        End Set
    End Property

    Public Property IS_NULLABLE As Boolean
        Get
            Return _IS_NULLABLE
        End Get
        Set(ByVal value As Boolean)
            _IS_NULLABLE = value
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

    Public Property DATA_TYPE_CODE As Integer
        Get
            Return _DATA_TYPE_CODE
        End Get
        Set(ByVal value As Integer)
            _DATA_TYPE_CODE = value
        End Set
    End Property

    Public Property DATA_TYPE As String
        Get
            Return _DATA_TYPE
        End Get
        Set(ByVal value As String)
            _DATA_TYPE = value
        End Set
    End Property

    Public Property CHARACTER_LENGHT As Long
        Get
            Return _CHARACTER_LENGHT
        End Get
        Set(ByVal value As Long)
            _CHARACTER_LENGHT = value
        End Set
    End Property

    Public Property NUMERIC_PRECISION As Long
        Get
            Return _NUMERIC_PRECISION
        End Get
        Set(ByVal value As Long)
            _NUMERIC_PRECISION = value
        End Set
    End Property

    Public Property NUMERIC_SCALE As Long
        Get
            Return _NUMERIC_SCALE
        End Get
        Set(ByVal value As Long)
            _NUMERIC_SCALE = value
        End Set
    End Property

    Public Property DESCRIPTION As String
        Get
            Return _DESCRIPTION
        End Get
        Set(ByVal value As String)
            _DESCRIPTION = value
        End Set
    End Property

    Public Property SEGMENT_LENGTH() As Long
        Get
            Return _SEGMENT_LENGTH
        End Get
        Set(ByVal value As Long)
            _SEGMENT_LENGTH = value
        End Set
    End Property

End Class
