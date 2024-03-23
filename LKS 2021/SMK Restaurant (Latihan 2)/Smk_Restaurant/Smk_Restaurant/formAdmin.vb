Public Class formAdmin

	Private Sub formAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
		If MsgBox("Anda yakin ingin keluar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

			Me.Hide()
			formLogin.Show()

		End If
	End Sub

	Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click

		formOrder.Show()
		Me.Hide()

	End Sub

	Private Sub btn_manageMenu_Click(sender As Object, e As EventArgs) Handles btn_manageMenu.Click
		formManageMenu.Show()
		Me.Hide()
	End Sub

	Private Sub btn_manageMember_Click(sender As Object, e As EventArgs) Handles btn_manageMember.Click
		formManageMember.Show()
		Me.Hide()
	End Sub

	Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
		formReport.Show()
		Me.Hide()
	End Sub

	Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

		If MsgBox("Anda yakin ingin keluar?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

			Me.Hide()
			formLogin.Show()

		End If

	End Sub

	Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class