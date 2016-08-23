Imports System.Data.OleDb

Imports System.Drawing.Printing

Public Class mcr
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
        myConnection.ConnectionString = connString
        Connection.ConnectionString = connString

        Dim cmd2 As OleDbCommand = New OleDbCommand("select * from [MCR] where [Curr_date]>=#" & DateTimePicker1.Text & "# AND [Curr_date]<=#" & DateTimePicker2.Text & "#", myConnection)

        myConnection.Open()
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

        Dim dt As New DataTable
        Dim query As String = " select * from [MCR] where [Curr_date]>=#" & DateTimePicker1.Text & "# AND [Curr_date]<=#" & DateTimePicker2.Text & "#"


        Using command As New OleDbCommand(query, Connection)
            Using adapter As New OleDb.OleDbDataAdapter(command)
                Connection.Open()
                adapter.Fill(dt)
                Connection.Close()
            End Using
        End Using


        If dr2.Read Then

            MetroGrid1.DataSource = dt

        Else
            MsgBox("Sorry, Can't load values", MsgBoxStyle.OkOnly, "Error")
        End If
        myConnection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       

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


    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim bm As New Bitmap(Me.MetroGrid1.Width, Me.MetroGrid1.Height)
        MetroGrid1.DrawToBitmap(bm, New Rectangle(0, 0, Me.MetroGrid1.Width, Me.MetroGrid1.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

    
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim font2 As New Font("lucida fax", 17, FontStyle.Bold)
        Dim font3 As New Font("lucida fax", 20, FontStyle.Bold)
        Dim font4 As New Font("lucida fax", 70, FontStyle.Bold, FontStyle.Underline)

        e.Graphics.DrawString(" MONTHLY COLLECTION REPORT ", font3, Brushes.DarkSeaGreen, 150, 80)
        e.Graphics.DrawString("                SQUBE MOVIES ", font3, Brushes.DarkSeaGreen, 150, 30)

        e.Graphics.DrawString("DATE             TICKETS             COLLECTION ", font2, Brushes.DarkBlue, 150, 155)
        Dim total As Integer = 0

        For i As Integer = 0 To MetroGrid1.RowCount - 1

            total += MetroGrid1.Rows(i).Cells(2).Value

        Next

        TextBox1.Text = total
        With MetroGrid1
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            Dim rc2 As RectangleF

            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim font1 As New Font("lucida fax", 20, FontStyle.Bold)
            Dim y As Single = e.MarginBounds.Top + 100
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left + 50
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width * 2, cell.Size.Height * 2)
                    Dim rc1 As RectangleF = New RectangleF(x, y + cell.Size.Height * 2, cell.Size.Width * 2, cell.Size.Height * 2)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    rc2 = rc
                    If (newpage) Then
                        e.Graphics.DrawString(MetroGrid1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), font1, Brushes.Black, rc1, fmt)

                    Else

                        e.Graphics.DrawString(MetroGrid1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), font1, Brushes.Black, rc1, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            e.Graphics.DrawRectangle(Pens.Black, rc2.Left, rc2.Top, rc2.Width, rc2.Height + 40)
            e.Graphics.DrawString(total, font3, Brushes.DarkRed, rc2.Left + 5, rc2.Top + 50)
            e.Graphics.DrawString("Total collection", font3, Brushes.DarkRed, rc2.Left - 400, rc2.Top + 50)
            mRow = 0
        End With

       
    End Sub


End Class