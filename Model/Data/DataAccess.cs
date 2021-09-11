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
        SqlConnection conexion;

        public DataAccess()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = Properties.Settings.Default.Cadena;
        }


        /// <summary>
        /// Abre la base de datos
        /// </summary>
        public void Open()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error fue " + ex);
            }
        }

        /// <summary>
        /// cierra la base de datos 
        /// </summary>

        public void Close()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error fue " + ex);
            }
        }

        /// <summary>
        /// obtiene la conexion con la base de datos 
        /// </summary>
        /// <returns></returns>

        public SqlConnection getConexion()
        {
            return conexion;
        }
    }
}
