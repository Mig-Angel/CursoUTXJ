using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dev.Data
{
    public class DataRepository : IDisposable
    {
        protected IDbConnection conn;

        public DataRepository()
        {
            string strConnection = "Server=localhost;Port=3306;Database=bd_ventas;Uid=root;Pwd=taller_utxj;";
            conn = new MySqlConnection(strConnection);
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
