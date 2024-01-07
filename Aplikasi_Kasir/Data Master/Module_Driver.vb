Imports alfathNET
Imports MySql.Data.MySqlClient
Module Driver
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
                Port = .cbPort.Text
            End With
            _db.Koneksi(IP, User, Pass, data_base, Port, Form1.StatusDB)
            If Form1.StatusDB.Text = "Connected" Then
                Form_Database.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Module
