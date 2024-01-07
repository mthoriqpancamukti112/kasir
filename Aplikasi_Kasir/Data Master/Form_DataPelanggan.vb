Public Class Form_DataPelanggan
    Sub TampilDataPelanggan()
        _db.tampilTabel1(GridDataPelanggan, "SELECT * FROM TBL_PELANGGAN")
    End Sub
    Sub RapikanGrid()
        GridDataPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        With GridDataPelanggan
            .Columns(0).HeaderText = "ID Pelanggan"
            .Columns(1).HeaderText = "Nama Pelanggan"
            .Columns(2).HeaderText = "Alamat"
            .Columns(3).HeaderText = "Kontak"
        End With
    End Sub
    Sub RefreshDataPelanggan()
        Call TampilDataPelanggan()
        Call RapikanGrid()
    End Sub
    Private Sub Form_DataPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataPelanggan()
    End Sub

        Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
            _kondisi = True
        _fs.formShow(False, Form_InputDataPelanggan, Me)
        End Sub

        Private Sub HapusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem1.Click
            Dim tanya As Object
            tanya = MsgBox("Yakin hapus data?", vbQuestion + vbYesNo, "Informasi") = vbYes = True
            If tanya = True Then
            _db.manipulasiData("Delete from tbl_pelanggan where ID_Pelanggan ='" & GridDataPelanggan.Item(0, GridDataPelanggan.CurrentRow.Index).Value & "'", "Hapus")
        End If
        Call RefreshDataPelanggan()
        End Sub



        Private Sub PilihToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihToolStripMenuItem.Click
        With GridDataPelanggan
            Form_InputDataPelanggan.txtIDPelanggan.Text = .Item(0, .CurrentRow.Index).Value 'Id suplier
            Form_InputDataPelanggan.txtNamapelanggan.Text = .Item(1, .CurrentRow.Index).Value 'Nama suplier
            Form_InputDataPelanggan.txtAlamat.Text = .Item(2, .CurrentRow.Index).Value 'Alamat
            Form_InputDataPelanggan.txtKontak.Text = .Item(3, .CurrentRow.Index).Value 'Kontak
            _kondisi = False
            Form_InputDataPelanggan.ShowDialog()
        End With
        End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        Dim cari As String = txtPencarian.Text.Trim()

        If cari <> "" Then
            Dim query As String = "SELECT * FROM tbl_pelanggan WHERE Nama_Pelanggan LIKE '%" & cari & "%'"

            Call _db.tampilTabel1(GridDataPelanggan, query)
        Else
            Call RefreshDataPelanggan()
        End If
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDataToolStripMenuItem.Click
        Call RefreshDataPelanggan()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        txtPencarian.Clear()
    End Sub
End Class