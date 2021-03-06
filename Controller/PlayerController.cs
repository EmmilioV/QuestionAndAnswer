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
            Player player = new Player(docNumber, "1", name, 0);

            try
            {
                _dataAccess = new DataAccess();
                _connection = _dataAccess.getConnection();

                _connection.Open();

                _command = new SqlCommand("Insert into Player (guid, docNumber, name, roundId, totalScore, win) " +
                    "values (@guid, @docNumber, @name, @roundId, @totalScore, @win)", _connection);

                _command.Parameters.AddWithValue("@guid", player.Guid);
                _command.Parameters.AddWithValue("@docNumber", player.DocNumber);
                _command.Parameters.AddWithValue("@name", player.Name);
                _command.Parameters.AddWithValue("@roundId", player.RoundId);
                _command.Parameters.AddWithValue("@totalScore", player.TotalScore);
                _command.Parameters.AddWithValue("@win", player.Win);


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

        public Player Update(Player player, Round round, bool correctAnswer)
        {
            
            player.RoundId = round.Id;

            if (correctAnswer)
                player.TotalScore += round.Score;
            if (correctAnswer && round.Id.Equals("5"))
                player.Win = true;

            try
            {
                _dataAccess = new DataAccess();
                _connection = _dataAccess.getConnection();

                _connection.Open();

                _command = new SqlCommand("Update Player " +
                    "Set roundId = @roundId, totalScore= @totalScore, win = @win " +
                    "where guid = @guid", _connection);


                _command.Parameters.AddWithValue("@roundId", player.RoundId);
                _command.Parameters.AddWithValue("@totalScore", player.TotalScore);
                _command.Parameters.AddWithValue("@guid", player.Guid);
                _command.Parameters.AddWithValue("@win", player.Win);

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
    }
}
