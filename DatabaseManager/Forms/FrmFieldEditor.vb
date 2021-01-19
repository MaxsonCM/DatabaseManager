Imports System.Windows.Forms

Public Class FrmFieldEditor

    Public table, field As String

    Private Sub FrmFieldEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Len(field) > 0 Then
            Me.Text = "Edit field [" & field & "]"
        Else
            Me.Text = "New field"
        End If

        LblTable.Text = table
        TxtField.Text = field

        Call DB_Mediator.LoadTypes(CmbType)

        CmbSubType.Items.Clear()
        CmbSubType.Visible = False
        LblSubType.Visible = False

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
