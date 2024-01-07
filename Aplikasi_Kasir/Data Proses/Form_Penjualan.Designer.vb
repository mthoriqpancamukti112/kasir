<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Penjualan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtPencarian = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GridDataPenjualan = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilihToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TambahToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilihToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridDataPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 400)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1260, 241)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripButton1, Me.txtPencarian, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 22)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1254, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(331, 28)
        Me.ToolStripButton1.Text = "Masukkan Untuk Pencarian Data"
        '
        'txtPencarian
        '
        Me.txtPencarian.Name = "txtPencarian"
        Me.txtPencarian.Size = New System.Drawing.Size(400, 31)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(78, 28)
        Me.ToolStripButton2.Text = "Batal"
        '
        'GridDataPenjualan
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridDataPenjualan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridDataPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDataPenjualan.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDataPenjualan.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridDataPenjualan.Location = New System.Drawing.Point(13, 25)
        Me.GridDataPenjualan.Name = "GridDataPenjualan"
        Me.GridDataPenjualan.RowTemplate.Height = 28
        Me.GridDataPenjualan.Size = New System.Drawing.Size(1251, 292)
        Me.GridDataPenjualan.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem, Me.PilihToolStripMenuItem, Me.RefreshDataToolStripMenuItem, Me.HapusToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(159, 124)
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Image = Global.Aplikasi_Kasir.My.Resources.Resources.tambah
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.TambahToolStripMenuItem.Text = "Tambah"
        '
        'PilihToolStripMenuItem
        '
        Me.PilihToolStripMenuItem.Image = Global.Aplikasi_Kasir.My.Resources.Resources.icon_pilih
        Me.PilihToolStripMenuItem.Name = "PilihToolStripMenuItem"
        Me.PilihToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.PilihToolStripMenuItem.Text = "Pilih Data"
        '
        'RefreshDataToolStripMenuItem
        '
        Me.RefreshDataToolStripMenuItem.Image = Global.Aplikasi_Kasir.My.Resources.Resources.cari
        Me.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem"
        Me.RefreshDataToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.RefreshDataToolStripMenuItem.Text = "Cari"
        '
        'HapusToolStripMenuItem1
        '
        Me.HapusToolStripMenuItem1.Image = Global.Aplikasi_Kasir.My.Resources.Resources.images
        Me.HapusToolStripMenuItem1.Name = "HapusToolStripMenuItem1"
        Me.HapusToolStripMenuItem1.Size = New System.Drawing.Size(158, 30)
        Me.HapusToolStripMenuItem1.Text = "Hapus"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridDataPenjualan)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1335, 362)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem1, Me.PilihToolStripMenuItem1, Me.HapusToolStripMenuItem, Me.BatalToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(153, 146)
        '
        'TambahToolStripMenuItem1
        '
        Me.TambahToolStripMenuItem1.Name = "TambahToolStripMenuItem1"
        Me.TambahToolStripMenuItem1.Size = New System.Drawing.Size(152, 30)
        Me.TambahToolStripMenuItem1.Text = "Tambah"
        '
        'PilihToolStripMenuItem1
        '
        Me.PilihToolStripMenuItem1.Name = "PilihToolStripMenuItem1"
        Me.PilihToolStripMenuItem1.Size = New System.Drawing.Size(152, 30)
        Me.PilihToolStripMenuItem1.Text = "Pilih"
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'BatalToolStripMenuItem
        '
        Me.BatalToolStripMenuItem.Name = "BatalToolStripMenuItem"
        Me.BatalToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.BatalToolStripMenuItem.Text = "Batal"
        '
        'Form_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 648)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Penjualan"
        Me.Text = "Form_Penjualan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridDataPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPencarian As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridDataPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PilihToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TambahToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PilihToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BatalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
