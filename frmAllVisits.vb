Public Class frmAllVisits

    Private Sub Business_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Business_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClientDBDataSet)

    End Sub

    Private Sub frmAllVisits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientDBDataSet.Business_table' table. You can move, or remove it, as needed.
        Me.Business_tableTableAdapter.Fill(Me.ClientDBDataSet.Business_table)

    End Sub

    Private Sub btnDets_Click(sender As Object, e As EventArgs) Handles btnDets.Click
        'Opens a details Form using selected entry

        'Figure out which box is selected and what entry that 
        '   coresponds to
        Dim cells As DataGridViewSelectedCellCollection = Business_tableDataGridView.SelectedCells

        Dim id As Integer = Business_tableDataGridView.Rows.Item(cells.Item(0).RowIndex).Cells.Item("Column1").Value

        Dim connection As New OleDb.OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ClientDB.accdb"
        Dim sqlCommand As String = "SELECT * FROM [Business_table] WHERE ID=" & id.ToString()
        Dim selectCommand As New OleDb.OleDbCommand(sqlCommand, connection)

        'Implement connection
        Try
            connection.Open()
            Dim reader As OleDb.OleDbDataReader = selectCommand.ExecuteReader
            reader.Read()

            Dim d As New Dictionary(Of String, String) From {
                {"Business", reader("Business").ToString()},
                {"Location", reader("Location").ToString()},
                {"ClientName", reader("ClientName").ToString()},
                {"Associate", reader("Associate").ToString()},
                {"Description", reader("Description").ToString()},
                {"DateVisited", reader("DateVisited").ToString()}
            }

            Dim frmDets As New frmDetsVisit(d)
            frmDets.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

End Class