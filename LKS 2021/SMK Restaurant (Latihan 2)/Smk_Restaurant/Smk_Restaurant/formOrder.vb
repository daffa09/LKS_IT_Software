Imports System.Data.SqlClient

Public Class formOrder

	Sub kondisiAwal()

		TextBox1.Enabled = False
		TextBox2.Enabled = True
		TextBox1.Text = ""
		TextBox2.Text = ""


		Label10.Visible = False
		Label11.Visible = False
		Label12.Visible = False
		Label13.Visible = False
		Label14.Visible = False



		PictureBox1.ImageLocation = ""

		btn_delete.Enabled = True
		btn_close.Text = "Close"



	End Sub

	Sub munculDataGridView()

		koneksi()
		Da = New SqlDataAdapter("SELECT * FROM MsMenu$", Conn)
		Ds = New DataSet
		Ds.Clear()
		Da.Fill(Ds, "MsMenu$")
		DataGridView1.DataSource = Ds.Tables("MsMenu$")
		DataGridView1.ReadOnly = True
		DataGridView1.Columns(3).Visible = False

	End Sub

	Sub repeatDataGridView2()

		For barisanAtas As Integer = 0 To DataGridView2.RowCount - 1
			For barisanBawah = barisanAtas + 1 To DataGridView2.RowCount - 1

				If DataGridView2.Rows(barisanBawah).Cells(0).Value = DataGridView2.Rows(barisanAtas).Cells(0).Value Then

					DataGridView2.Rows(barisanAtas).Cells(1).Value = DataGridView2.Rows(barisanAtas).Cells(1).Value + DataGridView2.Rows(barisanBawah).Cells(1).Value
					DataGridView2.Rows(barisanAtas).Cells(5).Value = DataGridView2.Rows(barisanAtas).Cells(1).Value * DataGridView2.Rows(barisanAtas).Cells(4).Value
					DataGridView2.Rows.RemoveAt(DataGridView2.CurrentCell.RowIndex)


					Exit Sub
				End If

			Next
		Next

	End Sub

	Sub kalkulasi()

		Dim total As Integer
		Dim carbon As Integer
		Dim protein As Integer

		For kalkulasi As Integer = 0 To DataGridView2.RowCount - 1

			total = total + DataGridView2.Rows(kalkulasi).Cells(5).Value
			carbon = carbon + DataGridView2.Rows(kalkulasi).Cells(2).Value * DataGridView2.Rows(kalkulasi).Cells(1).Value
			protein = protein + DataGridView2.Rows(kalkulasi).Cells(3).Value * DataGridView2.Rows(kalkulasi).Cells(1).Value

		Next

		Label7.Text = carbon
		Label8.Text = total
		Label9.Text = protein
	End Sub

	Private Sub formOrder_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

			Me.Hide()
			formAdmin.Show()

		ElseIf MsgBoxResult.Cancel Then

		End If
	End Sub

	Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
		If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

			Me.Hide()
			formAdmin.Show()

		ElseIf MsgBoxResult.Cancel Then

		End If
	End Sub

	Private Sub formOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		kondisiAwal()
		munculDataGridView()

	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				PictureBox1.ImageLocation = DataGridView1.Rows(e.RowIndex).Cells(3).Value
				PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
				Label10.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
				Label11.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
				Label12.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
				Label14.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				TextBox2.Focus()

			End If

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub

	Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

		If TextBox1.Text = "" Or TextBox2.Text = "" Then

			MsgBox("Harap isi semua data", MsgBoxStyle.Exclamation, "Perhatian")

		Else

			With DataGridView2

				DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

				.ColumnCount = 7
				.Columns(0).Name = "Menu"
				.Columns(1).Name = "Qty"
				.Columns(2).Name = "Carbo"
				.Columns(3).Name = "Protein"
				.Columns(4).Name = "Price"
				.Columns(5).Name = "Total"
				.Columns(6).Name = "Id"


				Dim total As String

				total = TextBox2.Text * Label12.Text

				DataGridView2.Rows.Add(TextBox1.Text, TextBox2.Text, Label10.Text, Label11.Text, Label12.Text, total, Label14.Text)
				DataGridView2.ReadOnly = True
				DataGridView2.Columns(6).Visible = False


			End With

			repeatDataGridView2()
			kalkulasi()
			kondisiAwal()

		End If

	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If MsgBox("Anda yakin ingin menghapus menu yang sudah dipesan?", MsgBoxStyle.OkCancel, "Peringatan!") = MsgBoxResult.Ok Then

			DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(0).Index)

		End If


	End Sub

	Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click

		If MsgBox("Apakah anda sudah yakin untuk memesan ini semua?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

			autoNumeric()

			For i As Integer = 0 To DataGridView2.RowCount - 1

				koneksi()
				Cmd = New SqlCommand("INSERT INTO OrderDetail$(OrderId,MenuId,Qty,Status) VALUES('" & Label13.Text & "', '" & DataGridView2.Rows(i).Cells(6).Value & "', '" & DataGridView2.Rows(i).Cells(1).Value & "', 'Unpaid')", Conn)
				Cmd.ExecuteNonQuery()
			Next
			MsgBox("Pesanan telah dibuat, silahkan melakukan pembayaran", MsgBoxStyle.Information, "Informasi")
			kondisiAwal()
			DataGridView2.Rows.Clear()
		ElseIf MsgBoxResult.Cancel Then

		End If

	End Sub

	Sub autoNumeric()

		Dim urutanKode As String
		Dim hitung As Long
		Da = New SqlDataAdapter("SELECT MAX(OrderId) FROM OrderDetail$", Conn)
		Da.Fill(Ds)

		If Ds.Tables(0).Rows.Count = 0 Then
			hitung = Convert.ToDateTime(Date.Now).ToString("yyyyMMdd") + "0001"
		Else
			hitung += 1
			urutanKode = Convert.ToDateTime(Date.Now).ToString("yyyyMMdd") + String.Concat("000", hitung)

			Label13.Text = urutanKode
		End If

	End Sub

End Class