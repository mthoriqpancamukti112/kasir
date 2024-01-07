Public Class Form_DataStaf
    Sub TampilDataStaf()
        _db.tampilTabel1(GridDataStaf, "SELECT * FROM TBL_STAF")
    End Sub
    Sub RapikanGrid()
        GridDataStaf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        With GridDataStaf
            .Columns(0).HeaderText = "ID Staf"
            .Columns(1).HeaderText = "Nama Staf"
            .Columns(2).HeaderText = "Alamat"
            .Columns(3).HeaderText = "Kontak"
        End With
    End Sub
    Sub RefreshDataStaf()
        Call TampilDataStaf()
        Call RapikanGrid()
    End Sub
    Private Sub Form_DataStaf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataStaf()
    End Sub

        Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
            _kondisi = True
        _fs.formShow(False, Form_InputDataStaf, Me)
        End Sub

        Private Sub HapusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem1.Click
            Dim tanya As Object
            tanya = MsgBox("Yakin hapus data?", vbQuestion + vbYesNo, "Informasi") = vbYes = True
            If tanya = True Then
            _db.manipulasiData("Delete from tbl_staf where ID_Staf ='" & GridDataStaf.Item(0, GridDataStaf.CurrentRow.Index).Value & "'", "Hapus")
        End If
        Call RefreshDataStaf()

        End Sub

        Private Sub PilihToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihToolStripMenuItem.Click
        With GridDataStaf
            Form_InputDataStaf.txtIDstaf.Text = .Item(0, .CurrentRow.Index).Value 'Id staf
            Form_InputDataStaf.txtNamastaf.Text = .Item(1, .CurrentRow.Index).Value 'Nama staf
            Form_InputDataStaf.txtAlamat.Text = .Item(2, .CurrentRow.Index).Value 'Alamat
            Form_InputDataStaf.txtKontak.Text = .Item(3, .CurrentRow.Index).Value 'Kontak
            _kondisi = False
            Form_InputDataStaf.ShowDialog()
        End With
        End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        Dim cari As String = txtPencarian.Text.Trim()

        If cari <> "" Then
            Dim query As String = "SELECT * FROM tbl_staf WHERE Nama_Staf LIKE '%" & cari & "%'"

            Call _db.tampilTabel1(GridDataStaf, query)
        Else
            Call RefreshDataStaf()
        End If
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDataToolStripMenuItem.Click
        Call RefreshDataStaf()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        txtPencarian.Clear()
    End Sub
End Class