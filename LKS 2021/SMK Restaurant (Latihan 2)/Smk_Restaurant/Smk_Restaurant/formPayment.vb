Imports System.Data.SqlClient

Public Class formPayment

	Private Sub formPayment_Closed(sender As Object, e As EventArgs) Handles Me.Closed

		If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

			Me.Hide()
			formCashier.Show()

		End If

	End Sub

	Private Sub formPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		koneksi()
		Cmd = New SqlCommand("SELECT OrderId FROM OrderDetail$ WHERE Status='Unpaid'")
		Dr = Cmd.ExecuteReader
		Dr.Read()

		For i As Integer = 0 To 10

			ComboBox1.Items.Add(Dr.Item("Status") = "Unpaid")

		Next


	End Sub
End Class