Public Class Form_Penjualan
    Sub TampilDataPenjualan()
        _db.tampilTabel1(GridDataPenjualan, "SELECT * FROM view_jual")
    End Sub
    Sub RapikanGrid()
        With GridDataPenjualan
            On Error Resume Next
            .Columns(0).HeaderText = "ID.Transaksi"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "ID.Jual"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "ID.Barang"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Nama.Barang"
            .Columns(3).Width = 200
            .Columns(4).HeaderText = "Harga Barang"
            .Columns(4).Width = 150
            .Columns(5).HeaderText = "Jml.Jual"
            .Columns(5).Width = 100
            .Columns(6).HeaderText = "Sub.Total"
            .Columns(6).Width = 150

            .Columns(4).HeaderText = "Tgl.Jual"
            .Columns(4).Width = 150
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Format = "dd-MM-yyyy"
            .Columns(5).HeaderText = "ID.Barang"
            .Columns(5).Width = 150

            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Format = "N0"

            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).DefaultCellStyle.Format = "N0"
        End With
    End Sub

    Sub RefreshDataPenjualan()
        Call TampilDataPenjualan()
        Call RapikanGrid()
    End Sub


    Private Sub Form_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataPenjualan()
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        _fs.formShow(False, Form_InputPenjualan, Me)
    End Sub

    Private Sub TambahToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem1.Click
        _fs.formShow(False, Form_InputPenjualan, Me)
    End Sub
End Class