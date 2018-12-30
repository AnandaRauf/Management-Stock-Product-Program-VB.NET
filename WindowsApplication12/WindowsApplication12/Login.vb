Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pass.Text = ""
        user.Text = ""
        user.Select()
    End Sub
    Private Function ValidasiEntry() As Boolean
        'Make sure that all fields have values
        If Me.user.Text.Trim = "" Or
            Me.user.Text.Trim = "" Then
            MsgBox("Please Inserted Username & Password !", MsgBoxStyle.Exclamation, "Insufficient Data")
            Return True
        End If
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call konekdatabase()
        Dim SQLCmd As New SqlCommand
        Dim DR As SqlDataReader
        SQLCmd = New SqlCommand("Select * From tbl_admin where Username='" & user.Text & "' and Password='" & pass.Text & "'", koneksiSQL)

        DR = SQLCmd.ExecuteReader



        If DR.Read Then

            user.Focus()
            pass.Focus()
            MsgBox("Login Succesfull !")
            Inputbarang.Show()

        Else
            MsgBox("Sorry Login Failed ! Wrong Username & Password !")

            user.Clear()

            pass.Clear()

            user.Focus()





        End If
    End Sub






    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Are You Sure You Want To Cancel Login ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Hide()

            MenuUtama.Show()
        Else
            MsgBox("Please Inserted Username And Passoword !")


        End If
    End Sub

End Class