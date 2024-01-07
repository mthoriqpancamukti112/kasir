Public Class Form_InputDataStaf

    Private Sub Form_InputDataStaf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _kondisi = True Then
            Call IDstaf()
        End If
    End Sub


    Private Sub Bersih()
        txtIDstaf.Focus()
        txtNamastaf.Clear()
        txtAlamat.Clear()
        txtKontak.Clear()
    End Sub

    Sub IDstaf()
        Dim Tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hhmmss")
        Dim ID As String = "IDS -" & Tgl & Jam
        txtIDstaf.Text = ID
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtIDstaf.Text = "" Or txtNamastaf.Text = "" Or txtAlamat.Text = "" Or txtKontak.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else

            If _kondisi = True Then
                _db.manipulasiData("Insert Ignore Into tbl_staf Values('" & txtIDstaf.Text & "','" & txtNamastaf.Text & "','" & txtAlamat.Text & "','" & txtKontak.Text & "')", "Simpan")
            Else
                _db.manipulasiData("Update tbl_staf Set Nama_Staf = '" & txtNamastaf.Text & "', Alamat ='" & txtAlamat.Text & "', Kontak = '" & txtKontak.Text & "' Where ID_Staf ='" & txtIDstaf.Text & "'", "Ubah")
            End If

            _kondisi = True
            Form_DataStaf.RefreshDataStaf()
            Call Bersih()
            Call IDstaf()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class