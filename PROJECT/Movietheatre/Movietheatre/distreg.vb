Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class distreg
    Dim rdr As OleDb.OleDbDataReader = Nothing
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim cmd1 As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean


        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then

            EmailAddressCheck = True

        Else

            EmailAddressCheck = False

        End If



    End Function


    Sub addnew()
        id.Enabled = True
        id.Text = ""
        Distributor.Text = ""
        Place.Text = ""
        Contact.Text = ""
        Email.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim updaterow As Integer = 0
        Try


            If Len(Trim(id.Text)) = 0 Then
                MessageBox.Show("Please enter distributor id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                id.Focus()
                Exit Sub
            End If
            If Len(Trim(Distributor.Text)) = 0 Then
                MessageBox.Show("Please enter Distributor name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Distributor.Focus()
                Exit Sub
            End If
            If Len(Trim(Place.Text)) = 0 Then
                MessageBox.Show("Please enter place", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Place.Focus()
                Exit Sub
            End If
            If Len(Trim(Contact.Text)) = 0 Then
                MessageBox.Show("Please Enter contact number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Contact.Focus()
                Exit Sub
            End If
            If Contact.Text.Length < 10 Or Contact.Text.Length > 10 Then
                MessageBox.Show(" Pleae enter a valid number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Contact.Text = ""
                Contact.Focus()
                Exit Sub
            End If
            Dim objRegEx As New System.Text.RegularExpressions.Regex("^\+?\s?\d{3}\s?\d{3}\s?\d{4}$")

            If Not objRegEx.IsMatch(Contact.Text) Then
                MessageBox.Show(" Pleae enter a valid  number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Contact.Text = ""
                Contact.Focus()
                Exit Sub
            End If

            If Len(Trim(Email.Text)) = 0 Then
                MessageBox.Show(" Pleae enter Email id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Email.Focus()
                Exit Sub
            End If
            If EmailAddressCheck(Email.Text) = False Then
                MessageBox.Show(" Pleae enter valid Email id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Email.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(ck)

            con.Open()

            Dim co As String = "insert into [distributor]([Dist_id],[distributor],[place],[contact no],[email id]) values('" & id.Text & "','" & Distributor.Text & "','" & Place.Text & "', '" & Contact.Text & "','" & Email.Text & "')"
            Dim co1 As String = "select * from [distributor] where [Dist_id] = " & id.Text & ""

            cmd = New OleDbCommand(co)
            cmd1 = New OleDbCommand(co1)
            cmd1.Connection = con
            cmd.Connection = con
            ' rdr = cmd1.ExecuteReader
            ' If rdr.Read Then
            'MessageBox.Show("Cant update, please check the values", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '  addnew()
            id.Focus()
            ' Else
            If cmd.ExecuteNonQuery() Then

                MessageBox.Show("Successfully Added", "distributor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
                myConnection.ConnectionString = connString
                Connection.ConnectionString = connString

                Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM [distributor]", myConnection)


                myConnection.Open()
                Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader

                Dim dt As New DataTable
                Dim query As String = "SELECT * FROM [distributor]"


                Using command As New OleDbCommand(query, Connection)
                    Using adapter As New OleDbDataAdapter(command)
                        Connection.Open()
                        adapter.Fill(dt)
                        Connection.Close()
                    End Using
                End Using


                If dr2.Read Then

                    Datagridview1.DataSource = dt

                Else
                    MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
                End If
                myConnection.Close()

                addnew()
                id.Focus()
            Else

                MessageBox.Show("Cant update, please check the values", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                addnew()
                id.Focus()
            End If
            con.Close()


            ' End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addnew()
            id.Focus()
        End Try
    End Sub

    Private Sub distreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
        myConnection.ConnectionString = connString
        Connection.ConnectionString = connString

        Dim cmd2 As OleDbCommand = New OleDbCommand("select * from [distributor]", myConnection)


        myConnection.Open()
        Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader

        Dim dt As New DataTable
        Dim query As String = "select * from [distributor]"


        Using command As New OleDbCommand(query, Connection)
            Using adapter As New OleDbDataAdapter(command)
                Connection.Open()
                adapter.Fill(dt)
                Connection.Close()
            End Using
        End Using


        If dr2.Read Then

            Datagridview1.DataSource = dt

        Else
            MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
        End If
        myConnection.Close()
    End Sub


    Private Sub Datagridview1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview1.CellContentDoubleClick
        id.Enabled = False
        Dim i As Integer

        i = Datagridview1.CurrentRow.Index

        Me.id.Text = Datagridview1.Item(0, i).Value
        Me.Distributor.Text = Datagridview1.Item(1, i).Value
        Me.Place.Text = Datagridview1.Item(2, i).Value
        Me.Contact.Text = Datagridview1.Item(3, i).Value
        Me.Email.Text = Datagridview1.Item(4, i).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim updaterow As Integer = 0
        Try


            If Len(Trim(id.Text)) = 0 Then
                MessageBox.Show("Please enter distributor id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                id.Focus()
                Exit Sub
            End If
            If Len(Trim(Distributor.Text)) = 0 Then
                MessageBox.Show("Please enter Distributor name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Distributor.Focus()
                Exit Sub
            End If
            If Len(Trim(Place.Text)) = 0 Then
                MessageBox.Show("Please enter place", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Place.Focus()
                Exit Sub
            End If
            If Len(Trim(Contact.Text)) = 0 Then
                MessageBox.Show("Please Enter contact number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Contact.Focus()
                Exit Sub
            End If
            If Contact.Text.Length < 10 Or Contact.Text.Length > 10 Then
                MessageBox.Show(" Pleae enter a valid number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Contact.Text = ""
                Contact.Focus()
                Exit Sub
            End If
            Dim objRegEx As New System.Text.RegularExpressions.Regex("^\+?\s?\d{3}\s?\d{3}\s?\d{4}$")

            If Not objRegEx.IsMatch(Contact.Text) Then
                MessageBox.Show(" Pleae enter a Valid number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Contact.Text = ""
                Contact.Focus()
                Exit Sub
            End If

            If Len(Trim(Email.Text)) = 0 Then
                MessageBox.Show(" Pleae enter Email id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Email.Focus()
                Exit Sub
            End If
            If EmailAddressCheck(Email.Text) = False Then
                MessageBox.Show(" Pleae enter valid Email id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Email.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(ck)

            con.Open()

            Dim co As String = "update [distributor] set [distributor]='" & Distributor.Text & "',[place]='" & Place.Text & "',[contact no]='" & Contact.Text & "',[email id]='" & Email.Text & "' where [Dist_id]='" & id.Text & "'"
           
            cmd = New OleDbCommand(co)
           cmd.Connection = con
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Updated successfully ", "distributor", MessageBoxButtons.OK, MessageBoxIcon.Information)

                connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
                myConnection.ConnectionString = connString
                Connection.ConnectionString = connString

                Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM [distributor]", myConnection)


                myConnection.Open()
                Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader

                Dim dt As New DataTable
                Dim query As String = "SELECT * FROM [distributor]"


                Using command As New OleDbCommand(query, Connection)
                    Using adapter As New OleDbDataAdapter(command)
                        Connection.Open()
                        adapter.Fill(dt)
                        Connection.Close()
                    End Using
                End Using


                If dr2.Read Then

                    Datagridview1.DataSource = dt

                Else
                    MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
                End If
                myConnection.Close()
                addnew()
                id.Focus()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addnew()
            id.Focus()
        End Try
        id.Enabled = True

    End Sub
End Class