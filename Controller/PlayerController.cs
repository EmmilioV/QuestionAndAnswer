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
    public class PlayerController
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        DataAccess _dataAccess;

        public Player CreatePlayer(string docNumber, string name)
        {
            Player player = new Player(docNumber, "0", name, 0);

            try
            {
                _dataAccess = new DataAccess();
                _connection = _dataAccess.getConnection();

                _connection.Open();

                _command = new SqlCommand("Insert into Player (guid, docNumber, name, roundId, totalScore) " +
                    "values (@guid, @docNumber, @name, @roundId, @totalScore)", _connection);

                _command.Parameters.AddWithValue("@guid", player.Guid);
                _command.Parameters.AddWithValue("@docNumber", player.DocNumber);
                _command.Parameters.AddWithValue("@name", player.Name);
                _command.Parameters.AddWithValue("@roundId", player.RoundId);
                _command.Parameters.AddWithValue("@totalScore", player.TotalScore);

                _command.ExecuteNonQuery();

                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                Console.WriteLine("El error fue " + ex.Message);
            }

            return player;
        }

        public Player Update(Player player, Round round)
        {
            player.TotalScore += round.Score;
            player.RoundId = round.Id;

            try
            {
                _dataAccess = new DataAccess();
                _connection = _dataAccess.getConnection();

                _connection.Open();

                _command = new SqlCommand("Update Player " +
                    "Set roundId = @roundId, totalScore= @totalScore)" +
                    "where guid = @guid", _connection);


                _command.Parameters.AddWithValue("@roundId", player.RoundId);
                _command.Parameters.AddWithValue("@totalScore", player.TotalScore);
                _command.Parameters.AddWithValue("@guid", player.Guid);


                _command.ExecuteNonQuery();

                _connection.Close();
            }
            catch(Exception ex)
            {
                _connection.Close();
                Console.WriteLine("El error fue " + ex.Message);
            }

            return player;
        }

        public static void EndGame(Player player, int roundNumber)
        {
            player.RoundId = roundNumber.ToString();
            return;
        }
    }
}
