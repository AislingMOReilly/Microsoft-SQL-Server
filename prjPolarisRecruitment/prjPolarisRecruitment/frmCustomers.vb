Imports System.Data.SqlClient

Public Class frmCustomers

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PolarisSqlConn.Open()
            MsgBox("Connection works")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ViewRecords()
    End Sub

    Private Sub ViewRecords()
        Dim ViewQuery As String = "SELECT * FROM Customers"
        PolarisSqlAdapter.SelectCommand = New SqlCommand(ViewQuery, PolarisSqlConn)
        PolarisSqlAdapter.Fill(dsPolarisSql, "CustomerDetails")

        grdCustomers.DataSource = dsPolarisSql.Tables("CustomerDetails")
    End Sub


    Private Sub btnCreate_Click(sender As Object, e As EventArgs)
        ViewRecords()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs)
        ViewRecords()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        ViewRecords()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        ViewRecords()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        PolarisSqlConn.Close()
        frmStaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        PolarisSqlConn.Close()
        Me.Close()
    End Sub
End Class
