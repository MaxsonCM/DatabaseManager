Public Class clsComponentsLoad

    Public Shared Function GetVersionDB() As String
        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            Return DB_AC.Version
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            Return "Version: Unknown"
        Else
            Return "Version: Unknown"
        End If
    End Function


    Public Shared Sub LoadListTable(ByRef listBox As ListBox)
        Dim myList As New List(Of String)
        Dim item As String

        listBox.Items.Clear()

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            myList = DB_AC.ListTable()
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            'myList = BD_FB.ListTable()
        Else
            Exit Sub
        End If

        For Each item In myList
            listBox.Items.Add(item)
        Next

    End Sub

    Public Shared Function LoadSchemaTable(ByVal tabela As String, ByRef grid As DataGridView) As DataTable
        Dim my_fields As New List(Of clsSchemaTable)
        Dim field As New clsSchemaTable

        Dim dt As DataTable
        Dim dc As DataColumn
        Dim dr As DataRow

        dt = New DataTable()

        dc = New DataColumn("POSITION", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)
        dc = New DataColumn("COLUMN_NAME", Type.GetType("System.String"))
        dt.Columns.Add(dc)
        dc = New DataColumn("DATA_TYPE", Type.GetType("System.String"))
        dt.Columns.Add(dc)
        dc = New DataColumn("CHARACTER_LENGHT", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)
        dc = New DataColumn("PRECISION", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)
        dc = New DataColumn("SCALE", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)
        dc = New DataColumn("DESCRIPTION", Type.GetType("System.String"))
        dt.Columns.Add(dc)

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            my_fields = DB_AC.ListFields(tabela)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            'exemple
            'ds = BD_FB.ListTable()
        Else

        End If

        For Each field In my_fields
            dr = dt.NewRow()
            dr("POSITION") = field.POSITION
            dr("COLUMN_NAME") = field.COLUMN_NAME
            dr("DATA_TYPE") = field.DATA_TYPE
            dr("CHARACTER_LENGHT") = field.CHARACTER_LENGHT
            dr("PRECISION") = field.NUMERIC_PRECISION
            dt.Rows.Add(dr)
        Next

        Return dt

    End Function


End Class
