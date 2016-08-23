
Imports System.Drawing.Printing
Imports System.Data.OleDb
Public Class printticket
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
    Dim rdr As OleDbDataReader = Nothing
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        Dim fntText As Font = DefaultFont

        Dim leftMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
        Dim topMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Top

        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)
        Dim font1 As New Font("showcard gothic", 25)
        Dim rec As New Rectangle(e.MarginBounds.X, 100, e.MarginBounds.Width, 70)
        Dim rec1 As New Rectangle(800, 380, 250, 30)
        Dim rec2 As New Rectangle(800, 445, 50, 40)
        Dim rec3 As New Rectangle(e.MarginBounds.X + 10, 645, 1050, 40)
        Dim rec4 As New Rectangle(e.MarginBounds.X + 220, 645, e.MarginBounds.Width - 230, 40)

        Dim myBrush As Brush
        Dim p As New Pen(Color.Black, 2)
        e.Graphics.DrawRectangle(p, rec)
        e.Graphics.DrawRectangle(p, rec1)
        e.Graphics.DrawRectangle(p, rec3)
        myBrush = New SolidBrush(Color.Black)
        e.Graphics.FillRectangle(myBrush, rec)
        e.Graphics.FillRectangle(myBrush, rec1)
        e.Graphics.FillRectangle(myBrush, rec2)
        e.Graphics.FillRectangle(myBrush, rec4)
        e.Graphics.DrawString("                                          SQUBE MOVIES ", font1, Brushes.White, 150, 105)

        Dim font2 As New Font("lucida fax", 20, FontStyle.Bold)

        Dim font4 As New Font("lucida fax", 10, FontStyle.Regular)
        e.Graphics.DrawString("                                          SAKTHI FILM CITY Pvt Ltd ", font2, Brushes.Black, -20, 190)

        Dim font3 As New Font("Franklin Gothic", 16, FontStyle.Bold)
        e.Graphics.DrawString("                                          Movie : " + TextBox1.Text + " - " + TextBox2.Text, font2, Brushes.DarkBlue, 0, 250)

        e.Graphics.DrawString("           Date :        " + Date.Now.ToString("f"), font3, Brushes.Black, 0, 330)


        e.Graphics.DrawString("           Show :               " + TextBox5.Text, font3, Brushes.Black, 0, 387)
        e.Graphics.DrawString(" " + TextBox6.Text, font3, Brushes.White, 820, 380)
        e.Graphics.DrawString("           Rate :    " + TextBox7.Text, font3, Brushes.Black, 0, 450)
        e.Graphics.DrawString("                                                                                                   No. Of Tickets :   ", font3, Brushes.Black, 0, 450)
        e.Graphics.DrawString("                                                                                                                              " + TextBox8.Text, font3, Brushes.White, 40, 450)
        ' e.Graphics.DrawString("           Reservation charges  :   " + TextBox9.Text, font3, Brushes.Black, 0, 550)
        e.Graphics.DrawString("                                                                                                   Total Amount  :   " + TextBox10.Text, font3, Brushes.Black, 0, 550)
        e.Graphics.DrawString("         SEAT NO.  :                           ", font2, Brushes.Black, 0, 650)

        e.Graphics.DrawString("                                                   " + TextBox11.Text, font3, Brushes.YellowGreen, 0, 650)

        e.Graphics.DrawString("              NB: Tickets once issued cannot be refunded or exchanged under any circumstances                  ", font4, Brushes.Black, 0, 750)



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PrintDialog1.PrinterSettings = PrintDoc.PrinterSettings
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings

            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Left = 50
                .Margins.Right = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
                .Landscape = True
            End With
            PrintDoc.DefaultPageSettings = pagesetup
        End If

        PrintPreviewDialog1.Document = PrintDoc
        PrintPreviewDialog1.ShowDialog()
    End Sub

  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
            TextBox1.Text = reader11.GetValue(2)
            TextBox2.Text = reader11.GetValue(4)
            TextBox3.Text = reader11.GetValue(5)
            TextBox4.Text = reader11.GetValue(6)
            TextBox5.Text = reader11.GetValue(7)
            TextBox6.Text = reader11.GetValue(8)
            TextBox7.Text = reader11.GetValue(9)
            TextBox8.Text = reader11.GetValue(10)
            TextBox10.Text = reader11.GetValue(11)
            TextBox11.Text = reader11.GetValue(3)
            TextBox13.Text = reader11.GetValue(1)
            MessageBox.Show("Done  !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        con.Close()
    End Sub

    Private Sub printticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox12.Focus()
    End Sub

    
End Class