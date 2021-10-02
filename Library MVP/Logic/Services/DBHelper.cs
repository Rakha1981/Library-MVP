using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_MVP.Logic.Services
{
	static public class DBHelper
	{
		public static SqlCommand command;
		//this mehod to get connection string from sql server
		private static SqlConnection getConnectionstring()
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.DataSource = Properties.Settings.Default.ServerName;
			builder.InitialCatalog = Properties.Settings.Default.DBName;
			builder.IntegratedSecurity = true;
			return new SqlConnection (builder.ConnectionString);
		}
		public static bool excuatData(string spName,Action Methoud)
		{
			using (SqlConnection connection = getConnectionstring())
			{
				try
				{
					command = new SqlCommand(spName, connection);
					command.CommandType = CommandType.StoredProcedure;
					Methoud.Invoke();
					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch(Exception ex)
				{
					connection.Close();
					Console.WriteLine(ex.Message);
					return false;
				}
				finally
				{
					connection.Close();
				}
			}
				return false;
		}
	}
}
