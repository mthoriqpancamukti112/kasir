<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DataStaf
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DataStaf))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridDataStaf = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilihToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPencarian = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridDataStaf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridDataStaf)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1393, 354)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GridDataStaf
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridDataStaf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridDataStaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDataStaf.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDataStaf.DefaultCellStyle = DataGridViewCellStyle4
        Me.GridDataStaf.Location = New System.Drawing.Point(6, 25)
        Me.GridDataStaf.Name = "GridDataStaf"
        Me.GridDataStaf.RowTemplate.Height = 28
        Me.GridDataStaf.Size = New System.Drawing.Size(1397, 336)
        Me.GridDataStaf.TabIndex = 0
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
        Me.RefreshDataToolStripMenuItem.Text = "Refresh"
        '
        'HapusToolStripMenuItem1
        '
        Me.HapusToolStripMenuItem1.Image = Global.Aplikasi_Kasir.My.Resources.Resources.images
        Me.HapusToolStripMenuItem1.Name = "HapusToolStripMenuItem1"
        Me.HapusToolStripMenuItem1.Size = New System.Drawing.Size(158, 30)
        Me.HapusToolStripMenuItem1.Text = "Hapus"
        '
        'txtPencarian
        '
        Me.txtPencarian.Name = "txtPencarian"
        Me.txtPencarian.Size = New System.Drawing.Size(400, 31)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripButton1, Me.txtPencarian, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 22)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1383, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(78, 28)
        Me.ToolStripButton2.Text = "Batal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 414)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1389, 216)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Form_DataStaf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form_DataStaf"
        Me.Text = "Form_DataStaf"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridDataStaf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridDataStaf As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PilihToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPencarian As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
