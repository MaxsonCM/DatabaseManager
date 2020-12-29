Public Class ccoTreeView
    Inherits System.Windows.Forms.TreeView

    Protected m_coll As ArrayList
    Protected m_lastNode, m_firstNode As TreeNode

    Public Sub New()
        m_coll = New ArrayList()
    End Sub

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        MyBase.OnPaint(pe)
    End Sub

    Public Property SelectedNodes As ArrayList
        Get
            Return m_coll
        End Get
        Set(ByVal value As ArrayList)
            removePaintFromNodes()
            m_coll.Clear()
            m_coll = value
            paintSelectedNodes()
        End Set
    End Property

    Protected Overrides Sub OnBeforeSelect(ByVal e As TreeViewCancelEventArgs)
        MyBase.OnBeforeSelect(e)
        Dim bControl As Boolean = (ModifierKeys = Keys.Control)
        Dim bShift As Boolean = (ModifierKeys = Keys.Shift)

        If bControl AndAlso m_coll.Contains(e.Node) Then
            e.Cancel = True
            removePaintFromNodes()
            m_coll.Remove(e.Node)
            paintSelectedNodes()
            Return
        End If

        m_lastNode = e.Node
        If Not bShift Then m_firstNode = e.Node
    End Sub

    Protected Overrides Sub OnAfterSelect(ByVal e As TreeViewEventArgs)
        MyBase.OnAfterSelect(e)
        Dim bControl As Boolean = (ModifierKeys = Keys.Control)
        Dim bShift As Boolean = (ModifierKeys = Keys.Shift)

        If bControl Then

            If Not m_coll.Contains(e.Node) Then
                m_coll.Add(e.Node)
            Else
                removePaintFromNodes()
                m_coll.Remove(e.Node)
            End If

            paintSelectedNodes()
        Else

            If bShift Then
                Dim myQueue As Queue = New Queue()
                Dim uppernode As TreeNode = m_firstNode
                Dim bottomnode As TreeNode = e.Node
                Dim bParent As Boolean = isParent(m_firstNode, e.Node)

                If Not bParent Then
                    bParent = isParent(bottomnode, uppernode)

                    If bParent Then
                        Dim t As TreeNode = uppernode
                        uppernode = bottomnode
                        bottomnode = t
                    End If
                End If

                If bParent Then
                    Dim n As TreeNode = bottomnode

                    While n.Text.Trim.ToLower <> uppernode.Parent.Text.Trim.ToLower
                        If Not m_coll.Contains(n) Then myQueue.Enqueue(n)
                        n = n.Parent
                    End While
                Else

                    If (uppernode.Parent Is Nothing AndAlso bottomnode.Parent Is Nothing) OrElse (uppernode.Parent IsNot Nothing AndAlso uppernode.Parent.Nodes.Contains(bottomnode)) Then
                        Dim nIndexUpper As Integer = uppernode.Index
                        Dim nIndexBottom As Integer = bottomnode.Index

                        If nIndexBottom < nIndexUpper Then
                            Dim t As TreeNode = uppernode
                            uppernode = bottomnode
                            bottomnode = t
                            nIndexUpper = uppernode.Index
                            nIndexBottom = bottomnode.Index
                        End If

                        Dim n As TreeNode = uppernode

                        While nIndexUpper <= nIndexBottom
                            If Not m_coll.Contains(n) Then myQueue.Enqueue(n)
                            n = n.NextNode
                            nIndexUpper += 1
                        End While
                    Else
                        If Not m_coll.Contains(uppernode) Then myQueue.Enqueue(uppernode)
                        If Not m_coll.Contains(bottomnode) Then myQueue.Enqueue(bottomnode)
                    End If
                End If

                m_coll.AddRange(myQueue)
                paintSelectedNodes()
                m_firstNode = e.Node
            Else

                If m_coll IsNot Nothing AndAlso m_coll.Count > 0 Then
                    removePaintFromNodes()
                    m_coll.Clear()
                End If

                m_coll.Add(e.Node)
            End If
        End If
    End Sub

    Protected Function isParent(ByVal parentNode As TreeNode, ByVal childNode As TreeNode) As Boolean
        If parentNode.Text.Trim.ToLower = childNode.Text.Trim.ToLower Then Return True
        Dim n As TreeNode = childNode
        Dim bFound As Boolean = False

        While Not bFound AndAlso n IsNot Nothing
            n = n.Parent
            If IsNothing(n) Then Exit While
            bFound = (n.Text.Trim.ToLower = parentNode.Text.Trim.ToLower)
        End While

        Return bFound
    End Function

    Protected Sub paintSelectedNodes()
        For Each n As TreeNode In m_coll
            n.BackColor = SystemColors.Highlight
            n.ForeColor = SystemColors.HighlightText
        Next
    End Sub

    Protected Sub removePaintFromNodes()
        If m_coll.Count = 0 Then Return
        Dim n0 As TreeNode = CType(m_coll(0), TreeNode)
        Dim back As Color = n0.TreeView.BackColor
        Dim fore As Color = n0.TreeView.ForeColor

        For Each n As TreeNode In m_coll
            n.BackColor = back
            n.ForeColor = fore
        Next
    End Sub

End Class
