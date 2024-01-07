Public Class Form_ViewJenis
    Sub TampilDataViewJenis()
        _db.tampilTabel1(GridDataViewJenis, "SELECT * FROM tbl_jenis")
    End Sub
    Sub RapikanGrid()
        With GridDataViewJenis
            On Error Resume Next
            .Columns(0).HeaderText = "ID.Jenis"
            .Columns(0).Width = 150
            .Columns(1).Width = 175
            .Columns(2).Width = 200

        End With
    End Sub

    Sub RefreshDataViewJenis()
        Call TampilDataViewJenis()
        Call RapikanGrid()
    End Sub
    Private Sub GridDataViewJenis_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridDataViewJenis.MouseDoubleClick
        With GridDataViewJenis
            Form_InputDataBarang.txtJenis.Text = .Item(1, .CurrentRow.Index).Value
            Form_InputDataBarang.txtIDJenis.Text = .Item(0, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub

    Private Sub Form_ViewJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataViewJenis()
    End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        _db.cariData1(GridDataViewJenis, "SELECT & FROM tbl_jenis WHERE Jenis LIKE '%" & txtPencarian.Text & "%'")
    End Sub
End Class