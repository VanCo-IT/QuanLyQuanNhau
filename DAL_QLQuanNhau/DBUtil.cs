using System.Data;
using System.Reflection;
using System.Data.SQLite;

namespace DAL_QLQuanNhau
{
    public class DBUtil
    {
        public static string connectionString =
        $@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\CSDL_QLQuanNhau.db;Version=3;";

        public static SQLiteCommand GetCommand(string sql, List<object> args, CommandType cmdType)
        {
            var conn = new SQLiteConnection(connectionString);
            var cmd = new SQLiteCommand(sql, conn);
            cmd.CommandType = cmdType;
            for (int i = 0; i < args.Count; i++)
            {
                cmd.Parameters.AddWithValue($"@{i}", args[i]);
            }
            return cmd;
        }

        public static void Update(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            SQLiteCommand cmd = GetCommand(sql, args, cmdType);
            cmd.Connection.Open();
            cmd.Transaction = cmd.Connection.BeginTransaction();
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (Exception)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();
                }
                throw;
            }
        }

        public static object ScalarQuery(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            try
            {
                SQLiteCommand cmd = GetCommand(sql, args, cmdType);
                cmd.Connection.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static SQLiteDataReader Query(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            var cmd = GetCommand(sql, args, cmdType);
            Console.WriteLine("SQL: " + sql);
            foreach (var p in args)
            {
                Console.WriteLine("Param: " + p);
            }
            cmd.Connection.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);// nếu sai thì xem cái tên .db mà sửa cái kết nối, than than cái lìn nhé bản thân
        }

        public static T Value<T>(string sql, List<object> args, CommandType cmdType = CommandType.Text) where T : new()
        {
            try
            {
                SQLiteCommand cmd = GetCommand(sql, args, cmdType);
                cmd.Connection.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    T result = new T();
                    Type type = typeof(T);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        PropertyInfo propertyInfo = type.GetProperty(columnName);

                        if (propertyInfo != null && propertyInfo.CanWrite)
                        {
                            object value = reader.IsDBNull(i) ? null : reader.GetValue(i);
                            if (value != null)
                                propertyInfo.SetValue(result, Convert.ChangeType(value, propertyInfo.PropertyType));
                        }
                    }

                    return result;
                }

                return default;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
