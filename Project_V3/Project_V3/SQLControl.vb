Imports System.Data
Imports System.Data.SqlClient
Public Class SQLControl
    'connection
    'Private SQLCon As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
    Private SQLCon As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    Private SQLCmd As SqlCommand

    'sql data
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet

    'parameter query
    Public Params As New List(Of SqlParameter)

    'stats
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        Try
            SQLCon.Open()

            'create new command
            SQLCmd = New SqlCommand(Query, SQLCon)


            'load parameters into sql
            Params.ForEach(Sub(x) SQLCmd.Parameters.Add(x))

            'clear params
            Params.Clear()

            'exec cmd and fill dataset
            SQLDS = New DataSet
            SQLDA = New SqlDataAdapter(SQLCmd)
            RecordCount = SQLDA.Fill(SQLDS)


            SQLCon.Close()
        Catch ex As Exception
            Exception = ex.Message
        End Try

        If SQLCon.State = ConnectionState.Open Then SQLCon.Close()
    End Sub


End Class
