
Public Class Form_InputDataDistributor

    Private Sub Form_InputDataDistributor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _kondisi = True Then
            Call IDsuplier()
        End If
    End Sub

    Private Sub Bersih()
        txtIDsuplier.Focus()
        txtNamaSuplier.Clear()
        txtAlamat.Clear()
        txtEmail.Clear()
        txtKontak.Clear()
    End Sub

    Sub IDsuplier()
        Dim Tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hhmmss")
        Dim ID As String = "IDS -" & Tgl & Jam
        txtIDsuplier.Text = ID


    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtIDsuplier.Text = "" Or txtNamaSuplier.Text = "" Or txtAlamat.Text = "" Or txtEmail.Text = "" Or txtKontak.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else

            If _kondisi = True Then
                _db.manipulasiData("Insert Ignore Into tbl_distributor Values('" & txtIDsuplier.Text &
                                   "','" & txtNamaSuplier.Text & "','" & txtAlamat.Text & "','" & txtEmail.Text & "','" & txtKontak.Text & "')", "Simpan")

            Else
                _db.manipulasiData("Update tbl_distributor Set Nama_Suplier = '" & txtNamaSuplier.Text &
                                   "', Alamat ='" & txtAlamat.Text & "', Email = '" & txtEmail.Text & "', Kontak = '" & txtKontak.Text &
                                   "' Where ID_Suplier ='" & txtIDsuplier.Text & "'", "Ubah")
            End If

            _kondisi = True
            Form_DataDistributor.RefreshDataDistributor()
            Call Bersih()
            Call IDsuplier()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
