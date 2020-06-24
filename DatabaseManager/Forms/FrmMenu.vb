Imports System.Windows.Forms
Imports System.IO

Public Class FrmMenu

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim new_form As New FrmCommand
        new_form.MdiParent = Me
        new_form.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        
        FrmInfoDB.ShowDialog()

        Call tsbRefresh_Click(sender, e)

    End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click
        Call OpenFile(sender, e)
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersionDB.Visible = False
        lblCaptionLabel.Visible = False

        TrvEstructure.Nodes.Clear()

        If File.Exists(clsGlobal.localDataBase) Then
            Call clsComponentsLoad.LoadListTable_Proc(TrvEstructure)
        End If
    End Sub
    
    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        lblVersionDB.Visible = False
        lblCaptionLabel.Visible = False

        If File.Exists(clsGlobal.localDataBase) Then

            If clsComponentsLoad.LoadListTable_Proc(TrvEstructure) Then

                lblVersionDB.Text = clsComponentsLoad.GetVersionDB
                If lblVersionDB.Text <> "error" Then
                    lblVersionDB.Visible = True
                    lblCaptionLabel.Visible = True
                End If
            End If
        Else
            'MsgBox("Database not found!")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub

    Private Sub ScriptyExecuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptyExecuteToolStripMenuItem.Click

        Dim new_window As New FrmCommand
        new_window.MdiParent = Me
        new_window.Show()

    End Sub

    Private Sub TrvEstructure_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TrvEstructure.AfterSelect
        Dim node_root, node_child As String

        If IsNothing(e.Node.Parent) Then Exit Sub

        Try

            node_root = e.Node.Parent.Text
            node_child = e.Node.Text

            If LCase(node_root) = "tables" Then
                Dim frmCollection As New FormCollection()
                frmCollection = Application.OpenForms()

                Dim new_window As New FrmTableEditor

                For Each new_window In frmCollection.OfType(Of FrmTableEditor)()
                    If new_window.table = node_child Then
                        new_window.BringToFront()
                        Exit Sub
                    End If
                Next

                new_window = New FrmTableEditor
                new_window.table = node_child
                new_window.MdiParent = Me
                new_window.Show()
            ElseIf LCase(node_root) = "procedures" Then

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
