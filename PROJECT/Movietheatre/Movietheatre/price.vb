Imports System.Data.OleDb
Public Class price
    Dim rdr As OleDbDataReader = Nothing

    Dim con As OleDbConnection = Nothing

    Dim cmd As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"

    Private Sub price_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Current_dateDateTimePicker.Text = Today
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updaterow As Integer = 0
        
        Try



            If Len(Trim(TextBox1.Text)) = 0 Then
                MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Focus()
                Exit Sub
            End If
            If Len(Trim(TextBox2.Text)) = 0 Then
                MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Focus()
                Exit Sub
            End If
            If Len(Trim(TextBox3.Text)) = 0 Then
                MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox3.Focus()
                Exit Sub
            End If
            If Len(Trim(TextBox4.Text)) = 0 Then
                MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox4.Focus()
                Exit Sub
            End If

            If Len(Trim(TextBox5.Text)) = 0 Then
                MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox5.Focus()
                Exit Sub
            End If
            If Len(Trim(TextBox6.Text)) = 0 Then
                MessageBox.Show(" Please enter price ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox6.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(ck)

            con.Open()
            Dim co1 As String = "select * from [price] where [current date]=#" & Current_dateDateTimePicker.Text & "#"
            Dim co2 As String = "update [price] set [balcony] = '" & TextBox1.Text & "',[first class]='" & TextBox2.Text & "',[second class]='" & TextBox3.Text & "',[first res]='" & TextBox5.Text & "',[second res]='" & TextBox6.Text & "',[balcony res]='" & TextBox4.Text & "'where [current date]=#" & Current_dateDateTimePicker.Text & "#"
            Dim co As String = "insert into [price]([Current date],[balcony],[first class],[second class],[first res],[second res],[balcony res]) values('" & Current_dateDateTimePicker.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox4.Text & "')"
            Dim cmd2 As New OleDbCommand(co1)
            Dim cmd3 As New OleDbCommand(co2)
            cmd = New OleDbCommand(co)

            cmd.Connection = con
            cmd2.Connection = con
            cmd3.Connection = con

            rdr = cmd2.ExecuteReader

            If rdr.Read Then

                updaterow = cmd3.ExecuteNonQuery()
                If updaterow > 0 Then

                    MessageBox.Show("Successfully Added", "distributor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    MessageBox.Show("Invalid Entry", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                updaterow = cmd.ExecuteNonQuery()
                If updaterow > 0 Then

                    MessageBox.Show("Successfully Added", "distributor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    MessageBox.Show("Invalid Entry", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        TextBox6.Text = "0"
        TextBox4.Focus()
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Button2.Enabled = False
            Button3.Enabled = False
            con = New OleDbConnection(ck)

            con.Open()

            Dim co As String = "select * from [price] where [current date]=#" & Current_dateDateTimePicker.Text & "#"
            cmd = New OleDbCommand(co)

            cmd.Connection = con


            rdr = cmd.ExecuteReader

            If rdr.Read Then
                TextBox1.Text = rdr.GetValue(1)
                TextBox2.Text = rdr.GetValue(2)
                TextBox3.Text = rdr.GetValue(3)
                TextBox4.Text = rdr.GetValue(6)
                TextBox5.Text = rdr.GetValue(4)
                TextBox6.Text = rdr.GetValue(5)
            Else

                MessageBox.Show("Wrong date", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class