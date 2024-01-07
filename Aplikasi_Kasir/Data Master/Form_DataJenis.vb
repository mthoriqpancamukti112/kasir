
Public Class Form_DataJenis

    Sub TampilDataJenis()
        _db.tampilTabel1(GridDataJenis, "SELECT * FROM TBL_JENIS")
    End Sub
    Sub RapikanGrid()
        GridDataJenis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        With GridDataJenis
            .Columns(0).HeaderText = "ID Jenis"
            .Columns(1).HeaderText = "Jenis Barang"
            .Columns(2).HeaderText = "Keterangan"
        End With
    End Sub


    Sub RefreshDataJenis()
        Call TampilDataJenis()
        Call RapikanGrid()
    End Sub

    Private Sub Form_DataJenis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call RefreshDataJenis()
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        _kondisi = True
        _fs.formShow(False, Form_InputDataJenis, Me)
    End Sub

    Private Sub HapusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem1.Click
        Dim tanya As Object
        tanya = MsgBox("Yakin hapus data?", vbQuestion + vbYesNo, "Informasi") = vbYes = True
        If tanya = True Then
            _db.manipulasiData("Delete from tbl_jenis where ID_Jenis ='" & GridDataJenis.Item(0, GridDataJenis.CurrentRow.Index).Value & "'", "Hapus")
        End If
        Call RefreshDataJenis()
    End Sub


    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        Dim cari As String = txtPencarian.Text.Trim()

        If cari <> "" Then
            Dim query As String = "SELECT * FROM tbl_jenis WHERE Jenis LIKE '%" & cari & "%'"

            Call _db.tampilTabel1(GridDataJenis, query)
        Else
            Call RefreshDataJenis()
        End If
    End Sub

    Private Sub PilihToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihToolStripMenuItem.Click

        With GridDataJenis
            Form_InputDataJenis.txtID.Text = .Item(0, .CurrentRow.Index).Value 'Id jenis
            Form_InputDataJenis.txtJenis.Text = .Item(1, .CurrentRow.Index).Value 'jenis
            Form_InputDataJenis.txtKeterangan.Text = .Item(2, .CurrentRow.Index).Value 'Keterangan
            _kondisi = False
            Form_InputDataJenis.ShowDialog()
        End With

    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDataToolStripMenuItem.Click
        Call RefreshDataJenis()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        txtPencarian.Clear()
    End Sub
End Class

