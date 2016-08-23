Imports System.Data.OleDb
Public Class Moviedetail
    Dim rdr As OleDb.OleDbDataReader = Nothing
   Dim connString As String
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Private Sub Moviedetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
        myConnection.ConnectionString = connString
        Connection.ConnectionString = connString

        Dim cmd2 As OleDbCommand = New OleDbCommand("select * from [moviereg]", myConnection)


        myConnection.Open()
        Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader

        Dim dt As New DataTable
        Dim query As String = "select * from [moviereg]"


        Using command As New OleDbCommand(query, Connection)
            Using adapter As New OleDbDataAdapter(command)
                Connection.Open()
                adapter.Fill(dt)
                Connection.Close()
            End Using
        End Using


        If dr2.Read Then

            MetroGrid1.DataSource = dt

        Else
            MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
        End If
        myConnection.Close()


    End Sub
End Class