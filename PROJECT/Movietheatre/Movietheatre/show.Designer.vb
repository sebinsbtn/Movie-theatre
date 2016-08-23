<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showassign
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Current_dateLabel As System.Windows.Forms.Label
        Dim Noon_showLabel As System.Windows.Forms.Label
        Dim MatineeLabel As System.Windows.Forms.Label
        Dim First_showLabel As System.Windows.Forms.Label
        Dim Second_showLabel As System.Windows.Forms.Label
        Me.Current_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Current_dateLabel = New System.Windows.Forms.Label()
        Noon_showLabel = New System.Windows.Forms.Label()
        MatineeLabel = New System.Windows.Forms.Label()
        First_showLabel = New System.Windows.Forms.Label()
        Second_showLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Current_dateLabel
        '
        Current_dateLabel.AutoSize = True
        Current_dateLabel.Location = New System.Drawing.Point(107, 97)
        Current_dateLabel.Name = "Current_dateLabel"
        Current_dateLabel.Size = New System.Drawing.Size(60, 13)
        Current_dateLabel.TabIndex = 1
        Current_dateLabel.Text = "Date         :"
        '
        'Noon_showLabel
        '
        Noon_showLabel.AutoSize = True
        Noon_showLabel.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Noon_showLabel.ForeColor = System.Drawing.Color.Indigo
        Noon_showLabel.Location = New System.Drawing.Point(51, 155)
        Noon_showLabel.Name = "Noon_showLabel"
        Noon_showLabel.Size = New System.Drawing.Size(116, 15)
        Noon_showLabel.TabIndex = 3
        Noon_showLabel.Text = "Noon show       :"
        '
        'MatineeLabel
        '
        MatineeLabel.AutoSize = True
        MatineeLabel.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatineeLabel.ForeColor = System.Drawing.Color.Indigo
        MatineeLabel.Location = New System.Drawing.Point(51, 208)
        MatineeLabel.Name = "MatineeLabel"
        MatineeLabel.Size = New System.Drawing.Size(115, 15)
        MatineeLabel.TabIndex = 5
        MatineeLabel.Text = "Matinee            :"
        '
        'First_showLabel
        '
        First_showLabel.AutoSize = True
        First_showLabel.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_showLabel.ForeColor = System.Drawing.Color.Indigo
        First_showLabel.Location = New System.Drawing.Point(51, 258)
        First_showLabel.Name = "First_showLabel"
        First_showLabel.Size = New System.Drawing.Size(115, 15)
        First_showLabel.TabIndex = 7
        First_showLabel.Text = "First show        :"
        '
        'Second_showLabel
        '
        Second_showLabel.AutoSize = True
        Second_showLabel.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Second_showLabel.ForeColor = System.Drawing.Color.Indigo
        Second_showLabel.Location = New System.Drawing.Point(51, 314)
        Second_showLabel.Name = "Second_showLabel"
        Second_showLabel.Size = New System.Drawing.Size(116, 15)
        Second_showLabel.TabIndex = 9
        Second_showLabel.Text = "Second show    :"
        '
        'Current_dateDateTimePicker
        '
        Me.Current_dateDateTimePicker.Location = New System.Drawing.Point(218, 90)
        Me.Current_dateDateTimePicker.Name = "Current_dateDateTimePicker"
        Me.Current_dateDateTimePicker.Size = New System.Drawing.Size(235, 20)
        Me.Current_dateDateTimePicker.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(79, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(299, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 36)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 366)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 80)
        Me.Panel1.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(218, 153)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(218, 206)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox2.TabIndex = 14
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(218, 255)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox3.TabIndex = 14
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(218, 308)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox4.TabIndex = 14
        '
        'showassign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(495, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Current_dateLabel)
        Me.Controls.Add(Me.Current_dateDateTimePicker)
        Me.Controls.Add(Noon_showLabel)
        Me.Controls.Add(MatineeLabel)
        Me.Controls.Add(First_showLabel)
        Me.Controls.Add(Second_showLabel)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Name = "showassign"
        Me.Text = "Show assign"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Current_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
End Class
