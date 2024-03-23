Imports System.Data.Sql
Imports System.Data.SqlClient


Module MdlKoneksi


	Public Conn As SqlConnection
	Public Da As SqlDataAdapter
	Public Ds As DataSet
	Public Dr As SqlDataReader
	Public Cmd As SqlCommand



	Sub koneksi()

		Conn = New SqlConnection("data source=FANTHOM\FANTHOM;initial catalog=SMK_Restaurant2; integrated security=true")
		If Conn.State = ConnectionState.Closed Then Conn.Open()

	End Sub





End Module
