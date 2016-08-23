Imports System.Data.OleDb

Public Class showassign

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim rdr As OleDbDataReader = Nothing

    Dim con As OleDbConnection = Nothing

    Dim cmd As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"


    Private Sub show_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myConnection.ConnectionString = ck
        Connection.ConnectionString = ck

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT username FROM [admin]", myConnection)


        myConnection.Open()
        Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader

        Dim dt As New DataTable
        Dim query As String = "SELECT [Movie name] FROM [moviereg]"


        Using command As New OleDbCommand(query, Connection)
            Using adapter As New OleDbDataAdapter(command)
                Connection.Open()
                adapter.Fill(dt)
                Connection.Close()
            End Using
        End Using




        If dr2.Read Then

            ComboBox1.DataSource = dt
            ComboBox1.ValueMember = "movie name"
            ComboBox1.DisplayMember = "movie name"
           

        Else
            MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
        End If
       
        myConnection.Close()



        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT username FROM [admin]", myConnection)


        myConnection.Open()
        Dim dr3 As OleDb.OleDbDataReader = cmd3.ExecuteReader

        Dim dt1 As New DataTable
        Dim query1 As String = "SELECT [Movie name] FROM [moviereg]"


        Using command As New OleDbCommand(query1, Connection)
            Using adapter As New OleDbDataAdapter(command)
                Connection.Open()
                adapter.Fill(dt1)
                Connection.Close()
            End Using
        End Using




        If dr3.Read Then


            ComboBox2.DataSource = dt1
            ComboBox2.ValueMember = "movie name"
            ComboBox2.DisplayMember = "movie name"
           

        Else
            MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
        End If

        myConnection.Close()


        Dim cmd4 As OleDbCommand = New OleDbCommand("SELECT username FROM [admin]", myConnection)


        myConnection.Open()
        Dim dr4 As OleDb.OleDbDataReader = cmd4.ExecuteReader

        Dim dt4 As New DataTable
        Dim query4 As String = "SELECT [Movie name] FROM [moviereg]"


        Using command As New OleDbCommand(query4, Connection)
            Using adapter As New OleDbDataAdapter(command)
                Connection.Open()
                adapter.Fill(dt4)
                Connection.Close()
            End Using
        End Using




        If dr4.Read Then

          
          
            ComboBox3.DataSource = dt4
            ComboBox3.ValueMember = "movie name"
            ComboBox3.DisplayMember = "movie name"
           

        Else
            MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
        End If

        myConnection.Close()



        Dim cmd5 As OleDbCommand = New OleDbCommand("SELECT username FROM [admin]", myConnection)


        myConnection.Open()
        Dim dr5 As OleDb.OleDbDataReader = cmd5.ExecuteReader

        Dim dt5 As New DataTable
        Dim query5 As String = "SELECT [Movie name] FROM [moviereg]"


        Using command As New OleDbCommand(query5, Connection)
            Using adapter As New OleDbDataAdapter(command)
                Connection.Open()
                adapter.Fill(dt5)
                Connection.Close()
            End Using
        End Using




        If dr5.Read Then


            ComboBox4.DataSource = dt5
            ComboBox4.ValueMember = "movie name"
            ComboBox4.DisplayMember = "movie name"

        Else
            MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
        End If

        myConnection.Close()



















    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updaterow As Integer = 0
        If Current_dateDateTimePicker.Text < Today Then

            MessageBox.Show("Access is denied", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else

            Try



                If Len(Trim(ComboBox1.Text)) = 0 Then
                    MessageBox.Show("Please select show", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ComboBox1.Focus()
                    Exit Sub
                End If
                If Len(Trim(ComboBox2.Text)) = 0 Then
                    MessageBox.Show("Please select show", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ComboBox2.Focus()
                    Exit Sub
                End If
                If Len(Trim(ComboBox3.Text)) = 0 Then
                    MessageBox.Show("Please select show", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ComboBox3.Focus()
                    Exit Sub
                End If
                If Len(Trim(ComboBox4.Text)) = 0 Then
                    MessageBox.Show("Please select show", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ComboBox4.Focus()
                    Exit Sub
                End If

                con = New OleDbConnection(ck)

                con.Open()

                Dim co As String = "insert into [show]([Current date],[Noon show],[Matinee],[First show],[Second show]) values('" & Current_dateDateTimePicker.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "', '" & ComboBox3.Text & "','" & ComboBox4.Text & "')"

                cmd = New OleDbCommand(co)

                cmd.Connection = con
                updaterow = cmd.ExecuteNonQuery()
                If updaterow > 0 Then

                    MessageBox.Show("Successfully Added", "distributor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    MessageBox.Show("invalid entry", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Invalid entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub


End Class