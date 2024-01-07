Imports MySql.Data.MySqlClient
Public Class Form_InputPenjualan
    Dim StokDapat As Integer
    Dim TanggalMasukTrasanski As String
    Dim Penjualan(10) As String
    Dim ada As Boolean
    Dim Jml As Integer = 1

    Sub SimpanDataSementara()
        Dim m As Integer
        Penjualan(0) = txtIDTransaksi.Text
        Penjualan(1) = txtIDJual.Text
        Penjualan(2) = txtIDPelanggan.Text
        Penjualan(3) = txtNamaPelanggan.Text
        Penjualan(4) = TanggalMasukTrasanski
        Penjualan(5) = txtBarcode.Text
        Penjualan(6) = txtNamaBarang.Text
        Penjualan(7) = Jml
        Penjualan(8) = txtHargaJual.Text
        Penjualan(9) = CDbl(Jml) * CDbl(txtHargaJual.Text)
        '========= grid ============
        DGSimpanPenjualan.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGSimpanPenjualan.Columns(7).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGSimpanPenjualan.RowCount = DGSimpanPenjualan.RowCount + 1
        '===========================
        For m = 0 To 9
            DGSimpanPenjualan(m, DGSimpanPenjualan.RowCount - 2).Value = Penjualan(m)
        Next
        DGSimpanPenjualan.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        DGSimpanPenjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        '=========================='
    End Sub
    Sub CariIsiGrid2()
        Dim Xloop1 As Integer
        Dim XPola As String
        Dim XBuka As String
        Dim XBetul As Boolean
        XPola = txtBarcode.Text + "*"
        XBetul = False

        With Me
            For Xloop1 = 0 To DGSimpanPenjualan.RowCount - 1
                XBuka = DGSimpanPenjualan.Rows(Xloop1 - 0).Cells(5).Value
                XBetul = UCase(XBuka) Like UCase(XPola)
                If XBetul = True Then
                    DGSimpanPenjualan.CurrentCell = DGSimpanPenjualan.Item(5, Xloop1 - 0)
                    If XBuka = txtBarcode.Text Then
                        ada = True
                        .DGSimpanPenjualan.Item(7, .DGSimpanPenjualan.CurrentRow.Index).Value += 1
                        .DGSimpanPenjualan.Item(9, .DGSimpanPenjualan.CurrentRow.Index).Value =
                        CDbl(.DGSimpanPenjualan.Item(7, .DGSimpanPenjualan.CurrentRow.Index).Value) *
                        CInt(.DGSimpanPenjualan.Item(8, .DGSimpanPenjualan.CurrentRow.Index).Value)
                        '========================================

                    End If
                    Exit Sub
                Else
                    DGSimpanPenjualan.CurrentCell = DGSimpanPenjualan.Item(5, Xloop1 - 0)
                    ada = False
                End If
            Next
        End With
    End Sub
    Sub IDTransaksi()
        Dim Tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hhmmss")
        Dim ID As String = "IDTrans -" & Tgl & Jam
        txtIDTransaksi.Text = ID

    End Sub
    Sub IDJual()
        Dim Tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hhmmss")
        Dim ID As String = "IDJ -" & Tgl & Jam
        txtIDJual.Text = ID
    End Sub
    Sub TanggalTransaksi()
        TanggalMasukTrasanski = Format(Now, "dd-MM-yyyy")
    End Sub
    Private Sub SimpanPenjualan()
        Dim IDJual, IDPelanggan, NamaPelanggan, TglTransaksi As String
        IDJual = txtIDJual.Text
        IDPelanggan = txtIDPelanggan.Text
        NamaPelanggan = txtNamaPelanggan.Text
        TglTransaksi = Format(Now, "yyyy-MM-dd")
        _db.manipulasiData("INSERT IGNORE INTO TBL_PENJUALAN VALUES ('" & IDJual & "','" & IDPelanggan & "','" & NamaPelanggan & "','" & TglTransaksi & "')", "Simpan")
    End Sub
    Private Sub SimpanPenjualanDetail()
        Dim IDTransaksi, IDJual, IDPelanggan, NamaPelanggan, IDBarang, NamaBarang As String
        Dim Harga, SubTotal As Double
        Dim Qty, JmlTransaksi As Integer

        'untuk tbl jual detail'
        With DGSimpanPenjualan
            For i As Integer = 0 To .Rows.Count - 2
                IDTransaksi = .Item(0, i).Value ' ID transaksi
                IDJual = .Item(1, i).Value ' ID Jual
                IDPelanggan = .Item(2, i).Value ' ID pelanggan
                NamaPelanggan = .Item(3, i).Value ' nama pelanggan
                IDBarang = .Item(5, i).Value ' ID barang
                NamaBarang = .Item(6, i).Value ' barang
                Qty = .Item(7, i).Value ' qty
                Harga = .Item(8, i).Value ' harga
                SubTotal = .Item(9, i).Value ' sub total
                JmlTransaksi = 1
                '============================================================================================================='
                _db.manipulasiData("INSERT IGNORE INTO TBL_DETAIL_PENJUALAN VALUES ('" & IDTransaksi & "','" & IDJual & "','" & IDBarang & "','" & NamaBarang & "','" & Harga & "','" & Qty & "','" & SubTotal & "')", "Simpan")
            Next i

            ''DGSimpan.Rows.Clear()
            'DGSimpan.Rows.Add("alfath.NET")
        End With

    End Sub

    Private Sub Form_InputPenjualan_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then
            If txtIDTransaksi.Text = "" Or txtIDJual.Text = "" Or txtIDPelanggan.Text = "" Or txtNamaPelanggan.Text = "" Or txtNamaBarang.Text = "" Or txtHargaJual.Text = "" Then
                MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Call SimpanPenjualan()
                Call SimpanPenjualanDetail()
                DGSimpanPenjualan.Rows.Clear()
                Call Form_Penjualan.RefreshDataPenjualan()
            End If
        End If
    End Sub

    Private Sub Form_InputPenjualan_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call IDTransaksi()
        Call IDJual()
        Call TanggalTransaksi()
        Me.KeyPreview = True
    End Sub

    Private Sub txtBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.Click

    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        ''Try
        If e.KeyChar = Chr(13) Then
            DGSimpanPenjualan.AllowUserToAddRows = True
            With _db
                .Con.Close() : .Con.Open()
                .Cmd = New MySqlCommand("SELECT ID_BARANG, NAMA_BARANG, HARGA_JUAL, STOK FROM TBL_BARANG WHERE ID_BARANG ='" & txtBarcode.Text & "'", .Con)
                .Rdr = .Cmd.ExecuteReader
                .Rdr.Read()
                If .Rdr.HasRows = True Then
                    txtBarcode.Text = .Rdr.GetString(0)
                    txtNamaBarang.Text = .Rdr.GetString(1)
                    txtHargaJual.Text = .Rdr.GetDouble(2)
                    StokDapat = .Rdr.GetInt32(3)
                    ''=================================''

                    'If Not Val(StokDapat) < Val(Qty) Then
                    Call CariIsiGrid2()
                    If ada = True Then
                    Else
                        Call SimpanDataSementara()
                        Call IDTransaksi()
                    End If
                    'End If
                End If
                .Rdr.Close()
            End With
            txtBarcode.Clear()
            txtBarcode.Focus()
            Call TanggalTransaksi()
            _fs.totalBiayaRecord1(DGSimpanPenjualan, txt1, 9)
        End If
        ''Catch ex As Exception
        ''MsgBox(ex.Message)
        ''End Try
    End Sub

    Private Sub DGSimpanPenjualan_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGSimpanPenjualan.MouseClick
        With DGSimpanPenjualan
            .Item(9, .CurrentRow.Index).Value = CDbl(.Item(7, .CurrentRow.Index).Value) * CDbl(.Item(8, .CurrentRow.Index).Value)
            txtSubTotal.Text = CDbl(.Item(9, .CurrentRow.Index).Value)
            _fs.totalBiayaRecord1(DGSimpanPenjualan, txt1, 9)
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
    End Sub

    Private Sub btnShowPelanggan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPelanggan.Click
        _fs.formShow(False, Form_ViewPelanggan, Me)
    End Sub

    Private Sub Hapusitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapusitem.Click
        On Error Resume Next
        DGSimpanPenjualan.Rows.RemoveAt(DGSimpanPenjualan.CurrentRow.Index)
    End Sub

    Private Sub HapusSemua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusSemua.Click
        DGSimpanPenjualan.Rows.Clear()
    End Sub
End Class