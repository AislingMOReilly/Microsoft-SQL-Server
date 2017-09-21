Imports System.Data.SqlClient

Public Class frmCustomerJobs
    Private Sub frmCustomerJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PolarisSqlConn.Open()
    End Sub

    Private Sub ViewRecords()
        Dim ViewQuery As String = "SELECT * FROM [Customer Jobs]"
        PolarisSqlAdapter.SelectCommand = New SqlCommand(ViewQuery, PolarisSqlConn)
        PolarisSqlAdapter.Fill(dsPolarisSql, "CustomerJobDetails")

        grdCustJobs.DataSource = dsPolarisSql.Tables("CustomerJobDetails")
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ViewRecords()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ViewRecords()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ViewRecords()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ViewRecords()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        PolarisSqlConn.Close()
        frmCourses.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        PolarisSqlConn.Close()
        Me.Close()
    End Sub
End Class