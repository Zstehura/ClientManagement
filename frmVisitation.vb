Public Class frmVisitation
    Private Sub Business_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Business_tableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Business_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClientDBDataSet)
    End Sub

    Private Sub frmVisitation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientDBDataSet.Client_table' table. You can move, or remove it, as needed.
        Me.Client_tableTableAdapter.Fill(Me.ClientDBDataSet.Client_table)
        'TODO: This line of code loads data into the 'ClientDBDataSet.Business_table' table. You can move, or remove it, as needed.
        Me.Business_tableTableAdapter.Fill(Me.ClientDBDataSet.Business_table)

        For Each cliNames In Me.Client_tableTableAdapter.GetData()
            Dim strCliName As String = cliNames.FirstName
            strCliName = strCliName & " " & cliNames.LastName
            txtClientName.AutoCompleteCustomSource.Add(strCliName)
        Next
    End Sub

    Private Sub chkGeneral_CheckedChanged(sender As Object, e As EventArgs) Handles chkGeneral.CheckedChanged
        If chkGeneral.Checked = True Then
            txtClientName.Text = "General"
            txtClientName.Enabled = False
        Else
            txtClientName.Enabled = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Asks if you actually want to clear then either does or doesn't

        Dim intAnswer As Integer = 0
        intAnswer = MsgBox("You are about to clear this entry." & Environment.NewLine & "Are you sure?", 4, "Clear?")

        If intAnswer = 6 Then
            txtAssociate.Text = ""
            txtBusiness.Text = ""
            datDateOf.Text = ""
            datDateOf.Value = Today()
            txtDescription.Text = ""
            txtClientName.Text = ""
            txtLocation.Text = ""
            txtBusiness.Focus()
        ElseIf intAnswer = 7 Then
            Exit Sub
        Else
            MessageBox.Show("Something went really wrong")
        End If
    End Sub

    Private Sub BindingNavigatorPositionItem_Changed(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        If txtClientName.Text = "General" Then
            txtClientName.Enabled = False
            chkGeneral.Checked = True
        Else
            txtClientName.Enabled = True
            chkGeneral.Checked = False
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        datDateOf.Value = Today()
    End Sub
End Class