Public Class Form_ViewPelanggan
    Sub TampilDataPelanggan()
        _db.tampilTabel1(GridDataViewPelanggan, "SELECT ID_Pelanggan, Nama_Pelanggan, Alamat FROM TBL_Pelanggan")
    End Sub
    Sub RapikanGrid()
        With GridDataViewPelanggan
            On Error Resume Next
            .Columns(0).HeaderText = "ID.Pelanggan"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "Nama Pelanggan"
            .Columns(1).Width = 185
            .Columns(2).Width = 200
        End With
    End Sub

    Sub RefreshDataPelanggan()
        Call TampilDataPelanggan()
        Call RapikanGrid()
    End Sub

    Private Sub Form_ViewPelanggan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call RefreshDataPelanggan()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub GridDataPelanggan_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles GridDataViewPelanggan.MouseDoubleClick
        With GridDataViewPelanggan
            Form_InputPenjualan.txtIDPelanggan.Text = .Item(0, .CurrentRow.Index).Value
            Form_InputPenjualan.txtNamaPelanggan.Text = .Item(1, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class