Public Class Form_utama
    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        _fs.formChildClose(Me, "|MENU UTAMA|")
        _fs.formShow(False, Form_Database, Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        statusJam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem.Click
        _fs.formChildClose(Me, "|MENU UTAMA|")
        _fs.formShow(True, Form_DataBarang, Me)
    End Sub

    Private Sub DataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataToolStripMenuItem.Click
        _fs.formChildClose(Me, "|MENU UTAMA|")
        _fs.formShow(True, Form_DataJenis, Me)
    End Sub

    Private Sub DataDistributorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataDistributorToolStripMenuItem.Click
        _fs.formChildClose(Me, "|MENU UTAMA|")
        _fs.formShow(True, Form_DataDistributor, Me)
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPelangganToolStripMenuItem.Click
        _fs.formChildClose(Me, "|MENU UTAMA|")
        _fs.formShow(True, Form_DataPelanggan, Me)
    End Sub

    Private Sub DataStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataStaffToolStripMenuItem.Click
        _fs.formChildClose(Me, "|MENU UTAMA|")
        _fs.formShow(True, Form_DataStaf, Me)
    End Sub

    Private Sub KeluarAplikasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarAplikasiToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        _fs.formChildClose(Me, "Form ")
        _fs.formShow(True, Form_Penjualan, Me)
    End Sub
End Class