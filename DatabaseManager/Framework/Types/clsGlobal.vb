
Public Class clsGlobal
    Private Shared _local_database As String
    Public Shared sourceDataBase As String
    Public Shared passDataBase As String
    Public Shared userDataBase As String
    Public Shared portDataBase As String
    Private Shared _type_database As DATABASE_TYPE = DATABASE_TYPE.NONE

    Public Shared Property localDataBase() As String
        Get
            Return _local_database
        End Get
        Set(ByVal Value As String)
            _local_database = Value

            Dim extension As String = clsUSEFUL.ExtensionFileName(_local_database)

            If extension = "MDB" Or extension = "ACCDB" Then
                _type_database = DATABASE_TYPE.ACCESS
            ElseIf extension = "FDB" Or extension = "GDB" Then
                _type_database = DATABASE_TYPE.FIREBIRD
            ElseIf _type_database = DATABASE_TYPE.NONE Then
                MsgBox("Unknown database !", MsgBoxStyle.Exclamation)
            End If

        End Set
    End Property

    Public Shared Property type_database() As DATABASE_TYPE
        Get
            Return _type_database
        End Get
        Set(ByVal Value As DATABASE_TYPE)
            _type_database = Value
        End Set
    End Property



End Class
