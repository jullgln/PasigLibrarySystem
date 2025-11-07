using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;   


namespace PasigLibrarySystem.DATABASES
{
    public class DBConnect
    {
        public static readonly string connectionString = "server=127.0.0.1;user=root;password=;database=pasiglibrary_db;";
        private MySqlConnection connectdb;

        public DBConnect()
        {
            connectdb = new MySqlConnection(connectionString);
        }
        public void Open()
        {
            connectdb.Open();
        }
        public void Close() 
        {
            connectdb.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connectdb;
        }
    }
    public static class IDGenerator
    {
        public static string GenerateUserID()
        {
            const string prefix = "UR";
            Random random = new Random();

            int code = random.Next(0, 1000); // generates from 0–999
            string formattedCode = code.ToString("D3"); // ensures 3 digits (e.g., 007, 123)

            return prefix + formattedCode;
        }
    }
}
