<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class distreg
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
        Dim Dist_idLabel As System.Windows.Forms.Label
        Dim DistributorLabel As System.Windows.Forms.Label
        Dim PlaceLabel As System.Windows.Forms.Label
        Dim Contact_noLabel As System.Windows.Forms.Label
        Dim Email_idLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(distreg))
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DistributorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.Email = New MetroFramework.Controls.MetroTextBox()
        Me.Contact = New MetroFramework.Controls.MetroTextBox()
        Me.Place = New MetroFramework.Controls.MetroTextBox()
        Me.Distributor = New MetroFramework.Controls.MetroTextBox()
        Me.Datagridview1 = New MetroFramework.Controls.MetroGrid()
        Me.Button2 = New System.Windows.Forms.Button()
        Dist_idLabel = New System.Windows.Forms.Label()
        DistributorLabel = New System.Windows.Forms.Label()
        PlaceLabel = New System.Windows.Forms.Label()
        Contact_noLabel = New System.Windows.Forms.Label()
        Email_idLabel = New System.Windows.Forms.Label()
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dist_idLabel
        '
        Dist_idLabel.AutoSize = True
        Dist_idLabel.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dist_idLabel.Location = New System.Drawing.Point(134, 106)
        Dist_idLabel.Name = "Dist_idLabel"
        Dist_idLabel.Size = New System.Drawing.Size(154, 23)
        Dist_idLabel.TabIndex = 1
        Dist_idLabel.Text = "Distributor ID           :"
        '
        'DistributorLabel
        '
        DistributorLabel.AutoSize = True
        DistributorLabel.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DistributorLabel.Location = New System.Drawing.Point(134, 150)
        DistributorLabel.Name = "DistributorLabel"
        DistributorLabel.Size = New System.Drawing.Size(154, 23)
        DistributorLabel.TabIndex = 3
        DistributorLabel.Text = "Distributor Name     :"
        '
        'PlaceLabel
        '
        PlaceLabel.AutoSize = True
        PlaceLabel.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlaceLabel.Location = New System.Drawing.Point(134, 192)
        PlaceLabel.Name = "PlaceLabel"
        PlaceLabel.Size = New System.Drawing.Size(154, 23)
        PlaceLabel.TabIndex = 5
        PlaceLabel.Text = "Address                     :"
        '
        'Contact_noLabel
        '
        Contact_noLabel.AutoSize = True
        Contact_noLabel.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_noLabel.Location = New System.Drawing.Point(134, 278)
        Contact_noLabel.Name = "Contact_noLabel"
        Contact_noLabel.Size = New System.Drawing.Size(155, 23)
        Contact_noLabel.TabIndex = 7
        Contact_noLabel.Text = "Contact no                 :"
        '
        'Email_idLabel
        '
        Email_idLabel.AutoSize = True
        Email_idLabel.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_idLabel.Location = New System.Drawing.Point(134, 316)
        Email_idLabel.Name = "Email_idLabel"
        Email_idLabel.Size = New System.Drawing.Size(157, 23)
        Email_idLabel.TabIndex = 9
        Email_idLabel.Text = "Email id                     :"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(309, 106)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(159, 20)
        Me.id.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DISTRIBUTOR REGISTRATION"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(240, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 43)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(694, 364)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(191, 43)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DistributorDataGridViewTextBoxColumn
        '
        Me.DistributorDataGridViewTextBoxColumn.DataPropertyName = "Distributor"
        Me.DistributorDataGridViewTextBoxColumn.HeaderText = "Distributor"
        Me.DistributorDataGridViewTextBoxColumn.Name = "DistributorDataGridViewTextBoxColumn"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Dist_id"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Place"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Place"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Email
        '
        '
        '
        '
        Me.Email.CustomButton.Image = Nothing
        Me.Email.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.Email.CustomButton.Name = ""
        Me.Email.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Email.CustomButton.TabIndex = 1
        Me.Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Email.CustomButton.UseSelectable = True
        Me.Email.CustomButton.Visible = False
        Me.Email.Lines = New String(-1) {}
        Me.Email.Location = New System.Drawing.Point(309, 316)
        Me.Email.MaxLength = 32767
        Me.Email.Name = "Email"
        Me.Email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Email.SelectedText = ""
        Me.Email.SelectionLength = 0
        Me.Email.SelectionStart = 0
        Me.Email.Size = New System.Drawing.Size(159, 23)
        Me.Email.TabIndex = 18
        Me.Email.UseSelectable = True
        Me.Email.WaterMark = "Enter Email id"
        Me.Email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Contact
        '
        '
        '
        '
        Me.Contact.CustomButton.Image = Nothing
        Me.Contact.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.Contact.CustomButton.Name = ""
        Me.Contact.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Contact.CustomButton.TabIndex = 1
        Me.Contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Contact.CustomButton.UseSelectable = True
        Me.Contact.CustomButton.Visible = False
        Me.Contact.Lines = New String(-1) {}
        Me.Contact.Location = New System.Drawing.Point(309, 278)
        Me.Contact.MaxLength = 32767
        Me.Contact.Name = "Contact"
        Me.Contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Contact.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Contact.SelectedText = ""
        Me.Contact.SelectionLength = 0
        Me.Contact.SelectionStart = 0
        Me.Contact.Size = New System.Drawing.Size(159, 23)
        Me.Contact.TabIndex = 18
        Me.Contact.UseSelectable = True
        Me.Contact.WaterMark = "Enter Contact number"
        Me.Contact.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Contact.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Place
        '
        '
        '
        '
        Me.Place.CustomButton.Image = Nothing
        Me.Place.CustomButton.Location = New System.Drawing.Point(91, 2)
        Me.Place.CustomButton.Name = ""
        Me.Place.CustomButton.Size = New System.Drawing.Size(65, 65)
        Me.Place.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Place.CustomButton.TabIndex = 1
        Me.Place.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Place.CustomButton.UseSelectable = True
        Me.Place.CustomButton.Visible = False
        Me.Place.Lines = New String(-1) {}
        Me.Place.Location = New System.Drawing.Point(309, 192)
        Me.Place.MaxLength = 32767
        Me.Place.Multiline = True
        Me.Place.Name = "Place"
        Me.Place.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Place.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Place.SelectedText = ""
        Me.Place.SelectionLength = 0
        Me.Place.SelectionStart = 0
        Me.Place.Size = New System.Drawing.Size(159, 70)
        Me.Place.TabIndex = 18
        Me.Place.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Place.UseSelectable = True
        Me.Place.WaterMark = "Enter Address Details"
        Me.Place.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Place.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Distributor
        '
        '
        '
        '
        Me.Distributor.CustomButton.Image = Nothing
        Me.Distributor.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.Distributor.CustomButton.Name = ""
        Me.Distributor.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Distributor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Distributor.CustomButton.TabIndex = 1
        Me.Distributor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Distributor.CustomButton.UseSelectable = True
        Me.Distributor.CustomButton.Visible = False
        Me.Distributor.Lines = New String(-1) {}
        Me.Distributor.Location = New System.Drawing.Point(309, 150)
        Me.Distributor.MaxLength = 32767
        Me.Distributor.Name = "Distributor"
        Me.Distributor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Distributor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Distributor.SelectedText = ""
        Me.Distributor.SelectionLength = 0
        Me.Distributor.SelectionStart = 0
        Me.Distributor.Size = New System.Drawing.Size(159, 23)
        Me.Distributor.TabIndex = 18
        Me.Distributor.UseSelectable = True
        Me.Distributor.WaterMark = "Enter Distributor name"
        Me.Distributor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Distributor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Datagridview1
        '
        Me.Datagridview1.AllowUserToResizeRows = False
        Me.Datagridview1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridview1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Datagridview1.EnableHeadersVisualStyles = False
        Me.Datagridview1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Datagridview1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Datagridview1.Location = New System.Drawing.Point(487, 106)
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Datagridview1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview1.Size = New System.Drawing.Size(484, 233)
        Me.Datagridview1.TabIndex = 19
        Me.Datagridview1.UseCustomBackColor = True
        Me.Datagridview1.UseCustomForeColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(476, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 43)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'distreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.Datagridview1)
        Me.Controls.Add(Me.Place)
        Me.Controls.Add(Me.Distributor)
        Me.Controls.Add(Me.Contact)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Dist_idLabel)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(DistributorLabel)
        Me.Controls.Add(PlaceLabel)
        Me.Controls.Add(Contact_noLabel)
        Me.Controls.Add(Email_idLabel)
        Me.Name = "distreg"
        Me.Text = resources.GetString("$this.Text")
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DistributorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents Email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Contact As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Place As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Distributor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Datagridview1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
