Imports System.Data.OleDb

Public Class viewmovie
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Private Sub viewmovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
        myconnection.ConnectionString = connString
        connection.ConnectionString = connString

        Dim cmd2 As OleDbCommand = New OleDbCommand("select * from [show]", myconnection)


        myconnection.Open()
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

        Dim dt As New DataTable
        Dim query As String = "select * from [show]"


        Using command As New OleDbCommand(query, connection)
            Using adapter As New OleDb.OleDbDataAdapter(command)
                connection.Open()
                adapter.Fill(dt)
                connection.Close()
            End Using
        End Using


        If dr2.Read Then

            MetroGrid1.DataSource = dt

        Else
            MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
        End If
        myconnection.Close()
    End Sub
End Class