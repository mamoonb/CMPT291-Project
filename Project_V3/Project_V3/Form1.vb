Imports System.Data.SqlClient
Public Class Form1
    Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            'This will print a the label "Connected in a greeen color
            lbl_Conn.Text = "Connected"
            lbl_Conn.ForeColor = Color.Green
        End If
    End Sub

    Private Sub lbl_Conn_Click(sender As Object, e As EventArgs) Handles lbl_Conn.Click

    End Sub
End Class
