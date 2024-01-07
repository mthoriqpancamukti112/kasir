Public Class Form_InputDataJenis

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Form_InputDataJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _kondisi = True Then
            Call IDJenis()
        End If


    End Sub

    Private Sub Bersih()
        txtID.Focus()
        txtJenis.Clear()
        txtKeterangan.Clear()
    End Sub

    Sub IDJenis()
        Dim Tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hhmmss")
        Dim ID As String = "IDJ -" & Tgl & Jam
        txtID.Text = ID
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtID.Text = "" Or txtJenis.Text = "" Or txtKeterangan.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else

            If _kondisi = True Then
                _db.manipulasiData("Insert Ignore Into tbl_Jenis Values('" & txtID.Text &
                                   "','" & txtJenis.Text & "','" & txtKeterangan.Text & "')", "Simpan")

            Else
                _db.manipulasiData("Update Tbl_Jenis Set Jenis = '" & txtJenis.Text &
                                   "', Keterangan ='" & txtKeterangan.Text &
                                   "' Where ID_Jenis ='" & txtID.Text & "'", "Ubah")
            End If

            _kondisi = True
            Form_DataJenis.RefreshDataJenis()
            Call Bersih()
            Call IDJenis()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class