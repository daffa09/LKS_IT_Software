Public Class formCashier

	Private Sub formCashier_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If MsgBox("Anda yakin ingin keluar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

			Me.Hide()
			formLogin.Show()

		End If
	End Sub

	Private Sub btn_payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
		formPayment.Show()
		Me.Hide()
	End Sub

	Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
		If MsgBox("Anda yakin ingin keluar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

			Me.Hide()
			formLogin.Show()

		End If
	End Sub

	Private Sub formCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class