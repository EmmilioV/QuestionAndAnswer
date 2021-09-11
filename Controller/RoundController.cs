using Model.Data;
using Model.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RoundController
    {
        SqlConnection _connetion;
        SqlCommand _command;
        SqlDataReader _reader;

        public RoundController()
        {}

        public List<string> GetRound(int roundNumber)
        {
            DataAccess dataAccess = new DataAccess();
            _command = new SqlCommand("Select * From Round Where id = @roundNumber", dataAccess.getConexion());

            _command.Parameters.AddWithValue("@roundNumber", roundNumber);

            List<string> roundInfo = new List<string>();
            
            try
            {
                dataAccess.Open();

                _reader = _command.ExecuteReader();
                
                if(_reader.HasRows)
                {
                    roundInfo[0] = _reader["id"].ToString();
                    roundInfo[1] = _reader["difficulty"].ToString();
                    roundInfo[2] = _reader["score"].ToString();

                }

                dataAccess.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error fue " + ex);
            }
            return roundInfo;
        }
    }
}
