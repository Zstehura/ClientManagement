Public Class frmClients
    Private Sub Client_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Client_tableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Client_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClientDBDataSet)

    End Sub

    Private Sub frmNewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientDBDataSet.Client_table' table. You can move, or remove it, as needed.
        Me.Client_tableTableAdapter.Fill(Me.ClientDBDataSet.Client_table)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Asks if you actually want to clear then either does or doesn't

        Dim intAnswer As Integer = 0
        intAnswer = MsgBox("You are about to clear this entry." & Environment.NewLine & "Are you sure?", 4, "Clear?")

        If intAnswer = 6 Then
            txtAddress.Text = ""
            txtCircum.Text = ""
            txtCity.Text = ""
            txtDoB.Text = ""
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtState.Text = ""
            txtZip.Text = ""
            txtFirstName.Focus()
        ElseIf intAnswer = 7 Then
            Exit Sub
        Else
            MessageBox.Show("Something went really wrong")
        End If
    End Sub
End Class