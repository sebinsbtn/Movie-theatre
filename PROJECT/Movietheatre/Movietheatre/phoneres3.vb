Imports System.Data.OleDb
Public Class phoneres3

    Dim rdr As OleDbDataReader = Nothing
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim ck As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE.accdb;Jet OLEDB:Database Password=123654789;Persist Security Info=true;"
    Public stime As Date = #5:30:00 PM#
    Dim bprice As Integer
    Dim fprice As Integer
    Dim sprice As Integer
    Dim balcony As Integer = 0
    Dim first As Integer = 0
    Dim second As Integer = 0

    Private Sub ticketres_Load(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged, Me.Load
        If DateTimePicker1.Text = Today And stime < TimeOfDay Then

            MessageBox.Show("Cancellation closed !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub

        Else
            Me.Cursor = Cursors.WaitCursor
            Dim rdrr As OleDbDataReader = Nothing
            Dim comd As OleDbCommand = Nothing
            Dim rdrr1 As OleDbDataReader = Nothing
            Dim comd1 As OleDbCommand = Nothing

            con = New OleDbConnection(ck)
            con.Open()
            Dim str As String = "select * from [price] where [Current date]=#" & DateTimePicker1.Text & "#"

            Dim ctr As String = "select * from [DCR] where [currdate]=#" & DateTimePicker1.Text & "#"

            comd = New OleDbCommand(str)
            comd.Connection = con
            comd1 = New OleDbCommand(ctr)
            comd1.Connection = con
            rdrr1 = comd1.ExecuteReader()
            If rdrr1.Read() Then
                first = rdrr1.GetValue(11)
                second = rdrr1.GetValue(19)
                balcony = rdrr1.GetValue(3)
                MessageBox.Show("Welcome", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            Dim reader As OleDbDataReader = Nothing
            reader = comd.ExecuteReader()
            If reader.Read() Then
                bprice = reader.GetValue(6)
                fprice = reader.GetValue(4)
                sprice = reader.GetValue(5)
                ' MessageBox.Show("Price set", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            con.Close()
            Dim rdr2 As OleDbDataReader = Nothing
            Dim cmd1 As OleDbCommand = Nothing

            Dim rdr3 As OleDbDataReader = Nothing
            Dim cmd2 As OleDbCommand = Nothing
            Dim rdr4 As OleDbDataReader = Nothing
            Dim cmd3 As OleDbCommand = Nothing
            Dim rdr5 As OleDbDataReader = Nothing
            Dim cmd4 As OleDbCommand = Nothing
            Dim rdr6 As OleDbDataReader = Nothing
            Dim cmd5 As OleDbCommand = Nothing
            Dim rdr7 As OleDbDataReader = Nothing
            Dim cmd6 As OleDbCommand = Nothing
            Dim rdr8 As OleDbDataReader = Nothing
            Dim cmd7 As OleDbCommand = Nothing
            Dim rdr9 As OleDbDataReader = Nothing
            Dim cmd8 As OleDbCommand = Nothing
            Dim rdr10 As OleDbDataReader = Nothing
            Dim cmd9 As OleDbCommand = Nothing
            Dim rdr11 As OleDbDataReader = Nothing
            Dim cmd10 As OleDbCommand = Nothing
            Dim rdr12 As OleDbDataReader = Nothing
            Dim cmd11 As OleDbCommand = Nothing
            Dim rdr13 As OleDbDataReader = Nothing
            Dim cmd12 As OleDbCommand = Nothing
            Dim rdr14 As OleDbDataReader = Nothing
            Dim cmd13 As OleDbCommand = Nothing
            Dim rdr15 As OleDbDataReader = Nothing
            Dim cmd14 As OleDbCommand = Nothing
            Dim rdr16 As OleDbDataReader = Nothing
            Dim cmd15 As OleDbCommand = Nothing
            Dim rdr17 As OleDbDataReader = Nothing
            Dim cmd16 As OleDbCommand = Nothing
            Dim rdr18 As OleDbDataReader = Nothing
            Dim cmd17 As OleDbCommand = Nothing
            Dim rdr19 As OleDbDataReader = Nothing
            Dim cmd18 As OleDbCommand = Nothing
            Dim rdr20 As OleDbDataReader = Nothing
            Dim cmd19 As OleDbCommand = Nothing
            Dim rdr21 As OleDbDataReader = Nothing
            Dim cmd20 As OleDbCommand = Nothing
            Dim rdr22 As OleDbDataReader = Nothing
            Dim cmd21 As OleDbCommand = Nothing
            Dim rdr23 As OleDbDataReader = Nothing
            Dim cmd22 As OleDbCommand = Nothing
            Dim rdr24 As OleDbDataReader = Nothing
            Dim cmd23 As OleDbCommand = Nothing
            Dim rdr25 As OleDbDataReader = Nothing
            Dim cmd24 As OleDbCommand = Nothing
            Dim rdr26 As OleDbDataReader = Nothing
            Dim cmd25 As OleDbCommand = Nothing
            Dim rdr27 As OleDbDataReader = Nothing
            Dim cmd26 As OleDbCommand = Nothing
            Dim rdr28 As OleDbDataReader = Nothing
            Dim cmd27 As OleDbCommand = Nothing
            Dim rdr29 As OleDbDataReader = Nothing
            Dim cmd28 As OleDbCommand = Nothing
            Dim rdr30 As OleDbDataReader = Nothing
            Dim cmd29 As OleDbCommand = Nothing
            Dim rdr31 As OleDbDataReader = Nothing
            Dim cmd30 As OleDbCommand = Nothing
            Dim rdr32 As OleDbDataReader = Nothing
            Dim cmd31 As OleDbCommand = Nothing
            Dim rdr33 As OleDbDataReader = Nothing
            Dim cmd32 As OleDbCommand = Nothing
            Dim rdr34 As OleDbDataReader = Nothing
            Dim cmd33 As OleDbCommand = Nothing
            Dim rdr35 As OleDbDataReader = Nothing
            Dim cmd34 As OleDbCommand = Nothing
            Dim rdr36 As OleDbDataReader = Nothing
            Dim cmd35 As OleDbCommand = Nothing
            Dim rdr37 As OleDbDataReader = Nothing
            Dim cmd36 As OleDbCommand = Nothing
            Dim rdr38 As OleDbDataReader = Nothing
            Dim cmd37 As OleDbCommand = Nothing
            Dim rdr39 As OleDbDataReader = Nothing
            Dim cmd38 As OleDbCommand = Nothing
            Dim rdr40 As OleDbDataReader = Nothing
            Dim cmd39 As OleDbCommand = Nothing
            Dim rdr41 As OleDbDataReader = Nothing
            Dim cmd40 As OleDbCommand = Nothing
            Dim rdr42 As OleDbDataReader = Nothing
            Dim cmd41 As OleDbCommand = Nothing
            Dim rdr43 As OleDbDataReader = Nothing
            Dim cmd42 As OleDbCommand = Nothing
            Dim rdr44 As OleDbDataReader = Nothing
            Dim cmd43 As OleDbCommand = Nothing
            Dim rdr45 As OleDbDataReader = Nothing
            Dim cmd44 As OleDbCommand = Nothing
            Dim rdr46 As OleDbDataReader = Nothing
            Dim cmd45 As OleDbCommand = Nothing
            Dim rdr47 As OleDbDataReader = Nothing
            Dim cmd46 As OleDbCommand = Nothing
            Dim rdr48 As OleDbDataReader = Nothing
            Dim cmd47 As OleDbCommand = Nothing
            Dim rdr49 As OleDbDataReader = Nothing
            Dim cmd48 As OleDbCommand = Nothing
            Dim rdr50 As OleDbDataReader = Nothing
            Dim cmd49 As OleDbCommand = Nothing
            Dim rdr51 As OleDbDataReader = Nothing
            Dim cmd50 As OleDbCommand = Nothing
            Dim rdr52 As OleDbDataReader = Nothing
            Dim cmd51 As OleDbCommand = Nothing
            Dim rdr53 As OleDbDataReader = Nothing
            Dim cmd52 As OleDbCommand = Nothing
            Dim rdr54 As OleDbDataReader = Nothing
            Dim cmd53 As OleDbCommand = Nothing
            Dim rdr55 As OleDbDataReader = Nothing
            Dim cmd54 As OleDbCommand = Nothing
            Dim rdr56 As OleDbDataReader = Nothing
            Dim cmd55 As OleDbCommand = Nothing
            Dim rdr57 As OleDbDataReader = Nothing
            Dim cmd56 As OleDbCommand = Nothing
            Dim rdr58 As OleDbDataReader = Nothing
            Dim cmd57 As OleDbCommand = Nothing
            Dim rdr59 As OleDbDataReader = Nothing
            Dim cmd58 As OleDbCommand = Nothing
            Dim rdr60 As OleDbDataReader = Nothing
            Dim cmd59 As OleDbCommand = Nothing
            Dim rdr61 As OleDbDataReader = Nothing
            Dim cmd60 As OleDbCommand = Nothing
            Dim rdr62 As OleDbDataReader = Nothing
            Dim cmd61 As OleDbCommand = Nothing
            Dim rdr63 As OleDbDataReader = Nothing
            Dim cmd62 As OleDbCommand = Nothing
            Dim rdr64 As OleDbDataReader = Nothing
            Dim cmd63 As OleDbCommand = Nothing
            Dim rdr65 As OleDbDataReader = Nothing
            Dim cmd64 As OleDbCommand = Nothing
            Dim rdr66 As OleDbDataReader = Nothing
            Dim cmd65 As OleDbCommand = Nothing
            Dim rdr67 As OleDbDataReader = Nothing
            Dim cmd66 As OleDbCommand = Nothing
            Dim rdr68 As OleDbDataReader = Nothing
            Dim cmd67 As OleDbCommand = Nothing
            Dim rdr69 As OleDbDataReader = Nothing
            Dim cmd68 As OleDbCommand = Nothing
            Dim rdr70 As OleDbDataReader = Nothing
            Dim cmd69 As OleDbCommand = Nothing
            Dim rdr71 As OleDbDataReader = Nothing
            Dim cmd70 As OleDbCommand = Nothing
            Dim rdr72 As OleDbDataReader = Nothing
            Dim cmd71 As OleDbCommand = Nothing
            Dim rdr73 As OleDbDataReader = Nothing
            Dim cmd72 As OleDbCommand = Nothing
            Dim rdr74 As OleDbDataReader = Nothing
            Dim cmd73 As OleDbCommand = Nothing
            Dim rdr75 As OleDbDataReader = Nothing
            Dim cmd74 As OleDbCommand = Nothing
            Dim rdr76 As OleDbDataReader = Nothing
            Dim cmd75 As OleDbCommand = Nothing
            Dim rdr77 As OleDbDataReader = Nothing
            Dim cmd76 As OleDbCommand = Nothing
            Dim rdr78 As OleDbDataReader = Nothing
            Dim cmd77 As OleDbCommand = Nothing
            Dim rdr79 As OleDbDataReader = Nothing
            Dim cmd78 As OleDbCommand = Nothing
            Dim rdr80 As OleDbDataReader = Nothing
            Dim cmd79 As OleDbCommand = Nothing
            Dim rdr81 As OleDbDataReader = Nothing
            Dim cmd80 As OleDbCommand = Nothing
            Dim rdr82 As OleDbDataReader = Nothing
            Dim cmd81 As OleDbCommand = Nothing
            Dim rdr83 As OleDbDataReader = Nothing
            Dim cmd82 As OleDbCommand = Nothing
            Dim rdr84 As OleDbDataReader = Nothing
            Dim cmd83 As OleDbCommand = Nothing
            Dim rdr85 As OleDbDataReader = Nothing
            Dim cmd84 As OleDbCommand = Nothing
            Dim rdr86 As OleDbDataReader = Nothing
            Dim cmd85 As OleDbCommand = Nothing
            Dim rdr87 As OleDbDataReader = Nothing
            Dim cmd86 As OleDbCommand = Nothing
            Dim rdr88 As OleDbDataReader = Nothing
            Dim cmd87 As OleDbCommand = Nothing
            Dim rdr89 As OleDbDataReader = Nothing
            Dim cmd88 As OleDbCommand = Nothing
            Dim rdr90 As OleDbDataReader = Nothing
            Dim cmd89 As OleDbCommand = Nothing
            Dim rdr91 As OleDbDataReader = Nothing
            Dim cmd90 As OleDbCommand = Nothing
            Dim rdr92 As OleDbDataReader = Nothing
            Dim cmd91 As OleDbCommand = Nothing
            Dim rdr93 As OleDbDataReader = Nothing
            Dim cmd92 As OleDbCommand = Nothing
            Dim rdr94 As OleDbDataReader = Nothing
            Dim cmd93 As OleDbCommand = Nothing
            Dim rdr95 As OleDbDataReader = Nothing
            Dim cmd94 As OleDbCommand = Nothing
            Dim rdr96 As OleDbDataReader = Nothing
            Dim cmd95 As OleDbCommand = Nothing
            Dim rdr97 As OleDbDataReader = Nothing
            Dim cmd96 As OleDbCommand = Nothing
            Dim rdr98 As OleDbDataReader = Nothing
            Dim cmd97 As OleDbCommand = Nothing
            Dim rdr99 As OleDbDataReader = Nothing
            Dim cmd98 As OleDbCommand = Nothing
            Dim rdr100 As OleDbDataReader = Nothing
            Dim cmd99 As OleDbCommand = Nothing
            Dim rdr101 As OleDbDataReader = Nothing
            Dim cmd100 As OleDbCommand = Nothing
            Dim rdr102 As OleDbDataReader = Nothing
            Dim cmd101 As OleDbCommand = Nothing
            Dim rdr103 As OleDbDataReader = Nothing
            Dim cmd102 As OleDbCommand = Nothing
            Dim rdr104 As OleDbDataReader = Nothing
            Dim cmd103 As OleDbCommand = Nothing
            Dim rdr105 As OleDbDataReader = Nothing
            Dim cmd104 As OleDbCommand = Nothing
            Dim rdr106 As OleDbDataReader = Nothing
            Dim cmd105 As OleDbCommand = Nothing
            Dim rdr107 As OleDbDataReader = Nothing
            Dim cmd106 As OleDbCommand = Nothing
            Dim rdr108 As OleDbDataReader = Nothing
            Dim cmd107 As OleDbCommand = Nothing
            Dim rdr109 As OleDbDataReader = Nothing
            Dim cmd108 As OleDbCommand = Nothing
            Dim rdr110 As OleDbDataReader = Nothing
            Dim cmd109 As OleDbCommand = Nothing
            Dim rdr111 As OleDbDataReader = Nothing
            Dim cmd110 As OleDbCommand = Nothing
            Dim rdr112 As OleDbDataReader = Nothing
            Dim cmd111 As OleDbCommand = Nothing
            Dim rdr113 As OleDbDataReader = Nothing
            Dim cmd112 As OleDbCommand = Nothing
            Dim rdr114 As OleDbDataReader = Nothing
            Dim cmd113 As OleDbCommand = Nothing
            Dim rdr115 As OleDbDataReader = Nothing
            Dim cmd114 As OleDbCommand = Nothing
            Dim rdr116 As OleDbDataReader = Nothing
            Dim cmd115 As OleDbCommand = Nothing
            Dim rdr117 As OleDbDataReader = Nothing
            Dim cmd116 As OleDbCommand = Nothing
            Dim rdr118 As OleDbDataReader = Nothing
            Dim cmd117 As OleDbCommand = Nothing
            Dim rdr119 As OleDbDataReader = Nothing
            Dim cmd118 As OleDbCommand = Nothing
            Dim rdr120 As OleDbDataReader = Nothing
            Dim cmd119 As OleDbCommand = Nothing
            Dim rdr121 As OleDbDataReader = Nothing
            Dim cmd120 As OleDbCommand = Nothing
            Dim rdr122 As OleDbDataReader = Nothing
            Dim cmd121 As OleDbCommand = Nothing
            Dim rdr123 As OleDbDataReader = Nothing
            Dim cmd122 As OleDbCommand = Nothing
            Dim rdr124 As OleDbDataReader = Nothing
            Dim cmd123 As OleDbCommand = Nothing
            Dim rdr125 As OleDbDataReader = Nothing
            Dim cmd124 As OleDbCommand = Nothing
            Dim rdr126 As OleDbDataReader = Nothing
            Dim cmd125 As OleDbCommand = Nothing
            Dim rdr127 As OleDbDataReader = Nothing
            Dim cmd126 As OleDbCommand = Nothing
            Dim rdr128 As OleDbDataReader = Nothing
            Dim cmd127 As OleDbCommand = Nothing
            Dim rdr129 As OleDbDataReader = Nothing
            Dim cmd128 As OleDbCommand = Nothing
            Dim rdr130 As OleDbDataReader = Nothing
            Dim cmd129 As OleDbCommand = Nothing
            Dim rdr131 As OleDbDataReader = Nothing
            Dim cmd130 As OleDbCommand = Nothing
            Dim rdr132 As OleDbDataReader = Nothing
            Dim cmd131 As OleDbCommand = Nothing
            Dim rdr133 As OleDbDataReader = Nothing
            Dim cmd132 As OleDbCommand = Nothing
            Dim rdr134 As OleDbDataReader = Nothing
            Dim cmd133 As OleDbCommand = Nothing
            Dim rdr135 As OleDbDataReader = Nothing
            Dim cmd134 As OleDbCommand = Nothing
            Dim rdr136 As OleDbDataReader = Nothing
            Dim cmd135 As OleDbCommand = Nothing
            Dim rdr137 As OleDbDataReader = Nothing
            Dim cmd136 As OleDbCommand = Nothing
            Dim rdr138 As OleDbDataReader = Nothing
            Dim cmd137 As OleDbCommand = Nothing
            Dim rdr139 As OleDbDataReader = Nothing
            Dim cmd138 As OleDbCommand = Nothing
            Dim rdr140 As OleDbDataReader = Nothing
            Dim cmd139 As OleDbCommand = Nothing
            Dim rdr141 As OleDbDataReader = Nothing
            Dim cmd140 As OleDbCommand = Nothing
            Dim rdr142 As OleDbDataReader = Nothing
            Dim cmd141 As OleDbCommand = Nothing
            Dim rdr143 As OleDbDataReader = Nothing
            Dim cmd142 As OleDbCommand = Nothing
            Dim rdr144 As OleDbDataReader = Nothing
            Dim cmd143 As OleDbCommand = Nothing
            Dim rdr145 As OleDbDataReader = Nothing
            Dim cmd144 As OleDbCommand = Nothing
            Dim rdr146 As OleDbDataReader = Nothing
            Dim cmd145 As OleDbCommand = Nothing
            Dim rdr147 As OleDbDataReader = Nothing
            Dim cmd146 As OleDbCommand = Nothing
            Dim rdr148 As OleDbDataReader = Nothing
            Dim cmd147 As OleDbCommand = Nothing
            Dim rdr149 As OleDbDataReader = Nothing
            Dim cmd148 As OleDbCommand = Nothing
            Dim rdr150 As OleDbDataReader = Nothing
            Dim cmd149 As OleDbCommand = Nothing
            Dim rdr151 As OleDbDataReader = Nothing
            Dim cmd150 As OleDbCommand = Nothing
            Dim rdr152 As OleDbDataReader = Nothing
            Dim cmd151 As OleDbCommand = Nothing
            Dim rdr153 As OleDbDataReader = Nothing
            Dim cmd152 As OleDbCommand = Nothing
            Dim rdr154 As OleDbDataReader = Nothing
            Dim cmd153 As OleDbCommand = Nothing
            Dim rdr155 As OleDbDataReader = Nothing
            Dim cmd154 As OleDbCommand = Nothing
            Dim rdr156 As OleDbDataReader = Nothing
            Dim cmd155 As OleDbCommand = Nothing
            Dim rdr157 As OleDbDataReader = Nothing
            Dim cmd156 As OleDbCommand = Nothing
            Dim rdr158 As OleDbDataReader = Nothing
            Dim cmd157 As OleDbCommand = Nothing
            Dim rdr159 As OleDbDataReader = Nothing
            Dim cmd158 As OleDbCommand = Nothing
            Dim rdr160 As OleDbDataReader = Nothing
            Dim cmd159 As OleDbCommand = Nothing
            Dim rdr161 As OleDbDataReader = Nothing
            Dim cmd160 As OleDbCommand = Nothing
            Dim rdr162 As OleDbDataReader = Nothing
            Dim cmd161 As OleDbCommand = Nothing
            Dim rdr163 As OleDbDataReader = Nothing
            Dim cmd162 As OleDbCommand = Nothing
            Dim rdr164 As OleDbDataReader = Nothing
            Dim cmd163 As OleDbCommand = Nothing
            Dim rdr165 As OleDbDataReader = Nothing
            Dim cmd164 As OleDbCommand = Nothing
            Dim rdr166 As OleDbDataReader = Nothing
            Dim cmd165 As OleDbCommand = Nothing
            Dim rdr167 As OleDbDataReader = Nothing
            Dim cmd166 As OleDbCommand = Nothing
            Dim rdr168 As OleDbDataReader = Nothing
            Dim cmd167 As OleDbCommand = Nothing
            Dim rdr169 As OleDbDataReader = Nothing
            Dim cmd168 As OleDbCommand = Nothing
            Dim rdr170 As OleDbDataReader = Nothing
            Dim cmd169 As OleDbCommand = Nothing
            Dim rdr171 As OleDbDataReader = Nothing
            Dim cmd170 As OleDbCommand = Nothing
            Dim rdr172 As OleDbDataReader = Nothing
            Dim cmd171 As OleDbCommand = Nothing
            Dim rdr173 As OleDbDataReader = Nothing
            Dim cmd172 As OleDbCommand = Nothing
            Dim rdr174 As OleDbDataReader = Nothing
            Dim cmd173 As OleDbCommand = Nothing
            Dim rdr175 As OleDbDataReader = Nothing
            Dim cmd174 As OleDbCommand = Nothing
            Dim rdr176 As OleDbDataReader = Nothing
            Dim cmd175 As OleDbCommand = Nothing
            Dim rdr177 As OleDbDataReader = Nothing
            Dim cmd176 As OleDbCommand = Nothing
            Dim rdr178 As OleDbDataReader = Nothing
            Dim cmd177 As OleDbCommand = Nothing
            Dim rdr179 As OleDbDataReader = Nothing
            Dim cmd178 As OleDbCommand = Nothing
            Dim rdr180 As OleDbDataReader = Nothing
            Dim cmd179 As OleDbCommand = Nothing
            Dim rdr181 As OleDbDataReader = Nothing
            Dim cmd180 As OleDbCommand = Nothing
            Dim rdr182 As OleDbDataReader = Nothing
            Dim cmd181 As OleDbCommand = Nothing
            Dim rdr183 As OleDbDataReader = Nothing
            Dim cmd182 As OleDbCommand = Nothing
            Dim rdr184 As OleDbDataReader = Nothing
            Dim cmd183 As OleDbCommand = Nothing
            Dim rdr185 As OleDbDataReader = Nothing
            Dim cmd184 As OleDbCommand = Nothing
            Dim rdr186 As OleDbDataReader = Nothing
            Dim cmd185 As OleDbCommand = Nothing
            Dim rdr187 As OleDbDataReader = Nothing
            Dim cmd186 As OleDbCommand = Nothing
            Dim rdr188 As OleDbDataReader = Nothing
            Dim cmd187 As OleDbCommand = Nothing
            Dim rdr189 As OleDbDataReader = Nothing
            Dim cmd188 As OleDbCommand = Nothing
            Dim rdr190 As OleDbDataReader = Nothing
            Dim cmd189 As OleDbCommand = Nothing
            Dim rdr191 As OleDbDataReader = Nothing
            Dim cmd190 As OleDbCommand = Nothing
            Dim rdr192 As OleDbDataReader = Nothing
            Dim cmd191 As OleDbCommand = Nothing
            Dim rdr193 As OleDbDataReader = Nothing
            Dim cmd192 As OleDbCommand = Nothing
            Dim rdr194 As OleDbDataReader = Nothing
            Dim cmd193 As OleDbCommand = Nothing
            Dim rdr195 As OleDbDataReader = Nothing
            Dim cmd194 As OleDbCommand = Nothing
            Dim rdr196 As OleDbDataReader = Nothing
            Dim cmd195 As OleDbCommand = Nothing
            Dim rdr197 As OleDbDataReader = Nothing
            Dim cmd196 As OleDbCommand = Nothing
            Dim rdr198 As OleDbDataReader = Nothing
            Dim cmd197 As OleDbCommand = Nothing
            Dim rdr199 As OleDbDataReader = Nothing
            Dim cmd198 As OleDbCommand = Nothing
            Dim rdr200 As OleDbDataReader = Nothing
            Dim cmd199 As OleDbCommand = Nothing
            con.Open()
            Dim ct As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f1]= -1 "
            Dim ct1 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f2]= -1 "
            Dim ct2 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f3]= -1 "
            Dim ct3 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f4]= -1 "
            Dim ct4 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f5]= -1 "
            Dim ct5 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f6]= -1 "
            Dim ct6 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f7]= -1 "
            Dim ct7 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f8]= -1 "
            Dim ct8 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f9]= -1 "
            Dim ct9 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f10]= -1 "
            Dim ct10 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f11]= -1 "
            Dim ct11 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f12]= -1 "
            Dim ct12 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f13]= -1 "
            Dim ct13 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f14]= -1 "
            Dim ct14 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f15]= -1 "
            Dim ct15 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f16]= -1 "
            Dim ct16 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f17]= -1 "
            Dim ct17 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f18]= -1 "
            Dim ct18 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f19]= -1 "
            Dim ct19 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f20]= -1 "
            Dim ct20 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f21]= -1 "
            Dim ct21 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f22]= -1 "
            Dim ct22 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f23]= -1 "
            Dim ct23 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f24]= -1 "
            Dim ct24 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f25]= -1 "
            Dim ct25 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f26]= -1 "
            Dim ct26 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f27]= -1 "
            Dim ct27 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f28]= -1 "
            Dim ct28 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f29]= -1 "
            Dim ct29 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f30]= -1 "
            Dim ct30 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f31]= -1 "
            Dim ct31 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f32]= -1 "
            Dim ct32 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f33]= -1 "
            Dim ct33 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f34]= -1 "
            Dim ct34 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f35]= -1 "
            Dim ct35 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f36]= -1 "
            Dim ct36 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f37]= -1 "
            Dim ct37 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f38]= -1 "
            Dim ct38 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f39]= -1 "
            Dim ct39 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f40]= -1 "
            Dim ct40 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f41]= -1 "
            Dim ct41 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f42]= -1 "
            Dim ct42 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f43]= -1 "
            Dim ct43 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f44]= -1 "
            Dim ct44 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f45]= -1 "
            Dim ct45 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f46]= -1 "
            Dim ct46 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f47]= -1 "
            Dim ct47 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f48]= -1 "
            Dim ct48 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f49]= -1 "
            Dim ct49 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f50]= -1 "
            Dim ct50 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f51]= -1 "
            Dim ct51 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f52]= -1 "
            Dim ct52 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f53]= -1 "
            Dim ct53 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f54]= -1 "
            Dim ct54 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f55]= -1 "
            Dim ct55 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f56]= -1 "
            Dim ct56 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f57]= -1 "
            Dim ct57 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f58]= -1 "
            Dim ct58 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f59]= -1 "
            Dim ct59 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f60]= -1 "
            Dim ct60 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f61]= -1 "
            Dim ct61 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f62]= -1 "
            Dim ct62 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f63]= -1 "
            Dim ct63 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f64]= -1 "
            Dim ct64 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f65]= -1 "
            Dim ct65 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f66]= -1 "
            Dim ct66 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f67]= -1 "
            Dim ct67 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f68]= -1 "
            Dim ct68 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f69]= -1 "
            Dim ct69 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f70]= -1 "
            Dim ct70 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f71]= -1 "
            Dim ct71 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f72]= -1 "
            Dim ct72 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f73]= -1 "
            Dim ct73 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f74]= -1 "
            Dim ct74 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f75]= -1 "
            Dim ct75 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f76]= -1 "
            Dim ct76 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f77]= -1 "
            Dim ct77 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f78]= -1 "
            Dim ct78 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f79]= -1 "
            Dim ct79 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f80]= -1 "
            Dim ct80 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f81]= -1 "
            Dim ct81 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f82]= -1 "
            Dim ct82 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f83]= -1 "
            Dim ct83 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f84]= -1 "
            Dim ct84 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f85]= -1 "
            Dim ct85 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f86]= -1 "
            Dim ct86 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f87]= -1 "
            Dim ct87 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f88]= -1 "
            Dim ct88 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f89]= -1 "
            Dim ct89 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f90]= -1 "
            Dim ct90 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f91]= -1 "
            Dim ct91 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f92]= -1 "
            Dim ct92 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f93]= -1 "
            Dim ct93 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f94]= -1 "
            Dim ct94 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f95]= -1 "
            Dim ct95 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f96]= -1 "
            Dim ct96 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f97]= -1 "
            Dim ct97 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f98]= -1 "
            Dim ct98 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f99]= -1 "
            Dim ct99 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f100]= -1 "
            Dim ct100 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f101]= -1 "
            Dim ct101 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f102]= -1 "
            Dim ct102 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f103]= -1 "
            Dim ct103 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f104]= -1 "
            Dim ct104 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f105]= -1 "
            Dim ct105 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f106]= -1 "
            Dim ct106 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f107]= -1 "
            Dim ct107 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f108]= -1 "
            Dim ct108 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f109]= -1 "
            Dim ct109 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f110]= -1 "
            Dim ct110 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f111]= -1 "
            Dim ct111 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [f112]= -1 "
            Dim ct112 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s1]= -1 "
            Dim ct113 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s2]= -1 "
            Dim ct114 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s3]= -1 "
            Dim ct115 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s4]= -1 "
            Dim ct116 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s5]= -1 "
            Dim ct117 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s6]= -1 "
            Dim ct118 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s7]= -1 "
            Dim ct119 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s8]= -1 "
            Dim ct120 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s9]= -1 "
            Dim ct121 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s10]= -1 "
            Dim ct122 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s11]= -1 "
            Dim ct123 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s12]= -1 "
            Dim ct124 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s13]= -1 "
            Dim ct125 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s14]= -1 "
            Dim ct126 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s15]= -1 "
            Dim ct127 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s16]= -1 "
            Dim ct128 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s17]= -1 "
            Dim ct129 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s18]= -1 "
            Dim ct130 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s19]= -1 "
            Dim ct131 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s20]= -1 "
            Dim ct132 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s21]= -1 "
            Dim ct133 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s22]= -1 "
            Dim ct134 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s23]= -1 "
            Dim ct135 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s24]= -1 "
            Dim ct136 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s25]= -1 "
            Dim ct137 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s26]= -1 "
            Dim ct138 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s27]= -1 "
            Dim ct139 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s28]= -1 "
            Dim ct140 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s29]= -1 "
            Dim ct141 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s30]= -1 "
            Dim ct142 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s31]= -1 "
            Dim ct143 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s32]= -1 "
            Dim ct144 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s33]= -1 "
            Dim ct145 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s34]= -1 "
            Dim ct146 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s35]= -1 "
            Dim ct147 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s36]= -1 "
            Dim ct148 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s37]= -1 "
            Dim ct149 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s38]= -1 "
            Dim ct150 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s39]= -1 "
            Dim ct151 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s40]= -1 "
            Dim ct152 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s41]= -1 "
            Dim ct153 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s42]= -1 "
            Dim ct154 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s43]= -1 "
            Dim ct155 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s44]= -1 "
            Dim ct156 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s45]= -1 "
            Dim ct157 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s46]= -1 "
            Dim ct158 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s47]= -1 "
            Dim ct159 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [s48]= -1 "
            Dim ct160 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b1]= -1 "
            Dim ct161 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b2]= -1 "
            Dim ct162 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b3]= -1 "
            Dim ct163 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b4]= -1 "
            Dim ct164 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b5]= -1 "
            Dim ct165 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b6]= -1 "
            Dim ct166 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b7]= -1 "
            Dim ct167 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b8]= -1 "
            Dim ct168 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b9]= -1 "
            Dim ct169 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b10]= -1 "
            Dim ct170 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b11]= -1 "
            Dim ct171 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b12]= -1 "
            Dim ct172 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b13]= -1 "
            Dim ct173 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b14]= -1 "
            Dim ct174 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b15]= -1 "
            Dim ct175 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b16]= -1 "
            Dim ct176 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b17]= -1 "
            Dim ct177 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b18]= -1 "
            Dim ct178 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b19]= -1 "
            Dim ct179 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b20]= -1 "
            Dim ct180 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b21]= -1 "
            Dim ct181 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b22]= -1 "
            Dim ct182 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b23]= -1 "
            Dim ct183 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b24]= -1 "
            Dim ct184 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b25]= -1 "
            Dim ct185 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b26]= -1 "
            Dim ct186 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b27]= -1 "
            Dim ct187 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b28]= -1 "
            Dim ct188 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b29]= -1 "
            Dim ct189 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b30]= -1 "
            Dim ct190 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b31]= -1 "
            Dim ct191 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b32]= -1 "
            Dim ct192 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b33]= -1 "
            Dim ct193 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b34]= -1 "
            Dim ct194 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b35]= -1 "
            Dim ct195 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b36]= -1 "
            Dim ct196 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b37]= -1 "
            Dim ct197 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b38]= -1 "
            Dim ct198 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b39]= -1 "
            Dim ct199 As String = "select * from [reservetab3] where resDate=#" & DateTimePicker1.Text & "# AND [b40]= -1 "


            cmd = New OleDbCommand(ct)
            cmd1 = New OleDbCommand(ct1)
            cmd2 = New OleDbCommand(ct2)
            cmd3 = New OleDbCommand(ct3)
            cmd4 = New OleDbCommand(ct4)
            cmd5 = New OleDbCommand(ct5)
            cmd6 = New OleDbCommand(ct6)
            cmd7 = New OleDbCommand(ct7)
            cmd8 = New OleDbCommand(ct8)
            cmd9 = New OleDbCommand(ct9)
            cmd10 = New OleDbCommand(ct10)
            cmd11 = New OleDbCommand(ct11)
            cmd12 = New OleDbCommand(ct12)
            cmd13 = New OleDbCommand(ct13)
            cmd14 = New OleDbCommand(ct14)
            cmd15 = New OleDbCommand(ct15)
            cmd16 = New OleDbCommand(ct16)
            cmd17 = New OleDbCommand(ct17)
            cmd18 = New OleDbCommand(ct18)
            cmd19 = New OleDbCommand(ct19)
            cmd20 = New OleDbCommand(ct20)
            cmd21 = New OleDbCommand(ct21)
            cmd22 = New OleDbCommand(ct22)
            cmd23 = New OleDbCommand(ct23)
            cmd24 = New OleDbCommand(ct24)
            cmd25 = New OleDbCommand(ct25)
            cmd26 = New OleDbCommand(ct26)
            cmd27 = New OleDbCommand(ct27)
            cmd28 = New OleDbCommand(ct28)
            cmd29 = New OleDbCommand(ct29)
            cmd30 = New OleDbCommand(ct30)
            cmd31 = New OleDbCommand(ct31)
            cmd32 = New OleDbCommand(ct32)
            cmd33 = New OleDbCommand(ct33)
            cmd34 = New OleDbCommand(ct34)
            cmd35 = New OleDbCommand(ct35)
            cmd36 = New OleDbCommand(ct36)
            cmd37 = New OleDbCommand(ct37)
            cmd38 = New OleDbCommand(ct38)
            cmd39 = New OleDbCommand(ct39)
            cmd40 = New OleDbCommand(ct40)
            cmd41 = New OleDbCommand(ct41)
            cmd42 = New OleDbCommand(ct42)
            cmd43 = New OleDbCommand(ct43)
            cmd44 = New OleDbCommand(ct44)
            cmd45 = New OleDbCommand(ct45)
            cmd46 = New OleDbCommand(ct46)
            cmd47 = New OleDbCommand(ct47)
            cmd48 = New OleDbCommand(ct48)
            cmd49 = New OleDbCommand(ct49)
            cmd50 = New OleDbCommand(ct50)
            cmd51 = New OleDbCommand(ct51)
            cmd52 = New OleDbCommand(ct52)
            cmd53 = New OleDbCommand(ct53)
            cmd54 = New OleDbCommand(ct54)
            cmd55 = New OleDbCommand(ct55)
            cmd56 = New OleDbCommand(ct56)
            cmd57 = New OleDbCommand(ct57)
            cmd58 = New OleDbCommand(ct58)
            cmd59 = New OleDbCommand(ct59)
            cmd60 = New OleDbCommand(ct60)
            cmd61 = New OleDbCommand(ct61)
            cmd62 = New OleDbCommand(ct62)
            cmd63 = New OleDbCommand(ct63)
            cmd64 = New OleDbCommand(ct64)
            cmd65 = New OleDbCommand(ct65)
            cmd66 = New OleDbCommand(ct66)
            cmd67 = New OleDbCommand(ct67)
            cmd68 = New OleDbCommand(ct68)
            cmd69 = New OleDbCommand(ct69)
            cmd70 = New OleDbCommand(ct70)
            cmd71 = New OleDbCommand(ct71)
            cmd72 = New OleDbCommand(ct72)
            cmd73 = New OleDbCommand(ct73)
            cmd74 = New OleDbCommand(ct74)
            cmd75 = New OleDbCommand(ct75)
            cmd76 = New OleDbCommand(ct76)
            cmd77 = New OleDbCommand(ct77)
            cmd78 = New OleDbCommand(ct78)
            cmd79 = New OleDbCommand(ct79)
            cmd80 = New OleDbCommand(ct80)
            cmd81 = New OleDbCommand(ct81)
            cmd82 = New OleDbCommand(ct82)
            cmd83 = New OleDbCommand(ct83)
            cmd84 = New OleDbCommand(ct84)
            cmd85 = New OleDbCommand(ct85)
            cmd86 = New OleDbCommand(ct86)
            cmd87 = New OleDbCommand(ct87)
            cmd88 = New OleDbCommand(ct88)
            cmd89 = New OleDbCommand(ct89)
            cmd90 = New OleDbCommand(ct90)
            cmd91 = New OleDbCommand(ct91)
            cmd92 = New OleDbCommand(ct92)
            cmd93 = New OleDbCommand(ct93)
            cmd94 = New OleDbCommand(ct94)
            cmd95 = New OleDbCommand(ct95)
            cmd96 = New OleDbCommand(ct96)
            cmd97 = New OleDbCommand(ct97)
            cmd98 = New OleDbCommand(ct98)
            cmd99 = New OleDbCommand(ct99)
            cmd100 = New OleDbCommand(ct100)
            cmd101 = New OleDbCommand(ct101)
            cmd102 = New OleDbCommand(ct102)
            cmd103 = New OleDbCommand(ct103)
            cmd104 = New OleDbCommand(ct104)
            cmd105 = New OleDbCommand(ct105)
            cmd106 = New OleDbCommand(ct106)
            cmd107 = New OleDbCommand(ct107)
            cmd108 = New OleDbCommand(ct108)
            cmd109 = New OleDbCommand(ct109)
            cmd110 = New OleDbCommand(ct110)
            cmd111 = New OleDbCommand(ct111)
            cmd112 = New OleDbCommand(ct112)
            cmd113 = New OleDbCommand(ct113)
            cmd114 = New OleDbCommand(ct114)
            cmd115 = New OleDbCommand(ct115)
            cmd116 = New OleDbCommand(ct116)
            cmd117 = New OleDbCommand(ct117)
            cmd118 = New OleDbCommand(ct118)
            cmd119 = New OleDbCommand(ct119)
            cmd120 = New OleDbCommand(ct120)
            cmd121 = New OleDbCommand(ct121)
            cmd122 = New OleDbCommand(ct122)
            cmd123 = New OleDbCommand(ct123)
            cmd124 = New OleDbCommand(ct124)
            cmd125 = New OleDbCommand(ct125)
            cmd126 = New OleDbCommand(ct126)
            cmd127 = New OleDbCommand(ct127)
            cmd128 = New OleDbCommand(ct128)
            cmd129 = New OleDbCommand(ct129)
            cmd130 = New OleDbCommand(ct130)
            cmd131 = New OleDbCommand(ct131)
            cmd132 = New OleDbCommand(ct132)
            cmd133 = New OleDbCommand(ct133)
            cmd134 = New OleDbCommand(ct134)
            cmd135 = New OleDbCommand(ct135)
            cmd136 = New OleDbCommand(ct136)
            cmd137 = New OleDbCommand(ct137)
            cmd138 = New OleDbCommand(ct138)
            cmd139 = New OleDbCommand(ct139)
            cmd140 = New OleDbCommand(ct140)
            cmd141 = New OleDbCommand(ct141)
            cmd142 = New OleDbCommand(ct142)
            cmd143 = New OleDbCommand(ct143)
            cmd144 = New OleDbCommand(ct144)
            cmd145 = New OleDbCommand(ct145)
            cmd146 = New OleDbCommand(ct146)
            cmd147 = New OleDbCommand(ct147)
            cmd148 = New OleDbCommand(ct148)
            cmd149 = New OleDbCommand(ct149)
            cmd150 = New OleDbCommand(ct150)
            cmd151 = New OleDbCommand(ct151)
            cmd152 = New OleDbCommand(ct152)
            cmd153 = New OleDbCommand(ct153)
            cmd154 = New OleDbCommand(ct154)
            cmd155 = New OleDbCommand(ct155)
            cmd156 = New OleDbCommand(ct156)
            cmd157 = New OleDbCommand(ct157)
            cmd158 = New OleDbCommand(ct158)
            cmd159 = New OleDbCommand(ct159)
            cmd160 = New OleDbCommand(ct160)
            cmd161 = New OleDbCommand(ct161)
            cmd162 = New OleDbCommand(ct162)
            cmd163 = New OleDbCommand(ct163)
            cmd164 = New OleDbCommand(ct164)
            cmd165 = New OleDbCommand(ct165)
            cmd166 = New OleDbCommand(ct166)
            cmd167 = New OleDbCommand(ct167)
            cmd168 = New OleDbCommand(ct168)
            cmd169 = New OleDbCommand(ct169)
            cmd170 = New OleDbCommand(ct170)
            cmd171 = New OleDbCommand(ct171)
            cmd172 = New OleDbCommand(ct172)
            cmd173 = New OleDbCommand(ct173)
            cmd174 = New OleDbCommand(ct174)
            cmd175 = New OleDbCommand(ct175)
            cmd176 = New OleDbCommand(ct176)
            cmd177 = New OleDbCommand(ct177)
            cmd178 = New OleDbCommand(ct178)
            cmd179 = New OleDbCommand(ct179)
            cmd180 = New OleDbCommand(ct180)
            cmd181 = New OleDbCommand(ct181)
            cmd182 = New OleDbCommand(ct182)
            cmd183 = New OleDbCommand(ct183)
            cmd184 = New OleDbCommand(ct184)
            cmd185 = New OleDbCommand(ct185)
            cmd186 = New OleDbCommand(ct186)
            cmd187 = New OleDbCommand(ct187)
            cmd188 = New OleDbCommand(ct188)
            cmd189 = New OleDbCommand(ct189)
            cmd190 = New OleDbCommand(ct190)
            cmd191 = New OleDbCommand(ct191)
            cmd192 = New OleDbCommand(ct192)
            cmd193 = New OleDbCommand(ct193)
            cmd194 = New OleDbCommand(ct194)
            cmd195 = New OleDbCommand(ct195)
            cmd196 = New OleDbCommand(ct196)
            cmd197 = New OleDbCommand(ct197)
            cmd198 = New OleDbCommand(ct198)
            cmd199 = New OleDbCommand(ct199)






            cmd.Connection = con
            cmd1.Connection = con
            cmd2.Connection = con
            cmd3.Connection = con
            cmd4.Connection = con
            cmd5.Connection = con
            cmd6.Connection = con
            cmd7.Connection = con
            cmd8.Connection = con
            cmd9.Connection = con
            cmd10.Connection = con
            cmd11.Connection = con
            cmd12.Connection = con
            cmd13.Connection = con
            cmd14.Connection = con
            cmd15.Connection = con
            cmd16.Connection = con
            cmd17.Connection = con
            cmd18.Connection = con
            cmd19.Connection = con
            cmd20.Connection = con
            cmd21.Connection = con
            cmd22.Connection = con
            cmd23.Connection = con
            cmd24.Connection = con
            cmd25.Connection = con
            cmd26.Connection = con
            cmd27.Connection = con
            cmd28.Connection = con
            cmd29.Connection = con
            cmd30.Connection = con
            cmd31.Connection = con
            cmd32.Connection = con
            cmd33.Connection = con
            cmd34.Connection = con
            cmd35.Connection = con
            cmd36.Connection = con
            cmd37.Connection = con
            cmd38.Connection = con
            cmd39.Connection = con
            cmd40.Connection = con
            cmd41.Connection = con
            cmd42.Connection = con
            cmd43.Connection = con
            cmd44.Connection = con
            cmd45.Connection = con
            cmd46.Connection = con
            cmd47.Connection = con
            cmd48.Connection = con
            cmd49.Connection = con
            cmd50.Connection = con
            cmd51.Connection = con
            cmd52.Connection = con
            cmd53.Connection = con
            cmd54.Connection = con
            cmd55.Connection = con
            cmd56.Connection = con
            cmd57.Connection = con
            cmd58.Connection = con
            cmd59.Connection = con
            cmd60.Connection = con
            cmd61.Connection = con
            cmd62.Connection = con
            cmd63.Connection = con
            cmd64.Connection = con
            cmd65.Connection = con
            cmd66.Connection = con
            cmd67.Connection = con
            cmd68.Connection = con
            cmd69.Connection = con
            cmd70.Connection = con
            cmd71.Connection = con
            cmd72.Connection = con
            cmd73.Connection = con
            cmd74.Connection = con
            cmd75.Connection = con
            cmd76.Connection = con
            cmd77.Connection = con
            cmd78.Connection = con
            cmd79.Connection = con
            cmd80.Connection = con
            cmd81.Connection = con
            cmd82.Connection = con
            cmd83.Connection = con
            cmd84.Connection = con
            cmd86.Connection = con
            cmd85.Connection = con
            cmd87.Connection = con
            cmd88.Connection = con
            cmd89.Connection = con
            cmd90.Connection = con
            cmd91.Connection = con
            cmd92.Connection = con
            cmd93.Connection = con
            cmd94.Connection = con
            cmd95.Connection = con
            cmd96.Connection = con
            cmd97.Connection = con
            cmd98.Connection = con
            cmd99.Connection = con
            cmd100.Connection = con
            cmd101.Connection = con
            cmd102.Connection = con
            cmd103.Connection = con
            cmd104.Connection = con
            cmd105.Connection = con
            cmd106.Connection = con
            cmd107.Connection = con
            cmd108.Connection = con
            cmd109.Connection = con
            cmd110.Connection = con
            cmd111.Connection = con
            cmd112.Connection = con
            cmd113.Connection = con
            cmd114.Connection = con
            cmd115.Connection = con
            cmd116.Connection = con
            cmd117.Connection = con
            cmd118.Connection = con
            cmd119.Connection = con
            cmd120.Connection = con
            cmd121.Connection = con
            cmd122.Connection = con
            cmd123.Connection = con
            cmd124.Connection = con
            cmd125.Connection = con
            cmd126.Connection = con
            cmd127.Connection = con
            cmd128.Connection = con
            cmd129.Connection = con
            cmd130.Connection = con
            cmd131.Connection = con
            cmd132.Connection = con
            cmd133.Connection = con
            cmd134.Connection = con
            cmd135.Connection = con
            cmd136.Connection = con
            cmd137.Connection = con
            cmd138.Connection = con
            cmd139.Connection = con
            cmd140.Connection = con
            cmd141.Connection = con
            cmd142.Connection = con
            cmd143.Connection = con
            cmd144.Connection = con
            cmd145.Connection = con
            cmd146.Connection = con
            cmd147.Connection = con
            cmd148.Connection = con
            cmd149.Connection = con
            cmd150.Connection = con
            cmd151.Connection = con
            cmd152.Connection = con
            cmd153.Connection = con
            cmd155.Connection = con
            cmd154.Connection = con
            cmd156.Connection = con
            cmd157.Connection = con
            cmd158.Connection = con
            cmd159.Connection = con
            cmd161.Connection = con
            cmd160.Connection = con
            cmd162.Connection = con
            cmd163.Connection = con
            cmd164.Connection = con
            cmd165.Connection = con
            cmd166.Connection = con
            cmd167.Connection = con
            cmd168.Connection = con
            cmd169.Connection = con
            cmd170.Connection = con
            cmd171.Connection = con
            cmd172.Connection = con
            cmd173.Connection = con
            cmd174.Connection = con
            cmd175.Connection = con
            cmd176.Connection = con
            cmd177.Connection = con
            cmd178.Connection = con
            cmd179.Connection = con
            cmd180.Connection = con
            cmd181.Connection = con
            cmd182.Connection = con
            cmd183.Connection = con
            cmd184.Connection = con
            cmd185.Connection = con
            cmd186.Connection = con
            cmd187.Connection = con
            cmd188.Connection = con
            cmd189.Connection = con
            cmd190.Connection = con
            cmd191.Connection = con
            cmd192.Connection = con
            cmd193.Connection = con
            cmd194.Connection = con
            cmd195.Connection = con
            cmd196.Connection = con
            cmd197.Connection = con
            cmd198.Connection = con
            cmd199.Connection = con









            rdr = cmd.ExecuteReader
            rdr2 = cmd1.ExecuteReader
            rdr3 = cmd2.ExecuteReader
            rdr4 = cmd3.ExecuteReader
            rdr5 = cmd4.ExecuteReader
            rdr6 = cmd5.ExecuteReader
            rdr7 = cmd6.ExecuteReader
            rdr8 = cmd7.ExecuteReader
            rdr9 = cmd8.ExecuteReader
            rdr10 = cmd9.ExecuteReader
            rdr11 = cmd10.ExecuteReader
            rdr12 = cmd11.ExecuteReader
            rdr13 = cmd12.ExecuteReader
            rdr14 = cmd13.ExecuteReader
            rdr15 = cmd14.ExecuteReader
            rdr16 = cmd15.ExecuteReader
            rdr17 = cmd16.ExecuteReader
            rdr18 = cmd17.ExecuteReader
            rdr19 = cmd18.ExecuteReader
            rdr20 = cmd19.ExecuteReader
            rdr21 = cmd20.ExecuteReader
            rdr22 = cmd21.ExecuteReader
            rdr23 = cmd22.ExecuteReader
            rdr24 = cmd23.ExecuteReader
            rdr25 = cmd24.ExecuteReader
            rdr26 = cmd25.ExecuteReader
            rdr27 = cmd26.ExecuteReader
            rdr28 = cmd27.ExecuteReader
            rdr29 = cmd28.ExecuteReader
            rdr30 = cmd29.ExecuteReader
            rdr31 = cmd30.ExecuteReader
            rdr32 = cmd31.ExecuteReader
            rdr33 = cmd32.ExecuteReader
            rdr34 = cmd33.ExecuteReader
            rdr35 = cmd34.ExecuteReader
            rdr36 = cmd35.ExecuteReader
            rdr37 = cmd36.ExecuteReader
            rdr38 = cmd37.ExecuteReader
            rdr39 = cmd38.ExecuteReader
            rdr40 = cmd39.ExecuteReader
            rdr41 = cmd40.ExecuteReader
            rdr42 = cmd41.ExecuteReader
            rdr43 = cmd42.ExecuteReader
            rdr44 = cmd43.ExecuteReader
            rdr45 = cmd44.ExecuteReader
            rdr46 = cmd45.ExecuteReader
            rdr47 = cmd46.ExecuteReader
            rdr48 = cmd47.ExecuteReader
            rdr49 = cmd48.ExecuteReader
            rdr50 = cmd49.ExecuteReader
            rdr51 = cmd50.ExecuteReader
            rdr52 = cmd51.ExecuteReader
            rdr53 = cmd52.ExecuteReader
            rdr54 = cmd53.ExecuteReader
            rdr55 = cmd54.ExecuteReader
            rdr56 = cmd55.ExecuteReader
            rdr57 = cmd56.ExecuteReader
            rdr58 = cmd57.ExecuteReader
            rdr59 = cmd58.ExecuteReader
            rdr60 = cmd59.ExecuteReader
            rdr61 = cmd60.ExecuteReader
            rdr62 = cmd61.ExecuteReader
            rdr63 = cmd62.ExecuteReader
            rdr64 = cmd63.ExecuteReader
            rdr65 = cmd64.ExecuteReader
            rdr66 = cmd65.ExecuteReader
            rdr67 = cmd66.ExecuteReader
            rdr68 = cmd67.ExecuteReader
            rdr69 = cmd68.ExecuteReader
            rdr70 = cmd69.ExecuteReader
            rdr71 = cmd70.ExecuteReader
            rdr72 = cmd71.ExecuteReader
            rdr73 = cmd72.ExecuteReader
            rdr74 = cmd73.ExecuteReader
            rdr75 = cmd74.ExecuteReader
            rdr76 = cmd75.ExecuteReader
            rdr77 = cmd76.ExecuteReader
            rdr78 = cmd77.ExecuteReader
            rdr79 = cmd78.ExecuteReader
            rdr80 = cmd79.ExecuteReader
            rdr81 = cmd80.ExecuteReader
            rdr82 = cmd81.ExecuteReader
            rdr83 = cmd82.ExecuteReader
            rdr84 = cmd83.ExecuteReader
            rdr85 = cmd84.ExecuteReader
            rdr86 = cmd85.ExecuteReader
            rdr87 = cmd86.ExecuteReader
            rdr88 = cmd87.ExecuteReader
            rdr89 = cmd88.ExecuteReader
            rdr90 = cmd89.ExecuteReader
            rdr91 = cmd90.ExecuteReader
            rdr92 = cmd91.ExecuteReader
            rdr93 = cmd92.ExecuteReader
            rdr94 = cmd93.ExecuteReader
            rdr95 = cmd94.ExecuteReader
            rdr96 = cmd95.ExecuteReader
            rdr97 = cmd96.ExecuteReader
            rdr98 = cmd97.ExecuteReader
            rdr99 = cmd98.ExecuteReader
            rdr100 = cmd99.ExecuteReader
            rdr101 = cmd100.ExecuteReader
            rdr102 = cmd101.ExecuteReader
            rdr103 = cmd102.ExecuteReader
            rdr104 = cmd103.ExecuteReader
            rdr105 = cmd104.ExecuteReader
            rdr106 = cmd105.ExecuteReader
            rdr107 = cmd106.ExecuteReader
            rdr108 = cmd107.ExecuteReader
            rdr109 = cmd108.ExecuteReader
            rdr110 = cmd109.ExecuteReader
            rdr111 = cmd110.ExecuteReader
            rdr112 = cmd111.ExecuteReader
            rdr113 = cmd112.ExecuteReader
            rdr114 = cmd113.ExecuteReader
            rdr115 = cmd114.ExecuteReader
            rdr116 = cmd115.ExecuteReader
            rdr117 = cmd116.ExecuteReader
            rdr118 = cmd117.ExecuteReader
            rdr119 = cmd118.ExecuteReader
            rdr120 = cmd119.ExecuteReader
            rdr121 = cmd120.ExecuteReader
            rdr122 = cmd121.ExecuteReader
            rdr123 = cmd122.ExecuteReader
            rdr124 = cmd123.ExecuteReader
            rdr125 = cmd124.ExecuteReader
            rdr126 = cmd125.ExecuteReader
            rdr127 = cmd126.ExecuteReader
            rdr128 = cmd127.ExecuteReader
            rdr129 = cmd128.ExecuteReader
            rdr130 = cmd129.ExecuteReader
            rdr131 = cmd130.ExecuteReader
            rdr132 = cmd131.ExecuteReader
            rdr133 = cmd132.ExecuteReader
            rdr134 = cmd133.ExecuteReader
            rdr135 = cmd134.ExecuteReader
            rdr136 = cmd135.ExecuteReader
            rdr137 = cmd136.ExecuteReader
            rdr138 = cmd137.ExecuteReader
            rdr139 = cmd138.ExecuteReader
            rdr140 = cmd139.ExecuteReader
            rdr141 = cmd140.ExecuteReader
            rdr142 = cmd141.ExecuteReader
            rdr143 = cmd142.ExecuteReader
            rdr146 = cmd145.ExecuteReader
            rdr145 = cmd144.ExecuteReader
            rdr147 = cmd146.ExecuteReader
            rdr144 = cmd143.ExecuteReader
            rdr148 = cmd147.ExecuteReader
            rdr149 = cmd148.ExecuteReader
            rdr150 = cmd149.ExecuteReader
            rdr151 = cmd150.ExecuteReader
            rdr152 = cmd151.ExecuteReader
            rdr153 = cmd152.ExecuteReader
            rdr154 = cmd153.ExecuteReader
            rdr155 = cmd154.ExecuteReader
            rdr156 = cmd155.ExecuteReader
            rdr157 = cmd156.ExecuteReader
            rdr158 = cmd157.ExecuteReader
            rdr159 = cmd158.ExecuteReader
            rdr160 = cmd159.ExecuteReader
            rdr161 = cmd160.ExecuteReader
            rdr162 = cmd161.ExecuteReader
            rdr163 = cmd162.ExecuteReader
            rdr164 = cmd163.ExecuteReader
            rdr165 = cmd164.ExecuteReader
            rdr166 = cmd165.ExecuteReader
            rdr167 = cmd166.ExecuteReader
            rdr168 = cmd167.ExecuteReader
            rdr169 = cmd168.ExecuteReader
            rdr170 = cmd169.ExecuteReader
            rdr171 = cmd170.ExecuteReader
            rdr172 = cmd171.ExecuteReader
            rdr173 = cmd172.ExecuteReader
            rdr174 = cmd173.ExecuteReader
            rdr175 = cmd174.ExecuteReader
            rdr176 = cmd175.ExecuteReader
            rdr177 = cmd176.ExecuteReader
            rdr178 = cmd177.ExecuteReader
            rdr179 = cmd178.ExecuteReader
            rdr180 = cmd179.ExecuteReader
            rdr181 = cmd180.ExecuteReader
            rdr182 = cmd181.ExecuteReader
            rdr183 = cmd182.ExecuteReader
            rdr184 = cmd183.ExecuteReader
            rdr185 = cmd184.ExecuteReader
            rdr186 = cmd185.ExecuteReader
            rdr187 = cmd186.ExecuteReader
            rdr188 = cmd187.ExecuteReader
            rdr189 = cmd188.ExecuteReader
            rdr190 = cmd189.ExecuteReader
            rdr191 = cmd190.ExecuteReader
            rdr192 = cmd191.ExecuteReader
            rdr193 = cmd192.ExecuteReader
            rdr194 = cmd193.ExecuteReader
            rdr195 = cmd194.ExecuteReader
            rdr196 = cmd195.ExecuteReader
            rdr197 = cmd196.ExecuteReader
            rdr198 = cmd197.ExecuteReader
            rdr199 = cmd198.ExecuteReader
            rdr200 = cmd199.ExecuteReader






            If rdr.Read Then

                Button1.BackColor = Color.Red
                Button1.Enabled = True

            End If
            If rdr2.Read Then

                Button2.BackColor = Color.Red
                Button2.Enabled = True

            End If


            If rdr3.Read Then

                Button3.BackColor = Color.Red
                Button3.Enabled = True

            End If
            If rdr4.Read Then

                Button4.BackColor = Color.Red
                Button4.Enabled = True

            End If
            If rdr5.Read Then

                Button5.BackColor = Color.Red
                Button5.Enabled = True

            End If
            If rdr6.Read Then

                Button6.BackColor = Color.Red
                Button6.Enabled = True

            End If
            If rdr7.Read Then

                Button7.BackColor = Color.Red
                Button7.Enabled = True

            End If
            If rdr9.Read Then

                Button9.BackColor = Color.Red
                Button9.Enabled = True

            End If
            If rdr8.Read Then

                Button8.BackColor = Color.Red
                Button8.Enabled = True

            End If
            If rdr9.Read Then

                Button9.BackColor = Color.Red
                Button9.Enabled = True

            End If
            If rdr10.Read Then

                Button10.BackColor = Color.Red
                Button10.Enabled = True

            End If
            If rdr11.Read Then

                Button11.BackColor = Color.Red
                Button11.Enabled = True

            End If
            If rdr12.Read Then

                Button12.BackColor = Color.Red
                Button12.Enabled = True

            End If
            If rdr13.Read Then

                Button13.BackColor = Color.Red
                Button13.Enabled = True

            End If
            If rdr14.Read Then

                Button14.BackColor = Color.Red
                Button14.Enabled = True

            End If
            If rdr15.Read Then

                Button15.BackColor = Color.Red
                Button15.Enabled = True

            End If
            If rdr16.Read Then

                Button16.BackColor = Color.Red
                Button16.Enabled = True

            End If
            If rdr17.Read Then

                Button17.BackColor = Color.Red
                Button17.Enabled = True

            End If
            If rdr18.Read Then

                Button18.BackColor = Color.Red
                Button18.Enabled = True

            End If
            If rdr19.Read Then

                Button19.BackColor = Color.Red
                Button19.Enabled = True

            End If
            If rdr20.Read Then

                Button20.BackColor = Color.Red
                Button20.Enabled = True

            End If
            If rdr21.Read Then

                Button21.BackColor = Color.Red
                Button21.Enabled = True

            End If
            If rdr22.Read Then

                Button22.BackColor = Color.Red
                Button22.Enabled = True

            End If
            If rdr23.Read Then

                Button23.BackColor = Color.Red
                Button23.Enabled = True

            End If
            If rdr24.Read Then

                Button24.BackColor = Color.Red
                Button24.Enabled = True

            End If
            If rdr25.Read Then

                Button25.BackColor = Color.Red
                Button25.Enabled = True

            End If
            If rdr26.Read Then

                Button26.BackColor = Color.Red
                Button26.Enabled = True

            End If
            If rdr27.Read Then

                Button27.BackColor = Color.Red
                Button27.Enabled = True

            End If
            If rdr28.Read Then

                Button28.BackColor = Color.Red
                Button28.Enabled = True

            End If
            If rdr29.Read Then

                Button29.BackColor = Color.Red
                Button29.Enabled = True

            End If
            If rdr30.Read Then

                Button30.BackColor = Color.Red
                Button30.Enabled = True

            End If
            If rdr31.Read Then

                Button31.BackColor = Color.Red
                Button31.Enabled = True

            End If
            If rdr32.Read Then

                Button32.BackColor = Color.Red
                Button32.Enabled = True

            End If
            If rdr33.Read Then

                Button33.BackColor = Color.Red
                Button33.Enabled = True

            End If
            If rdr34.Read Then

                Button34.BackColor = Color.Red
                Button34.Enabled = True

            End If
            If rdr35.Read Then

                Button35.BackColor = Color.Red
                Button35.Enabled = True

            End If
            If rdr36.Read Then

                Button36.BackColor = Color.Red
                Button36.Enabled = True

            End If
            If rdr37.Read Then

                Button37.BackColor = Color.Red
                Button37.Enabled = True

            End If
            If rdr38.Read Then

                Button38.BackColor = Color.Red
                Button38.Enabled = True

            End If
            If rdr39.Read Then

                Button39.BackColor = Color.Red
                Button39.Enabled = True

            End If
            If rdr40.Read Then

                Button40.BackColor = Color.Red
                Button40.Enabled = True

            End If
            If rdr41.Read Then

                Button41.BackColor = Color.Red
                Button41.Enabled = True

            End If
            If rdr42.Read Then

                Button42.BackColor = Color.Red
                Button42.Enabled = True

            End If
            If rdr43.Read Then

                Button43.BackColor = Color.Red
                Button43.Enabled = True

            End If
            If rdr44.Read Then

                Button44.BackColor = Color.Red
                Button44.Enabled = True

            End If
            If rdr45.Read Then

                Button45.BackColor = Color.Red
                Button45.Enabled = True

            End If
            If rdr46.Read Then

                Button46.BackColor = Color.Red
                Button46.Enabled = True

            End If
            If rdr47.Read Then

                Button47.BackColor = Color.Red
                Button47.Enabled = True

            End If
            If rdr48.Read Then

                Button48.BackColor = Color.Red
                Button48.Enabled = True

            End If
            If rdr49.Read Then

                Button49.BackColor = Color.Red
                Button49.Enabled = True

            End If
            If rdr50.Read Then

                Button50.BackColor = Color.Red
                Button50.Enabled = True

            End If
            If rdr51.Read Then

                Button51.BackColor = Color.Red
                Button51.Enabled = True

            End If
            If rdr52.Read Then

                Button52.BackColor = Color.Red
                Button52.Enabled = True

            End If
            If rdr53.Read Then

                Button53.BackColor = Color.Red
                Button53.Enabled = True

            End If
            If rdr54.Read Then

                Button54.BackColor = Color.Red
                Button54.Enabled = True

            End If
            If rdr55.Read Then

                Button55.BackColor = Color.Red
                Button55.Enabled = True

            End If
            If rdr56.Read Then

                Button56.BackColor = Color.Red
                Button56.Enabled = True

            End If
            If rdr57.Read Then

                Button57.BackColor = Color.Red
                Button57.Enabled = True

            End If
            If rdr58.Read Then

                Button58.BackColor = Color.Red
                Button58.Enabled = True

            End If
            If rdr59.Read Then

                Button59.BackColor = Color.Red
                Button59.Enabled = True

            End If
            If rdr60.Read Then

                Button60.BackColor = Color.Red
                Button60.Enabled = True

            End If
            If rdr61.Read Then

                Button61.BackColor = Color.Red
                Button61.Enabled = True

            End If
            If rdr62.Read Then

                Button62.BackColor = Color.Red
                Button62.Enabled = True

            End If
            If rdr63.Read Then

                Button63.BackColor = Color.Red
                Button63.Enabled = True

            End If
            If rdr64.Read Then

                Button64.BackColor = Color.Red
                Button64.Enabled = True

            End If
            If rdr65.Read Then

                Button65.BackColor = Color.Red
                Button65.Enabled = True

            End If
            If rdr66.Read Then

                Button66.BackColor = Color.Red
                Button66.Enabled = True

            End If
            If rdr67.Read Then

                Button67.BackColor = Color.Red
                Button67.Enabled = True

            End If
            If rdr68.Read Then

                Button68.BackColor = Color.Red
                Button68.Enabled = True

            End If
            If rdr69.Read Then

                Button69.BackColor = Color.Red
                Button69.Enabled = True

            End If
            If rdr70.Read Then

                Button70.BackColor = Color.Red
                Button70.Enabled = True

            End If
            If rdr71.Read Then

                Button71.BackColor = Color.Red
                Button71.Enabled = True

            End If
            If rdr72.Read Then

                Button72.BackColor = Color.Red
                Button72.Enabled = True

            End If
            If rdr73.Read Then

                Button73.BackColor = Color.Red
                Button73.Enabled = True

            End If
            If rdr74.Read Then

                Button74.BackColor = Color.Red
                Button74.Enabled = True

            End If
            If rdr75.Read Then

                Button75.BackColor = Color.Red
                Button75.Enabled = True

            End If
            If rdr76.Read Then

                Button76.BackColor = Color.Red
                Button76.Enabled = True

            End If
            If rdr77.Read Then

                Button77.BackColor = Color.Red
                Button77.Enabled = True

            End If
            If rdr78.Read Then

                Button78.BackColor = Color.Red
                Button78.Enabled = True

            End If
            If rdr79.Read Then

                Button79.BackColor = Color.Red
                Button79.Enabled = True

            End If
            If rdr80.Read Then

                Button80.BackColor = Color.Red
                Button80.Enabled = True

            End If
            If rdr81.Read Then

                Button81.BackColor = Color.Red
                Button81.Enabled = True

            End If
            If rdr82.Read Then

                Button82.BackColor = Color.Red
                Button82.Enabled = True

            End If
            If rdr83.Read Then

                Button83.BackColor = Color.Red
                Button83.Enabled = True

            End If
            If rdr84.Read Then

                Button84.BackColor = Color.Red
                Button84.Enabled = True

            End If
            If rdr85.Read Then

                Button85.BackColor = Color.Red
                Button85.Enabled = True

            End If
            If rdr86.Read Then

                Button86.BackColor = Color.Red
                Button86.Enabled = True

            End If
            If rdr87.Read Then

                Button87.BackColor = Color.Red
                Button87.Enabled = True

            End If
            If rdr88.Read Then

                Button88.BackColor = Color.Red
                Button88.Enabled = True

            End If
            If rdr89.Read Then

                Button89.BackColor = Color.Red
                Button89.Enabled = True

            End If
            If rdr90.Read Then

                Button90.BackColor = Color.Red
                Button90.Enabled = True

            End If
            If rdr91.Read Then

                Button91.BackColor = Color.Red
                Button91.Enabled = True

            End If
            If rdr92.Read Then

                Button92.BackColor = Color.Red
                Button92.Enabled = True

            End If
            If rdr93.Read Then

                Button93.BackColor = Color.Red
                Button93.Enabled = True

            End If
            If rdr94.Read Then

                Button94.BackColor = Color.Red
                Button94.Enabled = True

            End If
            If rdr95.Read Then

                Button95.BackColor = Color.Red
                Button95.Enabled = True

            End If
            If rdr96.Read Then

                Button96.BackColor = Color.Red
                Button96.Enabled = True

            End If
            If rdr97.Read Then

                Button97.BackColor = Color.Red
                Button97.Enabled = True

            End If
            If rdr98.Read Then

                Button98.BackColor = Color.Red
                Button98.Enabled = True

            End If
            If rdr99.Read Then

                Button99.BackColor = Color.Red
                Button99.Enabled = True

            End If
            If rdr100.Read Then

                Button100.BackColor = Color.Red
                Button100.Enabled = True

            End If
            If rdr101.Read Then

                Button101.BackColor = Color.Red
                Button101.Enabled = True

            End If
            If rdr102.Read Then

                Button102.BackColor = Color.Red
                Button102.Enabled = True

            End If
            If rdr103.Read Then

                Button103.BackColor = Color.Red
                Button103.Enabled = True

            End If
            If rdr104.Read Then

                Button104.BackColor = Color.Red
                Button104.Enabled = True

            End If
            If rdr105.Read Then

                Button105.BackColor = Color.Red
                Button105.Enabled = True

            End If
            If rdr106.Read Then

                Button106.BackColor = Color.Red
                Button106.Enabled = True

            End If
            If rdr107.Read Then

                Button107.BackColor = Color.Red
                Button107.Enabled = True

            End If
            If rdr108.Read Then

                Button108.BackColor = Color.Red
                Button108.Enabled = True

            End If
            If rdr109.Read Then

                Button109.BackColor = Color.Red
                Button109.Enabled = True

            End If
            If rdr110.Read Then

                Button110.BackColor = Color.Red
                Button110.Enabled = True

            End If
            If rdr111.Read Then

                Button111.BackColor = Color.Red
                Button111.Enabled = True

            End If
            If rdr112.Read Then

                Button112.BackColor = Color.Red
                Button112.Enabled = True

            End If
            If rdr113.Read Then

                Button113.BackColor = Color.Red
                Button113.Enabled = True

            End If
            If rdr114.Read Then

                Button114.BackColor = Color.Red
                Button114.Enabled = True

            End If
            If rdr115.Read Then

                Button115.BackColor = Color.Red
                Button115.Enabled = True

            End If
            If rdr116.Read Then

                Button116.BackColor = Color.Red
                Button116.Enabled = True

            End If
            If rdr117.Read Then

                Button117.BackColor = Color.Red
                Button117.Enabled = True

            End If
            If rdr118.Read Then

                Button118.BackColor = Color.Red
                Button118.Enabled = True

            End If
            If rdr119.Read Then

                Button119.BackColor = Color.Red
                Button119.Enabled = True

            End If
            If rdr120.Read Then

                Button120.BackColor = Color.Red
                Button120.Enabled = True

            End If
            If rdr121.Read Then

                Button121.BackColor = Color.Red
                Button121.Enabled = True

            End If
            If rdr122.Read Then

                Button122.BackColor = Color.Red
                Button122.Enabled = True

            End If
            If rdr123.Read Then

                Button123.BackColor = Color.Red
                Button123.Enabled = True

            End If
            If rdr124.Read Then

                Button124.BackColor = Color.Red
                Button124.Enabled = True

            End If
            If rdr125.Read Then

                Button125.BackColor = Color.Red
                Button125.Enabled = True

            End If
            If rdr126.Read Then

                Button126.BackColor = Color.Red
                Button126.Enabled = True

            End If
            If rdr127.Read Then

                Button127.BackColor = Color.Red
                Button127.Enabled = True

            End If
            If rdr128.Read Then

                Button128.BackColor = Color.Red
                Button128.Enabled = True

            End If
            If rdr129.Read Then

                Button129.BackColor = Color.Red
                Button129.Enabled = True

            End If
            If rdr130.Read Then

                Button130.BackColor = Color.Red
                Button130.Enabled = True

            End If
            If rdr131.Read Then

                Button131.BackColor = Color.Red
                Button131.Enabled = True

            End If
            If rdr132.Read Then

                Button132.BackColor = Color.Red
                Button132.Enabled = True

            End If
            If rdr133.Read Then

                Button133.BackColor = Color.Red
                Button133.Enabled = True

            End If
            If rdr134.Read Then

                Button134.BackColor = Color.Red
                Button134.Enabled = True

            End If
            If rdr135.Read Then

                Button135.BackColor = Color.Red
                Button135.Enabled = True

            End If
            If rdr136.Read Then

                Button136.BackColor = Color.Red
                Button136.Enabled = True

            End If
            If rdr137.Read Then

                Button137.BackColor = Color.Red
                Button137.Enabled = True

            End If
            If rdr138.Read Then

                Button138.BackColor = Color.Red
                Button138.Enabled = True

            End If
            If rdr139.Read Then

                Button139.BackColor = Color.Red
                Button139.Enabled = True

            End If
            If rdr140.Read Then

                Button140.BackColor = Color.Red
                Button140.Enabled = True

            End If
            If rdr141.Read Then

                Button141.BackColor = Color.Red
                Button141.Enabled = True

            End If
            If rdr142.Read Then

                Button142.BackColor = Color.Red
                Button142.Enabled = True

            End If
            If rdr143.Read Then

                Button143.BackColor = Color.Red
                Button143.Enabled = True

            End If
            If rdr144.Read Then

                Button144.BackColor = Color.Red
                Button144.Enabled = True

            End If
            If rdr145.Read Then

                Button145.BackColor = Color.Red
                Button145.Enabled = True

            End If
            If rdr146.Read Then

                Button146.BackColor = Color.Red
                Button146.Enabled = True

            End If
            If rdr147.Read Then

                Button147.BackColor = Color.Red
                Button147.Enabled = True

            End If
            If rdr148.Read Then

                Button148.BackColor = Color.Red
                Button148.Enabled = True

            End If
            If rdr149.Read Then

                Button149.BackColor = Color.Red
                Button149.Enabled = True

            End If
            If rdr150.Read Then

                Button150.BackColor = Color.Red
                Button150.Enabled = True

            End If
            If rdr151.Read Then

                Button151.BackColor = Color.Red
                Button151.Enabled = True

            End If
            If rdr152.Read Then

                Button152.BackColor = Color.Red
                Button152.Enabled = True

            End If
            If rdr153.Read Then

                Button153.BackColor = Color.Red
                Button153.Enabled = True

            End If
            If rdr154.Read Then

                Button154.BackColor = Color.Red
                Button154.Enabled = True

            End If
            If rdr155.Read Then

                Button155.BackColor = Color.Red
                Button155.Enabled = True

            End If
            If rdr156.Read Then

                Button156.BackColor = Color.Red
                Button156.Enabled = True

            End If
            If rdr157.Read Then

                Button157.BackColor = Color.Red
                Button157.Enabled = True

            End If
            If rdr158.Read Then

                Button158.BackColor = Color.Red
                Button158.Enabled = True

            End If
            If rdr159.Read Then

                Button159.BackColor = Color.Red
                Button159.Enabled = True

            End If
            If rdr160.Read Then

                Button160.BackColor = Color.Red
                Button160.Enabled = True

            End If
            If rdr161.Read Then

                Button161.BackColor = Color.Red
                Button161.Enabled = True

            End If
            If rdr162.Read Then

                Button162.BackColor = Color.Red
                Button162.Enabled = True

            End If
            If rdr163.Read Then

                Button163.BackColor = Color.Red
                Button163.Enabled = True

            End If
            If rdr164.Read Then

                Button164.BackColor = Color.Red
                Button164.Enabled = True

            End If
            If rdr165.Read Then

                Button165.BackColor = Color.Red
                Button165.Enabled = True

            End If
            If rdr166.Read Then

                Button166.BackColor = Color.Red
                Button166.Enabled = True

            End If
            If rdr167.Read Then

                Button167.BackColor = Color.Red
                Button167.Enabled = True

            End If
            If rdr168.Read Then

                Button168.BackColor = Color.Red
                Button168.Enabled = True

            End If
            If rdr169.Read Then

                Button169.BackColor = Color.Red
                Button169.Enabled = True

            End If
            If rdr170.Read Then

                Button170.BackColor = Color.Red
                Button170.Enabled = True

            End If
            If rdr171.Read Then

                Button171.BackColor = Color.Red
                Button171.Enabled = True

            End If
            If rdr172.Read Then

                Button172.BackColor = Color.Red
                Button172.Enabled = True

            End If
            If rdr173.Read Then

                Button173.BackColor = Color.Red
                Button173.Enabled = True

            End If
            If rdr174.Read Then

                Button174.BackColor = Color.Red
                Button174.Enabled = True

            End If
            If rdr175.Read Then

                Button175.BackColor = Color.Red
                Button175.Enabled = True

            End If
            If rdr176.Read Then

                Button176.BackColor = Color.Red
                Button176.Enabled = True

            End If
            If rdr177.Read Then

                Button177.BackColor = Color.Red
                Button177.Enabled = True

            End If
            If rdr178.Read Then

                Button178.BackColor = Color.Red
                Button178.Enabled = True

            End If
            If rdr179.Read Then

                Button179.BackColor = Color.Red
                Button179.Enabled = True

            End If
            If rdr180.Read Then

                Button180.BackColor = Color.Red
                Button180.Enabled = True

            End If
            If rdr181.Read Then

                Button181.BackColor = Color.Red
                Button181.Enabled = True

            End If


            If rdr182.Read Then

                Button182.BackColor = Color.Red
                Button182.Enabled = True

            End If
            If rdr183.Read Then

                Button183.BackColor = Color.Red
                Button183.Enabled = True

            End If
            If rdr184.Read Then

                Button184.BackColor = Color.Red
                Button184.Enabled = True

            End If
            If rdr185.Read Then

                Button185.BackColor = Color.Red
                Button185.Enabled = True

            End If
            If rdr186.Read Then

                Button186.BackColor = Color.Red
                Button186.Enabled = True

            End If
            If rdr187.Read Then

                Button187.BackColor = Color.Red
                Button187.Enabled = True

            End If
            If rdr188.Read Then

                Button188.BackColor = Color.Red
                Button188.Enabled = True

            End If
            If rdr189.Read Then

                Button189.BackColor = Color.Red
                Button189.Enabled = True

            End If
            If rdr190.Read Then

                Button190.BackColor = Color.Red
                Button190.Enabled = True

            End If
            If rdr191.Read Then

                Button191.BackColor = Color.Red
                Button191.Enabled = True

            End If
            If rdr192.Read Then

                Button192.BackColor = Color.Red
                Button192.Enabled = True

            End If
            If rdr193.Read Then

                Button193.BackColor = Color.Red
                Button193.Enabled = True

            End If
            If rdr194.Read Then

                Button194.BackColor = Color.Red
                Button194.Enabled = True

            End If
            If rdr195.Read Then

                Button195.BackColor = Color.Red
                Button195.Enabled = True

            End If
            If rdr196.Read Then

                Button196.BackColor = Color.Red
                Button196.Enabled = True

            End If
            If rdr197.Read Then

                Button197.BackColor = Color.Red
                Button197.Enabled = True

            End If
            If rdr198.Read Then

                Button198.BackColor = Color.Red
                Button198.Enabled = True

            End If
            If rdr199.Read Then

                Button199.BackColor = Color.Red
                Button199.Enabled = True

            End If
            If rdr200.Read Then

                Button200.BackColor = Color.Red
                Button200.Enabled = True
            End If

            con.Close()

            Me.Cursor = Cursors.Default
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.BackColor = Color.Red Then
            Button1.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button1.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.BackColor = Color.Red Then
            Button2.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button2.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.BackColor = Color.Red Then
            Button9.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button9.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.BackColor = Color.Red Then
            Button5.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button5.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Button17.BackColor = Color.Red Then
            Button17.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button17.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Button13.BackColor = Color.Red Then
            Button13.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button13.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If Button21.BackColor = Color.Red Then
            Button21.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button21.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button10.BackColor = Color.Red Then
            Button10.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button10.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If Button25.BackColor = Color.Red Then
            Button25.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button25.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.BackColor = Color.Red Then
            Button3.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button3.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Button29.BackColor = Color.Red Then
            Button29.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button29.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If Button33.BackColor = Color.Red Then
            Button33.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button33.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Button18.BackColor = Color.Red Then
            Button18.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button18.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If Button37.BackColor = Color.Red Then
            Button37.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button37.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Button14.BackColor = Color.Red Then
            Button14.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button14.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If Button41.BackColor = Color.Red Then
            Button41.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button41.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If Button22.BackColor = Color.Red Then
            Button22.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button22.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        If Button49.BackColor = Color.Red Then
            Button49.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button49.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        If Button45.BackColor = Color.Red Then
            Button45.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button45.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        If Button53.BackColor = Color.Red Then
            Button53.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button53.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If Button26.BackColor = Color.Red Then
            Button26.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button26.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        If Button57.BackColor = Color.Red Then
            Button57.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button57.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If Button30.BackColor = Color.Red Then
            Button30.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button30.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        If Button61.BackColor = Color.Red Then
            Button61.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button61.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If Button34.BackColor = Color.Red Then
            Button34.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button34.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        If Button65.BackColor = Color.Red Then
            Button65.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button65.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        If Button38.BackColor = Color.Red Then
            Button38.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button38.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        If Button69.BackColor = Color.Red Then
            Button69.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button69.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If Button42.BackColor = Color.Red Then
            Button42.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button42.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        If Button73.BackColor = Color.Red Then
            Button73.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button73.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        If Button46.BackColor = Color.Red Then
            Button46.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button46.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        If Button77.BackColor = Color.Red Then
            Button77.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button77.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        If Button50.BackColor = Color.Red Then
            Button50.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button50.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        If Button81.BackColor = Color.Red Then
            Button81.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button81.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.BackColor = Color.Red Then
            Button6.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button6.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles Button85.Click
        If Button85.BackColor = Color.Red Then
            Button85.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button85.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button89_Click(sender As Object, e As EventArgs) Handles Button89.Click
        If Button89.BackColor = Color.Red Then
            Button89.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button89.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        If Button54.BackColor = Color.Red Then
            Button54.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button54.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button93_Click(sender As Object, e As EventArgs) Handles Button93.Click
        If Button93.BackColor = Color.Red Then
            Button93.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button93.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button11.BackColor = Color.Red Then
            Button11.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button11.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button97_Click(sender As Object, e As EventArgs) Handles Button97.Click
        If Button97.BackColor = Color.Red Then
            Button97.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button97.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        If Button58.BackColor = Color.Red Then
            Button58.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button58.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click
        If Button101.BackColor = Color.Red Then
            Button101.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button101.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.BackColor = Color.Red Then
            Button7.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button7.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Button105.Click
        If Button105.BackColor = Color.Red Then
            Button105.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button105.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        If Button62.BackColor = Color.Red Then
            Button62.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button62.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button109_Click(sender As Object, e As EventArgs) Handles Button109.Click
        If Button109.BackColor = Color.Red Then
            Button109.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button109.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Button19.BackColor = Color.Red Then
            Button19.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button19.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        If Button66.BackColor = Color.Red Then
            Button66.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button66.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If Button23.BackColor = Color.Red Then
            Button23.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button23.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        If Button70.BackColor = Color.Red Then
            Button70.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button70.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If Button27.BackColor = Color.Red Then
            Button27.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button27.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        If Button74.BackColor = Color.Red Then
            Button74.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button74.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If Button31.BackColor = Color.Red Then
            Button31.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button31.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        If Button78.BackColor = Color.Red Then
            Button78.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button78.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If Button35.BackColor = Color.Red Then
            Button35.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button35.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Button82.Click
        If Button82.BackColor = Color.Red Then
            Button82.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button82.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If Button39.BackColor = Color.Red Then
            Button39.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button39.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button86_Click(sender As Object, e As EventArgs) Handles Button86.Click
        If Button86.BackColor = Color.Red Then
            Button86.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button86.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Button90.Click
        If Button90.BackColor = Color.Red Then
            Button90.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button90.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If Button43.BackColor = Color.Red Then
            Button43.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button43.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button94_Click(sender As Object, e As EventArgs) Handles Button94.Click
        If Button94.BackColor = Color.Red Then
            Button94.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button94.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        If Button51.BackColor = Color.Red Then
            Button51.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button51.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button98_Click(sender As Object, e As EventArgs) Handles Button98.Click
        If Button98.BackColor = Color.Red Then
            Button98.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button98.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        If Button55.BackColor = Color.Red Then
            Button55.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button55.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button102_Click(sender As Object, e As EventArgs) Handles Button102.Click
        If Button102.BackColor = Color.Red Then
            Button102.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button102.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        If Button59.BackColor = Color.Red Then
            Button59.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button59.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button106_Click(sender As Object, e As EventArgs) Handles Button106.Click
        If Button106.BackColor = Color.Red Then
            Button106.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button106.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        If Button63.BackColor = Color.Red Then
            Button63.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button63.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button110_Click(sender As Object, e As EventArgs) Handles Button110.Click
        If Button110.BackColor = Color.Red Then
            Button110.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button110.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        If Button67.BackColor = Color.Red Then
            Button67.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button67.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        If Button71.BackColor = Color.Red Then
            Button71.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button71.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        If Button75.BackColor = Color.Red Then
            Button75.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button75.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        If Button79.BackColor = Color.Red Then
            Button79.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button79.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        If Button83.BackColor = Color.Red Then
            Button83.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button83.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click
        If Button87.BackColor = Color.Red Then
            Button87.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button87.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button91_Click(sender As Object, e As EventArgs) Handles Button91.Click
        If Button91.BackColor = Color.Red Then
            Button91.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button91.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button95_Click(sender As Object, e As EventArgs) Handles Button95.Click
        If Button95.BackColor = Color.Red Then
            Button95.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button95.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button99_Click(sender As Object, e As EventArgs) Handles Button99.Click
        If Button99.BackColor = Color.Red Then
            Button99.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button99.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Button103.Click
        If Button103.BackColor = Color.Red Then
            Button103.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button103.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button107_Click(sender As Object, e As EventArgs) Handles Button107.Click
        If Button107.BackColor = Color.Red Then
            Button107.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button107.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button111_Click(sender As Object, e As EventArgs) Handles Button111.Click
        If Button111.BackColor = Color.Red Then
            Button111.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button111.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        If Button47.BackColor = Color.Red Then
            Button47.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button47.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Button15.BackColor = Color.Red Then
            Button15.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button15.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.BackColor = Color.Red Then
            Button4.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button4.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Button12.BackColor = Color.Red Then
            Button12.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button12.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Button20.BackColor = Color.Red Then
            Button20.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button20.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If Button24.BackColor = Color.Red Then
            Button24.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button24.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Button28.BackColor = Color.Red Then
            Button28.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button28.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If Button32.BackColor = Color.Red Then
            Button32.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button32.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If Button36.BackColor = Color.Red Then
            Button36.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button36.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If Button40.BackColor = Color.Red Then
            Button40.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button40.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        If Button44.BackColor = Color.Red Then
            Button44.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button44.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        If Button52.BackColor = Color.Red Then
            Button52.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button52.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        If Button56.BackColor = Color.Red Then
            Button56.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button56.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        If Button60.BackColor = Color.Red Then
            Button60.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button60.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        If Button64.BackColor = Color.Red Then
            Button64.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button64.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        If Button68.BackColor = Color.Red Then
            Button68.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button68.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        If Button72.BackColor = Color.Red Then
            Button72.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button72.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        If Button76.BackColor = Color.Red Then
            Button76.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button76.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        If Button80.BackColor = Color.Red Then
            Button80.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button80.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button84_Click(sender As Object, e As EventArgs) Handles Button84.Click
        If Button84.BackColor = Color.Red Then
            Button84.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button84.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button88_Click(sender As Object, e As EventArgs) Handles Button88.Click
        If Button88.BackColor = Color.Red Then
            Button88.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button88.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button92_Click(sender As Object, e As EventArgs) Handles Button92.Click
        If Button92.BackColor = Color.Red Then
            Button92.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button92.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button96_Click(sender As Object, e As EventArgs) Handles Button96.Click
        If Button96.BackColor = Color.Red Then
            Button96.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button96.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        If Button100.BackColor = Color.Red Then
            Button100.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button100.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Button104.Click
        If Button104.BackColor = Color.Red Then
            Button104.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button104.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button108_Click(sender As Object, e As EventArgs) Handles Button108.Click
        If Button108.BackColor = Color.Red Then
            Button108.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button108.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button112_Click(sender As Object, e As EventArgs) Handles Button112.Click
        If Button112.BackColor = Color.Red Then
            Button112.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button112.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If Button48.BackColor = Color.Red Then
            Button48.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button48.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Button16.BackColor = Color.Red Then
            Button16.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button16.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.BackColor = Color.Red Then
            Button8.BackColor = Color.Gold
            first = first - 1
        Else
            first = first + 1
            Button8.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub


    Private Sub Button201_Click(sender As Object, e As EventArgs) Handles Button201.Click

        Me.Cursor = Cursors.WaitCursor
        If Button1.BackColor = Color.Gold Then
            Button1.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f1] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then

            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If
        If Button2.BackColor = Color.Gold Then
            Button2.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f2] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then

            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button3.BackColor = Color.Gold Then
            Button3.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f3] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '    MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button4.BackColor = Color.Gold Then
            Button4.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f4] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button5.BackColor = Color.Gold Then
            Button5.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f5] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button6.BackColor = Color.Gold Then
            Button6.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f6] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button7.BackColor = Color.Gold Then
            Button7.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f7] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button8.BackColor = Color.Gold Then
            Button8.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f8] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button9.BackColor = Color.Gold Then
            Button9.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f9] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button10.BackColor = Color.Gold Then
            Button10.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f10] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button11.BackColor = Color.Gold Then
            Button11.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f11] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button12.BackColor = Color.Gold Then
            Button12.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f12] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button13.BackColor = Color.Gold Then
            Button13.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f13] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button14.BackColor = Color.Gold Then
            Button14.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f14] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                'MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button15.BackColor = Color.Gold Then
            Button15.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f15] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button16.BackColor = Color.Gold Then
            Button16.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f16] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button17.BackColor = Color.Gold Then
            Button17.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f17] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button18.BackColor = Color.Gold Then
            Button18.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f18] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button19.BackColor = Color.Gold Then
            Button19.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f19] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button20.BackColor = Color.Gold Then
            Button20.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f20] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button21.BackColor = Color.Gold Then
            Button21.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f21] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button22.BackColor = Color.Gold Then
            Button22.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f22] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button23.BackColor = Color.Gold Then
            Button23.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f23] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button24.BackColor = Color.Gold Then
            Button24.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f24] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button25.BackColor = Color.Gold Then
            Button25.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f25] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button26.BackColor = Color.Gold Then
            Button26.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f26] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '  MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button27.BackColor = Color.Gold Then
            Button27.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f27] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button28.BackColor = Color.Gold Then
            Button28.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f28] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button29.BackColor = Color.Gold Then
            Button29.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f29] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                ' MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button30.BackColor = Color.Gold Then
            Button30.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f30] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button31.BackColor = Color.Gold Then
            Button31.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f31] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button32.BackColor = Color.Gold Then
            Button32.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f32] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button33.BackColor = Color.Gold Then
            Button33.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f33] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button34.BackColor = Color.Gold Then
            Button34.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f34] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button35.BackColor = Color.Gold Then
            Button35.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f35] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button36.BackColor = Color.Gold Then
            Button36.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f36] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button37.BackColor = Color.Gold Then
            Button37.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f37] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button38.BackColor = Color.Gold Then
            Button38.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f38] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '    MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button39.BackColor = Color.Gold Then
            Button39.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f39] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button40.BackColor = Color.Gold Then
            Button40.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f40] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '        MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button41.BackColor = Color.Gold Then
            Button41.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f41] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button42.BackColor = Color.Gold Then
            Button42.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f42] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button43.BackColor = Color.Gold Then
            Button43.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f43] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button44.BackColor = Color.Gold Then
            Button44.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f44] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button45.BackColor = Color.Gold Then
            Button45.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f45] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button46.BackColor = Color.Gold Then
            Button46.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f46] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button47.BackColor = Color.Gold Then
            Button47.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f47] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button48.BackColor = Color.Gold Then
            Button48.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f48] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '      MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button49.BackColor = Color.Gold Then
            Button49.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f49] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button50.BackColor = Color.Gold Then
            Button50.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f50] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button51.BackColor = Color.Gold Then
            Button51.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f51] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button52.BackColor = Color.Gold Then
            Button52.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f52] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '        MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button53.BackColor = Color.Gold Then
            Button53.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f53] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '       MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button54.BackColor = Color.Gold Then
            Button54.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f54] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '        MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button55.BackColor = Color.Gold Then
            Button55.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f55] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button56.BackColor = Color.Gold Then
            Button56.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f56] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button57.BackColor = Color.Gold Then
            Button57.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f57] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button58.BackColor = Color.Gold Then
            Button58.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f58] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button59.BackColor = Color.Gold Then
            Button59.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f59] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button60.BackColor = Color.Gold Then
            Button60.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f60] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()



        End If

        If Button61.BackColor = Color.Gold Then
            Button61.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f61] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()



        End If

        If Button62.BackColor = Color.Gold Then
            Button62.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f62] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button63.BackColor = Color.Gold Then
            Button63.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f63] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button64.BackColor = Color.Gold Then
            Button64.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f64] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button65.BackColor = Color.Gold Then
            Button65.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f65] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button66.BackColor = Color.Gold Then
            Button66.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f66] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button67.BackColor = Color.Gold Then
            Button67.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f67] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button68.BackColor = Color.Gold Then
            Button68.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f68] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button69.BackColor = Color.Gold Then
            Button69.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f69] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button70.BackColor = Color.Gold Then
            Button70.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f70] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button71.BackColor = Color.Gold Then
            Button71.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f71] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button72.BackColor = Color.Gold Then
            Button72.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f72] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button73.BackColor = Color.Gold Then
            Button73.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f73] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button74.BackColor = Color.Gold Then
            Button74.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f74] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button75.BackColor = Color.Gold Then
            Button75.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f75] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button76.BackColor = Color.Gold Then
            Button76.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f76] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button77.BackColor = Color.Gold Then
            Button77.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f77] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button78.BackColor = Color.Gold Then
            Button78.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f78] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button79.BackColor = Color.Gold Then
            Button79.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f79] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button80.BackColor = Color.Gold Then
            Button80.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f80] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button81.BackColor = Color.Gold Then
            Button81.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f81] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button82.BackColor = Color.Gold Then
            Button82.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f82] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button83.BackColor = Color.Gold Then
            Button83.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f83] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button84.BackColor = Color.Gold Then
            Button84.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f84] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button85.BackColor = Color.Gold Then
            Button85.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f85] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button86.BackColor = Color.Gold Then
            Button86.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f86] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button87.BackColor = Color.Gold Then
            Button87.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f87] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button88.BackColor = Color.Gold Then
            Button88.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f88] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button89.BackColor = Color.Gold Then
            Button89.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f89] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button90.BackColor = Color.Gold Then
            Button90.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f90] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button91.BackColor = Color.Gold Then
            Button91.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f91] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button92.BackColor = Color.Gold Then
            Button92.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f92] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button93.BackColor = Color.Gold Then
            Button93.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f93] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button94.BackColor = Color.Gold Then
            Button94.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f94] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button95.BackColor = Color.Gold Then
            Button95.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f95] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button96.BackColor = Color.Gold Then
            Button96.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f96] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button97.BackColor = Color.Gold Then
            Button97.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f97] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button98.BackColor = Color.Gold Then
            Button98.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f98] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button99.BackColor = Color.Gold Then
            Button99.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f99] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button100.BackColor = Color.Gold Then
            Button100.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f100] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()



        End If

        If Button101.BackColor = Color.Gold Then
            Button101.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f101] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button102.BackColor = Color.Gold Then
            Button102.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f102] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button103.BackColor = Color.Gold Then
            Button103.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f103] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button104.BackColor = Color.Gold Then
            Button104.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f104] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button105.BackColor = Color.Gold Then
            Button105.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f105] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button106.BackColor = Color.Gold Then
            Button106.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f106] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button107.BackColor = Color.Gold Then
            Button107.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f107] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button108.BackColor = Color.Gold Then
            Button108.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f108] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button109.BackColor = Color.Gold Then
            Button109.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f109] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button110.BackColor = Color.Gold Then
            Button110.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f110] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button111.BackColor = Color.Gold Then
            Button111.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f111] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button112.BackColor = Color.Gold Then
            Button112.Enabled = False
            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [f112] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '     MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If



        If Button113.BackColor = Color.Ivory Then
            Button113.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s1] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If






        If Button114.BackColor = Color.Ivory Then
            Button114.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s2] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button115.BackColor = Color.Ivory Then
            Button115.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s3] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()



        End If

        If Button116.BackColor = Color.Ivory Then
            Button116.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s4] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button117.BackColor = Color.Ivory Then
            Button117.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s5] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button118.BackColor = Color.Ivory Then
            Button118.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s6] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button119.BackColor = Color.Ivory Then
            Button119.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s7] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button120.BackColor = Color.Ivory Then
            Button120.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s8] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button121.BackColor = Color.Ivory Then
            Button121.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s9] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button122.BackColor = Color.Ivory Then
            Button122.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s10] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()


        End If

        If Button123.BackColor = Color.Ivory Then
            Button123.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s11] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button124.BackColor = Color.Ivory Then
            Button124.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s12] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button125.BackColor = Color.Ivory Then
            Button125.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s13] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()



        End If

        If Button126.BackColor = Color.Ivory Then
            Button126.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s14] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button127.BackColor = Color.Ivory Then
            Button127.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s15] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button128.BackColor = Color.Ivory Then
            Button128.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s16] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button129.BackColor = Color.Ivory Then
            Button129.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s17] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button130.BackColor = Color.Ivory Then
            Button130.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s18] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button131.BackColor = Color.Ivory Then
            Button131.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s19] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button132.BackColor = Color.Ivory Then
            Button132.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s20] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button133.BackColor = Color.Ivory Then
            Button133.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s21] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button134.BackColor = Color.Ivory Then
            Button134.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s22] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button135.BackColor = Color.Ivory Then
            Button135.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s23] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button136.BackColor = Color.Ivory Then
            Button136.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s24] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button137.BackColor = Color.Ivory Then
            Button137.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s25] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button138.BackColor = Color.Ivory Then
            Button138.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s26] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button139.BackColor = Color.Ivory Then
            Button139.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s27] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button140.BackColor = Color.Ivory Then
            Button140.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s28] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button141.BackColor = Color.Ivory Then
            Button141.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s29] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button142.BackColor = Color.Ivory Then
            Button142.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s30] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button143.BackColor = Color.Ivory Then
            Button143.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s31] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button144.BackColor = Color.Ivory Then
            Button144.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s32] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If



        If Button145.BackColor = Color.Ivory Then
            Button145.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s33] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button146.BackColor = Color.Ivory Then
            Button146.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s34] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button147.BackColor = Color.Ivory Then
            Button147.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s35] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button148.BackColor = Color.Ivory Then
            Button148.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s36] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button149.BackColor = Color.Ivory Then
            Button149.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s37] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button150.BackColor = Color.Ivory Then
            Button150.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s38] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button151.BackColor = Color.Ivory Then
            Button151.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s39] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button152.BackColor = Color.Ivory Then
            Button152.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s40] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button153.BackColor = Color.Ivory Then
            Button153.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s41] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button154.BackColor = Color.Ivory Then
            Button154.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s42] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button155.BackColor = Color.Ivory Then
            Button155.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s43] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button156.BackColor = Color.Ivory Then
            Button156.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s44] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button157.BackColor = Color.Ivory Then
            Button157.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s45] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button158.BackColor = Color.Ivory Then
            Button158.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s46] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button159.BackColor = Color.Ivory Then
            Button159.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s47] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()





        End If
        If Button160.BackColor = Color.Ivory Then
            Button160.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [s48] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If

        If Button161.BackColor = Color.SpringGreen Then
            Button161.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b1] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        If Button162.BackColor = Color.SpringGreen Then
            Button162.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b2] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button163.BackColor = Color.SpringGreen Then
            Button163.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b3] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button164.BackColor = Color.SpringGreen Then
            Button164.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b4] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button165.BackColor = Color.SpringGreen Then
            Button165.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b5] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button166.BackColor = Color.SpringGreen Then
            Button166.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b6] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button167.BackColor = Color.SpringGreen Then
            Button167.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b7] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button168.BackColor = Color.SpringGreen Then
            Button168.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b8] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button169.BackColor = Color.SpringGreen Then
            Button169.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b9] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button170.BackColor = Color.SpringGreen Then
            Button170.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b10] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button171.BackColor = Color.SpringGreen Then
            Button171.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b11] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button172.BackColor = Color.SpringGreen Then
            Button172.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b12] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button173.BackColor = Color.SpringGreen Then
            Button173.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b13] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button174.BackColor = Color.SpringGreen Then
            Button174.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b14] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button175.BackColor = Color.SpringGreen Then
            Button175.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b15] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button176.BackColor = Color.SpringGreen Then
            Button176.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b16] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button177.BackColor = Color.SpringGreen Then
            Button177.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b17] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button178.BackColor = Color.SpringGreen Then
            Button178.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b18] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button179.BackColor = Color.SpringGreen Then
            Button179.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b19] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button180.BackColor = Color.SpringGreen Then
            Button180.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b20] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button181.BackColor = Color.SpringGreen Then
            Button181.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b21] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button182.BackColor = Color.SpringGreen Then
            Button182.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b22] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button183.BackColor = Color.SpringGreen Then
            Button183.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b23] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button184.BackColor = Color.SpringGreen Then
            Button184.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b24] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button185.BackColor = Color.SpringGreen Then
            Button185.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b25] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button186.BackColor = Color.SpringGreen Then
            Button186.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b26] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button187.BackColor = Color.SpringGreen Then
            Button187.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b27] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button188.BackColor = Color.SpringGreen Then
            Button188.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b28] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button189.BackColor = Color.SpringGreen Then
            Button189.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b29] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button190.BackColor = Color.SpringGreen Then
            Button190.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b30] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button191.BackColor = Color.SpringGreen Then
            Button191.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b31] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button192.BackColor = Color.SpringGreen Then
            Button192.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b32] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button193.BackColor = Color.SpringGreen Then
            Button193.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b33] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button194.BackColor = Color.SpringGreen Then
            Button194.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b34] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button195.BackColor = Color.SpringGreen Then
            Button195.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b35] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button196.BackColor = Color.SpringGreen Then
            Button196.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b36] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button197.BackColor = Color.SpringGreen Then
            Button197.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b37] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button198.BackColor = Color.SpringGreen Then
            Button198.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b38] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If

        If Button199.BackColor = Color.SpringGreen Then
            Button199.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b39] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If




        If Button200.BackColor = Color.SpringGreen Then
            Button200.Enabled = False


            Dim updaterow As Integer = 0

            Dim newpa As Integer = 0
            con = New OleDbConnection(ck)
            con.Open()
            Dim co As String = "update [reservetab3] set [b40] = '" & newpa & "' where [resDate]=#" & DateTimePicker1.Text & "#"

            cmd = New OleDbCommand(co)

            cmd.Connection = con
            updaterow = cmd.ExecuteNonQuery
            If updaterow > 0 Then
                '   MessageBox.Show("Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Not Successful!", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

        End If


        Dim updaterow1 As Integer = 0
        con = New OleDbConnection(ck)
        con.Open()
        Dim ct As String = "select * from [DCR] where [currdate]=#" & DateTimePicker1.Text & "#"
        Dim cmd1 As New OleDbCommand(ct)
        cmd1.Connection = con
        rdr = cmd1.ExecuteReader()
        rdr.Read()

        Dim co1 As String = "update [DCR] set [balcony3] = '" & balcony & "',[firstclass3] = '" & first & "',[second class3] = '" & second & "' where [currdate]=#" & DateTimePicker1.Text & "#"
        cmd = New OleDbCommand(co1)

        cmd.Connection = con
        updaterow1 = cmd.ExecuteNonQuery
        If updaterow1 > 0 Then

        Else
            MessageBox.Show("Something happened !", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button203_Click(sender As Object, e As EventArgs) Handles Button203.Click

        Me.Close()
        Form3.Show()

    End Sub

    Private Sub Button113_Click(sender As Object, e As EventArgs) Handles Button113.Click
        If Button113.BackColor = Color.Red Then
            Button113.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button113.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button114_Click(sender As Object, e As EventArgs) Handles Button114.Click
        If Button114.BackColor = Color.Red Then
            Button114.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button114.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button115_Click(sender As Object, e As EventArgs) Handles Button115.Click
        If Button115.BackColor = Color.Red Then
            Button115.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button115.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button116_Click(sender As Object, e As EventArgs) Handles Button116.Click
        If Button116.BackColor = Color.Red Then
            Button116.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button116.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button117_Click(sender As Object, e As EventArgs) Handles Button117.Click
        If Button117.BackColor = Color.Red Then
            Button117.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button117.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button118_Click(sender As Object, e As EventArgs) Handles Button118.Click
        If Button118.BackColor = Color.Red Then
            Button118.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button118.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button119_Click(sender As Object, e As EventArgs) Handles Button119.Click
        If Button119.BackColor = Color.Red Then
            Button119.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button119.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button120_Click(sender As Object, e As EventArgs) Handles Button120.Click
        If Button120.BackColor = Color.Red Then
            Button120.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button120.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button121_Click(sender As Object, e As EventArgs) Handles Button121.Click
        If Button121.BackColor = Color.Red Then
            Button121.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button121.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button122_Click(sender As Object, e As EventArgs) Handles Button122.Click
        If Button122.BackColor = Color.Red Then
            Button122.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button122.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button123_Click(sender As Object, e As EventArgs) Handles Button123.Click
        If Button123.BackColor = Color.Red Then
            Button123.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button123.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub


    Private Sub Button124_Click(sender As Object, e As EventArgs) Handles Button124.Click
        If Button124.BackColor = Color.Red Then
            Button124.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button124.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button125_Click(sender As Object, e As EventArgs) Handles Button125.Click
        If Button125.BackColor = Color.Red Then
            Button125.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button125.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button126_Click(sender As Object, e As EventArgs) Handles Button126.Click
        If Button126.BackColor = Color.Red Then
            Button126.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button126.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button127_Click(sender As Object, e As EventArgs) Handles Button127.Click
        If Button127.BackColor = Color.Red Then
            Button127.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button127.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button128_Click(sender As Object, e As EventArgs) Handles Button128.Click
        If Button128.BackColor = Color.Red Then
            Button128.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button128.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub


    Private Sub Button129_Click(sender As Object, e As EventArgs) Handles Button129.Click
        If Button129.BackColor = Color.Red Then
            Button129.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button129.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button130_Click(sender As Object, e As EventArgs) Handles Button130.Click
        If Button130.BackColor = Color.Red Then
            Button130.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button130.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button131_Click(sender As Object, e As EventArgs) Handles Button131.Click
        If Button131.BackColor = Color.Red Then
            Button131.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button131.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button132_Click(sender As Object, e As EventArgs) Handles Button132.Click
        If Button132.BackColor = Color.Red Then
            Button132.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button132.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button133_Click(sender As Object, e As EventArgs) Handles Button133.Click
        If Button133.BackColor = Color.Red Then
            Button133.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button133.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button134_Click(sender As Object, e As EventArgs) Handles Button134.Click
        If Button134.BackColor = Color.Red Then
            Button134.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button134.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button135_Click(sender As Object, e As EventArgs) Handles Button135.Click
        If Button135.BackColor = Color.Red Then
            Button135.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button135.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button136_Click(sender As Object, e As EventArgs) Handles Button136.Click
        If Button136.BackColor = Color.Red Then
            Button136.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button136.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button137_Click(sender As Object, e As EventArgs) Handles Button137.Click
        If Button137.BackColor = Color.Red Then
            Button137.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button137.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button138_Click(sender As Object, e As EventArgs) Handles Button138.Click
        If Button138.BackColor = Color.Red Then
            Button138.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button138.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button139_Click(sender As Object, e As EventArgs) Handles Button139.Click
        If Button139.BackColor = Color.Red Then
            Button139.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button139.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button140_Click(sender As Object, e As EventArgs) Handles Button140.Click
        If Button140.BackColor = Color.Red Then
            Button140.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button140.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button141_Click(sender As Object, e As EventArgs) Handles Button141.Click
        If Button141.BackColor = Color.Red Then
            Button141.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button141.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button142_Click(sender As Object, e As EventArgs) Handles Button142.Click
        If Button142.BackColor = Color.Red Then
            Button142.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button142.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button143_Click(sender As Object, e As EventArgs) Handles Button143.Click
        If Button143.BackColor = Color.Red Then
            Button143.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button143.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button144_Click(sender As Object, e As EventArgs) Handles Button144.Click
        If Button144.BackColor = Color.Red Then
            Button144.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button144.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button145_Click(sender As Object, e As EventArgs) Handles Button145.Click
        If Button145.BackColor = Color.Red Then
            Button145.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button145.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button146_Click(sender As Object, e As EventArgs) Handles Button146.Click
        If Button146.BackColor = Color.Red Then
            Button146.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button146.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button147_Click(sender As Object, e As EventArgs) Handles Button147.Click
        If Button147.BackColor = Color.Red Then
            Button147.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button147.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button148_Click(sender As Object, e As EventArgs) Handles Button148.Click
        If Button148.BackColor = Color.Red Then
            Button148.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button148.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button149_Click(sender As Object, e As EventArgs) Handles Button149.Click
        If Button149.BackColor = Color.Red Then
            Button149.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button149.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button150_Click(sender As Object, e As EventArgs) Handles Button150.Click
        If Button150.BackColor = Color.Red Then
            Button150.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button150.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button151_Click(sender As Object, e As EventArgs) Handles Button151.Click
        If Button151.BackColor = Color.Red Then
            Button151.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button151.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button152_Click(sender As Object, e As EventArgs) Handles Button152.Click
        If Button152.BackColor = Color.Red Then
            Button152.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button152.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button153_Click(sender As Object, e As EventArgs) Handles Button153.Click
        If Button153.BackColor = Color.Red Then
            Button153.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button153.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button154_Click(sender As Object, e As EventArgs) Handles Button154.Click
        If Button154.BackColor = Color.Red Then
            Button154.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button154.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub


    Private Sub Button155_Click(sender As Object, e As EventArgs) Handles Button155.Click
        If Button155.BackColor = Color.Red Then
            Button155.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button155.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button156_Click(sender As Object, e As EventArgs) Handles Button156.Click
        If Button156.BackColor = Color.Red Then
            Button156.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button156.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button157_Click(sender As Object, e As EventArgs) Handles Button157.Click
        If Button157.BackColor = Color.Red Then
            Button157.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button157.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button158_Click(sender As Object, e As EventArgs) Handles Button158.Click
        If Button158.BackColor = Color.Red Then
            Button158.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button158.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button159_Click(sender As Object, e As EventArgs) Handles Button159.Click
        If Button159.BackColor = Color.Red Then
            Button159.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button159.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub



    Private Sub Button160_Click(sender As Object, e As EventArgs) Handles Button160.Click

        If Button160.BackColor = Color.Red Then
            Button160.BackColor = Color.Ivory
            second = second - 1
        Else
            second = second + 1
            Button160.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub



    Private Sub Button161_Click(sender As Object, e As EventArgs) Handles Button161.Click

        If Button161.BackColor = Color.Red Then
            Button161.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button161.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button162_Click(sender As Object, e As EventArgs) Handles Button162.Click

        If Button162.BackColor = Color.Red Then
            Button162.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button162.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button163_Click(sender As Object, e As EventArgs) Handles Button163.Click

        If Button163.BackColor = Color.Red Then
            Button163.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button163.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button164_Click(sender As Object, e As EventArgs) Handles Button164.Click

        If Button164.BackColor = Color.Red Then
            Button164.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button164.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button165_Click(sender As Object, e As EventArgs) Handles Button165.Click

        If Button165.BackColor = Color.Red Then
            Button165.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button165.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button166_Click(sender As Object, e As EventArgs) Handles Button166.Click

        If Button166.BackColor = Color.Red Then
            Button166.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button166.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button167_Click(sender As Object, e As EventArgs) Handles Button167.Click

        If Button167.BackColor = Color.Red Then
            Button167.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button167.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button168_Click(sender As Object, e As EventArgs) Handles Button168.Click

        If Button168.BackColor = Color.Red Then
            Button168.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button168.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button169_Click(sender As Object, e As EventArgs) Handles Button169.Click

        If Button169.BackColor = Color.Red Then
            Button169.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button169.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button170_Click(sender As Object, e As EventArgs) Handles Button170.Click

        If Button170.BackColor = Color.Red Then
            Button170.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button170.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button171_Click(sender As Object, e As EventArgs) Handles Button171.Click

        If Button171.BackColor = Color.Red Then
            Button171.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button171.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button172_Click(sender As Object, e As EventArgs) Handles Button172.Click

        If Button172.BackColor = Color.Red Then
            Button172.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button172.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button173_Click(sender As Object, e As EventArgs) Handles Button173.Click

        If Button173.BackColor = Color.Red Then
            Button173.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button173.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button174_Click(sender As Object, e As EventArgs) Handles Button174.Click

        If Button174.BackColor = Color.Red Then
            Button174.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button174.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button175_Click(sender As Object, e As EventArgs) Handles Button175.Click

        If Button175.BackColor = Color.Red Then
            Button175.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button175.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button176_Click(sender As Object, e As EventArgs) Handles Button176.Click

        If Button176.BackColor = Color.Red Then
            Button176.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button176.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button177_Click(sender As Object, e As EventArgs) Handles Button177.Click

        If Button177.BackColor = Color.Red Then
            Button177.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button177.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button178_Click(sender As Object, e As EventArgs) Handles Button178.Click

        If Button178.BackColor = Color.Red Then
            Button178.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button178.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button179_Click(sender As Object, e As EventArgs) Handles Button179.Click

        If Button179.BackColor = Color.Red Then
            Button179.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button179.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button180_Click(sender As Object, e As EventArgs) Handles Button180.Click

        If Button180.BackColor = Color.Red Then
            Button180.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button180.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button181_Click(sender As Object, e As EventArgs) Handles Button181.Click

        If Button181.BackColor = Color.Red Then
            Button181.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button181.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button182_Click(sender As Object, e As EventArgs) Handles Button182.Click

        If Button182.BackColor = Color.Red Then
            Button182.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button182.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button183_Click(sender As Object, e As EventArgs) Handles Button183.Click

        If Button183.BackColor = Color.Red Then
            Button183.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button183.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button184_Click(sender As Object, e As EventArgs) Handles Button184.Click

        If Button184.BackColor = Color.Red Then
            Button184.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button184.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button185_Click(sender As Object, e As EventArgs) Handles Button185.Click

        If Button185.BackColor = Color.Red Then
            Button185.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button185.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button186_Click(sender As Object, e As EventArgs) Handles Button186.Click

        If Button186.BackColor = Color.Red Then
            Button186.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button186.BackColor = Color.Red
        End If


        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub

    Private Sub Button187_Click(sender As Object, e As EventArgs) Handles Button187.Click

        If Button187.BackColor = Color.Red Then
            Button187.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button187.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button188_Click(sender As Object, e As EventArgs) Handles Button188.Click

        If Button188.BackColor = Color.Red Then
            Button188.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button188.BackColor = Color.Red
        End If

        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)

    End Sub

    Private Sub Button189_Click(sender As Object, e As EventArgs) Handles Button189.Click

        If Button189.BackColor = Color.Red Then
            Button189.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button189.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button190_Click(sender As Object, e As EventArgs) Handles Button190.Click

        If Button190.BackColor = Color.Red Then
            Button190.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button190.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button191_Click(sender As Object, e As EventArgs) Handles Button191.Click

        If Button191.BackColor = Color.Red Then
            Button191.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button191.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button192_Click(sender As Object, e As EventArgs) Handles Button192.Click

        If Button192.BackColor = Color.Red Then
            Button192.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button192.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button193_Click(sender As Object, e As EventArgs) Handles Button193.Click

        If Button193.BackColor = Color.Red Then
            Button193.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button193.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button194_Click(sender As Object, e As EventArgs) Handles Button194.Click

        If Button194.BackColor = Color.Red Then
            Button194.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button194.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub
    Private Sub Button195_Click(sender As Object, e As EventArgs) Handles Button195.Click

        If Button195.BackColor = Color.Red Then
            Button195.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button195.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button196_Click(sender As Object, e As EventArgs) Handles Button196.Click

        If Button196.BackColor = Color.Red Then
            Button196.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button196.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button197_Click(sender As Object, e As EventArgs) Handles Button197.Click

        If Button197.BackColor = Color.Red Then
            Button197.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button197.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button198_Click(sender As Object, e As EventArgs) Handles Button198.Click

        If Button198.BackColor = Color.Red Then
            Button198.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button198.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button199_Click(sender As Object, e As EventArgs) Handles Button199.Click

        If Button199.BackColor = Color.Red Then
            Button199.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button199.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)


    End Sub

    Private Sub Button200_Click(sender As Object, e As EventArgs) Handles Button200.Click
        If Button200.BackColor = Color.Red Then
            Button200.BackColor = Color.SpringGreen
            balcony = balcony - 1
        Else
            balcony = balcony + 1
            Button200.BackColor = Color.Red
        End If
        TextBox1.Text = balcony + first + second
        TextBox2.Text = (balcony * bprice) + (first * fprice) + (second * sprice)
    End Sub






   
  
End Class

