Imports System.Data
Imports System.Data.SqlClient
Public Class Inputbarang
    Dim koneksi = Module1.koneksiSQL
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()


    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInput.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Penting\Database Kulibet Restor\Kulibet_Restor.mdf;Integrated Security=True;Connect Timeout=30"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO tbl_Barang([KodeBarang], [NamaBarang], [Satuan], [HargaJual], [HPP], [Stok]) VALUES('" & kodebarang.Text & "','" & nmbarang.Text & "','" & satuan.Text & "','" & hargajual.Text & "','" & hpp.Text & "','" & stok.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Inputed Succesfull")
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try


    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, koneksiSQL)

        koneksiSQL.Open()

        command.ExecuteNonQuery()

        koneksiSQL.Close()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        'save changes
        DataGridInputBarang.EndEdit()
        MessageBox.Show("Updated Succesfull")

    End Sub

    Private Sub Inputbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kulibet_RestorDataSet.tbl_barang' table. You can move, or remove it, as needed.
        Me.Tbl_barangTableAdapter.Fill(Me.Kulibet_RestorDataSet.tbl_barang)

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' get the index of the selected row
        Dim index As Integer
        index = DataGridInputBarang.CurrentCell.RowIndex

        ' delete the selected row
        DataGridInputBarang.Rows.RemoveAt(index)
        MessageBox.Show("Deleted Succesfull")
    End Sub
End Class