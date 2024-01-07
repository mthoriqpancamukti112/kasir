Imports alfathNET
Imports MySql.Data.MySqlClient
Module Driverr
    Public _db As New Database
    Public _fs As New Fungsi
    Public _lp As New Laporan
    Public _kondisi As New Boolean

    Sub Koneksidatabase()
        Try
            Dim IP, User, Pass, data_base, Port As String
            With Form_Database
                IP = .txtIp.Text
                User = .txtUser.Text
                Pass = .txtPass.Text
                data_base = .txtDB.Text
                Port = .cbPort.Text
            End With
            _db.Koneksi(IP, User, Pass, data_base, Port, Form_utama.StatusDB)
            If Form_utama.StatusDB.Text = "Connected" Then
                Form_Database.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
