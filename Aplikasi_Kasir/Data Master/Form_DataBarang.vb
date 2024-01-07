Public Class Form_DataBarang

    Sub TampilDataBarang()
        _db.tampilTabel1(GridDataBarang, "SELECT * FROM TBL_BARANG")
    End Sub
    Sub RapikanGrid()
        GridDataBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        With GridDataBarang
            .Columns(0).HeaderText = "ID Barang"
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "ID Jenis"
            .Columns(3).HeaderText = "Merek"
            .Columns(4).HeaderText = "Satuan"
            .Columns(5).HeaderText = "Harga Jual"
            .Columns(6).HeaderText = "Harga Beli"
            .Columns(7).HeaderText = "Selisih"
            .Columns(8).HeaderText = "Stok"
        End With
    End Sub
    Sub RefreshDataBarang()
        Call TampilDataBarang()
        Call RapikanGrid()
    End Sub
    Private Sub Form_DataBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataBarang()
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        _kondisi = True
        _fs.formShow(False, Form_InputDataBarang, Me)
    End Sub

    Private Sub HapusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem1.Click
        Dim tanya As Object
        tanya = MsgBox("Yakin hapus data?", vbQuestion + vbYesNo, "Informasi") = vbYes = True
        If tanya = True Then
            _db.manipulasiData("Delete from tbl_barang where ID_Barang ='" & GridDataBarang.Item(0, GridDataBarang.CurrentRow.Index).Value & "'", "Hapus")
        End If
        Call RefreshDataBarang()
    End Sub

    Private Sub PilihToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihToolStripMenuItem.Click
        With GridDataBarang
            Form_InputDataBarang.txtID.Text = .Item(0, .CurrentRow.Index).Value 'Id barang
            Form_InputDataBarang.txtNamaBarang.Text = .Item(1, .CurrentRow.Index).Value 'Nama barang
            Form_InputDataBarang.txtIDJenis.Text = .Item(2, .CurrentRow.Index).Value 'Id jenis
            Form_InputDataBarang.txtMerek.Text = .Item(3, .CurrentRow.Index).Value 'Merek
            Form_InputDataBarang.txtSatuan.Text = .Item(4, .CurrentRow.Index).Value 'Satuan
            Form_InputDataBarang.txtHrgbeli.Text = .Item(5, .CurrentRow.Index).Value 'Harga  beli
            Form_InputDataBarang.txtHrgjual.Text = .Item(6, .CurrentRow.Index).Value 'Harga jual
            Form_InputDataBarang.txtSelisih.Text = .Item(7, .CurrentRow.Index).Value 'Selisih
            Form_InputDataBarang.txtStok.Text = .Item(8, .CurrentRow.Index).Value 'Stok
            _kondisi = False
            Form_InputDataBarang.ShowDialog()
        End With
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDataToolStripMenuItem.Click
        Call RefreshDataBarang()
    End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        Dim cari As String = txtPencarian.Text.Trim()

        If cari <> "" Then
            Dim query As String = "SELECT * FROM tbl_barang WHERE Nama_Barang LIKE '%" & cari & "%'"

            Call _db.tampilTabel1(GridDataBarang, query)
        Else
            Call RefreshDataBarang()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        txtPencarian.Clear()
    End Sub
End Class