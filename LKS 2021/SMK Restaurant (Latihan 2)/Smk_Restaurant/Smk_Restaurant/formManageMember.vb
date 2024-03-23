Imports System.Data.SqlClient

Public Class formManageMember


	Sub kondisiAwal()

		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		TextBox5.Enabled = False

		btn_insert.Enabled = True
		btn_update.Enabled = True
		btn_delete.Enabled = True
		btn_insert.Text = "Insert"
		btn_update.Text = "Update"
		btn_close.Text = "Close"

	End Sub

	Sub munculDataGridView()

		koneksi()
		Da = New SqlDataAdapter("SELECT * FROM MsMember$", Conn)
		Ds = New DataSet
		Ds.Clear()
		Da.Fill(Ds, "MsMember$")
		DataGridView1.DataSource = (Ds.Tables("MsMember$"))
		DataGridView1.ReadOnly = True

	End Sub


	Sub autoNumeric()

		Dim urutanKode As String
		Dim hitung As Long
		Cmd = New SqlCommand("SELECT * FROM MsMember$ WHERE ID IN (SELECT MAX(Id) FROM MsMember$)", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()

		If Not Dr.HasRows Then

			urutanKode = "01"

		Else

			hitung = Microsoft.VisualBasic.Right(Dr.GetInt32(0), 2) + 1
			urutanKode = Microsoft.VisualBasic.Right("0" & hitung, 1)
			TextBox2.Text = urutanKode

		End If

	End Sub



	Private Sub formManageMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		kondisiAwal()
		munculDataGridView()

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

	Private Sub formManageMember_Closed(sender As Object, e As EventArgs) Handles Me.Closed

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

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

		koneksi()
		Cmd = New SqlCommand("SELECT * FROM MsMember$ WHERE	Name='" & TextBox1.Text & "' OR Email='" & TextBox1.Text & "' OR Handphone='" & TextBox1.Text & "'", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()

		If Dr.HasRows Then

			koneksi()
			Da = New SqlDataAdapter("SELECT * FROM MsMember$ WHERE	Name='" & TextBox1.Text & "' OR Email='" & TextBox1.Text & "' OR Handphone='" & TextBox1.Text & "'", Conn)
			Ds = New DataSet
			Da.Fill(Ds, "MsMember$")
			DataGridView1.DataSource = Ds.Tables("MsMember$")

		End If
	End Sub

	Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

		If TextBox1.Text = "" Then

			MsgBox("Harap isi data terlebih dahulu", MsgBoxStyle.Exclamation, "Peringatan!")

		Else

			koneksi()
			Da = New SqlDataAdapter("SELECT * FROM MsMember$ WHERE	Name='" & TextBox1.Text & "' OR Email='" & TextBox1.Text & "' OR Handphone='" & TextBox1.Text & "'", Conn)
			Ds = New DataSet
			Da.Fill(Ds, "MsMember$")
			DataGridView1.DataSource = Ds.Tables("MsMember$")
			TextBox1.Text = ""
		End If

	End Sub

	Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

		If btn_insert.Text = "Insert" Then

			btn_insert.Text = "Save"
			btn_update.Enabled = False
			btn_delete.Enabled = False
			btn_close.Text = "Cancel"

			TextBox3.Enabled = True
			TextBox4.Enabled = True
			TextBox5.Enabled = True


			autoNumeric()

		Else

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menyimpan data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					koneksi()
					Cmd = New SqlCommand("INSERT INTO MsMember$ VALUES('" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & Convert.ToDateTime(Date.Now).ToString("yyyy-MM-dd") & "')", Conn)
					Cmd.ExecuteNonQuery()
					MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If


			End If

		End If




	End Sub

	Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

		If btn_update.Text = "Update" Then

			btn_update.Text = "Save"
			btn_delete.Enabled = False
			btn_insert.Enabled = False
			btn_close.Text = "Cancel"

			TextBox3.Enabled = True
			TextBox4.Enabled = True
			TextBox5.Enabled = True

		Else

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin merubah data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					koneksi()
					Cmd = New SqlCommand("UPDATE MsMember$ SET Name='" & TextBox3.Text & "', Email='" & TextBox4.Text & "', Handphone='" & TextBox5.Text & "', JoinDate='" & Convert.ToDateTime(Date.Now).ToString("yyyy-MM-dd") & "' WHERE Id='" & TextBox2.Text & "'", Conn)
					Cmd.ExecuteNonQuery()
					MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If


		End If

	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If btn_update.Text = "Delete" Then

			btn_update.Enabled = False
			btn_insert.Enabled = False
			btn_close.Text = "Cancel"

		Else

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					koneksi()
					Cmd = New SqlCommand("DELETE FROM MsMember$ WHERE Id='" & TextBox2.Text & "'", Conn)
					Cmd.ExecuteNonQuery()
					MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If

			End If
		End If

	End Sub
End Class