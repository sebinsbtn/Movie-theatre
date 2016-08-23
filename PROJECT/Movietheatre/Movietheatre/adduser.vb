Imports System.Data.OleDb


Public Class adduser
    Dim provider As String
    Dim dataFile As String
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Conn As OleDb.OleDbConnection = New OleDb.OleDbConnection

    Sub addnew()
        TextBox1.Enabled = True
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
        TextBox4.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

       
        Dim updaterow As Integer = 0

        Dim newpa As Integer = -1
            Conn = New OleDbConnection(connString)
            Conn.Open()
      
            Dim cmd As OleDbCommand = New OleDbCommand("insert into [user](userid,username,[password],[email address]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", Conn)

        updaterow = cmd.ExecuteNonQuery
        If updaterow > 0 Then
                MessageBox.Show("Successful!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)

                myConnection.ConnectionString = connString
                Connection.ConnectionString = connString

                Dim cmd2 As OleDbCommand = New OleDbCommand("select * from [user]", myConnection)

                myConnection.Open()
                Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

                Dim dt As New DataTable
                Dim query As String = "select * from [user]"


                Using command As New OleDbCommand(query, Connection)
                    Using adapter As New OleDb.OleDbDataAdapter(command)
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

        Else
                MessageBox.Show("not Successful!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "User", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        addnew()
    End Sub

    Private Sub adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnection.ConnectionString = connString
        Connection.ConnectionString = connString

        Dim cmd2 As OleDbCommand = New OleDbCommand("select * from [user]", myConnection)

        myConnection.Open()
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

        Dim dt As New DataTable
        Dim query As String = "select * from [user]"


        Using command As New OleDbCommand(query, Connection)
            Using adapter As New OleDb.OleDbDataAdapter(command)
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

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        TextBox1.Enabled = False
        Dim i As Integer

        i = MetroGrid1.CurrentRow.Index

        Me.TextBox1.Text = MetroGrid1.Item(0, i).Value
        Me.TextBox2.Text = MetroGrid1.Item(1, i).Value
        Me.TextBox3.Text = MetroGrid1.Item(2, i).Value
        Me.TextBox4.Text = MetroGrid1.Item(3, i).Value

    End Sub

   
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If MetroGrid1.RowCount <= 2 Then
            MessageBox.Show("Atleast one user must be present  !", "Sorry ,cant delete ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try


                Dim updaterow As Integer = 0

                Dim newpa As Integer = -1
                Conn = New OleDbConnection(connString)
                Conn.Open()
                Dim num As Integer = TextBox1.Text
                Dim cmd As OleDbCommand = New OleDbCommand("delete * from [user] where userid = '" & TextBox1.Text & "'", Conn)

                updaterow = cmd.ExecuteNonQuery
                If updaterow > 0 Then
                    MessageBox.Show("Deleted   ", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    myConnection.ConnectionString = connString
                    Connection.ConnectionString = connString

                    Dim cmd2 As OleDbCommand = New OleDbCommand("select * from [user]", myConnection)

                    myConnection.Open()
                    Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

                    Dim dt As New DataTable
                    Dim query As String = "select * from [user]"


                    Using command As New OleDbCommand(query, Connection)
                        Using adapter As New OleDb.OleDbDataAdapter(command)
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

                Else
                    MessageBox.Show("Not Successful!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        addnew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            Dim updaterow As Integer = 0

            Dim newpa As Integer = -1
            Conn = New OleDbConnection(connString)
            Conn.Open()

            Dim cmd As OleDbCommand = New OleDbCommand("update [user] set username='" & TextBox2.Text & "',[password]='" & TextBox3.Text & "',[email address]='" & TextBox4.Text & "' where userid='" & TextBox1.Text & "'", Conn)

            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                MessageBox.Show("Successful!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)

                myConnection.ConnectionString = connString
                Connection.ConnectionString = connString

                Dim cmd2 As OleDbCommand = New OleDbCommand("select * from [user]", myConnection)

                myConnection.Open()
                Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

                Dim dt As New DataTable
                Dim query As String = "select * from [user]"


                Using command As New OleDbCommand(query, Connection)
                    Using adapter As New OleDb.OleDbDataAdapter(command)
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

            Else
                MessageBox.Show("not Successful!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "User", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        addnew()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        addnew()
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick

    End Sub
End Class