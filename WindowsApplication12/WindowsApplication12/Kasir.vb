Public Class Kasir
    Private Sub Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kulibet_RestorDataSet.tbl_barang' table. You can move, or remove it, as needed.
        Me.Tbl_barangTableAdapter1.Fill(Me.Kulibet_RestorDataSet.tbl_barang)
        'TODO: This line of code loads data into the 'Kulibet_RestorDataSet1.tbl_barang' table. You can move, or remove it, as needed.
        Me.Tbl_barangTableAdapter.Fill(Me.Kulibet_RestorDataSet1.tbl_barang)

    End Sub
End Class