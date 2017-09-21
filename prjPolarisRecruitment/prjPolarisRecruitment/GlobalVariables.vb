Imports System.Data.SqlClient

Module GlobalVariables
    Public PolarisSqlConn As New SqlConnection("Data Source = svr-studentsql.ccocstudents.local\Projects; Initial Catalog = AislingOReilly_PolarisRecruitment; Trusted_Connection=true;")
    Public PolarisSqlAdapter As SqlDataAdapter = New SqlDataAdapter
    Public dsPolarisSql As DataSet = New DataSet()
End Module
