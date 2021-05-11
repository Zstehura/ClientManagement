Public Class frmSwitchBoard
    Private Sub btnNewClient_Click(sender As Object, e As EventArgs) Handles btnNewClient.Click
        Dim frmCli As New frmClients
        frmCli.Show()
    End Sub

    Private Sub btnNewBusiness_Click(sender As Object, e As EventArgs) Handles btnNewBusiness.Click
        Dim frmVisit As New frmVisitation
        frmVisit.Show()
    End Sub

    Private Sub btnClientLookup_Click(sender As Object, e As EventArgs) Handles btnClientLookup.Click
        Dim frmCliAll As New frmAllClients
        frmCliAll.Show()
    End Sub

    Private Sub btnVisitLookup_Click(sender As Object, e As EventArgs) Handles btnVisitLookup.Click
        Dim frmVisAll As New frmAllVisits
        frmVisAll.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
