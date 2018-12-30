Public Class MenuUtama
    Private Sub CompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/mrvd02")

    End Sub

    Private Sub DeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/anandarauf08")
    End Sub

    Private Sub VersionSoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionSoftwareToolStripMenuItem.Click
        MessageBox.Show("Version 1.0.0")
        MessageBox.Show("Powered  By PT.Tech Media Development")
        MessageBox.Show("Developed Date: 08 September 2018")
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Login.Show()
    End Sub

    Private Sub CashierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierToolStripMenuItem.Click
        Kasir.Show()
        MessageBox.Show("Welcome Cashier")

    End Sub
End Class
