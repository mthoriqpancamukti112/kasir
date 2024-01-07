Public Class Form_InputDataPelanggan

    Private Sub Form_InputDataPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _kondisi = True Then
            Call IDPelanggan()
        End If
    End Sub


    Private Sub Bersih()
        txtIDPelanggan.Focus()
        txtNamapelanggan.Clear()
        txtAlamat.Clear()
        txtKontak.Clear()
    End Sub

    Sub IDPelanggan()
        Dim Tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hhmmss")
        Dim ID As String = "IDP -" & Tgl & Jam
        txtIDPelanggan.Text = ID
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtIDPelanggan.Text = "" Or txtNamapelanggan.Text = "" Or txtAlamat.Text = "" Or txtKontak.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else

            If _kondisi = True Then
                _db.manipulasiData("Insert Ignore Into tbl_pelanggan Values('" & txtIDPelanggan.Text & "','" & txtNamapelanggan.Text & "','" & txtAlamat.Text & "','" & txtKontak.Text & "')", "Simpan")
            Else
                _db.manipulasiData("Update Tbl_Pelanggan Set Nama_Pelanggan = '" & txtNamapelanggan.Text & "', Alamat ='" & txtAlamat.Text & "', Kontak = '" & txtKontak.Text & "' Where ID_Pelanggan ='" & txtIDPelanggan.Text & "'", "Ubah")
            End If

            _kondisi = True
            Form_DataPelanggan.RefreshDataPelanggan()
            Call Bersih()
            Call IDPelanggan()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class