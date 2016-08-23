<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class moviereg
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
        Dim Film_idLabel As System.Windows.Forms.Label
        Dim LanguageLabel As System.Windows.Forms.Label
        Dim CertificateLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim Release_dateLabel As System.Windows.Forms.Label
        Dim DistributorLabel1 As System.Windows.Forms.Label
        Dim Movie_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(moviereg))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Release_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Film_idTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.Movie_nameTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CertificateTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Film_idLabel = New System.Windows.Forms.Label()
        LanguageLabel = New System.Windows.Forms.Label()
        CertificateLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        Release_dateLabel = New System.Windows.Forms.Label()
        DistributorLabel1 = New System.Windows.Forms.Label()
        Movie_nameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Film_idLabel
        '
        Film_idLabel.AutoSize = True
        Film_idLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Film_idLabel.Location = New System.Drawing.Point(77, 99)
        Film_idLabel.Name = "Film_idLabel"
        Film_idLabel.Size = New System.Drawing.Size(98, 18)
        Film_idLabel.TabIndex = 39
        Film_idLabel.Text = "Film id               :"
        '
        'LanguageLabel
        '
        LanguageLabel.AutoSize = True
        LanguageLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LanguageLabel.Location = New System.Drawing.Point(78, 361)
        LanguageLabel.Name = "LanguageLabel"
        LanguageLabel.Size = New System.Drawing.Size(94, 18)
        LanguageLabel.TabIndex = 51
        LanguageLabel.Text = "Language        :"
        '
        'CertificateLabel
        '
        CertificateLabel.AutoSize = True
        CertificateLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CertificateLabel.Location = New System.Drawing.Point(77, 316)
        CertificateLabel.Name = "CertificateLabel"
        CertificateLabel.Size = New System.Drawing.Size(97, 18)
        CertificateLabel.TabIndex = 49
        CertificateLabel.Text = "Certificate        :"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeLabel.Location = New System.Drawing.Point(78, 270)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(96, 18)
        TypeLabel.TabIndex = 47
        TypeLabel.Text = "Type                  :"
        '
        'Release_dateLabel
        '
        Release_dateLabel.AutoSize = True
        Release_dateLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Release_dateLabel.Location = New System.Drawing.Point(76, 223)
        Release_dateLabel.Name = "Release_dateLabel"
        Release_dateLabel.Size = New System.Drawing.Size(99, 18)
        Release_dateLabel.TabIndex = 45
        Release_dateLabel.Text = "Release date    :"
        '
        'DistributorLabel1
        '
        DistributorLabel1.AutoSize = True
        DistributorLabel1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DistributorLabel1.Location = New System.Drawing.Point(77, 184)
        DistributorLabel1.Name = "DistributorLabel1"
        DistributorLabel1.Size = New System.Drawing.Size(98, 18)
        DistributorLabel1.TabIndex = 43
        DistributorLabel1.Text = "Distributor       :"
        '
        'Movie_nameLabel
        '
        Movie_nameLabel.AutoSize = True
        Movie_nameLabel.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Movie_nameLabel.Location = New System.Drawing.Point(78, 139)
        Movie_nameLabel.Name = "Movie_nameLabel"
        Movie_nameLabel.Size = New System.Drawing.Size(104, 18)
        Movie_nameLabel.TabIndex = 41
        Movie_nameLabel.Text = "Movie name    :  "
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(380, 414)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 49)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(32, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 49)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Release_dateDateTimePicker
        '
        Me.Release_dateDateTimePicker.Location = New System.Drawing.Point(214, 220)
        Me.Release_dateDateTimePicker.Name = "Release_dateDateTimePicker"
        Me.Release_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Release_dateDateTimePicker.TabIndex = 46
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "2D", "3D"})
        Me.ComboBox1.Location = New System.Drawing.Point(213, 270)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 53
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"", "Malayalam", "English", "Hindi", "Tamil", "Telungu", "Kannada"})
        Me.ComboBox2.Location = New System.Drawing.Point(213, 361)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 53
        '
        'Film_idTextBox
        '
        '
        '
        '
        Me.Film_idTextBox.CustomButton.Image = Nothing
        Me.Film_idTextBox.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.Film_idTextBox.CustomButton.Name = ""
        Me.Film_idTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Film_idTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Film_idTextBox.CustomButton.TabIndex = 1
        Me.Film_idTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Film_idTextBox.CustomButton.UseSelectable = True
        Me.Film_idTextBox.CustomButton.Visible = False
        Me.Film_idTextBox.Lines = New String(-1) {}
        Me.Film_idTextBox.Location = New System.Drawing.Point(214, 94)
        Me.Film_idTextBox.MaxLength = 32767
        Me.Film_idTextBox.Name = "Film_idTextBox"
        Me.Film_idTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Film_idTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Film_idTextBox.SelectedText = ""
        Me.Film_idTextBox.SelectionLength = 0
        Me.Film_idTextBox.SelectionStart = 0
        Me.Film_idTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Film_idTextBox.TabIndex = 55
        Me.Film_idTextBox.UseSelectable = True
        Me.Film_idTextBox.WaterMark = "Film id"
        Me.Film_idTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Film_idTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Movie_nameTextBox
        '
        '
        '
        '
        Me.Movie_nameTextBox.CustomButton.Image = Nothing
        Me.Movie_nameTextBox.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.Movie_nameTextBox.CustomButton.Name = ""
        Me.Movie_nameTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Movie_nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Movie_nameTextBox.CustomButton.TabIndex = 1
        Me.Movie_nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Movie_nameTextBox.CustomButton.UseSelectable = True
        Me.Movie_nameTextBox.CustomButton.Visible = False
        Me.Movie_nameTextBox.Lines = New String(-1) {}
        Me.Movie_nameTextBox.Location = New System.Drawing.Point(214, 134)
        Me.Movie_nameTextBox.MaxLength = 32767
        Me.Movie_nameTextBox.Name = "Movie_nameTextBox"
        Me.Movie_nameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Movie_nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Movie_nameTextBox.SelectedText = ""
        Me.Movie_nameTextBox.SelectionLength = 0
        Me.Movie_nameTextBox.SelectionStart = 0
        Me.Movie_nameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Movie_nameTextBox.TabIndex = 55
        Me.Movie_nameTextBox.UseSelectable = True
        Me.Movie_nameTextBox.WaterMark = "Enter Movie name"
        Me.Movie_nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Movie_nameTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(214, 181)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(199, 21)
        Me.ComboBox3.TabIndex = 54
        '
        'CertificateTextBox
        '
        '
        '
        '
        Me.CertificateTextBox.CustomButton.Image = Nothing
        Me.CertificateTextBox.CustomButton.Location = New System.Drawing.Point(178, 1)
        Me.CertificateTextBox.CustomButton.Name = ""
        Me.CertificateTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.CertificateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CertificateTextBox.CustomButton.TabIndex = 1
        Me.CertificateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CertificateTextBox.CustomButton.UseSelectable = True
        Me.CertificateTextBox.CustomButton.Visible = False
        Me.CertificateTextBox.Lines = New String(-1) {}
        Me.CertificateTextBox.Location = New System.Drawing.Point(214, 316)
        Me.CertificateTextBox.MaxLength = 32767
        Me.CertificateTextBox.Name = "CertificateTextBox"
        Me.CertificateTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CertificateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CertificateTextBox.SelectedText = ""
        Me.CertificateTextBox.SelectionLength = 0
        Me.CertificateTextBox.SelectionStart = 0
        Me.CertificateTextBox.Size = New System.Drawing.Size(200, 23)
        Me.CertificateTextBox.TabIndex = 55
        Me.CertificateTextBox.UseSelectable = True
        Me.CertificateTextBox.WaterMark = "Enter Type of Certificate"
        Me.CertificateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CertificateTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(202, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 49)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "View movies"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'moviereg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 475)
        Me.Controls.Add(Me.CertificateTextBox)
        Me.Controls.Add(Me.Movie_nameTextBox)
        Me.Controls.Add(Me.Film_idTextBox)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Film_idLabel)
        Me.Controls.Add(Movie_nameLabel)
        Me.Controls.Add(DistributorLabel1)
        Me.Controls.Add(Release_dateLabel)
        Me.Controls.Add(Me.Release_dateDateTimePicker)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(CertificateLabel)
        Me.Controls.Add(LanguageLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "moviereg"
        Me.Text = "Movie Registration"
        Me.TransparencyKey = System.Drawing.Color.Wheat
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Release_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Film_idTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Movie_nameTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents CertificateTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
