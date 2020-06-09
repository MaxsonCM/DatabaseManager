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

    Public Shared Function LoadListTable(ByRef listBox As ListBox) As Boolean
        Dim myList As New List(Of String)
        Dim item As String

        Try

            listBox.Items.Clear()

            If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
                myList = DB_AC.ListTable()
            ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
                'myList = BD_FB.ListTable()
                Return False
            Else
                Return False
            End If

            For Each item In myList
                listBox.Items.Add(item)
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function LoadGrid(ByVal table As String) As DataTable
        Dim dt As New DataTable
        'Dim command As String

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            'command = "SELECT * FROM [" & table & "]"
            'dt = DB_AC.Execute(command)

            dt = DB_AC.SearchTable(table)
        Else
            Return Nothing
        End If

        Return dt
    End Function

    Public Shared Function LoadSchemaTable(ByVal my_table As String, ByRef grid As DataGridView) As Boolean
        Dim my_fields As New List(Of clsSchemaTable)
        Dim field As New clsSchemaTable

        Dim dt As DataTable
        Dim dr As DataRow
        Dim imageConverter = New ImageConverter()

        dt = New DataTable()

        dt = ConfigureDataTable()

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            my_fields = DB_AC.ListFields(my_table)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            'exemple
            'ds = BD_FB.ListTable()
        Else

        End If

        For Each field In my_fields
            dr = dt.NewRow()

            If field.IS_PRIMARY_KEY Then
                dr("Key") = imageConverter.ConvertTo(My.Resources.Key_16, System.Type.GetType("System.Byte[]"))
            Else
                dr("Key") = imageConverter.ConvertTo(My.Resources.blank_16, System.Type.GetType("System.Byte[]"))
            End If

            'dr("Key") = My.Resources.blank_16
            dr("Position") = field.POSITION
            dr("Column Name") = field.COLUMN_NAME
            dr("Data Type") = field.DATA_TYPE
            dr("Character Lenght") = field.CHARACTER_LENGHT
            dr("Precision") = field.NUMERIC_PRECISION
            dr("Scale") = field.NUMERIC_SCALE
            dr("Description") = field.DESCRIPTION
            dt.Rows.Add(dr)
        Next

        grid.DataSource = dt

        Return True

    End Function


    Public Shared Function LoadSchemaIndexs(ByVal my_table As String, ByRef grid As DataGridView) As Boolean
        Dim my_fields As New List(Of clsSchemaTable)
        Dim field As New clsSchemaTable

        Dim dt As DataTable
        Dim dr As DataRow
        Dim imageConverter = New ImageConverter()

        dt = New DataTable()

        dt = ConfigureDataTable()

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            my_fields = DB_AC.ListFields(my_table)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            'exemple
            'ds = BD_FB.ListTable()
        Else

        End If

        For Each field In my_fields
            dr = dt.NewRow()

            If field.IS_PRIMARY_KEY Then
                dr("Key") = imageConverter.ConvertTo(My.Resources.Key_16, System.Type.GetType("System.Byte[]"))
            Else
                dr("Key") = imageConverter.ConvertTo(My.Resources.blank_16, System.Type.GetType("System.Byte[]"))
            End If

            'dr("Key") = My.Resources.blank_16
            dr("Position") = field.POSITION
            dr("Column Name") = field.COLUMN_NAME
            dr("Data Type") = field.DATA_TYPE
            dr("Character Lenght") = field.CHARACTER_LENGHT
            dr("Precision") = field.NUMERIC_PRECISION
            dr("Scale") = field.NUMERIC_SCALE
            dr("Description") = field.DESCRIPTION
            dt.Rows.Add(dr)
        Next

        grid.DataSource = dt

        Return True

    End Function


    Private Shared Function ConfigureDataTable() As DataTable
        Dim dt As DataTable
        Dim dc As DataColumn

        dt = New DataTable()

        dc = New DataColumn("Key", Type.GetType("System.Byte[]"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Position", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Column Name", Type.GetType("System.String"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Data Type", Type.GetType("System.String"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Character Lenght", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Precision", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Scale", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Description", Type.GetType("System.String"))
        dt.Columns.Add(dc)

        Return dt
    End Function

End Class
