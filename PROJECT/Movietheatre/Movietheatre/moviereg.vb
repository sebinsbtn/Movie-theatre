Imports System.Data.OleDb

Public Class moviereg

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim rdr As OleDbDataReader = Nothing

    Dim con As OleDbConnection = Nothing

    Dim cmd As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"


    Private Sub moviereg_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        myConnection.ConnectionString = ck
        Connection.ConnectionString = ck



        Dim dt As New DataTable
        Dim query As String = "SELECT [distributor] FROM [distributor]"


        Using command As New OleDbCommand(query, Connection)
            Using adapter As New OleDbDataAdapter(command)
                Connection.Open()
                adapter.Fill(dt)
                Connection.Close()
            End Using
        End Using



        ComboBox3.DataSource = dt
        ComboBox3.ValueMember = "distributor"
        ComboBox3.DisplayMember = "distributor"



        myConnection.Close()


        Film_idTextBox.Text = ""
        Movie_nameTextBox.Text = ""
        ' ComboBox3.Text = ""
        CertificateTextBox.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        Film_idTextBox.Focus()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updaterow As Integer = 0

        Try



            If Len(Trim(Film_idTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Film id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Film_idTextBox.Focus()
                Exit Sub
            End If
            If Len(Trim(Movie_nameTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Movie Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Movie_nameTextBox.Focus()
                Exit Sub
            End If
            If Len(Trim(ComboBox3.Text)) = 0 Then
                MessageBox.Show("Please Select a Distributor", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ComboBox3.Focus()
                Exit Sub
            End If
            If Len(Trim(CertificateTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Certificate Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CertificateTextBox.Focus()
                Exit Sub
            End If
            
            If Len(Trim(ComboBox1.Text)) = 0 Then
                MessageBox.Show(" Please Select Movie Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ComboBox1.Focus()
                Exit Sub
            End If
            If Len(Trim(ComboBox2.Text)) = 0 Then
                MessageBox.Show(" Please Select Movie Language ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ComboBox2.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(ck)

            con.Open()

            Dim co As String = "insert into [moviereg]([film_id],[movie name],[Distributor],[Release date],[Type],[Certificate],[language]) values('" & Film_idTextBox.Text & "','" & Movie_nameTextBox.Text & "','" & ComboBox3.Text & "', '" & Release_dateDateTimePicker.Text & "','" & ComboBox1.Text & "','" & CertificateTextBox.Text & "','" & ComboBox2.Text & "')"
            cmd = New OleDbCommand(co)

            cmd.Connection = con


            updaterow = cmd.ExecuteNonQuery()

            If updaterow > 0 Then

                MessageBox.Show("Successfully Added", "distributor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                MessageBox.Show("Something went wrong!", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Moviedetail.Show()

    End Sub
End Class