Imports System.Data.SqlClient

Public Class formReport

    Private Sub formReport_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        If MsgBox("Apakah anda yakin ingin keluar dari menu ini?", MsgBoxStyle.OkCancel, "Perhatian!") = MsgBoxResult.Ok Then

            Me.Hide()
            formAdmin.Show()

        ElseIf MsgBoxResult.Cancel Then

        End If

    End Sub

    Sub munculDataGridView()

        koneksi()
        Da = New SqlDataAdapter("SELECT * FROM Income", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Income")
        DataGridView1.DataSource = Ds.Tables("Income")
        DataGridView1.ReadOnly = True

    End Sub

    Sub getComboBox()

        ComboBox1.Items.Add("Januari")
        ComboBox1.Items.Add("Februari")
        ComboBox1.Items.Add("Maret")
        ComboBox1.Items.Add("April")
        ComboBox1.Items.Add("Mei")
        ComboBox1.Items.Add("Juni")
        ComboBox1.Items.Add("Agustus")
        ComboBox1.Items.Add("September")
        ComboBox1.Items.Add("Oktober")
        ComboBox1.Items.Add("November")
        ComboBox1.Items.Add("Desember")

        ComboBox2.Items.Add("Januari")
        ComboBox2.Items.Add("Februari")
        ComboBox2.Items.Add("Maret")
        ComboBox2.Items.Add("April")
        ComboBox2.Items.Add("Mei")
        ComboBox2.Items.Add("Juni")
        ComboBox2.Items.Add("Agustus")
        ComboBox2.Items.Add("September")
        ComboBox2.Items.Add("Oktober")
        ComboBox2.Items.Add("November")
        ComboBox2.Items.Add("Desember")

    End Sub

    Private Sub formReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getComboBox()
        munculDataGridView()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" And ComboBox2.Text = "" Then

            MsgBox("Harap isi semua data", MsgBoxStyle.Exclamation, "Perhatian")

        Else

            Me.Chart1.Series("Income").Points.AddXY("Januari", 100)
            Me.Chart1.Series("Income").Points.AddXY("Februari", 150)
            Me.Chart1.Series("Income").Points.AddXY("Maret", 130)
            Me.Chart1.Series("Income").Points.AddXY("April", 140)
            Me.Chart1.Series("Income").Points.AddXY("Mei", 120)
            Me.Chart1.Series("Income").Points.AddXY("Juni", 110)
            Me.Chart1.Series("Income").Points.AddXY("Juli", 160)
            Me.Chart1.Series("Income").Points.AddXY("Agustus", 200)
            Me.Chart1.Series("Income").Points.AddXY("September", 155)
            Me.Chart1.Series("Income").Points.AddXY("Oktober", 180)
            Me.Chart1.Series("Income").Points.AddXY("November", 146)
            Me.Chart1.Series("Income").Points.AddXY("Desember", 190)

        End If



    End Sub
End Class