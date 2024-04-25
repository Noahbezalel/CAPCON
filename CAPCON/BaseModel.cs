using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPCON
{
    public class BaseModel
    {

        public readonly string connectionString;

        public BaseModel()
        {
            this.connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Noah\\source\\database\\CaptureConnectDB.accdb";
        }

        // Method to execute SELECT queries
        public DataTable ExecuteQuery(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    OleDbDataReader dataReader = command.ExecuteReader();
                    dataTable.Load(dataReader);

                    return dataTable;
                }
            }
        }

        // Method to execute INSERT, UPDATE, DELETE queries
        public int ExecuteNonQuery(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
