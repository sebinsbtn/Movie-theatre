<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TICKETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.TICKETToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(902, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        Me.FILEToolStripMenuItem.ToolTipText = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeThemeToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        Me.EDITToolStripMenuItem.ToolTipText = "Edit"
        '
        'ChangeThemeToolStripMenuItem
        '
        Me.ChangeThemeToolStripMenuItem.Name = "ChangeThemeToolStripMenuItem"
        Me.ChangeThemeToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangeThemeToolStripMenuItem.Text = "Change theme"
        Me.ChangeThemeToolStripMenuItem.ToolTipText = "Change background theme"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change password"
        '
        'TICKETToolStripMenuItem
        '
        Me.TICKETToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservationToolStripMenuItem, Me.NormalToolStripMenuItem})
        Me.TICKETToolStripMenuItem.Name = "TICKETToolStripMenuItem"
        Me.TICKETToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.TICKETToolStripMenuItem.Text = "TICKET"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.AutoSize = True
        Me.MetroTile1.BackColor = System.Drawing.Color.Transparent
        Me.MetroTile1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile1.Location = New System.Drawing.Point(72, 149)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(228, 165)
        Me.MetroTile1.TabIndex = 11
        Me.MetroTile1.Text = "RESERVATION"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile1.TileImage = Global.Movietheatre.My.Resources.Resources.hollywood_ticket
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroToolTip1.SetToolTip(Me.MetroTile1, "Ticket reservation")
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseCustomForeColor = True
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.AutoSize = True
        Me.MetroTile2.BackColor = System.Drawing.Color.Transparent
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile2.Location = New System.Drawing.Point(355, 149)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(228, 165)
        Me.MetroTile2.TabIndex = 11
        Me.MetroTile2.Text = "Normal Ticket"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile2.TileImage = Global.Movietheatre.My.Resources.Resources.golden_ticket
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroToolTip1.SetToolTip(Me.MetroTile2, "Normal Ticket")
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseCustomForeColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.AutoSize = True
        Me.MetroTile3.BackColor = System.Drawing.Color.Transparent
        Me.MetroTile3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile3.Location = New System.Drawing.Point(645, 149)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(226, 166)
        Me.MetroTile3.TabIndex = 11
        Me.MetroTile3.Text = "Cancel Reservation "
        Me.MetroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile3.TileImage = Global.Movietheatre.My.Resources.Resources.cancel1
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroToolTip1.SetToolTip(Me.MetroTile3, "Cancel bookings")
        Me.MetroTile3.UseCustomBackColor = True
        Me.MetroTile3.UseCustomForeColor = True
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.AutoSize = True
        Me.MetroTile4.BackColor = System.Drawing.Color.Transparent
        Me.MetroTile4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile4.Location = New System.Drawing.Point(645, 354)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(226, 175)
        Me.MetroTile4.TabIndex = 11
        Me.MetroTile4.Text = "Logout"
        Me.MetroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile4.TileImage = Global.Movietheatre.My.Resources.Resources.gnome_panel_force_quit
        Me.MetroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.UseCustomBackColor = True
        Me.MetroTile4.UseCustomForeColor = True
        Me.MetroTile4.UseSelectable = True
        Me.MetroTile4.UseTileImage = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.AutoSize = True
        Me.MetroTile5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile5.Location = New System.Drawing.Point(72, 356)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(228, 173)
        Me.MetroTile5.TabIndex = 12
        Me.MetroTile5.Text = "View Show Details"
        Me.MetroTile5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile5.TileImage = Global.Movietheatre.My.Resources.Resources._5cc128aba7c93f8de23dbd109092827231
        Me.MetroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile5.UseCustomBackColor = True
        Me.MetroTile5.UseCustomForeColor = True
        Me.MetroTile5.UseSelectable = True
        Me.MetroTile5.UseTileImage = True
        '
        'MetroTile6
        '
        Me.MetroTile6.ActiveControl = Nothing
        Me.MetroTile6.Location = New System.Drawing.Point(358, 350)
        Me.MetroTile6.Name = "MetroTile6"
        Me.MetroTile6.Size = New System.Drawing.Size(224, 179)
        Me.MetroTile6.TabIndex = 13
        Me.MetroTile6.Text = "Print reservation slip"
        Me.MetroTile6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile6.TileImage = Global.Movietheatre.My.Resources.Resources.printer_icon_396651
        Me.MetroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile6.UseCustomBackColor = True
        Me.MetroTile6.UseCustomForeColor = True
        Me.MetroTile6.UseSelectable = True
        Me.MetroTile6.UseTileImage = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Movietheatre.My.Resources.Resources.untitled
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 574)
        Me.Controls.Add(Me.MetroTile6)
        Me.Controls.Add(Me.MetroTile5)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Operator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TICKETToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents ChangeThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
