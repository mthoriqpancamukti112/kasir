Public Class Form_Database

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If txtIp.Text = "" Or txtUser.Text = "" Or txtPass.Text = "" Or txtDB.Text = "" Or cbPort.Text = "" Then
            MsgBox("Lengkapi settingan anda", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call Koneksidatabase()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class