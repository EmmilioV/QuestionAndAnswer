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
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;

        public RoundController()
        {}

        public Round GetRound(int roundNumber)
        {
            DataAccess dataAccess = new DataAccess();
            _connection = dataAccess.getConnection();
            _command = new SqlCommand("Select * From Round Where id = @roundNumber", _connection);

            _command.Parameters.AddWithValue("@roundNumber", roundNumber.ToString());

            Round round = null;
            
            try
            {
                _connection.Open();

                _reader = _command.ExecuteReader();
                
                if(_reader.HasRows)
                {
                    while (_reader.Read())
                    {
                        round = new Round(_reader["id"].ToString(),
                                        int.Parse(_reader["difficulty"].ToString()),
                                        int.Parse(_reader["score"].ToString()));
                    }
                }

                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();

                Console.WriteLine("El error fue " + ex);
            }
            return round;
        }
    }
}
