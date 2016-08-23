Imports System.Data.OleDb
Public Class resselect
    Dim rdr As OleDbDataReader = Nothing
    Public passdate As Date

    Public nsdate As Date = #12:00:00 PM#
    Public msdate As Date = #3:30:00 PM#
    Public fsdate As Date = #6:30:00 PM#
    Public ssdate As Date = #9:30:00 PM#
    Public nsdate1 As Date = #11:00:00 AM#
    Public msdate1 As Date = #2:30:00 PM#
    Public fsdate1 As Date = #5:30:00 PM#
    Public ssdate1 As Date = #8:30:00 PM#
    Dim con As OleDbConnection = Nothing
    Dim cmd1 As OleDbCommand = Nothing
    Dim cmd As OleDbCommand = Nothing

    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
    Dim sd As Integer = -1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Cursor = Cursors.WaitCursor
        If ComboBox1.Text = "" Then
            MessageBox.Show("SELECT SHOW", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else


            con = New OleDbConnection(ck)
            con.Open()
            Dim update As Integer = 0
            Dim co1 As String = "insert into [DCR]([currdate]) values('" & DateTimePicker1.Text & "')"
            Dim ct1 As String = "select * from [DCR] where [currdate]=#" & DateTimePicker1.Text & "#"
            Dim co4 As String = "insert into [mcr]([curr_date]) values('" & DateTimePicker1.Text & "')"
            Dim ct4 As String = "select * from [mcr] where [curr_date]=#" & DateTimePicker1.Text & "#"
            Dim ct2 As String = "select * from [price] where [Current date]=#" & DateTimePicker1.Text & "#"
            Dim ct3 As String = "select * from [show] where [Current date]=#" & DateTimePicker1.Text & "#"

            cmd1 = New OleDbCommand(ct1)
            cmd = New OleDbCommand(co1)
            Dim cmd3 As New OleDbCommand(ct3)
            Dim cmd2 As New OleDbCommand(ct2)
            Dim cmd4 As New OleDbCommand(ct4)
            Dim cmd5 As New OleDbCommand(co4)
            cmd4.Connection = con
            cmd.Connection = con
            cmd1.Connection = con
            cmd2.Connection = con
            cmd3.Connection = con
            cmd5.Connection = con
            Dim rdr2 As OleDbDataReader = Nothing
            Dim rdr4 As OleDbDataReader = Nothing
            rdr2 = cmd2.ExecuteReader()
            Dim rdr3 As OleDbDataReader = Nothing
            ' rdr4 = cmd4.ExecuteReader()
            rdr3 = cmd3.ExecuteReader()
            If rdr2.Read() And rdr3.Read() Then
                ticketres4.Label45.Text = rdr3.GetValue(4)
                ticketres3.Label45.Text = rdr3.GetValue(3)
                ticketres2.Label45.Text = rdr3.GetValue(2)
                ticketres.Label45.Text = rdr3.GetValue(1)
                rdr = cmd1.ExecuteReader()
                rdr4 = cmd4.ExecuteReader()
                If rdr.Read() And rdr4.Read Then
                Else
                    update = cmd.ExecuteNonQuery()
                    update = cmd5.ExecuteNonQuery
                End If
                con.Close()
                If ComboBox1.Text = "NOON SHOW" Then
                    Dim updaterow As Integer = 0
                    passdate = DateTimePicker1.Text
                    If passdate < Today Then
                        MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf passdate = Today Then
                        If nsdate1 < TimeOfDay Then
                            MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                        If TimeOfDay > nsdate Then
                            MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                        Try

                            con = New OleDbConnection(ck)
                            con.Open()

                            Dim co As String = "insert into [reservetab]([resDate]) values('" & DateTimePicker1.Text & "')"
                            cmd = New OleDbCommand(co)

                            cmd.Connection = con
                            Dim ct As String = "select * from [reservetab] where [resDate]=#" & DateTimePicker1.Text & "#"
                            cmd1 = New OleDbCommand(ct)
                            cmd1.Connection = con
                            rdr = cmd1.ExecuteReader()
                            If rdr.Read() Then
                                MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ticketres.Show()
                                Me.Close()

                            Else
                                updaterow = cmd.ExecuteNonQuery()
                                If updaterow > 0 Then
                                    MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ticketres.Show()
                                    Me.Close()
                                End If
                            End If

                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else

                        Try

                            con = New OleDbConnection(ck)
                            con.Open()

                            Dim co As String = "insert into [reservetab]([resDate]) values('" & DateTimePicker1.Text & "')"
                            cmd = New OleDbCommand(co)

                            cmd.Connection = con
                            Dim ct As String = "select * from [reservetab] where [resDate]=#" & DateTimePicker1.Text & "#"
                            cmd1 = New OleDbCommand(ct)
                            cmd1.Connection = con
                            rdr = cmd1.ExecuteReader()
                            If rdr.Read() Then
                                MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ticketres.Show()
                                Me.Close()

                            Else
                                updaterow = cmd.ExecuteNonQuery()
                                If updaterow > 0 Then
                                    MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ticketres.Show()
                                    Me.Close()
                                End If
                            End If

                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If

                If ComboBox1.Text = "MATINEE" Then
                    Dim updaterow As Integer = 0
                    passdate = DateTimePicker1.Text
                    If passdate < Today Then
                        MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf passdate = Today Then
                        If msdate1 < TimeOfDay Then
                            MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                        If TimeOfDay > msdate Then
                            MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                        Try


                            con = New OleDbConnection(ck)
                            con.Open()

                            Dim co As String = "insert into [reservetab2]([resDate]) values('" & DateTimePicker1.Text & "')"
                            cmd = New OleDbCommand(co)

                            cmd.Connection = con
                            Dim ct As String = "select * from [reservetab2] where [resDate]=#" & DateTimePicker1.Text & "#"
                            cmd1 = New OleDbCommand(ct)
                            cmd1.Connection = con
                            rdr = cmd1.ExecuteReader()
                            If rdr.Read() Then
                                MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ticketres2.Show()
                                Me.Close()

                            Else
                                updaterow = cmd.ExecuteNonQuery()
                                If updaterow > 0 Then
                                    MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ticketres2.Show()
                                    Me.Close()
                                End If
                            End If

                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        Try


                            con = New OleDbConnection(ck)
                            con.Open()

                            Dim co As String = "insert into [reservetab2]([resDate]) values('" & DateTimePicker1.Text & "')"
                            cmd = New OleDbCommand(co)

                            cmd.Connection = con
                            Dim ct As String = "select * from [reservetab2] where [resDate]=#" & DateTimePicker1.Text & "#"
                            cmd1 = New OleDbCommand(ct)
                            cmd1.Connection = con
                            rdr = cmd1.ExecuteReader()
                            If rdr.Read() Then
                                MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ticketres2.Show()
                                Me.Close()

                            Else
                                updaterow = cmd.ExecuteNonQuery()
                                If updaterow > 0 Then
                                    MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ticketres2.Show()
                                    Me.Close()
                                End If
                            End If

                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If



                If ComboBox1.Text = "FIRST SHOW" Then
                    Dim updaterow As Integer = 0
                    passdate = DateTimePicker1.Text
                    If passdate < Today Then
                        MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf passdate = Today Then
                        If fsdate1 < TimeOfDay Then
                            MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                        If TimeOfDay > fsdate Then
                            MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                        Try


                            con = New OleDbConnection(ck)
                            con.Open()

                            Dim co As String = "insert into [reservetab3]([resDate]) values('" & DateTimePicker1.Text & "')"
                            cmd = New OleDbCommand(co)

                            cmd.Connection = con
                            Dim ct As String = "select * from [reservetab3] where [resDate]=#" & DateTimePicker1.Text & "#"
                            cmd1 = New OleDbCommand(ct)
                            cmd1.Connection = con
                            rdr = cmd1.ExecuteReader()
                            If rdr.Read() Then
                                MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ticketres3.Show()
                                Me.Close()

                            Else
                                updaterow = cmd.ExecuteNonQuery()
                                If updaterow > 0 Then
                                    MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ticketres3.Show()
                                    Me.Close()
                                End If
                            End If

                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        Try


                            con = New OleDbConnection(ck)
                            con.Open()

                            Dim co As String = "insert into [reservetab3]([resDate]) values('" & DateTimePicker1.Text & "')"
                            cmd = New OleDbCommand(co)

                            cmd.Connection = con
                            Dim ct As String = "select * from [reservetab3] where [resDate]=#" & DateTimePicker1.Text & "#"
                            cmd1 = New OleDbCommand(ct)
                            cmd1.Connection = con
                            rdr = cmd1.ExecuteReader()
                            If rdr.Read() Then
                                MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ticketres3.Show()
                                Me.Close()

                            Else
                                updaterow = cmd.ExecuteNonQuery()
                                If updaterow > 0 Then
                                    MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ticketres3.Show()
                                    Me.Close()
                                End If
                            End If

                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If

                If ComboBox1.Text = "SECOND SHOW" Then
                    Dim updaterow As Integer = 0
                    passdate = DateTimePicker1.Text
                    If passdate < Today Then
                        MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf passdate = Today Then
                        If ssdate1 < TimeOfDay Then
                            MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                        If TimeOfDay > ssdate Then
                            MessageBox.Show("Invalid Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If

                        Try
                            con = New OleDbConnection(ck)
                            con.Open()

                            Dim co As String = "insert into [reservetab4]([resDate]) values('" & DateTimePicker1.Text & "')"
                            cmd = New OleDbCommand(co)

                            cmd.Connection = con
                            Dim ct As String = "select * from [reservetab4] where [resDate]=#" & DateTimePicker1.Text & "#"
                            cmd1 = New OleDbCommand(ct)
                            cmd1.Connection = con
                            rdr = cmd1.ExecuteReader()
                            If rdr.Read() Then
                                MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ticketres4.Show()
                                Me.Close()

                            Else
                                updaterow = cmd.ExecuteNonQuery()
                                If updaterow > 0 Then
                                    MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ticketres4.Show()

                                    Me.Close()
                                End If
                            End If

                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                    Else

                        Try
                            con = New OleDbConnection(ck)
                            con.Open()

                            Dim co As String = "insert into [reservetab4]([resDate]) values('" & DateTimePicker1.Text & "')"
                            cmd = New OleDbCommand(co)

                            cmd.Connection = con
                            Dim ct As String = "select * from [reservetab4] where [resDate]=#" & DateTimePicker1.Text & "#"
                            cmd1 = New OleDbCommand(ct)
                            cmd1.Connection = con
                            rdr = cmd1.ExecuteReader()
                            If rdr.Read() Then
                                MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ticketres4.Show()

                                Me.Close()

                            Else
                                updaterow = cmd.ExecuteNonQuery()
                                If updaterow > 0 Then
                                    MessageBox.Show("Welcome", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ticketres4.Show()

                                    Me.Close()
                                End If
                            End If

                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If

            Else
                MessageBox.Show("Price/Show not set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
        Form3.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub resselect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Enabled = False
        ComboBox1.Text = ""
        DateTimePicker1.Text = Today
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form3.Show()
        Form3.Enabled = True
        Me.Close()
    End Sub

End Class