using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_MVP.Logic.Services
{
	static class CategoryService
	{
		public static bool categoryInsert(int id,string name)
		{
			return DBHelper.excuatData("CategoryInsert",()=> categoryParmaterInsert(id,name,DBHelper.command));
		}
		private static void categoryParmaterInsert(int id,string name,SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
		}
		public static bool categoryDelete(int id)
		{
			return DBHelper.excuatData("CategoryDelete", () => categoryParmaterDelete(id, DBHelper.command));
		}
		private static void categoryParmaterDelete(int id, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;

		}
		public static bool categoryUpdate(int id, string name)
		{
			return DBHelper.excuatData("CategoryUpdate", () => categoryParmaterUpdate(id, name, DBHelper.command));
		}
		private static void categoryParmaterUpdate(int id, string name, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
		}
		public static bool categoryDeleteAll()
		{
			return DBHelper.excuatData("CategoryDeleteAll", () => categoryParmaterDeleteAll());
		}
		private static void categoryParmaterDeleteAll()
		{
		}
	}
}
