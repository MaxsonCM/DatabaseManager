
Public Class clsGlobal
    Private Shared _local_database As String
    Public Shared passDataBase As String
    Private Shared _type_database As DATABASE_TYPE = DATABASE_TYPE.NONE

    Public Shared Property localDataBase() As String
        Get
            Return _local_database
        End Get
        Set(ByVal Value As String)
            _local_database = Value

            Dim extension As String = clsUTIL.ExtensionFileName(_local_database)

            If extension = "MDB" Or extension = "ACCDB" Then
                _type_database = DATABASE_TYPE.ACCESS
            ElseIf extension = "FDB" Or extension = "GDB" Then
                _type_database = DATABASE_TYPE.FIREBIRD
            Else
                _type_database = DATABASE_TYPE.NONE
                MsgBox("Unknown database", MsgBoxStyle.Exclamation)
            End If

        End Set
    End Property

    Public Shared ReadOnly Property type_database() As DATABASE_TYPE
        Get
            Return _type_database
        End Get
    End Property



End Class
