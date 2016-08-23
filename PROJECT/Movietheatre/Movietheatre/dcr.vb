Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class dcr
    Dim rdr As OleDbDataReader = Nothing
    Public passdate As Date

    Dim con As OleDbConnection = Nothing
    Dim cmd1 As OleDbCommand = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
    Dim sd As Integer = -1
    Dim b3 As Integer = 9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim updaterow As Integer = 0

            Try

                con = New OleDbConnection(ck)
                con.Open()

            Dim ct As String = "select * from [DCR] where [currdate]=#" & DateTimePicker1.Text & "#"
                cmd1 = New OleDbCommand(ct)
                cmd1.Connection = con
                rdr = cmd1.ExecuteReader()
                If rdr.Read() Then
                TextBox1.Text = rdr.GetValue(1)
                TextBox2.Text = rdr.GetValue(5)
                TextBox3.Text = rdr.GetValue(9)
                TextBox4.Text = rdr.GetValue(13)
                TextBox5.Text = rdr.GetValue(17)
                TextBox6.Text = rdr.GetValue(21)
                TextBox24.Text = rdr.GetValue(2)
                TextBox23.Text = rdr.GetValue(6)
                TextBox22.Text = rdr.GetValue(10)
                TextBox21.Text = rdr.GetValue(14)
                TextBox20.Text = rdr.GetValue(18)
                TextBox18.Text = rdr.GetValue(22)
                TextBox48.Text = rdr.GetValue(3)
                TextBox47.Text = rdr.GetValue(7)
                TextBox46.Text = rdr.GetValue(11)
                TextBox45.Text = rdr.GetValue(15)
                TextBox44.Text = rdr.GetValue(19)
                TextBox42.Text = rdr.GetValue(23)
                TextBox36.Text = rdr.GetValue(4)
                TextBox35.Text = rdr.GetValue(8)
                TextBox34.Text = rdr.GetValue(12)
                TextBox33.Text = rdr.GetValue(16)
                TextBox32.Text = rdr.GetValue(20)
                TextBox30.Text = rdr.GetValue(24)
                TextBox7.Text = rdr.GetValue(1) + rdr.GetValue(9) + rdr.GetValue(17)
                TextBox8.Text = rdr.GetValue(5) + rdr.GetValue(13) + rdr.GetValue(21)
                TextBox17.Text = rdr.GetValue(18) + rdr.GetValue(10) + rdr.GetValue(2)
                TextBox15.Text = rdr.GetValue(22) + rdr.GetValue(14) + rdr.GetValue(6)
                TextBox41.Text = rdr.GetValue(19) + rdr.GetValue(11) + rdr.GetValue(3)
                TextBox39.Text = rdr.GetValue(7) + rdr.GetValue(23) + rdr.GetValue(15)
                TextBox29.Text = rdr.GetValue(20) + rdr.GetValue(12) + rdr.GetValue(4)
                TextBox27.Text = rdr.GetValue(24) + rdr.GetValue(16) + rdr.GetValue(8)

                Label41.Text = rdr.GetValue(1) + rdr.GetValue(9) + rdr.GetValue(17) + rdr.GetValue(5) + rdr.GetValue(13) + rdr.GetValue(21) + rdr.GetValue(18) + rdr.GetValue(10) + rdr.GetValue(2) + rdr.GetValue(22) + rdr.GetValue(14) + rdr.GetValue(6) + rdr.GetValue(19) + rdr.GetValue(11) + rdr.GetValue(3) + rdr.GetValue(7) + rdr.GetValue(23) + rdr.GetValue(15) + rdr.GetValue(20) + rdr.GetValue(12) + rdr.GetValue(4) + rdr.GetValue(24) + rdr.GetValue(16) + rdr.GetValue(8)

            Else
                MessageBox.Show("No Entry found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Dim bprice As Integer = 0
        Dim bnprice As Integer = 0
        Dim fprice As Integer = 0
        Dim fnprice As Integer = 0
        Dim sprice As Integer = 0
        Dim snprice As Integer = 0
        Dim pread As OleDbDataReader = Nothing
        Dim pcon As New OleDbConnection
        con = New OleDbConnection(ck)
        con.Open()

        Dim ct1 As String = "select * from [price] where [current date]=#" & DateTimePicker1.Text & "#"
        cmd = New OleDbCommand(ct1)
        cmd.Connection = con
        Try

        
        pread = cmd.ExecuteReader
        If pread.Read Then
            bprice = pread.GetValue(6)
            bnprice = pread.GetValue(1)
            fprice = pread.GetValue(4)
            fnprice = pread.GetValue(2)
            sprice = pread.GetValue(5)
            snprice = pread.GetValue(3)

                TextBox9.Text = (bprice * TextBox1.Text) + (bnprice * TextBox2.Text)
                TextBox10.Text = (fprice * TextBox3.Text) + (fnprice * TextBox4.Text)
                TextBox11.Text = (sprice * TextBox5.Text) + (snprice * TextBox6.Text)
                TextBox12.Text = (bprice * TextBox1.Text) + (bnprice * TextBox2.Text) + (fprice * TextBox3.Text) + (fnprice * TextBox4.Text) + (sprice * TextBox5.Text) + (snprice * TextBox6.Text)


                TextBox25.Text = (bprice * TextBox36.Text) + (bnprice * TextBox35.Text)
                TextBox31.Text = (fprice * TextBox34.Text) + (fnprice * TextBox33.Text)
                TextBox28.Text = (sprice * TextBox32.Text) + (snprice * TextBox30.Text)
                TextBox26.Text = (bprice * TextBox36.Text) + (bnprice * TextBox35.Text) + (fprice * TextBox34.Text) + (fnprice * TextBox33.Text) + (sprice * TextBox32.Text) + (snprice * TextBox30.Text)


                TextBox37.Text = (bprice * TextBox48.Text) + (bnprice * TextBox47.Text)
                TextBox43.Text = (fprice * TextBox46.Text) + (fnprice * TextBox45.Text)
                TextBox40.Text = (sprice * TextBox44.Text) + (snprice * TextBox42.Text)
                TextBox38.Text = (bprice * TextBox48.Text) + (bnprice * TextBox47.Text) + (fprice * TextBox46.Text) + (fnprice * TextBox45.Text) + (sprice * TextBox44.Text) + (snprice * TextBox42.Text)

                TextBox13.Text = (bprice * TextBox24.Text) + (bnprice * TextBox23.Text)
                TextBox19.Text = (fprice * TextBox22.Text) + (fnprice * TextBox21.Text)
                TextBox16.Text = (sprice * TextBox20.Text) + (snprice * TextBox18.Text)
                TextBox14.Text = (bprice * TextBox24.Text) + (bnprice * TextBox23.Text) + (fprice * TextBox22.Text) + (fnprice * TextBox21.Text) + (sprice * TextBox20.Text) + (snprice * TextBox18.Text)

                Label42.Text = (bprice * TextBox24.Text) + (bnprice * TextBox23.Text) + (fprice * TextBox22.Text) + (fnprice * TextBox21.Text) + (sprice * TextBox20.Text) + (snprice * TextBox18.Text) + (bprice * TextBox48.Text) + (bnprice * TextBox47.Text) + (fprice * TextBox46.Text) + (fnprice * TextBox45.Text) + (sprice * TextBox44.Text) + (snprice * TextBox42.Text) + (bprice * TextBox36.Text) + (bnprice * TextBox35.Text) + (fprice * TextBox34.Text) + (fnprice * TextBox33.Text) + (sprice * TextBox32.Text) + (snprice * TextBox30.Text) + (bprice * TextBox1.Text) + (bnprice * TextBox2.Text) + (fprice * TextBox3.Text) + (fnprice * TextBox4.Text) + (sprice * TextBox5.Text) + (snprice * TextBox6.Text)

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updaterow As Integer = 0

        con = New OleDbConnection(ck)
        con.Open()
        Dim co As String = "update [mcr] set [total tickets] = '" & Label41.Text & "',[collection] = '" & Label42.Text & "' where [curr_date]=#" & DateTimePicker1.Text & "#"

        cmd = New OleDbCommand(co)

        cmd.Connection = con
        updaterow = cmd.ExecuteNonQuery
        If updaterow > 0 Then
            '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()

        PrintDialog1.PrinterSettings = PrintDoc.PrinterSettings
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings

            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Left = 50
                .Margins.Right = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
                .Landscape = False
            End With
            PrintDoc.DefaultPageSettings = pagesetup
        End If

        PrintPreviewDialog1.Document = PrintDoc
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage

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
        'e.Graphics.DrawRectangle(p, rec1)
        ' e.Graphics.DrawRectangle(p, rec3)
        myBrush = New SolidBrush(Color.Black)
        e.Graphics.FillRectangle(myBrush, rec)
        '  e.Graphics.FillRectangle(myBrush, rec1)
        '  e.Graphics.FillRectangle(myBrush, rec2)
        '  e.Graphics.FillRectangle(myBrush, rec4)
        e.Graphics.DrawString("                SQUBE MOVIES ", font1, Brushes.White, 150, 105)

        Dim font2 As New Font("lucida fax", 20, FontStyle.Bold)

        Dim font4 As New Font("Engravers MT", 15, FontStyle.Bold)
        e.Graphics.DrawString("                          SAKTHI FILM CITY Pvt Ltd ", font2, Brushes.Black, -20, 190)

        Dim font3 As New Font("Franklin Gothic", 16, FontStyle.Bold)
        e.Graphics.DrawString("                   DAILY COLLECTION REPORT                      ", font1, Brushes.DarkBlue, 0, 250)

        e.Graphics.DrawString("                                     Date :        " + DateTimePicker1.Text.ToString(), font3, Brushes.Black, 0, 330)


        e.Graphics.DrawString("                                            Reservation           Normal               ", font4, Brushes.Blue, 30, 400 + 50)
        e.Graphics.DrawString("        Noon show           :    ", font4, Brushes.Black, 50, 460 + 20 + 50)
        e.Graphics.DrawString("        Matinee                 :  ", font4, Brushes.Black, 50, 500 + 40 + 50)
        e.Graphics.DrawString("        First show          :     ", font4, Brushes.Black, 50, 540 + 80 + 50)
        e.Graphics.DrawString("        Second show     :      ", font4, Brushes.Black, 50, 580 + 120 + 50)
        e.Graphics.DrawString("                                           " + TextBox7.Text + "                           " + TextBox8.Text, font4, Brushes.DarkRed, 150, 460 + 20 + 50)
        e.Graphics.DrawString("                                           " + TextBox17.Text + "                           " + TextBox15.Text, font4, Brushes.DarkRed, 150, 500 + 40 + 50)
        e.Graphics.DrawString("                                           " + TextBox41.Text + "                           " + TextBox39.Text, font4, Brushes.DarkRed, 150, 540 + 80 + 50)
        e.Graphics.DrawString("                                           " + TextBox29.Text + "                           " + TextBox27.Text, font4, Brushes.DarkRed, 150, 580 + 120 + 50)
        e.Graphics.DrawString("        Total seats                  :     ", font4, Brushes.Black, 50, 580 + 120 + 80 + 50 + 50)
        e.Graphics.DrawString("        Total Collection     :          ", font4, Brushes.Black, 50, 580 + 120 + 80 + 50 + 80 + 50)
        e.Graphics.DrawString("                                                    " + Label41.Text + "                           ", font4, Brushes.DarkRed, 150, 580 + 120 + 80 + 50 + 50)
        e.Graphics.DrawString("                                                    " + Label42.Text + "                           ", font4, Brushes.DarkRed, 150, 580 + 120 + 80 + 50 + 80 + 50)


        e.Graphics.DrawString(" ADMINISTRATOR           ", font3, Brushes.DarkRed, 550, 580 + 120 + 80 + 50 + 80 + 50 + 100)


    End Sub
End Class