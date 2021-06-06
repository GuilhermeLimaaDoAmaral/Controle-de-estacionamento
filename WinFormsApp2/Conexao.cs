using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsApp2
{
	public class Conexao
	{
        public static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
		{
			Server = "127.0.0.1",
			Database = "banco",
			UserID = "root",
			Password = "12345678",
			SslMode = MySqlSslMode.Required,
		};
		MySqlConnection con = new MySqlConnection(builder.ConnectionString);

	public MySqlConnection conectar()
	{
		if (con.State == System.Data.ConnectionState.Closed)
		{
			con.Open();
		}

		return con;
	}

	public void desconectar()
	{
		if (con.State == System.Data.ConnectionState.Open)
		{
			con.Close();
		}
	}
}
}
