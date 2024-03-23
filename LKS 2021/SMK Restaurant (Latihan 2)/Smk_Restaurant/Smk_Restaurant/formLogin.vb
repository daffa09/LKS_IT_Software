Imports System.Data.SqlClient

Public Class formLogin

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		If TextBox1.Text = "" And TextBox2.Text = "" Then

			MsgBox("Harap isi semua data!", MsgBoxStyle.Exclamation, "Perhatian!")

		Else

			koneksi()
			Cmd = New SqlCommand("SELECT * FROM MsEmployee$ WHERE Email='" & TextBox1.Text & "' AND Password='" & TextBox2.Text & "'", Conn)
			Dr = Cmd.ExecuteReader
			Dr.Read()

			If Dr.HasRows Then

				If Dr.Item("Position") = "admin" Then

					MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
					Me.Hide()
					formAdmin.Show()
					formAdmin.Label2.Text = "Welcome " + "[" & Dr.Item("Name") & "]"
				ElseIf Dr.Item("Position") = "cashier" Then
					MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
					Me.Hide()
					formCashier.Show()
					formCashier.Label2.Text = "Welcome " + "[" & Dr.Item("Name") & "]"

				End If
			Else

				MsgBox("Username atau password yang anda masukan salah", MsgBoxStyle.Exclamation, "Perhatian!")
				TextBox1.Text = ""
				TextBox2.Text = ""
				TextBox1.Focus()

			End If


			TextBox1.Text = ""
			TextBox2.Text = ""
			TextBox1.Focus()
			TextBox2.PasswordChar = "*"


		End If

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		If MsgBox("Anda yakin ingin keluar dari aplikasi?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

			Me.Close()
			Me.Hide()

		End If

	End Sub

	Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextBox1.Focus()
		TextBox2.PasswordChar = "*"
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

		If CheckBox1.Checked = True Then

			TextBox2.PasswordChar = ""

		Else

			TextBox2.PasswordChar = "*"


		End If

	End Sub

	Private Sub formLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed

		If MsgBox("Anda yakin ingin keluar dari aplikasi?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

			Me.Close()
			Me.Hide()

		End If
	End Sub
End Class
