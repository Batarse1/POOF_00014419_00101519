using System;
using System.Data;
using Npgsql;

namespace POOF_00014419_00101519.Controlers
{
    public static class Connection
    {
        public interface IProxy
        {
            DataTable IExecuteQuery(string s);
            void IExecuteNonQuery(string s);
        }

        public class proxyA : IProxy
        {
            public DataTable IExecuteQuery(string s)
            {
                return ConnectionDB.ExecuteQuery(s);
            }

            public void IExecuteNonQuery(string s)
            {
                ConnectionDB.ExecuteNonQuery(s);
            }
        }

        private static class ConnectionDB
        {
            private static string host = "ec2-34-202-88-122.compute-1.amazonaws.com",
                dataBase = "da7b75f093ijdl",
                userID = "xosbiiqimcngyu",
                Password = "fd2f1ccce5291b2804ee18b34d92eccd4522b964d71563f2ca868c14ee00dbe8";


            private static string sConnection =
                $"Server={host};Port=5432;User Id={userID};Password={Password};Database={dataBase};" +
                "sslmode=Require;Trust Server Certificate=true ";


            public static DataTable ExecuteQuery(string query)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConnection);
                DataSet ds = new DataSet();

                connection.Open();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                da.Fill(ds);

                connection.Close();

                return ds.Tables[0];
            }

            public static void ExecuteNonQuery(string act)
            {
                Console.WriteLine(sConnection);
                NpgsqlConnection connection = new NpgsqlConnection(sConnection);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand(act, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}