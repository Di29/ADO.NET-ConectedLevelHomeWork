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
        static SqlConnection sqlConnection;
        static void Main(string[] args)
        {
            
            using (sqlConnection = new SqlConnection())
            {
                string connectionString = ConfigurationManager
                    .ConnectionStrings["GroupConnString"].ConnectionString;

                sqlConnection.ConnectionString = connectionString;

                sqlConnection.Open();

                UseSqlCommand("CREATE DATABASE UNIVER");

                UseSqlCommand("USE UNIVER");

                UseSqlCommand("create table gruppa(ID int NOT NULL CONSTRAINT PK_gruppa PRIMARY KEY," +
                    " Name nvarchar(MAX) NOT NULL)");
            }
        }

        private static void UseSqlCommand(string command)
        {
            SqlCommand createDataBaseCommand = new SqlCommand();
            createDataBaseCommand.Connection = sqlConnection;
            createDataBaseCommand.CommandText = (command);
            createDataBaseCommand.ExecuteNonQuery();
        }
    }
}
