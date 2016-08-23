
Imports System.Data.OleDb
Public Class cancelslip
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
    Dim rdr As OleDbDataReader = Nothing
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox11.Clear()
        TextBox13.Clear()
        Dim rdrr11 As OleDbDataReader = Nothing
        Dim comd11 As OleDbCommand = Nothing
        con = New OleDbConnection(ck)
        con.Open()
        Dim str11 As String = "select * from [resdetails] where [res_id] = '" & TextBox12.Text & "'"
        comd11 = New OleDbCommand(str11)
        comd11.Connection = con
        Dim reader11 As OleDbDataReader = Nothing
        reader11 = comd11.ExecuteReader()
        If reader11.Read() Then
            TextBox1.Text = reader11.GetValue(5)
            TextBox2.Text = reader11.GetValue(7)
            TextBox11.Text = reader11.GetValue(3)
            TextBox13.Text = reader11.GetValue(1)

            MessageBox.Show("Done  !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not found", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox12.Clear()
        End If
        con.Close()
        TextBox12.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox11.Clear()
        TextBox13.Clear()
        Dim rdrr11 As OleDbDataReader = Nothing
        Dim comd11 As OleDbCommand = Nothing
        con = New OleDbConnection(ck)
        con.Open()
        Dim str11 As String = "delete * from [resdetails] where [res_id] = '" & TextBox12.Text & "'"
        comd11 = New OleDbCommand(str11)
        comd11.Connection = con
        Dim reader11 As OleDbDataReader = Nothing
        Dim up As Integer = 0
        up = comd11.ExecuteNonQuery()
        If up > 0 Then
            MessageBox.Show("Done  !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not found", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox12.Clear()
        End If
        con.Close()
        TextBox12.Focus()
    End Sub

    Private Sub cancelslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox12.Focus()
    End Sub

End Class