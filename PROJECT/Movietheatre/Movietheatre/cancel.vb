Public Class cancel

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "NOON SHOW" Then
            phoneres.Show()
            Me.Close()
        ElseIf ComboBox1.Text = "MATINEE" Then
            phoneres2.Show()
            Me.Close()
        ElseIf ComboBox1.Text = "FIRST SHOW" Then
            phoneres3.Show()
            Me.Close()
        ElseIf ComboBox1.Text = "SECOND SHOW" Then
            phoneres4.Show()
            Me.Close()

        Else
            MessageBox.Show("Select Show", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

   
    Private Sub Button202_Click(sender As Object, e As EventArgs) Handles Button202.Click
        cancelslip.Show()
    End Sub
End Class