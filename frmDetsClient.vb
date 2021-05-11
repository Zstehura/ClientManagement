Public Class frmDetsClient
    Private d As Dictionary(Of String, String)

    Public Sub New(d As Dictionary(Of String, String))
        Me.d = d
        InitializeComponent()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmClientDets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAddress.Text = d("Address")
        txtCircum.Text = d("Circumstance")
        txtCity.Text = d("City")
        txtDoB.Text = d("DoB")
        txtState.Text = d("State")
        txtZip.Text = d("ZIP")
        txtName.Text = d("FirstName") & " " & d("LastName")
    End Sub
End Class