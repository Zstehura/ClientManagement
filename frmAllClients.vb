Public Class frmAllClients
    Private Sub Client_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Client_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClientDBDataSet)

    End Sub

    Private Sub frmClientsAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientDBDataSet.Client_table' table. You can move, or remove it, as needed.
        Me.Client_tableTableAdapter.Fill(Me.ClientDBDataSet.Client_table)
        Dim foundIt As Boolean = False
        For Each row As DataGridViewRow In Client_tableDataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing Then
                    If cell.Value.ToString() = "General" Then
                        Client_tableDataGridView.Rows.Remove(row)
                        foundIt = True
                        Exit For
                    End If
                End If
            Next
            If foundIt Then
                Exit For
            End If
        Next
    End Sub

    Private Sub btnDets_Click(sender As Object, e As EventArgs) Handles btnDets.Click
        'Opens a details Form using selected entry

        'Figure out which box is selected and what entry that 
        '   coresponds to
        Dim cells As DataGridViewSelectedCellCollection = Client_tableDataGridView.SelectedCells

        Dim id As Integer = Client_tableDataGridView.Rows.Item(cells.Item(0).RowIndex).Cells.Item("Column1").Value

        Dim connection As New OleDb.OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ClientDB.accdb"
        Dim sqlCommand As String = "SELECT * FROM [Client_table] WHERE ID=" & id.ToString()
        Dim selectCommand As New OleDb.OleDbCommand(sqlCommand, connection)

        'Implement connection
        Try
            connection.Open()
            Dim reader As OleDb.OleDbDataReader = selectCommand.ExecuteReader
            reader.Read()

            Dim d As New Dictionary(Of String, String)

            d.Add("FirstName", reader("FirstName").ToString())
            d.Add("LastName", reader("LastName").ToString())
            d.Add("DoB", reader("DoB").ToString())
            d.Add("Address", reader("Address").ToString())
            d.Add("City", reader("City").ToString())
            d.Add("State", reader("State").ToString())
            d.Add("ZIP", reader("ZIP").ToString())
            d.Add("Circumstance", reader("Circumstance").ToString())

            Dim frmDets As New frmDetsClient(d)
            frmDets.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class