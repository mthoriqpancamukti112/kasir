Public Class Form_DataDistributor

    Sub TampilDataDistributor()
        _db.tampilTabel1(GridDataDistributor, "SELECT * FROM TBL_DISTRIBUTOR")
    End Sub
    Sub RapikanGrid()
        GridDataDistributor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        With GridDataDistributor
            .Columns(0).HeaderText = "ID Suplier"
            .Columns(1).HeaderText = "Nama Suplier"
            .Columns(2).HeaderText = "Alamat"
            .Columns(3).HeaderText = "Email"
            .Columns(4).HeaderText = "Kontak"
        End With
    End Sub
    Sub RefreshDataDistributor()
        Call TampilDataDistributor()
        Call RapikanGrid()
    End Sub
    Private Sub Form_DataDistributor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataDistributor()
    End Sub

        Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
            _kondisi = True
        _fs.formShow(False, Form_InputDataDistributor, Me)
        End Sub

        Private Sub HapusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem1.Click
            Dim tanya As Object
            tanya = MsgBox("Yakin hapus data?", vbQuestion + vbYesNo, "Informasi") = vbYes = True
            If tanya = True Then
            _db.manipulasiData("Delete from tbl_barang where ID_Distributor ='" & GridDataDistributor.Item(0, GridDataDistributor.CurrentRow.Index).Value & "'", "Hapus")
        End If
        Call RefreshDataDistributor()
        End Sub

        Private Sub PilihToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihToolStripMenuItem.Click
        With GridDataDistributor
            Form_InputDataDistributor.txtIDsuplier.Text = .Item(0, .CurrentRow.Index).Value 'Id suplier
            Form_InputDataDistributor.txtNamaSuplier.Text = .Item(1, .CurrentRow.Index).Value 'Nama suplier
            Form_InputDataDistributor.txtAlamat.Text = .Item(2, .CurrentRow.Index).Value 'Alamat
            Form_InputDataDistributor.txtEmail.Text = .Item(3, .CurrentRow.Index).Value 'Email
            Form_InputDataDistributor.txtKontak.Text = .Item(4, .CurrentRow.Index).Value 'Kontak
            _kondisi = False
            Form_InputDataDistributor.ShowDialog()
        End With
    End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        Dim cari As String = txtPencarian.Text.Trim()

        If cari <> "" Then
            Dim query As String = "SELECT * FROM tbl_distributor WHERE Nama_Suplier LIKE '%" & cari & "%'"

            Call _db.tampilTabel1(GridDataDistributor, query)
        Else
            Call RefreshDataDistributor()
        End If
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDataToolStripMenuItem.Click
        Call RefreshDataDistributor()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        txtPencarian.Clear()
    End Sub
End Class