Public Class Form2
    Dim lbl As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = Form1.TextBox2.Text

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        moviereg.Show()
    End Sub


  

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        distreg.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        dcr.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        showassign.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles MetroTile8.Click

        home.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        userpasschange.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        showassign.Show()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        distreg.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        price.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        moviereg.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        dcr.Show()
    End Sub


   
  
   
    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        price.Show()
    End Sub

    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub MetroTile7_Click(sender As Object, e As EventArgs) Handles MetroTile7.Click
        mcr.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        adminpasschange.Show()
    End Sub

    Private Sub UserControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserControlToolStripMenuItem.Click
        adduser.Show()
    End Sub

    Private Sub MCRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MCRToolStripMenuItem.Click
        mcr.Show()
    End Sub

    Private Sub RegisterNewAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNewAdminToolStripMenuItem.Click
        form4.Show()
    End Sub
End Class