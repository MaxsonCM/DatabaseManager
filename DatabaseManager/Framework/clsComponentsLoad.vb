Public Class clsComponentsLoad

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

End Class
