using Model.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class DataAccess
    {
        SqlConnection _connection;

        public DataAccess()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = Properties.Settings.Default.cadena;
        }

        public SqlConnection getConnection()
        {
            return _connection;
        }
    }
}
