Imports System.Data.OleDb
Public Class Form3
    Public checkreserve As Integer = 0
    Dim rdr As OleDbDataReader = Nothing
   Dim con As OleDbConnection = Nothing
    Dim cmd1 As OleDbCommand = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Persist Security Info=False;"
    Public nsdate As Date = #12:00:00 PM#
    Public nsdate1 As Date = #11:00:00 PM#
    Public msdate As Date = #3:00:00 PM#
    Public msdate1 As Date = #2:00:00 PM#
    Public fsdate As Date = #6:30:00 PM#
    Public fsdate1 As Date = #5:30:00 PM#
    Public ssdate As Date = #11:00:00 PM#
    Public ssdate1 As Date = #8:00:00 PM#
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        resselect.Show()
        checkreserve = 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        home.Show()
        checkreserve = 0
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles MetroTile1.Click
        resselect.Show()
        checkreserve = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        resselect.DateTimePicker1.Enabled = False
        checkreserve = 0
        resselect.Show()
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        resselect.DateTimePicker1.Enabled = False
        checkreserve = 0
        resselect.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        cancel.Show()
        checkreserve = 0
    End Sub


   
   

   
    Private Sub ChangeThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeThemeToolStripMenuItem.Click
        If Me.Theme = MetroThemeStyle.Light Then
            Me.Theme = MetroThemeStyle.Dark
        Else
            Me.Theme = MetroThemeStyle.Light
        End If
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        viewmovie.Show()
    End Sub

    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click
        printticket.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        userpasschange.Show()
    End Sub
End Class