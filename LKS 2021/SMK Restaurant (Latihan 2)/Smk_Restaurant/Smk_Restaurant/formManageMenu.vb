Imports System.Data.SqlClient

Public Class formManageMenu

	Sub kondisiAwal()

		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		TextBox5.Enabled = False
		TextBox6.Enabled = False
		TextBox7.Enabled = False

		PictureBox1.ImageLocation = ""

		btn_photo.Enabled = False
		btn_insert.Enabled = True
		btn_update.Enabled = True
		btn_delete.Enabled = True
		btn_insert.Text = "Insert"
		btn_update.Text = "Update"
		btn_close.Text = "Close"

	End Sub

	Sub munculDataGridView()

		koneksi()
		Da = New SqlDataAdapter("SELECT * FROM MsMenu$", Conn)
		Ds = New DataSet
		Ds.Clear()
		Da.Fill(Ds, "MsMenu$")
		DataGridView1.DataSource = (Ds.Tables("MsMenu$"))
		DataGridView1.ReadOnly = True
		DataGridView1.Columns(3).Visible = False


	End Sub

	Sub autoNumeric()

		Dim urutanKode As String
		Dim hitung As Long
		Cmd = New SqlCommand("SELECT * FROM MsMenu$ WHERE Id IN(SELECT MAX(Id) FROM MsMenu$)", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()

		If Not Dr.HasRows Then

			urutanKode = "01"

		Else

			hitung = Microsoft.VisualBasic.Right(Dr.GetInt32(0), 2) + 1
			urutanKode = Microsoft.VisualBasic.Right("0" & hitung, 1)
			TextBox2.Text = urutanKode
			TextBox3.Focus()

		End If

	End Sub

	Private Sub formManageMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		kondisiAwal()
		munculDataGridView()

	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

		koneksi()
		Cmd = New SqlCommand("SELECT * FROM MsMenu$ WHERE Name LIKE '%" & TextBox1.Text & "&' OR Price LIKE '&" & TextBox1.Text & "%' OR Carbo LIKE '%" & TextBox1.Text & "%' OR Protein LIKE '%" & TextBox1.Text & "%'", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()

		If Dr.HasRows Then

			koneksi()
			Da = New SqlDataAdapter("SELECT * FROM MsMenu$ WHERE Name LIKE '%" & TextBox1.Text & "&' OR Price LIKE '&" & TextBox1.Text & "%' OR Carbo LIKE '%" & TextBox1.Text & "%' OR Protein LIKE '%" & TextBox1.Text & "%'", Conn)
			Ds = New DataSet
			Da.Fill(Ds, "ketemuData")
			DataGridView1.DataSource = Ds.Tables("ketemuData")

		End If

	End Sub

	Private Sub formManageMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed

		If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

			Me.Hide()
			formAdmin.Show()

		End If

	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
				TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
				TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
				TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

				PictureBox1.ImageLocation = TextBox5.Text
				PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

			End If

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub

	Private Sub btn_photo_Click(sender As Object, e As EventArgs) Handles btn_photo.Click

		FilePhoto.Filter = ".jpg |"
		FilePhoto.ShowDialog()
		TextBox5.Text = FilePhoto.FileName
		PictureBox1.ImageLocation = TextBox5.Text
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

	End Sub

	Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

		If TextBox1.Text = "" Then

			MsgBox("Harap data di isi terlebih dahulu", MsgBoxStyle.Exclamation, "Perhatian!")

		Else

			koneksi()
			Da = New SqlDataAdapter("SELECT * FROM MsMenu$ WHERE Name LIKE '%" & TextBox1.Text & "&' OR Price LIKE '&" & TextBox1.Text & "%' OR Carbo LIKE '%" & TextBox1.Text & "%' OR Protein LIKE '%" & TextBox1.Text & "%'", Conn)
			Ds = New DataSet
			Da.Fill(Ds, "ketemuData")
			DataGridView1.DataSource = Ds.Tables("ketemuData")
			TextBox1.Text = ""
		End If

	End Sub

	Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

		If btn_insert.Text = "Insert" Then

			btn_insert.Text = "Save"
			btn_delete.Enabled = False
			btn_update.Enabled = False
			btn_close.Text = "Cancel"
			btn_photo.Enabled = True

			TextBox3.Enabled = True
			TextBox4.Enabled = True
			TextBox6.Enabled = True
			TextBox7.Enabled = True

			autoNumeric()

		Else

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then

				MsgBox("Silahkan isi semua data", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menyimpan menu ini?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

					koneksi()
					Dim simpanData As String = "INSERT INTO MsMenu$ VALUES('" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "')"
					Cmd = New SqlCommand(simpanData, Conn)
					Cmd.ExecuteNonQuery()
					MsgBox("Menu berhasil disimpan", MsgBoxStyle.Information)
					munculDataGridView()
					kondisiAwal()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If

		End If


	End Sub

	Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

		If btn_close.Text = "Close" Then

			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

				Me.Hide()
				formAdmin.Show()

			End If

		Else

			kondisiAwal()
			munculDataGridView()

		End If

	End Sub

	Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

		If btn_update.Text = "Update" Then

			btn_update.Text = "Save"
			btn_delete.Enabled = False
			btn_insert.Enabled = False
			btn_close.Text = "Cancel"
			btn_photo.Enabled = True

			TextBox3.Enabled = True
			TextBox4.Enabled = True
			TextBox6.Enabled = True
			TextBox7.Enabled = True

		Else

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then

				MsgBox("Silahkan isi semua data dengan benar", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menyimpan menu ini?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

					koneksi()
					Dim editData As String = "UPDATE MsMenu$ SET Name='" & TextBox3.Text & "', Price='" & TextBox4.Text & "', Photo='" & TextBox5.Text & "', Carbo='" & TextBox6.Text & "', Protein='" & TextBox7.Text & "' WHERE Id='" & TextBox2.Text & "'"
					Cmd = New SqlCommand(editData, Conn)
					Cmd.ExecuteNonQuery()
					MsgBox("Menu berhasil diupdate", MsgBoxStyle.Information)
					munculDataGridView()
					kondisiAwal()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If

		End If



	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If btn_delete.Text = "Delete" Then

			btn_close.Text = "Cancel"
			btn_insert.Enabled = False
			btn_update.Enabled = False

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then

				MsgBox("Silahkan isi semua data dengan benar", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menghapus menu ini?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

					koneksi()
					Dim hapusData As String = "DELETE FROM MsMenu$ WHERE Id='" & TextBox2.Text & "'"
					Cmd = New SqlCommand(hapusData, Conn)
					Cmd.ExecuteNonQuery()
					MsgBox("Menu berhasil dihapus", MsgBoxStyle.Information)
					munculDataGridView()
					kondisiAwal()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If

			End If

	End Sub
End Class