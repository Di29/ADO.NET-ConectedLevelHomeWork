using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ConectedLevelHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["GroupConnString"].ConnectionString;

                sqlConnection.ConnectionString = connectionString;

                SqlCommand createDataBaseCommand = new SqlCommand();
                createDataBaseCommand.Connection = sqlConnection;
                createDataBaseCommand.CommandText = ("CREATE DATABASE UNIVER");
                createDataBaseCommand.ExecuteNonQuery();
            }
        }
    }
}
