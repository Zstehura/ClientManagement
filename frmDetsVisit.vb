Imports System.Data.OleDb

Public Class frmDetsVisit
    Private d As Dictionary(Of String, String)

    Public Sub New(d As Dictionary(Of String, String))
        Me.d = d
        InitializeComponent()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmDetsVisit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAssociate.Text = d("Associate")
        txtBusiness.Text = d("Business").ToString()
        txtClient.Text = d("ClientName").ToString()
        txtDate.Text = d("DateVisited").ToString()
        txtDescription.Text = d("Description").ToString()
        txtLocation.Text = d("Location").ToString()
    End Sub

End Class