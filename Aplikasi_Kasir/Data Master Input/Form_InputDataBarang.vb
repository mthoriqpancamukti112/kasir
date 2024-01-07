Public Class Form_InputDataBarang

    Private Sub Form_InputDataBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _kondisi = True Then
            Call ID()
        End If
    End Sub


    Private Sub Bersih()
        txtID.Focus()
        txtNamaBarang.Clear()
        txtIDJenis.Clear()
        txtMerek.Clear()
        txtSatuan.Clear()
        txtHrgbeli.Clear()
        txtHrgjual.Clear()
        txtSelisih.Clear()
        txtStok.Clear()
    End Sub

    Sub ID()
        Dim Tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hhmmss")
        Dim ID As String = "IDB -" & Tgl & Jam
        txtID.Text = ID
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtID.Text = "" Or txtNamaBarang.Text = "" Or txtIDJenis.Text = "" Or txtMerek.Text = "" Or txtSatuan.Text = "" Or txtHrgbeli.Text = "" Or txtHrgjual.Text = "" Or txtSelisih.Text = "" Or txtStok.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else

            If _kondisi = True Then
                _db.manipulasiData("Insert Ignore Into tbl_barang Values('" & txtID.Text & "','" & txtNamaBarang.Text & "','" & txtIDJenis.Text & "','" & txtMerek.Text & "','" & txtSatuan.Text & "','" & txtHrgbeli.Text & "','" & txtHrgjual.Text & "','" & txtSelisih.Text & "','" & txtStok.Text & "')", "Simpan")
            Else
                _db.manipulasiData("Update tbl_barang Set Nama_Barang = '" & txtNamaBarang.Text & "', Id_Jenis ='" & txtIDJenis.Text & "', Merek = '" & txtMerek.Text & "', Satuan = '" & txtSatuan.Text & "', Harga_Beli = '" & txtHrgbeli.Text & "', Harga_Jual = '" & txtHrgjual.Text & "', Selisih = '" & txtSelisih.Text & "', Stok = '" & txtStok.Text & "' Where ID_Barang ='" & txtID.Text & "'", "Ubah")
            End If

            _kondisi = True
            Form_DataBarang.RefreshDataBarang()
            Call Bersih()
            Call ID()
        End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _fs.formShow(False, Form_ViewJenis, Me)
    End Sub
End Class