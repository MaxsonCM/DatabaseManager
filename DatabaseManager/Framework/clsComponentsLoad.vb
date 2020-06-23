﻿Public Class clsComponentsLoad

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

    Public Shared Function LoadListTable_Proc(ByRef my_tree As TreeView) As Boolean
        Dim myTablesList, myProcList As New List(Of String)
        Dim nodo_root As TreeNode
        Dim item As String

        Try

            my_tree.Nodes.Clear()

            If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
                myTablesList = DB_AC.ListTable()
                myProcList = DB_AC.ListProcedures()
            ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then
                'myList = BD_FB.ListTable()
                Return False
            Else
                Return False
            End If

            nodo_root = New TreeNode

            If myTablesList.Count > 0 Then
                nodo_root = my_tree.Nodes.Add("Tables", "Tables", 1, 1)
                For Each item In myTablesList
                    nodo_root.Nodes.Add(item, item, 3, 3)
                Next
            End If

            If myProcList.Count > 0 Then
                nodo_root = my_tree.Nodes.Add("Procedures", "Procedures", 2, 2)
                For Each item In myProcList
                    nodo_root.Nodes.Add(item, item, 3, 3)
                Next
            End If


            my_tree.ExpandAll()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function LoadGrid(ByVal table As String) As DataSet
        Dim ds As New DataSet

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            ds = DB_AC.SearchTable(table)
        Else
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

    Public Shared Function LoadSchemaIndexs(ByVal table As String, ByRef my_tree As TreeView) As Boolean
        Dim my_indexs As New List(Of clsSchemaIndex)
        Dim index As New clsSchemaIndex
        Dim nodo_root, nodo_index, nodo_field As TreeNode
        Dim imageIdex As Integer

        Dim last_index As String
        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            my_indexs = DB_AC.ListAllIndex(table)
        ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then

        Else

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

        Return dt
    End Function

End Class
