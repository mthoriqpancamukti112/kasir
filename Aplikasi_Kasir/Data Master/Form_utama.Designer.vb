<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDistributorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanRugiLabaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel13 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1009, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.PenggunaToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.DataPenggunaToolStripMenuItem, Me.KeluarAplikasiToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(101, 32)
        Me.SettingsToolStripMenuItem.Text = "Setting"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Image = Global.Aplikasi_Kasir.My.Resources.Resources.database2
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.Image = Global.Aplikasi_Kasir.My.Resources.Resources.user
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DataPenggunaToolStripMenuItem
        '
        Me.DataPenggunaToolStripMenuItem.Name = "DataPenggunaToolStripMenuItem"
        Me.DataPenggunaToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.DataPenggunaToolStripMenuItem.Text = "Data Pengguna"
        '
        'KeluarAplikasiToolStripMenuItem
        '
        Me.KeluarAplikasiToolStripMenuItem.Name = "KeluarAplikasiToolStripMenuItem"
        Me.KeluarAplikasiToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.KeluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.DataBarangToolStripMenuItem, Me.DataDistributorToolStripMenuItem, Me.DataPelangganToolStripMenuItem, Me.DataStaffToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(158, 32)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(272, 32)
        Me.DataToolStripMenuItem.Text = "Data Jenis"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(272, 32)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataDistributorToolStripMenuItem
        '
        Me.DataDistributorToolStripMenuItem.Name = "DataDistributorToolStripMenuItem"
        Me.DataDistributorToolStripMenuItem.Size = New System.Drawing.Size(272, 32)
        Me.DataDistributorToolStripMenuItem.Text = "Data Distributor"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(272, 32)
        Me.DataPelangganToolStripMenuItem.Text = "Data Pelanggan"
        '
        'DataStaffToolStripMenuItem
        '
        Me.DataStaffToolStripMenuItem.Name = "DataStaffToolStripMenuItem"
        Me.DataStaffToolStripMenuItem.Size = New System.Drawing.Size(272, 32)
        Me.DataStaffToolStripMenuItem.Text = "Data Staff"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(133, 32)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(206, 32)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(206, 32)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem, Me.LaporanToolStripMenuItem1, Me.LaporanRugiLabaToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(116, 32)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(303, 32)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(303, 32)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'LaporanToolStripMenuItem1
        '
        Me.LaporanToolStripMenuItem1.Name = "LaporanToolStripMenuItem1"
        Me.LaporanToolStripMenuItem1.Size = New System.Drawing.Size(303, 32)
        Me.LaporanToolStripMenuItem1.Text = "Laporan Barang"
        '
        'LaporanRugiLabaToolStripMenuItem
        '
        Me.LaporanRugiLabaToolStripMenuItem.Name = "LaporanRugiLabaToolStripMenuItem"
        Me.LaporanRugiLabaToolStripMenuItem.Size = New System.Drawing.Size(303, 32)
        Me.LaporanRugiLabaToolStripMenuItem.Text = "Laporan Rugi-Laba"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 36)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1009, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.StatusDB, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel11, Me.statusJam, Me.ToolStripStatusLabel13})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 605)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1009, 33)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = Global.Aplikasi_Kasir.My.Resources.Resources.database1
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(139, 28)
        Me.ToolStripStatusLabel1.Text = "Database : "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(20, 28)
        Me.ToolStripStatusLabel2.Text = "["
        '
        'StatusDB
        '
        Me.StatusDB.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusDB.Name = "StatusDB"
        Me.StatusDB.Size = New System.Drawing.Size(22, 28)
        Me.StatusDB.Text = ".."
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(20, 28)
        Me.ToolStripStatusLabel4.Text = "]"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Image = Global.Aplikasi_Kasir.My.Resources.Resources.user
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(76, 28)
        Me.ToolStripStatusLabel5.Text = "User"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(20, 28)
        Me.ToolStripStatusLabel6.Text = "["
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(27, 28)
        Me.ToolStripStatusLabel7.Text = "..."
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(20, 28)
        Me.ToolStripStatusLabel8.Text = "]"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(485, 28)
        Me.ToolStripStatusLabel9.Spring = True
        Me.ToolStripStatusLabel9.Text = "App Kasir"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel10.Image = Global.Aplikasi_Kasir.My.Resources.Resources.time
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(101, 28)
        Me.ToolStripStatusLabel10.Text = "Waktu:"
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        Me.ToolStripStatusLabel11.Size = New System.Drawing.Size(20, 28)
        Me.ToolStripStatusLabel11.Text = "["
        '
        'statusJam
        '
        Me.statusJam.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusJam.Name = "statusJam"
        Me.statusJam.Size = New System.Drawing.Size(27, 28)
        Me.statusJam.Text = "..."
        '
        'ToolStripStatusLabel13
        '
        Me.ToolStripStatusLabel13.Name = "ToolStripStatusLabel13"
        Me.ToolStripStatusLabel13.Size = New System.Drawing.Size(17, 28)
        Me.ToolStripStatusLabel13.Text = "]"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 638)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_utama"
        Me.Text = "|MENU UTAMA|"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataDistributorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusDB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel13 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanRugiLabaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
