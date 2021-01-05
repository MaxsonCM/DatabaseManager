Public Class DB_Mediator

    Public Shared Function GetVersionDB() As String
        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            Return DB_AC.Version
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            Return DB_FB.GetDialectVersion + " - " + DB_FB.Version
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
                myList = DB_FB.ListTable()
                Return False
            Else
                MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")
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

    Public Shared Function LoadListTable_Proc(ByRef my_tree As TreeView) As Boolean
        Dim myTablesList, myProcsList, myViewsList As New List(Of String)
        Dim nodo_root As TreeNode
        Dim item As String

        Try

            my_tree.Nodes.Clear()

            If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
                myTablesList = DB_AC.ListTable()
                myProcsList = DB_AC.ListProcedures()
                myViewsList = DB_AC.ListViews()
            ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
                myTablesList = DB_FB.ListTable()
                myProcsList = DB_FB.ListProcedures()
                myViewsList = DB_FB.ListViews()
            Else
                MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")
                Return False
            End If

            nodo_root = New TreeNode

            If myTablesList.Count > 0 Then
                nodo_root = my_tree.Nodes.Add("Tables", "Tables", 1, 1)
                For Each item In myTablesList
                    nodo_root.Nodes.Add(item, item, 1, 1)
                Next
            End If

            If myProcsList.Count > 0 Then
                nodo_root = my_tree.Nodes.Add("Procedures", "Procedures", 2, 2)
                For Each item In myProcsList
                    nodo_root.Nodes.Add(item, item, 2, 2)
                Next
            End If

            If myViewsList.Count > 0 Then
                nodo_root = my_tree.Nodes.Add("Views", "Views", 3, 3)
                For Each item In myViewsList
                    nodo_root.Nodes.Add(item, item, 3, 3)
                Next
            End If

            my_tree.ExpandAll()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function LoadGrid(ByVal table As String, Optional ByVal where_clause As String = "") As DataSet
        Dim ds As New DataSet

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            ds = DB_AC.SearchTable(table, where_clause)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            ds = DB_FB.SearchTable(table, where_clause)
        Else
            MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")
            Return Nothing
        End If

        Return ds
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
            my_fields = DB_FB.ListFields(my_table)
        Else
            MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")
        End If

        If Not IsNothing(my_fields) Then

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
                dr("Segment Length") = field.SEGMENT_LENGTH
                dt.Rows.Add(dr)
            Next

            grid.DataSource = dt

        End If

        Return True

    End Function

    Public Shared Function LoadSchemaIndexs(ByVal table As String, ByRef my_tree As TreeView) As Boolean
        Dim my_indexs As New List(Of clsSchemaIndex)
        Dim index As New clsSchemaIndex
        Dim nodo_root, nodo_index, nodo_field As TreeNode
        Dim imageIdex As Integer

        Dim last_index As String
        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            my_indexs = DB_AC.ListAllIndex(table)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            my_indexs = DB_FB.ListAllIndex(table)
        Else
            MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")
        End If

        my_tree.Nodes.Clear()

        last_index = ""

        nodo_root = New TreeNode
        nodo_index = New TreeNode
        nodo_field = New TreeNode

        nodo_root = my_tree.Nodes.Add("Indixes", "Indixes", 1, 1)

        For Each index In my_indexs
            If last_index <> index.INDEX_NAME Then
                If last_index <> "" Then
                    nodo_index = New TreeNode
                    nodo_field = New TreeNode
                End If

                imageIdex = -1

                If index.IS_PRIMARY_KEY Then
                    imageIdex = 5
                ElseIf index.IS_FOREIGN_KEY Then
                    imageIdex = 4
                ElseIf index.IS_UNIQUE Then
                    imageIdex = 2
                Else
                    imageIdex = 3
                End If

                nodo_index = nodo_root.Nodes.Add(index.INDEX_NAME, index.INDEX_NAME, imageIdex, imageIdex)
            End If

            nodo_field = nodo_index.Nodes.Add(index.COLUMNS_NAME, index.COLUMNS_NAME, 6, 6)

            last_index = index.INDEX_NAME
        Next


        my_tree.ExpandAll()

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
        dc = New DataColumn("Segment Length", Type.GetType("System.Int32"))
        dt.Columns.Add(dc)

        Return dt
    End Function

    Shared Function ScriptDropTable(ByVal table As String) As String

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            Return DB_AC.GetScriptDropTable(table)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            Return DB_FB.GetScriptDropTable(table)
        Else
            MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")
        End If

        Return ""
    End Function

    Shared Function ScriptDropProcedure(ByVal procedure As String) As String

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            Return DB_AC.GetScriptDropProcedure(procedure)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            Return DB_FB.GetScriptDropProcedure(procedure)
        Else
            MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")
        End If

        Return ""
    End Function

    Shared Function Script_execute(ByVal my_command As String, Optional ByRef my_status As String = "", Optional ByRef data As DataSet = Nothing) As Boolean

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            Return DB_AC.Script_execute(my_command, my_status, data)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            Return DB_FB.Script_execute(my_command, my_status, data)
        Else
            MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")
            my_status = "The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!"
            Return False
        End If

        Return True
    End Function

    Shared Function Translate_criteria(ByVal column As String, ByVal criteria As String, ByVal value As String) As String

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            Return DB_AC.Translate_criteria(column, criteria, value)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
            Return DB_FB.Translate_criteria(column, criteria, value)
        Else
            MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")

            Return ""
        End If

    End Function

    Shared Function test_connection() As Boolean
        
        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then

            If Not DB_AC.Test_connection Then
                Return False
            End If

        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then

            If Not DB_FB.Test_conection Then
                Return False
            End If

        Else
            MsgBox("The functions [" & System.Reflection.MethodInfo.GetCurrentMethod().Name & "] has not implemented for the current database!")

            Return False
        End If

        Return True
    End Function

End Class
