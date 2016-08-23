Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Net.WebRequestMethods
Public Class Form1
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox1.Clear()
        TextBox2.Text = ""
        TextBox2.Focus()
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        home.Show()
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
        myConnection.ConnectionString = connString
      
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM admin WHERE username = '" & TextBox2.Text & "' AND password = '" & TextBox1.Text & "'", myConnection)
        Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT * FROM [user] WHERE username = '" & TextBox2.Text & "' AND password = '" & TextBox1.Text & "'", myConnection)
      
        myConnection.Open()

        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        Dim dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader

        Dim userFound As Boolean = False
        Dim userFound1 As Boolean = False
       
      

        If home.adminselect = 1 Then
           
            While dr.Read

                userFound = True

            End While


            If userFound = True Then
                My.Computer.Audio.Play(My.Resources.sda, AudioPlayMode.Background)
                Form2.Show()
                Me.Close()
                home.Close()
            Else

                MsgBox("Sorry, username or password is not correct", MsgBoxStyle.OkOnly, "Invalid Login")
                TextBox1.Focus()
                TextBox1.Clear()
                TextBox2.Text = ""
            End If


        Else

            While dr1.Read

                userFound1 = True

            End While


            If userFound1 = True Then
                My.Computer.Audio.Play(My.Resources.sda, AudioPlayMode.Background)

                Form3.Show()
                TextBox1.Focus()
                TextBox1.Clear()
                TextBox2.Text = ""
                Me.Close()

            Else

                MsgBox("Sorry, username or password is not correct", MsgBoxStyle.OkOnly, "Invalid Login")
                TextBox1.Focus()
                TextBox1.Clear()
                TextBox2.Text = ""
            End If


        End If




        myConnection.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TextBox1.Clear()
        TextBox1.Focus()
        TextBox2.Text = ""
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
        myConnection.ConnectionString = connString
        Connection.ConnectionString = connString
        If home.adminselect = 1 Then
            LinkLabel1.Visible = True
            Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT username FROM [admin]", myConnection)
            myConnection.Open()
            Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader
            Dim dt As New DataTable
            Dim query As String = "SELECT username FROM [admin]"
            Using command As New OleDbCommand(query, Connection)
                Using adapter As New OleDbDataAdapter(command)
                    Connection.Open()
                    adapter.Fill(dt)
                    Connection.Close()
                End Using
            End Using
            If dr2.Read Then
                TextBox2.DataSource = dt
                TextBox2.ValueMember = "username"
                TextBox2.DisplayMember = "username"
            Else
                MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
            End If
            myConnection.Close()

        Else
            LinkLabel1.Visible = False
            Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT username FROM [user]", myConnection)


            myConnection.Open()
            Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader

            Dim dt As New DataTable
            Dim query As String = "SELECT username FROM [user]"


            Using command As New OleDbCommand(query, Connection)
                Using adapter As New OleDbDataAdapter(command)
                    Connection.Open()
                    adapter.Fill(dt)
                    Connection.Close()
                End Using
            End Using


            If dr2.Read Then

                TextBox2.DataSource = dt
                TextBox2.ValueMember = "username"
                TextBox2.DisplayMember = "username"

            Else
                MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
            End If
            myConnection.Close()
        End If

    End Sub

    
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"

        Dim str As String = "Your password is  :   "
        Dim email As String = ""
        Dim rdrr11 As OleDbDataReader = Nothing
        Dim comd11 As OleDbCommand = Nothing
        Connection = New OleDbConnection(connString)
        Connection.Open()
        Dim str11 As String = "select * from [admin] where [username] = '" & TextBox2.Text & "'"
        comd11 = New OleDbCommand(str11)
        comd11.Connection = Connection
        Dim reader11 As OleDbDataReader = Nothing
        reader11 = comd11.ExecuteReader()
        If reader11.Read() Then
            str += reader11.GetValue(2)
            email = reader11.GetValue(3)
            MessageBox.Show("Done  !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        Connection.Close()

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = True
            Smtp_Server.Credentials = New Net.NetworkCredential("squbemovies@gmail.com", "7034311551")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("sebin.sbtn@gmail.com")
            e_mail.To.Add(email)
            e_mail.Subject = "PASSWORD RECOVERY FROM SQUBEMOVIES.. "
            e_mail.IsBodyHtml = False
            e_mail.Body = str
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try



    End Sub
End Class
