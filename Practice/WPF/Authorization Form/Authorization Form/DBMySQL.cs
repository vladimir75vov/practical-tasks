using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace Authorization_Form
{
    class DBMySQL
    {
        string host = "127.0.0.1";
        int port = 3306;
        string dataBase = "mydb";
        string userName = "root";
        string password = "Vova200375";

        public MySqlConnection getDBConnection()
        {
            String connectionString = "Server=" + this.host + ";Database=" + this.dataBase + ";port=" + this.port + ";User Id=" + this.userName + ";password=" + this.password;

            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }
        public MySqlConnection getDBConnection(string host, int port, string dataBase, string userName, string password)
        {
            this.host = host;
            this.port = port;
            this.dataBase = dataBase;
            this.userName = userName;
            this.password = password;

            return getDBConnection();
        }
        public MySqlCommand getDBCommand(string sql)
        {
            return new MySqlCommand(sql, getDBConnection());
        }
        public string getDBLotData(MySqlCommand mySqlCommand)
        {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            DataSet dataTable = new DataSet();

            mySqlDataAdapter.FillAsync(dataTable);



            return "";
        }
        public string getDBLittleData(MySqlCommand mySqlCommand)
        {
            return mySqlCommand.ExecuteScalar().ToString(); ;
        }
    }
}
