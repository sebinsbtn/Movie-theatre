Imports System.Data.OleDb

Public Class adminpasschange
    Dim rdr As OleDbDataReader = Nothing

    Dim con As OleDbConnection = Nothing

    Dim cmd As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim updaterow As Integer = 0
            If Len(Trim(UserName.Text)) = 0 Then
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserName.Focus()
                Exit Sub
            End If
            If Len(Trim(oldpassword.Text)) = 0 Then
                MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                oldpassword.Focus()
                Exit Sub
            End If
            If Len(Trim(newpassword.Text)) = 0 Then
                MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                newpassword.Focus()
                Exit Sub
            End If
            If Len(Trim(confirmpassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                confirmpassword.Focus()
                Exit Sub
            End If
            If newpassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                newpassword.Text = ""
                confirmpassword.Text = ""
                newpassword.Focus()
                Exit Sub
            ElseIf newpassword.Text <> confirmpassword.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                newpassword.Text = ""
                oldpassword.Text = ""
                confirmpassword.Text = ""
                oldpassword.Focus()
                Exit Sub
            ElseIf oldpassword.Text = newpassword.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                newpassword.Text = ""
                confirmpassword.Text = ""
                newpassword.Focus()
                Exit Sub
            End If


            con = New OleDbConnection(ck)

            con.Open()

            Dim co As String = "update [admin] set [Password] = '" & newpassword.Text & "'where [username]='" & username.Text & "' and [Password] = '" & oldpassword.Text & "'"
            '

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery()
            If updaterow > 0 Then

                MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form2.Show()
                username.Text = ""
                newpassword.Text = ""
                oldpassword.Text = ""
                confirmpassword.Text = ""

            Else

                MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                username.Text = ""
                newpassword.Text = ""
                oldpassword.Text = ""
                confirmpassword.Text = ""
                username.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    
End Class